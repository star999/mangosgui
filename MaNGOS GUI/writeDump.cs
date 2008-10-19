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
    public partial class writeDump : Form
    {
        public writeDump()
        {
            InitializeComponent();

        }      

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textFileName.Text))
                {
                    if (!String.IsNullOrEmpty(comboboxplayer.SelectedText  ))
                    {
                        string commandString = "writepdump " + textFileName.Text + " " + comboboxplayer.SelectedText;
                        ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                        ConfigAccess.updateLog(commandString);

                        MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(Resources.hcStringResources.writeDump_EnterPlayerName );
                    }
                }
                else
                {
                    MessageBox.Show(Resources.hcStringResources.writeDump_EnterFileName);
                }
            }
            catch
            {
                MessageBox.Show(Resources.hcStringResources.Global_CommandError );
            }
        }
    }
}
