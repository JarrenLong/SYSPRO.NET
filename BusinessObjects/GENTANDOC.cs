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
namespace SYSPRO.NET.BusinessObjects.GENTANDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostGlAnalysis {
        
        private PostGlAnalysisItem itemField;
        
        /// <remarks/>
        public PostGlAnalysisItem Item {
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
    public partial class PostGlAnalysisItem {
        
        private string ledgerCodeField;
        
        private string analysisNumberField;
        
        private string glYearField;
        
        private string glPeriodField;
        
        private string amountField;
        
        private PostGlAnalysisItemAnalysisEntry analysisEntryField;
        
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
        public string AnalysisNumber {
            get {
                return this.analysisNumberField;
            }
            set {
                this.analysisNumberField = value;
            }
        }
        
        /// <remarks/>
        public string GlYear {
            get {
                return this.glYearField;
            }
            set {
                this.glYearField = value;
            }
        }
        
        /// <remarks/>
        public string GlPeriod {
            get {
                return this.glPeriodField;
            }
            set {
                this.glPeriodField = value;
            }
        }
        
        /// <remarks/>
        public string Amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public PostGlAnalysisItemAnalysisEntry AnalysisEntry {
            get {
                return this.analysisEntryField;
            }
            set {
                this.analysisEntryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostGlAnalysisItemAnalysisEntry {
        
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
}
