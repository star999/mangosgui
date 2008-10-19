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
    public partial class playerLimit : Form
    {
        public playerLimit()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textPlayerLimit.Text))
            {
                try
                {
                    string commandString = "plimit " + textPlayerLimit.Text;
                    ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                    ConfigAccess.updateLog(commandString);

                    MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                    this.Close();
                }
                catch
                {
                    MessageBox.Show(hcStringResources.Global_CommandError);
                }
            }
            else
            {
                MessageBox.Show(hcStringResources.playerLimit_EnterLimit);
            }
        }
    }
}
