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
namespace SYSPRO.NET.BusinessObjects.delivery_route_load_list {
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
        
        private QueryOption optionField;
        
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
        public QueryOption Option {
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
    public partial class QueryKey {
        
        private string routeCodeField;
        
        private string deliveryDateField;
        
        private string deliverySeqField;
        
        /// <remarks/>
        public string RouteCode {
            get {
                return this.routeCodeField;
            }
            set {
                this.routeCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DeliveryDate {
            get {
                return this.deliveryDateField;
            }
            set {
                this.deliveryDateField = value;
            }
        }
        
        /// <remarks/>
        public string DeliverySeq {
            get {
                return this.deliverySeqField;
            }
            set {
                this.deliverySeqField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOption {
        
        private QueryOptionIncludeSalesorderLines includeSalesorderLinesField;
        
        public QueryOption() {
            this.includeSalesorderLinesField = QueryOptionIncludeSalesorderLines.Y;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSalesorderLines.Y)]
        public QueryOptionIncludeSalesorderLines IncludeSalesorderLines {
            get {
                return this.includeSalesorderLinesField;
            }
            set {
                this.includeSalesorderLinesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeSalesorderLines {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
}
