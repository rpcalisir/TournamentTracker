using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Connector;
using TrackerLibrary.Enum;
using TrackerLibrary.Interface;

namespace TrackerLibrary.Helper
{
    public static class GlobalConfigHelper
    {
        //public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Determines which database  type to store data into
        /// </summary>
        /// <param name="database"></param>
        /// <param name="textFile"></param>
        public static void InitializeConnections(DatabaseType databaseType)
        {
            switch (databaseType)
            {
                case DatabaseType.Sql:
                    SqlConnector sqlConnector = new SqlConnector();
                    Connection = sqlConnector;
                    break;
                case DatabaseType.TextFile:
                    TextConnector textConnector = new TextConnector();
                    Connection = textConnector;
                    break;
                default:
                    throw new Exception("No valid database type");
            }

            //if (database)
            //{
            //    //TODO - Create SQL Connection
            //    SqlConnector sqlConnector = new SqlConnector();
            //    Connections.Add(sqlConnector);
            //}
            //if(textFile)
            //{
            //    //TODO - Create file connection
            //    TextConnector textConnector = new TextConnector();
            //    Connections.Add(textConnector);
            //}
        }

    }
}
