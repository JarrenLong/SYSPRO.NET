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
namespace SYSPRO.NET.BusinessObjects.ASSTAQ {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostAssetAcquisition {
        
        private PostAssetAcquisitionParameters parametersField;
        
        /// <remarks/>
        public PostAssetAcquisitionParameters Parameters {
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
    public partial class PostAssetAcquisitionParameters {
        
        private PostAssetAcquisitionParametersIgnoreWarnings ignoreWarningsField;
        
        private PostAssetAcquisitionParametersApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private PostAssetAcquisitionParametersValidateOnly validateOnlyField;
        
        private PostAssetAcquisitionParametersActionType actionTypeField;
        
        private PostAssetAcquisitionParametersInitialCapture initialCaptureField;
        
        private string transferCompanyField;
        
        public PostAssetAcquisitionParameters() {
            this.ignoreWarningsField = PostAssetAcquisitionParametersIgnoreWarnings.N;
            this.applyIfEntireDocumentValidField = PostAssetAcquisitionParametersApplyIfEntireDocumentValid.Y;
            this.validateOnlyField = PostAssetAcquisitionParametersValidateOnly.N;
            this.actionTypeField = PostAssetAcquisitionParametersActionType.A;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostAssetAcquisitionParametersIgnoreWarnings.N)]
        public PostAssetAcquisitionParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostAssetAcquisitionParametersApplyIfEntireDocumentValid.Y)]
        public PostAssetAcquisitionParametersApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostAssetAcquisitionParametersValidateOnly.N)]
        public PostAssetAcquisitionParametersValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        public PostAssetAcquisitionParametersActionType ActionType {
            get {
                return this.actionTypeField;
            }
            set {
                this.actionTypeField = value;
            }
        }
        
        /// <remarks/>
        public PostAssetAcquisitionParametersInitialCapture InitialCapture {
            get {
                return this.initialCaptureField;
            }
            set {
                this.initialCaptureField = value;
            }
        }
        
        /// <remarks/>
        public string TransferCompany {
            get {
                return this.transferCompanyField;
            }
            set {
                this.transferCompanyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostAssetAcquisitionParametersIgnoreWarnings {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostAssetAcquisitionParametersApplyIfEntireDocumentValid {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostAssetAcquisitionParametersValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostAssetAcquisitionParametersActionType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        Q,
        
        /// <remarks/>
        T,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostAssetAcquisitionParametersInitialCapture {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
}
