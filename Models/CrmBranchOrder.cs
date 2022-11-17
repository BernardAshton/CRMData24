using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace CRM_MVC.Models
{
    public class BranchOrder
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual long BranchOrderLineID { get; set; }         // SOPOrderReturnLine.SOPOrderReturnLineID
        public virtual long BranchOrderID { get; set; }             // SOPOrderReturnLine.SOPOrderReturnID
        public virtual int OrderLineNo { get; set; }                // SOPOrderReturnLine.PrintSequenceNumber
        public virtual long SOPCancelledLineID { get; set; }        // SOPOrderCancelledLine.SOPCancelledLineID for any cancelled order lines
        public virtual long SOPDespatchReceiptLineID { get; set; }  // Latest Despatch record for this Order
        public virtual long SOPInvoiceCreditLineID { get; set; }    // Latest Invoice record for this Order
        public virtual string SLOrderNo { get; set; }               // SOPOrderReturn.DocumentNo
        public virtual string CustOrderNo { get; set; }             // SOPOrderReturn.CustomerDocumentNo
        public virtual DateTime? CustOrderDate { get; set; }        // SOPOrderReturn.DocumentDate
        public virtual int BranchID { get; set; }                   // SOPOrderReturnLine.AnalysisCode3
        public virtual string CustID { get; set; }                  // SOPOrderReturn.CustomerID
        public virtual string BDMUser { get; set; }                 // SOPOrderReturnLine.AnalysisCode1
        public virtual string ItemCode { get; set; }                // SOPOrderReturnLine.ItemCode
        public virtual string ItemDesc { get; set; }                // SOPOrderReturnLine.ItemDescription
        public virtual string ItemName { get; set; }                // StockItem.Name
        public virtual decimal OrderQuantity { get; set; }          // SOPOrderReturnLine.LineQuantity
        public virtual decimal UnitPrice { get; set; }              // SOPOrderReturnLine.UnitSellingPrice
        public virtual decimal LinePrice { get; set; }              // SOPOrderReturnLine.LineTotalValue
        public virtual string Notes { get; set; }                   // For any extra bits
        public DateTime? RequestedDeliveryDate { get; set; }        // SOPOrderReturnLine.RequestedDeliveryDate
        public DateTime? PromisedDeliveryDate { get; set; }         // SOPOrderReturnLine.PromisedDeliveryDate
        public virtual decimal DespatchReceiptQuantity { get; set; }// SOPOrderReturnLine.DespatchReceiptQuantity ** When these two match order = despatched
        public virtual decimal InvoiceCreditQuantity { get; set; }  // SOPOrderReturnLine.InvoiceCreditQuantity   **
        public virtual decimal DespatchQty { get; set; }            // SOPDespatchReceiptLine.DespatchReceiptQuantity
        public virtual decimal InvoiceQty { get; set; }             // SOPInvoiceCreditLine.InvoiceCreditQuantity
        public virtual DateTime CreateDate { get; set; }            // SOPOrderReturnLine.DateTimeCreated
        public virtual string CreateUser { get; set; }              // SOPOrderReturn.DocumentCreatedBy
        public virtual DateTime UpdateDate { get; set; }            // CRM Update Date
        public virtual string UpdateUser { get; set; }              // CRM Update User
                                                                    //     public Branch branch { get; set; }                          // Branch Record 08/12/15 Removed so that a BranchOrder can be created if the Branch does not exist
    }
    public class BranchOrderDBContext : DbContext
    {
        public virtual DbSet<BranchOrder> BranchOrders { get; set; }
    }
}
