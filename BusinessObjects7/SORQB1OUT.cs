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
namespace SYSPRO.NET.BusinessObjects.SORQB1OUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CommentLine {
        
        private SalesOrderLine salesOrderLineField;
        
        private string nCommentField;
        
        private string nCommentFromLinField;
        
        private string nCommentTypeField;
        
        private NCommentTextTyp nCommentTextTypField;
        
        /// <remarks/>
        public SalesOrderLine SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        public string NComment {
            get {
                return this.nCommentField;
            }
            set {
                this.nCommentField = value;
            }
        }
        
        /// <remarks/>
        public string NCommentFromLin {
            get {
                return this.nCommentFromLinField;
            }
            set {
                this.nCommentFromLinField = value;
            }
        }
        
        /// <remarks/>
        public string NCommentType {
            get {
                return this.nCommentTypeField;
            }
            set {
                this.nCommentTypeField = value;
            }
        }
        
        /// <remarks/>
        public NCommentTextTyp NCommentTextTyp {
            get {
                return this.nCommentTextTypField;
            }
            set {
                this.nCommentTextTypField = value;
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
    public partial class SalesOrderLine {
        
        private Merchandise merchandiseField;
        
        private CommentLine commentLineField;
        
        private Freight freightField;
        
        private MiscCharge miscChargeField;
        
        private string[] textField;
        
        /// <remarks/>
        public Merchandise Merchandise {
            get {
                return this.merchandiseField;
            }
            set {
                this.merchandiseField = value;
            }
        }
        
        /// <remarks/>
        public CommentLine CommentLine {
            get {
                return this.commentLineField;
            }
            set {
                this.commentLineField = value;
            }
        }
        
        /// <remarks/>
        public Freight Freight {
            get {
                return this.freightField;
            }
            set {
                this.freightField = value;
            }
        }
        
        /// <remarks/>
        public MiscCharge MiscCharge {
            get {
                return this.miscChargeField;
            }
            set {
                this.miscChargeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
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
    public partial class Merchandise {
        
        private SalesOrderLine salesOrderLineField;
        
        private string mStockCodeField;
        
        private string mStockDesField;
        
        private string mProductClassField;
        
        private string mWarehouseField;
        
        private string mBinField;
        
        private string mOrderQtyField;
        
        private MOrderQtyUnits mOrderQtyUnitsField;
        
        private string editedMOrderQtyField;
        
        private string mOrderQtyInStockingUmField;
        
        private MOrderQtyInStockingUmUnits mOrderQtyInStockingUmUnitsField;
        
        private string editedMOrderQtyInStockingUmField;
        
        private string mShipQtyField;
        
        private MShipQtyUnits mShipQtyUnitsField;
        
        private string editedMShipQtyField;
        
        private string qtyReservedField;
        
        private QtyReservedUnits qtyReservedUnitsField;
        
        private string editedQtyReservedField;
        
        private string mStockQtyToShpField;
        
        private MStockQtyToShpUnits mStockQtyToShpUnitsField;
        
        private string editedMStockQtyToShpField;
        
        private string qtyReservedShipField;
        
        private QtyReservedShipUnits qtyReservedShipUnitsField;
        
        private string editedQtyReservedShipField;
        
        private string mBackOrderQtyField;
        
        private MBackOrderQtyUnits mBackOrderQtyUnitsField;
        
        private string editedMBackOrderQtyField;
        
        private string mBackOrderQtyInStockingUmField;
        
        private MBackOrderQtyInStockingUmUnits mBackOrderQtyInStockingUmUnitsField;
        
        private string editedMBackOrderQtyInStockingUmField;
        
        private string mQtyDispatchedField;
        
        private MQtyDispatchedUnits mQtyDispatchedUnitsField;
        
        private string editedMQtyDispatchedField;
        
        private string mOrderUomField;
        
        private string mStockingUomField;
        
        private string mPriceField;
        
        private string mUnitCostField;
        
        private string mPriceUomField;
        
        private string orderLineValueField;
        
        private string mLineShipDateField;
        
        private string mCustRequestDatField;
        
        private MHierarchyJob mHierarchyJobField;
        
        private string mVersionField;
        
        private string mReleaseField;
        
        private string includeInMrpField;
        
        private LineJob lineJobField;
        
        private LineRequisition lineRequisitionField;
        
        private string lineRequisitionKeyField;
        
        private LinePurchaseOrder linePurchaseOrderField;
        
        private string linePurchaseOrderKeyField;
        
        private ReservedAllocation reservedAllocationField;
        
        private string lotTraceableFlagField;
        
        private string serialFlagField;
        
        private string binFlagField;
        
        private SctFlag sctFlagField;
        
        /// <remarks/>
        public SalesOrderLine SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        public string MStockCode {
            get {
                return this.mStockCodeField;
            }
            set {
                this.mStockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string MStockDes {
            get {
                return this.mStockDesField;
            }
            set {
                this.mStockDesField = value;
            }
        }
        
        /// <remarks/>
        public string MProductClass {
            get {
                return this.mProductClassField;
            }
            set {
                this.mProductClassField = value;
            }
        }
        
        /// <remarks/>
        public string MWarehouse {
            get {
                return this.mWarehouseField;
            }
            set {
                this.mWarehouseField = value;
            }
        }
        
        /// <remarks/>
        public string MBin {
            get {
                return this.mBinField;
            }
            set {
                this.mBinField = value;
            }
        }
        
        /// <remarks/>
        public string MOrderQty {
            get {
                return this.mOrderQtyField;
            }
            set {
                this.mOrderQtyField = value;
            }
        }
        
        /// <remarks/>
        public MOrderQtyUnits MOrderQtyUnits {
            get {
                return this.mOrderQtyUnitsField;
            }
            set {
                this.mOrderQtyUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedMOrderQty {
            get {
                return this.editedMOrderQtyField;
            }
            set {
                this.editedMOrderQtyField = value;
            }
        }
        
        /// <remarks/>
        public string MOrderQtyInStockingUm {
            get {
                return this.mOrderQtyInStockingUmField;
            }
            set {
                this.mOrderQtyInStockingUmField = value;
            }
        }
        
        /// <remarks/>
        public MOrderQtyInStockingUmUnits MOrderQtyInStockingUmUnits {
            get {
                return this.mOrderQtyInStockingUmUnitsField;
            }
            set {
                this.mOrderQtyInStockingUmUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedMOrderQtyInStockingUm {
            get {
                return this.editedMOrderQtyInStockingUmField;
            }
            set {
                this.editedMOrderQtyInStockingUmField = value;
            }
        }
        
        /// <remarks/>
        public string MShipQty {
            get {
                return this.mShipQtyField;
            }
            set {
                this.mShipQtyField = value;
            }
        }
        
        /// <remarks/>
        public MShipQtyUnits MShipQtyUnits {
            get {
                return this.mShipQtyUnitsField;
            }
            set {
                this.mShipQtyUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedMShipQty {
            get {
                return this.editedMShipQtyField;
            }
            set {
                this.editedMShipQtyField = value;
            }
        }
        
        /// <remarks/>
        public string QtyReserved {
            get {
                return this.qtyReservedField;
            }
            set {
                this.qtyReservedField = value;
            }
        }
        
        /// <remarks/>
        public QtyReservedUnits QtyReservedUnits {
            get {
                return this.qtyReservedUnitsField;
            }
            set {
                this.qtyReservedUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedQtyReserved {
            get {
                return this.editedQtyReservedField;
            }
            set {
                this.editedQtyReservedField = value;
            }
        }
        
        /// <remarks/>
        public string MStockQtyToShp {
            get {
                return this.mStockQtyToShpField;
            }
            set {
                this.mStockQtyToShpField = value;
            }
        }
        
        /// <remarks/>
        public MStockQtyToShpUnits MStockQtyToShpUnits {
            get {
                return this.mStockQtyToShpUnitsField;
            }
            set {
                this.mStockQtyToShpUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedMStockQtyToShp {
            get {
                return this.editedMStockQtyToShpField;
            }
            set {
                this.editedMStockQtyToShpField = value;
            }
        }
        
        /// <remarks/>
        public string QtyReservedShip {
            get {
                return this.qtyReservedShipField;
            }
            set {
                this.qtyReservedShipField = value;
            }
        }
        
        /// <remarks/>
        public QtyReservedShipUnits QtyReservedShipUnits {
            get {
                return this.qtyReservedShipUnitsField;
            }
            set {
                this.qtyReservedShipUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedQtyReservedShip {
            get {
                return this.editedQtyReservedShipField;
            }
            set {
                this.editedQtyReservedShipField = value;
            }
        }
        
        /// <remarks/>
        public string MBackOrderQty {
            get {
                return this.mBackOrderQtyField;
            }
            set {
                this.mBackOrderQtyField = value;
            }
        }
        
        /// <remarks/>
        public MBackOrderQtyUnits MBackOrderQtyUnits {
            get {
                return this.mBackOrderQtyUnitsField;
            }
            set {
                this.mBackOrderQtyUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedMBackOrderQty {
            get {
                return this.editedMBackOrderQtyField;
            }
            set {
                this.editedMBackOrderQtyField = value;
            }
        }
        
        /// <remarks/>
        public string MBackOrderQtyInStockingUm {
            get {
                return this.mBackOrderQtyInStockingUmField;
            }
            set {
                this.mBackOrderQtyInStockingUmField = value;
            }
        }
        
        /// <remarks/>
        public MBackOrderQtyInStockingUmUnits MBackOrderQtyInStockingUmUnits {
            get {
                return this.mBackOrderQtyInStockingUmUnitsField;
            }
            set {
                this.mBackOrderQtyInStockingUmUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedMBackOrderQtyInStockingUm {
            get {
                return this.editedMBackOrderQtyInStockingUmField;
            }
            set {
                this.editedMBackOrderQtyInStockingUmField = value;
            }
        }
        
        /// <remarks/>
        public string MQtyDispatched {
            get {
                return this.mQtyDispatchedField;
            }
            set {
                this.mQtyDispatchedField = value;
            }
        }
        
        /// <remarks/>
        public MQtyDispatchedUnits MQtyDispatchedUnits {
            get {
                return this.mQtyDispatchedUnitsField;
            }
            set {
                this.mQtyDispatchedUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string EditedMQtyDispatched {
            get {
                return this.editedMQtyDispatchedField;
            }
            set {
                this.editedMQtyDispatchedField = value;
            }
        }
        
        /// <remarks/>
        public string MOrderUom {
            get {
                return this.mOrderUomField;
            }
            set {
                this.mOrderUomField = value;
            }
        }
        
        /// <remarks/>
        public string MStockingUom {
            get {
                return this.mStockingUomField;
            }
            set {
                this.mStockingUomField = value;
            }
        }
        
        /// <remarks/>
        public string MPrice {
            get {
                return this.mPriceField;
            }
            set {
                this.mPriceField = value;
            }
        }
        
        /// <remarks/>
        public string MUnitCost {
            get {
                return this.mUnitCostField;
            }
            set {
                this.mUnitCostField = value;
            }
        }
        
        /// <remarks/>
        public string MPriceUom {
            get {
                return this.mPriceUomField;
            }
            set {
                this.mPriceUomField = value;
            }
        }
        
        /// <remarks/>
        public string OrderLineValue {
            get {
                return this.orderLineValueField;
            }
            set {
                this.orderLineValueField = value;
            }
        }
        
        /// <remarks/>
        public string MLineShipDate {
            get {
                return this.mLineShipDateField;
            }
            set {
                this.mLineShipDateField = value;
            }
        }
        
        /// <remarks/>
        public string MCustRequestDat {
            get {
                return this.mCustRequestDatField;
            }
            set {
                this.mCustRequestDatField = value;
            }
        }
        
        /// <remarks/>
        public MHierarchyJob MHierarchyJob {
            get {
                return this.mHierarchyJobField;
            }
            set {
                this.mHierarchyJobField = value;
            }
        }
        
        /// <remarks/>
        public string MVersion {
            get {
                return this.mVersionField;
            }
            set {
                this.mVersionField = value;
            }
        }
        
        /// <remarks/>
        public string MRelease {
            get {
                return this.mReleaseField;
            }
            set {
                this.mReleaseField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeInMrp {
            get {
                return this.includeInMrpField;
            }
            set {
                this.includeInMrpField = value;
            }
        }
        
        /// <remarks/>
        public LineJob LineJob {
            get {
                return this.lineJobField;
            }
            set {
                this.lineJobField = value;
            }
        }
        
        /// <remarks/>
        public LineRequisition LineRequisition {
            get {
                return this.lineRequisitionField;
            }
            set {
                this.lineRequisitionField = value;
            }
        }
        
        /// <remarks/>
        public string LineRequisitionKey {
            get {
                return this.lineRequisitionKeyField;
            }
            set {
                this.lineRequisitionKeyField = value;
            }
        }
        
        /// <remarks/>
        public LinePurchaseOrder LinePurchaseOrder {
            get {
                return this.linePurchaseOrderField;
            }
            set {
                this.linePurchaseOrderField = value;
            }
        }
        
        /// <remarks/>
        public string LinePurchaseOrderKey {
            get {
                return this.linePurchaseOrderKeyField;
            }
            set {
                this.linePurchaseOrderKeyField = value;
            }
        }
        
        /// <remarks/>
        public ReservedAllocation ReservedAllocation {
            get {
                return this.reservedAllocationField;
            }
            set {
                this.reservedAllocationField = value;
            }
        }
        
        /// <remarks/>
        public string LotTraceableFlag {
            get {
                return this.lotTraceableFlagField;
            }
            set {
                this.lotTraceableFlagField = value;
            }
        }
        
        /// <remarks/>
        public string SerialFlag {
            get {
                return this.serialFlagField;
            }
            set {
                this.serialFlagField = value;
            }
        }
        
        /// <remarks/>
        public string BinFlag {
            get {
                return this.binFlagField;
            }
            set {
                this.binFlagField = value;
            }
        }
        
        /// <remarks/>
        public SctFlag SctFlag {
            get {
                return this.sctFlagField;
            }
            set {
                this.sctFlagField = value;
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
    public partial class MOrderQtyUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MOrderQtyInStockingUmUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MShipQtyUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class QtyReservedUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MStockQtyToShpUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class QtyReservedShipUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MBackOrderQtyUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MBackOrderQtyInStockingUmUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MQtyDispatchedUnits {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class MHierarchyJob {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum LineJob {
        
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
    public enum LineRequisition {
        
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
    public enum LinePurchaseOrder {
        
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
    public partial class ReservedAllocation {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SctFlag {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Freight {
        
        private SalesOrderLine salesOrderLineField;
        
        private string nCommentField;
        
        private string nCommentFromLinField;
        
        private string nMscChargeValueField;
        
        /// <remarks/>
        public SalesOrderLine SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        public string NComment {
            get {
                return this.nCommentField;
            }
            set {
                this.nCommentField = value;
            }
        }
        
        /// <remarks/>
        public string NCommentFromLin {
            get {
                return this.nCommentFromLinField;
            }
            set {
                this.nCommentFromLinField = value;
            }
        }
        
        /// <remarks/>
        public string NMscChargeValue {
            get {
                return this.nMscChargeValueField;
            }
            set {
                this.nMscChargeValueField = value;
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
    public partial class MiscCharge {
        
        private SalesOrderLine salesOrderLineField;
        
        private string nCommentField;
        
        private string nCommentFromLinField;
        
        private string nMscChargeValueField;
        
        /// <remarks/>
        public SalesOrderLine SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        public string NComment {
            get {
                return this.nCommentField;
            }
            set {
                this.nCommentField = value;
            }
        }
        
        /// <remarks/>
        public string NCommentFromLin {
            get {
                return this.nCommentFromLinField;
            }
            set {
                this.nCommentFromLinField = value;
            }
        }
        
        /// <remarks/>
        public string NMscChargeValue {
            get {
                return this.nMscChargeValueField;
            }
            set {
                this.nMscChargeValueField = value;
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
    public partial class NCommentTextTyp {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class DispatchesMade {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SalesOrderLines {
        
        private string salesOrderField;
        
        private DispatchesMade dispatchesMadeField;
        
        private SalesOrderLine[] salesOrderLineField;
        
        /// <remarks/>
        public string SalesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }
        
        /// <remarks/>
        public DispatchesMade DispatchesMade {
            get {
                return this.dispatchesMadeField;
            }
            set {
                this.dispatchesMadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalesOrderLine")]
        public SalesOrderLine[] SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
    }
}
