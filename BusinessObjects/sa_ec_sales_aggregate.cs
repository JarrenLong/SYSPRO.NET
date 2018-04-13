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
namespace SYSPRO.NET.BusinessObjects.sa_ec_sales_aggregate {
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
        S,
        
        /// <remarks/>
        R,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class TariffCode {
        
        private TariffCodeFilterType filterTypeField;
        
        private string filterValueField;
        
        public TariffCode() {
            this.filterTypeField = TariffCodeFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(TariffCodeFilterType.A)]
        public TariffCodeFilterType FilterType {
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
    public enum TariffCodeFilterType {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum MonthEndPeriod {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
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
        
        private MonthEndPeriod monthEndPeriodField;
        
        private bool monthEndPeriodFieldSpecified;
        
        private string yearEndPeriodField;
        
        private Reprint reprintField;
        
        private bool reprintFieldSpecified;
        
        private ReprintSinglePeriod reprintSinglePeriodField;
        
        private bool reprintSinglePeriodFieldSpecified;
        
        private ReprintPeriodMonth reprintPeriodMonthField;
        
        private bool reprintPeriodMonthFieldSpecified;
        
        private ReprintPeriodYear reprintPeriodYearField;
        
        private bool reprintPeriodYearFieldSpecified;
        
        private ServiceEntries serviceEntriesField;
        
        private bool serviceEntriesFieldSpecified;
        
        public Option() {
            this.reportSelectionField = ReportSelection.A;
            this.reportTypeField = ReportType.S;
            this.yearEndPeriodField = "C";
            this.reprintField = Reprint.N;
            this.reprintSinglePeriodField = ReprintSinglePeriod.N;
            this.reprintPeriodYearField = ReprintPeriodYear.C;
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
        public MonthEndPeriod MonthEndPeriod {
            get {
                return this.monthEndPeriodField;
            }
            set {
                this.monthEndPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonthEndPeriodSpecified {
            get {
                return this.monthEndPeriodFieldSpecified;
            }
            set {
                this.monthEndPeriodFieldSpecified = value;
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
        public ReprintPeriodMonth ReprintPeriodMonth {
            get {
                return this.reprintPeriodMonthField;
            }
            set {
                this.reprintPeriodMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReprintPeriodMonthSpecified {
            get {
                return this.reprintPeriodMonthFieldSpecified;
            }
            set {
                this.reprintPeriodMonthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ReprintPeriodYear ReprintPeriodYear {
            get {
                return this.reprintPeriodYearField;
            }
            set {
                this.reprintPeriodYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReprintPeriodYearSpecified {
            get {
                return this.reprintPeriodYearFieldSpecified;
            }
            set {
                this.reprintPeriodYearFieldSpecified = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReprintPeriodMonth {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReprintPeriodYear {
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        P,
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
