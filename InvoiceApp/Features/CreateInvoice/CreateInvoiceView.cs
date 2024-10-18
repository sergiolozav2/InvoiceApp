using InvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Features.CreateInvoice
{
    public interface ICreateInvoiceView
    {
        string CustomerName { get; }
        string Nit { get; }
        List<Item> Items { get; set; }
        string ErrorMessage { get; set; }
        Boolean FetchCompleted {  get; set; }
        event EventHandler HandleOnClickCreateInvoice;
    }
}
