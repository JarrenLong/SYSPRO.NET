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
namespace SYSPRO.NET.BusinessObjects.PRJSSHDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SetupHierarchy {
        
        private SetupHierarchyItem itemField;
        
        /// <remarks/>
        public SetupHierarchyItem Item {
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
    public partial class SetupHierarchyItem {
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllowLabTran", typeof(SetupHierarchyItemAllowLabTran))]
        [System.Xml.Serialization.XmlElementAttribute("AllowNonTran", typeof(SetupHierarchyItemAllowNonTran))]
        [System.Xml.Serialization.XmlElementAttribute("AllowPorTran", typeof(SetupHierarchyItemAllowPorTran))]
        [System.Xml.Serialization.XmlElementAttribute("AllowSlsTran", typeof(SetupHierarchyItemAllowSlsTran))]
        [System.Xml.Serialization.XmlElementAttribute("AllowStkTran", typeof(SetupHierarchyItemAllowStkTran))]
        [System.Xml.Serialization.XmlElementAttribute("AllowSubTran", typeof(SetupHierarchyItemAllowSubTran))]
        [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Key", typeof(SetupHierarchyItemKey))]
        [System.Xml.Serialization.XmlElementAttribute("PctLimit", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("TrackCostsOnly", typeof(SetupHierarchyItemTrackCostsOnly))]
        [System.Xml.Serialization.XmlElementAttribute("WipCostTrkGlCode", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("WipCtlGlCode", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupHierarchyItemAllowLabTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupHierarchyItemAllowNonTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupHierarchyItemAllowPorTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupHierarchyItemAllowSlsTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupHierarchyItemAllowStkTran {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupHierarchyItemAllowSubTran {
        
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
    public partial class SetupHierarchyItemKey {
        
        private SetupHierarchyItemKeyHierarchyType hierarchyTypeField;
        
        private string hierarchyCodeField;
        
        private string hierHeadField;
        
        private string section1Field;
        
        private string section2Field;
        
        private string section3Field;
        
        private string section4Field;
        
        public SetupHierarchyItemKey() {
            this.hierarchyTypeField = SetupHierarchyItemKeyHierarchyType.L;
        }
        
        /// <remarks/>
        public SetupHierarchyItemKeyHierarchyType HierarchyType {
            get {
                return this.hierarchyTypeField;
            }
            set {
                this.hierarchyTypeField = value;
            }
        }
        
        /// <remarks/>
        public string HierarchyCode {
            get {
                return this.hierarchyCodeField;
            }
            set {
                this.hierarchyCodeField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupHierarchyItemKeyHierarchyType {
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupHierarchyItemTrackCostsOnly {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        AllowLabTran,
        
        /// <remarks/>
        AllowNonTran,
        
        /// <remarks/>
        AllowPorTran,
        
        /// <remarks/>
        AllowSlsTran,
        
        /// <remarks/>
        AllowStkTran,
        
        /// <remarks/>
        AllowSubTran,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        Key,
        
        /// <remarks/>
        PctLimit,
        
        /// <remarks/>
        TrackCostsOnly,
        
        /// <remarks/>
        WipCostTrkGlCode,
        
        /// <remarks/>
        WipCtlGlCode,
    }
}
