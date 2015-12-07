using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        private const string PatientBill_Search = "PatientBill_Search";
        private const string PatientBill_Insert = "PatientBill_Insert";
        private const string PatientBill_Select = "PatientBill_Select";
        private const string PatientBill_Update = "PatientBill_Update";
        private const string PatientBill_Delete = "PatientBill_Delete";

        internal static bool PatientBillInsert(Guid guid, Guid patientGuid, DateTime patientBillDate, string otherPatientName)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientBill_Insert))
            {
                PatientBillParameter(cmd, guid, patientGuid, patientBillDate,otherPatientName);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }


        internal static bool PatientBillUpdate(Guid guid, Guid patientGuid, DateTime patientBillDate, string otherPatientName)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientBill_Update))
            {
                PatientBillParameter(cmd, guid, patientGuid, patientBillDate, otherPatientName);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }

        internal static bool PatientBillDelete(Guid guid)
        {
            return Execute(PatientBill_Delete,  PatientBill.Columns.BillGuid, guid);
        }

        internal static SqlDataReader PatientBillSelect(Guid guid)
        {
            return GetReader(PatientBill_Select, PatientBill.Columns.BillGuid, guid);
        }

        //internal static SqlDataReader PatientSelectAll()
        //{
        //    return GetReader(Patient_SelectAll);
        //}

        internal static SqlDataReader PatientBillSearch(string searchText)
        {
            return GetReader(PatientBill_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
        }

        private static void PatientBillParameter(SqlCommand cmd, Guid guid, Guid patientGuid, DateTime patientBillDate, string otherPatientName)
        {
            AppDatabase.AddInParameter(cmd, PatientBill.Columns.BillGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, PatientBill.Columns.PatientGuid, SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(patientGuid));
            AppDatabase.AddInParameter(cmd, PatientBill.Columns.BillDate, SqlDbType.DateTime, patientBillDate);
            AppDatabase.AddInParameter(cmd, PatientBill.Columns.BillOther, SqlDbType.NVarChar,otherPatientName);
        }
    }
}
