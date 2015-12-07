using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class Medicines : Objectbase
    {
        internal struct Columns
        {            
            public const string MedicineId = "MedicineId";
            public const string MedicineGuid = "MedicineGuid";
            public const string MedicineCategoryGuid = "MedicineCategoryGuid";
            public const string MedicineCompanyGuid = "MedicineCompanyGuid";
            public const string MedicineItemGuid = "MedicineItemGuid";
            public const string MedicineCurrentStock = "MedicineCurrentStock";
            public const string MedicineReOrderLevel = "MedicineReOrderLevel";
            public const string MedicineCreatedDate = "MedicineCreatedDate";
            
        }

        #region Constructor

        public Medicines() : base() { }

        public Medicines(Guid key) : base(key) { }
      
        public Medicines(SqlDataReader dr) : base(dr) { }

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


        private int mCurrentStock;
        public int CurrentStock
        {
            get { return this.mCurrentStock; }
            set { this.mCurrentStock = value; }
        }

        private int mReOrderLevel;
        public int ReOrderLevel
        {
            get { return this.mReOrderLevel; }
            set { this.mReOrderLevel = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.MedicineGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.MedicineId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.MedicineGuid]);
                this.mCategoryGuid = AppShared.DbValueToGuid(dr[Columns.MedicineCategoryGuid]);
                this.mCompanyGuid = AppShared.DbValueToGuid(dr[Columns.MedicineCompanyGuid]);
                this.mItemGuid = AppShared.DbValueToGuid(dr[Columns.MedicineItemGuid]);
                this.mCurrentStock = AppShared.DbValueToInteger(dr[Columns.MedicineCurrentStock]);
                this.mReOrderLevel = AppShared.DbValueToInteger(dr[Columns.MedicineReOrderLevel]);
                this.mCreatedDate = AppShared.DbValueToDateTime(dr[Columns.MedicineCreatedDate]);                
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
            using (SqlDataReader dr = AppDAL.MedicineSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
           
            bool r = AppDAL.MedicinesInsert(this.mObjectGuid, this.mCategoryGuid, this.mCompanyGuid, this.mItemGuid, this.mReOrderLevel);
           
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.MedicinesUpdate(this.mObjectGuid, this.mCategoryGuid, this.mCompanyGuid, this.mItemGuid, this.mReOrderLevel);            
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.MedicinesDelete(this.mObjectGuid);
            
        }

        protected override void Reset()
        {
            base.Reset();
              
        }
        #endregion

        public decimal GetMaxQuantityAvailable(Category category, Company company, Item item)
        {
            decimal availableStock = AppDAL.GetAvailableStockMedicine(category.ObjectGuid, company.ObjectGuid, item.ObjectGuid);
            return availableStock;
        }
    }

    public sealed class MedicinesCollection : ObjectCollection<Medicines>
    {

        #region MedicinesCollection
        public MedicinesCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.MedicinesSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

        #region MedicinesCollection

        public MedicinesCollection()
        {
            using (SqlDataReader dr = AppDAL.MedicinesSelectAll())
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion

    }
}
