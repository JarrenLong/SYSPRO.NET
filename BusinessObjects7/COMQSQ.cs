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
namespace SYSPRO.NET.BusinessObjects.COMQSQ {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Option {
        
        private string lockTypeField;
        
        private string detailOrSummaryField;
        
        private string maxItemsToReturnField;
        
        private string includeTableCheckField;
        
        private string includeColumnCheckField;
        
        private string includeIndexCheckField;
        
        /// <remarks/>
        public string LockType {
            get {
                return this.lockTypeField;
            }
            set {
                this.lockTypeField = value;
            }
        }
        
        /// <remarks/>
        public string DetailOrSummary {
            get {
                return this.detailOrSummaryField;
            }
            set {
                this.detailOrSummaryField = value;
            }
        }
        
        /// <remarks/>
        public string MaxItemsToReturn {
            get {
                return this.maxItemsToReturnField;
            }
            set {
                this.maxItemsToReturnField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeTableCheck {
            get {
                return this.includeTableCheckField;
            }
            set {
                this.includeTableCheckField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeColumnCheck {
            get {
                return this.includeColumnCheckField;
            }
            set {
                this.includeColumnCheckField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeIndexCheck {
            get {
                return this.includeIndexCheckField;
            }
            set {
                this.includeIndexCheckField = value;
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
    public partial class QuerySqlHealth {
        
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
}
