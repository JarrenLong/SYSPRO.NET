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
namespace SYSPRO.NET.BusinessObjects.APSSSP {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ApplyIfEntireDocumentValid {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IgnoreWarnings {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
        
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ValidateOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Parameters {
        
        private IgnoreWarnings ignoreWarningsField;
        
        private bool ignoreWarningsFieldSpecified;
        
        private ApplyIfEntireDocumentValid applyIfEntireDocumentValidField;
        
        private bool applyIfEntireDocumentValidFieldSpecified;
        
        private ValidateOnly validateOnlyField;
        
        private bool validateOnlyFieldSpecified;
        
        public Parameters() {
            this.ignoreWarningsField = IgnoreWarnings.Y;
            this.applyIfEntireDocumentValidField = ApplyIfEntireDocumentValid.N;
            this.validateOnlyField = ValidateOnly.N;
        }
        
        /// <remarks/>
        public IgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IgnoreWarningsSpecified {
            get {
                return this.ignoreWarningsFieldSpecified;
            }
            set {
                this.ignoreWarningsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ApplyIfEntireDocumentValid ApplyIfEntireDocumentValid {
            get {
                return this.applyIfEntireDocumentValidField;
            }
            set {
                this.applyIfEntireDocumentValidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplyIfEntireDocumentValidSpecified {
            get {
                return this.applyIfEntireDocumentValidFieldSpecified;
            }
            set {
                this.applyIfEntireDocumentValidFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ValidateOnly ValidateOnly {
            get {
                return this.validateOnlyField;
            }
            set {
                this.validateOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidateOnlySpecified {
            get {
                return this.validateOnlyFieldSpecified;
            }
            set {
                this.validateOnlyFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SetupApSupplier {
        
        private Parameters parametersField;
        
        /// <remarks/>
        public Parameters Parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
    }
}
