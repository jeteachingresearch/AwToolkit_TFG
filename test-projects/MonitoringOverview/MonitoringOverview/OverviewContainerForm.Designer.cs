namespace MonitoringOverview
{

    using CustomControls;

    partial class overviewContainerForm
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
            this.containerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.monitoringPanel1 = new MonitoringOverview.CustomControls.MonitoringPanel();
            this.monitoringPanel2 = new MonitoringOverview.CustomControls.MonitoringPanel();
            this.monitoringPanel3 = new MonitoringOverview.CustomControls.MonitoringPanel();
            this.monitoringPanel4 = new MonitoringOverview.CustomControls.MonitoringPanel();
            this.containerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerLayout
            // 
            this.containerLayout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.containerLayout.ColumnCount = 2;
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerLayout.Controls.Add(this.monitoringPanel1, 0, 0);
            this.containerLayout.Controls.Add(this.monitoringPanel2, 1, 0);
            this.containerLayout.Controls.Add(this.monitoringPanel3, 0, 1);
            this.containerLayout.Controls.Add(this.monitoringPanel4, 1, 1);
            this.containerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerLayout.Location = new System.Drawing.Point(0, 0);
            this.containerLayout.Name = "containerLayout";
            this.containerLayout.RowCount = 2;
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.containerLayout.Size = new System.Drawing.Size(1464, 767);
            this.containerLayout.TabIndex = 0;
            this.containerLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.Layout_Paint);
            // 
            // monitoringPanel1
            // 
            this.monitoringPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monitoringPanel1.Location = new System.Drawing.Point(3, 3);
            this.monitoringPanel1.Name = "monitoringPanel1";
            this.monitoringPanel1.Size = new System.Drawing.Size(726, 377);
            this.monitoringPanel1.TabIndex = 0;
            // 
            // monitoringPanel2
            // 
            this.monitoringPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monitoringPanel2.Location = new System.Drawing.Point(735, 3);
            this.monitoringPanel2.Name = "monitoringPanel2";
            this.monitoringPanel2.Size = new System.Drawing.Size(726, 377);
            this.monitoringPanel2.TabIndex = 1;
            // 
            // monitoringPanel3
            // 
            this.monitoringPanel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monitoringPanel3.Location = new System.Drawing.Point(3, 386);
            this.monitoringPanel3.Name = "monitoringPanel3";
            this.monitoringPanel3.Size = new System.Drawing.Size(726, 378);
            this.monitoringPanel3.TabIndex = 2;
            // 
            // monitoringPanel4
            // 
            this.monitoringPanel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monitoringPanel4.Location = new System.Drawing.Point(735, 386);
            this.monitoringPanel4.Name = "monitoringPanel4";
            this.monitoringPanel4.Size = new System.Drawing.Size(726, 378);
            this.monitoringPanel4.TabIndex = 3;
            // 
            // overviewContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 767);
            this.Controls.Add(this.containerLayout);
            this.Name = "overviewContainerForm";
            this.Text = "MonitoringOverview";
            this.containerLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel containerLayout;
        private MonitoringPanel monitoring1;
        private MonitoringPanel monitoringPanel1;
        private MonitoringPanel monitoringPanel2;
        private MonitoringPanel monitoringPanel3;
        private MonitoringPanel monitoringPanel4;
    }
}