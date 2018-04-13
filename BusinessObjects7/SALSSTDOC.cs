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
namespace SYSPRO.NET.BusinessObjects.SALSSTDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SetupSalesTarget {
        
        private SetupSalesTargetItem itemField;
        
        /// <remarks/>
        public SetupSalesTargetItem Item {
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
    public partial class SetupSalesTargetItem {
        
        private SetupSalesTargetItemKey keyField;
        
        private string salesValueField;
        
        private string costValueField;
        
        private string quantityField;
        
        private string massField;
        
        private string volumeField;
        
        private SetupSalesTargetItemDistributeMethod distributeMethodField;
        
        public SetupSalesTargetItem() {
            this.distributeMethodField = SetupSalesTargetItemDistributeMethod.R;
        }
        
        /// <remarks/>
        public SetupSalesTargetItemKey Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string SalesValue {
            get {
                return this.salesValueField;
            }
            set {
                this.salesValueField = value;
            }
        }
        
        /// <remarks/>
        public string CostValue {
            get {
                return this.costValueField;
            }
            set {
                this.costValueField = value;
            }
        }
        
        /// <remarks/>
        public string Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        public string Mass {
            get {
                return this.massField;
            }
            set {
                this.massField = value;
            }
        }
        
        /// <remarks/>
        public string Volume {
            get {
                return this.volumeField;
            }
            set {
                this.volumeField = value;
            }
        }
        
        /// <remarks/>
        public SetupSalesTargetItemDistributeMethod DistributeMethod {
            get {
                return this.distributeMethodField;
            }
            set {
                this.distributeMethodField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class SetupSalesTargetItemKey {
        
        private string sequenceTypeField;
        
        private string sequence1Field;
        
        private string sequence2Field;
        
        private string sequence3Field;
        
        private string trnYearField;
        
        private string trnMonthField;
        
        /// <remarks/>
        public string SequenceType {
            get {
                return this.sequenceTypeField;
            }
            set {
                this.sequenceTypeField = value;
            }
        }
        
        /// <remarks/>
        public string Sequence1 {
            get {
                return this.sequence1Field;
            }
            set {
                this.sequence1Field = value;
            }
        }
        
        /// <remarks/>
        public string Sequence2 {
            get {
                return this.sequence2Field;
            }
            set {
                this.sequence2Field = value;
            }
        }
        
        /// <remarks/>
        public string Sequence3 {
            get {
                return this.sequence3Field;
            }
            set {
                this.sequence3Field = value;
            }
        }
        
        /// <remarks/>
        public string TrnYear {
            get {
                return this.trnYearField;
            }
            set {
                this.trnYearField = value;
            }
        }
        
        /// <remarks/>
        public string TrnMonth {
            get {
                return this.trnMonthField;
            }
            set {
                this.trnMonthField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum SetupSalesTargetItemDistributeMethod {
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        M,
    }
}
