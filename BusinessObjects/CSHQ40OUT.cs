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
namespace SYSPRO.NET.BusinessObjects.CSHQ40OUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CBConsolidatedStatement {
        
        private CBConsolidatedStatementSystemInformation systemInformationField;
        
        private CBConsolidatedStatementQueryOptions queryOptionsField;
        
        private CBConsolidatedStatementBankItem[] consolidatedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CBConsolidatedStatementSystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CBConsolidatedStatementQueryOptions QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("BankItem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public CBConsolidatedStatementBankItem[] Consolidated {
            get {
                return this.consolidatedField;
            }
            set {
                this.consolidatedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CBConsolidatedStatementSystemInformation {
        
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
    public partial class CBConsolidatedStatementQueryOptions {
        
        private string consolidationMonthField;
        
        private string translated_ConsolidationMonthField;
        
        private string statementPeriodField;
        
        private string statementYearField;
        
        private string transactionTypeField;
        
        private string translated_TransactionTypeField;
        
        private string highlightMissingChecksField;
        
        private string translated_HighlightMissingChecksField;
        
        private string onlyChecksForSelectedPeriodField;
        
        private string translated_OnlyChecksForSelectedPeriodField;
        
        private string bankFilterTypeField;
        
        private string translated_BankFilterTypeField;
        
        private string bankFilterValueField;
        
        private string transactionDateFilterTypeField;
        
        private string translated_TransactionDateFilterTypeField;
        
        private string transactionDateFilterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ConsolidationMonth {
            get {
                return this.consolidationMonthField;
            }
            set {
                this.consolidationMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_ConsolidationMonth {
            get {
                return this.translated_ConsolidationMonthField;
            }
            set {
                this.translated_ConsolidationMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StatementPeriod {
            get {
                return this.statementPeriodField;
            }
            set {
                this.statementPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StatementYear {
            get {
                return this.statementYearField;
            }
            set {
                this.statementYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TransactionType {
            get {
                return this.transactionTypeField;
            }
            set {
                this.transactionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_TransactionType {
            get {
                return this.translated_TransactionTypeField;
            }
            set {
                this.translated_TransactionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string HighlightMissingChecks {
            get {
                return this.highlightMissingChecksField;
            }
            set {
                this.highlightMissingChecksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_HighlightMissingChecks {
            get {
                return this.translated_HighlightMissingChecksField;
            }
            set {
                this.translated_HighlightMissingChecksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OnlyChecksForSelectedPeriod {
            get {
                return this.onlyChecksForSelectedPeriodField;
            }
            set {
                this.onlyChecksForSelectedPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_OnlyChecksForSelectedPeriod {
            get {
                return this.translated_OnlyChecksForSelectedPeriodField;
            }
            set {
                this.translated_OnlyChecksForSelectedPeriodField = value;
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
        public string TransactionDateFilterType {
            get {
                return this.transactionDateFilterTypeField;
            }
            set {
                this.transactionDateFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_TransactionDateFilterType {
            get {
                return this.translated_TransactionDateFilterTypeField;
            }
            set {
                this.translated_TransactionDateFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TransactionDateFilterValue {
            get {
                return this.transactionDateFilterValueField;
            }
            set {
                this.transactionDateFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CBConsolidatedStatementBankItem {
        
        private string bankField;
        
        private string aPSBNK_DescriptionField;
        
        private string foreignCurrencyRequiredField;
        
        private CBConsolidatedStatementBankItemDetail[] detailField;
        
        private CBConsolidatedStatementBankItemBankTotal[] bankTotalField;
        
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
        public string APSBNK_Description {
            get {
                return this.aPSBNK_DescriptionField;
            }
            set {
                this.aPSBNK_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ForeignCurrencyRequired {
            get {
                return this.foreignCurrencyRequiredField;
            }
            set {
                this.foreignCurrencyRequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Detail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CBConsolidatedStatementBankItemDetail[] Detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BankTotal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CBConsolidatedStatementBankItemBankTotal[] BankTotal {
            get {
                return this.bankTotalField;
            }
            set {
                this.bankTotalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CBConsolidatedStatementBankItemDetail {
        
        private string transactionTypeField;
        
        private string translated_Transactiontype_Check_HeadingField;
        
        private string translated_Transactiontype_Total_HeadingField;
        
        private string translated_Transactiontype_Value_HeadingField;
        
        private string postingMonthField;
        
        private string postingYearField;
        
        private string checkField;
        
        private string transactionDateField;
        
        private string referenceField;
        
        private string currencyField;
        
        private string tBLCUR_DescriptionField;
        
        private double transactionValueField;
        
        private bool transactionValueFieldSpecified;
        
        private string edited_TransactionValueField;
        
        private double bankEquivalentField;
        
        private bool bankEquivalentFieldSpecified;
        
        private string edited_BankEquivalentField;
        
        private string reconciledField;
        
        private string translated_ReconciledField;
        
        private string reconciledMonthField;
        
        private string reconciledYearField;
        
        private string narrationField;
        
        private string missingCheckField;
        
        private string missingCheckFromField;
        
        private string missingCheckToField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TransactionType {
            get {
                return this.transactionTypeField;
            }
            set {
                this.transactionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_Transactiontype_Check_Heading {
            get {
                return this.translated_Transactiontype_Check_HeadingField;
            }
            set {
                this.translated_Transactiontype_Check_HeadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_Transactiontype_Total_Heading {
            get {
                return this.translated_Transactiontype_Total_HeadingField;
            }
            set {
                this.translated_Transactiontype_Total_HeadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_Transactiontype_Value_Heading {
            get {
                return this.translated_Transactiontype_Value_HeadingField;
            }
            set {
                this.translated_Transactiontype_Value_HeadingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostingMonth {
            get {
                return this.postingMonthField;
            }
            set {
                this.postingMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PostingYear {
            get {
                return this.postingYearField;
            }
            set {
                this.postingYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Check {
            get {
                return this.checkField;
            }
            set {
                this.checkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TransactionDate {
            get {
                return this.transactionDateField;
            }
            set {
                this.transactionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
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
        public double TransactionValue {
            get {
                return this.transactionValueField;
            }
            set {
                this.transactionValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionValueSpecified {
            get {
                return this.transactionValueFieldSpecified;
            }
            set {
                this.transactionValueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_TransactionValue {
            get {
                return this.edited_TransactionValueField;
            }
            set {
                this.edited_TransactionValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double BankEquivalent {
            get {
                return this.bankEquivalentField;
            }
            set {
                this.bankEquivalentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BankEquivalentSpecified {
            get {
                return this.bankEquivalentFieldSpecified;
            }
            set {
                this.bankEquivalentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_BankEquivalent {
            get {
                return this.edited_BankEquivalentField;
            }
            set {
                this.edited_BankEquivalentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reconciled {
            get {
                return this.reconciledField;
            }
            set {
                this.reconciledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_Reconciled {
            get {
                return this.translated_ReconciledField;
            }
            set {
                this.translated_ReconciledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReconciledMonth {
            get {
                return this.reconciledMonthField;
            }
            set {
                this.reconciledMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReconciledYear {
            get {
                return this.reconciledYearField;
            }
            set {
                this.reconciledYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Narration {
            get {
                return this.narrationField;
            }
            set {
                this.narrationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MissingCheck {
            get {
                return this.missingCheckField;
            }
            set {
                this.missingCheckField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MissingCheckFrom {
            get {
                return this.missingCheckFromField;
            }
            set {
                this.missingCheckFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MissingCheckTo {
            get {
                return this.missingCheckToField;
            }
            set {
                this.missingCheckToField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class CBConsolidatedStatementBankItemBankTotal {
        
        private double totalDepositsField;
        
        private bool totalDepositsFieldSpecified;
        
        private string edited_TotalDepositsField;
        
        private double totalWithdrawalsField;
        
        private bool totalWithdrawalsFieldSpecified;
        
        private string edited_TotalWithdrawalsField;
        
        private double totalBalanceField;
        
        private bool totalBalanceFieldSpecified;
        
        private string edited_TotalBalanceField;
        
        private string totalCurrencyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double TotalDeposits {
            get {
                return this.totalDepositsField;
            }
            set {
                this.totalDepositsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalDepositsSpecified {
            get {
                return this.totalDepositsFieldSpecified;
            }
            set {
                this.totalDepositsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_TotalDeposits {
            get {
                return this.edited_TotalDepositsField;
            }
            set {
                this.edited_TotalDepositsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double TotalWithdrawals {
            get {
                return this.totalWithdrawalsField;
            }
            set {
                this.totalWithdrawalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalWithdrawalsSpecified {
            get {
                return this.totalWithdrawalsFieldSpecified;
            }
            set {
                this.totalWithdrawalsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_TotalWithdrawals {
            get {
                return this.edited_TotalWithdrawalsField;
            }
            set {
                this.edited_TotalWithdrawalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double TotalBalance {
            get {
                return this.totalBalanceField;
            }
            set {
                this.totalBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalBalanceSpecified {
            get {
                return this.totalBalanceFieldSpecified;
            }
            set {
                this.totalBalanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_TotalBalance {
            get {
                return this.edited_TotalBalanceField;
            }
            set {
                this.edited_TotalBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TotalCurrency {
            get {
                return this.totalCurrencyField;
            }
            set {
                this.totalCurrencyField = value;
            }
        }
    }
}
