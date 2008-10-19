using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;
using MaNGOS_GUI.Resources;

namespace MaNGOS_GUI
{
    public partial class deleteAccount : Form
    {
        public deleteAccount()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textAccountName.Text))
            {
                if (MessageBox.Show(hcStringResources.deleteAccount_ConfirmDelete, hcStringResources.deleteAccount_ConfirmDeleteCaption, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        ServerData sData = new ServerData();

                        if (sData.checkAccountExists(textAccountName.Text))
                        {
                            string commandString = "delete " + textAccountName.Text;
                            ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                            ConfigAccess.updateLog(commandString);

                            MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(hcStringResources.deleteAccount_AccountDoesntExist);
                        }
                    }
                    catch
                    {
                        MessageBox.Show(hcStringResources.Global_CommandError);
                    }
                }
            }
            else
            {
                MessageBox.Show(hcStringResources.deleteAccount_EnterAccount);
            }
        }

        private void textAccountName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAccountName_Click(object sender, EventArgs e)
        {

        }
    }
}
