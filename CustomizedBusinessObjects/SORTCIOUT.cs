namespace SYSPRO.NET.BusinessObjects.SORTCIOUT
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public class postcreditfrominvoice
  {
    public Item Item { get; set; }
    public StatusOfItems StatusOfItems { get; set; }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public class Item
  {
    public ValidationStatus ValidationStatus { get; set; }
    public string ItemNumber { get; set; }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public class ValidationStatus
  {
    public InvoiceDetails InvoiceDetails { get; set; }
    public string Status { get; set; }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public class InvoiceDetails
  {
    public string CreditNoteCreated { get; set; }
    public string InvoiceNumber { get; set; }
    public string SalesOrder { get; set; }
    public string Customer { get; set; }
    public string DispatchNote { get; set; }
  }

  [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.18020")]
  [System.SerializableAttribute()]
  [System.Diagnostics.DebuggerStepThroughAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
  public class StatusOfItems
  {
    public string ItemsProcessed { get; set; }
    public string ItemsInvalid { get; set; }
  }
}
