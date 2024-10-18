using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace InvoiceApp.Forms
{
    [Designer(typeof(ParentControlDesigner))]
    public partial class ContainerSection : UserControl
    {
        public ContainerSection()
        {
            InitializeComponent();
        }

        [Category("CustomOptions")]
        public string SectionName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}
