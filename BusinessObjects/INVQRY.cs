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
namespace SYSPRO.NET.BusinessObjects.INVQRY {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Filter {
        
        private Warehouse warehouseField;
        
        /// <remarks/>
        public Warehouse Warehouse {
            get {
                return this.warehouseField;
            }
            set {
                this.warehouseField = value;
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
    public partial class Warehouse {
        
        private WarehouseFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public WarehouseFilterType FilterType {
            get {
                return this.filterTypeField;
            }
            set {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FilterTypeSpecified {
            get {
                return this.filterTypeFieldSpecified;
            }
            set {
                this.filterTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue {
            get {
                return this.filterValueField;
            }
            set {
                this.filterValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum WarehouseFilterType {
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeCustomForms {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeBins {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        Z,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeHistory {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeLots {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        Z,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementAdjustments {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementBinTransfers {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementCostChanges {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementCostMods {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementCreditNotes {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementDebitNotes {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementDispatchNotes {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementInvoices {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementIssues {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementPhysical {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementReceipts {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeEcc {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovements {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeMovementTransfers {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeSerials {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        Z,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeNarrations {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReturnNarrationsinBlock {
        
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
    public partial class Key {
        
        private string stockCodeField;
        
        /// <remarks/>
        public string StockCode {
            get {
                return this.stockCodeField;
            }
            set {
                this.stockCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum MovementDateSequence {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        D,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Option {
        
        private string multiMediaImageTypeField;
        
        private IncludeHistory includeHistoryField;
        
        private bool includeHistoryFieldSpecified;
        
        private IncludeBins includeBinsField;
        
        private bool includeBinsFieldSpecified;
        
        private IncludeLots includeLotsField;
        
        private bool includeLotsFieldSpecified;
        
        private IncludeSerials includeSerialsField;
        
        private bool includeSerialsFieldSpecified;
        
        private IncludeMovements includeMovementsField;
        
        private bool includeMovementsFieldSpecified;
        
        private MovementDateSequence movementDateSequenceField;
        
        private bool movementDateSequenceFieldSpecified;
        
        private System.DateTime movementStartDateField;
        
        private bool movementStartDateFieldSpecified;
        
        private string maxNumberMovementsField;
        
        private IncludeCustomForms includeCustomFormsField;
        
        private bool includeCustomFormsFieldSpecified;
        
        private IncludeMovementIssues includeMovementIssuesField;
        
        private bool includeMovementIssuesFieldSpecified;
        
        private IncludeMovementTransfers includeMovementTransfersField;
        
        private bool includeMovementTransfersFieldSpecified;
        
        private IncludeMovementReceipts includeMovementReceiptsField;
        
        private bool includeMovementReceiptsFieldSpecified;
        
        private IncludeMovementPhysical includeMovementPhysicalField;
        
        private bool includeMovementPhysicalFieldSpecified;
        
        private IncludeMovementAdjustments includeMovementAdjustmentsField;
        
        private bool includeMovementAdjustmentsFieldSpecified;
        
        private IncludeMovementCostChanges includeMovementCostChangesField;
        
        private bool includeMovementCostChangesFieldSpecified;
        
        private IncludeMovementCostMods includeMovementCostModsField;
        
        private bool includeMovementCostModsFieldSpecified;
        
        private IncludeMovementBinTransfers includeMovementBinTransfersField;
        
        private bool includeMovementBinTransfersFieldSpecified;
        
        private IncludeMovementInvoices includeMovementInvoicesField;
        
        private bool includeMovementInvoicesFieldSpecified;
        
        private IncludeMovementCreditNotes includeMovementCreditNotesField;
        
        private bool includeMovementCreditNotesFieldSpecified;
        
        private IncludeMovementDebitNotes includeMovementDebitNotesField;
        
        private bool includeMovementDebitNotesFieldSpecified;
        
        private IncludeMovementDispatchNotes includeMovementDispatchNotesField;
        
        private bool includeMovementDispatchNotesFieldSpecified;
        
        private IncludeEcc includeEccField;
        
        private bool includeEccFieldSpecified;
        
        private IncludeApprovedManuf includeApprovedManufField;
        
        private bool includeApprovedManufFieldSpecified;
        
        private IncludeNarrations includeNarrationsField;
        
        private ReturnNarrationsinBlock returnNarrationsinBlockField;
        
        private string xslStylesheetField;
        
        public Option() {
            this.includeHistoryField = IncludeHistory.Y;
            this.includeBinsField = IncludeBins.N;
            this.includeLotsField = IncludeLots.N;
            this.includeSerialsField = IncludeSerials.N;
            this.includeMovementsField = IncludeMovements.N;
            this.movementDateSequenceField = MovementDateSequence.A;
            this.includeCustomFormsField = IncludeCustomForms.N;
            this.includeMovementIssuesField = IncludeMovementIssues.Y;
            this.includeMovementTransfersField = IncludeMovementTransfers.Y;
            this.includeMovementReceiptsField = IncludeMovementReceipts.Y;
            this.includeMovementPhysicalField = IncludeMovementPhysical.Y;
            this.includeMovementAdjustmentsField = IncludeMovementAdjustments.Y;
            this.includeMovementCostChangesField = IncludeMovementCostChanges.Y;
            this.includeMovementCostModsField = IncludeMovementCostMods.Y;
            this.includeMovementBinTransfersField = IncludeMovementBinTransfers.Y;
            this.includeMovementInvoicesField = IncludeMovementInvoices.Y;
            this.includeMovementCreditNotesField = IncludeMovementCreditNotes.Y;
            this.includeMovementDebitNotesField = IncludeMovementDebitNotes.Y;
            this.includeMovementDispatchNotesField = IncludeMovementDispatchNotes.Y;
            this.includeEccField = IncludeEcc.Y;
            this.includeApprovedManufField = IncludeApprovedManuf.Y;
            this.includeNarrationsField = IncludeNarrations.Y;
            this.returnNarrationsinBlockField = ReturnNarrationsinBlock.N;
        }
        
        /// <remarks/>
        public string MultiMediaImageType {
            get {
                return this.multiMediaImageTypeField;
            }
            set {
                this.multiMediaImageTypeField = value;
            }
        }
        
        /// <remarks/>
        public IncludeHistory IncludeHistory {
            get {
                return this.includeHistoryField;
            }
            set {
                this.includeHistoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeHistorySpecified {
            get {
                return this.includeHistoryFieldSpecified;
            }
            set {
                this.includeHistoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeBins IncludeBins {
            get {
                return this.includeBinsField;
            }
            set {
                this.includeBinsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeBinsSpecified {
            get {
                return this.includeBinsFieldSpecified;
            }
            set {
                this.includeBinsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeLots IncludeLots {
            get {
                return this.includeLotsField;
            }
            set {
                this.includeLotsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeLotsSpecified {
            get {
                return this.includeLotsFieldSpecified;
            }
            set {
                this.includeLotsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeSerials IncludeSerials {
            get {
                return this.includeSerialsField;
            }
            set {
                this.includeSerialsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeSerialsSpecified {
            get {
                return this.includeSerialsFieldSpecified;
            }
            set {
                this.includeSerialsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovements IncludeMovements {
            get {
                return this.includeMovementsField;
            }
            set {
                this.includeMovementsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementsSpecified {
            get {
                return this.includeMovementsFieldSpecified;
            }
            set {
                this.includeMovementsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public MovementDateSequence MovementDateSequence {
            get {
                return this.movementDateSequenceField;
            }
            set {
                this.movementDateSequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MovementDateSequenceSpecified {
            get {
                return this.movementDateSequenceFieldSpecified;
            }
            set {
                this.movementDateSequenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime MovementStartDate {
            get {
                return this.movementStartDateField;
            }
            set {
                this.movementStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MovementStartDateSpecified {
            get {
                return this.movementStartDateFieldSpecified;
            }
            set {
                this.movementStartDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string MaxNumberMovements {
            get {
                return this.maxNumberMovementsField;
            }
            set {
                this.maxNumberMovementsField = value;
            }
        }
        
        /// <remarks/>
        public IncludeCustomForms IncludeCustomForms {
            get {
                return this.includeCustomFormsField;
            }
            set {
                this.includeCustomFormsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeCustomFormsSpecified {
            get {
                return this.includeCustomFormsFieldSpecified;
            }
            set {
                this.includeCustomFormsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementIssues IncludeMovementIssues {
            get {
                return this.includeMovementIssuesField;
            }
            set {
                this.includeMovementIssuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementIssuesSpecified {
            get {
                return this.includeMovementIssuesFieldSpecified;
            }
            set {
                this.includeMovementIssuesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementTransfers IncludeMovementTransfers {
            get {
                return this.includeMovementTransfersField;
            }
            set {
                this.includeMovementTransfersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementTransfersSpecified {
            get {
                return this.includeMovementTransfersFieldSpecified;
            }
            set {
                this.includeMovementTransfersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementReceipts IncludeMovementReceipts {
            get {
                return this.includeMovementReceiptsField;
            }
            set {
                this.includeMovementReceiptsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementReceiptsSpecified {
            get {
                return this.includeMovementReceiptsFieldSpecified;
            }
            set {
                this.includeMovementReceiptsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementPhysical IncludeMovementPhysical {
            get {
                return this.includeMovementPhysicalField;
            }
            set {
                this.includeMovementPhysicalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementPhysicalSpecified {
            get {
                return this.includeMovementPhysicalFieldSpecified;
            }
            set {
                this.includeMovementPhysicalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementAdjustments IncludeMovementAdjustments {
            get {
                return this.includeMovementAdjustmentsField;
            }
            set {
                this.includeMovementAdjustmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementAdjustmentsSpecified {
            get {
                return this.includeMovementAdjustmentsFieldSpecified;
            }
            set {
                this.includeMovementAdjustmentsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementCostChanges IncludeMovementCostChanges {
            get {
                return this.includeMovementCostChangesField;
            }
            set {
                this.includeMovementCostChangesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementCostChangesSpecified {
            get {
                return this.includeMovementCostChangesFieldSpecified;
            }
            set {
                this.includeMovementCostChangesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementCostMods IncludeMovementCostMods {
            get {
                return this.includeMovementCostModsField;
            }
            set {
                this.includeMovementCostModsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementCostModsSpecified {
            get {
                return this.includeMovementCostModsFieldSpecified;
            }
            set {
                this.includeMovementCostModsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementBinTransfers IncludeMovementBinTransfers {
            get {
                return this.includeMovementBinTransfersField;
            }
            set {
                this.includeMovementBinTransfersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementBinTransfersSpecified {
            get {
                return this.includeMovementBinTransfersFieldSpecified;
            }
            set {
                this.includeMovementBinTransfersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementInvoices IncludeMovementInvoices {
            get {
                return this.includeMovementInvoicesField;
            }
            set {
                this.includeMovementInvoicesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementInvoicesSpecified {
            get {
                return this.includeMovementInvoicesFieldSpecified;
            }
            set {
                this.includeMovementInvoicesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementCreditNotes IncludeMovementCreditNotes {
            get {
                return this.includeMovementCreditNotesField;
            }
            set {
                this.includeMovementCreditNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementCreditNotesSpecified {
            get {
                return this.includeMovementCreditNotesFieldSpecified;
            }
            set {
                this.includeMovementCreditNotesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementDebitNotes IncludeMovementDebitNotes {
            get {
                return this.includeMovementDebitNotesField;
            }
            set {
                this.includeMovementDebitNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementDebitNotesSpecified {
            get {
                return this.includeMovementDebitNotesFieldSpecified;
            }
            set {
                this.includeMovementDebitNotesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeMovementDispatchNotes IncludeMovementDispatchNotes {
            get {
                return this.includeMovementDispatchNotesField;
            }
            set {
                this.includeMovementDispatchNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMovementDispatchNotesSpecified {
            get {
                return this.includeMovementDispatchNotesFieldSpecified;
            }
            set {
                this.includeMovementDispatchNotesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeEcc IncludeEcc {
            get {
                return this.includeEccField;
            }
            set {
                this.includeEccField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeEccSpecified {
            get {
                return this.includeEccFieldSpecified;
            }
            set {
                this.includeEccFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeApprovedManuf IncludeApprovedManuf {
            get {
                return this.includeApprovedManufField;
            }
            set {
                this.includeApprovedManufField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeApprovedManufSpecified {
            get {
                return this.includeApprovedManufFieldSpecified;
            }
            set {
                this.includeApprovedManufFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public IncludeNarrations IncludeNarrations {
            get {
                return this.includeNarrationsField;
            }
            set {
                this.includeNarrationsField = value;
            }
        }
        
        /// <remarks/>
        public ReturnNarrationsinBlock ReturnNarrationsinBlock {
            get {
                return this.returnNarrationsinBlockField;
            }
            set {
                this.returnNarrationsinBlockField = value;
            }
        }
        
        /// <remarks/>
        public string XslStylesheet {
            get {
                return this.xslStylesheetField;
            }
            set {
                this.xslStylesheetField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum IncludeApprovedManuf {
        
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Query {
        
        private Key keyField;
        
        private Option optionField;
        
        private Filter filterField;
        
        /// <remarks/>
        public Key Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public Option Option {
            get {
                return this.optionField;
            }
            set {
                this.optionField = value;
            }
        }
        
        /// <remarks/>
        public Filter Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
    }
}
