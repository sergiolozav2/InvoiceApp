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
            _view.HandleOnClickDownloadInvoicePDF += OnClickDownloadInvoicePDF;

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

        public async void OnClickDownloadInvoicePDF(object? sender, EventArgs e)
        {
            if (sender == null) { throw new ApplicationException("sender shouldn't be null"); }
            var cuf = (string)sender;
            try
            {
                var filePath = await _invoiceService.GetInvoicePDFAsync(cuf);
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                _view.ErrorMessage = ex.Message;
            }
        }
    }
}
