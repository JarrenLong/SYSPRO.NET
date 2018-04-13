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
namespace SYSPRO.NET.BusinessObjects.ASSQDLOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QueryQueryOptions[] queryOptionsField;
        
        private QueryListofDepreciationAdjustments[] listofDepreciationAdjustmentsField;
        
        private string languageField;
        
        private string cssStyleField;
        
        private string decFormatField;
        
        private string dateFormatField;
        
        private string roleField;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public QueryQueryOptions[] QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListofDepreciationAdjustments", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public QueryListofDepreciationAdjustments[] ListofDepreciationAdjustments {
            get {
                return this.listofDepreciationAdjustmentsField;
            }
            set {
                this.listofDepreciationAdjustmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
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
        
        private string assetFilterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FromPeriod {
            get {
                return this.fromPeriodField;
            }
            set {
                this.fromPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ToPeriod {
            get {
                return this.toPeriodField;
            }
            set {
                this.toPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AssetFilterType {
            get {
                return this.assetFilterTypeField;
            }
            set {
                this.assetFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    public partial class QueryListofDepreciationAdjustments {
        
        private QueryListofDepreciationAdjustmentsAssetsAsset[][] assetsField;
        
        private QueryListofDepreciationAdjustmentsCompanyAssetTotal[] companyAssetTotalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Asset", typeof(QueryListofDepreciationAdjustmentsAssetsAsset), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public QueryListofDepreciationAdjustmentsAssetsAsset[][] Assets {
            get {
                return this.assetsField;
            }
            set {
                this.assetsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CompanyAssetTotal", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public QueryListofDepreciationAdjustmentsCompanyAssetTotal[] CompanyAssetTotal {
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
    public partial class QueryListofDepreciationAdjustmentsAssetsAsset {
        
        private QueryListofDepreciationAdjustmentsAssetsAssetAssetDetail[] assetDetailField;
        
        private QueryListofDepreciationAdjustmentsAssetsAssetAdjustmentsAdjustment[][] adjustmentsField;
        
        private QueryListofDepreciationAdjustmentsAssetsAssetTotalAdjustment[] totalAdjustmentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssetDetail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public QueryListofDepreciationAdjustmentsAssetsAssetAssetDetail[] AssetDetail {
            get {
                return this.assetDetailField;
            }
            set {
                this.assetDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Adjustment", typeof(QueryListofDepreciationAdjustmentsAssetsAssetAdjustmentsAdjustment), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public QueryListofDepreciationAdjustmentsAssetsAssetAdjustmentsAdjustment[][] Adjustments {
            get {
                return this.adjustmentsField;
            }
            set {
                this.adjustmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TotalAdjustment", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public QueryListofDepreciationAdjustmentsAssetsAssetTotalAdjustment[] TotalAdjustment {
            get {
                return this.totalAdjustmentField;
            }
            set {
                this.totalAdjustmentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofDepreciationAdjustmentsAssetsAssetAssetDetail {
        
        private string assetCodeField;
        
        private string assetDescriptionField;
        
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
    public partial class QueryListofDepreciationAdjustmentsAssetsAssetAdjustmentsAdjustment {
        
        private string dateOfAdjustmentField;
        
        private string costPriceField;
        
        private string depreciationAdjustmentField;
        
        private string depreciationThisYearField;
        
        private string accumDeprBroughtForwardField;
        
        private string narrationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DateOfAdjustment {
            get {
                return this.dateOfAdjustmentField;
            }
            set {
                this.dateOfAdjustmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CostPrice {
            get {
                return this.costPriceField;
            }
            set {
                this.costPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DepreciationAdjustment {
            get {
                return this.depreciationAdjustmentField;
            }
            set {
                this.depreciationAdjustmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DepreciationThisYear {
            get {
                return this.depreciationThisYearField;
            }
            set {
                this.depreciationThisYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AccumDeprBroughtForward {
            get {
                return this.accumDeprBroughtForwardField;
            }
            set {
                this.accumDeprBroughtForwardField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofDepreciationAdjustmentsAssetsAssetTotalAdjustment {
        
        private string costPriceField;
        
        private string depreciationAdjustmentField;
        
        private string depreciationThisYearField;
        
        private string accumDeprBroughtForwardField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CostPrice {
            get {
                return this.costPriceField;
            }
            set {
                this.costPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DepreciationAdjustment {
            get {
                return this.depreciationAdjustmentField;
            }
            set {
                this.depreciationAdjustmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DepreciationThisYear {
            get {
                return this.depreciationThisYearField;
            }
            set {
                this.depreciationThisYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AccumDeprBroughtForward {
            get {
                return this.accumDeprBroughtForwardField;
            }
            set {
                this.accumDeprBroughtForwardField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryListofDepreciationAdjustmentsCompanyAssetTotal {
        
        private string costPriceField;
        
        private string depreciationAdjustmentField;
        
        private string depreciationThisYearField;
        
        private string accumDeprBroughtForwardField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CostPrice {
            get {
                return this.costPriceField;
            }
            set {
                this.costPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DepreciationAdjustment {
            get {
                return this.depreciationAdjustmentField;
            }
            set {
                this.depreciationAdjustmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DepreciationThisYear {
            get {
                return this.depreciationThisYearField;
            }
            set {
                this.depreciationThisYearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AccumDeprBroughtForward {
            get {
                return this.accumDeprBroughtForwardField;
            }
            set {
                this.accumDeprBroughtForwardField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class NewDataSet {
        
        private Query[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Query")]
        public Query[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
