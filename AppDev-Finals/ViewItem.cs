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
    public partial class ViewItem : Form
    {
        public ViewItem(Item item)
        {
            InitializeComponent();
            this.Show();
            itemID.Text = item.ItemID.ToString();
            reportedby.Text = item.ReportedBy;
            itemname.Text = item.ItemName;
            category.Text = item.Category;
            placefound.Text = item.PlaceFound;
            date.Text = item.DateFound.ToString("MMMM dd, yyyy");
            time.Text = item.TimeFound.ToString("hh:mm tt");
            description.Text = item.Description;

            SetImageFromByteArray1(image1, item.Image);



        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

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


        private void panel5_Paint(object sender, PaintEventArgs e)
        {



        }
    }
}
