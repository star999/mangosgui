using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaNGOS_GUI.MangosConfig
{
    class MangosConfigReader
    {
        //Contains mangosd.conf keys and values
        Hashtable values;

        public MangosConfigReader()
        {
            values = new Hashtable();
        }
        
        public MangosConfigReader(TextReader reader)
        {
            values = new Hashtable();
            configParser(reader);
        }

        public string getValue(string valueName)
        {
            if (values.ContainsKey(valueName))
            {
                return (string)values[valueName];
            }
            else
            {
                throw new Exception("Value does not exist.");
            }
        }

        public void setValue(string valueName, string value)
        {
            values[valueName] = value;
        }

        public void saveConfig(TextWriter writer)
        {
            IDictionaryEnumerator enumerator = values.GetEnumerator();

            writer.WriteLine("###############################################");
            writer.WriteLine("# This config was writen with the MaNGOS GUI. #");
            writer.WriteLine("###############################################");

            while (enumerator.MoveNext())
            {
                writer.WriteLine("{0}={1}", enumerator.Key, enumerator.Value);
            }
        }

        public void configParser(TextReader reader)
        {
            string ln, vn, v;

            while (null != (ln = reader.ReadLine()))
            {
                int y=0,z=0;

                while (ln.Length > y && Char.IsWhiteSpace(ln, y)) y++;
                if (ln.Length <= y)
                    continue;
                if (ln[y] == '#')
                    continue;

                z = ln.IndexOf('=', y);
                if (z == -1)
                    throw new Exception("Invalid Input.");
                vn = ln.Substring(y, z - 0).Trim();
                v = ln.Substring(z + 1).Trim();
                values[vn] = v;
            }
        }
    }
}
