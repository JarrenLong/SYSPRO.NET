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
namespace SYSPRO.NET.BusinessObjects.BOMSMCDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SetupBomMachine {
        
        private SetupBomMachineItem itemField;
        
        /// <remarks/>
        public SetupBomMachineItem Item {
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
    public partial class SetupBomMachineItem {
        
        private SetupBomMachineItemKey[] keyField;
        
        private string[] descriptionField;
        
        private string[] mtdStdHrsEarnedField;
        
        private string[] workCentreField;
        
        private string[] shiftIdField;
        
        private string[] stdHrsPerMonthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Key")]
        public SetupBomMachineItemKey[] Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public string[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MtdStdHrsEarned")]
        public string[] MtdStdHrsEarned {
            get {
                return this.mtdStdHrsEarnedField;
            }
            set {
                this.mtdStdHrsEarnedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkCentre")]
        public string[] WorkCentre {
            get {
                return this.workCentreField;
            }
            set {
                this.workCentreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShiftId")]
        public string[] ShiftId {
            get {
                return this.shiftIdField;
            }
            set {
                this.shiftIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StdHrsPerMonth")]
        public string[] StdHrsPerMonth {
            get {
                return this.stdHrsPerMonthField;
            }
            set {
                this.stdHrsPerMonthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SetupBomMachineItemKey {
        
        private string machineField;
        
        /// <remarks/>
        public string Machine {
            get {
                return this.machineField;
            }
            set {
                this.machineField = value;
            }
        }
    }
}
