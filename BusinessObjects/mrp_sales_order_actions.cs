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
namespace SYSPRO.NET.BusinessObjects.mrp_sales_order_actions {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private Option optionField;
        
        /// <remarks/>
        public Option Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
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
    public partial class Option {
        
        private ChangesToInclude changesToIncludeField;
        
        private bool changesToIncludeFieldSpecified;
        
        private OnlyWhereSuggestedDateAfterOriginalDate onlyWhereSuggestedDateAfterOriginalDateField;
        
        private bool onlyWhereSuggestedDateAfterOriginalDateFieldSpecified;
        
        private XslStylesheet xslStylesheetField;
        
        /// <remarks/>
        public ChangesToInclude ChangesToInclude {
            get {
                return this.changesToIncludeField;
            }
            set {
                this.changesToIncludeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChangesToIncludeSpecified {
            get {
                return this.changesToIncludeFieldSpecified;
            }
            set {
                this.changesToIncludeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public OnlyWhereSuggestedDateAfterOriginalDate OnlyWhereSuggestedDateAfterOriginalDate {
            get {
                return this.onlyWhereSuggestedDateAfterOriginalDateField;
            }
            set {
                this.onlyWhereSuggestedDateAfterOriginalDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnlyWhereSuggestedDateAfterOriginalDateSpecified {
            get {
                return this.onlyWhereSuggestedDateAfterOriginalDateFieldSpecified;
            }
            set {
                this.onlyWhereSuggestedDateAfterOriginalDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public XslStylesheet XslStylesheet {
            get {
                return this.xslStylesheetField;
            }
            set {
                this.xslStylesheetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ChangesToInclude {
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        Q,
        
        /// <remarks/>
        B,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum OnlyWhereSuggestedDateAfterOriginalDate {
        
        /// <remarks/>
        Y,
        
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
    public partial class XslStylesheet {
    }
}
