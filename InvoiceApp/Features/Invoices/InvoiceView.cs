using InvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Features.Invoices
{
    public interface IInvoiceView
    {
        Boolean IsLoading { get; set; }
        string ErrorMessage { get; set; }
        List<Invoice>? Invoices { get; set; }
        event EventHandler HandleOnLoadFetchInvoices;
    }
}
