// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeeLeaveApplicationControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeLeaveApplicationID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public HREmployeeLeaveApplicationEntity _HREmployeeLeaveApplicationEntity
        {
            get
            {
                HREmployeeLeaveApplicationEntity entity = new HREmployeeLeaveApplicationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeLeaveApplicationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeLeaveApplicationEntity CurrentHREmployeeLeaveApplicationEntity
        {
            get
            {
                if (_EmployeeLeaveApplicationID > 0)
                {
                    if (_HREmployeeLeaveApplicationEntity.EmployeeLeaveApplicationID != _EmployeeLeaveApplicationID)
                    {
                        _HREmployeeLeaveApplicationEntity = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetByID(_EmployeeLeaveApplicationID);
                    }
                }

                return _HREmployeeLeaveApplicationEntity;
            }
            set
            {
                _HREmployeeLeaveApplicationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHREmployee(ddlBackupEmployeeID, true);
            MiscUtil.PopulateMDLeaveApplicationApplicationStatus(ddlLeaveApplicationApplicationStatusID, false);

            if (ddlLeaveApplicationApplicationStatusID != null && ddlLeaveApplicationApplicationStatusID.Items.Count > 0)
            {
                ddlLeaveApplicationApplicationStatusID.SelectedValue = MasterDataConstants.MDLeaveApplicatoinStatus.PENDING.ToString();
            }

            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false, MasterDataConstants.APPanelStartWith.HRLEAVE);
        }

        private void PrepareValidator()
        {

        }

        private Boolean ValidationInput()
        {

            Boolean flag = true;

            #region Check Balance 

            Decimal? totalLeaveEarned = GetToalLeaveEarned();
            Decimal? totalLeaveEnjoyed = GetToalLeaveEnjoyed()+Decimal.Parse(txtTotalLeaveDays.Text);

            if (totalLeaveEarned > 0 && totalLeaveEarned <= totalLeaveEnjoyed)
            {
                //MiscUtil.ShowMessage(lblMessage, "Sorry you do not have sufficient balance to take a leave please ask your HOD for extra leave.", true);
                this.messageDetails.Text = "Sorry you do not have sufficient balance to take a leave please ask your HOD for extra leave.";
                this.MPE.Show();
                flag = false;
            }

            #endregion

            String fe = "SessionStartDate<= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and  SessionEndDate>='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "'";
            IList<MDSalarySessionEntity> lstMDSalarySession = FCCMDSalarySession.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lstMDSalarySession != null && lstMDSalarySession.Count > 0)
            {
                ViewState["SalarySessionID"] = lstMDSalarySession[0].SalarySessionID;
            }
            else
            {
                //MiscUtil.ShowMessage(lblMessage, "Sorry your Request start and end date is not under any session please choose.", true);
                this.messageDetails.Text = "Sorry your Request Start or End Date did not match with our month. May be they are under two different month. So please check the date.";
                this.MPE.Show();
                flag = false;
            }

            if (flag)
            {
                String fe_alreadyRequested1 = "(RequestStartDate >= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and  RequestEndDate <='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "' OR RequestEndDate >= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and RequestStartDate <='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "')";
                String fe_alreadyRequested2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
                String fe_alreadyRequested = SqlExpressionBuilder.PrepareFilterExpression(fe_alreadyRequested1, SQLJoinType.AND, fe_alreadyRequested2);
                IList<HREmployeeLeaveApplicationEntity> lstHREmployeeLeaveApplication = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetIL(null, null, String.Empty, fe_alreadyRequested, DatabaseOperationType.LoadWithFilterExpression);

                if (lstHREmployeeLeaveApplication != null && lstHREmployeeLeaveApplication.Count > 0)
                {
                    //MiscUtil.ShowMessage(lblMessage, "Sorry You already have leave in this session please take carefully", true);
                    this.messageDetails.Text = "Sorry You already have leave in this date. Please Check.";
                    this.MPE.Show();
                    flag = false;
                }
            }
            
            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtApplicationDate.Text = DateTime.Now.Date.ToString();
            txtRequestStartDate.Text = String.Empty;
            txtRequestEndDate.Text = String.Empty;
            txtTotalLeaveDays.Text = String.Empty;
            //txtDescription.Text = String.Empty;
            //txtLeaveLocation.Text = String.Empty;

            HasPendingLeave();
            HavingLeave();
            CheckBalance();
            //HasLeaveExist

            //btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private Decimal? GetToalLeaveEnjoyed()
        {
            Decimal? totalLeaveEnjoyed = 0;
            String filterEmployeeID = "" + OverviewEmployeeID + "";
            IList<HREmployeeLeaveStatus_DetailedEntity> statusList = FCCHREmployeeLeaveStatus_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, filterEmployeeID);

            if (statusList != null && statusList.Count > 0)
            {
                if (statusList[0].EarnLeaveEnjoyed == null)
                {
                    statusList[0].EarnLeaveEnjoyed = 0;
                }
                if (statusList[0].CasualLeaveEnjoyed == null)
                {
                    statusList[0].CasualLeaveEnjoyed = 0;
                }
                if (statusList[0].MedicalLeaveEnjoyed == null)
                {
                    statusList[0].MedicalLeaveEnjoyed = 0;
                }
                if (statusList[0].LWPLeaveEnjoyed == null)
                {
                    statusList[0].LWPLeaveEnjoyed = 0;
                }
                totalLeaveEnjoyed = statusList[0].EarnLeaveEnjoyed + statusList[0].CasualLeaveEnjoyed + statusList[0].MedicalLeaveEnjoyed + statusList[0].LWPLeaveEnjoyed;
            }

            return totalLeaveEnjoyed;
        }


        private Decimal? GetToalLeaveEarned()
        {
            Int64 fiscalYearID = MiscUtil.GetActiveFiscalYear();
            Decimal? totalLeaveEarned = 0;

            String fe = "EmployeeID = " + OverviewEmployeeID + " and FiscalYearID = " + fiscalYearID + "";


            IList<HRMemberLeaveAccountEntity> list = FCCHRMemberLeaveAccount.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (list != null && list.Count > 0)
            {
                totalLeaveEarned = list.AsEnumerable().Sum(x => x.EarnedDays);
            }

            return totalLeaveEarned;
        }

        private void CheckBalance()
        {
            
            Decimal? totalLeaveEarned = GetToalLeaveEarned();
            Decimal? totalLeaveEnjoyed = GetToalLeaveEnjoyed();

            if (totalLeaveEarned > 0 && totalLeaveEarned <= totalLeaveEnjoyed)
            {
                btnSubmit.Enabled = false;
                lblPending.Text = "<font color='red'>Sorry You don't have Balance So you cannot take any leave. Please talk to your HOD or HR</font>";
                this.messageDetails.Text = lblPending.Text;
                this.MPE.Show();
            }
        }

        private void HasPendingLeave()
        {
            String fe = "EmployeeID = " + OverviewEmployeeID + " and LeaveApplicationApplicationStatusID = "+MasterDataConstants.MDLeaveApplicatoinStatus.PENDING+"";
            IList<HREmployeeLeaveApplicationEntity> leaveList = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            if (leaveList != null && leaveList.Count > 0)
            {
                btnSubmit.Enabled = false;
                lblPending.Text = "Sorry You Have Submitted one application which is under process. You can not submit another application until it is approved or reject.";
                this.messageDetails.Text = lblPending.Text;
                this.MPE.Show();
            }

        }

        private void HavingLeave()
        {
            String fe_alreadyRequested1 = "(RequestStartDate >= '" + DateTime.Now + "' and  RequestEndDate <='" + DateTime.Now + "' OR RequestEndDate >= '" + DateTime.Now + "' and RequestStartDate <='" + DateTime.Now + "')";
            
            String fe_alreadyRequested2 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            String fe_alreadyRequested = SqlExpressionBuilder.PrepareFilterExpression(fe_alreadyRequested1, SQLJoinType.AND, fe_alreadyRequested2);
            IList<HREmployeeLeaveApplicationEntity> lstHREmployeeLeaveApplication = FCCHREmployeeLeaveApplication.GetFacadeCreate().GetIL(null, null, String.Empty, fe_alreadyRequested, DatabaseOperationType.LoadWithFilterExpression);

            if (lstHREmployeeLeaveApplication != null && lstHREmployeeLeaveApplication.Count > 0)
            {
                btnSubmit.Enabled = false;
                lblPending.Text = "<font color='green'>You are having leave</font>";
                this.messageDetails.Text = lblPending.Text;
                this.MPE.Show();
            }
        }

        private void PrepareEditView()
        {
            HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = CurrentHREmployeeLeaveApplicationEntity;
            

            if (!hREmployeeLeaveApplicationEntity.IsNew)
            {
                
                txtApplicationDate.Text = hREmployeeLeaveApplicationEntity.ApplicationDate.ToStringDefault();
                txtRequestStartDate.Text = hREmployeeLeaveApplicationEntity.RequestStartDate.ToStringDefault();
                txtRequestEndDate.Text = hREmployeeLeaveApplicationEntity.RequestEndDate.ToStringDefault();
                txtTotalLeaveDays.Text = hREmployeeLeaveApplicationEntity.TotalLeaveDays.ToString();
                
                if (ddlBackupEmployeeID.Items.Count > 0 && hREmployeeLeaveApplicationEntity.BackupEmployeeID != null)
                {
                    ddlBackupEmployeeID.SelectedValue = hREmployeeLeaveApplicationEntity.BackupEmployeeID.ToString();
                }

                if (ddlLeaveApplicationApplicationStatusID.Items.Count > 0 && hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID != null)
                {
                    ddlLeaveApplicationApplicationStatusID.SelectedValue = hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID.ToString();
                }

                if (ddlLeavePurpose.Items.Count > 0 && hREmployeeLeaveApplicationEntity.Description != null)
                {
                    ddlLeavePurpose.SelectedValue = hREmployeeLeaveApplicationEntity.Description.ToString();
                }

                if (ddlLeaveLocation.Items.Count > 0 && hREmployeeLeaveApplicationEntity.LeaveLocation != null)
                {
                    ddlLeaveLocation.SelectedValue = hREmployeeLeaveApplicationEntity.LeaveLocation.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeLeaveApplicationList();
        }

        private void BindHREmployeeLeaveApplicationList()
        {
            lvHREmployeeLeaveApplication.DataBind();
        }

        private HREmployeeLeaveApplicationEntity BuildHREmployeeLeaveApplicationEntity()
        {
            HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = CurrentHREmployeeLeaveApplicationEntity;


            hREmployeeLeaveApplicationEntity.EmployeeID = OverviewEmployeeID;

            if (txtApplicationDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLeaveApplicationEntity.ApplicationDate = DateTime.Parse(txtApplicationDate.Text);
            }

            if (txtRequestStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLeaveApplicationEntity.RequestStartDate = MiscUtil.ParseToDateTime(txtRequestStartDate.Text);
            }

            if (txtRequestEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeLeaveApplicationEntity.RequestEndDate = MiscUtil.ParseToDateTime(txtRequestEndDate.Text);
            }

            if (!txtTotalLeaveDays.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeLeaveApplicationEntity.TotalLeaveDays = Decimal.Parse(txtTotalLeaveDays.Text.Trim());
            }

            //hREmployeeLeaveApplicationEntity.Description = txtDescription.Text.Trim();
            if (ddlLeavePurpose.Items.Count > 0)
            {
                if (ddlLeavePurpose.SelectedValue == "0")
                {
                    hREmployeeLeaveApplicationEntity.Description = null;
                }
                else
                {
                    hREmployeeLeaveApplicationEntity.Description = ddlLeavePurpose.SelectedValue;
                }
            }
            
            //hREmployeeLeaveApplicationEntity.LeaveLocation = txtLeaveLocation.Text.Trim();

            if (ddlLeaveLocation.Items.Count > 0)
            {
                if (ddlLeaveLocation.SelectedValue == "0")
                {
                    hREmployeeLeaveApplicationEntity.LeaveLocation = null;
                }
                else
                {
                    hREmployeeLeaveApplicationEntity.LeaveLocation = ddlLeaveLocation.SelectedValue;
                }
            }

            if (ddlBackupEmployeeID.Items.Count > 0)
            {
                if (ddlBackupEmployeeID.SelectedValue == "0")
                {
                    hREmployeeLeaveApplicationEntity.BackupEmployeeID = null;
                }
                else
                {
                    hREmployeeLeaveApplicationEntity.BackupEmployeeID = Int64.Parse(ddlBackupEmployeeID.SelectedValue);
                }
            }

            if (ddlLeaveApplicationApplicationStatusID.Items.Count > 0)
            {
                if (ddlLeaveApplicationApplicationStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLeaveApplicationEntity.LeaveApplicationApplicationStatusID = Int64.Parse(ddlLeaveApplicationApplicationStatusID.SelectedValue);
                }
            }

            #region Active FiscalYearID

            IList<ACFiscalYearEntity> listACFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(10000, 1, String.Empty, String.Empty, DatabaseOperationType.Load);

            ACFiscalYearEntity aCFiscalYearEntity = listACFiscalYear.Where( x=> x.IsClosed ==  false).Single();
            //if (listACFiscalYear.Count > 0 && listACFiscalYear[0].IsClosed == false)
            if (listACFiscalYear.Count > 0)
            {
                hREmployeeLeaveApplicationEntity.FiscalYearID = aCFiscalYearEntity.FiscalYearID;
            }

            #endregion


            return hREmployeeLeaveApplicationEntity;
        }

        private void SaveHREmployeeLeaveApplicationEntity()
        {
           
            if (ValidationInput())
            {
                if (IsValid)
                {
                    try
                    {

                        HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = BuildHREmployeeLeaveApplicationEntity();

                        hREmployeeLeaveApplicationEntity.SalarySessionID = Int64.Parse(ViewState["SalarySessionID"].ToString());



                        Int64 result = -1;
                        if (hREmployeeLeaveApplicationEntity.IsNew)
                        {
                            result = FCCHREmployeeLeaveApplication.GetFacadeCreate().Add(hREmployeeLeaveApplicationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            if (hREmployeeLeaveApplicationEntity.BackupEmployeeID != null)
                            {
                                SendMail(hREmployeeLeaveApplicationEntity);
                            }
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeLeaveApplicationID, hREmployeeLeaveApplicationEntity.EmployeeLeaveApplicationID.ToString(), SQLMatchType.Equal);
                            result = FCCHREmployeeLeaveApplication.GetFacadeCreate().Update(hREmployeeLeaveApplicationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {

                            if (hREmployeeLeaveApplicationEntity.IsNew)
                            {
                                #region Approval Process

                                if (ddlAPPanelID != null && ddlAPPanelID.SelectedValue != "0")
                                {
                                    
                                    Boolean apResult = APRobot.CreateApprovalProcessForNewLeaveApplication(result, Int64.Parse(ddlAPPanelID.SelectedValue.ToString()));
                                    if (apResult == true)
                                    {
                                        
                                        MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                                    }
                                    else
                                    {
                                        MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                                    }
                                }
                            }

                                #endregion

                            _EmployeeLeaveApplicationID = 0;
                            _HREmployeeLeaveApplicationEntity = new HREmployeeLeaveApplicationEntity();
                            PrepareInitialView();
                            BindHREmployeeLeaveApplicationList();

                            if (hREmployeeLeaveApplicationEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Employee Leave Application Information has been added successfully.", false);
                              
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Employee Leave Application Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (hREmployeeLeaveApplicationEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Leave Application Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Leave Application Information.", false);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }

        }

        private void SendMail(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity)
        {
            HREmployeeLeaveApplicationEntity entity = hREmployeeLeaveApplicationEntity;

            String fe = "EmployeeID = " + entity.BackupEmployeeID + "";
            IList<HREmployee_DetailedEntity> listEmployee = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe);
            String EmployeeName = listEmployee[0].EmployeeFullName;
            String EmployeeCode = listEmployee[0].EmployeeCode;
            Int64 BackupEmployeeID = (Int64)entity.BackupEmployeeID;


            #region Notice Mail

            String MailBody = String.Empty;
            String Subject = String.Empty;
            //int count = 0;

            StringBuilder sb = new StringBuilder();

            sb.Append("Dear Sir,");
            sb.Append("<br/>");
            sb.Append("This is a auto generated mail from the ERP.");
            sb.Append("<br/>");
            sb.Append("Employee Name: "+EmployeeName+" Code :"+EmployeeCode+" is going to take "+entity.TotalLeaveDays+" days leave. And you are the back employee or assigned to his/her work. .");
            sb.Append("<br/>");
            sb.Append("Please contact with him/her if you have any problem.");
            sb.Append("<br/>");
            sb.Append("-");
            sb.Append("<br/>");
            sb.Append("Thanks");
            sb.Append("<br/>");
            sb.Append("ERP System");
            MailBody = sb.ToString();
            Subject = "ERP, Leave";

            String[] sendToMail = new String[1];

            HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(BackupEmployeeID);

            if (_hREmployeeEntity != null)
            {
                sendToMail[0] = _hREmployeeEntity.PrimaryEmail;
            }

            MiscUtil.SendMail(sendToMail, Subject, MailBody);

            #endregion
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployeeLeaveApplication_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HREmployeeLeaveApplication_DetailedEntity ent = (HREmployeeLeaveApplication_DetailedEntity)dataItem.DataItem;
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.LEAVE_APPLICATION, ent.EmployeeLeaveApplicationID);
                if (aPApprovalProcessEntity.APApprovalProcessID > 0)
                {
                    lnkShowApprovalStatus.NavigateUrl = UrlHelper.BuildSecureUrl(
                               "~/AP/APView.aspx",
                               string.Empty,
                               APApprovalProcessEntity.FLD_NAME_APApprovalProcessID,
                               aPApprovalProcessEntity.APApprovalProcessID.ToString()
                               ).ToString();

                    lnkShowApprovalStatus.Target = "_blank";
                }
                else
                {
                    lnkShowApprovalStatus.NavigateUrl = String.Empty;
                    lnkShowApprovalStatus.Enabled = false;
                }
            }
        }

        protected void lvHREmployeeLeaveApplication_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeLeaveApplicationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeLeaveApplicationID);

            if (EmployeeLeaveApplicationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeLeaveApplicationID = EmployeeLeaveApplicationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeLeaveApplicationID, EmployeeLeaveApplicationID.ToString(), SQLMatchType.Equal);

                        HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity = new HREmployeeLeaveApplicationEntity();


                        result = FCCHREmployeeLeaveApplication.GetFacadeCreate().Delete(hREmployeeLeaveApplicationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeLeaveApplicationID = 0;
                            _HREmployeeLeaveApplicationEntity = new HREmployeeLeaveApplicationEntity();
                            PrepareInitialView();
                            BindHREmployeeLeaveApplicationList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Leave Application has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Leave Application.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        protected void lvLeaveApplicationChecking_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

            }
        }

        protected void lvLeaveStatus_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                Label lblCasualLeaveEarned = (Label)e.Item.FindControl("lblCasualLeaveEarned");
                Label lblCasualLeaveEnjoyed = (Label)e.Item.FindControl("lblCasualLeaveEnjoyed");
                Label lblCasualleaveBalance = (Label)e.Item.FindControl("lblCasualleaveBalance");
                Label lblMedicalLeaveEarned = (Label)e.Item.FindControl("lblMedicalLeaveEarned");
                Label lblMedicalLeaveEnjoyed = (Label)e.Item.FindControl("lblMedicalLeaveEnjoyed");
                Label lblMedicalLeaveBalance = (Label)e.Item.FindControl("lblMedicalLeaveBalance");
                Label lblEarnLeaveEarned = (Label)e.Item.FindControl("lblEarnLeaveEarned");
                Label lblEarnLeaveEnjoyed = (Label)e.Item.FindControl("lblEarnLeaveEnjoyed");
                Label lblEarnLeaveBalance = (Label)e.Item.FindControl("lblEarnLeaveBalance");
                Label lblLWPLeaveEarned = (Label)e.Item.FindControl("lblLWPLeaveEarned");
                Label lblLWPLeaveEnjoyed = (Label)e.Item.FindControl("lblLWPLeaveEnjoyed");
                Label lblLWPLeaveBalance = (Label)e.Item.FindControl("lblLWPLeaveBalance");
                Label lblTotalLeaveEnjoyed = (Label)e.Item.FindControl("lblTotalLeaveEnjoyed");

                if (lblCasualLeaveEarned.Text == String.Empty)
                {
                    lblCasualLeaveEarned.Text = "0";
                }

                if (lblCasualLeaveEnjoyed.Text == String.Empty)
                {
                    lblCasualLeaveEnjoyed.Text = "0";
                }

                if (lblMedicalLeaveEarned.Text == String.Empty)
                {
                    lblMedicalLeaveEarned.Text = "0";
                }

                if (lblMedicalLeaveEnjoyed.Text == String.Empty)
                {
                    lblMedicalLeaveEnjoyed.Text = "0";
                }

                if (lblEarnLeaveEarned.Text == String.Empty)
                {
                    lblEarnLeaveEarned.Text = "0";
                }

                if (lblEarnLeaveEnjoyed.Text == String.Empty)
                {
                    lblEarnLeaveEnjoyed.Text = "0";
                }

                if (lblLWPLeaveEarned.Text == String.Empty)
                {
                    lblLWPLeaveEarned.Text = "0";
                }

                if (lblLWPLeaveEnjoyed.Text == String.Empty)
                {
                    lblLWPLeaveEnjoyed.Text = "0";
                }

                lblCasualleaveBalance.Text = (Decimal.Parse(lblCasualLeaveEarned.Text) - Decimal.Parse(lblCasualLeaveEnjoyed.Text)).ToString();
                lblMedicalLeaveBalance.Text = (Decimal.Parse(lblMedicalLeaveEarned.Text) - Decimal.Parse(lblMedicalLeaveEnjoyed.Text)).ToString();
                lblEarnLeaveBalance.Text = (Decimal.Parse(lblEarnLeaveEarned.Text) - Decimal.Parse(lblEarnLeaveEnjoyed.Text)).ToString();
                lblLWPLeaveBalance.Text = (Decimal.Parse(lblLWPLeaveEarned.Text) - Decimal.Parse(lblLWPLeaveEnjoyed.Text)).ToString();

                lblTotalLeaveEnjoyed.Text = (Decimal.Parse(lblCasualLeaveEnjoyed.Text) + Decimal.Parse(lblMedicalLeaveEnjoyed.Text) + Decimal.Parse(lblEarnLeaveEnjoyed.Text) + Decimal.Parse(lblLWPLeaveEnjoyed.Text)).ToString().Trim();

            }
        }

        protected void lvOTIssue_Detailed_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                OTIssue_DetailedEntity ent = (OTIssue_DetailedEntity)dataItem.DataItem;

                Label lblIssuePriorityNameLV = (Label)e.Item.FindControl("lblIssuePriorityNameLV");
                Label lblExpectedEndDateLV = (Label)e.Item.FindControl("lblExpectedEndDateLV");
                Label lblSupervisorAgreedLV = (Label)e.Item.FindControl("lblSupervisorAgreedLV");
                HyperLink hypIssueReport = (HyperLink)e.Item.FindControl("hypIssueReport");

                if (ent.IssuePriorityID == MasterDataConstants.MDIssuePriority.CRITICAL && ent.IssueStatusID != MasterDataConstants.MDIssueStatus.COMPLETED)
                {
                    lblIssuePriorityNameLV.ForeColor = System.Drawing.Color.Red;
                }

                //if (ent.IssueStatusID != MasterDataConstants.MDIssueStatus.COMPLETED && ent.ExpectedEndDate < System.DateTime.Now)
                //{
                //    lblExpectedEndDateLV.ForeColor = System.Drawing.Color.Red;
                //}

                if (ent.SupervisorAgreed == false)
                {
                    lblSupervisorAgreedLV.ForeColor = System.Drawing.Color.Red;
                }

                if (ent.ReferenceID != null)
                {
                    hypIssueReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "ViewIssue", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                }
                else
                {
                    hypIssueReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTAdhocIssue.aspx", string.Empty, "do", "ViewIssue", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                }

                hypIssueReport.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsHREmployeeLeaveApplication_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeLeaveApplication." + HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsLeaveApplicationChecking_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeLeaveApplication." + HREmployeeLeaveApplicationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            if (chbxFilter.Checked)
            {
                if (txtRequestStartDate.Text.IsNotNullOrEmpty() || txtRequestEndDate.Text.IsNotNullOrEmpty())
                {
                    String fe2 = "(RequestStartDate >= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and  RequestEndDate <='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "' OR RequestEndDate >= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and RequestStartDate <='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "')";
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe2, SQLJoinType.AND, fe);
                }
                else
                {
                    this.messageDetails.Text = "Please Select Request Start Date and End Date. First";
                    this.MPE.Show();
                }
            }
            

            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsLeaveStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = "" + OverviewEmployeeID + "";

            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsOTIssue_Detailed_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
            //String fe_assignToEmployee = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_AssignedToEmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            String fe_assignToEmployee = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_AssignedToEmployeeID, "00", SQLMatchType.Equal);
            fe = fe_assignToEmployee;
            if (chbxFilter.Checked)
            {
                if (txtRequestStartDate.Text.IsNotNullOrEmpty() || txtRequestEndDate.Text.IsNotNullOrEmpty())
                {
                    String fe2 = "OTIssue.AssignedToEmployeeID = " + OverviewEmployeeID + " and ( OTIssue.ExpectedStartDate >= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and  OTIssue.ExpectedEndDate <='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "' or OTIssue.ExpectedEndDate >= '" + MiscUtil.ParseToDateTime(txtRequestStartDate.Text) + "' and OTIssue.ExpectedStartDate <='" + MiscUtil.ParseToDateTime(txtRequestEndDate.Text) + "')";
                    fe = fe2;
                }
                else
                {
                    this.messageDetails.Text = "Please Select Request Start Date and End Date. First";
                    this.MPE.Show();
                }
            }
            //fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe_assignToEmployee);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeLeaveApplicationEntity();
            //MPE.Show();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeLeaveApplicationID = 0;
            _HREmployeeLeaveApplicationEntity = new HREmployeeLeaveApplicationEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            
            PrepareInitialView();
            PrepareEditView();
        }


        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            lvLeaveApplicationChecking.DataBind();
            lvOTIssue_Detailed.DataBind();
        }

        #endregion

        #endregion Event
    }
}
