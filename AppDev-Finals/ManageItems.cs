using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDev_Finals
{
    public partial class ManageItems : Form
    {
        Functions func = new Functions();
        List<Item> items = new List<Item>();
        public ManageItems()
        {
            InitializeComponent();
            addTable();
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        public void addTable()
        {
            itemsTable.Controls.Clear();
            items = func.getAllItems();

            foreach (Item item in items)
            {
                ManageRow data = new ManageRow(item, this);
                itemsTable.Controls.Add(data);
            }


        }


    }
}
