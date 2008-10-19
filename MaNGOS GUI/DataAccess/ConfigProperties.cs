using System;
using System.Collections.Generic;
using System.Text;

namespace MaNGOS_GUI.DataAccess
{
    class ConfigProperties
    {

        private static string _timerInterval;
        private static bool _mangosHosted;
        private static bool _realmHosted;
        private static string _mangosAppName;
        private static string _realmAppName;
        private static string _mangosAppPath;
        private static string _realmAppPath;
        private static string _dbHost;
        private static string _dbPort;
        private static string _dbUser;
        private static string _dbPassword;
        private static string _mangosDatabaseName;
        private static string _realmDatabaseName;
        private static string _charDatabaseName;
        private static string _mangosMOTD;

        public static string timerInterval
        {
            get { return _timerInterval; }
            set { _timerInterval = value; }
        }

        public static bool mangosHosted
        {
            get { return _mangosHosted; }
            set { _mangosHosted = value; }
        }

        public static bool realmHosted
        {
            get { return _realmHosted; }
            set { _realmHosted = value; }
        }

        public static string mangosAppName
        {
            get { return _mangosAppName; }
            set { _mangosAppName = value; }
        }

        public static string realmAppName
        {
            get { return _realmAppName; }
            set { _realmAppName = value; }
        }

        public static string mangosAppPath
        {
            get { return _mangosAppPath; }
            set { _mangosAppPath = value; }
        }

        public static string realmAppPath
        {
            get { return _realmAppPath; }
            set { _realmAppPath = value; }
        }

        public static string dbHost
        {
            get { return _dbHost; }
            set { _dbHost = value; }
        }

        public static string dbPort
        {
            get { return _dbPort; }
            set { _dbPort = value; }
        }

        public static string dbUser
        {
            get { return _dbUser; }
            set { _dbUser = value; }
        }

        public static string dbPassword
        {
            get { return _dbPassword; }
            set { _dbPassword = value; }
        }

        public static string mangosDatabaseName
        {
            get { return _mangosDatabaseName; }
            set { _mangosDatabaseName = value; }
        }

        public static string realmDatabaseName
        {
            get { return _realmDatabaseName; }
            set { _realmDatabaseName = value; }
        }

        public static string charDatabaseName
        {
            get { return _charDatabaseName; }
            set { _charDatabaseName = value; }
        }

        public static string mangosMOTD
        {
            get { return _mangosMOTD; }
            set { _mangosMOTD = value; }
        }
    
    }
}
