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
namespace SYSPRO.NET.BusinessObjects.inv_serial_tracking_balance_out {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SerialFileBalanceReport {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", typeof(SerialFileBalanceReportQueryOptions), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("Serials", typeof(SerialFileBalanceReportSerials), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", typeof(SerialFileBalanceReportSystemInformation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TranslatedText", typeof(SerialFileBalanceReportTranslatedText), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    public partial class SerialFileBalanceReportQueryOptions {
        
        private string includeSerialsWithZeroOnHandField;
        
        private string includeStockItemsPreviouslySerializedField;
        
        private string stockCodeFilterTypeField;
        
        private string stockCodeFilterValueField;
        
        private string warehouseFilterTypeField;
        
        private string warehouseFilterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeSerialsWithZeroOnHand {
            get {
                return this.includeSerialsWithZeroOnHandField;
            }
            set {
                this.includeSerialsWithZeroOnHandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string IncludeStockItemsPreviouslySerialized {
            get {
                return this.includeStockItemsPreviouslySerializedField;
            }
            set {
                this.includeStockItemsPreviouslySerializedField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SerialFileBalanceReportSerials {
        
        private SerialFileBalanceReportSerialsStockCodeStockCodeDetails[][] stockCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("StockCodeDetails", typeof(SerialFileBalanceReportSerialsStockCodeStockCodeDetails), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public SerialFileBalanceReportSerialsStockCodeStockCodeDetails[][] StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SerialFileBalanceReportSerialsStockCodeStockCodeDetails {
        
        private SerialFileBalanceReportSerialsStockCodeStockCodeDetailsStockCodeHeader[] stockCodeHeaderField;
        
        private SerialFileBalanceReportSerialsStockCodeStockCodeDetailsStockCodeDetail[] stockCodeDetailField;
        
        private SerialFileBalanceReportSerialsStockCodeStockCodeDetailsSerialDetailsDetail[][] serialDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StockCodeHeader", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SerialFileBalanceReportSerialsStockCodeStockCodeDetailsStockCodeHeader[] StockCodeHeader {
            get {
                return this.stockCodeHeaderField;
            }
            set {
                this.stockCodeHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StockCodeDetail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SerialFileBalanceReportSerialsStockCodeStockCodeDetailsStockCodeDetail[] StockCodeDetail {
            get {
                return this.stockCodeDetailField;
            }
            set {
                this.stockCodeDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Detail", typeof(SerialFileBalanceReportSerialsStockCodeStockCodeDetailsSerialDetailsDetail), Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public SerialFileBalanceReportSerialsStockCodeStockCodeDetailsSerialDetailsDetail[][] SerialDetails {
            get {
                return this.serialDetailsField;
            }
            set {
                this.serialDetailsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SerialFileBalanceReportSerialsStockCodeStockCodeDetailsStockCodeHeader {
        
        private string stockCodeField;
        
        private string descriptionField;
        
        private double decimalsField;
        
        private bool decimalsFieldSpecified;
        
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double Decimals {
            get {
                return this.decimalsField;
            }
            set {
                this.decimalsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DecimalsSpecified {
            get {
                return this.decimalsFieldSpecified;
            }
            set {
                this.decimalsFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SerialFileBalanceReportSerialsStockCodeStockCodeDetailsStockCodeDetail {
        
        private string warehouseField;
        
        private double warehouseQtyOnHandField;
        
        private bool warehouseQtyOnHandFieldSpecified;
        
        private string warehouseQtyOnHandUnitsField;
        
        private double serialQtyOnHandField;
        
        private bool serialQtyOnHandFieldSpecified;
        
        private string serialQtyOnHandUnitsField;
        
        private double differenceField;
        
        private bool differenceFieldSpecified;
        
        private string differenceUnitsField;
        
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
        public double WarehouseQtyOnHand {
            get {
                return this.warehouseQtyOnHandField;
            }
            set {
                this.warehouseQtyOnHandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarehouseQtyOnHandSpecified {
            get {
                return this.warehouseQtyOnHandFieldSpecified;
            }
            set {
                this.warehouseQtyOnHandFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WarehouseQtyOnHandUnits {
            get {
                return this.warehouseQtyOnHandUnitsField;
            }
            set {
                this.warehouseQtyOnHandUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double SerialQtyOnHand {
            get {
                return this.serialQtyOnHandField;
            }
            set {
                this.serialQtyOnHandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerialQtyOnHandSpecified {
            get {
                return this.serialQtyOnHandFieldSpecified;
            }
            set {
                this.serialQtyOnHandFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SerialQtyOnHandUnits {
            get {
                return this.serialQtyOnHandUnitsField;
            }
            set {
                this.serialQtyOnHandUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double Difference {
            get {
                return this.differenceField;
            }
            set {
                this.differenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DifferenceSpecified {
            get {
                return this.differenceFieldSpecified;
            }
            set {
                this.differenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DifferenceUnits {
            get {
                return this.differenceUnitsField;
            }
            set {
                this.differenceUnitsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SerialFileBalanceReportSerialsStockCodeStockCodeDetailsSerialDetailsDetail {
        
        private string serialField;
        
        private string versionField;
        
        private string releaseField;
        
        private string serialDescriptionField;
        
        private string serviceFlagField;
        
        private string loadFlagField;
        
        private string serviceDepotFlagField;
        
        private double serialQtyOnHandField;
        
        private bool serialQtyOnHandFieldSpecified;
        
        private string serialQtyOnHandUnitsField;
        
        private string locationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Serial {
            get {
                return this.serialField;
            }
            set {
                this.serialField = value;
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
        public string SerialDescription {
            get {
                return this.serialDescriptionField;
            }
            set {
                this.serialDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ServiceFlag {
            get {
                return this.serviceFlagField;
            }
            set {
                this.serviceFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string LoadFlag {
            get {
                return this.loadFlagField;
            }
            set {
                this.loadFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ServiceDepotFlag {
            get {
                return this.serviceDepotFlagField;
            }
            set {
                this.serviceDepotFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double SerialQtyOnHand {
            get {
                return this.serialQtyOnHandField;
            }
            set {
                this.serialQtyOnHandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerialQtyOnHandSpecified {
            get {
                return this.serialQtyOnHandFieldSpecified;
            }
            set {
                this.serialQtyOnHandFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SerialQtyOnHandUnits {
            get {
                return this.serialQtyOnHandUnitsField;
            }
            set {
                this.serialQtyOnHandUnitsField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SerialFileBalanceReportSystemInformation {
        
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SerialFileBalanceReportTranslatedText {
        
        private string text_YesField;
        
        private string text_NoField;
        
        private string text_RangeField;
        
        private string text_AllField;
        
        private string text_SingleField;
        
        private string text_Warehouse_record_missingField;
        
        private string text_On_loanField;
        
        private string text_At_depotField;
        
        private string text_In_serviceField;
        
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
        public string Text_Range {
            get {
                return this.text_RangeField;
            }
            set {
                this.text_RangeField = value;
            }
        }
        
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
        public string Text_Single {
            get {
                return this.text_SingleField;
            }
            set {
                this.text_SingleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Warehouse_record_missing {
            get {
                return this.text_Warehouse_record_missingField;
            }
            set {
                this.text_Warehouse_record_missingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_On_loan {
            get {
                return this.text_On_loanField;
            }
            set {
                this.text_On_loanField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_At_depot {
            get {
                return this.text_At_depotField;
            }
            set {
                this.text_At_depotField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_In_service {
            get {
                return this.text_In_serviceField;
            }
            set {
                this.text_In_serviceField = value;
            }
        }
    }
}
