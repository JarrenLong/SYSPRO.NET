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
namespace SYSPRO.NET.BusinessObjects.IMPQST {
    using System.Xml.Serialization;
    
    
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Option {
        
        private TopBottomStockCodes topBottomStockCodesField;
        
        private string numberOfStockCodesField;
        
        private BasedOnMeasure basedOnMeasureField;
        
        private DateSelection dateSelectionField;
        
        private string currencyField;
        
        private InclSubTotalsStockCode inclSubTotalsStockCodeField;
        
        private InclOrigPurchPrice inclOrigPurchPriceField;
        
        private InclQtyOrdered inclQtyOrderedField;
        
        private InclQtyReceived inclQtyReceivedField;
        
        private InclRejectionQty inclRejectionQtyField;
        
        private InclPriceReceived inclPriceReceivedField;
        
        private InclOnTimeInFullQuality inclOnTimeInFullQualityField;
        
        private InclAgeing inclAgeingField;
        
        private InclPurchRecCount inclPurchRecCountField;
        
        private InclReceiptCount inclReceiptCountField;
        
        private InclPurchRejCount inclPurchRejCountField;
        
        private InclRejectionCount inclRejectionCountField;
        
        private InclPurchaseOrderCount inclPurchaseOrderCountField;
        
        private InclQtyVariance inclQtyVarianceField;
        
        private InclPriceVariance inclPriceVarianceField;
        
        private InclQtyInvoiced inclQtyInvoicedField;
        
        private InclQtyOutstanding inclQtyOutstandingField;
        
        private InclNetSlsValExTax inclNetSlsValExTaxField;
        
        private InclInvoiceCount inclInvoiceCountField;
        
        /// <remarks/>
        public TopBottomStockCodes TopBottomStockCodes {
            get {
                return this.topBottomStockCodesField;
            }
            set {
                this.topBottomStockCodesField = value;
            }
        }
        
        /// <remarks/>
        public string NumberOfStockCodes {
            get {
                return this.numberOfStockCodesField;
            }
            set {
                this.numberOfStockCodesField = value;
            }
        }
        
        /// <remarks/>
        public BasedOnMeasure BasedOnMeasure {
            get {
                return this.basedOnMeasureField;
            }
            set {
                this.basedOnMeasureField = value;
            }
        }
        
        /// <remarks/>
        public DateSelection DateSelection {
            get {
                return this.dateSelectionField;
            }
            set {
                this.dateSelectionField = value;
            }
        }
        
        /// <remarks/>
        public string Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        public InclSubTotalsStockCode InclSubTotalsStockCode {
            get {
                return this.inclSubTotalsStockCodeField;
            }
            set {
                this.inclSubTotalsStockCodeField = value;
            }
        }
        
        /// <remarks/>
        public InclOrigPurchPrice InclOrigPurchPrice {
            get {
                return this.inclOrigPurchPriceField;
            }
            set {
                this.inclOrigPurchPriceField = value;
            }
        }
        
        /// <remarks/>
        public InclQtyOrdered InclQtyOrdered {
            get {
                return this.inclQtyOrderedField;
            }
            set {
                this.inclQtyOrderedField = value;
            }
        }
        
        /// <remarks/>
        public InclQtyReceived InclQtyReceived {
            get {
                return this.inclQtyReceivedField;
            }
            set {
                this.inclQtyReceivedField = value;
            }
        }
        
        /// <remarks/>
        public InclRejectionQty InclRejectionQty {
            get {
                return this.inclRejectionQtyField;
            }
            set {
                this.inclRejectionQtyField = value;
            }
        }
        
        /// <remarks/>
        public InclPriceReceived InclPriceReceived {
            get {
                return this.inclPriceReceivedField;
            }
            set {
                this.inclPriceReceivedField = value;
            }
        }
        
        /// <remarks/>
        public InclOnTimeInFullQuality InclOnTimeInFullQuality {
            get {
                return this.inclOnTimeInFullQualityField;
            }
            set {
                this.inclOnTimeInFullQualityField = value;
            }
        }
        
        /// <remarks/>
        public InclAgeing InclAgeing {
            get {
                return this.inclAgeingField;
            }
            set {
                this.inclAgeingField = value;
            }
        }
        
        /// <remarks/>
        public InclPurchRecCount InclPurchRecCount {
            get {
                return this.inclPurchRecCountField;
            }
            set {
                this.inclPurchRecCountField = value;
            }
        }
        
        /// <remarks/>
        public InclReceiptCount InclReceiptCount {
            get {
                return this.inclReceiptCountField;
            }
            set {
                this.inclReceiptCountField = value;
            }
        }
        
        /// <remarks/>
        public InclPurchRejCount InclPurchRejCount {
            get {
                return this.inclPurchRejCountField;
            }
            set {
                this.inclPurchRejCountField = value;
            }
        }
        
        /// <remarks/>
        public InclRejectionCount InclRejectionCount {
            get {
                return this.inclRejectionCountField;
            }
            set {
                this.inclRejectionCountField = value;
            }
        }
        
        /// <remarks/>
        public InclPurchaseOrderCount InclPurchaseOrderCount {
            get {
                return this.inclPurchaseOrderCountField;
            }
            set {
                this.inclPurchaseOrderCountField = value;
            }
        }
        
        /// <remarks/>
        public InclQtyVariance InclQtyVariance {
            get {
                return this.inclQtyVarianceField;
            }
            set {
                this.inclQtyVarianceField = value;
            }
        }
        
        /// <remarks/>
        public InclPriceVariance InclPriceVariance {
            get {
                return this.inclPriceVarianceField;
            }
            set {
                this.inclPriceVarianceField = value;
            }
        }
        
        /// <remarks/>
        public InclQtyInvoiced InclQtyInvoiced {
            get {
                return this.inclQtyInvoicedField;
            }
            set {
                this.inclQtyInvoicedField = value;
            }
        }
        
        /// <remarks/>
        public InclQtyOutstanding InclQtyOutstanding {
            get {
                return this.inclQtyOutstandingField;
            }
            set {
                this.inclQtyOutstandingField = value;
            }
        }
        
        /// <remarks/>
        public InclNetSlsValExTax InclNetSlsValExTax {
            get {
                return this.inclNetSlsValExTaxField;
            }
            set {
                this.inclNetSlsValExTaxField = value;
            }
        }
        
        /// <remarks/>
        public InclInvoiceCount InclInvoiceCount {
            get {
                return this.inclInvoiceCountField;
            }
            set {
                this.inclInvoiceCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum TopBottomStockCodes {
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        B,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum BasedOnMeasure {
        
        /// <remarks/>
        AA,
        
        /// <remarks/>
        OP,
        
        /// <remarks/>
        QO,
        
        /// <remarks/>
        QR,
        
        /// <remarks/>
        PR,
        
        /// <remarks/>
        OQ,
        
        /// <remarks/>
        RC,
        
        /// <remarks/>
        PC,
        
        /// <remarks/>
        QV,
        
        /// <remarks/>
        PV,
        
        /// <remarks/>
        RQ,
        
        /// <remarks/>
        PU,
        
        /// <remarks/>
        RE,
        
        /// <remarks/>
        RJ,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DateSelection {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        R,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum InclSubTotalsStockCode {
        
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
    public enum InclOrigPurchPrice {
        
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
    public enum InclQtyOrdered {
        
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
    public enum InclQtyReceived {
        
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
    public enum InclRejectionQty {
        
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
    public enum InclPriceReceived {
        
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
    public enum InclOnTimeInFullQuality {
        
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
    public enum InclAgeing {
        
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
    public enum InclPurchRecCount {
        
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
    public enum InclReceiptCount {
        
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
    public enum InclPurchRejCount {
        
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
    public enum InclRejectionCount {
        
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
    public enum InclPurchaseOrderCount {
        
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
    public enum InclQtyVariance {
        
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
    public enum InclPriceVariance {
        
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
    public enum InclQtyInvoiced {
        
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
    public enum InclQtyOutstanding {
        
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
    public enum InclNetSlsValExTax {
        
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
    public enum InclInvoiceCount {
        
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
    public partial class Filter {
        
        private Date dateField;
        
        private StockCode stockCodeField;
        
        private OrderAge orderAgeField;
        
        /// <remarks/>
        public Date Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
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
        public OrderAge OrderAge {
            get {
                return this.orderAgeField;
            }
            set {
                this.orderAgeField = value;
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
    public partial class Date {
        
        private DateFilterType filterTypeField;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DateFilterType FilterType {
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
    public enum DateFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
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
    public partial class StockCode {
        
        private StockCodeFilterType filterTypeField;
        
        private string filterValueField;
        
        public StockCode() {
            this.filterTypeField = StockCodeFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(StockCodeFilterType.A)]
        public StockCodeFilterType FilterType {
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
    public enum StockCodeFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
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
    public partial class OrderAge {
        
        private OrderAgeFilterType filterTypeField;
        
        private string filterValueField;
        
        public OrderAge() {
            this.filterTypeField = OrderAgeFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(OrderAgeFilterType.A)]
        public OrderAgeFilterType FilterType {
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
    public enum OrderAgeFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        S,
    }
}
