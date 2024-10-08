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
namespace SYSPRO.NET.BusinessObjects.IMPQTROUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class TaxReturnReport {
        
        private TaxReturnReportSystemInformation systemInformationField;
        
        private TaxReturnReportQueryOptions queryOptionsField;
        
        private TaxReturnReportCompanyInformation companyInformationField;
        
        private TaxReturnReportItem[] itemsField;
        
        /// <remarks/>
        public TaxReturnReportSystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public TaxReturnReportQueryOptions QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        public TaxReturnReportCompanyInformation CompanyInformation {
            get {
                return this.companyInformationField;
            }
            set {
                this.companyInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable=false)]
        public TaxReturnReportItem[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TaxReturnReportSystemInformation {
        
        private string cssStyleField;
        
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
        
        private string localCurrencyField;
        
        private string localCurrencyDescField;
        
        private string glPrdPerYearField;
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
        private string operatorPrimaryRoleField;
        
        private double noOfDigitsField;
        
        private bool noOfDigitsFieldSpecified;
        
        private string decCharToUseField;
        
        /// <remarks/>
        public string CssStyle {
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
        public string LocalCurrency {
            get {
                return this.localCurrencyField;
            }
            set {
                this.localCurrencyField = value;
            }
        }
        
        /// <remarks/>
        public string LocalCurrencyDesc {
            get {
                return this.localCurrencyDescField;
            }
            set {
                this.localCurrencyDescField = value;
            }
        }
        
        /// <remarks/>
        public string GlPrdPerYear {
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
        public string OperatorPrimaryRole {
            get {
                return this.operatorPrimaryRoleField;
            }
            set {
                this.operatorPrimaryRoleField = value;
            }
        }
        
        /// <remarks/>
        public double NoOfDigits {
            get {
                return this.noOfDigitsField;
            }
            set {
                this.noOfDigitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoOfDigitsSpecified {
            get {
                return this.noOfDigitsFieldSpecified;
            }
            set {
                this.noOfDigitsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string DecCharToUse {
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
    public partial class TaxReturnReportQueryOptions {
        
        private string reprintField;
        
        private string taxPeriodField;
        
        private string taxYearField;
        
        private object taxPeriodToField;
        
        private object taxYearToField;
        
        private object taxCodesToOmitField;
        
        private object reportTypeField;
        
        private object reportSubmitField;
        
        /// <remarks/>
        public string Reprint {
            get {
                return this.reprintField;
            }
            set {
                this.reprintField = value;
            }
        }
        
        /// <remarks/>
        public string TaxPeriod {
            get {
                return this.taxPeriodField;
            }
            set {
                this.taxPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string TaxYear {
            get {
                return this.taxYearField;
            }
            set {
                this.taxYearField = value;
            }
        }
        
        /// <remarks/>
        public object TaxPeriodTo {
            get {
                return this.taxPeriodToField;
            }
            set {
                this.taxPeriodToField = value;
            }
        }
        
        /// <remarks/>
        public object TaxYearTo {
            get {
                return this.taxYearToField;
            }
            set {
                this.taxYearToField = value;
            }
        }
        
        /// <remarks/>
        public object TaxCodesToOmit {
            get {
                return this.taxCodesToOmitField;
            }
            set {
                this.taxCodesToOmitField = value;
            }
        }
        
        /// <remarks/>
        public object ReportType {
            get {
                return this.reportTypeField;
            }
            set {
                this.reportTypeField = value;
            }
        }
        
        /// <remarks/>
        public object ReportSubmit {
            get {
                return this.reportSubmitField;
            }
            set {
                this.reportSubmitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TaxReturnReportCompanyInformation {
        
        private object companyIdField;
        
        private object companyNameField;
        
        private object registrationNoField;
        
        private object taxRegistrationNoField;
        
        private object addr1Field;
        
        private object addr2Field;
        
        private object addr3Field;
        
        private object periodFromField;
        
        private object periodToField;
        
        /// <remarks/>
        public object CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        public object CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public object RegistrationNo {
            get {
                return this.registrationNoField;
            }
            set {
                this.registrationNoField = value;
            }
        }
        
        /// <remarks/>
        public object TaxRegistrationNo {
            get {
                return this.taxRegistrationNoField;
            }
            set {
                this.taxRegistrationNoField = value;
            }
        }
        
        /// <remarks/>
        public object Addr1 {
            get {
                return this.addr1Field;
            }
            set {
                this.addr1Field = value;
            }
        }
        
        /// <remarks/>
        public object Addr2 {
            get {
                return this.addr2Field;
            }
            set {
                this.addr2Field = value;
            }
        }
        
        /// <remarks/>
        public object Addr3 {
            get {
                return this.addr3Field;
            }
            set {
                this.addr3Field = value;
            }
        }
        
        /// <remarks/>
        public object PeriodFrom {
            get {
                return this.periodFromField;
            }
            set {
                this.periodFromField = value;
            }
        }
        
        /// <remarks/>
        public object PeriodTo {
            get {
                return this.periodToField;
            }
            set {
                this.periodToField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TaxReturnReportItem {
        
        private string vatBlockField;
        
        private string companyField;
        
        private string sourceField;
        
        private string jnlYearField;
        
        private string jnlMonthField;
        
        private string journalField;
        
        private string entryField;
        
        private string inputOutputField;
        
        private string taxValueField;
        
        private string vendorField;
        
        private string invoiceField;
        
        private string referenceField;
        
        private string invoiceDateField;
        
        private string invoiceValueField;
        
        private string nationalityField;
        
        private string ecMemberSalesField;
        
        private string ecAcquisitionField;
        
        private string submittedField;
        
        private string vatPeriodField;
        
        private string vatYearField;
        
        private string taxCodeField;
        
        private string vatDue1Field;
        
        private string vatDue2Field;
        
        private string vatDue4Field;
        
        private string totalValSales6Field;
        
        private string totalValPurch7Field;
        
        private string totalEcSales8Field;
        
        private string totalEcPurch9Field;
        
        /// <remarks/>
        public string VatBlock {
            get {
                return this.vatBlockField;
            }
            set {
                this.vatBlockField = value;
            }
        }
        
        /// <remarks/>
        public string Company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }
        
        /// <remarks/>
        public string Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        public string JnlYear {
            get {
                return this.jnlYearField;
            }
            set {
                this.jnlYearField = value;
            }
        }
        
        /// <remarks/>
        public string JnlMonth {
            get {
                return this.jnlMonthField;
            }
            set {
                this.jnlMonthField = value;
            }
        }
        
        /// <remarks/>
        public string Journal {
            get {
                return this.journalField;
            }
            set {
                this.journalField = value;
            }
        }
        
        /// <remarks/>
        public string Entry {
            get {
                return this.entryField;
            }
            set {
                this.entryField = value;
            }
        }
        
        /// <remarks/>
        public string InputOutput {
            get {
                return this.inputOutputField;
            }
            set {
                this.inputOutputField = value;
            }
        }
        
        /// <remarks/>
        public string TaxValue {
            get {
                return this.taxValueField;
            }
            set {
                this.taxValueField = value;
            }
        }
        
        /// <remarks/>
        public string Vendor {
            get {
                return this.vendorField;
            }
            set {
                this.vendorField = value;
            }
        }
        
        /// <remarks/>
        public string Invoice {
            get {
                return this.invoiceField;
            }
            set {
                this.invoiceField = value;
            }
        }
        
        /// <remarks/>
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        public string InvoiceDate {
            get {
                return this.invoiceDateField;
            }
            set {
                this.invoiceDateField = value;
            }
        }
        
        /// <remarks/>
        public string InvoiceValue {
            get {
                return this.invoiceValueField;
            }
            set {
                this.invoiceValueField = value;
            }
        }
        
        /// <remarks/>
        public string Nationality {
            get {
                return this.nationalityField;
            }
            set {
                this.nationalityField = value;
            }
        }
        
        /// <remarks/>
        public string EcMemberSales {
            get {
                return this.ecMemberSalesField;
            }
            set {
                this.ecMemberSalesField = value;
            }
        }
        
        /// <remarks/>
        public string EcAcquisition {
            get {
                return this.ecAcquisitionField;
            }
            set {
                this.ecAcquisitionField = value;
            }
        }
        
        /// <remarks/>
        public string Submitted {
            get {
                return this.submittedField;
            }
            set {
                this.submittedField = value;
            }
        }
        
        /// <remarks/>
        public string VatPeriod {
            get {
                return this.vatPeriodField;
            }
            set {
                this.vatPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string VatYear {
            get {
                return this.vatYearField;
            }
            set {
                this.vatYearField = value;
            }
        }
        
        /// <remarks/>
        public string TaxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }
        
        /// <remarks/>
        public string VatDue1 {
            get {
                return this.vatDue1Field;
            }
            set {
                this.vatDue1Field = value;
            }
        }
        
        /// <remarks/>
        public string VatDue2 {
            get {
                return this.vatDue2Field;
            }
            set {
                this.vatDue2Field = value;
            }
        }
        
        /// <remarks/>
        public string VatDue4 {
            get {
                return this.vatDue4Field;
            }
            set {
                this.vatDue4Field = value;
            }
        }
        
        /// <remarks/>
        public string TotalValSales6 {
            get {
                return this.totalValSales6Field;
            }
            set {
                this.totalValSales6Field = value;
            }
        }
        
        /// <remarks/>
        public string TotalValPurch7 {
            get {
                return this.totalValPurch7Field;
            }
            set {
                this.totalValPurch7Field = value;
            }
        }
        
        /// <remarks/>
        public string TotalEcSales8 {
            get {
                return this.totalEcSales8Field;
            }
            set {
                this.totalEcSales8Field = value;
            }
        }
        
        /// <remarks/>
        public string TotalEcPurch9 {
            get {
                return this.totalEcPurch9Field;
            }
            set {
                this.totalEcPurch9Field = value;
            }
        }
    }
}
