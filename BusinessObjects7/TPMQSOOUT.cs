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
namespace SYSPRO.NET.BusinessObjects.TPMQSOOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class TradePromotionOptions {
        
        private TradePromotionOptionsCompany companyField;
        
        private TradePromotionOptionsGeneral generalField;
        
        private TradePromotionOptionsOptions optionsField;
        
        private TradePromotionOptionsDefaults defaultsField;
        
        private TradePromotionOptionsHistory historyField;
        
        private TradePromotionOptionsQualifications qualificationsField;
        
        private string languageField;
        
        private string language2Field;
        
        private string cssStyleField;
        
        private string decFormatField;
        
        private string dateFormatField;
        
        private string roleField;
        
        private string versionField;
        
        private string operatorPrimaryRoleField;
        
        /// <remarks/>
        public TradePromotionOptionsCompany Company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }
        
        /// <remarks/>
        public TradePromotionOptionsGeneral General {
            get {
                return this.generalField;
            }
            set {
                this.generalField = value;
            }
        }
        
        /// <remarks/>
        public TradePromotionOptionsOptions Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        public TradePromotionOptionsDefaults Defaults {
            get {
                return this.defaultsField;
            }
            set {
                this.defaultsField = value;
            }
        }
        
        /// <remarks/>
        public TradePromotionOptionsHistory History {
            get {
                return this.historyField;
            }
            set {
                this.historyField = value;
            }
        }
        
        /// <remarks/>
        public TradePromotionOptionsQualifications Qualifications {
            get {
                return this.qualificationsField;
            }
            set {
                this.qualificationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language {
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
        public string DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role {
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
    public partial class TradePromotionOptionsCompany {
        
        private string companyIdField;
        
        /// <remarks/>
        public string CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TradePromotionOptionsGeneral {
        
        private string nextTpmRefNumField;
        
        private string defTextDedAmountField;
        
        private string textForFreeGoodsField;
        
        private string nextTpmJnlField;
        
        private string dedDebitDateField;
        
        private string applyTpmCrCheckField;
        
        private string kitCompGblPromField;
        
        /// <remarks/>
        public string NextTpmRefNum {
            get {
                return this.nextTpmRefNumField;
            }
            set {
                this.nextTpmRefNumField = value;
            }
        }
        
        /// <remarks/>
        public string DefTextDedAmount {
            get {
                return this.defTextDedAmountField;
            }
            set {
                this.defTextDedAmountField = value;
            }
        }
        
        /// <remarks/>
        public string TextForFreeGoods {
            get {
                return this.textForFreeGoodsField;
            }
            set {
                this.textForFreeGoodsField = value;
            }
        }
        
        /// <remarks/>
        public string NextTpmJnl {
            get {
                return this.nextTpmJnlField;
            }
            set {
                this.nextTpmJnlField = value;
            }
        }
        
        /// <remarks/>
        public string DedDebitDate {
            get {
                return this.dedDebitDateField;
            }
            set {
                this.dedDebitDateField = value;
            }
        }
        
        /// <remarks/>
        public string ApplyTpmCrCheck {
            get {
                return this.applyTpmCrCheckField;
            }
            set {
                this.applyTpmCrCheckField = value;
            }
        }
        
        /// <remarks/>
        public string KitCompGblProm {
            get {
                return this.kitCompGblPromField;
            }
            set {
                this.kitCompGblPromField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TradePromotionOptionsOptions {
        
        private string autoSelLinePromField;
        
        private string autoSelGblPromField;
        
        private string autoShipLineFreeGdsField;
        
        private string autoShipGblFreeGdsField;
        
        private string chkSOPromField;
        
        private string allowSelGblPromField;
        
        private string applySODiscTpmCustField;
        
        private string creditAccrualsInvoicesField;
        
        private string creditOffInvLinesFromInvoicesField;
        
        private string excludeFGLinesFromInvDiscField;
        
        private string excludeSingleQualLinesFromInvDiscField;
        
        private string setMiscCostToZeroField;
        
        private string allowMaintOfMiscCostField;
        
        private string reactivatePromotionUtilizationReducedField;
        
        private string applyPromotionIfLimitExceededField;
        
        /// <remarks/>
        public string AutoSelLineProm {
            get {
                return this.autoSelLinePromField;
            }
            set {
                this.autoSelLinePromField = value;
            }
        }
        
        /// <remarks/>
        public string AutoSelGblProm {
            get {
                return this.autoSelGblPromField;
            }
            set {
                this.autoSelGblPromField = value;
            }
        }
        
        /// <remarks/>
        public string AutoShipLineFreeGds {
            get {
                return this.autoShipLineFreeGdsField;
            }
            set {
                this.autoShipLineFreeGdsField = value;
            }
        }
        
        /// <remarks/>
        public string AutoShipGblFreeGds {
            get {
                return this.autoShipGblFreeGdsField;
            }
            set {
                this.autoShipGblFreeGdsField = value;
            }
        }
        
        /// <remarks/>
        public string ChkSOProm {
            get {
                return this.chkSOPromField;
            }
            set {
                this.chkSOPromField = value;
            }
        }
        
        /// <remarks/>
        public string AllowSelGblProm {
            get {
                return this.allowSelGblPromField;
            }
            set {
                this.allowSelGblPromField = value;
            }
        }
        
        /// <remarks/>
        public string ApplySODiscTpmCust {
            get {
                return this.applySODiscTpmCustField;
            }
            set {
                this.applySODiscTpmCustField = value;
            }
        }
        
        /// <remarks/>
        public string CreditAccrualsInvoices {
            get {
                return this.creditAccrualsInvoicesField;
            }
            set {
                this.creditAccrualsInvoicesField = value;
            }
        }
        
        /// <remarks/>
        public string CreditOffInvLinesFromInvoices {
            get {
                return this.creditOffInvLinesFromInvoicesField;
            }
            set {
                this.creditOffInvLinesFromInvoicesField = value;
            }
        }
        
        /// <remarks/>
        public string ExcludeFGLinesFromInvDisc {
            get {
                return this.excludeFGLinesFromInvDiscField;
            }
            set {
                this.excludeFGLinesFromInvDiscField = value;
            }
        }
        
        /// <remarks/>
        public string ExcludeSingleQualLinesFromInvDisc {
            get {
                return this.excludeSingleQualLinesFromInvDiscField;
            }
            set {
                this.excludeSingleQualLinesFromInvDiscField = value;
            }
        }
        
        /// <remarks/>
        public string SetMiscCostToZero {
            get {
                return this.setMiscCostToZeroField;
            }
            set {
                this.setMiscCostToZeroField = value;
            }
        }
        
        /// <remarks/>
        public string AllowMaintOfMiscCost {
            get {
                return this.allowMaintOfMiscCostField;
            }
            set {
                this.allowMaintOfMiscCostField = value;
            }
        }
        
        /// <remarks/>
        public string ReactivatePromotionUtilizationReduced {
            get {
                return this.reactivatePromotionUtilizationReducedField;
            }
            set {
                this.reactivatePromotionUtilizationReducedField = value;
            }
        }
        
        /// <remarks/>
        public string ApplyPromotionIfLimitExceeded {
            get {
                return this.applyPromotionIfLimitExceededField;
            }
            set {
                this.applyPromotionIfLimitExceededField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TradePromotionOptionsDefaults {
        
        private string defDedCodeField;
        
        private string defOffInvLineProdClsField;
        
        private string defOffInvGlobalProdClsField;
        
        private string freeGdsUseMerchProdClsField;
        
        private string offInvUseMerchProdClsField;
        
        private string defDedResCodeNormalField;
        
        private string defDedResCodeWoffField;
        
        private string defDedResCodeMatchField;
        
        private string promTaxDefTaxCodeField;
        
        private string promUseMerchLinTaxCodeField;
        
        private string promTaxDefGstCodeField;
        
        private string promUseMerchLinGSTCodeField;
        
        private string dedTaxInclDedAccrField;
        
        private string dedTaxDefTaxCodeField;
        
        private string dedTaxCodeDefGstCodeField;
        
        private string accrualTaxField;
        
        private string taxPromoLevelField;
        
        /// <remarks/>
        public string DefDedCode {
            get {
                return this.defDedCodeField;
            }
            set {
                this.defDedCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DefOffInvLineProdCls {
            get {
                return this.defOffInvLineProdClsField;
            }
            set {
                this.defOffInvLineProdClsField = value;
            }
        }
        
        /// <remarks/>
        public string DefOffInvGlobalProdCls {
            get {
                return this.defOffInvGlobalProdClsField;
            }
            set {
                this.defOffInvGlobalProdClsField = value;
            }
        }
        
        /// <remarks/>
        public string FreeGdsUseMerchProdCls {
            get {
                return this.freeGdsUseMerchProdClsField;
            }
            set {
                this.freeGdsUseMerchProdClsField = value;
            }
        }
        
        /// <remarks/>
        public string OffInvUseMerchProdCls {
            get {
                return this.offInvUseMerchProdClsField;
            }
            set {
                this.offInvUseMerchProdClsField = value;
            }
        }
        
        /// <remarks/>
        public string DefDedResCodeNormal {
            get {
                return this.defDedResCodeNormalField;
            }
            set {
                this.defDedResCodeNormalField = value;
            }
        }
        
        /// <remarks/>
        public string DefDedResCodeWoff {
            get {
                return this.defDedResCodeWoffField;
            }
            set {
                this.defDedResCodeWoffField = value;
            }
        }
        
        /// <remarks/>
        public string DefDedResCodeMatch {
            get {
                return this.defDedResCodeMatchField;
            }
            set {
                this.defDedResCodeMatchField = value;
            }
        }
        
        /// <remarks/>
        public string PromTaxDefTaxCode {
            get {
                return this.promTaxDefTaxCodeField;
            }
            set {
                this.promTaxDefTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PromUseMerchLinTaxCode {
            get {
                return this.promUseMerchLinTaxCodeField;
            }
            set {
                this.promUseMerchLinTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PromTaxDefGstCode {
            get {
                return this.promTaxDefGstCodeField;
            }
            set {
                this.promTaxDefGstCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PromUseMerchLinGSTCode {
            get {
                return this.promUseMerchLinGSTCodeField;
            }
            set {
                this.promUseMerchLinGSTCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DedTaxInclDedAccr {
            get {
                return this.dedTaxInclDedAccrField;
            }
            set {
                this.dedTaxInclDedAccrField = value;
            }
        }
        
        /// <remarks/>
        public string DedTaxDefTaxCode {
            get {
                return this.dedTaxDefTaxCodeField;
            }
            set {
                this.dedTaxDefTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DedTaxCodeDefGstCode {
            get {
                return this.dedTaxCodeDefGstCodeField;
            }
            set {
                this.dedTaxCodeDefGstCodeField = value;
            }
        }
        
        /// <remarks/>
        public string AccrualTax {
            get {
                return this.accrualTaxField;
            }
            set {
                this.accrualTaxField = value;
            }
        }
        
        /// <remarks/>
        public string TaxPromoLevel {
            get {
                return this.taxPromoLevelField;
            }
            set {
                this.taxPromoLevelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TradePromotionOptionsHistory {
        
        private string daysRetExpPromField;
        
        /// <remarks/>
        public string DaysRetExpProm {
            get {
                return this.daysRetExpPromField;
            }
            set {
                this.daysRetExpPromField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TradePromotionOptionsQualifications {
        
        private string stockQualification1Field;
        
        private string stockQualification2Field;
        
        private string customerQualification1Field;
        
        private string customerQualification2Field;
        
        /// <remarks/>
        public string StockQualification1 {
            get {
                return this.stockQualification1Field;
            }
            set {
                this.stockQualification1Field = value;
            }
        }
        
        /// <remarks/>
        public string StockQualification2 {
            get {
                return this.stockQualification2Field;
            }
            set {
                this.stockQualification2Field = value;
            }
        }
        
        /// <remarks/>
        public string CustomerQualification1 {
            get {
                return this.customerQualification1Field;
            }
            set {
                this.customerQualification1Field = value;
            }
        }
        
        /// <remarks/>
        public string CustomerQualification2 {
            get {
                return this.customerQualification2Field;
            }
            set {
                this.customerQualification2Field = value;
            }
        }
    }
}
