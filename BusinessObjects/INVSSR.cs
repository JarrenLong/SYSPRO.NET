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
namespace SYSPRO.NET.BusinessObjects.INVSSR {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SetupInvSerialHead {
        
        private SetupInvSerialHeadParameters parametersField;
        
        /// <remarks/>
        public SetupInvSerialHeadParameters Parameters {
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
    public partial class SetupInvSerialHeadParameters {
        
        private SetupInvSerialHeadParametersIgnoreWarnings ignoreWarningsField;
        
        private SetupInvSerialHeadParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private SetupInvSerialHeadParametersValidateOnly validateOnlyField;
        
        private string notationField;
        
        private SetupInvSerialHeadParametersUnitQuantities unitQuantitiesField;
        
        public SetupInvSerialHeadParameters() {
            this.ignoreWarningsField = SetupInvSerialHeadParametersIgnoreWarnings.Y;
            this.applyIfEntireDocumentValidField = SetupInvSerialHeadParametersApplyIfEntireDocumentValid.N;
            this.validateOnlyField = SetupInvSerialHeadParametersValidateOnly.N;
            this.unitQuantitiesField = SetupInvSerialHeadParametersUnitQuantities.Reject;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupInvSerialHeadParametersIgnoreWarnings.Y)]
        public SetupInvSerialHeadParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupInvSerialHeadParametersApplyIfEntireDocumentValid.N)]
        public SetupInvSerialHeadParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupInvSerialHeadParametersValidateOnly.N)]
        public SetupInvSerialHeadParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        public string Notation {
            get {
                return this.notationField;
            }
            set {
                this.notationField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(SetupInvSerialHeadParametersUnitQuantities.Reject)]
        public SetupInvSerialHeadParametersUnitQuantities UnitQuantities {
            get {
                return this.unitQuantitiesField;
            }
            set {
                this.unitQuantitiesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupInvSerialHeadParametersIgnoreWarnings {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupInvSerialHeadParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupInvSerialHeadParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupInvSerialHeadParametersUnitQuantities {
        
        /// <remarks/>
        Reject,
        
        /// <remarks/>
        Round,
    }
}
