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
namespace SYSPRO.NET.BusinessObjects.CSHQ45OUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CashBookBankBalances {
        
        private CashBookBankBalancesSystemInformation[] systemInformationField;
        
        private CashBookBankBalancesQueryOptions[] queryOptionsField;
        
        private CashBookBankBalancesBankDetails[] bankDetailsField;
        
        private CashBookBankBalancesCompanyTotals[] companyTotalsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CashBookBankBalancesSystemInformation[] SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CashBookBankBalancesQueryOptions[] QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BankDetails", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CashBookBankBalancesBankDetails[] BankDetails {
            get {
                return this.bankDetailsField;
            }
            set {
                this.bankDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompanyTotals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CashBookBankBalancesCompanyTotals[] CompanyTotals {
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
    public partial class CashBookBankBalancesSystemInformation {
        
        private string cssStyleField;
        
        private string languageField;
        
        private string decFormatField;
        
        private string dateFormatField;
        
        private string versionField;
        
        private string companyIdField;
        
        private string companyNameField;
        
        private string operatorCodeField;
        
        private string operatorNameField;
        
        private string operatorGroupField;
        
        private string operatorEmailAddressField;
        
        private string operatorLocationField;
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorCode {
            get {
                return this.operatorCodeField;
            }
            set {
                this.operatorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorName {
            get {
                return this.operatorNameField;
            }
            set {
                this.operatorNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorGroup {
            get {
                return this.operatorGroupField;
            }
            set {
                this.operatorGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorEmailAddress {
            get {
                return this.operatorEmailAddressField;
            }
            set {
                this.operatorEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorLocation {
            get {
                return this.operatorLocationField;
            }
            set {
                this.operatorLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReportDate {
            get {
                return this.reportDateField;
            }
            set {
                this.reportDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UseSeparatorOnReports {
            get {
                return this.useSeparatorOnReportsField;
            }
            set {
                this.useSeparatorOnReportsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    public partial class CashBookBankBalancesQueryOptions {
        
        private string monthField;
        
        private string translated_MonthField;
        
        private string bankFilterTypeField;
        
        private string translated_BankFilterTypeField;
        
        private string bankFilterValueField;
        
        private string currencyFilterTypeField;
        
        private string translated_CurrencyFilterTypeField;
        
        private string currencyFilterValueField;
        
        private string forCurrCBReqdField;
        
        private string translated_ForCurrCBReqdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Month {
            get {
                return this.monthField;
            }
            set {
                this.monthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_Month {
            get {
                return this.translated_MonthField;
            }
            set {
                this.translated_MonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BankFilterType {
            get {
                return this.bankFilterTypeField;
            }
            set {
                this.bankFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_BankFilterType {
            get {
                return this.translated_BankFilterTypeField;
            }
            set {
                this.translated_BankFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BankFilterValue {
            get {
                return this.bankFilterValueField;
            }
            set {
                this.bankFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CurrencyFilterType {
            get {
                return this.currencyFilterTypeField;
            }
            set {
                this.currencyFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_CurrencyFilterType {
            get {
                return this.translated_CurrencyFilterTypeField;
            }
            set {
                this.translated_CurrencyFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CurrencyFilterValue {
            get {
                return this.currencyFilterValueField;
            }
            set {
                this.currencyFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ForCurrCBReqd {
            get {
                return this.forCurrCBReqdField;
            }
            set {
                this.forCurrCBReqdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_ForCurrCBReqd {
            get {
                return this.translated_ForCurrCBReqdField;
            }
            set {
                this.translated_ForCurrCBReqdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CashBookBankBalancesBankDetails {
        
        private string bankField;
        
        private string bankDescriptionField;
        
        private string currencyField;
        
        private string tBLCUR_DescriptionField;
        
        private string accountNumberField;
        
        private string telephoneField;
        
        private string cashLedgerAccountField;
        
        private string gENMST_DescriptionField;
        
        private double statementBalanceField;
        
        private bool statementBalanceFieldSpecified;
        
        private string edited_StatementBalanceField;
        
        private double outstandingDepositsField;
        
        private bool outstandingDepositsFieldSpecified;
        
        private string edited_OutstandingDepositsField;
        
        private double outstandingWithdrawalsField;
        
        private bool outstandingWithdrawalsFieldSpecified;
        
        private string edited_OutstandingWithdrawalsField;
        
        private double currentBalanceField;
        
        private bool currentBalanceFieldSpecified;
        
        private string edited_CurrentBalanceField;
        
        private double localEquivalentField;
        
        private bool localEquivalentFieldSpecified;
        
        private string edited_LocalEquivalentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Bank {
            get {
                return this.bankField;
            }
            set {
                this.bankField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BankDescription {
            get {
                return this.bankDescriptionField;
            }
            set {
                this.bankDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TBLCUR_Description {
            get {
                return this.tBLCUR_DescriptionField;
            }
            set {
                this.tBLCUR_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AccountNumber {
            get {
                return this.accountNumberField;
            }
            set {
                this.accountNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Telephone {
            get {
                return this.telephoneField;
            }
            set {
                this.telephoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CashLedgerAccount {
            get {
                return this.cashLedgerAccountField;
            }
            set {
                this.cashLedgerAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GENMST_Description {
            get {
                return this.gENMST_DescriptionField;
            }
            set {
                this.gENMST_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double StatementBalance {
            get {
                return this.statementBalanceField;
            }
            set {
                this.statementBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatementBalanceSpecified {
            get {
                return this.statementBalanceFieldSpecified;
            }
            set {
                this.statementBalanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_StatementBalance {
            get {
                return this.edited_StatementBalanceField;
            }
            set {
                this.edited_StatementBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double OutstandingDeposits {
            get {
                return this.outstandingDepositsField;
            }
            set {
                this.outstandingDepositsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutstandingDepositsSpecified {
            get {
                return this.outstandingDepositsFieldSpecified;
            }
            set {
                this.outstandingDepositsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_OutstandingDeposits {
            get {
                return this.edited_OutstandingDepositsField;
            }
            set {
                this.edited_OutstandingDepositsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double OutstandingWithdrawals {
            get {
                return this.outstandingWithdrawalsField;
            }
            set {
                this.outstandingWithdrawalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutstandingWithdrawalsSpecified {
            get {
                return this.outstandingWithdrawalsFieldSpecified;
            }
            set {
                this.outstandingWithdrawalsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_OutstandingWithdrawals {
            get {
                return this.edited_OutstandingWithdrawalsField;
            }
            set {
                this.edited_OutstandingWithdrawalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double CurrentBalance {
            get {
                return this.currentBalanceField;
            }
            set {
                this.currentBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrentBalanceSpecified {
            get {
                return this.currentBalanceFieldSpecified;
            }
            set {
                this.currentBalanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_CurrentBalance {
            get {
                return this.edited_CurrentBalanceField;
            }
            set {
                this.edited_CurrentBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double LocalEquivalent {
            get {
                return this.localEquivalentField;
            }
            set {
                this.localEquivalentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocalEquivalentSpecified {
            get {
                return this.localEquivalentFieldSpecified;
            }
            set {
                this.localEquivalentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_LocalEquivalent {
            get {
                return this.edited_LocalEquivalentField;
            }
            set {
                this.edited_LocalEquivalentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CashBookBankBalancesCompanyTotals {
        
        private string periodSelectionField;
        
        private double statementBalanceField;
        
        private bool statementBalanceFieldSpecified;
        
        private string edited_StatementBalanceField;
        
        private double outstandingDepositsField;
        
        private bool outstandingDepositsFieldSpecified;
        
        private string edited_OutstandingDepositsField;
        
        private double outstandingWithdrawalsField;
        
        private bool outstandingWithdrawalsFieldSpecified;
        
        private string edited_OutstandingWithdrawalsField;
        
        private double currentBalanceField;
        
        private bool currentBalanceFieldSpecified;
        
        private string edited_CurrentBalanceField;
        
        private double localEquivalentField;
        
        private bool localEquivalentFieldSpecified;
        
        private string edited_LocalEquivalentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PeriodSelection {
            get {
                return this.periodSelectionField;
            }
            set {
                this.periodSelectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double StatementBalance {
            get {
                return this.statementBalanceField;
            }
            set {
                this.statementBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatementBalanceSpecified {
            get {
                return this.statementBalanceFieldSpecified;
            }
            set {
                this.statementBalanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_StatementBalance {
            get {
                return this.edited_StatementBalanceField;
            }
            set {
                this.edited_StatementBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double OutstandingDeposits {
            get {
                return this.outstandingDepositsField;
            }
            set {
                this.outstandingDepositsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutstandingDepositsSpecified {
            get {
                return this.outstandingDepositsFieldSpecified;
            }
            set {
                this.outstandingDepositsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_OutstandingDeposits {
            get {
                return this.edited_OutstandingDepositsField;
            }
            set {
                this.edited_OutstandingDepositsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double OutstandingWithdrawals {
            get {
                return this.outstandingWithdrawalsField;
            }
            set {
                this.outstandingWithdrawalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OutstandingWithdrawalsSpecified {
            get {
                return this.outstandingWithdrawalsFieldSpecified;
            }
            set {
                this.outstandingWithdrawalsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_OutstandingWithdrawals {
            get {
                return this.edited_OutstandingWithdrawalsField;
            }
            set {
                this.edited_OutstandingWithdrawalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double CurrentBalance {
            get {
                return this.currentBalanceField;
            }
            set {
                this.currentBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrentBalanceSpecified {
            get {
                return this.currentBalanceFieldSpecified;
            }
            set {
                this.currentBalanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_CurrentBalance {
            get {
                return this.edited_CurrentBalanceField;
            }
            set {
                this.edited_CurrentBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double LocalEquivalent {
            get {
                return this.localEquivalentField;
            }
            set {
                this.localEquivalentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LocalEquivalentSpecified {
            get {
                return this.localEquivalentFieldSpecified;
            }
            set {
                this.localEquivalentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_LocalEquivalent {
            get {
                return this.edited_LocalEquivalentField;
            }
            set {
                this.edited_LocalEquivalentField = value;
            }
        }
    }
}
