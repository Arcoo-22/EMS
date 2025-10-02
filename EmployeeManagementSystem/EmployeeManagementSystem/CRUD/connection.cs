using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.CRUD
{
    class connection
    {
        static string dbPath = @"C:\LOCALDB\EMS.accdb";
        public static string connString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};";

        public static OleDbConnection mysqldb()
        {
            return new OleDbConnection(connString);
        }
        public static OleDbConnection con = mysqldb();
    }
}
