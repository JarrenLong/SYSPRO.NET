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
namespace SYSPRO.NET.BusinessObjects.WIPTCE {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostExpectedCosts {
        
        private PostExpectedCostsParameters parametersField;
        
        /// <remarks/>
        public PostExpectedCostsParameters Parameters {
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
    public partial class PostExpectedCostsParameters {
        
        private PostExpectedCostsParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private PostExpectedCostsParametersValidateOnly validateOnlyField;
        
        private PostExpectedCostsParametersIgnoreWarnings ignoreWarningsField;
        
        public PostExpectedCostsParameters() {
            this.applyIfEntireDocumentValidField = PostExpectedCostsParametersApplyIfEntireDocumentValid.Y;
            this.validateOnlyField = PostExpectedCostsParametersValidateOnly.N;
            this.ignoreWarningsField = PostExpectedCostsParametersIgnoreWarnings.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostExpectedCostsParametersApplyIfEntireDocumentValid.Y)]
        public PostExpectedCostsParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostExpectedCostsParametersValidateOnly.N)]
        public PostExpectedCostsParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostExpectedCostsParametersIgnoreWarnings.N)]
        public PostExpectedCostsParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostExpectedCostsParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostExpectedCostsParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostExpectedCostsParametersIgnoreWarnings {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
}
