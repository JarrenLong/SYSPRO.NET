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
namespace SYSPRO.NET.BusinessObjects.sample_cs_remittance_bank_document {
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
        
        private string supplierNameField;
        
        private string supplierAddressOneField;
        
        private string supplierAddressTwoField;
        
        private string supplierAddressThreField;
        
        private string supplierAddressFourField;
        
        private string supplierAddressFiveField;
        
        private string supplierCodeField;
        
        private string paymentDateField;
        
        private string paymentDateCymdField;
        
        private string pageNumberField;
        
        private string bankIdField;
        
        private string bankNameField;
        
        private string bnkMediaField;
        
        private string companyNameField;
        
        private string companyAddressOneField;
        
        private string companyAddressTwoField;
        
        private string companyAddressThreField;
        
        private string foreignCurDesField;
        
        private string compRegNumberField;
        
        private string taxRegNumberField;
        
        private string remittanceNameField;
        
        private string remittanceAddressOneField;
        
        private string remittanceAddressTwoField;
        
        private string remittanceAddressThrField;
        
        private string remittanceAddressForField;
        
        private string remittanceAddressFivField;
        
        private string remittancePostalCodeField;
        
        /// <remarks/>
        public string SupplierName {
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
        public string PageNumber {
            get {
                return this.pageNumberField;
            }
            set {
                this.pageNumberField = value;
            }
        }
        
        /// <remarks/>
        public string BankId {
            get {
                return this.bankIdField;
            }
            set {
                this.bankIdField = value;
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
        public string BnkMedia {
            get {
                return this.bnkMediaField;
            }
            set {
                this.bnkMediaField = value;
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
        public string CompanyAddressThre {
            get {
                return this.companyAddressThreField;
            }
            set {
                this.companyAddressThreField = value;
            }
        }
        
        /// <remarks/>
        public string ForeignCurDes {
            get {
                return this.foreignCurDesField;
            }
            set {
                this.foreignCurDesField = value;
            }
        }
        
        /// <remarks/>
        public string CompRegNumber {
            get {
                return this.compRegNumberField;
            }
            set {
                this.compRegNumberField = value;
            }
        }
        
        /// <remarks/>
        public string TaxRegNumber {
            get {
                return this.taxRegNumberField;
            }
            set {
                this.taxRegNumberField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceName {
            get {
                return this.remittanceNameField;
            }
            set {
                this.remittanceNameField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddressOne {
            get {
                return this.remittanceAddressOneField;
            }
            set {
                this.remittanceAddressOneField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddressTwo {
            get {
                return this.remittanceAddressTwoField;
            }
            set {
                this.remittanceAddressTwoField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddressThr {
            get {
                return this.remittanceAddressThrField;
            }
            set {
                this.remittanceAddressThrField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddressFor {
            get {
                return this.remittanceAddressForField;
            }
            set {
                this.remittanceAddressForField = value;
            }
        }
        
        /// <remarks/>
        public string RemittanceAddressFiv {
            get {
                return this.remittanceAddressFivField;
            }
            set {
                this.remittanceAddressFivField = value;
            }
        }
        
        /// <remarks/>
        public string RemittancePostalCode {
            get {
                return this.remittancePostalCodeField;
            }
            set {
                this.remittancePostalCodeField = value;
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
        
        private string detInvoiceDateField;
        
        private string detInvoiceAmountField;
        
        private string detRemittanceTxtField;
        
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
        public string DetInvoiceDate {
            get {
                return this.detInvoiceDateField;
            }
            set {
                this.detInvoiceDateField = value;
            }
        }
        
        /// <remarks/>
        public string DetInvoiceAmount {
            get {
                return this.detInvoiceAmountField;
            }
            set {
                this.detInvoiceAmountField = value;
            }
        }
        
        /// <remarks/>
        public string DetRemittanceTxt {
            get {
                return this.detRemittanceTxtField;
            }
            set {
                this.detRemittanceTxtField = value;
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
        
        private string totSupplierNameField;
        
        private string totCheckNumberField;
        
        private string totBankIdField;
        
        private string totBankMediaField;
        
        private string totRemittanceAdvAmtField;
        
        private string totRemittanceNameField;
        
        /// <remarks/>
        public string TotSupplierName {
            get {
                return this.totSupplierNameField;
            }
            set {
                this.totSupplierNameField = value;
            }
        }
        
        /// <remarks/>
        public string TotCheckNumber {
            get {
                return this.totCheckNumberField;
            }
            set {
                this.totCheckNumberField = value;
            }
        }
        
        /// <remarks/>
        public string TotBankId {
            get {
                return this.totBankIdField;
            }
            set {
                this.totBankIdField = value;
            }
        }
        
        /// <remarks/>
        public string TotBankMedia {
            get {
                return this.totBankMediaField;
            }
            set {
                this.totBankMediaField = value;
            }
        }
        
        /// <remarks/>
        public string TotRemittanceAdvAmt {
            get {
                return this.totRemittanceAdvAmtField;
            }
            set {
                this.totRemittanceAdvAmtField = value;
            }
        }
        
        /// <remarks/>
        public string TotRemittanceName {
            get {
                return this.totRemittanceNameField;
            }
            set {
                this.totRemittanceNameField = value;
            }
        }
    }
}
