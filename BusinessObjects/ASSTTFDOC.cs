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
namespace SYSPRO.NET.BusinessObjects.ASSTTFDOC {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class PostAssetTransfer {
        
        private PostAssetTransferItem[] itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public PostAssetTransferItem[] Item {
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
    public partial class PostAssetTransferItem {
        
        private string assetField;
        
        private string transferDateField;
        
        private string transferCommentField;
        
        private string branchField;
        
        private string assetCostCenterField;
        
        private string assetGroupCodeField;
        
        private string locationField;
        
        private string respUserField;
        
        private string assetOwnerField;
        
        private string eSignatureField;
        
        /// <remarks/>
        public string Asset {
            get {
                return this.assetField;
            }
            set {
                this.assetField = value;
            }
        }
        
        /// <remarks/>
        public string TransferDate {
            get {
                return this.transferDateField;
            }
            set {
                this.transferDateField = value;
            }
        }
        
        /// <remarks/>
        public string TransferComment {
            get {
                return this.transferCommentField;
            }
            set {
                this.transferCommentField = value;
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
        public string AssetCostCenter {
            get {
                return this.assetCostCenterField;
            }
            set {
                this.assetCostCenterField = value;
            }
        }
        
        /// <remarks/>
        public string AssetGroupCode {
            get {
                return this.assetGroupCodeField;
            }
            set {
                this.assetGroupCodeField = value;
            }
        }
        
        /// <remarks/>
        public string Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        public string RespUser {
            get {
                return this.respUserField;
            }
            set {
                this.respUserField = value;
            }
        }
        
        /// <remarks/>
        public string AssetOwner {
            get {
                return this.assetOwnerField;
            }
            set {
                this.assetOwnerField = value;
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
}
