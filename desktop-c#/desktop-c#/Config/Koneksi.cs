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
        string konfigurasi = "server=localhost;username=root;port=3306;database=db_spp_sekolah_xii;password=;";

        public void GetConnection()
        {
            MySqlConnection koneksi = new MySqlConnection(konfigurasi);
            try {
                koneksi.Open();

            }catch(Exception) 
            {
                MessageBox.Show("");
            }
            return;
        }
    }
}
