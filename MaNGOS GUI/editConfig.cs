using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaNGOS_GUI.DataAccess;

namespace MaNGOS_GUI
{
    public partial class editConfig : Form
    {
        public editConfig()
        {
            InitializeComponent();

            textTimerInterval.Text = ConfigProperties.timerInterval;
            checkBoxMangosHosted.Checked = ConfigProperties.mangosHosted;
            checkBoxRealmHosted.Checked = ConfigProperties.realmHosted;
            textMangosAppName.Text = ConfigProperties.mangosAppName;
            textRealmAppName.Text = ConfigProperties.realmAppName;
            textMangosPath.Text = ConfigProperties.mangosAppPath;
            textRealmPath.Text = ConfigProperties.realmAppPath;
            textDbHost.Text = ConfigProperties.dbHost;
            textDbPort.Text = ConfigProperties.dbPort;
            textDbUser.Text = ConfigProperties.dbUser;
            textDbPassword.Text = ConfigProperties.dbPassword;
            textMangosDbName.Text = ConfigProperties.mangosDatabaseName;
            textRealmDbName.Text = ConfigProperties.realmDatabaseName;
            textCharactersDbName.Text = ConfigProperties.charDatabaseName;
            textMOTD.Text = ConfigProperties.mangosMOTD;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ConfigAccess.setConfigData(textTimerInterval.Text,
                                       checkBoxMangosHosted.Checked,
                                       checkBoxRealmHosted.Checked,
                                       textMangosAppName.Text,
                                       textRealmAppName.Text,
                                       textMangosPath.Text,
                                       textRealmPath.Text,
                                       textDbHost.Text,
                                       textDbPort.Text,
                                       textDbUser.Text,
                                       textDbPassword.Text,
                                       textMangosDbName.Text,
                                       textRealmDbName.Text,
                                       textCharactersDbName.Text,
                                       textMOTD.Text,
                                       false);
            ConfigAccess.updateLog("Configuration changed");
            this.Close();
        }
    }
}
