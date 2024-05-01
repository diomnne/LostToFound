using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_Finals
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Signup s = new Signup();
            s.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e) 
        {

            string con = "server=127.0.0.1;uid=root;pwd=20181024;database=lost_and_found";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();

            string email = txt_email.Text.Trim();
            string password = txt_password.Text; //173, 21, 21

            if (string.IsNullOrEmpty(email))
            {
                txt_email.BorderColor = Color.FromArgb(173, 21, 21);
                MessageBox.Show("Email is a required field");

                txt_email.BorderColor = SystemColors.WindowFrame;
                return; 
            }

            if (string.IsNullOrEmpty(password))
            {
                txt_password.BorderColor = Color.FromArgb(173, 21, 21);
                MessageBox.Show("Incorrect password");

                txt_password.BorderColor = SystemColors.WindowFrame;
                return; 
            }


            string sql = "SELECT Email, Password FROM lost_and_found.user WHERE email=@Email AND password=@Password";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login Successful!");
                Home h = new Home(email);
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account does not exist");
            }

            reader.Close();
            conConn.Close();

            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
