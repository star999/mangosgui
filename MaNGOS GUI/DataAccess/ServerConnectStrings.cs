using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaNGOS_GUI.DataAccess
{
    class ServerConnectStrings
    {

        public static string realmConnectString()
        {
            string cs;

            cs = "Server=" + ConfigProperties.dbHost + ";Port=" + ConfigProperties.dbPort +
                    ";Database=" + ConfigProperties.realmDatabaseName + ";User=" + ConfigProperties.dbUser +
                    ";Password=" + ConfigProperties.dbPassword + ";";

            return cs;
        }

        public static string mangosConnectString()
        {
            string cs;

            cs = "Server=" + ConfigProperties.dbHost + ";Port=" + ConfigProperties.dbPort +
                    ";Database=" + ConfigProperties.mangosDatabaseName + ";User=" + ConfigProperties.dbUser +
                    ";Password=" + ConfigProperties.dbPassword + ";";

            return cs;
        }

        public static string charConnectString()
        {
            string cs;

            cs = "Server=" + ConfigProperties.dbHost + ";Port=" + ConfigProperties.dbPort +
                    ";Database=" + ConfigProperties.charDatabaseName + ";User=" + ConfigProperties.dbUser +
                    ";Password=" + ConfigProperties.dbPassword + ";";

            return cs;
        }

    }
}
