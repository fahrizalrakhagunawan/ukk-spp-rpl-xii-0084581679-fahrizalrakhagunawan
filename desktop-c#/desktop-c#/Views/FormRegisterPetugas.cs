using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop_c_.Config;
using MySql.Data.MySqlClient;

namespace desktop_c_
{
    public partial class FormRegisterPetugas : Form
    {
        public FormRegisterPetugas()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBoxPassword2.UseSystemPasswordChar = true;
            textBoxKonfirmasiPassword.UseSystemPasswordChar = true;

            comboBox1.Items.AddRange(new string[] { "petugas", "admin" });
            comboBox1.SelectedIndex = 0;
        }
        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            // 1. Validasi Dasar
            if (textBoxUsername1.Text == "" || textBoxNamaPetugas.Text == "" || textBoxPassword2.Text == "")
            {
                MessageBox.Show("Semua kolom wajib diisi!");
                return;
            }
            if (textBoxPassword2.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter!");
                return;
            }
            if (textBoxPassword2.Text != textBoxKonfirmasiPassword.Text)
            {
                MessageBox.Show("Konfirmasi password tidak sama!");
                return;
            }

            using (var conn = Koneksi.GetConnection())
            {
                if (conn == null) return;

                // 2. Cek Duplikasi Username
                var cmdCek = new MySqlCommand("SELECT COUNT(*) FROM petugas WHERE username = @user", conn);
                cmdCek.Parameters.AddWithValue("@user", textBoxUsername1.Text.Trim());

                if (Convert.ToInt32(cmdCek.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("Username sudah dipakai!");
                    return;
                }

                // 3. Hash Password & Insert
                string hash = BCrypt.Net.BCrypt.HashPassword(textBoxPassword2.Text);
                string sql = "INSERT INTO petugas (username, password, nama_petugas, level) VALUES (@user, @pass, @nama, @lvl)";

                var cmdSimpan = new MySqlCommand(sql, conn);
                cmdSimpan.Parameters.AddWithValue("@user", textBoxUsername1.Text.Trim());
                cmdSimpan.Parameters.AddWithValue("@pass", hash);
                cmdSimpan.Parameters.AddWithValue("@nama", textBoxNamaPetugas.Text.Trim());
                cmdSimpan.Parameters.AddWithValue("@lvl", comboBox1.Text);

                cmdSimpan.ExecuteNonQuery();
                MessageBox.Show("Petugas berhasil didaftarkan!");
                this.Close();
            }
        }

        private void buttonBatal1_Click(object sender, EventArgs e) => Application.Exit();
    }
}
