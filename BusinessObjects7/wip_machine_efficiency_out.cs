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
namespace SYSPRO.NET.BusinessObjects.wip_machine_efficiency_out {
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
        [System.Xml.Serialization.XmlElementAttribute("MachineList", typeof(QueryMachineList), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("QueryOptions", typeof(QueryQueryOptions), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("SystemInformation", typeof(QuerySystemInformation), Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    public partial class QueryMachineList {
        
        private QueryMachineListDetail[] detailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Detail", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public QueryMachineListDetail[] Detail {
            get {
                return this.detailField;
            }
            set {
                this.detailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class QueryMachineListDetail {
        
        private string machineField;
        
        private string machineDescriptionField;
        
        private double mtdStdHrsEarnedField;
        
        private bool mtdStdHrsEarnedFieldSpecified;
        
        private string edited_MtdStdHrsEarnedField;
        
        private double mtdNonProdHoursField;
        
        private bool mtdNonProdHoursFieldSpecified;
        
        private string edited_MtdNonProdHoursField;
        
        private double mtdActualProductiveHoursField;
        
        private bool mtdActualProductiveHoursFieldSpecified;
        
        private double stdHoursPerMonthField;
        
        private bool stdHoursPerMonthFieldSpecified;
        
        private string edited_StdHoursPerMonthField;
        
        private string workCenterField;
        
        private string shiftIdField;
        
        private double standardTimeEarnedField;
        
        private bool standardTimeEarnedFieldSpecified;
        
        private double nonProductiveTimeField;
        
        private bool nonProductiveTimeFieldSpecified;
        
        private double standardTimePerMonthField;
        
        private bool standardTimePerMonthFieldSpecified;
        
        private double lostTimeField;
        
        private bool lostTimeFieldSpecified;
        
        private string edited_LostTimeField;
        
        private double actualProductiveTimeField;
        
        private bool actualProductiveTimeFieldSpecified;
        
        private string edited_ActualProductiveTimeField;
        
        private double percentageProductionUtilisedField;
        
        private bool percentageProductionUtilisedFieldSpecified;
        
        private double percentageTotalUtilisedField;
        
        private bool percentageTotalUtilisedFieldSpecified;
        
        private double percentageEfficiencyField;
        
        private bool percentageEfficiencyFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Machine {
            get {
                return this.machineField;
            }
            set {
                this.machineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MachineDescription {
            get {
                return this.machineDescriptionField;
            }
            set {
                this.machineDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double MtdStdHrsEarned {
            get {
                return this.mtdStdHrsEarnedField;
            }
            set {
                this.mtdStdHrsEarnedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MtdStdHrsEarnedSpecified {
            get {
                return this.mtdStdHrsEarnedFieldSpecified;
            }
            set {
                this.mtdStdHrsEarnedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_MtdStdHrsEarned {
            get {
                return this.edited_MtdStdHrsEarnedField;
            }
            set {
                this.edited_MtdStdHrsEarnedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double MtdNonProdHours {
            get {
                return this.mtdNonProdHoursField;
            }
            set {
                this.mtdNonProdHoursField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MtdNonProdHoursSpecified {
            get {
                return this.mtdNonProdHoursFieldSpecified;
            }
            set {
                this.mtdNonProdHoursFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_MtdNonProdHours {
            get {
                return this.edited_MtdNonProdHoursField;
            }
            set {
                this.edited_MtdNonProdHoursField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double MtdActualProductiveHours {
            get {
                return this.mtdActualProductiveHoursField;
            }
            set {
                this.mtdActualProductiveHoursField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MtdActualProductiveHoursSpecified {
            get {
                return this.mtdActualProductiveHoursFieldSpecified;
            }
            set {
                this.mtdActualProductiveHoursFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double StdHoursPerMonth {
            get {
                return this.stdHoursPerMonthField;
            }
            set {
                this.stdHoursPerMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StdHoursPerMonthSpecified {
            get {
                return this.stdHoursPerMonthFieldSpecified;
            }
            set {
                this.stdHoursPerMonthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_StdHoursPerMonth {
            get {
                return this.edited_StdHoursPerMonthField;
            }
            set {
                this.edited_StdHoursPerMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string WorkCenter {
            get {
                return this.workCenterField;
            }
            set {
                this.workCenterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ShiftId {
            get {
                return this.shiftIdField;
            }
            set {
                this.shiftIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double StandardTimeEarned {
            get {
                return this.standardTimeEarnedField;
            }
            set {
                this.standardTimeEarnedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StandardTimeEarnedSpecified {
            get {
                return this.standardTimeEarnedFieldSpecified;
            }
            set {
                this.standardTimeEarnedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double NonProductiveTime {
            get {
                return this.nonProductiveTimeField;
            }
            set {
                this.nonProductiveTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonProductiveTimeSpecified {
            get {
                return this.nonProductiveTimeFieldSpecified;
            }
            set {
                this.nonProductiveTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double StandardTimePerMonth {
            get {
                return this.standardTimePerMonthField;
            }
            set {
                this.standardTimePerMonthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StandardTimePerMonthSpecified {
            get {
                return this.standardTimePerMonthFieldSpecified;
            }
            set {
                this.standardTimePerMonthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double LostTime {
            get {
                return this.lostTimeField;
            }
            set {
                this.lostTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LostTimeSpecified {
            get {
                return this.lostTimeFieldSpecified;
            }
            set {
                this.lostTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_LostTime {
            get {
                return this.edited_LostTimeField;
            }
            set {
                this.edited_LostTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double ActualProductiveTime {
            get {
                return this.actualProductiveTimeField;
            }
            set {
                this.actualProductiveTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActualProductiveTimeSpecified {
            get {
                return this.actualProductiveTimeFieldSpecified;
            }
            set {
                this.actualProductiveTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Edited_ActualProductiveTime {
            get {
                return this.edited_ActualProductiveTimeField;
            }
            set {
                this.edited_ActualProductiveTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double PercentageProductionUtilised {
            get {
                return this.percentageProductionUtilisedField;
            }
            set {
                this.percentageProductionUtilisedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageProductionUtilisedSpecified {
            get {
                return this.percentageProductionUtilisedFieldSpecified;
            }
            set {
                this.percentageProductionUtilisedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double PercentageTotalUtilised {
            get {
                return this.percentageTotalUtilisedField;
            }
            set {
                this.percentageTotalUtilisedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageTotalUtilisedSpecified {
            get {
                return this.percentageTotalUtilisedFieldSpecified;
            }
            set {
                this.percentageTotalUtilisedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double PercentageEfficiency {
            get {
                return this.percentageEfficiencyField;
            }
            set {
                this.percentageEfficiencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageEfficiencySpecified {
            get {
                return this.percentageEfficiencyFieldSpecified;
            }
            set {
                this.percentageEfficiencyFieldSpecified = value;
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
        
        private string machineSelectionFilterTypeField;
        
        private string machineSelectionFilterValueField;
        
        private string translated_MachineSelectionFilterTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MachineSelectionFilterType {
            get {
                return this.machineSelectionFilterTypeField;
            }
            set {
                this.machineSelectionFilterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string MachineSelectionFilterValue {
            get {
                return this.machineSelectionFilterValueField;
            }
            set {
                this.machineSelectionFilterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Translated_MachineSelectionFilterType {
            get {
                return this.translated_MachineSelectionFilterTypeField;
            }
            set {
                this.translated_MachineSelectionFilterTypeField = value;
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
        
        private string bOMQtyPerDecimalsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CssStyle {
            get {
                return this.cssStyleField;
            }
            set {
                this.cssStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DecFormat {
            get {
                return this.decFormatField;
            }
            set {
                this.decFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DateFormat {
            get {
                return this.dateFormatField;
            }
            set {
                this.dateFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Role {
            get {
                return this.roleField;
            }
            set {
                this.roleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorCode {
            get {
                return this.operatorCodeField;
            }
            set {
                this.operatorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorName {
            get {
                return this.operatorNameField;
            }
            set {
                this.operatorNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorGroup {
            get {
                return this.operatorGroupField;
            }
            set {
                this.operatorGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorEmailAddress {
            get {
                return this.operatorEmailAddressField;
            }
            set {
                this.operatorEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string OperatorLocation {
            get {
                return this.operatorLocationField;
            }
            set {
                this.operatorLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ReportDate {
            get {
                return this.reportDateField;
            }
            set {
                this.reportDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UseSeparatorOnReports {
            get {
                return this.useSeparatorOnReportsField;
            }
            set {
                this.useSeparatorOnReportsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SeparatorToUse {
            get {
                return this.separatorToUseField;
            }
            set {
                this.separatorToUseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DecCharToUse {
            get {
                return this.decCharToUseField;
            }
            set {
                this.decCharToUseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string BOMQtyPerDecimals {
            get {
                return this.bOMQtyPerDecimalsField;
            }
            set {
                this.bOMQtyPerDecimalsField = value;
            }
        }
    }
}
