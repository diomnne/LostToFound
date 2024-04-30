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
            txt_itemname.Text = item.ItemName;
            txt_placefound.Text = item.PlaceFound;
            txt_itemtype.Text = item.Type;
            txt_datefound.Text = item.DateFound.ToString();
            txt_timefound.Text = item.TimeFound.ToString();
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
    }
}
