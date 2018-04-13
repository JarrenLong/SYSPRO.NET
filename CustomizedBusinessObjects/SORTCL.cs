using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSPRO.NET.BusinessObjects.SORTCL
{
    public partial class Parameters
    {
        public Parameters(int unused) : this()
        {
            DocumentDate = "";
            IgnoreWarnings = SORTCL.IgnoreWarnings.Y;
            IgnoreWarningsSpecified = true;
            ApplyIfEntireDocumentValid = SORTCL.ApplyIfEntireDocumentValid.Y;
            ApplyIfEntireDocumentValidSpecified = true;
            ValidateOnly = SORTCL.ValidateOnly.N;
            ValidateOnlySpecified = true;
            TransferManualSerials = SORTCL.TransferManualSerials.N;
            TransferManualSerialsSpecified = true;
        }
    }

}
