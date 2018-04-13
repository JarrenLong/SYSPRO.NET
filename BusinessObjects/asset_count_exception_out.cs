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
namespace SYSPRO.NET.BusinessObjects.asset_count_exception_out {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class AssetCountExceptionReport {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssetCountExceptions", typeof(AssetCountExceptionReportAssetCountExceptions), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", typeof(AssetCountExceptionReportQueryOptions), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", typeof(AssetCountExceptionReportSystemInformation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    public partial class AssetCountExceptionReportAssetCountExceptions {
        
        private AssetCountExceptionReportAssetCountExceptionsAssetCountException[] assetCountExceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssetCountException", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AssetCountExceptionReportAssetCountExceptionsAssetCountException[] AssetCountException {
            get {
                return this.assetCountExceptionField;
            }
            set {
                this.assetCountExceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class AssetCountExceptionReportAssetCountExceptionsAssetCountException {
        
        private string branchField;
        
        private string aSSBRN_DescriptionField;
        
        private string locationField;
        
        private string aSSLOC_LocationField;
        
        private string assetCodeField;
        
        private string aSSMST_DescriptionField;
        
        private string groupField;
        
        private string aSSGRP_DescriptionField;
        
        private string typeField;
        
        private string aSSTYP_DescriptionField;
        
        private string iDCodeField;
        
        private string registrationField;
        
        private string chassisNumField;
        
        private double savedQtyField;
        
        private bool savedQtyFieldSpecified;
        
        private double qtyCapturedField;
        
        private bool qtyCapturedFieldSpecified;
        
        private double qtyVerifiedField;
        
        private bool qtyVerifiedFieldSpecified;
        
        private string extractedNotCountedField;
        
        private string countedNotExtractedField;
        
        private string verifiedNotCountedField;
        
        private string countedNotVerifiedField;
        
        private string differenceInBranchField;
        
        private string differenceInLocationField;
        
        private string differenceInIdCodeField;
        
        private string differenceInCountVerifiedExtractedField;
        
        private string newIdCodeField;
        
        private string masterAssetField;
        
        private AssetCountExceptionReportAssetCountExceptionsAssetCountExceptionAssetInOtherCountLocationsAssetInOtherCountLocation[][] assetInOtherCountLocationsField;
        
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
        public string ASSBRN_Description {
            get {
                return this.aSSBRN_DescriptionField;
            }
            set {
                this.aSSBRN_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ASSLOC_Location {
            get {
                return this.aSSLOC_LocationField;
            }
            set {
                this.aSSLOC_LocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AssetCode {
            get {
                return this.assetCodeField;
            }
            set {
                this.assetCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ASSMST_Description {
            get {
                return this.aSSMST_DescriptionField;
            }
            set {
                this.aSSMST_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Group {
            get {
                return this.groupField;
            }
            set {
                this.groupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ASSGRP_Description {
            get {
                return this.aSSGRP_DescriptionField;
            }
            set {
                this.aSSGRP_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ASSTYP_Description {
            get {
                return this.aSSTYP_DescriptionField;
            }
            set {
                this.aSSTYP_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IDCode {
            get {
                return this.iDCodeField;
            }
            set {
                this.iDCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Registration {
            get {
                return this.registrationField;
            }
            set {
                this.registrationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ChassisNum {
            get {
                return this.chassisNumField;
            }
            set {
                this.chassisNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double SavedQty {
            get {
                return this.savedQtyField;
            }
            set {
                this.savedQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SavedQtySpecified {
            get {
                return this.savedQtyFieldSpecified;
            }
            set {
                this.savedQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double QtyCaptured {
            get {
                return this.qtyCapturedField;
            }
            set {
                this.qtyCapturedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtyCapturedSpecified {
            get {
                return this.qtyCapturedFieldSpecified;
            }
            set {
                this.qtyCapturedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double QtyVerified {
            get {
                return this.qtyVerifiedField;
            }
            set {
                this.qtyVerifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtyVerifiedSpecified {
            get {
                return this.qtyVerifiedFieldSpecified;
            }
            set {
                this.qtyVerifiedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ExtractedNotCounted {
            get {
                return this.extractedNotCountedField;
            }
            set {
                this.extractedNotCountedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CountedNotExtracted {
            get {
                return this.countedNotExtractedField;
            }
            set {
                this.countedNotExtractedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VerifiedNotCounted {
            get {
                return this.verifiedNotCountedField;
            }
            set {
                this.verifiedNotCountedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CountedNotVerified {
            get {
                return this.countedNotVerifiedField;
            }
            set {
                this.countedNotVerifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DifferenceInBranch {
            get {
                return this.differenceInBranchField;
            }
            set {
                this.differenceInBranchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DifferenceInLocation {
            get {
                return this.differenceInLocationField;
            }
            set {
                this.differenceInLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DifferenceInIdCode {
            get {
                return this.differenceInIdCodeField;
            }
            set {
                this.differenceInIdCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DifferenceInCountVerifiedExtracted {
            get {
                return this.differenceInCountVerifiedExtractedField;
            }
            set {
                this.differenceInCountVerifiedExtractedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NewIdCode {
            get {
                return this.newIdCodeField;
            }
            set {
                this.newIdCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MasterAsset {
            get {
                return this.masterAssetField;
            }
            set {
                this.masterAssetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AssetInOtherCountLocation", typeof(AssetCountExceptionReportAssetCountExceptionsAssetCountExceptionAssetInOtherCountLocationsAssetInOtherCountLocation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public AssetCountExceptionReportAssetCountExceptionsAssetCountExceptionAssetInOtherCountLocationsAssetInOtherCountLocation[][] AssetInOtherCountLocations {
            get {
                return this.assetInOtherCountLocationsField;
            }
            set {
                this.assetInOtherCountLocationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class AssetCountExceptionReportAssetCountExceptionsAssetCountExceptionAssetInOtherCountLocationsAssetInOtherCountLocation {
        
        private string branchField;
        
        private string aSSBRN_DescriptionField;
        
        private string locationField;
        
        private string aSSLOC_DescriptionField;
        
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
        public string ASSBRN_Description {
            get {
                return this.aSSBRN_DescriptionField;
            }
            set {
                this.aSSBRN_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ASSLOC_Description {
            get {
                return this.aSSLOC_DescriptionField;
            }
            set {
                this.aSSLOC_DescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class AssetCountExceptionReportQueryOptions {
        
        private string branchFilterTypeField;
        
        private string branchFilterValueField;
        
        private string locationFilterTypeField;
        
        private string locationFilterValueField;
        
        private string countItemSelectionsField;
        
        private string includeExtractedNotCountedField;
        
        private string includeCountedNotExtractedField;
        
        private string includeVerifiedNotCountedField;
        
        private string includeCountedNotVerifiedField;
        
        private string includeDifferenceInBranchField;
        
        private string includeDifferenceInLocationField;
        
        private string includeDifferenceInIDCodeField;
        
        private string includeDifferenceCountedVerifiedExtractedField;
        
        private string includeNewIDCodeField;
        
        private string includeAssetsFoundInOtherLocationsField;
        
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
        public string LocationFilterType {
            get {
                return this.locationFilterTypeField;
            }
            set {
                this.locationFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LocationFilterValue {
            get {
                return this.locationFilterValueField;
            }
            set {
                this.locationFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CountItemSelections {
            get {
                return this.countItemSelectionsField;
            }
            set {
                this.countItemSelectionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeExtractedNotCounted {
            get {
                return this.includeExtractedNotCountedField;
            }
            set {
                this.includeExtractedNotCountedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeCountedNotExtracted {
            get {
                return this.includeCountedNotExtractedField;
            }
            set {
                this.includeCountedNotExtractedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeVerifiedNotCounted {
            get {
                return this.includeVerifiedNotCountedField;
            }
            set {
                this.includeVerifiedNotCountedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeCountedNotVerified {
            get {
                return this.includeCountedNotVerifiedField;
            }
            set {
                this.includeCountedNotVerifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeDifferenceInBranch {
            get {
                return this.includeDifferenceInBranchField;
            }
            set {
                this.includeDifferenceInBranchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeDifferenceInLocation {
            get {
                return this.includeDifferenceInLocationField;
            }
            set {
                this.includeDifferenceInLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeDifferenceInIDCode {
            get {
                return this.includeDifferenceInIDCodeField;
            }
            set {
                this.includeDifferenceInIDCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeDifferenceCountedVerifiedExtracted {
            get {
                return this.includeDifferenceCountedVerifiedExtractedField;
            }
            set {
                this.includeDifferenceCountedVerifiedExtractedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeNewIDCode {
            get {
                return this.includeNewIDCodeField;
            }
            set {
                this.includeNewIDCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeAssetsFoundInOtherLocations {
            get {
                return this.includeAssetsFoundInOtherLocationsField;
            }
            set {
                this.includeAssetsFoundInOtherLocationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class AssetCountExceptionReportSystemInformation {
        
        private string cssStyleField;
        
        private string languageField;
        
        private double decFormatField;
        
        private bool decFormatFieldSpecified;
        
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
        public double DecFormat {
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
    }
}
