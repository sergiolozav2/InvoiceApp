using InvoiceApp.Features.Invoices;
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

namespace InvoiceApp.Forms.Invoices
{
    public partial class DataGridViewInvoice : UserControl, IInvoiceView
    {
        public DataGridViewInvoice()
        {
            InitializeComponent();
            timerFetchPolling.Start();
        }

        public bool IsLoading
        {
            get { return pictureBox1.Visible; }
            set { pictureBox1.Visible = value; }
        }
        public List<Invoice>? Invoices
        {
            get { return DataGridInvoices; }
            set
            {
                if (value != null)
                {
                    DataGridInvoices = value;
                    dataGridView1.DataSource = Invoices;
                    dataGridView1.Visible = true;
                    dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        row.Height = 50;
                    }
                    if (dataGridView1.Columns.Count > 7)
                    {
                    dataGridView1.Columns[1].DisplayIndex = 7;
                    dataGridView1.Columns[0].DisplayIndex = 6;
                    }
                }
            }
        }
        public string ErrorMessage
        {
            get
            {
                return labelError.Text;
            }
            set
            {
                labelError.Text = value;
            }
        }
        public event EventHandler? HandleOnLoadFetchInvoices;
        private void OnLoadDataGrid(object sender, EventArgs e)
        {
            this.HandleOnLoadFetchInvoices?.Invoke(this, EventArgs.Empty);
        }

        private void OnTickFetchInvoices(object sender, EventArgs e)
        {
            this.HandleOnLoadFetchInvoices?.Invoke(this, EventArgs.Empty);
        }

        private List<Invoice> DataGridInvoices { get; set; } = [];
    }
}
