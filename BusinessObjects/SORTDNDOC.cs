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
namespace SYSPRO.NET.BusinessObjects.SORTDNDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostDispatchNotes {
        
        private PostDispatchNotesDispatchNote[] dispatchNoteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DispatchNote")]
        public PostDispatchNotesDispatchNote[] DispatchNote {
            get {
                return this.dispatchNoteField;
            }
            set {
                this.dispatchNoteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostDispatchNotesDispatchNote {
        
        private PostDispatchNotesDispatchNoteDispatchHeader dispatchHeaderField;
        
        private PostDispatchNotesDispatchNoteDispatchDetails dispatchDetailsField;
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchHeader DispatchHeader {
            get {
                return this.dispatchHeaderField;
            }
            set {
                this.dispatchHeaderField = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchDetails DispatchDetails {
            get {
                return this.dispatchDetailsField;
            }
            set {
                this.dispatchDetailsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostDispatchNotesDispatchNoteDispatchHeader {
        
        private string salesOrderField;
        
        private string shippingInstrsField;
        
        private string customerNameField;
        
        private string shipAddress1Field;
        
        private string shipAddress2Field;
        
        private string shipAddress3Field;
        
        private string shipAddress4Field;
        
        private string shipAddress5Field;
        
        private string shipPostalCodeField;
        
        private string multiShipCodeField;
        
        private string specialInstrsField;
        
        private string plannedDispatchDateField;
        
        private string userDefined1Field;
        
        private string userDefined2Field;
        
        private string dispatchNoteNumberField;
        
        private string[] dispatchCommentsField;
        
        private string nationalityField;
        
        private string deliveryTermsField;
        
        private string transactionNatureField;
        
        private string transportModeField;
        
        private string processFlagField;
        
        private string stateField;
        
        private string countyZipField;
        
        private string cityField;
        
        private string companyTaxNumberField;
        
        private PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted dispatchStatusPrintedField;
        
        private string actualDispatchDateField;
        
        private string eSignatureField;
        
        public PostDispatchNotesDispatchNoteDispatchHeader() {
            this.dispatchStatusPrintedField = PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted.N;
        }
        
        /// <remarks/>
        public string SalesOrder {
            get {
                return this.salesOrderField;
            }
            set {
                this.salesOrderField = value;
            }
        }
        
        /// <remarks/>
        public string ShippingInstrs {
            get {
                return this.shippingInstrsField;
            }
            set {
                this.shippingInstrsField = value;
            }
        }
        
        /// <remarks/>
        public string CustomerName {
            get {
                return this.customerNameField;
            }
            set {
                this.customerNameField = value;
            }
        }
        
        /// <remarks/>
        public string ShipAddress1 {
            get {
                return this.shipAddress1Field;
            }
            set {
                this.shipAddress1Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipAddress2 {
            get {
                return this.shipAddress2Field;
            }
            set {
                this.shipAddress2Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipAddress3 {
            get {
                return this.shipAddress3Field;
            }
            set {
                this.shipAddress3Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipAddress4 {
            get {
                return this.shipAddress4Field;
            }
            set {
                this.shipAddress4Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipAddress5 {
            get {
                return this.shipAddress5Field;
            }
            set {
                this.shipAddress5Field = value;
            }
        }
        
        /// <remarks/>
        public string ShipPostalCode {
            get {
                return this.shipPostalCodeField;
            }
            set {
                this.shipPostalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string MultiShipCode {
            get {
                return this.multiShipCodeField;
            }
            set {
                this.multiShipCodeField = value;
            }
        }
        
        /// <remarks/>
        public string SpecialInstrs {
            get {
                return this.specialInstrsField;
            }
            set {
                this.specialInstrsField = value;
            }
        }
        
        /// <remarks/>
        public string PlannedDispatchDate {
            get {
                return this.plannedDispatchDateField;
            }
            set {
                this.plannedDispatchDateField = value;
            }
        }
        
        /// <remarks/>
        public string UserDefined1 {
            get {
                return this.userDefined1Field;
            }
            set {
                this.userDefined1Field = value;
            }
        }
        
        /// <remarks/>
        public string UserDefined2 {
            get {
                return this.userDefined2Field;
            }
            set {
                this.userDefined2Field = value;
            }
        }
        
        /// <remarks/>
        public string DispatchNoteNumber {
            get {
                return this.dispatchNoteNumberField;
            }
            set {
                this.dispatchNoteNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DispatchComments")]
        public string[] DispatchComments {
            get {
                return this.dispatchCommentsField;
            }
            set {
                this.dispatchCommentsField = value;
            }
        }
        
        /// <remarks/>
        public string Nationality {
            get {
                return this.nationalityField;
            }
            set {
                this.nationalityField = value;
            }
        }
        
        /// <remarks/>
        public string DeliveryTerms {
            get {
                return this.deliveryTermsField;
            }
            set {
                this.deliveryTermsField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionNature {
            get {
                return this.transactionNatureField;
            }
            set {
                this.transactionNatureField = value;
            }
        }
        
        /// <remarks/>
        public string TransportMode {
            get {
                return this.transportModeField;
            }
            set {
                this.transportModeField = value;
            }
        }
        
        /// <remarks/>
        public string ProcessFlag {
            get {
                return this.processFlagField;
            }
            set {
                this.processFlagField = value;
            }
        }
        
        /// <remarks/>
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string CountyZip {
            get {
                return this.countyZipField;
            }
            set {
                this.countyZipField = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyTaxNumber {
            get {
                return this.companyTaxNumberField;
            }
            set {
                this.companyTaxNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted.N)]
        public PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted DispatchStatusPrinted {
            get {
                return this.dispatchStatusPrintedField;
            }
            set {
                this.dispatchStatusPrintedField = value;
            }
        }
        
        /// <remarks/>
        public string ActualDispatchDate {
            get {
                return this.actualDispatchDateField;
            }
            set {
                this.actualDispatchDateField = value;
            }
        }
        
        /// <remarks/>
        public string eSignature {
            get {
                return this.eSignatureField;
            }
            set {
                this.eSignatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchHeaderDispatchStatusPrinted {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostDispatchNotesDispatchNoteDispatchDetails {
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine[] merchandiseLineField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsCommentLine[] commentLineField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLine[] miscChargeLineField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsFreightLine[] freightLineField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MerchandiseLine")]
        public PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine[] MerchandiseLine {
            get {
                return this.merchandiseLineField;
            }
            set {
                this.merchandiseLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommentLine")]
        public PostDispatchNotesDispatchNoteDispatchDetailsCommentLine[] CommentLine {
            get {
                return this.commentLineField;
            }
            set {
                this.commentLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MiscChargeLine")]
        public PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLine[] MiscChargeLine {
            get {
                return this.miscChargeLineField;
            }
            set {
                this.miscChargeLineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FreightLine")]
        public PostDispatchNotesDispatchNoteDispatchDetailsFreightLine[] FreightLine {
            get {
                return this.freightLineField;
            }
            set {
                this.freightLineField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine {
        
        private string salesOrderLineField;
        
        private string dispatchQtyField;
        
        private string unitsField;
        
        private string piecesField;
        
        private string stockingDispatchQtyField;
        
        private string lotField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBins[] binsField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineSerials[] serialsField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch overOrUnderDispatchField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineDispatchZeroQty dispatchZeroQtyField;
        
        private bool dispatchZeroQtyFieldSpecified;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBasisForDispatch basisForDispatchField;
        
        private bool basisForDispatchFieldSpecified;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBackorderShipBeforeValidation backorderShipBeforeValidationField;
        
        private bool backorderShipBeforeValidationFieldSpecified;
        
        public PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLine() {
            this.overOrUnderDispatchField = PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch.N;
        }
        
        /// <remarks/>
        public string SalesOrderLine {
            get {
                return this.salesOrderLineField;
            }
            set {
                this.salesOrderLineField = value;
            }
        }
        
        /// <remarks/>
        public string DispatchQty {
            get {
                return this.dispatchQtyField;
            }
            set {
                this.dispatchQtyField = value;
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
        public string StockingDispatchQty {
            get {
                return this.stockingDispatchQtyField;
            }
            set {
                this.stockingDispatchQtyField = value;
            }
        }
        
        /// <remarks/>
        public string Lot {
            get {
                return this.lotField;
            }
            set {
                this.lotField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Bins")]
        public PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBins[] Bins {
            get {
                return this.binsField;
            }
            set {
                this.binsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Serials")]
        public PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineSerials[] Serials {
            get {
                return this.serialsField;
            }
            set {
                this.serialsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch.N)]
        public PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch OverOrUnderDispatch {
            get {
                return this.overOrUnderDispatchField;
            }
            set {
                this.overOrUnderDispatchField = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineDispatchZeroQty DispatchZeroQty {
            get {
                return this.dispatchZeroQtyField;
            }
            set {
                this.dispatchZeroQtyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DispatchZeroQtySpecified {
            get {
                return this.dispatchZeroQtyFieldSpecified;
            }
            set {
                this.dispatchZeroQtyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBasisForDispatch BasisForDispatch {
            get {
                return this.basisForDispatchField;
            }
            set {
                this.basisForDispatchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BasisForDispatchSpecified {
            get {
                return this.basisForDispatchFieldSpecified;
            }
            set {
                this.basisForDispatchFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBackorderShipBeforeValidation BackorderShipBeforeValidation {
            get {
                return this.backorderShipBeforeValidationField;
            }
            set {
                this.backorderShipBeforeValidationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BackorderShipBeforeValidationSpecified {
            get {
                return this.backorderShipBeforeValidationFieldSpecified;
            }
            set {
                this.backorderShipBeforeValidationFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBins {
        
        private string binLocationField;
        
        private string binQuantityField;
        
        private string binUnitsField;
        
        private string binPiecesField;
        
        /// <remarks/>
        public string BinLocation {
            get {
                return this.binLocationField;
            }
            set {
                this.binLocationField = value;
            }
        }
        
        /// <remarks/>
        public string BinQuantity {
            get {
                return this.binQuantityField;
            }
            set {
                this.binQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string BinUnits {
            get {
                return this.binUnitsField;
            }
            set {
                this.binUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string BinPieces {
            get {
                return this.binPiecesField;
            }
            set {
                this.binPiecesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineSerials {
        
        private string serialNumberField;
        
        private string serialQuantityField;
        
        private string serialUnitsField;
        
        private string serialPiecesField;
        
        private string serialCreationDateField;
        
        private string serialExpiryDateField;
        
        private string serialScrapDateField;
        
        private string serialLocationField;
        
        /// <remarks/>
        public string SerialNumber {
            get {
                return this.serialNumberField;
            }
            set {
                this.serialNumberField = value;
            }
        }
        
        /// <remarks/>
        public string SerialQuantity {
            get {
                return this.serialQuantityField;
            }
            set {
                this.serialQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string SerialUnits {
            get {
                return this.serialUnitsField;
            }
            set {
                this.serialUnitsField = value;
            }
        }
        
        /// <remarks/>
        public string SerialPieces {
            get {
                return this.serialPiecesField;
            }
            set {
                this.serialPiecesField = value;
            }
        }
        
        /// <remarks/>
        public string SerialCreationDate {
            get {
                return this.serialCreationDateField;
            }
            set {
                this.serialCreationDateField = value;
            }
        }
        
        /// <remarks/>
        public string SerialExpiryDate {
            get {
                return this.serialExpiryDateField;
            }
            set {
                this.serialExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        public string SerialScrapDate {
            get {
                return this.serialScrapDateField;
            }
            set {
                this.serialScrapDateField = value;
            }
        }
        
        /// <remarks/>
        public string SerialLocation {
            get {
                return this.serialLocationField;
            }
            set {
                this.serialLocationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineOverOrUnderDispatch {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineDispatchZeroQty {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBasisForDispatch {
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsMerchandiseLineBackorderShipBeforeValidation {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostDispatchNotesDispatchNoteDispatchDetailsCommentLine {
        
        private string commentField;
        
        private string attachedLineNumberField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType commentTypeField;
        
        public PostDispatchNotesDispatchNoteDispatchDetailsCommentLine() {
            this.commentTypeField = PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType.I;
        }
        
        /// <remarks/>
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public string AttachedLineNumber {
            get {
                return this.attachedLineNumberField;
            }
            set {
                this.attachedLineNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType.I)]
        public PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType CommentType {
            get {
                return this.commentTypeField;
            }
            set {
                this.commentTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsCommentLineCommentType {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLine {
        
        private string miscChargeValueField;
        
        private string miscChargeCostField;
        
        private string miscProductClassField;
        
        private string miscTaxCodeField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotTaxable miscNotTaxableField;
        
        private bool miscNotTaxableFieldSpecified;
        
        private string miscFstCodeField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotFstTaxable miscNotFstTaxableField;
        
        private bool miscNotFstTaxableFieldSpecified;
        
        private string miscDescriptionField;
        
        /// <remarks/>
        public string MiscChargeValue {
            get {
                return this.miscChargeValueField;
            }
            set {
                this.miscChargeValueField = value;
            }
        }
        
        /// <remarks/>
        public string MiscChargeCost {
            get {
                return this.miscChargeCostField;
            }
            set {
                this.miscChargeCostField = value;
            }
        }
        
        /// <remarks/>
        public string MiscProductClass {
            get {
                return this.miscProductClassField;
            }
            set {
                this.miscProductClassField = value;
            }
        }
        
        /// <remarks/>
        public string MiscTaxCode {
            get {
                return this.miscTaxCodeField;
            }
            set {
                this.miscTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotTaxable MiscNotTaxable {
            get {
                return this.miscNotTaxableField;
            }
            set {
                this.miscNotTaxableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MiscNotTaxableSpecified {
            get {
                return this.miscNotTaxableFieldSpecified;
            }
            set {
                this.miscNotTaxableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string MiscFstCode {
            get {
                return this.miscFstCodeField;
            }
            set {
                this.miscFstCodeField = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotFstTaxable MiscNotFstTaxable {
            get {
                return this.miscNotFstTaxableField;
            }
            set {
                this.miscNotFstTaxableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MiscNotFstTaxableSpecified {
            get {
                return this.miscNotFstTaxableFieldSpecified;
            }
            set {
                this.miscNotFstTaxableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string MiscDescription {
            get {
                return this.miscDescriptionField;
            }
            set {
                this.miscDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotTaxable {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsMiscChargeLineMiscNotFstTaxable {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        
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
    public partial class PostDispatchNotesDispatchNoteDispatchDetailsFreightLine {
        
        private string freightValueField;
        
        private string freightCostField;
        
        private string freightTaxCodeField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotTaxable freightNotTaxableField;
        
        private bool freightNotTaxableFieldSpecified;
        
        private string freightFstCodeField;
        
        private PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotFstTaxable freightNotFstTaxableField;
        
        private bool freightNotFstTaxableFieldSpecified;
        
        /// <remarks/>
        public string FreightValue {
            get {
                return this.freightValueField;
            }
            set {
                this.freightValueField = value;
            }
        }
        
        /// <remarks/>
        public string FreightCost {
            get {
                return this.freightCostField;
            }
            set {
                this.freightCostField = value;
            }
        }
        
        /// <remarks/>
        public string FreightTaxCode {
            get {
                return this.freightTaxCodeField;
            }
            set {
                this.freightTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotTaxable FreightNotTaxable {
            get {
                return this.freightNotTaxableField;
            }
            set {
                this.freightNotTaxableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreightNotTaxableSpecified {
            get {
                return this.freightNotTaxableFieldSpecified;
            }
            set {
                this.freightNotTaxableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string FreightFstCode {
            get {
                return this.freightFstCodeField;
            }
            set {
                this.freightFstCodeField = value;
            }
        }
        
        /// <remarks/>
        public PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotFstTaxable FreightNotFstTaxable {
            get {
                return this.freightNotFstTaxableField;
            }
            set {
                this.freightNotFstTaxableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FreightNotFstTaxableSpecified {
            get {
                return this.freightNotFstTaxableFieldSpecified;
            }
            set {
                this.freightNotFstTaxableFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotTaxable {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostDispatchNotesDispatchNoteDispatchDetailsFreightLineFreightNotFstTaxable {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
}
