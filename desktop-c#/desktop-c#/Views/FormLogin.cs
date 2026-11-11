using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop_c_;
using desktop_c_.Config;
using desktop_c_.Models;
using desktop_c_.Views;
using MySql.Data.MySqlClient;

namespace desktop_c_.Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textBoxPassword.UseSystemPasswordChar = true;
            AcceptButton = buttonLogin;
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            // 1. Cek input kosong
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text)) { textBoxUsername.Focus(); return; }
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text)) { textBoxPassword.Focus(); return; }

            using (var conn = Koneksi.GetConnection())
            {
                if (conn == null) return;

                string sql = "SELECT * FROM petugas WHERE username = @user";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@user", textBoxUsername.Text.Trim());

                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read())
                    {
                        MessageBox.Show("Username tidak ditemukan!");
                        textBoxPassword.Clear();
                        textBoxUsername.Focus();
                        return;
                    }

                    string dbPass = rd["password"].ToString();
                    string inputPass = textBoxPassword.Text;

                    // 2. Cek password (BCrypt atau teks biasa dari seeder)
                    bool valid = dbPass.StartsWith("$2")
                        ? BCrypt.Net.BCrypt.Verify(inputPass, dbPass)
                        : (inputPass == dbPass);

                    if (!valid)
                    {
                        MessageBox.Show("Password salah!");
                        textBoxPassword.Clear();
                        textBoxPassword.Focus();
                        return;
                    }

                    // 3. Simpan session & buka Dashboard
                    SessionUser.SetSession(
                        Convert.ToInt32(rd["id_petugas"]),
                        rd["username"].ToString(),
                        rd["nama_petugas"].ToString(),
                        rd["level"].ToString()
                    );

                    new FormDashboard().Show();
                    this.Hide();
                }
            }
        }

        private void buttonBatal_Click(object sender, EventArgs e) => Application.Exit();

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormRegisterPetugas().ShowDialog();
        }
    }
}
