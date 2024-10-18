using InvoiceApp.Features.CreateInvoice;
using InvoiceApp.Features.Invoices;
using InvoiceApp.Forms;

namespace InvoiceApp
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            CustomInitializeComponent();

            var invoiceService = new InvoiceService();
            _ = new InvoicePresenter(dataGridViewInvoice2, invoiceService);
        }

        private void buttonSidebar3_Load(object sender, EventArgs e)
        {
            var form = new CreateInvoiceForm();
            var invoiceService = new CreateInvoiceService();
            _ = new CreateInvoicePresenter(form, invoiceService);
            form.Show(this);
        }
    }
}
