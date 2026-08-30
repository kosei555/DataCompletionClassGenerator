using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace DataCompletionClassGenerator.Class
{
    internal static class OdbcConnectionCreator
    {
        public static OdbcConnection CreateOdbcConection(string dsn,string uid,string pwd)
        {
            string connCmd = $"DSN={dsn};UID={uid};PWD={pwd}";
            return new OdbcConnection(connCmd);
        }
    }
}
