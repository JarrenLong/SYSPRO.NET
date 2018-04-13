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
namespace SYSPRO.NET.BusinessObjects.CFGTOCDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostConfiguration {
        
        private PostConfigurationItem itemField;
        
        /// <remarks/>
        public PostConfigurationItem Item {
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
    public partial class PostConfigurationItem {
        
        private PostConfigurationItemOption optionField;
        
        /// <remarks/>
        public PostConfigurationItemOption Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostConfigurationItemOption {
        
        private string[] lineField;
        
        private PostConfigurationItemOptionType[] typeField;
        
        private PostConfigurationItemOptionOperation[] operationField;
        
        private PostConfigurationItemOptionComponent[] componentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Line")]
        public string[] Line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Type")]
        public PostConfigurationItemOptionType[] Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Operation")]
        public PostConfigurationItemOptionOperation[] Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Component")]
        public PostConfigurationItemOptionComponent[] Component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostConfigurationItemOptionType {
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostConfigurationItemOptionOperation {
        
        private Select selectField;
        
        private string lineField;
        
        private string runTimeField;
        
        private string productClassField;
        
        private string userDefinedCommentsField;
        
        /// <remarks/>
        public Select Select {
            get {
                return this.selectField;
            }
            set {
                this.selectField = value;
            }
        }
        
        /// <remarks/>
        public string Line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
        
        /// <remarks/>
        public string RunTime {
            get {
                return this.runTimeField;
            }
            set {
                this.runTimeField = value;
            }
        }
        
        /// <remarks/>
        public string ProductClass {
            get {
                return this.productClassField;
            }
            set {
                this.productClassField = value;
            }
        }
        
        /// <remarks/>
        public string UserDefinedComments {
            get {
                return this.userDefinedCommentsField;
            }
            set {
                this.userDefinedCommentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Select {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        D,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostConfigurationItemOptionComponent {
        
        private Select selectField;
        
        private string lineField;
        
        private string phantomLineField;
        
        private string stockCodeField;
        
        private string descriptionField;
        
        private string warehouseField;
        
        private string productClassField;
        
        private string quantityField;
        
        private string unitCostField;
        
        private PostConfigurationItemOptionComponentPriceFlg priceFlgField;
        
        private bool priceFlgFieldSpecified;
        
        private string priceCodeField;
        
        private string priceField;
        
        private string priceUomField;
        
        private PostConfigurationItemOptionComponentPriceUomMulDiv priceUomMulDivField;
        
        private bool priceUomMulDivFieldSpecified;
        
        private string priceUomFactorField;
        
        private string commissionField;
        
        private PostConfigurationItemOptionComponentDiscountFlag discountFlagField;
        
        private bool discountFlagFieldSpecified;
        
        private PostConfigurationItemOptionComponentDiscountPctPlusLess discountPctPlusLessField;
        
        private bool discountPctPlusLessFieldSpecified;
        
        private string discountPct1Field;
        
        private string discountPct2Field;
        
        private string discountPct3Field;
        
        private string discountValueField;
        
        private string userDefinedCommentsField;
        
        /// <remarks/>
        public Select Select {
            get {
                return this.selectField;
            }
            set {
                this.selectField = value;
            }
        }
        
        /// <remarks/>
        public string Line {
            get {
                return this.lineField;
            }
            set {
                this.lineField = value;
            }
        }
        
        /// <remarks/>
        public string PhantomLine {
            get {
                return this.phantomLineField;
            }
            set {
                this.phantomLineField = value;
            }
        }
        
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
        public string ProductClass {
            get {
                return this.productClassField;
            }
            set {
                this.productClassField = value;
            }
        }
        
        /// <remarks/>
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public string UnitCost {
            get {
                return this.unitCostField;
            }
            set {
                this.unitCostField = value;
            }
        }
        
        /// <remarks/>
        public PostConfigurationItemOptionComponentPriceFlg PriceFlg {
            get {
                return this.priceFlgField;
            }
            set {
                this.priceFlgField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceFlgSpecified {
            get {
                return this.priceFlgFieldSpecified;
            }
            set {
                this.priceFlgFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string PriceCode {
            get {
                return this.priceCodeField;
            }
            set {
                this.priceCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
        
        /// <remarks/>
        public string PriceUom {
            get {
                return this.priceUomField;
            }
            set {
                this.priceUomField = value;
            }
        }
        
        /// <remarks/>
        public PostConfigurationItemOptionComponentPriceUomMulDiv PriceUomMulDiv {
            get {
                return this.priceUomMulDivField;
            }
            set {
                this.priceUomMulDivField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceUomMulDivSpecified {
            get {
                return this.priceUomMulDivFieldSpecified;
            }
            set {
                this.priceUomMulDivFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string PriceUomFactor {
            get {
                return this.priceUomFactorField;
            }
            set {
                this.priceUomFactorField = value;
            }
        }
        
        /// <remarks/>
        public string Commission {
            get {
                return this.commissionField;
            }
            set {
                this.commissionField = value;
            }
        }
        
        /// <remarks/>
        public PostConfigurationItemOptionComponentDiscountFlag DiscountFlag {
            get {
                return this.discountFlagField;
            }
            set {
                this.discountFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountFlagSpecified {
            get {
                return this.discountFlagFieldSpecified;
            }
            set {
                this.discountFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PostConfigurationItemOptionComponentDiscountPctPlusLess DiscountPctPlusLess {
            get {
                return this.discountPctPlusLessField;
            }
            set {
                this.discountPctPlusLessField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountPctPlusLessSpecified {
            get {
                return this.discountPctPlusLessFieldSpecified;
            }
            set {
                this.discountPctPlusLessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPct1 {
            get {
                return this.discountPct1Field;
            }
            set {
                this.discountPct1Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPct2 {
            get {
                return this.discountPct2Field;
            }
            set {
                this.discountPct2Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPct3 {
            get {
                return this.discountPct3Field;
            }
            set {
                this.discountPct3Field = value;
            }
        }
        
        /// <remarks/>
        public string DiscountValue {
            get {
                return this.discountValueField;
            }
            set {
                this.discountValueField = value;
            }
        }
        
        /// <remarks/>
        public string UserDefinedComments {
            get {
                return this.userDefinedCommentsField;
            }
            set {
                this.userDefinedCommentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostConfigurationItemOptionComponentPriceFlg {
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostConfigurationItemOptionComponentPriceUomMulDiv {
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostConfigurationItemOptionComponentDiscountFlag {
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        V,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostConfigurationItemOptionComponentDiscountPctPlusLess {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
}
