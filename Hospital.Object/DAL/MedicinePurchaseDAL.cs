using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string MedicinePurchase_Insert = "MedicinePurchase_Insert";
        public const string MedicinePurchase_Update = "MedicinePurchase_Update";
        public const string MedicinePurchase_Delete = "MedicinePurchase_Delete";
        public const string MedicinePurchase_Select = "MedicinePurchase_Select";
        public const string MedicinePurchase_SelectAll = "MedicinePurchase_SelectAll";
        public const string MedicinePurchase_Search = "MedicinePurchase_Search";

        internal static bool MedicinePurchaseInsert(Guid MedicinePurchaseguid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, string BillType, int Quantity, decimal WholesaleRate, decimal Amount, DateTime ExpiryDate, decimal MRP)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(MedicinePurchase_Insert))
            {
                MedicinePurchaseParameters(cmd, MedicinePurchaseguid, CategoryGuid, CompanyGuid, ItemGuid, BillType, Quantity, WholesaleRate, Amount, ExpiryDate, MRP);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }


        internal static bool MedicinePurchaseUpdate(Guid MedicinePurchaseguid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, string BillType, int Quantity, decimal WholesaleRate, decimal Amount, DateTime ExpiryDate, decimal MRP)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(MedicinePurchase_Update))
            {
                MedicinePurchaseParameters(cmd, MedicinePurchaseguid, CategoryGuid, CompanyGuid, ItemGuid, BillType, Quantity, WholesaleRate, Amount, ExpiryDate, MRP);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);

            }
            return r;
        }

        internal static bool MedicinePurchaseDelete(Guid guid)
        {
            return Execute(MedicinePurchase_Delete, MedicinePurchase.Columns.MedicinePurchaseGuid, guid);
        }
        internal static SqlDataReader MedicinePurchaseSelect(Guid guid)
        {
            return GetReader(MedicinePurchase_Select, MedicinePurchase.Columns.MedicinePurchaseGuid, guid);
        }
        internal static SqlDataReader MedicinePurchaseSelectAll()
        {
            return GetReader(MedicinePurchase_SelectAll);
        }
        internal static SqlDataReader MedicinePurchaseSearch(string SearchText)
        {
            return GetReader(MedicinePurchase_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void MedicinePurchaseParameters(SqlCommand cmd, Guid MedicinePurchaseGuid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, string BillType, int Quantity, decimal WholesaleRate, decimal Amount, DateTime ExpiryDate, decimal MRP)
        {
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseGuid, SqlDbType.UniqueIdentifier, MedicinePurchaseGuid);
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseCategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseCompanyGuid, SqlDbType.UniqueIdentifier, CompanyGuid);
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseItemGuid, SqlDbType.UniqueIdentifier, ItemGuid);
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseBillType, SqlDbType.NVarChar, BillType);
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseQuantity, SqlDbType.Int, Quantity);
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseWholesaleRate, SqlDbType.Decimal, WholesaleRate);
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseAmount, SqlDbType.Decimal, Amount);            
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseExpiryDate, SqlDbType.DateTime, ExpiryDate);
            AppDatabase.AddInParameter(cmd, MedicinePurchase.Columns.MedicinePurchaseMRP, SqlDbType.Decimal,MRP );

        }
    }
}
