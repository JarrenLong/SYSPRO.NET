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
namespace SYSPRO.NET.BusinessObjects.LOTTSODOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class LotTraceabilityOptions {
        
        private General generalField;
        
        /// <remarks/>
        public General General {
            get {
                return this.generalField;
            }
            set {
                this.generalField = value;
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
    public partial class General {
        
        private AutoLotNum autoLotNumField;
        
        private double nextLotNumField;
        
        private double nextLotArchiveNumField;
        
        private ParentTraceIfCompTrace parentTraceIfCompTraceField;
        
        private LotNumEqualToJobNum lotNumEqualToJobNumField;
        
        private SameLotMultStockCodes sameLotMultStockCodesField;
        
        /// <remarks/>
        public AutoLotNum AutoLotNum {
            get {
                return this.autoLotNumField;
            }
            set {
                this.autoLotNumField = value;
            }
        }
        
        /// <remarks/>
        public double NextLotNum {
            get {
                return this.nextLotNumField;
            }
            set {
                this.nextLotNumField = value;
            }
        }
        
        /// <remarks/>
        public double NextLotArchiveNum {
            get {
                return this.nextLotArchiveNumField;
            }
            set {
                this.nextLotArchiveNumField = value;
            }
        }
        
        /// <remarks/>
        public ParentTraceIfCompTrace ParentTraceIfCompTrace {
            get {
                return this.parentTraceIfCompTraceField;
            }
            set {
                this.parentTraceIfCompTraceField = value;
            }
        }
        
        /// <remarks/>
        public LotNumEqualToJobNum LotNumEqualToJobNum {
            get {
                return this.lotNumEqualToJobNumField;
            }
            set {
                this.lotNumEqualToJobNumField = value;
            }
        }
        
        /// <remarks/>
        public SameLotMultStockCodes SameLotMultStockCodes {
            get {
                return this.sameLotMultStockCodesField;
            }
            set {
                this.sameLotMultStockCodesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum AutoLotNum {
        
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
    public enum ParentTraceIfCompTrace {
        
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
    public enum LotNumEqualToJobNum {
        
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
    public enum SameLotMultStockCodes {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
}
