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
namespace SYSPRO.NET.BusinessObjects.stock_take_exception_out {
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
        
        private QueryStockCodeExceptItem[] stockCodeExceptItemField;
        
        private string totalNumberOfItemsListedField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("StockCodeExceptItem")]
        public QueryStockCodeExceptItem[] StockCodeExceptItem {
            get {
                return this.stockCodeExceptItemField;
            }
            set {
                this.stockCodeExceptItemField = value;
            }
        }
        
        /// <remarks/>
        public string TotalNumberOfItemsListed {
            get {
                return this.totalNumberOfItemsListedField;
            }
            set {
                this.totalNumberOfItemsListedField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryQueryOptions {
        
        private string sequenceField;
        
        private string reportTypeField;
        
        private string stockCheckDateField;
        
        private string includeItemsWithNoABCClassField;
        
        private string includeAClassField;
        
        private string includeBClassField;
        
        private string includeCClassField;
        
        private string includeDClassField;
        
        private string stockCodeFilterTypeField;
        
        private string stockCodeFilterValueField;
        
        private string warehouseFilterTypeField;
        
        private string warehouseFilterValueField;
        
        private string supplierFilterTypeField;
        
        private string supplierFilterValueField;
        
        private string productClassFilterTypeField;
        
        private string productClassFilterValueField;
        
        private string cycleCountFilterTypeField;
        
        private string cycleCountFilterValueField;
        
        /// <remarks/>
        public string Sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
        
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
        public string StockCheckDate {
            get {
                return this.stockCheckDateField;
            }
            set {
                this.stockCheckDateField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeItemsWithNoABCClass {
            get {
                return this.includeItemsWithNoABCClassField;
            }
            set {
                this.includeItemsWithNoABCClassField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeAClass {
            get {
                return this.includeAClassField;
            }
            set {
                this.includeAClassField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeBClass {
            get {
                return this.includeBClassField;
            }
            set {
                this.includeBClassField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeCClass {
            get {
                return this.includeCClassField;
            }
            set {
                this.includeCClassField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeDClass {
            get {
                return this.includeDClassField;
            }
            set {
                this.includeDClassField = value;
            }
        }
        
        /// <remarks/>
        public string StockCodeFilterType {
            get {
                return this.stockCodeFilterTypeField;
            }
            set {
                this.stockCodeFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string StockCodeFilterValue {
            get {
                return this.stockCodeFilterValueField;
            }
            set {
                this.stockCodeFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseFilterType {
            get {
                return this.warehouseFilterTypeField;
            }
            set {
                this.warehouseFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseFilterValue {
            get {
                return this.warehouseFilterValueField;
            }
            set {
                this.warehouseFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierFilterType {
            get {
                return this.supplierFilterTypeField;
            }
            set {
                this.supplierFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierFilterValue {
            get {
                return this.supplierFilterValueField;
            }
            set {
                this.supplierFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string ProductClassFilterType {
            get {
                return this.productClassFilterTypeField;
            }
            set {
                this.productClassFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string ProductClassFilterValue {
            get {
                return this.productClassFilterValueField;
            }
            set {
                this.productClassFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string CycleCountFilterType {
            get {
                return this.cycleCountFilterTypeField;
            }
            set {
                this.cycleCountFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string CycleCountFilterValue {
            get {
                return this.cycleCountFilterValueField;
            }
            set {
                this.cycleCountFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryStockCodeExceptItem {
        
        private string stockCodeField;
        
        private string descriptionField;
        
        private string longDescriptionField;
        
        private string supplierField;
        
        private string supplierNameField;
        
        private string productClassField;
        
        private string productClassDescriptionField;
        
        private string stockUnitOfMeasureField;
        
        private string aBCClassField;
        
        private string cycleCountField;
        
        private QueryStockCodeExceptItemWarehouseItem[] warehousesField;
        
        /// <remarks/>
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
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
        public string LongDescription {
            get {
                return this.longDescriptionField;
            }
            set {
                this.longDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierName {
            get {
                return this.supplierNameField;
            }
            set {
                this.supplierNameField = value;
            }
        }
        
        /// <remarks/>
        public string ProductClass {
            get {
                return this.productClassField;
            }
            set {
                this.productClassField = value;
            }
        }
        
        /// <remarks/>
        public string ProductClassDescription {
            get {
                return this.productClassDescriptionField;
            }
            set {
                this.productClassDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string StockUnitOfMeasure {
            get {
                return this.stockUnitOfMeasureField;
            }
            set {
                this.stockUnitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        public string ABCClass {
            get {
                return this.aBCClassField;
            }
            set {
                this.aBCClassField = value;
            }
        }
        
        /// <remarks/>
        public string CycleCount {
            get {
                return this.cycleCountField;
            }
            set {
                this.cycleCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WarehouseItem", IsNullable=false)]
        public QueryStockCodeExceptItemWarehouseItem[] Warehouses {
            get {
                return this.warehousesField;
            }
            set {
                this.warehousesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryStockCodeExceptItemWarehouseItem {
        
        private string warehouseField;
        
        private string binLocationField;
        
        private string dateLastCountField;
        
        private string alternateUnitOfMeasureField;
        
        private string otherUnitOfMeasureField;
        
        private string massField;
        
        private string volumeField;
        
        /// <remarks/>
        public string Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public string BinLocation {
            get {
                return this.binLocationField;
            }
            set {
                this.binLocationField = value;
            }
        }
        
        /// <remarks/>
        public string DateLastCount {
            get {
                return this.dateLastCountField;
            }
            set {
                this.dateLastCountField = value;
            }
        }
        
        /// <remarks/>
        public string AlternateUnitOfMeasure {
            get {
                return this.alternateUnitOfMeasureField;
            }
            set {
                this.alternateUnitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        public string OtherUnitOfMeasure {
            get {
                return this.otherUnitOfMeasureField;
            }
            set {
                this.otherUnitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        public string Mass {
            get {
                return this.massField;
            }
            set {
                this.massField = value;
            }
        }
        
        /// <remarks/>
        public string Volume {
            get {
                return this.volumeField;
            }
            set {
                this.volumeField = value;
            }
        }
    }
}
