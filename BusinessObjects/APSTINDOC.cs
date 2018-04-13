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
namespace SYSPRO.NET.BusinessObjects.APSTINDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DiscountBasis {
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        V,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Item {
        
        private string eSignatureField;
        
        private string supplierField;
        
        private TransactionCode transactionCodeField;
        
        private string branchField;
        
        private string invoiceField;
        
        private string transactionValueField;
        
        private string freightChargeField;
        
        private string miscellaneousChargeField;
        
        private string notationField;
        
        private string transactionReferenceField;
        
        private string journalNotationField;
        
        private DiscountBasis discountBasisField;
        
        private bool discountBasisFieldSpecified;
        
        private string discountableValueField;
        
        private string discountPercentageValueField;
        
        private string discountAdjustmentField;
        
        private string invoiceDateField;
        
        private string dueDateField;
        
        private string discountDateField;
        
        private string exchRateAtEntryField;
        
        private string fixedExchRateField;
        
        private TaxBasis taxBasisField;
        
        private string calculateQstOnTaxField;
        
        private TaxCode taxCodeField;
        
        private string taxValueField;
        
        private SecondTaxCode secondTaxCodeField;
        
        private string secondTaxValueField;
        
        private EcAcquisition ecAcquisitionField;
        
        private bool ecAcquisitionFieldSpecified;
        
        private string nationalityField;
        
        private string analysisEntryField;
        
        private ItemAnalysisLineEntry analysisLineEntryField;
        
        private GrnDetails[] grnDetailsField;
        
        private LedgerDistribution[] ledgerDistributionField;
        
        public Item() {
            this.transactionCodeField = TransactionCode.I;
            this.discountBasisField = DiscountBasis.T;
            this.taxBasisField = TaxBasis.E;
            this.ecAcquisitionField = EcAcquisition.Y;
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
        
        /// <remarks/>
        public string Supplier {
            get {
                return this.supplierField;
            }
            set {
                this.supplierField = value;
            }
        }
        
        /// <remarks/>
        public TransactionCode TransactionCode {
            get {
                return this.transactionCodeField;
            }
            set {
                this.transactionCodeField = value;
            }
        }
        
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
        public string Invoice {
            get {
                return this.invoiceField;
            }
            set {
                this.invoiceField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionValue {
            get {
                return this.transactionValueField;
            }
            set {
                this.transactionValueField = value;
            }
        }
        
        /// <remarks/>
        public string FreightCharge {
            get {
                return this.freightChargeField;
            }
            set {
                this.freightChargeField = value;
            }
        }
        
        /// <remarks/>
        public string MiscellaneousCharge {
            get {
                return this.miscellaneousChargeField;
            }
            set {
                this.miscellaneousChargeField = value;
            }
        }
        
        /// <remarks/>
        public string Notation {
            get {
                return this.notationField;
            }
            set {
                this.notationField = value;
            }
        }
        
        /// <remarks/>
        public string TransactionReference {
            get {
                return this.transactionReferenceField;
            }
            set {
                this.transactionReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string JournalNotation {
            get {
                return this.journalNotationField;
            }
            set {
                this.journalNotationField = value;
            }
        }
        
        /// <remarks/>
        public DiscountBasis DiscountBasis {
            get {
                return this.discountBasisField;
            }
            set {
                this.discountBasisField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountBasisSpecified {
            get {
                return this.discountBasisFieldSpecified;
            }
            set {
                this.discountBasisFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string DiscountableValue {
            get {
                return this.discountableValueField;
            }
            set {
                this.discountableValueField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountPercentageValue {
            get {
                return this.discountPercentageValueField;
            }
            set {
                this.discountPercentageValueField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountAdjustment {
            get {
                return this.discountAdjustmentField;
            }
            set {
                this.discountAdjustmentField = value;
            }
        }
        
        /// <remarks/>
        public string InvoiceDate {
            get {
                return this.invoiceDateField;
            }
            set {
                this.invoiceDateField = value;
            }
        }
        
        /// <remarks/>
        public string DueDate {
            get {
                return this.dueDateField;
            }
            set {
                this.dueDateField = value;
            }
        }
        
        /// <remarks/>
        public string DiscountDate {
            get {
                return this.discountDateField;
            }
            set {
                this.discountDateField = value;
            }
        }
        
        /// <remarks/>
        public string ExchRateAtEntry {
            get {
                return this.exchRateAtEntryField;
            }
            set {
                this.exchRateAtEntryField = value;
            }
        }
        
        /// <remarks/>
        public string FixedExchRate {
            get {
                return this.fixedExchRateField;
            }
            set {
                this.fixedExchRateField = value;
            }
        }
        
        /// <remarks/>
        public TaxBasis TaxBasis {
            get {
                return this.taxBasisField;
            }
            set {
                this.taxBasisField = value;
            }
        }
        
        /// <remarks/>
        public string CalculateQstOnTax {
            get {
                return this.calculateQstOnTaxField;
            }
            set {
                this.calculateQstOnTaxField = value;
            }
        }
        
        /// <remarks/>
        public TaxCode TaxCode {
            get {
                return this.taxCodeField;
            }
            set {
                this.taxCodeField = value;
            }
        }
        
        /// <remarks/>
        public string TaxValue {
            get {
                return this.taxValueField;
            }
            set {
                this.taxValueField = value;
            }
        }
        
        /// <remarks/>
        public SecondTaxCode SecondTaxCode {
            get {
                return this.secondTaxCodeField;
            }
            set {
                this.secondTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public string SecondTaxValue {
            get {
                return this.secondTaxValueField;
            }
            set {
                this.secondTaxValueField = value;
            }
        }
        
        /// <remarks/>
        public EcAcquisition EcAcquisition {
            get {
                return this.ecAcquisitionField;
            }
            set {
                this.ecAcquisitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EcAcquisitionSpecified {
            get {
                return this.ecAcquisitionFieldSpecified;
            }
            set {
                this.ecAcquisitionFieldSpecified = value;
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
        public string AnalysisEntry {
            get {
                return this.analysisEntryField;
            }
            set {
                this.analysisEntryField = value;
            }
        }
        
        /// <remarks/>
        public ItemAnalysisLineEntry AnalysisLineEntry {
            get {
                return this.analysisLineEntryField;
            }
            set {
                this.analysisLineEntryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GrnDetails")]
        public GrnDetails[] GrnDetails {
            get {
                return this.grnDetailsField;
            }
            set {
                this.grnDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LedgerDistribution")]
        public LedgerDistribution[] LedgerDistribution {
            get {
                return this.ledgerDistributionField;
            }
            set {
                this.ledgerDistributionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum TransactionCode {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        C,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum TaxBasis {
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        I,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum TaxCode {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        H,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        K,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        Q,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        V,
        
        /// <remarks/>
        W,
        
        /// <remarks/>
        X,
        
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
    public enum SecondTaxCode {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        GH,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        K,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        Q,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        V,
        
        /// <remarks/>
        W,
        
        /// <remarks/>
        X,
        
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
    public enum EcAcquisition {
        
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
    public partial class ItemAnalysisLineEntry {
        
        private string analysisCode1Field;
        
        private string analysisCode2Field;
        
        private string analysisCode3Field;
        
        private string analysisCode4Field;
        
        private string analysisCode5Field;
        
        private string startDateField;
        
        private string endDateField;
        
        private string entryAmountField;
        
        private string commentField;
        
        /// <remarks/>
        public string AnalysisCode1 {
            get {
                return this.analysisCode1Field;
            }
            set {
                this.analysisCode1Field = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisCode2 {
            get {
                return this.analysisCode2Field;
            }
            set {
                this.analysisCode2Field = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisCode3 {
            get {
                return this.analysisCode3Field;
            }
            set {
                this.analysisCode3Field = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisCode4 {
            get {
                return this.analysisCode4Field;
            }
            set {
                this.analysisCode4Field = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisCode5 {
            get {
                return this.analysisCode5Field;
            }
            set {
                this.analysisCode5Field = value;
            }
        }
        
        /// <remarks/>
        public string StartDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        public string EndDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        public string EntryAmount {
            get {
                return this.entryAmountField;
            }
            set {
                this.entryAmountField = value;
            }
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class GrnDetails {
        
        private string grnDetailKeyField;
        
        private GrnMatchType grnMatchTypeField;
        
        private bool grnMatchTypeFieldSpecified;
        
        private string grnMatchValueField;
        
        private string grnPartialMatchQuantityField;
        
        private string grnPartialMatchValueField;
        
        /// <remarks/>
        public string GrnDetailKey {
            get {
                return this.grnDetailKeyField;
            }
            set {
                this.grnDetailKeyField = value;
            }
        }
        
        /// <remarks/>
        public GrnMatchType GrnMatchType {
            get {
                return this.grnMatchTypeField;
            }
            set {
                this.grnMatchTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GrnMatchTypeSpecified {
            get {
                return this.grnMatchTypeFieldSpecified;
            }
            set {
                this.grnMatchTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string GrnMatchValue {
            get {
                return this.grnMatchValueField;
            }
            set {
                this.grnMatchValueField = value;
            }
        }
        
        /// <remarks/>
        public string GrnPartialMatchQuantity {
            get {
                return this.grnPartialMatchQuantityField;
            }
            set {
                this.grnPartialMatchQuantityField = value;
            }
        }
        
        /// <remarks/>
        public string GrnPartialMatchValue {
            get {
                return this.grnPartialMatchValueField;
            }
            set {
                this.grnPartialMatchValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum GrnMatchType {
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        O,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class LedgerDistribution {
        
        private string ledgerCodeField;
        
        private string passwordForLedgerCodeField;
        
        private LedgerTaxCode ledgerTaxCodeField;
        
        private LedgerSecondTaxCode ledgerSecondTaxCodeField;
        
        private string ledgerNotationField;
        
        private string ledgerValueField;
        
        private string analysisEntryField;
        
        private LedgerDistributionAnalysisLineEntry analysisLineEntryField;
        
        /// <remarks/>
        public string LedgerCode {
            get {
                return this.ledgerCodeField;
            }
            set {
                this.ledgerCodeField = value;
            }
        }
        
        /// <remarks/>
        public string PasswordForLedgerCode {
            get {
                return this.passwordForLedgerCodeField;
            }
            set {
                this.passwordForLedgerCodeField = value;
            }
        }
        
        /// <remarks/>
        public LedgerTaxCode LedgerTaxCode {
            get {
                return this.ledgerTaxCodeField;
            }
            set {
                this.ledgerTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public LedgerSecondTaxCode LedgerSecondTaxCode {
            get {
                return this.ledgerSecondTaxCodeField;
            }
            set {
                this.ledgerSecondTaxCodeField = value;
            }
        }
        
        /// <remarks/>
        public string LedgerNotation {
            get {
                return this.ledgerNotationField;
            }
            set {
                this.ledgerNotationField = value;
            }
        }
        
        /// <remarks/>
        public string LedgerValue {
            get {
                return this.ledgerValueField;
            }
            set {
                this.ledgerValueField = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisEntry {
            get {
                return this.analysisEntryField;
            }
            set {
                this.analysisEntryField = value;
            }
        }
        
        /// <remarks/>
        public LedgerDistributionAnalysisLineEntry AnalysisLineEntry {
            get {
                return this.analysisLineEntryField;
            }
            set {
                this.analysisLineEntryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum LedgerTaxCode {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        H,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        K,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        O,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        Q,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        V,
        
        /// <remarks/>
        W,
        
        /// <remarks/>
        X,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        Z,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum LedgerSecondTaxCode {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        D,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        G,
        
        /// <remarks/>
        H,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        J,
        
        /// <remarks/>
        KL,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        NO,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        Q,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        U,
        
        /// <remarks/>
        V,
        
        /// <remarks/>
        W,
        
        /// <remarks/>
        X,
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        Z,
        
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
    public partial class LedgerDistributionAnalysisLineEntry {
        
        private string analysisCode1Field;
        
        private string analysisCode2Field;
        
        private string analysisCode3Field;
        
        private string analysisCode4Field;
        
        private string analysisCode5Field;
        
        private string startDateField;
        
        private string endDateField;
        
        private string entryAmountField;
        
        private string commentField;
        
        /// <remarks/>
        public string AnalysisCode1 {
            get {
                return this.analysisCode1Field;
            }
            set {
                this.analysisCode1Field = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisCode2 {
            get {
                return this.analysisCode2Field;
            }
            set {
                this.analysisCode2Field = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisCode3 {
            get {
                return this.analysisCode3Field;
            }
            set {
                this.analysisCode3Field = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisCode4 {
            get {
                return this.analysisCode4Field;
            }
            set {
                this.analysisCode4Field = value;
            }
        }
        
        /// <remarks/>
        public string AnalysisCode5 {
            get {
                return this.analysisCode5Field;
            }
            set {
                this.analysisCode5Field = value;
            }
        }
        
        /// <remarks/>
        public string StartDate {
            get {
                return this.startDateField;
            }
            set {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        public string EndDate {
            get {
                return this.endDateField;
            }
            set {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        public string EntryAmount {
            get {
                return this.entryAmountField;
            }
            set {
                this.entryAmountField = value;
            }
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostApInvoice {
        
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
