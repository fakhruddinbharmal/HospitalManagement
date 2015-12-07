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
    public partial class PatientVitalForm : Hospital.ObjectbaseForm
    {
       private PatientVital mEntry;
       //private Patient mPatient;

       #region PatientVitalForm

        public PatientVitalForm() : this(null) { }
        public PatientVitalForm(PatientVital patientvital) : base(patientvital)
        {
            this.mEntry = patientvital;
            this.InitializeComponent();
            this.UserInitialize();
        }              
        #endregion

        #region UserInitialize
        private void UserInitialize()
        {
            this.cmbPatientName.Tag = this.lblPatientName;
            this.lblPatientName.Click += new EventHandler(OnLabelClick);
            this.cmbPatientName.Enter += new EventHandler(OnControlEnter);
            this.cmbPatientName.Leave += new EventHandler(OnControlLeave);

            this.dtpDate.Tag = this.lblDate;
            this.lblDate.Click += new EventHandler(OnLabelClick);
            this.dtpDate.Enter += new EventHandler(OnControlEnter);
            this.dtpDate.Leave += new EventHandler(OnControlLeave);

            this.cmbTime.Tag = this.lblTime;
            this.lblTime.Click += new EventHandler(OnLabelClick);
            this.cmbTime.Enter += new EventHandler(OnControlEnter);
            this.cmbTime.Leave += new EventHandler(OnControlLeave);

            this.txtBP.Tag = this.lblBP;
            this.lblBP.Click += new EventHandler(OnLabelClick);
            this.txtBP.Enter += new EventHandler(OnControlEnter);
            this.txtBP.Leave += new EventHandler(OnControlLeave);

            this.txtHR.Tag = this.lblHR;
            this.lblHR.Click += new EventHandler(OnLabelClick);
            this.txtHR.Enter += new EventHandler(OnControlEnter);
            this.txtHR.Leave += new EventHandler(OnControlLeave);

            this.txtRR.Tag = this.lblRR;
            this.lblRR.Click += new EventHandler(OnLabelClick);
            this.txtRR.Enter += new EventHandler(OnControlEnter);
            this.txtRR.Leave += new EventHandler(OnControlLeave);

            this.txtTemp.Tag = this.lblTemp;
            this.lblTemp.Click += new EventHandler(OnLabelClick);
            this.txtTemp.Enter += new EventHandler(OnControlEnter);
            this.txtTemp.Leave += new EventHandler(OnControlLeave);

            this.txtRBS.Tag = this.lblRBS;
            this.lblRBS.Click += new EventHandler(OnLabelClick);
            this.txtRBS.Enter += new EventHandler(OnControlEnter);
            this.txtRBS.Leave += new EventHandler(OnControlLeave);

            this.txtECG.Tag = this.lblECG;
            this.lblECG.Click += new EventHandler(OnLabelClick);
            this.txtECG.Enter += new EventHandler(OnControlEnter);
            this.txtECG.Leave += new EventHandler(OnControlLeave);

            this.txtWeight.Tag = this.lblWeight;
            this.lblWeight.Click += new EventHandler(OnLabelClick);
            this.txtWeight.Enter += new EventHandler(OnControlEnter);
            this.txtWeight.Leave += new EventHandler(OnControlLeave);

            this.txtHeight.Tag = this.lblHeight;
            this.lblHeight.Click += new EventHandler(OnLabelClick);
            this.txtHeight.Enter += new EventHandler(OnControlEnter);
            this.txtHeight.Leave += new EventHandler(OnControlLeave);

            this.txtOther.Tag = this.lblOther;
            this.lblOther.Click += new EventHandler(OnLabelClick);
            this.txtOther.Enter += new EventHandler(OnControlEnter);
            this.txtOther.Leave += new EventHandler(OnControlLeave);

            this.txtSPO2.Tag = this.lblSPO2;
            this.lblSPO2.Click += new EventHandler(OnLabelClick);
            this.txtSPO2.Enter += new EventHandler(OnControlEnter);
            this.txtSPO2.Leave += new EventHandler(OnControlLeave);

            this.txtPULSE.Tag = this.lblPulse;
            this.lblPulse.Click += new EventHandler(OnLabelClick);
            this.txtPULSE.Enter += new EventHandler(OnControlEnter);
            this.txtPULSE.Leave += new EventHandler(OnControlLeave);
        }

        #endregion

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            bool IsIPD = true;

            Patients patient = new Patients(IsIPD);
            this.cmbPatientName.DataSource = patient;
            this.cmbPatientName.DisplayMember = "DisplayName";

            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                //this.mEntry.Patient = mPatient;
                this.cmbPatientName.SelectedItem = this.mEntry.DisplayName;
                this.cmbPatientName.SelectedItem = this.mEntry.Patient != null ? this.mEntry.Patient as Patient : null;
                this.cmbTime.SelectedItem = this.mEntry.Time;
                this.txtBP.Text = this.mEntry.BP;
                this.txtHR.Text = this.mEntry.HR;
                this.txtRR.Text = this.mEntry.RR;
                this.txtTemp.Text = this.mEntry.Temp;
                this.txtRBS.Text = this.mEntry.RBS;
                this.txtECG.Text = this.mEntry.ECG;
                this.txtWeight.Text = this.mEntry.Weight;
                this.txtHeight.Text = this.mEntry.Height;
                this.txtOther.Text = this.mEntry.Other;
                this.txtSPO2.Text = this.mEntry.SPO2;
                this.txtPULSE.Text = this.mEntry.PULSE;
                if (!string.IsNullOrEmpty(this.mEntry.Date.ToString()) && (this.mEntry.Date != DateTime.MinValue))
                {
                    this.dtpDate.Value = this.mEntry.Date;
                }
                this.cmbPatientName.Select();
            }
       }
        #endregion

        #region OnDataSet
        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.Patient = this.cmbPatientName.SelectedItem as Patient;
                this.mEntry.Date = dtpDate.Value;
                if (this.cmbTime.SelectedItem != null)
                    this.mEntry.Time = cmbTime.SelectedItem.ToString();
                this.mEntry.BP = txtBP.Text;
                this.mEntry.HR = txtHR.Text;
                this.mEntry.RR = txtRR.Text;
                this.mEntry.Temp = txtTemp.Text;
                this.mEntry.RBS = txtRBS.Text;
                this.mEntry.ECG = txtECG.Text;
                this.mEntry.Weight = txtWeight.Text;
                this.mEntry.Height = txtHeight.Text;
                this.mEntry.Other = txtOther.Text;
                this.mEntry.SPO2 = txtSPO2.Text;
                this.mEntry.PULSE = txtPULSE.Text;
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
                    if (e.DisplayName == "Patient Vital Details")
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

        #region ShowForm
        public static bool ShowForm(PatientVital obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (PatientVitalForm frm = new PatientVitalForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }
        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;

            if (this.cmbPatientName.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbPatientName, "Patient", "Patient is Required!", ContentAlignment.TopLeft);
                if (r)
                    this.cmbPatientName.Select();
                r = false;
            }

            return r && base.OnDataValidation();
        }
        #endregion

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            IPDPatientTreamentDetailsReport p=new IPDPatientTreamentDetailsReport();
            p.IPDPatientTreatmentSheetGuid = mEntry.ObjectGuid;
            p.PatientName = mEntry.Patient == null ? mEntry.Other : mEntry.Patient.DisplayName;
            if (mEntry.Patient != null)
            {
                p.PatientGuid = mEntry.PatientGuid;
            }
            p.Show();
        }
    }
}
