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
namespace SYSPRO.NET.BusinessObjects.PORTRBDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostRequisitionBudget {
        
        private PostRequisitionBudgetItem[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public PostRequisitionBudgetItem[] Item {
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
    public partial class PostRequisitionBudgetItem {
        
        private string requisitionGroupField;
        
        private string productClassField;
        
        private string stockCodeField;
        
        private string budgetYearField;
        
        private object groupBudget1Field;
        
        private object groupBudget2Field;
        
        private object groupBudget3Field;
        
        private object groupBudget4Field;
        
        private object groupBudget5Field;
        
        private object groupBudget6Field;
        
        private object groupBudget7Field;
        
        private object groupBudget8Field;
        
        private object groupBudget9Field;
        
        private object groupBudget10Field;
        
        private object groupBudget11Field;
        
        private string groupBudget12Field;
        
        private string spreadAmountField;
        
        private PostRequisitionBudgetItemSpreadType spreadTypeField;
        
        private bool spreadTypeFieldSpecified;
        
        private PostRequisitionBudgetItemNonStockedEntry nonStockedEntryField;
        
        private bool nonStockedEntryFieldSpecified;
        
        /// <remarks/>
        public string RequisitionGroup {
            get {
                return this.requisitionGroupField;
            }
            set {
                this.requisitionGroupField = value;
            }
        }
        
        /// <remarks/>
        public string ProductClass {
            get {
                return this.productClassField;
            }
            set {
                this.productClassField = value;
            }
        }
        
        /// <remarks/>
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
        
        /// <remarks/>
        public string BudgetYear {
            get {
                return this.budgetYearField;
            }
            set {
                this.budgetYearField = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget1 {
            get {
                return this.groupBudget1Field;
            }
            set {
                this.groupBudget1Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget2 {
            get {
                return this.groupBudget2Field;
            }
            set {
                this.groupBudget2Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget3 {
            get {
                return this.groupBudget3Field;
            }
            set {
                this.groupBudget3Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget4 {
            get {
                return this.groupBudget4Field;
            }
            set {
                this.groupBudget4Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget5 {
            get {
                return this.groupBudget5Field;
            }
            set {
                this.groupBudget5Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget6 {
            get {
                return this.groupBudget6Field;
            }
            set {
                this.groupBudget6Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget7 {
            get {
                return this.groupBudget7Field;
            }
            set {
                this.groupBudget7Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget8 {
            get {
                return this.groupBudget8Field;
            }
            set {
                this.groupBudget8Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget9 {
            get {
                return this.groupBudget9Field;
            }
            set {
                this.groupBudget9Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget10 {
            get {
                return this.groupBudget10Field;
            }
            set {
                this.groupBudget10Field = value;
            }
        }
        
        /// <remarks/>
        public object GroupBudget11 {
            get {
                return this.groupBudget11Field;
            }
            set {
                this.groupBudget11Field = value;
            }
        }
        
        /// <remarks/>
        public string GroupBudget12 {
            get {
                return this.groupBudget12Field;
            }
            set {
                this.groupBudget12Field = value;
            }
        }
        
        /// <remarks/>
        public string SpreadAmount {
            get {
                return this.spreadAmountField;
            }
            set {
                this.spreadAmountField = value;
            }
        }
        
        /// <remarks/>
        public PostRequisitionBudgetItemSpreadType SpreadType {
            get {
                return this.spreadTypeField;
            }
            set {
                this.spreadTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpreadTypeSpecified {
            get {
                return this.spreadTypeFieldSpecified;
            }
            set {
                this.spreadTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PostRequisitionBudgetItemNonStockedEntry NonStockedEntry {
            get {
                return this.nonStockedEntryField;
            }
            set {
                this.nonStockedEntryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonStockedEntrySpecified {
            get {
                return this.nonStockedEntryFieldSpecified;
            }
            set {
                this.nonStockedEntryFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostRequisitionBudgetItemSpreadType {
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostRequisitionBudgetItemNonStockedEntry {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
}
