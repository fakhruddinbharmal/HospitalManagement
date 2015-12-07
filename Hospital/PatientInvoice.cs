using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Object;
using CrystalDecisions.CrystalReports.Engine;
using Hospital.Dataset;
using Hospital.Reports;

namespace Hospital
{
    public partial class PatientInvoice : Form
    {
        public Guid PatientGuid;
        public Guid PatientMedicineBillGuid;
        public string PatientName;

        Hospital.Reports.PatientBillReport objrpt;
        Patient objPatient;

        public PatientInvoice()
        {
            InitializeComponent();
        }

        private void PatientInvoice_Load(object sender, EventArgs e)
        {

            DataSet1 ds = new DataSet1();
            if (PatientMedicineBillGuid != Guid.Empty)
            {
                Hospital.Reports.PatientMedicineSale objPatientMedicineSaleRpt = new Hospital.Reports.PatientMedicineSale();
                TextObject txtPatientName = objPatientMedicineSaleRpt.ReportDefinition.ReportObjects["txtPatientName"] as TextObject;
                TextObject txtPatientAge = objPatientMedicineSaleRpt.ReportDefinition.ReportObjects["txtPatientAge"] as TextObject;
                TextObject txtAddress = objPatientMedicineSaleRpt.ReportDefinition.ReportObjects["txtAddress"] as TextObject;
                TextObject txtOPDNo = objPatientMedicineSaleRpt.ReportDefinition.ReportObjects["txtOPDNo"] as TextObject;
                TextObject txtIPDNo = objPatientMedicineSaleRpt.ReportDefinition.ReportObjects["txtIPDNo"] as TextObject;
                TextObject txtMobileNo = objPatientMedicineSaleRpt.ReportDefinition.ReportObjects["txtMobileNo"] as TextObject;
                TextObject txtAdmittedDate = objPatientMedicineSaleRpt.ReportDefinition.ReportObjects["txtAdmittedDate"] as TextObject;
                txtPatientName.Text = PatientName;

                if (PatientGuid != Guid.Empty)
                {
                    objPatient = new Patient(PatientGuid);

                    txtPatientAge.Text = objPatient.Age.ToString();
                    txtAddress.Text = objPatient.Address;
                    if (objPatient.IsIPD)
                    {
                        txtIPDNo.Text = objPatient.PatientIndoorNo.ToString();
                    }
                    else
                    {
                        txtOPDNo.Text = objPatient.Number.ToString();
                    }
                    txtMobileNo.Text = objPatient.ContactNo;
                    txtAdmittedDate.Text = Common.DateToString(objPatient.AdmittedDate);
                }

                var obj = Report.GetPatientMedicineSaleReport(PatientMedicineBillGuid);
                ds.Tables[4].Merge(obj);
                ReportDocument reportdocument = new ReportDocument();
                objPatientMedicineSaleRpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = objPatientMedicineSaleRpt;
            }
            else
            {
                var obj = Report.GetReport(PatientGuid);
                objPatient = new Patient(PatientGuid);

                ds.Tables[0].Merge(obj);
                objrpt = new Reports.PatientBillReport();

                TextObject txtPatientName = objrpt.ReportDefinition.ReportObjects["txtPatientName"] as TextObject;
                TextObject txtInvoiceNo = objrpt.ReportDefinition.ReportObjects["txtInvoiceNo"] as TextObject;
                TextObject txtPatientNo = objrpt.ReportDefinition.ReportObjects["txtPatientNo"] as TextObject;
                TextObject txtMobileNo = objrpt.ReportDefinition.ReportObjects["txtMobileNo"] as TextObject;
                //TextObject txtCity = objrpt.ReportDefinition.ReportObjects["txtCity"] as TextObject;
                TextObject txtAddress = objrpt.ReportDefinition.ReportObjects["txtAddress"] as TextObject;
                TextObject txtAdmittedDate = objrpt.ReportDefinition.ReportObjects["txtAdmittedDate"] as TextObject;
                TextObject txtDischaegeDate = objrpt.ReportDefinition.ReportObjects["txtDischaegeDate"] as TextObject;
                TextObject txtBillDate = objrpt.ReportDefinition.ReportObjects["txtBillDate"] as TextObject;
                TextObject txtTypeOfCase = objrpt.ReportDefinition.ReportObjects["txtTypeOfCase"] as TextObject;
                TextObject txtAge = objrpt.ReportDefinition.ReportObjects["txtAge"] as TextObject;

                txtPatientName.Text = objPatient.DisplayName;
                //txtInvoiceNo.Text = Common.IntToString(objPatient.InvoiceNo);
                //txtPatientNo.Text = Common.IntToString(objPatient.Number);
                txtInvoiceNo.Text = objPatient.PatientBillNo;
                txtPatientNo.Text = objPatient.PatientIndoorNo;
                txtMobileNo.Text = objPatient.ContactNo;
                //txtCity.Text = objPatient.City;
                txtAddress.Text = objPatient.Address;
                txtAdmittedDate.Text = Common.DateToString(objPatient.AdmittedDate);
                txtDischaegeDate.Text = Common.DateToString(objPatient.DischargeDate);
                txtBillDate.Text = Common.DateToString(objPatient.InvoiceDate);
                txtTypeOfCase.Text = objPatient.PatientTypeOfCase;
                txtAge.Text = objPatient.Age > 0 ? objPatient.Age.ToString() : string.Empty; ;

                ReportDocument reportdocument = new ReportDocument();
                objrpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = objrpt;
            }
        }
    }

}
