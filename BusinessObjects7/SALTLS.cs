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
namespace SYSPRO.NET.BusinessObjects.SALTLS {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostLostSales {
        
        private PostLostSalesParameters parametersField;
        
        /// <remarks/>
        public PostLostSalesParameters Parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostLostSalesParameters {
        
        private PostLostSalesParametersIgnoreWarnings ignoreWarningsField;
        
        private PostLostSalesParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private PostLostSalesParametersValidateOnly validateOnlyField;
        
        private System.DateTime transactionDateField;
        
        private bool transactionDateFieldSpecified;
        
        private PostLostSalesParametersDeleteEntries deleteEntriesField;
        
        private PostLostSalesParametersReturnItemFormat returnItemFormatField;
        
        private bool returnItemFormatFieldSpecified;
        
        public PostLostSalesParameters() {
            this.ignoreWarningsField = PostLostSalesParametersIgnoreWarnings.N;
            this.applyIfEntireDocumentValidField = PostLostSalesParametersApplyIfEntireDocumentValid.N;
            this.validateOnlyField = PostLostSalesParametersValidateOnly.N;
            this.deleteEntriesField = PostLostSalesParametersDeleteEntries.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostLostSalesParametersIgnoreWarnings.N)]
        public PostLostSalesParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostLostSalesParametersApplyIfEntireDocumentValid.N)]
        public PostLostSalesParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostLostSalesParametersValidateOnly.N)]
        public PostLostSalesParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime TransactionDate {
            get {
                return this.transactionDateField;
            }
            set {
                this.transactionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionDateSpecified {
            get {
                return this.transactionDateFieldSpecified;
            }
            set {
                this.transactionDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostLostSalesParametersDeleteEntries.N)]
        public PostLostSalesParametersDeleteEntries DeleteEntries {
            get {
                return this.deleteEntriesField;
            }
            set {
                this.deleteEntriesField = value;
            }
        }
        
        /// <remarks/>
        public PostLostSalesParametersReturnItemFormat ReturnItemFormat {
            get {
                return this.returnItemFormatField;
            }
            set {
                this.returnItemFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnItemFormatSpecified {
            get {
                return this.returnItemFormatFieldSpecified;
            }
            set {
                this.returnItemFormatFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostLostSalesParametersIgnoreWarnings {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostLostSalesParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostLostSalesParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostLostSalesParametersDeleteEntries {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostLostSalesParametersReturnItemFormat {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
}
