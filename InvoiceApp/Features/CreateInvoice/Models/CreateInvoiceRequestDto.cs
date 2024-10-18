using InvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Features.CreateInvoice.Models
{
    public class CreateInvoiceRequestDto
    {
        required public string Nit { get; set; }
        required public string CustomerName { get; set; }
        required public List<Item> LineItems { get; set; }

    }
}
