using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using MaNGOS_GUI;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI
{
    public partial class setMOTD : Form
    {
        public setMOTD()
        {
            InitializeComponent();
        }

        private void buttonSetMOTD_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textSetMOTD.Text))
                {
                    string commandString = "motd " + textSetMOTD.Text;
                    ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Resources.hcStringResources.SetMOTD_EnterMOTD );
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_CommandError );
            }
        }
    }
}
