using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string Item_Insert = "Item_Insert";
        public const string Item_Update = "Item_Update";
        public const string Item_Delete = "Item_Delete";
        public const string Item_Select = "Item_Select";
        public const string Item_SelectAll = "Item_SelectAll";
        public const string Item_Search = "Item_Search";
        public const string Item_CompanyWise = "Item_CompanyWise";
        public const string Item_QuantityWise = "Item_QuantityWise";

        internal static bool ItemInsert(Guid ItemGuid, Guid CategoryGuid, Guid CompanyGuid, string ItemName)
        {
            bool r = false;            
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Item_Insert))
            {
                ItemParameters(cmd, ItemGuid, CategoryGuid, CompanyGuid, ItemName);                

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);                
            }
            return r;
        }


        internal static bool ItemUpdate(Guid ItemGuid, Guid CategoryGuid, Guid CompanyGuid, string ItemName)
        {
            bool r = false;            
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Item_Update))
            {
                ItemParameters(cmd, ItemGuid, CategoryGuid, CompanyGuid, ItemName);              

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
              
            }
            return r;
        }

        internal static bool ItemDelete(Guid guid)
        {
            return Execute(Item_Delete, Item.Columns.ItemGuid, guid);
        }
        internal static SqlDataReader ItemSelect(Guid guid)
        {
            return GetReader(Item_Select, Item.Columns.ItemGuid, guid);
        }
        internal static SqlDataReader ItemSelectAll()
        {
            return GetReader(Item_SelectAll);
        }

        internal static SqlDataReader ItemListCompanyWise(Guid CompanyGuid)
        {
            return GetReader(Item_CompanyWise, "@CompanyGuid", SqlDbType.UniqueIdentifier, CompanyGuid);
        }

        internal static SqlDataReader ItemListQuantityWise(Guid CompanyGuid,Guid CategoryGuid)
        {
           //return GetReader(Item_QuantityWise, "@CompanyGuid", SqlDbType.UniqueIdentifier, CompanyGuid);
            SqlDataReader r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Item_QuantityWise))
            {
                AppDatabase.AddInParameter(cmd, "@CategoryGuid", SqlDbType.UniqueIdentifier,CategoryGuid);
                AppDatabase.AddInParameter(cmd, "@CompanyGuid", SqlDbType.UniqueIdentifier,CompanyGuid);
               
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }
            return r;
        }

        internal static SqlDataReader ItemSearch(string SearchText)
        {
            return GetReader(Item_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void ItemParameters(SqlCommand cmd, Guid ItemGuid, Guid CategoryGuid, Guid CompanyGuid, string ItemName)
        {
            AppDatabase.AddInParameter(cmd, Item.Columns.ItemGuid, SqlDbType.UniqueIdentifier, ItemGuid);
            AppDatabase.AddInParameter(cmd, Item.Columns.ItemCategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);
            AppDatabase.AddInParameter(cmd, Item.Columns.ItemCompanyGuid, SqlDbType.UniqueIdentifier, CompanyGuid);
            AppDatabase.AddInParameter(cmd, Item.Columns.ItemName, SqlDbType.NVarChar, ItemName);
            
        }
     }
}
