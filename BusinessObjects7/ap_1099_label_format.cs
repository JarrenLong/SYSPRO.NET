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
namespace SYSPRO.NET.BusinessObjects.ap_1099_label_format {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DefaultFormat {
        
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
    public enum PrintDefaultDescription {
        
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
    public partial class Option {
        
        private double formatNoField;
        
        private bool formatNoFieldSpecified;
        
        private DefaultFormat defaultFormatField;
        
        private bool defaultFormatFieldSpecified;
        
        private string formatDescField;
        
        private PrintDefaultDescription printDefaultDescriptionField;
        
        private bool printDefaultDescriptionFieldSpecified;
        
        private decimal minPaymentField;
        
        private bool minPaymentFieldSpecified;
        
        private XslStyleSheet xslStyleSheetField;
        
        /// <remarks/>
        public double FormatNo {
            get {
                return this.formatNoField;
            }
            set {
                this.formatNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FormatNoSpecified {
            get {
                return this.formatNoFieldSpecified;
            }
            set {
                this.formatNoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DefaultFormat DefaultFormat {
            get {
                return this.defaultFormatField;
            }
            set {
                this.defaultFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultFormatSpecified {
            get {
                return this.defaultFormatFieldSpecified;
            }
            set {
                this.defaultFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string FormatDesc {
            get {
                return this.formatDescField;
            }
            set {
                this.formatDescField = value;
            }
        }
        
        /// <remarks/>
        public PrintDefaultDescription PrintDefaultDescription {
            get {
                return this.printDefaultDescriptionField;
            }
            set {
                this.printDefaultDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintDefaultDescriptionSpecified {
            get {
                return this.printDefaultDescriptionFieldSpecified;
            }
            set {
                this.printDefaultDescriptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public decimal MinPayment {
            get {
                return this.minPaymentField;
            }
            set {
                this.minPaymentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinPaymentSpecified {
            get {
                return this.minPaymentFieldSpecified;
            }
            set {
                this.minPaymentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public XslStyleSheet XslStyleSheet {
            get {
                return this.xslStyleSheetField;
            }
            set {
                this.xslStyleSheetField = value;
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
    public partial class XslStyleSheet {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private Option optionField;
        
        /// <remarks/>
        public Option Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
    }
}
