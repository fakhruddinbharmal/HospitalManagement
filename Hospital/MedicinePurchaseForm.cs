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
    public partial class MedicinePurchaseForm : Hospital.ObjectbaseForm
    {
        private MedicinePurchase mEntry;

        #region MedicinePurchaseForm
        public MedicinePurchaseForm() : this(null) { }
        public MedicinePurchaseForm(MedicinePurchase medicine)
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

            this.cmbBillType.Tag = this.lblBillType;
            this.lblItem.Click += new EventHandler(OnLabelClick);
            this.cmbBillType.Enter += new EventHandler(OnControlEnter);
            this.cmbBillType.Leave += new EventHandler(OnControlLeave);

            this.nupQuantity.Tag = this.lblQuantity;
            this.lblQuantity.Click += new EventHandler(OnLabelClick);
            this.nupQuantity.Enter += new EventHandler(OnControlEnter);
            this.nupQuantity.Leave += new EventHandler(OnControlLeave);

            this.nupWholeSaleRate.Tag = this.lblWholesaleRate;
            this.lblWholesaleRate.Click += new EventHandler(OnLabelClick);
            this.nupWholeSaleRate.Enter += new EventHandler(OnControlEnter);
            this.nupWholeSaleRate.Leave += new EventHandler(OnControlLeave);

            this.numMRP.Tag = this.lblMRP;
            this.lblMRP.Click += new EventHandler(OnLabelClick);
            this.numMRP.Enter += new EventHandler(OnControlEnter);
            this.numMRP.Leave += new EventHandler(OnControlLeave);

            this.numAmount.Tag = this.lblAmount;
            this.lblAmount.Click += new EventHandler(OnLabelClick);
            this.numAmount.Enter += new EventHandler(OnControlEnter);
            this.numAmount.Leave += new EventHandler(OnControlLeave);

            this.dtpExpiryDate.Tag = this.lblExpiryDate;
            this.lblExpiryDate.Click += new EventHandler(OnLabelClick);
            this.dtpExpiryDate.Enter += new EventHandler(OnControlEnter);
            this.dtpExpiryDate.Leave += new EventHandler(OnControlLeave);
                      

        }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Category = cmbCategory.SelectedItem as Category;
                this.mEntry.Company = cmbCompany.SelectedItem as Company;
                this.mEntry.Item = cmbItem.SelectedItem as Item;
                this.mEntry.BillType = this.cmbBillType.SelectedItem.ToString();
                this.mEntry.Quantity = int.Parse(this.nupQuantity.Value.ToString());
                this.mEntry.WholesaleRate = this.nupWholeSaleRate.Value;
                this.mEntry.Amount = this.numAmount.Value;
               this.mEntry.ExpiryDate= dtpExpiryDate.Value;
               this.mEntry.MRP = numMRP.Value;
               
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
                if (!this.mEntry.IsNew)
                {
                    this.cmbCategory.Enabled = this.cmbCompany.Enabled = this.cmbItem.Enabled = false;
                }
                this.cmbCategory.SelectedItem = this.mEntry.Category as Category;
                this.cmbCompany.SelectedItem = this.mEntry.Company as Company;
                this.cmbItem.SelectedItem = this.mEntry.Item as Item;
                 this.cmbBillType.SelectedIndex = !string.IsNullOrEmpty(this.mEntry.BillType) ? cmbBillType.FindStringExact(this.mEntry.BillType.ToString()) : 0;
                this.nupQuantity.Value= this.mEntry.Quantity;
                this.nupWholeSaleRate.Value = this.mEntry.WholesaleRate;
                this.numAmount.Value = this.mEntry.Amount;
                if (!string.IsNullOrEmpty(this.mEntry.ExpiryDate.ToString()) && (this.mEntry.ExpiryDate!= DateTime.MinValue))
                {
                    this.dtpExpiryDate.Value = mEntry.ExpiryDate;
                }
                this.numMRP.Value = this.mEntry.MRP;
                
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

            return r && base.OnDataValidation();
        }
        #endregion

        public static bool ShowForm(MedicinePurchase obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (MedicinePurchaseForm frm = new MedicinePurchaseForm(obj))
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
       
        public decimal AmountCalculation()
        {
            decimal amount;
            decimal rate = nupWholeSaleRate.Value;
            int qty = int.Parse(nupQuantity.Value.ToString());
            amount = rate * qty;
            return amount;
        }
               
        private void nupQuantity_Leave(object sender, EventArgs e)
        {
            numAmount.Value = AmountCalculation();
        }

        private void nupWholeSaleRate_Leave(object sender, EventArgs e)
        {
            numAmount.Value = AmountCalculation();
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedItem != null)
            {
                Guid companyGuid = new Guid(cmbCompany.SelectedItem.ToString());
                ItemCollection itemList = new ItemCollection(companyGuid);
                this.cmbItem.DataSource = itemList;
                this.cmbItem.DisplayMember = "DisplayName";
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
            {
                Guid categoryGuid = new Guid(cmbCategory.SelectedItem.ToString());
                CompanyCollection companyList = new CompanyCollection();
                this.cmbCompany.DataSource = companyList;
                this.cmbCompany.DisplayMember = "DisplayName";
            }
        }


    }
}
