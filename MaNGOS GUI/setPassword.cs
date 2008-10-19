using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI
{
    public partial class setPassword : Form
    {
        public setPassword()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (validatePassword())
            {
                ServerData sData = new ServerData();

                try
                {
                    string commandString = "setpass " + accountComboBox1.SelectedItem + " " + textPassword.Text + " " + textValidatePassword.Text;
                    ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                    this.Close();
                }
                catch
                {
                    MessageBox.Show(Resources.hcStringResources.Global_CommandError);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match or have not been entered.");
            }

        }

        private bool validatePassword()
        {
            if (!String.IsNullOrEmpty(textPassword.Text))
            {
                if (textPassword.Text == textValidatePassword.Text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
