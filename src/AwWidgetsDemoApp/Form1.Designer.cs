using AwWidgetsDemoApp.mocking;
using AwWidgetsControls;
using AwWidgetsCore.models;

namespace AwWidgetsDemoApp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.f_resp = new System.Windows.Forms.Label();
            this.co2 = new System.Windows.Forms.Label();
            this.co2_value = new System.Windows.Forms.Label();
            this.spO2 = new System.Windows.Forms.Label();
            this.spO2_value = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.temp_value = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.f_card = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new AwPanel<String, SpecificGazeData>(5000);
            this.name = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.spacer = new System.Windows.Forms.Label();
            this.mean = new System.Windows.Forms.Label();
            this.mean_val = new System.Windows.Forms.Label();
            this.sistolica = new System.Windows.Forms.Label();
            this.distolica = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 452);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.f_resp);
            this.panel1.Controls.Add(this.co2);
            this.panel1.Controls.Add(this.co2_value);
            this.panel1.Controls.Add(this.spO2);
            this.panel1.Controls.Add(this.spO2_value);
            this.panel1.Controls.Add(this.temp);
            this.panel1.Controls.Add(this.temp_value);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(564, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 196);
            this.panel1.TabIndex = 3;
            // 
            // f_resp
            // 
            this.f_resp.AutoSize = true;
            this.f_resp.ForeColor = System.Drawing.Color.Cyan;
            this.f_resp.Location = new System.Drawing.Point(90, 36);
            this.f_resp.Name = "f_resp";
            this.f_resp.Size = new System.Drawing.Size(67, 25);
            this.f_resp.TabIndex = 7;
            this.f_resp.Text = "default";
            // 
            // co2
            // 
            this.co2.AutoSize = true;
            this.co2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.co2.Location = new System.Drawing.Point(10, 93);
            this.co2.Name = "co2";
            this.co2.Size = new System.Drawing.Size(51, 25);
            this.co2.TabIndex = 6;
            this.co2.Text = "CO2:";
            // 
            // co2_value
            // 
            this.co2_value.AutoSize = true;
            this.co2_value.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.co2_value.Location = new System.Drawing.Point(74, 93);
            this.co2_value.Name = "co2_value";
            this.co2_value.Size = new System.Drawing.Size(67, 25);
            this.co2_value.TabIndex = 5;
            this.co2_value.Text = "default";
            // 
            // spO2
            // 
            this.spO2.AutoSize = true;
            this.spO2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.spO2.Location = new System.Drawing.Point(10, 127);
            this.spO2.Name = "spO2";
            this.spO2.Size = new System.Drawing.Size(61, 25);
            this.spO2.TabIndex = 4;
            this.spO2.Text = "SpO2:";
            // 
            // spO2_value
            // 
            this.spO2_value.AutoSize = true;
            this.spO2_value.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.spO2_value.Location = new System.Drawing.Point(74, 127);
            this.spO2_value.Name = "spO2_value";
            this.spO2_value.Size = new System.Drawing.Size(67, 25);
            this.spO2_value.TabIndex = 3;
            this.spO2_value.Text = "default";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.temp.Location = new System.Drawing.Point(10, 164);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(114, 25);
            this.temp.TabIndex = 2;
            this.temp.Text = "Temperature:";
            // 
            // temp_value
            // 
            this.temp_value.AutoSize = true;
            this.temp_value.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.temp_value.Location = new System.Drawing.Point(132, 164);
            this.temp_value.Name = "temp_value";
            this.temp_value.Size = new System.Drawing.Size(67, 25);
            this.temp_value.TabIndex = 1;
            this.temp_value.Text = "default";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 196);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AwWidgetsDemoApp.Properties.Resources.resp;
            this.pictureBox3.Location = new System.Drawing.Point(40, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(456, 75);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.f_card);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(564, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 44);
            this.panel3.TabIndex = 5;
            // 
            // f_card
            // 
            this.f_card.AutoSize = true;
            this.f_card.ForeColor = System.Drawing.Color.Red;
            this.f_card.Location = new System.Drawing.Point(90, 7);
            this.f_card.Name = "f_card";
            this.f_card.Size = new System.Drawing.Size(67, 25);
            this.f_card.TabIndex = 1;
            this.f_card.Text = "default";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 194);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AwWidgetsDemoApp.Properties.Resources.electro1;
            this.pictureBox2.Location = new System.Drawing.Point(236, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 183);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AwWidgetsDemoApp.Properties.Resources.electro1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 183);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.name);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(555, 44);
            this.panel5.TabIndex = 7;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.name.Location = new System.Drawing.Point(245, 7);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(67, 25);
            this.name.TabIndex = 0;
            this.name.Text = "default";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Controls.Add(this.spacer);
            this.panel6.Controls.Add(this.mean);
            this.panel6.Controls.Add(this.mean_val);
            this.panel6.Controls.Add(this.sistolica);
            this.panel6.Controls.Add(this.distolica);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(564, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 194);
            this.panel6.TabIndex = 8;
            // 
            // spacer
            // 
            this.spacer.AutoSize = true;
            this.spacer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.spacer.Location = new System.Drawing.Point(115, 85);
            this.spacer.Name = "spacer";
            this.spacer.Size = new System.Drawing.Size(19, 25);
            this.spacer.TabIndex = 11;
            this.spacer.Text = "/";
            // 
            // mean
            // 
            this.mean.AutoSize = true;
            this.mean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mean.Location = new System.Drawing.Point(10, 161);
            this.mean.Name = "mean";
            this.mean.Size = new System.Drawing.Size(60, 25);
            this.mean.TabIndex = 10;
            this.mean.Text = "Mean:";
            // 
            // mean_val
            // 
            this.mean_val.AutoSize = true;
            this.mean_val.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mean_val.Location = new System.Drawing.Point(74, 161);
            this.mean_val.Name = "mean_val";
            this.mean_val.Size = new System.Drawing.Size(67, 25);
            this.mean_val.TabIndex = 9;
            this.mean_val.Text = "default";
            // 
            // sistolica
            // 
            this.sistolica.AutoSize = true;
            this.sistolica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sistolica.Location = new System.Drawing.Point(57, 85);
            this.sistolica.Name = "sistolica";
            this.sistolica.Size = new System.Drawing.Size(67, 25);
            this.sistolica.TabIndex = 8;
            this.sistolica.Text = "default";
            // 
            // distolica
            // 
            this.distolica.AutoSize = true;
            this.distolica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.distolica.Location = new System.Drawing.Point(140, 85);
            this.distolica.Name = "distolica";
            this.distolica.Size = new System.Drawing.Size(67, 25);
            this.distolica.TabIndex = 7;
            this.distolica.Text = "default";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AppDataProvider appDataProvider;
        private GazeDataProvider gazeDataProvider;
        private TableLayoutPanel tableLayoutPanel1;
        private Label name;
        private Label f_card;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private AwPanel<String,SpecificGazeData> panel5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label temp;
        private Label temp_value;
        private Label co2;
        private Label co2_value;
        private Label spO2;
        private Label spO2_value;
        private Label f_resp;
        private Panel panel6;
        private Label sistolica;
        private Label distolica;
        private Label mean;
        private Label mean_val;
        private Label spacer;
    }
}