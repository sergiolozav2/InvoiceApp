using InvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public async void OnLoadFetchInvoices(object? sender, EventArgs e)
        {
            _view.IsLoading = true;
            try
            {
                var invoices = await _invoiceService.GetInvoicesAsync();
                _view.Invoices = invoices;
                _view.ErrorMessage = string.Empty;
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
            var invoice = (Invoice)sender;
            if(invoice.Status == 0)
            {
                _view.ErrorMessage = "La factura no está aprobada todavía";
            }
            try
            {
                var filePath = await _invoiceService.GetInvoicePDFAsync(invoice.Cuf);
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
                _view.ErrorMessage = string.Empty;
            }
            catch (Exception ex)
            {
                _view.ErrorMessage = ex.Message;
            }
        }
    }
}
