using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hospital.Object
{
    public sealed class PatientVital : Objectbase
    {
        internal struct Columns
        {
            public const string PatientVitalId = "PatientVitalId";
            public const string PatientVitalGuid = "PatientVitalGuid";
            public const string PatientVitalPatientGuid = "PatientVitalPatientGuid";
            public const string PatientVitalDate = "PatientVitalDate";
            public const string PatientVitalTime = "PatientVitalTime";
            public const string PatientVitalBP = "PatientVitalBP";
            public const string PatientVitalHR = "PatientVitalHR";
            public const string PatientVitalRR = "PatientVitalRR";
            public const string PatientVitalTemp = "PatientVitalTemp";
            public const string PatientVitalRBS = "PatientVitalRBS";
            public const string PatientVitalECG = "PatientVitalECG";
            public const string PatientVitalWeight = "PatientVitalWeight";
            public const string PatientVitalHeight = "PatientVitalHeight";
            public const string PatientVitalOther = "PatientVitalOther";
            public const string PatientVitalSPO2 = "PatientVitalSPO2";
            public const string PatientVitalPULSE = "PatientVitalPULSE";
        }
        #region Constructor

        public PatientVital() : base() { }

        public PatientVital(Guid key) : base(key) { }

        public PatientVital(SqlDataReader dr) : base(dr) { }

        #endregion

        #region properties

        public override string DisplayName
        {
            get {return this.FirstName + " " + this.LastName;}
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
        public string FirstName
        {
            get
            {
                Patient obj = this.Patient;
                return IsNullOrEmpty(obj) ? string.Empty : obj.FirstName;
            }
        }
        public string LastName
        {
            get
            {
                Patient obj = this.Patient;
                return IsNullOrEmpty(obj) ? string.Empty : obj.LastName;
            }
        }

        private string mPatientName;
        public string PatientName
        {
            set { this.mPatientName = value; }
            get
            {
                Patient obj = this.Patient;
                return (IsNullOrEmpty(obj) ? string.Empty : obj.DisplayName);
            }
        }

        private DateTime mDate;
        public DateTime Date
        {
            get { return this.mDate; }
            set { this.mDate = value; }
        }

        private string mTime;
        public string Time
        {
            get { return this.mTime; }
            set { this.mTime = value; }
        }

        private string mBP;
        public string BP
        {
            get { return this.mBP; }
            set { this.mBP = value; }
        }

        private string mHR;
        public string HR
        {
            get { return this.mHR; }
            set { this.mHR = value; }
        }

        private string mRR;
        public string RR
        {
            get { return this.mRR; }
            set { this.mRR = value; }
        }

        private string mTemp;
        public string Temp
        {
            get { return this.mTemp; }
            set { this.mTemp = value; }
        }

        private string mRBS;
        public string RBS
        {
            get { return this.mRBS; }
            set { this.mRBS = value; }
        }

        private string mECG;
        public string ECG
        {
            get { return this.mECG; }
            set { this.mECG = value; }
        }

        private string mWeight;
        public string Weight
        {
            get { return this.mWeight; }
            set { this.mWeight = value; }
        }

        private string mHeight;
        public string Height
        {
            get { return this.mHeight; }
            set { this.mHeight = value; }
        }

        private string mOther;
        public string Other
        {
            get { return this.mOther; }
            set { this.mOther = value; }
        }

        private string mSPO2;
        public string SPO2
        {
            get { return this.mSPO2; }
            set { this.mSPO2 = value; }
        }

        private string mPULSE;
        public string PULSE
        {
            get { return this.mPULSE; }
            set { this.mPULSE = value; }
        }
        #endregion

        #region Overridden

        internal override bool CreateRecord()
        {
            return base.CreateRecord();
        }

        internal override bool Populate(SqlDataReader dr)
        {
            bool r = false;

            if (dr != null && AppShared.IsNotNull(dr[Columns.PatientVitalGuid]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.PatientVitalId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.PatientVitalGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.PatientVitalPatientGuid]);
                this.mDate = AppShared.DbValueToDateTime(dr[Columns.PatientVitalDate]);
                this.mTime = AppShared.DbValueToString(dr[Columns.PatientVitalTime]);
                this.mBP = AppShared.DbValueToString(dr[Columns.PatientVitalBP]);
                this.mHR = AppShared.DbValueToString(dr[Columns.PatientVitalHR]);
                this.mRR = AppShared.DbValueToString(dr[Columns.PatientVitalRR]);
                this.mTemp = AppShared.DbValueToString(dr[Columns.PatientVitalTemp]);
                this.mRBS = AppShared.DbValueToString(dr[Columns.PatientVitalRBS]);
                this.mECG = AppShared.DbValueToString(dr[Columns.PatientVitalECG]);
                this.mWeight = AppShared.DbValueToString(dr[Columns.PatientVitalWeight]);
                this.mHeight = AppShared.DbValueToString(dr[Columns.PatientVitalHeight]);
                this.mOther = AppShared.DbValueToString(dr[Columns.PatientVitalOther]);
                this.mSPO2 = AppShared.DbValueToString(dr[Columns.PatientVitalSPO2]);
                this.mPULSE = AppShared.DbValueToString(dr[Columns.PatientVitalPULSE]);
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
            using (SqlDataReader dr = AppDAL.PatientVitalSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            bool r = AppDAL.PatientVitalInsert(this.mObjectGuid, this.mPatientGuid, this.mDate, this.mTime, this.mBP, this.mHR, this.mRR, this.mTemp, this.mRBS, this.mECG, this.mWeight, this.mHeight, this.mOther,this.mSPO2,this.mPULSE);
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.PatientVitalUpdate(this.mObjectGuid, this.mPatientGuid, this.mDate, this.mTime, this.mBP, this.mHR, this.mRR, this.mTemp, this.mRBS, this.mECG, this.mWeight, this.mHeight, this.mOther, this.mSPO2, this.mPULSE);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.PatientVitalDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            //this.mCategoryName = string.Empty;
        }
        #endregion
    }
        public sealed class PatientVitalCollection : ObjectCollection<PatientVital>
        {

            #region PatientVitalCollection
            /*public PatientVitalCollection(string searchText)
            {
                using (SqlDataReader dr = AppDAL.PatientVitalSearch(searchText))
                {
                    LoadObjectsFromReader(dr);
                }
            }*/

            public PatientVitalCollection(string searchText, DateTime dateFrom, DateTime dateTo)
            {
            using (SqlDataReader dr = AppDAL.PatientVitalSearch(searchText, dateFrom, dateTo))
            {
                LoadObjectsFromReader(dr);
            }
        }
            #endregion

            #region PatientVitalCollection

            public PatientVitalCollection()
            {
                using (SqlDataReader dr = AppDAL.PatientVitalSelectAll())
                {
                    LoadObjectsFromReader(dr);
                }
            }
            #endregion
        }
    }
