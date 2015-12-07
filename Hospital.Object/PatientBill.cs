using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Hospital.Object
{
    public sealed class PatientBill : Objectbase
    {
        internal struct Columns
        {
            public const string BillId = "PatientBillId";
            public const string BillGuid = "PatientBillGuid";
            public const string PatientGuid = "PatientBilPatientGuid";
            public const string BillDate = "PatientBillDate";
            public const string BillOther = "PatientBillOther";
        }

        #region Constructor
        public PatientBill() : base() { }

        public PatientBill(Guid key) : base(key) { }

        public PatientBill(SqlDataReader dr) : base(dr) { }
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

        public string OPDNo
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
                    if (obj.IsOPD)
                    {
                        return obj.Number.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }

            }
        }

        public string IPDNo
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
                    if (obj.IsIPD)
                    {
                        return obj.Number.ToString();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }

            }
        }

        //public string PatientContactNo
        //{
        //    get
        //    {
        //        Patient obj = this.Patient;
        //        return (IsNullOrEmpty(obj) ? string.Empty : obj.ContactNo);
        //    }
        //}

        private DateTime mPatientBillDate;
        public DateTime PatientBillDate
        {
            get { return this.mPatientBillDate; }
            set { this.mPatientBillDate = value; }
        }

        private string mOther;
        public string Other
        {
            get { return this.mOther; }
            set { this.mOther = value; }
        }

        //private DateTime mPatientAdmittedDate;
        //public DateTime PatientAdmittedDate
        //{
        //    get
        //    {
        //        Patient obj = this.Patient;
        //        return (IsNullOrEmpty(obj) || string.IsNullOrEmpty(obj.AdmittedDate.ToString())? DateTime.MinValue : obj.AdmittedDate);
        //    }
        //}

        PatientMedicineSale mPatientMedicineSale;
        public PatientMedicineSale PatientMedicineSale
        {
            get { return this.mPatientMedicineSale; }
            set { this.mPatientMedicineSale = value; }
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

            if (dr != null && AppShared.IsNotNull(dr[Columns.BillId]))
            {
                this.mId = AppShared.DbValueToInteger(dr[Columns.BillId]);
                this.mObjectGuid = AppShared.DbValueToGuid(dr[Columns.BillGuid]);
                this.mPatientGuid = AppShared.DbValueToGuid(dr[Columns.PatientGuid]);
                this.mPatientBillDate = AppShared.DbValueToDateTime(dr[Columns.BillDate]);
                this.mOther = AppShared.DbValueToString(dr[Columns.BillOther]);
                this.Status = ObjectStatus.Opened;
                r = true;
            }
            return r;
        }

        protected override bool OpenRecord(Guid key)
        {
            bool r = false;
            using (SqlDataReader dr = AppDAL.PatientBillSelect(key))
                r = dr != null && dr.Read() && this.Populate(dr);
            return r;

        }

        protected override bool InsertRecord()
        {
            bool r = AppDAL.PatientBillInsert(this.mObjectGuid, this.mPatientGuid, this.mPatientBillDate, this.mOther);
            return r;
        }

        protected override bool UpdateRecord()
        {
            bool r = AppDAL.PatientBillUpdate(this.mObjectGuid, this.mPatientGuid, this.mPatientBillDate, this.mOther);
            return r;
        }

        protected override bool DeleteRecord()
        {
            return AppDAL.PatientBillDelete(this.mObjectGuid);
        }

        protected override void Reset()
        {
            base.Reset();
            this.mPatientGuid = Guid.Empty;
            this.mPatientBillDate = DateTime.MinValue;
            this.mOther = string.Empty;
        }

        protected override bool UpdateChild()
        {
            bool r = true;
            if (this.mPatientMedicineSale != null)
            {
                this.mPatientMedicineSale.BillGuid = this.mObjectGuid;
                this.mPatientMedicineSale.MarkToSave();
                this.mPatientMedicineSale.UpdateChanges();
            }

            return r;
        }
        #endregion
    }

    public sealed class PatientBillCollection : ObjectCollection<PatientBill>
    {
        #region PatientCollection
        //public PatientBillCollection()
        //{
        //    using (SqlDataReader dr = AppDAL.PatientSelectAll())
        //    {
        //        LoadObjectsFromReader(dr);
        //    }
        //}

        #endregion

        #region PatientCollection
        public PatientBillCollection(string searchText)
        {
            using (SqlDataReader dr = AppDAL.PatientBillSearch(searchText))
            {
                LoadObjectsFromReader(dr);
            }
        }
        #endregion
    }
}
