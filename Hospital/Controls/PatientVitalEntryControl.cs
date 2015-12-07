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
    public partial class PatientVitalEntryControl : ObjectListControl
    {
        public PatientVitalEntryControl() : base()
        {
            InitializeComponent();

            this.tstSearch.TextBox.Enter += new EventHandler(this.OnControlEnter);
            this.tstSearch.TextBox.Leave += new EventHandler(this.OnControlLeave);

            this.tstSearch.KeyDown += new KeyEventHandler(this.OnSearchKeyDown);
            this.dgvData.KeyDown += new KeyEventHandler(this.OnGridKeyDown);

            this.tsbAdd.Click += new EventHandler(this.OnAddClick);
            this.tsbClose.Click += new EventHandler(this.OnCloseClick);
            this.tsbSearch.Click += new EventHandler(this.OnSearchClick);
            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);

            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);
            //this.dgvData.CellContentClick += new DataGridViewCellEventHandler(this.CellContentClick);
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            PatientVital obj = new PatientVital();
            if (PatientVitalForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void LoadListData(PatientVital selected)
        {
            int count = 0;
            DateTime fromDate = dtpDateFrom.Checked == true ? dtpDateFrom.Value : DateTime.MinValue;
            DateTime toDate = dtpDateTo.Checked == true ? dtpDateTo.Value : DateTime.MaxValue;

            this.LoadEntityList<PatientVital>(this.dgvData, this.clmPatientName.Index, new PatientVitalCollection(tstSearch.Text,fromDate,toDate), selected,
                delegate(DataGridViewRow row, PatientVital obj)
                {
                    count++;
                    row.Cells[this.clmPatientName.Index].Value = obj.DisplayName;
                    row.Cells[this.clmDate.Index].Value = Common.DateToString(obj.Date);
                    row.Cells[this.clmTime.Index].Value = obj.Time;

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
                if (e.DisplayName == "Patient Vital Details")
                {
                    this.tsbAdd.Enabled = AppContext.CanCreate(e.ObjectGuid);
                }
            }
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private PatientVital GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as PatientVital;
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            this.SendCloseTabRequest();
        }

        private void OnSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null && e.KeyCode == Keys.Enter)
            {
                this.tsbSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
       
        private void OnSearchClick(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelected());
        }

        private PatientVital GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as PatientVital;
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            PatientVital obj = this.GetSelected();

            if (obj != null)
                obj.RefershData();
            if (PatientVitalForm.ShowForm(obj))
            {
                this.LoadListData(obj);
            }
            this.LoadListData(obj);
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

        private void tspReport_Click(object sender, EventArgs e)
        {
           //OPDPatientAppointmentReport obj = new OPDPatientAppointmentReport();
           IPDPatientTreamentDetailsReport obj = new IPDPatientTreamentDetailsReport();
           obj.Show();
        }

        
    }
}
