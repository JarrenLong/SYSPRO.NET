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
namespace SYSPRO.NET.BusinessObjects.GENQBA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum CheckGlJournalToSubModule {
        
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
    public enum CheckGlTransactionToJournal {
        
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
    public enum CheckNormalJournalEntries {
        
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
    public enum CheckUnpostedGlJournalEntries {
        
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
    public enum CheckUnpostedSubModuleEntries {
        
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
    public enum IncludeZeroValueEntries {
        
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
    public enum GlPeriod {
        
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
        
        private string glYearField;
        
        private GlPeriod glPeriodField;
        
        private bool glPeriodFieldSpecified;
        
        private ReportType reportTypeField;
        
        private bool reportTypeFieldSpecified;
        
        private CheckNormalJournalEntries checkNormalJournalEntriesField;
        
        private bool checkNormalJournalEntriesFieldSpecified;
        
        private CheckUnpostedGlJournalEntries checkUnpostedGlJournalEntriesField;
        
        private bool checkUnpostedGlJournalEntriesFieldSpecified;
        
        private CheckUnpostedSubModuleEntries checkUnpostedSubModuleEntriesField;
        
        private bool checkUnpostedSubModuleEntriesFieldSpecified;
        
        private CheckGlTransactionToJournal checkGlTransactionToJournalField;
        
        private bool checkGlTransactionToJournalFieldSpecified;
        
        private CheckGlJournalToSubModule checkGlJournalToSubModuleField;
        
        private bool checkGlJournalToSubModuleFieldSpecified;
        
        private IncludeZeroValueEntries includeZeroValueEntriesField;
        
        private bool includeZeroValueEntriesFieldSpecified;
        
        private XslStylesheet xslStylesheetField;
        
        /// <remarks/>
        public string GlYear {
            get {
                return this.glYearField;
            }
            set {
                this.glYearField = value;
            }
        }
        
        /// <remarks/>
        public GlPeriod GlPeriod {
            get {
                return this.glPeriodField;
            }
            set {
                this.glPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GlPeriodSpecified {
            get {
                return this.glPeriodFieldSpecified;
            }
            set {
                this.glPeriodFieldSpecified = value;
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
        public CheckNormalJournalEntries CheckNormalJournalEntries {
            get {
                return this.checkNormalJournalEntriesField;
            }
            set {
                this.checkNormalJournalEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckNormalJournalEntriesSpecified {
            get {
                return this.checkNormalJournalEntriesFieldSpecified;
            }
            set {
                this.checkNormalJournalEntriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CheckUnpostedGlJournalEntries CheckUnpostedGlJournalEntries {
            get {
                return this.checkUnpostedGlJournalEntriesField;
            }
            set {
                this.checkUnpostedGlJournalEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckUnpostedGlJournalEntriesSpecified {
            get {
                return this.checkUnpostedGlJournalEntriesFieldSpecified;
            }
            set {
                this.checkUnpostedGlJournalEntriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CheckUnpostedSubModuleEntries CheckUnpostedSubModuleEntries {
            get {
                return this.checkUnpostedSubModuleEntriesField;
            }
            set {
                this.checkUnpostedSubModuleEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckUnpostedSubModuleEntriesSpecified {
            get {
                return this.checkUnpostedSubModuleEntriesFieldSpecified;
            }
            set {
                this.checkUnpostedSubModuleEntriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CheckGlTransactionToJournal CheckGlTransactionToJournal {
            get {
                return this.checkGlTransactionToJournalField;
            }
            set {
                this.checkGlTransactionToJournalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckGlTransactionToJournalSpecified {
            get {
                return this.checkGlTransactionToJournalFieldSpecified;
            }
            set {
                this.checkGlTransactionToJournalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CheckGlJournalToSubModule CheckGlJournalToSubModule {
            get {
                return this.checkGlJournalToSubModuleField;
            }
            set {
                this.checkGlJournalToSubModuleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckGlJournalToSubModuleSpecified {
            get {
                return this.checkGlJournalToSubModuleFieldSpecified;
            }
            set {
                this.checkGlJournalToSubModuleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeZeroValueEntries IncludeZeroValueEntries {
            get {
                return this.includeZeroValueEntriesField;
            }
            set {
                this.includeZeroValueEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeZeroValueEntriesSpecified {
            get {
                return this.includeZeroValueEntriesFieldSpecified;
            }
            set {
                this.includeZeroValueEntriesFieldSpecified = value;
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
    public enum ReportType {
        
        /// <remarks/>
        D,
        
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
        
        /// <remarks/>
        public Option Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
    }
}
