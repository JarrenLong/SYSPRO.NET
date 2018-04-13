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
namespace SYSPRO.NET.BusinessObjects.QOTTSODOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class QuotationsOptions {
        
        private General generalField;
        
        private Pricing pricingField;
        
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
        public Pricing Pricing {
            get {
                return this.pricingField;
            }
            set {
                this.pricingField = value;
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
        
        private QuotationNumMethod quotationNumMethodField;
        
        private double nxtQuotationNumField;
        
        private QuotationVersioning quotationVersioningField;
        
        private string defDescOffer1Field;
        
        private string defDescOffer2Field;
        
        private string defDescOffer3Field;
        
        private string defDescOffer4Field;
        
        private string defDescOffer5Field;
        
        private string defDescDefOfferField;
        
        private CostImplosionJobCreationUseRouteZero costImplosionJobCreationUseRouteZeroField;
        
        private AllowChgQueryDate allowChgQueryDateField;
        
        private AllowChgExpiryDate allowChgExpiryDateField;
        
        private DefExpiryDate defExpiryDateField;
        
        private double daysBaseDateExpiryDateField;
        
        /// <remarks/>
        public QuotationNumMethod QuotationNumMethod {
            get {
                return this.quotationNumMethodField;
            }
            set {
                this.quotationNumMethodField = value;
            }
        }
        
        /// <remarks/>
        public double NxtQuotationNum {
            get {
                return this.nxtQuotationNumField;
            }
            set {
                this.nxtQuotationNumField = value;
            }
        }
        
        /// <remarks/>
        public QuotationVersioning QuotationVersioning {
            get {
                return this.quotationVersioningField;
            }
            set {
                this.quotationVersioningField = value;
            }
        }
        
        /// <remarks/>
        public string DefDescOffer1 {
            get {
                return this.defDescOffer1Field;
            }
            set {
                this.defDescOffer1Field = value;
            }
        }
        
        /// <remarks/>
        public string DefDescOffer2 {
            get {
                return this.defDescOffer2Field;
            }
            set {
                this.defDescOffer2Field = value;
            }
        }
        
        /// <remarks/>
        public string DefDescOffer3 {
            get {
                return this.defDescOffer3Field;
            }
            set {
                this.defDescOffer3Field = value;
            }
        }
        
        /// <remarks/>
        public string DefDescOffer4 {
            get {
                return this.defDescOffer4Field;
            }
            set {
                this.defDescOffer4Field = value;
            }
        }
        
        /// <remarks/>
        public string DefDescOffer5 {
            get {
                return this.defDescOffer5Field;
            }
            set {
                this.defDescOffer5Field = value;
            }
        }
        
        /// <remarks/>
        public string DefDescDefOffer {
            get {
                return this.defDescDefOfferField;
            }
            set {
                this.defDescDefOfferField = value;
            }
        }
        
        /// <remarks/>
        public CostImplosionJobCreationUseRouteZero CostImplosionJobCreationUseRouteZero {
            get {
                return this.costImplosionJobCreationUseRouteZeroField;
            }
            set {
                this.costImplosionJobCreationUseRouteZeroField = value;
            }
        }
        
        /// <remarks/>
        public AllowChgQueryDate AllowChgQueryDate {
            get {
                return this.allowChgQueryDateField;
            }
            set {
                this.allowChgQueryDateField = value;
            }
        }
        
        /// <remarks/>
        public AllowChgExpiryDate AllowChgExpiryDate {
            get {
                return this.allowChgExpiryDateField;
            }
            set {
                this.allowChgExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        public DefExpiryDate DefExpiryDate {
            get {
                return this.defExpiryDateField;
            }
            set {
                this.defExpiryDateField = value;
            }
        }
        
        /// <remarks/>
        public double DaysBaseDateExpiryDate {
            get {
                return this.daysBaseDateExpiryDateField;
            }
            set {
                this.daysBaseDateExpiryDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum QuotationNumMethod {
        
        /// <remarks/>
        Y,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        B,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum QuotationVersioning {
        
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
    public enum CostImplosionJobCreationUseRouteZero {
        
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
    public enum AllowChgQueryDate {
        
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
    public enum AllowChgExpiryDate {
        
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
    public enum DefExpiryDate {
        
        /// <remarks/>
        Q,
        
        /// <remarks/>
        T,
        
        /// <remarks/>
        P,
        
        /// <remarks/>
        F,
        
        /// <remarks/>
        Z,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Pricing {
        
        private DefNonStProfitBasis defNonStProfitBasisField;
        
        private double defNonStProfitPercField;
        
        private DefNonStProfitAllowChg defNonStProfitAllowChgField;
        
        private DefNonStProfitConvert defNonStProfitConvertField;
        
        private DefAddLabProfitBasis defAddLabProfitBasisField;
        
        private double defAddLabProfitPercField;
        
        private DefAddLabProfitAllowChg defAddLabProfitAllowChgField;
        
        private DefAddLabProfitConvert defAddLabProfitConvertField;
        
        private ApplySOLineDiscBreaks applySOLineDiscBreaksField;
        
        private RecalcLineDiscBreaks recalcLineDiscBreaksField;
        
        private DefAddMatProfitBasis defAddMatProfitBasisField;
        
        private double defAddMatProfitPercField;
        
        private DefAddMatProfitAllowChg defAddMatProfitAllowChgField;
        
        private DefAddMatProfitConvert defAddMatProfitConvertField;
        
        private CostToUseForQotImplosion costToUseForQotImplosionField;
        
        /// <remarks/>
        public DefNonStProfitBasis DefNonStProfitBasis {
            get {
                return this.defNonStProfitBasisField;
            }
            set {
                this.defNonStProfitBasisField = value;
            }
        }
        
        /// <remarks/>
        public double DefNonStProfitPerc {
            get {
                return this.defNonStProfitPercField;
            }
            set {
                this.defNonStProfitPercField = value;
            }
        }
        
        /// <remarks/>
        public DefNonStProfitAllowChg DefNonStProfitAllowChg {
            get {
                return this.defNonStProfitAllowChgField;
            }
            set {
                this.defNonStProfitAllowChgField = value;
            }
        }
        
        /// <remarks/>
        public DefNonStProfitConvert DefNonStProfitConvert {
            get {
                return this.defNonStProfitConvertField;
            }
            set {
                this.defNonStProfitConvertField = value;
            }
        }
        
        /// <remarks/>
        public DefAddLabProfitBasis DefAddLabProfitBasis {
            get {
                return this.defAddLabProfitBasisField;
            }
            set {
                this.defAddLabProfitBasisField = value;
            }
        }
        
        /// <remarks/>
        public double DefAddLabProfitPerc {
            get {
                return this.defAddLabProfitPercField;
            }
            set {
                this.defAddLabProfitPercField = value;
            }
        }
        
        /// <remarks/>
        public DefAddLabProfitAllowChg DefAddLabProfitAllowChg {
            get {
                return this.defAddLabProfitAllowChgField;
            }
            set {
                this.defAddLabProfitAllowChgField = value;
            }
        }
        
        /// <remarks/>
        public DefAddLabProfitConvert DefAddLabProfitConvert {
            get {
                return this.defAddLabProfitConvertField;
            }
            set {
                this.defAddLabProfitConvertField = value;
            }
        }
        
        /// <remarks/>
        public ApplySOLineDiscBreaks ApplySOLineDiscBreaks {
            get {
                return this.applySOLineDiscBreaksField;
            }
            set {
                this.applySOLineDiscBreaksField = value;
            }
        }
        
        /// <remarks/>
        public RecalcLineDiscBreaks RecalcLineDiscBreaks {
            get {
                return this.recalcLineDiscBreaksField;
            }
            set {
                this.recalcLineDiscBreaksField = value;
            }
        }
        
        /// <remarks/>
        public DefAddMatProfitBasis DefAddMatProfitBasis {
            get {
                return this.defAddMatProfitBasisField;
            }
            set {
                this.defAddMatProfitBasisField = value;
            }
        }
        
        /// <remarks/>
        public double DefAddMatProfitPerc {
            get {
                return this.defAddMatProfitPercField;
            }
            set {
                this.defAddMatProfitPercField = value;
            }
        }
        
        /// <remarks/>
        public DefAddMatProfitAllowChg DefAddMatProfitAllowChg {
            get {
                return this.defAddMatProfitAllowChgField;
            }
            set {
                this.defAddMatProfitAllowChgField = value;
            }
        }
        
        /// <remarks/>
        public DefAddMatProfitConvert DefAddMatProfitConvert {
            get {
                return this.defAddMatProfitConvertField;
            }
            set {
                this.defAddMatProfitConvertField = value;
            }
        }
        
        /// <remarks/>
        public CostToUseForQotImplosion CostToUseForQotImplosion {
            get {
                return this.costToUseForQotImplosionField;
            }
            set {
                this.costToUseForQotImplosionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DefNonStProfitBasis {
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        G,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DefNonStProfitAllowChg {
        
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
    public enum DefNonStProfitConvert {
        
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
    public enum DefAddLabProfitBasis {
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        G,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DefAddLabProfitAllowChg {
        
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
    public enum DefAddLabProfitConvert {
        
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
    public enum ApplySOLineDiscBreaks {
        
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
    public enum RecalcLineDiscBreaks {
        
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
    public enum DefAddMatProfitBasis {
        
        /// <remarks/>
        M,
        
        /// <remarks/>
        G,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum DefAddMatProfitAllowChg {
        
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
    public enum DefAddMatProfitConvert {
        
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
    public enum CostToUseForQotImplosion {
        
        /// <remarks/>
        I,
        
        /// <remarks/>
        L,
        
        /// <remarks/>
        S,
    }
}
