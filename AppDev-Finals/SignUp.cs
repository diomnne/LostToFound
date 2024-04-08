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
            
            string email = txt_email.Text;
            string password = txt_password.Text;

            txt_email.Text = "";
            txt_password.Text = "";
            string con = "server=127.0.0.1;uid=root;pwd=20181024;database=lost_and_found";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();

            string insertSql = "INSERT INTO lost_and_found.user  (email, password) VALUES (?, ?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);

            insertCmd.Parameters.AddWithValue("@email", email);
            insertCmd.Parameters.AddWithValue("@password", password);

            insertCmd.ExecuteNonQuery();

            conConn.Close();

            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
