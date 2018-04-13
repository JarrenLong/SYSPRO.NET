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
namespace SYSPRO.NET.BusinessObjects.SORQDD {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QueryOption optionField;
        
        private QueryFilter filterField;
        
        /// <remarks/>
        public QueryOption Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilter Filter {
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOption {
        
        private QueryOptionReprint reprintField;
        
        private string documentDateField;
        
        private QueryOptionDateToCheck dateToCheckField;
        
        private QueryOptionIncludeSCT includeSCTField;
        
        private QueryOptionIncludeForms includeFormsField;
        
        private QueryOptionIncludeCustomerForms includeCustomerFormsField;
        
        private QueryOptionIncludeStockForms includeStockFormsField;
        
        private QueryOptionIncludeDetailForms includeDetailFormsField;
        
        private QueryOptionIncludeNotes includeNotesField;
        
        private QueryOptionIgnorePrintStatus ignorePrintStatusField;
        
        private QueryOptionReprintStatus reprintStatusField;
        
        private QueryOptionRoundMass roundMassField;
        
        private string roundMassDecsField;
        
        private QueryOptionRoundVolume roundVolumeField;
        
        private string roundVolumeDecsField;
        
        private QueryOptionCall3rdPartyForUsaTax call3rdPartyForUsaTaxField;
        
        private bool call3rdPartyForUsaTaxFieldSpecified;
        
        private string xslStylesheetField;
        
        public QueryOption() {
            this.reprintField = QueryOptionReprint.N;
            this.dateToCheckField = QueryOptionDateToCheck.N;
            this.includeSCTField = QueryOptionIncludeSCT.I;
            this.includeFormsField = QueryOptionIncludeForms.N;
            this.includeCustomerFormsField = QueryOptionIncludeCustomerForms.N;
            this.includeStockFormsField = QueryOptionIncludeStockForms.N;
            this.includeDetailFormsField = QueryOptionIncludeDetailForms.N;
            this.includeNotesField = QueryOptionIncludeNotes.N;
            this.ignorePrintStatusField = QueryOptionIgnorePrintStatus.N;
            this.reprintStatusField = QueryOptionReprintStatus.D;
            this.roundMassField = QueryOptionRoundMass.O;
            this.roundVolumeField = QueryOptionRoundVolume.O;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionReprint.N)]
        public QueryOptionReprint Reprint {
            get {
                return this.reprintField;
            }
            set {
                this.reprintField = value;
            }
        }
        
        /// <remarks/>
        public string DocumentDate {
            get {
                return this.documentDateField;
            }
            set {
                this.documentDateField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionDateToCheck.N)]
        public QueryOptionDateToCheck DateToCheck {
            get {
                return this.dateToCheckField;
            }
            set {
                this.dateToCheckField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSCT.I)]
        public QueryOptionIncludeSCT IncludeSCT {
            get {
                return this.includeSCTField;
            }
            set {
                this.includeSCTField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeForms.N)]
        public QueryOptionIncludeForms IncludeForms {
            get {
                return this.includeFormsField;
            }
            set {
                this.includeFormsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCustomerForms.N)]
        public QueryOptionIncludeCustomerForms IncludeCustomerForms {
            get {
                return this.includeCustomerFormsField;
            }
            set {
                this.includeCustomerFormsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeStockForms.N)]
        public QueryOptionIncludeStockForms IncludeStockForms {
            get {
                return this.includeStockFormsField;
            }
            set {
                this.includeStockFormsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeDetailForms.N)]
        public QueryOptionIncludeDetailForms IncludeDetailForms {
            get {
                return this.includeDetailFormsField;
            }
            set {
                this.includeDetailFormsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeNotes.N)]
        public QueryOptionIncludeNotes IncludeNotes {
            get {
                return this.includeNotesField;
            }
            set {
                this.includeNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIgnorePrintStatus.N)]
        public QueryOptionIgnorePrintStatus IgnorePrintStatus {
            get {
                return this.ignorePrintStatusField;
            }
            set {
                this.ignorePrintStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionReprintStatus.D)]
        public QueryOptionReprintStatus ReprintStatus {
            get {
                return this.reprintStatusField;
            }
            set {
                this.reprintStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionRoundMass.O)]
        public QueryOptionRoundMass RoundMass {
            get {
                return this.roundMassField;
            }
            set {
                this.roundMassField = value;
            }
        }
        
        /// <remarks/>
        public string RoundMassDecs {
            get {
                return this.roundMassDecsField;
            }
            set {
                this.roundMassDecsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionRoundVolume.O)]
        public QueryOptionRoundVolume RoundVolume {
            get {
                return this.roundVolumeField;
            }
            set {
                this.roundVolumeField = value;
            }
        }
        
        /// <remarks/>
        public string RoundVolumeDecs {
            get {
                return this.roundVolumeDecsField;
            }
            set {
                this.roundVolumeDecsField = value;
            }
        }
        
        /// <remarks/>
        public QueryOptionCall3rdPartyForUsaTax Call3rdPartyForUsaTax {
            get {
                return this.call3rdPartyForUsaTaxField;
            }
            set {
                this.call3rdPartyForUsaTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Call3rdPartyForUsaTaxSpecified {
            get {
                return this.call3rdPartyForUsaTaxFieldSpecified;
            }
            set {
                this.call3rdPartyForUsaTaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string XslStylesheet {
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
    public enum QueryOptionReprint {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionDateToCheck {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        D,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeSCT {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeForms {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeCustomerForms {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeStockForms {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeDetailForms {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeNotes {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIgnorePrintStatus {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionReprintStatus {
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionRoundMass {
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionRoundVolume {
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionCall3rdPartyForUsaTax {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryFilter {
        
        private QueryFilterBranch branchField;
        
        private QueryFilterCustomer customerField;
        
        private QueryFilterCustomerPo customerPoField;
        
        private QueryFilterDispatchNote dispatchNoteField;
        
        private QueryFilterOperator operatorField;
        
        private QueryFilterRequestedDate requestedDateField;
        
        private QueryFilterDispatchStatus dispatchStatusField;
        
        private QueryFilterDispatchInvoice dispatchInvoiceField;
        
        /// <remarks/>
        public QueryFilterBranch Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterCustomer Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterCustomerPo CustomerPo {
            get {
                return this.customerPoField;
            }
            set {
                this.customerPoField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterDispatchNote DispatchNote {
            get {
                return this.dispatchNoteField;
            }
            set {
                this.dispatchNoteField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterOperator Operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterRequestedDate RequestedDate {
            get {
                return this.requestedDateField;
            }
            set {
                this.requestedDateField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterDispatchStatus DispatchStatus {
            get {
                return this.dispatchStatusField;
            }
            set {
                this.dispatchStatusField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterDispatchInvoice DispatchInvoice {
            get {
                return this.dispatchInvoiceField;
            }
            set {
                this.dispatchInvoiceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryFilterBranch {
        
        private QueryFilterBranchFilterType filterTypeField;
        
        private string filterValueField;
        
        public QueryFilterBranch() {
            this.filterTypeField = QueryFilterBranchFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterBranchFilterType.A)]
        public QueryFilterBranchFilterType FilterType {
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
    public enum QueryFilterBranchFilterType {
        
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
    public partial class QueryFilterCustomer {
        
        private QueryFilterCustomerFilterType filterTypeField;
        
        private string filterValueField;
        
        public QueryFilterCustomer() {
            this.filterTypeField = QueryFilterCustomerFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterCustomerFilterType.A)]
        public QueryFilterCustomerFilterType FilterType {
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
    public enum QueryFilterCustomerFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryFilterCustomerPo {
        
        private QueryFilterCustomerPoFilterType filterTypeField;
        
        private string filterValueField;
        
        public QueryFilterCustomerPo() {
            this.filterTypeField = QueryFilterCustomerPoFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterCustomerPoFilterType.A)]
        public QueryFilterCustomerPoFilterType FilterType {
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
    public enum QueryFilterCustomerPoFilterType {
        
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
    public partial class QueryFilterDispatchNote {
        
        private QueryFilterDispatchNoteFilterType filterTypeField;
        
        private string filterValueField;
        
        public QueryFilterDispatchNote() {
            this.filterTypeField = QueryFilterDispatchNoteFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterDispatchNoteFilterType.A)]
        public QueryFilterDispatchNoteFilterType FilterType {
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
    public enum QueryFilterDispatchNoteFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryFilterOperator {
        
        private QueryFilterOperatorFilterType filterTypeField;
        
        public QueryFilterOperator() {
            this.filterTypeField = QueryFilterOperatorFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterOperatorFilterType.A)]
        public QueryFilterOperatorFilterType FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryFilterOperatorFilterType {
        
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
    public partial class QueryFilterRequestedDate {
        
        private QueryFilterRequestedDateFilterType filterTypeField;
        
        private string filterValueField;
        
        public QueryFilterRequestedDate() {
            this.filterTypeField = QueryFilterRequestedDateFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterRequestedDateFilterType.A)]
        public QueryFilterRequestedDateFilterType FilterType {
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
    public enum QueryFilterRequestedDateFilterType {
        
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
    public partial class QueryFilterDispatchStatus {
        
        private QueryFilterDispatchStatusFilterType filterTypeField;
        
        private string filterValueField;
        
        private string valueField;
        
        public QueryFilterDispatchStatus() {
            this.filterTypeField = QueryFilterDispatchStatusFilterType.L;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterDispatchStatusFilterType.L)]
        public QueryFilterDispatchStatusFilterType FilterType {
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryFilterDispatchStatusFilterType {
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryFilterDispatchInvoice {
        
        private QueryFilterDispatchInvoiceFilterType filterTypeField;
        
        private string filterValueField;
        
        private string valueField;
        
        public QueryFilterDispatchInvoice() {
            this.filterTypeField = QueryFilterDispatchInvoiceFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterDispatchInvoiceFilterType.A)]
        public QueryFilterDispatchInvoiceFilterType FilterType {
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryFilterDispatchInvoiceFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
}
