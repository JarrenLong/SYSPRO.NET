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
namespace SYSPRO.NET.BusinessObjects.IMPQTXOUT {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class TaxOptions {
        
        private General generalField;
        
        private Options optionsField;
        
        private WithholdingTax withholdingTaxField;
        
        private Intrastat intrastatField;
        
        private USA3rdParty uSA3rdPartyField;
        
        /// <remarks/>
        public General General {
            get {
                return this.generalField;
            }
            set {
                this.generalField = value;
            }
        }
        
        /// <remarks/>
        public Options Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        public WithholdingTax WithholdingTax {
            get {
                return this.withholdingTaxField;
            }
            set {
                this.withholdingTaxField = value;
            }
        }
        
        /// <remarks/>
        public Intrastat Intrastat {
            get {
                return this.intrastatField;
            }
            set {
                this.intrastatField = value;
            }
        }
        
        /// <remarks/>
        public USA3rdParty USA3rdParty {
            get {
                return this.uSA3rdPartyField;
            }
            set {
                this.uSA3rdPartyField = value;
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
    public partial class General {
        
        private string taxSystemField;
        
        private string compTaxCodeFileField;
        
        private string ecVatReqField;
        
        private string canGstReqField;
        
        private string ausGstReqField;
        
        private string salesTaxIntGlField;
        
        private string salesTaxCalcField;
        
        private string discInclTaxField;
        
        private string discMerLinesField;
        
        private string discFrtLinesField;
        
        private string discMiscLinesField;
        
        private string gstCalcField;
        
        /// <remarks/>
        public string TaxSystem {
            get {
                return this.taxSystemField;
            }
            set {
                this.taxSystemField = value;
            }
        }
        
        /// <remarks/>
        public string CompTaxCodeFile {
            get {
                return this.compTaxCodeFileField;
            }
            set {
                this.compTaxCodeFileField = value;
            }
        }
        
        /// <remarks/>
        public string EcVatReq {
            get {
                return this.ecVatReqField;
            }
            set {
                this.ecVatReqField = value;
            }
        }
        
        /// <remarks/>
        public string CanGstReq {
            get {
                return this.canGstReqField;
            }
            set {
                this.canGstReqField = value;
            }
        }
        
        /// <remarks/>
        public string AusGstReq {
            get {
                return this.ausGstReqField;
            }
            set {
                this.ausGstReqField = value;
            }
        }
        
        /// <remarks/>
        public string SalesTaxIntGl {
            get {
                return this.salesTaxIntGlField;
            }
            set {
                this.salesTaxIntGlField = value;
            }
        }
        
        /// <remarks/>
        public string SalesTaxCalc {
            get {
                return this.salesTaxCalcField;
            }
            set {
                this.salesTaxCalcField = value;
            }
        }
        
        /// <remarks/>
        public string DiscInclTax {
            get {
                return this.discInclTaxField;
            }
            set {
                this.discInclTaxField = value;
            }
        }
        
        /// <remarks/>
        public string DiscMerLines {
            get {
                return this.discMerLinesField;
            }
            set {
                this.discMerLinesField = value;
            }
        }
        
        /// <remarks/>
        public string DiscFrtLines {
            get {
                return this.discFrtLinesField;
            }
            set {
                this.discFrtLinesField = value;
            }
        }
        
        /// <remarks/>
        public string DiscMiscLines {
            get {
                return this.discMiscLinesField;
            }
            set {
                this.discMiscLinesField = value;
            }
        }
        
        /// <remarks/>
        public string GstCalc {
            get {
                return this.gstCalcField;
            }
            set {
                this.gstCalcField = value;
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
    public partial class Options {
        
        private object defTaxMiscField;
        
        private object defTaxFrtField;
        
        private object defTaxNonField;
        
        private object defTaxCrField;
        
        private string glPerTaxRetField;
        
        private string descTaxCodesField;
        
        private string taxRndReqField;
        
        private string rndTaxValField;
        
        private string rndInvValField;
        
        private string incForInvField;
        
        private string rndValuesField;
        
        private string invRoundField;
        
        private object rndFactorField;
        
        /// <remarks/>
        public object DefTaxMisc {
            get {
                return this.defTaxMiscField;
            }
            set {
                this.defTaxMiscField = value;
            }
        }
        
        /// <remarks/>
        public object DefTaxFrt {
            get {
                return this.defTaxFrtField;
            }
            set {
                this.defTaxFrtField = value;
            }
        }
        
        /// <remarks/>
        public object DefTaxNon {
            get {
                return this.defTaxNonField;
            }
            set {
                this.defTaxNonField = value;
            }
        }
        
        /// <remarks/>
        public object DefTaxCr {
            get {
                return this.defTaxCrField;
            }
            set {
                this.defTaxCrField = value;
            }
        }
        
        /// <remarks/>
        public string GlPerTaxRet {
            get {
                return this.glPerTaxRetField;
            }
            set {
                this.glPerTaxRetField = value;
            }
        }
        
        /// <remarks/>
        public string DescTaxCodes {
            get {
                return this.descTaxCodesField;
            }
            set {
                this.descTaxCodesField = value;
            }
        }
        
        /// <remarks/>
        public string TaxRndReq {
            get {
                return this.taxRndReqField;
            }
            set {
                this.taxRndReqField = value;
            }
        }
        
        /// <remarks/>
        public string RndTaxVal {
            get {
                return this.rndTaxValField;
            }
            set {
                this.rndTaxValField = value;
            }
        }
        
        /// <remarks/>
        public string RndInvVal {
            get {
                return this.rndInvValField;
            }
            set {
                this.rndInvValField = value;
            }
        }
        
        /// <remarks/>
        public string IncForInv {
            get {
                return this.incForInvField;
            }
            set {
                this.incForInvField = value;
            }
        }
        
        /// <remarks/>
        public string RndValues {
            get {
                return this.rndValuesField;
            }
            set {
                this.rndValuesField = value;
            }
        }
        
        /// <remarks/>
        public string InvRound {
            get {
                return this.invRoundField;
            }
            set {
                this.invRoundField = value;
            }
        }
        
        /// <remarks/>
        public object RndFactor {
            get {
                return this.rndFactorField;
            }
            set {
                this.rndFactorField = value;
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
    public partial class WithholdingTax {
        
        private string withTaxReqField;
        
        private string autoCalcWithTaxField;
        
        private string withholdingTaxTrnField;
        
        private string withholdingTaxForCompField;
        
        private string withholdingTaxLocCompField;
        
        private string withholdingTaxIndiCompField;
        
        private string withholdingTaxAppProdField;
        
        private string withholdingTaxCalcBasisField;
        
        private string withholdingAmtTaxCalcField;
        
        /// <remarks/>
        public string WithTaxReq {
            get {
                return this.withTaxReqField;
            }
            set {
                this.withTaxReqField = value;
            }
        }
        
        /// <remarks/>
        public string AutoCalcWithTax {
            get {
                return this.autoCalcWithTaxField;
            }
            set {
                this.autoCalcWithTaxField = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingTaxTrn {
            get {
                return this.withholdingTaxTrnField;
            }
            set {
                this.withholdingTaxTrnField = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingTaxForComp {
            get {
                return this.withholdingTaxForCompField;
            }
            set {
                this.withholdingTaxForCompField = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingTaxLocComp {
            get {
                return this.withholdingTaxLocCompField;
            }
            set {
                this.withholdingTaxLocCompField = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingTaxIndiComp {
            get {
                return this.withholdingTaxIndiCompField;
            }
            set {
                this.withholdingTaxIndiCompField = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingTaxAppProd {
            get {
                return this.withholdingTaxAppProdField;
            }
            set {
                this.withholdingTaxAppProdField = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingTaxCalcBasis {
            get {
                return this.withholdingTaxCalcBasisField;
            }
            set {
                this.withholdingTaxCalcBasisField = value;
            }
        }
        
        /// <remarks/>
        public string WithholdingAmtTaxCalc {
            get {
                return this.withholdingAmtTaxCalcField;
            }
            set {
                this.withholdingAmtTaxCalcField = value;
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
    public partial class Intrastat {
        
        private object intrInvNatrField;
        
        private object intrCrnNatrField;
        
        private object intrArrNatrField;
        
        private object intrInvDeltField;
        
        private object intrCrnDeltField;
        
        private object intrArrDeltField;
        
        private object captureDelTermsNonEcField;
        
        /// <remarks/>
        public object IntrInvNatr {
            get {
                return this.intrInvNatrField;
            }
            set {
                this.intrInvNatrField = value;
            }
        }
        
        /// <remarks/>
        public object IntrCrnNatr {
            get {
                return this.intrCrnNatrField;
            }
            set {
                this.intrCrnNatrField = value;
            }
        }
        
        /// <remarks/>
        public object IntrArrNatr {
            get {
                return this.intrArrNatrField;
            }
            set {
                this.intrArrNatrField = value;
            }
        }
        
        /// <remarks/>
        public object IntrInvDelt {
            get {
                return this.intrInvDeltField;
            }
            set {
                this.intrInvDeltField = value;
            }
        }
        
        /// <remarks/>
        public object IntrCrnDelt {
            get {
                return this.intrCrnDeltField;
            }
            set {
                this.intrCrnDeltField = value;
            }
        }
        
        /// <remarks/>
        public object IntrArrDelt {
            get {
                return this.intrArrDeltField;
            }
            set {
                this.intrArrDeltField = value;
            }
        }
        
        /// <remarks/>
        public object CaptureDelTermsNonEc {
            get {
                return this.captureDelTermsNonEcField;
            }
            set {
                this.captureDelTermsNonEcField = value;
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
    public partial class USA3rdParty {
        
        private string interfaceTypeField;
        
        private string businessObjectField;
        
        private string taxSetupField;
        
        private string identificationTypeField;
        
        private string userCompanyIdField;
        
        private string userDivisionField;
        
        private string updateTaxFlagField;
        
        private string liveTaxCompanyField;
        
        private string defaultShipFromStreetField;
        
        private string defaultShipFromCityField;
        
        private string defaultShipFromStateField;
        
        private string defaultShipFromZipField;
        
        private string userParametersField;
        
        /// <remarks/>
        public string InterfaceType {
            get {
                return this.interfaceTypeField;
            }
            set {
                this.interfaceTypeField = value;
            }
        }
        
        /// <remarks/>
        public string BusinessObject {
            get {
                return this.businessObjectField;
            }
            set {
                this.businessObjectField = value;
            }
        }
        
        /// <remarks/>
        public string TaxSetup {
            get {
                return this.taxSetupField;
            }
            set {
                this.taxSetupField = value;
            }
        }
        
        /// <remarks/>
        public string IdentificationType {
            get {
                return this.identificationTypeField;
            }
            set {
                this.identificationTypeField = value;
            }
        }
        
        /// <remarks/>
        public string UserCompanyId {
            get {
                return this.userCompanyIdField;
            }
            set {
                this.userCompanyIdField = value;
            }
        }
        
        /// <remarks/>
        public string UserDivision {
            get {
                return this.userDivisionField;
            }
            set {
                this.userDivisionField = value;
            }
        }
        
        /// <remarks/>
        public string UpdateTaxFlag {
            get {
                return this.updateTaxFlagField;
            }
            set {
                this.updateTaxFlagField = value;
            }
        }
        
        /// <remarks/>
        public string LiveTaxCompany {
            get {
                return this.liveTaxCompanyField;
            }
            set {
                this.liveTaxCompanyField = value;
            }
        }
        
        /// <remarks/>
        public string DefaultShipFromStreet {
            get {
                return this.defaultShipFromStreetField;
            }
            set {
                this.defaultShipFromStreetField = value;
            }
        }
        
        /// <remarks/>
        public string DefaultShipFromCity {
            get {
                return this.defaultShipFromCityField;
            }
            set {
                this.defaultShipFromCityField = value;
            }
        }
        
        /// <remarks/>
        public string DefaultShipFromState {
            get {
                return this.defaultShipFromStateField;
            }
            set {
                this.defaultShipFromStateField = value;
            }
        }
        
        /// <remarks/>
        public string DefaultShipFromZip {
            get {
                return this.defaultShipFromZipField;
            }
            set {
                this.defaultShipFromZipField = value;
            }
        }
        
        /// <remarks/>
        public string UserParameters {
            get {
                return this.userParametersField;
            }
            set {
                this.userParametersField = value;
            }
        }
    }
}
