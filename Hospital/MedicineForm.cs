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
    public partial class MedicineForm : Hospital.ObjectbaseForm
    {
        private Medicine mEntry;

        #region MedicineForm
        public MedicineForm() : this(null) { }
        public MedicineForm(Medicine medicine)  : base(medicine)
        {
            this.mEntry = medicine;
            this.InitializeComponent();
            this.UserInitialize();
        }
        #endregion

        #region UserIntialize
        private void UserInitialize()
        {

            this.txtMedicine.Tag = this.lblMedicine;
            this.lblMedicine.Click += new EventHandler(OnLabelClick);
            this.txtMedicine.Enter += new EventHandler(OnControlEnter);
            this.txtMedicine.Leave += new EventHandler(OnControlLeave);


            this.txtDescription.Tag = this.lblDescription;
            this.lblDescription.Click += new EventHandler(OnLabelClick);
            this.txtDescription.Enter += new EventHandler(OnControlEnter);
            this.txtDescription.Leave += new EventHandler(OnControlLeave);

        }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Name = txtMedicine.Text;
                this.mEntry.Description = txtDescription.Text;
            }
        }
        #endregion

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            ChiefComplainCollection opdtreatmentcollection = new ChiefComplainCollection();            

            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                this.txtMedicine.Text = this.mEntry.Name;
                this.txtDescription.Text = this.mEntry.Description;
                txtMedicine.Focus();
            }
        }
        
        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;
            if (this.txtMedicine.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtMedicine, "Medicine", "Medicine is Required!", ContentAlignment.TopLeft);
                if (r)
                    this.txtMedicine.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        public static bool ShowForm(Medicine obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (MedicineForm frm = new MedicineForm(obj))
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

    }
}
