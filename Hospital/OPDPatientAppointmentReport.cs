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
using Hospital.Dataset;
using Hospital.Object;

namespace Hospital
{
    public partial class OPDPatientAppointmentReport : Form
    {
        Hospital.Reports.AppointmentReport objrpt;

        private DateTime d1;
        private DateTime d2;

        public OPDPatientAppointmentReport()
        {
            InitializeComponent();
            DataSet1 ds = new DataSet1();
            DateTime fromdate = DateTime.Now.Date;
            DateTime toDate = DateTime.Now.Date.AddDays(7);
            var obj = Report.GetAppointmentFor7Days(fromdate,toDate);

            dtpFromDate.Value = fromdate;
            dtpToDate.Value = toDate;
            
            if (obj != null)
            {
                ds.Tables["PatientAppointment"].Merge(obj);
            }
            objrpt = new Reports.AppointmentReport();
            ReportDocument reportdocument = new ReportDocument();
            objrpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = objrpt;
            crystalReportViewer1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            d1 = dtpFromDate.Value;
            d2 = dtpToDate.Value;

            var obj = Report.GetAppointmentReport(d1, d2);
            if (obj != null)
            {
                ds.Tables["PatientAppointment"].Merge(obj);
            }
            objrpt = new Reports.AppointmentReport();
            ReportDocument reportdocument = new ReportDocument();
            objrpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = objrpt;
            crystalReportViewer1.Refresh();

        }
    }
}
