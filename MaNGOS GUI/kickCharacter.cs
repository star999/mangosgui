using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;
using MaNGOS_GUI.Resources;

namespace MaNGOS_GUI
{
    public partial class kickCharacter : Form
    {
        public kickCharacter()
        {
            InitializeComponent();
        }

        private void buttonKick_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textCharacterName.Text))
            {
                try
                {
                    ServerData sData = new ServerData();

                    if (sData.checkCharacterExists(textCharacterName.Text))
                    {
                        string commandString = "kick " + textCharacterName.Text;
                        ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                        ConfigAccess.updateLog(commandString);

                        MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(hcStringResources.kickCharacter_CharacterDoesntExist);
                    }
                }
                catch
                {
                    MessageBox.Show(hcStringResources.Global_CommandError);
                }                
            }
            else
            {
                MessageBox.Show(hcStringResources.kickCharacter_EnterCharacter);
            }
        }
    }
}
