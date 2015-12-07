namespace Hospital.Controls
{
    partial class IPDPatientTreatmentSheetListControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tsbPatientMedicin = new System.Windows.Forms.ToolStripButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsp2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslDateFrom = new System.Windows.Forms.ToolStripLabel();
            this.tstDateFrom = new System.Windows.Forms.ToolStripTextBox();
            this.tslDateTo = new System.Windows.Forms.ToolStripLabel();
            this.tstDateTo = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.clmPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiatAdvice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSOSDrug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSpecialAdvice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIPDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPatientGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatmentSheetGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrintBill = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tspToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 140F;
            this.dataGridViewImageColumn1.HeaderText = "View Treatment Sheet Report";
            this.dataGridViewImageColumn1.Image = global::Hospital.Properties.Resources.PrintIcon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // tsbPatientMedicin
            // 
            this.tsbPatientMedicin.Image = global::Hospital.Properties.Resources.Attachment;
            this.tsbPatientMedicin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPatientMedicin.Name = "tsbPatientMedicin";
            this.tsbPatientMedicin.Size = new System.Drawing.Size(110, 22);
            this.tsbPatientMedicin.Text = "&Patient Medicin";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeight = 24;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPatientName,
            this.clmTreatmentDate,
            this.clmDiatAdvice,
            this.clmSOSDrug,
            this.clmSpecialAdvice,
            this.clmIPDNo,
            this.clmPatientGuid,
            this.clmTreatmentSheetGuid,
            this.clmPrintBill,
            this.clmFill});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 25);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1301, 681);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 21;
            // 
            // tspToolbar
            // 
            this.tspToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.toolStripSeparator2,
            this.tsbOpen,
            this.toolStripSeparator1,
            this.tslSearch,
            this.tstSearch,
            this.tsp2,
            this.tslDateFrom,
            this.tstDateFrom,
            this.tslDateTo,
            this.tstDateTo,
            this.tsbSearch,
            this.tsbClose});
            this.tspToolbar.Location = new System.Drawing.Point(0, 0);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.tspToolbar.Size = new System.Drawing.Size(1301, 25);
            this.tspToolbar.TabIndex = 20;
            this.tspToolbar.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::Hospital.Properties.Resources.Add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "&Add";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::Hospital.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 22);
            this.tsbOpen.Text = "&Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslSearch
            // 
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(51, 22);
            this.tslSearch.Text = "&Search : ";
            // 
            // tstSearch
            // 
            this.tstSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.Size = new System.Drawing.Size(100, 25);
            // 
            // tsp2
            // 
            this.tsp2.Name = "tsp2";
            this.tsp2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslDateFrom
            // 
            this.tslDateFrom.Name = "tslDateFrom";
            this.tslDateFrom.Size = new System.Drawing.Size(68, 22);
            this.tslDateFrom.Text = "Date From :";
            // 
            // tstDateFrom
            // 
            this.tstDateFrom.Name = "tstDateFrom";
            this.tstDateFrom.Size = new System.Drawing.Size(120, 25);
            // 
            // tslDateTo
            // 
            this.tslDateTo.Name = "tslDateTo";
            this.tslDateTo.Size = new System.Drawing.Size(54, 22);
            this.tslDateTo.Text = "Date To :";
            // 
            // tstDateTo
            // 
            this.tstDateTo.Name = "tstDateTo";
            this.tstDateTo.Size = new System.Drawing.Size(120, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = global::Hospital.Properties.Resources.Find;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.MergeIndex = 0;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(42, 22);
            this.tsbSearch.Text = "&Go";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::Hospital.Properties.Resources.Cancel;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(56, 22);
            this.tsbClose.Text = "&Close";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Checked = false;
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(356, 3);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.ShowCheckBox = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpDateFrom.TabIndex = 22;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Checked = false;
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(532, 2);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.ShowCheckBox = true;
            this.dtpDateTo.Size = new System.Drawing.Size(120, 21);
            this.dtpDateTo.TabIndex = 23;
            // 
            // clmPatientName
            // 
            this.clmPatientName.HeaderText = "Patient Name";
            this.clmPatientName.Name = "clmPatientName";
            this.clmPatientName.ReadOnly = true;
            this.clmPatientName.Width = 200;
            // 
            // clmTreatmentDate
            // 
            this.clmTreatmentDate.HeaderText = "Treatment Date";
            this.clmTreatmentDate.Name = "clmTreatmentDate";
            this.clmTreatmentDate.ReadOnly = true;
            this.clmTreatmentDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmDiatAdvice
            // 
            this.clmDiatAdvice.FillWeight = 120F;
            this.clmDiatAdvice.HeaderText = "Diat Advice";
            this.clmDiatAdvice.Name = "clmDiatAdvice";
            this.clmDiatAdvice.ReadOnly = true;
            this.clmDiatAdvice.Width = 200;
            // 
            // clmSOSDrug
            // 
            this.clmSOSDrug.HeaderText = "SOS Drug";
            this.clmSOSDrug.Name = "clmSOSDrug";
            this.clmSOSDrug.ReadOnly = true;
            this.clmSOSDrug.Width = 200;
            // 
            // clmSpecialAdvice
            // 
            this.clmSpecialAdvice.HeaderText = "Special Advice";
            this.clmSpecialAdvice.Name = "clmSpecialAdvice";
            this.clmSpecialAdvice.ReadOnly = true;
            this.clmSpecialAdvice.Width = 300;
            // 
            // clmIPDNo
            // 
            this.clmIPDNo.HeaderText = "Patient No";
            this.clmIPDNo.Name = "clmIPDNo";
            this.clmIPDNo.ReadOnly = true;
            this.clmIPDNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmPatientGuid
            // 
            this.clmPatientGuid.HeaderText = "PatientGuid";
            this.clmPatientGuid.Name = "clmPatientGuid";
            this.clmPatientGuid.ReadOnly = true;
            this.clmPatientGuid.Visible = false;
            // 
            // clmTreatmentSheetGuid
            // 
            this.clmTreatmentSheetGuid.HeaderText = "TreatmentSheetGuid";
            this.clmTreatmentSheetGuid.Name = "clmTreatmentSheetGuid";
            this.clmTreatmentSheetGuid.ReadOnly = true;
            this.clmTreatmentSheetGuid.Visible = false;
            // 
            // clmPrintBill
            // 
            this.clmPrintBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmPrintBill.FillWeight = 140F;
            this.clmPrintBill.HeaderText = "View Treatment Sheet Report";
            this.clmPrintBill.Image = global::Hospital.Properties.Resources.PrintIcon;
            this.clmPrintBill.Name = "clmPrintBill";
            this.clmPrintBill.ReadOnly = true;
            this.clmPrintBill.Width = 173;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            // 
            // IPDPatientTreatmentSheetListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tspToolbar);
            this.Name = "IPDPatientTreatmentSheetListControl";
            this.Size = new System.Drawing.Size(1301, 706);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbPatientMedicin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripSeparator tsp2;
        private System.Windows.Forms.ToolStripLabel tslDateFrom;
        private System.Windows.Forms.ToolStripTextBox tstDateFrom;
        private System.Windows.Forms.ToolStripLabel tslDateTo;
        private System.Windows.Forms.ToolStripTextBox tstDateTo;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiatAdvice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSOSDrug;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSpecialAdvice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIPDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPatientGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatmentSheetGuid;
        private System.Windows.Forms.DataGridViewImageColumn clmPrintBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
    }
}
