using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDev_Finals.Properties;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppDev_Finals
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string firstname = txt_firstname.Text.Trim();
            string lastname = txt_lastname.Text.Trim();
            string email = txt_email.Text;
            string password = txt_password.Text;
            DateTime datejoined = DateTime.Now;
            int position = 0;

            if (string.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("Please enter your first name.");
                return;
            }

            else if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Please enter your last name.");
                return;
            }

            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.");
                return;
            }

            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return;
            }

            if (password != txt_confirmPass.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.");
                return;
            }

            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            txt_confirmPass.Text = "";

            string con = "server=127.0.0.1;uid=root;pwd=20181024;database=lost_and_found";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();

            string insertSql = "INSERT INTO lost_and_found.user  (firstname, lastname, email, password, datejoined, position) VALUES (?, ?, ?, ?, ?, ?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);

            insertCmd.Parameters.AddWithValue("@Firstname", firstname);
            insertCmd.Parameters.AddWithValue("@Lastname", lastname);
            insertCmd.Parameters.AddWithValue("@Email", email);
            insertCmd.Parameters.AddWithValue("@Password", password);
            insertCmd.Parameters.AddWithValue("@DateJoined", datejoined);
            insertCmd.Parameters.AddWithValue("@Position", position);

            insertCmd.ExecuteNonQuery();

            conConn.Close();

            MessageBox.Show("Your account has been created successfully!");
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_firstname_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_firstname_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_lastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_email.Focus();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_backToLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
