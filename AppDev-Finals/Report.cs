using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.IO;
using Guna.UI.WinForms;

namespace AppDev_Finals
{
    public partial class Report : Form
    {

        Functions functions = new Functions();
        public Report()
        {
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void btn_upload_Click_1(object sender, EventArgs e)
        {

            String imageLoc = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png| All Files(*.*)|*.*";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = ofd.FileName;

                    image1.ImageLocation = imageLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datePicker_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            string connection = "server=127.0.0.1;uid=root;pwd=20181024;database=lost_and_found";
            int itemID = 0;
            string itemName = txt_itemname.Text;
            string placeFound = txt_placefound.Text; 
            string description = txt_description.Text;
            string type = typePicker.SelectedItem.ToString();
            string category = (choice_lost.Checked) ? "Lost" : "Found";
            DateTime dateFound = datePicker.Value;
            DateTime timeFound = timePicker.Value;
            int claimStatus = 0;
            byte[] image = getPhoto();

            Item item = new Item(itemID, itemName, category, type, placeFound, dateFound, timeFound, description, claimStatus, image);

            functions.submitReport(item);

            MessageBox.Show("Lost/Found item report submitted successfully!");

            // Clear input fields for new report
            txt_itemname.Text = "";
            txt_placefound.Text = "";
            txt_description.Text = "";
            typePicker.SelectedIndex = 0;
            choice_lost.Checked = false;
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;

            this.Close();

        }

        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            if (image1.Image != null) // Check if picture.Image exists
            {
                image1.Image.Save(stream, image1.Image.RawFormat);
            }

            return stream.GetBuffer();
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
