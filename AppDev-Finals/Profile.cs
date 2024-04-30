using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_Finals
{
    public partial class Profile : Form
    {
        Functions functions = new Functions();
        User user;
        string email;
        public Profile(string email)
        {
            InitializeComponent();

            this.email = email;
            user = functions.InitializeUser(email);
            lbl_fullname.Text = functions.InitializeUser(email).FirstName + " " + functions.InitializeUser(email).LastName;
            lbl_userID.Text = functions.InitializeUser(email).UserID.ToString();
            lbl_email.Text = functions.InitializeUser(email).Email;
            lbl_date.Text = functions.InitializeUser(email).DateJoined.ToString("MMMM dd, yyyy");

            int pos = functions.InitializeUser(email).Position;

            if(pos == 1)
            {
                lbl_position.Text = "Admin";
            }
            else
            {
                lbl_position.Text = "User";
            }

            setProfilePic(profilepic, user.ProfilePicture);
        }

        public void setProfilePic(PictureBox Image_cont, byte[] byteArray)
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

        private void btn_editprofile_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilepic_Click(object sender, EventArgs e)
        {

        }
    }
}
