using System;
namespace PMS.Data
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public string MeasureType { get; set; }
        public decimal Quantity { get; set; }
        public int Status { get; set; }

        public Supplier Supplier { get; set; }
        public Category Category { get; set; }

    }
}
