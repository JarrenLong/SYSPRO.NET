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
namespace SYSPRO.NET.BusinessObjects.PRJTDD {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostDepositDetail {
        
        private PostDepositDetailParameters parametersField;
        
        /// <remarks/>
        public PostDepositDetailParameters Parameters {
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
    public partial class PostDepositDetailParameters {
        
        private PostDepositDetailParametersIgnoreWarnings ignoreWarningsField;
        
        private PostDepositDetailParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private PostDepositDetailParametersValidateOnly validateOnlyField;
        
        private PostDepositDetailParametersActionType actionTypeField;
        
        public PostDepositDetailParameters() {
            this.ignoreWarningsField = PostDepositDetailParametersIgnoreWarnings.Y;
            this.applyIfEntireDocumentValidField = PostDepositDetailParametersApplyIfEntireDocumentValid.N;
            this.validateOnlyField = PostDepositDetailParametersValidateOnly.N;
            this.actionTypeField = PostDepositDetailParametersActionType.A;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDepositDetailParametersIgnoreWarnings.Y)]
        public PostDepositDetailParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDepositDetailParametersApplyIfEntireDocumentValid.N)]
        public PostDepositDetailParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDepositDetailParametersValidateOnly.N)]
        public PostDepositDetailParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDepositDetailParametersActionType.A)]
        public PostDepositDetailParametersActionType ActionType {
            get {
                return this.actionTypeField;
            }
            set {
                this.actionTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDepositDetailParametersIgnoreWarnings {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDepositDetailParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDepositDetailParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDepositDetailParametersActionType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
    }
}
