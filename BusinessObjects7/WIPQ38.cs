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
namespace SYSPRO.NET.BusinessObjects.WIPQ38 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum CoProductSelection {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        C,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum CompletedJobs {
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        O,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CostCenter {
        
        private CostCenterFilterType filterTypeField;
        
        private string filterValueField;
        
        public CostCenter() {
            this.filterTypeField = CostCenterFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(CostCenterFilterType.A)]
        public CostCenterFilterType FilterType {
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
    public enum CostCenterFilterType {
        
        /// <remarks/>
        A,
        
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
    public partial class Date {
        
        private DateFilterType filterTypeField;
        
        private string filterValueField;
        
        public Date() {
            this.filterTypeField = DateFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(DateFilterType.A)]
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
    public partial class Filter {
        
        private CostCenter costCenterField;
        
        private WorkCenter workCenterField;
        
        private Date dateField;
        
        /// <remarks/>
        public CostCenter CostCenter {
            get {
                return this.costCenterField;
            }
            set {
                this.costCenterField = value;
            }
        }
        
        /// <remarks/>
        public WorkCenter WorkCenter {
            get {
                return this.workCenterField;
            }
            set {
                this.workCenterField = value;
            }
        }
        
        /// <remarks/>
        public Date Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
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
    public partial class WorkCenter {
        
        private WorkCenterFilterType filterTypeField;
        
        private string filterValueField;
        
        public WorkCenter() {
            this.filterTypeField = WorkCenterFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(WorkCenterFilterType.A)]
        public WorkCenterFilterType FilterType {
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
    public enum WorkCenterFilterType {
        
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeSuggestedJobs {
        
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
    public enum JobsOnHold {
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        O,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum NewPagePerDay {
        
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
    public enum NewPagePerOperation {
        
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
    public enum PrintManufacturingUMQuantities {
        
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
    public enum OpCompletionOverdueByToday {
        
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
    public enum OpStartedLateNotCompleted {
        
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
    public enum OperationActive {
        
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
    public enum OperationCompleted {
        
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
    public enum OperationPlannedForQueue {
        
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
    public enum OpstartOverdueByToday {
        
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
    public partial class Option {
        
        private ReportSequence reportSequenceField;
        
        private bool reportSequenceFieldSpecified;
        
        private OpCompletionOverdueByToday opCompletionOverdueByTodayField;
        
        private bool opCompletionOverdueByTodayFieldSpecified;
        
        private OpstartOverdueByToday opstartOverdueByTodayField;
        
        private bool opstartOverdueByTodayFieldSpecified;
        
        private OpStartedLateNotCompleted opStartedLateNotCompletedField;
        
        private bool opStartedLateNotCompletedFieldSpecified;
        
        private IncludeSuggestedJobs includeSuggestedJobsField;
        
        private bool includeSuggestedJobsFieldSpecified;
        
        private JobsOnHold jobsOnHoldField;
        
        private bool jobsOnHoldFieldSpecified;
        
        private CompletedJobs completedJobsField;
        
        private bool completedJobsFieldSpecified;
        
        private UnconfirmedJobs unconfirmedJobsField;
        
        private bool unconfirmedJobsFieldSpecified;
        
        private string noOfNarrationLinesField;
        
        private OptionReturnNotesInBlock returnNotesInBlockField;
        
        private bool returnNotesInBlockFieldSpecified;
        
        private NewPagePerOperation newPagePerOperationField;
        
        private bool newPagePerOperationFieldSpecified;
        
        private NewPagePerDay newPagePerDayField;
        
        private bool newPagePerDayFieldSpecified;
        
        private OperationActive operationActiveField;
        
        private bool operationActiveFieldSpecified;
        
        private OperationCompleted operationCompletedField;
        
        private bool operationCompletedFieldSpecified;
        
        private OperationPlannedForQueue operationPlannedForQueueField;
        
        private bool operationPlannedForQueueFieldSpecified;
        
        private SubTotalEachDay subTotalEachDayField;
        
        private bool subTotalEachDayFieldSpecified;
        
        private CoProductSelection coProductSelectionField;
        
        private bool coProductSelectionFieldSpecified;
        
        private PrintManufacturingUMQuantities printManufacturingUMQuantitiesField;
        
        private bool printManufacturingUMQuantitiesFieldSpecified;
        
        private XslStylesheet xslStylesheetField;
        
        /// <remarks/>
        public ReportSequence ReportSequence {
            get {
                return this.reportSequenceField;
            }
            set {
                this.reportSequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportSequenceSpecified {
            get {
                return this.reportSequenceFieldSpecified;
            }
            set {
                this.reportSequenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public OpCompletionOverdueByToday OpCompletionOverdueByToday {
            get {
                return this.opCompletionOverdueByTodayField;
            }
            set {
                this.opCompletionOverdueByTodayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OpCompletionOverdueByTodaySpecified {
            get {
                return this.opCompletionOverdueByTodayFieldSpecified;
            }
            set {
                this.opCompletionOverdueByTodayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public OpstartOverdueByToday OpstartOverdueByToday {
            get {
                return this.opstartOverdueByTodayField;
            }
            set {
                this.opstartOverdueByTodayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OpstartOverdueByTodaySpecified {
            get {
                return this.opstartOverdueByTodayFieldSpecified;
            }
            set {
                this.opstartOverdueByTodayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public OpStartedLateNotCompleted OpStartedLateNotCompleted {
            get {
                return this.opStartedLateNotCompletedField;
            }
            set {
                this.opStartedLateNotCompletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OpStartedLateNotCompletedSpecified {
            get {
                return this.opStartedLateNotCompletedFieldSpecified;
            }
            set {
                this.opStartedLateNotCompletedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeSuggestedJobs IncludeSuggestedJobs {
            get {
                return this.includeSuggestedJobsField;
            }
            set {
                this.includeSuggestedJobsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeSuggestedJobsSpecified {
            get {
                return this.includeSuggestedJobsFieldSpecified;
            }
            set {
                this.includeSuggestedJobsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public JobsOnHold JobsOnHold {
            get {
                return this.jobsOnHoldField;
            }
            set {
                this.jobsOnHoldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool JobsOnHoldSpecified {
            get {
                return this.jobsOnHoldFieldSpecified;
            }
            set {
                this.jobsOnHoldFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CompletedJobs CompletedJobs {
            get {
                return this.completedJobsField;
            }
            set {
                this.completedJobsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompletedJobsSpecified {
            get {
                return this.completedJobsFieldSpecified;
            }
            set {
                this.completedJobsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public UnconfirmedJobs UnconfirmedJobs {
            get {
                return this.unconfirmedJobsField;
            }
            set {
                this.unconfirmedJobsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnconfirmedJobsSpecified {
            get {
                return this.unconfirmedJobsFieldSpecified;
            }
            set {
                this.unconfirmedJobsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string NoOfNarrationLines {
            get {
                return this.noOfNarrationLinesField;
            }
            set {
                this.noOfNarrationLinesField = value;
            }
        }
        
        /// <remarks/>
        public OptionReturnNotesInBlock ReturnNotesInBlock {
            get {
                return this.returnNotesInBlockField;
            }
            set {
                this.returnNotesInBlockField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnNotesInBlockSpecified {
            get {
                return this.returnNotesInBlockFieldSpecified;
            }
            set {
                this.returnNotesInBlockFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public NewPagePerOperation NewPagePerOperation {
            get {
                return this.newPagePerOperationField;
            }
            set {
                this.newPagePerOperationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewPagePerOperationSpecified {
            get {
                return this.newPagePerOperationFieldSpecified;
            }
            set {
                this.newPagePerOperationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public NewPagePerDay NewPagePerDay {
            get {
                return this.newPagePerDayField;
            }
            set {
                this.newPagePerDayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewPagePerDaySpecified {
            get {
                return this.newPagePerDayFieldSpecified;
            }
            set {
                this.newPagePerDayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public OperationActive OperationActive {
            get {
                return this.operationActiveField;
            }
            set {
                this.operationActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationActiveSpecified {
            get {
                return this.operationActiveFieldSpecified;
            }
            set {
                this.operationActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public OperationCompleted OperationCompleted {
            get {
                return this.operationCompletedField;
            }
            set {
                this.operationCompletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationCompletedSpecified {
            get {
                return this.operationCompletedFieldSpecified;
            }
            set {
                this.operationCompletedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public OperationPlannedForQueue OperationPlannedForQueue {
            get {
                return this.operationPlannedForQueueField;
            }
            set {
                this.operationPlannedForQueueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OperationPlannedForQueueSpecified {
            get {
                return this.operationPlannedForQueueFieldSpecified;
            }
            set {
                this.operationPlannedForQueueFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public SubTotalEachDay SubTotalEachDay {
            get {
                return this.subTotalEachDayField;
            }
            set {
                this.subTotalEachDayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubTotalEachDaySpecified {
            get {
                return this.subTotalEachDayFieldSpecified;
            }
            set {
                this.subTotalEachDayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public CoProductSelection CoProductSelection {
            get {
                return this.coProductSelectionField;
            }
            set {
                this.coProductSelectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CoProductSelectionSpecified {
            get {
                return this.coProductSelectionFieldSpecified;
            }
            set {
                this.coProductSelectionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PrintManufacturingUMQuantities PrintManufacturingUMQuantities {
            get {
                return this.printManufacturingUMQuantitiesField;
            }
            set {
                this.printManufacturingUMQuantitiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintManufacturingUMQuantitiesSpecified {
            get {
                return this.printManufacturingUMQuantitiesFieldSpecified;
            }
            set {
                this.printManufacturingUMQuantitiesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public XslStylesheet XslStylesheet {
            get {
                return this.xslStylesheetField;
            }
            set {
                this.xslStylesheetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReportSequence {
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        C,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum UnconfirmedJobs {
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        O,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum OptionReturnNotesInBlock {
        
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
    public enum SubTotalEachDay {
        
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
    public partial class XslStylesheet {
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
