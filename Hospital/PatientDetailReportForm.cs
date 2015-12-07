using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using System.Configuration;
using Hospital.Object;
using Hospital.Dataset;

namespace Hospital
{
    public partial class PatientDetailReportForm : Form
    {
        public Guid PatientGuid;

        Hospital.Reports.PatientDetailReport objrpt;

        public PatientDetailReportForm()
        {
            InitializeComponent();
        }

        private void PatientDetailReportForm_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            var obj = Report.GetPatientDetailReport(PatientGuid);
            ds.Tables["PatientRelatedDetail"].Merge(obj);
            objrpt = new Reports.PatientDetailReport();
            ReportDocument reportdocument = new ReportDocument();
            objrpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = objrpt;
        }
    }
}
