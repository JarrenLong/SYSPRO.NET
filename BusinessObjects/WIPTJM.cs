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
namespace SYSPRO.NET.BusinessObjects.WIPTJM {
    using System.Xml.Serialization;
    
    
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Parameters {
        
        private ValidateOnly validateOnlyField;
        
        private bool validateOnlyFieldSpecified;
        
        private IgnoreWarnings ignoreWarningsField;
        
        private bool ignoreWarningsFieldSpecified;
        
        private Snapshot snapshotField;
        
        private bool snapshotFieldSpecified;
        
        private ActionType actionTypeField;
        
        private bool actionTypeFieldSpecified;
        
        public Parameters() {
            this.validateOnlyField = ValidateOnly.Y;
            this.ignoreWarningsField = IgnoreWarnings.Y;
            this.snapshotField = Snapshot.N;
            this.actionTypeField = ActionType.A;
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
        public Snapshot Snapshot {
            get {
                return this.snapshotField;
            }
            set {
                this.snapshotField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SnapshotSpecified {
            get {
                return this.snapshotFieldSpecified;
            }
            set {
                this.snapshotFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ActionType ActionType {
            get {
                return this.actionTypeField;
            }
            set {
                this.actionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionTypeSpecified {
            get {
                return this.actionTypeFieldSpecified;
            }
            set {
                this.actionTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ValidateOnly {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Snapshot {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ActionType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostMaterialAllocations {
        
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
