using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class Category : Objectbase
    {
        internal struct Columns
        {
            public const string CategoryId = "CategoryId";
            public const string CategoryGuid = "CategoryGuid";
            public const string CategoryName = "CategoryName";
            public const string CategoryCreatedDate = "CategoryCreatedDate";

        }

        #region Constructor

        public Category() : base() { }

        public Category(Guid key) : base(key) { }

        public Category(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return this.mCategoryName; }
        }


        private string mCategoryName;
        public string CategoryName
        {
            get { return this.mCategoryName; }
            set { this.mCategoryName = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.CategoryGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.CategoryId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.CategoryGuid]);
                this.mCategoryName = AppShared.DbValueToString(dr[Columns.CategoryName]);
                this.mCreatedDate = AppShared.DbValueToDateTime(dr[Columns.CategoryCreatedDate]);
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
            using (SqlDataReader dr = AppDAL.CategorySelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {

            bool r = AppDAL.CategoryInsert(this.mObjectGuid, this.mCategoryName);

            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.CategoryUpdate(this.mObjectGuid, this.mCategoryName);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.CategoryDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mCategoryName = string.Empty;
        }
        #endregion

    }

    public sealed class CategoryCollection : ObjectCollection<Category>
    {

        #region CategoryCollection
        public CategoryCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.CategorySearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region CategoryCollection

        public CategoryCollection()
        {
            using (SqlDataReader dr = AppDAL.CategorySelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

    }
}
