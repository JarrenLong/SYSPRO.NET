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
namespace SYSPRO.NET.BusinessObjects.CFGTFD {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostConfiguration {
        
        private PostConfigurationParameters parametersField;
        
        /// <remarks/>
        public PostConfigurationParameters Parameters {
            get {
                return this.parametersField;
            }
            set {
                this.parametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class PostConfigurationParameters {
        
        private PostConfigurationParametersFunction functionField;
        
        private string configurationInstanceField;
        
        private PostConfigurationParametersIgnoreWarnings ignoreWarningsField;
        
        private PostConfigurationParametersValidateWorkingDays validateWorkingDaysField;
        
        public PostConfigurationParameters() {
            this.functionField = PostConfigurationParametersFunction.N;
            this.ignoreWarningsField = PostConfigurationParametersIgnoreWarnings.N;
            this.validateWorkingDaysField = PostConfigurationParametersValidateWorkingDays.A;
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostConfigurationParametersFunction.N)]
        public PostConfigurationParametersFunction Function {
            get {
                return this.functionField;
            }
            set {
                this.functionField = value;
            }
        }
        
        /// <remarks/>
        public string ConfigurationInstance {
            get {
                return this.configurationInstanceField;
            }
            set {
                this.configurationInstanceField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostConfigurationParametersIgnoreWarnings.N)]
        public PostConfigurationParametersIgnoreWarnings IgnoreWarnings {
            get {
                return this.ignoreWarningsField;
            }
            set {
                this.ignoreWarningsField = value;
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(PostConfigurationParametersValidateWorkingDays.A)]
        public PostConfigurationParametersValidateWorkingDays ValidateWorkingDays {
            get {
                return this.validateWorkingDaysField;
            }
            set {
                this.validateWorkingDaysField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostConfigurationParametersFunction {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        P,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostConfigurationParametersIgnoreWarnings {
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        Y,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public enum PostConfigurationParametersValidateWorkingDays {
        
        /// <remarks/>
        A,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        P,
    }
}
