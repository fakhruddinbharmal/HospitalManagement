namespace Hospital
{
    partial class IPDPatientTreatmentSheetForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIPDNo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.lblDrIncharge = new System.Windows.Forms.Label();
            this.lblDiatAdvice = new System.Windows.Forms.Label();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.lblSOSDrug = new System.Windows.Forms.Label();
            this.txtSpecialAdvice = new System.Windows.Forms.TextBox();
            this.lblSpecialAdvice = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.cmbPatientName = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpTreatmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtDrIncharge = new System.Windows.Forms.TextBox();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.txtDiatAdvice = new System.Windows.Forms.TextBox();
            this.txtSOSDrug = new System.Windows.Forms.TextBox();
            this.cmbNoonTime = new System.Windows.Forms.ComboBox();
            this.lblEveningTime = new System.Windows.Forms.Label();
            this.cmbEveningTime = new System.Windows.Forms.ComboBox();
            this.lblNightTime = new System.Windows.Forms.Label();
            this.cmbNightTime = new System.Windows.Forms.ComboBox();
            this.lblMorningTime = new System.Windows.Forms.Label();
            this.cmbMorningTime = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMorningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNoonTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEveningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNightTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNoonTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIndoorNo = new System.Windows.Forms.TextBox();
            this.lblIndoorNo = new System.Windows.Forms.Label();
            this.txtIPDNo = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tspToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 664);
            this.lineAction.Size = new System.Drawing.Size(968, 2);
            this.lineAction.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(868, 671);
            this.btnCancel.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(782, 671);
            this.btnSave.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 671);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblIPDNo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.tspToolbar, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.lblDrIncharge, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDiatAdvice, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDiagnosis, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSOSDrug, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSpecialAdvice, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblSpecialAdvice, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblPatientName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPatientName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpTreatmentDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDrIncharge, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDiagnosis, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDiatAdvice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSOSDrug, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbNoonTime, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.lblEveningTime, 2, 14);
            this.tableLayoutPanel1.Controls.Add(this.cmbEveningTime, 3, 14);
            this.tableLayoutPanel1.Controls.Add(this.lblNightTime, 4, 14);
            this.tableLayoutPanel1.Controls.Add(this.cmbNightTime, 5, 14);
            this.tableLayoutPanel1.Controls.Add(this.lblMorningTime, 4, 12);
            this.tableLayoutPanel1.Controls.Add(this.cmbMorningTime, 5, 12);
            this.tableLayoutPanel1.Controls.Add(this.dgvData, 1, 16);
            this.tableLayoutPanel1.Controls.Add(this.lblNoonTime, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 612);
            this.tableLayoutPanel1.TabIndex = 109;
            // 
            // lblIPDNo
            // 
            this.lblIPDNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIPDNo.AutoSize = true;
            this.lblIPDNo.Location = new System.Drawing.Point(323, 6);
            this.lblIPDNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblIPDNo.Name = "lblIPDNo";
            this.lblIPDNo.Size = new System.Drawing.Size(64, 15);
            this.lblIPDNo.TabIndex = 2;
            this.lblIPDNo.Text = "Patient No";
            this.lblIPDNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescription
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescription, 3);
            this.txtDescription.Location = new System.Drawing.Point(117, 284);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(517, 65);
            this.txtDescription.TabIndex = 16;
            // 
            // tspToolbar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tspToolbar, 7);
            this.tspToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbDelete});
            this.tspToolbar.Location = new System.Drawing.Point(0, 390);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Size = new System.Drawing.Size(968, 25);
            this.tspToolbar.TabIndex = 25;
            this.tspToolbar.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::Hospital.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 22);
            this.tsbOpen.Text = "&Open";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Hospital.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "&Delete";
            // 
            // lblDrIncharge
            // 
            this.lblDrIncharge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrIncharge.AutoSize = true;
            this.lblDrIncharge.Location = new System.Drawing.Point(640, 6);
            this.lblDrIncharge.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDrIncharge.Name = "lblDrIncharge";
            this.lblDrIncharge.Size = new System.Drawing.Size(73, 15);
            this.lblDrIncharge.TabIndex = 4;
            this.lblDrIncharge.Text = "Dr. Incharge";
            this.lblDrIncharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiatAdvice
            // 
            this.lblDiatAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiatAdvice.AutoSize = true;
            this.lblDiatAdvice.Location = new System.Drawing.Point(3, 121);
            this.lblDiatAdvice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDiatAdvice.Name = "lblDiatAdvice";
            this.lblDiatAdvice.Size = new System.Drawing.Size(108, 15);
            this.lblDiatAdvice.TabIndex = 10;
            this.lblDiatAdvice.Text = "Diat Advice";
            this.lblDiatAdvice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Location = new System.Drawing.Point(323, 39);
            this.lblDiagnosis.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(64, 15);
            this.lblDiagnosis.TabIndex = 8;
            this.lblDiagnosis.Text = "Diagnosis";
            this.lblDiagnosis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSOSDrug
            // 
            this.lblSOSDrug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSOSDrug.AutoSize = true;
            this.lblSOSDrug.Location = new System.Drawing.Point(640, 121);
            this.lblSOSDrug.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSOSDrug.Name = "lblSOSDrug";
            this.lblSOSDrug.Size = new System.Drawing.Size(73, 15);
            this.lblSOSDrug.TabIndex = 12;
            this.lblSOSDrug.Text = "SOS Drug";
            this.lblSOSDrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSpecialAdvice
            // 
            this.txtSpecialAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtSpecialAdvice, 3);
            this.txtSpecialAdvice.Location = new System.Drawing.Point(117, 203);
            this.txtSpecialAdvice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtSpecialAdvice.MaxLength = 200;
            this.txtSpecialAdvice.Multiline = true;
            this.txtSpecialAdvice.Name = "txtSpecialAdvice";
            this.txtSpecialAdvice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpecialAdvice.Size = new System.Drawing.Size(517, 69);
            this.txtSpecialAdvice.TabIndex = 15;
            // 
            // lblSpecialAdvice
            // 
            this.lblSpecialAdvice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpecialAdvice.Location = new System.Drawing.Point(3, 203);
            this.lblSpecialAdvice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblSpecialAdvice.Name = "lblSpecialAdvice";
            this.lblSpecialAdvice.Size = new System.Drawing.Size(108, 19);
            this.lblSpecialAdvice.TabIndex = 14;
            this.lblSpecialAdvice.Text = "Special Advice";
            this.lblSpecialAdvice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPatientName
            // 
            this.lblPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(3, 6);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(108, 15);
            this.lblPatientName.TabIndex = 0;
            this.lblPatientName.Text = "Patient";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPatientName
            // 
            this.cmbPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPatientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientName.FormattingEnabled = true;
            this.cmbPatientName.Items.AddRange(new object[] {
            "Company1",
            "Company2",
            "Company3"});
            this.cmbPatientName.Location = new System.Drawing.Point(117, 3);
            this.cmbPatientName.Name = "cmbPatientName";
            this.cmbPatientName.Size = new System.Drawing.Size(200, 23);
            this.cmbPatientName.TabIndex = 1;
            this.cmbPatientName.SelectedIndexChanged += new System.EventHandler(this.cmbPatientName_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 39);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpTreatmentDate
            // 
            this.dtpTreatmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTreatmentDate.CustomFormat = "dd/MM/yyyy";
            this.dtpTreatmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTreatmentDate.Location = new System.Drawing.Point(117, 39);
            this.dtpTreatmentDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpTreatmentDate.Name = "dtpTreatmentDate";
            this.dtpTreatmentDate.Size = new System.Drawing.Size(200, 21);
            this.dtpTreatmentDate.TabIndex = 7;
            // 
            // txtDrIncharge
            // 
            this.txtDrIncharge.Enabled = false;
            this.txtDrIncharge.Location = new System.Drawing.Point(719, 6);
            this.txtDrIncharge.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDrIncharge.Name = "txtDrIncharge";
            this.txtDrIncharge.Size = new System.Drawing.Size(200, 21);
            this.txtDrIncharge.TabIndex = 5;
            // 
            // txtDiagnosis
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDiagnosis, 4);
            this.txtDiagnosis.Enabled = false;
            this.txtDiagnosis.Location = new System.Drawing.Point(393, 39);
            this.txtDiagnosis.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDiagnosis.MaxLength = 1000;
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnosis.Size = new System.Drawing.Size(563, 70);
            this.txtDiagnosis.TabIndex = 9;
            // 
            // txtDiatAdvice
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDiatAdvice, 3);
            this.txtDiatAdvice.Location = new System.Drawing.Point(117, 121);
            this.txtDiatAdvice.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtDiatAdvice.MaxLength = 1000;
            this.txtDiatAdvice.Multiline = true;
            this.txtDiatAdvice.Name = "txtDiatAdvice";
            this.txtDiatAdvice.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiatAdvice.Size = new System.Drawing.Size(517, 70);
            this.txtDiatAdvice.TabIndex = 11;
            // 
            // txtSOSDrug
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtSOSDrug, 2);
            this.txtSOSDrug.Location = new System.Drawing.Point(719, 118);
            this.txtSOSDrug.MaxLength = 100;
            this.txtSOSDrug.Multiline = true;
            this.txtSOSDrug.Name = "txtSOSDrug";
            this.txtSOSDrug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSOSDrug.Size = new System.Drawing.Size(237, 73);
            this.txtSOSDrug.TabIndex = 13;
            // 
            // cmbNoonTime
            // 
            this.cmbNoonTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNoonTime.FormattingEnabled = true;
            this.cmbNoonTime.Items.AddRange(new object[] {
            "01 AM",
            "02 AM",
            "03 AM",
            "04 AM",
            "05 AM",
            "06 AM",
            "07 AM",
            "08 AM",
            "09 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "01 PM",
            "02 PM",
            "03 PM",
            "04 PM",
            "05 PM",
            "06 PM",
            "07 PM",
            "08 PM",
            "09 PM",
            "10 PM",
            "11 PM",
            "12 AM"});
            this.cmbNoonTime.Location = new System.Drawing.Point(117, 361);
            this.cmbNoonTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbNoonTime.MaxDropDownItems = 100;
            this.cmbNoonTime.Name = "cmbNoonTime";
            this.cmbNoonTime.Size = new System.Drawing.Size(72, 23);
            this.cmbNoonTime.TabIndex = 20;
            // 
            // lblEveningTime
            // 
            this.lblEveningTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEveningTime.AutoSize = true;
            this.lblEveningTime.Location = new System.Drawing.Point(323, 361);
            this.lblEveningTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblEveningTime.Name = "lblEveningTime";
            this.lblEveningTime.Size = new System.Drawing.Size(64, 15);
            this.lblEveningTime.TabIndex = 21;
            this.lblEveningTime.Text = "Eve. Time";
            this.lblEveningTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEveningTime
            // 
            this.cmbEveningTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEveningTime.FormattingEnabled = true;
            this.cmbEveningTime.Items.AddRange(new object[] {
            "01 AM",
            "02 AM",
            "03 AM",
            "04 AM",
            "05 AM",
            "06 AM",
            "07 AM",
            "08 AM",
            "09 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "01 PM",
            "02 PM",
            "03 PM",
            "04 PM",
            "05 PM",
            "06 PM",
            "07 PM",
            "08 PM",
            "09 PM",
            "10 PM",
            "11 PM",
            "12 AM"});
            this.cmbEveningTime.Location = new System.Drawing.Point(393, 361);
            this.cmbEveningTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbEveningTime.MaxDropDownItems = 100;
            this.cmbEveningTime.Name = "cmbEveningTime";
            this.cmbEveningTime.Size = new System.Drawing.Size(74, 23);
            this.cmbEveningTime.TabIndex = 22;
            // 
            // lblNightTime
            // 
            this.lblNightTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNightTime.AutoSize = true;
            this.lblNightTime.Location = new System.Drawing.Point(640, 361);
            this.lblNightTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNightTime.Name = "lblNightTime";
            this.lblNightTime.Size = new System.Drawing.Size(73, 15);
            this.lblNightTime.TabIndex = 23;
            this.lblNightTime.Text = "Night Time";
            this.lblNightTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNightTime
            // 
            this.cmbNightTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNightTime.FormattingEnabled = true;
            this.cmbNightTime.Items.AddRange(new object[] {
            "01 AM",
            "02 AM",
            "03 AM",
            "04 AM",
            "05 AM",
            "06 AM",
            "07 AM",
            "08 AM",
            "09 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "01 PM",
            "02 PM",
            "03 PM",
            "04 PM",
            "05 PM",
            "06 PM",
            "07 PM",
            "08 PM",
            "09 PM",
            "10 PM",
            "11 PM",
            "12 AM"});
            this.cmbNightTime.Location = new System.Drawing.Point(719, 361);
            this.cmbNightTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbNightTime.MaxDropDownItems = 100;
            this.cmbNightTime.Name = "cmbNightTime";
            this.cmbNightTime.Size = new System.Drawing.Size(69, 23);
            this.cmbNightTime.TabIndex = 24;
            // 
            // lblMorningTime
            // 
            this.lblMorningTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMorningTime.AutoSize = true;
            this.lblMorningTime.Location = new System.Drawing.Point(640, 284);
            this.lblMorningTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMorningTime.Name = "lblMorningTime";
            this.lblMorningTime.Size = new System.Drawing.Size(73, 15);
            this.lblMorningTime.TabIndex = 17;
            this.lblMorningTime.Text = "Mor. Time";
            this.lblMorningTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMorningTime
            // 
            this.cmbMorningTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMorningTime.FormattingEnabled = true;
            this.cmbMorningTime.Items.AddRange(new object[] {
            "01 AM",
            "02 AM",
            "03 AM",
            "04 AM",
            "05 AM",
            "06 AM",
            "07 AM",
            "08 AM",
            "09 AM",
            "10 AM",
            "11 AM",
            "12 PM",
            "01 PM",
            "02 PM",
            "03 PM",
            "04 PM",
            "05 PM",
            "06 PM",
            "07 PM",
            "08 PM",
            "09 PM",
            "10 PM",
            "11 PM",
            "12 AM"});
            this.cmbMorningTime.Location = new System.Drawing.Point(719, 281);
            this.cmbMorningTime.MaxDropDownItems = 100;
            this.cmbMorningTime.Name = "cmbMorningTime";
            this.cmbMorningTime.Size = new System.Drawing.Size(69, 23);
            this.cmbMorningTime.TabIndex = 18;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSrNo,
            this.clmDescription,
            this.clmMorningTime,
            this.clmNoonTime,
            this.clmEveningTime,
            this.clmNightTime,
            this.clmFill});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvData, 7);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Location = new System.Drawing.Point(3, 418);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(953, 200);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 47;
            this.dgvData.TabStop = false;
            // 
            // clmSrNo
            // 
            this.clmSrNo.HeaderText = "Sr.No";
            this.clmSrNo.Name = "clmSrNo";
            this.clmSrNo.ReadOnly = true;
            this.clmSrNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Description";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            this.clmDescription.Width = 400;
            // 
            // clmMorningTime
            // 
            this.clmMorningTime.HeaderText = "Morning Time";
            this.clmMorningTime.Name = "clmMorningTime";
            this.clmMorningTime.ReadOnly = true;
            this.clmMorningTime.Width = 200;
            // 
            // clmNoonTime
            // 
            this.clmNoonTime.HeaderText = "Noon Time";
            this.clmNoonTime.Name = "clmNoonTime";
            this.clmNoonTime.ReadOnly = true;
            // 
            // clmEveningTime
            // 
            this.clmEveningTime.HeaderText = "Evening Time";
            this.clmEveningTime.Name = "clmEveningTime";
            this.clmEveningTime.ReadOnly = true;
            this.clmEveningTime.Width = 200;
            // 
            // clmNightTime
            // 
            this.clmNightTime.HeaderText = "Night Time";
            this.clmNightTime.Name = "clmNightTime";
            this.clmNightTime.ReadOnly = true;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            this.clmFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblNoonTime
            // 
            this.lblNoonTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoonTime.Location = new System.Drawing.Point(3, 361);
            this.lblNoonTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNoonTime.Name = "lblNoonTime";
            this.lblNoonTime.Size = new System.Drawing.Size(108, 23);
            this.lblNoonTime.TabIndex = 19;
            this.lblNoonTime.Text = "Noon Time";
            this.lblNoonTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIndoorNo);
            this.panel1.Controls.Add(this.lblIndoorNo);
            this.panel1.Controls.Add(this.txtIPDNo);
            this.panel1.Location = new System.Drawing.Point(393, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 27);
            this.panel1.TabIndex = 48;
            // 
            // txtIndoorNo
            // 
            this.txtIndoorNo.Enabled = false;
            this.txtIndoorNo.Location = new System.Drawing.Point(154, 2);
            this.txtIndoorNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtIndoorNo.MaxLength = 50;
            this.txtIndoorNo.Name = "txtIndoorNo";
            this.txtIndoorNo.Size = new System.Drawing.Size(84, 21);
            this.txtIndoorNo.TabIndex = 5;
            // 
            // lblIndoorNo
            // 
            this.lblIndoorNo.AutoSize = true;
            this.lblIndoorNo.Location = new System.Drawing.Point(84, 2);
            this.lblIndoorNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblIndoorNo.Name = "lblIndoorNo";
            this.lblIndoorNo.Size = new System.Drawing.Size(64, 15);
            this.lblIndoorNo.TabIndex = 4;
            this.lblIndoorNo.Text = "Indoor No.";
            this.lblIndoorNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIPDNo
            // 
            this.txtIPDNo.Enabled = false;
            this.txtIPDNo.Location = new System.Drawing.Point(3, 2);
            this.txtIPDNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtIPDNo.Name = "txtIPDNo";
            this.txtIPDNo.Size = new System.Drawing.Size(75, 21);
            this.txtIPDNo.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Location = new System.Drawing.Point(-1, 335);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 18);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IPDPatientTreatmentSheetForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 703);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IPDPatientTreatmentSheetForm";
            this.Text = "IPDPatientTreatmentSheetForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.lblDescription, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDrIncharge;
        private System.Windows.Forms.Label lblDiatAdvice;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblSOSDrug;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.ComboBox cmbPatientName;
        private System.Windows.Forms.Label lblIPDNo;
        private System.Windows.Forms.TextBox txtIPDNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpTreatmentDate;
        private System.Windows.Forms.TextBox txtDrIncharge;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TextBox txtDiatAdvice;
        private System.Windows.Forms.TextBox txtSOSDrug;
        private System.Windows.Forms.TextBox txtSpecialAdvice;
        private System.Windows.Forms.Label lblSpecialAdvice;
        private System.Windows.Forms.Label lblMorningTime;
        private System.Windows.Forms.ComboBox cmbMorningTime;
        private System.Windows.Forms.Label lblNoonTime;
        private System.Windows.Forms.ComboBox cmbNoonTime;
        private System.Windows.Forms.Label lblEveningTime;
        private System.Windows.Forms.ComboBox cmbEveningTime;
        private System.Windows.Forms.Label lblNightTime;
        private System.Windows.Forms.ComboBox cmbNightTime;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMorningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNoonTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEveningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNightTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIndoorNo;
        private System.Windows.Forms.Label lblIndoorNo;
    }
}