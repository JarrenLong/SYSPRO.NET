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
namespace SYSPRO.NET.BusinessObjects.PRJTJHDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostJobHierarchy {
        
        private PostJobHierarchyItem itemField;
        
        /// <remarks/>
        public PostJobHierarchyItem Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostJobHierarchyItem {
        
        private PostJobHierarchyItemHierarchyType hierarchyTypeField;
        
        private string jobQuoteField;
        
        private string quoteLineField;
        
        private string hierHeadField;
        
        private string section1Field;
        
        private string section2Field;
        
        private string section3Field;
        
        private string section4Field;
        
        private string descriptionField;
        
        private string anticipatedVal1Field;
        
        private string anticipatedVal2Field;
        
        private string anticipatedVal3Field;
        
        private string wipCtlGlCodeField;
        
        private PostJobHierarchyItemTrackCostsOnly trackCostsOnlyField;
        
        private string wipCostTrkGlCodeField;
        
        private PostJobHierarchyItemAllowStkTran allowStkTranField;
        
        private PostJobHierarchyItemAllowNonTran allowNonTranField;
        
        private PostJobHierarchyItemAllowLabTran allowLabTranField;
        
        private PostJobHierarchyItemAllowSubTran allowSubTranField;
        
        private PostJobHierarchyItemAllowSlsTran allowSlsTranField;
        
        private bool allowSlsTranFieldSpecified;
        
        private PostJobHierarchyItemAllowPorTran allowPorTranField;
        
        private PostJobHierarchyItemPctLimit pctLimitField;
        
        public PostJobHierarchyItem() {
            this.hierarchyTypeField = PostJobHierarchyItemHierarchyType.J;
            this.trackCostsOnlyField = PostJobHierarchyItemTrackCostsOnly.N;
            this.allowStkTranField = PostJobHierarchyItemAllowStkTran.N;
            this.allowNonTranField = PostJobHierarchyItemAllowNonTran.N;
            this.allowLabTranField = PostJobHierarchyItemAllowLabTran.N;
            this.allowSubTranField = PostJobHierarchyItemAllowSubTran.N;
            this.allowPorTranField = PostJobHierarchyItemAllowPorTran.N;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemHierarchyType.J)]
        public PostJobHierarchyItemHierarchyType HierarchyType {
            get {
                return this.hierarchyTypeField;
            }
            set {
                this.hierarchyTypeField = value;
            }
        }
        
        /// <remarks/>
        public string JobQuote {
            get {
                return this.jobQuoteField;
            }
            set {
                this.jobQuoteField = value;
            }
        }
        
        /// <remarks/>
        public string QuoteLine {
            get {
                return this.quoteLineField;
            }
            set {
                this.quoteLineField = value;
            }
        }
        
        /// <remarks/>
        public string HierHead {
            get {
                return this.hierHeadField;
            }
            set {
                this.hierHeadField = value;
            }
        }
        
        /// <remarks/>
        public string Section1 {
            get {
                return this.section1Field;
            }
            set {
                this.section1Field = value;
            }
        }
        
        /// <remarks/>
        public string Section2 {
            get {
                return this.section2Field;
            }
            set {
                this.section2Field = value;
            }
        }
        
        /// <remarks/>
        public string Section3 {
            get {
                return this.section3Field;
            }
            set {
                this.section3Field = value;
            }
        }
        
        /// <remarks/>
        public string Section4 {
            get {
                return this.section4Field;
            }
            set {
                this.section4Field = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string AnticipatedVal1 {
            get {
                return this.anticipatedVal1Field;
            }
            set {
                this.anticipatedVal1Field = value;
            }
        }
        
        /// <remarks/>
        public string AnticipatedVal2 {
            get {
                return this.anticipatedVal2Field;
            }
            set {
                this.anticipatedVal2Field = value;
            }
        }
        
        /// <remarks/>
        public string AnticipatedVal3 {
            get {
                return this.anticipatedVal3Field;
            }
            set {
                this.anticipatedVal3Field = value;
            }
        }
        
        /// <remarks/>
        public string WipCtlGlCode {
            get {
                return this.wipCtlGlCodeField;
            }
            set {
                this.wipCtlGlCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemTrackCostsOnly.N)]
        public PostJobHierarchyItemTrackCostsOnly TrackCostsOnly {
            get {
                return this.trackCostsOnlyField;
            }
            set {
                this.trackCostsOnlyField = value;
            }
        }
        
        /// <remarks/>
        public string WipCostTrkGlCode {
            get {
                return this.wipCostTrkGlCodeField;
            }
            set {
                this.wipCostTrkGlCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowStkTran.N)]
        public PostJobHierarchyItemAllowStkTran AllowStkTran {
            get {
                return this.allowStkTranField;
            }
            set {
                this.allowStkTranField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowNonTran.N)]
        public PostJobHierarchyItemAllowNonTran AllowNonTran {
            get {
                return this.allowNonTranField;
            }
            set {
                this.allowNonTranField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowLabTran.N)]
        public PostJobHierarchyItemAllowLabTran AllowLabTran {
            get {
                return this.allowLabTranField;
            }
            set {
                this.allowLabTranField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowSubTran.N)]
        public PostJobHierarchyItemAllowSubTran AllowSubTran {
            get {
                return this.allowSubTranField;
            }
            set {
                this.allowSubTranField = value;
            }
        }
        
        /// <remarks/>
        public PostJobHierarchyItemAllowSlsTran AllowSlsTran {
            get {
                return this.allowSlsTranField;
            }
            set {
                this.allowSlsTranField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowSlsTranSpecified {
            get {
                return this.allowSlsTranFieldSpecified;
            }
            set {
                this.allowSlsTranFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostJobHierarchyItemAllowPorTran.N)]
        public PostJobHierarchyItemAllowPorTran AllowPorTran {
            get {
                return this.allowPorTranField;
            }
            set {
                this.allowPorTranField = value;
            }
        }
        
        /// <remarks/>
        public PostJobHierarchyItemPctLimit PctLimit {
            get {
                return this.pctLimitField;
            }
            set {
                this.pctLimitField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemHierarchyType {
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        E,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemTrackCostsOnly {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemAllowStkTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemAllowNonTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemAllowLabTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemAllowSubTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemAllowSlsTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemAllowPorTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostJobHierarchyItemPctLimit {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
}
