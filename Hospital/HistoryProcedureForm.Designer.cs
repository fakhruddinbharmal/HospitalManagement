namespace Hospital
{
    partial class HistoryProcedureForm
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
            this.tspToolbar = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvHistoryData = new System.Windows.Forms.DataGridView();
            this.clmPriscription = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChiefComplain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProblemSince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAssociateComplain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAssociateComplainDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHistoryOfProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyHistoryDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBP = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.lblRR = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblRBS = new System.Windows.Forms.Label();
            this.lblECG = new System.Windows.Forms.Label();
            this.lblWt = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.txtHR = new System.Windows.Forms.TextBox();
            this.txtRR = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtRBS = new System.Windows.Forms.TextBox();
            this.txtECG = new System.Windows.Forms.TextBox();
            this.txtWt = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtMLC = new System.Windows.Forms.TextBox();
            this.lblMLCNo = new System.Windows.Forms.Label();
            this.lblFollowUp = new System.Windows.Forms.Label();
            this.dtpFollowUp = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChiefComplain = new System.Windows.Forms.Label();
            this.lblProblemSince = new System.Windows.Forms.Label();
            this.lblAssociateComplain = new System.Windows.Forms.Label();
            this.lblAssociateComplainDuration = new System.Windows.Forms.Label();
            this.lblHistoryOfProblem = new System.Windows.Forms.Label();
            this.lblFamilyHistory = new System.Windows.Forms.Label();
            this.lblFamilyHistoryDuration = new System.Windows.Forms.Label();
            this.txtProblemSince = new System.Windows.Forms.TextBox();
            this.txtAssociateComplainDuration = new System.Windows.Forms.TextBox();
            this.txtFamilyHistory = new System.Windows.Forms.TextBox();
            this.txtFamilyHistoryDuration = new System.Windows.Forms.TextBox();
            this.btnAddNewChiefComplain = new System.Windows.Forms.Button();
            this.btnAddNewAssociateComplain = new System.Windows.Forms.Button();
            this.btnAddNewHistory = new System.Windows.Forms.Button();
            this.cmbChiefComplain = new System.Windows.Forms.CheckedListBox();
            this.cmbAssociateComplain = new System.Windows.Forms.CheckedListBox();
            this.cmbHistoryOfProblem = new System.Windows.Forms.CheckedListBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimeAMPM = new System.Windows.Forms.TextBox();
            this.lblTimeHour = new System.Windows.Forms.Label();
            this.txtTimeMinute = new System.Windows.Forms.TextBox();
            this.txtTimeHour = new System.Windows.Forms.TextBox();
            this.lblTimeMinute = new System.Windows.Forms.Label();
            this.lblTimeAMPM = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpHistoryDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpVitals = new System.Windows.Forms.GroupBox();
            this.tspToolbar.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpVitals.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 629);
            this.lineAction.Size = new System.Drawing.Size(1009, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(917, 638);
            this.btnCancel.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(831, 638);
            this.btnSave.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 638);
            this.btnDelete.TabIndex = 5;
            // 
            // tspToolbar
            // 
            this.tspToolbar.AutoSize = false;
            this.tspToolbar.Dock = System.Windows.Forms.DockStyle.None;
            this.tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen});
            this.tspToolbar.Location = new System.Drawing.Point(0, 456);
            this.tspToolbar.Name = "tspToolbar";
            this.tspToolbar.Size = new System.Drawing.Size(1009, 32);
            this.tspToolbar.TabIndex = 2;
            this.tspToolbar.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::Hospital.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(56, 29);
            this.tsbOpen.Text = "&Open";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dgvHistoryData, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 491);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1060, 118);
            this.tableLayoutPanel2.TabIndex = 110;
            // 
            // dgvHistoryData
            // 
            this.dgvHistoryData.AllowUserToAddRows = false;
            this.dgvHistoryData.AllowUserToDeleteRows = false;
            this.dgvHistoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPriscription,
            this.clmDate,
            this.clmChiefComplain,
            this.clmProblemSince,
            this.clmAssociateComplain,
            this.clmAssociateComplainDuration,
            this.clmHistoryOfProblem,
            this.clmFamilyHistory,
            this.clmFamilyHistoryDuration,
            this.clmGuid,
            this.clmId});
            this.dgvHistoryData.Location = new System.Drawing.Point(3, 3);
            this.dgvHistoryData.Name = "dgvHistoryData";
            this.dgvHistoryData.ReadOnly = true;
            this.dgvHistoryData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoryData.Size = new System.Drawing.Size(1000, 112);
            this.dgvHistoryData.TabIndex = 0;
            this.dgvHistoryData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistoryData_CellContentClick);
            // 
            // clmPriscription
            // 
            this.clmPriscription.HeaderText = "Priscription";
            this.clmPriscription.Image = global::Hospital.Properties.Resources.PrintIcon;
            this.clmPriscription.Name = "clmPriscription";
            this.clmPriscription.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmChiefComplain
            // 
            this.clmChiefComplain.HeaderText = "Chief Complain";
            this.clmChiefComplain.Name = "clmChiefComplain";
            this.clmChiefComplain.ReadOnly = true;
            this.clmChiefComplain.Width = 150;
            // 
            // clmProblemSince
            // 
            this.clmProblemSince.HeaderText = "Problem Since";
            this.clmProblemSince.Name = "clmProblemSince";
            this.clmProblemSince.ReadOnly = true;
            // 
            // clmAssociateComplain
            // 
            this.clmAssociateComplain.HeaderText = "Associate Complain";
            this.clmAssociateComplain.Name = "clmAssociateComplain";
            this.clmAssociateComplain.ReadOnly = true;
            this.clmAssociateComplain.Width = 150;
            // 
            // clmAssociateComplainDuration
            // 
            this.clmAssociateComplainDuration.HeaderText = "Associate Complain Duration";
            this.clmAssociateComplainDuration.Name = "clmAssociateComplainDuration";
            this.clmAssociateComplainDuration.ReadOnly = true;
            this.clmAssociateComplainDuration.Width = 150;
            // 
            // clmHistoryOfProblem
            // 
            this.clmHistoryOfProblem.HeaderText = "History Of Problem";
            this.clmHistoryOfProblem.Name = "clmHistoryOfProblem";
            this.clmHistoryOfProblem.ReadOnly = true;
            this.clmHistoryOfProblem.Width = 150;
            // 
            // clmFamilyHistory
            // 
            this.clmFamilyHistory.HeaderText = "Family History";
            this.clmFamilyHistory.Name = "clmFamilyHistory";
            this.clmFamilyHistory.ReadOnly = true;
            this.clmFamilyHistory.Width = 150;
            // 
            // clmFamilyHistoryDuration
            // 
            this.clmFamilyHistoryDuration.HeaderText = "Family History Duration";
            this.clmFamilyHistoryDuration.Name = "clmFamilyHistoryDuration";
            this.clmFamilyHistoryDuration.ReadOnly = true;
            this.clmFamilyHistoryDuration.Width = 150;
            // 
            // clmGuid
            // 
            this.clmGuid.HeaderText = "Guid";
            this.clmGuid.Name = "clmGuid";
            this.clmGuid.ReadOnly = true;
            this.clmGuid.Visible = false;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Location = new System.Drawing.Point(6, 20);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(27, 15);
            this.lblBP.TabIndex = 0;
            this.lblBP.Text = "B.P.";
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(6, 49);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(25, 15);
            this.lblHR.TabIndex = 2;
            this.lblHR.Text = "HR";
            // 
            // lblRR
            // 
            this.lblRR.AutoSize = true;
            this.lblRR.Location = new System.Drawing.Point(6, 76);
            this.lblRR.Name = "lblRR";
            this.lblRR.Size = new System.Drawing.Size(25, 15);
            this.lblRR.TabIndex = 4;
            this.lblRR.Text = "RR";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(6, 103);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(38, 15);
            this.lblTemp.TabIndex = 6;
            this.lblTemp.Text = "Temp";
            // 
            // lblRBS
            // 
            this.lblRBS.AutoSize = true;
            this.lblRBS.Location = new System.Drawing.Point(6, 133);
            this.lblRBS.Name = "lblRBS";
            this.lblRBS.Size = new System.Drawing.Size(32, 15);
            this.lblRBS.TabIndex = 8;
            this.lblRBS.Text = "RBS";
            // 
            // lblECG
            // 
            this.lblECG.AutoSize = true;
            this.lblECG.Location = new System.Drawing.Point(6, 157);
            this.lblECG.Name = "lblECG";
            this.lblECG.Size = new System.Drawing.Size(33, 15);
            this.lblECG.TabIndex = 10;
            this.lblECG.Text = "ECG";
            // 
            // lblWt
            // 
            this.lblWt.AutoSize = true;
            this.lblWt.Location = new System.Drawing.Point(6, 188);
            this.lblWt.Name = "lblWt";
            this.lblWt.Size = new System.Drawing.Size(21, 15);
            this.lblWt.TabIndex = 12;
            this.lblWt.Text = "Wt";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(6, 216);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(37, 15);
            this.lblOther.TabIndex = 14;
            this.lblOther.Text = "Other";
            // 
            // txtBP
            // 
            this.txtBP.Location = new System.Drawing.Point(68, 20);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(100, 21);
            this.txtBP.TabIndex = 1;
            // 
            // txtHR
            // 
            this.txtHR.Location = new System.Drawing.Point(68, 49);
            this.txtHR.Name = "txtHR";
            this.txtHR.Size = new System.Drawing.Size(100, 21);
            this.txtHR.TabIndex = 3;
            // 
            // txtRR
            // 
            this.txtRR.Location = new System.Drawing.Point(68, 76);
            this.txtRR.Name = "txtRR";
            this.txtRR.Size = new System.Drawing.Size(100, 21);
            this.txtRR.TabIndex = 5;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(68, 103);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 21);
            this.txtTemp.TabIndex = 7;
            // 
            // txtRBS
            // 
            this.txtRBS.Location = new System.Drawing.Point(68, 130);
            this.txtRBS.Name = "txtRBS";
            this.txtRBS.Size = new System.Drawing.Size(100, 21);
            this.txtRBS.TabIndex = 9;
            // 
            // txtECG
            // 
            this.txtECG.Location = new System.Drawing.Point(68, 157);
            this.txtECG.Name = "txtECG";
            this.txtECG.Size = new System.Drawing.Size(100, 21);
            this.txtECG.TabIndex = 11;
            // 
            // txtWt
            // 
            this.txtWt.Location = new System.Drawing.Point(68, 188);
            this.txtWt.Name = "txtWt";
            this.txtWt.Size = new System.Drawing.Size(100, 21);
            this.txtWt.TabIndex = 13;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(68, 216);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(100, 21);
            this.txtOther.TabIndex = 15;
            // 
            // txtMLC
            // 
            this.txtMLC.Location = new System.Drawing.Point(833, 315);
            this.txtMLC.Name = "txtMLC";
            this.txtMLC.Size = new System.Drawing.Size(100, 21);
            this.txtMLC.TabIndex = 1;
            // 
            // lblMLCNo
            // 
            this.lblMLCNo.AutoSize = true;
            this.lblMLCNo.Location = new System.Drawing.Point(771, 318);
            this.lblMLCNo.Name = "lblMLCNo";
            this.lblMLCNo.Size = new System.Drawing.Size(54, 15);
            this.lblMLCNo.TabIndex = 0;
            this.lblMLCNo.Text = "MLC No.";
            // 
            // lblFollowUp
            // 
            this.lblFollowUp.AutoSize = true;
            this.lblFollowUp.Location = new System.Drawing.Point(3, 4);
            this.lblFollowUp.Name = "lblFollowUp";
            this.lblFollowUp.Size = new System.Drawing.Size(91, 15);
            this.lblFollowUp.TabIndex = 0;
            this.lblFollowUp.Text = "Follow Up Date";
            // 
            // dtpFollowUp
            // 
            this.dtpFollowUp.Checked = false;
            this.dtpFollowUp.CustomFormat = "dd/MM/yyyy";
            this.dtpFollowUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFollowUp.Location = new System.Drawing.Point(100, 3);
            this.dtpFollowUp.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpFollowUp.Name = "dtpFollowUp";
            this.dtpFollowUp.ShowCheckBox = true;
            this.dtpFollowUp.Size = new System.Drawing.Size(142, 21);
            this.dtpFollowUp.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblChiefComplain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProblemSince, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAssociateComplain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAssociateComplainDuration, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHistoryOfProblem, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFamilyHistory, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFamilyHistoryDuration, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtProblemSince, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAssociateComplainDuration, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFamilyHistory, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFamilyHistoryDuration, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNewChiefComplain, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNewAssociateComplain, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddNewHistory, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbChiefComplain, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAssociateComplain, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbHistoryOfProblem, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 395);
            this.tableLayoutPanel1.TabIndex = 132;
            // 
            // lblChiefComplain
            // 
            this.lblChiefComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChiefComplain.AutoSize = true;
            this.lblChiefComplain.Location = new System.Drawing.Point(3, 6);
            this.lblChiefComplain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblChiefComplain.Name = "lblChiefComplain";
            this.lblChiefComplain.Size = new System.Drawing.Size(180, 15);
            this.lblChiefComplain.TabIndex = 0;
            this.lblChiefComplain.Text = "Chief Complain";
            this.lblChiefComplain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProblemSince
            // 
            this.lblProblemSince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProblemSince.AutoSize = true;
            this.lblProblemSince.Location = new System.Drawing.Point(3, 64);
            this.lblProblemSince.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblProblemSince.Name = "lblProblemSince";
            this.lblProblemSince.Size = new System.Drawing.Size(180, 15);
            this.lblProblemSince.TabIndex = 3;
            this.lblProblemSince.Text = "Problem Since";
            this.lblProblemSince.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssociateComplain
            // 
            this.lblAssociateComplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssociateComplain.AutoSize = true;
            this.lblAssociateComplain.Location = new System.Drawing.Point(3, 97);
            this.lblAssociateComplain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAssociateComplain.Name = "lblAssociateComplain";
            this.lblAssociateComplain.Size = new System.Drawing.Size(180, 15);
            this.lblAssociateComplain.TabIndex = 5;
            this.lblAssociateComplain.Text = "Associate Complain";
            this.lblAssociateComplain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAssociateComplainDuration
            // 
            this.lblAssociateComplainDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssociateComplainDuration.Location = new System.Drawing.Point(3, 155);
            this.lblAssociateComplainDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAssociateComplainDuration.Name = "lblAssociateComplainDuration";
            this.lblAssociateComplainDuration.Size = new System.Drawing.Size(180, 17);
            this.lblAssociateComplainDuration.TabIndex = 8;
            this.lblAssociateComplainDuration.Text = "Associate Complain Duration";
            this.lblAssociateComplainDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHistoryOfProblem
            // 
            this.lblHistoryOfProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHistoryOfProblem.AutoSize = true;
            this.lblHistoryOfProblem.Location = new System.Drawing.Point(3, 188);
            this.lblHistoryOfProblem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHistoryOfProblem.Name = "lblHistoryOfProblem";
            this.lblHistoryOfProblem.Size = new System.Drawing.Size(180, 15);
            this.lblHistoryOfProblem.TabIndex = 10;
            this.lblHistoryOfProblem.Text = "History Of Problem";
            this.lblHistoryOfProblem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFamilyHistory
            // 
            this.lblFamilyHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFamilyHistory.AutoSize = true;
            this.lblFamilyHistory.Location = new System.Drawing.Point(3, 246);
            this.lblFamilyHistory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFamilyHistory.Name = "lblFamilyHistory";
            this.lblFamilyHistory.Size = new System.Drawing.Size(180, 15);
            this.lblFamilyHistory.TabIndex = 13;
            this.lblFamilyHistory.Text = "Family History";
            this.lblFamilyHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFamilyHistoryDuration
            // 
            this.lblFamilyHistoryDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFamilyHistoryDuration.AutoSize = true;
            this.lblFamilyHistoryDuration.Location = new System.Drawing.Point(3, 326);
            this.lblFamilyHistoryDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblFamilyHistoryDuration.Name = "lblFamilyHistoryDuration";
            this.lblFamilyHistoryDuration.Size = new System.Drawing.Size(180, 15);
            this.lblFamilyHistoryDuration.TabIndex = 15;
            this.lblFamilyHistoryDuration.Text = "Family History Duration ";
            this.lblFamilyHistoryDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProblemSince
            // 
            this.txtProblemSince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProblemSince.Location = new System.Drawing.Point(189, 64);
            this.txtProblemSince.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtProblemSince.MaxLength = 25;
            this.txtProblemSince.Name = "txtProblemSince";
            this.txtProblemSince.Size = new System.Drawing.Size(298, 21);
            this.txtProblemSince.TabIndex = 4;
            // 
            // txtAssociateComplainDuration
            // 
            this.txtAssociateComplainDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssociateComplainDuration.Location = new System.Drawing.Point(189, 155);
            this.txtAssociateComplainDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtAssociateComplainDuration.MaxLength = 25;
            this.txtAssociateComplainDuration.Name = "txtAssociateComplainDuration";
            this.txtAssociateComplainDuration.Size = new System.Drawing.Size(298, 21);
            this.txtAssociateComplainDuration.TabIndex = 9;
            // 
            // txtFamilyHistory
            // 
            this.txtFamilyHistory.Location = new System.Drawing.Point(189, 243);
            this.txtFamilyHistory.Multiline = true;
            this.txtFamilyHistory.Name = "txtFamilyHistory";
            this.txtFamilyHistory.Size = new System.Drawing.Size(250, 74);
            this.txtFamilyHistory.TabIndex = 14;
            // 
            // txtFamilyHistoryDuration
            // 
            this.txtFamilyHistoryDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFamilyHistoryDuration.Location = new System.Drawing.Point(189, 326);
            this.txtFamilyHistoryDuration.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtFamilyHistoryDuration.MaxLength = 25;
            this.txtFamilyHistoryDuration.Name = "txtFamilyHistoryDuration";
            this.txtFamilyHistoryDuration.Size = new System.Drawing.Size(298, 21);
            this.txtFamilyHistoryDuration.TabIndex = 16;
            // 
            // btnAddNewChiefComplain
            // 
            this.btnAddNewChiefComplain.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewChiefComplain.Image = global::Hospital.Properties.Resources.Add;
            this.btnAddNewChiefComplain.Location = new System.Drawing.Point(493, 3);
            this.btnAddNewChiefComplain.Name = "btnAddNewChiefComplain";
            this.btnAddNewChiefComplain.Size = new System.Drawing.Size(91, 26);
            this.btnAddNewChiefComplain.TabIndex = 2;
            this.btnAddNewChiefComplain.Text = "&Add ";
            this.btnAddNewChiefComplain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewChiefComplain.UseVisualStyleBackColor = true;
            // 
            // btnAddNewAssociateComplain
            // 
            this.btnAddNewAssociateComplain.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewAssociateComplain.Image = global::Hospital.Properties.Resources.Add;
            this.btnAddNewAssociateComplain.Location = new System.Drawing.Point(493, 94);
            this.btnAddNewAssociateComplain.Name = "btnAddNewAssociateComplain";
            this.btnAddNewAssociateComplain.Size = new System.Drawing.Size(91, 26);
            this.btnAddNewAssociateComplain.TabIndex = 7;
            this.btnAddNewAssociateComplain.Text = "&Add";
            this.btnAddNewAssociateComplain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewAssociateComplain.UseVisualStyleBackColor = true;
            // 
            // btnAddNewHistory
            // 
            this.btnAddNewHistory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddNewHistory.Image = global::Hospital.Properties.Resources.Add;
            this.btnAddNewHistory.Location = new System.Drawing.Point(493, 185);
            this.btnAddNewHistory.Name = "btnAddNewHistory";
            this.btnAddNewHistory.Size = new System.Drawing.Size(91, 26);
            this.btnAddNewHistory.TabIndex = 12;
            this.btnAddNewHistory.Text = "&Add ";
            this.btnAddNewHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewHistory.UseVisualStyleBackColor = true;
            // 
            // cmbChiefComplain
            // 
            this.cmbChiefComplain.CheckOnClick = true;
            this.cmbChiefComplain.FormattingEnabled = true;
            this.cmbChiefComplain.Location = new System.Drawing.Point(189, 3);
            this.cmbChiefComplain.Name = "cmbChiefComplain";
            this.cmbChiefComplain.Size = new System.Drawing.Size(250, 52);
            this.cmbChiefComplain.Sorted = true;
            this.cmbChiefComplain.TabIndex = 1;
            // 
            // cmbAssociateComplain
            // 
            this.cmbAssociateComplain.CheckOnClick = true;
            this.cmbAssociateComplain.FormattingEnabled = true;
            this.cmbAssociateComplain.Location = new System.Drawing.Point(189, 94);
            this.cmbAssociateComplain.Name = "cmbAssociateComplain";
            this.cmbAssociateComplain.Size = new System.Drawing.Size(250, 52);
            this.cmbAssociateComplain.Sorted = true;
            this.cmbAssociateComplain.TabIndex = 6;
            // 
            // cmbHistoryOfProblem
            // 
            this.cmbHistoryOfProblem.CheckOnClick = true;
            this.cmbHistoryOfProblem.FormattingEnabled = true;
            this.cmbHistoryOfProblem.Location = new System.Drawing.Point(189, 185);
            this.cmbHistoryOfProblem.Name = "cmbHistoryOfProblem";
            this.cmbHistoryOfProblem.Size = new System.Drawing.Size(250, 52);
            this.cmbHistoryOfProblem.Sorted = true;
            this.cmbHistoryOfProblem.TabIndex = 11;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 359);
            this.lblTime.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(180, 15);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimeAMPM);
            this.panel1.Controls.Add(this.lblTimeHour);
            this.panel1.Controls.Add(this.txtTimeMinute);
            this.panel1.Controls.Add(this.txtTimeHour);
            this.panel1.Controls.Add(this.lblTimeMinute);
            this.panel1.Controls.Add(this.lblTimeAMPM);
            this.panel1.Location = new System.Drawing.Point(189, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 27);
            this.panel1.TabIndex = 18;
            // 
            // txtTimeAMPM
            // 
            this.txtTimeAMPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeAMPM.Location = new System.Drawing.Point(206, 2);
            this.txtTimeAMPM.Name = "txtTimeAMPM";
            this.txtTimeAMPM.Size = new System.Drawing.Size(44, 21);
            this.txtTimeAMPM.TabIndex = 4;
            // 
            // lblTimeHour
            // 
            this.lblTimeHour.Location = new System.Drawing.Point(3, 4);
            this.lblTimeHour.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblTimeHour.Name = "lblTimeHour";
            this.lblTimeHour.Size = new System.Drawing.Size(34, 15);
            this.lblTimeHour.TabIndex = 0;
            this.lblTimeHour.Text = "Hour";
            // 
            // txtTimeMinute
            // 
            this.txtTimeMinute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeMinute.Location = new System.Drawing.Point(111, 1);
            this.txtTimeMinute.Name = "txtTimeMinute";
            this.txtTimeMinute.Size = new System.Drawing.Size(31, 21);
            this.txtTimeMinute.TabIndex = 2;
            // 
            // txtTimeHour
            // 
            this.txtTimeHour.Location = new System.Drawing.Point(37, 1);
            this.txtTimeHour.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtTimeHour.MaxLength = 2;
            this.txtTimeHour.Name = "txtTimeHour";
            this.txtTimeHour.Size = new System.Drawing.Size(27, 21);
            this.txtTimeHour.TabIndex = 1;
            // 
            // lblTimeMinute
            // 
            this.lblTimeMinute.Location = new System.Drawing.Point(70, 4);
            this.lblTimeMinute.Name = "lblTimeMinute";
            this.lblTimeMinute.Size = new System.Drawing.Size(46, 17);
            this.lblTimeMinute.TabIndex = 137;
            this.lblTimeMinute.Text = "Minute";
            // 
            // lblTimeAMPM
            // 
            this.lblTimeAMPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeAMPM.AutoSize = true;
            this.lblTimeAMPM.Location = new System.Drawing.Point(156, 4);
            this.lblTimeAMPM.Name = "lblTimeAMPM";
            this.lblTimeAMPM.Size = new System.Drawing.Size(43, 15);
            this.lblTimeAMPM.TabIndex = 3;
            this.lblTimeAMPM.Text = "AM/PM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.dtpHistoryDate);
            this.panel2.Location = new System.Drawing.Point(493, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 26);
            this.panel2.TabIndex = 142;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 3);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpHistoryDate
            // 
            this.dtpHistoryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpHistoryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHistoryDate.Location = new System.Drawing.Point(42, 3);
            this.dtpHistoryDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpHistoryDate.Name = "dtpHistoryDate";
            this.dtpHistoryDate.Size = new System.Drawing.Size(142, 21);
            this.dtpHistoryDate.TabIndex = 1;
            this.dtpHistoryDate.ValueChanged += new System.EventHandler(this.dtpHistoryDate_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblFollowUp);
            this.panel3.Controls.Add(this.dtpFollowUp);
            this.panel3.Location = new System.Drawing.Point(493, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 27);
            this.panel3.TabIndex = 143;
            // 
            // grpVitals
            // 
            this.grpVitals.Controls.Add(this.txtBP);
            this.grpVitals.Controls.Add(this.lblBP);
            this.grpVitals.Controls.Add(this.lblHR);
            this.grpVitals.Controls.Add(this.lblRR);
            this.grpVitals.Controls.Add(this.lblTemp);
            this.grpVitals.Controls.Add(this.txtHR);
            this.grpVitals.Controls.Add(this.txtRR);
            this.grpVitals.Controls.Add(this.txtTemp);
            this.grpVitals.Controls.Add(this.txtRBS);
            this.grpVitals.Controls.Add(this.lblRBS);
            this.grpVitals.Controls.Add(this.txtECG);
            this.grpVitals.Controls.Add(this.lblECG);
            this.grpVitals.Controls.Add(this.txtOther);
            this.grpVitals.Controls.Add(this.lblOther);
            this.grpVitals.Controls.Add(this.txtWt);
            this.grpVitals.Controls.Add(this.lblWt);
            this.grpVitals.Location = new System.Drawing.Point(765, 51);
            this.grpVitals.Name = "grpVitals";
            this.grpVitals.Size = new System.Drawing.Size(227, 244);
            this.grpVitals.TabIndex = 133;
            this.grpVitals.TabStop = false;
            this.grpVitals.Text = "Vitals";
            // 
            // HistoryProcedureForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 724);
            this.Controls.Add(this.grpVitals);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tspToolbar);
            this.Controls.Add(this.lblMLCNo);
            this.Controls.Add(this.txtMLC);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "HistoryProcedureForm";
            this.Text = "HistoryProcedureForm";
            this.Controls.SetChildIndex(this.tableLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.txtMLC, 0);
            this.Controls.SetChildIndex(this.lblMLCNo, 0);
            this.Controls.SetChildIndex(this.tspToolbar, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.grpVitals, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tspToolbar.ResumeLayout(false);
            this.tspToolbar.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpVitals.ResumeLayout(false);
            this.grpVitals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvHistoryData;
        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label lblRR;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblRBS;
        private System.Windows.Forms.Label lblECG;
        private System.Windows.Forms.Label lblWt;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.TextBox txtHR;
        private System.Windows.Forms.TextBox txtRR;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtRBS;
        private System.Windows.Forms.TextBox txtECG;
        private System.Windows.Forms.TextBox txtWt;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtMLC;
        private System.Windows.Forms.Label lblMLCNo;
        private System.Windows.Forms.Label lblFollowUp;
        private System.Windows.Forms.DateTimePicker dtpFollowUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblChiefComplain;
        private System.Windows.Forms.Label lblProblemSince;
        private System.Windows.Forms.Label lblAssociateComplain;
        private System.Windows.Forms.Label lblAssociateComplainDuration;
        private System.Windows.Forms.Label lblHistoryOfProblem;
        private System.Windows.Forms.Label lblFamilyHistory;
        private System.Windows.Forms.Label lblFamilyHistoryDuration;
        private System.Windows.Forms.TextBox txtProblemSince;
        private System.Windows.Forms.TextBox txtAssociateComplainDuration;
        private System.Windows.Forms.TextBox txtFamilyHistory;
        private System.Windows.Forms.TextBox txtFamilyHistoryDuration;
        private System.Windows.Forms.DateTimePicker dtpHistoryDate;
        private System.Windows.Forms.Button btnAddNewChiefComplain;
        private System.Windows.Forms.Button btnAddNewAssociateComplain;
        private System.Windows.Forms.Button btnAddNewHistory;
        private System.Windows.Forms.CheckedListBox cmbChiefComplain;
        private System.Windows.Forms.CheckedListBox cmbAssociateComplain;
        private System.Windows.Forms.CheckedListBox cmbHistoryOfProblem;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimeAMPM;
        private System.Windows.Forms.Label lblTimeHour;
        private System.Windows.Forms.TextBox txtTimeMinute;
        private System.Windows.Forms.TextBox txtTimeHour;
        private System.Windows.Forms.Label lblTimeMinute;
        private System.Windows.Forms.Label lblTimeAMPM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpVitals;
        private System.Windows.Forms.DataGridViewImageColumn clmPriscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChiefComplain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProblemSince;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssociateComplain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssociateComplainDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHistoryOfProblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyHistoryDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
    }
}