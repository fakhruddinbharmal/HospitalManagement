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
    public partial class CategoryForm : Hospital.ObjectbaseForm
    {
        private Category mEntry;

        #region CategoryForm

        public CategoryForm() : this(null) { }

        public CategoryForm(Category category)
            : base(category)
        {
            this.mEntry = category;
            this.InitializeComponent();
            this.UserInitialize();
        }              
        #endregion

        #region UserInitialize

        public void UserInitialize()
        {
            this.txtCategoryName.Tag = this.lblCategoryName;
            lblCategoryName.Click += new EventHandler(OnLabelClick);
            txtCategoryName.Enter += new EventHandler(OnControlEnter);
            txtCategoryName.Leave += new EventHandler(OnControlLeave);

        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.CategoryName = txtCategoryName.Text.Trim();
                
            }
        } 

        #endregion

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            { 
                //this.c
                this.txtCategoryName.Text = this.mEntry.CategoryName;                
                this.txtCategoryName.Select();
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
                    if (e.DisplayName == "Category Details")
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
            if (this.txtCategoryName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtCategoryName, "Category ", "Category Name is Required!", ContentAlignment.TopRight);
                if (r)
                    this.txtCategoryName.Select();
                r = false;
            }           
            return r && base.OnDataValidation();
        }
        #endregion

        #region ShowForm
        public static bool ShowForm(Category obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (CategoryForm frm = new CategoryForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
    }
}
