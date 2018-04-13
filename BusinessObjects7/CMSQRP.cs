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
namespace SYSPRO.NET.BusinessObjects.CMSQRP {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Account {
        
        private AccountFilterType filterTypeField;
        
        private string filterValueField;
        
        public Account() {
            this.filterTypeField = AccountFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AccountFilterType.A)]
        public AccountFilterType FilterType {
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
    public enum AccountFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ActivityFollowUpFlag {
        
        private ActivityFollowUpFlagFilterType filterTypeField;
        
        private string filterValueField;
        
        public ActivityFollowUpFlag() {
            this.filterTypeField = ActivityFollowUpFlagFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ActivityFollowUpFlagFilterType.A)]
        public ActivityFollowUpFlagFilterType FilterType {
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
    public enum ActivityFollowUpFlagFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ActivityPriority {
        
        private ActivityPriorityFilterType filterTypeField;
        
        private ActivityPriorityFilterValue filterValueField;
        
        private bool filterValueFieldSpecified;
        
        public ActivityPriority() {
            this.filterTypeField = ActivityPriorityFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ActivityPriorityFilterType.A)]
        public ActivityPriorityFilterType FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ActivityPriorityFilterValue FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterValueSpecified {
            get {
                return this.filterValueFieldSpecified;
            }
            set {
                this.filterValueFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ActivityPriorityFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum ActivityPriorityFilterValue {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ActivityType {
        
        private ActivityTypeFilterType filterTypeField;
        
        private string filterValueField;
        
        public ActivityType() {
            this.filterTypeField = ActivityTypeFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ActivityTypeFilterType.A)]
        public ActivityTypeFilterType FilterType {
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
    public enum ActivityTypeFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Customer {
        
        private CustomerFilterType filterTypeField;
        
        private string filterValueField;
        
        public Customer() {
            this.filterTypeField = CustomerFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(CustomerFilterType.A)]
        public CustomerFilterType FilterType {
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
    public enum CustomerFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Filter {
        
        private Customer customerField;
        
        private Supplier supplierField;
        
        private Account accountField;
        
        private ActivityType activityTypeField;
        
        private ActivityFollowUpFlag activityFollowUpFlagField;
        
        private ActivityPriority activityPriorityField;
        
        /// <remarks/>
        public Customer Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
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
        public Account Account {
            get {
                return this.accountField;
            }
            set {
                this.accountField = value;
            }
        }
        
        /// <remarks/>
        public ActivityType ActivityType {
            get {
                return this.activityTypeField;
            }
            set {
                this.activityTypeField = value;
            }
        }
        
        /// <remarks/>
        public ActivityFollowUpFlag ActivityFollowUpFlag {
            get {
                return this.activityFollowUpFlagField;
            }
            set {
                this.activityFollowUpFlagField = value;
            }
        }
        
        /// <remarks/>
        public ActivityPriority ActivityPriority {
            get {
                return this.activityPriorityField;
            }
            set {
                this.activityPriorityField = value;
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
        
        private SupplierFilterType filterTypeField;
        
        private string filterValueField;
        
        public Supplier() {
            this.filterTypeField = SupplierFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SupplierFilterType.A)]
        public SupplierFilterType FilterType {
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
    public enum SupplierFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeActivityMaxAge {
        
        /// <remarks/>
        ALL,
        
        /// <remarks/>
        PTH,
        
        /// <remarks/>
        P2MTH,
        
        /// <remarks/>
        P3MTH,
        
        /// <remarks/>
        P6MTH,
        
        /// <remarks/>
        P9MTH,
        
        /// <remarks/>
        PYR,
        
        /// <remarks/>
        P2YR,
        
        /// <remarks/>
        P3YR,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeOrganizaitonAccounts {
        
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
    public enum IncludeOrganizaitonCustomers {
        
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
    public enum IncludeOrganizaitonSuppliers {
        
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
    public enum IncludeActivities {
        
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
    public enum IncludeClearedActivities {
        
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
    public enum IncludeAddresses {
        
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
    public enum IncludeMultimedia {
        
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
    public enum IncludeTelephone {
        
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
    public enum IncludeEmail {
        
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
    public enum IncludeUrl {
        
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
    public enum IncludeDate {
        
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
    public enum IncludeFullBody {
        
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
        
        private IncludeOrganizaitonAccounts includeOrganizaitonAccountsField;
        
        private IncludeOrganizaitonCustomers includeOrganizaitonCustomersField;
        
        private IncludeOrganizaitonSuppliers includeOrganizaitonSuppliersField;
        
        private IncludeClearedActivities includeClearedActivitiesField;
        
        private IncludeActivities includeActivitiesField;
        
        private IncludeAddresses includeAddressesField;
        
        private IncludeMultimedia includeMultimediaField;
        
        private IncludeTelephone includeTelephoneField;
        
        private IncludeEmail includeEmailField;
        
        private IncludeUrl includeUrlField;
        
        private IncludeDate includeDateField;
        
        private IncludeFullBody includeFullBodyField;
        
        private IncludeActivityMaxAge includeActivityMaxAgeField;
        
        private string regardingField;
        
        private string resultField;
        
        private string locationField;
        
        private string userField1Field;
        
        private string userField2Field;
        
        private string userField3Field;
        
        public Option() {
            this.includeOrganizaitonAccountsField = IncludeOrganizaitonAccounts.Y;
            this.includeOrganizaitonCustomersField = IncludeOrganizaitonCustomers.Y;
            this.includeOrganizaitonSuppliersField = IncludeOrganizaitonSuppliers.Y;
            this.includeClearedActivitiesField = IncludeClearedActivities.N;
            this.includeActivitiesField = IncludeActivities.N;
            this.includeAddressesField = IncludeAddresses.N;
            this.includeMultimediaField = IncludeMultimedia.N;
            this.includeTelephoneField = IncludeTelephone.N;
            this.includeEmailField = IncludeEmail.N;
            this.includeUrlField = IncludeUrl.N;
            this.includeDateField = IncludeDate.N;
            this.includeFullBodyField = IncludeFullBody.N;
            this.includeActivityMaxAgeField = IncludeActivityMaxAge.ALL;
        }
        
        /// <remarks/>
        public IncludeOrganizaitonAccounts IncludeOrganizaitonAccounts {
            get {
                return this.includeOrganizaitonAccountsField;
            }
            set {
                this.includeOrganizaitonAccountsField = value;
            }
        }
        
        /// <remarks/>
        public IncludeOrganizaitonCustomers IncludeOrganizaitonCustomers {
            get {
                return this.includeOrganizaitonCustomersField;
            }
            set {
                this.includeOrganizaitonCustomersField = value;
            }
        }
        
        /// <remarks/>
        public IncludeOrganizaitonSuppliers IncludeOrganizaitonSuppliers {
            get {
                return this.includeOrganizaitonSuppliersField;
            }
            set {
                this.includeOrganizaitonSuppliersField = value;
            }
        }
        
        /// <remarks/>
        public IncludeClearedActivities IncludeClearedActivities {
            get {
                return this.includeClearedActivitiesField;
            }
            set {
                this.includeClearedActivitiesField = value;
            }
        }
        
        /// <remarks/>
        public IncludeActivities IncludeActivities {
            get {
                return this.includeActivitiesField;
            }
            set {
                this.includeActivitiesField = value;
            }
        }
        
        /// <remarks/>
        public IncludeAddresses IncludeAddresses {
            get {
                return this.includeAddressesField;
            }
            set {
                this.includeAddressesField = value;
            }
        }
        
        /// <remarks/>
        public IncludeMultimedia IncludeMultimedia {
            get {
                return this.includeMultimediaField;
            }
            set {
                this.includeMultimediaField = value;
            }
        }
        
        /// <remarks/>
        public IncludeTelephone IncludeTelephone {
            get {
                return this.includeTelephoneField;
            }
            set {
                this.includeTelephoneField = value;
            }
        }
        
        /// <remarks/>
        public IncludeEmail IncludeEmail {
            get {
                return this.includeEmailField;
            }
            set {
                this.includeEmailField = value;
            }
        }
        
        /// <remarks/>
        public IncludeUrl IncludeUrl {
            get {
                return this.includeUrlField;
            }
            set {
                this.includeUrlField = value;
            }
        }
        
        /// <remarks/>
        public IncludeDate IncludeDate {
            get {
                return this.includeDateField;
            }
            set {
                this.includeDateField = value;
            }
        }
        
        /// <remarks/>
        public IncludeFullBody IncludeFullBody {
            get {
                return this.includeFullBodyField;
            }
            set {
                this.includeFullBodyField = value;
            }
        }
        
        /// <remarks/>
        public IncludeActivityMaxAge IncludeActivityMaxAge {
            get {
                return this.includeActivityMaxAgeField;
            }
            set {
                this.includeActivityMaxAgeField = value;
            }
        }
        
        /// <remarks/>
        public string Regarding {
            get {
                return this.regardingField;
            }
            set {
                this.regardingField = value;
            }
        }
        
        /// <remarks/>
        public string Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
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
        public string UserField1 {
            get {
                return this.userField1Field;
            }
            set {
                this.userField1Field = value;
            }
        }
        
        /// <remarks/>
        public string UserField2 {
            get {
                return this.userField2Field;
            }
            set {
                this.userField2Field = value;
            }
        }
        
        /// <remarks/>
        public string UserField3 {
            get {
                return this.userField3Field;
            }
            set {
                this.userField3Field = value;
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
