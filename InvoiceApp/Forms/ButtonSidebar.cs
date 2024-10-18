using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace InvoiceApp.Forms
{
    public partial class ButtonSidebar : UserControl
    {
        public ButtonSidebar()
        {
            InitializeComponent();
        }

        [Category("CustomOptions")]
        public string OptionName
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        [Category("CustomOptions")]
        public Image OptionImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        [Category("CustomOptions")]
        public Color OptionBackgroundColor
        {
            get { return BackColor; }
            set
            {
                BackColor = value;
                CustomBackColor = value;
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(15, Color.Black);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            BackColor = CustomBackColor;
        }

        private Color CustomBackColor;
    }
}
