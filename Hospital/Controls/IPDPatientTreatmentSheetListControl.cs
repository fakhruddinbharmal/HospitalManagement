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
    public partial class IPDPatientTreatmentSheetListControl : ObjectListControl
    {
        public IPDPatientTreatmentSheetListControl()
            : base()
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

            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);
            this.dgvData.CellContentClick += new DataGridViewCellEventHandler(this.CellContentClick);
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private IPDPatientTreatmentSheet GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as IPDPatientTreatmentSheet;
        }

        private void LoadListData(IPDPatientTreatmentSheet selected)
        {
            int count = 0;
            DateTime fromDate = dtpDateFrom.Checked == true ? dtpDateFrom.Value : DateTime.MinValue;
            DateTime toDate = dtpDateTo.Checked == true ? dtpDateTo.Value : DateTime.MaxValue;
            this.LoadEntityList<IPDPatientTreatmentSheet>(this.dgvData, this.clmPatientName.Index, new IPDPatientTreatmentSheetCollection(tstSearch.Text, fromDate, toDate), selected,
                delegate(DataGridViewRow row, IPDPatientTreatmentSheet obj)
                {
                    count++;
                    row.Cells[this.clmPatientName.Index].Value = obj.Patient.FirstName + " " + obj.Patient.LastName;
                    row.Cells[this.clmTreatmentDate.Index].Value = Common.DateToString(obj.SheetDate);
                    row.Cells[this.clmDiatAdvice.Index].Value = obj.DiatAdvice;
                    row.Cells[this.clmSOSDrug.Index].Value = obj.SOSDrug;
                    row.Cells[this.clmSpecialAdvice.Index].Value = obj.SpecialAdvice;
                    row.Cells[this.clmIPDNo.Index].Value = obj.Patient.Number;
                    row.Cells[this.clmPatientGuid.Index].Value = obj.PatientGuid;
                    row.Cells[this.clmTreatmentSheetGuid.Index].Value = obj.ObjectGuid;
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
                if (e.DisplayName == "IPDPatient Treatment Sheet")
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
            IPDPatientTreatmentSheet obj = new IPDPatientTreatmentSheet();
             IPDPatientTreatmentSheetForm.ShowForm(obj);
            this.LoadListData(obj);
        }

        private IPDPatientTreatmentSheet GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as IPDPatientTreatmentSheet;
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            IPDPatientTreatmentSheet obj = this.GetSelected();

            if (obj != null)
                obj.RefershData();
            if (IPDPatientTreatmentSheetForm.ShowForm(obj))
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

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(DataGridViewImageColumn))
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvData.Rows[rowIndex];
                IPDPatientTreamentDetailsReport ipdPatientTreatMentSheetReport = new IPDPatientTreamentDetailsReport();
                ipdPatientTreatMentSheetReport.PatientGuid = (Guid)(row.Cells[6].Value);
                ipdPatientTreatMentSheetReport.IPDPatientTreatmentSheetGuid = (Guid)(row.Cells[7].Value);
                ipdPatientTreatMentSheetReport.Show();
            }

        }
    }
}
