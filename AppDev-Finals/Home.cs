using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_Finals
{
    public partial class Home : Form
    {
        Functions functions = new Functions();
        User user;
        string email;
        public Home(string email)
        {
            this.user = user;
            InitializeComponent(); 
            this.email = email;
            
            user = functions.InitializeUser(email);
            
                firstname.Text = user.FirstName;
                lastname.Text = user.LastName;
            
            SetImageFromByteArray1(profilepic, user.ProfilePicture);


        }

        public void updateInfo()
        {
            user = functions.InitializeUser(email);
            firstname.Text = user.FirstName;
            lastname.Text = user.LastName;

            SetImageFromByteArray1(profilepic, user.ProfilePicture);
        }

        public void SetImageFromByteArray1(GunaCirclePictureBox Image_cont, byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    Image_cont.Image = image;
                }
            }
        }

        public void loadForm(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
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
            if(MessageBox.Show("Are you sure you want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            loadForm(new Dashboard());
 

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            loadForm(new Profile(email,this));
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            loadForm(new ManageItems());
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            loadForm(new Settings());
        }

        private void btn_dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(222, 196, 122);
        }

        private void btn_dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(69, 90, 100); 
        }

        private void profilepic_Click(object sender, EventArgs e)
        {
            loadForm(new Profile(email,this));
        }

        private void btn_addNewItem_Click(object sender, EventArgs e)
        {
            Report report = new Report(); 
            report.Show();
        }
    }
}
