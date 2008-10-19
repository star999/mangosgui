using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI
{
    public partial class teleChar : Form
    {
        private IList<string> locations;

        public teleChar()
        {
            InitializeComponent();

            fillLocations();
        }

        private void fillLocations()
        {
            ServerData sData = new ServerData();
            locations = sData.getTeleportLocations();
            comboLocations.DataSource = locations;
        }

        private void buttonTeleport_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textCharacterName.Text))
            {
                try
                {
                    ServerData sData = new ServerData();

                    if (sData.checkCharacterExists(textCharacterName.Text))
                    {
                        string commandString = "tele " + textCharacterName.Text + " " + comboLocations.Text;
                        ManguiMain.mangosProcess.StandardInput.WriteLine(commandString);

                        ConfigAccess.updateLog(commandString);

                        MessageBox.Show(string.Format(Resources.hcStringResources.Global_CommandSuccesful, commandString));
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Resources.hcStringResources.teleChar_BadCharacterName, textCharacterName.Text));
                    }
                }
                catch
                {
                    MessageBox.Show(Resources.hcStringResources.Global_CommandError);
                }
            }
            else
            {
                MessageBox.Show(Resources.hcStringResources.teleChar_PleaseEnterCharacterToTeleport );
            }
        }
    }
}
