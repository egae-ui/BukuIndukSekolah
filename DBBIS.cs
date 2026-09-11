using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BukuIndukSekolah
{
    class DBBIS
    {
        public static MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1; username='root'; password=''; database='dbbis'");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;

        public static void crud(string sqlbis)
        {
            Console.WriteLine(sqlbis);
            ds.Tables.Clear();
            perintah = new MySqlCommand(sqlbis, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
    }
}
