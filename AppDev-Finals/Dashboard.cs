using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        private string filter = null;
        public Dashboard()
        {
            InitializeComponent();
            addTable();
            updateDashboardData();

            filter_date.SelectedIndex = 0;
        }

        public void updateDashboardData(string filter = null, string sortOrder = "DESC")
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

            if (sortOrder == "ASC")
            {
                filteredItems = filteredItems.OrderBy(item => item.ItemID).ToList();
            }
            else
            {
                filteredItems = filteredItems.OrderByDescending(item => item.ItemID).ToList();
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
            filter = null;
            updateDashboardData(filter);
        }

        private void btn_viewFound_Click(object sender, EventArgs e)
        {
            filter = "FoundToday";
            updateDashboardData(filter);
        }

        private void btn_viewLost_Click(object sender, EventArgs e)
        {
            filter = "LostToday";
            updateDashboardData(filter);
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void filter_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSort = filter_date.SelectedItem.ToString() == "Newest first" ? "DESC" : "ASC";
            updateDashboardData(filter, selectedSort);
        }


        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateDashboardData();
        }

        
    }
}