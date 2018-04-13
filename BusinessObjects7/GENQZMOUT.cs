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
namespace SYSPRO.NET.BusinessObjects.GENQZMOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class LedgerQueryZoom {
        
        private LedgerQueryZoomSystemInformation systemInformationField;
        
        private LedgerQueryZoomGeneralLedgerJournal generalLedgerJournalField;
        
        /// <remarks/>
        public LedgerQueryZoomSystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public LedgerQueryZoomGeneralLedgerJournal GeneralLedgerJournal {
            get {
                return this.generalLedgerJournalField;
            }
            set {
                this.generalLedgerJournalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LedgerQueryZoomSystemInformation {
        
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
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
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
    public partial class LedgerQueryZoomGeneralLedgerJournal {
        
        private string glYearField;
        
        private string glJournalField;
        
        private string jnlPostingTypeField;
        
        private string journalDateField;
        
        private string referenceField;
        
        private string notationField;
        
        private string glPeriodField;
        
        private string debitAmountField;
        
        private string creditAmountField;
        
        private string numOfEntriesField;
        
        private string sourceField;
        
        private string jnlStatusField;
        
        private object currencyField;
        
        private string operatorField;
        
        private string jnlPrintFlagField;
        
        private string auditorsPasswordInUseField;
        
        private LedgerQueryZoomGeneralLedgerJournalGeneralLedgerJournalDetail[] generalLedgerJournalDetailField;
        
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
        public string GlJournal {
            get {
                return this.glJournalField;
            }
            set {
                this.glJournalField = value;
            }
        }
        
        /// <remarks/>
        public string JnlPostingType {
            get {
                return this.jnlPostingTypeField;
            }
            set {
                this.jnlPostingTypeField = value;
            }
        }
        
        /// <remarks/>
        public string JournalDate {
            get {
                return this.journalDateField;
            }
            set {
                this.journalDateField = value;
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
        public string Notation {
            get {
                return this.notationField;
            }
            set {
                this.notationField = value;
            }
        }
        
        /// <remarks/>
        public string GlPeriod {
            get {
                return this.glPeriodField;
            }
            set {
                this.glPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string DebitAmount {
            get {
                return this.debitAmountField;
            }
            set {
                this.debitAmountField = value;
            }
        }
        
        /// <remarks/>
        public string CreditAmount {
            get {
                return this.creditAmountField;
            }
            set {
                this.creditAmountField = value;
            }
        }
        
        /// <remarks/>
        public string NumOfEntries {
            get {
                return this.numOfEntriesField;
            }
            set {
                this.numOfEntriesField = value;
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
        public string JnlStatus {
            get {
                return this.jnlStatusField;
            }
            set {
                this.jnlStatusField = value;
            }
        }
        
        /// <remarks/>
        public object Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        public string Operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
        
        /// <remarks/>
        public string JnlPrintFlag {
            get {
                return this.jnlPrintFlagField;
            }
            set {
                this.jnlPrintFlagField = value;
            }
        }
        
        /// <remarks/>
        public string AuditorsPasswordInUse {
            get {
                return this.auditorsPasswordInUseField;
            }
            set {
                this.auditorsPasswordInUseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GeneralLedgerJournalDetail")]
        public LedgerQueryZoomGeneralLedgerJournalGeneralLedgerJournalDetail[] GeneralLedgerJournalDetail {
            get {
                return this.generalLedgerJournalDetailField;
            }
            set {
                this.generalLedgerJournalDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LedgerQueryZoomGeneralLedgerJournalGeneralLedgerJournalDetail {
        
        private string glCodeField;
        
        private string descriptionField;
        
        private string entryDateField;
        
        private string referenceField;
        
        private string entryValueField;
        
        private string entryTypeField;
        
        private string commentField;
        
        private string interCompanyFlagField;
        
        /// <remarks/>
        public string GlCode {
            get {
                return this.glCodeField;
            }
            set {
                this.glCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string EntryDate {
            get {
                return this.entryDateField;
            }
            set {
                this.entryDateField = value;
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
        public string EntryValue {
            get {
                return this.entryValueField;
            }
            set {
                this.entryValueField = value;
            }
        }
        
        /// <remarks/>
        public string EntryType {
            get {
                return this.entryTypeField;
            }
            set {
                this.entryTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public string InterCompanyFlag {
            get {
                return this.interCompanyFlagField;
            }
            set {
                this.interCompanyFlagField = value;
            }
        }
    }
}
