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
namespace SYSPRO.NET.BusinessObjects.list_of_requisition_users_out {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QuerySystemInformation systemInformationField;
        
        private QueryQueryOptions queryOptionsField;
        
        private QueryUserItem[] userItemField;
        
        private QueryTranslatedText translatedTextField;
        
        /// <remarks/>
        public QuerySystemInformation SystemInformation {
            get {
                return this.systemInformationField;
            }
            set {
                this.systemInformationField = value;
            }
        }
        
        /// <remarks/>
        public QueryQueryOptions QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserItem")]
        public QueryUserItem[] UserItem {
            get {
                return this.userItemField;
            }
            set {
                this.userItemField = value;
            }
        }
        
        /// <remarks/>
        public QueryTranslatedText TranslatedText {
            get {
                return this.translatedTextField;
            }
            set {
                this.translatedTextField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QuerySystemInformation {
        
        private string cssStyleField;
        
        private string languageField;
        
        private string decFormatField;
        
        private string dateFormatField;
        
        private string roleField;
        
        private string versionField;
        
        private string companyIdField;
        
        private string companyNameField;
        
        private string operatorCodeField;
        
        private string operatorNameField;
        
        private string operatorGroupField;
        
        private string operatorEmailAddressField;
        
        private string operatorLocationField;
        
        private string localCurrencyField;
        
        private string localCurrencyDescField;
        
        private string glPrdPerYearField;
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
        private string operatorPrimaryRoleField;
        
        private double noOfDigitsField;
        
        private bool noOfDigitsFieldSpecified;
        
        private string decCharToUseField;
        
        /// <remarks/>
        public string CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        public string DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        public string DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorCode {
            get {
                return this.operatorCodeField;
            }
            set {
                this.operatorCodeField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorName {
            get {
                return this.operatorNameField;
            }
            set {
                this.operatorNameField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorGroup {
            get {
                return this.operatorGroupField;
            }
            set {
                this.operatorGroupField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorEmailAddress {
            get {
                return this.operatorEmailAddressField;
            }
            set {
                this.operatorEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorLocation {
            get {
                return this.operatorLocationField;
            }
            set {
                this.operatorLocationField = value;
            }
        }
        
        /// <remarks/>
        public string LocalCurrency {
            get {
                return this.localCurrencyField;
            }
            set {
                this.localCurrencyField = value;
            }
        }
        
        /// <remarks/>
        public string LocalCurrencyDesc {
            get {
                return this.localCurrencyDescField;
            }
            set {
                this.localCurrencyDescField = value;
            }
        }
        
        /// <remarks/>
        public string GlPrdPerYear {
            get {
                return this.glPrdPerYearField;
            }
            set {
                this.glPrdPerYearField = value;
            }
        }
        
        /// <remarks/>
        public string ReportDate {
            get {
                return this.reportDateField;
            }
            set {
                this.reportDateField = value;
            }
        }
        
        /// <remarks/>
        public string UseSeparatorOnReports {
            get {
                return this.useSeparatorOnReportsField;
            }
            set {
                this.useSeparatorOnReportsField = value;
            }
        }
        
        /// <remarks/>
        public string SeparatorToUse {
            get {
                return this.separatorToUseField;
            }
            set {
                this.separatorToUseField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorPrimaryRole {
            get {
                return this.operatorPrimaryRoleField;
            }
            set {
                this.operatorPrimaryRoleField = value;
            }
        }
        
        /// <remarks/>
        public double NoOfDigits {
            get {
                return this.noOfDigitsField;
            }
            set {
                this.noOfDigitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoOfDigitsSpecified {
            get {
                return this.noOfDigitsFieldSpecified;
            }
            set {
                this.noOfDigitsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string DecCharToUse {
            get {
                return this.decCharToUseField;
            }
            set {
                this.decCharToUseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryQueryOptions {
        
        private string includeAddRequisitionsField;
        
        private string includeAddDetailInfoField;
        
        private string includeChangeDetailInfoField;
        
        private string includeApproveReqField;
        
        private string includeCreatePoField;
        
        private string userFilterTypeField;
        
        private string userFilterValueField;
        
        private string reqApprovalLevelField;
        
        /// <remarks/>
        public string IncludeAddRequisitions {
            get {
                return this.includeAddRequisitionsField;
            }
            set {
                this.includeAddRequisitionsField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeAddDetailInfo {
            get {
                return this.includeAddDetailInfoField;
            }
            set {
                this.includeAddDetailInfoField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeChangeDetailInfo {
            get {
                return this.includeChangeDetailInfoField;
            }
            set {
                this.includeChangeDetailInfoField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeApproveReq {
            get {
                return this.includeApproveReqField;
            }
            set {
                this.includeApproveReqField = value;
            }
        }
        
        /// <remarks/>
        public string IncludeCreatePo {
            get {
                return this.includeCreatePoField;
            }
            set {
                this.includeCreatePoField = value;
            }
        }
        
        /// <remarks/>
        public string UserFilterType {
            get {
                return this.userFilterTypeField;
            }
            set {
                this.userFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string UserFilterValue {
            get {
                return this.userFilterValueField;
            }
            set {
                this.userFilterValueField = value;
            }
        }
        
        /// <remarks/>
        public string ReqApprovalLevel {
            get {
                return this.reqApprovalLevelField;
            }
            set {
                this.reqApprovalLevelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryUserItem {
        
        private string userCodeField;
        
        private string userNameField;
        
        private string authorityLevelField;
        
        private string maxLineValueField;
        
        private string authWarehouseField;
        
        private string nextUserField;
        
        private QueryUserItemSoReviewFlag soReviewFlagField;
        
        private string maintainReqnFlagField;
        
        private string emailField;
        
        private string canAddReqnField;
        
        private QueryUserItemCanAddReqnDetails canAddReqnDetailsField;
        
        private QueryUserItemCanChgReqnDetails canChgReqnDetailsField;
        
        private QueryUserItemCanApproveReqn canApproveReqnField;
        
        private QueryUserItemCanCreateOrder canCreateOrderField;
        
        private string maxApproveValueField;
        
        private string onHoldFlagField;
        
        private string forwardToUserField;
        
        private QueryUserItemMandatoryChkReqd mandatoryChkReqdField;
        
        /// <remarks/>
        public string UserCode {
            get {
                return this.userCodeField;
            }
            set {
                this.userCodeField = value;
            }
        }
        
        /// <remarks/>
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public string AuthorityLevel {
            get {
                return this.authorityLevelField;
            }
            set {
                this.authorityLevelField = value;
            }
        }
        
        /// <remarks/>
        public string MaxLineValue {
            get {
                return this.maxLineValueField;
            }
            set {
                this.maxLineValueField = value;
            }
        }
        
        /// <remarks/>
        public string AuthWarehouse {
            get {
                return this.authWarehouseField;
            }
            set {
                this.authWarehouseField = value;
            }
        }
        
        /// <remarks/>
        public string NextUser {
            get {
                return this.nextUserField;
            }
            set {
                this.nextUserField = value;
            }
        }
        
        /// <remarks/>
        public QueryUserItemSoReviewFlag SoReviewFlag {
            get {
                return this.soReviewFlagField;
            }
            set {
                this.soReviewFlagField = value;
            }
        }
        
        /// <remarks/>
        public string MaintainReqnFlag {
            get {
                return this.maintainReqnFlagField;
            }
            set {
                this.maintainReqnFlagField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string CanAddReqn {
            get {
                return this.canAddReqnField;
            }
            set {
                this.canAddReqnField = value;
            }
        }
        
        /// <remarks/>
        public QueryUserItemCanAddReqnDetails CanAddReqnDetails {
            get {
                return this.canAddReqnDetailsField;
            }
            set {
                this.canAddReqnDetailsField = value;
            }
        }
        
        /// <remarks/>
        public QueryUserItemCanChgReqnDetails CanChgReqnDetails {
            get {
                return this.canChgReqnDetailsField;
            }
            set {
                this.canChgReqnDetailsField = value;
            }
        }
        
        /// <remarks/>
        public QueryUserItemCanApproveReqn CanApproveReqn {
            get {
                return this.canApproveReqnField;
            }
            set {
                this.canApproveReqnField = value;
            }
        }
        
        /// <remarks/>
        public QueryUserItemCanCreateOrder CanCreateOrder {
            get {
                return this.canCreateOrderField;
            }
            set {
                this.canCreateOrderField = value;
            }
        }
        
        /// <remarks/>
        public string MaxApproveValue {
            get {
                return this.maxApproveValueField;
            }
            set {
                this.maxApproveValueField = value;
            }
        }
        
        /// <remarks/>
        public string OnHoldFlag {
            get {
                return this.onHoldFlagField;
            }
            set {
                this.onHoldFlagField = value;
            }
        }
        
        /// <remarks/>
        public string ForwardToUser {
            get {
                return this.forwardToUserField;
            }
            set {
                this.forwardToUserField = value;
            }
        }
        
        /// <remarks/>
        public QueryUserItemMandatoryChkReqd MandatoryChkReqd {
            get {
                return this.mandatoryChkReqdField;
            }
            set {
                this.mandatoryChkReqdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryUserItemSoReviewFlag {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryUserItemCanAddReqnDetails {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryUserItemCanChgReqnDetails {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryUserItemCanApproveReqn {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryUserItemCanCreateOrder {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum QueryUserItemMandatoryChkReqd {
        
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
    public partial class QueryTranslatedText {
        
        private object text_YesField;
        
        private object text_NoField;
        
        private object text_AllField;
        
        /// <remarks/>
        public object Text_Yes {
            get {
                return this.text_YesField;
            }
            set {
                this.text_YesField = value;
            }
        }
        
        /// <remarks/>
        public object Text_No {
            get {
                return this.text_NoField;
            }
            set {
                this.text_NoField = value;
            }
        }
        
        /// <remarks/>
        public object Text_All {
            get {
                return this.text_AllField;
            }
            set {
                this.text_AllField = value;
            }
        }
    }
}
