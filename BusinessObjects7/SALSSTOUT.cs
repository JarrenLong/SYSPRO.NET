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
namespace SYSPRO.NET.BusinessObjects.SALSSTOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class StatusOfItems {
        
        private string recordsReadField;
        
        private string recordsInvalidField;
        
        /// <remarks/>
        public string RecordsRead {
            get {
                return this.recordsReadField;
            }
            set {
                this.recordsReadField = value;
            }
        }
        
        /// <remarks/>
        public string RecordsInvalid {
            get {
                return this.recordsInvalidField;
            }
            set {
                this.recordsInvalidField = value;
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
        
        private string sequencetypeField;
        
        private string sequence1Field;
        
        private string sequence2Field;
        
        private string sequence3Field;
        
        private string trnyearField;
        
        private string trnmonthField;
        
        /// <remarks/>
        public string sequencetype {
            get {
                return this.sequencetypeField;
            }
            set {
                this.sequencetypeField = value;
            }
        }
        
        /// <remarks/>
        public string sequence1 {
            get {
                return this.sequence1Field;
            }
            set {
                this.sequence1Field = value;
            }
        }
        
        /// <remarks/>
        public string sequence2 {
            get {
                return this.sequence2Field;
            }
            set {
                this.sequence2Field = value;
            }
        }
        
        /// <remarks/>
        public string sequence3 {
            get {
                return this.sequence3Field;
            }
            set {
                this.sequence3Field = value;
            }
        }
        
        /// <remarks/>
        public string trnyear {
            get {
                return this.trnyearField;
            }
            set {
                this.trnyearField = value;
            }
        }
        
        /// <remarks/>
        public string trnmonth {
            get {
                return this.trnmonthField;
            }
            set {
                this.trnmonthField = value;
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
    public partial class setupsalestarget {
        
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
}
