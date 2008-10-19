using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;
using MaNGOS_GUI.Resources;

namespace MaNGOS_GUI
{
    public partial class loadDump : Form
    {
        public loadDump()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textFileName.Text))
                {
                    if (!String.IsNullOrEmpty(textAccountName.Text))
                    {
                        ServerData sData = new ServerData();

                        if (sData.checkAccountExists(textAccountName.Text))
                        {
                            string commandString = "loadpdump " + textFileName.Text + " " + textAccountName.Text;
                            ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                            ConfigAccess.updateLog(commandString);

                            MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(hcStringResources.loadDump_AccountDoesntExist);
                        }
                    }
                    else
                    {
                        MessageBox.Show(hcStringResources.loadDump_EnterNameOrGuid);
                    }
                }
                else
                {
                    MessageBox.Show(hcStringResources.loadDump_EnterFileName);
                }
            }
            catch
            {
                MessageBox.Show(hcStringResources.Global_CommandError);
            }
        }
    }
}
