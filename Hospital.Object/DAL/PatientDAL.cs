using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace Hospital.Object
{
    internal static partial class AppDAL
    {
        private const string Patient_Insert = "Patient_Insert";
        private const string Patient_Update = "Patient_Update";
        private const string Patient_Delete = "Patient_Delete";
        private const string Patient_Select = "Patient_Select";
        //private const string Patient_SelectAll = "Patient_SelectAll";
        private const string Patient_Search = "Patient_Search";
        private const string Select_IPDPatient = "Select_IPDPatient";
        private const string Select_OPDPatient = "Select_OPDPatient";

        internal static bool PatientInsert(Guid guid, string firstName, string middleName, string lastName, int gender, int age, string address, string city,
/*patientDetails fields*/string district, string taluko, string contactNo, string otherNo, string residenceNo, int maritalstatus, decimal marragetimeyear, int childern, string notes, 
            Guid wardGuid, Guid roomGuid, DateTime admittedDate, string admittedtime, string admittedBy, string operation, DateTime followUpDate, decimal amount, bool isIpd, 
            bool isOpd, Guid referenceDoctorGuid, decimal referenceDoctorShare, string PatientOccupation, string PatientOccupationFullAddress, string PatientReference, 
            string PatientInsurance, string PatientInsuranceCompany, string insuranceAmount, DateTime PatientOperationDateTime, string PatientSigningPersonName, 
            string PatientRelationshipWith, string PatientDoctorIncharge, string PatientDivison, string PatientPSOName, string PatientReceivingStaff, string receivingStaffReceptionMO,
            string PatientMO, string PatientProvisionalDiagnosis, string PatientCamePreviously, DateTime? patientBirthDate, string senderName,string chiefComplaint,
            string typeOfCase, string ht, string dm, string ihd, string majorIllness, string drugAllergy, string pregenency, string bt, string admittedTimetemperature,
            string admittedTimePulse, string admittedTimeRR, string admittedTimeSpo2, string admittedTimeBp, string admittedTimeHr, string admittedTimeRbs,
            string admittedTimeEcg, string admittedTimeOther, string admittedTimeWeight, string admittedTimeHeight, string systemicExamination,
            string rs, string cvs, string cns, string pa, string other, string suggestedInvestigation, string clinicalNote, string admittedTimeTreatment,
            DateTime? operationDate, string operationTime,
/*mlc form*/bool isMlc, string mlcFormFillupName, string PatientMLCNo, string PatientEntryNo, string PatientMarkOfIdentity, string PatientEventDetail, 
            string PatientFetcherPersonName, string PatientFetcherPersonFullAddress,
            string InformerStaffPerson, string PatientInformTime, string RelatedPoliceStation, string RelatedPoliceOfficer,
/*dischage fields*/ bool isDischarge, DateTime dischargeDate, string dischargeTime, string dischargeBy, string dischargeStaffReception, string dischargeStaffReceptionMO, 
            int invoiceNo, DateTime invoiceDate, string PatientFinalDiagnosis, string conditionOnDischarge, string typeOfDischarge, string dischargeTypeTemperature,
            string dischargeTimePulse, string dischargeTimeRR, string dischargeTimeSpo2, string dischargeTimeBp, string dischargeTimeHr, string dischargeTimeRbs,
            string dischargeTimeEcg, string dischargeTimeRcg, string dischargeTimeOther, string dischargeTimeWeight, string dischargeTimeHeight, string dischargeTimeClinicalExamination,
            string dischargeTimeOperativeNote, string dischargeTimeInvestigation, string dischargeTimeTreatment, string advice, string status, string medicalOfficer, string indoorno, string billno,
            DateTime? medicalOfficeDate, string medicalOfficeTime, Guid createdbyUser, out DateTime createdOn)
        {
            bool r = false;
            createdOn = DateTime.MinValue;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Patient_Insert))
            {
                PatientParameters(cmd, guid, firstName, middleName, lastName, gender, age, address, city, district, taluko, contactNo, otherNo, residenceNo, maritalstatus,
/*patientDetails fields*/marragetimeyear, childern, notes, wardGuid, roomGuid, admittedDate, admittedtime, admittedBy, operation, followUpDate, amount, isIpd, isOpd, referenceDoctorGuid,
                    referenceDoctorShare, PatientOccupation, PatientOccupationFullAddress, PatientReference, PatientInsurance, PatientInsuranceCompany, insuranceAmount,
                    PatientOperationDateTime, PatientSigningPersonName, PatientRelationshipWith,PatientDoctorIncharge, PatientDivison, PatientPSOName, PatientReceivingStaff, 
                    receivingStaffReceptionMO, PatientMO, PatientProvisionalDiagnosis, PatientCamePreviously,patientBirthDate, senderName, chiefComplaint, typeOfCase,
                    ht,dm,ihd,majorIllness,drugAllergy,pregenency,bt,admittedTimetemperature,admittedTimePulse,admittedTimeRR,admittedTimeSpo2,admittedTimeBp,admittedTimeHr,
                    admittedTimeRbs, admittedTimeEcg, admittedTimeOther, admittedTimeWeight, admittedTimeHeight,systemicExamination, rs, cvs, cns, pa, other, 
                    suggestedInvestigation, clinicalNote, admittedTimeTreatment, operationDate, operationTime,
      /*mlc form*/  isMlc, mlcFormFillupName, PatientMLCNo, PatientEntryNo, PatientMarkOfIdentity, PatientEventDetail, PatientFetcherPersonName, PatientFetcherPersonFullAddress,
                    InformerStaffPerson, PatientInformTime, RelatedPoliceStation, RelatedPoliceOfficer,
/*dischage fields*/ isDischarge, dischargeDate, dischargeTime, dischargeBy, dischargeStaffReception, dischargeStaffReceptionMO, invoiceNo, invoiceDate, PatientFinalDiagnosis,
                    conditionOnDischarge, typeOfDischarge, dischargeTypeTemperature, dischargeTimePulse, dischargeTimeRR, dischargeTimeSpo2, dischargeTimeBp, dischargeTimeHr,
                    dischargeTimeRbs, dischargeTimeEcg, dischargeTimeRcg, dischargeTimeOther, dischargeTimeWeight,  dischargeTimeHeight,  dischargeTimeClinicalExamination,
             dischargeTimeOperativeNote, dischargeTimeInvestigation,  dischargeTimeTreatment,  advice,  status,  medicalOfficer, indoorno, billno,
             medicalOfficeDate,  medicalOfficeTime, createdbyUser);
                SqlParameter prmModifiedOn = AppDatabase.AddOutParameter(cmd, Patient.Columns.PatientModifiedOn, SqlDbType.DateTime);
                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                    createdOn = AppShared.DbValueToDateTime(prmModifiedOn.Value);
            }
            return r;
        }

        internal static bool PatientUpdate(Guid guid, string firstName, string middleName, string lastName, int gender, int age, string address, string city,
/*patientDetails fields*/  string district, string taluko, string contactNo, string otherNo, string residenceNo, int maritalstatus, decimal marragetimeyear, int childern, string notes,
            Guid wardGuid, Guid roomGuid, DateTime admittedDate, string admittedtime, string admittedBy, string operation, DateTime followUpDate, decimal amount, bool isIpd,
            bool isOpd, Guid referenceDoctorGuid, decimal referenceDoctorShare, string PatientOccupation, string PatientOccupationFullAddress, string PatientReference,
            string PatientInsurance, string PatientInsuranceCompany, string insuranceAmount, DateTime PatientOperationDateTime, string PatientSigningPersonName,
            string PatientRelationshipWith, string PatientDoctorIncharge, string PatientDivison, string PatientPSOName, string PatientReceivingStaff, string receivingStaffReceptionMO,
            string PatientMO, string PatientProvisionalDiagnosis, string PatientCamePreviously, DateTime? patientBirthDate, string senderName, string chiefComplaint,
            string typeOfCase, string ht, string dm, string ihd, string majorIllness, string drugAllergy, string pregenency, string bt, string admittedTimetemperature,
            string admittedTimePulse, string admittedTimeRR, string admittedTimeSpo2, string admittedTimeBp, string admittedTimeHr, string admittedTimeRbs,
            string admittedTimeEcg, string admittedTimeOther, string admittedTimeWeight, string admittedTimeHeight, string systemicExamination,
            string rs, string cvs, string cns, string pa, string other, string suggestedInvestigation, string clinicalNote, string admittedTimeTreatment,
            DateTime? operationDate, string operationTime,
/*mlc form*/bool isMlc, string mlcFormFillupName, string PatientMLCNo, string PatientEntryNo, string PatientMarkOfIdentity, string PatientEventDetail,
            string PatientFetcherPersonName, string PatientFetcherPersonFullAddress,
            string InformerStaffPerson, string PatientInformTime, string RelatedPoliceStation, string RelatedPoliceOfficer,
/*dischage fields*/ bool isDischarge, DateTime dischargeDate, string dischargeTime, string dischargeBy, string dischargeStaffReception, string dischargeStaffReceptionMO,
            int invoiceNo, DateTime invoiceDate, string PatientFinalDiagnosis, string conditionOnDischarge, string typeOfDischarge, string dischargeTypeTemperature,
            string dischargeTimePulse, string dischargeTimeRR, string dischargeTimeSpo2, string dischargeTimeBp, string dischargeTimeHr, string dischargeTimeRbs,
            string dischargeTimeEcg, string dischargeTimeRcg, string dischargeTimeOther, string dischargeTimeWeight, string dischargeTimeHeight, string dischargeTimeClinicalExamination,
            string dischargeTimeOperativeNote, string dischargeTimeInvestigation, string dischargeTimeTreatment, string advice, string status, string medicalOfficer, string indoorno, string billno, 
            DateTime? medicalOfficeDate, string medicalOfficeTime, Guid modifiedByUser, out DateTime modifiedOn)
        {
            bool r = false;
            modifiedOn = DateTime.MinValue;

            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Patient_Update))
            {
                PatientParameters(cmd, guid, firstName, middleName, lastName, gender, age, address, city, district, taluko, contactNo, otherNo, residenceNo, maritalstatus,
/*patientDetails fields*/marragetimeyear, childern, notes, wardGuid, roomGuid, admittedDate, admittedtime, admittedBy, operation, followUpDate, amount, isIpd, isOpd, referenceDoctorGuid,
                    referenceDoctorShare, PatientOccupation, PatientOccupationFullAddress, PatientReference, PatientInsurance, PatientInsuranceCompany, insuranceAmount,
                    PatientOperationDateTime, PatientSigningPersonName, PatientRelationshipWith, PatientDoctorIncharge, PatientDivison, PatientPSOName, PatientReceivingStaff,
                    receivingStaffReceptionMO, PatientMO, PatientProvisionalDiagnosis, PatientCamePreviously, patientBirthDate, senderName, chiefComplaint, typeOfCase,
                    ht, dm, ihd, majorIllness, drugAllergy, pregenency, bt, admittedTimetemperature, admittedTimePulse, admittedTimeRR, admittedTimeSpo2, admittedTimeBp, admittedTimeHr,
                    admittedTimeRbs, admittedTimeEcg, admittedTimeOther, admittedTimeWeight, admittedTimeHeight, systemicExamination, rs, cvs, cns, pa, other,
                    suggestedInvestigation, clinicalNote, admittedTimeTreatment, operationDate, operationTime,
/*mlc form*/        isMlc, mlcFormFillupName, PatientMLCNo, PatientEntryNo, PatientMarkOfIdentity, PatientEventDetail, PatientFetcherPersonName, PatientFetcherPersonFullAddress,
                    InformerStaffPerson, PatientInformTime, RelatedPoliceStation, RelatedPoliceOfficer,
/*dischage fields*/ isDischarge, dischargeDate, dischargeTime, dischargeBy, dischargeStaffReception, dischargeStaffReceptionMO, invoiceNo, invoiceDate, PatientFinalDiagnosis,
                    conditionOnDischarge, typeOfDischarge, dischargeTypeTemperature, dischargeTimePulse, dischargeTimeRR, dischargeTimeSpo2, dischargeTimeBp, dischargeTimeHr,
                    dischargeTimeRbs, dischargeTimeEcg, dischargeTimeRcg, dischargeTimeOther, dischargeTimeWeight, dischargeTimeHeight, dischargeTimeClinicalExamination,
             dischargeTimeOperativeNote, dischargeTimeInvestigation, dischargeTimeTreatment, advice, status, medicalOfficer, indoorno, billno,
             medicalOfficeDate, medicalOfficeTime, modifiedByUser);
                SqlParameter prmDate = AppDatabase.AddOutParameter(cmd, Patient.Columns.PatientModifiedOn, SqlDbType.DateTime);

                AppDatabase db = OpenDatabase();
                r = db != null && db.ExecuteCommand(cmd);
                if (r)
                {
                    modifiedOn = AppShared.DbValueToDateTime(prmDate.Value);
                }
            }

            return r;
        }

        internal static bool PatientDelete(Guid guid)
        {
            return Execute(Patient_Delete, Patient.Columns.PatientGuid, guid);
        }

        internal static SqlDataReader PatientSelect(Guid guid)
        {
            return GetReader(Patient_Select, Patient.Columns.PatientGuid, guid);
        }

        //internal static SqlDataReader PatientSelectAll()
        //{
        //    return GetReader(Patient_SelectAll);
        //}

        internal static SqlDataReader PatientSearch(string searchText, bool IsIpd, bool IsOPD, int isDischarge,DateTime dateFrom,DateTime dateTo)
        {
            SqlDataReader r = null;
            using (SqlCommand cmd = AppDatabase.GetStoreProcCommand(Patient_Search))
            {
                AppDatabase.AddInParameter(cmd, "@SearchText", SqlDbType.NVarChar, AppShared.ToDbLikeText(searchText));
                AppDatabase.AddInParameter(cmd, "@IsIpd", SqlDbType.Bit, IsIpd);
                AppDatabase.AddInParameter(cmd, "@IsOpd", SqlDbType.Bit, IsOPD);
                AppDatabase.AddInParameter(cmd, "@IsDischarge", SqlDbType.Int, isDischarge);
                AppDatabase.AddInParameter(cmd, "@DateFrom", SqlDbType.DateTime, AppShared.ToDbValueNullable(dateFrom));
                AppDatabase.AddInParameter(cmd, "@DateTo", SqlDbType.DateTime, AppShared.ToDbValueNullable(dateTo));
                AppDatabase db = OpenDatabase();
                if (db != null)
                    r = db.GetSqlDataReader(cmd);
            }
            return r;
        }

        internal static SqlDataReader SelectIPDPatient()
        {
            return GetReader(Select_IPDPatient);
        }

        internal static SqlDataReader SelectOPDPatient()
        {
            return GetReader(Select_OPDPatient);
        }

        private static void PatientParameters(SqlCommand cmd, Guid guid, string firstName, string middleName, string lastName, int gender, int age, string address, string city,
/*patientDetails fields*/string district, string taluko, string contactNo, string otherNo, string residenceNo, int maritalstatus, decimal marragetimeyear, int childern, string notes, 
            Guid wardGuid, Guid roomGuid, DateTime admittedDate, string admittedtime, string admittedBy, string operation, DateTime followUpDate, decimal amount, bool isIpd, 
            bool isOpd, Guid referenceDoctorGuid, decimal referenceDoctorShare, string PatientOccupation, string PatientOccupationFullAddress, string PatientReference, 
            string PatientInsurance, string PatientInsuranceCompany, string insuranceAmount, DateTime? PatientOperationDateTime, string PatientSigningPersonName, 
            string PatientRelationshipWith, string PatientDoctorIncharge, string PatientDivison, string PatientPSOName, string PatientReceivingStaff, string receivingStaffReceptionMO,
            string PatientMO, string PatientProvisionalDiagnosis, string PatientCamePreviously, DateTime? patientBirthDate, string senderName,string chiefComplaint,
            string typeOfCase, string ht, string dm, string ihd, string majorIllness, string drugAllergy, string pregenency, string bt, string admittedTimetemperature,
            string admittedTimePulse, string admittedTimeRR, string admittedTimeSpo2, string admittedTimeBp, string admittedTimeHr, string admittedTimeRbs,
            string admittedTimeEcg, string admittedTimeOther, string admittedTimeWeight, string admittedTimeHeight, string systemicExamination,
            string rs, string cvs, string cns, string pa, string other, string suggestedInvestigation, string clinicalNote, string admittedTimeTreatment,
            DateTime? operationDate, string operationTime,
/*mlc form*/bool isMlc, string mlcFormFillupName, string PatientMLCNo, string PatientEntryNo, string PatientMarkOfIdentity, string PatientEventDetail, 
            string PatientFetcherPersonName, string PatientFetcherPersonFullAddress,
            string InformerStaffPerson, string PatientInformTime, string RelatedPoliceStation, string RelatedPoliceOfficer,
/*dischage fields*/ bool isDischarge, DateTime? dischargeDate, string dischargeTime, string dischargeBy, string dischargeStaffReception, string dischargeStaffReceptionMO, 
            int invoiceNo, DateTime? invoiceDate, string PatientFinalDiagnosis, string conditionOnDischarge, string typeOfDischarge, string dischargeTypeTemperature,
            string dischargeTimePulse, string dischargeTimeRR, string dischargeTimeSpo2, string dischargeTimeBp, string dischargeTimeHr, string dischargeTimeRbs,
            string dischargeTimeEcg, string dischargeTimeRcg, string dischargeTimeOther, string dischargeTimeWeight, string dischargeTimeHeight, string dischargeTimeClinicalExamination,
            string dischargeTimeOperativeNote, string dischargeTimeInvestigation, string dischargeTimeTreatment, string advice, string status, string medicalOfficer, string indoorno, string billno,
            DateTime? medicalOfficeDate, string medicalOfficeTime, Guid modifiedBy)
        {
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientGuid, SqlDbType.UniqueIdentifier, guid);

            #region patientdetailsparameteres

            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientFirstName, SqlDbType.NVarChar, AppShared.SafeString(firstName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMiddleName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(middleName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientLastName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(lastName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientGender, SqlDbType.Int, gender);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAge, SqlDbType.Int, AppShared.ToDbValueNullable(age));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAddress, SqlDbType.NVarChar, AppShared.ToDbValueNullable(address));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientCity, SqlDbType.NVarChar, AppShared.ToDbValueNullable(city));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDistrict, SqlDbType.NVarChar, AppShared.ToDbValueNullable(district));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientTaluko, SqlDbType.NVarChar, AppShared.ToDbValueNullable(taluko));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientContactNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(contactNo));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOtherNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(otherNo));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientResidenceNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(residenceNo));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMaritalStatus, SqlDbType.Int, maritalstatus);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMarrageTimeyear, SqlDbType.Decimal, AppShared.ToDbValueNullable(marragetimeyear));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientChildern, SqlDbType.Int, AppShared.ToDbValueNullable(childern));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientWardGuid, SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(wardGuid));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientRoomGuid, SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(roomGuid));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(admittedDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedtime));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedBy, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedBy));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientIsIPD, SqlDbType.Bit, isIpd);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientIsOPD, SqlDbType.Bit, isOpd);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientReferenceDoctorGuid, SqlDbType.UniqueIdentifier, AppShared.ToDbValueNullable(referenceDoctorGuid));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientReferenceDoctorShare, SqlDbType.Decimal, AppShared.ToDbValueNullable(referenceDoctorShare));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOccupation, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientOccupation));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOccupationFullAddress, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientOccupationFullAddress));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientReference, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientReference));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInsurance, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientInsurance));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInsuranceCompany, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientInsuranceCompany));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInsuranceAmount, SqlDbType.NVarChar, AppShared.ToDbValueNullable(insuranceAmount));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientSigningPersonName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientSigningPersonName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientRelationshipWith, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientRelationshipWith));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDoctorIncharge, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientDoctorIncharge));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDivison, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientDivison));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientPSOName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientPSOName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientReceivingStaff, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientReceivingStaff));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientReceivingStaffReceptionMO, SqlDbType.NVarChar, AppShared.ToDbValueNullable(receivingStaffReceptionMO));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMO, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientMO));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientProvisionalDiagnosis, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientProvisionalDiagnosis));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientCamePreviously, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientCamePreviously));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientBirthDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(patientBirthDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientSenderName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(senderName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientChiefComplaint, SqlDbType.NVarChar, AppShared.ToDbValueNullable(chiefComplaint));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientTypeOfCase, SqlDbType.NVarChar, AppShared.ToDbValueNullable(typeOfCase));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientHt, SqlDbType.NVarChar, AppShared.ToDbValueNullable(ht));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDm, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dm));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientIhd, SqlDbType.NVarChar, AppShared.ToDbValueNullable(ihd));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMajorIllness, SqlDbType.NVarChar, AppShared.ToDbValueNullable(majorIllness));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDrugAllergy, SqlDbType.NVarChar, AppShared.ToDbValueNullable(drugAllergy));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientPregnency, SqlDbType.NVarChar, AppShared.ToDbValueNullable(pregenency));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientBt, SqlDbType.NVarChar, AppShared.ToDbValueNullable(bt));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeTemperature, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimetemperature));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimePulse, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimePulse));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeRr, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeRR));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeSpo2, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeSpo2));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeBp, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeBp));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeHr, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeHr));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeRbs, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeRbs));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeEcg, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeEcg));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeOther, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeOther));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeWeight, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeWeight));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeHeight, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeHeight));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientSystemicExamination, SqlDbType.NVarChar, AppShared.ToDbValueNullable(systemicExamination));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientRs, SqlDbType.NVarChar, AppShared.ToDbValueNullable(rs));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientCvs, SqlDbType.NVarChar, AppShared.ToDbValueNullable(cvs));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientCNS, SqlDbType.NVarChar, AppShared.ToDbValueNullable(cns));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientPa, SqlDbType.NVarChar, AppShared.ToDbValueNullable(pa));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOther, SqlDbType.NVarChar, AppShared.ToDbValueNullable(other));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientSuggestedInvstigation, SqlDbType.NVarChar, AppShared.ToDbValueNullable(suggestedInvestigation));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientClinicalNote, SqlDbType.NVarChar, AppShared.ToDbValueNullable(clinicalNote));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAdmittedTimeTreatment, SqlDbType.NVarChar, AppShared.ToDbValueNullable(admittedTimeTreatment));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOperationDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(operationDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOperationTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(operationTime));

            #endregion

            #region mlcrelatedparameters

            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientIsMlc, SqlDbType.Bit, AppShared.ToDbValueNullable(isMlc));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMlcFormFillUpName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(mlcFormFillupName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMLCNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientMLCNo));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientEntryNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientEntryNo));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMarkOfIdentity, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientMarkOfIdentity));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientEventDetail, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientEventDetail));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientFetcherPersonName, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientFetcherPersonName));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientFetcherPersonFullAddress, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientFetcherPersonFullAddress));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInformerStaffPerson, SqlDbType.NVarChar, AppShared.ToDbValueNullable(InformerStaffPerson));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInformTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientInformTime));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientRelatedPoliceStation, SqlDbType.NVarChar, AppShared.ToDbValueNullable(RelatedPoliceStation));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientRelatedPoliceOfficer, SqlDbType.NVarChar, AppShared.ToDbValueNullable(RelatedPoliceOfficer));

            #endregion

            #region dischargerelatedparameters

            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientIsDischarge, SqlDbType.Bit, isDischarge);
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatiendDischargeDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(dischargeDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTime));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeBy, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeBy));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeStaffReception, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeStaffReception));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeStaffReceptionMO, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeStaffReceptionMO));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInvoiceNo, SqlDbType.Int, AppShared.ToDbValueNullable(invoiceNo));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientInvoiceDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(invoiceDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientFinalDiagnosis, SqlDbType.NVarChar, AppShared.ToDbValueNullable(PatientFinalDiagnosis));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientConditionOnDischarge, SqlDbType.NVarChar, AppShared.ToDbValueNullable(conditionOnDischarge));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientTypeOfDischarge, SqlDbType.NVarChar, AppShared.ToDbValueNullable(typeOfDischarge));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeTemperature, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTypeTemperature));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimePulse, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimePulse));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeRr, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeRR));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeSpo2, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeSpo2));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeBp, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeBp));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeHr, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeHr));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeRbs, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeRbs));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeEcg, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeEcg));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeOther, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeOther));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeWeight, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeWeight));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeHeight, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeHeight));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeClinicalExamination, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeClinicalExamination));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeOperativeNote, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeOperativeNote));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeInvestigation, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeInvestigation));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeTreatment, SqlDbType.NVarChar, AppShared.ToDbValueNullable(dischargeTimeTreatment));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientDischargeTimeAdvice, SqlDbType.NVarChar, AppShared.ToDbValueNullable(advice));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientStatus, SqlDbType.NVarChar, AppShared.ToDbValueNullable(status));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMedicalOfficer, SqlDbType.NVarChar, AppShared.ToDbValueNullable(medicalOfficer));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMedicalOfficerDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(medicalOfficeDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientMedicalOfficerTime, SqlDbType.NVarChar, AppShared.ToDbValueNullable(medicalOfficeTime));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientIndoorNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(indoorno));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientBillNo, SqlDbType.NVarChar, AppShared.ToDbValueNullable(billno));

            #endregion

            #region otherFields

            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientNotes, SqlDbType.NVarChar, AppShared.ToDbValueNullable(notes));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOperation, SqlDbType.NVarChar, AppShared.ToDbValueNullable(operation));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientFollowUpDate, SqlDbType.DateTime, AppShared.ToDbValueNullable(followUpDate));
            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientAmountReceived, SqlDbType.Decimal, AppShared.ToDbValueNullable(amount));

            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientOperationDateTime, SqlDbType.DateTime, AppShared.ToDbValueNullable(PatientOperationDateTime));

            #endregion

            AppDatabase.AddInParameter(cmd, Patient.Columns.PatientModifiedBy, SqlDbType.UniqueIdentifier, modifiedBy);
        }
    }
}
