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
namespace SYSPRO.NET.BusinessObjects.inventory_stock_take_variance {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BinLocation {
        
        private BinLocationFilterType filterTypeField;
        
        private string filterValueField;
        
        public BinLocation() {
            this.filterTypeField = BinLocationFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(BinLocationFilterType.A)]
        public BinLocationFilterType FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum BinLocationFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        R,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ExcludeZeroLots {
        
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
    public enum ExcludeZeroSerials {
        
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
    public partial class Filter {
        
        private StockCode stockCodeField;
        
        private BinLocation binLocationField;
        
        private UnitOfMeasure unitOfMeasureField;
        
        private ProductClass productClassField;
        
        /// <remarks/>
        public StockCode StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        public BinLocation BinLocation {
            get {
                return this.binLocationField;
            }
            set {
                this.binLocationField = value;
            }
        }
        
        /// <remarks/>
        public UnitOfMeasure UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        public ProductClass ProductClass {
            get {
                return this.productClassField;
            }
            set {
                this.productClassField = value;
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
    public partial class StockCode {
        
        private StockCodeFilterType filterTypeField;
        
        private string filterValueField;
        
        public StockCode() {
            this.filterTypeField = StockCodeFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StockCodeFilterType.A)]
        public StockCodeFilterType FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum StockCodeFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
        
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
    public partial class UnitOfMeasure {
        
        private UnitOfMeasureFilterType filterTypeField;
        
        private string filterValueField;
        
        public UnitOfMeasure() {
            this.filterTypeField = UnitOfMeasureFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(UnitOfMeasureFilterType.A)]
        public UnitOfMeasureFilterType FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum UnitOfMeasureFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ProductClass {
        
        private ProductClassFilterType filterTypeField;
        
        private string filterValueField;
        
        public ProductClass() {
            this.filterTypeField = ProductClassFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ProductClassFilterType.A)]
        public ProductClassFilterType FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ProductClassFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        R,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeBatchSerials {
        
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
    public enum IncludeLots {
        
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
    public enum IncludeManualSerials {
        
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
    public enum IncludeQtyNotCaptured {
        
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
    public enum IncludeZeroSaveQty {
        
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
    public partial class Key {
        
        private string warehouseField;
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum OnlyShowExceptionLines {
        
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
        
        private Sequence sequenceField;
        
        private ValueStockAt valueStockAtField;
        
        private ValueFIFO valueFIFOField;
        
        private OnlyShowExceptionLines onlyShowExceptionLinesField;
        
        private IncludeLots includeLotsField;
        
        private ExcludeZeroLots excludeZeroLotsField;
        
        private IncludeZeroSaveQty includeZeroSaveQtyField;
        
        private IncludeQtyNotCaptured includeQtyNotCapturedField;
        
        private IncludeBatchSerials includeBatchSerialsField;
        
        private IncludeManualSerials includeManualSerialsField;
        
        private ExcludeZeroSerials excludeZeroSerialsField;
        
        private XslStylesheet xslStylesheetField;
        
        /// <remarks/>
        public Sequence Sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
        
        /// <remarks/>
        public ValueStockAt ValueStockAt {
            get {
                return this.valueStockAtField;
            }
            set {
                this.valueStockAtField = value;
            }
        }
        
        /// <remarks/>
        public ValueFIFO ValueFIFO {
            get {
                return this.valueFIFOField;
            }
            set {
                this.valueFIFOField = value;
            }
        }
        
        /// <remarks/>
        public OnlyShowExceptionLines OnlyShowExceptionLines {
            get {
                return this.onlyShowExceptionLinesField;
            }
            set {
                this.onlyShowExceptionLinesField = value;
            }
        }
        
        /// <remarks/>
        public IncludeLots IncludeLots {
            get {
                return this.includeLotsField;
            }
            set {
                this.includeLotsField = value;
            }
        }
        
        /// <remarks/>
        public ExcludeZeroLots ExcludeZeroLots {
            get {
                return this.excludeZeroLotsField;
            }
            set {
                this.excludeZeroLotsField = value;
            }
        }
        
        /// <remarks/>
        public IncludeZeroSaveQty IncludeZeroSaveQty {
            get {
                return this.includeZeroSaveQtyField;
            }
            set {
                this.includeZeroSaveQtyField = value;
            }
        }
        
        /// <remarks/>
        public IncludeQtyNotCaptured IncludeQtyNotCaptured {
            get {
                return this.includeQtyNotCapturedField;
            }
            set {
                this.includeQtyNotCapturedField = value;
            }
        }
        
        /// <remarks/>
        public IncludeBatchSerials IncludeBatchSerials {
            get {
                return this.includeBatchSerialsField;
            }
            set {
                this.includeBatchSerialsField = value;
            }
        }
        
        /// <remarks/>
        public IncludeManualSerials IncludeManualSerials {
            get {
                return this.includeManualSerialsField;
            }
            set {
                this.includeManualSerialsField = value;
            }
        }
        
        /// <remarks/>
        public ExcludeZeroSerials ExcludeZeroSerials {
            get {
                return this.excludeZeroSerialsField;
            }
            set {
                this.excludeZeroSerialsField = value;
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
    public enum Sequence {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        B,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ValueStockAt {
        
        /// <remarks/>
        W,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ValueFIFO {
        
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
    public partial class XslStylesheet {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private Key keyField;
        
        private Option optionField;
        
        private Filter filterField;
        
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
        
        /// <remarks/>
        public Filter Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
    }
}
