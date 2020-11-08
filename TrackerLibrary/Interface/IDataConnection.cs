using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Interface
{
    /// <summary>
    /// MySql, MsSql or Text File Connection implementation
    /// Opens the connection and saves the data into file or sql server
    /// </summary>
    public interface IDataConnection
    {
        Prize CreatePrize(Prize prize);
    }
}
