using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSPRO.NET.BusinessObjects.SORTCHDOC
{
    public partial class SOCreditNoteHeaderItem
    {
        public SOCreditNoteHeaderItem(int unused)
            : this()
        {
            Customer = "";
            CreditNoteNumber = "";
            CustomerPoNumber = "";
            CreditNoteDate = "";
            InvoiceNumber = "";
            Branch = "";
            Salesperson = "";
            ARInvoiceTerms = "";
            OrderType = "";
            PaymentMethod = SOCreditNoteHeaderItemPaymentMethod.CR;
            GeographicArea = "";
            AlternateReference = "";
            MultipleShipCode = "";
            ShipDate = "";
            ShipName = "";
            ShippingInstrs = "";
            ShipAddress1 = "";
            ShipAddress2 = "";
            ShipAddress3 = "";
            ShipAddress4 = "";
            ShipAddress5 = "";
            ShipPostalCode = "";
            Email = "";
            SpecialInstrs = "";
            OrderDiscPercent1 = "";
            OrderDiscPercent2 = "";
            OrderDiscPercent3 = "";
            Nationality = "";
            DeliveryTerms = "";
            TransactionNature = "";
            TransportMode = "";
            ProcessFlag = "";
            TaxExemptNumber = "";
            TaxExemptStatus = SOCreditNoteHeaderItemTaxExemptStatus.Item;
            TaxExemptStatusSpecified = true;
            GstExemptNumber = "";
            GstExemptStatus = SOCreditNoteHeaderItemGstExemptStatus.Item;
            GstExemptStatusSpecified = true;
            CompanyTaxNumber = "";
            State = "";
            CountyZip = "";
            City = "";
            OrderComments = "";
            DocumentFormat = "";
            eSignature = "";
        }
    }

    namespace Response
    {
        public class socreditnoteheader
        {
            public Item Item { get; set; }
            public StatusOfItems StatusOfItems { get; set; }

            public socreditnoteheader() { }
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
            public string Customer { get; set; }
            public string CreditNoteCreated { get; set; }

            public CreditNoteDetails() { }
        }
    }
}
