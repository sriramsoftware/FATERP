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
using System.Web.UI.HtmlControls;
using System.Text;

namespace Bay.ERP.Web.UI
{
    public partial class ACBankAccountPaymentDetailsWithApprovalControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountPaymentID
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

        public ACBankAccountPaymentEntity _ACBankAccountPaymentEntity
        {
            get
            {
                ACBankAccountPaymentEntity entity = new ACBankAccountPaymentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountPaymentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountPayment_DetailedEntity CurrentACBankAccountPayment_DetailedEntity
        {
            get
            {
                IList<ACBankAccountPayment_DetailedEntity> lstBankAccountPayment_Detailed = new List<ACBankAccountPayment_DetailedEntity>();

                if (OverviewBankAccountPaymentID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentEntity.FLD_NAME_BankAccountPaymentID, OverviewBankAccountPaymentID.ToString(), SQLMatchType.Equal);

                    lstBankAccountPayment_Detailed = FCCACBankAccountPayment_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
                }

                return lstBankAccountPayment_Detailed[0];
            }
        }

        private ACBankAccountPaymentEntity CurrentACBankAccountPaymentEntity
        {
            get
            {
                if (OverviewBankAccountPaymentID > 0)
                { 
                   _ACBankAccountPaymentEntity = FCCACBankAccountPayment.GetFacadeCreate().GetByID(OverviewBankAccountPaymentID);
                }

                return _ACBankAccountPaymentEntity;
            }
            set
            {
                _ACBankAccountPaymentEntity = value;
            }
        }

        public IList<ACBankAccountPaymentItem_DetailedEntity> CurrentACBankAccountPaymentItemList
        {
            get
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountPaymentItem." + ACBankAccountPaymentItemEntity.FLD_NAME_BankAccountPaymentID, OverviewBankAccountPaymentID.ToString(), SQLMatchType.Equal);
                ViewState["vs_CurrentACBankAccountPaymentItem_DetailedList"] = FCCACBankAccountPaymentItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
                return (IList<ACBankAccountPaymentItem_DetailedEntity>)ViewState["vs_CurrentACBankAccountPaymentItem_DetailedList"];
            }
            set
            {
                ViewState["vs_CurrentACBankAccountPaymentItem_DetailedList"] = value;
            }
        }

        public Int64 _bankAccountPaymentID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["bankAccountPaymentID"] != null)
                {
                    Int64.TryParse(ViewState["bankAccountPaymentID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["bankAccountPaymentID"] = value;
            }
        }

        public Int64 _BankAccountPaymentItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["BankAccountPaymentItemID"] != null)
                {
                    Int64.TryParse(ViewState["BankAccountPaymentItemID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["BankAccountPaymentItemID"] = value;
            }
        }

        public ACBankAccountPaymentItem_DetailedEntity _ACBankAccountPaymentItemEntity
        {
            get
            {
                ACBankAccountPaymentItem_DetailedEntity entity = new ACBankAccountPaymentItem_DetailedEntity();

                if (ViewState["Current_ACBankAccountPaymentItemEntity"] != null)
                {
                    entity = (ACBankAccountPaymentItem_DetailedEntity)ViewState["Current_ACBankAccountPaymentItemEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["Current_ACBankAccountPaymentItemEntity"] = value;
            }
        }

        private ACBankAccountPaymentItem_DetailedEntity CurrentACBankAccountPaymentItemEntity
        {
            get
            {
                if (_BankAccountPaymentItemID > 0)
                {
                    //if (_ACBankAccountDepositItemEntity.BankAccountDepositItemID != _BankAccountDepositItemID)
                    //{   
                    _ACBankAccountPaymentItemEntity = (from s in CurrentACBankAccountPaymentItemList
                                                       where s.BankAccountPaymentItemID == _BankAccountPaymentItemID
                                                       select s).FirstOrDefault();
                    // }
                }

                return _ACBankAccountPaymentItemEntity;
            }
            set
            {
                _ACBankAccountPaymentItemEntity = value;
            }
        }


        public Int64 OverviewBankAccountPaymentID
        {
            get
            {
                Int64 bankAccountPaymentID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID], out bankAccountPaymentID);
                }

                return bankAccountPaymentID;
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

        private void IsBankAmountOrCashAmount()
        {
            //ACBankAccount_DetailedEntity ent = _
            if (CurrentACBankAccountPaymentEntity.BankAccountID == 3)
            {
                lblPayment.Text = "<h1>Cash Account Payment</h1>";
            }
            else
            {
                lblPayment.Text = "<h1>Bank Account Payment</h1>";
            }

        }

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
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.BANK_PAYMENT, OverviewBankAccountPaymentID);
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


        private Boolean ValidateInput()
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

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACMDPayTo(ddlPayToID, false);
            MiscUtil.PopulateACBankAccount(ddlBankAccountID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, true);

            BuildReferenceByPayTo();

            BuildDropDownAPList();
        }

        private void BuildDropDownListPaymentItem()
        { 
            MiscUtil.PopulateMDItem(ddlItemID, true);
            MiscUtil.PopulateBDProject(ddlProjectID, true);

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

        private void PrepareInitialViewPaymentItem()
        {
            BuildDropDownListPaymentItem();
            BindACBankAccountPaymentItemList();

            txtAmount.Text = String.Empty;
            txtMemoDetail.Text = String.Empty;
        }

        private void PrepareValidator()
        {
        }

        private void BuildTotalValueLabel()
        {
            Decimal totalValue = (from s in CurrentACBankAccountPaymentItemList
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

        private Boolean ValidationInput()
        {
            Boolean flag = true;

            if (CurrentACBankAccountPaymentItemList.Count <= 0)
            {
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Please Make at least one Bank Account Payment Information.", true);
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BuildTotalValueLabel();
            IsBankAmountOrCashAmount();

            txtPaymentDate.Text = String.Empty;
            txtReference.Text = String.Empty;
            txtName.Text = String.Empty;
            txtMemo.Text = String.Empty;
            lblPreparedBy.Text = CurrentACBankAccountPayment_DetailedEntity.MemberFullName.ToString();
            
            btnSubmit.Text = "Process Payment";
            //btnAddNew.Visible = false;

            CurrentACBankAccountPaymentItemList = new List<ACBankAccountPaymentItem_DetailedEntity>();


            hypReportLink.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BANK_ACCOUNT_PAYMENT_REPORT, UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID, OverviewBankAccountPaymentID.ToString()).ToString();
            hypReportLink.Target = "_blank";

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            #endregion
        }

        private void PrepareEditViewPaymentItem()
        {
            ACBankAccountPaymentItem_DetailedEntity aCBankAccountPaymentItemEntity = CurrentACBankAccountPaymentItemEntity;

            if (!aCBankAccountPaymentItemEntity.IsNew)
            {
                if (aCBankAccountPaymentItemEntity.AccountID > 0)
                {
                    txtItemName.Text = aCBankAccountPaymentItemEntity.AccountName.ToString();
                    hdEmpID.Value = aCBankAccountPaymentItemEntity.AccountID.ToString();
                }

                if (ddlItemID.Items.Count > 0 && aCBankAccountPaymentItemEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = aCBankAccountPaymentItemEntity.ItemID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.ItemID == null)
                {
                    ddlItemID.SelectedValue = "0";
                }

                if (ddlProjectID.Items.Count > 0 && aCBankAccountPaymentItemEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = aCBankAccountPaymentItemEntity.ProjectID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.ProjectID == null)
                {
                    ddlProjectID.SelectedValue = "0";
                }

                BuildProjectWiseDropdownInfo();

                if (ddlRequisitionID.Items.Count > 0 && aCBankAccountPaymentItemEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = aCBankAccountPaymentItemEntity.RequisitionID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.RequisitionID == null)
                {
                    ddlRequisitionID.SelectedValue = "0";
                }

                BuildRequisitionWiseInfo();

                if (ddlWorkOrderID.Items.Count > 0 && aCBankAccountPaymentItemEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = aCBankAccountPaymentItemEntity.WorkOrderID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.WorkOrderID == null)
                {
                    ddlWorkOrderID.SelectedValue = "0";
                }

                BuildWorkorderWiseInfo();

                if (ddlBillID.Items.Count > 0 && aCBankAccountPaymentItemEntity.BillID != null)
                {
                    ddlBillID.SelectedValue = aCBankAccountPaymentItemEntity.BillID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.BillID == null)
                {
                    ddlBillID.SelectedValue = "0";
                }

                if (ddlProjectFloorID.Items.Count > 0 && aCBankAccountPaymentItemEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = aCBankAccountPaymentItemEntity.ProjectFloorID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.ProjectFloorID == null)
                {
                    ddlProjectFloorID.SelectedValue = "0";
                }

                BuildFloorWiseInfo();

                if (ddlProjectFloorUnitID.Items.Count > 0 && aCBankAccountPaymentItemEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = aCBankAccountPaymentItemEntity.ProjectFloorUnitID.ToString();
                }
                else if (aCBankAccountPaymentItemEntity.ProjectFloorUnitID == null)
                {
                    ddlProjectFloorUnitID.SelectedValue = "0";
                }

                txtAmount.Text = aCBankAccountPaymentItemEntity.Amount.ToString();
                txtMemoDetail.Text = aCBankAccountPaymentItemEntity.Memo.ToString();
            }
        }

        private void BuildReferenceByPayTo()
        {
            if (ddlPayToID != null && ddlPayToID.Items.Count > 0)
            {
                lblReference.Text = ddlPayToID.SelectedItem.ToString() + " :";

                switch (Int64.Parse(ddlPayToID.SelectedValue))
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

        private void PrepareEditView()
        {
            ACBankAccountPaymentEntity aCBankAccountPaymentEntity = CurrentACBankAccountPaymentEntity;
            IsBankAmountOrCashAmount();

            if (!aCBankAccountPaymentEntity.IsNew)
            {
                txtPaymentDate.Text = aCBankAccountPaymentEntity.PaymentDate.ToStringDefault();
                if (ddlPayToID.Items.Count > 0 && aCBankAccountPaymentEntity.PayToID != null)
                {
                    ddlPayToID.SelectedValue = aCBankAccountPaymentEntity.PayToID.ToString();
                }

                BuildReferenceByPayTo();

                if (ddlReferenceID.Items.Count > 0 && aCBankAccountPaymentEntity.ReferenceID != null)
                {
                    ddlReferenceID.SelectedValue = aCBankAccountPaymentEntity.ReferenceID.ToString();
                }

                if (ddlBankAccountID.Items.Count > 0 && aCBankAccountPaymentEntity.BankAccountID != null)
                {
                    ddlBankAccountID.SelectedValue = aCBankAccountPaymentEntity.BankAccountID.ToString();
                }

                txtReference.Text = aCBankAccountPaymentEntity.Reference.ToString();
                txtName.Text = aCBankAccountPaymentEntity.Name.ToString();
                txtMemo.Text = aCBankAccountPaymentEntity.Memo.ToString();

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindACBankAccountPaymentList();
        }

        private void BindACBankAccountPaymentList()
        {
           
        }

        private void BindACBankAccountPaymentItemList()
        {   
            lvACBankAccountPaymentItem.DataSource = CurrentACBankAccountPaymentItemList;
            lvACBankAccountPaymentItem.DataBind();
        }

        private ACBankAccountPaymentEntity BuildACBankAccountPaymentEntity()
        {
            ACBankAccountPaymentEntity aCBankAccountPaymentEntity = CurrentACBankAccountPaymentEntity;

            if (txtPaymentDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCBankAccountPaymentEntity.PaymentDate = MiscUtil.ParseToDateTime(txtPaymentDate.Text);
            }

            if (ddlPayToID.Items.Count > 0)
            {
                if (ddlPayToID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountPaymentEntity.PayToID = Int64.Parse(ddlPayToID.SelectedValue);
                }
            }

            if (ddlBankAccountID.Items.Count > 0)
            {
                if (ddlBankAccountID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountPaymentEntity.BankAccountID = Int64.Parse(ddlBankAccountID.SelectedValue);
                }
            }

            aCBankAccountPaymentEntity.BankAccountPaymentApprovalStatusID = MasterDataConstants.ACMDBankAccountPaymentApprovalStatus.INITIATED;
            aCBankAccountPaymentEntity.Reference = txtReference.Text.Trim();
            aCBankAccountPaymentEntity.Name = txtName.Text.Trim();
            aCBankAccountPaymentEntity.Memo = txtMemo.Text.Trim();

            return aCBankAccountPaymentEntity;
        }

        private void SaveACBankAccountPaymentEntity()
        {
            if (ValidationInput())
            {
                if (IsValid)
                {
                    try
                    {
                        ACBankAccountPaymentEntity aCBankAccountPaymentEntity = BuildACBankAccountPaymentEntity();

                        Int64 result = -1;

                        if (aCBankAccountPaymentEntity.IsNew)
                        {
                            result = FCCACBankAccountPayment.GetFacadeCreate().Add(aCBankAccountPaymentEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentEntity.FLD_NAME_BankAccountPaymentID, aCBankAccountPaymentEntity.BankAccountPaymentID.ToString(), SQLMatchType.Equal);
                            result = FCCACBankAccountPayment.GetFacadeCreate().Update(aCBankAccountPaymentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {
 
                            BindACBankAccountPaymentList();
                            PrepareInitialViewPaymentItem();
                            CurrentACBankAccountPaymentItemList = new List<ACBankAccountPaymentItem_DetailedEntity>();
                            BindACBankAccountPaymentItemList();
                            BuildTotalValueLabel();

                            if (aCBankAccountPaymentEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bank Account Payment Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bank Account Payment Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (aCBankAccountPaymentEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Bank Account Payment Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Bank Account Payment Information.", false);
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

        private void ClearAll()
        {
            txtAmount.Text = String.Empty;
            txtMemoDetail.Text = String.Empty;
            txtItemName.Text = String.Empty;

            //if (ddlProjectID.Items.Count > 0)
            //{
            //    ddlProjectID.SelectedValue = "0";
            //    BuildProjectWiseDropdownInfo();
            //}

            //if (ddlItemID.Items.Count > 0)
            //{
            //    ddlItemID.SelectedValue = "0";
            //}

            hdEmpID.Value = "0";
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
            IsBankAmountOrCashAmount();
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
                PrepareInitialViewPaymentItem();
            }
        }

        #endregion

        #region List View Event

        protected void lvACBankAccountPaymentItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountPaymentitemID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountPaymentitemID);

            if (BankAccountPaymentitemID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountPaymentItemID = BankAccountPaymentitemID;

                    PrepareEditViewPaymentItem();

                    pnlAdd.Visible = false;
                    pnlUpdate.Visible = true;
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity = new ACBankAccountPaymentItemEntity();
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentItemEntity.FLD_NAME_BankAccountPaymentItemID, BankAccountPaymentitemID.ToString(), SQLMatchType.Equal);
                        result = FCCACBankAccountPaymentItem.GetFacadeCreate().Delete(aCBankAccountPaymentItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            BindACBankAccountPaymentItemList();
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
            SaveACBankAccountPaymentEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountPaymentID = 0;
            _ACBankAccountPaymentEntity = new ACBankAccountPaymentEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            _BankAccountPaymentID = 0;
            CurrentACBankAccountPaymentItemEntity = new ACBankAccountPaymentItem_DetailedEntity();
            txtMemoDetail.Text = String.Empty;
            txtAmount.Text = String.Empty;
            pnlUpdate.Visible = false;
            pnlAdd.Visible = true;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Implement Update Code Here.
                ACBankAccountPaymentItemEntity aCBankAccountPaymentItemEntity = FCCACBankAccountPaymentItem.GetFacadeCreate().GetByID(_BankAccountPaymentItemID);

                if (hdEmpID.Value != "0")
                {
                    aCBankAccountPaymentItemEntity.AccountID = Int64.Parse(hdEmpID.Value);
                }

                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.ItemID = null;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.RequisitionID = null;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                    }
                }

                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.WorkOrderID = null;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.BillID = null;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.ProjectID = null;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.ProjectFloorID = null;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        aCBankAccountPaymentItemEntity.ProjectFloorUnitID = null;
                    }
                    else
                    {
                        aCBankAccountPaymentItemEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                    }
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    aCBankAccountPaymentItemEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                aCBankAccountPaymentItemEntity.Memo = txtMemoDetail.Text.Trim();

                aCBankAccountPaymentItemEntity.BankAccountPaymentID = OverviewBankAccountPaymentID;

                #region Update Bank Account Payment Item

                String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountPaymentItemEntity.FLD_NAME_BankAccountPaymentItemID, _BankAccountPaymentItemID.ToString(), SQLMatchType.Equal);
                FCCACBankAccountPaymentItem.GetFacadeCreate().Update(aCBankAccountPaymentItemEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                #endregion

                BindACBankAccountPaymentItemList();

                ClearAll();

                pnlAdd.Visible = true;
                pnlUpdate.Visible = false;
                BuildTotalValueLabel();
            }
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;

            APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.BANK_PAYMENT, OverviewBankAccountPaymentID);

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
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.BANK_PAYMENT, OverviewBankAccountPaymentID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.BANK_PAYMENT, OverviewBankAccountPaymentID, rejectToAPMemberFeedbackID);
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
                sb.Append("A Bank Account Payment Request Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Bank Account Payment, Forwarded";

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

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ACBankAccountPaymentItemEntity acBankAccountPaymentItemEntity = new ACBankAccountPaymentItemEntity();

                if (hdEmpID.Value != "0")
                {
                    acBankAccountPaymentItemEntity.AccountID = Int64.Parse(hdEmpID.Value);
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    acBankAccountPaymentItemEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                acBankAccountPaymentItemEntity.Memo = txtMemoDetail.Text.Trim();
                acBankAccountPaymentItemEntity.BankAccountPaymentID = OverviewBankAccountPaymentID;

                FCCACBankAccountPaymentItem.GetFacadeCreate().Add(acBankAccountPaymentItemEntity, DatabaseOperationType.Add, TransactionRequired.No);

                BindACBankAccountPaymentItemList();

                ClearAll();

                BuildTotalValueLabel();
            }
        }

        #endregion

        #region DropDownList Event

        protected void ddlPayToID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildReferenceByPayTo();
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
