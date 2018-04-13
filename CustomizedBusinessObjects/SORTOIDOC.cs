using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSPRO.NET.BusinessObjects.SORTOIDOC
{
    public partial class FreightLine
    {
        public FreightLine(int unused)
            : this()
        {
            this.CustomerPoLine = "";
            this.LineActionType = LineActionType.A;
            this.LineCancelCode = "";
            this.FreightValue = "";
            this.FreightCost = "";
            this.FreightTaxCode = "";
            this.FreightNotTaxable = FreightNotTaxable.Item;
            this.FreightNotTaxableSpecified = true;
            this.FreightFstCode = "";
            this.FreightNotFstTaxable = FreightNotFstTaxable.Item;
            this.FreightNotFstTaxableSpecified = true;
        }
    }

    public partial class CommentLine
    {
        public CommentLine(int unused)
            : this()
        {
            this.CustomerPoLine = "";
            this.LineActionType = LineActionType.A;
            this.Comment = "";
            this.AttachedLineNumber = "";
            this.CommentType = CommentType.Item;
            this.CommentTypeSpecified = true;
        }
    }

    public partial class StockLine
    {
        public StockLine(int unused)
            : this()
        {
            this.CustomerPoLine = "";
            this.LineActionType = LineActionType.A;
            this.LineCancelCode = "";
            this.StockCode = "";
            this.StockDescription = "";
            this.Warehouse = "";
            this.CustomersPartNumber = "";
            this.OrderQty = "";
            this.OrderUom = "";
            this.Price = "";
            this.PriceUom = "";
            this.PriceCode = "";
            this.AlwaysUsePriceEntered = AlwaysUsePriceEntered.Item;
            this.AlwaysUsePriceEnteredSpecified = true;
            this.Units = "";
            this.Pieces = "";
            this.ProductClass = "";
            this.LineDiscPercent1 = "";
            this.LineDiscPercent2 = "";
            this.LineDiscPercent3 = "";
            this.AlwaysUseDiscountEntered = AlwaysUseDiscountEntered.N;
            this.AlwaysUseDiscountEnteredSpecified = true;
            this.CustRequestDate = DateTime.Now.AddDays(7);
            this.CustRequestDateSpecified = true;
            this.LineDiscValue = "";
            this.NsProductClass = "";
            this.TradePromotionCodes = "";
            this.CommissionCode = "";
            this.LineShipDate = "";
            this.LineDiscValFlag = LineDiscValFlag.Item;
            this.LineDiscValFlagSpecified = true;
            this.OverrideCalculatedDiscount = null;
            this.UserDefined = "";
            this.NonStockedLine = NonStockedLine.Item;
            this.NonStockedLineSpecified = true;
            this.NsUnitCost = "";
            this.UnitMass = "";
            this.UnitVolume = "";
            this.StockTaxCode = "";
            this.StockNotTaxable = StockNotTaxable.Item;
            this.StockNotTaxableSpecified = true;
            this.StockFstCode = "";
            this.StockNotFstTaxable = StockNotFstTaxable.Item;
            this.StockNotFstTaxableSpecified = true;
            this.AllocationAction = AllocationAction.Item;
            this.AllocationActionSpecified = true;
            this.ConfigPrintInv = ConfigPrintInv.Item;
            this.ConfigPrintInvSpecified = true;
            this.ConfigPrintDel = ConfigPrintDel.Item;
            this.ConfigPrintDelSpecified = true;
            this.ConfigPrintAck = ConfigPrintAck.Item;
            this.ConfigPrintAckSpecified = true;
            this.TariffCode = "";
            this.LineMultiShipCode = "";
            this.SupplementaryUnitsFactor = "";
            this.ReserveStock = ReserveStock.Item;
            this.ReserveStockSpecified = true;
            this.ReserveStockRequestAllocs = ReserveStockRequestAllocs.Item;
            this.ReserveStockRequestAllocsSpecified = true;
        }
    }

    public partial class OrderHeader
    {
        public OrderHeader(int unused)
            : this()
        {
            this.CustomerPoNumber = "";
            this.OrderActionType = OrderActionType.A;
            this.OrderActionTypeSpecified = true;
            this.Customer = "";
            this.OrderDate = DateTime.Now;
            this.OrderDateSpecified = true;
            this.InvoiceTerms = "";
            this.Currency = "$";
            this.ShippingInstrs = "";
            this.CustomerName = "";
            this.ShipAddress1 = "";
            this.ShipAddress2 = "";
            this.ShipAddress3 = "";
            this.ShipAddress4 = "";
            this.ShipAddress5 = "";
            this.ShipPostalCode = "";
            this.Email = "";
            this.OrderDiscPercent1 = "";
            this.OrderDiscPercent2 = "";
            this.OrderDiscPercent3 = "";
            this.Warehouse = "";
            this.SpecialInstrs = "";
            this.SalesOrder = "";
            this.OrderType = "";
            this.Salesperson = "";
            this.Supplier = "";
            this.MultiShipCode = "";
            this.ShipAddressPerLine = ShipAddressPerLine.Item;
            this.ShipAddressPerLineSpecified = true;
            this.AlternateReference = "";
            this.Area = "";
            this.Branch = "";
            this.RequestedShipDate = DateTime.Now.AddDays(7);
            this.RequestedShipDateSpecified = true;
            this.OrderComments = new string[] { "" };
            this.Nationality = "";
            this.DeliveryTerms = "";
            this.TransactionNature = "";
            this.TransportMode = "";
            this.ProcessFlag = "";
            this.TaxExemptNumber = "";
            this.TaxExemptionStatus = TaxExemptionStatus.Item;
            this.TaxExemptionStatusSpecified = true;
            this.GstExemptNumber = "";
            this.GstExemptionStatus = GstExemptionStatus.Item;
            this.GstExemptionStatusSpecified = true;
            this.CompanyTaxNumber = "";
            this.CancelReasonCode = "";
            this.DocumentFormat = "";
            this.InvoiceWholeOrderOnly = InvoiceWholeOrderOnly.Item;
            this.InvoiceWholeOrderOnlySpecified = true;
            this.NewCustomerPoNumber = "";
            this.InvoiceNumberEntered = "";
            this.InvoiceDateEntered = ""; // DateTime.Now.ToString("yyyy-MM-dd");
            this.State = "";
            this.CountyZip = "";
            this.City = "";
            this.SalesOrderPromoQualifyAction = SalesOrderPromoQualifyAction.Item;
            this.SalesOrderPromoQualifyActionSpecified = true;
            this.SalesOrderPromoSelectAction = SalesOrderPromoSelectAction.Item;
            this.SalesOrderPromoSelectActionSpecified = true;
            this.GlobalTradePromotionCodes = "";
            this.eSignature = "";
        }
    }

    public partial class TransmissionHeader
    {
        public TransmissionHeader()
        {
            this.TransmissionReference = "";
            this.SenderCode = "";
            this.ReceiverCode = "";
            this.DatePrepared = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            this.DatePreparedSpecified = true;
            this.TimePrepared = DateTime.Now.ToShortTimeString();
        }

        public TransmissionHeader(int unused) : this() { }
    }

    namespace Rsp
    {
        public class Order
        {
            public string CustomerPoNumber { get; set; }
            public string SalesOrder { get; set; }
            public OrderActionType OrderActionType { get; set; }
        }
        public class SalesOrders
        {
            public TransmissionHeader TransmissionHeader { get; set; }
            public Order Order { get; set; }
        }
    }
}
