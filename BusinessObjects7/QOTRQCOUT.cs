﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.18020.
// 
namespace SYSPRO.NET.BusinessObjects.QOTRQCOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CustomerPoNumber {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class DetailLine {
        
        private string lineField;
        
        private string lineTypeField;
        
        private string stockcodeField;
        
        private string descriptionField;
        
        private string lineShipDateField;
        
        private string offerField;
        
        private bool offerQtyField;
        
        private string offerUnitPriceField;
        
        private string[] textField;
        
        /// <remarks/>
        public string Line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
        
        /// <remarks/>
        public string LineType {
            get {
                return this.lineTypeField;
            }
            set {
                this.lineTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Stockcode {
            get {
                return this.stockcodeField;
            }
            set {
                this.stockcodeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string LineShipDate {
            get {
                return this.lineShipDateField;
            }
            set {
                this.lineShipDateField = value;
            }
        }
        
        /// <remarks/>
        public string Offer {
            get {
                return this.offerField;
            }
            set {
                this.offerField = value;
            }
        }
        
        /// <remarks/>
        public bool OfferQty {
            get {
                return this.offerQtyField;
            }
            set {
                this.offerQtyField = value;
            }
        }
        
        /// <remarks/>
        public string OfferUnitPrice {
            get {
                return this.offerUnitPriceField;
            }
            set {
                this.offerUnitPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private Options optionsField;
        
        private DetailLine detailLineField;
        
        private string[] textField;
        
        /// <remarks/>
        public Options Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        public DetailLine DetailLine {
            get {
                return this.detailLineField;
            }
            set {
                this.detailLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Options {
        
        private string quotationField;
        
        private string offerSelectionField;
        
        private CustomerPoNumber customerPoNumberField;
        
        private string createSalesOrderField;
        
        private string createJobsField;
        
        private SalesOrderType salesOrderTypeField;
        
        private string buildPoRequisitionDetailsField;
        
        private string copyNotesToSalesOrderField;
        
        /// <remarks/>
        public string Quotation {
            get {
                return this.quotationField;
            }
            set {
                this.quotationField = value;
            }
        }
        
        /// <remarks/>
        public string OfferSelection {
            get {
                return this.offerSelectionField;
            }
            set {
                this.offerSelectionField = value;
            }
        }
        
        /// <remarks/>
        public CustomerPoNumber CustomerPoNumber {
            get {
                return this.customerPoNumberField;
            }
            set {
                this.customerPoNumberField = value;
            }
        }
        
        /// <remarks/>
        public string CreateSalesOrder {
            get {
                return this.createSalesOrderField;
            }
            set {
                this.createSalesOrderField = value;
            }
        }
        
        /// <remarks/>
        public string CreateJobs {
            get {
                return this.createJobsField;
            }
            set {
                this.createJobsField = value;
            }
        }
        
        /// <remarks/>
        public SalesOrderType SalesOrderType {
            get {
                return this.salesOrderTypeField;
            }
            set {
                this.salesOrderTypeField = value;
            }
        }
        
        /// <remarks/>
        public string BuildPoRequisitionDetails {
            get {
                return this.buildPoRequisitionDetailsField;
            }
            set {
                this.buildPoRequisitionDetailsField = value;
            }
        }
        
        /// <remarks/>
        public string CopyNotesToSalesOrder {
            get {
                return this.copyNotesToSalesOrderField;
            }
            set {
                this.copyNotesToSalesOrderField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SalesOrderType {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class QuotationDetails {
        
        private Item itemField;
        
        private string languageField;
        
        private string language2Field;
        
        private string cssStyleField;
        
        private string decFormatField;
        
        private string dateFormatField;
        
        private string roleField;
        
        private string versionField;
        
        /// <remarks/>
        public Item Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language2 {
            get {
                return this.language2Field;
            }
            set {
                this.language2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
