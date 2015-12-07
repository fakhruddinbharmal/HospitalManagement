using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string Medicines_Insert = "Medicines_Insert";
        public const string Medicines_Update = "Medicines_Update";
        public const string Medicines_Delete = "Medicines_Delete";
        public const string Medicines_Select = "Medicines_Select";
        public const string Medicines_SelectAll = "Medicines_SelectAll";
        public const string Medicines_Search = "Medicines_Search";
        public const string Medicine_MaxQuantity = "Medicine_MaxQuantity";

        internal static bool MedicinesInsert(Guid Medicinesguid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, int ReOrderLevel)
        {
            bool r = false;            
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Medicines_Insert))
            {
                MedicinesParameters(cmd, Medicinesguid, CategoryGuid, CompanyGuid, ItemGuid, ReOrderLevel);                

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);                
            }
            return r;
        }


        internal static bool MedicinesUpdate(Guid Medicinesguid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, int ReOrderLevel)
        {
            bool r = false;            
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Medicines_Update))
            {
                MedicinesParameters(cmd, Medicinesguid, CategoryGuid, CompanyGuid, ItemGuid, ReOrderLevel);              

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
              
            }
            return r;
        }

        //internal static bool MedicinesDelete(Guid MedicinesGuid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, int ReOrderLevel)
        internal static bool MedicinesDelete(Guid guid)
        {
            return Execute(Medicines_Delete, Medicines.Columns.MedicineGuid, guid);
            /*bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Medicines_Delete))
            {
                MedicinesParameters(cmd, MedicinesGuid, CategoryGuid, CompanyGuid, ItemGuid, ReOrderLevel); 

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);

            }
            return r;*/
        }
        internal static SqlDataReader MedicinesSelect(Guid guid)
        {
            return GetReader(Medicines_Select, Medicines.Columns.MedicineGuid, guid);
        }
        internal static SqlDataReader MedicinesSelectAll()
        {
            return GetReader(Medicines_SelectAll);
        }
        internal static SqlDataReader MedicinesSearch(string SearchText)
        {
            return GetReader(Medicines_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        internal static Decimal GetAvailableStockMedicine(Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid)
        {
            decimal AvailableStock = 0;
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Medicine_MaxQuantity))
            {
                AppDatabase.AddInParameter(cmd, Medicines.Columns.MedicineCategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);
                AppDatabase.AddInParameter(cmd, Medicines.Columns.MedicineCompanyGuid, SqlDbType.UniqueIdentifier, CompanyGuid);
                AppDatabase.AddInParameter(cmd, Medicines.Columns.MedicineItemGuid, SqlDbType.UniqueIdentifier, ItemGuid);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Medicines.Columns.MedicineCurrentStock, SqlDbType.Decimal);
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.ExecuteCommand(cmd);
                if (r)
                {
                    AvailableStock = AppShared.DbValueToDecimal(prmDate.Value);
                }
            }
            return AvailableStock;
            // return GetReader(Patient_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }
        private static void MedicinesParameters(SqlCommand cmd, Guid MedicinesGuid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, int ReOrderLevel)
        {
            AppDatabase.AddInParameter(cmd, Medicines.Columns.MedicineGuid, SqlDbType.UniqueIdentifier, MedicinesGuid);
            AppDatabase.AddInParameter(cmd, Medicines.Columns.MedicineCategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);
            AppDatabase.AddInParameter(cmd, Medicines.Columns.MedicineCompanyGuid, SqlDbType.UniqueIdentifier, CompanyGuid);
            AppDatabase.AddInParameter(cmd, Medicines.Columns.MedicineItemGuid, SqlDbType.UniqueIdentifier, ItemGuid);
            AppDatabase.AddInParameter(cmd, Medicines.Columns.MedicineReOrderLevel, SqlDbType.Int, ReOrderLevel);
        }
    }
}
