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
namespace SYSPRO.NET.BusinessObjects.SORQT3 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QueryTaxInformation taxInformationField;
        
        /// <remarks/>
        public QueryTaxInformation TaxInformation {
            get {
                return this.taxInformationField;
            }
            set {
                this.taxInformationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryTaxInformation {
        
        private string customerField;
        
        private string stockCodeField;
        
        private string quantityField;
        
        private string lineValueField;
        
        private string lineValueGrossField;
        
        private string extendedTaxCodeField;
        
        private string extendedTaxStateField;
        
        private string extendedTaxCoZipField;
        
        private string extendedTaxCityField;
        
        private string taxDateField;
        
        private string branchField;
        
        private string nationalityField;
        
        private string productClassField;
        
        private string descriptionField;
        
        private string shipToAddress1Field;
        
        private string shipToAddress2Field;
        
        private string shipToAddress3Field;
        
        private string shipToAddress4Field;
        
        private string shipToAddress5Field;
        
        private string shipToPostalCodeField;
        
        private string multiShipCodeField;
        
        private string shipFromAddress1Field;
        
        private string shipFromAddress2Field;
        
        private string shipFromAddress3Field;
        
        private string shipFromAddress4Field;
        
        private string shipFromAddress5Field;
        
        private string shipFromPostalCodeField;
        
        private string nonStockedFlagField;
        
        private QueryTaxInformationDetailLineType detailLineTypeField;
        
        private bool detailLineTypeFieldSpecified;
        
        private string conversionFactorField;
        
        private QueryTaxInformationConversionMd conversionMdField;
        
        private bool conversionMdFieldSpecified;
        
        private string pricingUomField;
        
        private string orderUomField;
        
        private string stockingUomField;
        
        private string unitQuantityFactorField;
        
        private QueryTaxInformationUnitQuantityFlag unitQuantityFlagField;
        
        private bool unitQuantityFlagFieldSpecified;
        
        private string lineDiscPerc1Field;
        
        private string lineDiscPerc2Field;
        
        private string lineDiscPerc3Field;
        
        private QueryTaxInformationDiscountFlag discountFlagField;
        
        private bool discountFlagFieldSpecified;
        
        private string discountValueField;
        
        private string orderTypeField;
        
        private string areaField;
        
        private string invoiceField;
        
        private string invoiceDateField;
        
        private string salesOrderField;
        
        private string salesOrderLineField;
        
        private string salesOrderInitLineField;
        
        private string dispatchNoteField;
        
        private string dispatchLineField;
        
        private QueryTaxInformationEndOrderFlag endOrderFlagField;
        
        private bool endOrderFlagFieldSpecified;
        
        private string taxableFlagField;
        
        private QueryTaxInformationTaxLevel taxLevelField;
        
        private bool taxLevelFieldSpecified;
        
        private QueryTaxInformationCalcType calcTypeField;
        
        private bool calcTypeFieldSpecified;
        
        private string taxExemptNumberField;
        
        private string customerPoNumberField;
        
        private string salespersonField;
        
        private string updateTaxFlagField;
        
        private string interfaceTypeField;
        
        private string identificationTypeField;
        
        private string userCompanyIdField;
        
        private string userDivisionField;
        
        private string liveTaxCompanyField;
        
        private string defaultShipFromStreetField;
        
        private string defaultShipFromCityField;
        
        private string defaultShipFromStateField;
        
        private string defaultShipFromZipField;
        
        private string userParametersField;
        
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
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
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
        public string LineValue {
            get {
                return this.lineValueField;
            }
            set {
                this.lineValueField = value;
            }
        }
        
        /// <remarks/>
        public string LineValueGross {
            get {
                return this.lineValueGrossField;
            }
            set {
                this.lineValueGrossField = value;
            }
        }
        
        /// <remarks/>
        public string ExtendedTaxCode {
            get {
                return this.extendedTaxCodeField;
            }
            set {
                this.extendedTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public string ExtendedTaxState {
            get {
                return this.extendedTaxStateField;
            }
            set {
                this.extendedTaxStateField = value;
            }
        }
        
        /// <remarks/>
        public string ExtendedTaxCoZip {
            get {
                return this.extendedTaxCoZipField;
            }
            set {
                this.extendedTaxCoZipField = value;
            }
        }
        
        /// <remarks/>
        public string ExtendedTaxCity {
            get {
                return this.extendedTaxCityField;
            }
            set {
                this.extendedTaxCityField = value;
            }
        }
        
        /// <remarks/>
        public string TaxDate {
            get {
                return this.taxDateField;
            }
            set {
                this.taxDateField = value;
            }
        }
        
        /// <remarks/>
        public string Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        public string Nationality {
            get {
                return this.nationalityField;
            }
            set {
                this.nationalityField = value;
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string ShipToAddress1 {
            get {
                return this.shipToAddress1Field;
            }
            set {
                this.shipToAddress1Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipToAddress2 {
            get {
                return this.shipToAddress2Field;
            }
            set {
                this.shipToAddress2Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipToAddress3 {
            get {
                return this.shipToAddress3Field;
            }
            set {
                this.shipToAddress3Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipToAddress4 {
            get {
                return this.shipToAddress4Field;
            }
            set {
                this.shipToAddress4Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipToAddress5 {
            get {
                return this.shipToAddress5Field;
            }
            set {
                this.shipToAddress5Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipToPostalCode {
            get {
                return this.shipToPostalCodeField;
            }
            set {
                this.shipToPostalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string MultiShipCode {
            get {
                return this.multiShipCodeField;
            }
            set {
                this.multiShipCodeField = value;
            }
        }
        
        /// <remarks/>
        public string ShipFromAddress1 {
            get {
                return this.shipFromAddress1Field;
            }
            set {
                this.shipFromAddress1Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipFromAddress2 {
            get {
                return this.shipFromAddress2Field;
            }
            set {
                this.shipFromAddress2Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipFromAddress3 {
            get {
                return this.shipFromAddress3Field;
            }
            set {
                this.shipFromAddress3Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipFromAddress4 {
            get {
                return this.shipFromAddress4Field;
            }
            set {
                this.shipFromAddress4Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipFromAddress5 {
            get {
                return this.shipFromAddress5Field;
            }
            set {
                this.shipFromAddress5Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipFromPostalCode {
            get {
                return this.shipFromPostalCodeField;
            }
            set {
                this.shipFromPostalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string NonStockedFlag {
            get {
                return this.nonStockedFlagField;
            }
            set {
                this.nonStockedFlagField = value;
            }
        }
        
        /// <remarks/>
        public QueryTaxInformationDetailLineType DetailLineType {
            get {
                return this.detailLineTypeField;
            }
            set {
                this.detailLineTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DetailLineTypeSpecified {
            get {
                return this.detailLineTypeFieldSpecified;
            }
            set {
                this.detailLineTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ConversionFactor {
            get {
                return this.conversionFactorField;
            }
            set {
                this.conversionFactorField = value;
            }
        }
        
        /// <remarks/>
        public QueryTaxInformationConversionMd ConversionMd {
            get {
                return this.conversionMdField;
            }
            set {
                this.conversionMdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConversionMdSpecified {
            get {
                return this.conversionMdFieldSpecified;
            }
            set {
                this.conversionMdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string PricingUom {
            get {
                return this.pricingUomField;
            }
            set {
                this.pricingUomField = value;
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
        public string StockingUom {
            get {
                return this.stockingUomField;
            }
            set {
                this.stockingUomField = value;
            }
        }
        
        /// <remarks/>
        public string UnitQuantityFactor {
            get {
                return this.unitQuantityFactorField;
            }
            set {
                this.unitQuantityFactorField = value;
            }
        }
        
        /// <remarks/>
        public QueryTaxInformationUnitQuantityFlag UnitQuantityFlag {
            get {
                return this.unitQuantityFlagField;
            }
            set {
                this.unitQuantityFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitQuantityFlagSpecified {
            get {
                return this.unitQuantityFlagFieldSpecified;
            }
            set {
                this.unitQuantityFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string LineDiscPerc1 {
            get {
                return this.lineDiscPerc1Field;
            }
            set {
                this.lineDiscPerc1Field = value;
            }
        }
        
        /// <remarks/>
        public string LineDiscPerc2 {
            get {
                return this.lineDiscPerc2Field;
            }
            set {
                this.lineDiscPerc2Field = value;
            }
        }
        
        /// <remarks/>
        public string LineDiscPerc3 {
            get {
                return this.lineDiscPerc3Field;
            }
            set {
                this.lineDiscPerc3Field = value;
            }
        }
        
        /// <remarks/>
        public QueryTaxInformationDiscountFlag DiscountFlag {
            get {
                return this.discountFlagField;
            }
            set {
                this.discountFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountFlagSpecified {
            get {
                return this.discountFlagFieldSpecified;
            }
            set {
                this.discountFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string DiscountValue {
            get {
                return this.discountValueField;
            }
            set {
                this.discountValueField = value;
            }
        }
        
        /// <remarks/>
        public string OrderType {
            get {
                return this.orderTypeField;
            }
            set {
                this.orderTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Area {
            get {
                return this.areaField;
            }
            set {
                this.areaField = value;
            }
        }
        
        /// <remarks/>
        public string Invoice {
            get {
                return this.invoiceField;
            }
            set {
                this.invoiceField = value;
            }
        }
        
        /// <remarks/>
        public string InvoiceDate {
            get {
                return this.invoiceDateField;
            }
            set {
                this.invoiceDateField = value;
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
        public string SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrderInitLine {
            get {
                return this.salesOrderInitLineField;
            }
            set {
                this.salesOrderInitLineField = value;
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
        public string DispatchLine {
            get {
                return this.dispatchLineField;
            }
            set {
                this.dispatchLineField = value;
            }
        }
        
        /// <remarks/>
        public QueryTaxInformationEndOrderFlag EndOrderFlag {
            get {
                return this.endOrderFlagField;
            }
            set {
                this.endOrderFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndOrderFlagSpecified {
            get {
                return this.endOrderFlagFieldSpecified;
            }
            set {
                this.endOrderFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string TaxableFlag {
            get {
                return this.taxableFlagField;
            }
            set {
                this.taxableFlagField = value;
            }
        }
        
        /// <remarks/>
        public QueryTaxInformationTaxLevel TaxLevel {
            get {
                return this.taxLevelField;
            }
            set {
                this.taxLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxLevelSpecified {
            get {
                return this.taxLevelFieldSpecified;
            }
            set {
                this.taxLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public QueryTaxInformationCalcType CalcType {
            get {
                return this.calcTypeField;
            }
            set {
                this.calcTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalcTypeSpecified {
            get {
                return this.calcTypeFieldSpecified;
            }
            set {
                this.calcTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string TaxExemptNumber {
            get {
                return this.taxExemptNumberField;
            }
            set {
                this.taxExemptNumberField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerPoNumber {
            get {
                return this.customerPoNumberField;
            }
            set {
                this.customerPoNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Salesperson {
            get {
                return this.salespersonField;
            }
            set {
                this.salespersonField = value;
            }
        }
        
        /// <remarks/>
        public string UpdateTaxFlag {
            get {
                return this.updateTaxFlagField;
            }
            set {
                this.updateTaxFlagField = value;
            }
        }
        
        /// <remarks/>
        public string InterfaceType {
            get {
                return this.interfaceTypeField;
            }
            set {
                this.interfaceTypeField = value;
            }
        }
        
        /// <remarks/>
        public string IdentificationType {
            get {
                return this.identificationTypeField;
            }
            set {
                this.identificationTypeField = value;
            }
        }
        
        /// <remarks/>
        public string UserCompanyId {
            get {
                return this.userCompanyIdField;
            }
            set {
                this.userCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        public string UserDivision {
            get {
                return this.userDivisionField;
            }
            set {
                this.userDivisionField = value;
            }
        }
        
        /// <remarks/>
        public string LiveTaxCompany {
            get {
                return this.liveTaxCompanyField;
            }
            set {
                this.liveTaxCompanyField = value;
            }
        }
        
        /// <remarks/>
        public string DefaultShipFromStreet {
            get {
                return this.defaultShipFromStreetField;
            }
            set {
                this.defaultShipFromStreetField = value;
            }
        }
        
        /// <remarks/>
        public string DefaultShipFromCity {
            get {
                return this.defaultShipFromCityField;
            }
            set {
                this.defaultShipFromCityField = value;
            }
        }
        
        /// <remarks/>
        public string DefaultShipFromState {
            get {
                return this.defaultShipFromStateField;
            }
            set {
                this.defaultShipFromStateField = value;
            }
        }
        
        /// <remarks/>
        public string DefaultShipFromZip {
            get {
                return this.defaultShipFromZipField;
            }
            set {
                this.defaultShipFromZipField = value;
            }
        }
        
        /// <remarks/>
        public string UserParameters {
            get {
                return this.userParametersField;
            }
            set {
                this.userParametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryTaxInformationDetailLineType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryTaxInformationConversionMd {
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryTaxInformationUnitQuantityFlag {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryTaxInformationDiscountFlag {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        V,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryTaxInformationEndOrderFlag {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryTaxInformationTaxLevel {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryTaxInformationCalcType {
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
}
