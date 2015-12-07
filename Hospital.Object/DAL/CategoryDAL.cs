using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string Category_Insert = "Category_Insert";
        public const string Category_Update = "Category_Update";
        public const string Category_Delete = "Category_Delete";
        public const string Category_Select = "Category_Select";
        public const string Category_SelectAll = "Category_SelectAll";
        public const string Category_Search = "Category_Search";

        internal static bool CategoryInsert(Guid CategoryGuid, string CategoryName)
        {
            bool r = false;            
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Category_Insert))
            {
                CategoryParameters(cmd, CategoryGuid, CategoryName);                

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);                
            }
            return r;
        }


        internal static bool CategoryUpdate(Guid CategoryGuid, string CategoryName)
        {
            bool r = false;            
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Category_Update))
            {
                CategoryParameters(cmd, CategoryGuid, CategoryName);              

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
              
            }
            return r;
        }

        internal static bool CategoryDelete(Guid guid)
        {
            return Execute(Category_Delete, Category.Columns.CategoryGuid, guid);
        }
        internal static SqlDataReader CategorySelect(Guid guid)
        {
            return GetReader(Category_Select, Category.Columns.CategoryGuid, guid);
        }
        internal static SqlDataReader CategorySelectAll()
        {
            return GetReader(Category_SelectAll);
        }
        internal static SqlDataReader CategorySearch(string SearchText)
        {
            return GetReader(Category_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }
        private static void CategoryParameters(SqlCommand cmd, Guid CategoryGuid, string CategoryName)
        {
            AppDatabase.AddInParameter(cmd, Category.Columns.CategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);
            AppDatabase.AddInParameter(cmd, Category.Columns.CategoryName, SqlDbType.NVarChar, CategoryName);
            
        }
    }
}
