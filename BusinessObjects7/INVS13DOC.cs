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
namespace SYSPRO.NET.BusinessObjects.INVS13DOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private Key keyField;
        
        private string salesQty1Field;
        
        private string salesQty2Field;
        
        private string salesQty3Field;
        
        private string salesQty4Field;
        
        private string salesQty5Field;
        
        private string salesQty6Field;
        
        private string salesQty7Field;
        
        private string salesQty8Field;
        
        private string salesQty9Field;
        
        private string salesQty10Field;
        
        private string salesQty11Field;
        
        private string salesQty12Field;
        
        private string dateLastSaleField;
        
        private string dateLastPurchaseField;
        
        private string ytdUsageValueField;
        
        private string ytdSalesValueField;
        
        private string prevYtdSalesValField;
        
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
        public string SalesQty1 {
            get {
                return this.salesQty1Field;
            }
            set {
                this.salesQty1Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty2 {
            get {
                return this.salesQty2Field;
            }
            set {
                this.salesQty2Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty3 {
            get {
                return this.salesQty3Field;
            }
            set {
                this.salesQty3Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty4 {
            get {
                return this.salesQty4Field;
            }
            set {
                this.salesQty4Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty5 {
            get {
                return this.salesQty5Field;
            }
            set {
                this.salesQty5Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty6 {
            get {
                return this.salesQty6Field;
            }
            set {
                this.salesQty6Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty7 {
            get {
                return this.salesQty7Field;
            }
            set {
                this.salesQty7Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty8 {
            get {
                return this.salesQty8Field;
            }
            set {
                this.salesQty8Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty9 {
            get {
                return this.salesQty9Field;
            }
            set {
                this.salesQty9Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty10 {
            get {
                return this.salesQty10Field;
            }
            set {
                this.salesQty10Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty11 {
            get {
                return this.salesQty11Field;
            }
            set {
                this.salesQty11Field = value;
            }
        }
        
        /// <remarks/>
        public string SalesQty12 {
            get {
                return this.salesQty12Field;
            }
            set {
                this.salesQty12Field = value;
            }
        }
        
        /// <remarks/>
        public string DateLastSale {
            get {
                return this.dateLastSaleField;
            }
            set {
                this.dateLastSaleField = value;
            }
        }
        
        /// <remarks/>
        public string DateLastPurchase {
            get {
                return this.dateLastPurchaseField;
            }
            set {
                this.dateLastPurchaseField = value;
            }
        }
        
        /// <remarks/>
        public string YtdUsageValue {
            get {
                return this.ytdUsageValueField;
            }
            set {
                this.ytdUsageValueField = value;
            }
        }
        
        /// <remarks/>
        public string YtdSalesValue {
            get {
                return this.ytdSalesValueField;
            }
            set {
                this.ytdSalesValueField = value;
            }
        }
        
        /// <remarks/>
        public string PrevYtdSalesVal {
            get {
                return this.prevYtdSalesValField;
            }
            set {
                this.prevYtdSalesValField = value;
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
        
        private string stockCodeField;
        
        private string warehouseField;
        
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
        public string Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
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
    public partial class SetupSalesQuantityHistory {
        
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
}
