namespace InvoiceApp.Forms
{
    partial class CreateInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            dataGridItems = new DataGridView();
            Description = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            textBoxCustomerName = new TextBox();
            textBoxNit = new TextBox();
            label2 = new Label();
            labelDataGrid = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridItems).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelTitle.Location = new Point(16, 24);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(162, 23);
            labelTitle.TabIndex = 9;
            labelTitle.Text = "Crear nueva factura";
            // 
            // dataGridItems
            // 
            dataGridItems.BackgroundColor = SystemColors.Control;
            dataGridItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItems.Columns.AddRange(new DataGridViewColumn[] { Description, Quantity, UnitPrice });
            dataGridItems.Location = new Point(19, 195);
            dataGridItems.Margin = new Padding(3, 12, 3, 3);
            dataGridItems.Name = "dataGridItems";
            dataGridItems.RowHeadersWidth = 51;
            dataGridItems.Size = new Size(435, 188);
            dataGridItems.TabIndex = 10;
            // 
            // Description
            // 
            Description.HeaderText = "Descripción";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Cantidad";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "Precio por unidad";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(319, 436);
            button1.Margin = new Padding(3, 16, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(135, 40);
            button1.TabIndex = 13;
            button1.Text = "Crear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += HandleClickCreateInvoice;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 75);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 14;
            label1.Text = "Nombre de cliente";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(19, 108);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(195, 27);
            textBoxCustomerName.TabIndex = 15;
            // 
            // textBoxNit
            // 
            textBoxNit.Location = new Point(259, 108);
            textBoxNit.Name = "textBoxNit";
            textBoxNit.Size = new Size(195, 27);
            textBoxNit.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 75);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 16;
            label2.Text = "NIT";
            // 
            // labelDataGrid
            // 
            labelDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDataGrid.AutoSize = true;
            labelDataGrid.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDataGrid.Location = new Point(19, 163);
            labelDataGrid.Margin = new Padding(3, 24, 3, 0);
            labelDataGrid.Name = "labelDataGrid";
            labelDataGrid.Size = new Size(45, 20);
            labelDataGrid.TabIndex = 18;
            labelDataGrid.Text = "Items";
            // 
            // CreateInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 515);
            Controls.Add(labelDataGrid);
            Controls.Add(textBoxNit);
            Controls.Add(label2);
            Controls.Add(textBoxCustomerName);
            Controls.Add(label1);
            Controls.Add(labelTitle);
            Controls.Add(dataGridItems);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CreateInvoiceForm";
            Padding = new Padding(16, 24, 16, 16);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Manager - Crear";
            ((System.ComponentModel.ISupportInitialize)dataGridItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridItems;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn UnitPrice;
        private Button button1;
        private Label label1;
        private TextBox textBoxCustomerName;
        private TextBox textBoxNit;
        private Label label2;
        private Label labelDataGrid;
    }
}