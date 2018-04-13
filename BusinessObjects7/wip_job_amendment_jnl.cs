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
namespace SYSPRO.NET.BusinessObjects.wip_job_amendment_jnl {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeReprint {
        
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
        
        private IncludeMatAllocs includeMatAllocsField;
        
        private bool includeMatAllocsFieldSpecified;
        
        private IncludeLabAllocs includeLabAllocsField;
        
        private bool includeLabAllocsFieldSpecified;
        
        private IncludeReprint includeReprintField;
        
        private bool includeReprintFieldSpecified;
        
        private PrintAdditions printAdditionsField;
        
        private bool printAdditionsFieldSpecified;
        
        private PrintChanges printChangesField;
        
        private bool printChangesFieldSpecified;
        
        private PrintDeletions printDeletionsField;
        
        private bool printDeletionsFieldSpecified;
        
        private XslStylesheet xslStylesheetField;
        
        public Option() {
            this.includeMatAllocsField = IncludeMatAllocs.N;
            this.includeLabAllocsField = IncludeLabAllocs.N;
            this.includeReprintField = IncludeReprint.N;
            this.printAdditionsField = PrintAdditions.Y;
            this.printChangesField = PrintChanges.Y;
            this.printDeletionsField = PrintDeletions.Y;
        }
        
        /// <remarks/>
        public IncludeMatAllocs IncludeMatAllocs {
            get {
                return this.includeMatAllocsField;
            }
            set {
                this.includeMatAllocsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMatAllocsSpecified {
            get {
                return this.includeMatAllocsFieldSpecified;
            }
            set {
                this.includeMatAllocsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeLabAllocs IncludeLabAllocs {
            get {
                return this.includeLabAllocsField;
            }
            set {
                this.includeLabAllocsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeLabAllocsSpecified {
            get {
                return this.includeLabAllocsFieldSpecified;
            }
            set {
                this.includeLabAllocsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeReprint IncludeReprint {
            get {
                return this.includeReprintField;
            }
            set {
                this.includeReprintField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeReprintSpecified {
            get {
                return this.includeReprintFieldSpecified;
            }
            set {
                this.includeReprintFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PrintAdditions PrintAdditions {
            get {
                return this.printAdditionsField;
            }
            set {
                this.printAdditionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintAdditionsSpecified {
            get {
                return this.printAdditionsFieldSpecified;
            }
            set {
                this.printAdditionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PrintChanges PrintChanges {
            get {
                return this.printChangesField;
            }
            set {
                this.printChangesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintChangesSpecified {
            get {
                return this.printChangesFieldSpecified;
            }
            set {
                this.printChangesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PrintDeletions PrintDeletions {
            get {
                return this.printDeletionsField;
            }
            set {
                this.printDeletionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrintDeletionsSpecified {
            get {
                return this.printDeletionsFieldSpecified;
            }
            set {
                this.printDeletionsFieldSpecified = value;
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
    public enum IncludeMatAllocs {
        
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
    public enum IncludeLabAllocs {
        
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
    public enum PrintAdditions {
        
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
    public enum PrintChanges {
        
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
    public enum PrintDeletions {
        
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
    public partial class XslStylesheet {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Job {
        
        private JobFilterType filterTypeField;
        
        private string filterValueField;
        
        public Job() {
            this.filterTypeField = JobFilterType.A;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(JobFilterType.A)]
        public JobFilterType FilterType {
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
    public enum JobFilterType {
        
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
    public partial class Query {
        
        private Option optionField;
        
        private QueryFilter filterField;
        
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
    public partial class QueryFilter {
        
        private Job jobField;
        
        /// <remarks/>
        public Job Job {
            get {
                return this.jobField;
            }
            set {
                this.jobField = value;
            }
        }
    }
}
