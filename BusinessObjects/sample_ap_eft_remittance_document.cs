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
namespace SYSPRO.NET.BusinessObjects.sample_ap_eft_remittance_document {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Documents {
        
        private DocumentsDocument[] documentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Document")]
        public DocumentsDocument[] Document {
            get {
                return this.documentField;
            }
            set {
                this.documentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class DocumentsDocument {
        
        private DocumentsDocumentSystemInformation systemInformationField;
        
        private DocumentsDocumentHeaderData headerDataField;
        
        private DocumentsDocumentDetailLine[] detailDataField;
        
        private DocumentsDocumentTotalData totalDataField;
        
        /// <remarks/>
        public DocumentsDocumentSystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public DocumentsDocumentHeaderData HeaderData {
            get {
                return this.headerDataField;
            }
            set {
                this.headerDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DetailLine", IsNullable=false)]
        public DocumentsDocumentDetailLine[] DetailData {
            get {
                return this.detailDataField;
            }
            set {
                this.detailDataField = value;
            }
        }
        
        /// <remarks/>
        public DocumentsDocumentTotalData TotalData {
            get {
                return this.totalDataField;
            }
            set {
                this.totalDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class DocumentsDocumentSystemInformation {
        
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
        
        private string noOfDigitsField;
        
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
        public string NoOfDigits {
            get {
                return this.noOfDigitsField;
            }
            set {
                this.noOfDigitsField = value;
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
    public partial class DocumentsDocumentHeaderData {
        
        private object supplierNameField;
        
        private string supplierAddressOneField;
        
        private string supplierAddressTwoField;
        
        private string supplierAddressThreField;
        
        private string supplierAddressFourField;
        
        private string supplierAddressFiveField;
        
        private string supplierCodeField;
        
        private object supplierField;
        
        private string supplierTaxField;
        
        private string paymentDateField;
        
        private string paymentDateCymdField;
        
        private object bankField;
        
        private string bankNameField;
        
        private string companyNameField;
        
        private string companyAddressOneField;
        
        private string companyAddressTwoField;
        
        private string companyAddressThreeField;
        
        private string foreignCurrencyDescField;
        
        private string companyRegNumberField;
        
        private string companyTaxNumberField;
        
        private object remittanceNameField;
        
        private string remittanceAddrOneField;
        
        private string remittanceAddrTwoField;
        
        private string remittanceAddrThreeField;
        
        private string remittanceAddrFourField;
        
        private string remittanceAddrFiveField;
        
        private string remittancePostCodeField;
        
        private string telephoneNumberField;
        
        private string faxNumberField;
        
        private string contactNameField;
        
        private string emailAddressField;
        
        private string remittanceFaxNumberField;
        
        private string remittanceContactNaField;
        
        private string remittanceEmailField;
        
        private string userDefinedFieldAField;
        
        private string userDefinedFieldBField;
        
        private string withholdingTaxField;
        
        /// <remarks/>
        public object SupplierName {
            get {
                return this.supplierNameField;
            }
            set {
                this.supplierNameField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierAddressOne {
            get {
                return this.supplierAddressOneField;
            }
            set {
                this.supplierAddressOneField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierAddressTwo {
            get {
                return this.supplierAddressTwoField;
            }
            set {
                this.supplierAddressTwoField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierAddressThre {
            get {
                return this.supplierAddressThreField;
            }
            set {
                this.supplierAddressThreField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierAddressFour {
            get {
                return this.supplierAddressFourField;
            }
            set {
                this.supplierAddressFourField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierAddressFive {
            get {
                return this.supplierAddressFiveField;
            }
            set {
                this.supplierAddressFiveField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierCode {
            get {
                return this.supplierCodeField;
            }
            set {
                this.supplierCodeField = value;
            }
        }
        
        /// <remarks/>
        public object Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierTax {
            get {
                return this.supplierTaxField;
            }
            set {
                this.supplierTaxField = value;
            }
        }
        
        /// <remarks/>
        public string PaymentDate {
            get {
                return this.paymentDateField;
            }
            set {
                this.paymentDateField = value;
            }
        }
        
        /// <remarks/>
        public string PaymentDateCymd {
            get {
                return this.paymentDateCymdField;
            }
            set {
                this.paymentDateCymdField = value;
            }
        }
        
        /// <remarks/>
        public object Bank {
            get {
                return this.bankField;
            }
            set {
                this.bankField = value;
            }
        }
        
        /// <remarks/>
        public string BankName {
            get {
                return this.bankNameField;
            }
            set {
                this.bankNameField = value;
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
        public string CompanyAddressOne {
            get {
                return this.companyAddressOneField;
            }
            set {
                this.companyAddressOneField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyAddressTwo {
            get {
                return this.companyAddressTwoField;
            }
            set {
                this.companyAddressTwoField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyAddressThree {
            get {
                return this.companyAddressThreeField;
            }
            set {
                this.companyAddressThreeField = value;
            }
        }
        
        /// <remarks/>
        public string ForeignCurrencyDesc {
            get {
                return this.foreignCurrencyDescField;
            }
            set {
                this.foreignCurrencyDescField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyRegNumber {
            get {
                return this.companyRegNumberField;
            }
            set {
                this.companyRegNumberField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyTaxNumber {
            get {
                return this.companyTaxNumberField;
            }
            set {
                this.companyTaxNumberField = value;
            }
        }
        
        /// <remarks/>
        public object RemittanceName {
            get {
                return this.remittanceNameField;
            }
            set {
                this.remittanceNameField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddrOne {
            get {
                return this.remittanceAddrOneField;
            }
            set {
                this.remittanceAddrOneField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddrTwo {
            get {
                return this.remittanceAddrTwoField;
            }
            set {
                this.remittanceAddrTwoField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddrThree {
            get {
                return this.remittanceAddrThreeField;
            }
            set {
                this.remittanceAddrThreeField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddrFour {
            get {
                return this.remittanceAddrFourField;
            }
            set {
                this.remittanceAddrFourField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddrFive {
            get {
                return this.remittanceAddrFiveField;
            }
            set {
                this.remittanceAddrFiveField = value;
            }
        }
        
        /// <remarks/>
        public string RemittancePostCode {
            get {
                return this.remittancePostCodeField;
            }
            set {
                this.remittancePostCodeField = value;
            }
        }
        
        /// <remarks/>
        public string TelephoneNumber {
            get {
                return this.telephoneNumberField;
            }
            set {
                this.telephoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string FaxNumber {
            get {
                return this.faxNumberField;
            }
            set {
                this.faxNumberField = value;
            }
        }
        
        /// <remarks/>
        public string ContactName {
            get {
                return this.contactNameField;
            }
            set {
                this.contactNameField = value;
            }
        }
        
        /// <remarks/>
        public string EmailAddress {
            get {
                return this.emailAddressField;
            }
            set {
                this.emailAddressField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceFaxNumber {
            get {
                return this.remittanceFaxNumberField;
            }
            set {
                this.remittanceFaxNumberField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceContactNa {
            get {
                return this.remittanceContactNaField;
            }
            set {
                this.remittanceContactNaField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceEmail {
            get {
                return this.remittanceEmailField;
            }
            set {
                this.remittanceEmailField = value;
            }
        }
        
        /// <remarks/>
        public string UserDefinedFieldA {
            get {
                return this.userDefinedFieldAField;
            }
            set {
                this.userDefinedFieldAField = value;
            }
        }
        
        /// <remarks/>
        public string UserDefinedFieldB {
            get {
                return this.userDefinedFieldBField;
            }
            set {
                this.userDefinedFieldBField = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingTax {
            get {
                return this.withholdingTaxField;
            }
            set {
                this.withholdingTaxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class DocumentsDocumentDetailLine {
        
        private DocumentsDocumentDetailLineGeneral generalField;
        
        /// <remarks/>
        public DocumentsDocumentDetailLineGeneral General {
            get {
                return this.generalField;
            }
            set {
                this.generalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class DocumentsDocumentDetailLineGeneral {
        
        private string detInvoiceField;
        
        private string detInvReferenceField;
        
        private string detInvDateField;
        
        private string detInvGrossAmountField;
        
        private string detInvDiscAmountField;
        
        private string detInvNetAmountField;
        
        private string detInvWithTaxAmtField;
        
        private string detInvBranchField;
        
        private string detInvWithTaxCodeField;
        
        /// <remarks/>
        public string DetInvoice {
            get {
                return this.detInvoiceField;
            }
            set {
                this.detInvoiceField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvReference {
            get {
                return this.detInvReferenceField;
            }
            set {
                this.detInvReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvDate {
            get {
                return this.detInvDateField;
            }
            set {
                this.detInvDateField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvGrossAmount {
            get {
                return this.detInvGrossAmountField;
            }
            set {
                this.detInvGrossAmountField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvDiscAmount {
            get {
                return this.detInvDiscAmountField;
            }
            set {
                this.detInvDiscAmountField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvNetAmount {
            get {
                return this.detInvNetAmountField;
            }
            set {
                this.detInvNetAmountField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvWithTaxAmt {
            get {
                return this.detInvWithTaxAmtField;
            }
            set {
                this.detInvWithTaxAmtField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvBranch {
            get {
                return this.detInvBranchField;
            }
            set {
                this.detInvBranchField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvWithTaxCode {
            get {
                return this.detInvWithTaxCodeField;
            }
            set {
                this.detInvWithTaxCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class DocumentsDocumentTotalData {
        
        private object supplierNameField;
        
        private object supplierField;
        
        private string eftNumberField;
        
        private object bankField;
        
        private string remittanceGrossAmtField;
        
        private string remittanceDiscAmtField;
        
        private string remittanceNetAmtField;
        
        private string remittWithTaxAmtField;
        
        private object remittanceNameField;
        
        /// <remarks/>
        public object SupplierName {
            get {
                return this.supplierNameField;
            }
            set {
                this.supplierNameField = value;
            }
        }
        
        /// <remarks/>
        public object Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        public string EftNumber {
            get {
                return this.eftNumberField;
            }
            set {
                this.eftNumberField = value;
            }
        }
        
        /// <remarks/>
        public object Bank {
            get {
                return this.bankField;
            }
            set {
                this.bankField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceGrossAmt {
            get {
                return this.remittanceGrossAmtField;
            }
            set {
                this.remittanceGrossAmtField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceDiscAmt {
            get {
                return this.remittanceDiscAmtField;
            }
            set {
                this.remittanceDiscAmtField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceNetAmt {
            get {
                return this.remittanceNetAmtField;
            }
            set {
                this.remittanceNetAmtField = value;
            }
        }
        
        /// <remarks/>
        public string RemittWithTaxAmt {
            get {
                return this.remittWithTaxAmtField;
            }
            set {
                this.remittWithTaxAmtField = value;
            }
        }
        
        /// <remarks/>
        public object RemittanceName {
            get {
                return this.remittanceNameField;
            }
            set {
                this.remittanceNameField = value;
            }
        }
    }
}
