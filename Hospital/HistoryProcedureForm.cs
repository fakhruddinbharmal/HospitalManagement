using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Hospital.Object;

namespace Hospital
{
    public partial class HistoryProcedureForm : Hospital.ObjectbaseForm
    {
        private HistoryProcedure mHistoryProcedure;

        private HistoryProcedureCollection mHistoryCollection;

        private HistoryProcedureCollections mHistoryCollections;
        
        private Patient mPatient;

        //Chief Complain

        private OPDChiefComplains OPDChiefComplains;

        private OPDHistoryProcedureChiefComplain obj1;
        

        // Associate Complain

        private OPDAssociateComplains OPDAssociateComplains;

        private OPDHistoryProcedureAssociateComplain obj2;
        

        // History 

        private OPDHistorys OPDHistorys;

        private OPDHistoryProcedureHistory obj3;

       //

         public HistoryProcedureForm(Patient obj)
             : base(obj,false)
        {
            this.mPatient = obj;
            this.mHistoryProcedure = new HistoryProcedure();

            this.mHistoryCollection = new HistoryProcedureCollection(this.mPatient.ObjectGuid);
            this.mHistoryCollections = new HistoryProcedureCollections(this.mHistoryProcedure.ObjectGuid);

            this.OPDChiefComplains = new OPDChiefComplains(this.mHistoryProcedure.ObjectGuid);
            this.OPDAssociateComplains = new OPDAssociateComplains(this.mHistoryProcedure.ObjectGuid);
            this.OPDHistorys = new OPDHistorys(this.mHistoryProcedure.ObjectGuid);

            this.InitializeComponent();
            this.UserInitialize();
        }

         private void UserInitialize()
         {      
             this.cmbChiefComplain.Tag = this.lblChiefComplain;
             this.lblChiefComplain.Click += new EventHandler(OnLabelClick);
             this.cmbChiefComplain.Enter += new EventHandler(OnControlEnter);
             this.cmbChiefComplain.Leave += new EventHandler(OnControlLeave);

             this.cmbAssociateComplain.Tag = this.lblAssociateComplain;
             this.lblAssociateComplain.Click += new EventHandler(OnLabelClick);
             this.cmbAssociateComplain.Enter += new EventHandler(OnControlEnter);
             this.cmbAssociateComplain.Leave += new EventHandler(OnControlLeave);

             this.cmbHistoryOfProblem.Tag = this.lblHistoryOfProblem;
             this.lblHistoryOfProblem.Click += new EventHandler(OnLabelClick);
             this.cmbHistoryOfProblem.Enter += new EventHandler(OnControlEnter);
             this.cmbHistoryOfProblem.Leave += new EventHandler(OnControlLeave);

             this.txtProblemSince.Tag = this.lblProblemSince;
             this.lblProblemSince.Click += new EventHandler(OnLabelClick);
             this.txtProblemSince.Enter += new EventHandler(OnControlEnter);
             this.txtProblemSince.Leave += new EventHandler(OnControlLeave);

             this.txtAssociateComplainDuration.Tag = this.lblAssociateComplainDuration;
             this.lblAssociateComplainDuration.Click += new EventHandler(OnLabelClick);
             this.txtAssociateComplainDuration.Enter += new EventHandler(OnControlEnter);
             this.txtAssociateComplainDuration.Leave += new EventHandler(OnControlLeave);

             this.txtFamilyHistoryDuration.Tag = this.lblFamilyHistoryDuration;
             this.lblFamilyHistoryDuration.Click += new EventHandler(OnLabelClick);
             this.txtFamilyHistoryDuration.Enter += new EventHandler(OnControlEnter);
             this.txtFamilyHistoryDuration.Leave += new EventHandler(OnControlLeave);

             this.txtFamilyHistory.Tag = this.lblFamilyHistory;
             this.lblFamilyHistory.Click += new EventHandler(OnLabelClick);
             this.txtFamilyHistory.Enter += new EventHandler(OnControlEnter);
             this.txtFamilyHistory.Leave += new EventHandler(OnControlLeave);

             this.dtpHistoryDate.Tag = this.lblDate;
             this.lblDate.Click += new EventHandler(OnLabelClick);
             this.dtpHistoryDate.Enter += new EventHandler(OnControlEnter);
             this.dtpHistoryDate.Leave += new EventHandler(OnControlLeave);

             this.btnAddNewChiefComplain.Click += new EventHandler(OnAddNewChiefComplainClick);
             this.btnAddNewAssociateComplain.Click += new EventHandler(OnAddNewAssociateComplainClick);
             this.btnAddNewHistory.Click += new EventHandler(OnAddNewHistoryClick);

             this.tsbOpen.Click += new EventHandler(this.OnOpenClick);
             this.dgvHistoryData.DoubleClick += new EventHandler(this.OnCellDoubleClick);

             this.txtBP.Tag = this.lblBP;
             this.lblBP.Click += new EventHandler(OnLabelClick);
             this.txtBP.Enter += new EventHandler(OnControlEnter);
             this.txtBP.Leave += new EventHandler(OnControlLeave);

             this.txtHR.Tag = this.lblHR;
             this.lblHR.Click += new EventHandler(OnLabelClick);
             this.txtHR.Enter += new EventHandler(OnControlEnter);
             this.txtHR.Leave += new EventHandler(OnControlLeave);

             this.txtRR.Tag = this.lblRR;
             this.lblRR.Click += new EventHandler(OnLabelClick);
             this.txtRR.Enter += new EventHandler(OnControlEnter);
             this.txtRR.Leave += new EventHandler(OnControlLeave);

             this.txtTemp.Tag = this.lblTemp;
             this.lblTemp.Click += new EventHandler(OnLabelClick);
             this.txtTemp.Enter += new EventHandler(OnControlEnter);
             this.txtTemp.Leave += new EventHandler(OnControlLeave);

             this.txtRBS.Tag = this.lblRBS;
             this.lblRBS.Click += new EventHandler(OnLabelClick);
             this.txtRBS.Enter += new EventHandler(OnControlEnter);
             this.txtRBS.Leave += new EventHandler(OnControlLeave);

             this.txtECG.Tag = this.lblECG;
             this.lblECG.Click += new EventHandler(OnLabelClick);
             this.txtECG.Enter += new EventHandler(OnControlEnter);
             this.txtECG.Leave += new EventHandler(OnControlLeave);

             this.txtWt.Tag = this.lblWt;
             this.lblWt.Click += new EventHandler(OnLabelClick);
             this.txtWt.Enter += new EventHandler(OnControlEnter);
             this.txtWt.Leave += new EventHandler(OnControlLeave);

             this.txtOther.Tag = this.lblOther;
             this.lblOther.Click += new EventHandler(OnLabelClick);
             this.txtOther.Enter += new EventHandler(OnControlEnter);
             this.txtOther.Leave += new EventHandler(OnControlLeave);

             this.txtMLC.Tag = this.lblMLCNo;
             this.lblMLCNo.Click += new EventHandler(OnLabelClick);
             this.txtMLC.Enter += new EventHandler(OnControlEnter);
             this.txtMLC.Leave += new EventHandler(OnControlLeave);

             this.dtpFollowUp.Tag = this.lblFollowUp;
             this.lblFollowUp.Click += new EventHandler(OnLabelClick);
             this.dtpFollowUp.Enter += new EventHandler(OnControlEnter);
             this.dtpFollowUp.Leave += new EventHandler(OnControlLeave);

             this.txtTimeHour.Tag = this.lblTimeHour;
             this.lblTimeHour.Click += new EventHandler(OnLabelClick);
             this.txtTimeHour.Enter += new EventHandler(OnControlEnter);
             this.txtTimeHour.Leave += new EventHandler(OnControlLeave);

             this.txtTimeMinute.Tag = this.lblTimeMinute;
             this.lblTimeMinute.Click += new EventHandler(OnLabelClick);
             this.txtTimeMinute.Enter += new EventHandler(OnControlEnter);
             this.txtTimeMinute.Leave += new EventHandler(OnControlLeave);

             this.txtTimeAMPM.Tag = this.lblTimeAMPM;
             this.lblTimeAMPM.Click += new EventHandler(OnLabelClick);
             this.txtTimeAMPM.Enter += new EventHandler(OnControlEnter);
             this.txtTimeAMPM.Leave += new EventHandler(OnControlLeave);
         }

         private void OnAddNewHistoryClick(object sender, EventArgs e)
         {
             History obj = new History(this.mHistoryProcedure);
             HistoryForm.ShowForm(obj);
             HistoryCollection historyList = new HistoryCollection();             
             this.cmbHistoryOfProblem.DataSource = historyList;
             this.cmbHistoryOfProblem.DisplayMember = "DisplayName";
         }

         private void OnAddNewAssociateComplainClick(object sender, EventArgs e)
         {
             AssociateComplain obj = new AssociateComplain(this.mHistoryProcedure);
             AssociateComplainForm.ShowForm(obj);
             AssociateComplainCollection associateComplainList = new AssociateComplainCollection();          
             this.cmbAssociateComplain.DataSource = associateComplainList;
             this.cmbAssociateComplain.DisplayMember = "DisplayName";
         }

         private void OnAddNewChiefComplainClick(object sender, EventArgs e)
         {
             ChiefComplain obj = new ChiefComplain(this.mHistoryProcedure);
             ChiefComplainForm.ShowForm(obj);
             ChiefComplainCollection chiefComplainList = new ChiefComplainCollection();             
             this.cmbChiefComplain.DataSource = chiefComplainList;
             this.cmbChiefComplain.DisplayMember = "DisplayName";
         }

         private HistoryProcedure GetSelectedProcedure(DataGridView dgv)
         {
             HistoryProcedure obj = null;
             if (dgv != null && dgv.CurrentRow != null)
                 obj = dgv.CurrentRow.Tag as HistoryProcedure;
             return obj;
         }

         #region OnDataShow
         protected override void OnDataShow()
         {
             base.OnDataShow();
             this.cmbChiefComplain.Select();
             this.Text = "History Procedure";

             ChiefComplainCollection chiefComplainList = new ChiefComplainCollection();
             this.cmbChiefComplain.DataSource = chiefComplainList;
             this.cmbChiefComplain.DisplayMember = "DisplayName";
             this.cmbChiefComplain.SelectedItem = null;
          
             
             AssociateComplainCollection associateComplainList = new AssociateComplainCollection();
             this.cmbAssociateComplain.DataSource = associateComplainList;
             this.cmbAssociateComplain.DisplayMember = "DisplayName";
             this.cmbAssociateComplain.SelectedItem = null;

             HistoryCollection historyList = new HistoryCollection();
             this.cmbHistoryOfProblem.DataSource = historyList;
             this.cmbHistoryOfProblem.DisplayMember = "DisplayName";
             this.cmbHistoryOfProblem.SelectedItem = null;

             this.txtProblemSince.Text = this.mHistoryProcedure.ProblemSince;
             this.txtAssociateComplainDuration.Text = this.mHistoryProcedure.AssociateComplainDuration;
             this.txtFamilyHistory.Text = this.mHistoryProcedure.FamilyHistory;
             this.txtFamilyHistoryDuration.Text = this.mHistoryProcedure.FamilyHistoryDuration;
             this.txtBP.Text = this.mHistoryProcedure.BP;
             this.txtHR.Text = this.mHistoryProcedure.HR;
             this.txtRR.Text = this.mHistoryProcedure.RR;
             this.txtTemp.Text = this.mHistoryProcedure.Temp;
             this.txtRBS.Text = this.mHistoryProcedure.RBS;
             this.txtECG.Text = this.mHistoryProcedure.ECG;
             this.txtWt.Text = this.mHistoryProcedure.Wt;
             this.txtOther.Text = this.mHistoryProcedure.Other;
             this.txtMLC.Text = this.mHistoryProcedure.MLCNo;
             this.txtTimeHour.Text = this.mHistoryProcedure.TimeHour;
             this.txtTimeMinute.Text = this.mHistoryProcedure.TimeMinute;
             this.txtTimeAMPM.Text = this.mHistoryProcedure.TimeAMPM;
             if (!string.IsNullOrEmpty(this.mHistoryProcedure.FollowUpDate.Date.ToString()) && (this.mHistoryProcedure.FollowUpDate != DateTime.MinValue))
             {
                 this.dtpFollowUp.Checked =true;
                 this.dtpFollowUp.Value = this.mHistoryProcedure.FollowUpDate;
             }
             if(!string.IsNullOrEmpty(this.mHistoryProcedure.Date.ToString()) && (this.mHistoryProcedure.Date != DateTime.MinValue)) 
             {
                this.dtpHistoryDate.Value = this.mHistoryProcedure.Date;
             }

             //ChiefComplain
             if (this.OPDChiefComplains.Count > 0)
             {
                 for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
                 {
                     for (int j = 0; j < this.OPDChiefComplains.Count; j++)
                     {
                         if (OPDChiefComplains[j].ChiefComplainGuid == new Guid(cmbChiefComplain.Items[i].ToString()))
                         {
                             cmbChiefComplain.SetItemChecked(i, true);
                             break;
                         }
                     }
                 }
             }

             //Associate Complain

             if (this.OPDAssociateComplains.Count > 0)
             {
                 for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                 {
                     for (int j = 0; j < this.OPDAssociateComplains.Count; j++)
                     {
                         if (OPDAssociateComplains[j].AssociateComplainGuid == new Guid(cmbAssociateComplain.Items[i].ToString()))
                         {
                             cmbAssociateComplain.SetItemChecked(i, true);
                             break;
                         }
                     }
                 }
             }
             
             //History

             if (this.OPDHistorys.Count > 0)
             {
                 for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                 {
                     for (int j = 0; j < this.OPDHistorys.Count; j++)
                     {
                         if (OPDHistorys[j].HistoryGuid == new Guid(cmbHistoryOfProblem.Items[i].ToString()))
                         {
                             cmbHistoryOfProblem.SetItemChecked(i, true);
                             break;
                         }
                     }
                 }

             }
            
             LoadHistoryProcedure(GetSelectedProcedure(this.dgvHistoryData));

         }
         #endregion
     
         #region OnDataSet
         protected override void OnDataSet()
         {
             base.OnDataSet();
             if (!Objectbase.IsNullOrEmpty(this.mHistoryProcedure))
             {
                 this.mHistoryProcedure.ProblemSince = this.txtProblemSince.Text;
                 this.mHistoryProcedure.AssociateComplainDuration = this.txtAssociateComplainDuration.Text;
                 this.mHistoryProcedure.FamilyHistory = this.txtFamilyHistory.Text;
                 this.mHistoryProcedure.FamilyHistoryDuration = this.txtFamilyHistoryDuration.Text;
                 this.mHistoryProcedure.BP = this.txtBP.Text;
                 this.mHistoryProcedure.HR = this.txtHR.Text;
                 this.mHistoryProcedure.RR = this.txtRR.Text;
                 this.mHistoryProcedure.Temp = this.txtTemp.Text;
                 this.mHistoryProcedure.RBS = this.txtRBS.Text;
                 this.mHistoryProcedure.ECG = this.txtECG.Text;
                 this.mHistoryProcedure.Wt = this.txtWt.Text;
                 this.mHistoryProcedure.Other = this.txtOther.Text;
                 this.mHistoryProcedure.MLCNo = this.txtMLC.Text;

                 if(dtpFollowUp.Checked)
                 this.mHistoryProcedure.FollowUpDate = this.dtpFollowUp.Value;

                 this.mHistoryProcedure.TimeHour = this.txtTimeHour.Text;
                 this.mHistoryProcedure.TimeMinute = this.txtTimeMinute.Text;
                 this.mHistoryProcedure.TimeAMPM = this.txtTimeAMPM.Text;
                 this.mHistoryProcedure.Date = this.dtpHistoryDate.Value;
                 //Chief Complain

                 this.mPatient.HistoryProcedure = this.mHistoryProcedure;
                 this.mHistoryProcedure.OPDChiefComplains.Clear();

                 for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
                 {
                     if (cmbChiefComplain.GetItemChecked(i))
                     {
                         obj1 = new OPDHistoryProcedureChiefComplain();
                         Guid gd = new Guid(cmbChiefComplain.Items[i].ToString());
                         obj1.PatientGuid = this.mPatient.ObjectGuid;
                         obj1.ChiefComplainGuid = gd;                        
                         this.mHistoryProcedure.OPDChiefComplains.Add(obj1);
                     }
                 }
                 // For Clear Of Cheif Complain

                 for (int i = 0; i < cmbChiefComplain.Items.Count;i++)
                 {
                     if (cmbChiefComplain.GetItemChecked(i))
                     {
                         cmbChiefComplain.SetItemChecked(i, false);
                     }
                 }

                 //Associate Complain

                 this.mHistoryProcedure.OPDAssociateComplains.Clear();

                 for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                 {
                     if (cmbAssociateComplain.GetItemChecked(i))
                     {
                         obj2 = new OPDHistoryProcedureAssociateComplain();
                         Guid gd = new Guid(cmbAssociateComplain.Items[i].ToString());
                         obj2.PatientGuid = this.mPatient.ObjectGuid;
                         obj2.AssociateComplainGuid = gd;
                         this.mHistoryProcedure.OPDAssociateComplains.Add(obj2);
                     }
                 }
                 // For clear Of Associate complain

                 for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                 {
                     if (cmbAssociateComplain.GetItemChecked(i))
                     {
                         cmbAssociateComplain.SetItemChecked(i, false);
                     }
                 }

                 //History

                 this.mHistoryProcedure.OPDHistorys.Clear();
                 for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                 {
                     if (cmbHistoryOfProblem.GetItemChecked(i))
                     {
                         obj3 = new OPDHistoryProcedureHistory();
                         Guid gd = new Guid(cmbHistoryOfProblem.Items[i].ToString());
                         obj3.PatientGuid = this.mPatient.ObjectGuid;
                         obj3.HistoryGuid = gd;
                         this.mHistoryProcedure.OPDHistorys.Add(obj3);
                     }
                 }
                 // For Clear Of History Procedure

                 for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                 {
                     if (cmbHistoryOfProblem.GetItemChecked(i))
                     {
                         cmbHistoryOfProblem.SetItemChecked(i, false);
                     }
                 }

             }
         }
         #endregion

         #region OnSaveComplete
         protected override void OnSaveComplete()
         {
             base.OnSaveComplete();
             HistoryProcedure obj = this.GetSelectedProcedure(this.dgvHistoryData);
             this.LoadHistoryProcedure(obj);

             this.cmbAssociateComplain.SelectedItem = null;
             this.cmbChiefComplain.SelectedItem=null;
             this.cmbHistoryOfProblem.SelectedItem=null;
             this.txtAssociateComplainDuration.ResetText();
             this.txtFamilyHistory.ResetText();
             this.txtFamilyHistoryDuration.ResetText();
             this.txtProblemSince.ResetText();
             this.txtBP.ResetText();
             this.txtHR.ResetText();
             this.txtRR.ResetText();
             this.txtTemp.ResetText();
             this.txtRBS.ResetText();
             this.txtECG.ResetText();
             this.txtWt.ResetText();
             this.txtOther.ResetText();
             this.txtMLC.ResetText();
             this.txtTimeHour.ResetText();
             this.txtTimeMinute.ResetText();
             this.txtTimeAMPM.ResetText();
             this.dtpFollowUp.Value = DateTime.Now;
             this.dtpHistoryDate.Value = DateTime.Now;

             this.mHistoryProcedure = new HistoryProcedure();
         }
         #endregion

         #region OnOpenClick
         private void OnOpenClick(object sender, EventArgs e)
         {
             HistoryProcedure obj = this.GetSelectedProcedure(this.dgvHistoryData);
             if (obj != null)
             {
                 obj.RefershData();
                 this.mHistoryProcedure = obj;

                 // Chief Complain Clear

                 for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
                 {
                     if (cmbChiefComplain.GetItemChecked(i))
                     {
                         cmbChiefComplain.SetItemChecked(i, false);
                     }
                 }

                 //Chief Complain
                 if (this.mHistoryProcedure.OPDChiefComplains.Count > 0)
                 {
                     for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
                     {
                         for (int j = 0; j < this.mHistoryProcedure.OPDChiefComplains.Count; j++)
                         {
                             if (mHistoryProcedure.OPDChiefComplains[j].ChiefComplainGuid == new Guid(cmbChiefComplain.Items[i].ToString()))
                             {
                                 cmbChiefComplain.SetItemChecked(i, true);
                                 break;
                             }
                         }
                     }
                 }

                 // Associate Complain Clear

                 for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                 {
                     if (cmbAssociateComplain.GetItemChecked(i))
                     {
                         cmbAssociateComplain.SetItemChecked(i, false);
                     }
                 }

                 //Associate Complain
                 if (this.mHistoryProcedure.OPDAssociateComplains.Count > 0)
                 {
                     for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
                     {
                         for (int j = 0; j < this.mHistoryProcedure.OPDAssociateComplains.Count; j++)
                         {
                             if (mHistoryProcedure.OPDAssociateComplains[j].AssociateComplainGuid == new Guid(cmbAssociateComplain.Items[i].ToString()))
                             {
                                 cmbAssociateComplain.SetItemChecked(i, true);
                                 break;
                             }
                         }
                     }
                 }

                 // History Complain Clear

                 for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                 {
                     if (cmbHistoryOfProblem.GetItemChecked(i))
                     {
                         cmbHistoryOfProblem.SetItemChecked(i, false);
                     }
                 }

                 //History Complain
                 if (this.mHistoryProcedure.OPDHistorys.Count > 0)
                 {
                     for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
                     {
                         for (int j = 0; j < this.mHistoryProcedure.OPDHistorys.Count; j++)
                         {
                             if (mHistoryProcedure.OPDHistorys[j].HistoryGuid == new Guid(cmbHistoryOfProblem.Items[i].ToString()))
                             {
                                 cmbHistoryOfProblem.SetItemChecked(i, true);
                                 break;
                             }
                         }
                     }
                 }


                 this.txtProblemSince.Text = obj.ProblemSince;
                 this.txtFamilyHistory.Text = obj.FamilyHistory;
                 this.txtFamilyHistoryDuration.Text = obj.FamilyHistoryDuration;
                 this.txtAssociateComplainDuration.Text = obj.AssociateComplainDuration;
                 this.txtBP.Text = obj.BP;
                 this.txtHR.Text = obj.HR;
                 this.txtRR.Text = obj.RR;
                 this.txtRBS.Text = obj.RBS;
                 this.txtMLC.Text = obj.MLCNo;
                 this.txtOther.Text = obj.Other;
                 this.txtTemp.Text = obj.Temp;
                 this.txtWt.Text = obj.Wt;
                 this.txtECG.Text = obj.ECG;
                 this.txtTimeHour.Text= obj.TimeHour;
                 this.txtTimeMinute.Text=obj.TimeMinute;
                 this.txtTimeAMPM.Text=obj.TimeAMPM;
                 if (!string.IsNullOrEmpty(obj.FollowUpDate.ToString()) && (obj.FollowUpDate != DateTime.MinValue))
                 {
                     this.dtpFollowUp.Checked = true;
                     this.dtpFollowUp.Value = obj.FollowUpDate;
                 }
                
                 this.dtpHistoryDate.Value = obj.Date;
             }
         }
         #endregion

         #region OnDeleteClick
         protected override void OnDeleteClick()
         {
             HistoryProcedure obj = this.GetSelectedProcedure(this.dgvHistoryData);
             if (obj != null)
             {
                 this.mHistoryProcedure = obj;
                 this.mHistoryProcedure.MarkToDelete();
                 this.mHistoryProcedure.UpdateChanges();
             }
             // Chief Complain Clear

             for (int i = 0; i < cmbChiefComplain.Items.Count; i++)
             {
                 if (cmbChiefComplain.GetItemChecked(i))
                 {
                     cmbChiefComplain.SetItemChecked(i, false);
                 }
             }

             // Associate Complain Clear

             for (int i = 0; i < cmbAssociateComplain.Items.Count; i++)
             {
                 if (cmbAssociateComplain.GetItemChecked(i))
                 {
                     cmbAssociateComplain.SetItemChecked(i, false);
                 }
             }

             // History Complain Clear

             for (int i = 0; i < cmbHistoryOfProblem.Items.Count; i++)
             {
                 if (cmbHistoryOfProblem.GetItemChecked(i))
                 {
                     cmbHistoryOfProblem.SetItemChecked(i, false);
                 }
             }

             this.txtAssociateComplainDuration.ResetText();
             this.txtFamilyHistory.ResetText();
             this.txtFamilyHistoryDuration.ResetText();
             this.txtProblemSince.ResetText();
             this.dtpHistoryDate.Value = DateTime.Now;
             this.txtBP.ResetText();
             this.txtHR.ResetText();
             this.txtRR.ResetText();
             this.txtTemp.ResetText();
             this.txtRBS.ResetText();
             this.txtECG.ResetText();
             this.txtWt.ResetText();
             this.txtOther.ResetText();
             this.txtMLC.ResetText();
             this.txtTimeHour.ResetText();
             this.txtTimeMinute.ResetText();
             this.txtTimeAMPM.ResetText();
             this.dtpFollowUp.Value = DateTime.Now;
             LoadHistoryProcedure(GetSelectedProcedure(this.dgvHistoryData));

             this.mHistoryProcedure = new HistoryProcedure();
             this.cmbAssociateComplain.SelectedItem = null;
             this.cmbChiefComplain.SelectedItem = null;
             this.cmbHistoryOfProblem.SelectedItem = null;

         }
         #endregion

         #region OnCellDoubleClick
         private void OnCellDoubleClick(object sender, EventArgs e)
         {
             this.tsbOpen.PerformClick();
             //this.cmbAssociateComplain.SelectedItem = null;
             //this.cmbChiefComplain.SelectedItem = null;
             //this.cmbHistoryOfProblem.SelectedItem = null;
         }
         #endregion

         #region OnDataValidation
         protected override bool OnDataValidation()
         {
             bool r = true;
             //if (Objectbase.IsNullOrEmpty(this.cmbChiefComplain.SelectedItem as ChiefComplain))
             //{
             //    this.ShowTooltip(this.cmbChiefComplain, "ChiefComplain", "ChiefComplain is required", ContentAlignment.TopLeft);
             //    if (r)
             //        this.cmbChiefComplain.Select();
             //    r = false;
             //}
             //if (Objectbase.IsNullOrEmpty(this.cmbAssociateComplain.SelectedItem as AssociateComplain))
             //{
             //    this.ShowTooltip(this.cmbAssociateComplain, "AssociateComplain", "AssociateComplain is required", ContentAlignment.TopRight);
             //    if (r)
             //        this.cmbAssociateComplain.Select();
             //    r = false;
             //}
             //if (Objectbase.IsNullOrEmpty(this.cmbHistoryOfProblem.SelectedItem as History))
             //{
             //    this.ShowTooltip(this.cmbHistoryOfProblem, "History", "History is required", ContentAlignment.TopRight);
             //    if (r)
             //        this.cmbHistoryOfProblem.Select();
             //    r = false;
             //}
            
             return base.OnDataValidation() && r;
         }
        #endregion

         #region LoadHistoryProcedure
         private void LoadHistoryProcedure(HistoryProcedure selected)
         {
             int count = 0;
             this.LoadEntityList<HistoryProcedure>(this.dgvHistoryData, this.clmId.Index, new HistoryProcedureCollection(this.mPatient.ObjectGuid), selected, true, true,
                                                     delegate(DataGridViewRow row, HistoryProcedure obj)
                                                     {
                                                         count++;
                                                         row.Cells[this.clmId.Index].Value = obj.Id;
                                                         row.Cells[this.clmGuid.Index].Value = obj.ObjectGuid;
                                                         row.Cells[this.clmChiefComplain.Index].Value = obj.ChiefComplain;
                                                         row.Cells[this.clmProblemSince.Index].Value = obj.ProblemSince;
                                                         row.Cells[this.clmAssociateComplain.Index].Value = obj.AssociateComplain;
                                                         row.Cells[this.clmAssociateComplainDuration.Index].Value = obj.AssociateComplainDuration;
                                                         row.Cells[this.clmHistoryOfProblem.Index].Value = obj.History;
                                                         row.Cells[this.clmFamilyHistory.Index].Value = obj.FamilyHistory;
                                                         row.Cells[this.clmFamilyHistoryDuration.Index].Value = obj.FamilyHistoryDuration;
                                                         row.Cells[this.clmDate.Index].Value = obj.Date.ToString() != string.Empty ? string.Format("{0:dd/MM/yyyy}",obj.Date) : string.Empty;
                                                     }
              );
                
         }
        #endregion

         #region ShowForm
         public static bool ShowForm(Patient obj)
         {
             bool r = false;
             if (!Objectbase.IsNullOrEmpty(obj))
             {
                 using (HistoryProcedureForm frm = new HistoryProcedureForm(obj))
                 {
                     r = frm.ShowDialog() == DialogResult.OK;
                 }
             }
             return r;
         }
        #endregion



        

         private void dgvHistoryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex].GetType() == typeof(DataGridViewImageColumn))
             {
                 int rowIndex = e.RowIndex;
                 DataGridViewRow row = dgvHistoryData.Rows[rowIndex];                 
                 OPDPriscription obj = new OPDPriscription();
                 obj.HistoryProcedureGuid = (Guid)(row.Cells[9].Value);
                 obj.Show();
             }
         }

         private void dtpHistoryDate_ValueChanged(object sender, EventArgs e)
         {

         }


    }
}
