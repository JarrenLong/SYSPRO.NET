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
namespace SYSPRO.NET.BusinessObjects.SWSTMGDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Category {
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        W,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Message {
        
        private string typeField;
        
        private string operatorRoleField;
        
        private System.DateTime dateCreatedField;
        
        private System.DateTime timeCreatedField;
        
        private string messageKeyField;
        
        private System.DateTime expiryDateField;
        
        private bool expiryDateFieldSpecified;
        
        private System.DateTime expiryTimeField;
        
        private bool expiryTimeFieldSpecified;
        
        private Category categoryField;
        
        private bool categoryFieldSpecified;
        
        private Status statusField;
        
        private bool statusFieldSpecified;
        
        private sbyte actionIdField;
        
        private bool actionIdFieldSpecified;
        
        private string subjectField;
        
        private Message message1Field;
        
        private sbyte priorityField;
        
        private bool priorityFieldSpecified;
        
        private string actioningOperatorField;
        
        private string workflowNameField;
        
        private sbyte workflowKeyField;
        
        private bool workflowKeyFieldSpecified;
        
        private string[] textField;
        
        /// <remarks/>
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        public string OperatorRole {
            get {
                return this.operatorRoleField;
            }
            set {
                this.operatorRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DateCreated {
            get {
                return this.dateCreatedField;
            }
            set {
                this.dateCreatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime TimeCreated {
            get {
                return this.timeCreatedField;
            }
            set {
                this.timeCreatedField = value;
            }
        }
        
        /// <remarks/>
        public string MessageKey {
            get {
                return this.messageKeyField;
            }
            set {
                this.messageKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime ExpiryDate {
            get {
                return this.expiryDateField;
            }
            set {
                this.expiryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpiryDateSpecified {
            get {
                return this.expiryDateFieldSpecified;
            }
            set {
                this.expiryDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime ExpiryTime {
            get {
                return this.expiryTimeField;
            }
            set {
                this.expiryTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpiryTimeSpecified {
            get {
                return this.expiryTimeFieldSpecified;
            }
            set {
                this.expiryTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Category Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategorySpecified {
            get {
                return this.categoryFieldSpecified;
            }
            set {
                this.categoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public Status Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified {
            get {
                return this.statusFieldSpecified;
            }
            set {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public sbyte ActionId {
            get {
                return this.actionIdField;
            }
            set {
                this.actionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionIdSpecified {
            get {
                return this.actionIdFieldSpecified;
            }
            set {
                this.actionIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string Subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Message")]
        public Message Message1 {
            get {
                return this.message1Field;
            }
            set {
                this.message1Field = value;
            }
        }
        
        /// <remarks/>
        public sbyte Priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrioritySpecified {
            get {
                return this.priorityFieldSpecified;
            }
            set {
                this.priorityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string ActioningOperator {
            get {
                return this.actioningOperatorField;
            }
            set {
                this.actioningOperatorField = value;
            }
        }
        
        /// <remarks/>
        public string WorkflowName {
            get {
                return this.workflowNameField;
            }
            set {
                this.workflowNameField = value;
            }
        }
        
        /// <remarks/>
        public sbyte WorkflowKey {
            get {
                return this.workflowKeyField;
            }
            set {
                this.workflowKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WorkflowKeySpecified {
            get {
                return this.workflowKeyFieldSpecified;
            }
            set {
                this.workflowKeyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum Status {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostMessages {
        
        private Message[] messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Message")]
        public Message[] Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
}
