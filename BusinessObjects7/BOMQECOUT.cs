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
namespace SYSPRO.NET.BusinessObjects.BOMQECOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BomEccAvailable {
        
        private BomEccAvailableItemsItem[][] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", typeof(BomEccAvailableItemsItem), IsNullable=false)]
        public BomEccAvailableItemsItem[][] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BomEccAvailableItemsItem {
        
        private string stockCodeField;
        
        private string descriptionField;
        
        private string warehouseField;
        
        private string versionField;
        
        private string releaseField;
        
        private string dateReleasedField;
        
        private string binField;
        
        private string stockUomField;
        
        private string availQuantityField;
        
        private BomEccAvailableItemsItemLotAndSerial lotAndSerialField;
        
        /// <remarks/>
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
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
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        
        /// <remarks/>
        public string DateReleased {
            get {
                return this.dateReleasedField;
            }
            set {
                this.dateReleasedField = value;
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
        
        /// <remarks/>
        public string StockUom {
            get {
                return this.stockUomField;
            }
            set {
                this.stockUomField = value;
            }
        }
        
        /// <remarks/>
        public string AvailQuantity {
            get {
                return this.availQuantityField;
            }
            set {
                this.availQuantityField = value;
            }
        }
        
        /// <remarks/>
        public BomEccAvailableItemsItemLotAndSerial LotAndSerial {
            get {
                return this.lotAndSerialField;
            }
            set {
                this.lotAndSerialField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BomEccAvailableItemsItemLotAndSerial {
        
        private BomEccAvailableItemsItemLotAndSerialLots[] lotsField;
        
        private BomEccAvailableItemsItemLotAndSerialSerials[] serialsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lots")]
        public BomEccAvailableItemsItemLotAndSerialLots[] Lots {
            get {
                return this.lotsField;
            }
            set {
                this.lotsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Serials")]
        public BomEccAvailableItemsItemLotAndSerialSerials[] Serials {
            get {
                return this.serialsField;
            }
            set {
                this.serialsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BomEccAvailableItemsItemLotAndSerialLots {
        
        private string lotField;
        
        private string binField;
        
        private string stockUomField;
        
        private string lotQuantityField;
        
        /// <remarks/>
        public string Lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
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
        
        /// <remarks/>
        public string StockUom {
            get {
                return this.stockUomField;
            }
            set {
                this.stockUomField = value;
            }
        }
        
        /// <remarks/>
        public string LotQuantity {
            get {
                return this.lotQuantityField;
            }
            set {
                this.lotQuantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BomEccAvailableItemsItemLotAndSerialSerials {
        
        private string lotField;
        
        private BomEccAvailableItemsItemLotAndSerialSerialsSerialNumber serialNumberField;
        
        private bool serialNumberFieldSpecified;
        
        private string stockUomField;
        
        private string serialQuantityField;
        
        /// <remarks/>
        public string Lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
            }
        }
        
        /// <remarks/>
        public BomEccAvailableItemsItemLotAndSerialSerialsSerialNumber SerialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerialNumberSpecified {
            get {
                return this.serialNumberFieldSpecified;
            }
            set {
                this.serialNumberFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string StockUom {
            get {
                return this.stockUomField;
            }
            set {
                this.stockUomField = value;
            }
        }
        
        /// <remarks/>
        public string SerialQuantity {
            get {
                return this.serialQuantityField;
            }
            set {
                this.serialQuantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum BomEccAvailableItemsItemLotAndSerialSerialsSerialNumber {
        
        /// <remarks/>
        BH4567,
        
        /// <remarks/>
        BH5678,
        
        /// <remarks/>
        BH6789,
        
        /// <remarks/>
        BH7890,
    }
}
