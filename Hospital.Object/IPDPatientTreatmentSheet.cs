using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class IPDPatientTreatmentSheet : Objectbase
    {
        internal struct Columns
        {
            public const string TreatmentSheetId = "IPDPatientTreatmentSheetId";
            public const string TreatmentSheetGuid = "IPDPatientTreatmentSheetGuid";
            public const string TreatmentSheetPatientGuid = "IPDPatientTreatmentSheetPatientGuid";
            public const string TreatmentSheetDiatAdvice = "IPDPatientTreatmentSheetDiatAdvice";
            public const string TreatmentSheetSOSDrug = "IPDPatientTreatmentSheetSOSDrug";
            public const string TreatmentSheetSpecialAdvice = "IPDPatientTreatmentSheetSpecialAdvice";
            public const string TreatmentSheetDate = "IPDPatientTreatmentSheetDate";
        }

         #region Constructor
        public IPDPatientTreatmentSheet() : base() { }

        public IPDPatientTreatmentSheet(Guid key) : base(key) { }

        public IPDPatientTreatmentSheet(SqlDataReader dr) : base(dr) { }
        #endregion

        #region Properties

        public override string DisplayName
        {
            get { return string.Empty; }
        }

        private Guid mPatientGuid;
        public Guid PatientGuid
        {
            get { return this.mPatientGuid; }
            set { this.mPatientGuid = value; }
        }

        private Patient mPatient;
        public Patient Patient
        {
            get
            {
                if (IsNullOrEmpty(this.mPatient) || this.mPatient.ObjectGuid != this.mPatientGuid)
                    this.mPatient = (this.mPatientGuid != Guid.Empty ? new Patient(this.mPatientGuid) : null);

                return this.mPatient;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mPatientGuid = Guid.Empty;
                    this.mPatient = null;
                }
                else
                {
                    this.mPatientGuid = value.ObjectGuid;
                    this.mPatient = value;
                }
            }
        }


        public string DrIncharge
        {
            get
            {
                Patient obj = this.Patient;
                if (IsNullOrEmpty(obj))
                {
                    return string.Empty;
                }
                else
                {
                    return obj.PatientDoctorIncharge;
                }

            }
        }

        private string mDiatAdvice;
        public string DiatAdvice
        {
            get { return this.mDiatAdvice; }
            set { this.mDiatAdvice = value; }
        }

        private string mSOSDrug;
        public string SOSDrug
        {
            get { return this.mSOSDrug; }
            set { this.mSOSDrug = value; }
        }

        private string mSpecialAdvice;
        public string SpecialAdvice
        {
            get { return this.mSpecialAdvice; }
            set { this.mSpecialAdvice = value; }
        }

        private DateTime mSheetDate;
        public DateTime SheetDate
        {
            get { return this.mSheetDate; }
            set { this.mSheetDate = value; }
        }

        IPDPatientTreatmentSheetDetails mIPDPatientTreatmentSheetDetails;
        public IPDPatientTreatmentSheetDetails IPDPatientTreatmentSheetDetails
        {
            get { return this.mIPDPatientTreatmentSheetDetails; }
            set { this.mIPDPatientTreatmentSheetDetails = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.TreatmentSheetId]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.TreatmentSheetId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.TreatmentSheetGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.TreatmentSheetPatientGuid]);
                this.mDiatAdvice = AppShared.DbValueToString(dr[Columns.TreatmentSheetDiatAdvice]);
                this.mSpecialAdvice = AppShared.DbValueToString(dr[Columns.TreatmentSheetSpecialAdvice]);
                this.mSOSDrug = AppShared.DbValueToString(dr[Columns.TreatmentSheetSOSDrug]);
                this.mSheetDate = AppShared.DbValueToDateTime(dr[Columns.TreatmentSheetDate]);
                this.Status = ObjectStatus.Opened;
                r = true;
            }
            return r;
        }

        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.IPDPatientTreatmentSheetSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            bool r = AppDAL.IPDPatientTreatmentSheetInsert(this.mObjectGuid, this.mPatientGuid, this.mDiatAdvice, this.mSOSDrug, this.mSpecialAdvice, this.mSheetDate);
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.IPDPatientTreatmentSheetUpdate(this.mObjectGuid, this.mPatientGuid, this.mDiatAdvice, this.mSOSDrug, this.mSpecialAdvice, this.mSheetDate);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.IPDPatientTreatmentSheetDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mPatientGuid = Guid.Empty;
            this.mDiatAdvice = this.mSpecialAdvice = this.mSOSDrug = string.Empty;
            this.mSheetDate = DateTime.MinValue;
        }

        protected override bool UpdateChild()
        {
            bool r = true;
            if (this.mIPDPatientTreatmentSheetDetails != null)
            {
                this.mIPDPatientTreatmentSheetDetails.IPDPatientTreatmentSheetGuid = this.mObjectGuid;
                this.mIPDPatientTreatmentSheetDetails.MarkToSave();
                this.mIPDPatientTreatmentSheetDetails.UpdateChanges();
            }

            return r;
        }
        #endregion
    }

    public sealed class IPDPatientTreatmentSheetCollection : ObjectCollection<IPDPatientTreatmentSheet>
    {
        #region PatientCollection

        public IPDPatientTreatmentSheetCollection(string searchText, DateTime dateFrom, DateTime dateTo)
        {
            using (SqlDataReader dr = AppDAL.IPDPatientTreatmentSheetSearch(searchText, dateFrom, dateTo))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
