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
namespace SYSPRO.NET.BusinessObjects.COMQFMOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QueryKey keyField;
        
        private QueryField[] fieldField;
        
        private QueryMandatoryFields mandatoryFieldsField;
        
        private byte languageField;
        
        private string cssStyleField;
        
        private byte decFormatField;
        
        private byte dateFormatField;
        
        private byte roleField;
        
        private string versionField;
        
        /// <remarks/>
        public QueryKey Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Field")]
        public QueryField[] Field {
            get {
                return this.fieldField;
            }
            set {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        public QueryMandatoryFields MandatoryFields {
            get {
                return this.mandatoryFieldsField;
            }
            set {
                this.mandatoryFieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryKey {
        
        private string formTypeField;
        
        private string keyFieldField;
        
        /// <remarks/>
        public string FormType {
            get {
                return this.formTypeField;
            }
            set {
                this.formTypeField = value;
            }
        }
        
        /// <remarks/>
        public string KeyField {
            get {
                return this.keyFieldField;
            }
            set {
                this.keyFieldField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryField {
        
        private byte sequenceField;
        
        private string nameField;
        
        private string promptField;
        
        private string typeField;
        
        private byte lengthField;
        
        private byte decimalsField;
        
        private string defaultField;
        
        private string allowNullField;
        
        private string valueField;
        
        private string valueNullField;
        
        /// <remarks/>
        public byte Sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Prompt {
            get {
                return this.promptField;
            }
            set {
                this.promptField = value;
            }
        }
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public byte Length {
            get {
                return this.lengthField;
            }
            set {
                this.lengthField = value;
            }
        }
        
        /// <remarks/>
        public byte Decimals {
            get {
                return this.decimalsField;
            }
            set {
                this.decimalsField = value;
            }
        }
        
        /// <remarks/>
        public string Default {
            get {
                return this.defaultField;
            }
            set {
                this.defaultField = value;
            }
        }
        
        /// <remarks/>
        public string AllowNull {
            get {
                return this.allowNullField;
            }
            set {
                this.allowNullField = value;
            }
        }
        
        /// <remarks/>
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        public string ValueNull {
            get {
                return this.valueNullField;
            }
            set {
                this.valueNullField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryMandatoryFields {
        
        private string anyMandatoryFieldsField;
        
        private string allFieldsValidField;
        
        /// <remarks/>
        public string AnyMandatoryFields {
            get {
                return this.anyMandatoryFieldsField;
            }
            set {
                this.anyMandatoryFieldsField = value;
            }
        }
        
        /// <remarks/>
        public string AllFieldsValid {
            get {
                return this.allFieldsValidField;
            }
            set {
                this.allFieldsValidField = value;
            }
        }
    }
}
