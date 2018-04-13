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
namespace SYSPRO.NET.BusinessObjects.picking_list_out {
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
        
        private QueryLoadItemStockCodes[][] loadItemField;
        
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
        [System.Xml.Serialization.XmlArrayItemAttribute("StockCodes", typeof(QueryLoadItemStockCodes), IsNullable=false)]
        public QueryLoadItemStockCodes[][] LoadItem {
            get {
                return this.loadItemField;
            }
            set {
                this.loadItemField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryQueryOptions {
        
        private string fromRouteCodeField;
        
        private string toRouteCodeField;
        
        private string fromDeliveryDateField;
        
        private string toDeliveryDateField;
        
        /// <remarks/>
        public string FromRouteCode {
            get {
                return this.fromRouteCodeField;
            }
            set {
                this.fromRouteCodeField = value;
            }
        }
        
        /// <remarks/>
        public string ToRouteCode {
            get {
                return this.toRouteCodeField;
            }
            set {
                this.toRouteCodeField = value;
            }
        }
        
        /// <remarks/>
        public string FromDeliveryDate {
            get {
                return this.fromDeliveryDateField;
            }
            set {
                this.fromDeliveryDateField = value;
            }
        }
        
        /// <remarks/>
        public string ToDeliveryDate {
            get {
                return this.toDeliveryDateField;
            }
            set {
                this.toDeliveryDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryLoadItemStockCodes {
        
        private QueryLoadItemStockCodesStockItem stockItemField;
        
        /// <remarks/>
        public QueryLoadItemStockCodesStockItem StockItem {
            get {
                return this.stockItemField;
            }
            set {
                this.stockItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryLoadItemStockCodesStockItem {
        
        private string routeCodeField;
        
        private string routeDescriptionField;
        
        private string deliveryDateField;
        
        private string deliverySeqField;
        
        private string transportField;
        
        private string driverField;
        
        private string loadReferenceField;
        
        private string stockCodeField;
        
        private string stockCodeDescField;
        
        private string salesOrderField;
        
        private string salesOrderLinesField;
        
        private string dispatchNoteField;
        
        private string dispatchNoteLineField;
        
        private string quantityField;
        
        private string orderUomField;
        
        private string volumeField;
        
        private string massField;
        
        /// <remarks/>
        public string RouteCode {
            get {
                return this.routeCodeField;
            }
            set {
                this.routeCodeField = value;
            }
        }
        
        /// <remarks/>
        public string RouteDescription {
            get {
                return this.routeDescriptionField;
            }
            set {
                this.routeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string DeliveryDate {
            get {
                return this.deliveryDateField;
            }
            set {
                this.deliveryDateField = value;
            }
        }
        
        /// <remarks/>
        public string DeliverySeq {
            get {
                return this.deliverySeqField;
            }
            set {
                this.deliverySeqField = value;
            }
        }
        
        /// <remarks/>
        public string Transport {
            get {
                return this.transportField;
            }
            set {
                this.transportField = value;
            }
        }
        
        /// <remarks/>
        public string Driver {
            get {
                return this.driverField;
            }
            set {
                this.driverField = value;
            }
        }
        
        /// <remarks/>
        public string LoadReference {
            get {
                return this.loadReferenceField;
            }
            set {
                this.loadReferenceField = value;
            }
        }
        
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
        public string StockCodeDesc {
            get {
                return this.stockCodeDescField;
            }
            set {
                this.stockCodeDescField = value;
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
        public string SalesOrderLines {
            get {
                return this.salesOrderLinesField;
            }
            set {
                this.salesOrderLinesField = value;
            }
        }
        
        /// <remarks/>
        public string DispatchNote {
            get {
                return this.dispatchNoteField;
            }
            set {
                this.dispatchNoteField = value;
            }
        }
        
        /// <remarks/>
        public string DispatchNoteLine {
            get {
                return this.dispatchNoteLineField;
            }
            set {
                this.dispatchNoteLineField = value;
            }
        }
        
        /// <remarks/>
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public string OrderUom {
            get {
                return this.orderUomField;
            }
            set {
                this.orderUomField = value;
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
        
        /// <remarks/>
        public string Mass {
            get {
                return this.massField;
            }
            set {
                this.massField = value;
            }
        }
    }
}
