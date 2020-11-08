using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Connector;
using TrackerLibrary.Interface;

namespace TrackerLibrary.Helper
{
    public static class GlobalConfigHelper
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFile)
        {
            if (database)
            {
                //TODO - Create SQL Connection
                SqlConnector sqlConnector = new SqlConnector();
                Connections.Add(sqlConnector);
            }
            if(textFile)
            {
                //TODO - Create file connection
                TextConnector textConnector = new TextConnector();
                Connections.Add(textConnector);
            }
        }

    }
}
