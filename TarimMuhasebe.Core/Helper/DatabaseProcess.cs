using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarimMuhasebe.Core.Helper
{
    public static class DatabaseProcess
    {
        public static void DatabaseBackUp(string connectionString, string fileAddress)
        {
            string file = $"{fileAddress}/{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.sql";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }
    }
}
