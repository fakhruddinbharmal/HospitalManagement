using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string IPDPatientTreatmentSheetDetails_Insert = "IPDPatientTreatmentSheetDetails_Insert";
        public const string IPDPatientTreatmentSheetDetails_Update = "IPDPatientTreatmentSheetDetails_Update";
        public const string IPDPatientTreatmentSheetDetails_Delete = "IPDPatientTreatmentSheetDetails_Delete";
        public const string IPDPatientTreatmentSheetDetails_Select = "IPDPatientTreatmentSheetDetails_Select";
        public const string IPDPatientTreatmentSheetDetails_Select_ByTreatmentSheet = "IPDPatientTreatmentSheetDetails_Select_ByTreatmentSheet";

        internal static bool IPDPatientTreatmentSheetDetailsInsert(Guid guid, Guid treatmentGuid, Guid patientGuid, string description, string morningTime, string noonTime, string eveningTime,
            string nightTime)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDPatientTreatmentSheetDetails_Insert))
            {
                IPDPatientTreatmentSheetDetailsParameters(cmd,guid, treatmentGuid, patientGuid, description, morningTime,noonTime,eveningTime,nightTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }

        internal static bool IPDPatientTreatmentSheetDetailsUpdate(Guid guid, Guid treatmentGuid, Guid patientGuid, string description, string morningTime, string noonTime, string eveningTime,
            string nightTime)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDPatientTreatmentSheetDetails_Update))
            {
                IPDPatientTreatmentSheetDetailsParameters(cmd,guid, treatmentGuid,patientGuid, description, morningTime,noonTime,eveningTime,nightTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);

            }
            return r;
        }

        internal static bool IPDPatientTreatmentSheetDetailsDelete(Guid guid)
        {
            return Execute(IPDPatientTreatmentSheetDetails_Delete, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsGuid, guid);
        }

        internal static SqlDataReader IPDPatientTreatmentSheetDetailsSelect(Guid guid)
        {
            return GetReader(IPDPatientTreatmentSheetDetails_Select, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsGuid, guid);
        }

        internal static SqlDataReader IPDPatientTreatmentSheetDetailsSelectByTreatmentSheet(Guid tretmentSheetGuid)
        {
            return GetReader(IPDPatientTreatmentSheetDetails_Select_ByTreatmentSheet, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsTreatmentSheetGuid, tretmentSheetGuid);
        }

        private static void IPDPatientTreatmentSheetDetailsParameters(SqlCommand cmd, Guid guid, Guid treatmentGuid, Guid patientGuid, string description, string morningTime,
            string noonTime, string eveningTime, string nightTime)
        {
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsGuid, SqlDbType.UniqueIdentifier, guid);
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsTreatmentSheetGuid, SqlDbType.UniqueIdentifier, treatmentGuid);
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsPatientGuid, SqlDbType.UniqueIdentifier, patientGuid);
            AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsDescription, SqlDbType.NVarChar, AppShared.ToDbValueNullable(description));
             AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsMorningTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(morningTime));
             AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsNoonTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(noonTime));
             AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsEveningTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(eveningTime));
             AppDatabase.AddInParameter(cmd, IPDPatientTreatmentSheetDetails.Columns.IPDPatientTreatmentSheetDetailsNightTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(nightTime));
        }
    }
}
