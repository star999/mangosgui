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
    public partial class deleteCharacter : Form
    {
        public deleteCharacter()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textCharacterName.Text))
            {
                if (MessageBox.Show("Are you sure you want to proceed?.", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        ServerData sData = new ServerData();

                        if (sData.checkCharacterExists(textCharacterName.Text))
                        {
                            string commandString = "chardelete " + textCharacterName.Text;
                            ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                            ConfigAccess.updateLog(commandString);

                            MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("There is no character by that name in the database.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("An error occured while trying to complete this action.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a character to delete.");
            }
        }
    }
}
