using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSPRO.NET.BusinessObjects.SORTCLDOC
{
    public partial class Bins
    {
        public Bins() { }

        public Bins(int unused)
            : this()
        {
            BinLocation = "";
            BinQuantity = "";
            BinUnits = "";
            BinPieces = "";
        }
    }

    public partial class Item
    {
        public Item(int unused)
            : this()
        {
            CreditNoteNumber = "";
            CreditReason = "";
            NonStockedLine = NonStockedLine.Y;
#if SYSPRO_API61
            NonStockedLineSpecified = true;
#endif
            StockCode = "";
            Description = "";
            Revision = "";
            Release = "";
            Warehouse = "";
            CustomerPartNumber = "";
            OrderQty = "";
            OrderUom = "";
            AllowZeroQty = AllowZeroQty.N;
#if SYSPRO_API61
            AllowZeroQtySpecified = true;
#endif
            Price = "";
            PriceUom = "";
            PriceCode = "";
            OrderUnits = "";
            OrderPieces = "";
#if SYSPRO_API61
            Serials = new Serials[1] { new Serials(0) };
#elif SYSPRO_API70
            Serials = new Serials(0);
#endif
            Lot = "";
#if SYSPRO_API61
            Bins = new Bins[1] { new Bins(0) };
#elif SYSPRO_API70
            Bins = new Bins(0);
#endif
            ProductClass = "";
            DiscPercent1 = "";
            DiscPercent2 = "";
            DiscPercent3 = "";
            DiscValue = "";
            DiscValFlag = DiscValFlag.Item;
#if SYSPRO_API61
            DiscValFlagSpecified = true;
#endif
            OverrideCalculatedDiscount = OverrideCalculatedDiscount.Item;
#if SYSPRO_API61
            OverrideCalculatedDiscountSpecified = true;
#endif
            CustRequestDate = "";
            CommissionCode = "";
            ShipDate = "";
            UserDefined = "";
            UnitMass = "";
            UnitVolume = "";
            StockTaxCode = "";
            StockNotTaxable = StockNotTaxable.Item;
#if SYSPRO_API61
            StockNotTaxableSpecified = true;
#endif
            StockFstCode = "";
            StockNotFstTaxable = StockNotFstTaxable.Item;
#if SYSPRO_API61
            StockNotFstTaxableSpecified = true;
#endif
            NsProductClass = "";
            NsUnitCost = "";
            eSignature = "";
        }
    }

    public partial class Serials
    {
        public Serials() { }

        public Serials(int unused)
            : this()
        {
            SerialNumber = "";
            SerialQuantity = "";
            SerialUnits = "";
            SerialPieces = "";
            SerialCreationDate = "";
            SerialExpiryDate = "";
            SerialScrapDate = "";
            SerialLocation = "";
        }
    }

    namespace Response
    {
        public class socreditnoteline
        {
            public Item Item { get; set; }
            public StatusOfItems StatusOfItems { get; set; }

            public socreditnoteline() { }
        }

        public class StatusOfItems
        {
            public string ItemsProcessed { get; set; }
            public string ItemsInvalid { get; set; }

            public StatusOfItems() { }
        }
        public class Item
        {
            public ValidationStatus ValidationStatus { get; set; }
            public string ItemNumber { get; set; }

            public Item() { }
        }

        public class ValidationStatus
        {
            public CreditNoteDetails CreditNoteDetails { get; set; }
            public String Status { get; set; }

            public ValidationStatus() { }
        }

        public class CreditNoteDetails
        {
            public string CreditNoteNumber { get; set; }

            public CreditNoteDetails() { }
        }
    }
}