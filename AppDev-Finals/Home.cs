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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }    

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_home_click(object sender, EventArgs e)
        {
            string con = "server=127.0.0.1;uid=root;pwd=20181024;database=lost_and_found";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();
            string sql = "SELECT * FROM lost_and_found.user;";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int ctr = 0;
                string name = (string)reader["email"];

                Post post = new Post(name);


            }
        }

        private void newsFeed()
        {
            string con = "server=127.0.0.1;uid=root;pwd=20181024;database=lost_and_found";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();
            string sql = "SELECT * FROM lost_and_found.user;";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int ctr = 0;
                string name = (string)reader["email"];

                Post post = new Post(name);
                
            }
        }


        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;

                if (sidebar.Width <= 60)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;

                if (sidebar.Width >= 220)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btn_sidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();

            if (MessageBox.Show("Are you sure you want to log out?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                l.Show();
                this.Hide();
            }
        }

    }
}
