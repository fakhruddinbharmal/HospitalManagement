using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string Company_Insert = "Company_Insert";
        public const string Company_Update = "Company_Update";
        public const string Company_Delete = "Company_Delete";
        public const string Company_Select = "Company_Select";
        public const string Company_SelectAll = "Company_SelectAll";
        public const string Company_Search = "Company_Search";
        public const string Company_CategoryWise = "Company_CategoryWise";

        internal static bool CompanyInsert(Guid CompanyGuid, Guid CategoryGuid, string CompanyName)
        {
            bool r = false;            
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Company_Insert))
            {
                CompanyParameters(cmd, CompanyGuid, CategoryGuid, CompanyName);                

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);                
            }
            return r;
        }


        internal static bool CompanyUpdate(Guid CompanyGuid, Guid CategoryGuid, string CompanyName)
        {
            bool r = false;            
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Company_Update))
            {
                CompanyParameters(cmd, CompanyGuid, CategoryGuid, CompanyName);              

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
              
            }
            return r;
        }

        internal static bool CompanyDelete(Guid guid)
        {
            return Execute(Company_Delete, Company.Columns.CompanyGuid, guid);
        }
        internal static SqlDataReader CompanySelect(Guid guid)
        {
            return GetReader(Company_Select, Company.Columns.CompanyGuid, guid);
        }
        internal static SqlDataReader CompanySelectAll()
        {
            return GetReader(Company_SelectAll);
        }
        internal static SqlDataReader CompanySearch(string SearchText)
        {
            return GetReader(Company_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
        }

        internal static SqlDataReader CompanyListCategoryWise(Guid CategoryGuid)
        {
            return GetReader(Company_CategoryWise, "@CategoryGuid", SqlDbType.UniqueIdentifier, CategoryGuid);
        }

        private static void CompanyParameters(SqlCommand cmd, Guid CompanyGuid, Guid CategoryGuid, string CompanyName)
        {
            AppDatabase.AddInParameter(cmd, Company.Columns.CompanyGuid, SqlDbType.UniqueIdentifier, CompanyGuid);
            AppDatabase.AddInParameter(cmd, Company.Columns.CompanyCategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);            
            AppDatabase.AddInParameter(cmd, Company.Columns.CompanyName, SqlDbType.NVarChar, CompanyName);
            
        }
    }
}
