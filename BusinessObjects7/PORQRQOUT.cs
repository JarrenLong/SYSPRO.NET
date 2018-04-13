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
namespace SYSPRO.NET.BusinessObjects.PORQRQOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ReqQuery {
        
        private ReqQuerySystemInformation systemInformationField;
        
        private string userNameField;
        
        private string userCodeField;
        
        private ReqQueryRequisitionItem[] requisitionItemField;
        
        /// <remarks/>
        public ReqQuerySystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string UserCode {
            get {
                return this.userCodeField;
            }
            set {
                this.userCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequisitionItem")]
        public ReqQueryRequisitionItem[] RequisitionItem {
            get {
                return this.requisitionItemField;
            }
            set {
                this.requisitionItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReqQuerySystemInformation {
        
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
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReqQueryRequisitionItem {
        
        private string requisitionField;
        
        private string reasonForReqnField;
        
        private string lineField;
        
        private string showCommitmentStatusField;
        
        private string warnIfBudgetExceededField;
        
        private string notationField;
        
        private ReqQueryRequisitionItemFromUserInformation fromUserInformationField;
        
        private string routeNarrativeField;
        
        private string supplierField;
        
        private string supplierNameField;
        
        private string supplierCurrencyField;
        
        private string priceField;
        
        private string priceUomField;
        
        private string glCodeField;
        
        private string discountCodeField;
        
        private string lessPlusDiscField;
        
        private string discPct1Field;
        
        private string discPct2Field;
        
        private string discPct3Field;
        
        private string versionField;
        
        private string releaseField;
        
        private string eccHoldField;
        
        private string orderQtyField;
        
        private string orderUomField;
        
        private string dateReqnRaisedField;
        
        private string dueDateField;
        
        private string dateLastReceiptField;
        
        private string datePoConfirmedField;
        
        private string dateActionedField;
        
        private string reqnStatusField;
        
        private string includeInMrpField;
        
        private string reqnStatDescriptionField;
        
        private string pOStatusField;
        
        private string stockCodeField;
        
        private string stockDescriptionField;
        
        private string includeInMrp1Field;
        
        private string warehouseField;
        
        private string supCatalogueNumField;
        
        private string buyerField;
        
        private string customerField;
        
        private string customerPoNumberField;
        
        private string productClassField;
        
        private string taxCodeField;
        
        private string salesOrderField;
        
        private string salesOrderLineField;
        
        private string quoteField;
        
        private string quoteLineNumField;
        
        private string capexNumField;
        
        private string bpoApprovedField;
        
        private string jobField;
        
        private string jobDescriptionField;
        
        private string subOperationNumField;
        
        private ReqQueryRequisitionItemOriginatorInformation originatorInformationField;
        
        private string confirmedPoNumField;
        
        private string confirmedPoLineField;
        
        private ReqQueryRequisitionItemHolderInformation holderInformationField;
        
        private ReqQueryRequisitionItemApprovedInformation approvedInformationField;
        
        private string[] notesField;
        
        private string[] commentsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Requisition {
            get {
                return this.requisitionField;
            }
            set {
                this.requisitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ReasonForReqn {
            get {
                return this.reasonForReqnField;
            }
            set {
                this.reasonForReqnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ShowCommitmentStatus {
            get {
                return this.showCommitmentStatusField;
            }
            set {
                this.showCommitmentStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string WarnIfBudgetExceeded {
            get {
                return this.warnIfBudgetExceededField;
            }
            set {
                this.warnIfBudgetExceededField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Notation {
            get {
                return this.notationField;
            }
            set {
                this.notationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public ReqQueryRequisitionItemFromUserInformation FromUserInformation {
            get {
                return this.fromUserInformationField;
            }
            set {
                this.fromUserInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string RouteNarrative {
            get {
                return this.routeNarrativeField;
            }
            set {
                this.routeNarrativeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string SupplierName {
            get {
                return this.supplierNameField;
            }
            set {
                this.supplierNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string SupplierCurrency {
            get {
                return this.supplierCurrencyField;
            }
            set {
                this.supplierCurrencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string PriceUom {
            get {
                return this.priceUomField;
            }
            set {
                this.priceUomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string GlCode {
            get {
                return this.glCodeField;
            }
            set {
                this.glCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string DiscountCode {
            get {
                return this.discountCodeField;
            }
            set {
                this.discountCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string LessPlusDisc {
            get {
                return this.lessPlusDiscField;
            }
            set {
                this.lessPlusDiscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string DiscPct1 {
            get {
                return this.discPct1Field;
            }
            set {
                this.discPct1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string DiscPct2 {
            get {
                return this.discPct2Field;
            }
            set {
                this.discPct2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string DiscPct3 {
            get {
                return this.discPct3Field;
            }
            set {
                this.discPct3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string EccHold {
            get {
                return this.eccHoldField;
            }
            set {
                this.eccHoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string OrderQty {
            get {
                return this.orderQtyField;
            }
            set {
                this.orderQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string OrderUom {
            get {
                return this.orderUomField;
            }
            set {
                this.orderUomField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string DateReqnRaised {
            get {
                return this.dateReqnRaisedField;
            }
            set {
                this.dateReqnRaisedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public string DateLastReceipt {
            get {
                return this.dateLastReceiptField;
            }
            set {
                this.dateLastReceiptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public string DatePoConfirmed {
            get {
                return this.datePoConfirmedField;
            }
            set {
                this.datePoConfirmedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=28)]
        public string DateActioned {
            get {
                return this.dateActionedField;
            }
            set {
                this.dateActionedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=29)]
        public string ReqnStatus {
            get {
                return this.reqnStatusField;
            }
            set {
                this.reqnStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public string IncludeInMrp {
            get {
                return this.includeInMrpField;
            }
            set {
                this.includeInMrpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=31)]
        public string ReqnStatDescription {
            get {
                return this.reqnStatDescriptionField;
            }
            set {
                this.reqnStatDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public string POStatus {
            get {
                return this.pOStatusField;
            }
            set {
                this.pOStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=33)]
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=34)]
        public string StockDescription {
            get {
                return this.stockDescriptionField;
            }
            set {
                this.stockDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncludeInMrp", Order=35)]
        public string IncludeInMrp1 {
            get {
                return this.includeInMrp1Field;
            }
            set {
                this.includeInMrp1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=36)]
        public string Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=37)]
        public string SupCatalogueNum {
            get {
                return this.supCatalogueNumField;
            }
            set {
                this.supCatalogueNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=38)]
        public string Buyer {
            get {
                return this.buyerField;
            }
            set {
                this.buyerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=39)]
        public string Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=40)]
        public string CustomerPoNumber {
            get {
                return this.customerPoNumberField;
            }
            set {
                this.customerPoNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=41)]
        public string ProductClass {
            get {
                return this.productClassField;
            }
            set {
                this.productClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=42)]
        public string TaxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=43)]
        public string SalesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=44)]
        public string SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=45)]
        public string Quote {
            get {
                return this.quoteField;
            }
            set {
                this.quoteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=46)]
        public string QuoteLineNum {
            get {
                return this.quoteLineNumField;
            }
            set {
                this.quoteLineNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=47)]
        public string CapexNum {
            get {
                return this.capexNumField;
            }
            set {
                this.capexNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=48)]
        public string BpoApproved {
            get {
                return this.bpoApprovedField;
            }
            set {
                this.bpoApprovedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=49)]
        public string Job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=50)]
        public string JobDescription {
            get {
                return this.jobDescriptionField;
            }
            set {
                this.jobDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=51)]
        public string SubOperationNum {
            get {
                return this.subOperationNumField;
            }
            set {
                this.subOperationNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=52)]
        public ReqQueryRequisitionItemOriginatorInformation OriginatorInformation {
            get {
                return this.originatorInformationField;
            }
            set {
                this.originatorInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=53)]
        public string ConfirmedPoNum {
            get {
                return this.confirmedPoNumField;
            }
            set {
                this.confirmedPoNumField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=54)]
        public string ConfirmedPoLine {
            get {
                return this.confirmedPoLineField;
            }
            set {
                this.confirmedPoLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=55)]
        public ReqQueryRequisitionItemHolderInformation HolderInformation {
            get {
                return this.holderInformationField;
            }
            set {
                this.holderInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=56)]
        public ReqQueryRequisitionItemApprovedInformation ApprovedInformation {
            get {
                return this.approvedInformationField;
            }
            set {
                this.approvedInformationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=57)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable=false)]
        public string[] Notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=58)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable=false)]
        public string[] Comments {
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
    public partial class ReqQueryRequisitionItemFromUserInformation {
        
        private string fromUserField;
        
        private string userNameField;
        
        /// <remarks/>
        public string FromUser {
            get {
                return this.fromUserField;
            }
            set {
                this.fromUserField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReqQueryRequisitionItemOriginatorInformation {
        
        private string originatorField;
        
        private string userNameField;
        
        /// <remarks/>
        public string Originator {
            get {
                return this.originatorField;
            }
            set {
                this.originatorField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReqQueryRequisitionItemHolderInformation {
        
        private string currentHolderField;
        
        private string userNameField;
        
        /// <remarks/>
        public string CurrentHolder {
            get {
                return this.currentHolderField;
            }
            set {
                this.currentHolderField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReqQueryRequisitionItemApprovedInformation {
        
        private string userCodeField;
        
        private string userNameField;
        
        /// <remarks/>
        public string UserCode {
            get {
                return this.userCodeField;
            }
            set {
                this.userCodeField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
    }
}
