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
namespace SYSPRO.NET.BusinessObjects.SORQBS {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QueryOption optionField;
        
        private QueryFilter filterField;
        
        /// <remarks/>
        public QueryOption Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilter Filter {
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
    public partial class QueryOption {
        
        private QueryOptionIncludeSalesOrderDetails includeSalesOrderDetailsField;
        
        private QueryOptionIncludeContractDetails includeContractDetailsField;
        
        private QueryOptionIncludeDeliveryHistory includeDeliveryHistoryField;
        
        private QueryOptionIncludeUnconfirmedReleases includeUnconfirmedReleasesField;
        
        private QueryOptionIncludeConfirmedReleases includeConfirmedReleasesField;
        
        private QueryOptionIncludeReleaseDetails includeReleaseDetailsField;
        
        private QueryOptionIncludeReleaseHistory includeReleaseHistoryField;
        
        public QueryOption() {
            this.includeSalesOrderDetailsField = QueryOptionIncludeSalesOrderDetails.N;
            this.includeContractDetailsField = QueryOptionIncludeContractDetails.N;
            this.includeDeliveryHistoryField = QueryOptionIncludeDeliveryHistory.N;
            this.includeUnconfirmedReleasesField = QueryOptionIncludeUnconfirmedReleases.N;
            this.includeConfirmedReleasesField = QueryOptionIncludeConfirmedReleases.N;
            this.includeReleaseDetailsField = QueryOptionIncludeReleaseDetails.N;
            this.includeReleaseHistoryField = QueryOptionIncludeReleaseHistory.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeSalesOrderDetails.N)]
        public QueryOptionIncludeSalesOrderDetails IncludeSalesOrderDetails {
            get {
                return this.includeSalesOrderDetailsField;
            }
            set {
                this.includeSalesOrderDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeContractDetails.N)]
        public QueryOptionIncludeContractDetails IncludeContractDetails {
            get {
                return this.includeContractDetailsField;
            }
            set {
                this.includeContractDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeDeliveryHistory.N)]
        public QueryOptionIncludeDeliveryHistory IncludeDeliveryHistory {
            get {
                return this.includeDeliveryHistoryField;
            }
            set {
                this.includeDeliveryHistoryField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeUnconfirmedReleases.N)]
        public QueryOptionIncludeUnconfirmedReleases IncludeUnconfirmedReleases {
            get {
                return this.includeUnconfirmedReleasesField;
            }
            set {
                this.includeUnconfirmedReleasesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeConfirmedReleases.N)]
        public QueryOptionIncludeConfirmedReleases IncludeConfirmedReleases {
            get {
                return this.includeConfirmedReleasesField;
            }
            set {
                this.includeConfirmedReleasesField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeReleaseDetails.N)]
        public QueryOptionIncludeReleaseDetails IncludeReleaseDetails {
            get {
                return this.includeReleaseDetailsField;
            }
            set {
                this.includeReleaseDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(QueryOptionIncludeReleaseHistory.N)]
        public QueryOptionIncludeReleaseHistory IncludeReleaseHistory {
            get {
                return this.includeReleaseHistoryField;
            }
            set {
                this.includeReleaseHistoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeSalesOrderDetails {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeContractDetails {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeDeliveryHistory {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeUnconfirmedReleases {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeConfirmedReleases {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeReleaseDetails {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryOptionIncludeReleaseHistory {
        
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
    public partial class QueryFilter {
        
        private QueryFilterCustomer customerField;
        
        private QueryFilterCustomerPurchaseOrder customerPurchaseOrderField;
        
        private QueryFilterCustomerStockCode customerStockCodeField;
        
        /// <remarks/>
        public QueryFilterCustomer Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterCustomerPurchaseOrder CustomerPurchaseOrder {
            get {
                return this.customerPurchaseOrderField;
            }
            set {
                this.customerPurchaseOrderField = value;
            }
        }
        
        /// <remarks/>
        public QueryFilterCustomerStockCode CustomerStockCode {
            get {
                return this.customerStockCodeField;
            }
            set {
                this.customerStockCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryFilterCustomer {
        
        private QueryFilterCustomerFilterType filterTypeField;
        
        private string filterValueField;
        
        public QueryFilterCustomer() {
            this.filterTypeField = QueryFilterCustomerFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterCustomerFilterType.A)]
        public QueryFilterCustomerFilterType FilterType {
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
    public enum QueryFilterCustomerFilterType {
        
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
    public partial class QueryFilterCustomerPurchaseOrder {
        
        private QueryFilterCustomerPurchaseOrderFilterType filterTypeField;
        
        private string filterValueField;
        
        public QueryFilterCustomerPurchaseOrder() {
            this.filterTypeField = QueryFilterCustomerPurchaseOrderFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterCustomerPurchaseOrderFilterType.A)]
        public QueryFilterCustomerPurchaseOrderFilterType FilterType {
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
    public enum QueryFilterCustomerPurchaseOrderFilterType {
        
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
    public partial class QueryFilterCustomerStockCode {
        
        private QueryFilterCustomerStockCodeFilterType filterTypeField;
        
        private string filterValueField;
        
        public QueryFilterCustomerStockCode() {
            this.filterTypeField = QueryFilterCustomerStockCodeFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(QueryFilterCustomerStockCodeFilterType.A)]
        public QueryFilterCustomerStockCodeFilterType FilterType {
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
    public enum QueryFilterCustomerStockCodeFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        S,
    }
}
