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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            BackColor = Color.FromArgb(239, 244, 249); ;
        }
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            BackColor = Color.FromArgb(243, 243, 243);
        }
    }
}
