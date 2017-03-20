using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HuginWS
{
    #region Enums
    public enum PaymentTypes
    {
        Cash = 1,
        Check = 2,
        Credit = 3,
        Curr = 4
    }
    #endregion

    #region SalesInfo
    public class SalesInfo
    {
        public string OkcId = string.Empty;
        public string OkcPassword = string.Empty;
        public string TokenId = string.Empty;
        public int DocumentType;
        public int DocumentNo;
        public string InvoiceNo = string.Empty;
        public DateTime InvoiceDate = new DateTime();
        public int ZNo;
        public DateTime CreateDate = new DateTime();
        public string CashierNum = string.Empty;
        public List<ItemInfo> SaleItems = new List<ItemInfo>();
        public List<PaymentInfo> PayItems = new List<PaymentInfo>();
        public decimal SalesTotal;
        public List<string> FooterNotes = new List<string>();
        public CustomerInfo CustomerInfo = new CustomerInfo();
        public List<CustomTag> CustomTags = new List<CustomTag>();
        public string DiscountCode = string.Empty;
        public DiscountInfo DiscountInfo = new DiscountInfo();
        public int SalesPerson;
        public string CashInOutSerial = string.Empty;
        public string UserName = string.Empty;
        public string OperationCode = string.Empty;
        public string OrderCode = string.Empty;
    }

    public class ItemInfo
    {
        public decimal Quantity;
        public decimal Amount;
        public int PLUNo;
        public int DepartmentId;
        public decimal VatRate;
        public string Definition = string.Empty;
        public string Barcode = string.Empty;
        public string ReferenceCode = string.Empty;
        public DiscountInfo DiscountInfo = new DiscountInfo();
        public string Weighable = string.Empty;
        public decimal Price;
        public int SalesPerson;
        public List<string> ItemNotes = new List<string>();
        public string ProductSerialNum = string.Empty;
        public string OwnerCode;
        public int StockControl;
    }

    public class PaymentInfo
    {
        public decimal Amount;
        public PaymentTypes PaymentType;
        public int InstallmentNo;
        public int CreditId;
        public string Definition = string.Empty;
        public string ReferenceCode = string.Empty;
        public string IssuerId = string.Empty;
        public string CardNumber = string.Empty;
        public string AcquireId = string.Empty;
    }

    public class CustomerInfo
    {
        public string Name = string.Empty;
        public string ID = string.Empty;
    }

    public class DiscountInfo
    {
        public decimal DiscountTotal = 0;
        public int DiscountRate = 0;
        public List<string> DiscountNotes = new List<string>();
    }

    public class CustomTag
    {
        public int Type;//1-Sipariş,2-İndirim,3-ReferansKodu
        public string Value = string.Empty;
    }

    public class OrderInfo
    {
        public string OrderId;
        public string OrderTitle;
    }

    public class ListOrder
    {
        public List<OrderInfo> OrderList = new List<OrderInfo>();
    }
    #endregion
}