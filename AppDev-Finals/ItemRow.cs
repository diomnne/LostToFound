using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_Finals
{
    public partial class ItemRow : UserControl
    {
        Item item;
        User user;
        public ItemRow(Item item)
        {
            InitializeComponent();
            this.item = item;
            itemID.Text = item.ItemID.ToString();
            itemName.Text = item.ItemName;
            category.Text = item.Category;
            email.Text = item.ReportedBy;
            location.Text = item.PlaceFound;
            datefound.Text = item.DateFound.ToString("MM-dd-yyyy") + ",";
            timefound.Text = item.TimeFound.ToString("hh:mm tt");

            itemName.AutoEllipsis = true;
            location.AutoEllipsis = true;

            if (item.ClaimStatus == 1)
            {
                status.Text = "Claimed/Returned";
                status.BackColor = Color.FromArgb(75, 143, 120); //red = 196, 94, 94 green = 75, 143, 120
            }
            else
            {
                status.Text = "Unclaimed/Missing";
                status.BackColor = Color.FromArgb(196, 94, 94);
            }
        }



        private void status_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
