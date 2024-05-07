using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev_Finals
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string PlaceFound { get; set; }
        public DateTime DateFound { get; set; }
        public DateTime TimeFound { get; set; }
        public string Description { get; set; }

        public int ClaimStatus { get; set; }

        public byte[] Image { get; set; }

        public string ReportedBy { get; set; } 
        

        public Item(int itemID, string itemName, string category, string placeFound, DateTime dateFound, DateTime timeFound, string description, int claimStatus, byte[] image, string reportedBy)
        {
            ItemID = itemID;
            ItemName = itemName;
            Category = category;
            PlaceFound = placeFound;
            DateFound = dateFound;
            TimeFound = timeFound;
            Description = description;
            ClaimStatus = claimStatus;
            this.Image = image; 
            ReportedBy = reportedBy;
        }

        public Item() { }   
    }


}
