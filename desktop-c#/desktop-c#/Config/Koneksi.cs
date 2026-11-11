using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace desktop_c_.Config
{
    internal class Koneksi
    {
        public static string sql = "server=localhost;username=root;port=3306;database=db_spp_sekolah_xii;password=;";

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(sql);
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Koneksi MySQL Gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
