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
namespace SYSPRO.NET.BusinessObjects.ASSTCIDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostAssetCount {
        
        private PostAssetCountItem[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public PostAssetCountItem[] Item {
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
    public partial class PostAssetCountItem {
        
        private string branchField;
        
        private string locationField;
        
        private string assetField;
        
        private string assetIdField;
        
        private string qtyCapturedField;
        
        /// <remarks/>
        public string Branch {
            get {
                return this.branchField;
            }
            set {
                this.branchField = value;
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
        public string Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <remarks/>
        public string AssetId {
            get {
                return this.assetIdField;
            }
            set {
                this.assetIdField = value;
            }
        }
        
        /// <remarks/>
        public string QtyCaptured {
            get {
                return this.qtyCapturedField;
            }
            set {
                this.qtyCapturedField = value;
            }
        }
    }
}
