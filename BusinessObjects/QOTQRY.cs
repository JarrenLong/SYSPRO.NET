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
namespace SYSPRO.NET.BusinessObjects.QOTQRY {
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
        
        private string quotationField;
        
        /// <remarks/>
        public string Quotation {
            get {
                return this.quotationField;
            }
            set {
                this.quotationField = value;
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
        
        private QueryOptionIncludeStockedLines includeStockedLinesField;
        
        private QueryOptionIncludeNonStockedLines includeNonStockedLinesField;
        
        private QueryOptionIncludeFreightLines includeFreightLinesField;
        
        private QueryOptionIncludeMiscLines includeMiscLinesField;
        
        private QueryOptionIncludeCommentLines includeCommentLinesField;
        
        private QueryOptionIncludeOffers includeOffersField;
        
        private QueryOptionIncludeCustomForms includeCustomFormsField;
        
        public QueryOption() {
            this.includeStockedLinesField = QueryOptionIncludeStockedLines.Y;
            this.includeNonStockedLinesField = QueryOptionIncludeNonStockedLines.Y;
            this.includeFreightLinesField = QueryOptionIncludeFreightLines.Y;
            this.includeMiscLinesField = QueryOptionIncludeMiscLines.Y;
            this.includeCommentLinesField = QueryOptionIncludeCommentLines.Y;
            this.includeOffersField = QueryOptionIncludeOffers.A;
            this.includeCustomFormsField = QueryOptionIncludeCustomForms.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeStockedLines.Y)]
        public QueryOptionIncludeStockedLines IncludeStockedLines {
            get {
                return this.includeStockedLinesField;
            }
            set {
                this.includeStockedLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeNonStockedLines.Y)]
        public QueryOptionIncludeNonStockedLines IncludeNonStockedLines {
            get {
                return this.includeNonStockedLinesField;
            }
            set {
                this.includeNonStockedLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeFreightLines.Y)]
        public QueryOptionIncludeFreightLines IncludeFreightLines {
            get {
                return this.includeFreightLinesField;
            }
            set {
                this.includeFreightLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeMiscLines.Y)]
        public QueryOptionIncludeMiscLines IncludeMiscLines {
            get {
                return this.includeMiscLinesField;
            }
            set {
                this.includeMiscLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCommentLines.Y)]
        public QueryOptionIncludeCommentLines IncludeCommentLines {
            get {
                return this.includeCommentLinesField;
            }
            set {
                this.includeCommentLinesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeOffers.A)]
        public QueryOptionIncludeOffers IncludeOffers {
            get {
                return this.includeOffersField;
            }
            set {
                this.includeOffersField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeCustomForms.N)]
        public QueryOptionIncludeCustomForms IncludeCustomForms {
            get {
                return this.includeCustomFormsField;
            }
            set {
                this.includeCustomFormsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeStockedLines {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeNonStockedLines {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeFreightLines {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeMiscLines {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeCommentLines {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeOffers {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeCustomForms {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
}
