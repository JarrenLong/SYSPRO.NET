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
namespace SYSPRO.NET.BusinessObjects.BOMSM3OUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SetupAbcElementStructure {
        
        private item itemField;
        
        private StatusOfItems statusOfItemsField;
        
        /// <remarks/>
        public item item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public StatusOfItems StatusOfItems {
            get {
                return this.statusOfItemsField;
            }
            set {
                this.statusOfItemsField = value;
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
    public partial class item {
        
        private key keyField;
        
        /// <remarks/>
        public key key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
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
    public partial class key {
        
        private byte[] stockCodeField;
        
        private string incidentField;
        
        private string elementField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary")]
        public byte[] StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Incident {
            get {
                return this.incidentField;
            }
            set {
                this.incidentField = value;
            }
        }
        
        /// <remarks/>
        public string Element {
            get {
                return this.elementField;
            }
            set {
                this.elementField = value;
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
    public partial class StatusOfItems {
        
        private bool recordsReadField;
        
        private bool recordsInvalidField;
        
        /// <remarks/>
        public bool RecordsRead {
            get {
                return this.recordsReadField;
            }
            set {
                this.recordsReadField = value;
            }
        }
        
        /// <remarks/>
        public bool RecordsInvalid {
            get {
                return this.recordsInvalidField;
            }
            set {
                this.recordsInvalidField = value;
            }
        }
    }
}
