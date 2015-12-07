namespace Hospital
{
    partial class PatientBillForm
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
            this.tlpUserRole = new System.Windows.Forms.TableLayoutPanel();
            this.lblPatientType = new System.Windows.Forms.Label();
            this.cmbPatientType = new System.Windows.Forms.ComboBox();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtOtherPatientName = new System.Windows.Forms.TextBox();
            this.lblOtherPatientName = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.tlpUserRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 263);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(425, 275);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(327, 275);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 275);
            // 
            // tlpUserRole
            // 
            this.tlpUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUserRole.ColumnCount = 2;
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUserRole.Controls.Add(this.lblPatientType, 0, 0);
            this.tlpUserRole.Controls.Add(this.cmbPatientType, 1, 0);
            this.tlpUserRole.Controls.Add(this.cmbPatient, 1, 1);
            this.tlpUserRole.Controls.Add(this.lblPatient, 0, 1);
            this.tlpUserRole.Controls.Add(this.txtOtherPatientName, 1, 3);
            this.tlpUserRole.Controls.Add(this.lblOtherPatientName, 0, 3);
            this.tlpUserRole.Controls.Add(this.lblBillDate, 0, 4);
            this.tlpUserRole.Controls.Add(this.dtpBillDate, 1, 4);
            this.tlpUserRole.Location = new System.Drawing.Point(38, 65);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 5;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpUserRole.Size = new System.Drawing.Size(457, 138);
            this.tlpUserRole.TabIndex = 111;
            // 
            // lblPatientType
            // 
            this.lblPatientType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatientType.AutoSize = true;
            this.lblPatientType.Location = new System.Drawing.Point(3, 6);
            this.lblPatientType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPatientType.Name = "lblPatientType";
            this.lblPatientType.Size = new System.Drawing.Size(115, 15);
            this.lblPatientType.TabIndex = 0;
            this.lblPatientType.Text = "Patient Type";
            this.lblPatientType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmbPatientType.Location = new System.Drawing.Point(124, 6);
            this.cmbPatientType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbPatientType.Name = "cmbPatientType";
            this.cmbPatientType.Size = new System.Drawing.Size(131, 23);
            this.cmbPatientType.Sorted = true;
            this.cmbPatientType.TabIndex = 1;
            this.cmbPatientType.SelectedIndexChanged += new System.EventHandler(this.cmbPatientType_SelectedIndexChanged);
            // 
            // cmbPatient
            // 
            this.cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Items.AddRange(new object[] {
            "Company1",
            "Company2",
            "Company3"});
            this.cmbPatient.Location = new System.Drawing.Point(124, 38);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(200, 23);
            this.cmbPatient.TabIndex = 4;
            // 
            // lblPatient
            // 
            this.lblPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(3, 41);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(115, 15);
            this.lblPatient.TabIndex = 2;
            this.lblPatient.Text = "Patient";
            this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOtherPatientName
            // 
            this.txtOtherPatientName.Location = new System.Drawing.Point(124, 70);
            this.txtOtherPatientName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtOtherPatientName.Name = "txtOtherPatientName";
            this.txtOtherPatientName.Size = new System.Drawing.Size(241, 21);
            this.txtOtherPatientName.TabIndex = 8;
            this.txtOtherPatientName.Visible = false;
            // 
            // lblOtherPatientName
            // 
            this.lblOtherPatientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOtherPatientName.AutoSize = true;
            this.lblOtherPatientName.Location = new System.Drawing.Point(3, 70);
            this.lblOtherPatientName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblOtherPatientName.Name = "lblOtherPatientName";
            this.lblOtherPatientName.Size = new System.Drawing.Size(115, 15);
            this.lblOtherPatientName.TabIndex = 7;
            this.lblOtherPatientName.Text = "Other Patient Name";
            this.lblOtherPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOtherPatientName.Visible = false;
            // 
            // lblBillDate
            // 
            this.lblBillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Location = new System.Drawing.Point(3, 101);
            this.lblBillDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(115, 15);
            this.lblBillDate.TabIndex = 5;
            this.lblBillDate.Text = "Bill Date";
            this.lblBillDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(124, 98);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(200, 21);
            this.dtpBillDate.TabIndex = 9;
            // 
            // PatientBillForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 313);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "PatientBillForm";
            this.Text = "PatientBillForm";
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.Controls.SetChildIndex(this.tlpUserRole, 0);
            this.tlpUserRole.ResumeLayout(false);
            this.tlpUserRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUserRole;
        private System.Windows.Forms.Label lblPatientType;
        private System.Windows.Forms.ComboBox cmbPatientType;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblOtherPatientName;
        private System.Windows.Forms.TextBox txtOtherPatientName;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
    }
}