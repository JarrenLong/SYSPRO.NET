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
namespace SYSPRO.NET.BusinessObjects.WIPTJMDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostMaterialAllocations {
        
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
        
        private string jobField;
        
        private string nonStockedField;
        
        private string stockCodeField;
        
        private string warehouseField;
        
        private string newWarehouseField;
        
        private string lineField;
        
        private string explodeIfPhantomPartField;
        
        private string explodeIfKitPartField;
        
        private string componentWhToUseField;
        
        private string stockDescriptionField;
        
        private string qtyReqdTypeField;
        
        private string qtyReqdField;
        
        private string fixedQtyPerFlagField;
        
        private string fixedQtyPerField;
        
        private string unitCostField;
        
        private string operationOffsetField;
        
        private string opOffsetFlagField;
        
        private string uomField;
        
        private string sequenceNumField;
        
        private HierarchyJob hierarchyJobField;
        
        private string versionField;
        
        private string releaseField;
        
        private string eSignatureField;
        
        private string includeinKitIssueField;
        
        private string quantityToReserveField;
        
        private ItemReserveKitPhantComponents reserveKitPhantComponentsField;
        
        private string componentTypeField;
        
        private ItemEccConsumption eccConsumptionField;
        
        private string refDesignatorField;
        
        private string assemblyPlaceField;
        
        private string itemNumberField;
        
        private ItemOverEccSpecIssue overEccSpecIssueField;
        
        public Item() {
            this.nonStockedField = "N";
            this.explodeIfPhantomPartField = "N";
            this.explodeIfKitPartField = "N";
            this.componentWhToUseField = "N";
            this.qtyReqdTypeField = "U";
            this.fixedQtyPerFlagField = "N";
            this.opOffsetFlagField = "O";
            this.includeinKitIssueField = "Y";
            this.reserveKitPhantComponentsField = ItemReserveKitPhantComponents.Y;
            this.eccConsumptionField = ItemEccConsumption.S;
            this.overEccSpecIssueField = ItemOverEccSpecIssue.N;
        }
        
        /// <remarks/>
        public string Job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        public string NonStocked {
            get {
                return this.nonStockedField;
            }
            set {
                this.nonStockedField = value;
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
        public string Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public string NewWarehouse {
            get {
                return this.newWarehouseField;
            }
            set {
                this.newWarehouseField = value;
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
        public string ExplodeIfPhantomPart {
            get {
                return this.explodeIfPhantomPartField;
            }
            set {
                this.explodeIfPhantomPartField = value;
            }
        }
        
        /// <remarks/>
        public string ExplodeIfKitPart {
            get {
                return this.explodeIfKitPartField;
            }
            set {
                this.explodeIfKitPartField = value;
            }
        }
        
        /// <remarks/>
        public string ComponentWhToUse {
            get {
                return this.componentWhToUseField;
            }
            set {
                this.componentWhToUseField = value;
            }
        }
        
        /// <remarks/>
        public string StockDescription {
            get {
                return this.stockDescriptionField;
            }
            set {
                this.stockDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string QtyReqdType {
            get {
                return this.qtyReqdTypeField;
            }
            set {
                this.qtyReqdTypeField = value;
            }
        }
        
        /// <remarks/>
        public string QtyReqd {
            get {
                return this.qtyReqdField;
            }
            set {
                this.qtyReqdField = value;
            }
        }
        
        /// <remarks/>
        public string FixedQtyPerFlag {
            get {
                return this.fixedQtyPerFlagField;
            }
            set {
                this.fixedQtyPerFlagField = value;
            }
        }
        
        /// <remarks/>
        public string FixedQtyPer {
            get {
                return this.fixedQtyPerField;
            }
            set {
                this.fixedQtyPerField = value;
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
        public string OperationOffset {
            get {
                return this.operationOffsetField;
            }
            set {
                this.operationOffsetField = value;
            }
        }
        
        /// <remarks/>
        public string OpOffsetFlag {
            get {
                return this.opOffsetFlagField;
            }
            set {
                this.opOffsetFlagField = value;
            }
        }
        
        /// <remarks/>
        public string Uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }
        
        /// <remarks/>
        public string SequenceNum {
            get {
                return this.sequenceNumField;
            }
            set {
                this.sequenceNumField = value;
            }
        }
        
        /// <remarks/>
        public HierarchyJob HierarchyJob {
            get {
                return this.hierarchyJobField;
            }
            set {
                this.hierarchyJobField = value;
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
        public string eSignature {
            get {
                return this.eSignatureField;
            }
            set {
                this.eSignatureField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeinKitIssue {
            get {
                return this.includeinKitIssueField;
            }
            set {
                this.includeinKitIssueField = value;
            }
        }
        
        /// <remarks/>
        public string QuantityToReserve {
            get {
                return this.quantityToReserveField;
            }
            set {
                this.quantityToReserveField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(ItemReserveKitPhantComponents.Y)]
        public ItemReserveKitPhantComponents ReserveKitPhantComponents {
            get {
                return this.reserveKitPhantComponentsField;
            }
            set {
                this.reserveKitPhantComponentsField = value;
            }
        }
        
        /// <remarks/>
        public string ComponentType {
            get {
                return this.componentTypeField;
            }
            set {
                this.componentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(ItemEccConsumption.S)]
        public ItemEccConsumption EccConsumption {
            get {
                return this.eccConsumptionField;
            }
            set {
                this.eccConsumptionField = value;
            }
        }
        
        /// <remarks/>
        public string RefDesignator {
            get {
                return this.refDesignatorField;
            }
            set {
                this.refDesignatorField = value;
            }
        }
        
        /// <remarks/>
        public string AssemblyPlace {
            get {
                return this.assemblyPlaceField;
            }
            set {
                this.assemblyPlaceField = value;
            }
        }
        
        /// <remarks/>
        public string ItemNumber {
            get {
                return this.itemNumberField;
            }
            set {
                this.itemNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(ItemOverEccSpecIssue.N)]
        public ItemOverEccSpecIssue OverEccSpecIssue {
            get {
                return this.overEccSpecIssueField;
            }
            set {
                this.overEccSpecIssueField = value;
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
    public partial class HierarchyJob {
        
        private string headField;
        
        private string section1Field;
        
        private string section2Field;
        
        private string section3Field;
        
        private string section4Field;
        
        /// <remarks/>
        public string Head {
            get {
                return this.headField;
            }
            set {
                this.headField = value;
            }
        }
        
        /// <remarks/>
        public string Section1 {
            get {
                return this.section1Field;
            }
            set {
                this.section1Field = value;
            }
        }
        
        /// <remarks/>
        public string Section2 {
            get {
                return this.section2Field;
            }
            set {
                this.section2Field = value;
            }
        }
        
        /// <remarks/>
        public string Section3 {
            get {
                return this.section3Field;
            }
            set {
                this.section3Field = value;
            }
        }
        
        /// <remarks/>
        public string Section4 {
            get {
                return this.section4Field;
            }
            set {
                this.section4Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ItemReserveKitPhantComponents {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ItemEccConsumption {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ItemOverEccSpecIssue {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
}
