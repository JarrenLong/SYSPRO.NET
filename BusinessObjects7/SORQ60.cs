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
namespace SYSPRO.NET.BusinessObjects.SORQ60 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Branch {
        
        private BranchFilterType filterTypeField;
        
        private string filterValueField;
        
        public Branch() {
            this.filterTypeField = BranchFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(BranchFilterType.A)]
        public BranchFilterType FilterType {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum BranchFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Filter {
        
        private Branch branchField;
        
        /// <remarks/>
        public Branch Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeCommentLines {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeCompletedLines {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeDispatchedNotInvoiced {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeForward {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeInWarehouse {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeOpenBackorders {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeOpenOrders {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeReadyToInvoice {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeReleasedBackorders {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeSuspense {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeZeroProfitPercent {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Option {
        
        private IncludeOpenOrders includeOpenOrdersField;
        
        private bool includeOpenOrdersFieldSpecified;
        
        private IncludeOpenBackorders includeOpenBackordersField;
        
        private bool includeOpenBackordersFieldSpecified;
        
        private IncludeReleasedBackorders includeReleasedBackordersField;
        
        private bool includeReleasedBackordersFieldSpecified;
        
        private IncludeInWarehouse includeInWarehouseField;
        
        private bool includeInWarehouseFieldSpecified;
        
        private IncludeReadyToInvoice includeReadyToInvoiceField;
        
        private bool includeReadyToInvoiceFieldSpecified;
        
        private IncludeSuspense includeSuspenseField;
        
        private bool includeSuspenseFieldSpecified;
        
        private IncludeForward includeForwardField;
        
        private bool includeForwardFieldSpecified;
        
        private SummaryLineForOrders summaryLineForOrdersField;
        
        private bool summaryLineForOrdersFieldSpecified;
        
        private PrintStockDescription printStockDescriptionField;
        
        private bool printStockDescriptionFieldSpecified;
        
        private IncludeCompletedLines includeCompletedLinesField;
        
        private bool includeCompletedLinesFieldSpecified;
        
        private IncludeZeroProfitPercent includeZeroProfitPercentField;
        
        private bool includeZeroProfitPercentFieldSpecified;
        
        private IncludeDispatchedNotInvoiced includeDispatchedNotInvoicedField;
        
        private bool includeDispatchedNotInvoicedFieldSpecified;
        
        private IncludeCommentLines includeCommentLinesField;
        
        private bool includeCommentLinesFieldSpecified;
        
        private IncludeExcludedOrders includeExcludedOrdersField;
        
        private bool includeExcludedOrdersFieldSpecified;
        
        private ProfitMarginBasis profitMarginBasisField;
        
        private bool profitMarginBasisFieldSpecified;
        
        private DateSelection dateSelectionField;
        
        private bool dateSelectionFieldSpecified;
        
        private string fromDateField;
        
        private string toDateField;
        
        private ProfitMarginSource profitMarginSourceField;
        
        private bool profitMarginSourceFieldSpecified;
        
        private string profitLessThanField;
        
        private string profitGreaterThanField;
        
        private object xslStylesheetField;
        
        /// <remarks/>
        public IncludeOpenOrders IncludeOpenOrders {
            get {
                return this.includeOpenOrdersField;
            }
            set {
                this.includeOpenOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeOpenOrdersSpecified {
            get {
                return this.includeOpenOrdersFieldSpecified;
            }
            set {
                this.includeOpenOrdersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeOpenBackorders IncludeOpenBackorders {
            get {
                return this.includeOpenBackordersField;
            }
            set {
                this.includeOpenBackordersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeOpenBackordersSpecified {
            get {
                return this.includeOpenBackordersFieldSpecified;
            }
            set {
                this.includeOpenBackordersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeReleasedBackorders IncludeReleasedBackorders {
            get {
                return this.includeReleasedBackordersField;
            }
            set {
                this.includeReleasedBackordersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeReleasedBackordersSpecified {
            get {
                return this.includeReleasedBackordersFieldSpecified;
            }
            set {
                this.includeReleasedBackordersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeInWarehouse IncludeInWarehouse {
            get {
                return this.includeInWarehouseField;
            }
            set {
                this.includeInWarehouseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeInWarehouseSpecified {
            get {
                return this.includeInWarehouseFieldSpecified;
            }
            set {
                this.includeInWarehouseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeReadyToInvoice IncludeReadyToInvoice {
            get {
                return this.includeReadyToInvoiceField;
            }
            set {
                this.includeReadyToInvoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeReadyToInvoiceSpecified {
            get {
                return this.includeReadyToInvoiceFieldSpecified;
            }
            set {
                this.includeReadyToInvoiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeSuspense IncludeSuspense {
            get {
                return this.includeSuspenseField;
            }
            set {
                this.includeSuspenseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeSuspenseSpecified {
            get {
                return this.includeSuspenseFieldSpecified;
            }
            set {
                this.includeSuspenseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeForward IncludeForward {
            get {
                return this.includeForwardField;
            }
            set {
                this.includeForwardField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeForwardSpecified {
            get {
                return this.includeForwardFieldSpecified;
            }
            set {
                this.includeForwardFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public SummaryLineForOrders SummaryLineForOrders {
            get {
                return this.summaryLineForOrdersField;
            }
            set {
                this.summaryLineForOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SummaryLineForOrdersSpecified {
            get {
                return this.summaryLineForOrdersFieldSpecified;
            }
            set {
                this.summaryLineForOrdersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PrintStockDescription PrintStockDescription {
            get {
                return this.printStockDescriptionField;
            }
            set {
                this.printStockDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintStockDescriptionSpecified {
            get {
                return this.printStockDescriptionFieldSpecified;
            }
            set {
                this.printStockDescriptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeCompletedLines IncludeCompletedLines {
            get {
                return this.includeCompletedLinesField;
            }
            set {
                this.includeCompletedLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeCompletedLinesSpecified {
            get {
                return this.includeCompletedLinesFieldSpecified;
            }
            set {
                this.includeCompletedLinesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeZeroProfitPercent IncludeZeroProfitPercent {
            get {
                return this.includeZeroProfitPercentField;
            }
            set {
                this.includeZeroProfitPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeZeroProfitPercentSpecified {
            get {
                return this.includeZeroProfitPercentFieldSpecified;
            }
            set {
                this.includeZeroProfitPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeDispatchedNotInvoiced IncludeDispatchedNotInvoiced {
            get {
                return this.includeDispatchedNotInvoicedField;
            }
            set {
                this.includeDispatchedNotInvoicedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeDispatchedNotInvoicedSpecified {
            get {
                return this.includeDispatchedNotInvoicedFieldSpecified;
            }
            set {
                this.includeDispatchedNotInvoicedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeCommentLines IncludeCommentLines {
            get {
                return this.includeCommentLinesField;
            }
            set {
                this.includeCommentLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeCommentLinesSpecified {
            get {
                return this.includeCommentLinesFieldSpecified;
            }
            set {
                this.includeCommentLinesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeExcludedOrders IncludeExcludedOrders {
            get {
                return this.includeExcludedOrdersField;
            }
            set {
                this.includeExcludedOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeExcludedOrdersSpecified {
            get {
                return this.includeExcludedOrdersFieldSpecified;
            }
            set {
                this.includeExcludedOrdersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ProfitMarginBasis ProfitMarginBasis {
            get {
                return this.profitMarginBasisField;
            }
            set {
                this.profitMarginBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfitMarginBasisSpecified {
            get {
                return this.profitMarginBasisFieldSpecified;
            }
            set {
                this.profitMarginBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DateSelection DateSelection {
            get {
                return this.dateSelectionField;
            }
            set {
                this.dateSelectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSelectionSpecified {
            get {
                return this.dateSelectionFieldSpecified;
            }
            set {
                this.dateSelectionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string FromDate {
            get {
                return this.fromDateField;
            }
            set {
                this.fromDateField = value;
            }
        }
        
        /// <remarks/>
        public string ToDate {
            get {
                return this.toDateField;
            }
            set {
                this.toDateField = value;
            }
        }
        
        /// <remarks/>
        public ProfitMarginSource ProfitMarginSource {
            get {
                return this.profitMarginSourceField;
            }
            set {
                this.profitMarginSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfitMarginSourceSpecified {
            get {
                return this.profitMarginSourceFieldSpecified;
            }
            set {
                this.profitMarginSourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ProfitLessThan {
            get {
                return this.profitLessThanField;
            }
            set {
                this.profitLessThanField = value;
            }
        }
        
        /// <remarks/>
        public string ProfitGreaterThan {
            get {
                return this.profitGreaterThanField;
            }
            set {
                this.profitGreaterThanField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum SummaryLineForOrders {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum PrintStockDescription {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeExcludedOrders {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ProfitMarginBasis {
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        O,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DateSelection {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ProfitMarginSource {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        M,
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
}
