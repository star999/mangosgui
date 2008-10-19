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
    public partial class serverShutdown : Form
    {
        public serverShutdown()
        {
            InitializeComponent();
        }

        private void buttonIdleShutdown_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textShutdownDelay.Text))
                {
                    string commandString = "idleshutdown " + textShutdownDelay.Text;
                    ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(hcStringResources.serverShutdown_EnterDelayTime);
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_CommandError );
            }
        }

        private void buttonDelayedShutdown_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textShutdownDelay.Text))
                {
                    string commandString = "shutdown " + textShutdownDelay.Text;
                    ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(hcStringResources.serverShutdown_EnterDelayTime);
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_CommandError);
            }
        }
    }
}
