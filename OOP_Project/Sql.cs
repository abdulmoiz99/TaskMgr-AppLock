using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Project
{
    public class Sql
    {
        public SqlConnection con = new SqlConnection(Sql.ReadCS());
        public static string userName = string.Empty;
        public static string ReadCS()
        {
            using (var streamReader = File.OpenText("SqlSettings.dat"))
            {
                var lines = streamReader.ReadToEnd();
                return lines;
            }
        }


    }
}
