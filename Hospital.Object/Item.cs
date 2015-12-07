using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class Item : Objectbase
    {
        internal struct Columns
        {
            public const string ItemId = "ItemId";
            public const string ItemGuid = "ItemGuid";
            public const string ItemCategoryGuid = "ItemCategoryGuid";
            public const string ItemCompanyGuid = "ItemCompanyGuid";
            public const string ItemName = "ItemName";
            public const string ItemCreatedDate = "ItemCreatedDate";
          

        }

        #region Constructor

        public Item() : base() { }

        public Item(Guid key) : base(key) { }

        public Item(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return this.mItemName; }
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

        private string mItemName;
        public string ItemName
        {
            get { return this.mItemName; }
            set { this.mItemName = value; }
        }

        private DateTime mCreatedDate;
        public DateTime CreatedDate
        {
            get { return this.mCreatedDate; }
            set { this.mCreatedDate = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.ItemGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.ItemId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.ItemGuid]);
                this.mCategoryGuid = AppShared.DbValueToGuid(dr[Columns.ItemCategoryGuid]);
                this.mCompanyGuid = AppShared.DbValueToGuid(dr[Columns.ItemCompanyGuid]);
                this.mItemName = AppShared.DbValueToString(dr[Columns.ItemName]);
                this.mCreatedDate = AppShared.DbValueToDateTime(dr[Columns.ItemCreatedDate]);
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
            using (SqlDataReader dr = AppDAL.ItemSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {

            bool r = AppDAL.ItemInsert(this.mObjectGuid, this.mCategoryGuid, this.mCompanyGuid, this.mItemName);

            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.ItemUpdate(this.mObjectGuid, this.mCategoryGuid, this.mCompanyGuid, this.mItemName);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.ItemDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mItemName = string.Empty;
        }
        #endregion

    }

    public sealed class ItemCollection : ObjectCollection<Item>
    {

        #region ItemCollection
        public ItemCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.ItemSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region ItemCollection

        public ItemCollection()
        {
            using (SqlDataReader dr = AppDAL.ItemSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public ItemCollection(Guid companyGuid)
        {
            using (SqlDataReader dr = AppDAL.ItemListCompanyWise(companyGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }

        public ItemCollection(Guid companyGuid,Guid categoryGuid)
        {
            using (SqlDataReader dr = AppDAL.ItemListQuantityWise(companyGuid,categoryGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

    }
}
