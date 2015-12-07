using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class Company : Objectbase
    {
        internal struct Columns
        {
            public const string CompanyId = "CompanyId";
            public const string CompanyGuid = "CompanyGuid";
            public const string CompanyCategoryGuid = "CompanyCategoryGuid";            
            public const string CompanyName = "CompanyName";
            public const string CompanyCreatedDate = "CompanyCreatedDate";

        }

        #region Constructor

        public Company() : base() { }

        public Company(Guid key) : base(key) { }

        public Company(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return this.mCompanyName; }
        }

        private Guid mCategoryGuid;
        public Guid CategoryGuid
        {
            get { return this.mCategoryGuid; }
            set { this.mCategoryGuid = value; }
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

        private string mCompanyName;
        public string CompanyName
        {
            get { return this.mCompanyName; }
            set { this.mCompanyName = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.CompanyGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.CompanyId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.CompanyGuid]);
                this.mCategoryGuid = AppShared.DbValueToGuid(dr[Columns.CompanyCategoryGuid]);                
                this.mCompanyName = AppShared.DbValueToString(dr[Columns.CompanyName]);
                this.mCreatedDate = AppShared.DbValueToDateTime(dr[Columns.CompanyCreatedDate]);
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
            using (SqlDataReader dr = AppDAL.CompanySelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {

            bool r = AppDAL.CompanyInsert(this.mObjectGuid, this.mCategoryGuid, this.mCompanyName);

            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.CompanyUpdate(this.mObjectGuid, this.mCategoryGuid, this.mCompanyName);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.CompanyDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mCompanyName = string.Empty;
        }
        #endregion

    }

    public sealed class CompanyCollection : ObjectCollection<Company>
    {

        #region CompanyCollection
        public CompanyCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.CompanySearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region CompanyCollection

        public CompanyCollection()
        {
            using (SqlDataReader dr = AppDAL.CompanySelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }

        public CompanyCollection(Guid categoryGuid)
        {
            using (SqlDataReader dr = AppDAL.CompanyListCategoryWise(categoryGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }


        #endregion

    }
}
