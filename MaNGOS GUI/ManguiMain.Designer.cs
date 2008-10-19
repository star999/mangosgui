namespace MaNGOS_GUI
{
    partial class ManguiMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManguiMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileLanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileLanguageFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServerOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStartServers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMangosServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMangosStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMangosStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMangosRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealmServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealmStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRealmRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuLogLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMinimumLogLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBasicErrorLogLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDetailLogLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFullDebugLogLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccountOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetBC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetGM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCharacterOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKickCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWritePlayerDump = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadPlayerDump = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTeleport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGMList = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.cpuTimer = new System.Windows.Forms.Timer(this.components);
            this.labelMangosUpTime = new System.Windows.Forms.Label();
            this.labelUpTime = new System.Windows.Forms.Label();
            this.labelDaysUp = new System.Windows.Forms.Label();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelCPU = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBarCPU = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabelOnline = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonBroadcast = new System.Windows.Forms.Button();
            this.buttonSetMOTD = new System.Windows.Forms.Button();
            this.buttonBans = new System.Windows.Forms.Button();
            this.buttonLoadScripts = new System.Windows.Forms.Button();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonPlayerLimit = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuAddCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuBroadcast = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuSetMOTD = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuBans = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuLoadScripts = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuPlayerLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.characterOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuDeleteCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuKickCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuSendMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuWritePlayerDump = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuLoadPlayerDump = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuTeleport = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuAccountOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuCreateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuDeleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuSetPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuSetBC = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuSetGM = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuServerOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStartServers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuMangos = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStartMangos = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStopMangos = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuRealm = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStartRealm = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStopRealm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuLists = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuBansList = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuGMList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuEditConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.tbcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tbpMangosOutput = new DevExpress.XtraTab.XtraTabPage();
            this.rtbConsoleText = new System.Windows.Forms.RichTextBox();
            this.tbpRealmOutput = new DevExpress.XtraTab.XtraTabPage();
            this.rtbRealmText = new System.Windows.Forms.RichTextBox();
            this.tbpInfo = new DevExpress.XtraTab.XtraTabPage();
            this.groupAccountActions = new System.Windows.Forms.GroupBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.comboAccountActions = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataOnlineInfo = new System.Windows.Forms.DataGridView();
            this.consoleTimer = new System.Windows.Forms.Timer(this.components);
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.trayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcMain)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.tbpMangosOutput.SuspendLayout();
            this.tbpRealmOutput.SuspendLayout();
            this.tbpInfo.SuspendLayout();
            this.groupAccountActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataOnlineInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuServerOptions,
            this.menuAccountOptions,
            this.menuCharacterOptions,
            this.menuLists});
            resources.ApplyResources(this.menuMain, "menuMain");
            this.menuMain.Name = "menuMain";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditConfig,
            this.menuFileLanguage,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            resources.ApplyResources(this.menuFile, "menuFile");
            // 
            // menuEditConfig
            // 
            this.menuEditConfig.Name = "menuEditConfig";
            resources.ApplyResources(this.menuEditConfig, "menuEditConfig");
            this.menuEditConfig.Click += new System.EventHandler(this.menuEditConfig_Click);
            // 
            // menuFileLanguage
            // 
            this.menuFileLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileLanguageEnglish,
            this.menuFileLanguageFrench});
            this.menuFileLanguage.Name = "menuFileLanguage";
            resources.ApplyResources(this.menuFileLanguage, "menuFileLanguage");
            // 
            // menuFileLanguageEnglish
            // 
            this.menuFileLanguageEnglish.Name = "menuFileLanguageEnglish";
            resources.ApplyResources(this.menuFileLanguageEnglish, "menuFileLanguageEnglish");
            this.menuFileLanguageEnglish.Click += new System.EventHandler(this.menuFileLanguageEnglish_Click);
            // 
            // menuFileLanguageFrench
            // 
            this.menuFileLanguageFrench.Name = "menuFileLanguageFrench";
            resources.ApplyResources(this.menuFileLanguageFrench, "menuFileLanguageFrench");
            this.menuFileLanguageFrench.Click += new System.EventHandler(this.menuFileLanguageFrench_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            resources.ApplyResources(this.menuExit, "menuExit");
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuServerOptions
            // 
            this.menuServerOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStartServers,
            this.toolStripSeparator2,
            this.menuMangosServer,
            this.menuRealmServer,
            this.toolStripSeparator9,
            this.menuLogLevel});
            this.menuServerOptions.Name = "menuServerOptions";
            resources.ApplyResources(this.menuServerOptions, "menuServerOptions");
            // 
            // menuStartServers
            // 
            this.menuStartServers.Name = "menuStartServers";
            resources.ApplyResources(this.menuStartServers, "menuStartServers");
            this.menuStartServers.Click += new System.EventHandler(this.menuStartServers_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // menuMangosServer
            // 
            this.menuMangosServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMangosStart,
            this.menuMangosStop,
            this.toolStripSeparator3,
            this.menuMangosRestart});
            this.menuMangosServer.Name = "menuMangosServer";
            resources.ApplyResources(this.menuMangosServer, "menuMangosServer");
            // 
            // menuMangosStart
            // 
            this.menuMangosStart.Name = "menuMangosStart";
            resources.ApplyResources(this.menuMangosStart, "menuMangosStart");
            this.menuMangosStart.Click += new System.EventHandler(this.menuMangosStart_Click);
            // 
            // menuMangosStop
            // 
            this.menuMangosStop.Name = "menuMangosStop";
            resources.ApplyResources(this.menuMangosStop, "menuMangosStop");
            this.menuMangosStop.Click += new System.EventHandler(this.menuMangosStop_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // menuMangosRestart
            // 
            this.menuMangosRestart.CheckOnClick = true;
            this.menuMangosRestart.Name = "menuMangosRestart";
            resources.ApplyResources(this.menuMangosRestart, "menuMangosRestart");
            // 
            // menuRealmServer
            // 
            this.menuRealmServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRealmStart,
            this.menuRealmStop,
            this.toolStripSeparator4,
            this.menuRealmRestart});
            this.menuRealmServer.Name = "menuRealmServer";
            resources.ApplyResources(this.menuRealmServer, "menuRealmServer");
            // 
            // menuRealmStart
            // 
            this.menuRealmStart.Name = "menuRealmStart";
            resources.ApplyResources(this.menuRealmStart, "menuRealmStart");
            this.menuRealmStart.Click += new System.EventHandler(this.menuRealmStart_Click);
            // 
            // menuRealmStop
            // 
            this.menuRealmStop.Name = "menuRealmStop";
            resources.ApplyResources(this.menuRealmStop, "menuRealmStop");
            this.menuRealmStop.Click += new System.EventHandler(this.menuRealmStop_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // menuRealmRestart
            // 
            this.menuRealmRestart.CheckOnClick = true;
            this.menuRealmRestart.Name = "menuRealmRestart";
            resources.ApplyResources(this.menuRealmRestart, "menuRealmRestart");
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // menuLogLevel
            // 
            this.menuLogLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMinimumLogLevel,
            this.menuBasicErrorLogLevel,
            this.menuDetailLogLevel,
            this.menuFullDebugLogLevel});
            this.menuLogLevel.Name = "menuLogLevel";
            resources.ApplyResources(this.menuLogLevel, "menuLogLevel");
            // 
            // menuMinimumLogLevel
            // 
            this.menuMinimumLogLevel.Name = "menuMinimumLogLevel";
            resources.ApplyResources(this.menuMinimumLogLevel, "menuMinimumLogLevel");
            this.menuMinimumLogLevel.Click += new System.EventHandler(this.menuMinimumLogLevel_Click);
            // 
            // menuBasicErrorLogLevel
            // 
            this.menuBasicErrorLogLevel.Name = "menuBasicErrorLogLevel";
            resources.ApplyResources(this.menuBasicErrorLogLevel, "menuBasicErrorLogLevel");
            this.menuBasicErrorLogLevel.Click += new System.EventHandler(this.menuBasicErrorLogLevel_Click);
            // 
            // menuDetailLogLevel
            // 
            this.menuDetailLogLevel.Name = "menuDetailLogLevel";
            resources.ApplyResources(this.menuDetailLogLevel, "menuDetailLogLevel");
            this.menuDetailLogLevel.Click += new System.EventHandler(this.menuDetailLogLevel_Click);
            // 
            // menuFullDebugLogLevel
            // 
            this.menuFullDebugLogLevel.Name = "menuFullDebugLogLevel";
            resources.ApplyResources(this.menuFullDebugLogLevel, "menuFullDebugLogLevel");
            this.menuFullDebugLogLevel.Click += new System.EventHandler(this.menuFullDebugLogLevel_Click);
            // 
            // menuAccountOptions
            // 
            this.menuAccountOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSetBC,
            this.menuSetGM,
            this.menuSetPassword,
            this.menuDeleteAccount});
            this.menuAccountOptions.Name = "menuAccountOptions";
            resources.ApplyResources(this.menuAccountOptions, "menuAccountOptions");
            // 
            // menuSetBC
            // 
            this.menuSetBC.Name = "menuSetBC";
            resources.ApplyResources(this.menuSetBC, "menuSetBC");
            this.menuSetBC.Click += new System.EventHandler(this.menuSetBC_Click);
            // 
            // menuSetGM
            // 
            this.menuSetGM.Name = "menuSetGM";
            resources.ApplyResources(this.menuSetGM, "menuSetGM");
            this.menuSetGM.Click += new System.EventHandler(this.menuSetGM_Click);
            // 
            // menuSetPassword
            // 
            this.menuSetPassword.Name = "menuSetPassword";
            resources.ApplyResources(this.menuSetPassword, "menuSetPassword");
            this.menuSetPassword.Click += new System.EventHandler(this.menuSetPassword_Click);
            // 
            // menuDeleteAccount
            // 
            this.menuDeleteAccount.Name = "menuDeleteAccount";
            resources.ApplyResources(this.menuDeleteAccount, "menuDeleteAccount");
            this.menuDeleteAccount.Click += new System.EventHandler(this.menuDeleteAccount_Click);
            // 
            // menuCharacterOptions
            // 
            this.menuCharacterOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeleteCharacter,
            this.menuKickCharacter,
            this.menuSendMessage,
            this.menuWritePlayerDump,
            this.menuLoadPlayerDump,
            this.menuTeleport});
            this.menuCharacterOptions.Name = "menuCharacterOptions";
            resources.ApplyResources(this.menuCharacterOptions, "menuCharacterOptions");
            // 
            // menuDeleteCharacter
            // 
            this.menuDeleteCharacter.Name = "menuDeleteCharacter";
            resources.ApplyResources(this.menuDeleteCharacter, "menuDeleteCharacter");
            this.menuDeleteCharacter.Click += new System.EventHandler(this.menuDeleteCharacter_Click);
            // 
            // menuKickCharacter
            // 
            this.menuKickCharacter.Name = "menuKickCharacter";
            resources.ApplyResources(this.menuKickCharacter, "menuKickCharacter");
            this.menuKickCharacter.Click += new System.EventHandler(this.menuKickCharacter_Click);
            // 
            // menuSendMessage
            // 
            this.menuSendMessage.Name = "menuSendMessage";
            resources.ApplyResources(this.menuSendMessage, "menuSendMessage");
            this.menuSendMessage.Click += new System.EventHandler(this.menuSendMessage_Click);
            // 
            // menuWritePlayerDump
            // 
            this.menuWritePlayerDump.Name = "menuWritePlayerDump";
            resources.ApplyResources(this.menuWritePlayerDump, "menuWritePlayerDump");
            this.menuWritePlayerDump.Click += new System.EventHandler(this.menuWritePlayerDump_Click);
            // 
            // menuLoadPlayerDump
            // 
            this.menuLoadPlayerDump.Name = "menuLoadPlayerDump";
            resources.ApplyResources(this.menuLoadPlayerDump, "menuLoadPlayerDump");
            this.menuLoadPlayerDump.Click += new System.EventHandler(this.menuLoadPlayerDump_Click);
            // 
            // menuTeleport
            // 
            this.menuTeleport.Name = "menuTeleport";
            resources.ApplyResources(this.menuTeleport, "menuTeleport");
            this.menuTeleport.Click += new System.EventHandler(this.menuTeleport_Click);
            // 
            // menuLists
            // 
            this.menuLists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanList,
            this.menuGMList});
            this.menuLists.Name = "menuLists";
            resources.ApplyResources(this.menuLists, "menuLists");
            // 
            // menuBanList
            // 
            this.menuBanList.Name = "menuBanList";
            resources.ApplyResources(this.menuBanList, "menuBanList");
            this.menuBanList.Click += new System.EventHandler(this.menuBanList_Click);
            // 
            // menuGMList
            // 
            this.menuGMList.Name = "menuGMList";
            resources.ApplyResources(this.menuGMList, "menuGMList");
            this.menuGMList.Click += new System.EventHandler(this.menuGMList_Click);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Process";
            this.performanceCounter1.CounterName = "% Processor Time";
            // 
            // cpuTimer
            // 
            this.cpuTimer.Interval = 500;
            this.cpuTimer.Tick += new System.EventHandler(this.cpuTimer_Tick);
            // 
            // labelMangosUpTime
            // 
            resources.ApplyResources(this.labelMangosUpTime, "labelMangosUpTime");
            this.labelMangosUpTime.BackColor = System.Drawing.Color.Transparent;
            this.labelMangosUpTime.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelMangosUpTime.Name = "labelMangosUpTime";
            // 
            // labelUpTime
            // 
            resources.ApplyResources(this.labelUpTime, "labelUpTime");
            this.labelUpTime.BackColor = System.Drawing.Color.Transparent;
            this.labelUpTime.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelUpTime.Name = "labelUpTime";
            // 
            // labelDaysUp
            // 
            resources.ApplyResources(this.labelDaysUp, "labelDaysUp");
            this.labelDaysUp.BackColor = System.Drawing.Color.Transparent;
            this.labelDaysUp.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelDaysUp.Name = "labelDaysUp";
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonCreateAccount, "buttonCreateAccount");
            this.buttonCreateAccount.FlatAppearance.BorderSize = 0;
            this.buttonCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCreateAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelCPU,
            this.toolStripProgressBarCPU,
            this.toolStripLabelOnline});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStripLabelCPU
            // 
            resources.ApplyResources(this.toolStripLabelCPU, "toolStripLabelCPU");
            this.toolStripLabelCPU.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabelCPU.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripLabelCPU.Name = "toolStripLabelCPU";
            // 
            // toolStripProgressBarCPU
            // 
            this.toolStripProgressBarCPU.Name = "toolStripProgressBarCPU";
            resources.ApplyResources(this.toolStripProgressBarCPU, "toolStripProgressBarCPU");
            // 
            // toolStripLabelOnline
            // 
            resources.ApplyResources(this.toolStripLabelOnline, "toolStripLabelOnline");
            this.toolStripLabelOnline.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabelOnline.Name = "toolStripLabelOnline";
            this.toolStripLabelOnline.Text = global::MaNGOS_GUI.Resources.hcStringResources.ManguiMain_Online;
            // 
            // buttonBroadcast
            // 
            this.buttonBroadcast.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonBroadcast, "buttonBroadcast");
            this.buttonBroadcast.FlatAppearance.BorderSize = 0;
            this.buttonBroadcast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBroadcast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBroadcast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBroadcast.Name = "buttonBroadcast";
            this.buttonBroadcast.UseVisualStyleBackColor = false;
            this.buttonBroadcast.Click += new System.EventHandler(this.buttonBroadcast_Click);
            // 
            // buttonSetMOTD
            // 
            this.buttonSetMOTD.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonSetMOTD, "buttonSetMOTD");
            this.buttonSetMOTD.FlatAppearance.BorderSize = 0;
            this.buttonSetMOTD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSetMOTD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSetMOTD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSetMOTD.Name = "buttonSetMOTD";
            this.buttonSetMOTD.UseVisualStyleBackColor = false;
            this.buttonSetMOTD.Click += new System.EventHandler(this.buttonSetMOTD_Click);
            // 
            // buttonBans
            // 
            this.buttonBans.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonBans, "buttonBans");
            this.buttonBans.FlatAppearance.BorderSize = 0;
            this.buttonBans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBans.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBans.Name = "buttonBans";
            this.buttonBans.UseVisualStyleBackColor = false;
            this.buttonBans.Click += new System.EventHandler(this.buttonBans_Click);
            // 
            // buttonLoadScripts
            // 
            this.buttonLoadScripts.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonLoadScripts, "buttonLoadScripts");
            this.buttonLoadScripts.FlatAppearance.BorderSize = 0;
            this.buttonLoadScripts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonLoadScripts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonLoadScripts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLoadScripts.Name = "buttonLoadScripts";
            this.buttonLoadScripts.UseVisualStyleBackColor = false;
            this.buttonLoadScripts.Click += new System.EventHandler(this.buttonLoadScripts_Click);
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonShutdown, "buttonShutdown");
            this.buttonShutdown.FlatAppearance.BorderSize = 0;
            this.buttonShutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonShutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonShutdown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.UseVisualStyleBackColor = false;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonPlayerLimit
            // 
            this.buttonPlayerLimit.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonPlayerLimit, "buttonPlayerLimit");
            this.buttonPlayerLimit.FlatAppearance.BorderSize = 0;
            this.buttonPlayerLimit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerLimit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayerLimit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPlayerLimit.Name = "buttonPlayerLimit";
            this.buttonPlayerLimit.UseVisualStyleBackColor = false;
            this.buttonPlayerLimit.Click += new System.EventHandler(this.buttonPlayerLimit_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            resources.ApplyResources(this.trayIcon, "trayIcon");
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuAddCommands,
            this.toolStripSeparator7,
            this.characterOptionsToolStripMenuItem,
            this.trayMenuAccountOptions,
            this.trayMenuServerOptions,
            this.trayMenuLists,
            this.toolStripSeparator5,
            this.trayMenuEditConfig,
            this.trayMenuClose});
            this.trayMenu.Name = "trayMenu";
            resources.ApplyResources(this.trayMenu, "trayMenu");
            // 
            // trayMenuAddCommands
            // 
            this.trayMenuAddCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuBroadcast,
            this.trayMenuSetMOTD,
            this.trayMenuBans,
            this.trayMenuLoadScripts,
            this.trayMenuShutdown,
            this.trayMenuPlayerLimit});
            this.trayMenuAddCommands.Name = "trayMenuAddCommands";
            resources.ApplyResources(this.trayMenuAddCommands, "trayMenuAddCommands");
            // 
            // trayMenuBroadcast
            // 
            this.trayMenuBroadcast.Name = "trayMenuBroadcast";
            resources.ApplyResources(this.trayMenuBroadcast, "trayMenuBroadcast");
            this.trayMenuBroadcast.Click += new System.EventHandler(this.buttonBroadcast_Click);
            // 
            // trayMenuSetMOTD
            // 
            this.trayMenuSetMOTD.Name = "trayMenuSetMOTD";
            resources.ApplyResources(this.trayMenuSetMOTD, "trayMenuSetMOTD");
            this.trayMenuSetMOTD.Click += new System.EventHandler(this.buttonSetMOTD_Click);
            // 
            // trayMenuBans
            // 
            this.trayMenuBans.Name = "trayMenuBans";
            resources.ApplyResources(this.trayMenuBans, "trayMenuBans");
            this.trayMenuBans.Click += new System.EventHandler(this.buttonBans_Click);
            // 
            // trayMenuLoadScripts
            // 
            this.trayMenuLoadScripts.Name = "trayMenuLoadScripts";
            resources.ApplyResources(this.trayMenuLoadScripts, "trayMenuLoadScripts");
            this.trayMenuLoadScripts.Click += new System.EventHandler(this.buttonLoadScripts_Click);
            // 
            // trayMenuShutdown
            // 
            this.trayMenuShutdown.Name = "trayMenuShutdown";
            resources.ApplyResources(this.trayMenuShutdown, "trayMenuShutdown");
            this.trayMenuShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // trayMenuPlayerLimit
            // 
            this.trayMenuPlayerLimit.Name = "trayMenuPlayerLimit";
            resources.ApplyResources(this.trayMenuPlayerLimit, "trayMenuPlayerLimit");
            this.trayMenuPlayerLimit.Click += new System.EventHandler(this.buttonPlayerLimit_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // characterOptionsToolStripMenuItem
            // 
            this.characterOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuDeleteCharacter,
            this.trayMenuKickCharacter,
            this.trayMenuSendMessage,
            this.trayMenuWritePlayerDump,
            this.trayMenuLoadPlayerDump,
            this.trayMenuTeleport});
            this.characterOptionsToolStripMenuItem.Name = "characterOptionsToolStripMenuItem";
            resources.ApplyResources(this.characterOptionsToolStripMenuItem, "characterOptionsToolStripMenuItem");
            // 
            // trayMenuDeleteCharacter
            // 
            this.trayMenuDeleteCharacter.Name = "trayMenuDeleteCharacter";
            resources.ApplyResources(this.trayMenuDeleteCharacter, "trayMenuDeleteCharacter");
            // 
            // trayMenuKickCharacter
            // 
            this.trayMenuKickCharacter.Name = "trayMenuKickCharacter";
            resources.ApplyResources(this.trayMenuKickCharacter, "trayMenuKickCharacter");
            // 
            // trayMenuSendMessage
            // 
            this.trayMenuSendMessage.Name = "trayMenuSendMessage";
            resources.ApplyResources(this.trayMenuSendMessage, "trayMenuSendMessage");
            this.trayMenuSendMessage.Click += new System.EventHandler(this.menuSendMessage_Click);
            // 
            // trayMenuWritePlayerDump
            // 
            this.trayMenuWritePlayerDump.Name = "trayMenuWritePlayerDump";
            resources.ApplyResources(this.trayMenuWritePlayerDump, "trayMenuWritePlayerDump");
            this.trayMenuWritePlayerDump.Click += new System.EventHandler(this.menuWritePlayerDump_Click);
            // 
            // trayMenuLoadPlayerDump
            // 
            this.trayMenuLoadPlayerDump.Name = "trayMenuLoadPlayerDump";
            resources.ApplyResources(this.trayMenuLoadPlayerDump, "trayMenuLoadPlayerDump");
            this.trayMenuLoadPlayerDump.Click += new System.EventHandler(this.menuLoadPlayerDump_Click);
            // 
            // trayMenuTeleport
            // 
            this.trayMenuTeleport.Name = "trayMenuTeleport";
            resources.ApplyResources(this.trayMenuTeleport, "trayMenuTeleport");
            this.trayMenuTeleport.Click += new System.EventHandler(this.menuTeleport_Click);
            // 
            // trayMenuAccountOptions
            // 
            this.trayMenuAccountOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuCreateAccount,
            this.trayMenuDeleteAccount,
            this.trayMenuSetPassword,
            this.trayMenuSetBC,
            this.trayMenuSetGM});
            this.trayMenuAccountOptions.Name = "trayMenuAccountOptions";
            resources.ApplyResources(this.trayMenuAccountOptions, "trayMenuAccountOptions");
            // 
            // trayMenuCreateAccount
            // 
            this.trayMenuCreateAccount.Name = "trayMenuCreateAccount";
            resources.ApplyResources(this.trayMenuCreateAccount, "trayMenuCreateAccount");
            this.trayMenuCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // trayMenuDeleteAccount
            // 
            this.trayMenuDeleteAccount.Name = "trayMenuDeleteAccount";
            resources.ApplyResources(this.trayMenuDeleteAccount, "trayMenuDeleteAccount");
            this.trayMenuDeleteAccount.Click += new System.EventHandler(this.menuDeleteAccount_Click);
            // 
            // trayMenuSetPassword
            // 
            this.trayMenuSetPassword.Name = "trayMenuSetPassword";
            resources.ApplyResources(this.trayMenuSetPassword, "trayMenuSetPassword");
            this.trayMenuSetPassword.Click += new System.EventHandler(this.menuSetPassword_Click);
            // 
            // trayMenuSetBC
            // 
            this.trayMenuSetBC.Name = "trayMenuSetBC";
            resources.ApplyResources(this.trayMenuSetBC, "trayMenuSetBC");
            this.trayMenuSetBC.Click += new System.EventHandler(this.menuSetBC_Click);
            // 
            // trayMenuSetGM
            // 
            this.trayMenuSetGM.Name = "trayMenuSetGM";
            resources.ApplyResources(this.trayMenuSetGM, "trayMenuSetGM");
            this.trayMenuSetGM.Click += new System.EventHandler(this.menuSetGM_Click);
            // 
            // trayMenuServerOptions
            // 
            this.trayMenuServerOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuStartServers,
            this.toolStripSeparator6,
            this.trayMenuMangos,
            this.trayMenuRealm,
            this.toolStripSeparator8,
            this.trayMenuSaveAll});
            this.trayMenuServerOptions.Name = "trayMenuServerOptions";
            resources.ApplyResources(this.trayMenuServerOptions, "trayMenuServerOptions");
            // 
            // trayMenuStartServers
            // 
            this.trayMenuStartServers.Name = "trayMenuStartServers";
            resources.ApplyResources(this.trayMenuStartServers, "trayMenuStartServers");
            this.trayMenuStartServers.Click += new System.EventHandler(this.menuStartServers_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // trayMenuMangos
            // 
            this.trayMenuMangos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuStartMangos,
            this.trayMenuStopMangos});
            this.trayMenuMangos.Name = "trayMenuMangos";
            resources.ApplyResources(this.trayMenuMangos, "trayMenuMangos");
            // 
            // trayMenuStartMangos
            // 
            this.trayMenuStartMangos.Name = "trayMenuStartMangos";
            resources.ApplyResources(this.trayMenuStartMangos, "trayMenuStartMangos");
            this.trayMenuStartMangos.Click += new System.EventHandler(this.menuMangosStart_Click);
            // 
            // trayMenuStopMangos
            // 
            this.trayMenuStopMangos.Name = "trayMenuStopMangos";
            resources.ApplyResources(this.trayMenuStopMangos, "trayMenuStopMangos");
            this.trayMenuStopMangos.Click += new System.EventHandler(this.menuMangosStop_Click);
            // 
            // trayMenuRealm
            // 
            this.trayMenuRealm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuStartRealm,
            this.trayMenuStopRealm});
            this.trayMenuRealm.Name = "trayMenuRealm";
            resources.ApplyResources(this.trayMenuRealm, "trayMenuRealm");
            // 
            // trayMenuStartRealm
            // 
            this.trayMenuStartRealm.Name = "trayMenuStartRealm";
            resources.ApplyResources(this.trayMenuStartRealm, "trayMenuStartRealm");
            this.trayMenuStartRealm.Click += new System.EventHandler(this.menuRealmStart_Click);
            // 
            // trayMenuStopRealm
            // 
            this.trayMenuStopRealm.Name = "trayMenuStopRealm";
            resources.ApplyResources(this.trayMenuStopRealm, "trayMenuStopRealm");
            this.trayMenuStopRealm.Click += new System.EventHandler(this.menuRealmStop_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // trayMenuSaveAll
            // 
            this.trayMenuSaveAll.Name = "trayMenuSaveAll";
            resources.ApplyResources(this.trayMenuSaveAll, "trayMenuSaveAll");
            this.trayMenuSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // trayMenuLists
            // 
            this.trayMenuLists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuBansList,
            this.trayMenuGMList});
            this.trayMenuLists.Name = "trayMenuLists";
            resources.ApplyResources(this.trayMenuLists, "trayMenuLists");
            // 
            // trayMenuBansList
            // 
            this.trayMenuBansList.Name = "trayMenuBansList";
            resources.ApplyResources(this.trayMenuBansList, "trayMenuBansList");
            this.trayMenuBansList.Click += new System.EventHandler(this.menuBanList_Click);
            // 
            // trayMenuGMList
            // 
            this.trayMenuGMList.Name = "trayMenuGMList";
            resources.ApplyResources(this.trayMenuGMList, "trayMenuGMList");
            this.trayMenuGMList.Click += new System.EventHandler(this.menuGMList_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // trayMenuEditConfig
            // 
            this.trayMenuEditConfig.Name = "trayMenuEditConfig";
            resources.ApplyResources(this.trayMenuEditConfig, "trayMenuEditConfig");
            this.trayMenuEditConfig.Click += new System.EventHandler(this.menuEditConfig_Click);
            // 
            // trayMenuClose
            // 
            this.trayMenuClose.Name = "trayMenuClose";
            resources.ApplyResources(this.trayMenuClose, "trayMenuClose");
            this.trayMenuClose.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonSaveAll, "buttonSaveAll");
            this.buttonSaveAll.FlatAppearance.BorderSize = 0;
            this.buttonSaveAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSaveAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSaveAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.UseVisualStyleBackColor = false;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // pictureLogo
            // 
            resources.ApplyResources(this.pictureLogo, "pictureLogo");
            this.pictureLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogo.BackgroundImage = global::MaNGOS_GUI.Properties.Resources.MaNGOSGui;
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.TabStop = false;
            // 
            // tbcMain
            // 
            this.tbcMain.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbcMain.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.tbcMain, "tbcMain");
            this.tbcMain.LookAndFeel.SkinName = "Black";
            this.tbcMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedTabPage = this.tbpMangosOutput;
            this.tbcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tbpMangosOutput,
            this.tbpRealmOutput,
            this.tbpInfo});
            // 
            // tbpMangosOutput
            // 
            this.tbpMangosOutput.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbpMangosOutput.Appearance.PageClient.Options.UseBackColor = true;
            this.tbpMangosOutput.Controls.Add(this.rtbConsoleText);
            this.tbpMangosOutput.Name = "tbpMangosOutput";
            resources.ApplyResources(this.tbpMangosOutput, "tbpMangosOutput");
            // 
            // rtbConsoleText
            // 
            this.rtbConsoleText.BackColor = System.Drawing.SystemColors.Control;
            this.rtbConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbConsoleText, "rtbConsoleText");
            this.rtbConsoleText.Name = "rtbConsoleText";
            this.rtbConsoleText.ReadOnly = true;
            // 
            // tbpRealmOutput
            // 
            this.tbpRealmOutput.Controls.Add(this.rtbRealmText);
            this.tbpRealmOutput.Name = "tbpRealmOutput";
            resources.ApplyResources(this.tbpRealmOutput, "tbpRealmOutput");
            // 
            // rtbRealmText
            // 
            this.rtbRealmText.BackColor = System.Drawing.SystemColors.Control;
            this.rtbRealmText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbRealmText, "rtbRealmText");
            this.rtbRealmText.Name = "rtbRealmText";
            this.rtbRealmText.ReadOnly = true;
            // 
            // tbpInfo
            // 
            this.tbpInfo.Controls.Add(this.groupAccountActions);
            this.tbpInfo.Controls.Add(this.btnRefresh);
            this.tbpInfo.Controls.Add(this.dataOnlineInfo);
            this.tbpInfo.Name = "tbpInfo";
            resources.ApplyResources(this.tbpInfo, "tbpInfo");
            // 
            // groupAccountActions
            // 
            this.groupAccountActions.Controls.Add(this.btnGo);
            this.groupAccountActions.Controls.Add(this.comboAccountActions);
            resources.ApplyResources(this.groupAccountActions, "groupAccountActions");
            this.groupAccountActions.Name = "groupAccountActions";
            this.groupAccountActions.TabStop = false;
            // 
            // btnGo
            // 
            resources.ApplyResources(this.btnGo, "btnGo");
            this.btnGo.Name = "btnGo";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // comboAccountActions
            // 
            this.comboAccountActions.FormattingEnabled = true;
            this.comboAccountActions.Items.AddRange(new object[] {
            resources.GetString("comboAccountActions.Items"),
            resources.GetString("comboAccountActions.Items1"),
            resources.GetString("comboAccountActions.Items2"),
            resources.GetString("comboAccountActions.Items3"),
            resources.GetString("comboAccountActions.Items4"),
            resources.GetString("comboAccountActions.Items5"),
            resources.GetString("comboAccountActions.Items6"),
            resources.GetString("comboAccountActions.Items7"),
            resources.GetString("comboAccountActions.Items8"),
            resources.GetString("comboAccountActions.Items9"),
            resources.GetString("comboAccountActions.Items10"),
            resources.GetString("comboAccountActions.Items11")});
            resources.ApplyResources(this.comboAccountActions, "comboAccountActions");
            this.comboAccountActions.Name = "comboAccountActions";
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataOnlineInfo
            // 
            this.dataOnlineInfo.AllowUserToAddRows = false;
            this.dataOnlineInfo.AllowUserToDeleteRows = false;
            this.dataOnlineInfo.AllowUserToResizeRows = false;
            this.dataOnlineInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataOnlineInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataOnlineInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataOnlineInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataOnlineInfo, "dataOnlineInfo");
            this.dataOnlineInfo.Name = "dataOnlineInfo";
            this.dataOnlineInfo.ReadOnly = true;
            this.dataOnlineInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // consoleTimer
            // 
            this.consoleTimer.Enabled = true;
            this.consoleTimer.Interval = 1000;
            this.consoleTimer.Tick += new System.EventHandler(this.consoleTimer_Tick);
            // 
            // ManguiMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tbcMain);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.buttonPlayerLimit);
            this.Controls.Add(this.buttonShutdown);
            this.Controls.Add(this.buttonLoadScripts);
            this.Controls.Add(this.buttonBans);
            this.Controls.Add(this.buttonSetMOTD);
            this.Controls.Add(this.buttonBroadcast);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.labelDaysUp);
            this.Controls.Add(this.labelUpTime);
            this.Controls.Add(this.labelMangosUpTime);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.Name = "ManguiMain";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcMain)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.tbpMangosOutput.ResumeLayout(false);
            this.tbpRealmOutput.ResumeLayout(false);
            this.tbpInfo.ResumeLayout(false);
            this.groupAccountActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataOnlineInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuEditConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ToolStripMenuItem menuServerOptions;
        private System.Windows.Forms.ToolStripMenuItem menuStartServers;
        private System.Windows.Forms.Timer cpuTimer;
        private System.Windows.Forms.Label labelMangosUpTime;
        private System.Windows.Forms.Label labelUpTime;
        private System.Windows.Forms.Label labelDaysUp;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarCPU;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelCPU;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelOnline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuMangosServer;
        private System.Windows.Forms.ToolStripMenuItem menuRealmServer;
        private System.Windows.Forms.ToolStripMenuItem menuMangosStart;
        private System.Windows.Forms.ToolStripMenuItem menuMangosStop;
        private System.Windows.Forms.ToolStripMenuItem menuRealmStart;
        private System.Windows.Forms.ToolStripMenuItem menuRealmStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuMangosRestart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuRealmRestart;
        private System.Windows.Forms.Button buttonBroadcast;
        private System.Windows.Forms.Button buttonSetMOTD;
        private System.Windows.Forms.Button buttonBans;
        private System.Windows.Forms.Button buttonLoadScripts;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonPlayerLimit;
        private System.Windows.Forms.ToolStripMenuItem menuAccountOptions;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteAccount;
        private System.Windows.Forms.ToolStripMenuItem menuSetGM;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuClose;
        private System.Windows.Forms.ToolStripMenuItem trayMenuEditConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem trayMenuServerOptions;
        private System.Windows.Forms.ToolStripMenuItem trayMenuAccountOptions;
        private System.Windows.Forms.ToolStripMenuItem trayMenuStartServers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem trayMenuMangos;
        private System.Windows.Forms.ToolStripMenuItem trayMenuRealm;
        private System.Windows.Forms.ToolStripMenuItem trayMenuStartMangos;
        private System.Windows.Forms.ToolStripMenuItem trayMenuStopMangos;
        private System.Windows.Forms.ToolStripMenuItem trayMenuStartRealm;
        private System.Windows.Forms.ToolStripMenuItem trayMenuStopRealm;
        private System.Windows.Forms.ToolStripMenuItem trayMenuCreateAccount;
        private System.Windows.Forms.ToolStripMenuItem trayMenuDeleteAccount;
        private System.Windows.Forms.ToolStripMenuItem trayMenuSetBC;
        private System.Windows.Forms.ToolStripMenuItem trayMenuSetGM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem trayMenuAddCommands;
        private System.Windows.Forms.ToolStripMenuItem trayMenuBroadcast;
        private System.Windows.Forms.ToolStripMenuItem trayMenuSetMOTD;
        private System.Windows.Forms.ToolStripMenuItem trayMenuLoadScripts;
        private System.Windows.Forms.ToolStripMenuItem trayMenuShutdown;
        private System.Windows.Forms.ToolStripMenuItem trayMenuPlayerLimit;
        private System.Windows.Forms.ToolStripMenuItem trayMenuBans;
        private System.Windows.Forms.ToolStripMenuItem menuSetBC;
        private System.Windows.Forms.ToolStripMenuItem menuSetPassword;
        private System.Windows.Forms.ToolStripMenuItem trayMenuSetPassword;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem trayMenuSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem menuLogLevel;
        private System.Windows.Forms.ToolStripMenuItem menuMinimumLogLevel;
        private System.Windows.Forms.ToolStripMenuItem menuBasicErrorLogLevel;
        private System.Windows.Forms.ToolStripMenuItem menuDetailLogLevel;
        private System.Windows.Forms.ToolStripMenuItem menuFullDebugLogLevel;
        private System.Windows.Forms.ToolStripMenuItem menuCharacterOptions;
        private System.Windows.Forms.ToolStripMenuItem menuKickCharacter;
        private System.Windows.Forms.ToolStripMenuItem menuSendMessage;
        private System.Windows.Forms.ToolStripMenuItem characterOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trayMenuDeleteCharacter;
        private System.Windows.Forms.ToolStripMenuItem trayMenuKickCharacter;
        private System.Windows.Forms.ToolStripMenuItem trayMenuSendMessage;
        private System.Windows.Forms.ToolStripMenuItem menuWritePlayerDump;
        private System.Windows.Forms.ToolStripMenuItem trayMenuWritePlayerDump;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteCharacter;
        private System.Windows.Forms.ToolStripMenuItem menuLoadPlayerDump;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.ToolStripMenuItem trayMenuLoadPlayerDump;
        private System.Windows.Forms.ToolStripMenuItem menuTeleport;
        private System.Windows.Forms.ToolStripMenuItem trayMenuTeleport;
        private System.Windows.Forms.ToolStripMenuItem menuLists;
        private System.Windows.Forms.ToolStripMenuItem menuBanList;
        private System.Windows.Forms.ToolStripMenuItem menuGMList;
        private System.Windows.Forms.ToolStripMenuItem trayMenuLists;
        private System.Windows.Forms.ToolStripMenuItem trayMenuBansList;
        private System.Windows.Forms.ToolStripMenuItem trayMenuGMList;
        private System.Windows.Forms.ToolStripMenuItem menuFileLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuFileLanguageEnglish;
        private System.Windows.Forms.ToolStripMenuItem menuFileLanguageFrench;
        private DevExpress.XtraTab.XtraTabControl tbcMain;
        private DevExpress.XtraTab.XtraTabPage tbpMangosOutput;
        private DevExpress.XtraTab.XtraTabPage tbpInfo;
        private System.Windows.Forms.RichTextBox rtbConsoleText;
        private System.Windows.Forms.Timer consoleTimer;
        private System.Windows.Forms.DataGridView dataOnlineInfo;
        private System.Windows.Forms.GroupBox groupAccountActions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox comboAccountActions;
        private DevExpress.XtraTab.XtraTabPage tbpRealmOutput;
        private System.Windows.Forms.RichTextBox rtbRealmText;
    }
}

