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
    public partial class ItemForm : Hospital.ObjectbaseForm
    {
        private Item mEntry;

        #region ItemForm

        public ItemForm() : this(null) { }

        public ItemForm(Item Item)
            : base(Item)
        {
            this.mEntry = Item;
            this.InitializeComponent();
            this.UserInitialize();
        }
        #endregion

        #region UserInitialize

        public void UserInitialize()
        {
            this.cmbCategory.Tag = this.lblCategory;
            this.lblCategory.Click += new EventHandler(OnLabelClick);
            this.cmbCategory.Enter += new EventHandler(OnControlEnter);
            this.cmbCategory.Leave += new EventHandler(OnControlLeave);

            this.cmbCompany.Tag = this.lblCompany;
            this.lblCompany.Click += new EventHandler(OnLabelClick);
            this.cmbCompany.Enter += new EventHandler(OnControlEnter);
            this.cmbCompany.Leave += new EventHandler(OnControlLeave);

            this.txtItemName.Tag = this.lblItemName;
            lblItemName.Click += new EventHandler(OnLabelClick);
            txtItemName.Enter += new EventHandler(OnControlEnter);
            txtItemName.Leave += new EventHandler(OnControlLeave);

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
                this.mEntry.ItemName = txtItemName.Text.Trim();

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

           

            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                //this.c
                this.cmbCategory.SelectedItem = this.mEntry.Category as Category;
                this.cmbCompany.SelectedItem = this.mEntry.Company as Company;
                this.txtItemName.Text = this.mEntry.ItemName;
                this.cmbCategory.Select();
            }
        }
        #endregion

        #region CheckPermission

        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "Item Details")
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
                {
                    this.btnDelete.Visible = true;
                }
            }
        }
        #endregion


        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;
            if (this.txtItemName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtItemName, "Item ", "Item Name is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtItemName.Select();
                r = false;
            }

            if (this.cmbCategory.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbCategory, "Category", "Category is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbCategory.Select();
                r = false;
            }

            if (this.cmbCompany.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbCategory, "Company", "Company is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbCompany.Select();
                r = false;
            }


            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(Item obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (ItemForm frm = new ItemForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }
    }
}
