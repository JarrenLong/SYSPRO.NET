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
namespace SYSPRO.NET.BusinessObjects.PORTRQDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private string userField;
        
        private string userPasswordField;
        
        private string requisitionNumberField;
        
        private string requisitionLineField;
        
        private string stockCodeField;
        
        private string descriptionField;
        
        private string revisionField;
        
        private string releaseField;
        
        private string quantityField;
        
        private string unitsField;
        
        private string piecesField;
        
        private string unitOfMeasureField;
        
        private string dueDateField;
        
        private string reasonField;
        
        private ItemIncludeInMrp includeInMrpField;
        
        private bool includeInMrpFieldSpecified;
        
        private RouteOn routeOnField;
        
        private bool routeOnFieldSpecified;
        
        private string routeToUserField;
        
        private string routeNotationField;
        
        private RequisitionType requisitionTypeField;
        
        private string supplierField;
        
        private string priceField;
        
        private string priceUomField;
        
        private string discountCodeField;
        
        private string discPercent1Field;
        
        private string discPercent2Field;
        
        private string discPercent3Field;
        
        private LessPlusDisc lessPlusDiscField;
        
        private bool lessPlusDiscFieldSpecified;
        
        private string warehouseField;
        
        private string storesWarehouseField;
        
        private string catalogueField;
        
        private string jobField;
        
        private string operationField;
        
        private string ledgerCodeField;
        
        private string passwordForLedgerCodeField;
        
        private string productClassField;
        
        private string taxCodeField;
        
        private string customerField;
        
        private string customerPoNumberField;
        
        private string capexNumberField;
        
        private string buyerField;
        
        private string deliveryTermsField;
        
        private string shippingLocationField;
        
        private string notesField;
        
        private string purchaseOrderCommentsField;
        
        private ReceiptIntoInspection receiptIntoInspectionField;
        
        private bool receiptIntoInspectionFieldSpecified;
        
        private string withholdingTaxExpenseTypeField;
        
        private object eSignatureField;
        
        public Item() {
            this.requisitionTypeField = RequisitionType.N;
            this.lessPlusDiscField = LessPlusDisc.L;
        }
        
        /// <remarks/>
        public string User {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        
        /// <remarks/>
        public string UserPassword {
            get {
                return this.userPasswordField;
            }
            set {
                this.userPasswordField = value;
            }
        }
        
        /// <remarks/>
        public string RequisitionNumber {
            get {
                return this.requisitionNumberField;
            }
            set {
                this.requisitionNumberField = value;
            }
        }
        
        /// <remarks/>
        public string RequisitionLine {
            get {
                return this.requisitionLineField;
            }
            set {
                this.requisitionLineField = value;
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string Revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
            }
        }
        
        /// <remarks/>
        public string Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
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
        public string Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        public string Pieces {
            get {
                return this.piecesField;
            }
            set {
                this.piecesField = value;
            }
        }
        
        /// <remarks/>
        public string UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        public string DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        public string Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
        
        /// <remarks/>
        public ItemIncludeInMrp IncludeInMrp {
            get {
                return this.includeInMrpField;
            }
            set {
                this.includeInMrpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeInMrpSpecified {
            get {
                return this.includeInMrpFieldSpecified;
            }
            set {
                this.includeInMrpFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public RouteOn RouteOn {
            get {
                return this.routeOnField;
            }
            set {
                this.routeOnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RouteOnSpecified {
            get {
                return this.routeOnFieldSpecified;
            }
            set {
                this.routeOnFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string RouteToUser {
            get {
                return this.routeToUserField;
            }
            set {
                this.routeToUserField = value;
            }
        }
        
        /// <remarks/>
        public string RouteNotation {
            get {
                return this.routeNotationField;
            }
            set {
                this.routeNotationField = value;
            }
        }
        
        /// <remarks/>
        public RequisitionType RequisitionType {
            get {
                return this.requisitionTypeField;
            }
            set {
                this.requisitionTypeField = value;
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
        public string Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string PriceUom {
            get {
                return this.priceUomField;
            }
            set {
                this.priceUomField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountCode {
            get {
                return this.discountCodeField;
            }
            set {
                this.discountCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DiscPercent1 {
            get {
                return this.discPercent1Field;
            }
            set {
                this.discPercent1Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscPercent2 {
            get {
                return this.discPercent2Field;
            }
            set {
                this.discPercent2Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscPercent3 {
            get {
                return this.discPercent3Field;
            }
            set {
                this.discPercent3Field = value;
            }
        }
        
        /// <remarks/>
        public LessPlusDisc LessPlusDisc {
            get {
                return this.lessPlusDiscField;
            }
            set {
                this.lessPlusDiscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LessPlusDiscSpecified {
            get {
                return this.lessPlusDiscFieldSpecified;
            }
            set {
                this.lessPlusDiscFieldSpecified = value;
            }
        }
        
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
        public string StoresWarehouse {
            get {
                return this.storesWarehouseField;
            }
            set {
                this.storesWarehouseField = value;
            }
        }
        
        /// <remarks/>
        public string Catalogue {
            get {
                return this.catalogueField;
            }
            set {
                this.catalogueField = value;
            }
        }
        
        /// <remarks/>
        public string Job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        public string Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        public string LedgerCode {
            get {
                return this.ledgerCodeField;
            }
            set {
                this.ledgerCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PasswordForLedgerCode {
            get {
                return this.passwordForLedgerCodeField;
            }
            set {
                this.passwordForLedgerCodeField = value;
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
        public string TaxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }
        
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
        public string CustomerPoNumber {
            get {
                return this.customerPoNumberField;
            }
            set {
                this.customerPoNumberField = value;
            }
        }
        
        /// <remarks/>
        public string CapexNumber {
            get {
                return this.capexNumberField;
            }
            set {
                this.capexNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Buyer {
            get {
                return this.buyerField;
            }
            set {
                this.buyerField = value;
            }
        }
        
        /// <remarks/>
        public string DeliveryTerms {
            get {
                return this.deliveryTermsField;
            }
            set {
                this.deliveryTermsField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingLocation {
            get {
                return this.shippingLocationField;
            }
            set {
                this.shippingLocationField = value;
            }
        }
        
        /// <remarks/>
        public string Notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        public string PurchaseOrderComments {
            get {
                return this.purchaseOrderCommentsField;
            }
            set {
                this.purchaseOrderCommentsField = value;
            }
        }
        
        /// <remarks/>
        public ReceiptIntoInspection ReceiptIntoInspection {
            get {
                return this.receiptIntoInspectionField;
            }
            set {
                this.receiptIntoInspectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiptIntoInspectionSpecified {
            get {
                return this.receiptIntoInspectionFieldSpecified;
            }
            set {
                this.receiptIntoInspectionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingTaxExpenseType {
            get {
                return this.withholdingTaxExpenseTypeField;
            }
            set {
                this.withholdingTaxExpenseTypeField = value;
            }
        }
        
        /// <remarks/>
        public object eSignature {
            get {
                return this.eSignatureField;
            }
            set {
                this.eSignatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ItemIncludeInMrp {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum RouteOn {
        
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum RequisitionType {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        T,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum LessPlusDisc {
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReceiptIntoInspection {
        
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostRequisition {
        
        private Item itemField;
        
        /// <remarks/>
        public Item Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
