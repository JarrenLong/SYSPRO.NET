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
namespace SYSPRO.NET.BusinessObjects.PREQSOOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class FactorySchedulingOptions {
        
        private FactorySchedulingOptionsCompany companyField;
        
        private FactorySchedulingOptionsSetup setupField;
        
        private FactorySchedulingOptionsOptions optionsField;
        
        private FactorySchedulingOptionsDatabase databaseField;
        
        /// <remarks/>
        public FactorySchedulingOptionsCompany Company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }
        
        /// <remarks/>
        public FactorySchedulingOptionsSetup Setup {
            get {
                return this.setupField;
            }
            set {
                this.setupField = value;
            }
        }
        
        /// <remarks/>
        public FactorySchedulingOptionsOptions Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        public FactorySchedulingOptionsDatabase Database {
            get {
                return this.databaseField;
            }
            set {
                this.databaseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FactorySchedulingOptionsCompany {
        
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
    public partial class FactorySchedulingOptionsSetup {
        
        private string schedulingLevelField;
        
        private string preactorVersionField;
        
        private string configFolderField;
        
        private string configurationFileField;
        
        private string schedulingGroupsRequiredField;
        
        private string inclJobClassField;
        
        private string inclToolSetsField;
        
        private string dispSchedGroupErrorsField;
        
        private string coSpecAttributeDataMappingField;
        
        private string timeUomForMappedDataField;
        
        private string suggSchedInReqPlanningField;
        
        private string useHardwareConfigKeyField;
        
        /// <remarks/>
        public string SchedulingLevel {
            get {
                return this.schedulingLevelField;
            }
            set {
                this.schedulingLevelField = value;
            }
        }
        
        /// <remarks/>
        public string PreactorVersion {
            get {
                return this.preactorVersionField;
            }
            set {
                this.preactorVersionField = value;
            }
        }
        
        /// <remarks/>
        public string ConfigFolder {
            get {
                return this.configFolderField;
            }
            set {
                this.configFolderField = value;
            }
        }
        
        /// <remarks/>
        public string ConfigurationFile {
            get {
                return this.configurationFileField;
            }
            set {
                this.configurationFileField = value;
            }
        }
        
        /// <remarks/>
        public string SchedulingGroupsRequired {
            get {
                return this.schedulingGroupsRequiredField;
            }
            set {
                this.schedulingGroupsRequiredField = value;
            }
        }
        
        /// <remarks/>
        public string InclJobClass {
            get {
                return this.inclJobClassField;
            }
            set {
                this.inclJobClassField = value;
            }
        }
        
        /// <remarks/>
        public string InclToolSets {
            get {
                return this.inclToolSetsField;
            }
            set {
                this.inclToolSetsField = value;
            }
        }
        
        /// <remarks/>
        public string DispSchedGroupErrors {
            get {
                return this.dispSchedGroupErrorsField;
            }
            set {
                this.dispSchedGroupErrorsField = value;
            }
        }
        
        /// <remarks/>
        public string CoSpecAttributeDataMapping {
            get {
                return this.coSpecAttributeDataMappingField;
            }
            set {
                this.coSpecAttributeDataMappingField = value;
            }
        }
        
        /// <remarks/>
        public string TimeUomForMappedData {
            get {
                return this.timeUomForMappedDataField;
            }
            set {
                this.timeUomForMappedDataField = value;
            }
        }
        
        /// <remarks/>
        public string SuggSchedInReqPlanning {
            get {
                return this.suggSchedInReqPlanningField;
            }
            set {
                this.suggSchedInReqPlanningField = value;
            }
        }
        
        /// <remarks/>
        public string UseHardwareConfigKey {
            get {
                return this.useHardwareConfigKeyField;
            }
            set {
                this.useHardwareConfigKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FactorySchedulingOptionsOptions {
        
        private string baseEarliestStartForJobsField;
        
        private string inclInSchedJobsField;
        
        private string updatePlannedDatesField;
        
        private string applyScheduledDatesField;
        
        private string schedulingHorizonReqField;
        
        private string schedulingHorizonDaysField;
        
        private string inclInSchedJobsOnHoldField;
        
        private string inclInSchedStockOnHandField;
        
        private string inclInSchedPurchaseOrdersField;
        
        private string inclInSchedBulkIssueField;
        
        private string inclInSchedFloorStockField;
        
        private string inclInSchedSalesOrdersField;
        
        private string inclInSchedForwardOrdersField;
        
        private string inclInSchedOrdersInSuspField;
        
        /// <remarks/>
        public string BaseEarliestStartForJobs {
            get {
                return this.baseEarliestStartForJobsField;
            }
            set {
                this.baseEarliestStartForJobsField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedJobs {
            get {
                return this.inclInSchedJobsField;
            }
            set {
                this.inclInSchedJobsField = value;
            }
        }
        
        /// <remarks/>
        public string UpdatePlannedDates {
            get {
                return this.updatePlannedDatesField;
            }
            set {
                this.updatePlannedDatesField = value;
            }
        }
        
        /// <remarks/>
        public string ApplyScheduledDates {
            get {
                return this.applyScheduledDatesField;
            }
            set {
                this.applyScheduledDatesField = value;
            }
        }
        
        /// <remarks/>
        public string SchedulingHorizonReq {
            get {
                return this.schedulingHorizonReqField;
            }
            set {
                this.schedulingHorizonReqField = value;
            }
        }
        
        /// <remarks/>
        public string SchedulingHorizonDays {
            get {
                return this.schedulingHorizonDaysField;
            }
            set {
                this.schedulingHorizonDaysField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedJobsOnHold {
            get {
                return this.inclInSchedJobsOnHoldField;
            }
            set {
                this.inclInSchedJobsOnHoldField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedStockOnHand {
            get {
                return this.inclInSchedStockOnHandField;
            }
            set {
                this.inclInSchedStockOnHandField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedPurchaseOrders {
            get {
                return this.inclInSchedPurchaseOrdersField;
            }
            set {
                this.inclInSchedPurchaseOrdersField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedBulkIssue {
            get {
                return this.inclInSchedBulkIssueField;
            }
            set {
                this.inclInSchedBulkIssueField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedFloorStock {
            get {
                return this.inclInSchedFloorStockField;
            }
            set {
                this.inclInSchedFloorStockField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedSalesOrders {
            get {
                return this.inclInSchedSalesOrdersField;
            }
            set {
                this.inclInSchedSalesOrdersField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedForwardOrders {
            get {
                return this.inclInSchedForwardOrdersField;
            }
            set {
                this.inclInSchedForwardOrdersField = value;
            }
        }
        
        /// <remarks/>
        public string InclInSchedOrdersInSusp {
            get {
                return this.inclInSchedOrdersInSuspField;
            }
            set {
                this.inclInSchedOrdersInSuspField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class FactorySchedulingOptionsDatabase {
        
        private string sqlServerField;
        
        private string databaseNameField;
        
        private string usernameField;
        
        private string passwordField;
        
        private string trustedConnectionField;
        
        private string networkField;
        
        private string networkServerField;
        
        private string portField;
        
        private string licenseField;
        
        /// <remarks/>
        public string SqlServer {
            get {
                return this.sqlServerField;
            }
            set {
                this.sqlServerField = value;
            }
        }
        
        /// <remarks/>
        public string DatabaseName {
            get {
                return this.databaseNameField;
            }
            set {
                this.databaseNameField = value;
            }
        }
        
        /// <remarks/>
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string TrustedConnection {
            get {
                return this.trustedConnectionField;
            }
            set {
                this.trustedConnectionField = value;
            }
        }
        
        /// <remarks/>
        public string Network {
            get {
                return this.networkField;
            }
            set {
                this.networkField = value;
            }
        }
        
        /// <remarks/>
        public string NetworkServer {
            get {
                return this.networkServerField;
            }
            set {
                this.networkServerField = value;
            }
        }
        
        /// <remarks/>
        public string Port {
            get {
                return this.portField;
            }
            set {
                this.portField = value;
            }
        }
        
        /// <remarks/>
        public string License {
            get {
                return this.licenseField;
            }
            set {
                this.licenseField = value;
            }
        }
    }
}
