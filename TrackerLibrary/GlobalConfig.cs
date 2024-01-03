﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql) { 
            //TODO - create SQL connection
                SqlConnector sql = new SqlConnector();
                Connections = sql;
            }

            else if (db == DatabaseType.TextFile)
            {
                //TODO - create text file connection
                TextConnector text = new TextConnector();
                Connections = text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
