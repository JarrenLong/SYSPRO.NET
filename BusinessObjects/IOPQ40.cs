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
namespace SYSPRO.NET.BusinessObjects.IOPQ40 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum AnalysisType {
        
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Buyer {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Filter {
        
        private StockCode stockCodeField;
        
        private Warehouse warehouseField;
        
        private Planner plannerField;
        
        private Buyer buyerField;
        
        private Supplier supplierField;
        
        private ProductClass productClassField;
        
        private string[] textField;
        
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
        public Warehouse Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
            }
        }
        
        /// <remarks/>
        public Planner Planner {
            get {
                return this.plannerField;
            }
            set {
                this.plannerField = value;
            }
        }
        
        /// <remarks/>
        public Buyer Buyer {
            get {
                return this.buyerField;
            }
            set {
                this.buyerField = value;
            }
        }
        
        /// <remarks/>
        public Supplier Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
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
    public partial class StockCode {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Warehouse {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Planner {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Supplier {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ProductClass {
        
        private string filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterType {
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeClassItemsA {
        
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
    public enum IncludeClassItemsB {
        
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
    public enum IncludeClassItemsC {
        
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
    public enum IncludeClassItemsD {
        
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
    public enum IncludeMakeToOrderItems {
        
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
    public enum IncludeManuallyForecastItems {
        
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
    public enum IncludeMasterProductionScheduledItems {
        
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
    public enum IncludeNoMovementClassItemsE {
        
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
    public enum IncludeNonCurrentPolicies {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        O,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludePartTypeBoughtOut {
        
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
    public enum IncludePartTypeByProduct {
        
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
    public enum IncludePartTypeCoProduct {
        
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
    public enum IncludePartTypeKitPart {
        
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
    public enum IncludePartTypeMadeIn {
        
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
    public enum IncludePartTypeSubcontracted {
        
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
    public enum IncludeReplenishmentItems {
        
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
    public enum IncludeUnclassifiedItems {
        
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
        
        private UseSelectionSet useSelectionSetField;
        
        private bool useSelectionSetFieldSpecified;
        
        private string selectionSetField;
        
        private IncludePartTypeMadeIn includePartTypeMadeInField;
        
        private bool includePartTypeMadeInFieldSpecified;
        
        private IncludePartTypeBoughtOut includePartTypeBoughtOutField;
        
        private bool includePartTypeBoughtOutFieldSpecified;
        
        private IncludePartTypeSubcontracted includePartTypeSubcontractedField;
        
        private bool includePartTypeSubcontractedFieldSpecified;
        
        private IncludePartTypeKitPart includePartTypeKitPartField;
        
        private bool includePartTypeKitPartFieldSpecified;
        
        private IncludePartTypeCoProduct includePartTypeCoProductField;
        
        private bool includePartTypeCoProductFieldSpecified;
        
        private IncludePartTypeByProduct includePartTypeByProductField;
        
        private bool includePartTypeByProductFieldSpecified;
        
        private IncludeClassItemsA includeClassItemsAField;
        
        private bool includeClassItemsAFieldSpecified;
        
        private IncludeClassItemsB includeClassItemsBField;
        
        private bool includeClassItemsBFieldSpecified;
        
        private IncludeClassItemsC includeClassItemsCField;
        
        private bool includeClassItemsCFieldSpecified;
        
        private IncludeClassItemsD includeClassItemsDField;
        
        private bool includeClassItemsDFieldSpecified;
        
        private IncludeNoMovementClassItemsE includeNoMovementClassItemsEField;
        
        private bool includeNoMovementClassItemsEFieldSpecified;
        
        private IncludeUnclassifiedItems includeUnclassifiedItemsField;
        
        private bool includeUnclassifiedItemsFieldSpecified;
        
        private AnalysisType analysisTypeField;
        
        private bool analysisTypeFieldSpecified;
        
        private ParetoLevel paretoLevelField;
        
        private bool paretoLevelFieldSpecified;
        
        private IncludeManuallyForecastItems includeManuallyForecastItemsField;
        
        private bool includeManuallyForecastItemsFieldSpecified;
        
        private IncludeReplenishmentItems includeReplenishmentItemsField;
        
        private bool includeReplenishmentItemsFieldSpecified;
        
        private IncludeMasterProductionScheduledItems includeMasterProductionScheduledItemsField;
        
        private bool includeMasterProductionScheduledItemsFieldSpecified;
        
        private IncludeMakeToOrderItems includeMakeToOrderItemsField;
        
        private bool includeMakeToOrderItemsFieldSpecified;
        
        private IncludeNonCurrentPolicies includeNonCurrentPoliciesField;
        
        private bool includeNonCurrentPoliciesFieldSpecified;
        
        private System.DateTime runDateField;
        
        private bool runDateFieldSpecified;
        
        private string xslStylesheetField;
        
        public Option() {
            this.useSelectionSetField = UseSelectionSet.N;
            this.includePartTypeMadeInField = IncludePartTypeMadeIn.Y;
            this.includePartTypeBoughtOutField = IncludePartTypeBoughtOut.Y;
            this.includePartTypeSubcontractedField = IncludePartTypeSubcontracted.Y;
            this.includePartTypeKitPartField = IncludePartTypeKitPart.Y;
            this.includePartTypeCoProductField = IncludePartTypeCoProduct.Y;
            this.includePartTypeByProductField = IncludePartTypeByProduct.Y;
            this.includeClassItemsAField = IncludeClassItemsA.Y;
            this.includeClassItemsBField = IncludeClassItemsB.Y;
            this.includeClassItemsCField = IncludeClassItemsC.Y;
            this.includeClassItemsDField = IncludeClassItemsD.Y;
            this.includeNoMovementClassItemsEField = IncludeNoMovementClassItemsE.Y;
            this.includeUnclassifiedItemsField = IncludeUnclassifiedItems.Y;
            this.analysisTypeField = AnalysisType.S;
            this.paretoLevelField = ParetoLevel.Item1;
            this.includeManuallyForecastItemsField = IncludeManuallyForecastItems.Y;
            this.includeReplenishmentItemsField = IncludeReplenishmentItems.Y;
            this.includeMasterProductionScheduledItemsField = IncludeMasterProductionScheduledItems.Y;
            this.includeMakeToOrderItemsField = IncludeMakeToOrderItems.Y;
            this.includeNonCurrentPoliciesField = IncludeNonCurrentPolicies.N;
        }
        
        /// <remarks/>
        public UseSelectionSet UseSelectionSet {
            get {
                return this.useSelectionSetField;
            }
            set {
                this.useSelectionSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UseSelectionSetSpecified {
            get {
                return this.useSelectionSetFieldSpecified;
            }
            set {
                this.useSelectionSetFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string SelectionSet {
            get {
                return this.selectionSetField;
            }
            set {
                this.selectionSetField = value;
            }
        }
        
        /// <remarks/>
        public IncludePartTypeMadeIn IncludePartTypeMadeIn {
            get {
                return this.includePartTypeMadeInField;
            }
            set {
                this.includePartTypeMadeInField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludePartTypeMadeInSpecified {
            get {
                return this.includePartTypeMadeInFieldSpecified;
            }
            set {
                this.includePartTypeMadeInFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludePartTypeBoughtOut IncludePartTypeBoughtOut {
            get {
                return this.includePartTypeBoughtOutField;
            }
            set {
                this.includePartTypeBoughtOutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludePartTypeBoughtOutSpecified {
            get {
                return this.includePartTypeBoughtOutFieldSpecified;
            }
            set {
                this.includePartTypeBoughtOutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludePartTypeSubcontracted IncludePartTypeSubcontracted {
            get {
                return this.includePartTypeSubcontractedField;
            }
            set {
                this.includePartTypeSubcontractedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludePartTypeSubcontractedSpecified {
            get {
                return this.includePartTypeSubcontractedFieldSpecified;
            }
            set {
                this.includePartTypeSubcontractedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludePartTypeKitPart IncludePartTypeKitPart {
            get {
                return this.includePartTypeKitPartField;
            }
            set {
                this.includePartTypeKitPartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludePartTypeKitPartSpecified {
            get {
                return this.includePartTypeKitPartFieldSpecified;
            }
            set {
                this.includePartTypeKitPartFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludePartTypeCoProduct IncludePartTypeCoProduct {
            get {
                return this.includePartTypeCoProductField;
            }
            set {
                this.includePartTypeCoProductField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludePartTypeCoProductSpecified {
            get {
                return this.includePartTypeCoProductFieldSpecified;
            }
            set {
                this.includePartTypeCoProductFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludePartTypeByProduct IncludePartTypeByProduct {
            get {
                return this.includePartTypeByProductField;
            }
            set {
                this.includePartTypeByProductField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludePartTypeByProductSpecified {
            get {
                return this.includePartTypeByProductFieldSpecified;
            }
            set {
                this.includePartTypeByProductFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeClassItemsA IncludeClassItemsA {
            get {
                return this.includeClassItemsAField;
            }
            set {
                this.includeClassItemsAField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeClassItemsASpecified {
            get {
                return this.includeClassItemsAFieldSpecified;
            }
            set {
                this.includeClassItemsAFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeClassItemsB IncludeClassItemsB {
            get {
                return this.includeClassItemsBField;
            }
            set {
                this.includeClassItemsBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeClassItemsBSpecified {
            get {
                return this.includeClassItemsBFieldSpecified;
            }
            set {
                this.includeClassItemsBFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeClassItemsC IncludeClassItemsC {
            get {
                return this.includeClassItemsCField;
            }
            set {
                this.includeClassItemsCField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeClassItemsCSpecified {
            get {
                return this.includeClassItemsCFieldSpecified;
            }
            set {
                this.includeClassItemsCFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeClassItemsD IncludeClassItemsD {
            get {
                return this.includeClassItemsDField;
            }
            set {
                this.includeClassItemsDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeClassItemsDSpecified {
            get {
                return this.includeClassItemsDFieldSpecified;
            }
            set {
                this.includeClassItemsDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeNoMovementClassItemsE IncludeNoMovementClassItemsE {
            get {
                return this.includeNoMovementClassItemsEField;
            }
            set {
                this.includeNoMovementClassItemsEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeNoMovementClassItemsESpecified {
            get {
                return this.includeNoMovementClassItemsEFieldSpecified;
            }
            set {
                this.includeNoMovementClassItemsEFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeUnclassifiedItems IncludeUnclassifiedItems {
            get {
                return this.includeUnclassifiedItemsField;
            }
            set {
                this.includeUnclassifiedItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeUnclassifiedItemsSpecified {
            get {
                return this.includeUnclassifiedItemsFieldSpecified;
            }
            set {
                this.includeUnclassifiedItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public AnalysisType AnalysisType {
            get {
                return this.analysisTypeField;
            }
            set {
                this.analysisTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnalysisTypeSpecified {
            get {
                return this.analysisTypeFieldSpecified;
            }
            set {
                this.analysisTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ParetoLevel ParetoLevel {
            get {
                return this.paretoLevelField;
            }
            set {
                this.paretoLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ParetoLevelSpecified {
            get {
                return this.paretoLevelFieldSpecified;
            }
            set {
                this.paretoLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeManuallyForecastItems IncludeManuallyForecastItems {
            get {
                return this.includeManuallyForecastItemsField;
            }
            set {
                this.includeManuallyForecastItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeManuallyForecastItemsSpecified {
            get {
                return this.includeManuallyForecastItemsFieldSpecified;
            }
            set {
                this.includeManuallyForecastItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeReplenishmentItems IncludeReplenishmentItems {
            get {
                return this.includeReplenishmentItemsField;
            }
            set {
                this.includeReplenishmentItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeReplenishmentItemsSpecified {
            get {
                return this.includeReplenishmentItemsFieldSpecified;
            }
            set {
                this.includeReplenishmentItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMasterProductionScheduledItems IncludeMasterProductionScheduledItems {
            get {
                return this.includeMasterProductionScheduledItemsField;
            }
            set {
                this.includeMasterProductionScheduledItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMasterProductionScheduledItemsSpecified {
            get {
                return this.includeMasterProductionScheduledItemsFieldSpecified;
            }
            set {
                this.includeMasterProductionScheduledItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMakeToOrderItems IncludeMakeToOrderItems {
            get {
                return this.includeMakeToOrderItemsField;
            }
            set {
                this.includeMakeToOrderItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMakeToOrderItemsSpecified {
            get {
                return this.includeMakeToOrderItemsFieldSpecified;
            }
            set {
                this.includeMakeToOrderItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeNonCurrentPolicies IncludeNonCurrentPolicies {
            get {
                return this.includeNonCurrentPoliciesField;
            }
            set {
                this.includeNonCurrentPoliciesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeNonCurrentPoliciesSpecified {
            get {
                return this.includeNonCurrentPoliciesFieldSpecified;
            }
            set {
                this.includeNonCurrentPoliciesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime RunDate {
            get {
                return this.runDateField;
            }
            set {
                this.runDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RunDateSpecified {
            get {
                return this.runDateFieldSpecified;
            }
            set {
                this.runDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string XslStylesheet {
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
    public enum UseSelectionSet {
        
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
    public enum ParetoLevel {
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private Option optionField;
        
        private Filter filterField;
        
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
