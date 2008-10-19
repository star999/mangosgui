using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MaNGOS_GUI;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI
{
    public partial class broadcastMessage : Form
    {
        public broadcastMessage()
        {
            InitializeComponent();
        }

        private void buttonBroadcastMessage_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBroadcastMessage.Text))
            {
                try
                {
                    string commandString = "broadcast " + textBroadcastMessage.Text;
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
                MessageBox.Show(Resources.hcStringResources.broadcastMessage_EnterMessage);
            }
        }
    }
}
