using InvoiceApp.Features.CreateInvoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Features.CreateInvoice
{
    public class CreateInvoicePresenter
    {
        private readonly ICreateInvoiceView _view;
        private readonly CreateInvoiceService _invoiceService;

        public CreateInvoicePresenter(ICreateInvoiceView view, CreateInvoiceService invoiceService)
        {
            _view = view;
            _invoiceService = invoiceService;
            _view.HandleOnClickCreateInvoice += HandleOnClickCreateInvoice;

        }
        public async void HandleOnClickCreateInvoice(object? sender, EventArgs e)
        {
            if (sender == null) { throw new ApplicationException("Sender event null"); }
            var invoice = (CreateInvoiceRequestDto)sender;
            try
            {
                await _invoiceService.CreateInvoiceAsync(invoice);
                _view.FetchCompleted = true;
            }
            catch (Exception ex)
            {
                _view.ErrorMessage = ex.Message;
            }
        }
    }
}
