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
namespace SYSPRO.NET.BusinessObjects.COMTDI {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum CreateSingleScript {
        
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
    public enum GenerateRebuildFKey {
        
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
    public enum GenerateDropFKey {
        
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
    public enum GenerateIndexScript {
        
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
    public partial class PostCOMTDI {
        
        private parameters parametersField;
        
        /// <remarks/>
        public parameters parameters {
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class parameters {
        
        private GenerateIndexScript generateIndexScriptField;
        
        private bool generateIndexScriptFieldSpecified;
        
        private GenerateDropFKey generateDropFKeyField;
        
        private bool generateDropFKeyFieldSpecified;
        
        private GenerateRebuildFKey generateRebuildFKeyField;
        
        private bool generateRebuildFKeyFieldSpecified;
        
        private ReturnSqlScript returnSqlScriptField;
        
        private bool returnSqlScriptFieldSpecified;
        
        private CreateSingleScript createSingleScriptField;
        
        private bool createSingleScriptFieldSpecified;
        
        /// <remarks/>
        public GenerateIndexScript GenerateIndexScript {
            get {
                return this.generateIndexScriptField;
            }
            set {
                this.generateIndexScriptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenerateIndexScriptSpecified {
            get {
                return this.generateIndexScriptFieldSpecified;
            }
            set {
                this.generateIndexScriptFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public GenerateDropFKey GenerateDropFKey {
            get {
                return this.generateDropFKeyField;
            }
            set {
                this.generateDropFKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenerateDropFKeySpecified {
            get {
                return this.generateDropFKeyFieldSpecified;
            }
            set {
                this.generateDropFKeyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public GenerateRebuildFKey GenerateRebuildFKey {
            get {
                return this.generateRebuildFKeyField;
            }
            set {
                this.generateRebuildFKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenerateRebuildFKeySpecified {
            get {
                return this.generateRebuildFKeyFieldSpecified;
            }
            set {
                this.generateRebuildFKeyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ReturnSqlScript ReturnSqlScript {
            get {
                return this.returnSqlScriptField;
            }
            set {
                this.returnSqlScriptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnSqlScriptSpecified {
            get {
                return this.returnSqlScriptFieldSpecified;
            }
            set {
                this.returnSqlScriptFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CreateSingleScript CreateSingleScript {
            get {
                return this.createSingleScriptField;
            }
            set {
                this.createSingleScriptField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateSingleScriptSpecified {
            get {
                return this.createSingleScriptFieldSpecified;
            }
            set {
                this.createSingleScriptFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReturnSqlScript {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
}
