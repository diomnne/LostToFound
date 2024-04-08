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

            string email = txt_email.Text;
            string password = txt_password.Text;


            string sql = "SELECT email, password FROM lost_and_found.user WHERE email=@email AND password=@password";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login Successful!");
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }

            reader.Close();
            conConn.Close();

            
        }
    }
}
