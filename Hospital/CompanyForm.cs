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
    public partial class CompanyForm : Hospital.ObjectbaseForm
    {
        private Company mEntry;

        #region CompanyForm

        public CompanyForm() : this(null) { }

        public CompanyForm(Company Company)
            : base(Company)
        {
            this.mEntry = Company;
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

            this.txtCompanyName.Tag = this.lblCompanyName;
            lblCompanyName.Click += new EventHandler(OnLabelClick);
            txtCompanyName.Enter += new EventHandler(OnControlEnter);
            txtCompanyName.Leave += new EventHandler(OnControlLeave);

        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Category = cmbCategory.SelectedItem as Category;
                this.mEntry.CompanyName = txtCompanyName.Text.Trim();

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
                this.txtCompanyName.Text = this.mEntry.CompanyName;
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
                    if (e.DisplayName == "Company Details")
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
            if (this.txtCompanyName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtCompanyName, "Company ", "Company Name is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtCompanyName.Select();
                r = false;
            }

            if (this.cmbCategory.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbCategory, "Category", "Category is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbCategory.Select();
                r = false;
            }


            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(Company obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (CompanyForm frm = new CompanyForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
