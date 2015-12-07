namespace Hospital
{
    partial class MedicineSaleForm
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
            this.nupAmount = new System.Windows.Forms.NumericUpDown();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.txtHaste = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblHaste = new System.Windows.Forms.Label();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.tlpUserRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).BeginInit();
            this.pnlQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lineAction
            // 
            this.lineAction.Location = new System.Drawing.Point(0, 277);
            this.lineAction.Size = new System.Drawing.Size(598, 2);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(506, 287);
            this.btnCancel.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(420, 287);
            this.btnSave.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 287);
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
            this.tlpUserRole.Controls.Add(this.nupAmount, 1, 6);
            this.tlpUserRole.Controls.Add(this.lblCategory, 0, 0);
            this.tlpUserRole.Controls.Add(this.cmbCategory, 1, 0);
            this.tlpUserRole.Controls.Add(this.lblQuantity, 0, 5);
            this.tlpUserRole.Controls.Add(this.cmbItem, 1, 4);
            this.tlpUserRole.Controls.Add(this.lblItem, 0, 4);
            this.tlpUserRole.Controls.Add(this.cmbCompany, 1, 3);
            this.tlpUserRole.Controls.Add(this.txtHaste, 1, 1);
            this.tlpUserRole.Controls.Add(this.lblAmount, 0, 6);
            this.tlpUserRole.Controls.Add(this.lblCompany, 0, 3);
            this.tlpUserRole.Controls.Add(this.lblHaste, 0, 1);
            this.tlpUserRole.Controls.Add(this.pnlQuantity, 1, 5);
            this.tlpUserRole.Location = new System.Drawing.Point(51, 54);
            this.tlpUserRole.Name = "tlpUserRole";
            this.tlpUserRole.RowCount = 7;
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpUserRole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpUserRole.Size = new System.Drawing.Size(521, 209);
            this.tlpUserRole.TabIndex = 110;
            // 
            // nupAmount
            // 
            this.nupAmount.Location = new System.Drawing.Point(123, 177);
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
            this.nupAmount.Size = new System.Drawing.Size(128, 21);
            this.nupAmount.TabIndex = 11;
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
            this.cmbCategory.Size = new System.Drawing.Size(395, 23);
            this.cmbCategory.Sorted = true;
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(3, 140);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(114, 15);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbItem
            // 
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(123, 105);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(384, 23);
            this.cmbItem.TabIndex = 7;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // lblItem
            // 
            this.lblItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(3, 105);
            this.lblItem.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(114, 15);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "Item";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(123, 71);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(384, 23);
            this.cmbCompany.TabIndex = 5;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // txtHaste
            // 
            this.txtHaste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHaste.Location = new System.Drawing.Point(123, 41);
            this.txtHaste.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtHaste.Name = "txtHaste";
            this.txtHaste.Size = new System.Drawing.Size(395, 21);
            this.txtHaste.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(3, 177);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(114, 15);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompany
            // 
            this.lblCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(3, 74);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(114, 15);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "Company";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHaste
            // 
            this.lblHaste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHaste.AutoSize = true;
            this.lblHaste.Location = new System.Drawing.Point(3, 41);
            this.lblHaste.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblHaste.Name = "lblHaste";
            this.lblHaste.Size = new System.Drawing.Size(114, 15);
            this.lblHaste.TabIndex = 2;
            this.lblHaste.Text = "Haste";
            this.lblHaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuantity.Controls.Add(this.lblAvailableQuantity);
            this.pnlQuantity.Controls.Add(this.nupQuantity);
            this.pnlQuantity.Location = new System.Drawing.Point(123, 137);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(395, 31);
            this.pnlQuantity.TabIndex = 9;
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Location = new System.Drawing.Point(73, 11);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(41, 15);
            this.lblAvailableQuantity.TabIndex = 18;
            this.lblAvailableQuantity.Text = "label2";
            this.lblAvailableQuantity.Visible = false;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nupQuantity.Location = new System.Drawing.Point(3, 4);
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
            // MedicineSaleForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 317);
            this.Controls.Add(this.tlpUserRole);
            this.Name = "MedicineSaleForm";
            this.Text = "MedicineForm";
            this.Controls.SetChildIndex(this.tlpUserRole, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lineAction, 0);
            this.tlpUserRole.ResumeLayout(false);
            this.tlpUserRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmount)).EndInit();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlQuantity.PerformLayout();
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
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtHaste;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblHaste;
        private System.Windows.Forms.Panel pnlQuantity;
        private System.Windows.Forms.Label lblAvailableQuantity;
        private System.Windows.Forms.NumericUpDown nupQuantity;
        private System.Windows.Forms.NumericUpDown nupAmount;
    }
}