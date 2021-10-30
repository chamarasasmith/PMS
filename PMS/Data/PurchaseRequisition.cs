using System;
namespace PMS.Data
{
    public class PurchaseRequisition
    {
        public long PurchaseRequisitionID { get; set; } 
        public string Description { get; set; }
        public int ItemID { get; set; }
        public decimal Quantity { get; set; }
        public int LocationID { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByID { get; set; }
         
        public User CreatedBy { get; set; }
        public Item Item { get; set; }
        public Location Location { get; set; } 
    }
}
