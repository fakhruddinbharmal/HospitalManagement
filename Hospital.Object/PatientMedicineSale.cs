using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class PatientMedicineSale : Objectbase
    {
        internal struct Columns
        {
            public const string PatientMedicineSaleId = "PatientMedicineSaleId";
            public const string PatientMedicineSaleGuid = "PatientMedicineSaleGuid";
            public const string PatientMedicineSalePatientBillGuid = "PatientMedicineSalePatientBillGuid";
            public const string PatientMedicineSaleCategoryGuid = "PatientMedicineSaleCategoryGuid";
            public const string PatientMedicineSaleCompanyGuid = "PatientMedicineSaleCompanyGuid";
            public const string PatientMedicineSaleItemGuid = "PatientMedicineSaleItemGuid";
            public const string PatientMedicineSaleQuantity = "PatientMedicineSaleQuantity";
            public const string PatientMedicineSaleAmount = "PatientMedicineSaleAmount";
            public const string PatientMedicineSaleNote = "PatientMedicineSaleNote";
            public const string PatientMedicineSaleDate = "PatientMedicineSaleDate";
            public const string SrNo = "SrNo";
        }

        #region Constructor

        public PatientMedicineSale() : base() { }

        public PatientMedicineSale(Guid key) : base(key) { }

        public PatientMedicineSale(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return string.Empty; }
        }

        private Guid mBillGuid;
        public Guid BillGuid
        {
            get { return this.mBillGuid; }
            set { this.mBillGuid = value; }
        }

        private PatientBill mPatientBill;
        public PatientBill PatientBill
        {
            get
            {
                if (IsNullOrEmpty(this.mPatientBill) || this.mPatientBill.ObjectGuid != this.mBillGuid)
                    this.mPatientBill = (this.mBillGuid != Guid.Empty ? new PatientBill(this.mBillGuid) : null);
                return this.mPatientBill;
            }

            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mBillGuid = Guid.Empty;
                    this.mPatientBill = null;
                }
                else
                {
                    this.mBillGuid = value.ObjectGuid;
                    this.mPatientBill = value;
                }
            }
        }

        private Guid mCategoryGuid;
        public Guid CategoryGuid
        {
            get { return this.mCompanyGuid; }
            set { this.mCompanyGuid = value; }
        }

        private Category mCategory;
        public Category Category
        {
            get
            {
                if (IsNullOrEmpty(this.mCategory) || this.mCategory.ObjectGuid != this.mCategoryGuid)
                    this.mCategory = (this.mCategoryGuid != Guid.Empty ? new Category(this.mCategoryGuid) : null);
                return this.mCategory;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mCategoryGuid = Guid.Empty;
                    this.mCategory = null;
                }
                else
                {
                    this.mCategoryGuid = value.ObjectGuid;
                    this.mCategory = value;
                }
            }
        }

        public string CategoryName
        {
            get
            {
                Category obj = this.Category;
                return IsNullOrEmpty(obj) ? string.Empty : obj.CategoryName;
            }
        }

        private Guid mCompanyGuid;
        public Guid CompanyGuid
        {
            get { return this.mCompanyGuid; }
            set { this.mCompanyGuid = value; }
        }

        private Company mCompany;
        public Company Company
        {
            get
            {
                if (IsNullOrEmpty(this.mCompany) || this.mCompany.ObjectGuid != this.mCompanyGuid)
                    this.mCompany = (this.mCompanyGuid != Guid.Empty ? new Company(this.mCompanyGuid) : null);
                return this.mCompany;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mCompanyGuid = Guid.Empty;
                    this.mCompany = null;
                }
                else
                {
                    this.mCompanyGuid = value.ObjectGuid;
                    this.mCompany = value;
                }
            }
        }

        public string CompanyName
        {
            get
            {
                Company obj = this.Company;
                return IsNullOrEmpty(obj) ? string.Empty : obj.CompanyName;
            }
        }

        private Guid mItemGuid;
        public Guid ItemGuid
        {
            get { return this.mItemGuid; }
            set { this.mItemGuid = value; }
        }

        private Item mItem;
        public Item Item
        {
            get
            {
                if (IsNullOrEmpty(this.mItem) || this.mItem.ObjectGuid != this.mItemGuid)
                    this.mItem = (this.mItemGuid != Guid.Empty ? new Item(this.mItemGuid) : null);
                return this.mItem;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mItemGuid = Guid.Empty;
                    this.mItem = null;
                }
                else
                {
                    this.mItemGuid = value.ObjectGuid;
                    this.mItem = value;
                }
            }
        }

        public string ItemName
        {
            get
            {
                Item obj = this.Item;
                return IsNullOrEmpty(obj) ? string.Empty : obj.ItemName;
            }
        }

        private decimal mQuantity;
        public decimal Quantity
        {
            get { return this.mQuantity; }
            set { this.mQuantity = value; }
        }


        private decimal mAmount;
        public decimal Amount
        {
            get { return this.mAmount; }
            set { this.mAmount = value; }
        }

        private string mNote;
        public string Note
        {
            get { return this.mNote; }
            set { this.mNote = value; }
        }

        private DateTime mSaleDate;
        public DateTime SaleDate
        {
            get { return this.mSaleDate; }
            set { this.mSaleDate = value; }
        }

        private string mSrNo;
        public string SrNo
        {
            get { return this.mSrNo; }
            set { this.mSrNo = value; }
        }
        #endregion

        #region Overiden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.PatientMedicineSaleGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.PatientMedicineSaleId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.PatientMedicineSaleGuid]);
                this.mBillGuid = AppShared.DbValueToGuid(dr[Columns.PatientMedicineSalePatientBillGuid]);
                this.mCategoryGuid = AppShared.DbValueToGuid(dr[Columns.PatientMedicineSaleCategoryGuid]);
                this.mCompanyGuid = AppShared.DbValueToGuid(dr[Columns.PatientMedicineSaleCompanyGuid]);
                this.mItemGuid = AppShared.DbValueToGuid(dr[Columns.PatientMedicineSaleItemGuid]);
                this.mQuantity = AppShared.DbValueToDecimal(dr[Columns.PatientMedicineSaleQuantity]);
                this.mAmount = AppShared.DbValueToDecimal(dr[Columns.PatientMedicineSaleAmount]);
                this.mNote = AppShared.DbValueToString(dr[Columns.PatientMedicineSaleNote]);
                if (AppShared.HasColumn(dr, "SrNo"))
                {
                    this.mSrNo = AppShared.DbValueToString(dr[Columns.SrNo].ToString());
                }
                this.Status = ObjectStatus.Opened;
                r = true;
            }
            else
            {
                this.Reset();
            }
            return r;

        }

        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.PatientMedicineSaleSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {

            bool r = AppDAL.PatientMedicineSaleInsert(this.mObjectGuid, this.mBillGuid, this.mCategoryGuid, this.mCompanyGuid, this.mItemGuid, this.mQuantity, this.mAmount, this.mNote);

            return r;

        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.PatientMedicineSaleUpdate(this.mObjectGuid, this.mBillGuid, this.mCategoryGuid, this.mCompanyGuid, this.mItemGuid, this.mQuantity, this.mAmount, this.mNote);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.PatientMedicineSaleDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();

        }
        #endregion

        public decimal GetMRP(Category category, Company company, Item item)
        {
            decimal mrp = AppDAL.MRPFromPurchase(category.ObjectGuid, company.ObjectGuid, item.ObjectGuid);
            return mrp;
        }
    }

    public sealed class PatientMedicineSaleCollection : ObjectCollection<PatientMedicineSale>
    {

        #region PatientMedicineSaleCollection
        public PatientMedicineSaleCollection(Guid billGuid)
        {
            using (SqlDataReader dr = AppDAL.PatientMedicineSaleSearchByBill(billGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
