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
namespace SYSPRO.NET.BusinessObjects.BOMTSOOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BillOfMaterialOptions {
        
        private BillOfMaterialOptionsUpdateSummary[] updateSummaryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UpdateSummary")]
        public BillOfMaterialOptionsUpdateSummary[] UpdateSummary {
            get {
                return this.updateSummaryField;
            }
            set {
                this.updateSummaryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class BillOfMaterialOptionsUpdateSummary {
        
        private string optionsChangedField;
        
        /// <remarks/>
        public string OptionsChanged {
            get {
                return this.optionsChangedField;
            }
            set {
                this.optionsChangedField = value;
            }
        }
    }
}
