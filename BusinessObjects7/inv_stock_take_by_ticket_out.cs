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
namespace SYSPRO.NET.BusinessObjects.inv_stock_take_by_ticket_out {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class InventoryStockTakeByTicketNumber {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", typeof(InventoryStockTakeByTicketNumberQueryOptions), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("StockItemDetails", typeof(InventoryStockTakeByTicketNumberStockItemDetails), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", typeof(InventoryStockTakeByTicketNumberSystemInformation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("TranslatedText", typeof(InventoryStockTakeByTicketNumberTranslatedText), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    public partial class InventoryStockTakeByTicketNumberQueryOptions {
        
        private string warehouseField;
        
        private string descriptionField;
        
        private string ticketByStockCodeField;
        
        private string ticketNumberFilterTypeField;
        
        private string ticketNumberFilterValueField;
        
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
        public string TicketByStockCode {
            get {
                return this.ticketByStockCodeField;
            }
            set {
                this.ticketByStockCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TicketNumberFilterType {
            get {
                return this.ticketNumberFilterTypeField;
            }
            set {
                this.ticketNumberFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TicketNumberFilterValue {
            get {
                return this.ticketNumberFilterValueField;
            }
            set {
                this.ticketNumberFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InventoryStockTakeByTicketNumberStockItemDetails {
        
        private InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetail[] stockItemDetailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StockItemDetail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetail[] StockItemDetail {
            get {
                return this.stockItemDetailField;
            }
            set {
                this.stockItemDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetail {
        
        private InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetailTicketDetails[] ticketDetailsField;
        
        private InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetailStockTotals[] stockTotalsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TicketDetails", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetailTicketDetails[] TicketDetails {
            get {
                return this.ticketDetailsField;
            }
            set {
                this.ticketDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StockTotals", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetailStockTotals[] StockTotals {
            get {
                return this.stockTotalsField;
            }
            set {
                this.stockTotalsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetailTicketDetails {
        
        private string stockCodeField;
        
        private string descriptionField;
        
        private string binField;
        
        private string unitOfMeasureField;
        
        private string captureUnitOfMeasureField;
        
        private string productClassField;
        
        private double unitMassField;
        
        private bool unitMassFieldSpecified;
        
        private string ticketNumField;
        
        private string missingTicketsField;
        
        private double qtyCapturedField;
        
        private bool qtyCapturedFieldSpecified;
        
        private string qtyCapturedUnitsField;
        
        private double decimalsField;
        
        private bool decimalsFieldSpecified;
        
        private string commentsField;
        
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
        public string Bin {
            get {
                return this.binField;
            }
            set {
                this.binField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CaptureUnitOfMeasure {
            get {
                return this.captureUnitOfMeasureField;
            }
            set {
                this.captureUnitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ProductClass {
            get {
                return this.productClassField;
            }
            set {
                this.productClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double UnitMass {
            get {
                return this.unitMassField;
            }
            set {
                this.unitMassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnitMassSpecified {
            get {
                return this.unitMassFieldSpecified;
            }
            set {
                this.unitMassFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TicketNum {
            get {
                return this.ticketNumField;
            }
            set {
                this.ticketNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MissingTickets {
            get {
                return this.missingTicketsField;
            }
            set {
                this.missingTicketsField = value;
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
        public string QtyCapturedUnits {
            get {
                return this.qtyCapturedUnitsField;
            }
            set {
                this.qtyCapturedUnitsField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InventoryStockTakeByTicketNumberStockItemDetailsStockItemDetailStockTotals {
        
        private double totalQtyCapturedField;
        
        private bool totalQtyCapturedFieldSpecified;
        
        private string totalQtyCapturedUnitsField;
        
        private double totalOrigQtyOnHandField;
        
        private bool totalOrigQtyOnHandFieldSpecified;
        
        private string totalOrigQtyOnHandUnitsField;
        
        private double totalQtyVarianceField;
        
        private bool totalQtyVarianceFieldSpecified;
        
        private string totalQtyVarianceUnitsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double TotalQtyCaptured {
            get {
                return this.totalQtyCapturedField;
            }
            set {
                this.totalQtyCapturedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalQtyCapturedSpecified {
            get {
                return this.totalQtyCapturedFieldSpecified;
            }
            set {
                this.totalQtyCapturedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TotalQtyCapturedUnits {
            get {
                return this.totalQtyCapturedUnitsField;
            }
            set {
                this.totalQtyCapturedUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double TotalOrigQtyOnHand {
            get {
                return this.totalOrigQtyOnHandField;
            }
            set {
                this.totalOrigQtyOnHandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalOrigQtyOnHandSpecified {
            get {
                return this.totalOrigQtyOnHandFieldSpecified;
            }
            set {
                this.totalOrigQtyOnHandFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TotalOrigQtyOnHandUnits {
            get {
                return this.totalOrigQtyOnHandUnitsField;
            }
            set {
                this.totalOrigQtyOnHandUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double TotalQtyVariance {
            get {
                return this.totalQtyVarianceField;
            }
            set {
                this.totalQtyVarianceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalQtyVarianceSpecified {
            get {
                return this.totalQtyVarianceFieldSpecified;
            }
            set {
                this.totalQtyVarianceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TotalQtyVarianceUnits {
            get {
                return this.totalQtyVarianceUnitsField;
            }
            set {
                this.totalQtyVarianceUnitsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class InventoryStockTakeByTicketNumberSystemInformation {
        
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
    public partial class InventoryStockTakeByTicketNumberTranslatedText {
        
        private string text_YesField;
        
        private string text_NoField;
        
        private string text_RangeField;
        
        private string text_AllField;
        
        private string text_SingleField;
        
        private string text_Tickets_by_Stock_Code_ReportField;
        
        private string text_Stock_Take_Report_in_Ticket_Number_SequenceField;
        
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
        public string Text_Tickets_by_Stock_Code_Report {
            get {
                return this.text_Tickets_by_Stock_Code_ReportField;
            }
            set {
                this.text_Tickets_by_Stock_Code_ReportField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Text_Stock_Take_Report_in_Ticket_Number_Sequence {
            get {
                return this.text_Stock_Take_Report_in_Ticket_Number_SequenceField;
            }
            set {
                this.text_Stock_Take_Report_in_Ticket_Number_SequenceField = value;
            }
        }
    }
}
