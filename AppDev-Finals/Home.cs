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
            newsFeed();
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
                flow1.Controls.Add(post);


            }
        }

        private void btn_home_Click_1(object sender, EventArgs e)
        {
            flow1.Controls.Clear();
            newsFeed();

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
                flow1.Controls.Add(post);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Report r = new Report();
            r.Show();
        }

        private void flow1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
