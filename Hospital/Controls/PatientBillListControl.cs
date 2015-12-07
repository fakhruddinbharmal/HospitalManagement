using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Hospital.Object;
namespace Hospital.Controls
{
    public partial class PatientBillListControl : ObjectListControl
    {
        public PatientBillListControl() : base()
        {
            InitializeComponent();
            this.tspToolbar.Font = Common.ApplicationFont;

            this.FormatGrid(this.dgvData);

            this.tstSearch.TextBox.Enter += new EventHandler(this.OnControlEnter);
            this.tstSearch.TextBox.Leave += new EventHandler(this.OnControlLeave);

            this.tstSearch.KeyDown += new KeyEventHandler(this.OnSearchKeyDown);
            this.dgvData.KeyDown += new KeyEventHandler(this.OnGridKeyDown);

            this.tsbAdd.Click += new EventHandler(this.OnAddClick);
            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.tsbSearch.Click += new EventHandler(this.OnSearchClick);
            this.tsbClose.Click += new EventHandler(this.OnCloseClick);

            this.tsbPatientMedicin.Click += new EventHandler(OnpatientProcedureClick);
            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);
            this.dgvData.CellContentClick += new DataGridViewCellEventHandler(this.CellContentClick);
        }

        private void OnpatientProcedureClick(object sender, EventArgs e)
        {
            PatientBill obj = this.GetSelected();
            PatientMedicineSaleForm.ShowForm(obj);
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private PatientBill GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as PatientBill;
        }

        private void LoadListData(PatientBill selected)
        {
            int count = 0;

            this.LoadEntityList<PatientBill>(this.dgvData, this.clmPatientName.Index, new PatientBillCollection(tstSearch.Text), selected,
                delegate(DataGridViewRow row, PatientBill obj)
                {
                    count++;
                    row.Cells[this.clmPatientName.Index].Value = obj.Patient != null ? obj.Patient.FirstName + obj.Patient.LastName : obj.Other;
                    row.Cells[this.clmBillDate.Index].Value = Common.DateToString(obj.PatientBillDate);
                    row.Cells[this.clmAdmitedDate.Index].Value = obj.Patient != null && obj.Patient.AdmittedDate != DateTime.MinValue ? Common.DateToString(obj.Patient.AdmittedDate) : string.Empty;
                    row.Cells[this.clmAge.Index].Value = obj.Patient != null && obj.Patient.Age >0 ? obj.Patient.Age.ToString(): string.Empty;
                    row.Cells[this.clmAddress.Index].Value = obj.Patient != null ? obj.Patient.Address : string.Empty;
                    row.Cells[this.clmIPDNo.Index].Value = obj.IPDNo;
                    row.Cells[this.clmOPDNo.Index].Value = obj.OPDNo;
                    row.Cells[this.clmBillGuid.Index].Value = obj.ObjectGuid;
                    row.Cells[this.clmPatientGuid.Index].Value = obj.Patient != null ? obj.Patient.ObjectGuid:Guid.Empty;
                }
            );
            bool hasRows = count > 0;
            this.tsbOpen.Enabled = hasRows;
        }

        protected override void LoadListData()
        {
            EntityCollection ent = AppContext.UserRoleEntities;
            foreach (Entity e in ent)
            {
                if (e.DisplayName == "Patient Medicin Sales")
                {
                    this.tsbAdd.Enabled = AppContext.CanCreate(e.ObjectGuid);
                }
            }
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private void OnSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null && e.KeyCode == Keys.Enter)
            {
                this.tsbSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void OnGridKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.tsbOpen.PerformClick();
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
                {
                    this.tsbAdd.PerformClick();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            PatientBill obj = new PatientBill();
            PatientMedicineSaleForm.ShowForm(obj);
            this.LoadListData(obj);
        }

        private PatientBill GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as PatientBill;
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            PatientBill obj = this.GetSelected();

            if (obj != null)
                obj.RefershData();
            if (PatientMedicineSaleForm.ShowForm(obj))
            {
                this.LoadListData(obj);
            }
            this.LoadListData(obj);
        }

        private void OnSearchClick(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelected());
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void cmbPatientStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(DataGridViewImageColumn))
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvData.Rows[rowIndex];
                PatientInvoice p = new PatientInvoice();
                p.PatientMedicineBillGuid = (Guid)(row.Cells[8].Value);
                p.PatientGuid = (Guid)(row.Cells[7].Value);
                p.PatientName = row.Cells[0].Value.ToString();
                p.Show();

            }

        }
    }
}
