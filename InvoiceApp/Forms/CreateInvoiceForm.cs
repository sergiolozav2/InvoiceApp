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
        public List<Item> Items { set => Console.WriteLine(value); }
        public string ErrorMessage { get => labelError.Text; set => labelError.Text = value; }
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
            var invoiceCreate = new UnvalidatedCreateInvoiceRequestDto()
            {
                CustomerName = CustomerName,
                LineItems = GetRawItemsFromDataGrid(),
                Nit = Nit
            };
            HandleOnClickCreateInvoice?.Invoke(invoiceCreate, EventArgs.Empty);
        }

        private List<RawItem> GetRawItemsFromDataGrid()
        {
            var rawItems = new List<RawItem>();
            foreach (DataGridViewRow row in dataGridItems.Rows)
            {
                if (row.IsNewRow) continue;
                var description = row.Cells["Description"].Value?.ToString();
                var quantity = row.Cells["Quantity"].Value?.ToString();
                var unitPrice = row.Cells["UnitPrice"].Value?.ToString();
                rawItems.Add(new RawItem
                {
                    description = description,
                    quantity = quantity,
                    unitPrice = unitPrice
                });
            }
            return rawItems;
        }
    }
}
