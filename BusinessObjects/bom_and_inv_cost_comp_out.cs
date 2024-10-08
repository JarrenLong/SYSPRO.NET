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
namespace SYSPRO.NET.BusinessObjects.bom_and_inv_cost_comp_out {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BomInventoryCostComparison {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", typeof(BomInventoryCostComparisonQueryOptions), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("StockCodeCostsDetail", typeof(BomInventoryCostComparisonStockCodeCostsDetail), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", typeof(BomInventoryCostComparisonSystemInformation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TranslatedText", typeof(BomInventoryCostComparisonTranslatedText), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    public partial class BomInventoryCostComparisonQueryOptions {
        
        private string useBomCostsFromWarehouseField;
        
        private string translated_UseBomCostsFromWarehouseField;
        
        private string stockCodeFilterTypeField;
        
        private string stockCodeFilterValueField;
        
        private string translated_StockCodeFilterValueField;
        
        private string warehouseFilterTypeField;
        
        private string warehouseFilterValueField;
        
        private string translated_WarehouseFilterValueField;
        
        private string percentageVarianceSelectionFilterTypeField;
        
        private string percentageVarianceSelectionFilterValueField;
        
        private string translated_PercentageVarianceFilterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UseBomCostsFromWarehouse {
            get {
                return this.useBomCostsFromWarehouseField;
            }
            set {
                this.useBomCostsFromWarehouseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_UseBomCostsFromWarehouse {
            get {
                return this.translated_UseBomCostsFromWarehouseField;
            }
            set {
                this.translated_UseBomCostsFromWarehouseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StockCodeFilterType {
            get {
                return this.stockCodeFilterTypeField;
            }
            set {
                this.stockCodeFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StockCodeFilterValue {
            get {
                return this.stockCodeFilterValueField;
            }
            set {
                this.stockCodeFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_StockCodeFilterValue {
            get {
                return this.translated_StockCodeFilterValueField;
            }
            set {
                this.translated_StockCodeFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WarehouseFilterType {
            get {
                return this.warehouseFilterTypeField;
            }
            set {
                this.warehouseFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WarehouseFilterValue {
            get {
                return this.warehouseFilterValueField;
            }
            set {
                this.warehouseFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_WarehouseFilterValue {
            get {
                return this.translated_WarehouseFilterValueField;
            }
            set {
                this.translated_WarehouseFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PercentageVarianceSelectionFilterType {
            get {
                return this.percentageVarianceSelectionFilterTypeField;
            }
            set {
                this.percentageVarianceSelectionFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PercentageVarianceSelectionFilterValue {
            get {
                return this.percentageVarianceSelectionFilterValueField;
            }
            set {
                this.percentageVarianceSelectionFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_PercentageVarianceFilterValue {
            get {
                return this.translated_PercentageVarianceFilterValueField;
            }
            set {
                this.translated_PercentageVarianceFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BomInventoryCostComparisonStockCodeCostsDetail {
        
        private BomInventoryCostComparisonStockCodeCostsDetailStockCodeDetail[] stockCodeDetailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StockCodeDetail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BomInventoryCostComparisonStockCodeCostsDetailStockCodeDetail[] StockCodeDetail {
            get {
                return this.stockCodeDetailField;
            }
            set {
                this.stockCodeDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BomInventoryCostComparisonStockCodeCostsDetailStockCodeDetail {
        
        private string stockCodeField;
        
        private string iNVMST_DescriptionField;
        
        private string stockingUomField;
        
        private string partCategoryField;
        
        private string translated_PartCategoryField;
        
        private double bomMaterialCostsField;
        
        private bool bomMaterialCostsFieldSpecified;
        
        private string edited_BomMaterialCostsField;
        
        private double bomLaborCostsField;
        
        private bool bomLaborCostsFieldSpecified;
        
        private string edited_BomLaborCostsField;
        
        private double bomOverheadsField;
        
        private bool bomOverheadsFieldSpecified;
        
        private string edited_BomOverheadsField;
        
        private double bomTotalCostsField;
        
        private bool bomTotalCostsFieldSpecified;
        
        private string edited_BomTotalCostsField;
        
        private double bomSubContractCostField;
        
        private bool bomSubContractCostFieldSpecified;
        
        private string edited_BomSubContractCostField;
        
        private double abcCumPreProdField;
        
        private bool abcCumPreProdFieldSpecified;
        
        private string edited_AbcCumPreProdField;
        
        private double abcCumManufField;
        
        private bool abcCumManufFieldSpecified;
        
        private string edited_AbcCumManufField;
        
        private string warehouseField;
        
        private string iNVWHC_DescriptionField;
        
        private double inventoryCostsField;
        
        private bool inventoryCostsFieldSpecified;
        
        private string edited_InventoryCostsField;
        
        private string inventoryUomField;
        
        private double percentageVarianceField;
        
        private bool percentageVarianceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVMST_Description {
            get {
                return this.iNVMST_DescriptionField;
            }
            set {
                this.iNVMST_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string StockingUom {
            get {
                return this.stockingUomField;
            }
            set {
                this.stockingUomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PartCategory {
            get {
                return this.partCategoryField;
            }
            set {
                this.partCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_PartCategory {
            get {
                return this.translated_PartCategoryField;
            }
            set {
                this.translated_PartCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double BomMaterialCosts {
            get {
                return this.bomMaterialCostsField;
            }
            set {
                this.bomMaterialCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BomMaterialCostsSpecified {
            get {
                return this.bomMaterialCostsFieldSpecified;
            }
            set {
                this.bomMaterialCostsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_BomMaterialCosts {
            get {
                return this.edited_BomMaterialCostsField;
            }
            set {
                this.edited_BomMaterialCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double BomLaborCosts {
            get {
                return this.bomLaborCostsField;
            }
            set {
                this.bomLaborCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BomLaborCostsSpecified {
            get {
                return this.bomLaborCostsFieldSpecified;
            }
            set {
                this.bomLaborCostsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_BomLaborCosts {
            get {
                return this.edited_BomLaborCostsField;
            }
            set {
                this.edited_BomLaborCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double BomOverheads {
            get {
                return this.bomOverheadsField;
            }
            set {
                this.bomOverheadsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BomOverheadsSpecified {
            get {
                return this.bomOverheadsFieldSpecified;
            }
            set {
                this.bomOverheadsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_BomOverheads {
            get {
                return this.edited_BomOverheadsField;
            }
            set {
                this.edited_BomOverheadsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double BomTotalCosts {
            get {
                return this.bomTotalCostsField;
            }
            set {
                this.bomTotalCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BomTotalCostsSpecified {
            get {
                return this.bomTotalCostsFieldSpecified;
            }
            set {
                this.bomTotalCostsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_BomTotalCosts {
            get {
                return this.edited_BomTotalCostsField;
            }
            set {
                this.edited_BomTotalCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double BomSubContractCost {
            get {
                return this.bomSubContractCostField;
            }
            set {
                this.bomSubContractCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BomSubContractCostSpecified {
            get {
                return this.bomSubContractCostFieldSpecified;
            }
            set {
                this.bomSubContractCostFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_BomSubContractCost {
            get {
                return this.edited_BomSubContractCostField;
            }
            set {
                this.edited_BomSubContractCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double AbcCumPreProd {
            get {
                return this.abcCumPreProdField;
            }
            set {
                this.abcCumPreProdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AbcCumPreProdSpecified {
            get {
                return this.abcCumPreProdFieldSpecified;
            }
            set {
                this.abcCumPreProdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_AbcCumPreProd {
            get {
                return this.edited_AbcCumPreProdField;
            }
            set {
                this.edited_AbcCumPreProdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double AbcCumManuf {
            get {
                return this.abcCumManufField;
            }
            set {
                this.abcCumManufField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AbcCumManufSpecified {
            get {
                return this.abcCumManufFieldSpecified;
            }
            set {
                this.abcCumManufFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_AbcCumManuf {
            get {
                return this.edited_AbcCumManufField;
            }
            set {
                this.edited_AbcCumManufField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string INVWHC_Description {
            get {
                return this.iNVWHC_DescriptionField;
            }
            set {
                this.iNVWHC_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double InventoryCosts {
            get {
                return this.inventoryCostsField;
            }
            set {
                this.inventoryCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InventoryCostsSpecified {
            get {
                return this.inventoryCostsFieldSpecified;
            }
            set {
                this.inventoryCostsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_InventoryCosts {
            get {
                return this.edited_InventoryCostsField;
            }
            set {
                this.edited_InventoryCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InventoryUom {
            get {
                return this.inventoryUomField;
            }
            set {
                this.inventoryUomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double PercentageVariance {
            get {
                return this.percentageVarianceField;
            }
            set {
                this.percentageVarianceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageVarianceSpecified {
            get {
                return this.percentageVarianceFieldSpecified;
            }
            set {
                this.percentageVarianceFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BomInventoryCostComparisonSystemInformation {
        
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
        
        private double bOMQtyPerDecimalsField;
        
        private bool bOMQtyPerDecimalsFieldSpecified;
        
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
        public double BOMQtyPerDecimals {
            get {
                return this.bOMQtyPerDecimalsField;
            }
            set {
                this.bOMQtyPerDecimalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BOMQtyPerDecimalsSpecified {
            get {
                return this.bOMQtyPerDecimalsFieldSpecified;
            }
            set {
                this.bOMQtyPerDecimalsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BomInventoryCostComparisonTranslatedText {
        
        private string text_AllField;
        
        private string text_YesField;
        
        private string text_NoField;
        
        private string text_SpecificField;
        
        private string text_Made_inField;
        
        private string text_Bought_outField;
        
        private string text_Sub_contractedField;
        
        private string text_PhantomField;
        
        private string text_Planning_billField;
        
        private string text_Kit_partField;
        
        private string text_Co_productField;
        
        private string text_By_productField;
        
        private string text_Notional_partField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_All {
            get {
                return this.text_AllField;
            }
            set {
                this.text_AllField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Yes {
            get {
                return this.text_YesField;
            }
            set {
                this.text_YesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_No {
            get {
                return this.text_NoField;
            }
            set {
                this.text_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Specific {
            get {
                return this.text_SpecificField;
            }
            set {
                this.text_SpecificField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Made_in {
            get {
                return this.text_Made_inField;
            }
            set {
                this.text_Made_inField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Bought_out {
            get {
                return this.text_Bought_outField;
            }
            set {
                this.text_Bought_outField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Sub_contracted {
            get {
                return this.text_Sub_contractedField;
            }
            set {
                this.text_Sub_contractedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Phantom {
            get {
                return this.text_PhantomField;
            }
            set {
                this.text_PhantomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Planning_bill {
            get {
                return this.text_Planning_billField;
            }
            set {
                this.text_Planning_billField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Kit_part {
            get {
                return this.text_Kit_partField;
            }
            set {
                this.text_Kit_partField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Co_product {
            get {
                return this.text_Co_productField;
            }
            set {
                this.text_Co_productField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_By_product {
            get {
                return this.text_By_productField;
            }
            set {
                this.text_By_productField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Notional_part {
            get {
                return this.text_Notional_partField;
            }
            set {
                this.text_Notional_partField = value;
            }
        }
    }
}
