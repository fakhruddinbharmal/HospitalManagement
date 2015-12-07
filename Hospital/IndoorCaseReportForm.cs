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
    public partial class IndoorCaseReportForm : Form
    {
        public Guid PatientGuid;

        Hospital.Reports.IndoorCaseReport objrpt;

        public IndoorCaseReportForm()
        {
            InitializeComponent();
        }

        private void IndoorCaseReportForm_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            var obj = Report.GetIndoorCaseReport(PatientGuid);
            ds.Tables["PatientDetail"].Merge(obj);
            objrpt = new Reports.IndoorCaseReport();
            ReportDocument reportdocument = new ReportDocument();
            objrpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = objrpt;
        }
    }
}
