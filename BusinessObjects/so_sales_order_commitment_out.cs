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
namespace SYSPRO.NET.BusinessObjects.so_sales_order_commitment_out {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SalesOrderCommitment {
        
        private SalesOrderCommitmentSystemInformation systemInformationField;
        
        private SalesOrderCommitmentQueryOptions queryOptionsField;
        
        private SalesOrderCommitmentSalesOrderDetail[] salesOrdersField;
        
        private SalesOrderCommitmentCompanyTotals companyTotalsField;
        
        /// <remarks/>
        public SalesOrderCommitmentSystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public SalesOrderCommitmentQueryOptions QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SalesOrderDetail", IsNullable=false)]
        public SalesOrderCommitmentSalesOrderDetail[] SalesOrders {
            get {
                return this.salesOrdersField;
            }
            set {
                this.salesOrdersField = value;
            }
        }
        
        /// <remarks/>
        public SalesOrderCommitmentCompanyTotals CompanyTotals {
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
    public partial class SalesOrderCommitmentSystemInformation {
        
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
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
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
    public partial class SalesOrderCommitmentQueryOptions {
        
        private string reportTypeField;
        
        private string translated_ReportTypeField;
        
        private string projectionPeriodField;
        
        private string translated_ProjectionPeriodField;
        
        private string reportProjectionDaysField;
        
        private string projectionDays1Field;
        
        private string translated_ProjectionDays1Field;
        
        private string projectionDays2Field;
        
        private string translated_ProjectionDays2Field;
        
        private string projectionDays3Field;
        
        private string translated_ProjectionDays3Field;
        
        private string projectionDays4Field;
        
        private string translated_ProjectionDays4Field;
        
        private string projectionDays5Field;
        
        private string translated_ProjectionDays5Field;
        
        private string projectionDays6Field;
        
        private string translated_ProjectionDays6Field;
        
        private string projectionDays7Field;
        
        private string translated_ProjectionDays7Field;
        
        private string basedOnDateField;
        
        private string translated_BasedOnDateField;
        
        private string includeOrdersInSuspenseField;
        
        private string translated_IncludeOrdersInSuspenseField;
        
        private string currencyValuesField;
        
        private string translated_CurrencyValuesField;
        
        private string convertToLocalValueField;
        
        private string translated_ConvertToLocalValueField;
        
        private string customerFilterTypeField;
        
        private string translated_CustomerFilterTypeField;
        
        private string customerFilterValueField;
        
        private string salesOrderFilterTypeField;
        
        private string translated_SalesOrderFilterTypeField;
        
        private string salesOrderFilterValueField;
        
        private string branchFilterTypeField;
        
        private string translated_BranchFilterTypeField;
        
        private string branchFilterValueField;
        
        private string currencyFilterTypeField;
        
        private string translated_CurrencyFilterTypeField;
        
        private string currencyFilterValueField;
        
        private string operatorAccessSecurityField;
        
        /// <remarks/>
        public string ReportType {
            get {
                return this.reportTypeField;
            }
            set {
                this.reportTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ReportType {
            get {
                return this.translated_ReportTypeField;
            }
            set {
                this.translated_ReportTypeField = value;
            }
        }
        
        /// <remarks/>
        public string ProjectionPeriod {
            get {
                return this.projectionPeriodField;
            }
            set {
                this.projectionPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ProjectionPeriod {
            get {
                return this.translated_ProjectionPeriodField;
            }
            set {
                this.translated_ProjectionPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string ReportProjectionDays {
            get {
                return this.reportProjectionDaysField;
            }
            set {
                this.reportProjectionDaysField = value;
            }
        }
        
        /// <remarks/>
        public string ProjectionDays1 {
            get {
                return this.projectionDays1Field;
            }
            set {
                this.projectionDays1Field = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ProjectionDays1 {
            get {
                return this.translated_ProjectionDays1Field;
            }
            set {
                this.translated_ProjectionDays1Field = value;
            }
        }
        
        /// <remarks/>
        public string ProjectionDays2 {
            get {
                return this.projectionDays2Field;
            }
            set {
                this.projectionDays2Field = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ProjectionDays2 {
            get {
                return this.translated_ProjectionDays2Field;
            }
            set {
                this.translated_ProjectionDays2Field = value;
            }
        }
        
        /// <remarks/>
        public string ProjectionDays3 {
            get {
                return this.projectionDays3Field;
            }
            set {
                this.projectionDays3Field = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ProjectionDays3 {
            get {
                return this.translated_ProjectionDays3Field;
            }
            set {
                this.translated_ProjectionDays3Field = value;
            }
        }
        
        /// <remarks/>
        public string ProjectionDays4 {
            get {
                return this.projectionDays4Field;
            }
            set {
                this.projectionDays4Field = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ProjectionDays4 {
            get {
                return this.translated_ProjectionDays4Field;
            }
            set {
                this.translated_ProjectionDays4Field = value;
            }
        }
        
        /// <remarks/>
        public string ProjectionDays5 {
            get {
                return this.projectionDays5Field;
            }
            set {
                this.projectionDays5Field = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ProjectionDays5 {
            get {
                return this.translated_ProjectionDays5Field;
            }
            set {
                this.translated_ProjectionDays5Field = value;
            }
        }
        
        /// <remarks/>
        public string ProjectionDays6 {
            get {
                return this.projectionDays6Field;
            }
            set {
                this.projectionDays6Field = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ProjectionDays6 {
            get {
                return this.translated_ProjectionDays6Field;
            }
            set {
                this.translated_ProjectionDays6Field = value;
            }
        }
        
        /// <remarks/>
        public string ProjectionDays7 {
            get {
                return this.projectionDays7Field;
            }
            set {
                this.projectionDays7Field = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ProjectionDays7 {
            get {
                return this.translated_ProjectionDays7Field;
            }
            set {
                this.translated_ProjectionDays7Field = value;
            }
        }
        
        /// <remarks/>
        public string BasedOnDate {
            get {
                return this.basedOnDateField;
            }
            set {
                this.basedOnDateField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_BasedOnDate {
            get {
                return this.translated_BasedOnDateField;
            }
            set {
                this.translated_BasedOnDateField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeOrdersInSuspense {
            get {
                return this.includeOrdersInSuspenseField;
            }
            set {
                this.includeOrdersInSuspenseField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_IncludeOrdersInSuspense {
            get {
                return this.translated_IncludeOrdersInSuspenseField;
            }
            set {
                this.translated_IncludeOrdersInSuspenseField = value;
            }
        }
        
        /// <remarks/>
        public string CurrencyValues {
            get {
                return this.currencyValuesField;
            }
            set {
                this.currencyValuesField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_CurrencyValues {
            get {
                return this.translated_CurrencyValuesField;
            }
            set {
                this.translated_CurrencyValuesField = value;
            }
        }
        
        /// <remarks/>
        public string ConvertToLocalValue {
            get {
                return this.convertToLocalValueField;
            }
            set {
                this.convertToLocalValueField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_ConvertToLocalValue {
            get {
                return this.translated_ConvertToLocalValueField;
            }
            set {
                this.translated_ConvertToLocalValueField = value;
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
        public string CustomerFilterValue {
            get {
                return this.customerFilterValueField;
            }
            set {
                this.customerFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrderFilterType {
            get {
                return this.salesOrderFilterTypeField;
            }
            set {
                this.salesOrderFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_SalesOrderFilterType {
            get {
                return this.translated_SalesOrderFilterTypeField;
            }
            set {
                this.translated_SalesOrderFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrderFilterValue {
            get {
                return this.salesOrderFilterValueField;
            }
            set {
                this.salesOrderFilterValueField = value;
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
        public string BranchFilterValue {
            get {
                return this.branchFilterValueField;
            }
            set {
                this.branchFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string CurrencyFilterType {
            get {
                return this.currencyFilterTypeField;
            }
            set {
                this.currencyFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_CurrencyFilterType {
            get {
                return this.translated_CurrencyFilterTypeField;
            }
            set {
                this.translated_CurrencyFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string CurrencyFilterValue {
            get {
                return this.currencyFilterValueField;
            }
            set {
                this.currencyFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorAccessSecurity {
            get {
                return this.operatorAccessSecurityField;
            }
            set {
                this.operatorAccessSecurityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SalesOrderCommitmentSalesOrderDetail {
        
        private string customerField;
        
        private string nameField;
        
        private string salesOrderField;
        
        private string orderInProcessField;
        
        private string translated_OrderInProcessField;
        
        private double pastDueField;
        
        private bool pastDueFieldSpecified;
        
        private string editedPastDueField;
        
        private double commitment1Field;
        
        private bool commitment1FieldSpecified;
        
        private string editedCommitment1Field;
        
        private double commitment2Field;
        
        private bool commitment2FieldSpecified;
        
        private string editedCommitment2Field;
        
        private double commitment3Field;
        
        private bool commitment3FieldSpecified;
        
        private string editedCommitment3Field;
        
        private double commitment4Field;
        
        private bool commitment4FieldSpecified;
        
        private string editedCommitment4Field;
        
        private double commitment5Field;
        
        private bool commitment5FieldSpecified;
        
        private string editedCommitment5Field;
        
        private double commitment6Field;
        
        private bool commitment6FieldSpecified;
        
        private string editedCommitment6Field;
        
        private double commitment7Field;
        
        private bool commitment7FieldSpecified;
        
        private string editedCommitment7Field;
        
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
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }
        
        /// <remarks/>
        public string OrderInProcess {
            get {
                return this.orderInProcessField;
            }
            set {
                this.orderInProcessField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_OrderInProcess {
            get {
                return this.translated_OrderInProcessField;
            }
            set {
                this.translated_OrderInProcessField = value;
            }
        }
        
        /// <remarks/>
        public double PastDue {
            get {
                return this.pastDueField;
            }
            set {
                this.pastDueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PastDueSpecified {
            get {
                return this.pastDueFieldSpecified;
            }
            set {
                this.pastDueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string EditedPastDue {
            get {
                return this.editedPastDueField;
            }
            set {
                this.editedPastDueField = value;
            }
        }
        
        /// <remarks/>
        public double Commitment1 {
            get {
                return this.commitment1Field;
            }
            set {
                this.commitment1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Commitment1Specified {
            get {
                return this.commitment1FieldSpecified;
            }
            set {
                this.commitment1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string EditedCommitment1 {
            get {
                return this.editedCommitment1Field;
            }
            set {
                this.editedCommitment1Field = value;
            }
        }
        
        /// <remarks/>
        public double Commitment2 {
            get {
                return this.commitment2Field;
            }
            set {
                this.commitment2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Commitment2Specified {
            get {
                return this.commitment2FieldSpecified;
            }
            set {
                this.commitment2FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string EditedCommitment2 {
            get {
                return this.editedCommitment2Field;
            }
            set {
                this.editedCommitment2Field = value;
            }
        }
        
        /// <remarks/>
        public double Commitment3 {
            get {
                return this.commitment3Field;
            }
            set {
                this.commitment3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Commitment3Specified {
            get {
                return this.commitment3FieldSpecified;
            }
            set {
                this.commitment3FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string EditedCommitment3 {
            get {
                return this.editedCommitment3Field;
            }
            set {
                this.editedCommitment3Field = value;
            }
        }
        
        /// <remarks/>
        public double Commitment4 {
            get {
                return this.commitment4Field;
            }
            set {
                this.commitment4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Commitment4Specified {
            get {
                return this.commitment4FieldSpecified;
            }
            set {
                this.commitment4FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string EditedCommitment4 {
            get {
                return this.editedCommitment4Field;
            }
            set {
                this.editedCommitment4Field = value;
            }
        }
        
        /// <remarks/>
        public double Commitment5 {
            get {
                return this.commitment5Field;
            }
            set {
                this.commitment5Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Commitment5Specified {
            get {
                return this.commitment5FieldSpecified;
            }
            set {
                this.commitment5FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string EditedCommitment5 {
            get {
                return this.editedCommitment5Field;
            }
            set {
                this.editedCommitment5Field = value;
            }
        }
        
        /// <remarks/>
        public double Commitment6 {
            get {
                return this.commitment6Field;
            }
            set {
                this.commitment6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Commitment6Specified {
            get {
                return this.commitment6FieldSpecified;
            }
            set {
                this.commitment6FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string EditedCommitment6 {
            get {
                return this.editedCommitment6Field;
            }
            set {
                this.editedCommitment6Field = value;
            }
        }
        
        /// <remarks/>
        public double Commitment7 {
            get {
                return this.commitment7Field;
            }
            set {
                this.commitment7Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Commitment7Specified {
            get {
                return this.commitment7FieldSpecified;
            }
            set {
                this.commitment7FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string EditedCommitment7 {
            get {
                return this.editedCommitment7Field;
            }
            set {
                this.editedCommitment7Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SalesOrderCommitmentCompanyTotals {
        
        private double companyTotalPastDueField;
        
        private string editedCompanyTotalPastDueField;
        
        private double companyTotalCommitment1Field;
        
        private string editedCompanyTotalCommitment1Field;
        
        private double companyTotalCommitment2Field;
        
        private string editedCompanyTotalCommitment2Field;
        
        private double companyTotalCommitment3Field;
        
        private string editedCompanyTotalCommitment3Field;
        
        private double companyTotalCommitment4Field;
        
        private string editedCompanyTotalCommitment4Field;
        
        private double companyTotalCommitment5Field;
        
        private string editedCompanyTotalCommitment5Field;
        
        private double companyTotalCommitment6Field;
        
        private string editedCompanyTotalCommitment6Field;
        
        private double companyTotalCommitment7Field;
        
        private string editedCompanyTotalCommitment7Field;
        
        private string validOrdersProcessedField;
        
        /// <remarks/>
        public double CompanyTotalPastDue {
            get {
                return this.companyTotalPastDueField;
            }
            set {
                this.companyTotalPastDueField = value;
            }
        }
        
        /// <remarks/>
        public string EditedCompanyTotalPastDue {
            get {
                return this.editedCompanyTotalPastDueField;
            }
            set {
                this.editedCompanyTotalPastDueField = value;
            }
        }
        
        /// <remarks/>
        public double CompanyTotalCommitment1 {
            get {
                return this.companyTotalCommitment1Field;
            }
            set {
                this.companyTotalCommitment1Field = value;
            }
        }
        
        /// <remarks/>
        public string EditedCompanyTotalCommitment1 {
            get {
                return this.editedCompanyTotalCommitment1Field;
            }
            set {
                this.editedCompanyTotalCommitment1Field = value;
            }
        }
        
        /// <remarks/>
        public double CompanyTotalCommitment2 {
            get {
                return this.companyTotalCommitment2Field;
            }
            set {
                this.companyTotalCommitment2Field = value;
            }
        }
        
        /// <remarks/>
        public string EditedCompanyTotalCommitment2 {
            get {
                return this.editedCompanyTotalCommitment2Field;
            }
            set {
                this.editedCompanyTotalCommitment2Field = value;
            }
        }
        
        /// <remarks/>
        public double CompanyTotalCommitment3 {
            get {
                return this.companyTotalCommitment3Field;
            }
            set {
                this.companyTotalCommitment3Field = value;
            }
        }
        
        /// <remarks/>
        public string EditedCompanyTotalCommitment3 {
            get {
                return this.editedCompanyTotalCommitment3Field;
            }
            set {
                this.editedCompanyTotalCommitment3Field = value;
            }
        }
        
        /// <remarks/>
        public double CompanyTotalCommitment4 {
            get {
                return this.companyTotalCommitment4Field;
            }
            set {
                this.companyTotalCommitment4Field = value;
            }
        }
        
        /// <remarks/>
        public string EditedCompanyTotalCommitment4 {
            get {
                return this.editedCompanyTotalCommitment4Field;
            }
            set {
                this.editedCompanyTotalCommitment4Field = value;
            }
        }
        
        /// <remarks/>
        public double CompanyTotalCommitment5 {
            get {
                return this.companyTotalCommitment5Field;
            }
            set {
                this.companyTotalCommitment5Field = value;
            }
        }
        
        /// <remarks/>
        public string EditedCompanyTotalCommitment5 {
            get {
                return this.editedCompanyTotalCommitment5Field;
            }
            set {
                this.editedCompanyTotalCommitment5Field = value;
            }
        }
        
        /// <remarks/>
        public double CompanyTotalCommitment6 {
            get {
                return this.companyTotalCommitment6Field;
            }
            set {
                this.companyTotalCommitment6Field = value;
            }
        }
        
        /// <remarks/>
        public string EditedCompanyTotalCommitment6 {
            get {
                return this.editedCompanyTotalCommitment6Field;
            }
            set {
                this.editedCompanyTotalCommitment6Field = value;
            }
        }
        
        /// <remarks/>
        public double CompanyTotalCommitment7 {
            get {
                return this.companyTotalCommitment7Field;
            }
            set {
                this.companyTotalCommitment7Field = value;
            }
        }
        
        /// <remarks/>
        public string EditedCompanyTotalCommitment7 {
            get {
                return this.editedCompanyTotalCommitment7Field;
            }
            set {
                this.editedCompanyTotalCommitment7Field = value;
            }
        }
        
        /// <remarks/>
        public string ValidOrdersProcessed {
            get {
                return this.validOrdersProcessedField;
            }
            set {
                this.validOrdersProcessedField = value;
            }
        }
    }
}
