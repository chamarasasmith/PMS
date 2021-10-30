using System;
namespace PMS.Data
{
    public class PurchaseOrderDetails
    {
        public long PurchaseOrderDetailsID { get; set; }
        public long PurchaseOrderID { get; set; }
        public long PurchaseRequisitionID { get; set; }
        public int Status { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public PurchaseRequisition PurchaseRequisition { get; set; }
         
    }
}
