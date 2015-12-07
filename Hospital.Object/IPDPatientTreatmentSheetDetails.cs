using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class IPDPatientTreatmentSheetDetails : Objectbase
    {
        internal struct Columns
        {
            public const string IPDPatientTreatmentSheetDetailsId = "IPDPatientTreatmentSheetDetailsId";
            public const string IPDPatientTreatmentSheetDetailsGuid = "IPDPatientTreatmentSheetDetailsGuid";
            public const string IPDPatientTreatmentSheetDetailsTreatmentSheetGuid = "IPDPatientTreatmentSheetDetailsTreatmentSheetGuid";
            public const string IPDPatientTreatmentSheetDetailsPatientGuid = "IPDPatientTreatmentSheetDetailsPatientGuid";
            public const string IPDPatientTreatmentSheetDetailsDescription = "IPDPatientTreatmentSheetDetailsDescription";
            public const string IPDPatientTreatmentSheetDetailsMorningTime = "IPDPatientTreatmentSheetDetailsMorningTime";
            public const string IPDPatientTreatmentSheetDetailsNoonTime = "IPDPatientTreatmentSheetDetailsNoonTime";
            public const string IPDPatientTreatmentSheetDetailsEveningTime = "IPDPatientTreatmentSheetDetailsEveningTime";
            public const string IPDPatientTreatmentSheetDetailsNightTime = "IPDPatientTreatmentSheetDetailsNightTime";
            public const string SrNo = "SrNo";
        }

        #region Constructor

        public IPDPatientTreatmentSheetDetails() : base() { }

        public IPDPatientTreatmentSheetDetails(Guid key) : base(key) { }

        public IPDPatientTreatmentSheetDetails(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get { return string.Empty; }
        }

        private Guid mIPDPatientTreatmentSheetGuid;
        public Guid IPDPatientTreatmentSheetGuid
        {
            get { return this.mIPDPatientTreatmentSheetGuid; }
            set { this.mIPDPatientTreatmentSheetGuid = value; }
        }



        private IPDPatientTreatmentSheet mIPDPatientTreatmentSheet;
        public IPDPatientTreatmentSheet IPDPatientTreatmentSheet
        {
            get
            {
                if (IsNullOrEmpty(this.mIPDPatientTreatmentSheet) || this.mIPDPatientTreatmentSheet.ObjectGuid != this.mIPDPatientTreatmentSheetGuid)
                    this.mIPDPatientTreatmentSheet = (this.mIPDPatientTreatmentSheetGuid != Guid.Empty ? new IPDPatientTreatmentSheet(this.mIPDPatientTreatmentSheetGuid) : null);
                return this.mIPDPatientTreatmentSheet;
            }

            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mIPDPatientTreatmentSheetGuid = Guid.Empty;
                    this.mIPDPatientTreatmentSheet = null;
                }
                else
                {
                    this.mIPDPatientTreatmentSheetGuid = value.ObjectGuid;
                    this.mIPDPatientTreatmentSheet = value;
                }
            }
        }

        private Guid mIpdPatientTreatmentSheetDetailsPatientGuid;
        public Guid IpdPatientTreatmentSheetDetailsPatientGuid
        {
            get { return this.mIpdPatientTreatmentSheetDetailsPatientGuid; }
            set { this.mIpdPatientTreatmentSheetDetailsPatientGuid = value; }
        }

        private Patient mPatient;
        public Patient Patient
        {
            get
            {
                if (IsNullOrEmpty(this.mPatient) || this.mPatient.ObjectGuid != this.mIpdPatientTreatmentSheetDetailsPatientGuid)
                    this.mPatient = (this.mIpdPatientTreatmentSheetDetailsPatientGuid != Guid.Empty ? new Patient(this.mIpdPatientTreatmentSheetDetailsPatientGuid) : null);

                return this.mPatient;
            }
            set
            {
                if (IsNullOrEmpty(value))
                {
                    this.mIpdPatientTreatmentSheetDetailsPatientGuid = Guid.Empty;
                    this.mPatient = null;
                }
                else
                {
                    this.mIpdPatientTreatmentSheetDetailsPatientGuid = value.ObjectGuid;
                    this.mPatient = value;
                }
            }
        }

        private string mDescription;
        public string Description
        {
            get { return this.mDescription; }
            set { this.mDescription = value; }
        }

        private string mMorningTime;
        public string MorningTime
        {
            get { return this.mMorningTime; }
            set { this.mMorningTime = value; }
        }

        private string mNoonTime;
        public string NoonTime
        {
            get { return this.mNoonTime; }
            set { this.mNoonTime = value; }
        }

        private string mEveningTime;
        public string EveningTime
        {
            get { return this.mEveningTime; }
            set { this.mEveningTime = value; }
        }

        private string mNightTime;
        public string NightTime
        {
            get { return this.mNightTime; }
            set { this.mNightTime = value; }
        }

        private string mSrNo;
        public string SrNo
        {
            get { return this.mSrNo; }
            set { this.mSrNo = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.IPDPatientTreatmentSheetDetailsGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.IPDPatientTreatmentSheetDetailsId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.IPDPatientTreatmentSheetDetailsGuid]);
                this.mIPDPatientTreatmentSheetGuid = AppShared.DbValueToGuid(dr[Columns.IPDPatientTreatmentSheetDetailsTreatmentSheetGuid]);
                this.mIpdPatientTreatmentSheetDetailsPatientGuid = AppShared.DbValueToGuid(dr[Columns.IPDPatientTreatmentSheetDetailsPatientGuid]);
                this.mDescription = AppShared.DbValueToString(dr[Columns.IPDPatientTreatmentSheetDetailsDescription]);
                this.mMorningTime = AppShared.DbValueToString(dr[Columns.IPDPatientTreatmentSheetDetailsMorningTime]);
                this.mNoonTime = AppShared.DbValueToString(dr[Columns.IPDPatientTreatmentSheetDetailsNoonTime]);
                this.EveningTime = AppShared.DbValueToString(dr[Columns.IPDPatientTreatmentSheetDetailsEveningTime]);
                this.NightTime = AppShared.DbValueToString(dr[Columns.IPDPatientTreatmentSheetDetailsNightTime]);
                if (AppShared.HasColumn(dr, "SrNo"))
                {
                    this.mSrNo = AppShared.DbValueToString(dr[Columns.SrNo].ToString());
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
            using (SqlDataReader dr = AppDAL.IPDPatientTreatmentSheetDetailsSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {

            bool r = AppDAL.IPDPatientTreatmentSheetDetailsInsert(this.mObjectGuid, this.mIPDPatientTreatmentSheetGuid, this.mIpdPatientTreatmentSheetDetailsPatientGuid, this.mDescription, this.mMorningTime, this.mNoonTime,
                this.mEveningTime, this.mNightTime);

            return r;

        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.IPDPatientTreatmentSheetDetailsUpdate(this.mObjectGuid, this.mIPDPatientTreatmentSheetGuid, this.mIpdPatientTreatmentSheetDetailsPatientGuid, this.mDescription, this.mMorningTime, this.mNoonTime,
                this.mEveningTime, this.mNightTime);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.IPDPatientTreatmentSheetDetailsDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();

        }
        #endregion
    }

    public sealed class IPDPatientTreatmentSheetDetailsCollection : ObjectCollection<IPDPatientTreatmentSheetDetails>
    {

        #region IPDPatientTreatmentSheetDetailsCollection
        public IPDPatientTreatmentSheetDetailsCollection(Guid treatmentGuid)
        {
            using (SqlDataReader dr = AppDAL.IPDPatientTreatmentSheetDetailsSelectByTreatmentSheet(treatmentGuid))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
