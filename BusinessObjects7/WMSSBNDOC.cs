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
namespace SYSPRO.NET.BusinessObjects.WMSSBNDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum AllowReplenish {
        
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
    public enum ActiveCycleCount {
        
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
    public enum BinOnHold {
        
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
    public partial class SetupBin {
        
        private Item[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public Item[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
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
    public partial class Item {
        
        private Key keyField;
        
        private string binTypeField;
        
        private string binSeqField;
        
        private string whAreaField;
        
        private string binBarcodeField;
        
        private string binRfidField;
        
        private string reservedStockCodeField;
        
        private BinOnHold binOnHoldField;
        
        private bool binOnHoldFieldSpecified;
        
        private string onHoldReasonField;
        
        private ActiveCycleCount activeCycleCountField;
        
        private bool activeCycleCountFieldSpecified;
        
        private AllowReplenish allowReplenishField;
        
        private bool allowReplenishFieldSpecified;
        
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
        public string BinType {
            get {
                return this.binTypeField;
            }
            set {
                this.binTypeField = value;
            }
        }
        
        /// <remarks/>
        public string BinSeq {
            get {
                return this.binSeqField;
            }
            set {
                this.binSeqField = value;
            }
        }
        
        /// <remarks/>
        public string WhArea {
            get {
                return this.whAreaField;
            }
            set {
                this.whAreaField = value;
            }
        }
        
        /// <remarks/>
        public string BinBarcode {
            get {
                return this.binBarcodeField;
            }
            set {
                this.binBarcodeField = value;
            }
        }
        
        /// <remarks/>
        public string BinRfid {
            get {
                return this.binRfidField;
            }
            set {
                this.binRfidField = value;
            }
        }
        
        /// <remarks/>
        public string ReservedStockCode {
            get {
                return this.reservedStockCodeField;
            }
            set {
                this.reservedStockCodeField = value;
            }
        }
        
        /// <remarks/>
        public BinOnHold BinOnHold {
            get {
                return this.binOnHoldField;
            }
            set {
                this.binOnHoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BinOnHoldSpecified {
            get {
                return this.binOnHoldFieldSpecified;
            }
            set {
                this.binOnHoldFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string OnHoldReason {
            get {
                return this.onHoldReasonField;
            }
            set {
                this.onHoldReasonField = value;
            }
        }
        
        /// <remarks/>
        public ActiveCycleCount ActiveCycleCount {
            get {
                return this.activeCycleCountField;
            }
            set {
                this.activeCycleCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActiveCycleCountSpecified {
            get {
                return this.activeCycleCountFieldSpecified;
            }
            set {
                this.activeCycleCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public AllowReplenish AllowReplenish {
            get {
                return this.allowReplenishField;
            }
            set {
                this.allowReplenishField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowReplenishSpecified {
            get {
                return this.allowReplenishFieldSpecified;
            }
            set {
                this.allowReplenishFieldSpecified = value;
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
    public partial class Key {
        
        private string warehouseField;
        
        private string binField;
        
        /// <remarks/>
        public string Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public string Bin {
            get {
                return this.binField;
            }
            set {
                this.binField = value;
            }
        }
    }
}
