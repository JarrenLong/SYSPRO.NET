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
namespace SYSPRO.NET.BusinessObjects.SORTDN {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostDispatchNotes {
        
        private PostDispatchNotesParameters parametersField;
        
        /// <remarks/>
        public PostDispatchNotesParameters Parameters {
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
    public partial class PostDispatchNotesParameters {
        
        private PostDispatchNotesParametersValidateOnly validateOnlyField;
        
        private PostDispatchNotesParametersIgnoreWarnings ignoreWarningsField;
        
        private PostDispatchNotesParametersBasisForDispatch basisForDispatchField;
        
        private PostDispatchNotesParametersNonMerchandiseSource nonMerchandiseSourceField;
        
        private PostDispatchNotesParametersIgnoreAutoDepletion ignoreAutoDepletionField;
        
        private PostDispatchNotesParametersRetainZeroNonMerchCost retainZeroNonMerchCostField;
        
        private bool retainZeroNonMerchCostFieldSpecified;
        
        public PostDispatchNotesParameters() {
            this.validateOnlyField = PostDispatchNotesParametersValidateOnly.N;
            this.ignoreWarningsField = PostDispatchNotesParametersIgnoreWarnings.N;
            this.basisForDispatchField = PostDispatchNotesParametersBasisForDispatch.B;
            this.nonMerchandiseSourceField = PostDispatchNotesParametersNonMerchandiseSource.I;
            this.ignoreAutoDepletionField = PostDispatchNotesParametersIgnoreAutoDepletion.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersValidateOnly.N)]
        public PostDispatchNotesParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersIgnoreWarnings.N)]
        public PostDispatchNotesParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersBasisForDispatch.B)]
        public PostDispatchNotesParametersBasisForDispatch BasisForDispatch {
            get {
                return this.basisForDispatchField;
            }
            set {
                this.basisForDispatchField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersNonMerchandiseSource.I)]
        public PostDispatchNotesParametersNonMerchandiseSource NonMerchandiseSource {
            get {
                return this.nonMerchandiseSourceField;
            }
            set {
                this.nonMerchandiseSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDispatchNotesParametersIgnoreAutoDepletion.N)]
        public PostDispatchNotesParametersIgnoreAutoDepletion IgnoreAutoDepletion {
            get {
                return this.ignoreAutoDepletionField;
            }
            set {
                this.ignoreAutoDepletionField = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesParametersRetainZeroNonMerchCost RetainZeroNonMerchCost {
            get {
                return this.retainZeroNonMerchCostField;
            }
            set {
                this.retainZeroNonMerchCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RetainZeroNonMerchCostSpecified {
            get {
                return this.retainZeroNonMerchCostFieldSpecified;
            }
            set {
                this.retainZeroNonMerchCostFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesParametersIgnoreWarnings {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        W,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesParametersBasisForDispatch {
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesParametersNonMerchandiseSource {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesParametersIgnoreAutoDepletion {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesParametersRetainZeroNonMerchCost {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
}
