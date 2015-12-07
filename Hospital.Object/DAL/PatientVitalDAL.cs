using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string PatientVital_Insert = "PatientVital_Insert";
        public const string PatientVital_Update = "PatientVital_Update";
        public const string PatientVital_Delete = "PatientVital_Delete";
        public const string PatientVital_Select = "PatientVital_Select";
        public const string PatientVital_SelectAll = "PatientVital_SelectAll";
        public const string PatientVital_Search = "PatientVital_Search";

        internal static bool PatientVitalInsert(Guid Guid, Guid PatientGuid, DateTime VitalDate, string VitalTime, string Bp, string Hr, string Rr, string Temp, string Rbs, string Ecg, string Weight, string Height, string Other, string Spo2, string Pulse)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientVital_Insert))
            {
                PatientVitalParameters(cmd, Guid, PatientGuid, VitalDate, VitalTime, Bp, Hr, Rr, Temp, Rbs, Ecg, Weight, Height, Other, Spo2, Pulse);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
            }
            return r;
        }
        internal static bool PatientVitalUpdate(Guid Guid, Guid PatientGuid, DateTime VitalDate, string VitalTime, string Bp, string Hr, string Rr, string Temp, string Rbs, string Ecg, string Weight, string Height, string Other, string Spo2, string Pulse)
        {
            bool r = false;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientVital_Update))
            {
                PatientVitalParameters(cmd, Guid, PatientGuid, VitalDate, VitalTime, Bp, Hr, Rr, Temp, Rbs, Ecg, Weight, Height, Other, Spo2, Pulse);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);

            }
            return r;
        }

        internal static bool PatientVitalDelete(Guid guid)
        {
            return Execute(PatientVital_Delete, PatientVital.Columns.PatientVitalGuid, guid);
        }
        internal static SqlDataReader PatientVitalSelect(Guid guid)
        {
            return GetReader(PatientVital_Select, PatientVital.Columns.PatientVitalGuid, guid);
        }
        internal static SqlDataReader PatientVitalSelectAll()
        {
            return GetReader(PatientVital_SelectAll);
        }
        internal static SqlDataReader PatientVitalSearch(string SearchText, DateTime dateFrom, DateTime dateTo)
        {
            //return GetReader(PatientVital_Search, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
            SqlDataReader r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(PatientVital_Search))
            {
                AppDatabase.AddInParameter(cmd, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(SearchText));
                AppDatabase.AddInParameter(cmd, "@DateFrom", SqlDbType.DateTime, AppShared.ToDbValueNullable(dateFrom));
                AppDatabase.AddInParameter(cmd, "@DateTo", SqlDbType.DateTime, AppShared.ToDbValueNullable(dateTo));
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }
            return r;
        }
        private static void PatientVitalParameters(SqlCommand cmd, Guid Guid, Guid PatientGuid, DateTime VitalDate, string VitalTime, string Bp, string Hr, string Rr, string Temp, string Rbs, string Ecg, string Weight, string Height, string Other, string Spo2, string Pulse)
        {
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalGuid, SqlDbType.UniqueIdentifier, Guid);
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalPatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalDate, SqlDbType.DateTime, VitalDate);
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(VitalTime));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalBP, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Bp));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalHR, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Hr));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalRR, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Rr));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalTemp, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Temp));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalRBS, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Rbs));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalECG, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Ecg));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalWeight, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Weight));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalHeight, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Height));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalOther, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Other));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalSPO2, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Spo2));
            AppDatabase.AddInParameter(cmd, PatientVital.Columns.PatientVitalPULSE, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Pulse));
        }
    }
}

