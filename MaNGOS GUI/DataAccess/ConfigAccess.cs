using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaNGOS_GUI;
using ConfigEditor;

namespace MaNGOS_GUI.DataAccess
{
    
    class ConfigAccess
    {
        private static bool corruptConfig = false;

        public static void checkEncryptKey()
        {
        }

        public static void getConfigData()
        {
            string DataPath = Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\data\\";
            string FilePath = DataPath + "Config.dat";
            string EncryptKey = Properties.Settings.Default.GUID;

            if (!Directory.Exists(DataPath))
            {
                Directory.CreateDirectory(DataPath);
            }
            
            if (File.Exists(FilePath))
            {
                ConfigEncryptor ConfigEncrypt = new ConfigEncryptor();
                EncryptKey = Properties.Settings.Default.GUID;

                try
                {
                    ConfigEncrypt.DecryptConfig(FilePath, DataPath, EncryptKey);
                }
                catch
                {
                    MessageBox.Show("Config has become corrupt. Loading default values. Please update values again.");
                    corruptConfig = true;
                }

                if (corruptConfig)
                    goto Advance;
                
                StreamReader reader = new StreamReader(FilePath);
                ConfigEditor.ConfigEditor config = new ConfigEditor.ConfigEditor(reader);
                reader.Close();

                ConfigEncrypt.EncryptConfig(FilePath, DataPath, EncryptKey);

                ConfigProperties.timerInterval = (string)config.GetValue("TimerInterval");
                
                if ((string)config.GetValue("MangosHosted") == "1")
                {
                    ConfigProperties.mangosHosted = true;
                }
                else
                {
                    ConfigProperties.mangosHosted = false;
                }

                if ((string)config.GetValue("RealmHosted") == "1")
                {
                    ConfigProperties.realmHosted = true;
                }
                else
                {
                    ConfigProperties.realmHosted = false;
                }

                ConfigProperties.mangosAppName = (string)config.GetValue("MangosAppName");
                ConfigProperties.mangosAppPath = (string)config.GetValue("MangosAppPath");
                ConfigProperties.realmAppName = (string)config.GetValue("RealmAppName");
                ConfigProperties.realmAppPath = (string)config.GetValue("RealmAppPath");
                ConfigProperties.dbHost = (string)config.GetValue("DbHost");
                ConfigProperties.dbPort = (string)config.GetValue("DbPort");
                ConfigProperties.dbUser = (string)config.GetValue("DbUser");
                ConfigProperties.dbPassword = (string)config.GetValue("DbPassword");
                ConfigProperties.mangosDatabaseName = (string)config.GetValue("MangosDatabaseName");
                ConfigProperties.realmDatabaseName = (string)config.GetValue("RealmDatabaseName");
                ConfigProperties.charDatabaseName = (string)config.GetValue("CharDatabaseName");
                ConfigProperties.mangosMOTD = (string)config.GetValue("MangosMOTD");
                goto Finish;

            Advance:
                ConfigProperties.timerInterval = "10000";
                ConfigProperties.mangosHosted = true;
                ConfigProperties.realmHosted = true;
                ConfigProperties.mangosAppName = "mangosd";
                ConfigProperties.mangosAppPath = "C:\\mangos\\";
                ConfigProperties.realmAppName = "realmd";
                ConfigProperties.realmAppPath = "C:\\mangos\\";
                ConfigProperties.dbHost = "localhost";
                ConfigProperties.dbPort = "3306";
                ConfigProperties.dbUser = "root";
                ConfigProperties.dbPassword = "password";
                ConfigProperties.mangosDatabaseName = "mangos";
                ConfigProperties.realmDatabaseName = "realm";
                ConfigProperties.charDatabaseName = "characters";
                ConfigProperties.mangosMOTD = "Welcome to MaNGOS";
                editConfig showEditConfig = new editConfig();
                showEditConfig.Show();

            Finish: ;
            }
            else
            {
                ConfigProperties.timerInterval = "10000";
                ConfigProperties.mangosHosted = true;
                ConfigProperties.realmHosted = true;
                ConfigProperties.mangosAppName = "mangosd";
                ConfigProperties.mangosAppPath = "C:\\mangos\\";
                ConfigProperties.realmAppName = "realmd";
                ConfigProperties.realmAppPath = "C:\\mangos\\";
                ConfigProperties.dbHost = "localhost";
                ConfigProperties.dbPort = "3306";
                ConfigProperties.dbUser = "root";
                ConfigProperties.dbPassword = "password";
                ConfigProperties.mangosDatabaseName = "mangos";
                ConfigProperties.realmDatabaseName = "realm";
                ConfigProperties.charDatabaseName = "characters";
                ConfigProperties.mangosMOTD = "Welcome to MaNGOS";

                MessageBox.Show(string.Format(Resources.hcStringResources.Global_DataAccess_Config_NotSavedAnyConfigValues ));
                editConfig showEditConfig = new editConfig();
                showEditConfig.Show();
            }
        }

        public static void setConfigData(string timerInterval,
                                         bool mangosHosted,
                                         bool realmHosted,
                                         string mangosAppName,
                                         string realmAppName,
                                         string mangosAppPath,
                                         string realmAppPath,
                                         string dbHost,
                                         string dbPort,
                                         string dbUser,
                                         string dbPassword,
                                         string mangosDbName,
                                         string realmDbName,
                                         string charDbName,
                                         string mangosMOTD,
                                         bool firstUse)
        {
            string DataPath = Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\data\\";
            string FilePath = DataPath + "Config.dat";
            string EncryptKey = Properties.Settings.Default.GUID;

            if (corruptConfig)
            {
                File.Delete(FilePath);
                File.Delete(DataPath + "Temp.dat");
                corruptConfig = false;
            }

            if (File.Exists(FilePath))
            {
                ConfigEncryptor ConfigEncrypt = new ConfigEncryptor();
                EncryptKey = Properties.Settings.Default.GUID;

                ConfigEncrypt.DecryptConfig(FilePath, DataPath, EncryptKey);

                StreamReader reader = new StreamReader(FilePath);
                ConfigEditor.ConfigEditor config = new ConfigEditor.ConfigEditor(reader);
                reader.Close();
                StreamWriter writer = new StreamWriter(FilePath);

                config.SetValue("TimerInterval", timerInterval);

                if (mangosHosted)
                {
                    config.SetValue("MangosHosted", "1");
                }
                else
                {
                    config.SetValue("MangosHosted", "0");
                }

                if (realmHosted)
                {
                    config.SetValue("RealmHosted", "1");
                }
                else
                {
                    config.SetValue("RealmHosted", "0");
                }

                config.SetValue("MangosAppName", mangosAppName);
                config.SetValue("RealmAppName", realmAppName);
                config.SetValue("MangosAppPath", mangosAppPath);
                config.SetValue("RealmAppPath", realmAppPath);
                config.SetValue("DbHost", dbHost);
                config.SetValue("DbPort", dbPort);
                config.SetValue("DbUser", dbUser);
                config.SetValue("DbPassword", dbPassword);
                config.SetValue("MangosDatabaseName", mangosDbName);
                config.SetValue("RealmDatabaseName", realmDbName);
                config.SetValue("CharDatabaseName", charDbName);
                config.SetValue("MangosMOTD", mangosMOTD);

                config.SaveConfig(writer);
                writer.Close();

                ConfigEncrypt.EncryptConfig(FilePath, DataPath, EncryptKey);
            }
            else
            {
                ConfigEncryptor ConfigEncrypt = new ConfigEncryptor();
                EncryptKey = Properties.Settings.Default.GUID;

                ConfigEditor.ConfigEditor config = new ConfigEditor.ConfigEditor();
                StreamWriter writer = new StreamWriter(FilePath);

                config.SetValue("TimerInterval", timerInterval);

                if (mangosHosted)
                {
                    config.SetValue("MangosHosted", "1");
                }
                else
                {
                    config.SetValue("MangosHosted", "0");
                }

                if (realmHosted)
                {
                    config.SetValue("RealmHosted", "1");
                }
                else
                {
                    config.SetValue("RealmHosted", "0");
                }

                config.SetValue("MangosAppName", mangosAppName);
                config.SetValue("RealmAppName", realmAppName);
                config.SetValue("MangosAppPath", mangosAppPath);
                config.SetValue("RealmAppPath", realmAppPath);
                config.SetValue("DbHost", dbHost);
                config.SetValue("DbPort", dbPort);
                config.SetValue("DbUser", dbUser);
                config.SetValue("DbPassword", dbPassword);
                config.SetValue("MangosDatabaseName", mangosDbName);
                config.SetValue("RealmDatabaseName", realmDbName);
                config.SetValue("CharDatabaseName", charDbName);
                config.SetValue("MangosMOTD", mangosMOTD);

                config.SaveConfig(writer);
                writer.Close();

                ConfigEncrypt.EncryptConfig(FilePath, DataPath, EncryptKey);
            }

            getConfigData();
        }

        public static void updateLog(string entryDetails)
        {
            //Not implemented yet. Removed with move to file based config and log.
        }

    }

}
