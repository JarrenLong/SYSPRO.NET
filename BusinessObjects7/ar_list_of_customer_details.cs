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
namespace SYSPRO.NET.BusinessObjects.ar_list_of_customer_details {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class BranchSelection {
        
        private BranchSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BranchSelectionFilterType FilterType {
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
    public enum BranchSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CreditLimitSelection {
        
        private CreditLimitSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CreditLimitSelectionFilterType FilterType {
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
    public enum CreditLimitSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CurrencySelection {
        
        private CurrencySelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurrencySelectionFilterType FilterType {
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
    public enum CurrencySelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CustomerClassSelection {
        
        private CustomerClassSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerClassSelectionFilterType FilterType {
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
    public enum CustomerClassSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class CustomerSelection {
        
        private CustomerSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CustomerSelectionFilterType FilterType {
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
    public enum CustomerSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        R,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ExtraFields {
        
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
    public partial class Filter {
        
        private CustomerSelection customerSelectionField;
        
        private CustomerClassSelection customerClassSelectionField;
        
        private GeographicAreaSelection geographicAreaSelectionField;
        
        private BranchSelection branchSelectionField;
        
        private SalespersonSelection salespersonSelectionField;
        
        private LineDiscountCodeSelection lineDiscountCodeSelectionField;
        
        private TermsSelection termsSelectionField;
        
        private ProductCategorySelection productCategorySelectionField;
        
        private InvoiceDiscountCodeSelection invoiceDiscountCodeSelectionField;
        
        private CurrencySelection currencySelectionField;
        
        private CreditLimitSelection creditLimitSelectionField;
        
        /// <remarks/>
        public CustomerSelection CustomerSelection {
            get {
                return this.customerSelectionField;
            }
            set {
                this.customerSelectionField = value;
            }
        }
        
        /// <remarks/>
        public CustomerClassSelection CustomerClassSelection {
            get {
                return this.customerClassSelectionField;
            }
            set {
                this.customerClassSelectionField = value;
            }
        }
        
        /// <remarks/>
        public GeographicAreaSelection GeographicAreaSelection {
            get {
                return this.geographicAreaSelectionField;
            }
            set {
                this.geographicAreaSelectionField = value;
            }
        }
        
        /// <remarks/>
        public BranchSelection BranchSelection {
            get {
                return this.branchSelectionField;
            }
            set {
                this.branchSelectionField = value;
            }
        }
        
        /// <remarks/>
        public SalespersonSelection SalespersonSelection {
            get {
                return this.salespersonSelectionField;
            }
            set {
                this.salespersonSelectionField = value;
            }
        }
        
        /// <remarks/>
        public LineDiscountCodeSelection LineDiscountCodeSelection {
            get {
                return this.lineDiscountCodeSelectionField;
            }
            set {
                this.lineDiscountCodeSelectionField = value;
            }
        }
        
        /// <remarks/>
        public TermsSelection TermsSelection {
            get {
                return this.termsSelectionField;
            }
            set {
                this.termsSelectionField = value;
            }
        }
        
        /// <remarks/>
        public ProductCategorySelection ProductCategorySelection {
            get {
                return this.productCategorySelectionField;
            }
            set {
                this.productCategorySelectionField = value;
            }
        }
        
        /// <remarks/>
        public InvoiceDiscountCodeSelection InvoiceDiscountCodeSelection {
            get {
                return this.invoiceDiscountCodeSelectionField;
            }
            set {
                this.invoiceDiscountCodeSelectionField = value;
            }
        }
        
        /// <remarks/>
        public CurrencySelection CurrencySelection {
            get {
                return this.currencySelectionField;
            }
            set {
                this.currencySelectionField = value;
            }
        }
        
        /// <remarks/>
        public CreditLimitSelection CreditLimitSelection {
            get {
                return this.creditLimitSelectionField;
            }
            set {
                this.creditLimitSelectionField = value;
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
    public partial class GeographicAreaSelection {
        
        private GeographicAreaSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public GeographicAreaSelectionFilterType FilterType {
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
    public enum GeographicAreaSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class SalespersonSelection {
        
        private SalespersonSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SalespersonSelectionFilterType FilterType {
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
    public enum SalespersonSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class LineDiscountCodeSelection {
        
        private LineDiscountCodeSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LineDiscountCodeSelectionFilterType FilterType {
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
    public enum LineDiscountCodeSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class TermsSelection {
        
        private TermsSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TermsSelectionFilterType FilterType {
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
    public enum TermsSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class ProductCategorySelection {
        
        private ProductCategorySelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ProductCategorySelectionFilterType FilterType {
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
    public enum ProductCategorySelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class InvoiceDiscountCodeSelection {
        
        private InvoiceDiscountCodeSelectionFilterType filterTypeField;
        
        private bool filterTypeFieldSpecified;
        
        private string filterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDiscountCodeSelectionFilterType FilterType {
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
    public enum InvoiceDiscountCodeSelectionFilterType {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        S,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum InterestExemptionStatusSelection {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        E,
        
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
    public partial class Option {
        
        private ReportSequence reportSequenceField;
        
        private bool reportSequenceFieldSpecified;
        
        private string priceCodeField;
        
        private PriceProductmatrix priceProductmatrixField;
        
        private bool priceProductmatrixFieldSpecified;
        
        private ExtraFields extraFieldsField;
        
        private bool extraFieldsFieldSpecified;
        
        private InterestExemptionStatusSelection interestExemptionStatusSelectionField;
        
        private bool interestExemptionStatusSelectionFieldSpecified;
        
        private TaxExemptionSelection taxExemptionSelectionField;
        
        private bool taxExemptionSelectionFieldSpecified;
        
        /// <remarks/>
        public ReportSequence ReportSequence {
            get {
                return this.reportSequenceField;
            }
            set {
                this.reportSequenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportSequenceSpecified {
            get {
                return this.reportSequenceFieldSpecified;
            }
            set {
                this.reportSequenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string PriceCode {
            get {
                return this.priceCodeField;
            }
            set {
                this.priceCodeField = value;
            }
        }
        
        /// <remarks/>
        public PriceProductmatrix PriceProductmatrix {
            get {
                return this.priceProductmatrixField;
            }
            set {
                this.priceProductmatrixField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceProductmatrixSpecified {
            get {
                return this.priceProductmatrixFieldSpecified;
            }
            set {
                this.priceProductmatrixFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public ExtraFields ExtraFields {
            get {
                return this.extraFieldsField;
            }
            set {
                this.extraFieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtraFieldsSpecified {
            get {
                return this.extraFieldsFieldSpecified;
            }
            set {
                this.extraFieldsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public InterestExemptionStatusSelection InterestExemptionStatusSelection {
            get {
                return this.interestExemptionStatusSelectionField;
            }
            set {
                this.interestExemptionStatusSelectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InterestExemptionStatusSelectionSpecified {
            get {
                return this.interestExemptionStatusSelectionFieldSpecified;
            }
            set {
                this.interestExemptionStatusSelectionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public TaxExemptionSelection TaxExemptionSelection {
            get {
                return this.taxExemptionSelectionField;
            }
            set {
                this.taxExemptionSelectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaxExemptionSelectionSpecified {
            get {
                return this.taxExemptionSelectionFieldSpecified;
            }
            set {
                this.taxExemptionSelectionFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum ReportSequence {
        
        /// <remarks/>
        CU,
        
        /// <remarks/>
        SN,
        
        /// <remarks/>
        BR,
        
        /// <remarks/>
        CC,
        
        /// <remarks/>
        GA,
        
        /// <remarks/>
        SP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public enum PriceProductmatrix {
        
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
    public enum TaxExemptionSelection {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        E,
        
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
        
        private Option optionField;
        
        private Filter filterField;
        
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
