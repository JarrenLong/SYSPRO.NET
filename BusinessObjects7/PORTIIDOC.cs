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
namespace SYSPRO.NET.BusinessObjects.PORTIIDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum InspectionCompleted {
        
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
    public partial class Item {
        
        private string gRNNumberField;
        
        private string quantityField;
        
        private string unitOfMeasureField;
        
        private string unitsField;
        
        private string piecesField;
        
        private string documentField;
        
        private InspectionCompleted inspectionCompletedField;
        
        private bool inspectionCompletedFieldSpecified;
        
        public Item() {
            this.inspectionCompletedField = InspectionCompleted.N;
        }
        
        /// <remarks/>
        public string GRNNumber {
            get {
                return this.gRNNumberField;
            }
            set {
                this.gRNNumberField = value;
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
        public string UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
        
        /// <remarks/>
        public string Units {
            get {
                return this.unitsField;
            }
            set {
                this.unitsField = value;
            }
        }
        
        /// <remarks/>
        public string Pieces {
            get {
                return this.piecesField;
            }
            set {
                this.piecesField = value;
            }
        }
        
        /// <remarks/>
        public string Document {
            get {
                return this.documentField;
            }
            set {
                this.documentField = value;
            }
        }
        
        /// <remarks/>
        public InspectionCompleted InspectionCompleted {
            get {
                return this.inspectionCompletedField;
            }
            set {
                this.inspectionCompletedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InspectionCompletedSpecified {
            get {
                return this.inspectionCompletedFieldSpecified;
            }
            set {
                this.inspectionCompletedFieldSpecified = value;
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
    public partial class PostInspections {
        
        private Item[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public Item[] Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
}
