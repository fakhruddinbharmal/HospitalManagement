using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string MedicineSale_Insert = "MedicineSale_Insert";
        public const string MedicineSale_Update = "MedicineSale_Update";
        public const string MedicineSale_Delete = "MedicineSale_Delete";
        public const string MedicineSale_Select = "MedicineSale_Select";
        public const string MedicineSale_SelectAll = "MedicineSale_SelectAll";
        public const string MedicineSale_Search = "MedicineSale_Search";
        public const string MedicinePurchase_GETMRP = "MedicinePurchase_GETMRP";
        

        internal static bool MedicineSaleInsert(Guid MedicineSaleguid, string Haste, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, decimal Quantity, decimal Amount)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(MedicineSale_Insert))
            {
                MedicineSaleParameters(cmd, MedicineSaleguid, Haste, CategoryGuid, CompanyGuid, ItemGuid, Quantity, Amount);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }


        internal static bool MedicineSaleUpdate(Guid MedicineSaleguid, string Haste, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, decimal Quantity, decimal Amount)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(MedicineSale_Update))
            {
                MedicineSaleParameters(cmd, MedicineSaleguid, Haste, CategoryGuid, CompanyGuid, ItemGuid, Quantity, Amount);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);

            }
            return r;
        }

        internal static bool MedicineSaleDelete(Guid guid)
        {
            return Execute(MedicineSale_Delete, MedicineSale.Columns.MedicineSaleGuid, guid);
        }
        internal static SqlDataReader MedicineSaleSelect(Guid guid)
        {
            return GetReader(MedicineSale_Select, MedicineSale.Columns.MedicineSaleGuid, guid);
        }
        internal static SqlDataReader MedicineSaleSelectAll()
        {
            return GetReader(MedicineSale_SelectAll);
        }
        internal static SqlDataReader MedicineSaleSearch(string SearchText)
        {
            return GetReader(MedicineSale_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }

        internal static Decimal MRPFromPurchase(Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid)
        {
            decimal MRP = 0;
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(MedicinePurchase_GETMRP))
            {
                AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseCategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);
                AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseCompanyGuid, SqlDbType.UniqueIdentifier, CompanyGuid);
                AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseItemGuid, SqlDbType.UniqueIdentifier, ItemGuid);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseMRP, SqlDbType.Decimal);
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.ExecuteCommand(cmd);
                if (r)
                {
                    MRP = AppShared.DbValueToDecimal(prmDate.Value);
                }
            }
            return MRP;
            // return GetReader(Patient_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }



        private static void MedicineSaleParameters(SqlCommand cmd, Guid MedicineSaleGuid, string Haste, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, decimal Quantity, decimal Amount)
        {
            AppDatabase.AddInParameter(cmd, MedicineSale.Columns.MedicineSaleGuid, SqlDbType.UniqueIdentifier, MedicineSaleGuid);
            AppDatabase.AddInParameter(cmd, MedicineSale.Columns.MedicineSaleHaste, SqlDbType.NVarChar, Haste);
            AppDatabase.AddInParameter(cmd, MedicineSale.Columns.MedicineSaleCategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);
            AppDatabase.AddInParameter(cmd, MedicineSale.Columns.MedicineSaleCompanyGuid, SqlDbType.UniqueIdentifier, CompanyGuid);
            AppDatabase.AddInParameter(cmd, MedicineSale.Columns.MedicineSaleItemGuid, SqlDbType.UniqueIdentifier, ItemGuid);            
            AppDatabase.AddInParameter(cmd, MedicineSale.Columns.MedicineSaleQuantity, SqlDbType.Decimal, Quantity);            
            AppDatabase.AddInParameter(cmd, MedicineSale.Columns.MedicineSaleAmount, SqlDbType.Decimal, Amount);
        }
    }
}
