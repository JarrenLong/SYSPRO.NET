﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 
namespace SYSPRO.NET.BusinessObjects.PORTSCDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostSupplierContract {
        
        private PostSupplierContractItem[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public PostSupplierContractItem[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostSupplierContractItem {
        
        private string supplierField;
        
        private string stockCodeField;
        
        private string contractField;
        
        private string priceReferenceField;
        
        private string purchasePriceField;
        
        private string priceUomField;
        
        private string discountCodeField;
        
        private string packSizeField;
        
        private string minimumQtyField;
        
        private string priceStartDateField;
        
        private string priceExpiryDateField;
        
        private string priceQuoteDateField;
        
        private string quoteLeadTimeField;
        
        private string freightChargesField;
        
        private string discPct1Field;
        
        private string discPct2Field;
        
        private string discPct3Field;
        
        private string minimumQtyUomField;
        
        private string priceCommentField;
        
        private string shippingInstrsField;
        
        private string freightCommentField;
        
        /// <remarks/>
        public string Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Contract {
            get {
                return this.contractField;
            }
            set {
                this.contractField = value;
            }
        }
        
        /// <remarks/>
        public string PriceReference {
            get {
                return this.priceReferenceField;
            }
            set {
                this.priceReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string PurchasePrice {
            get {
                return this.purchasePriceField;
            }
            set {
                this.purchasePriceField = value;
            }
        }
        
        /// <remarks/>
        public string PriceUom {
            get {
                return this.priceUomField;
            }
            set {
                this.priceUomField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountCode {
            get {
                return this.discountCodeField;
            }
            set {
                this.discountCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PackSize {
            get {
                return this.packSizeField;
            }
            set {
                this.packSizeField = value;
            }
        }
        
        /// <remarks/>
        public string MinimumQty {
            get {
                return this.minimumQtyField;
            }
            set {
                this.minimumQtyField = value;
            }
        }
        
        /// <remarks/>
        public string PriceStartDate {
            get {
                return this.priceStartDateField;
            }
            set {
                this.priceStartDateField = value;
            }
        }
        
        /// <remarks/>
        public string PriceExpiryDate {
            get {
                return this.priceExpiryDateField;
            }
            set {
                this.priceExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        public string PriceQuoteDate {
            get {
                return this.priceQuoteDateField;
            }
            set {
                this.priceQuoteDateField = value;
            }
        }
        
        /// <remarks/>
        public string QuoteLeadTime {
            get {
                return this.quoteLeadTimeField;
            }
            set {
                this.quoteLeadTimeField = value;
            }
        }
        
        /// <remarks/>
        public string FreightCharges {
            get {
                return this.freightChargesField;
            }
            set {
                this.freightChargesField = value;
            }
        }
        
        /// <remarks/>
        public string DiscPct1 {
            get {
                return this.discPct1Field;
            }
            set {
                this.discPct1Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscPct2 {
            get {
                return this.discPct2Field;
            }
            set {
                this.discPct2Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscPct3 {
            get {
                return this.discPct3Field;
            }
            set {
                this.discPct3Field = value;
            }
        }
        
        /// <remarks/>
        public string MinimumQtyUom {
            get {
                return this.minimumQtyUomField;
            }
            set {
                this.minimumQtyUomField = value;
            }
        }
        
        /// <remarks/>
        public string PriceComment {
            get {
                return this.priceCommentField;
            }
            set {
                this.priceCommentField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingInstrs {
            get {
                return this.shippingInstrsField;
            }
            set {
                this.shippingInstrsField = value;
            }
        }
        
        /// <remarks/>
        public string FreightComment {
            get {
                return this.freightCommentField;
            }
            set {
                this.freightCommentField = value;
            }
        }
    }
}
