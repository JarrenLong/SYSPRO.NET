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
namespace SYSPRO.NET.BusinessObjects.INVTSC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum CaptureTicketNumbers {
        
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
    public enum CreateBins {
        
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
    public enum CreateLots {
        
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
    public enum CreateSerials {
        
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
    public enum IgnoreOtherWhsItems {
        
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
    public partial class Key {
        
        private string warehouseCodeField;
        
        /// <remarks/>
        public string WarehouseCode {
            get {
                return this.warehouseCodeField;
            }
            set {
                this.warehouseCodeField = value;
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
    public partial class Option {
        
        private CreateBins createBinsField;
        
        private CreateSerials createSerialsField;
        
        private CreateLots createLotsField;
        
        private ValidateReturnsAll validateReturnsAllField;
        
        private ValidateOnly validateOnlyField;
        
        private IgnoreOtherWhsItems ignoreOtherWhsItemsField;
        
        private CaptureTicketNumbers captureTicketNumbersField;
        
        private TicketNumbersExist ticketNumbersExistField;
        
        private DefaultCaptureMethod defaultCaptureMethodField;
        
        private bool defaultCaptureMethodFieldSpecified;
        
        private XslStylesheet xslStylesheetField;
        
        public Option() {
            this.createBinsField = CreateBins.N;
            this.createSerialsField = CreateSerials.N;
            this.createLotsField = CreateLots.N;
            this.validateReturnsAllField = ValidateReturnsAll.N;
            this.validateOnlyField = ValidateOnly.N;
            this.ignoreOtherWhsItemsField = IgnoreOtherWhsItems.Y;
            this.captureTicketNumbersField = CaptureTicketNumbers.N;
            this.ticketNumbersExistField = TicketNumbersExist.N;
            this.defaultCaptureMethodField = DefaultCaptureMethod.I;
        }
        
        /// <remarks/>
        public CreateBins CreateBins {
            get {
                return this.createBinsField;
            }
            set {
                this.createBinsField = value;
            }
        }
        
        /// <remarks/>
        public CreateSerials CreateSerials {
            get {
                return this.createSerialsField;
            }
            set {
                this.createSerialsField = value;
            }
        }
        
        /// <remarks/>
        public CreateLots CreateLots {
            get {
                return this.createLotsField;
            }
            set {
                this.createLotsField = value;
            }
        }
        
        /// <remarks/>
        public ValidateReturnsAll ValidateReturnsAll {
            get {
                return this.validateReturnsAllField;
            }
            set {
                this.validateReturnsAllField = value;
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
        public IgnoreOtherWhsItems IgnoreOtherWhsItems {
            get {
                return this.ignoreOtherWhsItemsField;
            }
            set {
                this.ignoreOtherWhsItemsField = value;
            }
        }
        
        /// <remarks/>
        public CaptureTicketNumbers CaptureTicketNumbers {
            get {
                return this.captureTicketNumbersField;
            }
            set {
                this.captureTicketNumbersField = value;
            }
        }
        
        /// <remarks/>
        public TicketNumbersExist TicketNumbersExist {
            get {
                return this.ticketNumbersExistField;
            }
            set {
                this.ticketNumbersExistField = value;
            }
        }
        
        /// <remarks/>
        public DefaultCaptureMethod DefaultCaptureMethod {
            get {
                return this.defaultCaptureMethodField;
            }
            set {
                this.defaultCaptureMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultCaptureMethodSpecified {
            get {
                return this.defaultCaptureMethodFieldSpecified;
            }
            set {
                this.defaultCaptureMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public XslStylesheet XslStylesheet {
            get {
                return this.xslStylesheetField;
            }
            set {
                this.xslStylesheetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ValidateReturnsAll {
        
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
    public enum ValidateOnly {
        
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
    public enum TicketNumbersExist {
        
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
    public enum DefaultCaptureMethod {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        R,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class XslStylesheet {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class StockTake {
        
        private Key keyField;
        
        private Option optionField;
        
        /// <remarks/>
        public Key Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
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
