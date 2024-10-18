using InvoiceApp.Features.CreateInvoice.Models;
using InvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            var rawInvoice = (UnvalidatedCreateInvoiceRequestDto)sender;

            var invoice = ValidateInvoiceRequest(rawInvoice);
            if (invoice == null)
            {
                return;
            }
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

        private CreateInvoiceRequestDto? ValidateInvoiceRequest(UnvalidatedCreateInvoiceRequestDto invoice)
        {
            List<Item> validItems = [];


            if (string.IsNullOrEmpty(invoice.CustomerName))
            {
                _view.ErrorMessage = "Nombre de cliente inválido";
                return null;
            }

            if (string.IsNullOrEmpty(invoice.Nit))
            {
                _view.ErrorMessage = "Nit inválido";
                return null;
            }

            foreach (var rawItem in invoice.LineItems)
            {
                var item = ValidateItemRowAndParse(rawItem);
                if (item == null)
                {
                    _view.ErrorMessage = "Item inválido";
                    return null;
                }
                validItems.Add(item);
            }

            if (validItems.Count == 0)
            {
                _view.ErrorMessage = "Debes incluir al menos 1 item";
                return null;
            }
            _view.Items = validItems;
            return new CreateInvoiceRequestDto()
            {
                CustomerName = invoice.CustomerName,
                LineItems = validItems,
                Nit = invoice.Nit
            };
        }
        private static Item? ValidateItemRowAndParse(RawItem rawItem)
        {
            var description = rawItem.description;
            var quantity = Convert.ToInt32(rawItem.quantity);
            var unitPrice = Convert.ToInt32(rawItem.unitPrice);

            if (string.IsNullOrWhiteSpace(description) || quantity <= 0 || unitPrice <= 0)
            {
                return null;
            }

            return new Item() { Description = description, Quantity = quantity, UnitPrice = unitPrice };
        }
    }
}
