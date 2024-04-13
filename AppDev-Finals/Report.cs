using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace AppDev_Finals
{
    public partial class Report : Form
    {
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
            string itemName = txt_itemname.Text;
            string placeFound = txt_placefound.Text; 
            string description = txt_description.Text;
            string type = typePicker.SelectedItem.ToString();
            string category = (choice_lost.Checked) ? "Lost" : "Found";
            DateTime dateFound = datePicker.Value;
            DateTime timeFound = timePicker.Value;
           

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string insertSql = @"INSERT INTO lost_and_found.item (itemName, placeFound, description, type, category, dateFound, timeFound) 
                     VALUES (@itemName, @placeFound, @description, @type, @category, @dateFound, @timeFound)";

                    MySqlCommand cmd = new MySqlCommand(insertSql, conn);

                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@placeFound", placeFound);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@dateFound", dateFound);
                    cmd.Parameters.AddWithValue("@timeFound", timeFound);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Lost/Found item report submitted successfully!");

                    // Clear input fields for new report
                    txt_itemname.Text = "";
                    txt_placefound.Text = "";
                    txt_description.Text = "";
                    typePicker.SelectedIndex = 0; 
                    choice_lost.Checked = false; 
                    datePicker.Value = DateTime.Now; 
                    timePicker.Value = DateTime.Now; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
