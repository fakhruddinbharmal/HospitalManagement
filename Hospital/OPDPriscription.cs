using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using Hospital.Dataset;
using Hospital.Object;

namespace Hospital
{
    public partial class OPDPriscription : Form
    {
        Hospital.Reports.OPDPriscription objrpt;
        Hospital.Reports.TreatmentReport TreatRpt;
        HistoryProcedure objHP;
        Patient objPatient;
        public Guid HistoryProcedureGuid; 
        public OPDPriscription()
        {
            InitializeComponent();
           
        }     

        private void OPDPriscription_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            
            
            objHP = new HistoryProcedure(HistoryProcedureGuid);
            var obj = Report.GetOPDPrescription(objHP.Date);
            var objTreatment = Report.GetOPDTreatment(objHP.Date);
            objPatient = new Patient(objHP.PatientGuid);
            if (obj != null)
            {
                ds.Tables[2].Merge(obj);
            }
            if (objTreatment != null)
            {
                ds.Tables[3].Merge(objTreatment);
            }
            TreatRpt = new Reports.TreatmentReport();
            TreatRpt.SetDataSource(ds);
            objrpt = new Reports.OPDPriscription();
            objrpt.SetDataSource(ds);

            TextObject txtDate = objrpt.ReportDefinition.ReportObjects["txtDate"] as TextObject;
            TextObject txtPatientName = objrpt.ReportDefinition.ReportObjects["txtPatientName"] as TextObject;
            TextObject txtBP = objrpt.ReportDefinition.ReportObjects["txtBP"] as TextObject;
            TextObject txtHR = objrpt.ReportDefinition.ReportObjects["txtHR"] as TextObject;
            TextObject txtRR = objrpt.ReportDefinition.ReportObjects["txtRR"] as TextObject;
            TextObject txtTEMP = objrpt.ReportDefinition.ReportObjects["txtTEMP"] as TextObject;
            TextObject txtRBS = objrpt.ReportDefinition.ReportObjects["txtRBS"] as TextObject;
            TextObject txtECG = objrpt.ReportDefinition.ReportObjects["txtECG"] as TextObject;
            TextObject txtWt = objrpt.ReportDefinition.ReportObjects["txtWt"] as TextObject;
            TextObject txtOther = objrpt.ReportDefinition.ReportObjects["txtOther"] as TextObject;
            TextObject txtFollowUp = objrpt.ReportDefinition.ReportObjects["txtFollowUp"] as TextObject;

            txtPatientName.Text = objPatient.DisplayName;
           // txtDate.Text = objHP.Date.ToShortDateString(); 
            txtDate.Text = objHP.Date.ToString("dd/MM/yyyy");
            txtBP.Text = objHP.BP;
            txtHR.Text = objHP.HR;
            txtRR.Text = objHP.RR;
            txtTEMP.Text = objHP.Temp;
            txtRBS.Text = objHP.RBS;
            txtECG.Text = objHP.ECG;
            txtWt.Text = objHP.Wt;
            txtOther.Text = objHP.Other;
            txtFollowUp.Text = objHP.FollowUpDate != DateTime.MinValue ? objHP.FollowUpDate.ToString("dd/MM/yyyy") : string.Empty;
            
            ReportDocument reportdocument = new ReportDocument();

            crystalReportViewer1.ReportSource = objrpt;
            crystalReportViewer1.Refresh();
        }         
    }
}
