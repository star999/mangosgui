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
    public partial class setBC : Form
    {
        public setBC()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string bcLevel = null;

                if (comboBC.Text == Resources.hcStringResources.setBC_Activate)
                    bcLevel = "1";

                if (comboBC.Text == Resources.hcStringResources.setBC_deactivate)
                    bcLevel = "0";

                if (!String.IsNullOrEmpty(accountComboBox1.Text))
                {
                    if (!String.IsNullOrEmpty(bcLevel))
                    {
                        ServerData sData = new ServerData();

                        if (sData.checkAccountExists(accountComboBox1.Text))
                        {
                            string commandString = "setbc " + accountComboBox1.Text + " " + bcLevel;
                            ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                            ConfigAccess.updateLog(commandString);

                            MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(Resources.hcStringResources.setBC_AccountUnknown);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Resources.hcStringResources.setBC_ChooseAction);
                    }
                }
                else
                {
                    MessageBox.Show(Resources.hcStringResources.setBC_EnterAccount);
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_CommandError);
            }
        }
    }
}
