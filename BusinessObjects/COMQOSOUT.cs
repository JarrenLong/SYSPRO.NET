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
namespace SYSPRO.NET.BusinessObjects.COMQOSOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private QueryOperators operatorsField;
        
        /// <remarks/>
        public QueryOperators Operators {
            get {
                return this.operatorsField;
            }
            set {
                this.operatorsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOperators {
        
        private QueryOperatorsRow rowField;
        
        /// <remarks/>
        public QueryOperatorsRow Row {
            get {
                return this.rowField;
            }
            set {
                this.rowField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOperatorsRow {
        
        private string operatorField;
        
        private string nameField;
        
        private string networkUserNameField;
        
        private string locationField;
        
        private string emailField;
        
        private string operatorLockedOutField;
        
        private string passwordRetrysField;
        
        private string lastLoginDateField;
        
        private string lastLoginTimeField;
        
        private string concurrentAccessField;
        
        private string loginOverrideField;
        
        private QueryOperatorsRowPrimaryGroup primaryGroupField;
        
        private QueryOperatorsRowPassword passwordField;
        
        private QueryOperatorsRowContactDetail contactDetailField;
        
        /// <remarks/>
        public string Operator {
            get {
                return this.operatorField;
            }
            set {
                this.operatorField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string NetworkUserName {
            get {
                return this.networkUserNameField;
            }
            set {
                this.networkUserNameField = value;
            }
        }
        
        /// <remarks/>
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public string OperatorLockedOut {
            get {
                return this.operatorLockedOutField;
            }
            set {
                this.operatorLockedOutField = value;
            }
        }
        
        /// <remarks/>
        public string PasswordRetrys {
            get {
                return this.passwordRetrysField;
            }
            set {
                this.passwordRetrysField = value;
            }
        }
        
        /// <remarks/>
        public string LastLoginDate {
            get {
                return this.lastLoginDateField;
            }
            set {
                this.lastLoginDateField = value;
            }
        }
        
        /// <remarks/>
        public string LastLoginTime {
            get {
                return this.lastLoginTimeField;
            }
            set {
                this.lastLoginTimeField = value;
            }
        }
        
        /// <remarks/>
        public string ConcurrentAccess {
            get {
                return this.concurrentAccessField;
            }
            set {
                this.concurrentAccessField = value;
            }
        }
        
        /// <remarks/>
        public string LoginOverride {
            get {
                return this.loginOverrideField;
            }
            set {
                this.loginOverrideField = value;
            }
        }
        
        /// <remarks/>
        public QueryOperatorsRowPrimaryGroup PrimaryGroup {
            get {
                return this.primaryGroupField;
            }
            set {
                this.primaryGroupField = value;
            }
        }
        
        /// <remarks/>
        public QueryOperatorsRowPassword Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public QueryOperatorsRowContactDetail ContactDetail {
            get {
                return this.contactDetailField;
            }
            set {
                this.contactDetailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOperatorsRowPrimaryGroup {
        
        private string groupCodeField;
        
        private string groupNameField;
        
        /// <remarks/>
        public string GroupCode {
            get {
                return this.groupCodeField;
            }
            set {
                this.groupCodeField = value;
            }
        }
        
        /// <remarks/>
        public string GroupName {
            get {
                return this.groupNameField;
            }
            set {
                this.groupNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOperatorsRowPassword {
        
        private string expiresField;
        
        private string hasPasswordField;
        
        private string changeNextLoginField;
        
        private string passExpiryField;
        
        /// <remarks/>
        public string Expires {
            get {
                return this.expiresField;
            }
            set {
                this.expiresField = value;
            }
        }
        
        /// <remarks/>
        public string HasPassword {
            get {
                return this.hasPasswordField;
            }
            set {
                this.hasPasswordField = value;
            }
        }
        
        /// <remarks/>
        public string ChangeNextLogin {
            get {
                return this.changeNextLoginField;
            }
            set {
                this.changeNextLoginField = value;
            }
        }
        
        /// <remarks/>
        public string PassExpiry {
            get {
                return this.passExpiryField;
            }
            set {
                this.passExpiryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryOperatorsRowContactDetail {
        
        private string fullNameField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string departmentField;
        
        private string jobTitleField;
        
        private string officeField;
        
        private string telephoneField;
        
        private string telephoneExtnField;
        
        private string managerNameField;
        
        private string managerTelephoneField;
        
        private string assistantNameField;
        
        private string assistantTelephoneField;
        
        /// <remarks/>
        public string FullName {
            get {
                return this.fullNameField;
            }
            set {
                this.fullNameField = value;
            }
        }
        
        /// <remarks/>
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public string Department {
            get {
                return this.departmentField;
            }
            set {
                this.departmentField = value;
            }
        }
        
        /// <remarks/>
        public string JobTitle {
            get {
                return this.jobTitleField;
            }
            set {
                this.jobTitleField = value;
            }
        }
        
        /// <remarks/>
        public string Office {
            get {
                return this.officeField;
            }
            set {
                this.officeField = value;
            }
        }
        
        /// <remarks/>
        public string Telephone {
            get {
                return this.telephoneField;
            }
            set {
                this.telephoneField = value;
            }
        }
        
        /// <remarks/>
        public string TelephoneExtn {
            get {
                return this.telephoneExtnField;
            }
            set {
                this.telephoneExtnField = value;
            }
        }
        
        /// <remarks/>
        public string ManagerName {
            get {
                return this.managerNameField;
            }
            set {
                this.managerNameField = value;
            }
        }
        
        /// <remarks/>
        public string ManagerTelephone {
            get {
                return this.managerTelephoneField;
            }
            set {
                this.managerTelephoneField = value;
            }
        }
        
        /// <remarks/>
        public string AssistantName {
            get {
                return this.assistantNameField;
            }
            set {
                this.assistantNameField = value;
            }
        }
        
        /// <remarks/>
        public string AssistantTelephone {
            get {
                return this.assistantTelephoneField;
            }
            set {
                this.assistantTelephoneField = value;
            }
        }
    }
}
