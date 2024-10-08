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
namespace SYSPRO.NET.BusinessObjects.WIPTWTDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostWipTransfer {
        
        private PostWipTransferItem[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public PostWipTransferItem[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostWipTransferItem {
        
        private string partBillingJournalField;
        
        private string inventoryJournalField;
        
        private string jobField;
        
        private PostWipTransferItemUnitOfMeasure unitOfMeasureField;
        
        private string quantityField;
        
        private PostWipTransferItemJobComplete jobCompleteField;
        
        private PostWipTransferItemCloseDate closeDateField;
        
        private string productClassField;
        
        private PostWipTransferItemWipValueBasis wipValueBasisField;
        
        private string materialValueField;
        
        private string laborValueField;
        
        private PostWipTransferItemCostBasis costBasisField;
        
        private bool costBasisFieldSpecified;
        
        private string lotField;
        
        private string lotConcessionField;
        
        private string lotCertificateField;
        
        private string referenceField;
        
        private string notationField;
        
        private string addReferenceField;
        
        private string materialReferenceField;
        
        private string eSignatureField;
        
        public PostWipTransferItem() {
            this.unitOfMeasureField = PostWipTransferItemUnitOfMeasure.S;
            this.jobCompleteField = PostWipTransferItemJobComplete.N;
            this.closeDateField = PostWipTransferItemCloseDate.N;
            this.wipValueBasisField = PostWipTransferItemWipValueBasis.A;
        }
        
        /// <remarks/>
        public string PartBillingJournal {
            get {
                return this.partBillingJournalField;
            }
            set {
                this.partBillingJournalField = value;
            }
        }
        
        /// <remarks/>
        public string InventoryJournal {
            get {
                return this.inventoryJournalField;
            }
            set {
                this.inventoryJournalField = value;
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
        public PostWipTransferItemUnitOfMeasure UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
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
        [System.ComponentModel.DefaultValueAttribute(PostWipTransferItemJobComplete.N)]
        public PostWipTransferItemJobComplete JobComplete {
            get {
                return this.jobCompleteField;
            }
            set {
                this.jobCompleteField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostWipTransferItemCloseDate.N)]
        public PostWipTransferItemCloseDate CloseDate {
            get {
                return this.closeDateField;
            }
            set {
                this.closeDateField = value;
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
        [System.ComponentModel.DefaultValueAttribute(PostWipTransferItemWipValueBasis.A)]
        public PostWipTransferItemWipValueBasis WipValueBasis {
            get {
                return this.wipValueBasisField;
            }
            set {
                this.wipValueBasisField = value;
            }
        }
        
        /// <remarks/>
        public string MaterialValue {
            get {
                return this.materialValueField;
            }
            set {
                this.materialValueField = value;
            }
        }
        
        /// <remarks/>
        public string LaborValue {
            get {
                return this.laborValueField;
            }
            set {
                this.laborValueField = value;
            }
        }
        
        /// <remarks/>
        public PostWipTransferItemCostBasis CostBasis {
            get {
                return this.costBasisField;
            }
            set {
                this.costBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CostBasisSpecified {
            get {
                return this.costBasisFieldSpecified;
            }
            set {
                this.costBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
            }
        }
        
        /// <remarks/>
        public string LotConcession {
            get {
                return this.lotConcessionField;
            }
            set {
                this.lotConcessionField = value;
            }
        }
        
        /// <remarks/>
        public string LotCertificate {
            get {
                return this.lotCertificateField;
            }
            set {
                this.lotCertificateField = value;
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
        public string Notation {
            get {
                return this.notationField;
            }
            set {
                this.notationField = value;
            }
        }
        
        /// <remarks/>
        public string AddReference {
            get {
                return this.addReferenceField;
            }
            set {
                this.addReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string MaterialReference {
            get {
                return this.materialReferenceField;
            }
            set {
                this.materialReferenceField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostWipTransferItemUnitOfMeasure {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        M,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostWipTransferItemJobComplete {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostWipTransferItemCloseDate {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostWipTransferItemWipValueBasis {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        W,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostWipTransferItemCostBasis {
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
}
