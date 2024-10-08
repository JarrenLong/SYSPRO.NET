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
namespace SYSPRO.NET.BusinessObjects.CFGTOCOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Selected {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Yes,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Type {
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        Mandatory,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Range ")]
        Range,
        
        /// <remarks/>
        Optional,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class postconfiguration {
        
        private postconfigurationItem itemField;
        
        private sbyte languageField;
        
        private string cssStyleField;
        
        private bool decFormatField;
        
        private sbyte dateFormatField;
        
        private sbyte roleField;
        
        private string versionField;
        
        /// <remarks/>
        public postconfigurationItem Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class postconfigurationItem {
        
        private postconfigurationItemOption[] optionField;
        
        private string lineField;
        
        private string phantomLineField;
        
        private postconfigurationItemComponents componentsField;
        
        private postconfigurationItemOperations operationsField;
        
        private postconfigurationItemCurrentConfigurationObject currentConfigurationObjectField;
        
        private postconfigurationItemParameters parametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Option")]
        public postconfigurationItemOption[] Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
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
        public postconfigurationItemComponents Components {
            get {
                return this.componentsField;
            }
            set {
                this.componentsField = value;
            }
        }
        
        /// <remarks/>
        public postconfigurationItemOperations Operations {
            get {
                return this.operationsField;
            }
            set {
                this.operationsField = value;
            }
        }
        
        /// <remarks/>
        public postconfigurationItemCurrentConfigurationObject CurrentConfigurationObject {
            get {
                return this.currentConfigurationObjectField;
            }
            set {
                this.currentConfigurationObjectField = value;
            }
        }
        
        /// <remarks/>
        public postconfigurationItemParameters Parameters {
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
    public partial class postconfigurationItemOption {
        
        private string lineField;
        
        private string descriptionField;
        
        private Type typeField;
        
        private bool typeFieldSpecified;
        
        private string minNumComponentsField;
        
        private string maxNumComponentsField;
        
        private string qtyPerDescField;
        
        private string minTotCompQtyField;
        
        private string maxTotCompQtyField;
        
        private postconfigurationItemOptionComponent[] componentField;
        
        private string minNumOperationsField;
        
        private string maxNumOperationsField;
        
        private string minTimeField;
        
        private string maxTimeField;
        
        private postconfigurationItemOptionOperation[] operationField;
        
        private postconfigurationItemOptionAnySelected anySelectedField;
        
        private bool anySelectedFieldSpecified;
        
        private string componentsField;
        
        private string operationsField;
        
        private string totalValueField;
        
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public Type Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string MinNumComponents {
            get {
                return this.minNumComponentsField;
            }
            set {
                this.minNumComponentsField = value;
            }
        }
        
        /// <remarks/>
        public string MaxNumComponents {
            get {
                return this.maxNumComponentsField;
            }
            set {
                this.maxNumComponentsField = value;
            }
        }
        
        /// <remarks/>
        public string QtyPerDesc {
            get {
                return this.qtyPerDescField;
            }
            set {
                this.qtyPerDescField = value;
            }
        }
        
        /// <remarks/>
        public string MinTotCompQty {
            get {
                return this.minTotCompQtyField;
            }
            set {
                this.minTotCompQtyField = value;
            }
        }
        
        /// <remarks/>
        public string MaxTotCompQty {
            get {
                return this.maxTotCompQtyField;
            }
            set {
                this.maxTotCompQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Component")]
        public postconfigurationItemOptionComponent[] Component {
            get {
                return this.componentField;
            }
            set {
                this.componentField = value;
            }
        }
        
        /// <remarks/>
        public string MinNumOperations {
            get {
                return this.minNumOperationsField;
            }
            set {
                this.minNumOperationsField = value;
            }
        }
        
        /// <remarks/>
        public string MaxNumOperations {
            get {
                return this.maxNumOperationsField;
            }
            set {
                this.maxNumOperationsField = value;
            }
        }
        
        /// <remarks/>
        public string MinTime {
            get {
                return this.minTimeField;
            }
            set {
                this.minTimeField = value;
            }
        }
        
        /// <remarks/>
        public string MaxTime {
            get {
                return this.maxTimeField;
            }
            set {
                this.maxTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Operation")]
        public postconfigurationItemOptionOperation[] Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        public postconfigurationItemOptionAnySelected AnySelected {
            get {
                return this.anySelectedField;
            }
            set {
                this.anySelectedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnySelectedSpecified {
            get {
                return this.anySelectedFieldSpecified;
            }
            set {
                this.anySelectedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Components {
            get {
                return this.componentsField;
            }
            set {
                this.componentsField = value;
            }
        }
        
        /// <remarks/>
        public string Operations {
            get {
                return this.operationsField;
            }
            set {
                this.operationsField = value;
            }
        }
        
        /// <remarks/>
        public string TotalValue {
            get {
                return this.totalValueField;
            }
            set {
                this.totalValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class postconfigurationItemOptionComponent {
        
        private string lineField;
        
        private Selected selectedField;
        
        private string phantomLineField;
        
        private postconfigurationItemOptionComponentMaterialType materialTypeField;
        
        private string stockCodeField;
        
        private string decimalsField;
        
        private string descriptionField;
        
        private string warehouseField;
        
        private string availableField;
        
        private string freeField;
        
        private string minimumPerField;
        
        private string maximumPerField;
        
        private string totalQuantityField;
        
        private string quantityUomField;
        
        private string quantityField;
        
        private string productClassField;
        
        private string backOrderQtyField;
        
        private string priceField;
        
        private string priceUomField;
        
        private string priceCodeField;
        
        private string commissionField;
        
        private postconfigurationItemOptionComponentDiscountFlag discountFlagField;
        
        private bool discountFlagFieldSpecified;
        
        private postconfigurationItemOptionComponentDiscountPctPlusLess discountPctPlusLessField;
        
        private bool discountPctPlusLessFieldSpecified;
        
        private string discountValueField;
        
        private string discountPct1Field;
        
        private string discountPct2Field;
        
        private string discountPct3Field;
        
        private string totalDiscountValueField;
        
        private string netPriceField;
        
        private string lineValueField;
        
        private string unitCostField;
        
        private string[] narrationsField;
        
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
        public Selected Selected {
            get {
                return this.selectedField;
            }
            set {
                this.selectedField = value;
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
        public postconfigurationItemOptionComponentMaterialType MaterialType {
            get {
                return this.materialTypeField;
            }
            set {
                this.materialTypeField = value;
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
        public string Decimals {
            get {
                return this.decimalsField;
            }
            set {
                this.decimalsField = value;
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
        public string Available {
            get {
                return this.availableField;
            }
            set {
                this.availableField = value;
            }
        }
        
        /// <remarks/>
        public string Free {
            get {
                return this.freeField;
            }
            set {
                this.freeField = value;
            }
        }
        
        /// <remarks/>
        public string MinimumPer {
            get {
                return this.minimumPerField;
            }
            set {
                this.minimumPerField = value;
            }
        }
        
        /// <remarks/>
        public string MaximumPer {
            get {
                return this.maximumPerField;
            }
            set {
                this.maximumPerField = value;
            }
        }
        
        /// <remarks/>
        public string TotalQuantity {
            get {
                return this.totalQuantityField;
            }
            set {
                this.totalQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string QuantityUom {
            get {
                return this.quantityUomField;
            }
            set {
                this.quantityUomField = value;
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
        public string ProductClass {
            get {
                return this.productClassField;
            }
            set {
                this.productClassField = value;
            }
        }
        
        /// <remarks/>
        public string BackOrderQty {
            get {
                return this.backOrderQtyField;
            }
            set {
                this.backOrderQtyField = value;
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
        public string PriceCode {
            get {
                return this.priceCodeField;
            }
            set {
                this.priceCodeField = value;
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
        public postconfigurationItemOptionComponentDiscountFlag DiscountFlag {
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
        public postconfigurationItemOptionComponentDiscountPctPlusLess DiscountPctPlusLess {
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
        public string DiscountValue {
            get {
                return this.discountValueField;
            }
            set {
                this.discountValueField = value;
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
        public string TotalDiscountValue {
            get {
                return this.totalDiscountValueField;
            }
            set {
                this.totalDiscountValueField = value;
            }
        }
        
        /// <remarks/>
        public string NetPrice {
            get {
                return this.netPriceField;
            }
            set {
                this.netPriceField = value;
            }
        }
        
        /// <remarks/>
        public string LineValue {
            get {
                return this.lineValueField;
            }
            set {
                this.lineValueField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable=false)]
        public string[] Narrations {
            get {
                return this.narrationsField;
            }
            set {
                this.narrationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum postconfigurationItemOptionComponentMaterialType {
        
        /// <remarks/>
        Mandatory,
        
        /// <remarks/>
        Range,
        
        /// <remarks/>
        Optional,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum postconfigurationItemOptionComponentDiscountFlag {
        
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
    public enum postconfigurationItemOptionComponentDiscountPctPlusLess {
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class postconfigurationItemOptionOperation {
        
        private string lineField;
        
        private Selected selectedField;
        
        private Type typeField;
        
        private string workCentreField;
        
        private string descriptionField;
        
        private string runTimeField;
        
        private string timeUomField;
        
        private string totalTimeField;
        
        private string supplierField;
        
        private string machineField;
        
        private string minimumPerField;
        
        private string maximumPerField;
        
        private string workCtrRateField;
        
        private string unitValueField;
        
        private string costField;
        
        private string productClassField;
        
        private string[] narrationsField;
        
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
        public Selected Selected {
            get {
                return this.selectedField;
            }
            set {
                this.selectedField = value;
            }
        }
        
        /// <remarks/>
        public Type Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string WorkCentre {
            get {
                return this.workCentreField;
            }
            set {
                this.workCentreField = value;
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
        public string RunTime {
            get {
                return this.runTimeField;
            }
            set {
                this.runTimeField = value;
            }
        }
        
        /// <remarks/>
        public string TimeUom {
            get {
                return this.timeUomField;
            }
            set {
                this.timeUomField = value;
            }
        }
        
        /// <remarks/>
        public string TotalTime {
            get {
                return this.totalTimeField;
            }
            set {
                this.totalTimeField = value;
            }
        }
        
        /// <remarks/>
        public string Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        public string Machine {
            get {
                return this.machineField;
            }
            set {
                this.machineField = value;
            }
        }
        
        /// <remarks/>
        public string MinimumPer {
            get {
                return this.minimumPerField;
            }
            set {
                this.minimumPerField = value;
            }
        }
        
        /// <remarks/>
        public string MaximumPer {
            get {
                return this.maximumPerField;
            }
            set {
                this.maximumPerField = value;
            }
        }
        
        /// <remarks/>
        public string WorkCtrRate {
            get {
                return this.workCtrRateField;
            }
            set {
                this.workCtrRateField = value;
            }
        }
        
        /// <remarks/>
        public string UnitValue {
            get {
                return this.unitValueField;
            }
            set {
                this.unitValueField = value;
            }
        }
        
        /// <remarks/>
        public string Cost {
            get {
                return this.costField;
            }
            set {
                this.costField = value;
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Text", IsNullable=false)]
        public string[] Narrations {
            get {
                return this.narrationsField;
            }
            set {
                this.narrationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum postconfigurationItemOptionAnySelected {
        
        /// <remarks/>
        Yes,
        
        /// <remarks/>
        No,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class postconfigurationItemComponents {
        
        private string lineCountField;
        
        private string validField;
        
        /// <remarks/>
        public string LineCount {
            get {
                return this.lineCountField;
            }
            set {
                this.lineCountField = value;
            }
        }
        
        /// <remarks/>
        public string Valid {
            get {
                return this.validField;
            }
            set {
                this.validField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class postconfigurationItemOperations {
        
        private string lineCountField;
        
        private string validField;
        
        /// <remarks/>
        public string LineCount {
            get {
                return this.lineCountField;
            }
            set {
                this.lineCountField = value;
            }
        }
        
        /// <remarks/>
        public string Valid {
            get {
                return this.validField;
            }
            set {
                this.validField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum postconfigurationItemCurrentConfigurationObject {
        
        /// <remarks/>
        CFGTOC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class postconfigurationItemParameters {
        
        private postconfigurationItemParametersFunction functionField;
        
        private string configurationInstanceField;
        
        /// <remarks/>
        public postconfigurationItemParametersFunction Function {
            get {
                return this.functionField;
            }
            set {
                this.functionField = value;
            }
        }
        
        /// <remarks/>
        public string ConfigurationInstance {
            get {
                return this.configurationInstanceField;
            }
            set {
                this.configurationInstanceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum postconfigurationItemParametersFunction {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        P,
    }
}
