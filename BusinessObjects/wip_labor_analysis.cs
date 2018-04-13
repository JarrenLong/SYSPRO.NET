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
namespace SYSPRO.NET.BusinessObjects.wip_labor_analysis {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class EntryDate {
        
        private EntryDateFilterType filterTypeField;
        
        private string filterValueField;
        
        public EntryDate() {
            this.filterTypeField = EntryDateFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(EntryDateFilterType.A)]
        public EntryDateFilterType FilterType {
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
    public enum EntryDateFilterType {
        
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
    public partial class Filter {
        
        private EntryDate entryDateField;
        
        /// <remarks/>
        public EntryDate EntryDate {
            get {
                return this.entryDateField;
            }
            set {
                this.entryDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum FirstReport {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        H,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        K,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum FourthReport {
        
        /// <remarks/>
        Z,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        H,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        K,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        O,
        
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
    public partial class Option {
        
        private FirstReport firstReportField;
        
        private SecondReport secondReportField;
        
        private ThirdReport thirdReportField;
        
        private FourthReport fourthReportField;
        
        private ReportType reportTypeField;
        
        private PrintCostDetails printCostDetailsField;
        
        private XslStylesheet xslStylesheetField;
        
        /// <remarks/>
        public FirstReport FirstReport {
            get {
                return this.firstReportField;
            }
            set {
                this.firstReportField = value;
            }
        }
        
        /// <remarks/>
        public SecondReport SecondReport {
            get {
                return this.secondReportField;
            }
            set {
                this.secondReportField = value;
            }
        }
        
        /// <remarks/>
        public ThirdReport ThirdReport {
            get {
                return this.thirdReportField;
            }
            set {
                this.thirdReportField = value;
            }
        }
        
        /// <remarks/>
        public FourthReport FourthReport {
            get {
                return this.fourthReportField;
            }
            set {
                this.fourthReportField = value;
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
        public PrintCostDetails PrintCostDetails {
            get {
                return this.printCostDetailsField;
            }
            set {
                this.printCostDetailsField = value;
            }
        }
        
        /// <remarks/>
        public XslStylesheet XslStylesheet {
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
    public enum SecondReport {
        
        /// <remarks/>
        Z,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        H,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        K,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ThirdReport {
        
        /// <remarks/>
        Z,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        H,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        K,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReportType {
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum PrintCostDetails {
        
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
    public partial class XslStylesheet {
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
