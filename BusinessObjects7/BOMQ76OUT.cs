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
namespace SYSPRO.NET.BusinessObjects.BOMQ76OUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BOMStructureAmendmentJournal {
        
        private BOMStructureAmendmentJournalSystemInformation[] systemInformationField;
        
        private BOMStructureAmendmentJournalQueryOptions[] queryOptionsField;
        
        private BOMStructureAmendmentJournalAmendmentDetailsAmendment[][] amendmentDetailsField;
        
        private BOMStructureAmendmentJournalFileDeleted[] fileDeletedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BOMStructureAmendmentJournalSystemInformation[] SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BOMStructureAmendmentJournalQueryOptions[] QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Amendment", typeof(BOMStructureAmendmentJournalAmendmentDetailsAmendment), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public BOMStructureAmendmentJournalAmendmentDetailsAmendment[][] AmendmentDetails {
            get {
                return this.amendmentDetailsField;
            }
            set {
                this.amendmentDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FileDeleted", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BOMStructureAmendmentJournalFileDeleted[] FileDeleted {
            get {
                return this.fileDeletedField;
            }
            set {
                this.fileDeletedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BOMStructureAmendmentJournalSystemInformation {
        
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
        
        private string bOMQtyPerDecimalsField;
        
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
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
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
        public string LocalCurrency {
            get {
                return this.localCurrencyField;
            }
            set {
                this.localCurrencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LocalCurrencyDesc {
            get {
                return this.localCurrencyDescField;
            }
            set {
                this.localCurrencyDescField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string GlPrdPerYear {
            get {
                return this.glPrdPerYearField;
            }
            set {
                this.glPrdPerYearField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorPrimaryRole {
            get {
                return this.operatorPrimaryRoleField;
            }
            set {
                this.operatorPrimaryRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DecCharToUse {
            get {
                return this.decCharToUseField;
            }
            set {
                this.decCharToUseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BOMQtyPerDecimals {
            get {
                return this.bOMQtyPerDecimalsField;
            }
            set {
                this.bOMQtyPerDecimalsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BOMStructureAmendmentJournalQueryOptions {
        
        private string reprintField;
        
        private string translated_ReprintField;
        
        private string printAdditionsField;
        
        private string translated_PrintAdditionsField;
        
        private string printChangesField;
        
        private string translated_PrintChangesField;
        
        private string printDeletionsField;
        
        private string translated_PrintDeletionsField;
        
        private string deleteJournalFileAfterReportField;
        
        private string translated_DeleteJournalFileAfterReportField;
        
        private string printManufacturingUMQuantitiesField;
        
        private string translated_PrintManufacturingUMQuantitiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reprint {
            get {
                return this.reprintField;
            }
            set {
                this.reprintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_Reprint {
            get {
                return this.translated_ReprintField;
            }
            set {
                this.translated_ReprintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrintAdditions {
            get {
                return this.printAdditionsField;
            }
            set {
                this.printAdditionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_PrintAdditions {
            get {
                return this.translated_PrintAdditionsField;
            }
            set {
                this.translated_PrintAdditionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrintChanges {
            get {
                return this.printChangesField;
            }
            set {
                this.printChangesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_PrintChanges {
            get {
                return this.translated_PrintChangesField;
            }
            set {
                this.translated_PrintChangesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrintDeletions {
            get {
                return this.printDeletionsField;
            }
            set {
                this.printDeletionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_PrintDeletions {
            get {
                return this.translated_PrintDeletionsField;
            }
            set {
                this.translated_PrintDeletionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DeleteJournalFileAfterReport {
            get {
                return this.deleteJournalFileAfterReportField;
            }
            set {
                this.deleteJournalFileAfterReportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_DeleteJournalFileAfterReport {
            get {
                return this.translated_DeleteJournalFileAfterReportField;
            }
            set {
                this.translated_DeleteJournalFileAfterReportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrintManufacturingUMQuantities {
            get {
                return this.printManufacturingUMQuantitiesField;
            }
            set {
                this.printManufacturingUMQuantitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_PrintManufacturingUMQuantities {
            get {
                return this.translated_PrintManufacturingUMQuantitiesField;
            }
            set {
                this.translated_PrintManufacturingUMQuantitiesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BOMStructureAmendmentJournalAmendmentDetailsAmendment {
        
        private string amendmentTypeField;
        
        private string translated_AmendmentTypeField;
        
        private string jnlDateField;
        
        private string jnlTimeField;
        
        private string jnlLineField;
        
        private string parentPartField;
        
        private string iNVMST_ParentDescriptionField;
        
        private string versionField;
        
        private string releaseField;
        
        private string routeField;
        
        private string sequenceNumField;
        
        private string componentField;
        
        private string iNVMST_ComponentDescriptionField;
        
        private string iNVMST_StockUomField;
        
        private string operatorField;
        
        private string reasonField;
        
        private string comVersionField;
        
        private string comReleaseField;
        
        private object eccConsumptionField;
        
        private object overEccSpecIssueField;
        
        private string structOnDateField;
        
        private string structOffDateField;
        
        private string opOffsetFlagField;
        
        private string translated_OpOffsetFlagField;
        
        private string operationOffsetField;
        
        private string translated_OperationOffsetField;
        
        private double qtyPerField;
        
        private bool qtyPerFieldSpecified;
        
        private string edited_QtyPerField;
        
        private string scrapPctField;
        
        private string edited_ScrapPctField;
        
        private double scrapQtyField;
        
        private bool scrapQtyFieldSpecified;
        
        private string edited_ScrapQtyField;
        
        private BOMStructureAmendmentJournalAmendmentDetailsAmendmentComponentAmendment[] componentAmendmentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AmendmentType {
            get {
                return this.amendmentTypeField;
            }
            set {
                this.amendmentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_AmendmentType {
            get {
                return this.translated_AmendmentTypeField;
            }
            set {
                this.translated_AmendmentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JnlDate {
            get {
                return this.jnlDateField;
            }
            set {
                this.jnlDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JnlTime {
            get {
                return this.jnlTimeField;
            }
            set {
                this.jnlTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string JnlLine {
            get {
                return this.jnlLineField;
            }
            set {
                this.jnlLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ParentPart {
            get {
                return this.parentPartField;
            }
            set {
                this.parentPartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVMST_ParentDescription {
            get {
                return this.iNVMST_ParentDescriptionField;
            }
            set {
                this.iNVMST_ParentDescriptionField = value;
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
        public string Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Route {
            get {
                return this.routeField;
            }
            set {
                this.routeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SequenceNum {
            get {
                return this.sequenceNumField;
            }
            set {
                this.sequenceNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVMST_ComponentDescription {
            get {
                return this.iNVMST_ComponentDescriptionField;
            }
            set {
                this.iNVMST_ComponentDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVMST_StockUom {
            get {
                return this.iNVMST_StockUomField;
            }
            set {
                this.iNVMST_StockUomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ComVersion {
            get {
                return this.comVersionField;
            }
            set {
                this.comVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ComRelease {
            get {
                return this.comReleaseField;
            }
            set {
                this.comReleaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object EccConsumption {
            get {
                return this.eccConsumptionField;
            }
            set {
                this.eccConsumptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object OverEccSpecIssue {
            get {
                return this.overEccSpecIssueField;
            }
            set {
                this.overEccSpecIssueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StructOnDate {
            get {
                return this.structOnDateField;
            }
            set {
                this.structOnDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StructOffDate {
            get {
                return this.structOffDateField;
            }
            set {
                this.structOffDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OpOffsetFlag {
            get {
                return this.opOffsetFlagField;
            }
            set {
                this.opOffsetFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_OpOffsetFlag {
            get {
                return this.translated_OpOffsetFlagField;
            }
            set {
                this.translated_OpOffsetFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperationOffset {
            get {
                return this.operationOffsetField;
            }
            set {
                this.operationOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_OperationOffset {
            get {
                return this.translated_OperationOffsetField;
            }
            set {
                this.translated_OperationOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double QtyPer {
            get {
                return this.qtyPerField;
            }
            set {
                this.qtyPerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtyPerSpecified {
            get {
                return this.qtyPerFieldSpecified;
            }
            set {
                this.qtyPerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_QtyPer {
            get {
                return this.edited_QtyPerField;
            }
            set {
                this.edited_QtyPerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ScrapPct {
            get {
                return this.scrapPctField;
            }
            set {
                this.scrapPctField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_ScrapPct {
            get {
                return this.edited_ScrapPctField;
            }
            set {
                this.edited_ScrapPctField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double ScrapQty {
            get {
                return this.scrapQtyField;
            }
            set {
                this.scrapQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScrapQtySpecified {
            get {
                return this.scrapQtyFieldSpecified;
            }
            set {
                this.scrapQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_ScrapQty {
            get {
                return this.edited_ScrapQtyField;
            }
            set {
                this.edited_ScrapQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComponentAmendment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BOMStructureAmendmentJournalAmendmentDetailsAmendmentComponentAmendment[] ComponentAmendment {
            get {
                return this.componentAmendmentField;
            }
            set {
                this.componentAmendmentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BOMStructureAmendmentJournalAmendmentDetailsAmendmentComponentAmendment {
        
        private string fieldDescriptionField;
        
        private string oldFieldValueField;
        
        private string newFieldValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FieldDescription {
            get {
                return this.fieldDescriptionField;
            }
            set {
                this.fieldDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OldFieldValue {
            get {
                return this.oldFieldValueField;
            }
            set {
                this.oldFieldValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NewFieldValue {
            get {
                return this.newFieldValueField;
            }
            set {
                this.newFieldValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BOMStructureAmendmentJournalFileDeleted {
        
        private string deleteField;
        
        private string translated_DeleteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Delete {
            get {
                return this.deleteField;
            }
            set {
                this.deleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_Delete {
            get {
                return this.translated_DeleteField;
            }
            set {
                this.translated_DeleteField = value;
            }
        }
    }
}
