using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security.Principal;

namespace Hospital.Object
{
    public sealed class Patient : Objectbase
    {
        internal struct Columns
        {

            #region patientDetailField
            public const string PatientId = "PatientId";
            public const string PatientGuid = "PatientGuid";
            public const string PatientNo = "PatientNo";
            public const string PatientFirstName = "PatientFirstName";
            public const string PatientMiddleName = "PatientMiddleName";
            public const string PatientLastName = "PatientLastName";
            public const string PatientGender = "PatientGender";
            public const string PatientAge = "PatientAge";
            public const string PatientAddress = "PatientAddress";
            public const string PatientCity = "PatientCity";
            public const string PatientDistrict = "PatientDistrict";
            public const string PatientTaluko = "PatientTaluko";
            public const string PatientContactNo = "PatientContactNo";
            public const string PatientOtherNo = "PatientOtherNo";
            public const string PatientResidenceNo = "PatientResidenceNo";
            public const string PatientMaritalStatus = "PatientMaritalStatus";
            public const string PatientMarrageTimeyear = "PatientMarrageTimeyear";
            public const string PatientChildern = "PatientChildern";
            public const string PatientNotes = "PatientNotes";
            public const string PatientWardGuid = "PatientWardGuid";
            public const string PatientRoomGuid = "PatientRoomGuid";
            public const string PatientAdmittedDate = "PatientAdmittedDate";
            public const string PatientAdmittedTime = "PatientAdmittedTime";
            public const string PatientAdmittedBy = "PatientAdmittedBy";
            public const string PatientOperation = "PatientOperation";
            public const string PatientFollowUpDate = "PatientFollowUpDate";
            public const string PatientAmountReceived = "PatientAmountReceived";
            public const string PatientIsIPD = "PatientIsIPD";
            public const string PatientIsOPD = "PatientIsOPD";
            public const string PatientReferenceDoctorGuid = "PatientReferenceDoctorGuid";
            public const string PatientReferenceDoctorShare = "PatientReferenceDoctorShare";
            public const string PatientOccupation = "PatientOccupation";
            public const string PatientOccupationFullAddress = "PatientOccupationFullAddress";
            public const string PatientReference = "PatientReference";
            public const string PatientInsurance = "PatientInsurance";
            public const string PatientInsuranceCompany = "PatientInsuranceCompany";
            public const string PatientInsuranceAmount = "PatientInsuranceAmount";
            public const string PatientOperationDateTime = "PatientOperationDateTime";
            public const string PatientSigningPersonName = "PatientSigningPersonName";
            public const string PatientRelationshipWith = "PatientRelationshipWith";
            public const string PatientDoctorIncharge = "PatientDoctorIncharge";
            public const string PatientDivison = "PatientDivison";
            public const string PatientPSOName = "PatientPSOName";
            public const string PatientReceivingStaff = "PatientReceivingStaff";
            public const string PatientReceivingStaffReceptionMO = "PatientReceivingStaffReceptionMO";
            public const string PatientMO = "PatientMO";
            public const string PatientProvisionalDiagnosis = "PatientProvisionalDiagnosis";
            public const string PatientCamePreviously = "PatientCamePreviously";
            //baki dal ma
            public const string PatientBirthDate = "PatientBirthDate";
            public const string PatientSenderName = "PatientSenderName";
            public const string PatientChiefComplaint = "PatientChiefComplaint";
            public const string PatientTypeOfCase = "PatientTypeOfCase";
            public const string PatientHt = "PatientHt";
            public const string PatientDm = "PatientDm";
            public const string PatientIhd = "PatientIhd";
            public const string PatientMajorIllness = "PatientMajorIllness";
            public const string PatientDrugAllergy = "PatientDrugAllergy";
            public const string PatientPregnency = "PatientPregnency";
            public const string PatientBt = "PatientBt";
            public const string PatientAdmittedTimeTemperature = "PatientAdmittedTimeTemperature";
            public const string PatientAdmittedTimePulse = "PatientAdmittedTimePulse";
            public const string PatientAdmittedTimeRr = "PatientAdmittedTimeRr";
            public const string PatientAdmittedTimeSpo2 = "PatientAdmittedTimeSpo2";
            public const string PatientAdmittedTimeBp = "PatientAdmittedTimeBp";
            public const string PatientAdmittedTimeHr = "PatientAdmittedTimeHr";
            public const string PatientAdmittedTimeRbs = "PatientAdmittedTimeRbs";
            public const string PatientAdmittedTimeEcg = "PatientAdmittedTimeEcg";
            public const string PatientAdmittedTimeOther = "PatientAdmittedTimeOther";
            public const string PatientAdmittedTimeWeight = "PatientAdmittedTimeWeight";
            public const string PatientAdmittedTimeHeight = "PatientAdmittedTimeHeight";
            public const string PatientSystemicExamination = "PatientSystemicExamination";
            public const string PatientRs = "PatientRs";
            public const string PatientCvs = "PatientCvs";
            public const string PatientCNS = "PatientCNS";
            public const string PatientPa = "PatientPa";
            public const string PatientOther = "PatientOther";
            public const string PatientSuggestedInvstigation = "PatientSuggestedInvstigation";
            public const string PatientClinicalNote = "PatientClinicalNote";
            public const string PatientAdmittedTimeTreatment = "PatientAdmittedTimeTreatment";
            public const string PatientOperationDate = "PatientOperationDate";
            public const string PatientOperationTime = "PatientOperationTime";

            #endregion

            #region mlcforlfield

            public const string PatientIsMlc = "PatientIsMlc";
            public const string PatientMlcFormFillUpName = "PatientMlcFormFillUpName";
            public const string PatientMLCNo = "PatientMLCNo";
            public const string PatientEntryNo = "PatientEntryNo";
            public const string PatientMarkOfIdentity = "PatientMarkOfIdentity";
            public const string PatientEventDetail = "PatientEventDetail";
            public const string PatientFetcherPersonName = "PatientFetcherPersonName";
            public const string PatientFetcherPersonFullAddress = "PatientFetcherPersonFullAddress";
            public const string PatientInformerStaffPerson = "PatientInformerStaffPerson";
            public const string PatientInformTime = "PatientInformTime";
            public const string PatientRelatedPoliceStation = "PatientRelatedPoliceStation";
            public const string PatientRelatedPoliceOfficer = "PatientRelatedPoliceOfficer";


            #endregion

            #region DischargeField

            public const string PatientIsDischarge = "PatientIsDischarge";
            public const string PatiendDischargeDate = "PatiendDischargeDate";
            public const string PatientDischargeTime = "PatientDischargeTime";
            public const string PatientDischargeBy = "PatientDischargeBy";
            public const string PatientDischargeStaffReception = "PatientDischargeStaffReception";
            public const string PatientDischargeStaffReceptionMO = "PatientDischargeStaffReceptionMO";
            public const string PatientInvoiceNo = "PatientInvoiceNo";
            public const string PatientInvoiceDate = "PatientInvoiceDate";
            public const string PatientFinalDiagnosis = "PatientFinalDiagnosis";
            public const string PatientConditionOnDischarge = "PatientConditionOnDischarge";
            public const string PatientTypeOfDischarge = "PatientTypeOfDischarge";
            public const string PatientDischargeTimeTemperature = "PatientDischargeTimeTemperature";
            public const string PatientDischargeTimePulse = "PatientDischargeTimePulse";
            public const string PatientDischargeTimeRr = "PatientDischargeTimeRr";
            public const string PatientDischargeTimeSpo2 = "PatientDischargeTimeSpo2";
            public const string PatientDischargeTimeBp = "PatientDischargeTimeBp";
            public const string PatientDischargeTimeHr = "PatientDischargeTimeHr";
            public const string PatientDischargeTimeRbs = "PatientDischargeTimeRbs";
            public const string PatientDischargeTimeEcg = "PatientDischargeTimeEcg";
            public const string PatientDischargeTimeOther = "PatientDischargeTimeOther";
            public const string PatientDischargeTimeWeight = "PatientDischargeTimeWeight";
            public const string PatientDischargeTimeHeight = "PatientDischargeTimeHeight";
            public const string PatientDischargeTimeClinicalExamination = "PatientDischargeTimeClinicalExamination";
            public const string PatientDischargeTimeOperativeNote = "PatientDischargeTimeOperativeNote";
            public const string PatientDischargeTimeInvestigation = "PatientDischargeTimeInvestigation";
            public const string PatientDischargeTimeTreatment = "PatientDischargeTimeTreatment";
            public const string PatientDischargeTimeAdvice = "PatientDischargeTimeAdvice";
            public const string PatientStatus = "PatientStatus";
            public const string PatientMedicalOfficer = "PatientMedicalOfficer";
            public const string PatientMedicalOfficerDate = "PatientMedicalOfficerDate";
            public const string PatientMedicalOfficerTime = "PatientMedicalOfficerTime";
            public const string PatientIndoorNo = "PatientIndoorNo";
            public const string PatientBillNo = "PatientBillNo";

            #endregion

            #region generelfield

            public const string PatientCreatedBy = "PatientCreatedBy";
            public const string PatientCreatedOn = "PatientCreatedOn";
            public const string PatientModifiedBy = "PatientModifiedBy";
            public const string PatientModifiedOn = "PatientModifiedOn";
            public const string MaxInvoiceNo = "MaxInvoiceNo";
            
            #endregion


        }

        #region Constructor

        public Patient() : base() { }

        public Patient(Guid key) : base(key) { }

        public Patient(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        #region patientdetailsproperties


        public override string DisplayName
        {
            get { return this.mFirstName + " " + this.mLastName; }
        }

        private int mNumber;
        public int Number
        {
            get { return this.mNumber; }
            set { this.mNumber = value; }
        }

        private string mFirstName;
        public string FirstName
        {
            get { return this.mFirstName; }
            set { this.mFirstName = value; }
        }

        private string mMiddleName;
        public string MiddleName
        {
            get { return this.mMiddleName; }
            set { this.mMiddleName = value; }
        }

        private string mLastName;
        public string LastName
        {
            get { return this.mLastName; }
            set { this.mLastName = value; }
        }

        private Gender mGender;
        public Gender Gender
        {
            get { return this.mGender; }
            set { this.mGender = value; }
        }

        private int mAge;
        public int Age
        {
            get { return this.mAge; }
            set { this.mAge = value; }
        }

        private string mAddress;
        public string Address
        {
            get { return this.mAddress; }
            set { this.mAddress = value; }
        }

        private string mCity;
        public string City
        {
            get { return this.mCity; }
            set { this.mCity = value; }
        }

        private string mDistrict;
        public string District
        {
            get { return this.mDistrict; }
            set { this.mDistrict = value; }
        }

        private string mTaluko;
        public string Taluko
        {
            get { return this.mTaluko; }
            set { this.mTaluko = value; }
        }

        private string mContactNo;
        public string ContactNo
        {
            get { return this.mContactNo; }
            set { this.mContactNo = value; }
        }

        private string mOtherNo;
        public string OtherNo
        {
            get { return this.mOtherNo; }
            set { this.mOtherNo = value; }
        }

        private string mResidenceNo;
        public string ResidenceNo
        {
            get { return this.mResidenceNo; }
            set { this.mResidenceNo = value; }
        }

        private MaritalStatus mPatientMaritalStatus;
        public MaritalStatus PatientMaritalStatus
        {
            get { return this.mPatientMaritalStatus; }
            set { this.mPatientMaritalStatus = value; }
        }

        private decimal mMarrageTimeyear;
        public decimal MarrageTimeyear
        {
            get { return this.mMarrageTimeyear; }
            set { this.mMarrageTimeyear = value; }
        }

        private int mChildern;
        public int Childern
        {
            get { return this.mChildern; }
            set { this.mChildern = value; }
        }


        private string mNotes;
        public string Notes
        {
            get { return this.mNotes; }
            set { this.mNotes = value; }
        }

        private Guid mWardGuid;
        public Guid WardGuid
        {
            get { return this.mWardGuid; }
            set { this.mWardGuid = value; }
        }

        private Ward mWard;
        public Ward Ward
        {
            get
            {
                if (IsNullOrEmpty(this.mWard) || this.mWard.ObjectGuid != this.mWardGuid)
                    this.mWard = (this.mWardGuid != Guid.Empty ? new Ward(this.mWardGuid) : null);
                return this.mWard;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mWardGuid = Guid.Empty;
                    this.mWard = null;
                }
                else
                {
                    this.mWardGuid = value.ObjectGuid;
                    this.mWard = value;
                }
            }
        }

        public string WardName
        {
            get
            {
                Ward obj = this.Ward;
                return IsNullOrEmpty(obj) ? string.Empty : obj.Name;
            }
        }

        private Guid mRoomGuid;
        public Guid RoomGuid
        {
            get { return this.mRoomGuid; }
            set { this.mRoomGuid = value; }
        }

        private Room mRoom;
        public Room Room
        {
            get
            {
                if (IsNullOrEmpty(this.mRoom) || this.mRoom.ObjectGuid != this.mRoomGuid)
                    this.mRoom = (this.mRoomGuid != Guid.Empty ? new Room(this.mRoomGuid) : null);
                return this.mRoom;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mRoomGuid = Guid.Empty;
                    this.mRoom = null;
                }
                else
                {
                    this.mRoomGuid = value.ObjectGuid;
                    this.mRoom = value;
                }
            }
        }

        public string RoomTypeName
        {
            get
            {
                Room obj = this.Room;
                return IsNullOrEmpty(obj) ? string.Empty : obj.Type;
            }
        }

        private DateTime mAdmittedDate;
        public DateTime AdmittedDate
        {
            get
            {
                return this.mAdmittedDate;
            }
            set
            {
                this.mAdmittedDate = value;
            }
        }

        private string mAdmittedTime;
        public string AdmittedTime
        {
            get
            {
                return this.mAdmittedTime;
            }
            set
            {
                this.mAdmittedTime = value;
            }
        }

        private string mAdmittedBy;
        public string AdmittedBy
        {
            get
            {
                return this.mAdmittedBy;
            }
            set
            {
                this.mAdmittedBy = value;
            }
        }

        private string mOpetation;
        public string Operation
        {
            get
            {
                return this.mOpetation;
            }
            set
            {
                this.mOpetation = value;
            }
        }

        private DateTime mFollowUpDate;
        public DateTime FollowUpDate
        {
            get { return this.mFollowUpDate; }
            set { this.mFollowUpDate = value; }
        }

        private decimal mAmountReceived;
        public decimal AmountReceived
        {
            get { return this.mAmountReceived; }
            set { this.mAmountReceived = value; }
        }

        private bool mIsIPD;
        public bool IsIPD
        {
            get { return this.mIsIPD; }
            set { this.mIsIPD = value; }
        }

        private bool mIsOPD;
        public bool IsOPD
        {
            get { return this.mIsOPD; }
            set { this.mIsOPD = value; }
        }

        private Guid mReferenceDoctorGuid;
        public Guid ReferenceDoctorGuid
        {
            get { return this.mReferenceDoctorGuid; }
            set { this.mReferenceDoctorGuid = value; }
        }

        private ReferenceDoctor mReferenceDoctor;
        public ReferenceDoctor ReferenceDoctor
        {
            get
            {
                if (IsNullOrEmpty(this.mReferenceDoctor) || this.mReferenceDoctor.ObjectGuid != this.mReferenceDoctorGuid)
                    this.mReferenceDoctor = (this.mReferenceDoctorGuid != Guid.Empty ? new ReferenceDoctor(this.mReferenceDoctorGuid) : null);
                return this.mReferenceDoctor;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mReferenceDoctorGuid = Guid.Empty;
                    this.mReferenceDoctor = null;
                }
                else
                {
                    this.mReferenceDoctorGuid = value.ObjectGuid;
                    this.mReferenceDoctor = value;
                }
            }
        }

        public string ReferenceDoctorName
        {
            get
            {
                ReferenceDoctor obj = this.ReferenceDoctor;
                return IsNullOrEmpty(obj) ? string.Empty : obj.Name;
            }
        }

        private decimal mReferenceDoctorShare;
        public decimal ReferenceDoctorShare
        {
            get { return this.mReferenceDoctorShare; }
            set { this.mReferenceDoctorShare = value; }
        }

        private string mPatientOccupation;
        public string PatientOccupation
        {
            get { return this.mPatientOccupation; }
            set { this.mPatientOccupation = value; }
        }

        private string mPatientOccupationFullAddress;
        public string PatientOccupationFullAddress
        {
            get { return this.mPatientOccupationFullAddress; }
            set { this.mPatientOccupationFullAddress = value; }
        }

        private string mPatientReference;
        public string PatientReference
        {
            get { return this.mPatientReference; }
            set { this.mPatientReference = value; }
        }

        private string mPatientInsurance;
        public string PatientInsurance
        {
            get { return this.mPatientInsurance; }
            set { this.mPatientInsurance = value; }
        }

        private string mPatientInsuranceCompany;
        public string PatientInsuranceCompany
        {
            get { return this.mPatientInsuranceCompany; }
            set { this.mPatientInsuranceCompany = value; }
        }

        private string mInsuranceAmount;
        public string InsuranceAmount
        {
            get { return this.mInsuranceAmount; }
            set { this.mInsuranceAmount = value; }
        }

        private DateTime mPatientOperationDateTime;
        public DateTime PatientOperationDateTime
        {
            get { return this.mPatientOperationDateTime; }
            set { this.mPatientOperationDateTime = value; }
        }

        private string mPatientSigningPersonName;
        public string PatientSigningPersonName
        {
            get { return this.mPatientSigningPersonName; }
            set { this.mPatientSigningPersonName = value; }
        }

        private string mPatientRelationshipWith;
        public string PatientRelationshipWith
        {
            get { return this.mPatientRelationshipWith; }
            set { this.mPatientRelationshipWith = value; }
        }

        private string mPatientDoctorIncharge;
        public string PatientDoctorIncharge
        {
            get { return this.mPatientDoctorIncharge; }
            set { this.mPatientDoctorIncharge = value; }
        }

        private string mPatientDivison;
        public string PatientDivison
        {
            get { return this.mPatientDivison; }
            set { this.mPatientDivison = value; }
        }

        private string mPatientPSOName;
        public string PatientPSOName
        {
            get { return this.mPatientPSOName; }
            set { this.mPatientPSOName = value; }
        }

        private string mPatientReceivingStaff;
        public string PatientReceivingStaff
        {
            get { return this.mPatientReceivingStaff; }
            set { this.mPatientReceivingStaff = value; }
        }

        private string mReceivingStaffReceptionMO;
        public string ReceivingStaffReceptionMO
        {
            get { return this.mReceivingStaffReceptionMO; }
            set { this.mReceivingStaffReceptionMO = value; }
        }

        private string mPatientMO;
        public string PatientMO
        {
            get { return this.mPatientMO; }
            set { this.mPatientMO = value; }
        }

        private string mPatientProvisionalDiagnosis;
        public string PatientProvisionalDiagnosis
        {
            get { return this.mPatientProvisionalDiagnosis; }
            set { this.mPatientProvisionalDiagnosis = value; }
        }

        private string mPatientCamePreviously;
        public string PatientCamePreviously
        {
            get { return this.mPatientCamePreviously; }
            set { this.mPatientCamePreviously = value; }
        }

        private string mPatientSenderName;
        public string PatientSenderName
        {
            get { return this.mPatientSenderName; }
            set { this.mPatientSenderName = value; }
        }

        private DateTime mPatientBirthDate;
        public DateTime PatientBirthDate
        {
            get { return this.mPatientBirthDate; }
            set { this.mPatientBirthDate = value; }
        }

        private string mPatientChiefComplaint;
        public string PatientChiefComplaint
        {
            get { return this.mPatientChiefComplaint; }
            set { this.mPatientChiefComplaint = value; }
        }

        private string mPatientTypeOfCase;
        public string PatientTypeOfCase
        {
            get { return this.mPatientTypeOfCase; }
            set { this.mPatientTypeOfCase = value; }
        }

        private string mPatientHt;
        public string PatientHt
        {
            get { return this.mPatientHt; }
            set { this.mPatientHt = value; }
        }

        private string mPatientDm;
        public string PatientDm
        {
            get { return this.mPatientDm; }
            set { this.mPatientDm = value; }
        }

        private string mPatientIhd;
        public string PatientIhd
        {
            get { return this.mPatientIhd; }
            set { this.mPatientIhd = value; }
        }

        private string mPatientMajorIllness;
        public string PatientMajorIllness
        {
            get { return this.mPatientMajorIllness; }
            set { this.mPatientMajorIllness = value; }
        }

        private string mPatientDrugAllergy;
        public string PatientDrugAllergy
        {
            get { return this.mPatientDrugAllergy; }
            set { this.mPatientDrugAllergy = value; }
        }

        private string mPatientPregnency;
        public string PatientPregnency
        {
            get { return this.mPatientPregnency; }
            set { this.mPatientPregnency = value; }
        }

        private string mPatientBt;
        public string PatientBt
        {
            get { return this.mPatientBt; }
            set { this.mPatientBt = value; }
        }

        private string mPatientAdmittedTimeTemperature;
        public string PatientAdmittedTimeTemperature
        {
            get { return this.mPatientAdmittedTimeTemperature; }
            set { this.mPatientAdmittedTimeTemperature = value; }
        }

        private string mPatientAdmittedTimePulse;
        public string PatientAdmittedTimePulse
        {
            get { return this.mPatientAdmittedTimePulse; }
            set { this.mPatientAdmittedTimePulse = value; }
        }

        private string mPatientAdmittedTimeRr;
        public string PatientAdmittedTimeRr
        {
            get { return this.mPatientAdmittedTimeRr; }
            set { this.mPatientAdmittedTimeRr = value; }
        }

        private string mPatientAdmittedTimeSpo2;
        public string PatientAdmittedTimeSpo2
        {
            get { return this.mPatientAdmittedTimeSpo2; }
            set { this.mPatientAdmittedTimeSpo2 = value; }
        }

        private string mPatientAdmittedTimeBp;
        public string PatientAdmittedTimeBp
        {
            get { return this.mPatientAdmittedTimeBp; }
            set { this.mPatientAdmittedTimeBp = value; }
        }

        private string mPatientAdmittedTimeHr;
        public string PatientAdmittedTimeHr
        {
            get { return this.mPatientAdmittedTimeHr; }
            set { this.mPatientAdmittedTimeHr = value; }
        }

        private string mPatientAdmittedTimeRbs;
        public string PatientAdmittedTimeRbs
        {
            get { return this.mPatientAdmittedTimeRbs; }
            set { this.mPatientAdmittedTimeRbs = value; }
        }

        private string mPatientAdmittedTimeEcg;
        public string PatientAdmittedTimeEcg
        {
            get { return this.mPatientAdmittedTimeEcg; }
            set { this.mPatientAdmittedTimeEcg = value; }
        }

        private string mPatientAdmittedTimeOther;
        public string PatientAdmittedTimeOther
        {
            get { return this.mPatientAdmittedTimeOther; }
            set { this.mPatientAdmittedTimeOther = value; }
        }

        private string mPatientAdmittedTimeWeight;
        public string PatientAdmittedTimeWeight
        {
            get { return this.mPatientAdmittedTimeWeight; }
            set { this.mPatientAdmittedTimeWeight = value; }
        }

        private string mPatientAdmittedTimeHeight;
        public string PatientAdmittedTimeHeight
        {
            get { return this.mPatientAdmittedTimeHeight; }
            set { this.mPatientAdmittedTimeHeight = value; }
        }

        private string mPatientSystemicExamination;
        public string PatientSystemicExamination
        {
            get { return this.mPatientSystemicExamination; }
            set { this.mPatientSystemicExamination = value; }
        }

        private string mPatientRs;
        public string PatientRs
        {
            get { return this.mPatientRs; }
            set { this.mPatientRs = value; }
        }

        private string mPatientCvs;
        public string PatientCvs
        {
            get { return this.mPatientCvs; }
            set { this.mPatientCvs = value; }
        }

        private string mPatientCNS;
        public string PatientCNS
        {
            get { return this.mPatientCNS; }
            set { this.mPatientCNS = value; }
        }

        private string mPatientPa;
        public string PatientPa
        {
            get { return this.mPatientPa; }
            set { this.mPatientPa = value; }
        }

        private string mPatientOther;
        public string PatientOther
        {
            get { return this.mPatientOther; }
            set { this.mPatientOther = value; }
        }

        private string mPatientSuggestedInvstigation;
        public string PatientSuggestedInvstigation
        {
            get { return this.mPatientSuggestedInvstigation; }
            set { this.mPatientSuggestedInvstigation = value; }
        }

        private string mPatientClinicalNote;
        public string PatientClinicalNote
        {
            get { return this.mPatientClinicalNote; }
            set { this.mPatientClinicalNote = value; }
        }

        private string mPatientAdmittedTimeTreatment;
        public string PatientAdmittedTimeTreatment
        {
            get { return this.mPatientAdmittedTimeTreatment; }
            set { this.mPatientAdmittedTimeTreatment = value; }
        }

        private DateTime mPatientOperationDate;
        public DateTime PatientOperationDate
        {
            get { return this.mPatientOperationDate; }
            set { this.mPatientOperationDate = value; }
        }


        private string mPatientOperationTime;
        public string PatientOperationTime
        {
            get { return this.mPatientOperationTime; }
            set { this.mPatientOperationTime = value; }
        }
        #endregion


        #region mlcformproperties

        private bool mIsMlc;
        public bool IsMlc
        {
            get { return this.mIsMlc; }
            set { this.mIsMlc = value; }
        }

        private string mMlcFormFillUpName;
        public string MlcFormFillUpName
        {
            get { return this.mMlcFormFillUpName; }
            set { this.mMlcFormFillUpName = value; }
        }

        private string mPatientFetcherPersonName;
        public string PatientFetcherPersonName
        {
            get { return this.mPatientFetcherPersonName; }
            set { this.mPatientFetcherPersonName = value; }

        }

        private string mPatientFetcherPersonFullAddress;
        public string PatientFetcherPersonFullAddress
        {
            get { return this.mPatientFetcherPersonFullAddress; }
            set { this.mPatientFetcherPersonFullAddress = value; }

        }

        private string mPatientMLCNo;
        public string PatientMLCNo
        {
            get { return this.mPatientMLCNo; }
            set { this.mPatientMLCNo = value; }
        }

        private string mPatientEntryNo;
        public string PatientEntryNo
        {
            get { return this.mPatientEntryNo; }
            set { this.mPatientEntryNo = value; }
        }

        private string mRelatedPoliceStation;
        public string RelatedPoliceStation
        {
            get { return this.mRelatedPoliceStation; }
            set { this.mRelatedPoliceStation = value; }
        }

        private string mRelatedPoliceOfficer;
        public string RelatedPoliceOfficer
        {
            get { return this.mRelatedPoliceOfficer; }
            set { this.mRelatedPoliceOfficer = value; }
        }

        private string mInformTime;
        public string InformTime
        {
            get
            {
                return this.mInformTime;
            }
            set
            {
                this.mInformTime = value;
            }
        }

        private string mInformerStaffPerson;
        public string InformerStaffPerson
        {
            get { return this.mInformerStaffPerson; }
            set { this.mInformerStaffPerson = value; }
        }

        private string mPatientEventDetail;
        public string PatientEventDetail
        {
            get { return this.mPatientEventDetail; }
            set { this.mPatientEventDetail = value; }
        }

        private string mPatientMarkOfIdentity;
        public string PatientMarkOfIdentity
        {
            get { return this.mPatientMarkOfIdentity; }
            set { this.mPatientMarkOfIdentity = value; }
        }

        #endregion

        #region Dischargefieldproperties

        private bool mIsDischarge;
        public bool IsDischarge
        {
            get { return this.mIsDischarge; }
            set { this.mIsDischarge = value; }

        }

        private DateTime mDischargeDate;
        public DateTime DischargeDate
        {
            get { return this.mDischargeDate; }
            set { this.mDischargeDate = value; }
        }

        private string mDischargeTime;
        public string DischargeTime
        {
            get
            {
                return this.mDischargeTime;
            }
            set
            {
                this.mDischargeTime = value;
            }
        }

        private string mDischargeBy;
        public string DischargeBy
        {
            get
            {
                return this.mDischargeBy;
            }
            set
            {
                this.mDischargeBy = value;
            }
        }

        private string mDischargeStaffReception;
        public string DischargeStaffReception
        {
            get
            {
                return this.mDischargeStaffReception;
            }
            set
            {
                this.mDischargeStaffReception = value;
            }
        }

        private string mDischargeStaffReceptionMO;
        public string DischargeStaffReceptionMO
        {
            get
            {
                return this.mDischargeStaffReceptionMO;
            }
            set
            {
                this.mDischargeStaffReceptionMO = value;
            }
        }

        private int mInvoiceNo;
        public int InvoiceNo
        {
            get { return this.mInvoiceNo; }
            set { this.mInvoiceNo = value; }
        }

        private DateTime mInvoiceDate;
        public DateTime InvoiceDate
        {
            get { return this.mInvoiceDate; }
            set { this.mInvoiceDate = value; }
        }

        private string mPatientFinalDiagnosis;
        public string PatientFinalDiagnosis
        {
            get { return this.mPatientFinalDiagnosis; }
            set { this.mPatientFinalDiagnosis = value; }
        }

        private string mPatientConditionOnDischarge;
        public string PatientConditionOnDischarge
        {
            get { return this.mPatientConditionOnDischarge; }
            set { this.mPatientConditionOnDischarge = value; }
        }

        private string mPatientTypeOfDischarge;
        public string PatientTypeOfDischarge
        {
            get { return this.mPatientTypeOfDischarge; }
            set { this.mPatientTypeOfDischarge = value; }
        }

        private string mPatientDischargeTimeTemperature;
        public string PatientDischargeTimeTemperature
        {
            get { return this.mPatientDischargeTimeTemperature; }
            set { this.mPatientDischargeTimeTemperature = value; }
        }

        private string mPatientDischargeTimePulse;
        public string PatientDischargeTimePulse
        {
            get { return this.mPatientDischargeTimePulse; }
            set { this.mPatientDischargeTimePulse = value; }
        }

        private string mPatientDischargeTimeRr;
        public string PatientDischargeTimeRr
        {
            get { return this.mPatientDischargeTimeRr; }
            set { this.mPatientDischargeTimeRr = value; }
        }

        private string mPatientDischargeTimeSpo2;
        public string PatientDischargeTimeSpo2
        {
            get { return this.mPatientDischargeTimeSpo2; }
            set { this.mPatientDischargeTimeSpo2 = value; }
        }

        private string mPatientDischargeTimeBp;
        public string PatientDischargeTimeBp
        {
            get { return this.mPatientDischargeTimeBp; }
            set { this.mPatientDischargeTimeBp = value; }
        }

        private string mPatientDischargeTimeHr;
        public string PatientDischargeTimeHr
        {
            get { return this.mPatientDischargeTimeHr; }
            set { this.mPatientDischargeTimeHr = value; }
        }

        private string mPatientDischargeTimeRbs;
        public string PatientDischargeTimeRbs
        {
            get { return this.mPatientDischargeTimeRbs; }
            set { this.mPatientDischargeTimeRbs = value; }
        }

        private string mPatientDischargeTimeEcg;
        public string PatientDischargeTimeEcg
        {
            get { return this.mPatientDischargeTimeEcg; }
            set { this.mPatientDischargeTimeEcg = value; }
        }

        private string mPatientDischargeTimeRcg;
        public string PatientDischargeTimeRcg
        {
            get { return this.mPatientDischargeTimeRcg; }
            set { this.mPatientDischargeTimeRcg = value; }
        }

        private string mPatientDischargeTimeOther;
        public string PatientDischargeTimeOther
        {
            get { return this.mPatientDischargeTimeOther; }
            set { this.mPatientDischargeTimeOther = value; }
        }

        private string mPatientDischargeTimeWeight;
        public string PatientDischargeTimeWeight
        {
            get { return this.mPatientDischargeTimeWeight; }
            set { this.mPatientDischargeTimeWeight = value; }
        }

        private string mPatientDischargeTimeHeight;
        public string PatientDischargeTimeHeight
        {
            get { return this.mPatientDischargeTimeHeight; }
            set { this.mPatientDischargeTimeHeight = value; }
        }

        private string mPatientDischargeTimeClinicalExamination;
        public string PatientDischargeTimeClinicalExamination
        {
            get { return this.mPatientDischargeTimeClinicalExamination; }
            set { this.mPatientDischargeTimeClinicalExamination = value; }
        }

        private string mPatientDischargeTimeOperativeNote;
        public string PatientDischargeTimeOperativeNote
        {
            get { return this.mPatientDischargeTimeOperativeNote; }
            set { this.mPatientDischargeTimeOperativeNote = value; }
        }

        private string mPatientDischargeTimeInvestigation;
        public string PatientDischargeTimeInvestigation
        {
            get { return this.mPatientDischargeTimeInvestigation; }
            set { this.mPatientDischargeTimeInvestigation = value; }
        }

        private string mPatientDischargeTimeTreatment;
        public string PatientDischargeTimeTreatment
        {
            get { return this.mPatientDischargeTimeTreatment; }
            set { this.mPatientDischargeTimeTreatment = value; }
        }

        private string mPatientDischargeTimeAdvice;
        public string PatientDischargeTimeAdvice
        {
            get { return this.mPatientDischargeTimeAdvice; }
            set { this.mPatientDischargeTimeAdvice = value; }
        }

        private string mPatientStatus;
        public string PatientStatus
        {
            get { return this.mPatientStatus; }
            set { this.mPatientStatus = value; }
        }

        private string mPatientMedicalOfficer;
        public string PatientMedicalOfficer
        {
            get { return this.mPatientMedicalOfficer; }
            set { this.mPatientMedicalOfficer = value; }
        }

        private DateTime mPatientMedicalOfficerDate;
        public DateTime PatientMedicalOfficerDate
        {
            get { return this.mPatientMedicalOfficerDate; }
            set { this.mPatientMedicalOfficerDate = value; }
        }

        private string mPatientMedicalOfficerTime;
        public string PatientMedicalOfficerTime
        {
            get { return this.mPatientMedicalOfficerTime; }
            set { this.mPatientMedicalOfficerTime = value; }
        }

        private string mPatientIndoorNo;
        public string PatientIndoorNo
        {
            get { return this.mPatientIndoorNo; }
            set { this.mPatientIndoorNo = value; }
        }

        private string mPatientBillNo;
        public string PatientBillNo
        {
            get { return this.mPatientBillNo; }
            set { this.mPatientBillNo = value; }
        }

        #endregion


        private int mMaxInvoiceNo;
        public int MaxInvoiceNo
        {
            get { return this.mMaxInvoiceNo; }
            set { this.mMaxInvoiceNo = value; }
        }

        PatientProcedure mPatientProcedure;
        public PatientProcedure PatientProcedure
        {
            get { return this.mPatientProcedure; }
            set { this.mPatientProcedure = value; }
        }

        IPDPatientTreatments mIPDPatientTreatment;
        public IPDPatientTreatments IPDPatientTreatment
        {
            get
            {
                if (this.mIPDPatientTreatment == null)
                    this.mIPDPatientTreatment = new IPDPatientTreatments(this.ObjectGuid);

                return mIPDPatientTreatment;
            }
            set
            {
                this.mIPDPatientTreatment = value;
            }
        }

        Appointment mAppointment;

        public Appointment Appointment
        {
            get { return this.mAppointment; }
            set { this.mAppointment = value; }
        }

        HistoryProcedure mHistoryProcedure;
        public HistoryProcedure HistoryProcedure
        {
            get { return this.mHistoryProcedure; }
            set { this.mHistoryProcedure = value; }
        }

        OPDTreatmentProcedure mOPDTreatmentProcedure;

        public OPDTreatmentProcedure OPDTreatmentProcedure
        {
            get { return this.mOPDTreatmentProcedure; }
            set { this.mOPDTreatmentProcedure = value; }
        }

        OPDInvestigationProcedure mOPDInvestigationProcedure;

        public OPDInvestigationProcedure OPDInvestigationProcedure
        {
            get { return mOPDInvestigationProcedure; }
            set { mOPDInvestigationProcedure = value; }
        }

        OPDPrescription mOPDPrescription;

        public OPDPrescription OPDPrescription
        {
            get { return mOPDPrescription; }
            set { mOPDPrescription = value; }
        }

        #endregion

        #region Overiden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.PatientGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.PatientId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.PatientGuid]);
                this.mNumber = AppShared.DbValueToInteger(dr[Columns.PatientNo]);
                 this.mIsIPD = AppShared.DbValueToBoolean(dr[Columns.PatientIsIPD]);
                this.mIsOPD = AppShared.DbValueToBoolean(dr[Columns.PatientIsOPD]);

                #region patient details fields

                this.mFirstName = AppShared.DbValueToString(dr[Columns.PatientFirstName]);
                this.mMiddleName = AppShared.DbValueToString(dr[Columns.PatientMiddleName]);
                this.mLastName = AppShared.DbValueToString(dr[Columns.PatientLastName]);
                this.mGender = (Gender)AppShared.DbValueToInteger(dr[Columns.PatientGender]);
                this.mAge = AppShared.DbValueToInteger(dr[Columns.PatientAge]);
                this.mPatientReference = AppShared.DbValueToString(dr[Columns.PatientReference]);
                this.mCity = AppShared.DbValueToString(dr[Columns.PatientCity]);
                this.mDistrict = AppShared.DbValueToString(dr[Columns.PatientDistrict]);
                this.mTaluko = AppShared.DbValueToString(dr[Columns.PatientTaluko]);
                this.mAddress = AppShared.DbValueToString(dr[Columns.PatientAddress]);
                this.mPatientOccupation = AppShared.DbValueToString(dr[Columns.PatientOccupation]);
                this.mPatientOccupationFullAddress = AppShared.DbValueToString(dr[Columns.PatientOccupationFullAddress]);
                this.mOtherNo = AppShared.DbValueToString(dr[Columns.PatientOtherNo]);
                this.mResidenceNo = AppShared.DbValueToString(dr[Columns.PatientResidenceNo]);
                this.mContactNo = AppShared.DbValueToString(dr[Columns.PatientContactNo]);
                this.mPatientMaritalStatus = (MaritalStatus)AppShared.DbValueToInteger(dr[Columns.PatientMaritalStatus]);
                this.mMarrageTimeyear = AppShared.DbValueToDecimal(dr[Columns.PatientMarrageTimeyear]);
                this.mChildern = AppShared.DbValueToInteger(dr[Columns.PatientChildern]);
                this.mWardGuid = AppShared.DbValueToGuid(dr[Columns.PatientWardGuid]);
                this.mRoomGuid = AppShared.DbValueToGuid(dr[Columns.PatientRoomGuid]);
                this.mPatientDoctorIncharge = AppShared.DbValueToString(dr[Columns.PatientDoctorIncharge]);
                this.mReferenceDoctorGuid = AppShared.DbValueToGuid(dr[Columns.PatientReferenceDoctorGuid]);
                this.mReferenceDoctorShare = AppShared.DbValueToDecimal(dr[Columns.PatientReferenceDoctorShare]);
                this.mPatientBirthDate = AppShared.DbValueToDateTime(dr[Columns.PatientBirthDate]);
                this.mAdmittedDate = AppShared.DbValueToDateTime(dr[Columns.PatientAdmittedDate]);
                this.mAdmittedTime = AppShared.DbValueToString(dr[Columns.PatientAdmittedTime]);
                this.mAdmittedBy = AppShared.DbValueToString(dr[Columns.PatientAdmittedBy]);
                this.mPatientChiefComplaint = AppShared.DbValueToString(dr[Columns.PatientChiefComplaint]);
                this.mPatientCamePreviously = AppShared.DbValueToString(dr[Columns.PatientCamePreviously]);
                this.mPatientProvisionalDiagnosis = AppShared.DbValueToString(dr[Columns.PatientProvisionalDiagnosis]);
                this.mPatientTypeOfCase = AppShared.DbValueToString(dr[Columns.PatientTypeOfCase]);
                this.mPatientHt = AppShared.DbValueToString(dr[Columns.PatientHt]);
                this.mPatientDrugAllergy = AppShared.DbValueToString(dr[Columns.PatientDrugAllergy]);
                this.mPatientDm = AppShared.DbValueToString(dr[Columns.PatientDm]);
                this.mPatientPregnency = AppShared.DbValueToString(dr[Columns.PatientPregnency]);
                this.mPatientIhd = AppShared.DbValueToString(dr[Columns.PatientIhd]);
                this.mPatientBt = AppShared.DbValueToString(dr[Columns.PatientBt]);
                this.mPatientMajorIllness = AppShared.DbValueToString(dr[Columns.PatientMajorIllness]);
                this.mPatientAdmittedTimeTemperature = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeTemperature]);
                this.mPatientAdmittedTimeSpo2 = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeSpo2]);
                this.mPatientAdmittedTimeRbs = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeRbs]);
                this.mPatientAdmittedTimeWeight = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeWeight]);
                this.mPatientAdmittedTimePulse = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimePulse]);
                this.mPatientAdmittedTimeBp = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeBp]);
                this.mPatientAdmittedTimeEcg = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeEcg]);
                this.mPatientAdmittedTimeHeight = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeHeight]);
                this.mPatientAdmittedTimeRr = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeRr]);
                this.mPatientAdmittedTimeHr = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeHr]);
                this.mPatientAdmittedTimeOther = AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeOther]);
                this.mPatientSystemicExamination = AppShared.DbValueToString(dr[Columns.PatientSystemicExamination]);
                this.mPatientRs = AppShared.DbValueToString(dr[Columns.PatientRs]);
                this.mPatientPSOName = AppShared.DbValueToString(dr[Columns.PatientPSOName]);
                this.mPatientDivison = AppShared.DbValueToString(dr[Columns.PatientDivison]);
                this.mPatientCvs = AppShared.DbValueToString(dr[Columns.PatientCvs]);
                this.mPatientMO = AppShared.DbValueToString(dr[Columns.PatientMO]);
                this.mPatientCNS = AppShared.DbValueToString(dr[Columns.PatientCNS]);
                this.mPatientPa = AppShared.DbValueToString(dr[Columns.PatientPa]);
                this.mPatientOther = AppShared.DbValueToString(dr[Columns.PatientOther]);
                this.mPatientSuggestedInvstigation = AppShared.DbValueToString(dr[Columns.PatientSuggestedInvstigation]);
                this.mPatientClinicalNote = AppShared.DbValueToString(dr[Columns.PatientClinicalNote]);
                this.mPatientAdmittedTimeTreatment= AppShared.DbValueToString(dr[Columns.PatientAdmittedTimeTreatment]);
                this.mPatientReceivingStaff = AppShared.DbValueToString(dr[Columns.PatientReceivingStaff]);
                this.mReceivingStaffReceptionMO = AppShared.DbValueToString(dr[Columns.PatientReceivingStaffReceptionMO]);
                this.mPatientSenderName = AppShared.DbValueToString(dr[Columns.PatientSenderName]);
                this.mPatientSigningPersonName = AppShared.DbValueToString(dr[Columns.PatientSigningPersonName]);
                this.mPatientRelationshipWith = AppShared.DbValueToString(dr[Columns.PatientRelationshipWith]);
                this.mPatientOperationDate = AppShared.DbValueToDateTime(dr[Columns.PatientOperationDate]);
                this.mPatientOperationTime = AppShared.DbValueToString(dr[Columns.PatientOperationTime]);
                this.mPatientInsurance = AppShared.DbValueToString(dr[Columns.PatientInsurance]);
                 this.mPatientInsuranceCompany = AppShared.DbValueToString(dr[Columns.PatientInsuranceCompany]);
                this.mInsuranceAmount = AppShared.DbValueToString(dr[Columns.PatientInsuranceAmount]);

                #endregion

                #region mlc form fields

                this.mIsMlc = AppShared.DbValueToBoolean(dr[Columns.PatientIsMlc]);
                this.mPatientMLCNo = AppShared.DbValueToString(dr[Columns.PatientMLCNo]);
                this.mPatientEntryNo = AppShared.DbValueToString(dr[Columns.PatientEntryNo]);
                this.mPatientMarkOfIdentity = AppShared.DbValueToString(dr[Columns.PatientMarkOfIdentity]);
                this.mMlcFormFillUpName = AppShared.DbValueToString(dr[Columns.PatientMlcFormFillUpName]);
                this.mPatientEventDetail = AppShared.DbValueToString(dr[Columns.PatientEventDetail]);
                this.mPatientFetcherPersonName = AppShared.DbValueToString(dr[Columns.PatientFetcherPersonName]);
                this.mPatientFetcherPersonFullAddress = AppShared.DbValueToString(dr[Columns.PatientFetcherPersonFullAddress]);
                this.mInformerStaffPerson = AppShared.DbValueToString(dr[Columns.PatientInformerStaffPerson]);
                this.mInformTime = AppShared.DbValueToString(dr[Columns.PatientInformTime]);
                this.mRelatedPoliceStation = AppShared.DbValueToString(dr[Columns.PatientRelatedPoliceStation]);
                this.mRelatedPoliceOfficer = AppShared.DbValueToString(dr[Columns.PatientRelatedPoliceOfficer]);

                #endregion  

                #region discharge fields

                this.mIsDischarge = AppShared.DbValueToBoolean(dr[Columns.PatientIsDischarge]);
                this.mDischargeDate = AppShared.DbValueToDateTime(dr[Columns.PatiendDischargeDate]);
                this.mDischargeTime = AppShared.DbValueToString(dr[Columns.PatientDischargeTime]);
                this.mDischargeBy = AppShared.DbValueToString(dr[Columns.PatientDischargeBy]);
                 this.mDischargeStaffReception = AppShared.DbValueToString(dr[Columns.PatientDischargeStaffReception]);
                this.mDischargeStaffReceptionMO = AppShared.DbValueToString(dr[Columns.PatientDischargeStaffReceptionMO]);
                this.mPatientConditionOnDischarge = AppShared.DbValueToString(dr[Columns.PatientConditionOnDischarge]);
                this.mPatientTypeOfDischarge = AppShared.DbValueToString(dr[Columns.PatientTypeOfDischarge]);
                this.mPatientDischargeTimeTemperature = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeTemperature]);
                this.mPatientDischargeTimeSpo2 = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeSpo2]);
                this.mPatientDischargeTimeRbs = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeRbs]);
                this.mPatientDischargeTimeRr = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeRr]);
                this.mPatientDischargeTimePulse = AppShared.DbValueToString(dr[Columns.PatientDischargeTimePulse]);
                this.mPatientDischargeTimeBp = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeBp]);
                this.mPatientDischargeTimeEcg = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeEcg]);
                this.mPatientDischargeTimeHr = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeHr]);
                this.mPatientDischargeTimeWeight = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeWeight]);
                this.mPatientDischargeTimeHeight = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeHeight]);
                this.mPatientDischargeTimeOther = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeOther]);
                this.mPatientFinalDiagnosis = AppShared.DbValueToString(dr[Columns.PatientFinalDiagnosis]);
                this.mPatientDischargeTimeClinicalExamination = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeClinicalExamination]);
                this.mPatientDischargeTimeOperativeNote = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeOperativeNote]);
                this.mPatientDischargeTimeInvestigation = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeInvestigation]);
                this.mPatientDischargeTimeTreatment = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeTreatment]);
                this.mPatientDischargeTimeAdvice = AppShared.DbValueToString(dr[Columns.PatientDischargeTimeAdvice]);
                this.mInvoiceDate = AppShared.DbValueToDateTime(dr[Columns.PatientInvoiceDate]);
                this.mPatientStatus = AppShared.DbValueToString(dr[Columns.PatientStatus]);
                this.mPatientMedicalOfficer = AppShared.DbValueToString(dr[Columns.PatientMedicalOfficer]);

                this.mPatientIndoorNo = AppShared.DbValueToString(dr[Columns.PatientIndoorNo]);
                this.mPatientBillNo = AppShared.DbValueToString(dr[Columns.PatientBillNo]);
                
                this.mPatientMedicalOfficerDate = AppShared.DbValueToDateTime(dr[Columns.PatientMedicalOfficerDate]);
                this.mPatientMedicalOfficerTime = AppShared.DbValueToString(dr[Columns.PatientMedicalOfficerTime]);
                

                #endregion

                #region otherfields

                this.mInvoiceNo = AppShared.DbValueToInteger(dr[Columns.PatientInvoiceNo]);
                this.mCreatedByUser = AppShared.DbValueToGuid(dr[Columns.PatientCreatedBy]);
                this.mCreatedOn = AppShared.DbValueToDateTime(dr[Columns.PatientCreatedOn]);
                this.mModifiedByUser = AppShared.DbValueToGuid(dr[Columns.PatientModifiedBy]);
                this.mModifiedOn = AppShared.DbValueToDateTime(dr[Columns.PatientModifiedOn]);

                #endregion

                this.mNotes = AppShared.DbValueToString(dr[Columns.PatientNotes]);
                this.mOpetation = AppShared.DbValueToString(dr[Columns.PatientOperation]);
                this.mFollowUpDate = AppShared.DbValueToDateTime(dr[Columns.PatientFollowUpDate]);
                this.mAmountReceived = AppShared.DbValueToDecimal(dr[Columns.PatientAmountReceived]);
                this.mPatientOperationDateTime = AppShared.DbValueToDateTime(dr[Columns.PatientOperationDateTime]);
               
                if (AppShared.HasColumn(dr, "MaxInvoiceNo"))
                {
                    this.mMaxInvoiceNo = AppShared.DbValueToInteger(dr[Columns.MaxInvoiceNo]);
                }

                this.Status = ObjectStatus.Opened;
                r = true;
            }
            else
            {
                this.Reset();
            }
            return r;

        }

        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.PatientSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            Guid createdBy = AppContext.UserGuid;
            DateTime createdOn;
            int gender = (int)this.mGender;
            int maritalstatus = (int)this.mPatientMaritalStatus;

            bool r = AppDAL.PatientInsert(this.mObjectGuid, this.mFirstName, this.mMiddleName, this.mLastName, gender, this.mAge, this.mAddress, this.mCity, this.mDistrict,
                this.mTaluko, this.mContactNo, this.mOtherNo, this.mResidenceNo, maritalstatus, this.mMarrageTimeyear, this.mChildern, this.mNotes, this.mWardGuid, this.mRoomGuid,
                this.mAdmittedDate, this.mAdmittedTime, this.mAdmittedBy, this.mOpetation, this.mFollowUpDate, this.mAmountReceived, this.mIsIPD, this.mIsOPD,
                this.mReferenceDoctorGuid, this.mReferenceDoctorShare, this.mPatientOccupation, this.mPatientOccupationFullAddress, this.mPatientReference, this.mPatientInsurance,
                this.mPatientInsuranceCompany, this.mInsuranceAmount, this.mPatientOperationDateTime, this.mPatientSigningPersonName, this.mPatientRelationshipWith,
                this.mPatientDoctorIncharge, this.mPatientDivison, this.mPatientPSOName, this.mPatientReceivingStaff, this.mReceivingStaffReceptionMO, this.mPatientMO,
                this.mPatientProvisionalDiagnosis, this.mPatientCamePreviously, this.mPatientBirthDate, this.mPatientSenderName, this.mPatientChiefComplaint, this.PatientTypeOfCase,
                this.mPatientHt, this.mPatientDm, this.mPatientIhd, this.mPatientMajorIllness, this.mPatientDrugAllergy, this.mPatientPregnency, this.mPatientBt,
                this.mPatientAdmittedTimeTemperature, this.mPatientAdmittedTimePulse, this.mPatientAdmittedTimeRr, this.mPatientAdmittedTimeSpo2, this.mPatientAdmittedTimeBp,
                this.mPatientAdmittedTimeHr, this.mPatientAdmittedTimeRbs, this.mPatientAdmittedTimeEcg, this.mPatientAdmittedTimeOther, this.mPatientAdmittedTimeWeight,
                this.mPatientAdmittedTimeHeight, this.mPatientSystemicExamination, this.mPatientRs, this.mPatientCvs, this.mPatientCNS, this.mPatientPa, this.mPatientOther,
                this.mPatientSuggestedInvstigation, this.mPatientClinicalNote, this.mPatientAdmittedTimeTreatment, this.mPatientOperationDate, this.mPatientOperationTime,
                this.mIsMlc, this.mMlcFormFillUpName, this.mPatientMLCNo, this.mPatientEntryNo, this.mPatientMarkOfIdentity, this.mPatientEventDetail,
                this.mPatientFetcherPersonName, this.mPatientFetcherPersonFullAddress, this.mInformerStaffPerson, this.mInformTime, this.mRelatedPoliceStation, this.mRelatedPoliceOfficer,
                this.mIsDischarge, this.mDischargeDate, this.mDischargeTime, this.mDischargeBy, this.mDischargeStaffReception, this.mDischargeStaffReceptionMO, this.mInvoiceNo,
                this.mInvoiceDate, this.mPatientFinalDiagnosis, this.mPatientConditionOnDischarge, this.mPatientTypeOfDischarge, this.mPatientDischargeTimeTemperature,
                this.mPatientDischargeTimePulse, this.mPatientDischargeTimeRr, this.mPatientDischargeTimeSpo2, this.mPatientDischargeTimeBp, this.mPatientDischargeTimeHr,
                this.mPatientDischargeTimeRbs, this.mPatientDischargeTimeEcg, this.mPatientDischargeTimeRcg, this.mPatientDischargeTimeOther, this.mPatientDischargeTimeWeight,
                this.mPatientDischargeTimeHeight, this.mPatientDischargeTimeClinicalExamination, this.mPatientDischargeTimeOperativeNote, this.mPatientDischargeTimeInvestigation,
                this.mPatientDischargeTimeTreatment, this.mPatientDischargeTimeAdvice, this.mPatientStatus, this.mPatientMedicalOfficer, this.mPatientIndoorNo, this.mPatientBillNo, this.mPatientMedicalOfficerDate,
                this.mPatientMedicalOfficerTime, createdBy, out createdOn);
            if (r)
            {
                this.mCreatedByUser = createdBy;
                this.mCreatedOn = createdOn;
                this.mModifiedByUser = createdBy;
                this.mModifiedOn = createdOn;
            }
            return r;
        }

        protected override bool UpdateRecord()
        {
            Guid modifiedBy = AppContext.UserGuid;
            DateTime modifiedOn;
            int gender = (int)this.mGender;
            int maritalstatus = (int)this.mPatientMaritalStatus;
            bool r = AppDAL.PatientUpdate(this.mObjectGuid, this.mFirstName, this.mMiddleName, this.mLastName, gender, this.mAge, this.mAddress, this.mCity, this.mDistrict,
                /*patientDetails fields*/ this.mTaluko, this.mContactNo, this.mOtherNo, this.mResidenceNo, maritalstatus, this.mMarrageTimeyear, this.mChildern, this.mNotes, this.mWardGuid, this.mRoomGuid,
                this.mAdmittedDate, this.mAdmittedTime, this.mAdmittedBy, this.mOpetation, this.mFollowUpDate, this.mAmountReceived, this.mIsIPD, this.mIsOPD,
                this.mReferenceDoctorGuid, this.mReferenceDoctorShare, this.mPatientOccupation, this.mPatientOccupationFullAddress, this.mPatientReference, this.mPatientInsurance,
                this.mPatientInsuranceCompany, this.mInsuranceAmount, this.mPatientOperationDateTime, this.mPatientSigningPersonName, this.mPatientRelationshipWith,
                this.mPatientDoctorIncharge, this.mPatientDivison, this.mPatientPSOName, this.mPatientReceivingStaff, this.mReceivingStaffReceptionMO, this.mPatientMO,
                this.mPatientProvisionalDiagnosis, this.mPatientCamePreviously, this.mPatientBirthDate, this.mPatientSenderName, this.mPatientChiefComplaint, this.PatientTypeOfCase,
                this.mPatientHt, this.mPatientDm, this.mPatientIhd, this.mPatientMajorIllness, this.mPatientDrugAllergy, this.mPatientPregnency, this.mPatientBt,
                this.mPatientAdmittedTimeTemperature, this.mPatientAdmittedTimePulse, this.mPatientAdmittedTimeRr, this.mPatientAdmittedTimeSpo2, this.mPatientAdmittedTimeBp,
                this.mPatientAdmittedTimeHr, this.mPatientAdmittedTimeRbs, this.mPatientAdmittedTimeEcg, this.mPatientAdmittedTimeOther, this.mPatientAdmittedTimeWeight,
                this.mPatientAdmittedTimeHeight, this.mPatientSystemicExamination, this.mPatientRs, this.mPatientCvs, this.mPatientCNS, this.mPatientPa, this.mPatientOther,
                this.mPatientSuggestedInvstigation, this.mPatientClinicalNote, this.mPatientAdmittedTimeTreatment, this.mPatientOperationDate, this.mPatientOperationTime,
                /*MLC form field*/ this.mIsMlc, this.mMlcFormFillUpName, this.mPatientMLCNo, this.mPatientEntryNo, this.mPatientMarkOfIdentity, this.mPatientEventDetail,
                this.mPatientFetcherPersonName, this.mPatientFetcherPersonFullAddress, this.mInformerStaffPerson, this.mInformTime, this.mRelatedPoliceStation, this.mRelatedPoliceOfficer,
                /*Discharge Field*/ this.mIsDischarge, this.mDischargeDate, this.mDischargeTime, this.mDischargeBy, this.mDischargeStaffReception, this.mDischargeStaffReceptionMO, this.mInvoiceNo,
                this.mInvoiceDate, this.mPatientFinalDiagnosis, this.mPatientConditionOnDischarge, this.mPatientTypeOfDischarge, this.mPatientDischargeTimeTemperature,
                this.mPatientDischargeTimePulse, this.mPatientDischargeTimeRr, this.mPatientDischargeTimeSpo2, this.mPatientDischargeTimeBp, this.mPatientDischargeTimeHr,
                this.mPatientDischargeTimeRbs, this.mPatientDischargeTimeEcg, this.mPatientDischargeTimeRcg, this.mPatientDischargeTimeOther, this.mPatientDischargeTimeWeight,
                this.mPatientDischargeTimeHeight, this.mPatientDischargeTimeClinicalExamination, this.mPatientDischargeTimeOperativeNote, this.mPatientDischargeTimeInvestigation,
                this.mPatientDischargeTimeTreatment, this.mPatientDischargeTimeAdvice, this.mPatientStatus, this.mPatientMedicalOfficer, this.mPatientIndoorNo, this.mPatientBillNo, this.mPatientMedicalOfficerDate,
                this.mPatientMedicalOfficerTime, modifiedBy, out modifiedOn);
            if (r)
            {
                this.mModifiedByUser = modifiedBy;
                this.mModifiedOn = modifiedOn;
            }
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.PatientDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mNumber = 0;
            this.mFirstName = string.Empty;
            this.mMiddleName = string.Empty;
            this.mLastName = string.Empty;
            this.mGender = 0;
            this.mAge = 0;
            this.mAddress = string.Empty;
            this.mCity = string.Empty;
            this.mContactNo = string.Empty;
            this.mPatientMaritalStatus = 0;
            this.mNotes = string.Empty;
            this.mWardGuid = Guid.Empty;
            this.mRoomGuid = Guid.Empty;
            this.mAdmittedDate = DateTime.MinValue;
            this.mAdmittedTime = string.Empty;
            this.mOpetation = string.Empty;
            this.mFollowUpDate = DateTime.MinValue;
            this.mAmountReceived = 0;
            this.mIsIPD = false;
            this.mIsOPD = false;
            this.mReferenceDoctorGuid = Guid.Empty;
            this.mReferenceDoctorShare = 0;
            this.mIsDischarge = false;
            this.mDischargeDate = DateTime.MinValue;
        }

        protected override bool UpdateChild()
        {
            bool r = true;
            if (this.mPatientProcedure != null)
            {
                this.mPatientProcedure.PatientGuid = this.mObjectGuid;
                this.mPatientProcedure.MarkToSave();
                this.mPatientProcedure.UpdateChanges();
            }

            if (this.mIPDPatientTreatment != null)
            {
                using (SqlDataReader dr = AppDAL.IPDPatientTreatmentDelete(this.mObjectGuid))
                {

                }
                foreach (IPDPatientTreatment item in this.mIPDPatientTreatment)
                {
                    item.PatientGuid = this.mObjectGuid;
                    item.MarkToSave();
                    item.UpdateChanges();
                }
            }

            // Chief Complain
            if (this.mHistoryProcedure != null)
            {
                this.mHistoryProcedure.PatientGuid = this.mObjectGuid;
                this.mHistoryProcedure.MarkToSave();
                this.mHistoryProcedure.UpdateChanges();
            }

            //Associate Complain

            if (this.mHistoryProcedure != null)
            {
                this.mHistoryProcedure.PatientGuid = this.mObjectGuid;
                this.mHistoryProcedure.MarkToSave();
                this.mHistoryProcedure.UpdateChanges();
            }

            // History

            if (this.mHistoryProcedure != null)
            {
                this.mHistoryProcedure.PatientGuid = this.mObjectGuid;
                this.mHistoryProcedure.MarkToSave();
                this.mHistoryProcedure.UpdateChanges();
            }

            //Main Investigation

            if (this.mOPDInvestigationProcedure != null)
            {
                this.mOPDInvestigationProcedure.PatientGuid = this.mObjectGuid;
                this.OPDInvestigationProcedure.MarkToSave();
                this.OPDInvestigationProcedure.UpdateChanges();
            }

            //Lab Investigation

            if (this.mOPDInvestigationProcedure != null)
            {
                this.mOPDInvestigationProcedure.PatientGuid = this.mObjectGuid;
                this.OPDInvestigationProcedure.MarkToSave();
                this.OPDInvestigationProcedure.UpdateChanges();
            }

            // Treatment
            if (this.mOPDTreatmentProcedure != null)
            {
                this.mOPDTreatmentProcedure.PatientGuid = this.mObjectGuid;
                this.mOPDTreatmentProcedure.MarkToSave();
                this.mOPDTreatmentProcedure.UpdateChanges();

            }
            //Medicine
            if (this.mOPDPrescription != null)
            {
                this.mOPDPrescription.PatientGuid = this.mObjectGuid;
                this.mOPDPrescription.MarkToSave();
                this.mOPDPrescription.UpdateChanges();
            }
            // Appointment
            if (this.mAppointment != null)
            {
                this.mAppointment.PatientGuid = this.mObjectGuid;
                this.mAppointment.MarkToSave();
                this.mAppointment.UpdateChanges();
            }
            return r;
        }

        #endregion
    }

    public sealed class Patients : ObjectCollection<Patient>
    {
        public Patients(string searchText, bool IsIpd, bool IsOPD, int isDischarge, DateTime dateFrom, DateTime dateTo)
        {
            using (SqlDataReader dr = AppDAL.PatientSearch(searchText, IsIpd, IsOPD, isDischarge, dateFrom, dateTo))
            {
                LoadObjectsFromReader(dr);
            }
        }

        public Patients(bool isIPD)
        {
            if (isIPD)
            {
                using (SqlDataReader dr = AppDAL.SelectIPDPatient())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            else
            {
                using (SqlDataReader dr = AppDAL.SelectOPDPatient())
                {
                    LoadObjectsFromReader(dr);
                }
            }
        }
    }
}
