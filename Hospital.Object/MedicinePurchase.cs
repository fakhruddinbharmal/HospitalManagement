using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class MedicinePurchase : Objectbase
    {
        internal struct Columns
        {
            public const string MedicinePurchaseId = "MedicinePurchaseId";
            public const string MedicinePurchaseGuid = "MedicinePurchaseGuid";
            public const string MedicinePurchaseCategoryGuid = "MedicinePurchaseCategoryGuid";
            public const string MedicinePurchaseCompanyGuid = "MedicinePurchaseCompanyGuid";
            public const string MedicinePurchaseItemGuid = "MedicinePurchaseItemGuid";
            public const string MedicinePurchaseBillType = "MedicinePurchaseBillType";
            public const string MedicinePurchaseQuantity = "MedicinePurchaseQuantity";
            public const string MedicinePurchaseWholesaleRate = "MedicinePurchaseWholesaleRate";
            public const string MedicinePurchaseAmount = "MedicinePurchaseAmount";
            public const string MedicinePurchaseExpiryDate = "MedicinePurchaseExpiryDate";
            public const string MedicinePurchaseMRP = "MedicinePurchaseMRP";
            public const string MedicinePurchaseDate = "MedicinePurchaseDate";

        }

        #region Constructor

        public MedicinePurchase() : base() { }

        public MedicinePurchase(Guid key) : base(key) { }

        public MedicinePurchase(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return string.Empty; }
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

        private string mBillType;
        public string BillType
        {
            get { return this.mBillType; }
            set { this.mBillType = value; }
        }

        private int mQuantity;
        public int Quantity
        {
            get { return this.mQuantity; }
            set { this.mQuantity = value; }
        }

        private decimal mWholesaleRate;
        public decimal WholesaleRate
        {
            get { return this.mWholesaleRate; }
            set { this.mWholesaleRate = value; }
        }

        private decimal mAmount;
        public decimal Amount
        {
            get { return this.mAmount; }
            set { this.mAmount = value; }
        }
        
        private DateTime mExpiryDate;
        public DateTime ExpiryDate
        {
            get { return this.mExpiryDate; }
            set { this.mExpiryDate = value; }
        }
        private decimal mMRP;
        public decimal MRP
        {
            get { return this.mMRP; }
            set { this.mMRP = value; }
        }

        private DateTime mPurchaseDate;
        public DateTime PurchaseDate
        {
            get { return this.mPurchaseDate; }
            set { this.mPurchaseDate = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.MedicinePurchaseGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.MedicinePurchaseId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.MedicinePurchaseGuid]);
                this.mCategoryGuid = AppShared.DbValueToGuid(dr[Columns.MedicinePurchaseCategoryGuid]);
                this.mCompanyGuid = AppShared.DbValueToGuid(dr[Columns.MedicinePurchaseCompanyGuid]);
                this.mItemGuid = AppShared.DbValueToGuid(dr[Columns.MedicinePurchaseItemGuid]);
                this.mBillType = AppShared.DbValueToString(dr[Columns.MedicinePurchaseBillType]);
                this.mQuantity= AppShared.DbValueToInteger(dr[Columns.MedicinePurchaseQuantity]);
                this.mWholesaleRate= AppShared.DbValueToDecimal(dr[Columns.MedicinePurchaseWholesaleRate]);
                this.mAmount = AppShared.DbValueToDecimal(dr[Columns.MedicinePurchaseAmount]);
                this.mExpiryDate= AppShared.DbValueToDateTime(dr[Columns.MedicinePurchaseExpiryDate]);
                this.mMRP = AppShared.DbValueToDecimal(dr[Columns.MedicinePurchaseMRP]);
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
            using (SqlDataReader dr = AppDAL.MedicinePurchaseSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {

            bool r = AppDAL.MedicinePurchaseInsert(this.mObjectGuid, this.mCategoryGuid, this.mCompanyGuid, this.mItemGuid, this.mBillType, this.mQuantity, this.mWholesaleRate, this.mAmount, this.mExpiryDate, this.mMRP);

            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.MedicinePurchaseUpdate(this.mObjectGuid, this.mCategoryGuid, this.mCompanyGuid, this.mItemGuid, this.mBillType, this.mQuantity, this.mWholesaleRate, this.mAmount, this.mExpiryDate, this.mMRP);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.MedicinePurchaseDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
           
        }
        #endregion

    }

    public sealed class MedicinePurchaseCollection : ObjectCollection<MedicinePurchase>
    {

        #region MedicinePurchaseCollection
        public MedicinePurchaseCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.MedicinePurchaseSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region MedicinePurchaseCollection

        public MedicinePurchaseCollection()
        {
            using (SqlDataReader dr = AppDAL.MedicinePurchaseSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

    }
}
