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
namespace SYSPRO.NET.BusinessObjects.WIPTRI {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostWIPInspectRework {
        
        private PostWIPInspectReworkParameters parametersField;
        
        /// <remarks/>
        public PostWIPInspectReworkParameters Parameters {
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
    public partial class PostWIPInspectReworkParameters {
        
        private PostWIPInspectReworkParametersValidateOnly validateOnlyField;
        
        private PostWIPInspectReworkParametersIgnoreWarnings ignoreWarningsField;
        
        private PostWIPInspectReworkParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private System.DateTime transactionDateField;
        
        private bool transactionDateFieldSpecified;
        
        public PostWIPInspectReworkParameters() {
            this.validateOnlyField = PostWIPInspectReworkParametersValidateOnly.N;
            this.ignoreWarningsField = PostWIPInspectReworkParametersIgnoreWarnings.Y;
            this.applyIfEntireDocumentValidField = PostWIPInspectReworkParametersApplyIfEntireDocumentValid.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostWIPInspectReworkParametersValidateOnly.N)]
        public PostWIPInspectReworkParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostWIPInspectReworkParametersIgnoreWarnings.Y)]
        public PostWIPInspectReworkParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostWIPInspectReworkParametersApplyIfEntireDocumentValid.N)]
        public PostWIPInspectReworkParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostWIPInspectReworkParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostWIPInspectReworkParametersIgnoreWarnings {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostWIPInspectReworkParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
}
