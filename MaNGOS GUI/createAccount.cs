using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI
{
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            ServerData sData = new ServerData();
            
            if (sData.checkAccountExists(textAccountName.Text) == false)
            {
                try
                {
                    if (!String.IsNullOrEmpty(textAccountName.Text))
                    {
                        if (!String.IsNullOrEmpty(textPassword.Text))
                        {
                            string commandString = "create " + textAccountName.Text + " " + textPassword.Text;
                            ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                            ConfigAccess.updateLog(commandString);

                            MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(Resources.hcStringResources.createAccount_EnterPassword);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Resources.hcStringResources.createAccount_EnterAccountName);
                    }
                }
                catch
                {
                    MessageBox.Show(Resources.hcStringResources.Global_CommandError);
                }
            }
            else
            {
                MessageBox.Show(Resources.hcStringResources.createAccount_AccountExists);

                ConfigAccess.updateLog("Account creation failed");
            }
        }
    }
}