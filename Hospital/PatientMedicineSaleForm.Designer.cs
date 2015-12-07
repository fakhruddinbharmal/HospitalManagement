namespace Hospital
{
    partial class PatientMedicineSaleForm
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
            this.txtOtherPatientName = new System.Windows.Forms.TextBox();
            this.lblOtherPatientName = new System.Windows.Forms.Label();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.cmbPatientType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tblBillTotal = new System.Windows.Forms.TableLayoutPanel();
            this.lblBalanceToCollect = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblBalanceToCollectValue = new System.Windows.Forms.Label();
            this.lblTotalAmountValue = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.clmSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPatientType = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPatient = new System.Windows.Forms.Label();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tspToolbar.SuspendLayout();
            this.tblBillTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 506);
            this.lineAction.Size = new System.Drawing.Size(1000, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(902, 519);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(817, 519);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 519);
            this.btnDelete.TabIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.txtOtherPatientName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOtherPatientName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpBillDate, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBillDate, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPatient, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPatientType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.tspToolbar, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.tblBillTotal, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.dgvData, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblPatientType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbItem, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblItem, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbCompany, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCompany, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCategory, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.nupAmount, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblAmount, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNotes, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblNotes, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPatient, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(988, 446);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtOtherPatientName
            // 
            this.txtOtherPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOtherPatientName.Location = new System.Drawing.Point(155, 41);
            this.txtOtherPatientName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtOtherPatientName.Name = "txtOtherPatientName";
            this.txtOtherPatientName.Size = new System.Drawing.Size(241, 21);
            this.txtOtherPatientName.TabIndex = 7;
            this.txtOtherPatientName.Visible = false;
            // 
            // lblOtherPatientName
            // 
            this.lblOtherPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherPatientName.AutoSize = true;
            this.lblOtherPatientName.Location = new System.Drawing.Point(3, 41);
            this.lblOtherPatientName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOtherPatientName.Name = "lblOtherPatientName";
            this.lblOtherPatientName.Size = new System.Drawing.Size(146, 15);
            this.lblOtherPatientName.TabIndex = 6;
            this.lblOtherPatientName.Text = "Other Patient Name";
            this.lblOtherPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOtherPatientName.Visible = false;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(808, 6);
            this.dtpBillDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(155, 21);
            this.dtpBillDate.TabIndex = 5;
            // 
            // lblBillDate
            // 
            this.lblBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Location = new System.Drawing.Point(742, 6);
            this.lblBillDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(60, 15);
            this.lblBillDate.TabIndex = 4;
            this.lblBillDate.Text = "Bill Date";
            this.lblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPatient
            // 
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(536, 3);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(200, 23);
            this.cmbPatient.TabIndex = 3;
            // 
            // cmbPatientType
            // 
            this.cmbPatientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatientType.DropDownWidth = 200;
            this.cmbPatientType.FormattingEnabled = true;
            this.cmbPatientType.Items.AddRange(new object[] {
            "I.P.D",
            "O.P.D",
            "Other"});
            this.cmbPatientType.Location = new System.Drawing.Point(155, 6);
            this.cmbPatientType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbPatientType.Name = "cmbPatientType";
            this.cmbPatientType.Size = new System.Drawing.Size(98, 23);
            this.cmbPatientType.Sorted = true;
            this.cmbPatientType.TabIndex = 1;
            this.cmbPatientType.SelectedIndexChanged += new System.EventHandler(this.cmbPatientType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 8);
            this.label1.TabIndex = 30;
            this.label1.Text = "Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tspToolbar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tspToolbar, 7);
            this.tspToolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbDelete});
            this.tspToolbar.Location = new System.Drawing.Point(0, 186);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Size = new System.Drawing.Size(988, 25);
            this.tspToolbar.TabIndex = 21;
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
            // tblBillTotal
            // 
            this.tblBillTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblBillTotal.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblBillTotal.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tblBillTotal, 7);
            this.tblBillTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBillTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBillTotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBillTotal.Controls.Add(this.lblBalanceToCollect, 1, 1);
            this.tblBillTotal.Controls.Add(this.lblTotalAmount, 1, 0);
            this.tblBillTotal.Controls.Add(this.lblBalanceToCollectValue, 2, 1);
            this.tblBillTotal.Controls.Add(this.lblTotalAmountValue, 2, 0);
            this.tblBillTotal.Location = new System.Drawing.Point(3, 386);
            this.tblBillTotal.Name = "tblBillTotal";
            this.tblBillTotal.RowCount = 2;
            this.tblBillTotal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBillTotal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblBillTotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBillTotal.Size = new System.Drawing.Size(964, 59);
            this.tblBillTotal.TabIndex = 28;
            // 
            // lblBalanceToCollect
            // 
            this.lblBalanceToCollect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBalanceToCollect.AutoSize = true;
            this.lblBalanceToCollect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceToCollect.Location = new System.Drawing.Point(658, 36);
            this.lblBalanceToCollect.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBalanceToCollect.Name = "lblBalanceToCollect";
            this.lblBalanceToCollect.Size = new System.Drawing.Size(61, 15);
            this.lblBalanceToCollect.TabIndex = 4;
            this.lblBalanceToCollect.Text = "To Collect";
            this.lblBalanceToCollect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(642, 7);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(77, 15);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "Total Amount";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBalanceToCollectValue
            // 
            this.lblBalanceToCollectValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalanceToCollectValue.AutoSize = true;
            this.lblBalanceToCollectValue.Location = new System.Drawing.Point(919, 35);
            this.lblBalanceToCollectValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBalanceToCollectValue.Name = "lblBalanceToCollectValue";
            this.lblBalanceToCollectValue.Size = new System.Drawing.Size(41, 15);
            this.lblBalanceToCollectValue.TabIndex = 5;
            this.lblBalanceToCollectValue.Text = "label1";
            this.lblBalanceToCollectValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmountValue
            // 
            this.lblTotalAmountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmountValue.AutoSize = true;
            this.lblTotalAmountValue.Location = new System.Drawing.Point(919, 7);
            this.lblTotalAmountValue.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTotalAmountValue.Name = "lblTotalAmountValue";
            this.lblTotalAmountValue.Size = new System.Drawing.Size(41, 15);
            this.lblTotalAmountValue.TabIndex = 1;
            this.lblTotalAmountValue.Text = "label1";
            this.lblTotalAmountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
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
            this.clmMedicine,
            this.clmQuantity,
            this.clmAmount,
            this.clmNotes,
            this.clmFill});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvData, 7);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Location = new System.Drawing.Point(3, 214);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(973, 166);
            this.dgvData.StandardTab = true;
            this.dgvData.TabIndex = 22;
            this.dgvData.TabStop = false;
            // 
            // clmSrNo
            // 
            this.clmSrNo.HeaderText = "Sr.No";
            this.clmSrNo.Name = "clmSrNo";
            this.clmSrNo.ReadOnly = true;
            this.clmSrNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmMedicine
            // 
            this.clmMedicine.HeaderText = "Medicine Name";
            this.clmMedicine.Name = "clmMedicine";
            this.clmMedicine.ReadOnly = true;
            this.clmMedicine.Width = 400;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 200;
            // 
            // clmAmount
            // 
            this.clmAmount.HeaderText = "Amount";
            this.clmAmount.Name = "clmAmount";
            this.clmAmount.ReadOnly = true;
            // 
            // clmNotes
            // 
            this.clmNotes.HeaderText = "Notes";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.ReadOnly = true;
            this.clmNotes.Width = 200;
            // 
            // clmFill
            // 
            this.clmFill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFill.HeaderText = "";
            this.clmFill.Name = "clmFill";
            this.clmFill.ReadOnly = true;
            this.clmFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblPatientType
            // 
            this.lblPatientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientType.Location = new System.Drawing.Point(3, 6);
            this.lblPatientType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPatientType.Name = "lblPatientType";
            this.lblPatientType.Size = new System.Drawing.Size(146, 23);
            this.lblPatientType.TabIndex = 0;
            this.lblPatientType.Text = "Patient Type";
            this.lblPatientType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(155, 76);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(241, 23);
            this.cmbItem.Sorted = true;
            this.cmbItem.TabIndex = 13;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(3, 76);
            this.lblItem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(146, 15);
            this.lblItem.TabIndex = 12;
            this.lblItem.Text = "Item";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(808, 41);
            this.cmbCompany.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(174, 23);
            this.cmbCompany.Sorted = true;
            this.cmbCompany.TabIndex = 11;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(742, 41);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(60, 15);
            this.lblCompany.TabIndex = 10;
            this.lblCompany.Text = "Company";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(536, 41);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            this.cmbCategory.Sorted = true;
            this.cmbCategory.TabIndex = 9;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.Location = new System.Drawing.Point(402, 41);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(128, 20);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nupAmount
            // 
            this.nupAmount.Location = new System.Drawing.Point(808, 76);
            this.nupAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.nupAmount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nupAmount.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.nupAmount.Name = "nupAmount";
            this.nupAmount.Size = new System.Drawing.Size(159, 21);
            this.nupAmount.TabIndex = 18;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(742, 76);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(60, 15);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(402, 76);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(128, 15);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtNotes, 3);
            this.txtNotes.Location = new System.Drawing.Point(155, 111);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtNotes.MaxLength = 500;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(581, 69);
            this.txtNotes.TabIndex = 20;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(3, 111);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(146, 15);
            this.lblNotes.TabIndex = 19;
            this.lblNotes.Text = "Notes";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAvailableQuantity);
            this.panel1.Controls.Add(this.nupQuantity);
            this.panel1.Location = new System.Drawing.Point(536, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 29);
            this.panel1.TabIndex = 16;
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Location = new System.Drawing.Point(70, 7);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(41, 15);
            this.lblAvailableQuantity.TabIndex = 16;
            this.lblAvailableQuantity.Text = "label2";
            this.lblAvailableQuantity.Visible = false;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupQuantity.Location = new System.Drawing.Point(0, 0);
            this.nupQuantity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.nupQuantity.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nupQuantity.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(48, 21);
            this.nupQuantity.TabIndex = 0;
            this.nupQuantity.Leave += new System.EventHandler(this.nupQuantity_Leave);
            // 
            // lblPatient
            // 
            this.lblPatient.Location = new System.Drawing.Point(402, 6);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(128, 23);
            this.lblPatient.TabIndex = 2;
            this.lblPatient.Text = "Patient";
            this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Image = global::Hospital.Properties.Resources.PrintIcon;
            this.btnGenerateBill.Location = new System.Drawing.Point(654, 519);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(130, 24);
            this.btnGenerateBill.TabIndex = 3;
            this.btnGenerateBill.Text = "View Bill Report";
            this.btnGenerateBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // PatientMedicineSaleForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 547);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PatientMedicineSaleForm";
            this.Text = "PatientMedicineSale";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.btnGenerateBill, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.tblBillTotal.ResumeLayout(false);
            this.tblBillTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.TableLayoutPanel tblBillTotal;
        private System.Windows.Forms.Label lblBalanceToCollect;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblBalanceToCollectValue;
        private System.Windows.Forms.Label lblTotalAmountValue;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nupAmount;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.TextBox txtOtherPatientName;
        private System.Windows.Forms.Label lblOtherPatientName;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatientType;
        private System.Windows.Forms.Label lblPatientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAvailableQuantity;

    }
}