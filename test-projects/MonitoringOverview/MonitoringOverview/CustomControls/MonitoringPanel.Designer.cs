namespace MonitoringOverview.CustomControls
{
    partial class MonitoringPanel
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.monitoringPanelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pacientName = new System.Windows.Forms.Label();
            this.electroGraph = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightPanelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.heartVitalsPanel = new System.Windows.Forms.Panel();
            this.cardioFreqValue = new System.Windows.Forms.Label();
            this.tensionVitalsPanel = new System.Windows.Forms.Panel();
            this.meanTensionValue = new System.Windows.Forms.Label();
            this.meanTensionLabel = new System.Windows.Forms.Label();
            this.tensionValues = new System.Windows.Forms.Label();
            this.respiratoryVitalsPanel = new System.Windows.Forms.Panel();
            this.co2Value = new System.Windows.Forms.Label();
            this.co2Label = new System.Windows.Forms.Label();
            this.respFreqValue = new System.Windows.Forms.Label();
            this.satO2Value = new System.Windows.Forms.Label();
            this.satO2Label = new System.Windows.Forms.Label();
            this.otherVitalspanel = new System.Windows.Forms.Panel();
            this.temperatureValue = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.monitoringPanelLayout.SuspendLayout();
            this.leftPanelLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electroGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.rightPanelLayout.SuspendLayout();
            this.heartVitalsPanel.SuspendLayout();
            this.tensionVitalsPanel.SuspendLayout();
            this.respiratoryVitalsPanel.SuspendLayout();
            this.otherVitalspanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitoringPanelLayout
            // 
            this.monitoringPanelLayout.ColumnCount = 2;
            this.monitoringPanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.monitoringPanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.monitoringPanelLayout.Controls.Add(this.leftPanelLayout, 0, 0);
            this.monitoringPanelLayout.Controls.Add(this.rightPanelLayout, 1, 0);
            this.monitoringPanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monitoringPanelLayout.Location = new System.Drawing.Point(0, 0);
            this.monitoringPanelLayout.Name = "monitoringPanelLayout";
            this.monitoringPanelLayout.RowCount = 1;
            this.monitoringPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.monitoringPanelLayout.Size = new System.Drawing.Size(1920, 1080);
            this.monitoringPanelLayout.TabIndex = 0;
            // 
            // leftPanelLayout
            // 
            this.leftPanelLayout.ColumnCount = 1;
            this.leftPanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanelLayout.Controls.Add(this.pacientName, 0, 0);
            this.leftPanelLayout.Controls.Add(this.electroGraph, 0, 1);
            this.leftPanelLayout.Controls.Add(this.pictureBox2, 0, 2);
            this.leftPanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanelLayout.Location = new System.Drawing.Point(3, 3);
            this.leftPanelLayout.Name = "leftPanelLayout";
            this.leftPanelLayout.RowCount = 3;
            this.leftPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.leftPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.leftPanelLayout.Size = new System.Drawing.Size(1338, 1074);
            this.leftPanelLayout.TabIndex = 0;
            // 
            // pacientName
            // 
            this.pacientName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pacientName.AutoSize = true;
            this.pacientName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pacientName.ForeColor = System.Drawing.SystemColors.Control;
            this.pacientName.Location = new System.Drawing.Point(599, 2);
            this.pacientName.Name = "pacientName";
            this.pacientName.Size = new System.Drawing.Size(140, 21);
            this.pacientName.TabIndex = 0;
            this.pacientName.Text = "{Nombre paciente}";
            // 
            // electroGraph
            // 
            this.electroGraph.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.electroGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electroGraph.Location = new System.Drawing.Point(25, 50);
            this.electroGraph.Margin = new System.Windows.Forms.Padding(25);
            this.electroGraph.Name = "electroGraph";
            this.electroGraph.Size = new System.Drawing.Size(1288, 474);
            this.electroGraph.TabIndex = 1;
            this.electroGraph.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(25, 574);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1288, 475);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // rightPanelLayout
            // 
            this.rightPanelLayout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightPanelLayout.ColumnCount = 1;
            this.rightPanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanelLayout.Controls.Add(this.heartVitalsPanel, 0, 0);
            this.rightPanelLayout.Controls.Add(this.tensionVitalsPanel, 0, 1);
            this.rightPanelLayout.Controls.Add(this.respiratoryVitalsPanel, 0, 2);
            this.rightPanelLayout.Controls.Add(this.otherVitalspanel, 0, 3);
            this.rightPanelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelLayout.Location = new System.Drawing.Point(1347, 3);
            this.rightPanelLayout.Name = "rightPanelLayout";
            this.rightPanelLayout.RowCount = 4;
            this.rightPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rightPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rightPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rightPanelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.rightPanelLayout.Size = new System.Drawing.Size(570, 1074);
            this.rightPanelLayout.TabIndex = 1;
            // 
            // heartVitalsPanel
            // 
            this.heartVitalsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heartVitalsPanel.BackColor = System.Drawing.SystemColors.Info;
            this.heartVitalsPanel.Controls.Add(this.cardioFreqValue);
            this.heartVitalsPanel.Location = new System.Drawing.Point(5, 5);
            this.heartVitalsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.heartVitalsPanel.Name = "heartVitalsPanel";
            this.heartVitalsPanel.Size = new System.Drawing.Size(560, 258);
            this.heartVitalsPanel.TabIndex = 0;
            // 
            // cardioFreqValue
            // 
            this.cardioFreqValue.AutoSize = true;
            this.cardioFreqValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardioFreqValue.Location = new System.Drawing.Point(239, 118);
            this.cardioFreqValue.Name = "cardioFreqValue";
            this.cardioFreqValue.Size = new System.Drawing.Size(83, 30);
            this.cardioFreqValue.TabIndex = 5;
            this.cardioFreqValue.Text = "{f. card}";
            // 
            // tensionVitalsPanel
            // 
            this.tensionVitalsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tensionVitalsPanel.BackColor = System.Drawing.SystemColors.Info;
            this.tensionVitalsPanel.Controls.Add(this.meanTensionValue);
            this.tensionVitalsPanel.Controls.Add(this.meanTensionLabel);
            this.tensionVitalsPanel.Controls.Add(this.tensionValues);
            this.tensionVitalsPanel.Location = new System.Drawing.Point(5, 273);
            this.tensionVitalsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.tensionVitalsPanel.Name = "tensionVitalsPanel";
            this.tensionVitalsPanel.Size = new System.Drawing.Size(560, 258);
            this.tensionVitalsPanel.TabIndex = 1;
            // 
            // meanTensionValue
            // 
            this.meanTensionValue.AutoSize = true;
            this.meanTensionValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.meanTensionValue.Location = new System.Drawing.Point(90, 210);
            this.meanTensionValue.Name = "meanTensionValue";
            this.meanTensionValue.Size = new System.Drawing.Size(133, 25);
            this.meanTensionValue.TabIndex = 4;
            this.meanTensionValue.Text = "({mean value})";
            // 
            // meanTensionLabel
            // 
            this.meanTensionLabel.AutoSize = true;
            this.meanTensionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.meanTensionLabel.Location = new System.Drawing.Point(16, 210);
            this.meanTensionLabel.Name = "meanTensionLabel";
            this.meanTensionLabel.Size = new System.Drawing.Size(68, 30);
            this.meanTensionLabel.TabIndex = 3;
            this.meanTensionLabel.Text = "Mean";
            // 
            // tensionValues
            // 
            this.tensionValues.AutoSize = true;
            this.tensionValues.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tensionValues.Location = new System.Drawing.Point(184, 116);
            this.tensionValues.Name = "tensionValues";
            this.tensionValues.Size = new System.Drawing.Size(217, 30);
            this.tensionValues.TabIndex = 2;
            this.tensionValues.Text = "{sistolica} / {diastolica}";
            // 
            // respiratoryVitalsPanel
            // 
            this.respiratoryVitalsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.respiratoryVitalsPanel.BackColor = System.Drawing.SystemColors.Info;
            this.respiratoryVitalsPanel.Controls.Add(this.co2Value);
            this.respiratoryVitalsPanel.Controls.Add(this.co2Label);
            this.respiratoryVitalsPanel.Controls.Add(this.respFreqValue);
            this.respiratoryVitalsPanel.Controls.Add(this.satO2Value);
            this.respiratoryVitalsPanel.Controls.Add(this.satO2Label);
            this.respiratoryVitalsPanel.Location = new System.Drawing.Point(5, 541);
            this.respiratoryVitalsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.respiratoryVitalsPanel.Name = "respiratoryVitalsPanel";
            this.respiratoryVitalsPanel.Size = new System.Drawing.Size(560, 258);
            this.respiratoryVitalsPanel.TabIndex = 2;
            // 
            // co2Value
            // 
            this.co2Value.AutoSize = true;
            this.co2Value.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.co2Value.Location = new System.Drawing.Point(419, 212);
            this.co2Value.Name = "co2Value";
            this.co2Value.Size = new System.Drawing.Size(116, 25);
            this.co2Value.TabIndex = 7;
            this.co2Value.Text = "({co2 value})";
            // 
            // co2Label
            // 
            this.co2Label.AutoSize = true;
            this.co2Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.co2Label.Location = new System.Drawing.Point(359, 208);
            this.co2Label.Name = "co2Label";
            this.co2Label.Size = new System.Drawing.Size(54, 30);
            this.co2Label.TabIndex = 6;
            this.co2Label.Text = "CO2";
            // 
            // respFreqValue
            // 
            this.respFreqValue.AutoSize = true;
            this.respFreqValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.respFreqValue.Location = new System.Drawing.Point(239, 114);
            this.respFreqValue.Name = "respFreqValue";
            this.respFreqValue.Size = new System.Drawing.Size(82, 30);
            this.respFreqValue.TabIndex = 6;
            this.respFreqValue.Text = "{f. resp}";
            // 
            // satO2Value
            // 
            this.satO2Value.AutoSize = true;
            this.satO2Value.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.satO2Value.Location = new System.Drawing.Point(90, 212);
            this.satO2Value.Name = "satO2Value";
            this.satO2Value.Size = new System.Drawing.Size(53, 25);
            this.satO2Value.TabIndex = 3;
            this.satO2Value.Text = "96 %";
            this.satO2Value.Click += new System.EventHandler(this.label6_Click);
            // 
            // satO2Label
            // 
            this.satO2Label.AutoSize = true;
            this.satO2Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.satO2Label.Location = new System.Drawing.Point(16, 208);
            this.satO2Label.Name = "satO2Label";
            this.satO2Label.Size = new System.Drawing.Size(66, 30);
            this.satO2Label.TabIndex = 2;
            this.satO2Label.Text = "SpO2";
            // 
            // otherVitalspanel
            // 
            this.otherVitalspanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otherVitalspanel.BackColor = System.Drawing.SystemColors.Info;
            this.otherVitalspanel.Controls.Add(this.temperatureValue);
            this.otherVitalspanel.Controls.Add(this.temperatureLabel);
            this.otherVitalspanel.Location = new System.Drawing.Point(5, 809);
            this.otherVitalspanel.Margin = new System.Windows.Forms.Padding(5);
            this.otherVitalspanel.Name = "otherVitalspanel";
            this.otherVitalspanel.Size = new System.Drawing.Size(560, 260);
            this.otherVitalspanel.TabIndex = 3;
            // 
            // temperatureValue
            // 
            this.temperatureValue.AutoSize = true;
            this.temperatureValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temperatureValue.Location = new System.Drawing.Point(164, 25);
            this.temperatureValue.Name = "temperatureValue";
            this.temperatureValue.Size = new System.Drawing.Size(128, 25);
            this.temperatureValue.TabIndex = 1;
            this.temperatureValue.Text = "{temperatura}";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperatureLabel.Location = new System.Drawing.Point(16, 20);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(142, 30);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "Temperature:";
            this.temperatureLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MonitoringPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.monitoringPanelLayout);
            this.Name = "MonitoringPanel";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.monitoringPanelLayout.ResumeLayout(false);
            this.leftPanelLayout.ResumeLayout(false);
            this.leftPanelLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.electroGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.rightPanelLayout.ResumeLayout(false);
            this.heartVitalsPanel.ResumeLayout(false);
            this.heartVitalsPanel.PerformLayout();
            this.tensionVitalsPanel.ResumeLayout(false);
            this.tensionVitalsPanel.PerformLayout();
            this.respiratoryVitalsPanel.ResumeLayout(false);
            this.respiratoryVitalsPanel.PerformLayout();
            this.otherVitalspanel.ResumeLayout(false);
            this.otherVitalspanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel monitoringPanelLayout;
        private TableLayoutPanel leftPanelLayout;
        private Label pacientName;
        private TableLayoutPanel rightPanelLayout;
        private Panel heartVitalsPanel;
        private Panel tensionVitalsPanel;
        private Panel respiratoryVitalsPanel;
        private Panel otherVitalspanel;
        private PictureBox electroGraph;
        private PictureBox pictureBox2;
        private Label temperatureLabel;
        private Label tensionValues;
        private Label satO2Label;
        private Label temperatureValue;
        private Label satO2Value;
        private Label cardioFreqValue;
        private Label meanTensionValue;
        private Label meanTensionLabel;
        private Label co2Value;
        private Label co2Label;
        private Label respFreqValue;
    }
}
