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
namespace SYSPRO.NET.BusinessObjects.APSTRIDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DiscountBasis {
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        V,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private string supplierField;
        
        private string branchField;
        
        private string invoiceField;
        
        private string invoiceValueField;
        
        private DiscountBasis discountBasisField;
        
        private bool discountBasisFieldSpecified;
        
        private string discountableValueField;
        
        private string discountPercentageValueField;
        
        private string referenceField;
        
        private string invoiceDateField;
        
        private string dueDateField;
        
        private string discountDateField;
        
        private string exchRateAtEntryField;
        
        private string authorisingPersonField;
        
        private string buyerField;
        
        private string dateInvoiceSentField;
        
        private string departmentField;
        
        private string followUpDateField;
        
        private string narrationField;
        
        private string eSignatureField;
        
        private string[] ordersField;
        
        private TransactionType transactionTypeField;
        
        private bool transactionTypeFieldSpecified;
        
        public Item() {
            this.discountBasisField = DiscountBasis.T;
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
        public string Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
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
        public string InvoiceValue {
            get {
                return this.invoiceValueField;
            }
            set {
                this.invoiceValueField = value;
            }
        }
        
        /// <remarks/>
        public DiscountBasis DiscountBasis {
            get {
                return this.discountBasisField;
            }
            set {
                this.discountBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountBasisSpecified {
            get {
                return this.discountBasisFieldSpecified;
            }
            set {
                this.discountBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string DiscountableValue {
            get {
                return this.discountableValueField;
            }
            set {
                this.discountableValueField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPercentageValue {
            get {
                return this.discountPercentageValueField;
            }
            set {
                this.discountPercentageValueField = value;
            }
        }
        
        /// <remarks/>
        public string Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
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
        public string DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountDate {
            get {
                return this.discountDateField;
            }
            set {
                this.discountDateField = value;
            }
        }
        
        /// <remarks/>
        public string ExchRateAtEntry {
            get {
                return this.exchRateAtEntryField;
            }
            set {
                this.exchRateAtEntryField = value;
            }
        }
        
        /// <remarks/>
        public string AuthorisingPerson {
            get {
                return this.authorisingPersonField;
            }
            set {
                this.authorisingPersonField = value;
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
        public string DateInvoiceSent {
            get {
                return this.dateInvoiceSentField;
            }
            set {
                this.dateInvoiceSentField = value;
            }
        }
        
        /// <remarks/>
        public string Department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }
        
        /// <remarks/>
        public string FollowUpDate {
            get {
                return this.followUpDateField;
            }
            set {
                this.followUpDateField = value;
            }
        }
        
        /// <remarks/>
        public string Narration {
            get {
                return this.narrationField;
            }
            set {
                this.narrationField = value;
            }
        }
        
        /// <remarks/>
        public string eSignature {
            get {
                return this.eSignatureField;
            }
            set {
                this.eSignatureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PurchaseOrder", IsNullable=false)]
        public string[] Orders {
            get {
                return this.ordersField;
            }
            set {
                this.ordersField = value;
            }
        }
        
        /// <remarks/>
        public TransactionType TransactionType {
            get {
                return this.transactionTypeField;
            }
            set {
                this.transactionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionTypeSpecified {
            get {
                return this.transactionTypeFieldSpecified;
            }
            set {
                this.transactionTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum TransactionType {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Orders {
        
        private string[] purchaseOrderField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PurchaseOrder")]
        public string[] PurchaseOrder {
            get {
                return this.purchaseOrderField;
            }
            set {
                this.purchaseOrderField = value;
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
    public partial class PostApRegisterInvoice {
        
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
