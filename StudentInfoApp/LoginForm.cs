using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace StudentInfoApp
{
public partial class LoginForm : Form
    {
        public LoginForm() => InitializeComponent();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using var conn = new SQLiteConnection("Data Source=sis.db;Version=3;");
            conn.Open();

            var cmd = new SQLiteCommand(
                "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p", conn);
            cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login successful!");
                Hide();
                // Replace 'Form1' with your main form class name if different
                new HomeForm().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Application.Exit();
    }
}
