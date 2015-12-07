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

    public partial class IPDPatientTreamentDetailsReport : Form
    {
        public Guid PatientGuid;
        public Guid IPDPatientTreatmentSheetGuid;
        public string PatientName;

        Patient objPatient;
        IPDPatientTreatmentSheet objTreatmentSheet;

        public IPDPatientTreamentDetailsReport()
        {
            InitializeComponent();
        }

        private void IPDPatientTreatmentSheet_Load(object sender, EventArgs e)
        {

            if (IPDPatientTreatmentSheetGuid != Guid.Empty)
            {
                DataSet1 ds = new DataSet1();
                Hospital.Reports.IPDPatientTreatmentSheetDetails objIPDPatientTreatmentSheetDetailsRpt = new Reports.IPDPatientTreatmentSheetDetails();
                TextObject txtPatientName = objIPDPatientTreatmentSheetDetailsRpt.ReportDefinition.ReportObjects["txtPatientName"] as TextObject;
                TextObject txtIPDNo = objIPDPatientTreatmentSheetDetailsRpt.ReportDefinition.ReportObjects["txtIPDNo"] as TextObject;
                TextObject txtInchargeDoctor = objIPDPatientTreatmentSheetDetailsRpt.ReportDefinition.ReportObjects["txtInchargeDoctor"] as TextObject;
                TextObject txtDiagnosis = objIPDPatientTreatmentSheetDetailsRpt.ReportDefinition.ReportObjects["txtDiagnosis"] as TextObject;

                //
                TextObject txtTreatmentDate = objIPDPatientTreatmentSheetDetailsRpt.ReportDefinition.ReportObjects["txtTreatmentDate"] as TextObject;
                TextObject txtDietAdvice = objIPDPatientTreatmentSheetDetailsRpt.ReportDefinition.ReportObjects["txtDietAdvice"] as TextObject;
                TextObject txtSOSDrug = objIPDPatientTreatmentSheetDetailsRpt.ReportDefinition.ReportObjects["txtSOSDrug"] as TextObject;
                TextObject txtSpecialAdvice = objIPDPatientTreatmentSheetDetailsRpt.ReportDefinition.ReportObjects["txtSpecialAdvice"] as TextObject;
                //


                if (PatientGuid != Guid.Empty)
                {
                    objPatient = new Patient(PatientGuid);
                    if (objPatient != null)
                    {
                        txtIPDNo.Text = objPatient.PatientIndoorNo.ToString();
                        txtPatientName.Text = objPatient.DisplayName;
                        txtInchargeDoctor.Text = objPatient.PatientDoctorIncharge;
                        txtDiagnosis.Text = objPatient.PatientFinalDiagnosis;

                    }
                }

                objTreatmentSheet = new IPDPatientTreatmentSheet(IPDPatientTreatmentSheetGuid);
                if (objTreatmentSheet != null)
                {
                    
                    txtDietAdvice.Text = objTreatmentSheet.DiatAdvice;
                    txtSOSDrug.Text = objTreatmentSheet.SOSDrug;
                    txtSpecialAdvice.Text = objTreatmentSheet.SpecialAdvice;
                    txtTreatmentDate.Text = Common.DateToString(objTreatmentSheet.SheetDate);
                }

                var obj = Report.GetIPDPatientTreatmentSheetDetailsReport(IPDPatientTreatmentSheetGuid);
                ds.Tables["IPDPatientTreatmentSheetDetails"].Merge(obj);

                var objVital = Report.GetIPDPatientVitalsByDate(PatientGuid, objTreatmentSheet.SheetDate);
                ds.Tables["PatientVitalDetails"].Merge(objVital);

                ReportDocument reportdocument = new ReportDocument();
                objIPDPatientTreatmentSheetDetailsRpt.SetDataSource(ds);
                IPDPatientTreatmentSheet.ReportSource = objIPDPatientTreatmentSheetDetailsRpt;

            }
        }
    }
}
