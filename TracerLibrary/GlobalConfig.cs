using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace TracerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } // Private set global config dışında kimse değiştiremez. ama herkes okur.

        public static void İnitializeConnection(DatabaseType db)
        {
            /// <summary>
            /// enum olduğu için switch kendisini otomatik oluşturuyor.
            /// <summary>
            //switch (db)
            //{
            //    case DatabaseType.Sql:
            //        break;
            //    case DatabaseType.TextFile:
            //        break;
            //    default:
            //        break;
            //}

            if (db == DatabaseType.Sql)
            {
                
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == DatabaseType.TextFile)
            {
                
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    
    }
}
