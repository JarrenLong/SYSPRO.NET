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
namespace SYSPRO.NET.BusinessObjects.list_of_customer_classes_out {
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
        
        private string queryOptionsField;
        
        private QueryDetail[] listOfCustomerClassesField;
        
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
        public string QueryOptions {
            get {
                return this.queryOptionsField;
            }
            set {
                this.queryOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Detail", IsNullable=false)]
        public QueryDetail[] ListOfCustomerClasses {
            get {
                return this.listOfCustomerClassesField;
            }
            set {
                this.listOfCustomerClassesField = value;
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
        
        private string reportDateField;
        
        private string useSeparatorOnReportsField;
        
        private string separatorToUseField;
        
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
    public partial class QueryDetail {
        
        private string tblCustomerClass_ClassField;
        
        private string tblCustomerClass_DescriptionField;
        
        /// <remarks/>
        public string TblCustomerClass_Class {
            get {
                return this.tblCustomerClass_ClassField;
            }
            set {
                this.tblCustomerClass_ClassField = value;
            }
        }
        
        /// <remarks/>
        public string TblCustomerClass_Description {
            get {
                return this.tblCustomerClass_DescriptionField;
            }
            set {
                this.tblCustomerClass_DescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryTranslatedText {
        
        private string text_SequenceField;
        
        private string text_YesField;
        
        private string text_NoField;
        
        private string text_AllField;
        
        private string text_SingleField;
        
        private string text_RangeField;
        
        private string text_ListField;
        
        /// <remarks/>
        public string Text_Sequence {
            get {
                return this.text_SequenceField;
            }
            set {
                this.text_SequenceField = value;
            }
        }
        
        /// <remarks/>
        public string Text_Yes {
            get {
                return this.text_YesField;
            }
            set {
                this.text_YesField = value;
            }
        }
        
        /// <remarks/>
        public string Text_No {
            get {
                return this.text_NoField;
            }
            set {
                this.text_NoField = value;
            }
        }
        
        /// <remarks/>
        public string Text_All {
            get {
                return this.text_AllField;
            }
            set {
                this.text_AllField = value;
            }
        }
        
        /// <remarks/>
        public string Text_Single {
            get {
                return this.text_SingleField;
            }
            set {
                this.text_SingleField = value;
            }
        }
        
        /// <remarks/>
        public string Text_Range {
            get {
                return this.text_RangeField;
            }
            set {
                this.text_RangeField = value;
            }
        }
        
        /// <remarks/>
        public string Text_List {
            get {
                return this.text_ListField;
            }
            set {
                this.text_ListField = value;
            }
        }
    }
}
