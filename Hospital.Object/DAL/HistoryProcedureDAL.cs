using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string HistoryProcedure_Insert     = "HistoryProcedure_Insert";
        public const string HistoryProcedure_Update     = "HistoryProcedure_Update";
        public const string HistoryProcedure_Delete     = "HistoryProcedure_Delete";
        public const string HistoryProcedure_Select     = "HistoryProcedure_Select";
        public const string HistoryProcedure_SelectAll  = "HistoryProcedure_SelectAll";
        public const string HistoryProcedure_Search     = "HistoryProcedure_Search";

        internal static bool HistoryProcedureInsert(Guid HistoryProcedureGuid, Guid PatientGuid, string ProblemSince,
                                                     string AssociateComplainDuration, string FamilyHistory, string FamilyHistoryDuration, DateTime Date, string BP, string HR, string RR, string Temp, string RBS, string ECG, string Wt, string Other, string MLCNo, DateTime FollowUpDate, string TimeHour, string TimeMinute, string TimeAMPM, Guid createdByUser,
                                                     out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(HistoryProcedure_Insert))
            {
                HistoryProcedureParameter(cmd, HistoryProcedureGuid, PatientGuid, ProblemSince, AssociateComplainDuration,
                                          FamilyHistory, FamilyHistoryDuration, Date, BP, HR, RR, Temp, RBS, ECG, Wt, Other, MLCNo, FollowUpDate, TimeHour,TimeMinute,TimeAMPM, createdByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, HistoryProcedure.Columns.HistoryProcedureModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    createdOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }

        internal static bool HistoryProcedureUpdate(Guid HistoryProcedureGuid, Guid PatientGuid, string ProblemSince,
                                                     string AssociateComplainDuration, string FamilyHistory, string FamilyHistoryDuration, DateTime Date, string BP, string HR, string RR, string Temp, string RBS, string ECG, string Wt, string Other, string MLCNo, DateTime FollowUpDate, string TimeHour, string TimeMinute, string TimeAMPM, Guid modifiedByUser,
                                                     out DateTime modifiedOn)
        {

            bool r = false;
            modifiedOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(HistoryProcedure_Update))
            {
                HistoryProcedureParameter(cmd, HistoryProcedureGuid,PatientGuid, ProblemSince, AssociateComplainDuration,
                                          FamilyHistory, FamilyHistoryDuration, Date, BP, HR, RR, Temp, RBS, ECG, Wt, Other, MLCNo, FollowUpDate, TimeHour, TimeMinute, TimeAMPM, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, HistoryProcedure.Columns.HistoryProcedureModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }
            return r;
        }
        internal static bool HistoryProcedureDelete(Guid guid)
        {
            return Execute(HistoryProcedure_Delete, HistoryProcedure.Columns.HistoryProcedureGuid, guid);
        }
        internal static SqlDataReader HistoryProcedureSelect(Guid guid)
        {
            return GetReader(HistoryProcedure_Select, HistoryProcedure.Columns.HistoryProcedureGuid, guid);
        }
        internal static SqlDataReader HistoryProcedureSelectAll()
        {
            return GetReader(HistoryProcedure_SelectAll);
        }
        internal static SqlDataReader HistoryProcedureSearch(Guid patientGuid)
        {
            return GetReader(HistoryProcedure_Search, HistoryProcedure.Columns.HistoryProcedurePatientGuid, SqlDbType.UniqueIdentifier, patientGuid);
        }

        private static void HistoryProcedureParameter(SqlCommand cmd, Guid HistoryProcedureGuid, Guid PatientGuid, string ProblemSince,
                                                        string AssociateComplainDuration, string FamilyHistory, string FamilyHistoryDuration, DateTime Date, string BP, string HR, string RR, string Temp, string RBS, string ECG, string Wt, string Other, string MLCNo, DateTime FollowUpDate, string TimeHour, string TimeMinute, string TimeAMPM, Guid ModifiedBy)
        { 
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.HistoryProcedureGuid,SqlDbType.UniqueIdentifier,HistoryProcedureGuid);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.HistoryProcedurePatientGuid, SqlDbType.UniqueIdentifier, PatientGuid);
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.ProblemSince,SqlDbType.NVarChar,AppShared.ToDbValueNullable(ProblemSince));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.AssociateComplainDuration,SqlDbType.NVarChar,AppShared.ToDbValueNullable(AssociateComplainDuration));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.FamilyHistory,SqlDbType.NVarChar,AppShared.ToDbValueNullable(FamilyHistory));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.FamilyHistoryDuration,SqlDbType.NVarChar,AppShared.ToDbValueNullable(FamilyHistoryDuration));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.Date, SqlDbType.DateTime, AppShared.ToDbValueNullable(Date));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.BP, SqlDbType.NVarChar, AppShared.ToDbValueNullable(BP));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.HR, SqlDbType.NVarChar, AppShared.ToDbValueNullable(HR));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.RR, SqlDbType.NVarChar, AppShared.ToDbValueNullable(RR));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.Temp, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Temp));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.RBS, SqlDbType.NVarChar, AppShared.ToDbValueNullable(RBS));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.ECG, SqlDbType.NVarChar, AppShared.ToDbValueNullable(ECG));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.Wt, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Wt));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.Other, SqlDbType.NVarChar, AppShared.ToDbValueNullable(Other));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.MLCNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(MLCNo));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.FollowUpDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(FollowUpDate));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.TimeHour, SqlDbType.NVarChar, AppShared.ToDbValueNullable(TimeHour));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.TimeMinute, SqlDbType.NVarChar, AppShared.ToDbValueNullable(TimeMinute));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.TimeAMPM, SqlDbType.NVarChar, AppShared.ToDbValueNullable(TimeAMPM));
            AppDatabase.AddInParameter(cmd, HistoryProcedure.Columns.HistoryProcedureModifiedBy,SqlDbType.UniqueIdentifier,ModifiedBy);

        }

    }
}
