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
namespace SYSPRO.NET.BusinessObjects.PORRLR {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Build {
        
        private string shipmentReferenceField;
        
        private string vesselField;
        
        private string departureDateField;
        
        /// <remarks/>
        public string ShipmentReference {
            get {
                return this.shipmentReferenceField;
            }
            set {
                this.shipmentReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string Vessel {
            get {
                return this.vesselField;
            }
            set {
                this.vesselField = value;
            }
        }
        
        /// <remarks/>
        public string DepartureDate {
            get {
                return this.departureDateField;
            }
            set {
                this.departureDateField = value;
            }
        }
    }
}
