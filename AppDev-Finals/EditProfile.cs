using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppDev_Finals
{
    public partial class EditProfile : Form
    {
        Functions f = new Functions();
        Profile profile;
        User user;
        string email;

        private int UserID;
        private string Password;
        private int Position;
        private DateTime DateJoined;
        private Home home;
        public EditProfile(User user, Profile profile, Home home)
        {
            InitializeComponent();
            this.home = home;
            this.Show();
            this.UserID = user.UserID;
            this.profile = profile;
            this.user = user;
            txt_firstname.Text = user.FirstName;
            txt_lastname.Text = user.LastName;
            txt_email.Text = user.Email;

            SetImageFromByteArray1(profilepic, user.ProfilePicture);

        }

        
        public void SetImageFromByteArray1(PictureBox Image_cont, byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                    Image_cont.Image = image;
                }
            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            if (profilepic.Image != null) // Check if picture.Image exists
            {
                profilepic.Image.Save(stream, profilepic.Image.RawFormat);
            }

            return stream.GetBuffer();
        }

        private void btn_updateprofile_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editprofile_Click(object sender, EventArgs e)
        {
            int userID = UserID;
            string password = Password;
            int position = Position;
            DateTime dateJoined = DateJoined;

            string firstName = txt_firstname.Text;
            string lastName = txt_lastname.Text;
            string email = txt_email.Text;


            byte[] profilePicture = this.user.ProfilePicture;

            User user = new User(userID, firstName, lastName, email, password, position, profilePicture, dateJoined);

            f.updateUser(user);
            home.updateInfo();

            profile.updateProfileInfo();

            this.Close();
        }

        /*private void btn_editpfp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select Profile Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    byte[] imageData;
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, (int)fs.Length);
                    }




                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        System.Drawing.Image image = System.Drawing.Image.FromStream(ms);


                        profilepic.Image = image;
                    }


                    f.changeUserProfile(imageData, this.user.UserID);
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred (ChangeUserProfile): " + ex.Message);
                    MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }*/

        private void btn_editpfp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select Profile Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] imageData;
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, (int)fs.Length);
                    }

                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        using (System.Drawing.Image image = System.Drawing.Image.FromStream(ms))
                        {
                            profilepic.Image = image;
                        }
                    }

                    f.changeUserProfile(imageData, this.user.UserID);

                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("File not found: " + ex.Message);
                    MessageBox.Show("The selected file could not be found. Please try again.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ex)
                {
                    Console.WriteLine("An error occurred while reading the file: " + ex.Message);
                    MessageBox.Show("An error occurred while accessing the file. Please try again later.", "File Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) // Catch other general exceptions
                {
                    Console.WriteLine("An error occurred (ChangeUserProfile): " + ex.Message);
                    MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
