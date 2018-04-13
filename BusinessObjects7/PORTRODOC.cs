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
namespace SYSPRO.NET.BusinessObjects.PORTRODOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostPOReceiptsReverse {
        
        private PostPOReceiptsReverseItem[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public PostPOReceiptsReverseItem[] Item {
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
    public partial class PostPOReceiptsReverseItem {
        
        private string journalField;
        
        private string purchaseOrderField;
        
        private string purchaseOrderLineField;
        
        private string quantityField;
        
        private string unitsField;
        
        private string piecesField;
        
        private string deliveryNoteField;
        
        private string costField;
        
        private string costBasisField;
        
        private string gRNNumberField;
        
        private PostPOReceiptsReverseItemGRNSource gRNSourceField;
        
        private string lotField;
        
        private string binLocationField;
        
        private string fifoBucketField;
        
        private PostPOReceiptsReverseItemSerials[] serialsField;
        
        private PostPOReceiptsReverseItemSerialAllocation[] serialAllocationField;
        
        private PostPOReceiptsReverseItemPurchaseOrderLineComplete purchaseOrderLineCompleteField;
        
        private PostPOReceiptsReverseItemApplyCostMultiplier applyCostMultiplierField;
        
        private string costMultiplierField;
        
        private string nonMerchandiseCostField;
        
        private PostPOReceiptsReverseItemNonMerchandiseDistribution[] nonMerchandiseDistributionField;
        
        private string notationField;
        
        private string ledgerCodeField;
        
        private string passwordForLedgerCodeField;
        
        private string debitLedgerCodeField;
        
        private string passwordForDebitLedgerCodeField;
        
        private string countryOfOriginField;
        
        private string deliveryTermsField;
        
        private string shippingLocationField;
        
        private string natureOfTransactionField;
        
        private string modeOfTransportField;
        
        private string tradersReferenceField;
        
        private string tariffCodeField;
        
        private string unitMassField;
        
        private PostPOReceiptsReverseItemSupplementaryUnits supplementaryUnitsField;
        
        private string supplementaryUnitsFactorField;
        
        private PostPOReceiptsReverseItemSwitchOnGRNMatching switchOnGRNMatchingField;
        
        private PostPOReceiptsReverseItemUseSingleTypeABCElements useSingleTypeABCElementsField;
        
        public PostPOReceiptsReverseItem() {
            this.purchaseOrderLineCompleteField = PostPOReceiptsReverseItemPurchaseOrderLineComplete.N;
            this.applyCostMultiplierField = PostPOReceiptsReverseItemApplyCostMultiplier.N;
            this.supplementaryUnitsField = PostPOReceiptsReverseItemSupplementaryUnits.N;
            this.switchOnGRNMatchingField = PostPOReceiptsReverseItemSwitchOnGRNMatching.N;
            this.useSingleTypeABCElementsField = PostPOReceiptsReverseItemUseSingleTypeABCElements.N;
        }
        
        /// <remarks/>
        public string Journal {
            get {
                return this.journalField;
            }
            set {
                this.journalField = value;
            }
        }
        
        /// <remarks/>
        public string PurchaseOrder {
            get {
                return this.purchaseOrderField;
            }
            set {
                this.purchaseOrderField = value;
            }
        }
        
        /// <remarks/>
        public string PurchaseOrderLine {
            get {
                return this.purchaseOrderLineField;
            }
            set {
                this.purchaseOrderLineField = value;
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
        public string Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        public string Pieces {
            get {
                return this.piecesField;
            }
            set {
                this.piecesField = value;
            }
        }
        
        /// <remarks/>
        public string DeliveryNote {
            get {
                return this.deliveryNoteField;
            }
            set {
                this.deliveryNoteField = value;
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
        public string CostBasis {
            get {
                return this.costBasisField;
            }
            set {
                this.costBasisField = value;
            }
        }
        
        /// <remarks/>
        public string GRNNumber {
            get {
                return this.gRNNumberField;
            }
            set {
                this.gRNNumberField = value;
            }
        }
        
        /// <remarks/>
        public PostPOReceiptsReverseItemGRNSource GRNSource {
            get {
                return this.gRNSourceField;
            }
            set {
                this.gRNSourceField = value;
            }
        }
        
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
        public string BinLocation {
            get {
                return this.binLocationField;
            }
            set {
                this.binLocationField = value;
            }
        }
        
        /// <remarks/>
        public string FifoBucket {
            get {
                return this.fifoBucketField;
            }
            set {
                this.fifoBucketField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Serials")]
        public PostPOReceiptsReverseItemSerials[] Serials {
            get {
                return this.serialsField;
            }
            set {
                this.serialsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SerialAllocation")]
        public PostPOReceiptsReverseItemSerialAllocation[] SerialAllocation {
            get {
                return this.serialAllocationField;
            }
            set {
                this.serialAllocationField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemPurchaseOrderLineComplete.N)]
        public PostPOReceiptsReverseItemPurchaseOrderLineComplete PurchaseOrderLineComplete {
            get {
                return this.purchaseOrderLineCompleteField;
            }
            set {
                this.purchaseOrderLineCompleteField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemApplyCostMultiplier.N)]
        public PostPOReceiptsReverseItemApplyCostMultiplier ApplyCostMultiplier {
            get {
                return this.applyCostMultiplierField;
            }
            set {
                this.applyCostMultiplierField = value;
            }
        }
        
        /// <remarks/>
        public string CostMultiplier {
            get {
                return this.costMultiplierField;
            }
            set {
                this.costMultiplierField = value;
            }
        }
        
        /// <remarks/>
        public string NonMerchandiseCost {
            get {
                return this.nonMerchandiseCostField;
            }
            set {
                this.nonMerchandiseCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NonMerchandiseDistribution")]
        public PostPOReceiptsReverseItemNonMerchandiseDistribution[] NonMerchandiseDistribution {
            get {
                return this.nonMerchandiseDistributionField;
            }
            set {
                this.nonMerchandiseDistributionField = value;
            }
        }
        
        /// <remarks/>
        public string Notation {
            get {
                return this.notationField;
            }
            set {
                this.notationField = value;
            }
        }
        
        /// <remarks/>
        public string LedgerCode {
            get {
                return this.ledgerCodeField;
            }
            set {
                this.ledgerCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PasswordForLedgerCode {
            get {
                return this.passwordForLedgerCodeField;
            }
            set {
                this.passwordForLedgerCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DebitLedgerCode {
            get {
                return this.debitLedgerCodeField;
            }
            set {
                this.debitLedgerCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PasswordForDebitLedgerCode {
            get {
                return this.passwordForDebitLedgerCodeField;
            }
            set {
                this.passwordForDebitLedgerCodeField = value;
            }
        }
        
        /// <remarks/>
        public string CountryOfOrigin {
            get {
                return this.countryOfOriginField;
            }
            set {
                this.countryOfOriginField = value;
            }
        }
        
        /// <remarks/>
        public string DeliveryTerms {
            get {
                return this.deliveryTermsField;
            }
            set {
                this.deliveryTermsField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingLocation {
            get {
                return this.shippingLocationField;
            }
            set {
                this.shippingLocationField = value;
            }
        }
        
        /// <remarks/>
        public string NatureOfTransaction {
            get {
                return this.natureOfTransactionField;
            }
            set {
                this.natureOfTransactionField = value;
            }
        }
        
        /// <remarks/>
        public string ModeOfTransport {
            get {
                return this.modeOfTransportField;
            }
            set {
                this.modeOfTransportField = value;
            }
        }
        
        /// <remarks/>
        public string TradersReference {
            get {
                return this.tradersReferenceField;
            }
            set {
                this.tradersReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string TariffCode {
            get {
                return this.tariffCodeField;
            }
            set {
                this.tariffCodeField = value;
            }
        }
        
        /// <remarks/>
        public string UnitMass {
            get {
                return this.unitMassField;
            }
            set {
                this.unitMassField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemSupplementaryUnits.N)]
        public PostPOReceiptsReverseItemSupplementaryUnits SupplementaryUnits {
            get {
                return this.supplementaryUnitsField;
            }
            set {
                this.supplementaryUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string SupplementaryUnitsFactor {
            get {
                return this.supplementaryUnitsFactorField;
            }
            set {
                this.supplementaryUnitsFactorField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemSwitchOnGRNMatching.N)]
        public PostPOReceiptsReverseItemSwitchOnGRNMatching SwitchOnGRNMatching {
            get {
                return this.switchOnGRNMatchingField;
            }
            set {
                this.switchOnGRNMatchingField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostPOReceiptsReverseItemUseSingleTypeABCElements.N)]
        public PostPOReceiptsReverseItemUseSingleTypeABCElements UseSingleTypeABCElements {
            get {
                return this.useSingleTypeABCElementsField;
            }
            set {
                this.useSingleTypeABCElementsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostPOReceiptsReverseItemGRNSource {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostPOReceiptsReverseItemSerials {
        
        private string serialNumberField;
        
        private string serialQuantityField;
        
        private string serialUnitsField;
        
        private string serialPiecesField;
        
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
        public string SerialUnits {
            get {
                return this.serialUnitsField;
            }
            set {
                this.serialUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string SerialPieces {
            get {
                return this.serialPiecesField;
            }
            set {
                this.serialPiecesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostPOReceiptsReverseItemSerialAllocation {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostPOReceiptsReverseItemPurchaseOrderLineComplete {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostPOReceiptsReverseItemApplyCostMultiplier {
        
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
    public partial class PostPOReceiptsReverseItemNonMerchandiseDistribution {
        
        private string nmReferenceField;
        
        private string nmLedgerCodeField;
        
        private string nmSupplierField;
        
        private string nmAmountField;
        
        /// <remarks/>
        public string NmReference {
            get {
                return this.nmReferenceField;
            }
            set {
                this.nmReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string NmLedgerCode {
            get {
                return this.nmLedgerCodeField;
            }
            set {
                this.nmLedgerCodeField = value;
            }
        }
        
        /// <remarks/>
        public string NmSupplier {
            get {
                return this.nmSupplierField;
            }
            set {
                this.nmSupplierField = value;
            }
        }
        
        /// <remarks/>
        public string NmAmount {
            get {
                return this.nmAmountField;
            }
            set {
                this.nmAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostPOReceiptsReverseItemSupplementaryUnits {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostPOReceiptsReverseItemSwitchOnGRNMatching {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostPOReceiptsReverseItemUseSingleTypeABCElements {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
}
