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
namespace SYSPRO.NET.BusinessObjects.APSQ50 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum EntrySelectionBy {
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        E,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Filter {
        
        private LedgerMonthSelection ledgerMonthSelectionField;
        
        private LedgerYearSelection ledgerYearSelectionField;
        
        private LedgerEntriesGroupSelection ledgerEntriesGroupSelectionField;
        
        private GlJournalSelection glJournalSelectionField;
        
        private LedgerCodeSelection ledgerCodeSelectionField;
        
        /// <remarks/>
        public LedgerMonthSelection LedgerMonthSelection {
            get {
                return this.ledgerMonthSelectionField;
            }
            set {
                this.ledgerMonthSelectionField = value;
            }
        }
        
        /// <remarks/>
        public LedgerYearSelection LedgerYearSelection {
            get {
                return this.ledgerYearSelectionField;
            }
            set {
                this.ledgerYearSelectionField = value;
            }
        }
        
        /// <remarks/>
        public LedgerEntriesGroupSelection LedgerEntriesGroupSelection {
            get {
                return this.ledgerEntriesGroupSelectionField;
            }
            set {
                this.ledgerEntriesGroupSelectionField = value;
            }
        }
        
        /// <remarks/>
        public GlJournalSelection GlJournalSelection {
            get {
                return this.glJournalSelectionField;
            }
            set {
                this.glJournalSelectionField = value;
            }
        }
        
        /// <remarks/>
        public LedgerCodeSelection LedgerCodeSelection {
            get {
                return this.ledgerCodeSelectionField;
            }
            set {
                this.ledgerCodeSelectionField = value;
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
    public partial class LedgerMonthSelection {
        
        private LedgerMonthSelectionFilterType filterTypeField;
        
        private string filterValueField;
        
        public LedgerMonthSelection() {
            this.filterTypeField = LedgerMonthSelectionFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LedgerMonthSelectionFilterType.A)]
        public LedgerMonthSelectionFilterType FilterType {
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
    public enum LedgerMonthSelectionFilterType {
        
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
    public partial class LedgerYearSelection {
        
        private LedgerYearSelectionFilterType filterTypeField;
        
        private string filterValueField;
        
        public LedgerYearSelection() {
            this.filterTypeField = LedgerYearSelectionFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LedgerYearSelectionFilterType.A)]
        public LedgerYearSelectionFilterType FilterType {
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
    public enum LedgerYearSelectionFilterType {
        
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
    public partial class LedgerEntriesGroupSelection {
        
        private LedgerEntriesGroupSelectionFilterType filterTypeField;
        
        private string filterValueField;
        
        public LedgerEntriesGroupSelection() {
            this.filterTypeField = LedgerEntriesGroupSelectionFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LedgerEntriesGroupSelectionFilterType.A)]
        public LedgerEntriesGroupSelectionFilterType FilterType {
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
    public enum LedgerEntriesGroupSelectionFilterType {
        
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
    public partial class GlJournalSelection {
        
        private GlJournalSelectionFilterType filterTypeField;
        
        private string filterValueField;
        
        public GlJournalSelection() {
            this.filterTypeField = GlJournalSelectionFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(GlJournalSelectionFilterType.A)]
        public GlJournalSelectionFilterType FilterType {
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
    public enum GlJournalSelectionFilterType {
        
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
    public partial class LedgerCodeSelection {
        
        private LedgerCodeSelectionFilterType filterTypeField;
        
        private string filterValueField;
        
        public LedgerCodeSelection() {
            this.filterTypeField = LedgerCodeSelectionFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(LedgerCodeSelectionFilterType.A)]
        public LedgerCodeSelectionFilterType FilterType {
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
    public enum LedgerCodeSelectionFilterType {
        
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
    public partial class Option {
        
        private string currentGLMonthField;
        
        private string currentGLYearField;
        
        private ReportType reportTypeField;
        
        private bool reportTypeFieldSpecified;
        
        private EntrySelectionBy entrySelectionByField;
        
        private bool entrySelectionByFieldSpecified;
        
        private ReprintDistributionOption reprintDistributionOptionField;
        
        private bool reprintDistributionOptionFieldSpecified;
        
        private ReprintSequence reprintSequenceField;
        
        private bool reprintSequenceFieldSpecified;
        
        private XslStylesheet xslStylesheetField;
        
        /// <remarks/>
        public string CurrentGLMonth {
            get {
                return this.currentGLMonthField;
            }
            set {
                this.currentGLMonthField = value;
            }
        }
        
        /// <remarks/>
        public string CurrentGLYear {
            get {
                return this.currentGLYearField;
            }
            set {
                this.currentGLYearField = value;
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
        public EntrySelectionBy EntrySelectionBy {
            get {
                return this.entrySelectionByField;
            }
            set {
                this.entrySelectionByField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntrySelectionBySpecified {
            get {
                return this.entrySelectionByFieldSpecified;
            }
            set {
                this.entrySelectionByFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ReprintDistributionOption ReprintDistributionOption {
            get {
                return this.reprintDistributionOptionField;
            }
            set {
                this.reprintDistributionOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReprintDistributionOptionSpecified {
            get {
                return this.reprintDistributionOptionFieldSpecified;
            }
            set {
                this.reprintDistributionOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ReprintSequence ReprintSequence {
            get {
                return this.reprintSequenceField;
            }
            set {
                this.reprintSequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReprintSequenceSpecified {
            get {
                return this.reprintSequenceFieldSpecified;
            }
            set {
                this.reprintSequenceFieldSpecified = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReprintDistributionOption {
        
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
    public enum ReprintSequence {
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        L,
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
