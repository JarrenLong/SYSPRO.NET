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
namespace SYSPRO.NET.BusinessObjects.TPMSM0 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SetupAccrualType {
        
        private SetupAccrualTypeParameters parametersField;
        
        /// <remarks/>
        public SetupAccrualTypeParameters Parameters {
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
    public partial class SetupAccrualTypeParameters {
        
        private SetupAccrualTypeParametersIgnoreWarnings ignoreWarningsField;
        
        private SetupAccrualTypeParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private SetupAccrualTypeParametersValidateOnly validateOnlyField;
        
        public SetupAccrualTypeParameters() {
            this.ignoreWarningsField = SetupAccrualTypeParametersIgnoreWarnings.Y;
            this.applyIfEntireDocumentValidField = SetupAccrualTypeParametersApplyIfEntireDocumentValid.Y;
            this.validateOnlyField = SetupAccrualTypeParametersValidateOnly.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupAccrualTypeParametersIgnoreWarnings.Y)]
        public SetupAccrualTypeParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupAccrualTypeParametersApplyIfEntireDocumentValid.Y)]
        public SetupAccrualTypeParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupAccrualTypeParametersValidateOnly.N)]
        public SetupAccrualTypeParametersValidateOnly ValidateOnly {
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
    public enum SetupAccrualTypeParametersIgnoreWarnings {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupAccrualTypeParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupAccrualTypeParametersValidateOnly {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
}
