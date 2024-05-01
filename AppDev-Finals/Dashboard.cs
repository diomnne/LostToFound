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

namespace AppDev_Finals
{
    public partial class Dashboard : Form
    {
        Functions func = new Functions();

        public List<Item> items;
        public List<Item> filteredItems;
        public Dashboard()
        {
            InitializeComponent();
            addTable();
            updateDashboardData();


        }

        private void updateDashboardData(string filter = null)
        {
            items = func.getAllItems();

            if (filter == "LostToday")
            {
                filteredItems = items.Where(item => item.Category == "Lost" && item.DateFound.Date == DateTime.Today).ToList();
            }
            else if (filter == "FoundToday")
            {
                filteredItems = items.Where(item => item.Category == "Found" && item.DateFound.Date == DateTime.Today).ToList();
            }
            else // No filter or invalid filter provided, use all items
            {
                filteredItems = items;
            }

            // Update counters based on the filtered list
            AllCtr.Text = items.Count().ToString();
            newLostCtr.Text = filteredItems.Count(item => item.Category == "Lost" && item.DateFound.Date == DateTime.Today).ToString();
            newFoundCtr.Text = filteredItems.Count(item => item.Category == "Found" && item.DateFound.Date == DateTime.Today).ToString();

            // Clear existing items from the table before adding filtered ones
            itemsTable.Controls.Clear();

            foreach (Item item in filteredItems)
            {
                ItemRow data = new ItemRow(item);
                itemsTable.Controls.Add(data);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        public void addTable()
        {
            items = func.getAllItems();

            foreach (Item item in items)
            {
                ItemRow data = new ItemRow(item);
                itemsTable.Controls.Add(data);
            }


        }

        private void itemsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            updateDashboardData();
        }

        private void btn_viewFound_Click(object sender, EventArgs e)
        {
            updateDashboardData("FoundToday");
        }

        private void btn_viewLost_Click(object sender, EventArgs e)
        {
            updateDashboardData("LostToday");
        }
    }
}