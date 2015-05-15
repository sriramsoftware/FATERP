// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

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
    public partial class ACCPostPayableStatementDetailWithApprovalControl : BaseControl
    {       
        #region Properties

        public Int64 _PostPayableStatementDetailID
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

        public ACCPostPayableStatementDetailEntity _ACCPostPayableStatementDetailEntity
        {
            get
            {
                ACCPostPayableStatementDetailEntity entity = new ACCPostPayableStatementDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACCPostPayableStatementDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACCPostPayableStatementDetailEntity CurrentACCPostPayableStatementDetailEntity
        {
            get
            {
                if (_PostPayableStatementDetailID > 0)
                {
                    if (_ACCPostPayableStatementDetailEntity.PostPayableStatementDetailID != _PostPayableStatementDetailID)
                    {
                        _ACCPostPayableStatementDetailEntity = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetByID(_PostPayableStatementDetailID);
                    }
                }

                return _ACCPostPayableStatementDetailEntity;
            }
            set
            {
                _ACCPostPayableStatementDetailEntity = value;
            }
        }

        public Int64 ACCPostPayableStatementDetailID
        {
            get
            {
                Int64 accPostPayableStatementDetailID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID], out accPostPayableStatementDetailID);
                }

                return accPostPayableStatementDetailID;
            }
        }

        public Int64 ACCPostPayableStatementID
        {
            get
            {
                Int64 accPostPayableStatementID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_ID], out accPostPayableStatementID);
                }

                return accPostPayableStatementID;
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

        private void BuildDropDownList()
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
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.PAYABLE_STATEMENT, ACCPostPayableStatementID);
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

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            #region Payable Info

            //if (CurrentACCPostPayableStatementEntity != null && CurrentACCPostPayableStatementEntity.PostPayableStatementID > 0)
            //{
            //    ACCPostPayableStatementEntity ent = CurrentACCPostPayableStatementEntity;

            //    lblRef.Text = ent.Ref;
            //    lblCreateDate.Text = ent.CreateDate.ToStringDefault();
            //    lblStartDate.Text = ent.StartDate.ToStringDefault();
            //    lblEndDate.Text = ent.EndDate.ToStringDefault();
            //}

            #endregion

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            #endregion
        }

        private void PrepareEditView()
        {
          
        }

        private void BindList()
        {
            BindACCPostPayableStatementDetailList();
        }

        private void BindACCPostPayableStatementDetailList()
        {
        //    lvACCPostPayableStatementDetail.DataBind();
        }

        private ACCPostPayableStatementDetailEntity BuildACCPostPayableStatementDetailEntity()
        {
            ACCPostPayableStatementDetailEntity aCCPrePayableStatementDetailEntity = CurrentACCPostPayableStatementDetailEntity;
            IList<ListViewDataItem> list = lvACCPrePayableStatementDetail.Items;
            Int32 tempDataItemIndex = 0;
            foreach (ListViewDataItem lvdi in list)
            {
                DataKey currentDataKey = lvACCPrePayableStatementDetail.DataKeys[tempDataItemIndex++];
                Int64 _postPayableStatementDetailID = (Int64)currentDataKey["PostPayableStatementDetailID"];

                //ACCPostPayableStatementDetailEntity aCCPrePayableStatementDetailEntity = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetByID(_postPayableStatementDetailID);

                DropDownList ddlACCPayableApprovalStatusIDLV = (DropDownList)lvdi.FindControl("ddlACCPayableApprovalStatusIDLV");
                DropDownList ddlACCPayablePaymentStatusIDLV = (DropDownList)lvdi.FindControl("ddlACCPayablePaymentStatusIDLV");
                DropDownList ddlAccountPaybleStatementDetailCategoryIDLV = (DropDownList)lvdi.FindControl("ddlAccountPaybleStatementDetailCategoryIDLV");
                DropDownList ddlPayableClassificationIDLV = (DropDownList)lvdi.FindControl("ddlPayableClassificationIDLV");
                CheckBox chkPartyReconcileLV = (CheckBox)lvdi.FindControl("chkPartyReconcileLV");
                TextBox txtPayableAgainstWorkOrderLV = (TextBox)lvdi.FindControl("txtPayableAgainstWorkOrderLV");
                TextBox txtNetPayableConsideringBillAndSecurityLV = (TextBox)lvdi.FindControl("txtNetPayableConsideringBillAndSecurityLV");
                TextBox txtDueDateLV = (TextBox)lvdi.FindControl("txtDueDateLV");
                TextBox txtPlannedDateLV = (TextBox)lvdi.FindControl("txtPlannedDateLV");
                TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
               

                if (!txtPayableAgainstWorkOrderLV.Text.Trim().IsNullOrEmpty())
                {
                    aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = Decimal.Parse(txtPayableAgainstWorkOrderLV.Text.Trim());
                }
                else
                {
                    aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = null;
                }

                if (!txtNetPayableConsideringBillAndSecurityLV.Text.Trim().IsNullOrEmpty())
                {
                    aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = Decimal.Parse(txtNetPayableConsideringBillAndSecurityLV.Text.Trim());
                }
                else
                {
                    aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = null;
                }

                aCCPrePayableStatementDetailEntity.PartyReconcile = chkPartyReconcileLV.Checked;

                aCCPrePayableStatementDetailEntity.Remarks = txtRemarksLV.Text.Trim();

                aCCPrePayableStatementDetailEntity.CreateDate = System.DateTime.Now;

                if (txtDueDateLV.Text.Trim().IsNotNullOrEmpty())
                {
                    aCCPrePayableStatementDetailEntity.DueDate = MiscUtil.ParseToDateTime(txtDueDateLV.Text);
                }

                if (txtPlannedDateLV.Text.Trim().IsNotNullOrEmpty())
                {
                    aCCPrePayableStatementDetailEntity.PlannedDate = MiscUtil.ParseToDateTime(txtPlannedDateLV.Text);
                }
                else
                {
                    aCCPrePayableStatementDetailEntity.PlannedDate = null;
                }

                if (ddlACCPayablePaymentStatusIDLV.Items.Count > 0)
                {
                    if (ddlACCPayablePaymentStatusIDLV.SelectedValue == "0")
                    {
                    }
                    else
                    {
                        aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID = Int64.Parse(ddlACCPayablePaymentStatusIDLV.SelectedValue);
                    }
                }

                if (ddlACCPayableApprovalStatusIDLV.Items.Count > 0)
                {
                    if (ddlACCPayableApprovalStatusIDLV.SelectedValue == "0")
                    {
                    }
                    else
                    {
                        aCCPrePayableStatementDetailEntity.ACCPayableApprovalStatusID = Int64.Parse(ddlACCPayableApprovalStatusIDLV.SelectedValue);
                    }
                }

                if (ddlAccountPaybleStatementDetailCategoryIDLV.Items.Count > 0)
                {
                    if (ddlAccountPaybleStatementDetailCategoryIDLV.SelectedValue == "0")
                    {
                    }
                    else
                    {
                        aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID = Int64.Parse(ddlAccountPaybleStatementDetailCategoryIDLV.SelectedValue);
                    }
                }

                if (ddlPayableClassificationIDLV.Items.Count > 0)
                {
                    if (ddlPayableClassificationIDLV.SelectedValue == "0")
                    {
                    }
                    else
                    {
                        aCCPrePayableStatementDetailEntity.PayableClassificationID = Int64.Parse(ddlPayableClassificationIDLV.SelectedValue);
                    }
                }

                aCCPrePayableStatementDetailEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                aCCPrePayableStatementDetailEntity.IPAddress = MiscUtil.GetLocalIP();
                aCCPrePayableStatementDetailEntity.IsRemoved = false;
                aCCPrePayableStatementDetailEntity.IsLocked = false;
            }

            return aCCPrePayableStatementDetailEntity;
        }

        private void SaveACCPostPayableStatementDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity = BuildACCPostPayableStatementDetailEntity();//new ACCPostPayableStatementDetailEntity();//BuildACCPostPayableStatementDetailEntity();

                    Int64 result = -1;

                    if (aCCPostPayableStatementDetailEntity.IsNew)
                    {
                        result = FCCACCPostPayableStatementDetail.GetFacadeCreate().Add(aCCPostPayableStatementDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, aCCPostPayableStatementDetailEntity.PostPayableStatementDetailID.ToString(), SQLMatchType.Equal);
                        result = FCCACCPostPayableStatementDetail.GetFacadeCreate().Update(aCCPostPayableStatementDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PostPayableStatementDetailID = 0;
                        _ACCPostPayableStatementDetailEntity = new ACCPostPayableStatementDetailEntity();
                        PrepareInitialView();
                        BindACCPostPayableStatementDetailList();

                        if (aCCPostPayableStatementDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Payable Statement Detail Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Payable Statement Detail Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCCPostPayableStatementDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Payable Statement Detail Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Payable Statement Detail Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void SetPayableStatementDetailID()
        {
            try
            {
                IList<ListViewDataItem> list = lvACCPrePayableStatementDetail.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvACCPrePayableStatementDetail.DataKeys[tempDataItemIndex++];
                        Int64 _postPayableStatementDetailID = (Int64)currentDataKey["PostPayableStatementDetailID"];
                        _PostPayableStatementDetailID = _postPayableStatementDetailID;
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void UpdatePayableStatementDetail()
        {
            try
            {
                IList<ListViewDataItem> list = lvACCPrePayableStatementDetail.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvACCPrePayableStatementDetail.DataKeys[tempDataItemIndex++];
                        Int64 _postPayableStatementDetailID = (Int64)currentDataKey["PostPayableStatementDetailID"];

                        // Decimal workOrderAgreementAmount = 0, paidAmount = 0, tDSAmount = 0, securityMoney = 0;

                        ACCPostPayableStatementDetailEntity aCCPrePayableStatementDetailEntity = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetByID(_postPayableStatementDetailID);

                        DropDownList ddlACCPayableApprovalStatusIDLV = (DropDownList)lvdi.FindControl("ddlACCPayableApprovalStatusIDLV");
                        DropDownList ddlACCPayablePaymentStatusIDLV = (DropDownList)lvdi.FindControl("ddlACCPayablePaymentStatusIDLV");
                        DropDownList ddlAccountPaybleStatementDetailCategoryIDLV = (DropDownList)lvdi.FindControl("ddlAccountPaybleStatementDetailCategoryIDLV");
                        DropDownList ddlPayableClassificationIDLV = (DropDownList)lvdi.FindControl("ddlPayableClassificationIDLV");
                        CheckBox chkPartyReconcileLV = (CheckBox)lvdi.FindControl("chkPartyReconcileLV");
                        //L lblWorkOrderNoLV = (TextBox)lvdi.FindControl("lblWorkOrderNoLV");
                        //TextBox txtWorkOrderAmountLV = (TextBox)lvdi.FindControl("txtWorkOrderAmountLV");
                        //TextBox txtWorkOrderDateLV = (TextBox)lvdi.FindControl("txtWorkOrderDateLV");
                        //TextBox txtPaidAmountLV = (TextBox)lvdi.FindControl("txtPaidAmountLV");
                        //TextBox txtSecurityMoneyLV = (TextBox)lvdi.FindControl("txtSecurityMoneyLV");
                        TextBox txtPayableAgainstWorkOrderLV = (TextBox)lvdi.FindControl("txtPayableAgainstWorkOrderLV");
                        //TextBox txtTDSAmountLV = (TextBox)lvdi.FindControl("txtTDSAmountLV");
                        //TextBox txtApprovedBillAmountLV = (TextBox)lvdi.FindControl("txtApprovedBillAmountLV");
                        TextBox txtNetPayableConsideringBillAndSecurityLV = (TextBox)lvdi.FindControl("txtNetPayableConsideringBillAndSecurityLV");
                        //TextBox txtRequisitionNoLV = (TextBox)lvdi.FindControl("txtRequisitionNoLV");
                        //TextBox txtRequisitionDateLV = (TextBox)lvdi.FindControl("txtRequisitionDateLV");
                        // TextBox txtBillNoLV = (TextBox)lvdi.FindControl("txtBillNoLV");
                        //TextBox txtBillDateLV = (TextBox)lvdi.FindControl("txtBillDateLV");
                        //TextBox txtRefLV = (TextBox)lvdi.FindControl("txtRefLV");
                        //TextBox txtCreateDateLV = (TextBox)lvdi.FindControl("txtCreateDateLV");
                        TextBox txtDueDateLV = (TextBox)lvdi.FindControl("txtDueDateLV");
                        TextBox txtPlannedDateLV = (TextBox)lvdi.FindControl("txtPlannedDateLV");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                        //TextBox txtAdditionalRemarksLV = (TextBox)lvdi.FindControl("txtAdditionalRemarksLV");

                        //if (!lblWorkOrderNoLV.Text.Trim().IsNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.WorkOrderNo = lblWorkOrderNoLV.Text.Trim();
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.WorkOrderNo = null;
                        //}

                        //Decimal payableAgainstWO = (workOrderAgreementAmount - paidAmount - tDSAmount);
                        //Decimal netPayableConsideringBillSecurity = (payableAgainstWO - paidAmount - securityMoney - tDSAmount);

                        //if (!txtWorkOrderAmountLV.Text.Trim().IsNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.WorkOrderAmount = Decimal.Parse(txtWorkOrderAmountLV.Text.Trim());
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.WorkOrderAmount = null;
                        //}

                        //if (txtWorkOrderDateLV.Text.Trim().IsNotNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.WorkOrderDate = MiscUtil.ParseToDateTime(txtWorkOrderDateLV.Text);
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.WorkOrderDate = null;
                        //}

                        //if (!txtPaidAmountLV.Text.Trim().IsNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.PaidAmount = Decimal.Parse(txtPaidAmountLV.Text.Trim());
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.PaidAmount = null;
                        //}

                        //if (!txtSecurityMoneyLV.Text.Trim().IsNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.SecurityMoney = Decimal.Parse(txtSecurityMoneyLV.Text.Trim());
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.SecurityMoney = null;
                        //}

                        //if (!txtTDSAmountLV.Text.Trim().IsNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.TDSAmount = Decimal.Parse(txtTDSAmountLV.Text.Trim());
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.TDSAmount = null;
                        //}

                        if (!txtPayableAgainstWorkOrderLV.Text.Trim().IsNullOrEmpty())
                        {
                            aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = Decimal.Parse(txtPayableAgainstWorkOrderLV.Text.Trim());
                        }
                        else
                        {
                            aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = null;
                        }

                        //if (!txtApprovedBillAmountLV.Text.Trim().IsNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.ApprovedBillAmount = Decimal.Parse(txtApprovedBillAmountLV.Text.Trim());
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.ApprovedBillAmount = null;
                        //}

                        if (!txtNetPayableConsideringBillAndSecurityLV.Text.Trim().IsNullOrEmpty())
                        {
                            aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = Decimal.Parse(txtNetPayableConsideringBillAndSecurityLV.Text.Trim());
                        }
                        else
                        {
                            aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = null;
                        }

                        aCCPrePayableStatementDetailEntity.PartyReconcile = chkPartyReconcileLV.Checked;

                        //aCCPrePayableStatementDetailEntity.RequisitionNo = txtRequisitionNoLV.Text.Trim();
                        //if (txtRequisitionDateLV.Text.Trim().IsNotNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.RequisitionDate = MiscUtil.ParseToDateTime(txtRequisitionDateLV.Text);
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.RequisitionDate = null;
                        //}

                        //aCCPrePayableStatementDetailEntity.BillNo = txtBillNoLV.Text.Trim();
                        //if (txtBillDateLV.Text.Trim().IsNotNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.BillDate = MiscUtil.ParseToDateTime(txtBillDateLV.Text);
                        //}
                        //else
                        //{
                        //    aCCPrePayableStatementDetailEntity.BillDate = null;
                        //}

                        aCCPrePayableStatementDetailEntity.Remarks = txtRemarksLV.Text.Trim();
                        // aCCPrePayableStatementDetailEntity.Ref = txtRemarksLV.Text.Trim();

                        //if (txtCreateDateLV.Text.Trim().IsNotNullOrEmpty())
                        //{
                        //    aCCPrePayableStatementDetailEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDateLV.Text);
                        //}

                        aCCPrePayableStatementDetailEntity.CreateDate = System.DateTime.Now;

                        if (txtDueDateLV.Text.Trim().IsNotNullOrEmpty())
                        {
                            aCCPrePayableStatementDetailEntity.DueDate = MiscUtil.ParseToDateTime(txtDueDateLV.Text);
                        }

                        if (txtPlannedDateLV.Text.Trim().IsNotNullOrEmpty())
                        {
                            aCCPrePayableStatementDetailEntity.PlannedDate = MiscUtil.ParseToDateTime(txtPlannedDateLV.Text);
                        }
                        else
                        {
                            aCCPrePayableStatementDetailEntity.PlannedDate = null;
                        }

                        // aCCPrePayableStatementDetailEntity.AdditionalRemarks = txtAdditionalRemarksLV.Text.Trim();

                        if (ddlACCPayablePaymentStatusIDLV.Items.Count > 0)
                        {
                            if (ddlACCPayablePaymentStatusIDLV.SelectedValue == "0")
                            {
                            }
                            else
                            {
                                aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID = Int64.Parse(ddlACCPayablePaymentStatusIDLV.SelectedValue);
                            }
                        }

                        if (ddlACCPayableApprovalStatusIDLV.Items.Count > 0)
                        {
                            if (ddlACCPayableApprovalStatusIDLV.SelectedValue == "0")
                            {
                            }
                            else
                            {
                                aCCPrePayableStatementDetailEntity.ACCPayableApprovalStatusID = Int64.Parse(ddlACCPayableApprovalStatusIDLV.SelectedValue);
                            }
                        }

                        if (ddlAccountPaybleStatementDetailCategoryIDLV.Items.Count > 0)
                        {
                            if (ddlAccountPaybleStatementDetailCategoryIDLV.SelectedValue == "0")
                            {
                            }
                            else
                            {
                                aCCPrePayableStatementDetailEntity.AccountPaybleStatementDetailCategoryID = Int64.Parse(ddlAccountPaybleStatementDetailCategoryIDLV.SelectedValue);
                            }
                        }

                        if (ddlPayableClassificationIDLV.Items.Count > 0)
                        {
                            if (ddlPayableClassificationIDLV.SelectedValue == "0")
                            {
                            }
                            else
                            {
                                aCCPrePayableStatementDetailEntity.PayableClassificationID = Int64.Parse(ddlPayableClassificationIDLV.SelectedValue);
                            }
                        }

                        aCCPrePayableStatementDetailEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                        aCCPrePayableStatementDetailEntity.IPAddress = MiscUtil.GetLocalIP();
                        aCCPrePayableStatementDetailEntity.IsRemoved = false;
                        aCCPrePayableStatementDetailEntity.IsLocked = false;

                        String fe_member = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, _postPayableStatementDetailID.ToString(), SQLMatchType.Equal);
                        FCCACCPostPayableStatementDetail.GetFacadeCreate().Update(aCCPrePayableStatementDetailEntity, fe_member, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    PrepareInitialView();
                    MiscUtil.ShowMessage(lblMessage, "Accounts Payable Information has been saved successfully.", false);
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Save Accounts Payable Information.", true);
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
            }
        }

        #endregion

        #region List View Event

        protected void lvACCPrePayableStatementDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACCPostPayableStatementDetailEntity ent = (ACCPostPayableStatementDetailEntity)dataItem.DataItem;

                Label lblProjectNameLV = (Label)e.Item.FindControl("lblProjectNameLV");
                Label lblVendorCategoryNameLV = (Label)e.Item.FindControl("lblVendorCategoryNameLV");
                Label lblVendorCategoryIDLV = (Label)e.Item.FindControl("lblVendorCategoryIDLV");
                Label lblVendorIDLV = (Label)e.Item.FindControl("lblVendorIDLV");
                Label lblVendorNameLV = (Label)e.Item.FindControl("lblVendorNameLV");
                Label lblProjectIDLV = (Label)e.Item.FindControl("lblProjectIDLV");
                DropDownList ddlACCPayableApprovalStatusIDLV = (DropDownList)e.Item.FindControl("ddlACCPayableApprovalStatusIDLV");
                DropDownList ddlACCPayablePaymentStatusIDLV = (DropDownList)e.Item.FindControl("ddlACCPayablePaymentStatusIDLV");
                DropDownList ddlPayableClassificationIDLV = (DropDownList)e.Item.FindControl("ddlPayableClassificationIDLV");
                DropDownList ddlAccountPaybleStatementDetailCategoryIDLV = (DropDownList)e.Item.FindControl("ddlAccountPaybleStatementDetailCategoryIDLV");
                CheckBox chkPartyReconcileLV = (CheckBox)e.Item.FindControl("chkPartyReconcileLV");

                if (lblProjectIDLV != null)
                {
                    BDProjectEntity _bDProjectEntity = FCCBDProject.GetFacadeCreate().GetByID(Int64.Parse(lblProjectIDLV.Text));

                    if (_bDProjectEntity != null)
                    {
                        lblProjectNameLV.Text = _bDProjectEntity.ProjectName + " (" + _bDProjectEntity.ProjectCode + ")";
                    }
                }

                MiscUtil.PopulateMDACCPayablePaymentStatus(ddlACCPayablePaymentStatusIDLV, false);
                MiscUtil.PopulateMDACCPayableApprovalStatus(ddlACCPayableApprovalStatusIDLV, false);
                MiscUtil.PopulateMDPayableClassification(ddlPayableClassificationIDLV, false);
                MiscUtil.PopulateMDAccountPaybleStatementDetailCategory(ddlAccountPaybleStatementDetailCategoryIDLV, false);
                _PostPayableStatementDetailID = ent.PostPayableStatementDetailID;

                if (ent.PartyReconcile == true)
                {
                    chkPartyReconcileLV.Checked = true;
                }
                else
                {
                    chkPartyReconcileLV.Checked = false;
                }

                Int64 vendorID;
                Int64.TryParse(lblVendorIDLV.Text.ToString(), out vendorID);

                switch (lblVendorCategoryIDLV.Text)
                {
                    case MasterDataConstants.CM_Bill_VendorCategory.CONSULTANT:
                        CMConsultantEntity _cmConsultantEntity = FCCCMConsultant.GetFacadeCreate().GetByID(vendorID);
                        lblVendorCategoryNameLV.Text = "CONSULTANT";
                        lblVendorNameLV.Text = _cmConsultantEntity.Name;
                        break;
                    case MasterDataConstants.CM_Bill_VendorCategory.CONTRACTOR:
                        CMContractorEntity _cMContractorEntity = FCCCMContractor.GetFacadeCreate().GetByID(vendorID);
                        lblVendorCategoryNameLV.Text = "CONTRACTOR";
                        lblVendorNameLV.Text = _cMContractorEntity.Name;
                        break;
                    case MasterDataConstants.CM_Bill_VendorCategory.VENDOR:
                        PRMSupplierEntity _pRMSupplierEntity = FCCPRMSupplier.GetFacadeCreate().GetByID(vendorID);
                        lblVendorCategoryNameLV.Text = "VENDOR";
                        lblVendorNameLV.Text = _pRMSupplierEntity.SupplierName;
                        break;
                }

                if (ddlACCPayableApprovalStatusIDLV != null && ddlACCPayableApprovalStatusIDLV.Items.Count > 0)
                {
                    ddlACCPayableApprovalStatusIDLV.SelectedValue = ent.ACCPayableApprovalStatusID.ToString();
                }

                if (ddlACCPayablePaymentStatusIDLV != null && ddlACCPayablePaymentStatusIDLV.Items.Count > 0)
                {
                    ddlACCPayablePaymentStatusIDLV.SelectedValue = ent.ACCPayablePaymentStatusID.ToString();
                }

                if (ddlPayableClassificationIDLV != null && ddlPayableClassificationIDLV.Items.Count > 0)
                {
                    ddlPayableClassificationIDLV.SelectedValue = ent.PayableClassificationID.ToString();
                }

                if (ddlAccountPaybleStatementDetailCategoryIDLV != null && ddlAccountPaybleStatementDetailCategoryIDLV.Items.Count > 0)
                {
                    ddlAccountPaybleStatementDetailCategoryIDLV.SelectedValue = ent.AccountPaybleStatementDetailCategoryID.ToString();
                }

                ddlACCPayableApprovalStatusIDLV.Enabled = false;
            }
        }

        protected void lvACCPrePayableStatementDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

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

        #region ObjectDataSource Event

        protected void odsACCPrePayableStatementDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

            if (e.ExecutingSelectCount == false)
            {
                //UpdatePayableStatementDetail();
            }

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, ACCPostPayableStatementDetailID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;

        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACCPostPayableStatementDetailEntity();
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;

            SetPayableStatementDetailID();

            APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.PAYABLE_STATEMENT, _PostPayableStatementDetailID);

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
            //RedirectPageToPendingList();
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            btnReject.Enabled = false;

            SetPayableStatementDetailID();
            if (ddlRejectTo.SelectedValue == "0")
            {
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.PAYABLE_STATEMENT, _PostPayableStatementDetailID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.PAYABLE_STATEMENT, _PostPayableStatementDetailID, rejectToAPMemberFeedbackID);
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
         //   RedirectPageToRejectList();
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
                sb.Append("A Payable Request Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Payable, Forwarded";

                HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(aPForwardInfoEntity.EmployeeID);

                if (_hREmployeeEntity != null)
                {
                    String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                    MiscUtil.SendMail(sendToMail, Subject, MailBody);
                }

                #endregion

                //RedirectPageToForwardList();
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

        #endregion Event
    }
}
