namespace DVLD.Licenses.Controls
{
    partial class ctrlDriverLicenses
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.cmsInterenationalLicenseHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InternationalLicenseHistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpLocalLicenses = new System.Windows.Forms.TabPage();
            this.dgvLocalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.cmsLocalLicenseHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLocalLicensesRecords = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInternationalLicenses = new System.Windows.Forms.TabPage();
            this.lblInternationalLicensesRecords = new System.Windows.Forms.Label();
            this.dgvInternationalLicensesHistory = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcDriverLicenses.SuspendLayout();
            this.cmsInterenationalLicenseHistory.SuspendLayout();
            this.tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).BeginInit();
            this.cmsLocalLicenseHistory.SuspendLayout();
            this.tbInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.ContextMenuStrip = this.cmsInterenationalLicenseHistory;
            this.tcDriverLicenses.Controls.Add(this.tpLocalLicenses);
            this.tcDriverLicenses.Controls.Add(this.tbInternationalLicenses);
            this.tcDriverLicenses.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcDriverLicenses.Location = new System.Drawing.Point(25, 35);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(1181, 288);
            this.tcDriverLicenses.TabIndex = 132;
            // 
            // cmsInterenationalLicenseHistory
            // 
            this.cmsInterenationalLicenseHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InternationalLicenseHistorytoolStripMenuItem});
            this.cmsInterenationalLicenseHistory.Name = "cmsLocalLicenseHistory";
            this.cmsInterenationalLicenseHistory.Size = new System.Drawing.Size(178, 28);
            // 
            // InternationalLicenseHistorytoolStripMenuItem
            // 
            this.InternationalLicenseHistorytoolStripMenuItem.Image = global::DVLD.Properties.Resources.dwfegr2222;
            this.InternationalLicenseHistorytoolStripMenuItem.Name = "InternationalLicenseHistorytoolStripMenuItem";
            this.InternationalLicenseHistorytoolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.InternationalLicenseHistorytoolStripMenuItem.Text = "Show License Info";
            this.InternationalLicenseHistorytoolStripMenuItem.Click += new System.EventHandler(this.InternationalLicenseHistorytoolStripMenuItem_Click_1);
            // 
            // tpLocalLicenses
            // 
            this.tpLocalLicenses.Controls.Add(this.dgvLocalLicensesHistory);
            this.tpLocalLicenses.Controls.Add(this.lblLocalLicensesRecords);
            this.tpLocalLicenses.Controls.Add(this.label5);
            this.tpLocalLicenses.Controls.Add(this.label1);
            this.tpLocalLicenses.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLocalLicenses.Location = new System.Drawing.Point(4, 32);
            this.tpLocalLicenses.Name = "tpLocalLicenses";
            this.tpLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicenses.Size = new System.Drawing.Size(1173, 252);
            this.tpLocalLicenses.TabIndex = 0;
            this.tpLocalLicenses.Text = "Local";
            this.tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicensesHistory
            // 
            this.dgvLocalLicensesHistory.AllowUserToAddRows = false;
            this.dgvLocalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicensesHistory.ContextMenuStrip = this.cmsLocalLicenseHistory;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalLicensesHistory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalLicensesHistory.Location = new System.Drawing.Point(15, 45);
            this.dgvLocalLicensesHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLocalLicensesHistory.MultiSelect = false;
            this.dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            this.dgvLocalLicensesHistory.ReadOnly = true;
            this.dgvLocalLicensesHistory.RowHeadersWidth = 51;
            this.dgvLocalLicensesHistory.RowTemplate.Height = 24;
            this.dgvLocalLicensesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicensesHistory.Size = new System.Drawing.Size(1136, 174);
            this.dgvLocalLicensesHistory.TabIndex = 136;
            // 
            // cmsLocalLicenseHistory
            // 
            this.cmsLocalLicenseHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.cmsLocalLicenseHistory.Name = "cmsLocalLicenseHistory";
            this.cmsLocalLicenseHistory.Size = new System.Drawing.Size(178, 28);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD.Properties.Resources.dwfegr2222;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click_1);
            // 
            // lblLocalLicensesRecords
            // 
            this.lblLocalLicensesRecords.AutoSize = true;
            this.lblLocalLicensesRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalLicensesRecords.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicensesRecords.Location = new System.Drawing.Point(107, 230);
            this.lblLocalLicensesRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
            this.lblLocalLicensesRecords.Size = new System.Drawing.Size(28, 28);
            this.lblLocalLicensesRecords.TabIndex = 138;
            this.lblLocalLicensesRecords.Text = "??";
            this.lblLocalLicensesRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 137;
            this.label5.Text = "# Records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 135;
            this.label1.Text = "Local Licenses History:";
            // 
            // tbInternationalLicenses
            // 
            this.tbInternationalLicenses.Controls.Add(this.lblInternationalLicensesRecords);
            this.tbInternationalLicenses.Controls.Add(this.dgvInternationalLicensesHistory);
            this.tbInternationalLicenses.Controls.Add(this.label2);
            this.tbInternationalLicenses.Controls.Add(this.label3);
            this.tbInternationalLicenses.Location = new System.Drawing.Point(4, 32);
            this.tbInternationalLicenses.Name = "tbInternationalLicenses";
            this.tbInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tbInternationalLicenses.Size = new System.Drawing.Size(1173, 252);
            this.tbInternationalLicenses.TabIndex = 1;
            this.tbInternationalLicenses.Text = "International";
            this.tbInternationalLicenses.UseVisualStyleBackColor = true;
            // 
            // lblInternationalLicensesRecords
            // 
            this.lblInternationalLicensesRecords.AutoSize = true;
            this.lblInternationalLicensesRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblInternationalLicensesRecords.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicensesRecords.Location = new System.Drawing.Point(110, 228);
            this.lblInternationalLicensesRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            this.lblInternationalLicensesRecords.Size = new System.Drawing.Size(28, 28);
            this.lblInternationalLicensesRecords.TabIndex = 135;
            this.lblInternationalLicensesRecords.Text = "??";
            this.lblInternationalLicensesRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvInternationalLicensesHistory
            // 
            this.dgvInternationalLicensesHistory.AllowUserToAddRows = false;
            this.dgvInternationalLicensesHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalLicensesHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalLicensesHistory.Location = new System.Drawing.Point(21, 42);
            this.dgvInternationalLicensesHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInternationalLicensesHistory.MultiSelect = false;
            this.dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            this.dgvInternationalLicensesHistory.ReadOnly = true;
            this.dgvInternationalLicensesHistory.RowHeadersWidth = 51;
            this.dgvInternationalLicensesHistory.RowTemplate.Height = 24;
            this.dgvInternationalLicensesHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicensesHistory.Size = new System.Drawing.Size(1133, 174);
            this.dgvInternationalLicensesHistory.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 134;
            this.label2.Text = "# Records:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 37);
            this.label3.TabIndex = 139;
            this.label3.Text = "International Licenses History:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcDriverLicenses);
            this.groupBox1.Font = new System.Drawing.Font("IBM Plex Sans Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 334);
            this.groupBox1.TabIndex = 133;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(1232, 346);
            this.tcDriverLicenses.ResumeLayout(false);
            this.cmsInterenationalLicenseHistory.ResumeLayout(false);
            this.tpLocalLicenses.ResumeLayout(false);
            this.tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicensesHistory)).EndInit();
            this.cmsLocalLicenseHistory.ResumeLayout(false);
            this.tbInternationalLicenses.ResumeLayout(false);
            this.tbInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesHistory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocalLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbInternationalLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.DataGridView dgvInternationalLicensesHistory;
        private System.Windows.Forms.Label lblLocalLicensesRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInternationalLicensesRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInterenationalLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicenseHistorytoolStripMenuItem;
    }
}
