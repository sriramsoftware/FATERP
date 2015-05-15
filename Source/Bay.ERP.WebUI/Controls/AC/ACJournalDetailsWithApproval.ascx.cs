// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;
using System.Text;
using System.Web.UI.HtmlControls;

namespace Bay.ERP.Web.UI
{
    public partial class ACJournalDetailsWithApprovalControl : BaseControl
    {       
        #region Properties

        public Int64 _JournalID
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

        public ACTemporaryJournalMasterEntity _ACJournalEntity
        {
            get
            {
                ACTemporaryJournalMasterEntity entity = new ACTemporaryJournalMasterEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACTemporaryJournalMasterEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACTemporaryJournalMasterEntity CurrentACJournalEntity
        {
            get
            {
                if (OverviewTemporaryJournalMasterID > 0)
                {
                    _ACJournalEntity = FCCACTemporaryJournalMaster.GetFacadeCreate().GetByID(OverviewTemporaryJournalMasterID);
                }

                return _ACJournalEntity;
            }
            set
            {
                _ACJournalEntity = value;
            }
        }

        public IList<ACTemporaryJournal_DetailedEntity> CurrentACJournalList
        {
            get
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression("ACTemporaryJournal." + ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalMasterID, OverviewTemporaryJournalMasterID.ToString(), SQLMatchType.Equal);
                ViewState["vs_CurrentACJournalList"] = FCCACTemporaryJournal_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);

                return (IList<ACTemporaryJournal_DetailedEntity>)ViewState["vs_CurrentACJournalList"];
            }
            set
            {
                ViewState["vs_CurrentACJournalList"] = value;
            }
        }

        public Int64 _temporaryJournalID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["temporaryJournalID"] != null)
                {
                    Int64.TryParse(ViewState["temporaryJournalID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["temporaryJournalID"] = value;
            }
        }

        public Int64 _temporaryJournalItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["TemporaryJournalItemID"] != null)
                {
                    Int64.TryParse(ViewState["TemporaryJournalItemID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["TemporaryJournalItemID"] = value;
            }
        }

        public ACTemporaryJournal_DetailedEntity _ACTemporaryJournalItemEntity
        {
            get
            {
                ACTemporaryJournal_DetailedEntity entity = new ACTemporaryJournal_DetailedEntity();

                if (ViewState["Current_ACTemporaryJournalItemEntity"] != null)
                {
                    entity = (ACTemporaryJournal_DetailedEntity)ViewState["Current_ACTemporaryJournalItemEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["Current_ACTemporaryJournalItemEntity"] = value;
            }
        }

        private ACTemporaryJournal_DetailedEntity CurrentACTemporaryJournalItemEntity
        {
            get
            {
                if (_temporaryJournalID > 0)
                {
                    //if (_ACBankAccountDepositItemEntity.BankAccountDepositItemID != _BankAccountDepositItemID)
                    //{   
                    _ACTemporaryJournalItemEntity = (from s in CurrentACJournalList
                                                     where s.TemporaryJournalID == _temporaryJournalID
                                                     select s).FirstOrDefault();
                    // }
                }

                return _ACTemporaryJournalItemEntity;
            }
            set
            {
                _ACTemporaryJournalItemEntity = value;
            }
        }

        public Int64 OverviewTemporaryJournalMasterID
        {
            get
            {
                Int64 temporaryJournalID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_ID], out temporaryJournalID);
                }

                return temporaryJournalID;
            }
        }


        public Int64 APApprovalProcessID
        {
            get
            {
                Int64 aPApprovalProcessID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APApprovalProcessID], out aPApprovalProcessID);
                }

                return aPApprovalProcessID;
            }
        }

        public Int64 APForwardInfoID
        {
            get
            {
                Int64 aPForwardInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APForwardInfoEntity.FLD_NAME_APForwardInfoID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APForwardInfoEntity.FLD_NAME_APForwardInfoID], out aPForwardInfoID);
                }

                return aPForwardInfoID;
            }
        }

        public Int64 ProxyEmployeeID
        {
            get
            {
                Int64 proxyEmployeeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_ProxyEmployeeID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_ProxyEmployeeID], out proxyEmployeeID);
                }

                return proxyEmployeeID;
            }
        }

        public Int64 APMemberFeedbackID
        {
            get
            {
                Int64 aPMemberFeedbackID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID], out aPMemberFeedbackID);
                }

                return aPMemberFeedbackID;
            }
        }

        #endregion

        #region Methods

        private void RedirectPageToAllPendingList()
        {
            Response.Redirect("~/AP/Default.aspx");
        }

        private void RedirectPageToRejectList()
        {
            Response.Redirect("~/AP/APRejectedList.aspx");
        }

        private void RedirectPageToForwardList()
        {
            Response.Redirect("~/AP/APPendingForwardList.aspx");
        }

        private void RedirectPageToPendingList()
        {
            Response.Redirect("~/AP/APPendingList.aspx");
        }

        private void RedirectPageToProxyList()
        {
            Response.Redirect("~/AP/APProxyApprovalRequest.aspx");
        }

        private void BuildDropDownAPList()
        {

            if (!(APForwardInfoID > 0))
            {
                ddlAction.Items.Add(new ListItem("Approve", "1"));
                ddlAction.Items.Add(new ListItem("Reject", "2"));
                ddlAction.Items.Add(new ListItem("Forward", "3"));

                APMemberFeedbackEntity ent = APRobot.GetAPMemberFeedbackByID(APMemberFeedbackID);

                ddlRejectTo.Items.Clear();
                ddlRejectTo.DataTextField = APMemberFeedback_DetailedEntity.FLD_NAME_MemberFullName;
                ddlRejectTo.DataValueField = APMemberFeedback_DetailedEntity.FLD_NAME_APMemberFeedbackID;
                ddlRejectTo.DataSource = APRobot.GetRejectToMemberFeedbacks_Detailed(APApprovalProcessID, ent.EmployeeID);
                ddlRejectTo.DataBind();
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                ddlRejectTo.Items.Insert(0, pleaseSelectListItem);

                ddlForwardTo.Items.Clear();
                ddlForwardTo.DataTextField = APPanelForwardMember_DetailedEntity.FLD_NAME_MemberFullName;
                ddlForwardTo.DataValueField = APPanelForwardMember_DetailedEntity.FLD_NAME_APPanelForwardMemberID;
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.TEMPORARY_JOURNAL, OverviewTemporaryJournalMasterID);
                ddlForwardTo.DataBind();
            }
            else
            {
                ddlAction.Items.Add(new ListItem("Comment", "4"));
            }

        }

        private void BuildTotalValueLabel()
        {

            Decimal resultDebit = (from s in CurrentACJournalList
                                   where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT
                                   select s.Amount).Sum(val => val);

            Decimal resultCredit = (from s in CurrentACJournalList
                                    where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT
                                    select s.Amount).Sum(val => val);

            lblTotalDebitValue.Text = MiscUtil.NumericCommaSeperatedFormat(resultDebit);
            lblTotalCreditValue.Text = MiscUtil.NumericCommaSeperatedFormat(resultCredit);

            if (resultDebit == 0 && resultCredit == 0)
            {
                dvTotalValue.Visible = false;
            }

            if (resultCredit > 0 || resultDebit > 0)
            {
                dvTotalValue.Visible = true;
            }
        }

        private Boolean ValidateInputAccounts()
        {
            Boolean validationResult = true;

            if (hdEmpID.Value == "0")
            {
                if (txtItemName.Text.Trim().IsNotNullOrEmpty())
                {
                    MiscUtil.ShowMessage(lblMessage, "Invalid Accounts, Please Enter Correct Account Name.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Please Select Correct Account Name.", true);
                }

                validationResult = false;
            }

            return validationResult;
        }

        private void EnableDisableApprovalButtons()
        {
            if (!(APForwardInfoID > 0))
            {
                APMemberFeedbackEntity ent = APRobot.GetAPMemberFeedbackByID(APMemberFeedbackID);

                if (ent.APFeedbackID == MasterDataConstants.APFeedback.APPROVED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.REJECTED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED ||
                    ent.APFeedbackID == MasterDataConstants.APFeedback.CANCELED)
                {
                    btnApprove.Enabled = false;
                    btnReject.Enabled = false;
                    btnForward.Enabled = false;
                }
                else
                {
                    btnApprove.Enabled = true;
                    btnReject.Enabled = true;
                    btnForward.Enabled = true;
                }

                Boolean isAPFirstMember = APRobot.IsFirstMemberFeedback(APMemberFeedbackID);

                if (isAPFirstMember)
                {
                    if (ent.APFeedbackID == MasterDataConstants.APFeedback.APPROVED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.REJECTED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.NOT_YET_REQUESTED ||
                        ent.APFeedbackID == MasterDataConstants.APFeedback.CANCELED)
                    {
                        // btnSubmit.Visible = false;
                    }
                    else
                    {
                        //btnSubmit.Visible = true;
                    }
                }
                else
                {
                    //btnSubmit.Visible = false;
                }
            }
            else
            {
                btnApprove.Enabled = false;
                btnReject.Enabled = false;
                btnForward.Enabled = false;

                //btnSubmit.Visible = false;
            }
        }

        private String AddProxyMemberInfo(String remarks)
        {
            if (ProxyEmployeeID > 0)
            {
                APMemberFeedback_DetailedEntity ent = APRobot.GetMemberFeedback_DetailedByAPMemberFeedbackID(APMemberFeedbackID);
                remarks += "<br />";
                remarks += "<br />";
                remarks += "<b><i>This action has been taken by proxy member - " + ent.ProxyMemberFullName + "</i></b>";
            }

            return remarks;
        }

        private void BuildDropDownList()
        { 
            MiscUtil.PopulateACMDDebitCredit(ddlMDDebitCreditID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, true);
            MiscUtil.PopulateMDItem(ddlItemID, true);
            BuildDropDownAPList();

           BuildProjectWiseDropdownInfo();
        }


        private void BuildProjectWiseDropdownInfo()
        {
            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulateREQApprovedRequisitionByProject(ddlRequisitionID, true, Int64.Parse(ddlProjectID.SelectedValue));

                BuildRequisitionWiseInfo();

                BuildWorkorderWiseInfo();

                BuildFloorInfo();

                BuildFloorWiseInfo();
            }
        }

        private void BuildRequisitionWiseInfo()
        {
            if (ddlRequisitionID != null && ddlRequisitionID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, true, Int64.Parse(ddlRequisitionID.SelectedValue));

                BuildWorkorderWiseInfo();
            }
        }

        private void BuildWorkorderWiseInfo()
        {
            if (ddlWorkOrderID != null && ddlWorkOrderID.Items.Count > 0)
            {
                MiscUtil.PopulateCMBillByWorkOrder(ddlBillID, true, Int64.Parse(ddlWorkOrderID.SelectedValue));
            }
        }

        private void BuildFloorInfo()
        {
            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulateBDProjectFloorByProject(ddlProjectFloorID, true, Int64.Parse(ddlProjectID.SelectedValue));

                BuildFloorWiseInfo();
            }
        }

        private void BuildFloorWiseInfo()
        {
            if (ddlProjectFloorID != null && ddlProjectFloorID.Items.Count > 0)
            {
                MiscUtil.PopulateBDProjectFloorUnitByFloor(ddlProjectFloorUnitID, true, Int64.Parse(ddlProjectFloorID.SelectedValue));
            }
        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidateInput()
        {
            Boolean flag=true;

            if (CurrentACJournalList != null && CurrentACJournalList.Count > 0)
            {
                var resultDebit = (from s in CurrentACJournalList
                                   where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT
                                   select s.Amount).Sum(val => val);

                var resultCredit = (from s in CurrentACJournalList
                                   where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT
                                   select s.Amount).Sum(val => val);

                if (resultCredit != resultDebit)
                {
                    flag = false;
                    MiscUtil.ShowMessage(lblMessage, "Debit and Credit amount should same.", true);
                }
            }

            if (CurrentACJournalList == null || CurrentACJournalList.Count <= 0)
            {
                flag = false;
            }

            return flag;
        }

        private void PrepareEditViewJournal()
        {
            ACTemporaryJournal_DetailedEntity aCTemporaryJournal_DetailedEntity = CurrentACTemporaryJournalItemEntity;

            if (!aCTemporaryJournal_DetailedEntity.IsNew)
            {
                if (aCTemporaryJournal_DetailedEntity.AccountID > 0)
                {
                    txtItemName.Text = aCTemporaryJournal_DetailedEntity.ACAccountAccountName.ToString();
                    hdEmpID.Value = aCTemporaryJournal_DetailedEntity.AccountID.ToString();
                }

                if (ddlItemID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = aCTemporaryJournal_DetailedEntity.ItemID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.ItemID == null)
                {
                    ddlItemID.SelectedValue = "0";
                }

                if (ddlProjectID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = aCTemporaryJournal_DetailedEntity.ProjectID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.ProjectID == null)
                {
                    ddlProjectID.SelectedValue = "0";
                }

                BuildProjectWiseDropdownInfo();

                if (ddlRequisitionID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = aCTemporaryJournal_DetailedEntity.RequisitionID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.RequisitionID == null)
                {
                    ddlRequisitionID.SelectedValue = "0";
                }

                BuildRequisitionWiseInfo();

                if (ddlWorkOrderID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = aCTemporaryJournal_DetailedEntity.WorkOrderID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.WorkOrderID == null)
                {
                    ddlWorkOrderID.SelectedValue = "0";
                }

                BuildWorkorderWiseInfo();

                if (ddlBillID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.BillID != null)
                {
                    ddlBillID.SelectedValue = aCTemporaryJournal_DetailedEntity.BillID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.BillID == null)
                {
                    ddlBillID.SelectedValue = "0";
                }

                if (ddlProjectFloorID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = aCTemporaryJournal_DetailedEntity.ProjectFloorID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.ProjectFloorID == null)
                {
                    ddlProjectFloorID.SelectedValue = "0";
                }

                BuildFloorWiseInfo();

                if (ddlProjectFloorUnitID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = aCTemporaryJournal_DetailedEntity.ProjectFloorUnitID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.ProjectFloorUnitID == null)
                {
                    ddlProjectFloorUnitID.SelectedValue = "0";
                }

                if (ddlMDDebitCreditID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.MDDebitCreditID != null)
                {
                    ddlMDDebitCreditID.SelectedValue = aCTemporaryJournal_DetailedEntity.MDDebitCreditID.ToString();
                }

                txtAmount.Text = aCTemporaryJournal_DetailedEntity.Amount.ToString();
                txtNote.Text = aCTemporaryJournal_DetailedEntity.Note.ToString();
            }
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            BindACJournalList();

            txtTransactionDateTime.Text = String.Empty;
            txtAmount.Text = String.Empty;
            txtReferenceOrMemoOrID.Text = String.Empty;
            txtNote.Text = String.Empty;
            chkIsReverseTransaction.Checked = false;
            lblPreparedBy.Text = CurrentACJournalList[0].MemberFullName.ToString();

            btnSubmit.Text = "Process Journal Entry";
            //btnAddNew.Visible = false;

            CurrentACJournalList = new List<ACTemporaryJournal_DetailedEntity>();

            hypReportLink.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.MANUAL_JOURNAL_REPORT, UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID, OverviewTemporaryJournalMasterID.ToString()).ToString();
            hypReportLink.Target = "_blank";

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            #endregion
        }

        private void PrepareEditView()
        {
            ACTemporaryJournalMasterEntity aCJournalEntity = CurrentACJournalEntity;


            if (!aCJournalEntity.IsNew)
            {
                

                String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalMasterID, aCJournalEntity.TemporaryJournalMasterID.ToString(), SQLMatchType.Equal);
                IList<ACTemporaryJournalEntity> lst = FCCACTemporaryJournal.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    txtTransactionDateTime.Text = lst[0].TransactionDateTime.ToStringDefault();
                    txtReferenceOrMemoOrID.Text = lst[0].ReferenceOrMemoOrID.ToString();
                    chkIsReverseTransaction.Checked = lst[0].IsReverseTransaction;
                    txtNote.Text = lst[0].Note.ToString();

                    btnSubmit.Text = "Update";
                }
            }
        }

        private void SaveTemporaryJournalEntity()
        {
           
                try
                {
                    //ACTemporaryJournalEntity 
                    //ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity = FCCACTemporaryJournalMaster.GetFacadeCreate().GetByID(OverviewTemporaryJournalMasterID);
                    //aCTemporaryJournalMasterEntity.t

                    

                    //aCTemporaryJournalMasterEntity.CreateDate = System.DateTime.Now;
                    //aCTemporaryJournalMasterEntity.Remarks = "Temporary Journal Entry";
                    //aCTemporaryJournalMasterEntity.TemporyJournalApprovalStatusID = MasterDataConstants.ACMDTemporaryJournalApprovalStatus.INITIATED;

                    //Int64 result = FCCACTemporaryJournalMaster.GetFacadeCreate().Add(aCTemporaryJournalMasterEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    
                    //if (result > 0)
                    //{
                    //    _temporaryJournalID = result;

                    //    if (CurrentACJournalList != null && CurrentACJournalList.Count > 0)
                    //    {
                    //        foreach (ACTemporaryJournal_DetailedEntity ent in CurrentACJournalList)
                    //        {
                    //            ACTemporaryJournalEntity acJournalEntity = new ACTemporaryJournalEntity();
                    //            acJournalEntity.TemporaryJournalMasterID = result;
                    //            acJournalEntity.AccountID = ent.AccountID;
                    //            acJournalEntity.AccountGroupID = ent.AccountGroupID;
                    //            acJournalEntity.ClassID = ent.ClassID;
                    //            acJournalEntity.ClassTypeID = ent.ClassTypeID;
                    //            acJournalEntity.FiscalYearID = ent.FiscalYearID;
                    //            acJournalEntity.TransactionDateTime = ent.TransactionDateTime;
                    //            acJournalEntity.Amount = ent.Amount;
                    //            acJournalEntity.EnteredByEmployeeID = ent.EnteredByEmployeeID;
                    //            acJournalEntity.ReferenceOrMemoOrID = ent.ReferenceOrMemoOrID;
                    //            acJournalEntity.Note = ent.Note;
                    //            if (chkIsReverseTransaction.Checked)
                    //            {
                    //                if (ent.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT)
                    //                {
                    //                    acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.CREDIT;
                    //                }
                    //                else if (ent.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT)
                    //                {
                    //                    acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                    //                }
                    //            }
                    //            else if (chkIsReverseTransaction.Checked == false)
                    //            {
                    //                acJournalEntity.MDDebitCreditID = ent.MDDebitCreditID;
                    //            }

                    //            acJournalEntity.DimensionID = ent.DimensionID;
                    //            acJournalEntity.ProjectID = ent.ProjectID;
                    //            acJournalEntity.IsReverseTransaction = chkIsReverseTransaction.Checked;

                    //            FCCACTemporaryJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    //        }

                            MiscUtil.ShowMessage(lblMessage, "Journal Information has been added successfully.", false);

                           // CurrentACJournalList = new List<ACTemporaryJournal_DetailedEntity>();
                            //BindACJournalList();
                       // }
                    //}
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to add Journal Information." + ex.Message, false);
                }
         
        }

        private void BindList()
        {
            BindACJournalList();
        }

        private void BindACJournalList()
        {
            lvACJournal.DataSource = CurrentACJournalList;
            lvACJournal.DataBind();
        }

        private void AddItemToListView()
        {
            try
            {
                ACTemporaryJournalEntity aCJournalEntity = new ACTemporaryJournalEntity();

                aCJournalEntity.TemporaryJournalMasterID = OverviewTemporaryJournalMasterID;

                if (hdEmpID.Value != "0")
                {
                    aCJournalEntity.AccountID = Int64.Parse(hdEmpID.Value);

                    ACAccountEntity acAccountEntity = FCCACAccount.GetFacadeCreate().GetByID(aCJournalEntity.AccountID);

                    if (acAccountEntity != null && acAccountEntity.AccountID > 0)
                    {
                        aCJournalEntity.AccountGroupID = acAccountEntity.AccountGroupID;
                        ACAccountGroupEntity acAccountGroup = FCCACAccountGroup.GetFacadeCreate().GetByID(aCJournalEntity.AccountGroupID);

                        if (acAccountGroup != null && acAccountGroup.AccountGroupID > 0)
                        {
                            String fe_accountClass = SqlExpressionBuilder.PrepareFilterExpression(ACClassEntity.FLD_NAME_ClassID, acAccountGroup.ClassID.ToString(), SQLMatchType.Equal);
                            IList<ACClassEntity> lstacAccountClass = FCCACClass.GetFacadeCreate().GetIL(null, null, String.Empty, fe_accountClass, DatabaseOperationType.LoadWithFilterExpression);

                            if (lstacAccountClass != null && lstacAccountClass.Count > 0)
                            {
                                aCJournalEntity.ClassID = lstacAccountClass[0].ClassID;
                                aCJournalEntity.ClassTypeID = lstacAccountClass[0].ClassTypeID;
                            }

                            String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
                            IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe_fiscalYear, DatabaseOperationType.LoadWithFilterExpression);

                            if (lstFiscalYear != null && lstFiscalYear.Count > 0)
                            {
                                aCJournalEntity.FiscalYearID = lstFiscalYear[0].FiscalYearID;
                            }

                        }
                    }
                }
                

                if (txtTransactionDateTime.Text.Trim().IsNotNullOrEmpty())
                {
                    aCJournalEntity.TransactionDateTime = MiscUtil.ParseToDateTime(txtTransactionDateTime.Text);
                }

                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        aCJournalEntity.ItemID = null;
                    }
                    else
                    {
                        aCJournalEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        aCJournalEntity.RequisitionID = null;
                    }
                    else
                    {
                        aCJournalEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                    }
                }
                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        aCJournalEntity.WorkOrderID = null;
                    }
                    else
                    {
                        aCJournalEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        aCJournalEntity.BillID = null;
                    }
                    else
                    {
                        aCJournalEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectID = null;
                    }
                    else
                    {
                        aCJournalEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectFloorID = null;
                    }
                    else
                    {
                        aCJournalEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectFloorUnitID = null;
                    }
                    else
                    {
                        aCJournalEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectID = null;
                    }
                    else
                    {
                        aCJournalEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                    }
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    aCJournalEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                aCJournalEntity.EnteredByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                aCJournalEntity.ReferenceOrMemoOrID = txtReferenceOrMemoOrID.Text.Trim();
                aCJournalEntity.Note = txtNote.Text.Trim();
                if (ddlMDDebitCreditID.Items.Count > 0)
                {
                    if (ddlMDDebitCreditID.SelectedValue == "0")
                    {
                    }
                    else
                    {
                        aCJournalEntity.MDDebitCreditID = Int64.Parse(ddlMDDebitCreditID.SelectedValue);
                       // aCJournalEntity.ACMDDebitCreditName = ddlMDDebitCreditID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectID = null;
                    }
                    else
                    {
                        aCJournalEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                       // aCJournalEntity.BDProjectProjectName = ddlProjectID.SelectedItem.ToString();
                    }
                }

                aCJournalEntity.IsReverseTransaction = chkIsReverseTransaction.Checked;

                aCJournalEntity.ReverseTransactionJournalID = null;
               // CurrentACJournalList.Add(aCJournalEntity);

                FCCACTemporaryJournal.GetFacadeCreate().Add(aCJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);

                BindACJournalList();

                MiscUtil.ShowMessage(lblMessage, "Item Added Successfully", UIConstants.MessageType.GREEN);

                txtAmount.Text = String.Empty;
                txtNote.Text = String.Empty;
                txtItemName.Text = String.Empty;
                hdEmpID.Value = "0";
                BuildTotalValueLabel();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            btnApprove.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnApprove, "").ToString());
            btnReject.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnReject, "").ToString());
            btnSubmitComment.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnSubmitComment, "").ToString());
            btnForward.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnForward, "").ToString());

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
                BuildTotalValueLabel();
            }
        }

        #endregion

        #region List View Event

        protected void lvACJournal_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Label lblDebitAmountLV = (Label)e.Item.FindControl("lblDebitAmountLV");
                Label lblCreditAmountLV = (Label)e.Item.FindControl("lblCreditAmountLV");

                switch (Int64.Parse(ddlMDDebitCreditID.SelectedValue))
                {
                    case MasterDataConstants.MDDebitCredit.DEBIT:
                        lblDebitAmountLV.Text = txtAmount.Text.ToString();
                        lblCreditAmountLV.Text = String.Empty;
                        break;
                    case MasterDataConstants.MDDebitCredit.CREDIT:
                        lblCreditAmountLV.Text = txtAmount.Text.ToString();
                        lblDebitAmountLV.Text = String.Empty;
                        break;
                }
            }
        }

        protected void lvAPMemberFeedbackRemarks_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                APMemberFeedbackRemarks_DetailedEntity ent = (APMemberFeedbackRemarks_DetailedEntity)e.Item.DataItem;

                APForwardInfo_DetailedEntity aPForwardInfo_DetailedEntity = APRobot.GetAPForwardInfo_DetailedByRemarksID(ent.APMemberFeedbackRemarksID);

                if (aPForwardInfo_DetailedEntity.APForwardInfoID > 0)
                {
                    HtmlGenericControl forwardInfoDiv = (HtmlGenericControl)e.Item.FindControl("forwardInfoDiv");

                    forwardInfoDiv.InnerHtml = "<br />";
                    forwardInfoDiv.InnerHtml += "<b>Forwading Remarks By Panel Member</b>";
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += aPForwardInfo_DetailedEntity.APMemberComment;
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<b>Response By " + aPForwardInfo_DetailedEntity.MemberFullName + "</b>";
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += aPForwardInfo_DetailedEntity.APForwardMemberComment;
                    forwardInfoDiv.InnerHtml += "<br />";
                    forwardInfoDiv.InnerHtml += "<br />";
                }
            }
        }

        protected void lvACJournal_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 temporaryJournalID;

            Int64.TryParse(e.CommandArgument.ToString(), out temporaryJournalID);

            if (temporaryJournalID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _temporaryJournalID = temporaryJournalID;

                    PrepareEditViewJournal();

                    pnlAdd.Visible = false;
                    pnlUpdate.Visible = true;

                }

                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        ACTemporaryJournalEntity aCTemporaryJournalEntity = new ACTemporaryJournalEntity();
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalID, temporaryJournalID.ToString(), SQLMatchType.Equal);
                        result = FCCACTemporaryJournal.GetFacadeCreate().Delete(aCTemporaryJournalEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            BindACJournalList();
                        }

                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACJournal_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ACTemporaryJournalEntity aCJournalEntity = FCCACTemporaryJournal.GetFacadeCreate().GetByID(_temporaryJournalID);

                aCJournalEntity.TransactionDateTime = MiscUtil.ParseToDateTime(txtTransactionDateTime.Text.Trim().ToString());
                aCJournalEntity.IsReverseTransaction = chkIsReverseTransaction.Checked;
               
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            //_JournalID = 0;
            //_ACJournalEntity = new ACTemporaryJournalEntity();
            //PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            CurrentACTemporaryJournalItemEntity = new ACTemporaryJournal_DetailedEntity();
            txtNote.Text = String.Empty;
            txtAmount.Text = String.Empty;

            pnlUpdate.Visible = false;
            pnlAdd.Visible = true;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputAccounts())
            {
                try
                {
                    ACTemporaryJournalEntity aCJournalEntity = FCCACTemporaryJournal.GetFacadeCreate().GetByID(_temporaryJournalID);

                    if (hdEmpID.Value != "0")
                    {
                        aCJournalEntity.AccountID = Int64.Parse(hdEmpID.Value);
                        ACAccountEntity acAccountEntity = FCCACAccount.GetFacadeCreate().GetByID(aCJournalEntity.AccountID);

                        if (acAccountEntity != null && acAccountEntity.AccountID > 0)
                        {
                            aCJournalEntity.AccountGroupID = acAccountEntity.AccountGroupID;
                            ACAccountGroupEntity acAccountGroup = FCCACAccountGroup.GetFacadeCreate().GetByID(aCJournalEntity.AccountGroupID);

                            if (acAccountGroup != null && acAccountGroup.AccountGroupID > 0)
                            {
                                String fe_accountClass = SqlExpressionBuilder.PrepareFilterExpression(ACClassEntity.FLD_NAME_ClassID, acAccountGroup.ClassID.ToString(), SQLMatchType.Equal);
                                IList<ACClassEntity> lstacAccountClass = FCCACClass.GetFacadeCreate().GetIL(null, null, String.Empty, fe_accountClass, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstacAccountClass != null && lstacAccountClass.Count > 0)
                                {
                                    aCJournalEntity.ClassID = lstacAccountClass[0].ClassID;
                                    aCJournalEntity.ClassTypeID = lstacAccountClass[0].ClassTypeID;
                                }

                                String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
                                IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe_fiscalYear, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstFiscalYear != null && lstFiscalYear.Count > 0)
                                {
                                    aCJournalEntity.FiscalYearID = lstFiscalYear[0].FiscalYearID;
                                }

                            }
                        }
                    }
                    

                    if (txtTransactionDateTime.Text.Trim().IsNotNullOrEmpty())
                    {
                        aCJournalEntity.TransactionDateTime = MiscUtil.ParseToDateTime(txtTransactionDateTime.Text);
                    }

                    if (!txtAmount.Text.Trim().IsNullOrEmpty())
                    {
                        aCJournalEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                    }

                    aCJournalEntity.EnteredByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                    aCJournalEntity.ReferenceOrMemoOrID = txtReferenceOrMemoOrID.Text.Trim();
                    aCJournalEntity.Note = txtNote.Text.Trim();
                    if (ddlMDDebitCreditID.Items.Count > 0)
                    {
                        if (ddlMDDebitCreditID.SelectedValue == "0")
                        {
                        }
                        else
                        {
                            aCJournalEntity.MDDebitCreditID = Int64.Parse(ddlMDDebitCreditID.SelectedValue);
                        }
                    }

                    if (ddlItemID.Items.Count > 0)
                    {
                        if (ddlItemID.SelectedValue == "0")
                        {
                            aCJournalEntity.ItemID = null;
                        }
                        else
                        {
                            aCJournalEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                        }
                    }

                    if (ddlRequisitionID.Items.Count > 0)
                    {
                        if (ddlRequisitionID.SelectedValue == "0")
                        {
                            aCJournalEntity.RequisitionID = null;
                        }
                        else
                        {
                            aCJournalEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                        }
                    }


                    if (ddlWorkOrderID.Items.Count > 0)
                    {
                        if (ddlWorkOrderID.SelectedValue == "0")
                        {
                            aCJournalEntity.WorkOrderID = null;
                        }
                        else
                        {
                            aCJournalEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                        }
                    }

                    if (ddlBillID.Items.Count > 0)
                    {
                        if (ddlBillID.SelectedValue == "0")
                        {
                            aCJournalEntity.BillID = null;
                        }
                        else
                        {
                            aCJournalEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                        }
                    }

                    if (ddlProjectID.Items.Count > 0)
                    {
                        if (ddlProjectID.SelectedValue == "0")
                        {
                            aCJournalEntity.ProjectID = null;
                        }
                        else
                        {
                            aCJournalEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                        }
                    }

                    if (ddlProjectFloorID.Items.Count > 0)
                    {
                        if (ddlProjectFloorID.SelectedValue == "0")
                        {
                            aCJournalEntity.ProjectFloorID = null;
                        }
                        else
                        {
                            aCJournalEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                        }
                    }

                    if (ddlProjectFloorUnitID.Items.Count > 0)
                    {
                        if (ddlProjectFloorUnitID.SelectedValue == "0")
                        {
                            aCJournalEntity.ProjectFloorUnitID = null;
                        }
                        else
                        {
                            aCJournalEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                        }
                    }

                    aCJournalEntity.IsReverseTransaction = chkIsReverseTransaction.Checked;
                    aCJournalEntity.ReverseTransactionJournalID = null;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalID, _temporaryJournalID.ToString(), SQLMatchType.Equal);
                    FCCACTemporaryJournal.GetFacadeCreate().Update(aCJournalEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                    BindACJournalList();

                    txtAmount.Text = String.Empty;

                    pnlAdd.Visible = true;
                    pnlUpdate.Visible = false;
                    txtItemName.Text = String.Empty;
                    hdEmpID.Value = "0";
                    BuildTotalValueLabel();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInputAccounts())
            {
                AddItemToListView();
            }
        }


        protected void btnApprove_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.TEMPORARY_JOURNAL, OverviewTemporaryJournalMasterID);

                String remarks = txtRemarks.Text.Trim();

                if (remarks.IsNullOrEmpty())
                {
                    remarks = "Approved";
                }

                remarks = AddProxyMemberInfo(remarks);

                APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

                EnableDisableApprovalButtons();

                MiscUtil.ShowMessage(lblMessage, "You Have Approved Successfully", UIConstants.MessageType.GREEN);

                PrepareInitialView();
                BindList();
                RedirectPageToPendingList();
            }
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            btnReject.Enabled = false;

            if (ddlRejectTo.SelectedValue == "0")
            {
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.TEMPORARY_JOURNAL, OverviewTemporaryJournalMasterID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.TEMPORARY_JOURNAL, OverviewTemporaryJournalMasterID, rejectToAPMemberFeedbackID);
            }

            String remarks = txtRemarks.Text.Trim();

            if (remarks.IsNullOrEmpty())
            {
                remarks = "Rejected";
            }

            remarks = AddProxyMemberInfo(remarks);

            APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

            EnableDisableApprovalButtons();

            MiscUtil.ShowMessage(lblMessage, "You Have Rejected Successfully", UIConstants.MessageType.GREEN);

            PrepareInitialView();
            BindList();
            RedirectPageToRejectList();
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            btnForward.Enabled = false;

            if (ddlRejectTo.Items.Count > 0)
            {
                APRobot.UpdateMemberFeedbackFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.FORWARDED);
                APRobot.UpdateMemberFeedbackLastResponseDate(APMemberFeedbackID, DateTime.Now);

                String remarks = txtRemarks.Text.Trim();

                if (remarks.IsNullOrEmpty())
                {
                    remarks = "Forwarded";
                }

                remarks = AddProxyMemberInfo(remarks);

                Int64 aPMemberFeedbackRemarksID = APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

                Int64 aPPanelForwardMemberID = Int64.Parse(ddlForwardTo.SelectedValue);

                APPanelForwardMemberEntity aPPanelForwardMemberEntity = APRobot.GetAPPanelForwardMemberByID(aPPanelForwardMemberID);

                APForwardInfoEntity aPForwardInfoEntity = new APForwardInfoEntity();

                aPForwardInfoEntity.APMemberFeedbackID = APMemberFeedbackID;
                aPForwardInfoEntity.APApprovalProcessID = APApprovalProcessID;
                aPForwardInfoEntity.APMemberFeedbackRemarksID = aPMemberFeedbackRemarksID;
                aPForwardInfoEntity.DepartmentID = aPPanelForwardMemberEntity.DepartmentID;
                aPForwardInfoEntity.EmployeeID = aPPanelForwardMemberEntity.EmployeeID;
                aPForwardInfoEntity.CommentRequestDate = DateTime.Now;
                aPForwardInfoEntity.CommentSubmitDate = null;
                aPForwardInfoEntity.APMemberComment = txtForwardRemarks.Text.Trim();
                aPForwardInfoEntity.APForwardMemberComment = String.Empty;

                FCCAPForwardInfo.GetFacadeCreate().Add(aPForwardInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);

                MiscUtil.ShowMessage(lblMessage, "You have forwarded the thread successfully", UIConstants.MessageType.GREEN);

                PrepareInitialView();
                BindList();

                #region Forwarded Mail

                String MailBody = String.Empty;
                String Subject = String.Empty;

                StringBuilder sb = new StringBuilder();

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Journal Request Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Journal, Forwarded";

                HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(aPForwardInfoEntity.EmployeeID);

                if (_hREmployeeEntity != null)
                {
                    String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                    MiscUtil.SendMail(sendToMail, Subject, MailBody);
                }

                #endregion

                RedirectPageToForwardList();
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to forward", UIConstants.MessageType.RED);
            }

        }

        protected void btnSubmitComment_Click(object sender, EventArgs e)
        {
            btnSubmitComment.Enabled = false;

            Boolean result = APRobot.UpdateAPForwardInfo(APForwardInfoID, txtComment.Text.Trim());

            if (result == true)
            {
                APRobot.UpdateMemberFeedbackFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED);

                PrepareInitialView();
                BindList();

                MiscUtil.ShowMessage(lblMessage, "You have submited comments successfully", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to submit comments", UIConstants.MessageType.RED);
            }
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildProjectWiseDropdownInfo();
        }

        protected void ddlRequisitionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildRequisitionWiseInfo();
        }

        protected void ddlWorkOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildWorkorderWiseInfo();
        }

        protected void ddlProjectFloorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildFloorWiseInfo();
        }

        #endregion

        #endregion Event
    }
}
