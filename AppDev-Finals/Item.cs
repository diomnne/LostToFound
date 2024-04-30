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

        //public int ReportedBy { get; set; } 
        

        public Item(int itemID, string itemName, string category, string type, string placeFound, DateTime dateFound, DateTime timeFound, string description, int claimStatus, byte[] image)
        {
            ItemID = itemID;
            ItemName = itemName;
            Category = category;
            Type = type;
            PlaceFound = placeFound;
            DateFound = dateFound;
            TimeFound = timeFound;
            Description = description;
            ClaimStatus = claimStatus;
            this.Image = image; 
        }

        public Item() { }   
    }


}
