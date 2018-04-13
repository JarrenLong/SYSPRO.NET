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
namespace SYSPRO.NET.BusinessObjects.WIPTJRDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostJobReceipts {
        
        private PostJobReceiptsItem[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public PostJobReceiptsItem[] Items {
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
    public partial class PostJobReceiptsItem {
        
        private string[] journalField;
        
        private string[] jobField;
        
        private string[] coProductLineField;
        
        private string[] ledgerCodeField;
        
        private string[] passwordForLedgerCodeField;
        
        private PostJobReceiptsItemUnitOfMeasure[] unitOfMeasureField;
        
        private string[] quantityField;
        
        private PostJobReceiptsItemInspectionFlag[] inspectionFlagField;
        
        private PostJobReceiptsItemCostBasis[] costBasisField;
        
        private string[] receiptCostField;
        
        private PostJobReceiptsItemUseSingleTypeABCElements[] useSingleTypeABCElementsField;
        
        private string[] materialDistributionValueField;
        
        private string[] laborDistributionValueField;
        
        private PostJobReceiptsItemJobComplete[] jobCompleteField;
        
        private PostJobReceiptsItemCoProductComplete[] coProductCompleteField;
        
        private string[] referenceField;
        
        private string[] notationField;
        
        private PostJobReceiptsItemIncreaseSalesOrderQuantity[] increaseSalesOrderQuantityField;
        
        private PostJobReceiptsItemSalesOrderComplete[] salesOrderCompleteField;
        
        private string[] lotField;
        
        private string[] lotConcessionField;
        
        private System.DateTime[] lotExpiryDateField;
        
        private string[] binLocationField;
        
        private PostJobReceiptsItemBinOnHold[] binOnHoldField;
        
        private string[] binOnHoldReasonField;
        
        private PostJobReceiptsItemBinUpdateWhDefault[] binUpdateWhDefaultField;
        
        private string[] fifoBucketField;
        
        private PostJobReceiptsItemSerials[] serialsField;
        
        private PostJobReceiptsItemSerialRange[] serialRangeField;
        
        private PostJobReceiptsItemSerialAllocation[] serialAllocationField;
        
        private string[] wipInspectionReferenceField;
        
        private string[] wipInspectionNarrationField;
        
        private PostJobReceiptsItemHierarchyJob[] hierarchyJobField;
        
        private string[] addReferenceField;
        
        private string[] materialReferenceField;
        
        private string[] quantityFromStockField;
        
        private string[] eSignatureField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Journal")]
        public string[] Journal {
            get {
                return this.journalField;
            }
            set {
                this.journalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Job")]
        public string[] Job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoProductLine")]
        public string[] CoProductLine {
            get {
                return this.coProductLineField;
            }
            set {
                this.coProductLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LedgerCode")]
        public string[] LedgerCode {
            get {
                return this.ledgerCodeField;
            }
            set {
                this.ledgerCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PasswordForLedgerCode")]
        public string[] PasswordForLedgerCode {
            get {
                return this.passwordForLedgerCodeField;
            }
            set {
                this.passwordForLedgerCodeField = value;
            }
        }
        
        /// <remarks/>
        // CODEGEN Warning: 'default' attribute on array-like elements is not supported in this version of the .Net Framework.  Ignoring default='S' attribute on element name='UnitOfMeasure'.
        [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasure")]
        public PostJobReceiptsItemUnitOfMeasure[] UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public string[] Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        // CODEGEN Warning: DefaultValue attribute on members of type PostJobReceiptsItemInspectionFlag[] is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute on array-like elements is not supported in this version of the .Net Framework.  Ignoring default='N' attribute on element name='InspectionFlag'.
        [System.Xml.Serialization.XmlElementAttribute("InspectionFlag")]
        public PostJobReceiptsItemInspectionFlag[] InspectionFlag {
            get {
                return this.inspectionFlagField;
            }
            set {
                this.inspectionFlagField = value;
            }
        }
        
        /// <remarks/>
        // CODEGEN Warning: DefaultValue attribute on members of type PostJobReceiptsItemCostBasis[] is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute on array-like elements is not supported in this version of the .Net Framework.  Ignoring default='C' attribute on element name='CostBasis'.
        [System.Xml.Serialization.XmlElementAttribute("CostBasis")]
        public PostJobReceiptsItemCostBasis[] CostBasis {
            get {
                return this.costBasisField;
            }
            set {
                this.costBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptCost")]
        public string[] ReceiptCost {
            get {
                return this.receiptCostField;
            }
            set {
                this.receiptCostField = value;
            }
        }
        
        /// <remarks/>
        // CODEGEN Warning: DefaultValue attribute on members of type PostJobReceiptsItemUseSingleTypeABCElements[] is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute on array-like elements is not supported in this version of the .Net Framework.  Ignoring default='N' attribute on element name='UseSingleTypeABCElements'.
        [System.Xml.Serialization.XmlElementAttribute("UseSingleTypeABCElements")]
        public PostJobReceiptsItemUseSingleTypeABCElements[] UseSingleTypeABCElements {
            get {
                return this.useSingleTypeABCElementsField;
            }
            set {
                this.useSingleTypeABCElementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDistributionValue")]
        public string[] MaterialDistributionValue {
            get {
                return this.materialDistributionValueField;
            }
            set {
                this.materialDistributionValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LaborDistributionValue")]
        public string[] LaborDistributionValue {
            get {
                return this.laborDistributionValueField;
            }
            set {
                this.laborDistributionValueField = value;
            }
        }
        
        /// <remarks/>
        // CODEGEN Warning: DefaultValue attribute on members of type PostJobReceiptsItemJobComplete[] is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute on array-like elements is not supported in this version of the .Net Framework.  Ignoring default=' ' attribute on element name='JobComplete'.
        [System.Xml.Serialization.XmlElementAttribute("JobComplete")]
        public PostJobReceiptsItemJobComplete[] JobComplete {
            get {
                return this.jobCompleteField;
            }
            set {
                this.jobCompleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CoProductComplete")]
        public PostJobReceiptsItemCoProductComplete[] CoProductComplete {
            get {
                return this.coProductCompleteField;
            }
            set {
                this.coProductCompleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public string[] Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Notation")]
        public string[] Notation {
            get {
                return this.notationField;
            }
            set {
                this.notationField = value;
            }
        }
        
        /// <remarks/>
        // CODEGEN Warning: DefaultValue attribute on members of type PostJobReceiptsItemIncreaseSalesOrderQuantity[] is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute on array-like elements is not supported in this version of the .Net Framework.  Ignoring default='N' attribute on element name='IncreaseSalesOrderQuantity'.
        [System.Xml.Serialization.XmlElementAttribute("IncreaseSalesOrderQuantity")]
        public PostJobReceiptsItemIncreaseSalesOrderQuantity[] IncreaseSalesOrderQuantity {
            get {
                return this.increaseSalesOrderQuantityField;
            }
            set {
                this.increaseSalesOrderQuantityField = value;
            }
        }
        
        /// <remarks/>
        // CODEGEN Warning: DefaultValue attribute on members of type PostJobReceiptsItemSalesOrderComplete[] is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute on array-like elements is not supported in this version of the .Net Framework.  Ignoring default='N' attribute on element name='SalesOrderComplete'.
        [System.Xml.Serialization.XmlElementAttribute("SalesOrderComplete")]
        public PostJobReceiptsItemSalesOrderComplete[] SalesOrderComplete {
            get {
                return this.salesOrderCompleteField;
            }
            set {
                this.salesOrderCompleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lot")]
        public string[] Lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LotConcession")]
        public string[] LotConcession {
            get {
                return this.lotConcessionField;
            }
            set {
                this.lotConcessionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LotExpiryDate", DataType="date")]
        public System.DateTime[] LotExpiryDate {
            get {
                return this.lotExpiryDateField;
            }
            set {
                this.lotExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinLocation")]
        public string[] BinLocation {
            get {
                return this.binLocationField;
            }
            set {
                this.binLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinOnHold")]
        public PostJobReceiptsItemBinOnHold[] BinOnHold {
            get {
                return this.binOnHoldField;
            }
            set {
                this.binOnHoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BinOnHoldReason")]
        public string[] BinOnHoldReason {
            get {
                return this.binOnHoldReasonField;
            }
            set {
                this.binOnHoldReasonField = value;
            }
        }
        
        /// <remarks/>
        // CODEGEN Warning: DefaultValue attribute on members of type PostJobReceiptsItemBinUpdateWhDefault[] is not supported in this version of the .Net Framework.
        // CODEGEN Warning: 'default' attribute on array-like elements is not supported in this version of the .Net Framework.  Ignoring default='N' attribute on element name='BinUpdateWhDefault'.
        [System.Xml.Serialization.XmlElementAttribute("BinUpdateWhDefault")]
        public PostJobReceiptsItemBinUpdateWhDefault[] BinUpdateWhDefault {
            get {
                return this.binUpdateWhDefaultField;
            }
            set {
                this.binUpdateWhDefaultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FifoBucket")]
        public string[] FifoBucket {
            get {
                return this.fifoBucketField;
            }
            set {
                this.fifoBucketField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Serials")]
        public PostJobReceiptsItemSerials[] Serials {
            get {
                return this.serialsField;
            }
            set {
                this.serialsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SerialRange")]
        public PostJobReceiptsItemSerialRange[] SerialRange {
            get {
                return this.serialRangeField;
            }
            set {
                this.serialRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SerialAllocation")]
        public PostJobReceiptsItemSerialAllocation[] SerialAllocation {
            get {
                return this.serialAllocationField;
            }
            set {
                this.serialAllocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WipInspectionReference")]
        public string[] WipInspectionReference {
            get {
                return this.wipInspectionReferenceField;
            }
            set {
                this.wipInspectionReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WipInspectionNarration")]
        public string[] WipInspectionNarration {
            get {
                return this.wipInspectionNarrationField;
            }
            set {
                this.wipInspectionNarrationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HierarchyJob")]
        public PostJobReceiptsItemHierarchyJob[] HierarchyJob {
            get {
                return this.hierarchyJobField;
            }
            set {
                this.hierarchyJobField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddReference")]
        public string[] AddReference {
            get {
                return this.addReferenceField;
            }
            set {
                this.addReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialReference")]
        public string[] MaterialReference {
            get {
                return this.materialReferenceField;
            }
            set {
                this.materialReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QuantityFromStock")]
        public string[] QuantityFromStock {
            get {
                return this.quantityFromStockField;
            }
            set {
                this.quantityFromStockField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eSignature")]
        public string[] eSignature {
            get {
                return this.eSignatureField;
            }
            set {
                this.eSignatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemUnitOfMeasure {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        M,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemInspectionFlag {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemCostBasis {
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        W,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        M,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemUseSingleTypeABCElements {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemJobComplete {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute(" ")]
        Item,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemCoProductComplete {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemIncreaseSalesOrderQuantity {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemSalesOrderComplete {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemBinOnHold {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobReceiptsItemBinUpdateWhDefault {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        
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
    public partial class PostJobReceiptsItemSerials {
        
        private string serialNumberField;
        
        private string serialQuantityField;
        
        private System.DateTime serialExpiryDateField;
        
        private bool serialExpiryDateFieldSpecified;
        
        private string serialLocationField;
        
        private string serialFifoBucketField;
        
        /// <remarks/>
        public string SerialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime SerialExpiryDate {
            get {
                return this.serialExpiryDateField;
            }
            set {
                this.serialExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerialExpiryDateSpecified {
            get {
                return this.serialExpiryDateFieldSpecified;
            }
            set {
                this.serialExpiryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string SerialLocation {
            get {
                return this.serialLocationField;
            }
            set {
                this.serialLocationField = value;
            }
        }
        
        /// <remarks/>
        public string SerialFifoBucket {
            get {
                return this.serialFifoBucketField;
            }
            set {
                this.serialFifoBucketField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostJobReceiptsItemSerialRange {
        
        private string serialPrefixField;
        
        private string serialSuffixField;
        
        private string startSerialNumberField;
        
        private string serialQuantityField;
        
        private System.DateTime serialExpiryDateField;
        
        private bool serialExpiryDateFieldSpecified;
        
        private string serialLocationField;
        
        /// <remarks/>
        public string SerialPrefix {
            get {
                return this.serialPrefixField;
            }
            set {
                this.serialPrefixField = value;
            }
        }
        
        /// <remarks/>
        public string SerialSuffix {
            get {
                return this.serialSuffixField;
            }
            set {
                this.serialSuffixField = value;
            }
        }
        
        /// <remarks/>
        public string StartSerialNumber {
            get {
                return this.startSerialNumberField;
            }
            set {
                this.startSerialNumberField = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime SerialExpiryDate {
            get {
                return this.serialExpiryDateField;
            }
            set {
                this.serialExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SerialExpiryDateSpecified {
            get {
                return this.serialExpiryDateFieldSpecified;
            }
            set {
                this.serialExpiryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string SerialLocation {
            get {
                return this.serialLocationField;
            }
            set {
                this.serialLocationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostJobReceiptsItemSerialAllocation {
        
        private string fromSerialNumberField;
        
        private string toSerialNumberField;
        
        private string serialQuantityField;
        
        /// <remarks/>
        public string FromSerialNumber {
            get {
                return this.fromSerialNumberField;
            }
            set {
                this.fromSerialNumberField = value;
            }
        }
        
        /// <remarks/>
        public string ToSerialNumber {
            get {
                return this.toSerialNumberField;
            }
            set {
                this.toSerialNumberField = value;
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostJobReceiptsItemHierarchyJob {
        
        private string headField;
        
        private string section1Field;
        
        private string section2Field;
        
        private string section3Field;
        
        private string section4Field;
        
        private string costOfSalesAmountField;
        
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
        
        /// <remarks/>
        public string CostOfSalesAmount {
            get {
                return this.costOfSalesAmountField;
            }
            set {
                this.costOfSalesAmountField = value;
            }
        }
    }
}
