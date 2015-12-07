using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        public const string IPDPatient_Bill = "IPDPatient_Bill";

        public const string OPDAppointment_Report = "OPDAppointment_Report";

        public const string OPDAppointment_Report7Days = "OPDAppointment_Report7Days";

        public const string OPDPriscription_Report = "OPDPriscription_Report";

        public const string OPDTreatment_Report = "OPDTreatment_Report";

        public const string PatientMedicineSale_Report = "PatientMedicineSale_Report";

        public const string IndoorCaseReport = "PatientIndoorCaseReport";

        public const string MLCFormSelect = "MLCFormReport";

        public const string PatientRDetailReport = "PatientDetailReport";

        public const string IPDPatientDischargeSummeryReport = "IPDPatientDischargeSummeryReport";

        public const string DisChargeTreatmentReport = "DisChargeTreatmentReport";

        public const string IPDPatientTreamentSheetDetailsReports = "IPDPatientTreamentSheetDetails_Report";

        public const string IPDPatientTreamentSheetReports = "IPDPatientTreamentSheet_Report";

        public const string IPDPatientVitalReport_ByDate = "IPDPatientVitalReport_ByDate";

        internal static DataTable PatientBillReport(Guid guid)
        {
            return GetDataTable(IPDPatient_Bill, Report.Columns.PatientGuid, guid);
        }
        internal static DataTable OPDAppointmentReport7Days(DateTime fromDate, DateTime toDate)
        {
            DataTable r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDAppointment_Report7Days))
            {
                AppDatabase.AddInParameter(cmd, "@AppointmentDateFrom", SqlDbType.DateTime, AppShared.ToDbValueNullable(fromDate));
                AppDatabase.AddInParameter(cmd, "@AppointmentDateTo", SqlDbType.DateTime, AppShared.ToDbValueNullable(toDate));
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetDataTable(cmd);
            }
            return r;

            //return GetDataTable(OPDAppointment_Report7Days);
        }
        internal static DataTable OPDAppointmentReport(DateTime DateFrom, DateTime DateTo)
        { 
             DataTable r = null;
             using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDAppointment_Report))
             {
                AppDatabase.AddInParameter(cmd, "@DateFrom", SqlDbType.DateTime, AppShared.ToDbValueNullable(DateFrom));
                AppDatabase.AddInParameter(cmd, "@DateTo", SqlDbType.DateTime, AppShared.ToDbValueNullable(DateTo));
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetDataTable(cmd);            
             }
             return r;
        }
        internal static DataTable OPDPrescriptionData(DateTime dt)
        {
            DataTable r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDPriscription_Report))
            {
                AppDatabase.AddInParameter(cmd, "@Date", SqlDbType.DateTime, AppShared.ToDbValueNullable(dt));
               
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetDataTable(cmd);
            }
            return r;
        }

        internal static DataTable OPDTreatmentData(DateTime dt)
        {
            DataTable r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(OPDTreatment_Report))
            {
                AppDatabase.AddInParameter(cmd, "@Date", SqlDbType.DateTime, AppShared.ToDbValueNullable(dt));

                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetDataTable(cmd);
            }
            return r;
        }

        internal static DataTable PatientMedicineBillReport(Guid patientMedicineBillGuid)
        {
            return GetDataTable(PatientMedicineSale_Report, Report.Columns.PatientMedicineSalePatientBillGuid, patientMedicineBillGuid);
        }

        internal static DataTable PatientIndoorCaseReport(Guid PatientGuid)
        {
            return GetDataTable(IndoorCaseReport, Report.Columns.PatientGuid, PatientGuid);
        }
        internal static DataTable PatientMLCReport(Guid PatientGuid)
        {
            return GetDataTable(MLCFormSelect, Report.Columns.PatientGuid, PatientGuid);
        }
        internal static DataTable PatientDetailReport(Guid PatientGuid)
        {
            return GetDataTable(PatientRDetailReport, Report.Columns.PatientGuid, PatientGuid);
        }
        internal static DataTable PatientDischargeSummeryReport(Guid PatientGuid)
        {
            return GetDataTable(IPDPatientDischargeSummeryReport, Report.Columns.PatientGuid, PatientGuid);
        }
        internal static DataTable PatientDischargeTreatmentRpt(Guid PatientGuid)
        {
            return GetDataTable(DisChargeTreatmentReport, Report.Columns.PatientGuid, PatientGuid);
        }
        internal static DataTable IPDPatientTreamentSheetDetailsReport(Guid IPDPatientTreatmentSheetDetailsGuid)
        {
            return GetDataTable(IPDPatientTreamentSheetDetailsReports, Report.Columns.IPDPatientTreatmentSheetGuid, IPDPatientTreatmentSheetDetailsGuid);
        }
        //internal static DataTable IPDPatientTreamentSheetReport(Guid IPDPatientTreatmentSheetGuid)
        //{
        //    return GetDataTable(IPDPatientTreamentSheetReports, Report.Columns.IPDPatientTreatmentSheetGuid, IPDPatientTreatmentSheetGuid);
        //}

        internal static DataTable IPDPatientVitalByDate(Guid patientGuid, DateTime treatMentDate)
        {
            DataTable r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(IPDPatientVitalReport_ByDate))
            {
                AppDatabase.AddInParameter(cmd, "@PatientGuid", SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(patientGuid));
                AppDatabase.AddInParameter(cmd, "@IPDPatientTreatmentSheetDate", SqlDbType.DateTime, AppShared.ToDbValueNullable(treatMentDate));

                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetDataTable(cmd);
            }
            return r;
        }
    }
}
