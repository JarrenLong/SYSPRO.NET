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
namespace SYSPRO.NET.BusinessObjects.WIPTJLDOC {
    using System.Xml.Serialization;
    
    
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private string jobField;
        
        private string operationField;
        
        private string workCentreField;
        
        private ItemUnitOfMeasure unitOfMeasureField;
        
        private string plannedQueueDateField;
        
        private string plannedStartDateField;
        
        private string plannedEndDateField;
        
        private string narrationField;
        
        private string workCentreDescField;
        
        private string fixedElapsedTimeField;
        
        private string elapsedTimeField;
        
        private string movementTimeField;
        
        private string unitNumOfPiecesField;
        
        private string inspectionFlagField;
        
        private string milestoneField;
        
        private string minorSetupCodeField;
        
        private string minorSetupField;
        
        private string toolSetField;
        
        private string toolSetQtyField;
        
        private string toolConsumptionField;
        
        private string queueTimeField;
        
        private HierarchyJob hierarchyJobField;
        
        private string previousOpMovementField;
        
        private string nextOpQueueField;
        
        private string calculateDatesField;
        
        private string iMachineField;
        
        private string iQuantityField;
        
        private string iTimeTakenField;
        
        private string iExpUnitRunTimField;
        
        private string iExpSetUpTimeField;
        
        private string iExpStartupTimeField;
        
        private string iExpShutdownTimField;
        
        private string iWaitTimeField;
        
        private string iWcRateIndField;
        
        private string iStartupQtyField;
        
        private string overrideCalcCapField;
        
        private string iCapacityReqdField;
        
        private string iMaxWorkOpertrsField;
        
        private string iMaxProdUnitsField;
        
        private string subSupplierField;
        
        private string supPoStkCodeField;
        
        private string subQtyPerField;
        
        private string subOrderUomField;
        
        private string subUnitValueField;
        
        private string subPlannerField;
        
        private string subBuyerField;
        
        private string subLeadTimeField;
        
        private string subDockToStockField;
        
        private string subOffsiteDaysField;
        
        private string operYieldPctField;
        
        private string operYieldQtyField;
        
        private string eSignatureField;
        
        public Item() {
            this.unitOfMeasureField = ItemUnitOfMeasure.S;
            this.fixedElapsedTimeField = "N";
            this.inspectionFlagField = "N";
            this.milestoneField = "Y";
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
        public string Operation {
            get {
                return this.operationField;
            }
            set {
                this.operationField = value;
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
        public ItemUnitOfMeasure UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        public string PlannedQueueDate {
            get {
                return this.plannedQueueDateField;
            }
            set {
                this.plannedQueueDateField = value;
            }
        }
        
        /// <remarks/>
        public string PlannedStartDate {
            get {
                return this.plannedStartDateField;
            }
            set {
                this.plannedStartDateField = value;
            }
        }
        
        /// <remarks/>
        public string PlannedEndDate {
            get {
                return this.plannedEndDateField;
            }
            set {
                this.plannedEndDateField = value;
            }
        }
        
        /// <remarks/>
        public string Narration {
            get {
                return this.narrationField;
            }
            set {
                this.narrationField = value;
            }
        }
        
        /// <remarks/>
        public string WorkCentreDesc {
            get {
                return this.workCentreDescField;
            }
            set {
                this.workCentreDescField = value;
            }
        }
        
        /// <remarks/>
        public string FixedElapsedTime {
            get {
                return this.fixedElapsedTimeField;
            }
            set {
                this.fixedElapsedTimeField = value;
            }
        }
        
        /// <remarks/>
        public string ElapsedTime {
            get {
                return this.elapsedTimeField;
            }
            set {
                this.elapsedTimeField = value;
            }
        }
        
        /// <remarks/>
        public string MovementTime {
            get {
                return this.movementTimeField;
            }
            set {
                this.movementTimeField = value;
            }
        }
        
        /// <remarks/>
        public string UnitNumOfPieces {
            get {
                return this.unitNumOfPiecesField;
            }
            set {
                this.unitNumOfPiecesField = value;
            }
        }
        
        /// <remarks/>
        public string InspectionFlag {
            get {
                return this.inspectionFlagField;
            }
            set {
                this.inspectionFlagField = value;
            }
        }
        
        /// <remarks/>
        public string Milestone {
            get {
                return this.milestoneField;
            }
            set {
                this.milestoneField = value;
            }
        }
        
        /// <remarks/>
        public string MinorSetupCode {
            get {
                return this.minorSetupCodeField;
            }
            set {
                this.minorSetupCodeField = value;
            }
        }
        
        /// <remarks/>
        public string MinorSetup {
            get {
                return this.minorSetupField;
            }
            set {
                this.minorSetupField = value;
            }
        }
        
        /// <remarks/>
        public string ToolSet {
            get {
                return this.toolSetField;
            }
            set {
                this.toolSetField = value;
            }
        }
        
        /// <remarks/>
        public string ToolSetQty {
            get {
                return this.toolSetQtyField;
            }
            set {
                this.toolSetQtyField = value;
            }
        }
        
        /// <remarks/>
        public string ToolConsumption {
            get {
                return this.toolConsumptionField;
            }
            set {
                this.toolConsumptionField = value;
            }
        }
        
        /// <remarks/>
        public string QueueTime {
            get {
                return this.queueTimeField;
            }
            set {
                this.queueTimeField = value;
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
        public string PreviousOpMovement {
            get {
                return this.previousOpMovementField;
            }
            set {
                this.previousOpMovementField = value;
            }
        }
        
        /// <remarks/>
        public string NextOpQueue {
            get {
                return this.nextOpQueueField;
            }
            set {
                this.nextOpQueueField = value;
            }
        }
        
        /// <remarks/>
        public string CalculateDates {
            get {
                return this.calculateDatesField;
            }
            set {
                this.calculateDatesField = value;
            }
        }
        
        /// <remarks/>
        public string IMachine {
            get {
                return this.iMachineField;
            }
            set {
                this.iMachineField = value;
            }
        }
        
        /// <remarks/>
        public string IQuantity {
            get {
                return this.iQuantityField;
            }
            set {
                this.iQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string ITimeTaken {
            get {
                return this.iTimeTakenField;
            }
            set {
                this.iTimeTakenField = value;
            }
        }
        
        /// <remarks/>
        public string IExpUnitRunTim {
            get {
                return this.iExpUnitRunTimField;
            }
            set {
                this.iExpUnitRunTimField = value;
            }
        }
        
        /// <remarks/>
        public string IExpSetUpTime {
            get {
                return this.iExpSetUpTimeField;
            }
            set {
                this.iExpSetUpTimeField = value;
            }
        }
        
        /// <remarks/>
        public string IExpStartupTime {
            get {
                return this.iExpStartupTimeField;
            }
            set {
                this.iExpStartupTimeField = value;
            }
        }
        
        /// <remarks/>
        public string IExpShutdownTim {
            get {
                return this.iExpShutdownTimField;
            }
            set {
                this.iExpShutdownTimField = value;
            }
        }
        
        /// <remarks/>
        public string IWaitTime {
            get {
                return this.iWaitTimeField;
            }
            set {
                this.iWaitTimeField = value;
            }
        }
        
        /// <remarks/>
        public string IWcRateInd {
            get {
                return this.iWcRateIndField;
            }
            set {
                this.iWcRateIndField = value;
            }
        }
        
        /// <remarks/>
        public string IStartupQty {
            get {
                return this.iStartupQtyField;
            }
            set {
                this.iStartupQtyField = value;
            }
        }
        
        /// <remarks/>
        public string OverrideCalcCap {
            get {
                return this.overrideCalcCapField;
            }
            set {
                this.overrideCalcCapField = value;
            }
        }
        
        /// <remarks/>
        public string ICapacityReqd {
            get {
                return this.iCapacityReqdField;
            }
            set {
                this.iCapacityReqdField = value;
            }
        }
        
        /// <remarks/>
        public string IMaxWorkOpertrs {
            get {
                return this.iMaxWorkOpertrsField;
            }
            set {
                this.iMaxWorkOpertrsField = value;
            }
        }
        
        /// <remarks/>
        public string IMaxProdUnits {
            get {
                return this.iMaxProdUnitsField;
            }
            set {
                this.iMaxProdUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string SubSupplier {
            get {
                return this.subSupplierField;
            }
            set {
                this.subSupplierField = value;
            }
        }
        
        /// <remarks/>
        public string SupPoStkCode {
            get {
                return this.supPoStkCodeField;
            }
            set {
                this.supPoStkCodeField = value;
            }
        }
        
        /// <remarks/>
        public string SubQtyPer {
            get {
                return this.subQtyPerField;
            }
            set {
                this.subQtyPerField = value;
            }
        }
        
        /// <remarks/>
        public string SubOrderUom {
            get {
                return this.subOrderUomField;
            }
            set {
                this.subOrderUomField = value;
            }
        }
        
        /// <remarks/>
        public string SubUnitValue {
            get {
                return this.subUnitValueField;
            }
            set {
                this.subUnitValueField = value;
            }
        }
        
        /// <remarks/>
        public string SubPlanner {
            get {
                return this.subPlannerField;
            }
            set {
                this.subPlannerField = value;
            }
        }
        
        /// <remarks/>
        public string SubBuyer {
            get {
                return this.subBuyerField;
            }
            set {
                this.subBuyerField = value;
            }
        }
        
        /// <remarks/>
        public string SubLeadTime {
            get {
                return this.subLeadTimeField;
            }
            set {
                this.subLeadTimeField = value;
            }
        }
        
        /// <remarks/>
        public string SubDockToStock {
            get {
                return this.subDockToStockField;
            }
            set {
                this.subDockToStockField = value;
            }
        }
        
        /// <remarks/>
        public string SubOffsiteDays {
            get {
                return this.subOffsiteDaysField;
            }
            set {
                this.subOffsiteDaysField = value;
            }
        }
        
        /// <remarks/>
        public string OperYieldPct {
            get {
                return this.operYieldPctField;
            }
            set {
                this.operYieldPctField = value;
            }
        }
        
        /// <remarks/>
        public string OperYieldQty {
            get {
                return this.operYieldQtyField;
            }
            set {
                this.operYieldQtyField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ItemUnitOfMeasure {
        
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostLabourAllocations {
        
        private Item itemField;
        
        /// <remarks/>
        public Item Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
