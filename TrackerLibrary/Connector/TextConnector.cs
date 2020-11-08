using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Interface;

namespace TrackerLibrary.Connector
{
    public class TextConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually saves into file.
        /// <summary>
        /// Saves a new prize to text file.
        /// </summary>
        /// <param name="prize"></param>
        /// <returns>The prize information, including the unique identifier.</returns>
        public Prize CreatePrize(Prize prize)
        {
            prize.Id = 2;
            return prize;
        }
    }
}
