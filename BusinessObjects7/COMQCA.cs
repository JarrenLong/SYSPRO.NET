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
namespace SYSPRO.NET.BusinessObjects.COMQCA {
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
        
        /// <remarks/>
        public QueryKey Key {
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
    public partial class QueryKey {
        
        private QueryKeySearchType searchTypeField;
        
        private System.DateTime searchSingleDayField;
        
        private string searchFromYearField;
        
        private string searchToYearField;
        
        private string searchFromMonthField;
        
        private string searchToMonthField;
        
        public QueryKey() {
            this.searchTypeField = QueryKeySearchType.D;
        }
        
        /// <remarks/>
        public QueryKeySearchType SearchType {
            get {
                return this.searchTypeField;
            }
            set {
                this.searchTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime SearchSingleDay {
            get {
                return this.searchSingleDayField;
            }
            set {
                this.searchSingleDayField = value;
            }
        }
        
        /// <remarks/>
        public string SearchFromYear {
            get {
                return this.searchFromYearField;
            }
            set {
                this.searchFromYearField = value;
            }
        }
        
        /// <remarks/>
        public string SearchToYear {
            get {
                return this.searchToYearField;
            }
            set {
                this.searchToYearField = value;
            }
        }
        
        /// <remarks/>
        public string SearchFromMonth {
            get {
                return this.searchFromMonthField;
            }
            set {
                this.searchFromMonthField = value;
            }
        }
        
        /// <remarks/>
        public string SearchToMonth {
            get {
                return this.searchToMonthField;
            }
            set {
                this.searchToMonthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryKeySearchType {
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        D,
    }
}
