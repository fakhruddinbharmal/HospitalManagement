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
    public partial class IPDPatientTreatmentSheetForm : ObjectbaseForm
    {
        private IPDPatientTreatmentSheet mIPDPatientTreatmentSheet;

        private IPDPatientTreatmentSheetDetailsCollection mPatientTreatmentSheetDetailsCollection;

        private IPDPatientTreatmentSheetDetails mEntry;

        private static int counter = 0;

        private static bool isPatientTreatmentSheetDetailsEdit = false;

        public IPDPatientTreatmentSheetForm(IPDPatientTreatmentSheet obj)
            : base(obj, false)
        {
            this.mIPDPatientTreatmentSheet = obj;
            this.mPatientTreatmentSheetDetailsCollection = new IPDPatientTreatmentSheetDetailsCollection(obj.ObjectGuid);
            this.mEntry = new IPDPatientTreatmentSheetDetails();
            counter = 0;
            this.InitializeComponent();
            this.UserInitialize();
        }

        private void UserInitialize()
        {
            this.cmbPatientName.Tag = this.lblPatientName;
            lblPatientName.Click += new EventHandler(OnLabelClick);
            cmbPatientName.Enter += new EventHandler(OnControlEnter);
            cmbPatientName.Leave += new EventHandler(OnControlLeave);

            this.txtIPDNo.Tag = this.lblIPDNo;
            this.lblIPDNo.Click += new EventHandler(OnLabelClick);
            this.txtIPDNo.Enter += new EventHandler(OnControlEnter);
            this.txtIPDNo.Leave += new EventHandler(OnControlLeave);

            this.txtDrIncharge.Tag = this.lblDrIncharge;
            this.lblDrIncharge.Click += new EventHandler(OnLabelClick);
            txtDrIncharge.Enter += new EventHandler(OnControlEnter);
            txtDrIncharge.Leave += new EventHandler(OnControlLeave);

            this.dtpTreatmentDate.Tag = this.lblDate;
            this.lblDate.Click += new EventHandler(OnLabelClick);
            dtpTreatmentDate.Enter += new EventHandler(OnControlEnter);
            dtpTreatmentDate.Leave += new EventHandler(OnControlLeave);

            this.txtDiagnosis.Tag = this.lblDiagnosis;
            this.lblDiagnosis.Click += new EventHandler(OnLabelClick);
            this.txtDiagnosis.Enter += new EventHandler(OnControlEnter);
            this.txtDiagnosis.Leave += new EventHandler(OnControlLeave);

            this.txtDiatAdvice.Tag = this.lblDiatAdvice;
            this.lblDiatAdvice.Click += new EventHandler(OnLabelClick);
            this.txtDiatAdvice.Enter += new EventHandler(OnControlEnter);
            this.txtDiatAdvice.Leave += new EventHandler(OnControlLeave);

            this.txtSOSDrug.Tag = this.lblSOSDrug;
            this.lblSOSDrug.Click += new EventHandler(OnLabelClick);
            this.txtSOSDrug.Enter += new EventHandler(OnControlEnter);
            this.txtSOSDrug.Leave += new EventHandler(OnControlLeave);

            this.txtSpecialAdvice.Tag = this.lblSpecialAdvice;
            this.lblSpecialAdvice.Click += new EventHandler(OnLabelClick);
            this.txtSpecialAdvice.Enter += new EventHandler(OnControlEnter);
            this.txtSpecialAdvice.Leave += new EventHandler(OnControlLeave);

            this.txtDescription.Tag = this.lblDescription;
            this.lblDescription.Click += new EventHandler(OnLabelClick);
            this.txtDescription.Enter += new EventHandler(OnControlEnter);
            this.txtDescription.Leave += new EventHandler(OnControlLeave);

            this.cmbMorningTime.Tag = this.lblMorningTime;
            this.lblMorningTime.Click += new EventHandler(OnLabelClick);
            this.cmbMorningTime.Enter += new EventHandler(OnControlEnter);
            this.cmbMorningTime.Leave += new EventHandler(OnControlLeave);

            this.cmbNoonTime.Tag = this.lblNoonTime;
            this.lblNoonTime.Click += new EventHandler(OnLabelClick);
            this.cmbNoonTime.Enter += new EventHandler(OnControlEnter);
            this.cmbNoonTime.Leave += new EventHandler(OnControlLeave);

            this.cmbEveningTime.Tag = this.lblEveningTime;
            this.lblEveningTime.Click += new EventHandler(OnLabelClick);
            this.cmbEveningTime.Enter += new EventHandler(OnControlEnter);
            this.cmbEveningTime.Leave += new EventHandler(OnControlLeave);

            this.cmbNightTime.Tag = this.lblNightTime;
            this.lblNightTime.Click += new EventHandler(OnLabelClick);
            this.cmbNightTime.Enter += new EventHandler(OnControlEnter);
            this.cmbNightTime.Leave += new EventHandler(OnControlLeave);

            this.txtIndoorNo.Tag = this.lblIndoorNo;
            this.lblIndoorNo.Click += new EventHandler(OnLabelClick);
            this.txtIndoorNo.Enter += new EventHandler(OnControlEnter);
            this.txtIndoorNo.Leave += new EventHandler(OnControlLeave);


            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.tsbDelete.Click += new EventHandler(this.OnDeletePatientTreatmentDetailsClick);
            this.dgvData.DoubleClick += new EventHandler(this.OnCellDoubleClick);

            this.dgvData.DoubleClick += new EventHandler(this.OnCellDoubleClick);
            btnDelete.Visible = false;
        }

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            CheckPermission();
            txtDiatAdvice.Select();
            Patients patients = new Patients(true);
            if (patients != null)
            {
                this.cmbPatientName.DataSource = patients;
                this.cmbPatientName.DisplayMember = "DisplayName";
            }

            if (this.mIPDPatientTreatmentSheet.Patient != null)
            {
                this.cmbPatientName.SelectedItem = this.mIPDPatientTreatmentSheet.Patient as Patient;
                this.txtIPDNo.Text = this.mIPDPatientTreatmentSheet.Patient.Number.ToString();
                this.txtDrIncharge.Text = this.mIPDPatientTreatmentSheet.Patient.PatientDoctorIncharge;
                this.txtDiagnosis.Text = this.mIPDPatientTreatmentSheet.Patient.PatientProvisionalDiagnosis;
                this.txtIndoorNo.Text = this.mIPDPatientTreatmentSheet.Patient.PatientIndoorNo;
            }
            this.dtpTreatmentDate.Value = this.mIPDPatientTreatmentSheet.SheetDate == DateTime.MinValue ? DateTime.Now : this.mIPDPatientTreatmentSheet.SheetDate;
            this.txtSOSDrug.Text = this.mIPDPatientTreatmentSheet.SOSDrug;
            this.txtDiatAdvice.Text = this.mIPDPatientTreatmentSheet.DiatAdvice;
            this.txtSpecialAdvice.Text = this.mIPDPatientTreatmentSheet.SpecialAdvice;

           
            

            LoadAllIPDTreatmenSheetDetail(GetSelectedTreatmentSheetDetails(this.dgvData));

            if (isPatientTreatmentSheetDetailsEdit)
            {
                this.txtDescription.Text = mEntry.Description;
                this.cmbMorningTime.SelectedItem = mEntry.MorningTime;
                this.cmbNoonTime.SelectedItem = mEntry.NoonTime;
                this.cmbEveningTime.SelectedItem = mEntry.EveningTime;
                this.cmbNightTime.SelectedItem = mEntry.NightTime;
            }
            else
            {
                this.txtDescription.Text = string.Empty;
                this.cmbMorningTime.SelectedItem = this.cmbNoonTime.SelectedItem = this.cmbEveningTime.SelectedItem = this.cmbNightTime.SelectedItem = null;
            }
        }

        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mIPDPatientTreatmentSheet))
            {
                //if (counter == 0)
                //{
                    this.mIPDPatientTreatmentSheet.Patient = cmbPatientName.SelectedItem as Patient;
                    this.mIPDPatientTreatmentSheet.SheetDate = dtpTreatmentDate.Value;
                    this.mIPDPatientTreatmentSheet.DiatAdvice = txtDiatAdvice.Text.Trim();
                    this.mIPDPatientTreatmentSheet.SOSDrug = txtSOSDrug.Text.Trim();
                    this.mIPDPatientTreatmentSheet.SpecialAdvice = txtSpecialAdvice.Text.Trim();

                    this.mIPDPatientTreatmentSheet.Patient.PatientIndoorNo = txtIndoorNo.Text.Trim();
                    counter = 1;
                //}

                if (!string.IsNullOrEmpty(txtDescription.Text) || cmbMorningTime.SelectedItem != null || cmbNoonTime.SelectedItem != null || cmbEveningTime.SelectedItem != null|| cmbNightTime.SelectedItem != null)
                {
                    this.mEntry.Description = txtDescription.Text.Trim();
                    if (cmbMorningTime.SelectedItem != null)
                    this.mEntry.MorningTime = cmbMorningTime.SelectedItem.ToString();
                    if (cmbNoonTime.SelectedItem != null)
                        this.mEntry.NoonTime = cmbNoonTime.SelectedItem.ToString();
                    if (this.cmbEveningTime.SelectedItem != null)
                        this.mEntry.EveningTime = cmbEveningTime.SelectedItem.ToString();
                    if (this.cmbNightTime.SelectedItem != null)
                        this.mEntry.NightTime = cmbNightTime.SelectedItem.ToString();
                    this.mEntry.Patient = cmbPatientName.SelectedItem as Patient;
                    this.mIPDPatientTreatmentSheet.IPDPatientTreatmentSheetDetails = this.mEntry;
                }
            }
        }

        #endregion

        #region onSaveComplete

        protected override void OnSaveComplete()
        {
            base.OnSaveComplete();
            this.mEntry = new IPDPatientTreatmentSheetDetails();

            IPDPatientTreatmentSheetDetails obj = this.GetSelectedTreatmentSheetDetails(this.dgvData);
            this.LoadAllIPDTreatmenSheetDetail(obj);
            this.txtDescription.Focus();
            ClearAllControls();
        }

        #endregion

        #region oncelldoubleclick

        private void OnCellDoubleClick(object sender, EventArgs e)
        {
            this.tsbOpen.PerformClick();
        }

        #endregion

        #region onOpenclick

        private void OnOpenClick(object sender, EventArgs e)
        {
            IPDPatientTreatmentSheetDetails obj = this.GetSelectedTreatmentSheetDetails(this.dgvData);
            if (obj != null)
                obj.RefershData();
            isPatientTreatmentSheetDetailsEdit = true;
            if (obj != null)
            {
                this.mEntry = obj;
                this.txtDescription.Text = obj.Description;
                this.cmbMorningTime.SelectedItem = obj.MorningTime;
                this.cmbNoonTime.SelectedItem = obj.NoonTime;
                this.cmbEveningTime.SelectedItem = obj.EveningTime;
                this.cmbNightTime.SelectedItem = obj.NightTime;
            }
        }

        #endregion

        #region loadpatientprocedure

        private IPDPatientTreatmentSheetDetails GetSelectedTreatmentSheetDetails(DataGridView dgv)
        {
            IPDPatientTreatmentSheetDetails obj = null;
            if (dgv != null && dgv.CurrentRow != null)
                obj = dgv.CurrentRow.Tag as IPDPatientTreatmentSheetDetails;
            return obj;
        }

        private void LoadAllIPDTreatmenSheetDetail(IPDPatientTreatmentSheetDetails selected)
        {
            int count = 0;

            this.LoadEntityList<IPDPatientTreatmentSheetDetails>(this.dgvData, clmSrNo.Index, new IPDPatientTreatmentSheetDetailsCollection(this.mIPDPatientTreatmentSheet.ObjectGuid), selected, false, false,
                delegate(DataGridViewRow row, IPDPatientTreatmentSheetDetails obj)
                {
                    count++;
                    row.Cells[this.clmSrNo.Index].Value = obj.SrNo;
                    row.Cells[this.clmDescription.Index].Value = obj.Description;
                    row.Cells[this.clmMorningTime.Index].Value = obj.MorningTime;
                    row.Cells[this.clmNoonTime.Index].Value = obj.NoonTime;
                    row.Cells[this.clmEveningTime.Index].Value = obj.EveningTime;
                    row.Cells[this.clmNightTime.Index].Value = obj.NightTime;
                }
            );
        }

        #endregion

        #region showform

        public static bool ShowForm(IPDPatientTreatmentSheet obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (IPDPatientTreatmentSheetForm frm = new IPDPatientTreatmentSheetForm(obj))
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

        #region Delete treatmentdetaisl

        private void OnDeletePatientTreatmentDetailsClick(object sender, EventArgs e)
        {
            IPDPatientTreatmentSheetDetails obj = this.GetSelectedTreatmentSheetDetails(this.dgvData);
            if (obj != null && MessageBox.Show(this, "Are you sure to delete selected treatment details?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.mEntry = obj;
                this.mEntry.MarkToDelete();
                this.mEntry.UpdateChanges();
                ClearAllControls();
                this.mEntry = new IPDPatientTreatmentSheetDetails();
                this.txtDescription.Focus();
            }
            LoadAllIPDTreatmenSheetDetail(GetSelectedTreatmentSheetDetails(this.dgvData));
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
                    if (e.DisplayName == "IPDPatient Treatment Sheet")
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

        #region other

        private void ClearAllControls()
        {
            this.cmbMorningTime.SelectedItem = this.cmbNoonTime.SelectedItem = this.cmbEveningTime.SelectedItem = this.cmbNightTime.SelectedItem = null;
            this.txtDescription.Text = string.Empty;
        }

        private void cmbPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guid patientGuid = new Guid(cmbPatientName.SelectedItem.ToString());
            Patient obj = new Patient(patientGuid);
            if (obj != null)
            {
                txtIPDNo.Text = obj.Number.ToString();
                txtDrIncharge.Text = obj.PatientDoctorIncharge;
                txtDiagnosis.Text = obj.PatientProvisionalDiagnosis;
                txtIndoorNo.Text = obj.PatientIndoorNo;
            }

        }

        #endregion

    }
}
