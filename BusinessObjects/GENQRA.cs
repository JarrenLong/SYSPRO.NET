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
namespace SYSPRO.NET.BusinessObjects.GENQRA {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Filter", typeof(QueryFilter))]
        [System.Xml.Serialization.XmlElementAttribute("Option", typeof(QueryOption))]
        public object[] Items {
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
    public partial class QueryFilter {
        
        private GlYear glYearField;
        
        private GlPeriod glPeriodField;
        
        private GlGroup glGroupField;
        
        private GlCode glCodeField;
        
        /// <remarks/>
        public GlYear GlYear {
            get {
                return this.glYearField;
            }
            set {
                this.glYearField = value;
            }
        }
        
        /// <remarks/>
        public GlPeriod GlPeriod {
            get {
                return this.glPeriodField;
            }
            set {
                this.glPeriodField = value;
            }
        }
        
        /// <remarks/>
        public GlGroup GlGroup {
            get {
                return this.glGroupField;
            }
            set {
                this.glGroupField = value;
            }
        }
        
        /// <remarks/>
        public GlCode GlCode {
            get {
                return this.glCodeField;
            }
            set {
                this.glCodeField = value;
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
    public partial class GlYear {
        
        private GlYearFilterType filterTypeField;
        
        private string filterValueField;
        
        public GlYear() {
            this.filterTypeField = GlYearFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(GlYearFilterType.A)]
        public GlYearFilterType FilterType {
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
    public enum GlYearFilterType {
        
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
    public partial class GlPeriod {
        
        private GlPeriodFilterType filterTypeField;
        
        private string filterValueField;
        
        public GlPeriod() {
            this.filterTypeField = GlPeriodFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(GlPeriodFilterType.A)]
        public GlPeriodFilterType FilterType {
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
    public enum GlPeriodFilterType {
        
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
    public partial class GlGroup {
        
        private GlGroupFilterType filterTypeField;
        
        private string filterValueField;
        
        public GlGroup() {
            this.filterTypeField = GlGroupFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(GlGroupFilterType.A)]
        public GlGroupFilterType FilterType {
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
    public enum GlGroupFilterType {
        
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
    public partial class GlCode {
        
        private GlCodeFilterType filterTypeField;
        
        private string filterValueField;
        
        public GlCode() {
            this.filterTypeField = GlCodeFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(GlCodeFilterType.A)]
        public GlCodeFilterType FilterType {
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
    public enum GlCodeFilterType {
        
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
    public partial class QueryOption {
        
        private IncludeCurrentRatio includeCurrentRatioField;
        
        private IncludeQuickRatio includeQuickRatioField;
        
        private IncludePayablesTurnover includePayablesTurnoverField;
        
        private IncludeReceivablesTurnover includeReceivablesTurnoverField;
        
        private IncludeInventoryTurnover includeInventoryTurnoverField;
        
        private IncludeNonCurrentAssetTurnover includeNonCurrentAssetTurnoverField;
        
        private IncludeTotalAssetTurnover includeTotalAssetTurnoverField;
        
        private IncludeLeverage includeLeverageField;
        
        private IncludeGearing includeGearingField;
        
        private IncludeNetProfitMargin includeNetProfitMarginField;
        
        private IncludeReturnOnAssets includeReturnOnAssetsField;
        
        private IncludeReturnOnEquity includeReturnOnEquityField;
        
        private IncludeDebtRatio includeDebtRatioField;
        
        private IncludeDebtEquity includeDebtEquityField;
        
        private IncludeFormulaDetail includeFormulaDetailField;
        
        private IncludeAccountDetail includeAccountDetailField;
        
        private IncludePeriodDetail includePeriodDetailField;
        
        private object includeAllPeriodCurrBudField;
        
        private IncludeCurrentBudget includeCurrentBudgetField;
        
        private IncludeNextBudget includeNextBudgetField;
        
        private IncludeAlternateBudget1 includeAlternateBudget1Field;
        
        private IncludeAlternateBudget2 includeAlternateBudget2Field;
        
        private IncludeAlternateBudget3 includeAlternateBudget3Field;
        
        private IncludeAlternateBudget4 includeAlternateBudget4Field;
        
        private IncludeAlternateBudget5 includeAlternateBudget5Field;
        
        private IncludeAlternateBudget6 includeAlternateBudget6Field;
        
        private IncludeAlternateBudget7 includeAlternateBudget7Field;
        
        private IncludeAlternateBudget8 includeAlternateBudget8Field;
        
        private object xslStylesheetField;
        
        /// <remarks/>
        public IncludeCurrentRatio IncludeCurrentRatio {
            get {
                return this.includeCurrentRatioField;
            }
            set {
                this.includeCurrentRatioField = value;
            }
        }
        
        /// <remarks/>
        public IncludeQuickRatio IncludeQuickRatio {
            get {
                return this.includeQuickRatioField;
            }
            set {
                this.includeQuickRatioField = value;
            }
        }
        
        /// <remarks/>
        public IncludePayablesTurnover IncludePayablesTurnover {
            get {
                return this.includePayablesTurnoverField;
            }
            set {
                this.includePayablesTurnoverField = value;
            }
        }
        
        /// <remarks/>
        public IncludeReceivablesTurnover IncludeReceivablesTurnover {
            get {
                return this.includeReceivablesTurnoverField;
            }
            set {
                this.includeReceivablesTurnoverField = value;
            }
        }
        
        /// <remarks/>
        public IncludeInventoryTurnover IncludeInventoryTurnover {
            get {
                return this.includeInventoryTurnoverField;
            }
            set {
                this.includeInventoryTurnoverField = value;
            }
        }
        
        /// <remarks/>
        public IncludeNonCurrentAssetTurnover IncludeNonCurrentAssetTurnover {
            get {
                return this.includeNonCurrentAssetTurnoverField;
            }
            set {
                this.includeNonCurrentAssetTurnoverField = value;
            }
        }
        
        /// <remarks/>
        public IncludeTotalAssetTurnover IncludeTotalAssetTurnover {
            get {
                return this.includeTotalAssetTurnoverField;
            }
            set {
                this.includeTotalAssetTurnoverField = value;
            }
        }
        
        /// <remarks/>
        public IncludeLeverage IncludeLeverage {
            get {
                return this.includeLeverageField;
            }
            set {
                this.includeLeverageField = value;
            }
        }
        
        /// <remarks/>
        public IncludeGearing IncludeGearing {
            get {
                return this.includeGearingField;
            }
            set {
                this.includeGearingField = value;
            }
        }
        
        /// <remarks/>
        public IncludeNetProfitMargin IncludeNetProfitMargin {
            get {
                return this.includeNetProfitMarginField;
            }
            set {
                this.includeNetProfitMarginField = value;
            }
        }
        
        /// <remarks/>
        public IncludeReturnOnAssets IncludeReturnOnAssets {
            get {
                return this.includeReturnOnAssetsField;
            }
            set {
                this.includeReturnOnAssetsField = value;
            }
        }
        
        /// <remarks/>
        public IncludeReturnOnEquity IncludeReturnOnEquity {
            get {
                return this.includeReturnOnEquityField;
            }
            set {
                this.includeReturnOnEquityField = value;
            }
        }
        
        /// <remarks/>
        public IncludeDebtRatio IncludeDebtRatio {
            get {
                return this.includeDebtRatioField;
            }
            set {
                this.includeDebtRatioField = value;
            }
        }
        
        /// <remarks/>
        public IncludeDebtEquity IncludeDebtEquity {
            get {
                return this.includeDebtEquityField;
            }
            set {
                this.includeDebtEquityField = value;
            }
        }
        
        /// <remarks/>
        public IncludeFormulaDetail IncludeFormulaDetail {
            get {
                return this.includeFormulaDetailField;
            }
            set {
                this.includeFormulaDetailField = value;
            }
        }
        
        /// <remarks/>
        public IncludeAccountDetail IncludeAccountDetail {
            get {
                return this.includeAccountDetailField;
            }
            set {
                this.includeAccountDetailField = value;
            }
        }
        
        /// <remarks/>
        public IncludePeriodDetail IncludePeriodDetail {
            get {
                return this.includePeriodDetailField;
            }
            set {
                this.includePeriodDetailField = value;
            }
        }
        
        /// <remarks/>
        public object IncludeAllPeriodCurrBud {
            get {
                return this.includeAllPeriodCurrBudField;
            }
            set {
                this.includeAllPeriodCurrBudField = value;
            }
        }
        
        /// <remarks/>
        public IncludeCurrentBudget IncludeCurrentBudget {
            get {
                return this.includeCurrentBudgetField;
            }
            set {
                this.includeCurrentBudgetField = value;
            }
        }
        
        /// <remarks/>
        public IncludeNextBudget IncludeNextBudget {
            get {
                return this.includeNextBudgetField;
            }
            set {
                this.includeNextBudgetField = value;
            }
        }
        
        /// <remarks/>
        public IncludeAlternateBudget1 IncludeAlternateBudget1 {
            get {
                return this.includeAlternateBudget1Field;
            }
            set {
                this.includeAlternateBudget1Field = value;
            }
        }
        
        /// <remarks/>
        public IncludeAlternateBudget2 IncludeAlternateBudget2 {
            get {
                return this.includeAlternateBudget2Field;
            }
            set {
                this.includeAlternateBudget2Field = value;
            }
        }
        
        /// <remarks/>
        public IncludeAlternateBudget3 IncludeAlternateBudget3 {
            get {
                return this.includeAlternateBudget3Field;
            }
            set {
                this.includeAlternateBudget3Field = value;
            }
        }
        
        /// <remarks/>
        public IncludeAlternateBudget4 IncludeAlternateBudget4 {
            get {
                return this.includeAlternateBudget4Field;
            }
            set {
                this.includeAlternateBudget4Field = value;
            }
        }
        
        /// <remarks/>
        public IncludeAlternateBudget5 IncludeAlternateBudget5 {
            get {
                return this.includeAlternateBudget5Field;
            }
            set {
                this.includeAlternateBudget5Field = value;
            }
        }
        
        /// <remarks/>
        public IncludeAlternateBudget6 IncludeAlternateBudget6 {
            get {
                return this.includeAlternateBudget6Field;
            }
            set {
                this.includeAlternateBudget6Field = value;
            }
        }
        
        /// <remarks/>
        public IncludeAlternateBudget7 IncludeAlternateBudget7 {
            get {
                return this.includeAlternateBudget7Field;
            }
            set {
                this.includeAlternateBudget7Field = value;
            }
        }
        
        /// <remarks/>
        public IncludeAlternateBudget8 IncludeAlternateBudget8 {
            get {
                return this.includeAlternateBudget8Field;
            }
            set {
                this.includeAlternateBudget8Field = value;
            }
        }
        
        /// <remarks/>
        public object XslStylesheet {
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
    public enum IncludeCurrentRatio {
        
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
    public enum IncludeQuickRatio {
        
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
    public enum IncludePayablesTurnover {
        
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
    public enum IncludeReceivablesTurnover {
        
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
    public enum IncludeInventoryTurnover {
        
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
    public enum IncludeNonCurrentAssetTurnover {
        
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
    public enum IncludeTotalAssetTurnover {
        
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
    public enum IncludeLeverage {
        
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
    public enum IncludeGearing {
        
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
    public enum IncludeNetProfitMargin {
        
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
    public enum IncludeReturnOnAssets {
        
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
    public enum IncludeReturnOnEquity {
        
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
    public enum IncludeDebtRatio {
        
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
    public enum IncludeDebtEquity {
        
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
    public enum IncludeFormulaDetail {
        
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
    public enum IncludeAccountDetail {
        
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
    public enum IncludePeriodDetail {
        
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
    public enum IncludeCurrentBudget {
        
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
    public enum IncludeNextBudget {
        
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
    public enum IncludeAlternateBudget1 {
        
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
    public enum IncludeAlternateBudget2 {
        
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
    public enum IncludeAlternateBudget3 {
        
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
    public enum IncludeAlternateBudget4 {
        
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
    public enum IncludeAlternateBudget5 {
        
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
    public enum IncludeAlternateBudget6 {
        
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
    public enum IncludeAlternateBudget7 {
        
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
    public enum IncludeAlternateBudget8 {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
}
