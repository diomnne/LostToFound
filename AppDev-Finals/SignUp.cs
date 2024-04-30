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
            string firstname = txt_firstname.Text;
            string lastname = txt_lastname.Text;
            string email = txt_email.Text;
            string password = txt_password.Text;

            txt_firstname.Text = "";
            txt_lastname.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";

            string con = "server=127.0.0.1;uid=root;pwd=20181024;database=lost_and_found";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();

            string insertSql = "INSERT INTO lost_and_found.user  (firstname, lastname, email, password) VALUES (?, ?, ?, ?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);

            insertCmd.Parameters.AddWithValue("@Firstname", firstname);
            insertCmd.Parameters.AddWithValue("@Lastname", lastname);
            insertCmd.Parameters.AddWithValue("@Email", email);
            insertCmd.Parameters.AddWithValue("@Password", password);

            insertCmd.ExecuteNonQuery();

            conConn.Close();

            Home h = new Home(email);
            h.Show();
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

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
