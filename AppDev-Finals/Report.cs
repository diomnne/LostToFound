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
        Dashboard dashboard = new Dashboard();
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

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            datePicker.MaxDate = DateTime.Now;
            timePicker.MaxDate = DateTime.Now;

            int itemID = 0;
            string itemName = txt_itemname.Text;
            string placeFound = txt_placefound.Text;
            string description = txt_description.Text;
            string category = (choice_lost.Checked) ? "Lost" : "Found";
            DateTime dateFound = datePicker.Value;
            DateTime timeFound = timePicker.Value;
            int claimStatus = 0;
            byte[] image = getPhoto();
            string reportedBy = txt_reportedBy.Text;

            bool flag = false;
            if (choice_found.Checked || choice_lost.Checked)
            {
                flag = true;
            }

            if (itemName != "" && placeFound != "" && flag && dateFound != null && timeFound != null && reportedBy != "")
            {
                Item item = new Item(itemID, itemName, category, placeFound, dateFound, timeFound, description, claimStatus, image, reportedBy);

                functions.submitReport(item);

                // Clear input fields for new report
                txt_itemname.Text = "";
                txt_placefound.Text = "";
                txt_description.Text = "";
                choice_lost.Checked = false;
                datePicker.Value = DateTime.Now;
                timePicker.Value = DateTime.Now;

                this.Close();
                dashboard.updateDashboardData();
                dashboard.addTable();
            }
            else
            {
                if (itemName == "" || placeFound == "" || reportedBy == "")
                {
                    MessageBox.Show("Please fill out the empty fields");
                }
                
                else if (!flag)
                {
                    MessageBox.Show("Please select a category");
                }

            }
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
