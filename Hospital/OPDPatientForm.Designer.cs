namespace Hospital
{
    partial class OPDPatientForm
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
            this.txtOPDContactNo = new System.Windows.Forms.TextBox();
            this.lblOPDPhoneNo = new System.Windows.Forms.Label();
            this.txtOPDCity = new System.Windows.Forms.TextBox();
            this.lblOPDCityTown = new System.Windows.Forms.Label();
            this.nupOPDAge = new System.Windows.Forms.NumericUpDown();
            this.lblOPDAge = new System.Windows.Forms.Label();
            this.cmbOPDGender = new System.Windows.Forms.ComboBox();
            this.lblOPDMiddleName = new System.Windows.Forms.Label();
            this.lblOPDGender = new System.Windows.Forms.Label();
            this.lblOPDAddress = new System.Windows.Forms.Label();
            this.txtOPDFirstName = new System.Windows.Forms.TextBox();
            this.lblOPDFirstName = new System.Windows.Forms.Label();
            this.txtOPDAddress = new System.Windows.Forms.TextBox();
            this.txtOPDMiddleName = new System.Windows.Forms.TextBox();
            this.lblOPDLastName = new System.Windows.Forms.Label();
            this.txtOPDLastName = new System.Windows.Forms.TextBox();
            this.tlpPatient = new System.Windows.Forms.TableLayoutPanel();
            this.lblOPDNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.chkDischarge = new System.Windows.Forms.CheckBox();
            this.lblDischargeDate = new System.Windows.Forms.Label();
            this.chkToIpd = new System.Windows.Forms.CheckBox();
            this.dtpDischargDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMaritalStatus = new System.Windows.Forms.ComboBox();
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupOPDAge)).BeginInit();
            this.tlpPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 415);
            this.lineAction.Size = new System.Drawing.Size(649, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(557, 425);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(471, 425);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 425);
            this.btnDelete.TabIndex = 2;
            // 
            // txtOPDContactNo
            // 
            this.txtOPDContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOPDContactNo.Location = new System.Drawing.Point(440, 188);
            this.txtOPDContactNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtOPDContactNo.MaxLength = 10;
            this.txtOPDContactNo.Name = "txtOPDContactNo";
            this.txtOPDContactNo.Size = new System.Drawing.Size(182, 21);
            this.txtOPDContactNo.TabIndex = 17;
            // 
            // lblOPDPhoneNo
            // 
            this.lblOPDPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDPhoneNo.AutoSize = true;
            this.lblOPDPhoneNo.Location = new System.Drawing.Point(315, 188);
            this.lblOPDPhoneNo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDPhoneNo.Name = "lblOPDPhoneNo";
            this.lblOPDPhoneNo.Size = new System.Drawing.Size(119, 15);
            this.lblOPDPhoneNo.TabIndex = 16;
            this.lblOPDPhoneNo.Text = "Contact No";
            this.lblOPDPhoneNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOPDCity
            // 
            this.txtOPDCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOPDCity.Location = new System.Drawing.Point(128, 188);
            this.txtOPDCity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtOPDCity.MaxLength = 50;
            this.txtOPDCity.Name = "txtOPDCity";
            this.txtOPDCity.Size = new System.Drawing.Size(181, 21);
            this.txtOPDCity.TabIndex = 15;
            // 
            // lblOPDCityTown
            // 
            this.lblOPDCityTown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDCityTown.AutoSize = true;
            this.lblOPDCityTown.Location = new System.Drawing.Point(3, 188);
            this.lblOPDCityTown.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDCityTown.Name = "lblOPDCityTown";
            this.lblOPDCityTown.Size = new System.Drawing.Size(119, 15);
            this.lblOPDCityTown.TabIndex = 14;
            this.lblOPDCityTown.Text = "City/Town";
            this.lblOPDCityTown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nupOPDAge
            // 
            this.nupOPDAge.Location = new System.Drawing.Point(440, 33);
            this.nupOPDAge.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.nupOPDAge.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupOPDAge.Name = "nupOPDAge";
            this.nupOPDAge.Size = new System.Drawing.Size(120, 21);
            this.nupOPDAge.TabIndex = 7;
            // 
            // lblOPDAge
            // 
            this.lblOPDAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDAge.AutoSize = true;
            this.lblOPDAge.Location = new System.Drawing.Point(315, 33);
            this.lblOPDAge.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDAge.Name = "lblOPDAge";
            this.lblOPDAge.Size = new System.Drawing.Size(119, 15);
            this.lblOPDAge.TabIndex = 6;
            this.lblOPDAge.Text = "Age";
            this.lblOPDAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOPDGender
            // 
            this.cmbOPDGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOPDGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOPDGender.FormattingEnabled = true;
            this.cmbOPDGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbOPDGender.Location = new System.Drawing.Point(128, 66);
            this.cmbOPDGender.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbOPDGender.Name = "cmbOPDGender";
            this.cmbOPDGender.Size = new System.Drawing.Size(181, 23);
            this.cmbOPDGender.TabIndex = 9;
            // 
            // lblOPDMiddleName
            // 
            this.lblOPDMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDMiddleName.AutoSize = true;
            this.lblOPDMiddleName.Location = new System.Drawing.Point(315, 6);
            this.lblOPDMiddleName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDMiddleName.Name = "lblOPDMiddleName";
            this.lblOPDMiddleName.Size = new System.Drawing.Size(119, 15);
            this.lblOPDMiddleName.TabIndex = 2;
            this.lblOPDMiddleName.Text = "Middle Name";
            this.lblOPDMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOPDGender
            // 
            this.lblOPDGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDGender.AutoSize = true;
            this.lblOPDGender.Location = new System.Drawing.Point(3, 66);
            this.lblOPDGender.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDGender.Name = "lblOPDGender";
            this.lblOPDGender.Size = new System.Drawing.Size(119, 15);
            this.lblOPDGender.TabIndex = 8;
            this.lblOPDGender.Text = "Gender";
            this.lblOPDGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOPDAddress
            // 
            this.lblOPDAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDAddress.AutoSize = true;
            this.lblOPDAddress.Location = new System.Drawing.Point(3, 101);
            this.lblOPDAddress.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDAddress.Name = "lblOPDAddress";
            this.tlpPatient.SetRowSpan(this.lblOPDAddress, 2);
            this.lblOPDAddress.Size = new System.Drawing.Size(119, 45);
            this.lblOPDAddress.TabIndex = 12;
            this.lblOPDAddress.Text = "Address\r\n(Press Ctl+Enter for New line)";
            this.lblOPDAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOPDFirstName
            // 
            this.txtOPDFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOPDFirstName.Location = new System.Drawing.Point(128, 3);
            this.txtOPDFirstName.MaxLength = 50;
            this.txtOPDFirstName.Name = "txtOPDFirstName";
            this.txtOPDFirstName.Size = new System.Drawing.Size(181, 21);
            this.txtOPDFirstName.TabIndex = 1;
            // 
            // lblOPDFirstName
            // 
            this.lblOPDFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDFirstName.AutoSize = true;
            this.lblOPDFirstName.Location = new System.Drawing.Point(3, 6);
            this.lblOPDFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDFirstName.Name = "lblOPDFirstName";
            this.lblOPDFirstName.Size = new System.Drawing.Size(119, 15);
            this.lblOPDFirstName.TabIndex = 0;
            this.lblOPDFirstName.Text = "First Name";
            this.lblOPDFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOPDAddress
            // 
            this.tlpPatient.SetColumnSpan(this.txtOPDAddress, 3);
            this.txtOPDAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOPDAddress.Location = new System.Drawing.Point(128, 101);
            this.txtOPDAddress.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtOPDAddress.MaxLength = 500;
            this.txtOPDAddress.Multiline = true;
            this.txtOPDAddress.Name = "txtOPDAddress";
            this.tlpPatient.SetRowSpan(this.txtOPDAddress, 2);
            this.txtOPDAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOPDAddress.Size = new System.Drawing.Size(494, 75);
            this.txtOPDAddress.TabIndex = 13;
            // 
            // txtOPDMiddleName
            // 
            this.txtOPDMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOPDMiddleName.Location = new System.Drawing.Point(440, 3);
            this.txtOPDMiddleName.MaxLength = 50;
            this.txtOPDMiddleName.Name = "txtOPDMiddleName";
            this.txtOPDMiddleName.Size = new System.Drawing.Size(182, 21);
            this.txtOPDMiddleName.TabIndex = 3;
            // 
            // lblOPDLastName
            // 
            this.lblOPDLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDLastName.AutoSize = true;
            this.lblOPDLastName.Location = new System.Drawing.Point(3, 33);
            this.lblOPDLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDLastName.Name = "lblOPDLastName";
            this.lblOPDLastName.Size = new System.Drawing.Size(119, 15);
            this.lblOPDLastName.TabIndex = 4;
            this.lblOPDLastName.Text = "Last Name";
            this.lblOPDLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOPDLastName
            // 
            this.txtOPDLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOPDLastName.Location = new System.Drawing.Point(128, 33);
            this.txtOPDLastName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtOPDLastName.MaxLength = 50;
            this.txtOPDLastName.Name = "txtOPDLastName";
            this.txtOPDLastName.Size = new System.Drawing.Size(181, 21);
            this.txtOPDLastName.TabIndex = 5;
            // 
            // tlpPatient
            // 
            this.tlpPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPatient.ColumnCount = 4;
            this.tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpPatient.Controls.Add(this.txtOPDLastName, 1, 1);
            this.tlpPatient.Controls.Add(this.lblOPDLastName, 0, 1);
            this.tlpPatient.Controls.Add(this.txtOPDMiddleName, 3, 0);
            this.tlpPatient.Controls.Add(this.txtOPDAddress, 1, 5);
            this.tlpPatient.Controls.Add(this.lblOPDFirstName, 0, 0);
            this.tlpPatient.Controls.Add(this.txtOPDFirstName, 1, 0);
            this.tlpPatient.Controls.Add(this.lblOPDAddress, 0, 5);
            this.tlpPatient.Controls.Add(this.lblOPDGender, 0, 2);
            this.tlpPatient.Controls.Add(this.lblOPDMiddleName, 2, 0);
            this.tlpPatient.Controls.Add(this.cmbOPDGender, 1, 2);
            this.tlpPatient.Controls.Add(this.lblOPDCityTown, 0, 7);
            this.tlpPatient.Controls.Add(this.txtOPDCity, 1, 7);
            this.tlpPatient.Controls.Add(this.lblOPDNotes, 0, 19);
            this.tlpPatient.Controls.Add(this.txtNotes, 1, 19);
            this.tlpPatient.Controls.Add(this.lblOPDAge, 2, 1);
            this.tlpPatient.Controls.Add(this.nupOPDAge, 3, 1);
            this.tlpPatient.Controls.Add(this.chkDischarge, 0, 21);
            this.tlpPatient.Controls.Add(this.lblDischargeDate, 2, 21);
            this.tlpPatient.Controls.Add(this.chkToIpd, 0, 20);
            this.tlpPatient.Controls.Add(this.dtpDischargDate, 3, 21);
            this.tlpPatient.Controls.Add(this.lblOPDPhoneNo, 2, 7);
            this.tlpPatient.Controls.Add(this.txtOPDContactNo, 3, 7);
            this.tlpPatient.Controls.Add(this.cmbMaritalStatus, 3, 2);
            this.tlpPatient.Controls.Add(this.lblMaritalStatus, 2, 2);
            this.tlpPatient.Location = new System.Drawing.Point(12, 51);
            this.tlpPatient.Name = "tlpPatient";
            this.tlpPatient.RowCount = 22;
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPatient.Size = new System.Drawing.Size(625, 368);
            this.tlpPatient.TabIndex = 109;
            // 
            // lblOPDNotes
            // 
            this.lblOPDNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOPDNotes.AutoSize = true;
            this.lblOPDNotes.Location = new System.Drawing.Point(3, 221);
            this.lblOPDNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOPDNotes.Name = "lblOPDNotes";
            this.lblOPDNotes.Size = new System.Drawing.Size(119, 45);
            this.lblOPDNotes.TabIndex = 18;
            this.lblOPDNotes.Text = "Notes\r\n(Press Ctl+Enter for New line)";
            this.lblOPDNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNotes
            // 
            this.tlpPatient.SetColumnSpan(this.txtNotes, 3);
            this.txtNotes.Location = new System.Drawing.Point(128, 221);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtNotes.MaxLength = 500;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(494, 69);
            this.txtNotes.TabIndex = 19;
            // 
            // chkDischarge
            // 
            this.chkDischarge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDischarge.AutoSize = true;
            this.chkDischarge.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDischarge.Location = new System.Drawing.Point(3, 330);
            this.chkDischarge.Name = "chkDischarge";
            this.chkDischarge.Size = new System.Drawing.Size(119, 19);
            this.chkDischarge.TabIndex = 21;
            this.chkDischarge.Text = "Discharge";
            this.chkDischarge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDischarge.UseVisualStyleBackColor = true;
            this.chkDischarge.Visible = false;
            this.chkDischarge.CheckedChanged += new System.EventHandler(this.chkDischarge_CheckedChanged);
            // 
            // lblDischargeDate
            // 
            this.lblDischargeDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDischargeDate.AutoSize = true;
            this.lblDischargeDate.Location = new System.Drawing.Point(315, 333);
            this.lblDischargeDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblDischargeDate.Name = "lblDischargeDate";
            this.lblDischargeDate.Size = new System.Drawing.Size(119, 15);
            this.lblDischargeDate.TabIndex = 22;
            this.lblDischargeDate.Text = "Discharge Date";
            this.lblDischargeDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDischargeDate.Visible = false;
            // 
            // chkToIpd
            // 
            this.chkToIpd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkToIpd.AutoSize = true;
            this.chkToIpd.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkToIpd.Location = new System.Drawing.Point(3, 302);
            this.chkToIpd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.chkToIpd.Name = "chkToIpd";
            this.chkToIpd.Size = new System.Drawing.Size(119, 19);
            this.chkToIpd.TabIndex = 20;
            this.chkToIpd.Text = "Transfer To IPD";
            this.chkToIpd.UseVisualStyleBackColor = true;
            // 
            // dtpDischargDate
            // 
            this.dtpDischargDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDischargDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDischargDate.Location = new System.Drawing.Point(440, 333);
            this.dtpDischargDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dtpDischargDate.Name = "dtpDischargDate";
            this.dtpDischargDate.Size = new System.Drawing.Size(181, 21);
            this.dtpDischargDate.TabIndex = 23;
            this.dtpDischargDate.Visible = false;
            // 
            // cmbMaritalStatus
            // 
            this.cmbMaritalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaritalStatus.FormattingEnabled = true;
            this.cmbMaritalStatus.Location = new System.Drawing.Point(440, 66);
            this.cmbMaritalStatus.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbMaritalStatus.Name = "cmbMaritalStatus";
            this.cmbMaritalStatus.Size = new System.Drawing.Size(182, 23);
            this.cmbMaritalStatus.TabIndex = 11;
            // 
            // lblMaritalStatus
            // 
            this.lblMaritalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaritalStatus.Location = new System.Drawing.Point(315, 66);
            this.lblMaritalStatus.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMaritalStatus.Name = "lblMaritalStatus";
            this.lblMaritalStatus.Size = new System.Drawing.Size(119, 15);
            this.lblMaritalStatus.TabIndex = 10;
            this.lblMaritalStatus.Text = "Marital Status";
            this.lblMaritalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OPDPatientForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 455);
            this.Controls.Add(this.tlpPatient);
            this.Name = "OPDPatientForm";
            this.Text = "PatientForm";
            this.Controls.SetChildIndex(this.tlpPatient, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nupOPDAge)).EndInit();
            this.tlpPatient.ResumeLayout(false);
            this.tlpPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOPDContactNo;
        private System.Windows.Forms.Label lblOPDPhoneNo;
        private System.Windows.Forms.TableLayoutPanel tlpPatient;
        private System.Windows.Forms.TextBox txtOPDLastName;
        private System.Windows.Forms.Label lblOPDLastName;
        private System.Windows.Forms.TextBox txtOPDMiddleName;
        private System.Windows.Forms.TextBox txtOPDAddress;
        private System.Windows.Forms.Label lblOPDFirstName;
        private System.Windows.Forms.TextBox txtOPDFirstName;
        private System.Windows.Forms.Label lblOPDAddress;
        private System.Windows.Forms.Label lblOPDGender;
        private System.Windows.Forms.Label lblOPDMiddleName;
        private System.Windows.Forms.ComboBox cmbOPDGender;
        private System.Windows.Forms.Label lblOPDAge;
        private System.Windows.Forms.NumericUpDown nupOPDAge;
        private System.Windows.Forms.Label lblOPDCityTown;
        private System.Windows.Forms.TextBox txtOPDCity;
        private System.Windows.Forms.Label lblOPDNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.CheckBox chkDischarge;
        private System.Windows.Forms.Label lblDischargeDate;
        private System.Windows.Forms.DateTimePicker dtpDischargDate;
        private System.Windows.Forms.CheckBox chkToIpd;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.ComboBox cmbMaritalStatus;

    }
}