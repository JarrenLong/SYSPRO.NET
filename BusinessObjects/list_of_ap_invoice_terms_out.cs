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
namespace SYSPRO.NET.BusinessObjects.list_of_ap_invoice_terms_out {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QuerySystemInformation systemInformationField;
        
        private string queryOptionsField;
        
        private QueryDetail[] listOfAPInvoiceTermsField;
        
        private QueryTranslatedText translatedTextField;
        
        /// <remarks/>
        public QuerySystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public string QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Detail", IsNullable=false)]
        public QueryDetail[] ListOfAPInvoiceTerms {
            get {
                return this.listOfAPInvoiceTermsField;
            }
            set {
                this.listOfAPInvoiceTermsField = value;
            }
        }
        
        /// <remarks/>
        public QueryTranslatedText TranslatedText {
            get {
                return this.translatedTextField;
            }
            set {
                this.translatedTextField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QuerySystemInformation {
        
        private object cssStyleField;
        
        private string languageField;
        
        private string decFormatField;
        
        private string dateFormatField;
        
        private string roleField;
        
        private string versionField;
        
        private string companyIdField;
        
        private string companyNameField;
        
        private string operatorCodeField;
        
        private string operatorNameField;
        
        private string operatorGroupField;
        
        private string operatorEmailAddressField;
        
        private string operatorLocationField;
        
        private object localCurrencyField;
        
        private object localCurrencyDescField;
        
        private object glPrdPerYearField;
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
        private object operatorPrimaryRoleField;
        
        private object noOfDigitsField;
        
        private object decCharToUseField;
        
        /// <remarks/>
        public object CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        public string DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        public string DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorCode {
            get {
                return this.operatorCodeField;
            }
            set {
                this.operatorCodeField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorName {
            get {
                return this.operatorNameField;
            }
            set {
                this.operatorNameField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorGroup {
            get {
                return this.operatorGroupField;
            }
            set {
                this.operatorGroupField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorEmailAddress {
            get {
                return this.operatorEmailAddressField;
            }
            set {
                this.operatorEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorLocation {
            get {
                return this.operatorLocationField;
            }
            set {
                this.operatorLocationField = value;
            }
        }
        
        /// <remarks/>
        public object LocalCurrency {
            get {
                return this.localCurrencyField;
            }
            set {
                this.localCurrencyField = value;
            }
        }
        
        /// <remarks/>
        public object LocalCurrencyDesc {
            get {
                return this.localCurrencyDescField;
            }
            set {
                this.localCurrencyDescField = value;
            }
        }
        
        /// <remarks/>
        public object GlPrdPerYear {
            get {
                return this.glPrdPerYearField;
            }
            set {
                this.glPrdPerYearField = value;
            }
        }
        
        /// <remarks/>
        public string ReportDate {
            get {
                return this.reportDateField;
            }
            set {
                this.reportDateField = value;
            }
        }
        
        /// <remarks/>
        public string UseSeparatorOnReports {
            get {
                return this.useSeparatorOnReportsField;
            }
            set {
                this.useSeparatorOnReportsField = value;
            }
        }
        
        /// <remarks/>
        public string SeparatorToUse {
            get {
                return this.separatorToUseField;
            }
            set {
                this.separatorToUseField = value;
            }
        }
        
        /// <remarks/>
        public object OperatorPrimaryRole {
            get {
                return this.operatorPrimaryRoleField;
            }
            set {
                this.operatorPrimaryRoleField = value;
            }
        }
        
        /// <remarks/>
        public object NoOfDigits {
            get {
                return this.noOfDigitsField;
            }
            set {
                this.noOfDigitsField = value;
            }
        }
        
        /// <remarks/>
        public object DecCharToUse {
            get {
                return this.decCharToUseField;
            }
            set {
                this.decCharToUseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryDetail {
        
        private string tblApTerms_TermsCodeField;
        
        private string tblApTerms_DescriptionField;
        
        private string tblApTerms_DiscPctField;
        
        private string tblApTerms_DiscDaysField;
        
        private string tblApTerms_DiscFixField;
        
        private string tblApTerms_DiscMonthsField;
        
        private string tblApTerms_DueDaysField;
        
        private string tblApTerms_DueFixField;
        
        private string tblApTerms_DueMonthsField;
        
        /// <remarks/>
        public string TblApTerms_TermsCode {
            get {
                return this.tblApTerms_TermsCodeField;
            }
            set {
                this.tblApTerms_TermsCodeField = value;
            }
        }
        
        /// <remarks/>
        public string TblApTerms_Description {
            get {
                return this.tblApTerms_DescriptionField;
            }
            set {
                this.tblApTerms_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string TblApTerms_DiscPct {
            get {
                return this.tblApTerms_DiscPctField;
            }
            set {
                this.tblApTerms_DiscPctField = value;
            }
        }
        
        /// <remarks/>
        public string TblApTerms_DiscDays {
            get {
                return this.tblApTerms_DiscDaysField;
            }
            set {
                this.tblApTerms_DiscDaysField = value;
            }
        }
        
        /// <remarks/>
        public string TblApTerms_DiscFix {
            get {
                return this.tblApTerms_DiscFixField;
            }
            set {
                this.tblApTerms_DiscFixField = value;
            }
        }
        
        /// <remarks/>
        public string TblApTerms_DiscMonths {
            get {
                return this.tblApTerms_DiscMonthsField;
            }
            set {
                this.tblApTerms_DiscMonthsField = value;
            }
        }
        
        /// <remarks/>
        public string TblApTerms_DueDays {
            get {
                return this.tblApTerms_DueDaysField;
            }
            set {
                this.tblApTerms_DueDaysField = value;
            }
        }
        
        /// <remarks/>
        public string TblApTerms_DueFix {
            get {
                return this.tblApTerms_DueFixField;
            }
            set {
                this.tblApTerms_DueFixField = value;
            }
        }
        
        /// <remarks/>
        public string TblApTerms_DueMonths {
            get {
                return this.tblApTerms_DueMonthsField;
            }
            set {
                this.tblApTerms_DueMonthsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryTranslatedText {
        
        private string text_SequenceField;
        
        private string text_YesField;
        
        private string text_NoField;
        
        private string text_AllField;
        
        private string text_SingleField;
        
        private string text_RangeField;
        
        private string text_ListField;
        
        /// <remarks/>
        public string Text_Sequence {
            get {
                return this.text_SequenceField;
            }
            set {
                this.text_SequenceField = value;
            }
        }
        
        /// <remarks/>
        public string Text_Yes {
            get {
                return this.text_YesField;
            }
            set {
                this.text_YesField = value;
            }
        }
        
        /// <remarks/>
        public string Text_No {
            get {
                return this.text_NoField;
            }
            set {
                this.text_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Text_All {
            get {
                return this.text_AllField;
            }
            set {
                this.text_AllField = value;
            }
        }
        
        /// <remarks/>
        public string Text_Single {
            get {
                return this.text_SingleField;
            }
            set {
                this.text_SingleField = value;
            }
        }
        
        /// <remarks/>
        public string Text_Range {
            get {
                return this.text_RangeField;
            }
            set {
                this.text_RangeField = value;
            }
        }
        
        /// <remarks/>
        public string Text_List {
            get {
                return this.text_ListField;
            }
            set {
                this.text_ListField = value;
            }
        }
    }
}
