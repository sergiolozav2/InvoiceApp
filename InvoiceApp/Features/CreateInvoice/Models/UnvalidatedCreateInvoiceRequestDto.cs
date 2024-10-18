using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Features.CreateInvoice.Models
{
    public class UnvalidatedCreateInvoiceRequestDto
    {
        required public string Nit { get; set; }
        required public string CustomerName { get; set; }
        required public List<RawItem> LineItems { get; set; }

    }
}
