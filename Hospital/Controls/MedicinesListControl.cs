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
    public partial class MedicinesListControl : Hospital.Controls.ObjectListControl
    {
        public MedicinesListControl()
            : base()
        {
            InitializeComponent();
            this.tspToolbar.Font = Common.ApplicationFont;

            this.FormatGrid(this.dgvData);
            this.dgvData.CellDoubleClick += new DataGridViewCellEventHandler(this.OnCellDoubleClick);

            this.tstSearch.TextBox.Enter += new EventHandler(this.OnControlEnter);
            this.tstSearch.TextBox.Leave += new EventHandler(this.OnControlLeave);

            this.tstSearch.KeyDown += new KeyEventHandler(this.OnSearchKeyDown);
            this.dgvData.KeyDown += new KeyEventHandler(this.OnGridKeyDown);

            this.tsbAdd.Click += new EventHandler(this.OnAddClick);
            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.tsbSearch.Click += new EventHandler(this.OnSearchClick);
            this.tsbClose.Click += new EventHandler(this.OnCloseClick);
        }

        private void LoadListData(Medicines selected)
        {
            int count = 0;
            this.LoadEntityList<Medicines>(this.dgvData, this.clmCategory.Index, new MedicinesCollection(tstSearch.Text), selected,
                delegate(DataGridViewRow row, Medicines obj)
                {
                    count++;
                    row.Cells[this.clmCategory.Index].Value = obj.CategoryName;
                    row.Cells[this.clmCompany.Index].Value = obj.CompanyName;
                    row.Cells[this.clmItem.Index].Value = obj.ItemName;
                    row.Cells[this.clmStock.Index].Value = obj.CurrentStock;
                    row.Cells[this.clmReOrderLevel.Index].Value = obj.ReOrderLevel;
                }
            );
            bool hasRows = count > 0;
            this.tsbOpen.Enabled = hasRows;
        }

        private Medicines GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as Medicines;
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            Medicines obj = this.GetSelected();
            if (obj != null)
                obj.RefershData();

            if (MedicinesForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            Medicines obj = new Medicines();
            if (MedicinesForm.ShowForm(obj))
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

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            this.LoadListData(this.GetSelectedEntityObject());
        }

        private Medicines GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as Medicines;
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
        }

        protected override void LoadListData()
        {
            EntityCollection ent = AppContext.UserRoleEntities;
            foreach (Entity e in ent)
            {
                if (e.DisplayName == "Medicine")
                {
                    this.tsbAdd.Enabled = AppContext.CanCreate(e.ObjectGuid);
                }
            }
            this.LoadListData(this.GetSelectedEntityObject());
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

        private void OnSearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e != null && e.KeyCode == Keys.Enter)
            {
                this.tsbSearch.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void OnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
                this.tsbOpen.PerformClick();
        }

    }
}
