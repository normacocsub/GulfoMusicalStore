using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class ConectionManager
    {
        public OracleConnection Connection;

        public ConectionManager(string connection)
        {
            Connection = new OracleConnection(connection);
        }

        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}
