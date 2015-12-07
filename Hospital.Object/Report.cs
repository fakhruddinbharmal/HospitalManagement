using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Hospital.Object
{
    public sealed class Report
    {
        internal struct Columns
        {
            public const string PatientGuid = "PatientGuid";
            public const string HistoryProcedureGuid = "HistoryProcedureGuid";
            public const string Date = "Date";
            public const string PatientMedicineSalePatientBillGuid = "PatientMedicineSalePatientBillGuid";
            public const string IPDPatientTreatmentSheetDetailsGuid = "IPDPatientTreatmentSheetDetailsGuid";
            public const string IPDPatientTreatmentSheetGuid = "IPDPatientTreatmentSheetGuid";
            public const string IPDPatientTreatmentSheetDate = "IPDPatientTreatmentSheetDate";
        }

        public static DataTable GetReport(Guid guid)
        {
            return AppDAL.PatientBillReport(guid);
        }
        public static DataTable GetAppointmentFor7Days(DateTime fromDate, DateTime toDate)
        {
            return AppDAL.OPDAppointmentReport7Days(fromDate, toDate);
        }
        public static DataTable GetAppointmentReport(DateTime d1, DateTime d2)
        {
            return AppDAL.OPDAppointmentReport(d1, d2);
        }

        public static DataTable GetOPDPrescription(DateTime dt)
        {
            return AppDAL.OPDPrescriptionData(dt);
        }

        public static DataTable GetOPDTreatment(DateTime dt)
        {
            return AppDAL.OPDTreatmentData(dt);
        }

        public static DataTable GetPatientMedicineSaleReport(Guid patientMedicinBillGuid)
        {
            return AppDAL.PatientMedicineBillReport(patientMedicinBillGuid);
        }

        public static DataTable GetIndoorCaseReport(Guid PatientGuid)
        {
            return AppDAL.PatientIndoorCaseReport(PatientGuid);
        }
        public static DataTable GetMLCReport(Guid PatientGuid)
        {
            return AppDAL.PatientMLCReport(PatientGuid);
        }
        public static DataTable GetPatientDetailReport(Guid PatientGuid)
        {
            return AppDAL.PatientDetailReport(PatientGuid);
        }
        public static DataTable GetDischargeSummeryReport(Guid PatientGuid)
        {
            return AppDAL.PatientDischargeSummeryReport(PatientGuid);
        }
        public static DataTable GetDischargeTreatmentRpt(Guid PatientGuid)
        {
            return AppDAL.PatientDischargeTreatmentRpt(PatientGuid);
        }
        public static DataTable GetIPDPatientTreatmentSheetDetailsReport(Guid IPDPatientTreatmentSheetDetailsGuid)
        {
            return AppDAL.IPDPatientTreamentSheetDetailsReport(IPDPatientTreatmentSheetDetailsGuid);
        }
        //public static DataTable GetIPDPatientTreatmentSheetReport(Guid IPDPatientTreatmentSheetGuid)
        //{
        //    return AppDAL.IPDPatientTreamentSheetReport(IPDPatientTreatmentSheetGuid);
        //}

        public static DataTable GetIPDPatientVitalsByDate(Guid patientGuid, DateTime treatMentDate)
        {
            return AppDAL.IPDPatientVitalByDate(patientGuid, treatMentDate);
        }
    }
}
