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
namespace SYSPRO.NET.BusinessObjects.TPMQTNOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class TPMDetailQuery {
        
        private TPMDetailQueryQueryOptions queryOptionsField;
        
        private TPMDetailQueryPromotionDetail[] tPMDetailItemsField;
        
        private sbyte languageField;
        
        private string language2Field;
        
        private string cssStyleField;
        
        private bool decFormatField;
        
        private sbyte dateFormatField;
        
        private sbyte roleField;
        
        private string versionField;
        
        private string operatorPrimaryRoleField;
        
        /// <remarks/>
        public TPMDetailQueryQueryOptions QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PromotionDetail", IsNullable=false)]
        public TPMDetailQueryPromotionDetail[] TPMDetailItems {
            get {
                return this.tPMDetailItemsField;
            }
            set {
                this.tPMDetailItemsField = value;
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
    public partial class TPMDetailQueryQueryOptions {
        
        private string sequenceField;
        
        private string includeOffInvoicePromotionsField;
        
        private string includeAccrualPromotionsField;
        
        private string includeFreeGoodsPromotionsField;
        
        private string customerFilterTypeField;
        
        private TPMDetailQueryQueryOptionsCustomerFilterValue customerFilterValueField;
        
        private string promotionFilterTypeField;
        
        private TPMDetailQueryQueryOptionsPromotionFilterValue promotionFilterValueField;
        
        private string invoiceFilterTypeField;
        
        private TPMDetailQueryQueryOptionsInvoiceFilterValue invoiceFilterValueField;
        
        private string salesOrderFilterTypeField;
        
        private TPMDetailQueryQueryOptionsSalesOrderFilterValue salesOrderFilterValueField;
        
        private string stockCodeFilterTypeField;
        
        private TPMDetailQueryQueryOptionsStockCodeFilterValue stockCodeFilterValueField;
        
        /// <remarks/>
        public string Sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeOffInvoicePromotions {
            get {
                return this.includeOffInvoicePromotionsField;
            }
            set {
                this.includeOffInvoicePromotionsField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeAccrualPromotions {
            get {
                return this.includeAccrualPromotionsField;
            }
            set {
                this.includeAccrualPromotionsField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeFreeGoodsPromotions {
            get {
                return this.includeFreeGoodsPromotionsField;
            }
            set {
                this.includeFreeGoodsPromotionsField = value;
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
        public TPMDetailQueryQueryOptionsCustomerFilterValue CustomerFilterValue {
            get {
                return this.customerFilterValueField;
            }
            set {
                this.customerFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string PromotionFilterType {
            get {
                return this.promotionFilterTypeField;
            }
            set {
                this.promotionFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public TPMDetailQueryQueryOptionsPromotionFilterValue PromotionFilterValue {
            get {
                return this.promotionFilterValueField;
            }
            set {
                this.promotionFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string InvoiceFilterType {
            get {
                return this.invoiceFilterTypeField;
            }
            set {
                this.invoiceFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public TPMDetailQueryQueryOptionsInvoiceFilterValue InvoiceFilterValue {
            get {
                return this.invoiceFilterValueField;
            }
            set {
                this.invoiceFilterValueField = value;
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
        public TPMDetailQueryQueryOptionsSalesOrderFilterValue SalesOrderFilterValue {
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
        public TPMDetailQueryQueryOptionsStockCodeFilterValue StockCodeFilterValue {
            get {
                return this.stockCodeFilterValueField;
            }
            set {
                this.stockCodeFilterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TPMDetailQueryQueryOptionsCustomerFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TPMDetailQueryQueryOptionsPromotionFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TPMDetailQueryQueryOptionsInvoiceFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TPMDetailQueryQueryOptionsSalesOrderFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TPMDetailQueryQueryOptionsStockCodeFilterValue {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TPMDetailQueryPromotionDetail {
        
        private int invoiceField;
        
        private string invoiceLineField;
        
        private string promotionCodeField;
        
        private string promotionCodeDescField;
        
        private sbyte tpmSequenceField;
        
        private short salesOrderField;
        
        private string salesOrderLineField;
        
        private System.DateTime trnDateField;
        
        private System.DateTime trnTimeField;
        
        private sbyte customerField;
        
        private string customerNameField;
        
        private string transactionValueField;
        
        private TPMDetailQueryPromotionDetailPromotionType promotionTypeField;
        
        private TPMDetailQueryPromotionDetailGlobalflag globalflagField;
        
        private string originalPriceField;
        
        private string soChargeLineField;
        
        private byte[] stockCodeField;
        
        private string stockCodeDescField;
        
        private string longDescriptionField;
        
        private TPMDetailQueryPromotionDetailFreeGoodsStockCode freeGoodsStockCodeField;
        
        private string freeGoodsStockCodeDescField;
        
        private string freeGoodsLongDescField;
        
        /// <remarks/>
        public int Invoice {
            get {
                return this.invoiceField;
            }
            set {
                this.invoiceField = value;
            }
        }
        
        /// <remarks/>
        public string InvoiceLine {
            get {
                return this.invoiceLineField;
            }
            set {
                this.invoiceLineField = value;
            }
        }
        
        /// <remarks/>
        public string PromotionCode {
            get {
                return this.promotionCodeField;
            }
            set {
                this.promotionCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PromotionCodeDesc {
            get {
                return this.promotionCodeDescField;
            }
            set {
                this.promotionCodeDescField = value;
            }
        }
        
        /// <remarks/>
        public sbyte TpmSequence {
            get {
                return this.tpmSequenceField;
            }
            set {
                this.tpmSequenceField = value;
            }
        }
        
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime TrnDate {
            get {
                return this.trnDateField;
            }
            set {
                this.trnDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime TrnTime {
            get {
                return this.trnTimeField;
            }
            set {
                this.trnTimeField = value;
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
        public string TransactionValue {
            get {
                return this.transactionValueField;
            }
            set {
                this.transactionValueField = value;
            }
        }
        
        /// <remarks/>
        public TPMDetailQueryPromotionDetailPromotionType PromotionType {
            get {
                return this.promotionTypeField;
            }
            set {
                this.promotionTypeField = value;
            }
        }
        
        /// <remarks/>
        public TPMDetailQueryPromotionDetailGlobalflag Globalflag {
            get {
                return this.globalflagField;
            }
            set {
                this.globalflagField = value;
            }
        }
        
        /// <remarks/>
        public string OriginalPrice {
            get {
                return this.originalPriceField;
            }
            set {
                this.originalPriceField = value;
            }
        }
        
        /// <remarks/>
        public string SoChargeLine {
            get {
                return this.soChargeLineField;
            }
            set {
                this.soChargeLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary")]
        public byte[] StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string StockCodeDesc {
            get {
                return this.stockCodeDescField;
            }
            set {
                this.stockCodeDescField = value;
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
        public TPMDetailQueryPromotionDetailFreeGoodsStockCode FreeGoodsStockCode {
            get {
                return this.freeGoodsStockCodeField;
            }
            set {
                this.freeGoodsStockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string FreeGoodsStockCodeDesc {
            get {
                return this.freeGoodsStockCodeDescField;
            }
            set {
                this.freeGoodsStockCodeDescField = value;
            }
        }
        
        /// <remarks/>
        public string FreeGoodsLongDesc {
            get {
                return this.freeGoodsLongDescField;
            }
            set {
                this.freeGoodsLongDescField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum TPMDetailQueryPromotionDetailPromotionType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        O,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TPMDetailQueryPromotionDetailGlobalflag {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class TPMDetailQueryPromotionDetailFreeGoodsStockCode {
    }
}
