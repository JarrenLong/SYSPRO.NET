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
namespace SYSPRO.NET.BusinessObjects.mrp_capacity_loading {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum PrintManufacturingUMQuantities {
        
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
        S,
        
        /// <remarks/>
        R,
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
        
        private WorkCenter workCenterField;
        
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
        public WorkCenter WorkCenter {
            get {
                return this.workCenterField;
            }
            set {
                this.workCenterField = value;
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
        S,
        
        /// <remarks/>
        R,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum FirstDayOfWeek {
        
        /// <remarks/>
        SUN,
        
        /// <remarks/>
        MON,
        
        /// <remarks/>
        TUE,
        
        /// <remarks/>
        WED,
        
        /// <remarks/>
        THU,
        
        /// <remarks/>
        FRI,
        
        /// <remarks/>
        SAT,
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
    public enum NewPagePerWorkCenter {
        
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
    public enum PrintGraphs {
        
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
        
        private Period periodField;
        
        private bool periodFieldSpecified;
        
        private string numberOfDaysField;
        
        private FirstDayOfWeek firstDayOfWeekField;
        
        private bool firstDayOfWeekFieldSpecified;
        
        private IncludeSuggestedJobs includeSuggestedJobsField;
        
        private bool includeSuggestedJobsFieldSpecified;
        
        private WorkCenterStatus workCenterStatusField;
        
        private bool workCenterStatusFieldSpecified;
        
        private Pegging peggingField;
        
        private bool peggingFieldSpecified;
        
        private NewPagePerWorkCenter newPagePerWorkCenterField;
        
        private bool newPagePerWorkCenterFieldSpecified;
        
        private PrintGraphs printGraphsField;
        
        private bool printGraphsFieldSpecified;
        
        private PrintManufacturingUMQuantities printManufacturingUMQuantitiesField;
        
        private bool printManufacturingUMQuantitiesFieldSpecified;
        
        /// <remarks/>
        public Period Period {
            get {
                return this.periodField;
            }
            set {
                this.periodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodSpecified {
            get {
                return this.periodFieldSpecified;
            }
            set {
                this.periodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string NumberOfDays {
            get {
                return this.numberOfDaysField;
            }
            set {
                this.numberOfDaysField = value;
            }
        }
        
        /// <remarks/>
        public FirstDayOfWeek FirstDayOfWeek {
            get {
                return this.firstDayOfWeekField;
            }
            set {
                this.firstDayOfWeekField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FirstDayOfWeekSpecified {
            get {
                return this.firstDayOfWeekFieldSpecified;
            }
            set {
                this.firstDayOfWeekFieldSpecified = value;
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
        public WorkCenterStatus WorkCenterStatus {
            get {
                return this.workCenterStatusField;
            }
            set {
                this.workCenterStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WorkCenterStatusSpecified {
            get {
                return this.workCenterStatusFieldSpecified;
            }
            set {
                this.workCenterStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Pegging Pegging {
            get {
                return this.peggingField;
            }
            set {
                this.peggingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeggingSpecified {
            get {
                return this.peggingFieldSpecified;
            }
            set {
                this.peggingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public NewPagePerWorkCenter NewPagePerWorkCenter {
            get {
                return this.newPagePerWorkCenterField;
            }
            set {
                this.newPagePerWorkCenterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewPagePerWorkCenterSpecified {
            get {
                return this.newPagePerWorkCenterFieldSpecified;
            }
            set {
                this.newPagePerWorkCenterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PrintGraphs PrintGraphs {
            get {
                return this.printGraphsField;
            }
            set {
                this.printGraphsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintGraphsSpecified {
            get {
                return this.printGraphsFieldSpecified;
            }
            set {
                this.printGraphsFieldSpecified = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Period {
        
        /// <remarks/>
        SD,
        
        /// <remarks/>
        MD,
        
        /// <remarks/>
        WK,
        
        /// <remarks/>
        MO,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum WorkCenterStatus {
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        A,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Pegging {
        
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
