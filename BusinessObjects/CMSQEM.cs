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
namespace SYSPRO.NET.BusinessObjects.CMSQEM {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Email {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("HELEN.KOPELOWITZ@BAYSIDE.COM")]
        HELENKOPELOWITZBAYSIDECOM,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("JAMES.PADDINGTON@BAYSIDE.COM")]
        JAMESPADDINGTONBAYSIDECOM,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("PETER@UNKNOWN.COM")]
        PETERUNKNOWNCOM,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Key {
        
        private Email[] emailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public Email[] Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
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
    public partial class Query {
        
        private Email[] keyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Email", IsNullable=false)]
        public Email[] Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
    }
}
