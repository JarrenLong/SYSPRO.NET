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
namespace SYSPRO.NET.BusinessObjects.APSQ73OUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class APPurchaseAnalysisHistory {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompanyTotals", typeof(APPurchaseAnalysisHistoryCompanyTotals), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", typeof(APPurchaseAnalysisHistoryQueryOptions), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Suppliers", typeof(APPurchaseAnalysisHistorySuppliers), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", typeof(APPurchaseAnalysisHistorySystemInformation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items {
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
    public partial class APPurchaseAnalysisHistoryCompanyTotals {
        
        private APPurchaseAnalysisHistoryCompanyTotalsSupplierTotals[] supplierTotalsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplierTotals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public APPurchaseAnalysisHistoryCompanyTotalsSupplierTotals[] SupplierTotals {
            get {
                return this.supplierTotalsField;
            }
            set {
                this.supplierTotalsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APPurchaseAnalysisHistoryCompanyTotalsSupplierTotals {
        
        private string supplierTotalsCurrentField;
        
        private string supplierTotalsPrev1Field;
        
        private string supplierTotalsPrev2Field;
        
        private string supplierTotalsPrev3Field;
        
        private string supplierTotalsPrev4Field;
        
        private string supplierTotalsPrev5Field;
        
        private string supplierTotalsPrev6Field;
        
        private string supplierTotalsPrev7Field;
        
        private string supplierTotalsPrev8Field;
        
        private string supplierTotalsPrev9Field;
        
        private string supplierTotalsPrev10Field;
        
        private string supplierTotalsPrev11Field;
        
        private string supplierPrevYearPurchasesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsCurrent {
            get {
                return this.supplierTotalsCurrentField;
            }
            set {
                this.supplierTotalsCurrentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev1 {
            get {
                return this.supplierTotalsPrev1Field;
            }
            set {
                this.supplierTotalsPrev1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev2 {
            get {
                return this.supplierTotalsPrev2Field;
            }
            set {
                this.supplierTotalsPrev2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev3 {
            get {
                return this.supplierTotalsPrev3Field;
            }
            set {
                this.supplierTotalsPrev3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev4 {
            get {
                return this.supplierTotalsPrev4Field;
            }
            set {
                this.supplierTotalsPrev4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev5 {
            get {
                return this.supplierTotalsPrev5Field;
            }
            set {
                this.supplierTotalsPrev5Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev6 {
            get {
                return this.supplierTotalsPrev6Field;
            }
            set {
                this.supplierTotalsPrev6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev7 {
            get {
                return this.supplierTotalsPrev7Field;
            }
            set {
                this.supplierTotalsPrev7Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev8 {
            get {
                return this.supplierTotalsPrev8Field;
            }
            set {
                this.supplierTotalsPrev8Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev9 {
            get {
                return this.supplierTotalsPrev9Field;
            }
            set {
                this.supplierTotalsPrev9Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev10 {
            get {
                return this.supplierTotalsPrev10Field;
            }
            set {
                this.supplierTotalsPrev10Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev11 {
            get {
                return this.supplierTotalsPrev11Field;
            }
            set {
                this.supplierTotalsPrev11Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierPrevYearPurchases {
            get {
                return this.supplierPrevYearPurchasesField;
            }
            set {
                this.supplierPrevYearPurchasesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APPurchaseAnalysisHistoryQueryOptions {
        
        private string reportSequenceField;
        
        private string printIfHistoryZeroField;
        
        private string tagFileField;
        
        private string supplierFilterTypeField;
        
        private string supplierFilterValueField;
        
        private string branchFilterTypeField;
        
        private string branchFilterValueField;
        
        private string supplierClassFilterTypeField;
        
        private string supplierClassFilterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReportSequence {
            get {
                return this.reportSequenceField;
            }
            set {
                this.reportSequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrintIfHistoryZero {
            get {
                return this.printIfHistoryZeroField;
            }
            set {
                this.printIfHistoryZeroField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TagFile {
            get {
                return this.tagFileField;
            }
            set {
                this.tagFileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierFilterType {
            get {
                return this.supplierFilterTypeField;
            }
            set {
                this.supplierFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierFilterValue {
            get {
                return this.supplierFilterValueField;
            }
            set {
                this.supplierFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BranchFilterType {
            get {
                return this.branchFilterTypeField;
            }
            set {
                this.branchFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BranchFilterValue {
            get {
                return this.branchFilterValueField;
            }
            set {
                this.branchFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierClassFilterType {
            get {
                return this.supplierClassFilterTypeField;
            }
            set {
                this.supplierClassFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierClassFilterValue {
            get {
                return this.supplierClassFilterValueField;
            }
            set {
                this.supplierClassFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APPurchaseAnalysisHistorySuppliers {
        
        private APPurchaseAnalysisHistorySuppliersSupplierHeader[] supplierHeaderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplierHeader", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public APPurchaseAnalysisHistorySuppliersSupplierHeader[] SupplierHeader {
            get {
                return this.supplierHeaderField;
            }
            set {
                this.supplierHeaderField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APPurchaseAnalysisHistorySuppliersSupplierHeader {
        
        private string supplierField;
        
        private string aPSMST_DescriptionField;
        
        private string supplierOnHoldField;
        
        private APPurchaseAnalysisHistorySuppliersSupplierHeaderHistoryAnalysis[] historyAnalysisField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APSMST_Description {
            get {
                return this.aPSMST_DescriptionField;
            }
            set {
                this.aPSMST_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierOnHold {
            get {
                return this.supplierOnHoldField;
            }
            set {
                this.supplierOnHoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HistoryAnalysis", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public APPurchaseAnalysisHistorySuppliersSupplierHeaderHistoryAnalysis[] HistoryAnalysis {
            get {
                return this.historyAnalysisField;
            }
            set {
                this.historyAnalysisField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APPurchaseAnalysisHistorySuppliersSupplierHeaderHistoryAnalysis {
        
        private string classField;
        
        private string tBLAPC_DescriptionField;
        
        private string branchField;
        
        private string aPSBRN_DescriptionField;
        
        private string supplierTotalsCurrentField;
        
        private string supplierTotalsPrev1Field;
        
        private string supplierTotalsPrev2Field;
        
        private string supplierTotalsPrev3Field;
        
        private string supplierTotalsPrev4Field;
        
        private string supplierTotalsPrev5Field;
        
        private string supplierTotalsPrev6Field;
        
        private string supplierTotalsPrev7Field;
        
        private string supplierTotalsPrev8Field;
        
        private string supplierTotalsPrev9Field;
        
        private string supplierTotalsPrev10Field;
        
        private string supplierTotalsPrev11Field;
        
        private string supplierPrevYearPurchasesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TBLAPC_Description {
            get {
                return this.tBLAPC_DescriptionField;
            }
            set {
                this.tBLAPC_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APSBRN_Description {
            get {
                return this.aPSBRN_DescriptionField;
            }
            set {
                this.aPSBRN_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsCurrent {
            get {
                return this.supplierTotalsCurrentField;
            }
            set {
                this.supplierTotalsCurrentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev1 {
            get {
                return this.supplierTotalsPrev1Field;
            }
            set {
                this.supplierTotalsPrev1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev2 {
            get {
                return this.supplierTotalsPrev2Field;
            }
            set {
                this.supplierTotalsPrev2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev3 {
            get {
                return this.supplierTotalsPrev3Field;
            }
            set {
                this.supplierTotalsPrev3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev4 {
            get {
                return this.supplierTotalsPrev4Field;
            }
            set {
                this.supplierTotalsPrev4Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev5 {
            get {
                return this.supplierTotalsPrev5Field;
            }
            set {
                this.supplierTotalsPrev5Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev6 {
            get {
                return this.supplierTotalsPrev6Field;
            }
            set {
                this.supplierTotalsPrev6Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev7 {
            get {
                return this.supplierTotalsPrev7Field;
            }
            set {
                this.supplierTotalsPrev7Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev8 {
            get {
                return this.supplierTotalsPrev8Field;
            }
            set {
                this.supplierTotalsPrev8Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev9 {
            get {
                return this.supplierTotalsPrev9Field;
            }
            set {
                this.supplierTotalsPrev9Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev10 {
            get {
                return this.supplierTotalsPrev10Field;
            }
            set {
                this.supplierTotalsPrev10Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierTotalsPrev11 {
            get {
                return this.supplierTotalsPrev11Field;
            }
            set {
                this.supplierTotalsPrev11Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierPrevYearPurchases {
            get {
                return this.supplierPrevYearPurchasesField;
            }
            set {
                this.supplierPrevYearPurchasesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APPurchaseAnalysisHistorySystemInformation {
        
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
}
