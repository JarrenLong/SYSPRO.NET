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
namespace SYSPRO.NET.BusinessObjects.ARSSIDDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DiscBasis {
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum PriceFlag {
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private Key keyField;
        
        private string descriptionField;
        
        private string discountPct1Field;
        
        private string discountPct2Field;
        
        private string discountPct3Field;
        
        private DiscBasis discBasisField;
        
        private bool discBasisFieldSpecified;
        
        private string priceCodeField;
        
        private PriceFlag priceFlagField;
        
        private bool priceFlagFieldSpecified;
        
        private string eSignatureField;
        
        /// <remarks/>
        public Key Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
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
        public string DiscountPct1 {
            get {
                return this.discountPct1Field;
            }
            set {
                this.discountPct1Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPct2 {
            get {
                return this.discountPct2Field;
            }
            set {
                this.discountPct2Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPct3 {
            get {
                return this.discountPct3Field;
            }
            set {
                this.discountPct3Field = value;
            }
        }
        
        /// <remarks/>
        public DiscBasis DiscBasis {
            get {
                return this.discBasisField;
            }
            set {
                this.discBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscBasisSpecified {
            get {
                return this.discBasisFieldSpecified;
            }
            set {
                this.discBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string PriceCode {
            get {
                return this.priceCodeField;
            }
            set {
                this.priceCodeField = value;
            }
        }
        
        /// <remarks/>
        public PriceFlag PriceFlag {
            get {
                return this.priceFlagField;
            }
            set {
                this.priceFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceFlagSpecified {
            get {
                return this.priceFlagFieldSpecified;
            }
            set {
                this.priceFlagFieldSpecified = value;
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Key {
        
        private string discountCodeField;
        
        /// <remarks/>
        public string DiscountCode {
            get {
                return this.discountCodeField;
            }
            set {
                this.discountCodeField = value;
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
    public partial class SetupArInvoiceDiscount {
        
        private Item[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public Item[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
