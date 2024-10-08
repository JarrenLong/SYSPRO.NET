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
namespace SYSPRO.NET.BusinessObjects.SALQ76 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Filter {
        
        private InvoiceDate invoiceDateField;
        
        private TariffCode tariffCodeField;
        
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
        public TariffCode TariffCode {
            get {
                return this.tariffCodeField;
            }
            set {
                this.tariffCodeField = value;
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
        
        private InvoiceDateFilterType filterTypeField;
        
        private string filterValueField;
        
        public InvoiceDate() {
            this.filterTypeField = InvoiceDateFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(InvoiceDateFilterType.A)]
        public InvoiceDateFilterType FilterType {
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
    public enum InvoiceDateFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
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
    public partial class TariffCode {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        public TariffCode() {
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
    public enum ServiceEntries {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        O,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Option {
        
        private ReportSelection reportSelectionField;
        
        private bool reportSelectionFieldSpecified;
        
        private ReportType reportTypeField;
        
        private bool reportTypeFieldSpecified;
        
        private string monthEndPeriodField;
        
        private string yearEndPeriodField;
        
        private Reprint reprintField;
        
        private bool reprintFieldSpecified;
        
        private ReprintSinglePeriod reprintSinglePeriodField;
        
        private bool reprintSinglePeriodFieldSpecified;
        
        private string reprintPeriodMonthField;
        
        private string reprintPeriodYearField;
        
        private ServiceEntries serviceEntriesField;
        
        private bool serviceEntriesFieldSpecified;
        
        public Option() {
            this.reportSelectionField = ReportSelection.A;
            this.reportTypeField = ReportType.S;
            this.yearEndPeriodField = "C";
            this.reprintField = Reprint.N;
            this.reprintSinglePeriodField = ReprintSinglePeriod.N;
            this.reprintPeriodYearField = "C";
        }
        
        /// <remarks/>
        public ReportSelection ReportSelection {
            get {
                return this.reportSelectionField;
            }
            set {
                this.reportSelectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportSelectionSpecified {
            get {
                return this.reportSelectionFieldSpecified;
            }
            set {
                this.reportSelectionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ReportType ReportType {
            get {
                return this.reportTypeField;
            }
            set {
                this.reportTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportTypeSpecified {
            get {
                return this.reportTypeFieldSpecified;
            }
            set {
                this.reportTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string MonthEndPeriod {
            get {
                return this.monthEndPeriodField;
            }
            set {
                this.monthEndPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string YearEndPeriod {
            get {
                return this.yearEndPeriodField;
            }
            set {
                this.yearEndPeriodField = value;
            }
        }
        
        /// <remarks/>
        public Reprint Reprint {
            get {
                return this.reprintField;
            }
            set {
                this.reprintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReprintSpecified {
            get {
                return this.reprintFieldSpecified;
            }
            set {
                this.reprintFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ReprintSinglePeriod ReprintSinglePeriod {
            get {
                return this.reprintSinglePeriodField;
            }
            set {
                this.reprintSinglePeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReprintSinglePeriodSpecified {
            get {
                return this.reprintSinglePeriodFieldSpecified;
            }
            set {
                this.reprintSinglePeriodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ReprintPeriodMonth {
            get {
                return this.reprintPeriodMonthField;
            }
            set {
                this.reprintPeriodMonthField = value;
            }
        }
        
        /// <remarks/>
        public string ReprintPeriodYear {
            get {
                return this.reprintPeriodYearField;
            }
            set {
                this.reprintPeriodYearField = value;
            }
        }
        
        /// <remarks/>
        public ServiceEntries ServiceEntries {
            get {
                return this.serviceEntriesField;
            }
            set {
                this.serviceEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServiceEntriesSpecified {
            get {
                return this.serviceEntriesFieldSpecified;
            }
            set {
                this.serviceEntriesFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReportSelection {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        A,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReportType {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        D,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Reprint {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReprintSinglePeriod {
        
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
