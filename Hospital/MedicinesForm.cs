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
    public partial class MedicinesForm : Hospital.ObjectbaseForm
    {
        private Medicines mEntry;

        #region MedicinesForm
        public MedicinesForm() : this(null) { }
        public MedicinesForm(Medicines medicine)
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


            this.txtReOrderLevel.Tag = this.lblReOrderLevel;
            this.lblReOrderLevel.Click += new EventHandler(OnLabelClick);
            this.txtReOrderLevel.Enter += new EventHandler(OnControlEnter);
            this.txtReOrderLevel.Leave += new EventHandler(OnControlLeave);

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
                if (txtReOrderLevel.Text != "")
                {
                    this.mEntry.ReOrderLevel = int.Parse(txtReOrderLevel.Text);
                }
                else
                {
                    this.mEntry.ReOrderLevel = 0;
                }
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
                this.CheckPermission();
                this.cmbCategory.SelectedItem = this.mEntry.Category as Category;
                this.cmbCompany.SelectedItem = this.mEntry.Company as Company;
                this.cmbItem.SelectedItem = this.mEntry.Item as Item;
                this.txtReOrderLevel.Text = this.mEntry.ReOrderLevel.ToString();
                this.cmbCategory.Select();
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

        public static bool ShowForm(Medicines obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (MedicinesForm frm = new MedicinesForm(obj))
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

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedItem != null)
            {
                Guid companyGuid = new Guid(cmbCompany.SelectedItem.ToString());
                ItemCollection itemList = new ItemCollection(companyGuid);
                //if (cmbItem.SelectedItem == null)
                {
                    this.cmbItem.DataSource = itemList;
                    this.cmbItem.DisplayMember = "DisplayName";
                }
            }
        }

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
