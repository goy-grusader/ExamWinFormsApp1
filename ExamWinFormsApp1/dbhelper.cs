using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace ExamWinFormsApp1
{
    internal class dbhelper
    {
        public static DataTable Execyteqery(string sql)
        {
            DataTable dt = new DataTable();
            string connstring = "host=localhost;database=test;username=postgres;password=postgres";
            using (NpgsqlConnection conn = new NpgsqlConnection(connstring))
            {
                conn.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn))
                    adapter.Fill(dt);
            }
            


                return dt;
        }
    }
}
