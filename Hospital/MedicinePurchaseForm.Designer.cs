namespace Hospital
{
    partial class MedicinePurchaseForm
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
            this.numMRP = new System.Windows.Forms.NumericUpDown();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.nupWholeSaleRate = new System.Windows.Forms.NumericUpDown();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lblBillType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblWholesaleRate = new System.Windows.Forms.Label();
            this.cmbBillType = new System.Windows.Forms.ComboBox();
            this.lblMRP = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tlpUserRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWholeSaleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 355);
            this.lineAction.Size = new System.Drawing.Size(587, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(495, 365);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(409, 365);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 365);
            this.btnDelete.TabIndex = 2;
            // 
            // tlpUserRole
            // 
            this.tlpUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpUserRole.ColumnCount = 2;
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpUserRole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUserRole.Controls.Add(this.numMRP, 1, 9);
            this.tlpUserRole.Controls.Add(this.numAmount, 1, 7);
            this.tlpUserRole.Controls.Add(this.nupWholeSaleRate, 0, 6);
            this.tlpUserRole.Controls.Add(this.nupQuantity, 1, 5);
            this.tlpUserRole.Controls.Add(this.lblCategory, 0, 0);
            this.tlpUserRole.Controls.Add(this.cmbCategory, 1, 0);
            this.tlpUserRole.Controls.Add(this.cmbCompany, 1, 1);
            this.tlpUserRole.Controls.Add(this.lblCompany, 0, 1);
            this.tlpUserRole.Controls.Add(this.lblItem, 0, 3);
            this.tlpUserRole.Controls.Add(this.cmbItem, 1, 3);
            this.tlpUserRole.Controls.Add(this.lblBillType, 0, 4);
            this.tlpUserRole.Controls.Add(this.lblQuantity, 0, 5);
            this.tlpUserRole.Controls.Add(this.lblWholesaleRate, 0, 6);
            this.tlpUserRole.Controls.Add(this.cmbBillType, 1, 4);
            this.tlpUserRole.Controls.Add(this.lblMRP, 0, 9);
            this.tlpUserRole.Controls.Add(this.dtpExpiryDate, 1, 8);
            this.tlpUserRole.Controls.Add(this.lblExpiryDate, 0, 8);
            this.tlpUserRole.Controls.Add(this.lblAmount, 0, 7);
            this.tlpUserRole.Location = new System.Drawing.Point(51, 54);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 10;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpUserRole.Size = new System.Drawing.Size(510, 298);
            this.tlpUserRole.TabIndex = 110;
            // 
            // numMRP
            // 
            this.numMRP.Location = new System.Drawing.Point(123, 267);
            this.numMRP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.numMRP.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numMRP.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numMRP.Name = "numMRP";
            this.numMRP.Size = new System.Drawing.Size(118, 21);
            this.numMRP.TabIndex = 17;
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(123, 210);
            this.numAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.numAmount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(118, 21);
            this.numAmount.TabIndex = 13;
            // 
            // nupWholeSaleRate
            // 
            this.nupWholeSaleRate.Location = new System.Drawing.Point(123, 178);
            this.nupWholeSaleRate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.nupWholeSaleRate.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nupWholeSaleRate.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            -2147483648});
            this.nupWholeSaleRate.Name = "nupWholeSaleRate";
            this.nupWholeSaleRate.Size = new System.Drawing.Size(118, 21);
            this.nupWholeSaleRate.TabIndex = 11;
            this.nupWholeSaleRate.Leave += new System.EventHandler(this.nupWholeSaleRate_Leave);
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(123, 145);
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
            this.nupQuantity.Size = new System.Drawing.Size(118, 21);
            this.nupQuantity.TabIndex = 9;
            this.nupQuantity.Leave += new System.EventHandler(this.nupQuantity_Leave);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(3, 6);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(114, 15);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.DropDownWidth = 200;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(123, 6);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(384, 23);
            this.cmbCategory.Sorted = true;
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(123, 38);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(384, 23);
            this.cmbCompany.TabIndex = 3;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(3, 41);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(114, 15);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Company";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItem
            // 
            this.lblItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(3, 70);
            this.lblItem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(114, 15);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(123, 70);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(384, 23);
            this.cmbItem.TabIndex = 5;
            // 
            // lblBillType
            // 
            this.lblBillType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillType.AutoSize = true;
            this.lblBillType.Location = new System.Drawing.Point(3, 101);
            this.lblBillType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(114, 15);
            this.lblBillType.TabIndex = 6;
            this.lblBillType.Text = "Bill Type";
            this.lblBillType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 145);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 15);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWholesaleRate
            // 
            this.lblWholesaleRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWholesaleRate.AutoSize = true;
            this.lblWholesaleRate.Location = new System.Drawing.Point(3, 178);
            this.lblWholesaleRate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWholesaleRate.Name = "lblWholesaleRate";
            this.lblWholesaleRate.Size = new System.Drawing.Size(114, 15);
            this.lblWholesaleRate.TabIndex = 10;
            this.lblWholesaleRate.Text = "WholesaleRate";
            this.lblWholesaleRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBillType
            // 
            this.cmbBillType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBillType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBillType.FormattingEnabled = true;
            this.cmbBillType.Items.AddRange(new object[] {
            "Cash Bill",
            "Debit Bill"});
            this.cmbBillType.Location = new System.Drawing.Point(123, 101);
            this.cmbBillType.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbBillType.Name = "cmbBillType";
            this.cmbBillType.Size = new System.Drawing.Size(384, 23);
            this.cmbBillType.TabIndex = 7;
            // 
            // lblMRP
            // 
            this.lblMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMRP.AutoSize = true;
            this.lblMRP.Location = new System.Drawing.Point(3, 267);
            this.lblMRP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(114, 15);
            this.lblMRP.TabIndex = 16;
            this.lblMRP.Text = "MRP";
            this.lblMRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpExpiryDate.CustomFormat = "dd/MM/yyyy";
            this.dtpExpiryDate.Location = new System.Drawing.Point(123, 235);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(384, 21);
            this.dtpExpiryDate.TabIndex = 15;
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(3, 238);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(114, 15);
            this.lblExpiryDate.TabIndex = 14;
            this.lblExpiryDate.Text = "ExpiryDate";
            this.lblExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(3, 210);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(114, 15);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MedicinePurchaseForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 395);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "MedicinePurchaseForm";
            this.Text = "MedicineForm";
            this.Controls.SetChildIndex(this.tlpUserRole, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tlpUserRole.ResumeLayout(false);
            this.tlpUserRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWholeSaleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUserRole;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblWholesaleRate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.ComboBox cmbBillType;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.NumericUpDown nupWholeSaleRate;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.NumericUpDown numMRP;
    }
}