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
namespace SYSPRO.NET.BusinessObjects.SORQPSOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum MBomFlag {
        
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MEccFlag {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum MParentKitType {
        
        /// <remarks/>
        N,
        
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
    public partial class MultiShipCode {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Release {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ReleaseReservedStockQuery {
        
        private ReleaseReservedStockQueryQueryOptions queryOptionsField;
        
        private ReleaseReservedStockQueryOrderItem[] releaseOrderItemsField;
        
        private sbyte languageField;
        
        private string language2Field;
        
        private string cssStyleField;
        
        private bool decFormatField;
        
        private sbyte dateFormatField;
        
        private sbyte roleField;
        
        private string versionField;
        
        private string operatorPrimaryRoleField;
        
        /// <remarks/>
        public ReleaseReservedStockQueryQueryOptions QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OrderItem", IsNullable=false)]
        public ReleaseReservedStockQueryOrderItem[] ReleaseOrderItems {
            get {
                return this.releaseOrderItemsField;
            }
            set {
                this.releaseOrderItemsField = value;
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
        public string Language2 {
            get {
                return this.language2Field;
            }
            set {
                this.language2Field = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OperatorPrimaryRole {
            get {
                return this.operatorPrimaryRoleField;
            }
            set {
                this.operatorPrimaryRoleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReleaseReservedStockQueryQueryOptions {
        
        private string pickingStatusLinesOnlyField;
        
        private string customerFilterTypeField;
        
        private ReleaseReservedStockQueryQueryOptionsCustomerFilterValue customerFilterValueField;
        
        private string shipDateFilterTypeField;
        
        private ReleaseReservedStockQueryQueryOptionsShipDateFilterValue shipDateFilterValueField;
        
        private string salesOrderFilterTypeField;
        
        private ReleaseReservedStockQueryQueryOptionsSalesOrderFilterValue salesOrderFilterValueField;
        
        private string stockCodeFilterTypeField;
        
        private ReleaseReservedStockQueryQueryOptionsStockCodeFilterValue stockCodeFilterValueField;
        
        private string warehouseFilterTypeField;
        
        private ReleaseReservedStockQueryQueryOptionsWarehouseFilterValue warehouseFilterValueField;
        
        /// <remarks/>
        public string PickingStatusLinesOnly {
            get {
                return this.pickingStatusLinesOnlyField;
            }
            set {
                this.pickingStatusLinesOnlyField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerFilterType {
            get {
                return this.customerFilterTypeField;
            }
            set {
                this.customerFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ReleaseReservedStockQueryQueryOptionsCustomerFilterValue CustomerFilterValue {
            get {
                return this.customerFilterValueField;
            }
            set {
                this.customerFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string ShipDateFilterType {
            get {
                return this.shipDateFilterTypeField;
            }
            set {
                this.shipDateFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ReleaseReservedStockQueryQueryOptionsShipDateFilterValue ShipDateFilterValue {
            get {
                return this.shipDateFilterValueField;
            }
            set {
                this.shipDateFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrderFilterType {
            get {
                return this.salesOrderFilterTypeField;
            }
            set {
                this.salesOrderFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ReleaseReservedStockQueryQueryOptionsSalesOrderFilterValue SalesOrderFilterValue {
            get {
                return this.salesOrderFilterValueField;
            }
            set {
                this.salesOrderFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string StockCodeFilterType {
            get {
                return this.stockCodeFilterTypeField;
            }
            set {
                this.stockCodeFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ReleaseReservedStockQueryQueryOptionsStockCodeFilterValue StockCodeFilterValue {
            get {
                return this.stockCodeFilterValueField;
            }
            set {
                this.stockCodeFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseFilterType {
            get {
                return this.warehouseFilterTypeField;
            }
            set {
                this.warehouseFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public ReleaseReservedStockQueryQueryOptionsWarehouseFilterValue WarehouseFilterValue {
            get {
                return this.warehouseFilterValueField;
            }
            set {
                this.warehouseFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReleaseReservedStockQueryQueryOptionsCustomerFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReleaseReservedStockQueryQueryOptionsShipDateFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReleaseReservedStockQueryQueryOptionsSalesOrderFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReleaseReservedStockQueryQueryOptionsStockCodeFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReleaseReservedStockQueryQueryOptionsWarehouseFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReleaseReservedStockQueryOrderItem {
        
        private short salesOrderField;
        
        private string salesOrderLineField;
        
        private sbyte customerField;
        
        private bool customerFieldSpecified;
        
        private string customerNameField;
        
        private string targetWarehouseField;
        
        private string targetWarehouseDescriptionField;
        
        private StockCode stockCodeField;
        
        private string stockCodeDescriptionField;
        
        private string longDescriptionField;
        
        private MEccFlag mEccFlagField;
        
        private Revision revisionField;
        
        private Release releaseField;
        
        private bool lineTypeField;
        
        private Warehouse warehouseField;
        
        private string warehouseDescriptionField;
        
        private string reservedQuantityField;
        
        private ReservedQuantityUnits reservedQuantityUnitsField;
        
        private string resQuantityStkField;
        
        private ResQuantityStkUnits resQuantityStkUnitsField;
        
        private string shipQuantityField;
        
        private ShipQuantityUnits shipQuantityUnitsField;
        
        private string shipQuantityStkField;
        
        private ShipQuantityStkUnits shipQuantityStkUnitsField;
        
        private MBomFlag mBomFlagField;
        
        private MParentKitType mParentKitTypeField;
        
        private string mQtyChangesFlagField;
        
        private string mTraceableTypeField;
        
        private string mSerialMethodField;
        
        private string salesOrderResStatField;
        
        private string mUnitQuantityField;
        
        private string mConvFactUnitQField;
        
        private bool mDecimalsUnitQField;
        
        private MultiShipCode multiShipCodeField;
        
        private ReleaseReservedStockQueryOrderItemKitItem[] kitItemField;
        
        /// <remarks/>
        public short SalesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        public sbyte Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomerSpecified {
            get {
                return this.customerFieldSpecified;
            }
            set {
                this.customerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string CustomerName {
            get {
                return this.customerNameField;
            }
            set {
                this.customerNameField = value;
            }
        }
        
        /// <remarks/>
        public string TargetWarehouse {
            get {
                return this.targetWarehouseField;
            }
            set {
                this.targetWarehouseField = value;
            }
        }
        
        /// <remarks/>
        public string TargetWarehouseDescription {
            get {
                return this.targetWarehouseDescriptionField;
            }
            set {
                this.targetWarehouseDescriptionField = value;
            }
        }
        
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
        public string StockCodeDescription {
            get {
                return this.stockCodeDescriptionField;
            }
            set {
                this.stockCodeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string LongDescription {
            get {
                return this.longDescriptionField;
            }
            set {
                this.longDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public MEccFlag MEccFlag {
            get {
                return this.mEccFlagField;
            }
            set {
                this.mEccFlagField = value;
            }
        }
        
        /// <remarks/>
        public Revision Revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
            }
        }
        
        /// <remarks/>
        public Release Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        
        /// <remarks/>
        public bool LineType {
            get {
                return this.lineTypeField;
            }
            set {
                this.lineTypeField = value;
            }
        }
        
        /// <remarks/>
        public Warehouse Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseDescription {
            get {
                return this.warehouseDescriptionField;
            }
            set {
                this.warehouseDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string ReservedQuantity {
            get {
                return this.reservedQuantityField;
            }
            set {
                this.reservedQuantityField = value;
            }
        }
        
        /// <remarks/>
        public ReservedQuantityUnits ReservedQuantityUnits {
            get {
                return this.reservedQuantityUnitsField;
            }
            set {
                this.reservedQuantityUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string ResQuantityStk {
            get {
                return this.resQuantityStkField;
            }
            set {
                this.resQuantityStkField = value;
            }
        }
        
        /// <remarks/>
        public ResQuantityStkUnits ResQuantityStkUnits {
            get {
                return this.resQuantityStkUnitsField;
            }
            set {
                this.resQuantityStkUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string ShipQuantity {
            get {
                return this.shipQuantityField;
            }
            set {
                this.shipQuantityField = value;
            }
        }
        
        /// <remarks/>
        public ShipQuantityUnits ShipQuantityUnits {
            get {
                return this.shipQuantityUnitsField;
            }
            set {
                this.shipQuantityUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string ShipQuantityStk {
            get {
                return this.shipQuantityStkField;
            }
            set {
                this.shipQuantityStkField = value;
            }
        }
        
        /// <remarks/>
        public ShipQuantityStkUnits ShipQuantityStkUnits {
            get {
                return this.shipQuantityStkUnitsField;
            }
            set {
                this.shipQuantityStkUnitsField = value;
            }
        }
        
        /// <remarks/>
        public MBomFlag MBomFlag {
            get {
                return this.mBomFlagField;
            }
            set {
                this.mBomFlagField = value;
            }
        }
        
        /// <remarks/>
        public MParentKitType MParentKitType {
            get {
                return this.mParentKitTypeField;
            }
            set {
                this.mParentKitTypeField = value;
            }
        }
        
        /// <remarks/>
        public string MQtyChangesFlag {
            get {
                return this.mQtyChangesFlagField;
            }
            set {
                this.mQtyChangesFlagField = value;
            }
        }
        
        /// <remarks/>
        public string MTraceableType {
            get {
                return this.mTraceableTypeField;
            }
            set {
                this.mTraceableTypeField = value;
            }
        }
        
        /// <remarks/>
        public string MSerialMethod {
            get {
                return this.mSerialMethodField;
            }
            set {
                this.mSerialMethodField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrderResStat {
            get {
                return this.salesOrderResStatField;
            }
            set {
                this.salesOrderResStatField = value;
            }
        }
        
        /// <remarks/>
        public string MUnitQuantity {
            get {
                return this.mUnitQuantityField;
            }
            set {
                this.mUnitQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string MConvFactUnitQ {
            get {
                return this.mConvFactUnitQField;
            }
            set {
                this.mConvFactUnitQField = value;
            }
        }
        
        /// <remarks/>
        public bool MDecimalsUnitQ {
            get {
                return this.mDecimalsUnitQField;
            }
            set {
                this.mDecimalsUnitQField = value;
            }
        }
        
        /// <remarks/>
        public MultiShipCode MultiShipCode {
            get {
                return this.multiShipCodeField;
            }
            set {
                this.multiShipCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KitItem")]
        public ReleaseReservedStockQueryOrderItemKitItem[] KitItem {
            get {
                return this.kitItemField;
            }
            set {
                this.kitItemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum StockCode {
        
        /// <remarks/>
        A100,
        
        /// <remarks/>
        A110,
        
        /// <remarks/>
        A121,
        
        /// <remarks/>
        A200,
        
        /// <remarks/>
        A201,
        
        /// <remarks/>
        A202,
        
        /// <remarks/>
        KIT101,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Revision {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Warehouse {
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        FG,
        
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
    public partial class ReservedQuantityUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ResQuantityStkUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ShipQuantityUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ShipQuantityStkUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class ReleaseReservedStockQueryOrderItemKitItem {
        
        private short salesOrderField;
        
        private string salesOrderLineField;
        
        private sbyte customerField;
        
        private string customerNameField;
        
        private StockCode stockCodeField;
        
        private string stockCodeDescriptionField;
        
        private string longDescriptionField;
        
        private MEccFlag mEccFlagField;
        
        private Revision revisionField;
        
        private Release releaseField;
        
        private bool lineTypeField;
        
        private Warehouse warehouseField;
        
        private string warehouseDescriptionField;
        
        private string reservedQuantityField;
        
        private ReservedQuantityUnits reservedQuantityUnitsField;
        
        private string resQuantityStkField;
        
        private ResQuantityStkUnits resQuantityStkUnitsField;
        
        private string shipQuantityField;
        
        private ShipQuantityUnits shipQuantityUnitsField;
        
        private string shipQuantityStkField;
        
        private ShipQuantityStkUnits shipQuantityStkUnitsField;
        
        private MBomFlag mBomFlagField;
        
        private MParentKitType mParentKitTypeField;
        
        private string mQtyChangesFlagField;
        
        private string mTraceableTypeField;
        
        private string mSerialMethodField;
        
        private string salesOrderResStatField;
        
        private string mUnitQuantityField;
        
        private string mConvFactUnitQField;
        
        private bool mDecimalsUnitQField;
        
        private MultiShipCode multiShipCodeField;
        
        /// <remarks/>
        public short SalesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        public sbyte Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerName {
            get {
                return this.customerNameField;
            }
            set {
                this.customerNameField = value;
            }
        }
        
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
        public string StockCodeDescription {
            get {
                return this.stockCodeDescriptionField;
            }
            set {
                this.stockCodeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string LongDescription {
            get {
                return this.longDescriptionField;
            }
            set {
                this.longDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public MEccFlag MEccFlag {
            get {
                return this.mEccFlagField;
            }
            set {
                this.mEccFlagField = value;
            }
        }
        
        /// <remarks/>
        public Revision Revision {
            get {
                return this.revisionField;
            }
            set {
                this.revisionField = value;
            }
        }
        
        /// <remarks/>
        public Release Release {
            get {
                return this.releaseField;
            }
            set {
                this.releaseField = value;
            }
        }
        
        /// <remarks/>
        public bool LineType {
            get {
                return this.lineTypeField;
            }
            set {
                this.lineTypeField = value;
            }
        }
        
        /// <remarks/>
        public Warehouse Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseDescription {
            get {
                return this.warehouseDescriptionField;
            }
            set {
                this.warehouseDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string ReservedQuantity {
            get {
                return this.reservedQuantityField;
            }
            set {
                this.reservedQuantityField = value;
            }
        }
        
        /// <remarks/>
        public ReservedQuantityUnits ReservedQuantityUnits {
            get {
                return this.reservedQuantityUnitsField;
            }
            set {
                this.reservedQuantityUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string ResQuantityStk {
            get {
                return this.resQuantityStkField;
            }
            set {
                this.resQuantityStkField = value;
            }
        }
        
        /// <remarks/>
        public ResQuantityStkUnits ResQuantityStkUnits {
            get {
                return this.resQuantityStkUnitsField;
            }
            set {
                this.resQuantityStkUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string ShipQuantity {
            get {
                return this.shipQuantityField;
            }
            set {
                this.shipQuantityField = value;
            }
        }
        
        /// <remarks/>
        public ShipQuantityUnits ShipQuantityUnits {
            get {
                return this.shipQuantityUnitsField;
            }
            set {
                this.shipQuantityUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string ShipQuantityStk {
            get {
                return this.shipQuantityStkField;
            }
            set {
                this.shipQuantityStkField = value;
            }
        }
        
        /// <remarks/>
        public ShipQuantityStkUnits ShipQuantityStkUnits {
            get {
                return this.shipQuantityStkUnitsField;
            }
            set {
                this.shipQuantityStkUnitsField = value;
            }
        }
        
        /// <remarks/>
        public MBomFlag MBomFlag {
            get {
                return this.mBomFlagField;
            }
            set {
                this.mBomFlagField = value;
            }
        }
        
        /// <remarks/>
        public MParentKitType MParentKitType {
            get {
                return this.mParentKitTypeField;
            }
            set {
                this.mParentKitTypeField = value;
            }
        }
        
        /// <remarks/>
        public string MQtyChangesFlag {
            get {
                return this.mQtyChangesFlagField;
            }
            set {
                this.mQtyChangesFlagField = value;
            }
        }
        
        /// <remarks/>
        public string MTraceableType {
            get {
                return this.mTraceableTypeField;
            }
            set {
                this.mTraceableTypeField = value;
            }
        }
        
        /// <remarks/>
        public string MSerialMethod {
            get {
                return this.mSerialMethodField;
            }
            set {
                this.mSerialMethodField = value;
            }
        }
        
        /// <remarks/>
        public string SalesOrderResStat {
            get {
                return this.salesOrderResStatField;
            }
            set {
                this.salesOrderResStatField = value;
            }
        }
        
        /// <remarks/>
        public string MUnitQuantity {
            get {
                return this.mUnitQuantityField;
            }
            set {
                this.mUnitQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string MConvFactUnitQ {
            get {
                return this.mConvFactUnitQField;
            }
            set {
                this.mConvFactUnitQField = value;
            }
        }
        
        /// <remarks/>
        public bool MDecimalsUnitQ {
            get {
                return this.mDecimalsUnitQField;
            }
            set {
                this.mDecimalsUnitQField = value;
            }
        }
        
        /// <remarks/>
        public MultiShipCode MultiShipCode {
            get {
                return this.multiShipCodeField;
            }
            set {
                this.multiShipCodeField = value;
            }
        }
    }
}
