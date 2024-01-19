using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace etudiantsoir
{
    internal class DBInteraction
    {
        static SqlConnection con;
        static SqlCommand cmd;
       static string sconn = "Data Source=MOI-PC\\SQLEXPRESS;Initial Catalog=isgasoir;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static void connect()
        {
             con = new SqlConnection(sconn);
            con.Open();
           cmd= con.CreateCommand();
            cmd.Connection = con;
        }

        public static void disconnect()
        {
            con.Close();
        }

        public static int Maj(string sql)
        {
            cmd.CommandText = sql;
            int nb = cmd.ExecuteNonQuery();
            return nb;
        }
        public static SqlDataReader select(string sql)
        {
            cmd.CommandText = sql;
            SqlDataReader rs = cmd.ExecuteReader();
            return rs;
        }
    }
}
