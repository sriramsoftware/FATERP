// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public partial class ACBankAccountDepositDetailsWithApprovalControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountDepositID
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

        public ACBankAccountDepositEntity _ACBankAccountDepositEntity
        {
            get
            {
                ACBankAccountDepositEntity entity = new ACBankAccountDepositEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountDepositEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountDepositEntity CurrentACBankAccountDepositEntity
        {
            get
            {
                if (OverviewBankAccountDepositID > 0)
                {
                    _ACBankAccountDepositEntity = FCCACBankAccountDeposit.GetFacadeCreate().GetByID(OverviewBankAccountDepositID);
                }

                return _ACBankAccountDepositEntity;
            }
            set
            {
                _ACBankAccountDepositEntity = value;
            }
        }

        private ACBankAccountDeposit_DetailedEntity CurrentACBankAccountDeposit_DetailedEntity
        {
            get
            {
                IList<ACBankAccountDeposit_DetailedEntity> lstBankAccountDeposit_Detailed = new List<ACBankAccountDeposit_DetailedEntity>();

                if (OverviewBankAccountDepositID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositEntity.FLD_NAME_BankAccountDepositID, OverviewBankAccountDepositID.ToString(), SQLMatchType.Equal);

                    lstBankAccountDeposit_Detailed = FCCACBankAccountDeposit_Detailed.GetFacadeCreate().GetIL(10000,1,String.Empty,fe);
                }

                return lstBankAccountDeposit_Detailed[0];
            }
        }

        public IList<ACBankAccountDepositItem_DetailedEntity> CurrentACBankAccountDepositItemList
        {
            get
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountDepositItem."+ACBankAccountDepositItemEntity.FLD_NAME_BankAccountDepositID, OverviewBankAccountDepositID.ToString(), SQLMatchType.Equal);
                ViewState["vs_CurrentACBankAccountDepositItemList"] = FCCACBankAccountDepositItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
                return (IList<ACBankAccountDepositItem_DetailedEntity>)ViewState["vs_CurrentACBankAccountDepositItemList"];
            }
            set
            {
                ViewState["vs_CurrentACBankAccountDepositItemList"] = value;
            }
        }

        public Int64 _BankAccountDepositItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["BankAccountDepositItemID"] != null)
                {
                    Int64.TryParse(ViewState["BankAccountDepositItemID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["BankAccountDepositItemID"] = value;
            }
        }

        public ACBankAccountDepositItem_DetailedEntity _ACBankAccountDepositItemEntity
        {
            get
            {
                ACBankAccountDepositItem_DetailedEntity entity = new ACBankAccountDepositItem_DetailedEntity();

                if (ViewState["Current_ACBankAccountDepositItemEntity"] != null)
                {
                    entity = (ACBankAccountDepositItem_DetailedEntity)ViewState["Current_ACBankAccountDepositItemEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["Current_ACBankAccountDepositItemEntity"] = value;
            }
        }

        private ACBankAccountDepositItem_DetailedEntity CurrentACBankAccountDepositItemEntity
        {
            get
            {
                if (_BankAccountDepositItemID > 0)
                {
                    if (_ACBankAccountDepositItemEntity.BankAccountDepositItemID != _BankAccountDepositItemID)
                    {   
                        _ACBankAccountDepositItemEntity = (from s in CurrentACBankAccountDepositItemList
                                                           where s.BankAccountDepositItemID == _BankAccountDepositItemID
                                                           select s).FirstOrDefault();
                    }
                }

                return _ACBankAccountDepositItemEntity;
            }
            set
            {
                _ACBankAccountDepositItemEntity = value;
            }
        }

        public Int64 OverviewBankAccountDepositID
        {  
            get
            {
                Int64 bankAccountDepositID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID], out bankAccountDepositID);
                }

                return bankAccountDepositID;
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
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.BANK_DEPOSIT, OverviewBankAccountDepositID);
                ddlForwardTo.DataBind();
            }
            else
            {
                ddlAction.Items.Add(new ListItem("Comment", "4"));
            }

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
            }
        }

        private void BuildTotalValueLabel()
        {
            Decimal totalValue = (from s in CurrentACBankAccountDepositItemList
                                  select s.Amount).Sum();

            lblTotalValue.Text = MiscUtil.NumericCommaSeperatedFormat(totalValue);

            if (totalValue == 0)
            {
                dvTotalValue.Visible = false;
            }
            if (totalValue > 0)
            {
                dvTotalValue.Visible = true;
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
            MiscUtil.PopulateACMDPaidFrom(ddlPaidFromID, false);
            MiscUtil.PopulateACBankAccount(ddlBankAccountID, false);
            
            BuildReferenceByPaidFrom();
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

        private void BuildDropDownListDepositeItem()
        {
            //MiscUtil.PopulateACDimension(ddlDimensionID, true);
            MiscUtil.PopulateMDItem(ddlItemID, true);
            MiscUtil.PopulateBDProject(ddlProjectID, true);

            BuildProjectWiseDropdownInfo();
        }

        private void BuildReferenceByPaidFrom()
        {
            if (ddlPaidFromID != null && ddlPaidFromID.Items.Count > 0)
            {
                lblReference.Text = ddlPaidFromID.SelectedItem.ToString()+" :";

                switch (Int64.Parse(ddlPaidFromID.SelectedValue))
                {
                    case MasterDataConstants.ACMDPaidFrom.MISCELLANEOUS:
                        pnlName.Visible = true;
                        pnlReference.Visible = false;
                        ddlReferenceID.Items.Clear();
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CONTRACTOR:
                        MiscUtil.PopulateCMContractor(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CONSULTANT:
                        MiscUtil.PopulateCMConsultant(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.VENDOR:
                        MiscUtil.PopulatePRMSupplier(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CUSTOMER:
                        MiscUtil.PopulateCRMCustomer(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                }
            }
        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidationInput()
        {
            Boolean flag=true;

            if (CurrentACBankAccountDepositItemList.Count <= 0)
            {   
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Please Make at least one Bank Account Deposit Information.", true);
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BuildDropDownAPList();

            txtDepositDate.Text = String.Empty;
            txtReference.Text = String.Empty;
            txtName.Text = String.Empty;
            txtMemo.Text = String.Empty;
            lblPreparedBy.Text = CurrentACBankAccountDeposit_DetailedEntity.MemberFullName.ToString();

            btnSubmit.Text = "Process Deposit";

            CurrentACBankAccountDepositItemList = new List<ACBankAccountDepositItem_DetailedEntity>();

            hypReportLink.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BANK_ACCOUNT_DEPOSIT_REPORT, UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID, OverviewBankAccountDepositID.ToString()).ToString();
            hypReportLink.Target = "_blank";

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            #endregion
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

        private void PrepareEditView()
        {
            ACBankAccountDepositEntity aCBankAccountDepositEntity = CurrentACBankAccountDepositEntity;


            if (!aCBankAccountDepositEntity.IsNew)
            {
                txtDepositDate.Text = aCBankAccountDepositEntity.DepositDate.ToStringDefault();
                if (ddlPaidFromID.Items.Count > 0 && aCBankAccountDepositEntity.PaidFromID != null)
                {
                    ddlPaidFromID.SelectedValue = aCBankAccountDepositEntity.PaidFromID.ToString();
                }

                BuildReferenceByPaidFrom();

                if (ddlReferenceID.Items.Count > 0 && aCBankAccountDepositEntity.ReferenceID!= null)
                {
                    ddlReferenceID.SelectedValue = aCBankAccountDepositEntity.ReferenceID.ToString();
                }

                if (ddlBankAccountID.Items.Count > 0 && aCBankAccountDepositEntity.BankAccountID != null)
                {
                    ddlBankAccountID.SelectedValue = aCBankAccountDepositEntity.BankAccountID.ToString();
                }

                //if (ddlProjectID.Items.Count > 0 && aCBankAccountDepositEntity.ProjectID != null)
                //{
                //    ddlProjectID.SelectedValue = aCBankAccountDepositEntity.ProjectID.ToString();
                //}

                txtReference.Text = aCBankAccountDepositEntity.Reference.ToString();
                txtName.Text = aCBankAccountDepositEntity.Name.ToString();
                txtMemo.Text = aCBankAccountDepositEntity.Memo.ToString();

                btnSubmit.Text = "Update";;
            }
        }

        private void PrepareInitialViewDepositeItem()
        {
            BuildDropDownListDepositeItem();
            BindACBankAccountDepositItemList();

            txtAmount.Text = String.Empty;
            txtMemoDetail.Text = String.Empty;
        }

        private void PrepareEditViewDepositeItem()
        {
            ACBankAccountDepositItem_DetailedEntity aCBankAccountDepositItemEntity = CurrentACBankAccountDepositItemEntity;

            if (!aCBankAccountDepositItemEntity.IsNew)
            {
                if (aCBankAccountDepositItemEntity.AccountID > 0)
                {
                    txtItemName.Text = aCBankAccountDepositItemEntity.AccountName.ToString();
                    hdEmpID.Value = aCBankAccountDepositItemEntity.AccountID.ToString();
                }

                if (ddlItemID.Items.Count > 0 && aCBankAccountDepositItemEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = aCBankAccountDepositItemEntity.ItemID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.ItemID == null)
                {
                    ddlItemID.SelectedValue = "0";
                }

                if (ddlProjectID.Items.Count > 0 && aCBankAccountDepositItemEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = aCBankAccountDepositItemEntity.ProjectID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.ProjectID == null)
                {
                    ddlProjectID.SelectedValue = "0";
                }

                BuildProjectWiseDropdownInfo();

                if (ddlRequisitionID.Items.Count > 0 && aCBankAccountDepositItemEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = aCBankAccountDepositItemEntity.RequisitionID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.RequisitionID == null)
                {
                    ddlRequisitionID.SelectedValue = "0";
                }

                BuildRequisitionWiseInfo();

                if (ddlWorkOrderID.Items.Count > 0 && aCBankAccountDepositItemEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = aCBankAccountDepositItemEntity.WorkOrderID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.WorkOrderID == null)
                {
                    ddlWorkOrderID.SelectedValue = "0";
                }

                BuildWorkorderWiseInfo();

                if (ddlBillID.Items.Count > 0 && aCBankAccountDepositItemEntity.BillID != null)
                {
                    ddlBillID.SelectedValue = aCBankAccountDepositItemEntity.BillID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.BillID == null)
                {
                    ddlBillID.SelectedValue = "0";
                }

                if (ddlProjectFloorID.Items.Count > 0 && aCBankAccountDepositItemEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = aCBankAccountDepositItemEntity.ProjectFloorID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.ProjectFloorID == null)
                {
                    ddlProjectFloorID.SelectedValue = "0";
                }

                BuildFloorWiseInfo();

                if (ddlProjectFloorUnitID.Items.Count > 0 && aCBankAccountDepositItemEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = aCBankAccountDepositItemEntity.ProjectFloorUnitID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.ProjectFloorUnitID == null)
                {
                    ddlProjectFloorUnitID.SelectedValue = "0";
                }  

                txtAmount.Text = aCBankAccountDepositItemEntity.Amount.ToString();
                txtMemoDetail.Text = aCBankAccountDepositItemEntity.Memo.ToString();
            }
        }

        private void BindList()
        {
            BindACBankAccountDepositList();
        }

        private void BindACBankAccountDepositList()
        {
            
        }

        private void BindACBankAccountDepositItemList()
        {
            lvACBankAccountDepositItem.DataSource = CurrentACBankAccountDepositItemList;
            lvACBankAccountDepositItem.DataBind();
        }

        private ACBankAccountDepositEntity BuildACBankAccountDepositEntity()
        {
            ACBankAccountDepositEntity aCBankAccountDepositEntity = CurrentACBankAccountDepositEntity;

            if (txtDepositDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCBankAccountDepositEntity.DepositDate = MiscUtil.ParseToDateTime(txtDepositDate.Text);
            }

            if (ddlPaidFromID.Items.Count > 0)
            {
                if (ddlPaidFromID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountDepositEntity.PaidFromID = Int64.Parse(ddlPaidFromID.SelectedValue);
                }
            }

            if (ddlReferenceID.Items.Count > 0 && ddlReferenceID.SelectedValue != "0")
            {
                aCBankAccountDepositEntity.ReferenceID = Int64.Parse(ddlReferenceID.SelectedValue);
            }

            else
            {
                aCBankAccountDepositEntity.ReferenceID = null;
            }

            if (ddlBankAccountID.Items.Count > 0)
            {
                if (ddlBankAccountID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountDepositEntity.BankAccountID = Int64.Parse(ddlBankAccountID.SelectedValue);
                }
            }

            //if (ddlProjectID.Items.Count > 0)
            //{
            //    if (ddlProjectID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        aCBankAccountDepositEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
            //    }
            //}

            aCBankAccountDepositEntity.BankAccountDepositApprovalStatusID = MasterDataConstants.ACMDBankAccountDepositApprovalStatus.INITIATED;
            aCBankAccountDepositEntity.Reference = txtReference.Text.Trim();
            aCBankAccountDepositEntity.Name = txtName.Text.Trim();
            aCBankAccountDepositEntity.Memo = txtMemo.Text.Trim();

            return aCBankAccountDepositEntity;
        }

        private void SaveACBankAccountDepositEntity()
        {
            if (ValidationInput())
            {
                if (IsValid)
                {
                    try
                    {
                        ACBankAccountDepositEntity aCBankAccountDepositEntity = BuildACBankAccountDepositEntity();

                        Int64 result = -1;

                        if (aCBankAccountDepositEntity.IsNew)
                        {
                            result = FCCACBankAccountDeposit.GetFacadeCreate().Add(aCBankAccountDepositEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositEntity.FLD_NAME_BankAccountDepositID, aCBankAccountDepositEntity.BankAccountDepositID.ToString(), SQLMatchType.Equal);
                            result = FCCACBankAccountDeposit.GetFacadeCreate().Update(aCBankAccountDepositEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {  
                            PrepareInitialViewDepositeItem();
                            BindACBankAccountDepositItemList();
                            BuildTotalValueLabel();

                            if (aCBankAccountDepositEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bank Account Deposit Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bank Account Deposit Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (aCBankAccountDepositEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Bank Account Deposit Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Bank Account Deposit Information.", false);
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
                PrepareInitialViewDepositeItem();
            }
        }

        #endregion

        #region List View Event

        protected void lvACBankAccountDepositItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountDepositItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountDepositItemID);

            if (BankAccountDepositItemID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountDepositItemID = BankAccountDepositItemID;

                    PrepareEditViewDepositeItem();
                    pnlAdd.Visible = false;
                    pnlUpdate.Visible = true;
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;
                        

                        ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity = new ACBankAccountDepositItemEntity();
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositItemEntity.FLD_NAME_BankAccountDepositItemID, BankAccountDepositItemID.ToString(), SQLMatchType.Equal);
                        result = FCCACBankAccountDepositItem.GetFacadeCreate().Delete(aCBankAccountDepositItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            BindACBankAccountDepositItemList();
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

        #endregion List View Event

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACBankAccountDepositEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountDepositID = 0;
            _ACBankAccountDepositEntity = new ACBankAccountDepositEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
      
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            _BankAccountDepositItemID = 0;
            CurrentACBankAccountDepositItemEntity = new ACBankAccountDepositItem_DetailedEntity();
            txtMemoDetail.Text = String.Empty;
            txtAmount.Text = String.Empty;
            pnlUpdate.Visible = false;
            pnlAdd.Visible = true;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputAccounts())
            {
                ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity = FCCACBankAccountDepositItem.GetFacadeCreate().GetByID(_BankAccountDepositItemID);

                if (hdEmpID.Value != "0")
                {
                    aCBankAccountDepositItemEntity.AccountID = Int64.Parse(hdEmpID.Value);
                }

                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ItemID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.RequisitionID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                    }
                }


                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.WorkOrderID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.BillID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorUnitID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                    }
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    aCBankAccountDepositItemEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                aCBankAccountDepositItemEntity.Memo = txtMemoDetail.Text.Trim();

                aCBankAccountDepositItemEntity.BankAccountDepositID = OverviewBankAccountDepositID;

                #region Update Bank Account Deposit Item

                String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositItemEntity.FLD_NAME_BankAccountDepositItemID, _BankAccountDepositItemID.ToString(), SQLMatchType.Equal);

                FCCACBankAccountDepositItem.GetFacadeCreate().Update(aCBankAccountDepositItemEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                #endregion

                BindACBankAccountDepositItemList();

                txtAmount.Text = String.Empty;
                txtMemoDetail.Text = String.Empty;
                txtItemName.Text = String.Empty;
                hdEmpID.Value = "0";
                BuildTotalValueLabel();
            }
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInputAccounts())
            {
                ACBankAccountDepositItemEntity aCBankAccountDepositItemEntity = new ACBankAccountDepositItemEntity();

                if (hdEmpID.Value != "0")
                {
                    aCBankAccountDepositItemEntity.AccountID = Int64.Parse(hdEmpID.Value);
                }
                
                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ItemID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.RequisitionID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                    }
                }


                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.WorkOrderID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.BillID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorUnitID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                    }
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    aCBankAccountDepositItemEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                aCBankAccountDepositItemEntity.Memo = txtMemoDetail.Text.Trim();

                aCBankAccountDepositItemEntity.BankAccountDepositID = OverviewBankAccountDepositID;

                #region Save Bank Account Deposit Item

                FCCACBankAccountDepositItem.GetFacadeCreate().Add(aCBankAccountDepositItemEntity, DatabaseOperationType.Add, TransactionRequired.No);

                #endregion

                BindACBankAccountDepositItemList();

                txtAmount.Text = String.Empty;
                txtMemoDetail.Text = String.Empty;
                txtItemName.Text = String.Empty;
                hdEmpID.Value = "0";
                BuildTotalValueLabel();
            }
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;

            APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.BANK_DEPOSIT, OverviewBankAccountDepositID);

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

        protected void btnReject_Click(object sender, EventArgs e)
        {
            btnReject.Enabled = false;

            if (ddlRejectTo.SelectedValue == "0")
            {
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.BANK_DEPOSIT, OverviewBankAccountDepositID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.BANK_DEPOSIT, OverviewBankAccountDepositID, rejectToAPMemberFeedbackID);
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
                sb.Append("A Bank Account Deposit Request Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bank Account Deposit, Forwarded";

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

        #region DropDownList Event

        protected void ddlPaidFromID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildReferenceByPaidFrom();
        }

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
