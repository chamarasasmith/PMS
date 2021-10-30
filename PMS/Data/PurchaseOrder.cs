using System;
namespace PMS.Data
{
    public class PurchaseOrder
    {
        public long PurchaseOrderID { get; set; }
        public string PurchaseOrderNo { get; set; }
        public string Description { get; set; }
        public int SupplierID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByID { get; set; }

        public Supplier Supplier { get; set; }
        public User CreatedBy { get; set; }
    }
}
