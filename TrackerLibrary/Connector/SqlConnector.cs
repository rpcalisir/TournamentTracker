using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Interface;

namespace TrackerLibrary.Connector
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually saves to the database.
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="prize"></param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public Prize CreatePrize(Prize prize)
        {
            prize.Id = 1;
            return prize;
        }
    }
}
