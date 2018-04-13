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
namespace SYSPRO.NET.BusinessObjects.RMATSODOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class RmaSetupOptions {
        
        private General generalField;
        
        private Options optionsField;
        
        private Defaults defaultsField;
        
        private Numbering numberingField;
        
        private UserDefined userDefinedField;
        
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
        public Defaults Defaults {
            get {
                return this.defaultsField;
            }
            set {
                this.defaultsField = value;
            }
        }
        
        /// <remarks/>
        public Numbering Numbering {
            get {
                return this.numberingField;
            }
            set {
                this.numberingField = value;
            }
        }
        
        /// <remarks/>
        public UserDefined UserDefined {
            get {
                return this.userDefinedField;
            }
            set {
                this.userDefinedField = value;
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
        
        private FixInHouse fixInHouseField;
        
        private double daysRetCompRmaField;
        
        private PromptForRevRelAtIssue promptForRevRelAtIssueField;
        
        private PrintRma printRmaField;
        
        private ProblemCodeMan problemCodeManField;
        
        private PromptForSave promptForSaveField;
        
        /// <remarks/>
        public FixInHouse FixInHouse {
            get {
                return this.fixInHouseField;
            }
            set {
                this.fixInHouseField = value;
            }
        }
        
        /// <remarks/>
        public double DaysRetCompRma {
            get {
                return this.daysRetCompRmaField;
            }
            set {
                this.daysRetCompRmaField = value;
            }
        }
        
        /// <remarks/>
        public PromptForRevRelAtIssue PromptForRevRelAtIssue {
            get {
                return this.promptForRevRelAtIssueField;
            }
            set {
                this.promptForRevRelAtIssueField = value;
            }
        }
        
        /// <remarks/>
        public PrintRma PrintRma {
            get {
                return this.printRmaField;
            }
            set {
                this.printRmaField = value;
            }
        }
        
        /// <remarks/>
        public ProblemCodeMan ProblemCodeMan {
            get {
                return this.problemCodeManField;
            }
            set {
                this.problemCodeManField = value;
            }
        }
        
        /// <remarks/>
        public PromptForSave PromptForSave {
            get {
                return this.promptForSaveField;
            }
            set {
                this.promptForSaveField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum FixInHouse {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        S,
        
        /// <remarks/>
        W,
        
        /// <remarks/>
        B,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum PromptForRevRelAtIssue {
        
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
    public enum PrintRma {
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        R,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ProblemCodeMan {
        
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
    public enum PromptForSave {
        
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
    public partial class Options {
        
        private CrossShipCrSo crossShipCrSoField;
        
        private CrossShipSerialNos crossShipSerialNosField;
        
        private double maxDayRetProdField;
        
        private double restockPercField;
        
        private string restockProdClsField;
        
        private PromptForRestock promptForRestockField;
        
        private ApplyRestockFeeDefCr applyRestockFeeDefCrField;
        
        private ApplyRestockFeeDefInWarr applyRestockFeeDefInWarrField;
        
        private ApplyRestockFeeDefOutWarr applyRestockFeeDefOutWarrField;
        
        private ApplyRestockFeeGenRet applyRestockFeeGenRetField;
        
        private ApplyRestockFeeIncOrd applyRestockFeeIncOrdField;
        
        private ApplyRestockFeeIncShip applyRestockFeeIncShipField;
        
        private ApplyRestockFeeShrtShip applyRestockFeeShrtShipField;
        
        /// <remarks/>
        public CrossShipCrSo CrossShipCrSo {
            get {
                return this.crossShipCrSoField;
            }
            set {
                this.crossShipCrSoField = value;
            }
        }
        
        /// <remarks/>
        public CrossShipSerialNos CrossShipSerialNos {
            get {
                return this.crossShipSerialNosField;
            }
            set {
                this.crossShipSerialNosField = value;
            }
        }
        
        /// <remarks/>
        public double MaxDayRetProd {
            get {
                return this.maxDayRetProdField;
            }
            set {
                this.maxDayRetProdField = value;
            }
        }
        
        /// <remarks/>
        public double RestockPerc {
            get {
                return this.restockPercField;
            }
            set {
                this.restockPercField = value;
            }
        }
        
        /// <remarks/>
        public string RestockProdCls {
            get {
                return this.restockProdClsField;
            }
            set {
                this.restockProdClsField = value;
            }
        }
        
        /// <remarks/>
        public PromptForRestock PromptForRestock {
            get {
                return this.promptForRestockField;
            }
            set {
                this.promptForRestockField = value;
            }
        }
        
        /// <remarks/>
        public ApplyRestockFeeDefCr ApplyRestockFeeDefCr {
            get {
                return this.applyRestockFeeDefCrField;
            }
            set {
                this.applyRestockFeeDefCrField = value;
            }
        }
        
        /// <remarks/>
        public ApplyRestockFeeDefInWarr ApplyRestockFeeDefInWarr {
            get {
                return this.applyRestockFeeDefInWarrField;
            }
            set {
                this.applyRestockFeeDefInWarrField = value;
            }
        }
        
        /// <remarks/>
        public ApplyRestockFeeDefOutWarr ApplyRestockFeeDefOutWarr {
            get {
                return this.applyRestockFeeDefOutWarrField;
            }
            set {
                this.applyRestockFeeDefOutWarrField = value;
            }
        }
        
        /// <remarks/>
        public ApplyRestockFeeGenRet ApplyRestockFeeGenRet {
            get {
                return this.applyRestockFeeGenRetField;
            }
            set {
                this.applyRestockFeeGenRetField = value;
            }
        }
        
        /// <remarks/>
        public ApplyRestockFeeIncOrd ApplyRestockFeeIncOrd {
            get {
                return this.applyRestockFeeIncOrdField;
            }
            set {
                this.applyRestockFeeIncOrdField = value;
            }
        }
        
        /// <remarks/>
        public ApplyRestockFeeIncShip ApplyRestockFeeIncShip {
            get {
                return this.applyRestockFeeIncShipField;
            }
            set {
                this.applyRestockFeeIncShipField = value;
            }
        }
        
        /// <remarks/>
        public ApplyRestockFeeShrtShip ApplyRestockFeeShrtShip {
            get {
                return this.applyRestockFeeShrtShipField;
            }
            set {
                this.applyRestockFeeShrtShipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum CrossShipCrSo {
        
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
    public enum CrossShipSerialNos {
        
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
    public enum PromptForRestock {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        L,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ApplyRestockFeeDefCr {
        
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
    public enum ApplyRestockFeeDefInWarr {
        
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
    public enum ApplyRestockFeeDefOutWarr {
        
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
    public enum ApplyRestockFeeGenRet {
        
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
    public enum ApplyRestockFeeIncOrd {
        
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
    public enum ApplyRestockFeeIncShip {
        
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
    public enum ApplyRestockFeeShrtShip {
        
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
    public partial class Defaults {
        
        private string rmaDefWhCredField;
        
        private string rmaDefWhRepField;
        
        private string rmaDefWhCompField;
        
        private RmaDefRecAction rmaDefRecActionField;
        
        private string rmaDefInvTermsField;
        
        private string rmaDefNsUomField;
        
        private string rmaDefNsProdClsField;
        
        private RmaDefLineType rmaDefLineTypeField;
        
        /// <remarks/>
        public string RmaDefWhCred {
            get {
                return this.rmaDefWhCredField;
            }
            set {
                this.rmaDefWhCredField = value;
            }
        }
        
        /// <remarks/>
        public string RmaDefWhRep {
            get {
                return this.rmaDefWhRepField;
            }
            set {
                this.rmaDefWhRepField = value;
            }
        }
        
        /// <remarks/>
        public string RmaDefWhComp {
            get {
                return this.rmaDefWhCompField;
            }
            set {
                this.rmaDefWhCompField = value;
            }
        }
        
        /// <remarks/>
        public RmaDefRecAction RmaDefRecAction {
            get {
                return this.rmaDefRecActionField;
            }
            set {
                this.rmaDefRecActionField = value;
            }
        }
        
        /// <remarks/>
        public string RmaDefInvTerms {
            get {
                return this.rmaDefInvTermsField;
            }
            set {
                this.rmaDefInvTermsField = value;
            }
        }
        
        /// <remarks/>
        public string RmaDefNsUom {
            get {
                return this.rmaDefNsUomField;
            }
            set {
                this.rmaDefNsUomField = value;
            }
        }
        
        /// <remarks/>
        public string RmaDefNsProdCls {
            get {
                return this.rmaDefNsProdClsField;
            }
            set {
                this.rmaDefNsProdClsField = value;
            }
        }
        
        /// <remarks/>
        public RmaDefLineType RmaDefLineType {
            get {
                return this.rmaDefLineTypeField;
            }
            set {
                this.rmaDefLineTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum RmaDefRecAction {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        C,
        
        /// <remarks/>
        E,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        Z,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum RmaDefLineType {
        
        /// <remarks/>
        S,
        
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
    public partial class Numbering {
        
        private RmaNumMethod rmaNumMethodField;
        
        private double rmaNextNoField;
        
        /// <remarks/>
        public RmaNumMethod RmaNumMethod {
            get {
                return this.rmaNumMethodField;
            }
            set {
                this.rmaNumMethodField = value;
            }
        }
        
        /// <remarks/>
        public double RmaNextNo {
            get {
                return this.rmaNextNoField;
            }
            set {
                this.rmaNextNoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum RmaNumMethod {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        B,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class UserDefined {
        
        private string rmaUdfHdrField;
        
        private RmaUdfHdrMand rmaUdfHdrMandField;
        
        private string rmaUdfLine1Field;
        
        private RmaUdfLine1Mand rmaUdfLine1MandField;
        
        private string rmaUdfLine2Field;
        
        private RmaUdfLine2Mand rmaUdfLine2MandField;
        
        /// <remarks/>
        public string RmaUdfHdr {
            get {
                return this.rmaUdfHdrField;
            }
            set {
                this.rmaUdfHdrField = value;
            }
        }
        
        /// <remarks/>
        public RmaUdfHdrMand RmaUdfHdrMand {
            get {
                return this.rmaUdfHdrMandField;
            }
            set {
                this.rmaUdfHdrMandField = value;
            }
        }
        
        /// <remarks/>
        public string RmaUdfLine1 {
            get {
                return this.rmaUdfLine1Field;
            }
            set {
                this.rmaUdfLine1Field = value;
            }
        }
        
        /// <remarks/>
        public RmaUdfLine1Mand RmaUdfLine1Mand {
            get {
                return this.rmaUdfLine1MandField;
            }
            set {
                this.rmaUdfLine1MandField = value;
            }
        }
        
        /// <remarks/>
        public string RmaUdfLine2 {
            get {
                return this.rmaUdfLine2Field;
            }
            set {
                this.rmaUdfLine2Field = value;
            }
        }
        
        /// <remarks/>
        public RmaUdfLine2Mand RmaUdfLine2Mand {
            get {
                return this.rmaUdfLine2MandField;
            }
            set {
                this.rmaUdfLine2MandField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum RmaUdfHdrMand {
        
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
    public enum RmaUdfLine1Mand {
        
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
    public enum RmaUdfLine2Mand {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
}
