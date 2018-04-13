using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SYSPRO.NET.BusinessObjects.SORTCH
{
    [XmlRoot("Parameters")]
    public partial class SOCreditNoteHeaderParameters
    {
        public SOCreditNoteHeaderParameters(int unused)
            : this()
        {
            DocumentDate = "";
            IgnoreWarnings = SOCreditNoteHeaderParametersIgnoreWarnings.Y;
            ApplyIfEntireDocumentValid = SOCreditNoteHeaderParametersApplyIfEntireDocumentValid.N;
            ValidateOnly = SOCreditNoteHeaderParametersValidateOnly.N;
            ValidateOnlySpecified = true;
        }
    }
}
