using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hospital.Object;
using System.Text.RegularExpressions;

namespace Hospital
{
    public partial class PatientForm : ObjectbaseForm
    {
        private Patient mEntry;
        private IPDPatientTreatments IPDPatienttreatments;
        private IPDPatientTreatment obj;
        private bool IsOPD = false;

        #region PatientForm

        public PatientForm() : this(null) { }
        public PatientForm(Patient patient)
            : base(patient)
        {
            this.mEntry = patient;
            this.IPDPatienttreatments = new IPDPatientTreatments(this.mEntry.ObjectGuid);
            this.InitializeComponent();
            this.UserInitialize();

        }
        #endregion

        #region UserIntialize
        private void UserInitialize()
        {
            /*--------------------First tab page------------------------------------------------------------------*/

            #region firsttabpage

            this.txtFirstName.Tag = this.lblFirstName;
            this.lblFirstName.Click += new EventHandler(OnLabelClick);
            this.txtFirstName.Enter += new EventHandler(OnControlEnter);
            this.txtFirstName.Leave += new EventHandler(OnControlLeave);

            this.txtMiddleName.Tag = this.lblMiddleName;
            this.lblMiddleName.Click += new EventHandler(OnLabelClick);
            this.txtMiddleName.Enter += new EventHandler(OnControlEnter);
            this.txtMiddleName.Leave += new EventHandler(OnControlLeave);

            this.txtLastName.Tag = this.lblLastName;
            this.lblLastName.Click += new EventHandler(OnLabelClick);
            this.txtLastName.Enter += new EventHandler(OnControlEnter);
            this.txtLastName.Leave += new EventHandler(OnControlLeave);

            this.cmbGender.Tag = this.lblGender;
            this.lblGender.Click += new EventHandler(OnLabelClick);
            this.cmbGender.Enter += new EventHandler(OnControlEnter);
            this.cmbGender.Leave += new EventHandler(OnControlLeave);

            this.nupAge.Tag = this.lblAge;
            this.lblAge.Click += new EventHandler(OnLabelClick);
            this.nupAge.Enter += new EventHandler(OnControlEnter);
            this.nupAge.Leave += new EventHandler(OnControlLeave);

            this.cmbReference.Tag = this.lblReference;
            this.lblReference.Click += new EventHandler(OnLabelClick);
            this.cmbReference.Enter += new EventHandler(OnControlEnter);
            this.cmbReference.Leave += new EventHandler(OnControlLeave);

            this.txtCity.Tag = this.lblCityTown;
            this.lblCityTown.Click += new EventHandler(OnLabelClick);
            this.txtCity.Enter += new EventHandler(OnControlEnter);
            this.txtCity.Leave += new EventHandler(OnControlLeave);

            this.txtDistrict.Tag = this.lblDistrict;
            this.lblDistrict.Click += new EventHandler(OnLabelClick);
            this.txtDistrict.Enter += new EventHandler(OnControlEnter);
            this.txtDistrict.Leave += new EventHandler(OnControlLeave);

            this.txtTaluko.Tag = this.lblTaluko;
            this.lblTaluko.Click += new EventHandler(OnLabelClick);
            this.txtTaluko.Enter += new EventHandler(OnControlEnter);
            this.txtTaluko.Leave += new EventHandler(OnControlLeave);

            this.txtAddress.Tag = this.lblAddress;
            this.lblAddress.Click += new EventHandler(OnLabelClick);
            this.txtAddress.Enter += new EventHandler(OnControlEnter);
            this.txtAddress.Leave += new EventHandler(OnControlLeave);

            this.txtOccupation.Tag = this.lblOccupation;
            this.lblOccupation.Click += new EventHandler(OnLabelClick);
            this.txtOccupation.Enter += new EventHandler(OnControlEnter);
            this.txtOccupation.Leave += new EventHandler(OnControlLeave);

            this.txtOccupationFullAddress.Tag = this.lblOccupationFullAddress;
            this.lblOccupationFullAddress.Click += new EventHandler(OnLabelClick);
            this.txtOccupationFullAddress.Enter += new EventHandler(OnControlEnter);
            this.txtOccupationFullAddress.Leave += new EventHandler(OnControlLeave);

            this.txtPhoneNoOther.Tag = this.lblPhone;
            this.lblPhone.Click += new EventHandler(OnLabelClick);
            this.txtPhoneNoOther.Enter += new EventHandler(OnControlEnter);
            this.txtPhoneNoOther.Leave += new EventHandler(OnControlLeave);

            this.txtResidentialPhone.Tag = this.lblPhoneReseidence;
            this.lblPhoneReseidence.Click += new EventHandler(OnLabelClick);
            this.txtResidentialPhone.Enter += new EventHandler(OnControlEnter);
            this.txtResidentialPhone.Leave += new EventHandler(OnControlLeave);

            this.txtContactNo.Tag = this.lblContactNo;
            this.lblContactNo.Click += new EventHandler(OnLabelClick);
            this.txtContactNo.Enter += new EventHandler(OnControlEnter);
            this.txtContactNo.Leave += new EventHandler(OnControlLeave);

            this.cmbMaritalStatus.Tag = this.lblMaritalStatus;
            this.lblMaritalStatus.Click += new EventHandler(OnLabelClick);
            this.cmbMaritalStatus.Enter += new EventHandler(OnControlEnter);
            this.cmbMaritalStatus.Leave += new EventHandler(OnControlLeave);

            this.nupMarrgeTimeYear.Tag = this.lblMarrageTimeyear;
            this.lblMarrageTimeyear.Click += new EventHandler(OnLabelClick);
            this.nupMarrgeTimeYear.Enter += new EventHandler(OnControlEnter);
            this.nupMarrgeTimeYear.Leave += new EventHandler(OnControlLeave);

            this.nupChildren.Tag = this.lblChildern;
            this.lblChildern.Click += new EventHandler(OnLabelClick);
            this.nupChildren.Enter += new EventHandler(OnControlEnter);
            this.nupChildren.Leave += new EventHandler(OnControlLeave);

            this.cmbWards.Tag = this.lblWards;
            this.lblWards.Click += new EventHandler(OnLabelClick);
            this.cmbWards.Enter += new EventHandler(OnControlEnter);
            this.cmbWards.Leave += new EventHandler(OnControlLeave);

            this.cmbRoomBedNo.Tag = this.lblRoomNo;
            this.lblRoomNo.Click += new EventHandler(OnLabelClick);
            this.cmbRoomBedNo.Enter += new EventHandler(OnControlEnter);
            this.cmbRoomBedNo.Leave += new EventHandler(OnControlLeave);

            this.txtDoctorIncharge.Tag = this.lblDoctorIncharge;
            this.lblDoctorIncharge.Click += new EventHandler(OnLabelClick);
            this.txtDoctorIncharge.Enter += new EventHandler(OnControlEnter);
            this.txtDoctorIncharge.Leave += new EventHandler(OnControlLeave);

            this.cmbReferredDoctor.Tag = this.lblRefferedDoctor;
            this.lblRefferedDoctor.Click += new EventHandler(OnLabelClick);
            this.cmbReferredDoctor.Enter += new EventHandler(OnControlEnter);
            this.cmbReferredDoctor.Leave += new EventHandler(OnControlLeave);

            this.nupReferredDoctorShare.Tag = this.lblReferredDoctorShare;
            this.lblReferredDoctorShare.Click += new EventHandler(OnLabelClick);
            this.nupReferredDoctorShare.Enter += new EventHandler(OnControlEnter);
            this.nupReferredDoctorShare.Leave += new EventHandler(OnControlLeave);

            this.dtpBirthDate.Tag = this.lblDateOfBirth;
            this.lblDateOfBirth.Click += new EventHandler(OnLabelClick);
            this.dtpBirthDate.Enter += new EventHandler(OnControlEnter);
            this.dtpBirthDate.Leave += new EventHandler(OnControlLeave);

            this.dtpAdmitedDate.Tag = this.lblAdmitedDate;
            this.lblAdmitedDate.Click += new EventHandler(OnLabelClick);
            this.dtpAdmitedDate.Enter += new EventHandler(OnControlEnter);
            this.dtpAdmitedDate.Leave += new EventHandler(OnControlLeave);

            this.cmbAdmitedTime.Tag = this.lblAdmitedTime;
            this.lblAdmitedTime.Click += new EventHandler(OnLabelClick);
            this.cmbAdmitedTime.Enter += new EventHandler(OnControlEnter);
            this.cmbAdmitedTime.Leave += new EventHandler(OnControlLeave);

            this.txtAdmittedBy.Tag = this.lblAdmittedBy;
            this.lblAdmittedBy.Click += new EventHandler(OnLabelClick);
            this.txtAdmittedBy.Enter += new EventHandler(OnControlEnter);
            this.txtAdmittedBy.Leave += new EventHandler(OnControlLeave);

            this.txtChiefComplaints.Tag = this.lblChiefCompaint;
            this.lblChiefCompaint.Click += new EventHandler(OnLabelClick);
            this.txtChiefComplaints.Enter += new EventHandler(OnControlEnter);
            this.txtChiefComplaints.Leave += new EventHandler(OnControlLeave);

            this.cmbCamePreviously.Tag = this.lblCanPrevious;
            this.lblCanPrevious.Click += new EventHandler(OnLabelClick);
            this.cmbCamePreviously.Enter += new EventHandler(OnControlEnter);
            this.cmbCamePreviously.Leave += new EventHandler(OnControlLeave);

            this.txtProvisionalDiagnosis.Tag = this.lblProvisonalDiagonsis;
            this.lblProvisonalDiagonsis.Click += new EventHandler(OnLabelClick);
            this.txtProvisionalDiagnosis.Enter += new EventHandler(OnControlEnter);
            this.txtProvisionalDiagnosis.Leave += new EventHandler(OnControlLeave);

            this.txtTypeOfCase.Tag = this.lblTypeOfCase;
            this.lblTypeOfCase.Click += new EventHandler(OnLabelClick);
            this.txtTypeOfCase.Enter += new EventHandler(OnControlEnter);
            this.txtTypeOfCase.Leave += new EventHandler(OnControlLeave);

            this.txtHT.Tag = this.lblHT;
            this.lblHT.Click += new EventHandler(OnLabelClick);
            this.txtHT.Enter += new EventHandler(OnControlEnter);
            this.txtHT.Leave += new EventHandler(OnControlLeave);

            this.txtDrugAllergy.Tag = this.lblDrugAllergy;
            this.lblDrugAllergy.Click += new EventHandler(OnLabelClick);
            this.txtDrugAllergy.Enter += new EventHandler(OnControlEnter);
            this.txtDrugAllergy.Leave += new EventHandler(OnControlLeave);

            this.txtDM.Tag = this.lblDM;
            this.lblDM.Click += new EventHandler(OnLabelClick);
            this.txtDM.Enter += new EventHandler(OnControlEnter);
            this.txtDM.Leave += new EventHandler(OnControlLeave);

            this.txtPregnency.Tag = this.lblPregnency;
            this.lblPregnency.Click += new EventHandler(OnLabelClick);
            this.txtPregnency.Enter += new EventHandler(OnControlEnter);
            this.txtPregnency.Leave += new EventHandler(OnControlLeave);

            this.txtIHD.Tag = this.lblIHD;
            this.lblIHD.Click += new EventHandler(OnLabelClick);
            this.txtIHD.Enter += new EventHandler(OnControlEnter);
            this.txtIHD.Leave += new EventHandler(OnControlLeave);

            this.txtBT.Tag = this.lblBT;
            this.lblBT.Click += new EventHandler(OnLabelClick);
            this.txtBT.Enter += new EventHandler(OnControlEnter);
            this.txtBT.Leave += new EventHandler(OnControlLeave);

            this.txtMajorIllness.Tag = this.lblMajorIllness;
            this.lblMajorIllness.Click += new EventHandler(OnLabelClick);
            this.txtMajorIllness.Enter += new EventHandler(OnControlEnter);
            this.txtMajorIllness.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeTemprature.Tag = this.lblAdmitTimeTemprature;
            this.lblAdmitTimeTemprature.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeTemprature.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeTemprature.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeSPO2.Tag = this.lblAdmitTimeSPO2;
            this.lblAdmitTimeSPO2.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeSPO2.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeSPO2.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeRBS.Tag = this.lblAdmitTimeRBS;
            this.lblAdmitTimeRBS.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeRBS.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeRBS.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeWeight.Tag = this.lblAdmitTimeWeight;
            this.lblAdmitTimeWeight.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeWeight.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeWeight.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimePulse.Tag = this.lblAdmitTimePulse;
            this.lblAdmitTimePulse.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimePulse.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimePulse.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeBP.Tag = this.lblAdmitTimeBP;
            this.lblAdmitTimeBP.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeBP.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeBP.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeECG.Tag = this.lblAdmitTimeECG;
            this.lblAdmitTimeECG.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeECG.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeECG.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeHeight.Tag = this.lblAdmitTimeHeight;
            this.lblAdmitTimeHeight.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeHeight.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeHeight.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeRR.Tag = this.lblAdmitTimeRR;
            this.lblAdmitTimeRR.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeRR.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeRR.Leave += new EventHandler(OnControlLeave);

            this.txtAdmitTimeHR.Tag = this.lblAdmitTimeHR;
            this.lblAdmitTimeHR.Click += new EventHandler(OnLabelClick);
            this.txtAdmitTimeHR.Enter += new EventHandler(OnControlEnter);
            this.txtAdmitTimeHR.Leave += new EventHandler(OnControlLeave);

            this.txtAdmittimeOther.Tag = this.lblAdmittimeOther;
            this.lblAdmittimeOther.Click += new EventHandler(OnLabelClick);
            this.txtAdmittimeOther.Enter += new EventHandler(OnControlEnter);
            this.txtAdmittimeOther.Leave += new EventHandler(OnControlLeave);

            this.txtSystemicExamination.Tag = this.lblSystemicExamination;
            this.lblSystemicExamination.Click += new EventHandler(OnLabelClick);
            this.txtSystemicExamination.Enter += new EventHandler(OnControlEnter);
            this.txtSystemicExamination.Leave += new EventHandler(OnControlLeave);

            this.txtRS.Tag = this.lblRS;
            this.lblRS.Click += new EventHandler(OnLabelClick);
            this.txtRS.Enter += new EventHandler(OnControlEnter);
            this.txtRS.Leave += new EventHandler(OnControlLeave);

            this.txtPSOName.Tag = this.lblPSOName;
            this.lblPSOName.Click += new EventHandler(OnLabelClick);
            this.txtPSOName.Enter += new EventHandler(OnControlEnter);
            this.txtPSOName.Leave += new EventHandler(OnControlLeave);

            this.txtDivision.Tag = this.lblDivision;
            this.lblDivision.Click += new EventHandler(OnLabelClick);
            this.txtDivision.Enter += new EventHandler(OnControlEnter);
            this.txtDivision.Leave += new EventHandler(OnControlLeave);

            #endregion
            /*--------------------First tab page------------------------------------------------------------------*/

            /*--------------------second tab page------------------------------------------------------------------*/

            #region send tab page

            this.txtCVS.Tag = this.lblCVS;
            this.lblCVS.Click += new EventHandler(OnLabelClick);
            this.txtCVS.Enter += new EventHandler(OnControlEnter);
            this.txtCVS.Leave += new EventHandler(OnControlLeave);

            this.txtMO.Tag = this.lblMO;
            this.lblMO.Click += new EventHandler(OnLabelClick);
            this.txtMO.Enter += new EventHandler(OnControlEnter);
            this.txtMO.Leave += new EventHandler(OnControlLeave);

            this.txtCNS.Tag = this.lblCNS;
            this.lblCNS.Click += new EventHandler(OnLabelClick);
            this.txtCNS.Enter += new EventHandler(OnControlEnter);
            this.txtCNS.Leave += new EventHandler(OnControlLeave);

            this.txtPA.Tag = this.lblPA;
            this.lblPA.Click += new EventHandler(OnLabelClick);
            this.txtPA.Enter += new EventHandler(OnControlEnter);
            this.txtPA.Leave += new EventHandler(OnControlLeave);

            this.txtOther.Tag = this.lblOther;
            this.lblOther.Click += new EventHandler(OnLabelClick);
            this.txtOther.Enter += new EventHandler(OnControlEnter);
            this.txtOther.Leave += new EventHandler(OnControlLeave);

            this.txtSuggestedInvestigation.Tag = this.lblSuggestedInvestigation;
            this.lblSuggestedInvestigation.Click += new EventHandler(OnLabelClick);
            this.txtSuggestedInvestigation.Enter += new EventHandler(OnControlEnter);
            this.txtSuggestedInvestigation.Leave += new EventHandler(OnControlLeave);

            this.txtHistoryAndClinicalNote.Tag = this.lblHistoryAndClinicalNote;
            this.lblHistoryAndClinicalNote.Click += new EventHandler(OnLabelClick);
            this.txtHistoryAndClinicalNote.Enter += new EventHandler(OnControlEnter);
            this.txtHistoryAndClinicalNote.Leave += new EventHandler(OnControlLeave);

            this.txtTreatment.Tag = this.lblTreatment;
            this.lblTreatment.Click += new EventHandler(OnLabelClick);
            this.txtTreatment.Enter += new EventHandler(OnControlEnter);
            this.txtTreatment.Leave += new EventHandler(OnControlLeave);

            this.txtReceivingStaffReception.Tag = this.lblReceivingStaffReception;
            this.lblReceivingStaffReception.Click += new EventHandler(OnLabelClick);
            this.txtReceivingStaffReception.Enter += new EventHandler(OnControlEnter);
            this.txtReceivingStaffReception.Leave += new EventHandler(OnControlLeave);

            this.txtReceivingStaffMO.Tag = this.lblReceivingStaffMO;
            this.lblReceivingStaffMO.Click += new EventHandler(OnLabelClick);
            this.txtReceivingStaffMO.Enter += new EventHandler(OnControlEnter);
            this.txtReceivingStaffMO.Leave += new EventHandler(OnControlLeave);

            this.txtSenderPersonName.Tag = this.lblSenderPerson;
            this.lblSenderPerson.Click += new EventHandler(OnLabelClick);
            this.txtSenderPersonName.Enter += new EventHandler(OnControlEnter);
            this.txtSenderPersonName.Leave += new EventHandler(OnControlLeave);

            this.txtSigningPersonName.Tag = this.lblSigningPersonName;
            this.lblSigningPersonName.Click += new EventHandler(OnLabelClick);
            this.txtSigningPersonName.Enter += new EventHandler(OnControlEnter);
            this.txtSigningPersonName.Leave += new EventHandler(OnControlLeave);

            this.txtRelationShipWithPatient.Tag = this.lblRelationshipWithPatient;
            this.lblRelationshipWithPatient.Click += new EventHandler(OnLabelClick);
            this.txtRelationShipWithPatient.Enter += new EventHandler(OnControlEnter);
            this.txtRelationShipWithPatient.Leave += new EventHandler(OnControlLeave);

            this.dtpOperationDate.Tag = this.lblOperationDate;
            this.lblOperationDate.Click += new EventHandler(OnLabelClick);
            this.dtpOperationDate.Enter += new EventHandler(OnControlEnter);
            this.dtpOperationDate.Leave += new EventHandler(OnControlLeave);

            this.txtOperationTime.Tag = this.lblOperationTime;
            this.lblOperationTime.Click += new EventHandler(OnLabelClick);
            this.txtOperationTime.Enter += new EventHandler(OnControlEnter);
            this.txtOperationTime.Leave += new EventHandler(OnControlLeave);

            this.cmbInsurance.Tag = this.lblInsurance;
            this.lblInsurance.Click += new EventHandler(OnLabelClick);
            this.cmbInsurance.Enter += new EventHandler(OnControlEnter);
            this.cmbInsurance.Leave += new EventHandler(OnControlLeave);

            this.txtInsuranceCompany.Tag = this.lblInsuranceCompany;
            this.lblInsuranceCompany.Click += new EventHandler(OnLabelClick);
            this.txtInsuranceCompany.Enter += new EventHandler(OnControlEnter);
            this.txtInsuranceCompany.Leave += new EventHandler(OnControlLeave);

            this.txtAmount.Tag = this.lblAmount;
            this.lblAmount.Click += new EventHandler(OnLabelClick);
            this.txtAmount.Enter += new EventHandler(OnControlEnter);
            this.txtAmount.Leave += new EventHandler(OnControlLeave);

            #endregion
            /*--------------------second tab page------------------------------------------------------------------*/

            /*--------------------third tab page------------------------------------------------------------------*/

            #region thirdtabepage

            this.txtMLCNo.Tag = this.lblMLCNo;
            this.lblMLCNo.Click += new EventHandler(OnLabelClick);
            this.txtMLCNo.Enter += new EventHandler(OnControlEnter);
            this.txtMLCNo.Leave += new EventHandler(OnControlLeave);

            this.txtEntryNo.Tag = this.lblEntryNo;
            this.lblEntryNo.Click += new EventHandler(OnLabelClick);
            this.txtEntryNo.Enter += new EventHandler(OnControlEnter);
            this.txtEntryNo.Leave += new EventHandler(OnControlLeave);

            this.txtMarkOfIdentity.Tag = this.lblMarkOfIdentity;
            this.lblMarkOfIdentity.Click += new EventHandler(OnLabelClick);
            this.txtMarkOfIdentity.Enter += new EventHandler(OnControlEnter);
            this.txtMarkOfIdentity.Leave += new EventHandler(OnControlLeave);

            this.txtMLCFormFillupName.Tag = this.lblMLCFormFillupName;
            this.lblMLCFormFillupName.Click += new EventHandler(OnLabelClick);
            this.txtMLCFormFillupName.Enter += new EventHandler(OnControlEnter);
            this.txtMLCFormFillupName.Leave += new EventHandler(OnControlLeave);

            this.txtEventDetail.Tag = this.lblEventDetails;
            this.lblEventDetails.Click += new EventHandler(OnLabelClick);
            this.txtEventDetail.Enter += new EventHandler(OnControlEnter);
            this.txtEventDetail.Leave += new EventHandler(OnControlLeave);

            this.txtFetcherPersonName.Tag = this.lblFetcherPersonName;
            this.lblFetcherPersonName.Click += new EventHandler(OnLabelClick);
            this.txtFetcherPersonName.Enter += new EventHandler(OnControlEnter);
            this.txtFetcherPersonName.Leave += new EventHandler(OnControlLeave);

            this.txtFetcherPersonFullAddress.Tag = this.lblFetcherPersonFullAddress;
            this.lblFetcherPersonFullAddress.Click += new EventHandler(OnLabelClick);
            this.txtFetcherPersonFullAddress.Enter += new EventHandler(OnControlEnter);
            this.txtFetcherPersonFullAddress.Leave += new EventHandler(OnControlLeave);

            this.txtInformerStaffPerson.Tag = this.lblInformStaffPerson;
            this.lblInformStaffPerson.Click += new EventHandler(OnLabelClick);
            this.txtInformerStaffPerson.Enter += new EventHandler(OnControlEnter);
            this.txtInformerStaffPerson.Leave += new EventHandler(OnControlLeave);

            this.cmbInformTime.Tag = this.lblInformTime;
            this.lblInformTime.Click += new EventHandler(OnLabelClick);
            this.cmbInformTime.Enter += new EventHandler(OnControlEnter);
            this.cmbInformTime.Leave += new EventHandler(OnControlLeave);

            this.txtRelatedPoliceStation.Tag = this.lblRelatedPoliceStation;
            this.lblRelatedPoliceStation.Click += new EventHandler(OnLabelClick);
            this.txtRelatedPoliceStation.Enter += new EventHandler(OnControlEnter);
            this.txtRelatedPoliceStation.Leave += new EventHandler(OnControlLeave);

            this.txtRelatedPoliceOfficer.Tag = this.lblRelatedPoliceOfficer;
            this.lblRelatedPoliceOfficer.Click += new EventHandler(OnLabelClick);
            this.txtRelatedPoliceOfficer.Enter += new EventHandler(OnControlEnter);
            this.txtRelatedPoliceOfficer.Leave += new EventHandler(OnControlLeave);

            #endregion
            /*--------------------third tab page------------------------------------------------------------------*/

            /*--------------------FOURTH tab page------------------------------------------------------------------*/

            #region fourth tab page

            this.dtpDischargDate.Tag = this.lblDischargeDate;
            this.lblDischargeDate.Click += new EventHandler(OnLabelClick);
            this.dtpDischargDate.Enter += new EventHandler(OnControlEnter);
            this.dtpDischargDate.Leave += new EventHandler(OnControlLeave);

            this.cmbDischargeTime.Tag = this.lblDischargeTime;
            this.lblDischargeTime.Click += new EventHandler(OnLabelClick);
            this.cmbDischargeTime.Enter += new EventHandler(OnControlEnter);
            this.cmbDischargeTime.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeBy.Tag = this.lblDischargeBy;
            this.lblDischargeBy.Click += new EventHandler(OnLabelClick);
            this.txtDischargeBy.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeBy.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeStaffReception.Tag = this.lblDischargeStaffReception;
            this.lblDischargeStaffReception.Click += new EventHandler(OnLabelClick);
            this.txtDischargeStaffReception.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeStaffReception.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeStaffReceptionMO.Tag = this.lblDischargeStaffReceptionMO;
            this.lblDischargeStaffReceptionMO.Click += new EventHandler(OnLabelClick);
            this.txtDischargeStaffReceptionMO.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeStaffReceptionMO.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeTemprature.Tag = this.lblDischargeTimeTemprature;
            this.lblDischargeTimeTemprature.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeTemprature.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeTemprature.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeSPO2.Tag = this.lblDischargeTimeSPO2;
            this.lblDischargeTimeSPO2.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeSPO2.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeSPO2.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeRBS.Tag = this.lblDischargeTimeRBS;
            this.lblDischargeTimeRBS.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeRBS.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeRBS.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeRR.Tag = this.lblDischargeTimeRR;
            this.lblDischargeTimeRR.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeRR.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeRR.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimePulse.Tag = this.lblDischargeTimePulse;
            this.lblDischargeTimePulse.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimePulse.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimePulse.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeBP.Tag = this.lblDischargeTimeBP;
            this.lblDischargeTimeBP.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeBP.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeBP.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeECG.Tag = this.lblDischargeTimeECG;
            this.lblDischargeTimeECG.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeECG.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeECG.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeHR.Tag = this.lblDischargeTimeHR;
            this.lblDischargeTimeHR.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeHR.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeHR.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeWeight.Tag = this.lblDischargeTimeWeight;
            this.lblDischargeTimeWeight.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeWeight.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeWeight.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeHeight.Tag = this.lblDischargeTimeHeight;
            this.lblDischargeTimeHeight.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeHeight.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeHeight.Leave += new EventHandler(OnControlLeave);

            this.txtDischargeTimeOther.Tag = this.lblDischargeTimeOther;
            this.lblDischargeTimeOther.Click += new EventHandler(OnLabelClick);
            this.txtDischargeTimeOther.Enter += new EventHandler(OnControlEnter);
            this.txtDischargeTimeOther.Leave += new EventHandler(OnControlLeave);

            this.txtFinalDiagnosis.Tag = this.lblFinalDiagnosis;
            this.lblFinalDiagnosis.Click += new EventHandler(OnLabelClick);
            this.txtFinalDiagnosis.Enter += new EventHandler(OnControlEnter);
            this.txtFinalDiagnosis.Leave += new EventHandler(OnControlLeave);

            this.txtHistoryClinicalExamination.Tag = this.lblHistoryClinicalExamination;
            this.lblHistoryClinicalExamination.Click += new EventHandler(OnLabelClick);
            this.txtHistoryClinicalExamination.Enter += new EventHandler(OnControlEnter);
            this.txtHistoryClinicalExamination.Leave += new EventHandler(OnControlLeave);

            this.txtOperativeNote.Tag = this.lblOperativeNote;
            this.lblOperativeNote.Click += new EventHandler(OnLabelClick);
            this.txtOperativeNote.Enter += new EventHandler(OnControlEnter);
            this.txtOperativeNote.Leave += new EventHandler(OnControlLeave);

            this.txtInvestigation.Tag = this.lblInvestigation;
            this.lblInvestigation.Click += new EventHandler(OnLabelClick);
            this.txtInvestigation.Enter += new EventHandler(OnControlEnter);
            this.txtInvestigation.Leave += new EventHandler(OnControlLeave);

            this.txtTreatmentOnDischarge.Tag = this.lblTreatmentOnDischarge;
            this.lblTreatmentOnDischarge.Click += new EventHandler(OnLabelClick);
            this.txtTreatmentOnDischarge.Enter += new EventHandler(OnControlEnter);
            this.txtTreatmentOnDischarge.Leave += new EventHandler(OnControlLeave);

            this.txtAdvice.Tag = this.lblAdvice;
            this.lblAdvice.Click += new EventHandler(OnLabelClick);
            this.txtAdvice.Enter += new EventHandler(OnControlEnter);
            this.txtAdvice.Leave += new EventHandler(OnControlLeave);

            this.dptInvoiceDate.Tag = this.lblInvoiceDate;
            this.lblInvoiceDate.Click += new EventHandler(OnLabelClick);
            this.dptInvoiceDate.Enter += new EventHandler(OnControlEnter);
            this.dptInvoiceDate.Leave += new EventHandler(OnControlLeave);

            this.txtStatus.Tag = this.lblStatus;
            this.lblStatus.Click += new EventHandler(OnLabelClick);
            this.txtStatus.Enter += new EventHandler(OnControlEnter);
            this.txtStatus.Leave += new EventHandler(OnControlLeave);

            this.txtMedicalOfficer.Tag = this.lblMedicalOfficer;
            this.lblMedicalOfficer.Click += new EventHandler(OnLabelClick);
            this.txtMedicalOfficer.Enter += new EventHandler(OnControlEnter);
            this.txtMedicalOfficer.Leave += new EventHandler(OnControlLeave);

            this.dtpMedicalOfficerDate.Tag = this.lblMedicalOfficerDate;
            this.lblMedicalOfficerDate.Click += new EventHandler(OnLabelClick);
            this.dtpMedicalOfficerDate.Enter += new EventHandler(OnControlEnter);
            this.dtpMedicalOfficerDate.Leave += new EventHandler(OnControlLeave);

            this.cmbMedicalOfficerTime.Tag = this.lblMedicalOfficerTime;
            this.lblMedicalOfficerTime.Click += new EventHandler(OnLabelClick);
            this.cmbMedicalOfficerTime.Enter += new EventHandler(OnControlEnter);
            this.cmbMedicalOfficerTime.Leave += new EventHandler(OnControlLeave);

            this.txtIndoorNo.Tag = this.lblIndoorNo;
            this.lblIndoorNo.Click += new EventHandler(OnLabelClick);
            this.txtIndoorNo.Enter += new EventHandler(OnControlEnter);
            this.txtIndoorNo.Leave += new EventHandler(OnControlLeave);

            this.txtBillNo.Tag = this.lblBillNo;
            this.lblBillNo.Click += new EventHandler(OnLabelClick);
            this.txtBillNo.Enter += new EventHandler(OnControlEnter);
            this.txtBillNo.Leave += new EventHandler(OnControlLeave);

            #endregion
            /*--------------------FOURTH tab page------------------------------------------------------------------*/
        }
        #endregion

        #region OnDataSet

        protected override void OnDataSet()
        {
            base.OnDataSet();
            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.mEntry.IsIPD = true;
                this.mEntry.IsOPD = IsOPD;

                #region first tab page

                this.mEntry.FirstName = txtFirstName.Text.Trim();
                this.mEntry.MiddleName = txtMiddleName.Text.Trim();
                this.mEntry.LastName = txtLastName.Text.Trim();
                this.mEntry.Gender = (Gender)this.cmbGender.SelectedItem;
                this.mEntry.Age = (int)(nupAge.Value);

                if (cmbReference.SelectedItem != null)
                    this.mEntry.PatientReference = cmbReference.SelectedItem.ToString();

                this.mEntry.City = txtCity.Text;
                this.mEntry.District = txtDistrict.Text;
                this.mEntry.Taluko = txtTaluko.Text;
                this.mEntry.Address = txtAddress.Text;
                this.mEntry.PatientOccupation = txtOccupation.Text;
                this.mEntry.PatientOccupationFullAddress = txtOccupationFullAddress.Text;
                this.mEntry.OtherNo = txtPhoneNoOther.Text.Trim();
                this.mEntry.ResidenceNo = txtResidentialPhone.Text.Trim();
                this.mEntry.ContactNo = txtContactNo.Text;
                this.mEntry.PatientMaritalStatus = (MaritalStatus)this.cmbMaritalStatus.SelectedItem;
                this.mEntry.MarrageTimeyear = nupMarrgeTimeYear.Value;
                this.mEntry.Childern = (int)(nupChildren.Value);
                this.mEntry.Ward = this.cmbWards.SelectedItem as Ward;
                this.mEntry.Room = this.cmbRoomBedNo.SelectedItem as Room;
                this.mEntry.PatientDoctorIncharge = txtDoctorIncharge.Text;
                this.mEntry.ReferenceDoctor = cmbReferredDoctor.SelectedItem as ReferenceDoctor;
                this.mEntry.ReferenceDoctorShare = nupReferredDoctorShare.Value;

                if (dtpBirthDate.Checked)
                    this.mEntry.PatientBirthDate = dtpBirthDate.Value;
                else
                    this.mEntry.PatientBirthDate = DateTime.MinValue;

                this.mEntry.AdmittedDate = dtpAdmitedDate.Value;

                if (cmbAdmitedTime.SelectedItem != null)
                    this.mEntry.AdmittedTime = cmbAdmitedTime.SelectedItem.ToString();


                this.mEntry.AdmittedBy = txtAdmittedBy.Text.Trim();
                this.mEntry.PatientChiefComplaint = txtChiefComplaints.Text.Trim();

                if (cmbCamePreviously.SelectedItem != null)
                    this.mEntry.PatientCamePreviously = cmbCamePreviously.SelectedItem.ToString();


                this.mEntry.PatientProvisionalDiagnosis = txtProvisionalDiagnosis.Text.Trim();
                this.mEntry.PatientTypeOfCase = txtTypeOfCase.Text.Trim();
                this.mEntry.PatientHt = txtHT.Text.Trim();
                this.mEntry.PatientDrugAllergy = txtDrugAllergy.Text.Trim();
                this.mEntry.PatientDm = txtDM.Text.Trim();
                this.mEntry.PatientPregnency = txtPregnency.Text.Trim();
                this.mEntry.PatientIhd = txtIHD.Text.Trim();
                this.mEntry.PatientBt = txtBT.Text.Trim();
                this.mEntry.PatientMajorIllness = txtMajorIllness.Text.Trim();
                this.mEntry.PatientAdmittedTimeTemperature = txtAdmitTimeTemprature.Text.Trim();
                this.mEntry.PatientAdmittedTimeSpo2 = txtAdmitTimeSPO2.Text.Trim();
                this.mEntry.PatientAdmittedTimeRbs = txtAdmitTimeRBS.Text.Trim();
                this.mEntry.PatientAdmittedTimeWeight = txtAdmitTimeWeight.Text.Trim();
                this.mEntry.PatientAdmittedTimePulse = txtAdmitTimePulse.Text.Trim();
                this.mEntry.PatientAdmittedTimeBp = txtAdmitTimeBP.Text.Trim();
                this.mEntry.PatientAdmittedTimeEcg = txtAdmitTimeECG.Text.Trim();
                this.mEntry.PatientAdmittedTimeHeight = txtAdmitTimeHeight.Text.Trim();
                this.mEntry.PatientAdmittedTimeRr = txtAdmitTimeRR.Text.Trim();
                this.mEntry.PatientAdmittedTimeHr = txtAdmitTimeHR.Text.Trim();
                this.mEntry.PatientAdmittedTimeOther = txtAdmittimeOther.Text.Trim();
                this.mEntry.PatientSystemicExamination = txtSystemicExamination.Text.Trim();
                this.mEntry.PatientRs = txtRS.Text.Trim();
                this.mEntry.PatientPSOName = txtPSOName.Text.Trim();
                this.mEntry.PatientDivison = txtDivision.Text.Trim();


                #endregion

                #region second tab page field

                this.mEntry.PatientCvs = txtCVS.Text.Trim();
                this.mEntry.PatientMO = txtMO.Text.Trim();
                this.mEntry.PatientCNS = txtCNS.Text.Trim();
                this.mEntry.PatientPa = txtPA.Text.Trim();
                this.mEntry.PatientOther = txtOther.Text.Trim();
                this.mEntry.PatientSuggestedInvstigation = txtSuggestedInvestigation.Text.Trim();
                this.mEntry.PatientClinicalNote = txtHistoryAndClinicalNote.Text.Trim();
                this.mEntry.PatientAdmittedTimeTreatment = txtTreatment.Text.Trim();
                this.mEntry.PatientReceivingStaff = txtReceivingStaffReception.Text.Trim();
                this.mEntry.ReceivingStaffReceptionMO = txtReceivingStaffMO.Text.Trim();
                this.mEntry.PatientSenderName = txtSenderPersonName.Text.Trim();
                this.mEntry.PatientSigningPersonName = txtSigningPersonName.Text.Trim();
                this.mEntry.PatientRelationshipWith = txtRelationShipWithPatient.Text.Trim();

                if (dtpOperationDate.Checked)
                    this.mEntry.PatientOperationDate = dtpOperationDate.Value;
                else
                    this.mEntry.PatientOperationDate = DateTime.MinValue;


                this.mEntry.PatientOperationTime = txtOperationTime.Text.Trim();

                if (cmbInsurance.SelectedItem != null)
                    this.mEntry.PatientInsurance = cmbInsurance.SelectedItem.ToString();


                this.mEntry.PatientInsuranceCompany = txtInsuranceCompany.Text;
                this.mEntry.InsuranceAmount = txtAmount.Text.Trim();

                #endregion

                #region third tab page field

                this.mEntry.IsMlc = chkMLC.Checked;
                this.mEntry.PatientMLCNo = txtMLCNo.Text.Trim();
                this.mEntry.PatientEntryNo = txtEntryNo.Text.Trim();
                this.mEntry.PatientMarkOfIdentity = txtMarkOfIdentity.Text;
                this.mEntry.MlcFormFillUpName = txtMLCFormFillupName.Text.Trim();
                this.mEntry.PatientEventDetail = txtEventDetail.Text.Trim();
                this.mEntry.PatientFetcherPersonName = txtFetcherPersonName.Text.Trim();
                this.mEntry.PatientFetcherPersonFullAddress = txtFetcherPersonFullAddress.Text.Trim();
                this.mEntry.InformerStaffPerson = txtInformerStaffPerson.Text.Trim();

                if (cmbInformTime.SelectedItem != null)
                    this.mEntry.InformTime = cmbInformTime.SelectedItem.ToString();

                this.mEntry.RelatedPoliceStation = txtRelatedPoliceStation.Text.Trim();
                this.mEntry.RelatedPoliceOfficer = txtRelatedPoliceOfficer.Text.Trim();

                #endregion

                #region fourth tab page field

                this.mEntry.IsDischarge = chkDischarge.Checked;

                if (this.dtpDischargDate.Checked)
                    this.mEntry.DischargeDate = dtpDischargDate.Value;
                else
                    this.mEntry.DischargeDate = DateTime.MinValue;

                if (cmbDischargeTime.SelectedItem != null)
                    this.mEntry.DischargeTime = cmbDischargeTime.SelectedItem.ToString();


                this.mEntry.DischargeBy = txtDischargeBy.Text.Trim();
                this.mEntry.DischargeStaffReception = txtDischargeStaffReception.Text.Trim();
                this.mEntry.DischargeStaffReceptionMO = txtDischargeStaffReceptionMO.Text.Trim();

                this.mEntry.PatientConditionOnDischarge = string.Empty;
                if (chkCured.Checked)
                    this.mEntry.PatientConditionOnDischarge = chkCured.Tag + ",";
                if (chkRelieved.Checked)
                    this.mEntry.PatientConditionOnDischarge = this.mEntry.PatientConditionOnDischarge + chkRelieved.Tag + ",";
                if (chkUnRelieved.Checked)
                    this.mEntry.PatientConditionOnDischarge = this.mEntry.PatientConditionOnDischarge + chkUnRelieved.Tag + ",";
                if (chkDead.Checked)
                    this.mEntry.PatientConditionOnDischarge = this.mEntry.PatientConditionOnDischarge + chkDead.Tag + ",";

                if (!string.IsNullOrEmpty(this.mEntry.PatientConditionOnDischarge))
                    this.mEntry.PatientConditionOnDischarge = this.mEntry.PatientConditionOnDischarge.Remove(this.mEntry.PatientConditionOnDischarge.Length - 1, 1);


                this.mEntry.PatientTypeOfDischarge = string.Empty;
                if (chkTransferred.Checked)
                    this.mEntry.PatientTypeOfDischarge = chkTransferred.Tag + ",";
                if (chkAbsconded.Checked)
                    this.mEntry.PatientTypeOfDischarge = this.mEntry.PatientTypeOfDischarge + chkAbsconded.Tag + ",";
                if (chkDAMA.Checked)
                    this.mEntry.PatientTypeOfDischarge = this.mEntry.PatientTypeOfDischarge + chkDAMA.Tag + ",";
                if (chkDuetoDeath.Checked)
                    this.mEntry.PatientTypeOfDischarge = this.mEntry.PatientTypeOfDischarge + chkDuetoDeath.Tag + ",";

                if (!string.IsNullOrEmpty(this.mEntry.PatientTypeOfDischarge))
                    this.mEntry.PatientTypeOfDischarge = this.mEntry.PatientTypeOfDischarge.Remove(this.mEntry.PatientTypeOfDischarge.Length - 1, 1);

                this.mEntry.PatientDischargeTimeTemperature = txtDischargeTimeTemprature.Text.Trim();
                this.mEntry.PatientDischargeTimeSpo2 = txtDischargeTimeSPO2.Text.Trim();
                this.mEntry.PatientDischargeTimeRbs = txtDischargeTimeRBS.Text.Trim();
                this.mEntry.PatientDischargeTimeRr = txtDischargeTimeRR.Text.Trim();
                this.mEntry.PatientDischargeTimePulse = txtDischargeTimePulse.Text.Trim();
                this.mEntry.PatientDischargeTimeBp = txtDischargeTimeBP.Text.Trim();
                this.mEntry.PatientDischargeTimeEcg = txtDischargeTimeECG.Text.Trim();
                this.mEntry.PatientDischargeTimeHr = txtDischargeTimeHR.Text.Trim();
                this.mEntry.PatientDischargeTimeWeight = txtDischargeTimeWeight.Text.Trim();
                this.mEntry.PatientDischargeTimeHeight = txtDischargeTimeHeight.Text.Trim();
                this.mEntry.PatientDischargeTimeOther = txtDischargeTimeOther.Text.Trim();
                this.mEntry.PatientFinalDiagnosis = txtFinalDiagnosis.Text;
                this.mEntry.PatientDischargeTimeClinicalExamination = txtHistoryClinicalExamination.Text.Trim();
                this.mEntry.PatientDischargeTimeOperativeNote = txtOperativeNote.Text.Trim();
                this.mEntry.PatientDischargeTimeInvestigation = txtInvestigation.Text.Trim();
                this.mEntry.PatientDischargeTimeTreatment = txtTreatmentOnDischarge.Text.Trim();
                this.mEntry.PatientDischargeTimeAdvice = txtAdvice.Text.Trim();

                this.mEntry.PatientIndoorNo = txtIndoorNo.Text.Trim();
                this.mEntry.PatientBillNo = txtBillNo.Text.Trim();

                if (this.dptInvoiceDate.Checked)
                    this.mEntry.InvoiceDate = dptInvoiceDate.Value;
                else
                    this.mEntry.InvoiceDate = DateTime.MinValue;

                this.mEntry.PatientStatus = txtStatus.Text.Trim();
                this.mEntry.PatientMedicalOfficer = txtMedicalOfficer.Text.Trim();

                if (this.dtpMedicalOfficerDate.Checked)
                    this.mEntry.PatientMedicalOfficerDate = dtpMedicalOfficerDate.Value;
                else
                    this.mEntry.PatientMedicalOfficerDate = DateTime.MinValue;

                if (cmbMedicalOfficerTime.SelectedItem != null)
                    this.mEntry.PatientMedicalOfficerTime = cmbMedicalOfficerTime.SelectedItem.ToString();


                if (chkDischarge.Checked)
                {
                    if (this.mEntry.InvoiceNo <= 0)
                    {
                        this.mEntry.InvoiceNo = this.mEntry.MaxInvoiceNo > 0 == true ? this.mEntry.MaxInvoiceNo + 1 : 1;
                    }
                }

                #endregion

                //if (chkDischarge.Checked)
                //{
                //    if (this.mEntry.InvoiceNo <= 0)
                //    {
                //        this.mEntry.InvoiceNo = this.mEntry.MaxInvoiceNo > 0 == true ? this.mEntry.MaxInvoiceNo + 1 : 1;
                //    }
                //    if (dtpDischargDate.Enabled == true && dptInvoiceDate.Enabled == true)
                //    {
                //        this.mEntry.DischargeDate = dtpDischargDate.Value;
                //        this.mEntry.InvoiceDate = dptInvoiceDate.Value;
                //    }
                //    if (this.cmbDischargeTime.SelectedItem != null)
                //    {
                //        this.mEntry.DischargeTime = cmbDischargeTime.SelectedItem.ToString();
                //    }
                //    this.mEntry.DischargeBy = txtDischargeBy.Text.Trim();
                //    this.mEntry.DischargeStaffReception = txtDischargeStaffReception.Text.Trim();
                //    this.mEntry.DischargeStaffReceptionMO = txtDischargeStaffReceptionMO.Text.Trim();
                //}
                //else // discharge kari ne pa6o undischarge kare a na maate
                //{
                //    this.mEntry.InvoiceNo = 0;
                //    this.mEntry.DischargeDate = DateTime.MinValue;
                //    this.mEntry.InvoiceDate = DateTime.MinValue;
                //}

                // treatment
                //this.mEntry.IPDPatientTreatment.Clear();

                //for (int i = 0; i < lbTreatment.Items.Count; i++)
                //{
                //    if (lbTreatment.GetItemChecked(i))
                //    {
                //        obj = new IPDPatientTreatment();
                //        Guid gd = new Guid(lbTreatment.Items[i].ToString());
                //        obj.TreatmentGuid = gd;
                //        this.mEntry.IPDPatientTreatment.Add(obj);
                //    }

                //}
                //
            }
        }


        #endregion

        #region OnDatashow

        protected override void OnDataShow()
        {
            base.OnDataShow();

            Wards wards = new Wards();
            this.cmbWards.DataSource = wards;
            this.cmbWards.DisplayMember = "DisplayName";

            Rooms rooms = new Rooms();
            this.cmbRoomBedNo.DataSource = rooms;
            this.cmbRoomBedNo.DisplayMember = "DisplayName";

            ReferenceDoctors referredDoctorList = new ReferenceDoctors();
            this.cmbReferredDoctor.DataSource = referredDoctorList;
            this.cmbReferredDoctor.DisplayMember = "DisplayName";

            this.cmbGender.DataSource = Enum.GetValues(typeof(Gender));

            this.cmbMaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));

            if (!Objectbase.IsNullOrEmpty(this.mEntry))
            {
                this.CheckPermission();
                // dtpDischargDate.Enabled = false;
                //dptInvoiceDate.Enabled = false;

                #region first tab page

                txtFirstName.Select();
                IsOPD = this.mEntry.IsOPD;
                txtFirstName.Text = this.mEntry.FirstName;
                txtMiddleName.Text = this.mEntry.MiddleName;
                txtLastName.Text = this.mEntry.LastName;
                cmbGender.SelectedItem = (Gender)this.mEntry.Gender;
                nupAge.Value = this.mEntry.Age;
                cmbReference.SelectedItem = this.mEntry.PatientReference;
                txtCity.Text = this.mEntry.City;
                txtDistrict.Text = this.mEntry.District;
                txtTaluko.Text = this.mEntry.Taluko;
                txtAddress.Text = this.mEntry.Address;
                txtOccupation.Text = this.mEntry.PatientOccupation;
                txtOccupationFullAddress.Text = this.mEntry.PatientOccupationFullAddress;
                txtPhoneNoOther.Text = this.mEntry.OtherNo;
                txtResidentialPhone.Text = this.mEntry.ResidenceNo;
                txtContactNo.Text = this.mEntry.ContactNo;
                cmbMaritalStatus.SelectedItem = (MaritalStatus)this.mEntry.PatientMaritalStatus;
                nupMarrgeTimeYear.Value = this.mEntry.MarrageTimeyear;
                nupChildren.Value = this.mEntry.Childern;
                cmbWards.SelectedItem = this.mEntry.Ward as Ward;
                this.cmbRoomBedNo.SelectedItem = this.mEntry.Room as Room;
                txtDoctorIncharge.Text = this.mEntry.PatientDoctorIncharge;
                cmbReferredDoctor.SelectedItem = this.mEntry.ReferenceDoctor as ReferenceDoctor;
                if (this.mEntry.IsNew)
                {
                }
                else
                {
                    if (this.mEntry.ReferenceDoctor != null)
                    {
                        nupReferredDoctorShare.Visible = true;
                        lblReferredDoctorShare.Visible = true;
                    }
                    nupReferredDoctorShare.Value = this.mEntry.ReferenceDoctorShare;
                }
                if (!string.IsNullOrEmpty(this.mEntry.PatientBirthDate.ToString()) && this.mEntry.PatientBirthDate != DateTime.MinValue)
                {
                    dtpBirthDate.Checked = true;
                    dtpBirthDate.Value = this.mEntry.PatientBirthDate;
                }
                if (this.mEntry.IsNew)
                    dtpAdmitedDate.Value = DateTime.Now;
                else
                    dtpAdmitedDate.Value = this.mEntry.AdmittedDate == DateTime.MinValue ? DateTime.Now : this.mEntry.AdmittedDate;

                cmbAdmitedTime.SelectedItem = this.mEntry.AdmittedTime;
                txtAdmittedBy.Text = this.mEntry.AdmittedBy;
                txtChiefComplaints.Text = this.mEntry.PatientChiefComplaint;
                cmbCamePreviously.SelectedItem = this.mEntry.PatientCamePreviously;
                txtProvisionalDiagnosis.Text = this.mEntry.PatientProvisionalDiagnosis;
                txtTypeOfCase.Text = this.mEntry.PatientTypeOfCase;
                txtHT.Text = this.mEntry.PatientHt;
                txtDrugAllergy.Text = this.mEntry.PatientDrugAllergy;
                txtDM.Text = this.mEntry.PatientDm;
                txtPregnency.Text = this.mEntry.PatientPregnency;
                txtIHD.Text = this.mEntry.PatientIhd;
                txtBT.Text = this.mEntry.PatientBt;
                txtMajorIllness.Text = this.mEntry.PatientMajorIllness;
                txtAdmitTimeTemprature.Text = this.mEntry.PatientAdmittedTimeTemperature;
                txtAdmitTimeSPO2.Text = this.mEntry.PatientAdmittedTimeSpo2;
                txtAdmitTimeRBS.Text = this.mEntry.PatientAdmittedTimeRbs;
                txtAdmitTimeWeight.Text = this.mEntry.PatientAdmittedTimeWeight;
                txtAdmitTimePulse.Text = this.mEntry.PatientAdmittedTimePulse;
                txtAdmitTimeBP.Text = this.mEntry.PatientAdmittedTimeBp;
                txtAdmitTimeECG.Text = this.mEntry.PatientAdmittedTimeEcg;
                txtAdmitTimeHeight.Text = this.mEntry.PatientAdmittedTimeHeight;
                txtAdmitTimeRR.Text = this.mEntry.PatientAdmittedTimeRr;
                txtAdmitTimeHR.Text = this.mEntry.PatientAdmittedTimeHr;
                txtAdmittimeOther.Text = this.mEntry.PatientAdmittedTimeOther;
                txtSystemicExamination.Text = this.mEntry.PatientSystemicExamination;
                txtRS.Text = this.mEntry.PatientRs;
                txtPSOName.Text = this.mEntry.PatientPSOName;
                txtDivision.Text = this.mEntry.PatientDivison;

                #endregion

                #region second tab page field

                txtCVS.Text = this.mEntry.PatientCvs;
                txtMO.Text = this.mEntry.PatientMO;
                txtCNS.Text = this.mEntry.PatientCNS;
                txtPA.Text = this.mEntry.PatientPa;
                txtOther.Text = this.mEntry.PatientOther;
                txtSuggestedInvestigation.Text = this.mEntry.PatientSuggestedInvstigation;
                txtHistoryAndClinicalNote.Text = this.mEntry.PatientClinicalNote;
                txtTreatment.Text = this.mEntry.PatientAdmittedTimeTreatment;
                txtReceivingStaffReception.Text = this.mEntry.PatientReceivingStaff;
                txtReceivingStaffMO.Text = this.mEntry.ReceivingStaffReceptionMO;
                txtSenderPersonName.Text = this.mEntry.PatientSenderName;
                txtSigningPersonName.Text = this.mEntry.PatientSigningPersonName;
                txtRelationShipWithPatient.Text = this.mEntry.PatientRelationshipWith;
                if (!string.IsNullOrEmpty(this.mEntry.PatientOperationDate.ToString()) && this.mEntry.PatientOperationDate != DateTime.MinValue)
                {
                    this.dtpOperationDate.Checked = true;
                    this.dtpOperationDate.Value = this.mEntry.PatientOperationDate;
                }

                txtOperationTime.Text = this.mEntry.PatientOperationTime;
                cmbInsurance.SelectedItem = this.mEntry.PatientInsurance;
                txtInsuranceCompany.Text = this.mEntry.PatientInsuranceCompany;
                txtAmount.Text = this.mEntry.InsuranceAmount;

                #endregion

                #region third tab page field

                if (!this.mEntry.IsMlc)
                    tbpMLCDetails.Enabled = false;
                chkMLC.Checked = this.mEntry.IsMlc;
                txtMLCNo.Text = this.mEntry.PatientMLCNo;
                txtEntryNo.Text = this.mEntry.PatientEntryNo;
                txtMarkOfIdentity.Text = this.mEntry.PatientMarkOfIdentity;
                txtMLCFormFillupName.Text = this.mEntry.MlcFormFillUpName;
                txtEventDetail.Text = this.mEntry.PatientEventDetail;
                txtFetcherPersonName.Text = this.mEntry.PatientFetcherPersonName;
                txtFetcherPersonFullAddress.Text = this.mEntry.PatientFetcherPersonFullAddress;
                txtInformerStaffPerson.Text = this.mEntry.InformerStaffPerson;
                cmbInformTime.SelectedItem = this.mEntry.InformTime;
                txtRelatedPoliceStation.Text = this.mEntry.RelatedPoliceStation;
                txtRelatedPoliceOfficer.Text = this.mEntry.RelatedPoliceOfficer;

                #endregion

                #region fourth tab page field

                chkDischarge.Checked = this.mEntry.IsDischarge;
                if (!string.IsNullOrEmpty(this.mEntry.DischargeDate.ToString()) && (this.mEntry.DischargeDate != DateTime.MinValue))
                {
                    dtpDischargDate.Checked = true;
                    dtpDischargDate.Value = this.mEntry.DischargeDate;
                }
                cmbDischargeTime.SelectedItem = this.mEntry.DischargeTime;
                txtDischargeBy.Text = this.mEntry.DischargeBy;
                txtDischargeStaffReception.Text = this.mEntry.DischargeStaffReception;
                txtDischargeStaffReceptionMO.Text = this.mEntry.DischargeStaffReceptionMO;

                if (!string.IsNullOrEmpty(this.mEntry.PatientConditionOnDischarge))
                {
                    string[] dischargeCondition = this.mEntry.PatientConditionOnDischarge.Split(',');
                    if (dischargeCondition.Length > 0)
                    {
                        for (int i = 0; i < dischargeCondition.Length; i++)
                        {
                            if (dischargeCondition[i] == "Cured")
                                chkCured.Checked = true;
                            else if (dischargeCondition[i] == "Relieved")
                                chkRelieved.Checked = true;
                            else if (dischargeCondition[i] == "Un Relieved")
                                chkUnRelieved.Checked = true;
                            else if (dischargeCondition[i] == "Dead")
                                chkDead.Checked = true;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(this.mEntry.PatientTypeOfDischarge))
                {
                    string[] dischargeType = this.mEntry.PatientTypeOfDischarge.Split(',');
                    if (dischargeType.Length > 0)
                    {
                        for (int i = 0; i < dischargeType.Length; i++)
                        {
                            if (dischargeType[i] == "Transferred")
                                chkTransferred.Checked = true;
                            else if (dischargeType[i] == "Absconded")
                                chkAbsconded.Checked = true;
                            else if (dischargeType[i] == "DAMA")
                                chkDAMA.Checked = true;
                            else if (dischargeType[i] == "Due to Death")
                                chkDuetoDeath.Checked = true;
                        }
                    }
                }

                txtDischargeTimeTemprature.Text = this.mEntry.PatientDischargeTimeTemperature;
                txtDischargeTimeSPO2.Text = this.mEntry.PatientDischargeTimeSpo2;
                txtDischargeTimeRBS.Text = this.mEntry.PatientDischargeTimeRbs;
                txtDischargeTimeRR.Text = this.mEntry.PatientDischargeTimeRr;
                txtDischargeTimePulse.Text = this.mEntry.PatientDischargeTimePulse;
                txtDischargeTimeBP.Text = this.mEntry.PatientDischargeTimeBp;
                txtDischargeTimeECG.Text = this.mEntry.PatientDischargeTimeEcg;
                txtDischargeTimeHR.Text = this.mEntry.PatientDischargeTimeHr;
                txtDischargeTimeWeight.Text = this.mEntry.PatientDischargeTimeWeight;
                txtDischargeTimeHeight.Text = this.mEntry.PatientDischargeTimeHeight;
                txtDischargeTimeOther.Text = this.mEntry.PatientDischargeTimeOther;
                txtFinalDiagnosis.Text = this.mEntry.PatientFinalDiagnosis;
                txtHistoryClinicalExamination.Text = this.mEntry.PatientDischargeTimeClinicalExamination;
                txtOperativeNote.Text = this.mEntry.PatientDischargeTimeOperativeNote;
                txtInvestigation.Text = this.mEntry.PatientDischargeTimeInvestigation;
                txtTreatmentOnDischarge.Text = this.mEntry.PatientDischargeTimeTreatment;
                txtAdvice.Text = this.mEntry.PatientDischargeTimeAdvice;

                txtIndoorNo.Text = this.mEntry.PatientIndoorNo;
                txtBillNo.Text = this.mEntry.PatientBillNo;

                if (!string.IsNullOrEmpty(this.mEntry.InvoiceDate.ToString()) && this.mEntry.InvoiceDate != DateTime.MinValue)
                {
                    dptInvoiceDate.Value = this.mEntry.InvoiceDate;
                    dptInvoiceDate.Checked = true;
                }

                txtStatus.Text = this.mEntry.PatientStatus;
                txtMedicalOfficer.Text = this.mEntry.PatientMedicalOfficer;

                if (!string.IsNullOrEmpty(this.mEntry.PatientMedicalOfficerDate.ToString()) && this.mEntry.PatientMedicalOfficerDate != DateTime.MinValue)
                {
                    dtpMedicalOfficerDate.Value = this.mEntry.PatientMedicalOfficerDate;
                    dtpMedicalOfficerDate.Checked = true;
                }

                cmbMedicalOfficerTime.SelectedItem = this.mEntry.PatientMedicalOfficerTime;

                #endregion


                //if (this.mEntry.IsNew)
                //{
                //    this.dtpAdmitedDate.Value = DateTime.Now;
                //    chkDischarge.Visible = dtpDischargDate.Visible = dptInvoiceDate.Visible = cmbDischargeTime.Visible = txtDischargeBy.Visible = txtDischargeStaffReception.Visible =
                //       txtDischargeStaffReceptionMO.Visible = lblDischargeDate.Visible = lblInvoiceDate.Visible = lblDischargeTime.Visible = lblDischargeBy.Visible =
                //       lblDischargeStaffReception.Visible = lblDischargeStaffReceptionMO.Visible = false;
                //    chkDischarge.Enabled = false;
                //}
                //else
                //{
                //    if (!string.IsNullOrEmpty(this.mEntry.AdmittedDate.ToString()) && (this.mEntry.DischargeDate != DateTime.MinValue))
                //        this.dtpAdmitedDate.Value = this.mEntry.AdmittedDate;
                //    if (!string.IsNullOrEmpty(this.mEntry.DischargeDate.ToString()) && (this.mEntry.DischargeDate != DateTime.MinValue))
                //    {
                //        this.dtpDischargDate.Value = this.mEntry.DischargeDate;
                //    }
                //    if (!string.IsNullOrEmpty(this.mEntry.InvoiceDate.ToString()) && (this.mEntry.InvoiceDate != DateTime.MinValue))
                //    {
                //        this.dptInvoiceDate.Value = this.mEntry.InvoiceDate;
                //    }
                //    if (this.mEntry.ReferenceDoctor != null)
                //    {
                //        nupReferredDoctorShare.Visible = true;
                //        this.lblReferredDoctorShare.Visible = true;
                //    }
                //    if (!this.mEntry.IsDischarge)
                //    {
                //        dtpDischargDate.Visible = dptInvoiceDate.Visible = cmbDischargeTime.Visible = txtDischargeBy.Visible = txtDischargeStaffReception.Visible =
                //       txtDischargeStaffReceptionMO.Visible = lblDischargeDate.Visible = lblInvoiceDate.Visible = lblDischargeTime.Visible = lblDischargeBy.Visible =
                //       lblDischargeStaffReception.Visible = lblDischargeStaffReceptionMO.Visible = false;
                //    }
                //    nupReferredDoctorShare.Value = this.mEntry.ReferenceDoctorShare;
                //    this.cmbRoomBedNo.SelectedItem = this.mEntry.Room as Room;
                //}

            }
        }

        #endregion

        #region checkPermission

        private void CheckPermission()
        {
            if (!AppContext.IsMainUser)
            {
                EntityCollection ent = AppContext.UserRoleEntities;
                foreach (Entity e in ent)
                {
                    if (e.DisplayName == "Patient Details")
                    {
                        if (!this.mEntry.IsNew)
                        {
                            this.btnDelete.Visible = AppContext.CanDelete(e.ObjectGuid);
                            this.btnSave.Visible = AppContext.CanEdit(e.ObjectGuid);
                        }
                    }
                }
            }
            else
            {
                if (!this.mEntry.IsNew)
                    this.btnDelete.Visible = true;
            }
        }

        #endregion

        #region OnDataValidation
        protected override bool OnDataValidation()
        {
            bool r = true;

            if (this.txtFirstName.Text.Trim().Length <= 0)
            {
                this.ShowTooltip(this.txtFirstName, "First Name", "First Name is Required!", ContentAlignment.TopLeft);
                if (r)
                    this.txtFirstName.Select();
                r = false;
            }


            if (this.cmbGender.SelectedItem == null)
            {
                this.ShowTooltip(this.cmbGender, "Gender", "Gender is required!", ContentAlignment.TopRight);
                if (r)
                    this.cmbGender.Select();
                r = false;
            }


            return r && base.OnDataValidation();
        }
        #endregion

        #region showform

        public static bool ShowForm(Patient obj)
        {
            bool r = false;
            if (!Objectbase.IsNullOrEmpty(obj))
            {
                using (PatientForm frm = new PatientForm(obj))
                {
                    r = frm.ShowDialog() == DialogResult.OK;
                }
            }
            return r;
        }

        #endregion

        private void chkDischarge_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkDischarge.Checked)
            //{
            //    dtpDischargDate.Enabled = dptInvoiceDate.Enabled = true;
            //    this.dtpDischargDate.Visible = this.dptInvoiceDate.Visible = txtDischargeBy.Visible = cmbDischargeTime.Visible = txtDischargeStaffReception.Visible =
            //        txtDischargeStaffReceptionMO.Visible = this.lblDischargeDate.Visible = this.lblInvoiceDate.Visible = lblDischargeBy.Visible = lblDischargeTime.Visible =
            //        lblDischargeStaffReception.Visible = lblDischargeStaffReceptionMO.Visible = true;
            //}
            //else
            //{
            //    dtpDischargDate.Enabled = dptInvoiceDate.Enabled = false;
            //    this.dtpDischargDate.Visible = this.dptInvoiceDate.Visible = txtDischargeBy.Visible = cmbDischargeTime.Visible = txtDischargeStaffReception.Visible =
            //        txtDischargeStaffReceptionMO.Visible = this.lblDischargeDate.Visible = this.lblInvoiceDate.Visible = lblDischargeBy.Visible = lblDischargeTime.Visible =
            //        lblDischargeStaffReception.Visible = lblDischargeStaffReceptionMO.Visible = false;
            //}
        }

        private void cmbReferredDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbReferredDoctor.SelectedItem != null)
            {
                var objReference = this.cmbReferredDoctor.SelectedItem as ReferenceDoctor;
                ReferenceDoctor obj = new ReferenceDoctor(objReference.ObjectGuid);
                this.lblReferredDoctorShare.Visible = true;
                this.nupReferredDoctorShare.Visible = true;
                if (objReference != null)
                    this.nupReferredDoctorShare.Value = obj.Share;
            }
            else
            {
                this.lblReferredDoctorShare.Visible = false;
                this.nupReferredDoctorShare.Visible = false;
                this.nupReferredDoctorShare.Value = 0;
            }
        }

        private void chkMLC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMLC.Checked)
                tbpMLCDetails.Enabled = true;
            else
                tbpMLCDetails.Enabled = false;
        }

        private void btnViewPatientDetailsReport_Click(object sender, EventArgs e)
        {
            PatientDetailReportForm p = new PatientDetailReportForm();
            p.PatientGuid = this.mEntry.ObjectGuid;
            p.Show();
        }

        private void btnIndoorCasePaperReport_Click(object sender, EventArgs e)
        {
            IndoorCaseReportForm p = new IndoorCaseReportForm();
            p.PatientGuid = this.mEntry.ObjectGuid;
            p.Show();
        }


    }
}
