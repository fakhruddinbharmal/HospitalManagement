using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        private const string IPDPatientTreatmentSheet_Search = "IPDPatientTreatmentSheet_Search";
        private const string IPDPatientTreatmentSheet_Insert = "IPDPatientTreatmentSheet_Insert";
        private const string IPDPatientTreatmentSheet_Update = "IPDPatientTreatmentSheet_Update";
        private const string IPDPatientTreatmentSheet_Delete = "IPDPatientTreatmentSheet_Delete";
        private const string IPDPatientTreatmentSheet_Select = "IPDPatientTreatmentSheet_Select";

        internal static bool IPDPatientTreatmentSheetInsert(Guid guid, Guid patientGuid, string diatAdvice, string sosDrug, string specialAdvice,DateTime treatmentDate)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDPatientTreatmentSheet_Insert))
            {
                IPDPatientTreatmentParameter(cmd, guid, patientGuid, diatAdvice, sosDrug, specialAdvice, treatmentDate);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }

        internal static bool IPDPatientTreatmentSheetUpdate(Guid guid, Guid patientGuid, string diatAdvice, string sosDrug, string specialAdvice, DateTime treatmentDate)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDPatientTreatmentSheet_Update))
            {
                IPDPatientTreatmentParameter(cmd, guid, patientGuid, diatAdvice, sosDrug, specialAdvice, treatmentDate);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }

        internal static bool IPDPatientTreatmentSheetDelete(Guid guid)
        {
            return Execute(IPDPatientTreatmentSheet_Delete, IPDPatientTreatmentSheet.Columns.TreatmentSheetGuid, guid);
        }

        internal static SqlDataReader IPDPatientTreatmentSheetSelect(Guid guid)
        {
            return GetReader(IPDPatientTreatmentSheet_Select, IPDPatientTreatmentSheet.Columns.TreatmentSheetGuid, guid);
        }

        internal static SqlDataReader IPDPatientTreatmentSheetSearch(string searchText, DateTime dateFrom, DateTime dateTo)
        {
            SqlDataReader r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDPatientTreatmentSheet_Search))
            {
                AppDatabase.AddInParameter(cmd, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
                AppDatabase.AddInParameter(cmd, "@DateFrom", SqlDbType.DateTime, AppShared.ToDbValueNullable(dateFrom));
                AppDatabase.AddInParameter(cmd, "@DateTo", SqlDbType.DateTime, AppShared.ToDbValueNullable(dateTo));
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }
            return r;
        }

        private static void IPDPatientTreatmentParameter(SqlCommand cmd, Guid guid, Guid patientGuid, string diatAdvice, string sosDrug, string specialAdvice,
            DateTime treatmentDate)
        {
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheet.Columns.TreatmentSheetGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheet.Columns.TreatmentSheetPatientGuid, SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(patientGuid));
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheet.Columns.TreatmentSheetDiatAdvice, SqlDbType.NVarChar, AppShared.ToDbValueNullable(diatAdvice));
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheet.Columns.TreatmentSheetSOSDrug, SqlDbType.NVarChar, AppShared.ToDbValueNullable(sosDrug));
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheet.Columns.TreatmentSheetSpecialAdvice, SqlDbType.NVarChar, AppShared.ToDbValueNullable(specialAdvice));
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheet.Columns.TreatmentSheetDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(treatmentDate));
            
        }
    }
}
