using InvoiceApp.Features.CreateInvoice;
using InvoiceApp.Features.CreateInvoice.Models;
using InvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceApp.Forms
{
    public partial class CreateInvoiceForm : BaseForm, ICreateInvoiceView
    {
        public CreateInvoiceForm()
        {
            InitializeComponent();
        }

        public string CustomerName { get => textBoxCustomerName.Text; }
        public string Nit { get => textBoxNit.Text; }
        public List<Item> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool FetchCompleted
        {
            get
            {
                return true;
            }
            set
            {
                if (value)
                {
                    Close();
                }
            }
        }

        public event EventHandler? HandleOnClickCreateInvoice;

        private void HandleClickCreateInvoice(object sender, EventArgs e)
        {
            var invoiceCreate = new CreateInvoiceRequestDto()
            {
                CustomerName = CustomerName,
                LineItems = [],
                Nit = Nit
            };
            HandleOnClickCreateInvoice?.Invoke(invoiceCreate, EventArgs.Empty);
        }
    }
}
