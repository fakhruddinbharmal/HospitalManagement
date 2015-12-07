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
    public partial class PatientMedicineSaleForm : ObjectbaseForm
    {
        private PatientBill mPatientBill;

        private PatientMedicineSaleCollection mPatientMedicineSaleCollections;

        private PatientMedicineSale mEntry;

        private static int counter = 0;

        private static decimal availableStock = 0;
        private static bool isPatientMedicineSaleEdit = false;

        public PatientMedicineSaleForm(PatientBill obj)
            : base(obj, false)
        {
            this.mPatientBill = obj;
            this.mPatientMedicineSaleCollections = new PatientMedicineSaleCollection(obj.ObjectGuid);
            this.mEntry = new PatientMedicineSale();
            counter = 0;
            this.InitializeComponent();
            this.UserInitialize();
        }

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

            this.cmbCategory.Tag = this.lblCategory;
            this.lblCategory.Click += new EventHandler(OnLabelClick);
            this.cmbCategory.Enter += new EventHandler(OnControlEnter);
            this.cmbCategory.Leave += new EventHandler(OnControlLeave);

            this.cmbCompany.Tag = this.lblCompany;
            this.lblCompany.Click += new EventHandler(OnLabelClick);
            this.cmbCompany.Enter += new EventHandler(OnControlEnter);
            this.cmbCompany.Leave += new EventHandler(OnControlLeave);

            this.cmbItem.Tag = this.lblItem;
            this.lblItem.Click += new EventHandler(OnLabelClick);
            this.cmbItem.Enter += new EventHandler(OnControlEnter);
            this.cmbItem.Leave += new EventHandler(OnControlLeave);

            this.nupQuantity.Tag = this.lblQuantity;
            this.lblQuantity.Click += new EventHandler(OnLabelClick);
            this.nupQuantity.Enter += new EventHandler(OnControlEnter);
            this.nupQuantity.Leave += new EventHandler(OnControlLeave);

            this.nupAmount.Tag = this.lblAmount;
            this.lblAmount.Click += new EventHandler(OnLabelClick);
            this.nupAmount.Enter += new EventHandler(OnControlEnter);
            this.nupAmount.Leave += new EventHandler(OnControlLeave);

            this.txtNotes.Tag = this.lblNotes;
            this.lblNotes.Click += new EventHandler(OnLabelClick);
            this.txtNotes.Enter += new EventHandler(OnControlEnter);
            this.txtNotes.Leave += new EventHandler(OnControlLeave);

            this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
            this.tsbDelete.Click += new EventHandler(this.OnDeletePatientMedicineClick);
            this.dgvData.DoubleClick += new EventHandler(this.OnCellDoubleClick);
            
            //this.dgvData.DoubleClick += new EventHandler(this.OnCellDoubleClick);
            btnDelete.Visible = false;
        }

        #region OnDataShow

        protected override void OnDataShow()
        {
            base.OnDataShow();
            this.CheckPermission();

            this.Text = "Manage Patient Medicine";

            CategoryCollection categoryList = new CategoryCollection();
            this.cmbCategory.DataSource = categoryList;
            this.cmbCategory.DisplayMember = "DisplayName";

            CompanyCollection companyList = new CompanyCollection();
            this.cmbCompany.DataSource = companyList;
            this.cmbCompany.DisplayMember = "DisplayName";

            cmbPatientType.Select();
            if (this.mPatientBill.Patient != null)
            {
                if (this.mPatientBill.Patient.IsIPD)
                    this.cmbPatientType.SelectedItem = "I.P.D";
                else if (this.mPatientBill.Patient.IsOPD)
                    this.cmbPatientType.SelectedItem = "O.P.D";
                //else
                //    this.cmbPatientType.SelectedItem = "Other";
            }

            if (!string.IsNullOrEmpty(this.mPatientBill.Other))
            {
                this.cmbPatientType.SelectedItem = "Other";
                this.txtOtherPatientName.Text = this.mPatientBill.Other;
                lblOtherPatientName.Visible = txtOtherPatientName.Visible = true;
                cmbPatient.Visible = lblPatient.Visible = false;
            }

            this.cmbPatient.SelectedItem = this.mPatientBill.Patient != null ? this.mPatientBill.Patient as Patient : null;
            this.txtOtherPatientName.Text = this.mPatientBill.Other;
            this.dtpBillDate.Value = this.mPatientBill.PatientBillDate != DateTime.MinValue ? this.mPatientBill.PatientBillDate : DateTime.Now.Date;
            LoadPatientAllMedicine(GetSelectedProcedure(this.dgvData));

            if (isPatientMedicineSaleEdit)
            {
                this.cmbCategory.SelectedItem = mEntry.Category;
                this.cmbCompany.SelectedItem = mEntry.Company;
                this.cmbItem.SelectedItem = mEntry.Item;
                this.nupQuantity.Value = mEntry.Quantity;
                this.nupAmount.Value = mEntry.Amount;
                this.txtNotes.Text = mEntry.Note;
            }
            else
            {
                this.cmbCategory.SelectedItem = this.cmbCompany.SelectedItem = this.cmbItem.SelectedItem = null;
            }
        }

        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mPatientBill))
            {
                if (counter == 0)
                {
                    this.mPatientBill.Patient = cmbPatient.SelectedItem as Patient;
                    this.mPatientBill.Other = txtOtherPatientName.Text.Trim();
                    this.mPatientBill.PatientBillDate = dtpBillDate.Value;
                    counter = 1;
                }

                if (this.cmbCategory.SelectedItem != null)
                {
                    this.mEntry.Category = this.cmbCategory.SelectedItem as Category;
                    this.mEntry.Company = this.cmbCompany.SelectedItem as Company;
                    this.mEntry.Item = this.cmbItem.SelectedItem as Item;
                    this.mEntry.Quantity = this.nupQuantity.Value;
                    this.mEntry.Amount = nupAmount.Value;
                    this.mEntry.Note = txtNotes.Text;
                    this.mPatientBill.PatientMedicineSale = this.mEntry;
                }
            }
        }

        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;

            if (this.cmbPatientType.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbPatientType, "Patient type", "Patient type is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbPatientType.Select();
                r = false;
            }

            if (this.nupQuantity.Value > availableStock)
            {
                this.ShowTooltip(this.nupQuantity, "Quantity", "Quantity should not be more than available", ContentAlignment.TopLeft);
                if (r)
                    this.nupQuantity.Select();
                r = false;
            }
            return r && base.OnDataValidation();
        }
        #endregion

        #region onSaveComplete

        protected override void OnSaveComplete()
        {
            base.OnSaveComplete();
            this.mEntry = new PatientMedicineSale();

            PatientMedicineSale obj = this.GetSelectedProcedure(this.dgvData);
            //PatientMedicineSaleForm.ShowForm(mPatientBill);
            this.LoadPatientAllMedicine(obj);
            this.cmbCategory.Focus();
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
            PatientMedicineSale obj = this.GetSelectedProcedure(this.dgvData);
            if (obj != null)
                obj.RefershData();
            isPatientMedicineSaleEdit = true;
            if (obj != null)
            {
                this.mEntry = obj;
                this.cmbCategory.SelectedItem = obj.Category;
                this.cmbCompany.SelectedItem = obj.Company;
                this.cmbItem.SelectedItem = obj.Item;
                this.nupQuantity.Value = obj.Quantity;
                this.nupAmount.Value = obj.Amount;
                this.txtNotes.Text = obj.Note;
            }
        }

        #endregion

        #region loadpatientprocedure

        private PatientMedicineSale GetSelectedProcedure(DataGridView dgv)
        {
            PatientMedicineSale obj = null;
            if (dgv != null && dgv.CurrentRow != null)
                obj = dgv.CurrentRow.Tag as PatientMedicineSale;
            return obj;
        }

        private void LoadPatientAllMedicine(PatientMedicineSale selected)
        {
            int count = 0;
            decimal totalAmount = 0;
            decimal balanceToCollect = 0;

            this.LoadEntityList<PatientMedicineSale>(this.dgvData, clmSrNo.Index, new PatientMedicineSaleCollection(this.mPatientBill.ObjectGuid), selected, false, false,
                delegate(DataGridViewRow row, PatientMedicineSale obj)
                {
                    count++;
                    row.Cells[this.clmSrNo.Index].Value = obj.SrNo;
                    row.Cells[this.clmMedicine.Index].Value = obj.CategoryName + " " + obj.CompanyName + " " + obj.ItemName;
                    row.Cells[this.clmQuantity.Index].Value = obj.Quantity;
                    row.Cells[this.clmAmount.Index].Value = obj.Amount;
                    row.Cells[this.clmNotes.Index].Value = obj.Note;
                    totalAmount = totalAmount + obj.Amount;
                }
            );
            balanceToCollect = totalAmount;
            lblTotalAmountValue.Text = totalAmount.ToString();
            lblBalanceToCollectValue.Text = balanceToCollect.ToString();
        }

        #endregion

        #region showform

        public static bool ShowForm(PatientBill obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (PatientMedicineSaleForm frm = new PatientMedicineSaleForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }

        #endregion

        #region Delete patientmedicinesale

        private void OnDeletePatientMedicineClick(object sender, EventArgs e)
        {
            PatientMedicineSale obj = this.GetSelectedProcedure(this.dgvData);
            if (obj != null && MessageBox.Show(this, "Are you sure to delete selected patient medicine?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.mEntry = obj;
                this.mEntry.MarkToDelete();
                this.mEntry.UpdateChanges();
                ClearAllControls();
                this.mEntry = new PatientMedicineSale();
                this.cmbCategory.Focus();
            }
            LoadPatientAllMedicine(GetSelectedProcedure(this.dgvData));
        }

        #endregion

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nupAmount.Value = 0;
            if (cmbCompany.SelectedItem != null)
            {
                Guid companyGuid = new Guid(cmbCompany.SelectedItem.ToString());
                Guid categoryGuid = new Guid(cmbCategory.SelectedItem.ToString());
                ItemCollection itemList = new ItemCollection(companyGuid,categoryGuid);
                this.cmbItem.DataSource = itemList;
                this.cmbItem.DisplayMember = "DisplayName";
            }

            if (cmbCategory.SelectedItem != null && cmbCompany.SelectedItem != null && cmbItem.SelectedItem != null)
            {
                availableStock = 0;
                Medicines m = new Medicines();
                availableStock = m.GetMaxQuantityAvailable(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                lblAvailableQuantity.Text = "Max Available (" + availableStock.ToString() + " )";
                lblAvailableQuantity.Visible = true;

                MedicineSale MSale = new MedicineSale();
                decimal mrp = MSale.GetMRP(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                decimal amount = mrp * (this.nupQuantity.Value);
                this.nupAmount.Value = amount;
            }
        }

        private void nupQuantity_Leave(object sender, EventArgs e)
        {
            
            this.nupAmount.Value = 0;
            this.nupQuantity.Value = 0;
            if (cmbCategory.SelectedItem != null && cmbCompany.SelectedItem != null && cmbItem.SelectedItem != null)
            {
               
                MedicineSale MSale = new MedicineSale();
                decimal mrp = MSale.GetMRP(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                decimal amount = mrp * (this.nupQuantity.Value);
                this.nupAmount.Value = amount;
            }
        }

        private void ClearAllControls()
        {
            this.cmbCategory.SelectedItem = this.cmbCompany.SelectedItem = this.cmbItem.SelectedItem = null;
            this.nupAmount.ResetText();
            this.nupQuantity.Value = 0;
            this.txtNotes.Text = string.Empty;
            this.lblAvailableQuantity.Visible = false;
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            PatientInvoice p = new PatientInvoice();
            p.PatientMedicineBillGuid = mPatientBill.ObjectGuid;
            p.PatientName = mPatientBill.Patient == null ? mPatientBill.Other : mPatientBill.Patient.DisplayName;
            if (mPatientBill.Patient != null)
            {
                p.PatientGuid = mPatientBill.PatientGuid;
            }
            p.Show();
        }

        private void cmbPatientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOtherPatientName.Visible = lblOtherPatientName.Visible = false;
            lblPatient.Visible = cmbPatient.Visible = true;
            cmbPatient.DataSource = null;

            if (cmbPatientType.SelectedItem != null && cmbPatientType.SelectedItem != "Other")
            {
                bool isIPD = false;
                if (cmbPatientType.SelectedItem == "I.P.D")
                {
                    isIPD = true;
                }
                Patients patients = new Patients(isIPD);
                if (patients != null)
                {
                    this.cmbPatient.DataSource = patients;
                    this.cmbPatient.DisplayMember = "DisplayName";
                }
            }
            else if (cmbPatientType.SelectedItem == "Other")
            {
                lblOtherPatientName.Visible = txtOtherPatientName.Visible = true;
                cmbPatient.Visible = lblPatient.Visible = false;
            }
        }
        
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

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nupAmount.Value = 0;
            if (cmbCategory.SelectedItem != null && cmbCompany.SelectedItem != null && cmbItem.SelectedItem != null)
            {
                availableStock = 0;
                Medicines m = new Medicines();
                availableStock = m.GetMaxQuantityAvailable(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                lblAvailableQuantity.Text = "Max Available (" + availableStock.ToString() + " )";
                lblAvailableQuantity.Visible = true;

                MedicineSale MSale = new MedicineSale();
                decimal mrp = MSale.GetMRP(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                decimal amount = mrp * (this.nupQuantity.Value);
                this.nupAmount.Value = amount;
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nupAmount.Value = 0;
            if (cmbCategory.SelectedItem != null && cmbCompany.SelectedItem != null && cmbItem.SelectedItem != null)
            {
                availableStock = 0;
                Medicines m = new Medicines();
                availableStock = m.GetMaxQuantityAvailable(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                lblAvailableQuantity.Text = "Max Available (" + availableStock.ToString() + " )";
                lblAvailableQuantity.Visible = true;

                MedicineSale MSale = new MedicineSale();
                decimal mrp = MSale.GetMRP(cmbCategory.SelectedItem as Category, cmbCompany.SelectedItem as Company, cmbItem.SelectedItem as Item);
                decimal amount = mrp * (this.nupQuantity.Value);
                this.nupAmount.Value = amount;
            }
        }
    }
}
