namespace InvoiceApp.Forms
{
    partial class ContainerSection
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 30);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 12);
            label1.Size = new Size(96, 53);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ContainerSection
            // 
            BackColor = SystemColors.Control;
            Controls.Add(label1);
            Margin = new Padding(3, 3, 16, 3);
            Name = "ContainerSection";
            Padding = new Padding(0, 30, 0, 0);
            Size = new Size(452, 240);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
