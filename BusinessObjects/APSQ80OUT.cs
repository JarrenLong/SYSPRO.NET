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
namespace SYSPRO.NET.BusinessObjects.APSQ80OUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class APInvoiceRegistration {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApInvoiceRegistrationItems", typeof(APInvoiceRegistrationApInvoiceRegistrationItems), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", typeof(APInvoiceRegistrationQueryOptions), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", typeof(APInvoiceRegistrationSystemInformation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    public partial class APInvoiceRegistrationApInvoiceRegistrationItems {
        
        private APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItem[] apInvoiceRegistrationItemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ApInvoiceRegistrationItem", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItem[] ApInvoiceRegistrationItem {
            get {
                return this.apInvoiceRegistrationItemField;
            }
            set {
                this.apInvoiceRegistrationItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItem {
        
        private APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceRegistrationHeader[] invoiceRegistrationHeaderField;
        
        private APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceDetails[] invoiceDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceRegistrationHeader", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceRegistrationHeader[] InvoiceRegistrationHeader {
            get {
                return this.invoiceRegistrationHeaderField;
            }
            set {
                this.invoiceRegistrationHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDetails", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceDetails[] InvoiceDetails {
            get {
                return this.invoiceDetailsField;
            }
            set {
                this.invoiceDetailsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceRegistrationHeader {
        
        private string buyerField;
        
        private string supplierField;
        
        private string aPSMST_DescriptionField;
        
        private string supplierClassField;
        
        private string tBLAPC_DescriptionField;
        
        private string authorizingPersonField;
        
        private string supplierOnHoldField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Buyer {
            get {
                return this.buyerField;
            }
            set {
                this.buyerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APSMST_Description {
            get {
                return this.aPSMST_DescriptionField;
            }
            set {
                this.aPSMST_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierClass {
            get {
                return this.supplierClassField;
            }
            set {
                this.supplierClassField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string TBLAPC_Description {
            get {
                return this.tBLAPC_DescriptionField;
            }
            set {
                this.tBLAPC_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AuthorizingPerson {
            get {
                return this.authorizingPersonField;
            }
            set {
                this.authorizingPersonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierOnHold {
            get {
                return this.supplierOnHoldField;
            }
            set {
                this.supplierOnHoldField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceDetails {
        
        private string invoiceField;
        
        private string branchField;
        
        private string aPSBRN_DescriptionField;
        
        private double invoiceAmountField;
        
        private bool invoiceAmountFieldSpecified;
        
        private double invoiceDiscountField;
        
        private bool invoiceDiscountFieldSpecified;
        
        private string invoiceDateField;
        
        private string dueDateField;
        
        private string referenceField;
        
        private string departmentField;
        
        private string dateSentField;
        
        private string followUpDateField;
        
        private string invoiceDetailsEntryDateField;
        
        private string statusField;
        
        private string operatorField;
        
        private string aDMOPR_NameField;
        
        private string approveDateField;
        
        private string reasonCancelledField;
        
        private string cancelledDateField;
        
        private string purgeDateField;
        
        private string reasonReturnedField;
        
        private string returnDateField;
        
        private string reasonModifiedField;
        
        private string modifyDateField;
        
        private string relatedPurchaseOrderField;
        
        private APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceDetailsNotesText[][] notesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Invoice {
            get {
                return this.invoiceField;
            }
            set {
                this.invoiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string APSBRN_Description {
            get {
                return this.aPSBRN_DescriptionField;
            }
            set {
                this.aPSBRN_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double InvoiceAmount {
            get {
                return this.invoiceAmountField;
            }
            set {
                this.invoiceAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceAmountSpecified {
            get {
                return this.invoiceAmountFieldSpecified;
            }
            set {
                this.invoiceAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double InvoiceDiscount {
            get {
                return this.invoiceDiscountField;
            }
            set {
                this.invoiceDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceDiscountSpecified {
            get {
                return this.invoiceDiscountFieldSpecified;
            }
            set {
                this.invoiceDiscountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InvoiceDate {
            get {
                return this.invoiceDateField;
            }
            set {
                this.invoiceDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DateSent {
            get {
                return this.dateSentField;
            }
            set {
                this.dateSentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FollowUpDate {
            get {
                return this.followUpDateField;
            }
            set {
                this.followUpDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InvoiceDetailsEntryDate {
            get {
                return this.invoiceDetailsEntryDateField;
            }
            set {
                this.invoiceDetailsEntryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ADMOPR_Name {
            get {
                return this.aDMOPR_NameField;
            }
            set {
                this.aDMOPR_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ApproveDate {
            get {
                return this.approveDateField;
            }
            set {
                this.approveDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReasonCancelled {
            get {
                return this.reasonCancelledField;
            }
            set {
                this.reasonCancelledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CancelledDate {
            get {
                return this.cancelledDateField;
            }
            set {
                this.cancelledDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PurgeDate {
            get {
                return this.purgeDateField;
            }
            set {
                this.purgeDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReasonReturned {
            get {
                return this.reasonReturnedField;
            }
            set {
                this.reasonReturnedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnDate {
            get {
                return this.returnDateField;
            }
            set {
                this.returnDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReasonModified {
            get {
                return this.reasonModifiedField;
            }
            set {
                this.reasonModifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ModifyDate {
            get {
                return this.modifyDateField;
            }
            set {
                this.modifyDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string RelatedPurchaseOrder {
            get {
                return this.relatedPurchaseOrderField;
            }
            set {
                this.relatedPurchaseOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Text", typeof(APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceDetailsNotesText), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceDetailsNotesText[][] Notes {
            get {
                return this.notesField;
            }
            set {
                this.notesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APInvoiceRegistrationApInvoiceRegistrationItemsApInvoiceRegistrationItemInvoiceDetailsNotesText {
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APInvoiceRegistrationQueryOptions {
        
        private string reportSequenceField;
        
        private string invoiceStatusField;
        
        private string newPagePerSupplierField;
        
        private string printRelatedPurchaseOrdersField;
        
        private string printNotesField;
        
        private string supplierFilterTypeField;
        
        private string supplierFilterValueField;
        
        private string branchFilterTypeField;
        
        private string branchFilterValueField;
        
        private string supplierClassFilterTypeField;
        
        private string supplierClassFilterValueField;
        
        private string buyerFilterTypeField;
        
        private string buyerFilterValueField;
        
        private string authorizingPersonFilterTypeField;
        
        private string authorizingPersonFilterValueField;
        
        private string departmentFilterTypeField;
        
        private string departmentFilterValueField;
        
        private string invoiceFilterTypeField;
        
        private string invoiceFilterValueField;
        
        private string followUpDateFilterTypeField;
        
        private string followUpDateFilterValueField;
        
        private string returnNotesInBlockField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReportSequence {
            get {
                return this.reportSequenceField;
            }
            set {
                this.reportSequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InvoiceStatus {
            get {
                return this.invoiceStatusField;
            }
            set {
                this.invoiceStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string NewPagePerSupplier {
            get {
                return this.newPagePerSupplierField;
            }
            set {
                this.newPagePerSupplierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrintRelatedPurchaseOrders {
            get {
                return this.printRelatedPurchaseOrdersField;
            }
            set {
                this.printRelatedPurchaseOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string PrintNotes {
            get {
                return this.printNotesField;
            }
            set {
                this.printNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierFilterType {
            get {
                return this.supplierFilterTypeField;
            }
            set {
                this.supplierFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierFilterValue {
            get {
                return this.supplierFilterValueField;
            }
            set {
                this.supplierFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BranchFilterType {
            get {
                return this.branchFilterTypeField;
            }
            set {
                this.branchFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BranchFilterValue {
            get {
                return this.branchFilterValueField;
            }
            set {
                this.branchFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierClassFilterType {
            get {
                return this.supplierClassFilterTypeField;
            }
            set {
                this.supplierClassFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SupplierClassFilterValue {
            get {
                return this.supplierClassFilterValueField;
            }
            set {
                this.supplierClassFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BuyerFilterType {
            get {
                return this.buyerFilterTypeField;
            }
            set {
                this.buyerFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BuyerFilterValue {
            get {
                return this.buyerFilterValueField;
            }
            set {
                this.buyerFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AuthorizingPersonFilterType {
            get {
                return this.authorizingPersonFilterTypeField;
            }
            set {
                this.authorizingPersonFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string AuthorizingPersonFilterValue {
            get {
                return this.authorizingPersonFilterValueField;
            }
            set {
                this.authorizingPersonFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DepartmentFilterType {
            get {
                return this.departmentFilterTypeField;
            }
            set {
                this.departmentFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DepartmentFilterValue {
            get {
                return this.departmentFilterValueField;
            }
            set {
                this.departmentFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InvoiceFilterType {
            get {
                return this.invoiceFilterTypeField;
            }
            set {
                this.invoiceFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string InvoiceFilterValue {
            get {
                return this.invoiceFilterValueField;
            }
            set {
                this.invoiceFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FollowUpDateFilterType {
            get {
                return this.followUpDateFilterTypeField;
            }
            set {
                this.followUpDateFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FollowUpDateFilterValue {
            get {
                return this.followUpDateFilterValueField;
            }
            set {
                this.followUpDateFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReturnNotesInBlock {
            get {
                return this.returnNotesInBlockField;
            }
            set {
                this.returnNotesInBlockField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class APInvoiceRegistrationSystemInformation {
        
        private string cssStyleField;
        
        private string languageField;
        
        private string decFormatField;
        
        private string dateFormatField;
        
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
    }
}
