using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string PatientMedicineSale_Insert = "PatientMedicineSale_Insert";
        public const string PatientMedicineSale_Update = "PatientMedicineSale_Update";
        public const string PatientMedicineSale_Delete = "PatientMedicineSale_Delete";
        public const string PatientMedicineSale_Select = "PatientMedicineSale_Select";
        public const string PatientMedicineSale_Select_ByBill = "PatientMedicineSale_Select_ByBill";

        internal static bool PatientMedicineSaleInsert(Guid PatientMedicineSaleGuid, Guid PatientMedicineSaleBillGuid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, decimal Quantity, decimal Amount, string Note)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientMedicineSale_Insert))
            {
                PatientMedicineSaleParameters(cmd, PatientMedicineSaleGuid, PatientMedicineSaleBillGuid, CategoryGuid, CompanyGuid, ItemGuid, Quantity, Amount,Note);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }

        internal static bool PatientMedicineSaleUpdate(Guid PatientMedicineSaleGuid, Guid PatientMedicineSaleBillGuid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, decimal Quantity, decimal Amount, string Note)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientMedicineSale_Update))
            {
                PatientMedicineSaleParameters(cmd, PatientMedicineSaleGuid, PatientMedicineSaleBillGuid, CategoryGuid, CompanyGuid, ItemGuid, Quantity, Amount, Note);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);

            }
            return r;
        }

        internal static bool PatientMedicineSaleDelete(Guid guid)
        {
            return Execute(PatientMedicineSale_Delete, PatientMedicineSale.Columns.PatientMedicineSaleGuid, guid);
        }

        internal static SqlDataReader PatientMedicineSaleSelect(Guid guid)
        {
            return GetReader(PatientMedicineSale_Select, PatientMedicineSale.Columns.PatientMedicineSaleGuid, guid);
        }

        internal static SqlDataReader PatientMedicineSaleSearchByBill(Guid billGuid)
        {
            return GetReader(PatientMedicineSale_Select_ByBill, PatientMedicineSale.Columns.PatientMedicineSalePatientBillGuid, billGuid);
        }

        private static void PatientMedicineSaleParameters(SqlCommand cmd, Guid PatientMedicineSaleGuid, Guid PatientMedicineSaleBillGuid, Guid CategoryGuid, Guid CompanyGuid, Guid ItemGuid, decimal Quantity, decimal Amount, string Note)
        {
            AppDatabase.AddInParameter(cmd, PatientMedicineSale.Columns.PatientMedicineSaleGuid, SqlDbType.UniqueIdentifier, PatientMedicineSaleGuid);
            AppDatabase.AddInParameter(cmd, PatientMedicineSale.Columns.PatientMedicineSalePatientBillGuid, SqlDbType.UniqueIdentifier, PatientMedicineSaleBillGuid);
            AppDatabase.AddInParameter(cmd, PatientMedicineSale.Columns.PatientMedicineSaleCategoryGuid, SqlDbType.UniqueIdentifier, CategoryGuid);
            AppDatabase.AddInParameter(cmd, PatientMedicineSale.Columns.PatientMedicineSaleCompanyGuid, SqlDbType.UniqueIdentifier, CompanyGuid);
            AppDatabase.AddInParameter(cmd, PatientMedicineSale.Columns.PatientMedicineSaleItemGuid, SqlDbType.UniqueIdentifier, ItemGuid);
            AppDatabase.AddInParameter(cmd, PatientMedicineSale.Columns.PatientMedicineSaleQuantity, SqlDbType.Decimal, Quantity);
            AppDatabase.AddInParameter(cmd, PatientMedicineSale.Columns.PatientMedicineSaleAmount, SqlDbType.Decimal, Amount);
            AppDatabase.AddInParameter(cmd, PatientMedicineSale.Columns.PatientMedicineSaleNote, SqlDbType.NVarChar, Note);
        }

    }
}
