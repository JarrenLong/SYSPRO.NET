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
namespace SYSPRO.NET.BusinessObjects.ASSSDP {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SetupAssetDepreciation {
        
        private SetupAssetDepreciationParameters parametersField;
        
        /// <remarks/>
        public SetupAssetDepreciationParameters Parameters {
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
    public partial class SetupAssetDepreciationParameters {
        
        private SetupAssetDepreciationParametersIgnoreWarnings ignoreWarningsField;
        
        private SetupAssetDepreciationParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private SetupAssetDepreciationParametersValidateOnly validateOnlyField;
        
        public SetupAssetDepreciationParameters() {
            this.ignoreWarningsField = SetupAssetDepreciationParametersIgnoreWarnings.N;
            this.applyIfEntireDocumentValidField = SetupAssetDepreciationParametersApplyIfEntireDocumentValid.Y;
            this.validateOnlyField = SetupAssetDepreciationParametersValidateOnly.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupAssetDepreciationParametersIgnoreWarnings.N)]
        public SetupAssetDepreciationParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupAssetDepreciationParametersApplyIfEntireDocumentValid.Y)]
        public SetupAssetDepreciationParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupAssetDepreciationParametersValidateOnly.N)]
        public SetupAssetDepreciationParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupAssetDepreciationParametersIgnoreWarnings {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupAssetDepreciationParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupAssetDepreciationParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
}
