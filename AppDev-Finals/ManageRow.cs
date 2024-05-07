using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppDev_Finals
{
    public partial class ManageRow : UserControl
    {
        Item item;
        ManageItems manage;
        Functions f = new Functions();
        public ManageRow(Item item, ManageItems manage)
        {
            InitializeComponent();
            this.item = item;
            this.manage = manage;

            this.item = item;
            itemID.Text = item.ItemID.ToString();
            itemName.Text = item.ItemName;
            category.Text = item.Category;
            reportedBy.Text = item.ReportedBy;
            datefound.Text = item.DateFound.ToString("MM-dd-yyyy") + ",";
            timefound.Text = item.TimeFound.ToString("hh:mm tt");

            if(item.ClaimStatus == 1)
            {
                btn_claimed.Visible = false;
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            ViewItem view = new ViewItem(item);
           


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditItem edit = new EditItem(item, manage);
        }

        private void btn_claimed_Click(object sender, EventArgs e)
        {
            item.ClaimStatus = 1;
            f.updateClaimStatus(item.ItemID, item.ClaimStatus);
            btn_claimed.Visible = false;

            MessageBox.Show("Marked as claimed!");
        }
    }
}
