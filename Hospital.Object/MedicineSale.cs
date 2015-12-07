using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class MedicineSale : Objectbase
    {
        internal struct Columns
        {
            public const string MedicineSaleId = "MedicineSaleId";
            public const string MedicineSaleGuid = "MedicineSaleGuid";
            public const string MedicineSaleHaste = "MedicineSaleHaste";
            public const string MedicineSaleCategoryGuid = "MedicineSaleCategoryGuid";
            public const string MedicineSaleCompanyGuid = "MedicineSaleCompanyGuid";
            public const string MedicineSaleItemGuid = "MedicineSaleItemGuid";
            public const string MedicineSaleQuantity = "MedicineSaleQuantity";
            public const string MedicineSaleAmount = "MedicineSaleAmount";
            public const string MedicineSaleDate = "MedicineSaleDate";

        }

        #region Constructor

        public MedicineSale() : base() { }

        public MedicineSale(Guid key) : base(key) { }

        public MedicineSale(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return string.Empty; }
        }
        private string mHaste;
        public string Haste
        {
            get { return this.mHaste; }
            set { this.mHaste = value; }
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
                
        private DateTime mSaleDate;
        public DateTime SaleDate
        {
            get { return this.mSaleDate; }
            set { this.mSaleDate = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.MedicineSaleGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.MedicineSaleId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.MedicineSaleGuid]);
                this.mHaste= AppShared.DbValueToString(dr[Columns.MedicineSaleHaste]);
                this.mCategoryGuid = AppShared.DbValueToGuid(dr[Columns.MedicineSaleCategoryGuid]);
                this.mCompanyGuid = AppShared.DbValueToGuid(dr[Columns.MedicineSaleCompanyGuid]);
                this.mItemGuid = AppShared.DbValueToGuid(dr[Columns.MedicineSaleItemGuid]);                
                this.mQuantity= AppShared.DbValueToDecimal(dr[Columns.MedicineSaleQuantity]);                
                this.mAmount = AppShared.DbValueToDecimal(dr[Columns.MedicineSaleAmount]);
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
            using (SqlDataReader dr = AppDAL.MedicineSaleSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        public decimal GetMRP(Category category, Company company, Item item)
        {
            decimal mrp = AppDAL.MRPFromPurchase(category.ObjectGuid, company.ObjectGuid, item.ObjectGuid);
            return mrp;
        }

       
        protected override bool InsertRecord()
        {

            bool r = AppDAL.MedicineSaleInsert(this.mObjectGuid, this.mHaste, this.mCategoryGuid, this.mCompanyGuid, this.mItemGuid, this.mQuantity, this.mAmount);

            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.MedicineSaleUpdate(this.mObjectGuid, this.mHaste, this.mCategoryGuid, this.mCompanyGuid, this.mItemGuid, this.mQuantity, this.mAmount);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.MedicineSaleDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            
        }
        #endregion

    }

    public sealed class MedicineSaleCollection : ObjectCollection<MedicineSale>
    {

        #region MedicineSaleCollection
        public MedicineSaleCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.MedicineSaleSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region MedicineSaleCollection

        public MedicineSaleCollection()
        {
            using (SqlDataReader dr = AppDAL.MedicineSaleSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

    }
}
