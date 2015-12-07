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
    public partial class DischargeSummeryReport : Form
    {
      
        public Guid PatientGuid;

        Hospital.Reports.DischargeSummeryReport objrpt;

        public DischargeSummeryReport()
        {
            InitializeComponent();
        }

        private void DischargeSummeryReportForm_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            var obj = Report.GetDischargeSummeryReport(PatientGuid);
            var objtre = Report.GetDischargeTreatmentRpt(PatientGuid);
            ds.Tables["DischargeSummery"].Merge(obj);
            ds.Tables["DischargeTreatment"].Merge(objtre);
            objrpt = new Reports.DischargeSummeryReport();
            ReportDocument reportdocument = new ReportDocument();
            objrpt.SetDataSource(ds);
            DischargeSummeryReportForm.ReportSource = objrpt;
        }
    }
}
