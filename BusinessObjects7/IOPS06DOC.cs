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
namespace SYSPRO.NET.BusinessObjects.IOPS06DOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Calendar {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Filter {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ForecastRef {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private Key keyField;
        
        private string descriptionField;
        
        private string optionsMaintField;
        
        private string updateLiveForeField;
        
        private string manualForecastsField;
        
        private string batchForecastsField;
        
        private string paretoAnalysisField;
        
        private string forecastAccuracyField;
        
        private string policySettingField;
        
        private string ioModellingField;
        
        private string forecastCompareField;
        
        private bool abcBaseField;
        
        private sbyte abcMonthsField;
        
        private sbyte paretoBreakAbField;
        
        private sbyte paretoBreakBcField;
        
        private sbyte paretoBreakCdField;
        
        private bool includeAdjustField;
        
        private bool analyzeByEccField;
        
        private string batchTargetField;
        
        private bool adjustOutliersField;
        
        private bool incNoDraftField;
        
        private string forecastCreateField;
        
        private bool inactivateCurField;
        
        private bool freezeInLeadField;
        
        private bool deleteDraftField;
        
        private ForecastRef forecastRefField;
        
        private string foreAccCalField;
        
        private sbyte foreAccPeriodsField;
        
        private string foreAccCompareField;
        
        private bool foreAccMovePeriodsField;
        
        private string foreAccUseField;
        
        private sbyte foreAccNoSnapField;
        
        private bool incPrdNoForeField;
        
        private bool onlyIfDiffField;
        
        private bool percentDiffField;
        
        private bool monthsDiffField;
        
        private Calendar calendarField;
        
        private bool incMadeInField;
        
        private bool incBoughtOutField;
        
        private bool incSubConField;
        
        private bool incKitField;
        
        private bool incCoProdField;
        
        private bool incByProdField;
        
        private bool includeAbcAField;
        
        private bool includeAbcBField;
        
        private bool includeAbcCField;
        
        private bool includeAbcDField;
        
        private bool includeAbcEField;
        
        private bool includeAbcNoneField;
        
        private string abcTypeField;
        
        private bool abcLevelField;
        
        private bool manualForecastField;
        
        private bool replenishItemField;
        
        private bool incMpsField;
        
        private bool incMtoField;
        
        private string warehouseSelField;
        
        private string warehouseFromField;
        
        private string warehouseToField;
        
        private string warehouseListField;
        
        private string stockSelField;
        
        private string stockFromField;
        
        private string stockToField;
        
        private string stockListField;
        
        private string supplierSelField;
        
        private string supplierFromField;
        
        private string supplierToField;
        
        private string supplierListField;
        
        private string prodClassSelField;
        
        private string prodClassFromField;
        
        private string prodClassToField;
        
        private string prodClassListField;
        
        private string plannerSelField;
        
        private string plannerFromField;
        
        private string plannerToField;
        
        private string plannerListField;
        
        private string buyerSelField;
        
        private string buyerFromField;
        
        private string buyerToField;
        
        private string buyerListField;
        
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
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string OptionsMaint {
            get {
                return this.optionsMaintField;
            }
            set {
                this.optionsMaintField = value;
            }
        }
        
        /// <remarks/>
        public string UpdateLiveFore {
            get {
                return this.updateLiveForeField;
            }
            set {
                this.updateLiveForeField = value;
            }
        }
        
        /// <remarks/>
        public string ManualForecasts {
            get {
                return this.manualForecastsField;
            }
            set {
                this.manualForecastsField = value;
            }
        }
        
        /// <remarks/>
        public string BatchForecasts {
            get {
                return this.batchForecastsField;
            }
            set {
                this.batchForecastsField = value;
            }
        }
        
        /// <remarks/>
        public string ParetoAnalysis {
            get {
                return this.paretoAnalysisField;
            }
            set {
                this.paretoAnalysisField = value;
            }
        }
        
        /// <remarks/>
        public string ForecastAccuracy {
            get {
                return this.forecastAccuracyField;
            }
            set {
                this.forecastAccuracyField = value;
            }
        }
        
        /// <remarks/>
        public string PolicySetting {
            get {
                return this.policySettingField;
            }
            set {
                this.policySettingField = value;
            }
        }
        
        /// <remarks/>
        public string IoModelling {
            get {
                return this.ioModellingField;
            }
            set {
                this.ioModellingField = value;
            }
        }
        
        /// <remarks/>
        public string ForecastCompare {
            get {
                return this.forecastCompareField;
            }
            set {
                this.forecastCompareField = value;
            }
        }
        
        /// <remarks/>
        public bool AbcBase {
            get {
                return this.abcBaseField;
            }
            set {
                this.abcBaseField = value;
            }
        }
        
        /// <remarks/>
        public sbyte AbcMonths {
            get {
                return this.abcMonthsField;
            }
            set {
                this.abcMonthsField = value;
            }
        }
        
        /// <remarks/>
        public sbyte ParetoBreakAb {
            get {
                return this.paretoBreakAbField;
            }
            set {
                this.paretoBreakAbField = value;
            }
        }
        
        /// <remarks/>
        public sbyte ParetoBreakBc {
            get {
                return this.paretoBreakBcField;
            }
            set {
                this.paretoBreakBcField = value;
            }
        }
        
        /// <remarks/>
        public sbyte ParetoBreakCd {
            get {
                return this.paretoBreakCdField;
            }
            set {
                this.paretoBreakCdField = value;
            }
        }
        
        /// <remarks/>
        public bool IncludeAdjust {
            get {
                return this.includeAdjustField;
            }
            set {
                this.includeAdjustField = value;
            }
        }
        
        /// <remarks/>
        public bool AnalyzeByEcc {
            get {
                return this.analyzeByEccField;
            }
            set {
                this.analyzeByEccField = value;
            }
        }
        
        /// <remarks/>
        public string BatchTarget {
            get {
                return this.batchTargetField;
            }
            set {
                this.batchTargetField = value;
            }
        }
        
        /// <remarks/>
        public bool AdjustOutliers {
            get {
                return this.adjustOutliersField;
            }
            set {
                this.adjustOutliersField = value;
            }
        }
        
        /// <remarks/>
        public bool IncNoDraft {
            get {
                return this.incNoDraftField;
            }
            set {
                this.incNoDraftField = value;
            }
        }
        
        /// <remarks/>
        public string ForecastCreate {
            get {
                return this.forecastCreateField;
            }
            set {
                this.forecastCreateField = value;
            }
        }
        
        /// <remarks/>
        public bool InactivateCur {
            get {
                return this.inactivateCurField;
            }
            set {
                this.inactivateCurField = value;
            }
        }
        
        /// <remarks/>
        public bool FreezeInLead {
            get {
                return this.freezeInLeadField;
            }
            set {
                this.freezeInLeadField = value;
            }
        }
        
        /// <remarks/>
        public bool DeleteDraft {
            get {
                return this.deleteDraftField;
            }
            set {
                this.deleteDraftField = value;
            }
        }
        
        /// <remarks/>
        public ForecastRef ForecastRef {
            get {
                return this.forecastRefField;
            }
            set {
                this.forecastRefField = value;
            }
        }
        
        /// <remarks/>
        public string ForeAccCal {
            get {
                return this.foreAccCalField;
            }
            set {
                this.foreAccCalField = value;
            }
        }
        
        /// <remarks/>
        public sbyte ForeAccPeriods {
            get {
                return this.foreAccPeriodsField;
            }
            set {
                this.foreAccPeriodsField = value;
            }
        }
        
        /// <remarks/>
        public string ForeAccCompare {
            get {
                return this.foreAccCompareField;
            }
            set {
                this.foreAccCompareField = value;
            }
        }
        
        /// <remarks/>
        public bool ForeAccMovePeriods {
            get {
                return this.foreAccMovePeriodsField;
            }
            set {
                this.foreAccMovePeriodsField = value;
            }
        }
        
        /// <remarks/>
        public string ForeAccUse {
            get {
                return this.foreAccUseField;
            }
            set {
                this.foreAccUseField = value;
            }
        }
        
        /// <remarks/>
        public sbyte ForeAccNoSnap {
            get {
                return this.foreAccNoSnapField;
            }
            set {
                this.foreAccNoSnapField = value;
            }
        }
        
        /// <remarks/>
        public bool IncPrdNoFore {
            get {
                return this.incPrdNoForeField;
            }
            set {
                this.incPrdNoForeField = value;
            }
        }
        
        /// <remarks/>
        public bool OnlyIfDiff {
            get {
                return this.onlyIfDiffField;
            }
            set {
                this.onlyIfDiffField = value;
            }
        }
        
        /// <remarks/>
        public bool PercentDiff {
            get {
                return this.percentDiffField;
            }
            set {
                this.percentDiffField = value;
            }
        }
        
        /// <remarks/>
        public bool MonthsDiff {
            get {
                return this.monthsDiffField;
            }
            set {
                this.monthsDiffField = value;
            }
        }
        
        /// <remarks/>
        public Calendar Calendar {
            get {
                return this.calendarField;
            }
            set {
                this.calendarField = value;
            }
        }
        
        /// <remarks/>
        public bool IncMadeIn {
            get {
                return this.incMadeInField;
            }
            set {
                this.incMadeInField = value;
            }
        }
        
        /// <remarks/>
        public bool IncBoughtOut {
            get {
                return this.incBoughtOutField;
            }
            set {
                this.incBoughtOutField = value;
            }
        }
        
        /// <remarks/>
        public bool IncSubCon {
            get {
                return this.incSubConField;
            }
            set {
                this.incSubConField = value;
            }
        }
        
        /// <remarks/>
        public bool IncKit {
            get {
                return this.incKitField;
            }
            set {
                this.incKitField = value;
            }
        }
        
        /// <remarks/>
        public bool IncCoProd {
            get {
                return this.incCoProdField;
            }
            set {
                this.incCoProdField = value;
            }
        }
        
        /// <remarks/>
        public bool IncByProd {
            get {
                return this.incByProdField;
            }
            set {
                this.incByProdField = value;
            }
        }
        
        /// <remarks/>
        public bool IncludeAbcA {
            get {
                return this.includeAbcAField;
            }
            set {
                this.includeAbcAField = value;
            }
        }
        
        /// <remarks/>
        public bool IncludeAbcB {
            get {
                return this.includeAbcBField;
            }
            set {
                this.includeAbcBField = value;
            }
        }
        
        /// <remarks/>
        public bool IncludeAbcC {
            get {
                return this.includeAbcCField;
            }
            set {
                this.includeAbcCField = value;
            }
        }
        
        /// <remarks/>
        public bool IncludeAbcD {
            get {
                return this.includeAbcDField;
            }
            set {
                this.includeAbcDField = value;
            }
        }
        
        /// <remarks/>
        public bool IncludeAbcE {
            get {
                return this.includeAbcEField;
            }
            set {
                this.includeAbcEField = value;
            }
        }
        
        /// <remarks/>
        public bool IncludeAbcNone {
            get {
                return this.includeAbcNoneField;
            }
            set {
                this.includeAbcNoneField = value;
            }
        }
        
        /// <remarks/>
        public string AbcType {
            get {
                return this.abcTypeField;
            }
            set {
                this.abcTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool AbcLevel {
            get {
                return this.abcLevelField;
            }
            set {
                this.abcLevelField = value;
            }
        }
        
        /// <remarks/>
        public bool ManualForecast {
            get {
                return this.manualForecastField;
            }
            set {
                this.manualForecastField = value;
            }
        }
        
        /// <remarks/>
        public bool ReplenishItem {
            get {
                return this.replenishItemField;
            }
            set {
                this.replenishItemField = value;
            }
        }
        
        /// <remarks/>
        public bool IncMps {
            get {
                return this.incMpsField;
            }
            set {
                this.incMpsField = value;
            }
        }
        
        /// <remarks/>
        public bool IncMto {
            get {
                return this.incMtoField;
            }
            set {
                this.incMtoField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseSel {
            get {
                return this.warehouseSelField;
            }
            set {
                this.warehouseSelField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseFrom {
            get {
                return this.warehouseFromField;
            }
            set {
                this.warehouseFromField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseTo {
            get {
                return this.warehouseToField;
            }
            set {
                this.warehouseToField = value;
            }
        }
        
        /// <remarks/>
        public string WarehouseList {
            get {
                return this.warehouseListField;
            }
            set {
                this.warehouseListField = value;
            }
        }
        
        /// <remarks/>
        public string StockSel {
            get {
                return this.stockSelField;
            }
            set {
                this.stockSelField = value;
            }
        }
        
        /// <remarks/>
        public string StockFrom {
            get {
                return this.stockFromField;
            }
            set {
                this.stockFromField = value;
            }
        }
        
        /// <remarks/>
        public string StockTo {
            get {
                return this.stockToField;
            }
            set {
                this.stockToField = value;
            }
        }
        
        /// <remarks/>
        public string StockList {
            get {
                return this.stockListField;
            }
            set {
                this.stockListField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierSel {
            get {
                return this.supplierSelField;
            }
            set {
                this.supplierSelField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierFrom {
            get {
                return this.supplierFromField;
            }
            set {
                this.supplierFromField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierTo {
            get {
                return this.supplierToField;
            }
            set {
                this.supplierToField = value;
            }
        }
        
        /// <remarks/>
        public string SupplierList {
            get {
                return this.supplierListField;
            }
            set {
                this.supplierListField = value;
            }
        }
        
        /// <remarks/>
        public string ProdClassSel {
            get {
                return this.prodClassSelField;
            }
            set {
                this.prodClassSelField = value;
            }
        }
        
        /// <remarks/>
        public string ProdClassFrom {
            get {
                return this.prodClassFromField;
            }
            set {
                this.prodClassFromField = value;
            }
        }
        
        /// <remarks/>
        public string ProdClassTo {
            get {
                return this.prodClassToField;
            }
            set {
                this.prodClassToField = value;
            }
        }
        
        /// <remarks/>
        public string ProdClassList {
            get {
                return this.prodClassListField;
            }
            set {
                this.prodClassListField = value;
            }
        }
        
        /// <remarks/>
        public string PlannerSel {
            get {
                return this.plannerSelField;
            }
            set {
                this.plannerSelField = value;
            }
        }
        
        /// <remarks/>
        public string PlannerFrom {
            get {
                return this.plannerFromField;
            }
            set {
                this.plannerFromField = value;
            }
        }
        
        /// <remarks/>
        public string PlannerTo {
            get {
                return this.plannerToField;
            }
            set {
                this.plannerToField = value;
            }
        }
        
        /// <remarks/>
        public string PlannerList {
            get {
                return this.plannerListField;
            }
            set {
                this.plannerListField = value;
            }
        }
        
        /// <remarks/>
        public string BuyerSel {
            get {
                return this.buyerSelField;
            }
            set {
                this.buyerSelField = value;
            }
        }
        
        /// <remarks/>
        public string BuyerFrom {
            get {
                return this.buyerFromField;
            }
            set {
                this.buyerFromField = value;
            }
        }
        
        /// <remarks/>
        public string BuyerTo {
            get {
                return this.buyerToField;
            }
            set {
                this.buyerToField = value;
            }
        }
        
        /// <remarks/>
        public string BuyerList {
            get {
                return this.buyerListField;
            }
            set {
                this.buyerListField = value;
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
        
        private string selectionSetField;
        
        /// <remarks/>
        public string SelectionSet {
            get {
                return this.selectionSetField;
            }
            set {
                this.selectionSetField = value;
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
    public partial class SetupIOSelectionSetsMaintenance {
        
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
