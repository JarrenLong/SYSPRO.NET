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
namespace SYSPRO.NET.BusinessObjects.SORTRS {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostSoReservedToShip {
        
        private PostSoReservedToShipParameters parametersField;
        
        /// <remarks/>
        public PostSoReservedToShipParameters Parameters {
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
    public partial class PostSoReservedToShipParameters {
        
        private PostSoReservedToShipParametersIgnoreWarnings ignoreWarningsField;
        
        private PostSoReservedToShipParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private PostSoReservedToShipParametersValidateOnly validateOnlyField;
        
        private PostSoReservedToShipParametersValidatePickStatus validatePickStatusField;
        
        private PostSoReservedToShipParametersReleaseForDispatch releaseForDispatchField;
        
        public PostSoReservedToShipParameters() {
            this.ignoreWarningsField = PostSoReservedToShipParametersIgnoreWarnings.N;
            this.applyIfEntireDocumentValidField = PostSoReservedToShipParametersApplyIfEntireDocumentValid.N;
            this.validateOnlyField = PostSoReservedToShipParametersValidateOnly.N;
            this.validatePickStatusField = PostSoReservedToShipParametersValidatePickStatus.N;
            this.releaseForDispatchField = PostSoReservedToShipParametersReleaseForDispatch.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostSoReservedToShipParametersIgnoreWarnings.N)]
        public PostSoReservedToShipParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostSoReservedToShipParametersApplyIfEntireDocumentValid.N)]
        public PostSoReservedToShipParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostSoReservedToShipParametersValidateOnly.N)]
        public PostSoReservedToShipParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostSoReservedToShipParametersValidatePickStatus.N)]
        public PostSoReservedToShipParametersValidatePickStatus ValidatePickStatus {
            get {
                return this.validatePickStatusField;
            }
            set {
                this.validatePickStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostSoReservedToShipParametersReleaseForDispatch.N)]
        public PostSoReservedToShipParametersReleaseForDispatch ReleaseForDispatch {
            get {
                return this.releaseForDispatchField;
            }
            set {
                this.releaseForDispatchField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostSoReservedToShipParametersIgnoreWarnings {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        W,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostSoReservedToShipParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostSoReservedToShipParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostSoReservedToShipParametersValidatePickStatus {
        
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
    public enum PostSoReservedToShipParametersReleaseForDispatch {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
}
