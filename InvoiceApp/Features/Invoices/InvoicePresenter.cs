using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Features.Invoices
{
    public class InvoicePresenter
    {
        private readonly IInvoiceView _view;
        private readonly InvoiceService _invoiceService;

        public InvoicePresenter(IInvoiceView view, InvoiceService invoiceService)
        {
            _view = view;
            _invoiceService = invoiceService;
            _view.HandleOnLoadFetchInvoices += OnLoadFetchInvoices;

        }
        public async void OnLoadFetchInvoices(object sender, EventArgs e)
        {
            _view.IsLoading = true;
            try
            {
                var invoices = await _invoiceService.GetInvoicesAsync();
                _view.Invoices = invoices;
            }
            catch (Exception ex)
            {
                _view.ErrorMessage = ex.Message;
            }
            finally
            {
                _view.IsLoading = false;
            }
        }
    }
}
