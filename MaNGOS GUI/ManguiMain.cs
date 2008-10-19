using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using MaNGOS_GUI.DataAccess;
using MaNGOS_GUI.MangosConfig;
using MaNGOS_GUI.Resources;

namespace MaNGOS_GUI
{
    public partial class ManguiMain : Form
    {

        private const int SW_NORMAL = 1;
        private const int SW_MINIMIZE = 6;
        private DateTime upTime;
        private int daysUp;
        private double timeCheckPop = 0;
        private int population;
        private int maxPopulation;
        private bool mangosStatus = false;
        private bool realmStatus = false;
        private bool versionUpdated = false;
        private bool consoleTextChanged = false;
        private bool realmTextChanged = false;
        private string mangosVersion = "";
        private StringBuilder consoleText;
        private StringBuilder realmText;

        public static Process mangosProcess;
        public Process realmProcess;

        public ManguiMain()
        {
            InitializeComponent();

            ConfigAccess.getConfigData();

            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            this.Resize += new EventHandler(ManguiMain_Resize);
            trayIcon.DoubleClick += new EventHandler(trayIcon_DoubleClick);

            consoleText = new StringBuilder();
            realmText = new StringBuilder();
            rtbConsoleText.Text = "Mangos not running ...";
            rtbRealmText.Text = "Realm not running ...";
        }

        private void getLogLevel()
        {
            try
            {
                StreamReader reader = new StreamReader(ConfigProperties.mangosAppPath + "mangosd.conf");
                MangosConfigReader conf = new MangosConfigReader(reader);

                string logLevel = conf.getValue("LogLevel");

                if (logLevel == "0")
                    menuMinimumLogLevel.Checked = true;

                if (logLevel == "1")
                    menuBasicErrorLogLevel.Checked = true;

                if (logLevel == "2")
                    menuDetailLogLevel.Checked = true;

                if (logLevel == "3")
                    menuFullDebugLogLevel.Checked = true;
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_ErrorMangosConf);
            }
        }

        void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        void ManguiMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                trayIcon.Visible = true;
                this.Hide();
            }
        }

        public void OnApplicationExit(Object sender, EventArgs e)
        {

            try
            {
                mangosProcess.CancelOutputRead();
                mangosProcess.Kill();
                realmProcess.Kill();
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_ServerShutdownError, hcStringResources.ManguiMain_ServerShutdownErrorCaption, MessageBoxButtons.OK);
            }

        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuEditConfig_Click(object sender, EventArgs e)
        {
            Form showEditConfig = new editConfig();
            showEditConfig.Show();
        }

        private void startMangos()
        {

            try
            {
                if (mangosStatus == false)
                {
                    mangosProcess = new Process();
                    mangosProcess.StartInfo.WorkingDirectory = ConfigProperties.mangosAppPath;
                    mangosProcess.StartInfo.FileName = ConfigProperties.mangosAppPath + ConfigProperties.mangosAppName;
                    mangosProcess.StartInfo.UseShellExecute = false;
                    mangosProcess.StartInfo.RedirectStandardInput = true;
                    mangosProcess.StartInfo.RedirectStandardOutput = true;
                    mangosProcess.StartInfo.CreateNoWindow = true;
                    mangosProcess.OutputDataReceived += new DataReceivedEventHandler(mangosProcess_OutputDataReceived);
                    mangosProcess.Start();
                    mangosProcess.BeginOutputReadLine();

                    cpuTimer.Enabled = true;
                    mangosStatus = true;
                    getLogLevel();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosStartError, hcStringResources.ManguiMain_MangosStartErrorCaption, MessageBoxButtons.OK);
            }

        }

        void mangosProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                if (consoleText.Length >= 12000)
                {
                    consoleText.Remove(0, consoleText.Length);
                }

                if (e.Data.StartsWith("MaNGOS/"))
                {
                    mangosVersion = e.Data;
                    versionUpdated = true;
                }

                if (!e.Data.StartsWith("="))
                {
                    consoleText.AppendLine(e.Data);
                    consoleTextChanged = true;
                }
            }
        }

        private void writeConsoleOutput()
        {
            rtbConsoleText.Text = consoleText.ToString();
            consoleTextChanged = false;
            rtbConsoleText.Select(rtbConsoleText.Text.Length - 1, 0);
            rtbConsoleText.ScrollToCaret();
        }

        private void startRealm()
        {
            try
            {
                if (realmStatus == false)
                {
                    realmProcess = new Process();
                    realmProcess.StartInfo.WorkingDirectory = ConfigProperties.realmAppPath;
                    realmProcess.StartInfo.FileName = ConfigProperties.realmAppPath + ConfigProperties.realmAppName;
                    realmProcess.StartInfo.UseShellExecute = false;
                    realmProcess.StartInfo.RedirectStandardInput = true;
                    realmProcess.StartInfo.RedirectStandardOutput = true;
                    realmProcess.StartInfo.CreateNoWindow = true;
                    realmProcess.OutputDataReceived += new DataReceivedEventHandler(realmProcess_OutputDataReceived);
                    realmProcess.Start();
                    realmProcess.BeginOutputReadLine();

                    realmStatus = true;
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_RealmRunning);
                }
            }
            catch
            {

                MessageBox.Show(hcStringResources.ManguiMain_RealmStartError, hcStringResources.ManguiMain_RealmStartErrorCaption, MessageBoxButtons.OK);

            }
        }

        void realmProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
            {
                if (realmText.Length >= 12000)
                {
                    realmText.Remove(0, realmText.Length);
                }

                realmText.AppendLine(e.Data);
                realmTextChanged = true;
            }
        }

        private void writeRealmOutput()
        {
            rtbRealmText.Text = realmText.ToString();
            realmTextChanged = false;
            rtbRealmText.Select(rtbRealmText.Text.Length - 1, 0);
            rtbRealmText.ScrollToCaret();
        }

        private void menuStartServers_Click(object sender, EventArgs e)
        {
            startMangos();
            startRealm();
        }

        private void cpuTimer_Tick(object sender, EventArgs e)
        {

            try
            {

                performanceCounter1.InstanceName = mangosProcess.ProcessName;
                toolStripProgressBarCPU.Value = (int)performanceCounter1.NextValue();
                toolStripLabelCPU.Text = "CPU " + toolStripProgressBarCPU.Value + "% :";
                upTime = upTime.AddSeconds(.5);

                if (labelUpTime.Text == "23:59:59")
                {
                    daysUp = daysUp + 1;
                    labelDaysUp.Text = hcStringResources.ManguiMain_Days + daysUp;
                    labelUpTime.Text = hcStringResources.ManguiMain_Hours + upTime.ToString("HH:mm:ss");
                }
                else
                {
                    labelUpTime.Text = hcStringResources.ManguiMain_Hours + upTime.ToString("HH:mm:ss");
                }

                if (versionUpdated)
                {
                    this.Text += hcStringResources.ManguiMain_Version + mangosVersion.Remove(34);
                    versionUpdated = false;
                }

                if (timeCheckPop == 60)
                {
                    timeCheckPop = 0;
                    checkPopulation();
                }
                else
                {
                    timeCheckPop = timeCheckPop + .5;
                }

                if (realmProcess.HasExited)
                {
                    realmText.Remove(0, realmText.Length);
                    rtbRealmText.Text = "Realm not running ...";

                    realmStatus = false;
                    
                    if (menuRealmRestart.Checked == true)
                    {
                        startRealm();
                    }
                }

            }
            catch
            {

                if (mangosProcess.HasExited)
                {
                    mangosProcess = null;

                    toolStripLabelCPU.Text = hcStringResources.ManguiMain_CpuOffline;
                    cpuTimer.Enabled = false;
                    toolStripProgressBarCPU.Value = 0;
                    consoleText.Remove(0, consoleText.Length);
                    rtbConsoleText.Text = "Mangos not running ...";
                    this.Text = "MaNGOS GUI";

                    daysUp = 0;
                    upTime = DateTime.MinValue;

                    mangosStatus = false;

                    if (menuMangosRestart.Checked == true)
                    {
                        startMangos();
                    }
                }
                else
                {
                    return;
                }

            }

        }

        private void checkPopulation()
        {
            ServerData popCheck = new ServerData();

            population = popCheck.checkCurrentPopulation();

            if (population > maxPopulation)
                maxPopulation = population;

            toolStripLabelOnline.Text = hcStringResources.ManguiMain_Online + population.ToString() + " (" + maxPopulation.ToString() + ")";
            timeCheckPop = 0;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showCreateAccount = new createAccount();
                    showCreateAccount.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void buttonBroadcast_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showBroadcastMessage = new broadcastMessage();
                    showBroadcastMessage.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void buttonSetMOTD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showSetMOTD = new setMOTD();
                    showSetMOTD.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuMangosStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosRunning);
                }
                else
                {
                    startMangos();
                    cpuTimer.Enabled = true;
                }
            }
            catch
            {
                startMangos();
                cpuTimer.Enabled = true;
            }
        }

        private void menuMangosStop_Click(object sender, EventArgs e)
        {
            try
            {
                mangosProcess.CancelOutputRead();
                mangosProcess.Kill();
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuRealmStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!realmProcess.HasExited)
                {
                    MessageBox.Show(hcStringResources.ManguiMain_RealmRunning);
                }
                else
                {
                    startRealm();
                }
            }
            catch
            {
                startRealm();
            }
        }

        private void menuRealmStop_Click(object sender, EventArgs e)
        {
            try
            {
                realmProcess.Kill();
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_RealmNotRunning);
            }
        }

        private void menuSetBC_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showSetBC = new setBC();
                    showSetBC.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuSetGM_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showSetGM = new setGM();
                    showSetGM.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showDeleteAccount = new deleteAccount();
                    showDeleteAccount.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void buttonLoadScripts_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    string commandString = "loadscripts";
                    mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    MessageBox.Show(string.Format(hcStringResources.Global_CommandSuccesful, commandString));
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void buttonPlayerLimit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showPlayerLimit = new playerLimit();
                    showPlayerLimit.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showServerShutdown = new serverShutdown();
                    showServerShutdown.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void buttonBans_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showServerBans = new serverBans();
                    showServerBans.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuDeleteCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showDeleteCharacter = new deleteCharacter();
                    showDeleteCharacter.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuKickCharacter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showKickCharacter = new kickCharacter();
                    showKickCharacter.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuSetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showSetPassword = new setPassword();
                    showSetPassword.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    string commandString = "saveall";
                    mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    MessageBox.Show(string.Format(hcStringResources.Global_CommandSuccesful, commandString));
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuMinimumLogLevel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    string commandString = "setloglevel 0";
                    mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    menuMinimumLogLevel.Checked = true;
                    menuBasicErrorLogLevel.Checked = false;
                    menuDetailLogLevel.Checked = false;
                    menuFullDebugLogLevel.Checked = false;

                    MessageBox.Show(string.Format(hcStringResources.Global_CommandSuccesful, commandString));
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuBasicErrorLogLevel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    string commandString = "setloglevel 1";
                    mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    menuMinimumLogLevel.Checked = false;
                    menuBasicErrorLogLevel.Checked = true;
                    menuDetailLogLevel.Checked = false;
                    menuFullDebugLogLevel.Checked = false;

                    MessageBox.Show(string.Format(hcStringResources.Global_CommandSuccesful, commandString));
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuDetailLogLevel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    string commandString = "setloglevel 2";
                    mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    menuMinimumLogLevel.Checked = false;
                    menuBasicErrorLogLevel.Checked = false;
                    menuDetailLogLevel.Checked = true;
                    menuFullDebugLogLevel.Checked = false;

                    MessageBox.Show(string.Format(hcStringResources.Global_CommandSuccesful, commandString));
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuFullDebugLogLevel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    string commandString = "setloglevel 3";
                    mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    menuMinimumLogLevel.Checked = false;
                    menuBasicErrorLogLevel.Checked = false;
                    menuDetailLogLevel.Checked = false;
                    menuFullDebugLogLevel.Checked = true;

                    MessageBox.Show(string.Format(hcStringResources.Global_CommandSuccesful, commandString));
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showSendMessage = new sendMessage();
                    showSendMessage.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuWritePlayerDump_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showWriteDump = new writeDump();
                    showWriteDump.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuLoadPlayerDump_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showLoadDump = new loadDump();
                    showLoadDump.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuTeleport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mangosProcess.HasExited)
                {
                    Form showTeleChar = new teleChar();
                    showTeleChar.Show();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void menuBanList_Click(object sender, EventArgs e)
        {
            Form showListBans = new listBans();
            showListBans.Show();
        }

        private void menuGMList_Click(object sender, EventArgs e)
        {
            Form showGMList = new listGM();
            showGMList.Show();
        }

        private void menuFileLanguageEnglish_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChoosenLanguage = "en";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void menuFileLanguageFrench_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ChoosenLanguage = "fr";
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void consoleTimer_Tick(object sender, EventArgs e)
        {
            if (consoleTextChanged)
                writeConsoleOutput();

            if (realmTextChanged)
                writeRealmOutput();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ServerData sData = new ServerData();

            dataOnlineInfo.DataSource = sData.getOnlineData();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int selection = comboAccountActions.SelectedIndex;

            switch (selection)
            {
                case 0:
                    LoadGMWithData();
                    break;
                case 1:
                    LoadBCWithData();
                    break;
                case 2:
                    LoadPasswordWithData();
                    break;
                case 3:
                    LoadDeleteWithData();
                    break;
                case 4:
                    LoadBanAccountWithData();
                    break;
                case 5:
                    LoadBanCharacterWithData();
                    break;
                case 6:
                    LoadBanIpWithData();
                    break;
                case 7:
                    LoadKickWithData();
                    break;
                case 8:
                    LoadDeleteCharWithData();
                    break;
                case 9:
                    LoadSendMessageWithData();
                    break;
                case 10:
                    LoadWriteDumpWithData();
                    break;
                case 11:
                    LoadTeleportWithData();
                    break;
            }
        }

        private void LoadTeleportWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    teleChar frmShowTeleport = new teleChar();
                    frmShowTeleport.Show();
                    frmShowTeleport.Controls["textCharacterName"].Text =
                        dataOnlineInfo.Rows[row].Cells["Character"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadWriteDumpWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    writeDump frmShowWriteDump = new writeDump();
                    frmShowWriteDump.Show();
                    frmShowWriteDump.Controls["comboboxplayer"].Text =
                        dataOnlineInfo.Rows[row].Cells["Character"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadSendMessageWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    sendMessage frmShowSendMessage = new sendMessage();
                    frmShowSendMessage.Show();
                    frmShowSendMessage.Controls["textCharacterName"].Text =
                        dataOnlineInfo.Rows[row].Cells["Character"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadDeleteCharWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    deleteCharacter frmShowDeleteCharacter = new deleteCharacter();
                    frmShowDeleteCharacter.Show();
                    frmShowDeleteCharacter.Controls["textCharacterName"].Text =
                        dataOnlineInfo.Rows[row].Cells["Character"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadKickWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    kickCharacter frmShowKickCharacter = new kickCharacter();
                    frmShowKickCharacter.Show();
                    frmShowKickCharacter.Controls["textCharacterName"].Text =
                        dataOnlineInfo.Rows[row].Cells["Character"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadBanIpWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    serverBans frmShowBanIp = new serverBans();
                    frmShowBanIp.Show();

                    frmShowBanIp.radioBan.Checked = true;

                    frmShowBanIp.comboBanType.SelectedIndex = 2;

                    frmShowBanIp.Controls["textChosenType"].Text =
                        dataOnlineInfo.Rows[row].Cells["Ip"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadBanCharacterWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    serverBans frmShowBanCharacter = new serverBans();
                    frmShowBanCharacter.Show();

                    frmShowBanCharacter.radioBan.Checked = true;

                    frmShowBanCharacter.comboBanType.SelectedIndex = 1;

                    frmShowBanCharacter.Controls["textChosenType"].Text =
                        dataOnlineInfo.Rows[row].Cells["Character"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadBanAccountWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    serverBans frmShowBanAccount = new serverBans();
                    frmShowBanAccount.Show();

                    frmShowBanAccount.radioBan.Checked = true;

                    frmShowBanAccount.comboBanType.SelectedIndex = 0;

                    frmShowBanAccount.Controls["textChosenType"].Text =
                        dataOnlineInfo.Rows[row].Cells["Account"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadDeleteWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    deleteAccount frmShowDeleteAccount = new deleteAccount();
                    frmShowDeleteAccount.Show();
                    frmShowDeleteAccount.Controls["textAccountName"].Text =
                        dataOnlineInfo.Rows[row].Cells["Account"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadPasswordWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    setPassword frmShowSetPassword = new setPassword();
                    frmShowSetPassword.Show();
                    frmShowSetPassword.Controls["accountComboBox1"].Text =
                        dataOnlineInfo.Rows[row].Cells["Account"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadBCWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    setBC frmShowSetBC = new setBC();
                    frmShowSetBC.Show();
                    frmShowSetBC.Controls["accountComboBox1"].Text =
                        dataOnlineInfo.Rows[row].Cells["Account"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

        private void LoadGMWithData()
        {
            int row = dataOnlineInfo.CurrentRow.Index;
            try
            {
                if (!mangosProcess.HasExited)
                {
                    setGM frmShowSetGM = new setGM();
                    frmShowSetGM.Show();
                    frmShowSetGM.Controls["accountComboBox1"].Text =
                        dataOnlineInfo.Rows[row].Cells["Account"].Value.ToString();
                }
                else
                {
                    MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.ManguiMain_MangosNotRunning);
            }
        }

    }
}