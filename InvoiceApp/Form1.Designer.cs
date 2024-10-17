using InvoiceApp.Forms;

namespace InvoiceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SidebarPanel = new Panel();
            layoutPanelSidebarOptions = new FlowLayoutPanel();
            buttonSidebar1 = new ButtonSidebar();
            buttonSidebar2 = new ButtonSidebar();
            layoutPanelLogo = new FlowLayoutPanel();
            pictureBoxLogo = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            labelLogo = new Label();
            labelDescription = new Label();
            SidebarPanel.SuspendLayout();
            layoutPanelSidebarOptions.SuspendLayout();
            layoutPanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // SidebarPanel
            // 
            SidebarPanel.Controls.Add(layoutPanelSidebarOptions);
            SidebarPanel.Controls.Add(layoutPanelLogo);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Padding = new Padding(16, 0, 16, 0);
            SidebarPanel.Size = new Size(361, 464);
            SidebarPanel.TabIndex = 0;
            // 
            // layoutPanelSidebarOptions
            // 
            layoutPanelSidebarOptions.Controls.Add(buttonSidebar1);
            layoutPanelSidebarOptions.Controls.Add(buttonSidebar2);
            layoutPanelSidebarOptions.Dock = DockStyle.Top;
            layoutPanelSidebarOptions.FlowDirection = FlowDirection.TopDown;
            layoutPanelSidebarOptions.Location = new Point(16, 100);
            layoutPanelSidebarOptions.Margin = new Padding(0);
            layoutPanelSidebarOptions.Name = "layoutPanelSidebarOptions";
            layoutPanelSidebarOptions.Padding = new Padding(0, 16, 0, 0);
            layoutPanelSidebarOptions.Size = new Size(329, 216);
            layoutPanelSidebarOptions.TabIndex = 3;
            // 
            // buttonSidebar1
            // 
            buttonSidebar1.BackColor = Color.FromArgb(15, 0, 0, 0);
            buttonSidebar1.Location = new Point(0, 16);
            buttonSidebar1.Margin = new Padding(0);
            buttonSidebar1.Name = "buttonSidebar1";
            buttonSidebar1.OptionBackgroundColor = Color.FromArgb(15, 0, 0, 0);
            buttonSidebar1.OptionImage = (Image)resources.GetObject("buttonSidebar1.OptionImage");
            buttonSidebar1.OptionName = "Facturas";
            buttonSidebar1.Padding = new Padding(12, 0, 12, 0);
            buttonSidebar1.Size = new Size(300, 45);
            buttonSidebar1.TabIndex = 0;
            // 
            // buttonSidebar2
            // 
            buttonSidebar2.BackColor = Color.FromArgb(0, 0, 0, 0);
            buttonSidebar2.Location = new Point(0, 73);
            buttonSidebar2.Margin = new Padding(0, 12, 0, 0);
            buttonSidebar2.Name = "buttonSidebar2";
            buttonSidebar2.OptionBackgroundColor = Color.FromArgb(0, 0, 0, 0);
            buttonSidebar2.OptionImage = (Image)resources.GetObject("buttonSidebar2.OptionImage");
            buttonSidebar2.OptionName = "Configuración";
            buttonSidebar2.Padding = new Padding(12, 0, 12, 0);
            buttonSidebar2.Size = new Size(300, 45);
            buttonSidebar2.TabIndex = 1;
            // 
            // layoutPanelLogo
            // 
            layoutPanelLogo.AutoSize = true;
            layoutPanelLogo.Controls.Add(pictureBoxLogo);
            layoutPanelLogo.Controls.Add(flowLayoutPanel2);
            layoutPanelLogo.Dock = DockStyle.Top;
            layoutPanelLogo.Location = new Point(16, 0);
            layoutPanelLogo.Name = "layoutPanelLogo";
            layoutPanelLogo.Padding = new Padding(0, 12, 0, 12);
            layoutPanelLogo.Size = new Size(329, 100);
            layoutPanelLogo.TabIndex = 2;
            layoutPanelLogo.WrapContents = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Left;
            pictureBoxLogo.Enabled = false;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(3, 15);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(78, 70);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(labelLogo);
            flowLayoutPanel2.Controls.Add(labelDescription);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(92, 12);
            flowLayoutPanel2.Margin = new Padding(8, 0, 0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 12, 0, 12);
            flowLayoutPanel2.Size = new Size(203, 76);
            flowLayoutPanel2.TabIndex = 5;
            flowLayoutPanel2.WrapContents = false;
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelLogo.Location = new Point(0, 12);
            labelLogo.Margin = new Padding(0, 0, 0, 4);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(163, 28);
            labelLogo.TabIndex = 5;
            labelLogo.Text = "Invoice Manager";
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescription.ForeColor = SystemColors.ControlText;
            labelDescription.Location = new Point(0, 44);
            labelDescription.Margin = new Padding(0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(203, 20);
            labelDescription.TabIndex = 4;
            labelDescription.Text = "Crea y administra tus facturas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 464);
            Controls.Add(SidebarPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Invoice Manager";
            SidebarPanel.ResumeLayout(false);
            SidebarPanel.PerformLayout();
            layoutPanelSidebarOptions.ResumeLayout(false);
            layoutPanelLogo.ResumeLayout(false);
            layoutPanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidebarPanel;
        private FlowLayoutPanel layoutPanelLogo;
        private PictureBox pictureBoxLogo;
        private Label labelDescription;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label labelLogo;
        private FlowLayoutPanel layoutPanelSidebarOptions;
        private ButtonSidebar buttonSidebar1;
        private ButtonSidebar buttonSidebar2;
    }
}
