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
namespace SYSPRO.NET.BusinessObjects.SALQ16 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Branch {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        public Branch() {
            this.filterTypeField = "A";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("A")]
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
    public partial class Customer {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        public Customer() {
            this.filterTypeField = "A";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("A")]
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
    public partial class CustomerClass {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        public CustomerClass() {
            this.filterTypeField = "A";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("A")]
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
        
        private InvoiceDate invoiceDateField;
        
        private Branch branchField;
        
        private GeographicArea geographicAreaField;
        
        private OrderType orderTypeField;
        
        private CustomerClass customerClassField;
        
        private SalesPerson salesPersonField;
        
        private Customer customerField;
        
        /// <remarks/>
        public InvoiceDate InvoiceDate {
            get {
                return this.invoiceDateField;
            }
            set {
                this.invoiceDateField = value;
            }
        }
        
        /// <remarks/>
        public Branch Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        public GeographicArea GeographicArea {
            get {
                return this.geographicAreaField;
            }
            set {
                this.geographicAreaField = value;
            }
        }
        
        /// <remarks/>
        public OrderType OrderType {
            get {
                return this.orderTypeField;
            }
            set {
                this.orderTypeField = value;
            }
        }
        
        /// <remarks/>
        public CustomerClass CustomerClass {
            get {
                return this.customerClassField;
            }
            set {
                this.customerClassField = value;
            }
        }
        
        /// <remarks/>
        public SalesPerson SalesPerson {
            get {
                return this.salesPersonField;
            }
            set {
                this.salesPersonField = value;
            }
        }
        
        /// <remarks/>
        public Customer Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
    public partial class InvoiceDate {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        public InvoiceDate() {
            this.filterTypeField = "A";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("A")]
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
    public partial class GeographicArea {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        public GeographicArea() {
            this.filterTypeField = "A";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("A")]
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
    public partial class OrderType {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        public OrderType() {
            this.filterTypeField = "A";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("A")]
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
    public partial class SalesPerson {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        public SalesPerson() {
            this.filterTypeField = "A";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("A")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum HighlightMissingInvoice {
        
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
    public enum NewPageAfterTotals {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Option {
        
        private ReportSequence reportSequenceField;
        
        private bool reportSequenceFieldSpecified;
        
        private string monthToPrintField;
        
        private string yearToPrintField;
        
        private TurnoverOption turnoverOptionField;
        
        private bool turnoverOptionFieldSpecified;
        
        private HighlightMissingInvoice highlightMissingInvoiceField;
        
        private bool highlightMissingInvoiceFieldSpecified;
        
        private NewPageAfterTotals newPageAfterTotalsField;
        
        private bool newPageAfterTotalsFieldSpecified;
        
        private PrintChargeLines printChargeLinesField;
        
        private bool printChargeLinesFieldSpecified;
        
        public Option() {
            this.reportSequenceField = ReportSequence.Item1;
            this.yearToPrintField = "C";
            this.turnoverOptionField = TurnoverOption.D;
            this.highlightMissingInvoiceField = HighlightMissingInvoice.Y;
            this.newPageAfterTotalsField = NewPageAfterTotals.N;
            this.printChargeLinesField = PrintChargeLines.Y;
        }
        
        /// <remarks/>
        public ReportSequence ReportSequence {
            get {
                return this.reportSequenceField;
            }
            set {
                this.reportSequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportSequenceSpecified {
            get {
                return this.reportSequenceFieldSpecified;
            }
            set {
                this.reportSequenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string MonthToPrint {
            get {
                return this.monthToPrintField;
            }
            set {
                this.monthToPrintField = value;
            }
        }
        
        /// <remarks/>
        public string YearToPrint {
            get {
                return this.yearToPrintField;
            }
            set {
                this.yearToPrintField = value;
            }
        }
        
        /// <remarks/>
        public TurnoverOption TurnoverOption {
            get {
                return this.turnoverOptionField;
            }
            set {
                this.turnoverOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TurnoverOptionSpecified {
            get {
                return this.turnoverOptionFieldSpecified;
            }
            set {
                this.turnoverOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public HighlightMissingInvoice HighlightMissingInvoice {
            get {
                return this.highlightMissingInvoiceField;
            }
            set {
                this.highlightMissingInvoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HighlightMissingInvoiceSpecified {
            get {
                return this.highlightMissingInvoiceFieldSpecified;
            }
            set {
                this.highlightMissingInvoiceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public NewPageAfterTotals NewPageAfterTotals {
            get {
                return this.newPageAfterTotalsField;
            }
            set {
                this.newPageAfterTotalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewPageAfterTotalsSpecified {
            get {
                return this.newPageAfterTotalsFieldSpecified;
            }
            set {
                this.newPageAfterTotalsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PrintChargeLines PrintChargeLines {
            get {
                return this.printChargeLinesField;
            }
            set {
                this.printChargeLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintChargeLinesSpecified {
            get {
                return this.printChargeLinesFieldSpecified;
            }
            set {
                this.printChargeLinesFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReportSequence {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum TurnoverOption {
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        M,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum PrintChargeLines {
        
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
