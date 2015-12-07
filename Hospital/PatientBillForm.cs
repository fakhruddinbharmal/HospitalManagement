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
    public partial class PatientBillForm : Hospital.ObjectbaseForm
    {
        private PatientBill mPatientBill;

        public PatientBillForm() : this(null) { }

        public PatientBillForm(PatientBill patientBill)
            : base(patientBill)
        {
            this.mPatientBill = patientBill;
            InitializeComponent();
            this.UserInitialize();
        }


        #region UserIntialize
        private void UserInitialize()
        {
            this.cmbPatientType.Tag = this.lblPatientType;
            lblPatientType.Click += new EventHandler(OnLabelClick);
            cmbPatientType.Enter += new EventHandler(OnControlEnter);
            cmbPatientType.Leave += new EventHandler(OnControlLeave);

            this.cmbPatient.Tag = this.lblPatient;
            this.lblPatient.Click += new EventHandler(OnLabelClick);
            this.cmbPatient.Enter += new EventHandler(OnControlEnter);
            this.cmbPatient.Leave += new EventHandler(OnControlLeave);

            this.txtOtherPatientName.Tag = this.lblOtherPatientName;
            this.lblOtherPatientName.Click += new EventHandler(OnLabelClick);
            txtOtherPatientName.Enter += new EventHandler(OnControlEnter);
            txtOtherPatientName.Leave += new EventHandler(OnControlLeave);

            this.dtpBillDate.Tag = this.lblBillDate;
            this.lblBillDate.Click += new EventHandler(OnLabelClick);
            dtpBillDate.Enter += new EventHandler(OnControlEnter);
            dtpBillDate.Leave += new EventHandler(OnControlLeave);
        }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mPatientBill))
            {
                this.mPatientBill.Patient = cmbPatient.SelectedItem as Patient;
                this.mPatientBill.Other = txtOtherPatientName.Text.Trim();
                this.mPatientBill.PatientBillDate = dtpBillDate.Value;
            }
        }
        #endregion

        #region OnDataShow
        protected override void OnDataShow()
        {
            base.OnDataShow();
            if (!Objectbase.IsNullOrEmpty(this.mPatientBill))
            {
                this.CheckPermission();
                if (this.mPatientBill.Patient != null)
                {
                    if (this.mPatientBill.Patient.IsIPD)
                        this.cmbPatientType.SelectedItem = "I.P.D";
                    else if (this.mPatientBill.Patient.IsOPD)
                        this.cmbPatientType.SelectedItem = "O.P.D";
                    else
                        this.cmbPatientType.SelectedItem = "Other";
                }
                this.cmbPatient.SelectedItem = this.mPatientBill.Patient != null ? this.mPatientBill.Patient as Patient : null;
                this.txtOtherPatientName.Text = this.mPatientBill.Other;
                this.dtpBillDate.Value = this.mPatientBill.PatientBillDate != DateTime.MinValue ? this.mPatientBill.PatientBillDate : DateTime.Now.Date;
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
                    if (e.DisplayName == "Patient Medicin Sales")
                    {
                        if (!this.mPatientBill.IsNew)
                        {
                            this.btnDelete.Visible = AppContext.CanDelete(e.ObjectGuid);
                            this.btnSave.Visible = AppContext.CanEdit(e.ObjectGuid);
                        }
                    }
                }
            }
            else
            {
                if (!this.mPatientBill.IsNew)
                {
                    this.btnDelete.Visible = true;
                }
            }

        }
        #endregion

        #region ShowForm
        public static bool ShowForm(PatientBill obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (PatientBillForm frm = new PatientBillForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion
        private void cmbPatientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOtherPatientName.Visible = lblOtherPatientName.Visible = false;
            cmbPatient.DataSource = null;

            if (cmbPatientType.SelectedItem != null && cmbPatientType.SelectedItem != "Other")
            {
                bool isIPD = false;
                if (cmbPatientType.SelectedItem == "I.P.D")
                {
                    isIPD = true;
                }
                Patients patients = new Patients(isIPD);
                this.cmbPatient.DataSource = patients;
                this.cmbPatient.DisplayMember = "DisplayName";
            }
            else if (cmbPatientType.SelectedItem == "Other")
            {
                lblOtherPatientName.Visible = txtOtherPatientName.Visible = true;
                cmbPatient.Visible = lblPatient.Visible = false;
            }
        }
    }
}
