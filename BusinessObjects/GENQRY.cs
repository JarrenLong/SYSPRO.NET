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
namespace SYSPRO.NET.BusinessObjects.GENQRY {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QueryKey keyField;
        
        private QueryOption optionField;
        
        /// <remarks/>
        public QueryKey Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public QueryOption Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryKey {
        
        private string ledgerCodeField;
        
        /// <remarks/>
        public string LedgerCode {
            get {
                return this.ledgerCodeField;
            }
            set {
                this.ledgerCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOption {
        
        private string ledgerCodePasswordField;
        
        private string currencyField;
        
        private string glYearField;
        
        private QueryOptionBudgetType budgetTypeField;
        
        private bool budgetTypeFieldSpecified;
        
        private QueryOptionAddSeparators addSeparatorsField;
        
        private QueryOptionIncludeCustomForms includeCustomFormsField;
        
        private QueryOptionIncludeTransactions includeTransactionsField;
        
        private QueryOptionTransactions transactionsField;
        
        private object xslStylesheetField;
        
        public QueryOption() {
            this.addSeparatorsField = QueryOptionAddSeparators.N;
            this.includeCustomFormsField = QueryOptionIncludeCustomForms.N;
            this.includeTransactionsField = QueryOptionIncludeTransactions.N;
        }
        
        /// <remarks/>
        public string LedgerCodePassword {
            get {
                return this.ledgerCodePasswordField;
            }
            set {
                this.ledgerCodePasswordField = value;
            }
        }
        
        /// <remarks/>
        public string Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
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
        public QueryOptionBudgetType BudgetType {
            get {
                return this.budgetTypeField;
            }
            set {
                this.budgetTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BudgetTypeSpecified {
            get {
                return this.budgetTypeFieldSpecified;
            }
            set {
                this.budgetTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionAddSeparators.N)]
        public QueryOptionAddSeparators AddSeparators {
            get {
                return this.addSeparatorsField;
            }
            set {
                this.addSeparatorsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCustomForms.N)]
        public QueryOptionIncludeCustomForms IncludeCustomForms {
            get {
                return this.includeCustomFormsField;
            }
            set {
                this.includeCustomFormsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeTransactions.N)]
        public QueryOptionIncludeTransactions IncludeTransactions {
            get {
                return this.includeTransactionsField;
            }
            set {
                this.includeTransactionsField = value;
            }
        }
        
        /// <remarks/>
        public QueryOptionTransactions Transactions {
            get {
                return this.transactionsField;
            }
            set {
                this.transactionsField = value;
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
    public enum QueryOptionBudgetType {
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        N,
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionAddSeparators {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeCustomForms {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeTransactions {
        
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
    public partial class QueryOptionTransactions {
        
        private string maxRowsToReturnField;
        
        private QueryOptionTransactionsSourceCode sourceCodeField;
        
        private bool sourceCodeFieldSpecified;
        
        private QueryOptionTransactionsStartAtKey startAtKeyField;
        
        private QueryOptionTransactionsDirection directionField;
        
        private bool directionFieldSpecified;
        
        private QueryOptionTransactionsFilter filterField;
        
        public QueryOptionTransactions() {
            this.maxRowsToReturnField = "100";
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute("100")]
        public string MaxRowsToReturn {
            get {
                return this.maxRowsToReturnField;
            }
            set {
                this.maxRowsToReturnField = value;
            }
        }
        
        /// <remarks/>
        public QueryOptionTransactionsSourceCode SourceCode {
            get {
                return this.sourceCodeField;
            }
            set {
                this.sourceCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SourceCodeSpecified {
            get {
                return this.sourceCodeFieldSpecified;
            }
            set {
                this.sourceCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public QueryOptionTransactionsStartAtKey StartAtKey {
            get {
                return this.startAtKeyField;
            }
            set {
                this.startAtKeyField = value;
            }
        }
        
        /// <remarks/>
        public QueryOptionTransactionsDirection Direction {
            get {
                return this.directionField;
            }
            set {
                this.directionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectionSpecified {
            get {
                return this.directionFieldSpecified;
            }
            set {
                this.directionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public QueryOptionTransactionsFilter Filter {
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
    public enum QueryOptionTransactionsSourceCode {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        
        /// <remarks/>
        AP,
        
        /// <remarks/>
        AR,
        
        /// <remarks/>
        SA,
        
        /// <remarks/>
        CS,
        
        /// <remarks/>
        IN,
        
        /// <remarks/>
        GR,
        
        /// <remarks/>
        AS,
        
        /// <remarks/>
        PA,
        
        /// <remarks/>
        WP,
        
        /// <remarks/>
        JE,
        
        /// <remarks/>
        PV,
        
        /// <remarks/>
        RV,
        
        /// <remarks/>
        IC,
        
        /// <remarks/>
        PE,
        
        /// <remarks/>
        AV,
        
        /// <remarks/>
        YE,
        
        /// <remarks/>
        HM,
        
        /// <remarks/>
        ST,
        
        /// <remarks/>
        AC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOptionTransactionsStartAtKey {
        
        private string periodField;
        
        private string lineField;
        
        public QueryOptionTransactionsStartAtKey() {
            this.periodField = "0";
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute("0")]
        public string Period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }
        
        /// <remarks/>
        public string Line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionTransactionsDirection {
        
        /// <remarks/>
        pagedown,
        
        /// <remarks/>
        pageup,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOptionTransactionsFilter {
        
        private QueryOptionTransactionsFilterSelectPeriods selectPeriodsField;
        
        /// <remarks/>
        public QueryOptionTransactionsFilterSelectPeriods SelectPeriods {
            get {
                return this.selectPeriodsField;
            }
            set {
                this.selectPeriodsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOptionTransactionsFilterSelectPeriods {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        private string valueField;
        
        public QueryOptionTransactionsFilterSelectPeriods() {
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}
