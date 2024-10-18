namespace InvoiceApp.Forms.Invoices
{
    partial class DataGridViewInvoice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewInvoice));
            dataGridView1 = new DataGridView();
            DownloadPDF = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            labelError = new Label();
            timerFetchPolling = new System.Windows.Forms.Timer();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DownloadPDF });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(3);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.Size = new Size(464, 259);
            dataGridView1.MinimumSize = new Size(150, 500);

            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
            // 
            // DownloadPDF
            // 
            DownloadPDF.FlatStyle = FlatStyle.Flat;
            DownloadPDF.HeaderText = "Acción";
            DownloadPDF.MinimumWidth = 6;
            DownloadPDF.Name = "DownloadPDF";
            DownloadPDF.ReadOnly = true;
            DownloadPDF.Resizable = DataGridViewTriState.False;
            DownloadPDF.SortMode = DataGridViewColumnSortMode.Automatic;
            DownloadPDF.Text = "Descargar";
            DownloadPDF.UseColumnTextForButtonValue = true;
            DownloadPDF.Width = 125;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 259);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(464, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Dock = DockStyle.Top;
            labelError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelError.ForeColor = Color.IndianRed;
            labelError.Location = new Point(0, 286);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 20);
            labelError.TabIndex = 2;
            // 
            // timerFetchPolling
            // 
            timerFetchPolling.Interval = 1500;
            timerFetchPolling.Tick += OnTickFetchInvoices;
            // 
            // DataGridViewInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelError);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            dataGridView1.CellClick += DataGridViewDownloadPDF_CellClick;
            Name = "DataGridViewInvoice";
            Size = new Size(464, 400);
            Load += OnLoadDataGrid;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label labelError;
        private DataGridViewButtonColumn DownloadPDF;
        private System.Windows.Forms.Timer timerFetchPolling;
    }
}
