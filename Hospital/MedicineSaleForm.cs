using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Object;

namespace Hospital
{
    public partial class MedicineSaleForm : Hospital.ObjectbaseForm
    {
        private MedicineSale mEntry;
        private static decimal availableStock = 0;

        #region MedicineSaleForm
        public MedicineSaleForm() : this(null) { }
        public MedicineSaleForm(MedicineSale medicine)
            : base(medicine)
        {
            this.mEntry = medicine;
            this.InitializeComponent();
            this.UserInitialize();
        }
        #endregion

        #region UserIntialize
        private void UserInitialize()
        {
            this.txtHaste.Tag = this.lblHaste;
            this.lblHaste.Click += new EventHandler(OnLabelClick);
            this.txtHaste.Enter += new EventHandler(OnControlEnter);
            this.txtHaste.Leave += new EventHandler(OnControlLeave);

            this.cmbCategory.Tag = this.lblCategory;
            this.lblCategory.Click += new EventHandler(OnLabelClick);
            this.cmbCategory.Enter += new EventHandler(OnControlEnter);
            this.cmbCategory.Leave += new EventHandler(OnControlLeave);

            this.cmbCompany.Tag = this.lblCompany;
            this.lblCompany.Click += new EventHandler(OnLabelClick);
            this.cmbCompany.Enter += new EventHandler(OnControlEnter);
            this.cmbCompany.Leave += new EventHandler(OnControlLeave);

            this.cmbItem.Tag = this.lblItem;
            this.lblItem.Click += new EventHandler(OnLabelClick);
            this.cmbItem.Enter += new EventHandler(OnControlEnter);
            this.cmbItem.Leave += new EventHandler(OnControlLeave);

            this.nupQuantity.Tag = this.lblQuantity;
            this.lblQuantity.Click += new EventHandler(OnLabelClick);
            this.nupQuantity.Enter += new EventHandler(OnControlEnter);
            this.nupQuantity.Leave += new EventHandler(OnControlLeave);

            this.nupAmount.Tag = this.lblAmount;
            this.lblAmount.Click += new EventHandler(OnLabelClick);
            this.nupAmount.Enter += new EventHandler(OnControlEnter);
            this.nupAmount.Leave += new EventHandler(OnControlLeave);

            
        }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Haste= this.txtHaste.Text.ToString();
                this.mEntry.Category = cmbCategory.SelectedItem as Category;
                this.mEntry.Company = cmbCompany.SelectedItem as Company;
                this.mEntry.Item = cmbItem.SelectedItem as Item;
                this.mEntry.Quantity = this.nupQuantity.Value;
                this.mEntry.Amount = this.nupAmount.Value;              
            }
        }
        #endregion

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            CategoryCollection categoryList = new CategoryCollection();
            this.cmbCategory.DataSource = categoryList;
            this.cmbCategory.DisplayMember = "DisplayName";

            this.cmbCategory.Select();
             if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                this.txtHaste.Text = this.mEntry.Haste;
                this.cmbCategory.SelectedItem = this.mEntry.Category as Category;
                this.cmbCompany.SelectedItem = this.mEntry.Company as Company;
                this.cmbItem.SelectedItem = this.mEntry.Item as Item;

                 
                this.nupQuantity.Value = this.mEntry.Quantity;
                
                this.nupAmount.Value = this.mEntry.Amount;                
            }
        }
        
        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;
            if (this.cmbCategory.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbCategory, "Category", "Category is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbCategory.Select();
                r = false;
            }

            if (this.cmbCompany.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbCompany, "Company", "Company is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbCompany.Select();
                r = false;
            }

            if (this.cmbItem.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbItem, "Item", "Item is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbItem.Select();
                r = false;
            }

            if (this.nupQuantity.Value > availableStock && this.nupQuantity.Value > this.mEntry.Quantity)
            {
                this.ShowTooltip(this.nupQuantity, "Quantity", "Quantity should not be more than available", ContentAlignment.TopRight);
                if (r)
                    this.nupQuantity.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }
        #endregion

        public static bool ShowForm(MedicineSale obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (MedicineSaleForm frm = new MedicineSaleForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }

        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "OPDTreatment")
                    {
                        if (!this.mEntry.IsNew)
                        {
                            this.btnDelete.Visible = AppContext.CanDelete(e.ObjectGuid);
                            this.btnSave.Visible = AppContext.CanEdit(e.ObjectGuid);
                        }
                    }
                }
            }
            else
            {
                if (!this.mEntry.IsNew)
                    this.btnDelete.Visible = true;
            }
        }

        private void nupQuantity_Leave(object sender, EventArgs e)
        {
            this.nupAmount.Value = 0;
            this.nupQuantity.Value = 0;
            if (cmbCategory.SelectedItem != null && cmbCompany.SelectedItem != null && cmbItem.SelectedItem != null)
            {
                MedicineSale MSale = new MedicineSale();
                decimal mrp = MSale.GetMRP(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);

                if (nupQuantity.Text != "")
                {
                    //this.mEntry.Quantity = int.Parse(nupQuantity.Text);
                    decimal amount = mrp * int.Parse(this.nupQuantity.Text);
                    this.nupAmount.Value = amount;
                
                }
                else
                {
                    this.mEntry.Quantity = 0;
                }
                
            }
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nupAmount.Value = 0;
            if (cmbCompany.SelectedItem != null)
            {
                Guid companyGuid = new Guid(cmbCompany.SelectedItem.ToString());
                ItemCollection itemList = new ItemCollection(companyGuid);
                this.cmbItem.DataSource = itemList;
                this.cmbItem.DisplayMember = "DisplayName";
            }
            if (cmbCategory.SelectedItem != null && cmbCompany.SelectedItem != null && cmbItem.SelectedItem != null)
            {
                availableStock = 0;
                Medicines m = new Medicines();
                availableStock = m.GetMaxQuantityAvailable(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                lblAvailableQuantity.Text = "Max Available (" + availableStock.ToString() + " )";
                lblAvailableQuantity.Visible = true;

                MedicineSale MSale = new MedicineSale();
                decimal mrp = MSale.GetMRP(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                decimal amount = mrp * (this.nupQuantity.Value);
                this.nupAmount.Value = amount;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nupAmount.Value = 0;
            if (cmbCategory.SelectedItem != null)
            {
                Guid categoryGuid = new Guid(cmbCategory.SelectedItem.ToString());
                CompanyCollection companyList = new CompanyCollection();
                if (cmbCompany.SelectedItem == null)
                {
                    this.cmbCompany.DataSource = companyList;
                    this.cmbCompany.DisplayMember = "DisplayName";
                }
            }
            this.nupAmount.Value = 0;
            if (cmbCategory.SelectedItem != null && cmbCompany.SelectedItem != null && cmbItem.SelectedItem != null)
            {
                availableStock = 0;
                Medicines m = new Medicines();
                availableStock = m.GetMaxQuantityAvailable(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                lblAvailableQuantity.Text = "Max Available (" + availableStock.ToString() + " )";
                lblAvailableQuantity.Visible = true;

                MedicineSale MSale = new MedicineSale();
                decimal mrp = MSale.GetMRP(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                decimal amount = mrp * (this.nupQuantity.Value);
                this.nupAmount.Value = amount;
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nupAmount.Value = 0;
            if (cmbCategory.SelectedItem != null && cmbCompany.SelectedItem != null && cmbItem.SelectedItem != null)
            {
                availableStock = 0;
                Medicines m = new Medicines();
                availableStock = m.GetMaxQuantityAvailable(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                lblAvailableQuantity.Text = "Max Available (" + availableStock.ToString() + " )";
                lblAvailableQuantity.Visible = true;

                MedicineSale MSale = new MedicineSale();
                decimal mrp = MSale.GetMRP(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                decimal amount = mrp * (this.nupQuantity.Value);
                this.nupAmount.Value = amount;
            }
        }
    }
}
