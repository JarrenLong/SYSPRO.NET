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
namespace SYSPRO.NET.BusinessObjects.WIPTJR {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostJobReceipts {
        
        private PostJobReceiptsParameters parametersField;
        
        /// <remarks/>
        public PostJobReceiptsParameters Parameters {
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
    public partial class PostJobReceiptsParameters {
        
        private PostJobReceiptsParametersValidateOnly validateOnlyField;
        
        private PostJobReceiptsParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private PostJobReceiptsParametersIgnoreWarnings ignoreWarningsField;
        
        private System.DateTime transactionDateField;
        
        private bool transactionDateFieldSpecified;
        
        private PostJobReceiptsParametersSetJobToCompleteIfCoProductsComplete setJobToCompleteIfCoProductsCompleteField;
        
        public PostJobReceiptsParameters() {
            this.validateOnlyField = PostJobReceiptsParametersValidateOnly.N;
            this.applyIfEntireDocumentValidField = PostJobReceiptsParametersApplyIfEntireDocumentValid.N;
            this.ignoreWarningsField = PostJobReceiptsParametersIgnoreWarnings.N;
            this.setJobToCompleteIfCoProductsCompleteField = PostJobReceiptsParametersSetJobToCompleteIfCoProductsComplete.Y;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobReceiptsParametersValidateOnly.N)]
        public PostJobReceiptsParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobReceiptsParametersApplyIfEntireDocumentValid.N)]
        public PostJobReceiptsParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobReceiptsParametersIgnoreWarnings.N)]
        public PostJobReceiptsParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
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
        [System.ComponentModel.DefaultValueAttribute(PostJobReceiptsParametersSetJobToCompleteIfCoProductsComplete.Y)]
        public PostJobReceiptsParametersSetJobToCompleteIfCoProductsComplete SetJobToCompleteIfCoProductsComplete {
            get {
                return this.setJobToCompleteIfCoProductsCompleteField;
            }
            set {
                this.setJobToCompleteIfCoProductsCompleteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsParametersIgnoreWarnings {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsParametersSetJobToCompleteIfCoProductsComplete {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
}
