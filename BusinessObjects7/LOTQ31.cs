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
namespace SYSPRO.NET.BusinessObjects.LOTQ31 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Bin {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
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
    public partial class ExpiryDate {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
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
    public partial class Filter {
        
        private StockCode stockCodeField;
        
        private Warehouse warehouseField;
        
        private Lot lotField;
        
        private Bin binField;
        
        private ExpiryDate expiryDateField;
        
        private TransactionDate transactionDateField;
        
        /// <remarks/>
        public StockCode StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        public Warehouse Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public Lot Lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
            }
        }
        
        /// <remarks/>
        public Bin Bin {
            get {
                return this.binField;
            }
            set {
                this.binField = value;
            }
        }
        
        /// <remarks/>
        public ExpiryDate ExpiryDate {
            get {
                return this.expiryDateField;
            }
            set {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        public TransactionDate TransactionDate {
            get {
                return this.transactionDateField;
            }
            set {
                this.transactionDateField = value;
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
    public partial class StockCode {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
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
    public partial class Warehouse {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
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
    public partial class Lot {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
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
    public partial class TransactionDate {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
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
    public partial class Option {
        
        private object stkTopBottomField;
        
        private object stkNumberTopBottomField;
        
        private object stkBasedOnMeasureField;
        
        private string includeZeroOnHandField;
        
        private string printNarrationsField;
        
        private string archivedLotsField;
        
        private string includeIssuesField;
        
        private string includeSalesField;
        
        private string includeAdjustmentsField;
        
        private string includeTransfersField;
        
        private string includeReceiptsField;
        
        private string includeBinTransfersField;
        
        private string includeExpiryField;
        
        private string includeDispatchesField;
        
        private string includeCostChangesField;
        
        private string lotsOnHoldField;
        
        private object xslStylesheetField;
        
        /// <remarks/>
        public object StkTopBottom {
            get {
                return this.stkTopBottomField;
            }
            set {
                this.stkTopBottomField = value;
            }
        }
        
        /// <remarks/>
        public object StkNumberTopBottom {
            get {
                return this.stkNumberTopBottomField;
            }
            set {
                this.stkNumberTopBottomField = value;
            }
        }
        
        /// <remarks/>
        public object StkBasedOnMeasure {
            get {
                return this.stkBasedOnMeasureField;
            }
            set {
                this.stkBasedOnMeasureField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeZeroOnHand {
            get {
                return this.includeZeroOnHandField;
            }
            set {
                this.includeZeroOnHandField = value;
            }
        }
        
        /// <remarks/>
        public string PrintNarrations {
            get {
                return this.printNarrationsField;
            }
            set {
                this.printNarrationsField = value;
            }
        }
        
        /// <remarks/>
        public string ArchivedLots {
            get {
                return this.archivedLotsField;
            }
            set {
                this.archivedLotsField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeIssues {
            get {
                return this.includeIssuesField;
            }
            set {
                this.includeIssuesField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeSales {
            get {
                return this.includeSalesField;
            }
            set {
                this.includeSalesField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeAdjustments {
            get {
                return this.includeAdjustmentsField;
            }
            set {
                this.includeAdjustmentsField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeTransfers {
            get {
                return this.includeTransfersField;
            }
            set {
                this.includeTransfersField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeReceipts {
            get {
                return this.includeReceiptsField;
            }
            set {
                this.includeReceiptsField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeBinTransfers {
            get {
                return this.includeBinTransfersField;
            }
            set {
                this.includeBinTransfersField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeExpiry {
            get {
                return this.includeExpiryField;
            }
            set {
                this.includeExpiryField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeDispatches {
            get {
                return this.includeDispatchesField;
            }
            set {
                this.includeDispatchesField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeCostChanges {
            get {
                return this.includeCostChangesField;
            }
            set {
                this.includeCostChangesField = value;
            }
        }
        
        /// <remarks/>
        public string LotsOnHold {
            get {
                return this.lotsOnHoldField;
            }
            set {
                this.lotsOnHoldField = value;
            }
        }
        
        /// <remarks/>
        public object XslStylesheet {
            get {
                return this.xslStylesheetField;
            }
            set {
                this.xslStylesheetField = value;
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
    public partial class Query {
        
        private Option optionField;
        
        private Filter filterField;
        
        /// <remarks/>
        public Option Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
        
        /// <remarks/>
        public Filter Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum StkBasedOnMeasure {
        
        /// <remarks/>
        QONH,
        
        /// <remarks/>
        QREC,
        
        /// <remarks/>
        QSHP,
    }
}
