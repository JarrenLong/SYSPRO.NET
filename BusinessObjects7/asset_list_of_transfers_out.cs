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
namespace SYSPRO.NET.BusinessObjects.asset_list_of_transfers_out {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QuerySystemInformation systemInformationField;
        
        private QueryQueryOptions queryOptionsField;
        
        private QueryListofTransfers listofTransfersField;
        
        /// <remarks/>
        public QuerySystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public QueryQueryOptions QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        public QueryListofTransfers ListofTransfers {
            get {
                return this.listofTransfersField;
            }
            set {
                this.listofTransfersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QuerySystemInformation {
        
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
        
        /// <remarks/>
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
    public partial class QueryQueryOptions {
        
        private string fromPeriodField;
        
        private string toPeriodField;
        
        private string assetFilterTypeField;
        
        private string translated_AssetFilterTypeField;
        
        private string assetFilterValueField;
        
        /// <remarks/>
        public string FromPeriod {
            get {
                return this.fromPeriodField;
            }
            set {
                this.fromPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string ToPeriod {
            get {
                return this.toPeriodField;
            }
            set {
                this.toPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string AssetFilterType {
            get {
                return this.assetFilterTypeField;
            }
            set {
                this.assetFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Translated_AssetFilterType {
            get {
                return this.translated_AssetFilterTypeField;
            }
            set {
                this.translated_AssetFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string AssetFilterValue {
            get {
                return this.assetFilterValueField;
            }
            set {
                this.assetFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfers {
        
        private QueryListofTransfersAssets[] assetsField;
        
        private QueryListofTransfersCompanyAssetTotal[] companyAssetTotalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Assets")]
        public QueryListofTransfersAssets[] Assets {
            get {
                return this.assetsField;
            }
            set {
                this.assetsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompanyAssetTotal")]
        public QueryListofTransfersCompanyAssetTotal[] CompanyAssetTotal {
            get {
                return this.companyAssetTotalField;
            }
            set {
                this.companyAssetTotalField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfersAssets {
        
        private QueryListofTransfersAssetsAsset[] assetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Asset")]
        public QueryListofTransfersAssetsAsset[] Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfersAssetsAsset {
        
        private QueryListofTransfersAssetsAssetAssetDetail[] assetDetailField;
        
        private QueryListofTransfersAssetsAssetTransfers[] transfersField;
        
        private QueryListofTransfersAssetsAssetTotalTransfer[] totalTransferField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssetDetail")]
        public QueryListofTransfersAssetsAssetAssetDetail[] AssetDetail {
            get {
                return this.assetDetailField;
            }
            set {
                this.assetDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transfers")]
        public QueryListofTransfersAssetsAssetTransfers[] Transfers {
            get {
                return this.transfersField;
            }
            set {
                this.transfersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TotalTransfer")]
        public QueryListofTransfersAssetsAssetTotalTransfer[] TotalTransfer {
            get {
                return this.totalTransferField;
            }
            set {
                this.totalTransferField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfersAssetsAssetAssetDetail {
        
        private string assetCodeField;
        
        private string assetDescriptionField;
        
        /// <remarks/>
        public string AssetCode {
            get {
                return this.assetCodeField;
            }
            set {
                this.assetCodeField = value;
            }
        }
        
        /// <remarks/>
        public string AssetDescription {
            get {
                return this.assetDescriptionField;
            }
            set {
                this.assetDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfersAssetsAssetTransfers {
        
        private QueryListofTransfersAssetsAssetTransfersTransfer[] transferField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transfer")]
        public QueryListofTransfersAssetsAssetTransfersTransfer[] Transfer {
            get {
                return this.transferField;
            }
            set {
                this.transferField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfersAssetsAssetTransfersTransfer {
        
        private string entryDateField;
        
        private string fromCompanyField;
        
        private string toCompanyField;
        
        private string fromBranchField;
        
        private string fromBranchNameField;
        
        private string toBranchField;
        
        private string toBranchNameField;
        
        private string fromGroupField;
        
        private string fromGroupDescriptionField;
        
        private string toGroupAfterField;
        
        private string toGroupDescriptionField;
        
        private string fromCostCentreField;
        
        private string fromCostCentreDescriptionField;
        
        private string toCostCentreAfterField;
        
        private string toCostCentreDescriptionField;
        
        private string narrationField;
        
        private double depreciationValueField;
        
        private double transferValueField;
        
        private string edited_DepreciationValueField;
        
        private string edited_TransferValueField;
        
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
        public string FromCompany {
            get {
                return this.fromCompanyField;
            }
            set {
                this.fromCompanyField = value;
            }
        }
        
        /// <remarks/>
        public string ToCompany {
            get {
                return this.toCompanyField;
            }
            set {
                this.toCompanyField = value;
            }
        }
        
        /// <remarks/>
        public string FromBranch {
            get {
                return this.fromBranchField;
            }
            set {
                this.fromBranchField = value;
            }
        }
        
        /// <remarks/>
        public string FromBranchName {
            get {
                return this.fromBranchNameField;
            }
            set {
                this.fromBranchNameField = value;
            }
        }
        
        /// <remarks/>
        public string ToBranch {
            get {
                return this.toBranchField;
            }
            set {
                this.toBranchField = value;
            }
        }
        
        /// <remarks/>
        public string ToBranchName {
            get {
                return this.toBranchNameField;
            }
            set {
                this.toBranchNameField = value;
            }
        }
        
        /// <remarks/>
        public string FromGroup {
            get {
                return this.fromGroupField;
            }
            set {
                this.fromGroupField = value;
            }
        }
        
        /// <remarks/>
        public string FromGroupDescription {
            get {
                return this.fromGroupDescriptionField;
            }
            set {
                this.fromGroupDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string ToGroupAfter {
            get {
                return this.toGroupAfterField;
            }
            set {
                this.toGroupAfterField = value;
            }
        }
        
        /// <remarks/>
        public string ToGroupDescription {
            get {
                return this.toGroupDescriptionField;
            }
            set {
                this.toGroupDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string FromCostCentre {
            get {
                return this.fromCostCentreField;
            }
            set {
                this.fromCostCentreField = value;
            }
        }
        
        /// <remarks/>
        public string FromCostCentreDescription {
            get {
                return this.fromCostCentreDescriptionField;
            }
            set {
                this.fromCostCentreDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string ToCostCentreAfter {
            get {
                return this.toCostCentreAfterField;
            }
            set {
                this.toCostCentreAfterField = value;
            }
        }
        
        /// <remarks/>
        public string ToCostCentreDescription {
            get {
                return this.toCostCentreDescriptionField;
            }
            set {
                this.toCostCentreDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Narration {
            get {
                return this.narrationField;
            }
            set {
                this.narrationField = value;
            }
        }
        
        /// <remarks/>
        public double DepreciationValue {
            get {
                return this.depreciationValueField;
            }
            set {
                this.depreciationValueField = value;
            }
        }
        
        /// <remarks/>
        public double TransferValue {
            get {
                return this.transferValueField;
            }
            set {
                this.transferValueField = value;
            }
        }
        
        /// <remarks/>
        public string Edited_DepreciationValue {
            get {
                return this.edited_DepreciationValueField;
            }
            set {
                this.edited_DepreciationValueField = value;
            }
        }
        
        /// <remarks/>
        public string Edited_TransferValue {
            get {
                return this.edited_TransferValueField;
            }
            set {
                this.edited_TransferValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfersAssetsAssetTotalTransfer {
        
        private double depreciationValueField;
        
        private double transferValueField;
        
        private string edited_DepreciationValueField;
        
        private string edited_TransferValueField;
        
        /// <remarks/>
        public double DepreciationValue {
            get {
                return this.depreciationValueField;
            }
            set {
                this.depreciationValueField = value;
            }
        }
        
        /// <remarks/>
        public double TransferValue {
            get {
                return this.transferValueField;
            }
            set {
                this.transferValueField = value;
            }
        }
        
        /// <remarks/>
        public string Edited_DepreciationValue {
            get {
                return this.edited_DepreciationValueField;
            }
            set {
                this.edited_DepreciationValueField = value;
            }
        }
        
        /// <remarks/>
        public string Edited_TransferValue {
            get {
                return this.edited_TransferValueField;
            }
            set {
                this.edited_TransferValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfersCompanyAssetTotal {
        
        private QueryListofTransfersCompanyAssetTotalCompanyTotalTransfer[] companyTotalTransferField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompanyTotalTransfer")]
        public QueryListofTransfersCompanyAssetTotalCompanyTotalTransfer[] CompanyTotalTransfer {
            get {
                return this.companyTotalTransferField;
            }
            set {
                this.companyTotalTransferField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofTransfersCompanyAssetTotalCompanyTotalTransfer {
        
        private double depreciationValueField;
        
        private double transferValueField;
        
        private string edited_DepreciationValueField;
        
        private string edited_TransferValueField;
        
        /// <remarks/>
        public double DepreciationValue {
            get {
                return this.depreciationValueField;
            }
            set {
                this.depreciationValueField = value;
            }
        }
        
        /// <remarks/>
        public double TransferValue {
            get {
                return this.transferValueField;
            }
            set {
                this.transferValueField = value;
            }
        }
        
        /// <remarks/>
        public string Edited_DepreciationValue {
            get {
                return this.edited_DepreciationValueField;
            }
            set {
                this.edited_DepreciationValueField = value;
            }
        }
        
        /// <remarks/>
        public string Edited_TransferValue {
            get {
                return this.edited_TransferValueField;
            }
            set {
                this.edited_TransferValueField = value;
            }
        }
    }
}
