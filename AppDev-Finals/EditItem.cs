using Guna.UI.WinForms;
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
    public partial class EditItem : Form
    {
        Functions f = new Functions();
        private int ItemID;
        private string ReportedBy;
        ManageItems manage;
        private User user;
        private Item item;
        public EditItem(Item item, ManageItems mg)
        {
            this.item = item;
            InitializeComponent();
            this.Show();
            this.ItemID = item.ItemID;
            this.ReportedBy = item.ReportedBy;
            this.manage = mg;

            txt_itemname.Text = item.ItemName;
            txt_placefound.Text = item.PlaceFound;
            //txt_email.Text = item.ReportedBy;
            datePicker.Value = item.DateFound;
            timePicker.Value = item.TimeFound;
            txt_description.Text = item.Description;

            if (item.Category == "Lost")
            {
                choice_lost.Checked = true;
            }
            else if (item.Category == "Found")
            {
                choice_found.Checked = true;
            }

            SetImageFromByteArray1(image1, item.Image);
            
            

        }

        public void SetImageFromByteArray1(PictureBox Image_cont, byte[] byteArray)
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

        private void ItemInfo_Load(object sender, EventArgs e)
        {

        }

        private void btn_editInfo_Click(object sender, EventArgs e)
        {
            int itemID = ItemID;
            string itemName = txt_itemname.Text;
            string placeFound = txt_placefound.Text;
            string description = txt_description.Text;
            string category = (choice_lost.Checked) ? "Lost" : "Found";
            DateTime dateFound = datePicker.Value;
            DateTime timeFound = timePicker.Value;
            int claimStatus = 0;
            byte[] image = this.item.Image;
            string email = ReportedBy;
            

            Item item = new Item(itemID, itemName, category, placeFound, dateFound, timeFound, description, claimStatus, image, email);
            f.updateReport(item);

            manage.addTable();
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
