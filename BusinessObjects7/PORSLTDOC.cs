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
namespace SYSPRO.NET.BusinessObjects.PORSLTDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private Key keyField;
        
        private string tariffDescField;
        
        private string tariffClassField;
        
        private decimal dutyRate1Field;
        
        private bool dutyRate1FieldSpecified;
        
        private decimal dutyRate2Field;
        
        private bool dutyRate2FieldSpecified;
        
        private decimal dutyRate3Field;
        
        private bool dutyRate3FieldSpecified;
        
        private object eSignatureField;
        
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
        public string TariffDesc {
            get {
                return this.tariffDescField;
            }
            set {
                this.tariffDescField = value;
            }
        }
        
        /// <remarks/>
        public string TariffClass {
            get {
                return this.tariffClassField;
            }
            set {
                this.tariffClassField = value;
            }
        }
        
        /// <remarks/>
        public decimal DutyRate1 {
            get {
                return this.dutyRate1Field;
            }
            set {
                this.dutyRate1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DutyRate1Specified {
            get {
                return this.dutyRate1FieldSpecified;
            }
            set {
                this.dutyRate1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal DutyRate2 {
            get {
                return this.dutyRate2Field;
            }
            set {
                this.dutyRate2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DutyRate2Specified {
            get {
                return this.dutyRate2FieldSpecified;
            }
            set {
                this.dutyRate2FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal DutyRate3 {
            get {
                return this.dutyRate3Field;
            }
            set {
                this.dutyRate3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DutyRate3Specified {
            get {
                return this.dutyRate3FieldSpecified;
            }
            set {
                this.dutyRate3FieldSpecified = value;
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Key {
        
        private string tariffCodeField;
        
        private string lctCountryStatusField;
        
        /// <remarks/>
        public string TariffCode {
            get {
                return this.tariffCodeField;
            }
            set {
                this.tariffCodeField = value;
            }
        }
        
        /// <remarks/>
        public string LctCountryStatus {
            get {
                return this.lctCountryStatusField;
            }
            set {
                this.lctCountryStatusField = value;
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
    public partial class SetupTariffCode {
        
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
