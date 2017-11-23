using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingToSqlWithC
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=.\\SQLEXPRESS;Database=mydb;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT 'FIRST NAME', 'LAST NAME' FROM EMPLOYEESTABLE", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{1}, {0}", reader.GetString(0), reader.GetString(1));
            }
            reader.Close();
            conn.Close(); 

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }
    }
}
