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
namespace SYSPRO.NET.BusinessObjects.ARSQPDOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ARListofPostDatedChecks {
        
        private ARListofPostDatedChecksSystemInformation systemInformationField;
        
        private ARListofPostDatedChecksQueryOptions queryOptionsField;
        
        private ARListofPostDatedChecksPostDatedbyMonth[] postDatedbyMonthField;
        
        private ARListofPostDatedChecksCompanyTotals companyTotalsField;
        
        /// <remarks/>
        public ARListofPostDatedChecksSystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public ARListofPostDatedChecksQueryOptions QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PostDatedbyMonth")]
        public ARListofPostDatedChecksPostDatedbyMonth[] PostDatedbyMonth {
            get {
                return this.postDatedbyMonthField;
            }
            set {
                this.postDatedbyMonthField = value;
            }
        }
        
        /// <remarks/>
        public ARListofPostDatedChecksCompanyTotals CompanyTotals {
            get {
                return this.companyTotalsField;
            }
            set {
                this.companyTotalsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksSystemInformation {
        
        private ARListofPostDatedChecksSystemInformationCssStyle cssStyleField;
        
        private sbyte languageField;
        
        private bool languageFieldSpecified;
        
        private bool decFormatField;
        
        private bool decFormatFieldSpecified;
        
        private sbyte dateFormatField;
        
        private bool dateFormatFieldSpecified;
        
        private string versionField;
        
        private bool companyIdField;
        
        private bool companyIdFieldSpecified;
        
        private string companyNameField;
        
        private string operatorCodeField;
        
        private string operatorNameField;
        
        private string operatorGroupField;
        
        private ARListofPostDatedChecksSystemInformationOperatorEmailAddress operatorEmailAddressField;
        
        private ARListofPostDatedChecksSystemInformationOperatorLocation operatorLocationField;
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
        /// <remarks/>
        public ARListofPostDatedChecksSystemInformationCssStyle CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        public sbyte Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LanguageSpecified {
            get {
                return this.languageFieldSpecified;
            }
            set {
                this.languageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DecFormatSpecified {
            get {
                return this.decFormatFieldSpecified;
            }
            set {
                this.decFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public sbyte DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateFormatSpecified {
            get {
                return this.dateFormatFieldSpecified;
            }
            set {
                this.dateFormatFieldSpecified = value;
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
        public bool CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompanyIdSpecified {
            get {
                return this.companyIdFieldSpecified;
            }
            set {
                this.companyIdFieldSpecified = value;
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
        public ARListofPostDatedChecksSystemInformationOperatorEmailAddress OperatorEmailAddress {
            get {
                return this.operatorEmailAddressField;
            }
            set {
                this.operatorEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        public ARListofPostDatedChecksSystemInformationOperatorLocation OperatorLocation {
            get {
                return this.operatorLocationField;
            }
            set {
                this.operatorLocationField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksSystemInformationCssStyle {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksSystemInformationOperatorEmailAddress {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksSystemInformationOperatorLocation {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksQueryOptions {
        
        private string reportSequenceField;
        
        private string translated_ReportSequenceField;
        
        private string currencyField;
        
        private string customerFilterTypeField;
        
        private string translated_CustomerFilterTypeField;
        
        private ARListofPostDatedChecksQueryOptionsCustomerFilterValue customerFilterValueField;
        
        private string branchFilterTypeField;
        
        private string translated_BranchFilterTypeField;
        
        private ARListofPostDatedChecksQueryOptionsBranchFilterValue branchFilterValueField;
        
        private string salespersonFilterTypeField;
        
        private string translated_SalespersonFilterTypeField;
        
        private ARListofPostDatedChecksQueryOptionsSalespersonFilterValue salespersonFilterValueField;
        
        private string geographicAreaFilterTypeField;
        
        private string translated_GeographicAreaFilterTypeField;
        
        private ARListofPostDatedChecksQueryOptionsGeographicAreaFilterValue geographicAreaFilterValueField;
        
        private string postDatedChequeDateFilterTypeField;
        
        private string translated_PostDatedChequeDateFilterTypeField;
        
        private ARListofPostDatedChecksQueryOptionsPostDatedChequeDateFilterValue postDatedChequeDateFilterValueField;
        
        /// <remarks/>
        public string ReportSequence {
            get {
                return this.reportSequenceField;
            }
            set {
                this.reportSequenceField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ReportSequence {
            get {
                return this.translated_ReportSequenceField;
            }
            set {
                this.translated_ReportSequenceField = value;
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
        public string CustomerFilterType {
            get {
                return this.customerFilterTypeField;
            }
            set {
                this.customerFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_CustomerFilterType {
            get {
                return this.translated_CustomerFilterTypeField;
            }
            set {
                this.translated_CustomerFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ARListofPostDatedChecksQueryOptionsCustomerFilterValue CustomerFilterValue {
            get {
                return this.customerFilterValueField;
            }
            set {
                this.customerFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string BranchFilterType {
            get {
                return this.branchFilterTypeField;
            }
            set {
                this.branchFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_BranchFilterType {
            get {
                return this.translated_BranchFilterTypeField;
            }
            set {
                this.translated_BranchFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ARListofPostDatedChecksQueryOptionsBranchFilterValue BranchFilterValue {
            get {
                return this.branchFilterValueField;
            }
            set {
                this.branchFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string SalespersonFilterType {
            get {
                return this.salespersonFilterTypeField;
            }
            set {
                this.salespersonFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_SalespersonFilterType {
            get {
                return this.translated_SalespersonFilterTypeField;
            }
            set {
                this.translated_SalespersonFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ARListofPostDatedChecksQueryOptionsSalespersonFilterValue SalespersonFilterValue {
            get {
                return this.salespersonFilterValueField;
            }
            set {
                this.salespersonFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string GeographicAreaFilterType {
            get {
                return this.geographicAreaFilterTypeField;
            }
            set {
                this.geographicAreaFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_GeographicAreaFilterType {
            get {
                return this.translated_GeographicAreaFilterTypeField;
            }
            set {
                this.translated_GeographicAreaFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ARListofPostDatedChecksQueryOptionsGeographicAreaFilterValue GeographicAreaFilterValue {
            get {
                return this.geographicAreaFilterValueField;
            }
            set {
                this.geographicAreaFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string PostDatedChequeDateFilterType {
            get {
                return this.postDatedChequeDateFilterTypeField;
            }
            set {
                this.postDatedChequeDateFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_PostDatedChequeDateFilterType {
            get {
                return this.translated_PostDatedChequeDateFilterTypeField;
            }
            set {
                this.translated_PostDatedChequeDateFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ARListofPostDatedChecksQueryOptionsPostDatedChequeDateFilterValue PostDatedChequeDateFilterValue {
            get {
                return this.postDatedChequeDateFilterValueField;
            }
            set {
                this.postDatedChequeDateFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksQueryOptionsCustomerFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksQueryOptionsBranchFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksQueryOptionsSalespersonFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksQueryOptionsGeographicAreaFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksQueryOptionsPostDatedChequeDateFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksPostDatedbyMonth {
        
        private string monthCheckDatedField;
        
        private ARListofPostDatedChecksPostDatedbyMonthPostDatedCheck[] postDatedCheckField;
        
        /// <remarks/>
        public string MonthCheckDated {
            get {
                return this.monthCheckDatedField;
            }
            set {
                this.monthCheckDatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PostDatedCheck")]
        public ARListofPostDatedChecksPostDatedbyMonthPostDatedCheck[] PostDatedCheck {
            get {
                return this.postDatedCheckField;
            }
            set {
                this.postDatedCheckField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksPostDatedbyMonthPostDatedCheck {
        
        private string customerField;
        
        private object aRSMST_NameField;
        
        private string shortNameField;
        
        private double chequeField;
        
        private bool chequeFieldSpecified;
        
        private string availableDateField;
        
        private decimal amountField;
        
        private bool amountFieldSpecified;
        
        private string edited_AmountField;
        
        private string branchField;
        
        private string sALBRN_DescriptionField;
        
        private string classField;
        
        private string tBLARC_DescriptionField;
        
        private string areaField;
        
        private string sALARE_DescriptionField;
        
        private object salespersonField;
        
        private string sALSLS_NameField;
        
        /// <remarks/>
        public string Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }
        
        /// <remarks/>
        public object ARSMST_Name {
            get {
                return this.aRSMST_NameField;
            }
            set {
                this.aRSMST_NameField = value;
            }
        }
        
        /// <remarks/>
        public string ShortName {
            get {
                return this.shortNameField;
            }
            set {
                this.shortNameField = value;
            }
        }
        
        /// <remarks/>
        public double Cheque {
            get {
                return this.chequeField;
            }
            set {
                this.chequeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChequeSpecified {
            get {
                return this.chequeFieldSpecified;
            }
            set {
                this.chequeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string AvailableDate {
            get {
                return this.availableDateField;
            }
            set {
                this.availableDateField = value;
            }
        }
        
        /// <remarks/>
        public decimal Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AmountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Edited_Amount {
            get {
                return this.edited_AmountField;
            }
            set {
                this.edited_AmountField = value;
            }
        }
        
        /// <remarks/>
        public string Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        public string SALBRN_Description {
            get {
                return this.sALBRN_DescriptionField;
            }
            set {
                this.sALBRN_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        public string TBLARC_Description {
            get {
                return this.tBLARC_DescriptionField;
            }
            set {
                this.tBLARC_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Area {
            get {
                return this.areaField;
            }
            set {
                this.areaField = value;
            }
        }
        
        /// <remarks/>
        public string SALARE_Description {
            get {
                return this.sALARE_DescriptionField;
            }
            set {
                this.sALARE_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        public object Salesperson {
            get {
                return this.salespersonField;
            }
            set {
                this.salespersonField = value;
            }
        }
        
        /// <remarks/>
        public string SALSLS_Name {
            get {
                return this.sALSLS_NameField;
            }
            set {
                this.sALSLS_NameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksCompanyTotals {
        
        private ARListofPostDatedChecksCompanyTotalsMonthDueTotals[] totalsbyMonthDueField;
        
        private string reportCurrencyField;
        
        private object reportCurrencyDescField;
        
        private sbyte totalPostDatedChField;
        
        private bool totalPostDatedChFieldSpecified;
        
        private decimal totalField;
        
        private bool totalFieldSpecified;
        
        private string edited_TotalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MonthDueTotals", IsNullable=false)]
        public ARListofPostDatedChecksCompanyTotalsMonthDueTotals[] TotalsbyMonthDue {
            get {
                return this.totalsbyMonthDueField;
            }
            set {
                this.totalsbyMonthDueField = value;
            }
        }
        
        /// <remarks/>
        public string ReportCurrency {
            get {
                return this.reportCurrencyField;
            }
            set {
                this.reportCurrencyField = value;
            }
        }
        
        /// <remarks/>
        public object ReportCurrencyDesc {
            get {
                return this.reportCurrencyDescField;
            }
            set {
                this.reportCurrencyDescField = value;
            }
        }
        
        /// <remarks/>
        public sbyte TotalPostDatedCh {
            get {
                return this.totalPostDatedChField;
            }
            set {
                this.totalPostDatedChField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalPostDatedChSpecified {
            get {
                return this.totalPostDatedChFieldSpecified;
            }
            set {
                this.totalPostDatedChFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal Total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalSpecified {
            get {
                return this.totalFieldSpecified;
            }
            set {
                this.totalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Edited_Total {
            get {
                return this.edited_TotalField;
            }
            set {
                this.edited_TotalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ARListofPostDatedChecksCompanyTotalsMonthDueTotals {
        
        private string monthDueField;
        
        private decimal monthTotalField;
        
        private bool monthTotalFieldSpecified;
        
        private string edited_MonthTotalField;
        
        /// <remarks/>
        public string MonthDue {
            get {
                return this.monthDueField;
            }
            set {
                this.monthDueField = value;
            }
        }
        
        /// <remarks/>
        public decimal MonthTotal {
            get {
                return this.monthTotalField;
            }
            set {
                this.monthTotalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonthTotalSpecified {
            get {
                return this.monthTotalFieldSpecified;
            }
            set {
                this.monthTotalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Edited_MonthTotal {
            get {
                return this.edited_MonthTotalField;
            }
            set {
                this.edited_MonthTotalField = value;
            }
        }
    }
}
