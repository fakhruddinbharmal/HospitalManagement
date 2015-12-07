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
    public partial class MedicinePurchaseListControl : Hospital.Controls.ObjectListControl
    {
        public MedicinePurchaseListControl()
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

        private void LoadListData(MedicinePurchase selected)
        {
            int count = 0;
            this.LoadEntityList<MedicinePurchase>(this.dgvData, this.clmCategory.Index, new MedicinePurchaseCollection(tstSearch.Text), selected,
                delegate(DataGridViewRow row, MedicinePurchase obj)
                {
                    count++;
                    row.Cells[this.clmCategory.Index].Value = obj.CategoryName;
                    row.Cells[this.clmItem.Index].Value = obj.ItemName;
                    row.Cells[this.clmQuantity.Index].Value = obj.Quantity;
                    row.Cells[this.clmWholesaleRate.Index].Value = obj.WholesaleRate;
                    row.Cells[this.clmAmount.Index].Value = obj.Amount;
                    row.Cells[this.clmExpiryDate.Index].Value = Common.DateToString(obj.ExpiryDate);
                    row.Cells[this.clmMRP.Index].Value = obj.MRP;
                }
            );
            bool hasRows = count > 0;
            this.tsbOpen.Enabled = hasRows;
        }

        private MedicinePurchase GetSelected()
        {
            return GetSelectedEntity(this.dgvData) as MedicinePurchase;
        }

        private void OnOpenClick(object sender, EventArgs e)
        {
            MedicinePurchase obj = this.GetSelected();
            if (obj != null)
                obj.RefershData();

            if (MedicinePurchaseForm.ShowForm(obj))
                this.LoadListData(obj);
        }

        private void OnAddClick(object sender, EventArgs e)
        {
            MedicinePurchase obj = new MedicinePurchase();
            if (MedicinePurchaseForm.ShowForm(obj))
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

        private MedicinePurchase GetSelectedEntityObject()
        {
            return GetSelectedEntity(this.dgvData) as MedicinePurchase;
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
