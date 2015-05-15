// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




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

namespace Bay.ERP.Web.UI
{
    public partial class ACCPrePayableStatementDetailControl : BaseControl
    {       
        #region Properties

        public Int64 ACCPrePayableStatementID
        {
            get
            {
                Int64 accPrePayableStatementID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID], out accPrePayableStatementID);
                }

                return accPrePayableStatementID;
            }
        }

        public ACCPrePayableStatementEntity _ACCPrePayableStatementEntity
        {
            get
            {
                ACCPrePayableStatementEntity entity = new ACCPrePayableStatementEntity();

                if (ViewState["CurrentACCPrePayableStatementEntity"] != null)
                {
                    entity = (ACCPrePayableStatementEntity)ViewState["CurrentACCPrePayableStatementEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentACCPrePayableStatementEntity"] = value;
            }
        }

        private ACCPrePayableStatementEntity CurrentACCPrePayableStatementEntity
        {
            get
            {
                if (ACCPrePayableStatementID > 0)
                {
                    if (_ACCPrePayableStatementEntity.PrePayableStatementID != ACCPrePayableStatementID)
                    {
                        _ACCPrePayableStatementEntity = FCCACCPrePayableStatement.GetFacadeCreate().GetByID(ACCPrePayableStatementID);
                    }
                }

                return _ACCPrePayableStatementEntity;
            }
            set
            {
                _ACCPrePayableStatementEntity = value;
            }
        }

        public Int64 _PrePayableStatementDetailID
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

        #endregion

        #region Methods

        #region Bill

        public void UpdateBillApprovalStatus(Int64 billID, Int64 billApprovalStatus)
        {
            CMBillEntity ent = FCCCMBill.GetFacadeCreate().GetByID(billID);

            ent.BillApprovalStatusID = billApprovalStatus;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillID, billID.ToString(), SQLMatchType.Equal);

            FCCCMBill.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
        }

        #endregion

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACCPrePayableStatementDistinct(ddlACCPrePayableStatementID, false);
        }

        private void CalculatePayableStatementDetailID()
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
                        Int64 _prePayableStatementDetailID = (Int64)currentDataKey["PrePayableStatementDetailID"];
                        _PrePayableStatementDetailID = _prePayableStatementDetailID;

                        Label lblApprovedBillAmountLV = (Label)lvdi.FindControl("lblApprovedBillAmountLV");
                        Label lblPaidAmountLV = (Label)lvdi.FindControl("lblPaidAmountLV");
                        Label lblSecurityMoneyLV = (Label)lvdi.FindControl("lblSecurityMoneyLV");
                        Label lblWorkOrderAmountLV = (Label)lvdi.FindControl("lblWorkOrderAmountLV");
                        TextBox txtPayableAgainstWorkOrderLV = (TextBox)lvdi.FindControl("txtPayableAgainstWorkOrderLV");
                        TextBox txtTDSAmountLV = (TextBox)lvdi.FindControl("txtTDSAmountLV");
                        TextBox txtNetPayableConsideringBillAndSecurityLV = (TextBox)lvdi.FindControl("txtNetPayableConsideringBillAndSecurityLV");

                        Decimal tdsAmount, securityMoney, appBillAmount, paidAmount, netPayableConsideringBillAndSecurity,payableAgaintWO,woAmount;

                        Decimal.TryParse(txtTDSAmountLV.Text.ToString(), out tdsAmount);
                        Decimal.TryParse(lblWorkOrderAmountLV.Text.ToString(), out woAmount);
                        Decimal.TryParse(lblSecurityMoneyLV.Text.ToString(), out securityMoney);
                        Decimal.TryParse(lblPaidAmountLV.Text.ToString(), out paidAmount);
                        Decimal.TryParse(lblApprovedBillAmountLV.Text.ToString(), out appBillAmount);

                        payableAgaintWO = woAmount - paidAmount - securityMoney - tdsAmount;
                        netPayableConsideringBillAndSecurity = appBillAmount - paidAmount - securityMoney - tdsAmount;

                        txtPayableAgainstWorkOrderLV.Text = payableAgaintWO.ToString();
                        txtNetPayableConsideringBillAndSecurityLV.Text = netPayableConsideringBillAndSecurity.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void DeductPayableStatementDetailID()
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
                        Int64 _prePayableStatementDetailID = (Int64)currentDataKey["PrePayableStatementDetailID"];
                        _PrePayableStatementDetailID = _prePayableStatementDetailID;
                        
                        TextBox txtPayableAgainstWorkOrderLV = (TextBox)lvdi.FindControl("txtPayableAgainstWorkOrderLV");
                        TextBox txtTDSAmountLV = (TextBox)lvdi.FindControl("txtTDSAmountLV");
                        TextBox txtNetPayableConsideringBillAndSecurityLV = (TextBox)lvdi.FindControl("txtNetPayableConsideringBillAndSecurityLV");

                        Decimal tdsAmount, netPayableConsideringBillAndSecurity, payableAgaintWO;

                        Decimal.TryParse(txtNetPayableConsideringBillAndSecurityLV.Text.ToString(), out netPayableConsideringBillAndSecurity);
                        Decimal.TryParse(txtPayableAgainstWorkOrderLV.Text.ToString(), out payableAgaintWO);

                        Decimal.TryParse(txtTDSAmountLV.Text.ToString(), out tdsAmount);

                        payableAgaintWO = payableAgaintWO-tdsAmount;
                        netPayableConsideringBillAndSecurity = netPayableConsideringBillAndSecurity - tdsAmount;

                        txtPayableAgainstWorkOrderLV.Text = payableAgaintWO.ToString();
                        txtNetPayableConsideringBillAndSecurityLV.Text = netPayableConsideringBillAndSecurity.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

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
                        Int64 _prePayableStatementDetailID = (Int64)currentDataKey["PrePayableStatementDetailID"];
                        _PrePayableStatementDetailID = _prePayableStatementDetailID;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            if (CurrentACCPrePayableStatementEntity != null && CurrentACCPrePayableStatementEntity.PrePayableStatementID > 0)
            {
                ACCPrePayableStatementEntity ent = CurrentACCPrePayableStatementEntity;

                lblRef.Text = ent.Ref;
                lblCreateDate.Text = ent.CreateDate.ToStringDefault();
                lblStartDate.Text = ent.StartDate.ToStringDefault();
                lblEndDate.Text = ent.EndDate.ToStringDefault();
            }

            hypPayableFromBill.NavigateUrl = UrlHelper.BuildSecureUrl("~/ACC/ACCPrePayableStatementFromBill.aspx", string.Empty, UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID, ACCPrePayableStatementID.ToString()).ToString();
            hypPayableFromBill.Target = "_blank";

            hypEditSummary.NavigateUrl = UrlHelper.BuildSecureUrl("~/ACC/ACCPrePayableStatement.aspx", string.Empty, UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID, ACCPrePayableStatementID.ToString()).ToString();

            #region Enable Disable Operation Panel 

            if (ACCPrePayableStatementID > 0)
            {
                if (ACCPrePayableStatementID == MasterDataConstants.ACCPayableDefault.ACC_PRE_PAYABLE_STATEMENT_DEFAULT)
                {
                    pnlButtonOperation.Visible = false;
                    pnlMoveToPayableStatement.Visible = true;
                }
                else
                {
                    pnlMoveToPayableStatement.Visible = false;
                    pnlButtonOperation.Visible = true;
                }
            }

            #endregion
        }

        private void BindList()
        {
            BindACCPrePayableStatementDetailList();
        }

        private void BindACCPrePayableStatementDetailList()
        {
            lvACCPrePayableStatementDetail.DataBind();
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
                        Int64 _prePayableStatementDetailID = (Int64)currentDataKey["PrePayableStatementDetailID"];

                        // Decimal workOrderAgreementAmount = 0, paidAmount = 0, tDSAmount = 0, securityMoney = 0;

                        CheckBox chbxIsLockedLV = (CheckBox)lvdi.FindControl("chbxIsLockedLV");

                        if (chbxIsLockedLV.Text == "No")
                        {

                            ACCPrePayableStatementDetailEntity aCCPrePayableStatementDetailEntity = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetByID(_prePayableStatementDetailID);

                            DropDownList ddlACCPayableApprovalStatusIDLV = (DropDownList)lvdi.FindControl("ddlACCPayableApprovalStatusIDLV");
                            DropDownList ddlACCPayablePaymentStatusIDLV = (DropDownList)lvdi.FindControl("ddlACCPayablePaymentStatusIDLV");
                            DropDownList ddlAccountPaybleStatementDetailCategoryIDLV = (DropDownList)lvdi.FindControl("ddlAccountPaybleStatementDetailCategoryIDLV");
                            DropDownList ddlPayableClassificationIDLV = (DropDownList)lvdi.FindControl("ddlPayableClassificationIDLV");
                            DropDownList ddlAPPanelIDLV = (DropDownList)lvdi.FindControl("ddlAPPanelIDLV");
                            CheckBox chkPartyReconcileLV = (CheckBox)lvdi.FindControl("chkPartyReconcileLV");

                            //L lblWorkOrderNoLV = (TextBox)lvdi.FindControl("lblWorkOrderNoLV");
                            //TextBox txtWorkOrderAmountLV = (TextBox)lvdi.FindControl("txtWorkOrderAmountLV");
                            //TextBox txtWorkOrderDateLV = (TextBox)lvdi.FindControl("txtWorkOrderDateLV");
                            //TextBox txtPaidAmountLV = (TextBox)lvdi.FindControl("txtPaidAmountLV");
                            //TextBox txtSecurityMoneyLV = (TextBox)lvdi.FindControl("txtSecurityMoneyLV");
                            TextBox txtPayableAgainstWorkOrderLV = (TextBox)lvdi.FindControl("txtPayableAgainstWorkOrderLV");
                            TextBox txtTDSAmountLV = (TextBox)lvdi.FindControl("txtTDSAmountLV");
                            //TextBox txtApprovedBillAmountLV = (TextBox)lvdi.FindControl("txtApprovedBillAmountLV");
                            TextBox txtNetPayableConsideringBillAndSecurityLV = (TextBox)lvdi.FindControl("txtNetPayableConsideringBillAndSecurityLV");
                            //TextBox txtRequisitionNoLV = (TextBox)lvdi.FindControl("txtRequisitionNoLV");
                            //TextBox txtRequisitionDateLV = (TextBox)lvdi.FindControl("txtRequisitionDateLV");
                            // TextBox txtBillNoLV = (TextBox)lvdi.FindControl("txtBillNoLV");
                            //TextBox txtBillDateLV = (TextBox)lvdi.FindControl("txtBillDateLV");
                            TextBox txtRefLV = (TextBox)lvdi.FindControl("txtRefLV");
                            //TextBox txtCreateDateLV = (TextBox)lvdi.FindControl("txtCreateDateLV");
                            TextBox txtDueDateLV = (TextBox)lvdi.FindControl("txtDueDateLV");
                            TextBox txtPlannedDateLV = (TextBox)lvdi.FindControl("txtPlannedDateLV");
                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");

                            if (ddlACCPayablePaymentStatusIDLV != null && ddlACCPayablePaymentStatusIDLV.Items.Count > 0)
                            {
                                if (Int64.Parse(ddlACCPayablePaymentStatusIDLV.SelectedValue) == MasterDataConstants.MDACCPayablePaymentStatus.CURRENT)
                                {
                                    txtDueDateLV.Text = CurrentACCPrePayableStatementEntity.StartDate.ToStringDefault();
                                }
                            }
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

                            if (!txtTDSAmountLV.Text.Trim().IsNullOrEmpty())
                            {
                                aCCPrePayableStatementDetailEntity.TDSAmount = Decimal.Parse(txtTDSAmountLV.Text.Trim());
                            }
                            else
                            {
                                aCCPrePayableStatementDetailEntity.TDSAmount = null;
                            }

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

                            Decimal netPayableAmount = 0, gPartialPayment = 0;
                            Decimal.TryParse(txtNetPayableConsideringBillAndSecurityLV.Text.Trim(), out netPayableAmount);

                            if (ddlACCPayablePaymentStatusIDLV.Items.Count > 0)
                            {
                                if (ddlACCPayablePaymentStatusIDLV.SelectedValue == MasterDataConstants.MDACCPayablePaymentStatus.PARTIAL_PAYMENT.ToString() && txtRefLV.Text.IsNotNullOrEmpty())
                                {
                                    aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID = MasterDataConstants.MDACCPayablePaymentStatus.PARTIAL_PAYMENT;
                                    Decimal partialPayableAmount;

                                    Decimal.TryParse(txtRefLV.Text.Trim(), out partialPayableAmount);
                                    gPartialPayment = netPayableAmount - partialPayableAmount;
                                    netPayableAmount = partialPayableAmount;
                                }

                                else
                                {
                                    aCCPrePayableStatementDetailEntity.ACCPayablePaymentStatusID = Int64.Parse(ddlACCPayablePaymentStatusIDLV.SelectedValue);
                                }
                            }

                            if (!txtNetPayableConsideringBillAndSecurityLV.Text.Trim().IsNullOrEmpty())
                            {
                                aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = netPayableAmount;
                            }
                            else
                            {
                                aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = null;
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

                            if (ddlAPPanelIDLV.Items.Count > 0)
                            {
                                if (ddlAPPanelIDLV.SelectedValue == "0")
                                {
                                }
                                else
                                {
                                    aCCPrePayableStatementDetailEntity.APPanelID = Int64.Parse(ddlAPPanelIDLV.SelectedValue);
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

                            String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
                            IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                            if (lstEmployee != null && lstEmployee.Count > 0)
                            {
                                aCCPrePayableStatementDetailEntity.CreateByEmployeeID = lstEmployee[0].EmployeeID;
                            }

                            aCCPrePayableStatementDetailEntity.IPAddress = MiscUtil.GetLocalIP();
                            aCCPrePayableStatementDetailEntity.IsRemoved = false;

                            if (chbxIsLockedLV.Text == "Yes")
                            {
                                aCCPrePayableStatementDetailEntity.IsLocked = true;
                            }

                            else if (chbxIsLockedLV.Text == "No")
                            {
                                aCCPrePayableStatementDetailEntity.IsLocked = false;
                            }

                            String fe_member = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementDetailEntity.FLD_NAME_PrePayableStatementDetailID, _prePayableStatementDetailID.ToString(), SQLMatchType.Equal);
                            FCCACCPrePayableStatementDetail.GetFacadeCreate().Update(aCCPrePayableStatementDetailEntity, fe_member, DatabaseOperationType.Update, TransactionRequired.No);

                            if (ddlACCPayablePaymentStatusIDLV.SelectedValue == MasterDataConstants.MDACCPayablePaymentStatus.PARTIAL_PAYMENT.ToString())
                            {
                                if (txtRefLV.Text.IsNotNullOrEmpty())
                                {
                                    if (gPartialPayment > 0)
                                    {
                                        ACCPrePayableStatementDetailEntity partialACCPrePayableStatementDetailEntity = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetByID(_prePayableStatementDetailID);
                                        partialACCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = gPartialPayment;
                                        partialACCPrePayableStatementDetailEntity.PrePayableStatementID = MasterDataConstants.ACCPayableDefault.ACC_PRE_PAYABLE_STATEMENT_DEFAULT;
                                        //partialACCPrePayableStatementDetailEntity.DueDate = MiscUtil.ParseToDateTime(CurrentACCPrePayableStatementEntity.EndDate.AddDays(2).ToString());
                                        FCCACCPrePayableStatementDetail.GetFacadeCreate().Add(partialACCPrePayableStatementDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                    }
                                }
                            }

                            MiscUtil.ShowMessage(lblMessage, "Accounts Payable Information has been saved successfully.", false);
                            BindList();
                        }

                        //  PrepareInitialView();
                    }
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

            btnGeneratePayable.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnGeneratePayable, "").ToString());

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
            }
        }

        #endregion

        #region List View Event

        protected void lvACCPrePayableStatementDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACCPrePayableStatementDetailEntity ent = (ACCPrePayableStatementDetailEntity)dataItem.DataItem;

                CheckBox chbxIsLockedLV = (CheckBox)e.Item.FindControl("chbxIsLockedLV");

              
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
                    DropDownList ddlAPPanelIDLV = (DropDownList)e.Item.FindControl("ddlAPPanelIDLV");
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
                    MiscUtil.PopulateStartWithAPPanel(ddlAPPanelIDLV, false, MasterDataConstants.APPanelStartWith.PAYABLE);

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

                    if (ddlAPPanelIDLV != null && ddlAPPanelIDLV.Items.Count > 0)
                    {
                        ddlAPPanelIDLV.SelectedValue = ent.APPanelID.ToString();
                    }

                    ddlACCPayableApprovalStatusIDLV.Enabled = false;

                    if (chbxIsLockedLV.Text == "No")
                    {
                        lblFormLock.Visible = false;
                        pnlButtonOperation.Enabled = true;
                    }

                    else if (chbxIsLockedLV.Text == "Yes")
                    {
                        lblFormLock.Visible = true;
                        pnlButtonOperation.Enabled = false;
                    }
            }
           
        }

        protected void lvACCPrePayableStatementDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACCPrePayableStatementDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            if (e.ExecutingSelectCount == false)
            {
                UpdatePayableStatementDetail();
            }

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementEntity.FLD_NAME_PrePayableStatementID, ACCPrePayableStatementID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePayableStatementDetail();
        }

        protected void btnGeneratePayable_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                try
                {
                    Int64 result = 0;

                    Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                    if (employeeID > 0)
                    {
                        IList<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity> list = FCCACCPrePayableStatementtoACCPostPayableStatementMigrate_Custom.GetFacadeCreate().GetIL(ACCPrePayableStatementID, employeeID);

                        if (list != null && list.Count > 0)
                        {
                            if (list[0].POSTPAYABLESTATEMENTID != null)
                            {
                                result = list[0].POSTPAYABLESTATEMENTID.Value;
                            }
                        }
                    }

                    if (result > 0)
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementDetailEntity.FLD_NAME_PrePayableStatementID, ACCPrePayableStatementID.ToString(), SQLMatchType.Equal);
                        IList<ACCPrePayableStatementDetailEntity> lstPrePayableStatementDetail = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

                        if (lstPrePayableStatementDetail != null && lstPrePayableStatementDetail.Count > 0)
                        {
                            foreach (ACCPrePayableStatementDetailEntity ent in lstPrePayableStatementDetail)
                            {
                                if (ent.BillID > 0)
                                {
                                    UpdateBillApprovalStatus(Int64.Parse(ent.BillID.ToString()), MasterDataConstants.BillApprovalStatus.APPROVED_AND_IN_PAYABLE);
                                }
                            }
                        }

                        String fe_result = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementID, result.ToString(), SQLMatchType.Equal);
                        IList<ACCPostPayableStatementDetailEntity> lstPostPayableDetail = FCCACCPostPayableStatementDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_result, DatabaseOperationType.LoadWithFilterExpression);
                        
                        if (lstPostPayableDetail != null && lstPostPayableDetail.Count > 0)
                        {
                            foreach (ACCPostPayableStatementDetailEntity entPostPayableStatementDetailEntity in lstPostPayableDetail)
                            {
                                #region Approval Process

                                if (entPostPayableStatementDetailEntity.APPanelID != null && entPostPayableStatementDetailEntity.APPanelID > 0)
                                {

                                    Boolean apResult = APRobot.CreateApprovalProcessForNewPayableStatement(entPostPayableStatementDetailEntity.PostPayableStatementDetailID, Int64.Parse(entPostPayableStatementDetailEntity.APPanelID.ToString()));

                                    if (apResult == true)
                                    {
                                        MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                                    }
                                    else
                                    {
                                        MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                                    }
                                   
                                }

                                #endregion
                                
                            }
                        }

                       
                       String NavigationUrl = UrlHelper.BuildSecureUrl("~/ACC/ACCPrePayableStatement.aspx", string.Empty).ToString();
                       Response.Redirect(NavigationUrl);
                    }
                    else
                    {
                     //   MiscUtil.ShowMessage(lblMessage, "Payable Statement Post Failed.", UIConstants.MessageType.RED);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, UIConstants.MessageType.RED);
                }
            }
        }

        protected void btnRemoveFromPayable_Click(object sender, EventArgs e)
        {
            SetPayableStatementDetailID();
            ACCPrePayableStatementDetailEntity ent = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetByID(_PrePayableStatementDetailID);

            if (ent != null && ent.PrePayableStatementDetailID>0)
            {
                ent.ACCPayablePaymentStatusID =MasterDataConstants.MDACCPayablePaymentStatus.DELETED;
                ent.PrePayableStatementID = MasterDataConstants.ACCPayableDefault.ACC_PRE_PAYABLE_STATEMENT_DEFAULT;
                try
                {
                    IList<ListViewDataItem> list = lvACCPrePayableStatementDetail.Items;

                    if (list != null && list.Count > 0)
                    {
                        Int32 tempDataItemIndex = 0;

                        foreach (ListViewDataItem lvdi in list)
                        {
                            DataKey currentDataKey = lvACCPrePayableStatementDetail.DataKeys[tempDataItemIndex++];
                            Int64 _postPayableStatementDetailID = (Int64)currentDataKey["PrePayableStatementDetailID"];
                            _PrePayableStatementDetailID = _postPayableStatementDetailID;
                            DropDownList ddlACCPayablePaymentStatusIDLV = (DropDownList)lvdi.FindControl("ddlACCPayablePaymentStatusIDLV");
                            ddlACCPayablePaymentStatusIDLV.SelectedValue = MasterDataConstants.MDACCPayablePaymentStatus.DELETED.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {

                }

                String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementDetailEntity.FLD_NAME_PrePayableStatementDetailID, ent.PrePayableStatementDetailID.ToString(), SQLMatchType.Equal);
                FCCACCPrePayableStatementDetail.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);

                BindList();
            }
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.PRE_PAYABLE_REPORT, UrlConstants.OVERVIEW_PRE_PAYABLE_STATEMENT_ID, ACCPrePayableStatementID.ToString()).ToString();
            Response.Redirect(navUrl);
        }

        protected void btnMoveToPaybale_Click(object sender, EventArgs e)
        {
            SetPayableStatementDetailID();
            ACCPrePayableStatementDetailEntity ent = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetByID(_PrePayableStatementDetailID);

            if (ent != null && ent.PrePayableStatementDetailID > 0)
            {
                if (ddlACCPrePayableStatementID != null && ddlACCPrePayableStatementID.Items.Count > 0)
                {
                    ent.PrePayableStatementID = Int64.Parse(ddlACCPrePayableStatementID.SelectedValue);
                }

                String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPrePayableStatementDetailEntity.FLD_NAME_PrePayableStatementDetailID, ent.PrePayableStatementDetailID.ToString(), SQLMatchType.Equal);
                FCCACCPrePayableStatementDetail.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);

                BindList();
            }
        }

        protected void btnDeduct_Click(object sender, EventArgs e)
        {
            DeductPayableStatementDetailID();
        }

        protected void btnCalculate_OnClick(object sender, EventArgs e)
        {
            CalculatePayableStatementDetailID();
        }
        protected void btnSynWO_Click(object sender, EventArgs e)
        {
            //#region AccPayableStatemenet Detail

            //IList<ACCPrePayableStatementDetailFromWO_CustomEntity> lstACCPrePayableStatementDetail_CustomEntity = FCCACCPrePayableStatementDetailFromWO_Custom.GetFacadeCreate().GetIL();

            //if (lstACCPrePayableStatementDetail_CustomEntity != null && lstACCPrePayableStatementDetail_CustomEntity.Count > 0)
            //{
            //    IList<ACCPrePayableStatementDetailEntity> lstACCPrePayableStatementDetail = new List<ACCPrePayableStatementDetailEntity>();

            //    foreach (ACCPrePayableStatementDetailFromWO_CustomEntity entACCPrePayableStatementDetail_CustomEntity in lstACCPrePayableStatementDetail_CustomEntity)
            //    {
            //        ACCPrePayableStatementDetailEntity entACCPrePayableStatementDetail = new ACCPrePayableStatementDetailEntity();



            //        //if (lstACCPrePayableStatementDetail != null && lstACCPrePayableStatementDetail.Count > 0)
            //        //{
            //        //    ACCPrePayableStatementDetailEntity entTempACCPrePayableStatementDetail = (from s in lstACCPrePayableStatementDetail
            //        //                                                                              where s.BillID == entACCPrePayableStatementDetail_CustomEntity.BillID && s.WorkOrderID == entACCPrePayableStatementDetail_CustomEntity.WorkOrderID
            //        //                                                                              && s.ApprovedBillAmount == entACCPrePayableStatementDetail_CustomEntity.BillAmount && s.RequisitionID != entACCPrePayableStatementDetail_CustomEntity.RequisitionID
            //        //                                                                              select s).FirstOrDefault();


            //        //    if (entTempACCPrePayableStatementDetail != null && entTempACCPrePayableStatementDetail.BillID > 0)
            //        //    {

            //        //        //Remove Previous Item
            //        //        lstACCPrePayableStatementDetail.Remove(entTempACCPrePayableStatementDetail);

            //        //        entTempACCPrePayableStatementDetail.RequisitionNo += "," + entACCPrePayableStatementDetail_CustomEntity.RequisitionNo;

            //        //        //Add New Edited Item.
            //        //        lstACCPrePayableStatementDetail.Add(entTempACCPrePayableStatementDetail);

            //        //        continue;
            //        //    }
            //        //}

            //        //else if(Flag)
            //        //{

            //        Decimal workOrderAgreementAmount = 0, paidAmount = 0, tDSAmount = 0, securityMoney = 0;

            //        entACCPrePayableStatementDetail.PrePayableStatementID = ACCPrePayableStatementID;
            //        if (entACCPrePayableStatementDetail_CustomEntity.WorkOrderNo.IsNotNullOrEmpty())
            //        {
            //            entACCPrePayableStatementDetail.WorkOrderNo = entACCPrePayableStatementDetail_CustomEntity.WorkOrderNo.Trim();
            //        }
            //        else
            //        {
            //            entACCPrePayableStatementDetail.WorkOrderNo = null;
            //        }

            //        if (entACCPrePayableStatementDetail_CustomEntity.WOAmount.HasValue)
            //        {
            //            workOrderAgreementAmount = Decimal.Parse(entACCPrePayableStatementDetail_CustomEntity.WOAmount.ToString());
            //            entACCPrePayableStatementDetail.WorkOrderAmount = workOrderAgreementAmount;
            //        }
            //        else
            //        {
            //            entACCPrePayableStatementDetail.WorkOrderAmount = null;
            //        }

            //        if (entACCPrePayableStatementDetail_CustomEntity.WorkOrderID > 0)
            //        {
            //            entACCPrePayableStatementDetail.WorkOrderID = Int64.Parse(entACCPrePayableStatementDetail_CustomEntity.WorkOrderID.ToString());
            //        }
            //        else
            //        {
            //            entACCPrePayableStatementDetail.WorkOrderID = null;
            //        }

            //        if (entACCPrePayableStatementDetail_CustomEntity.StartDate.IsValidDate())
            //        {
            //            entACCPrePayableStatementDetail.WorkOrderDate = entACCPrePayableStatementDetail_CustomEntity.StartDate;
            //        }
            //        else
            //        {
            //            entACCPrePayableStatementDetail.WorkOrderDate = null;
            //        }

            //        Decimal payableAgainstWO = (workOrderAgreementAmount - paidAmount - tDSAmount);
            //        Decimal netPayableConsideringBillSecurity = (payableAgainstWO - paidAmount - securityMoney - tDSAmount);

            //        entACCPrePayableStatementDetail.PaidAmount = paidAmount;
            //        entACCPrePayableStatementDetail.SecurityMoney = securityMoney;
            //        entACCPrePayableStatementDetail.TDSAmount = tDSAmount;
            //        entACCPrePayableStatementDetail.PayableAgainstWorkOrder = payableAgainstWO;
            //        entACCPrePayableStatementDetail.NetPayableConsideringBillAndSecurity = netPayableConsideringBillSecurity;
            //        entACCPrePayableStatementDetail.CreateDate = System.DateTime.Now;

            //        //if (!txtSecurityMoneyLV.Text.Trim().IsNullOrEmpty())
            //        //{
            //        //    aCCPrePayableStatementDetailEntity.SecurityMoney = Decimal.Parse(txtSecurityMoneyLV.Text.Trim());
            //        //}
            //        //else
            //        //{
            //        //    aCCPrePayableStatementDetailEntity.SecurityMoney = null;
            //        //}

            //        //if (!txtTDSAmountLV.Text.Trim().IsNullOrEmpty())
            //        //{
            //        //    aCCPrePayableStatementDetailEntity.TDSAmount = Decimal.Parse(txtTDSAmountLV.Text.Trim());
            //        //}
            //        //else
            //        //{
            //        //    aCCPrePayableStatementDetailEntity.TDSAmount = null;
            //        //}

            //        //if (!txtPayableAgainstWorkOrderLV.Text.Trim().IsNullOrEmpty())
            //        //{
            //        //    aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = Decimal.Parse(txtPayableAgainstWorkOrderLV.Text.Trim());
            //        //}
            //        //else
            //        //{
            //        //    aCCPrePayableStatementDetailEntity.PayableAgainstWorkOrder = null;
            //        //}

            //        if (!entACCPrePayableStatementDetail_CustomEntity.BillAmount.IsZero())
            //        {
            //            entACCPrePayableStatementDetail.ApprovedBillAmount = Decimal.Parse(entACCPrePayableStatementDetail_CustomEntity.BillAmount.ToString());
            //        }
            //        else
            //        {
            //            entACCPrePayableStatementDetail.ApprovedBillAmount = null;
            //        }

            //        //if (!txtNetPayableConsideringBillAndSecurityLV.Text.Trim().IsNullOrEmpty())
            //        //{
            //        //    aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = Decimal.Parse(txtNetPayableConsideringBillAndSecurityLV.Text.Trim());
            //        //}
            //        //else
            //        //{
            //        //    aCCPrePayableStatementDetailEntity.NetPayableConsideringBillAndSecurity = null;
            //        //}

            //        entACCPrePayableStatementDetail.PartyReconcile = false;

            //        if (entACCPrePayableStatementDetail_CustomEntity.RequisitionID > 0)
            //        {

            //            entACCPrePayableStatementDetail.RequisitionID = entACCPrePayableStatementDetail_CustomEntity.RequisitionID;
            //        }

            //        else
            //        {
            //            entACCPrePayableStatementDetail.RequisitionID = null;
            //        }


            //        if (entACCPrePayableStatementDetail_CustomEntity.RequisitionNo.IsNotNullOrEmpty())
            //        {
            //            entACCPrePayableStatementDetail.RequisitionNo = entACCPrePayableStatementDetail_CustomEntity.RequisitionNo;
            //        }
            //        else
            //        {
            //            entACCPrePayableStatementDetail.RequisitionNo = null;
            //        }

            //        if (entACCPrePayableStatementDetail_CustomEntity.RequisitionDate.IsValidDate())
            //        {
            //            entACCPrePayableStatementDetail.RequisitionDate = entACCPrePayableStatementDetail_CustomEntity.RequisitionDate;
            //        }
            //        else
            //        {
            //            entACCPrePayableStatementDetail.RequisitionDate = null;
            //        }

            //        entACCPrePayableStatementDetail.ProjectID = entACCPrePayableStatementDetail_CustomEntity.ProjectID;
            //        entACCPrePayableStatementDetail.BillID = entACCPrePayableStatementDetail_CustomEntity.BillID;
            //        entACCPrePayableStatementDetail.BillDate = entACCPrePayableStatementDetail_CustomEntity.billdate;
            //        entACCPrePayableStatementDetail.BillNo = entACCPrePayableStatementDetail_CustomEntity.BIllNo;
            //        entACCPrePayableStatementDetail.VendorCategoryID = entACCPrePayableStatementDetail_CustomEntity.VendorCategory;
            //        entACCPrePayableStatementDetail.FromVendorID = entACCPrePayableStatementDetail_CustomEntity.Vendor;
            //        entACCPrePayableStatementDetail.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
            //        entACCPrePayableStatementDetail.Ref = null;
            //        entACCPrePayableStatementDetail.DueDate = DateTime.Now;
            //        entACCPrePayableStatementDetail.PlannedDate = null;
            //        entACCPrePayableStatementDetail.Remarks = null;
            //        entACCPrePayableStatementDetail.AdditionalRemarks = null;

            //        entACCPrePayableStatementDetail.ACCPayablePaymentStatusID = MasterDataConstants.MDACCPayablePaymentStatus.CURRENT;
            //        entACCPrePayableStatementDetail.ACCPayableApprovalStatusID = MasterDataConstants.ACCPrePayableStatementApprovalStatus.INITIATED;
            //        entACCPrePayableStatementDetail.AccountPaybleStatementDetailCategoryID = MasterDataConstants.MDAccountPaybleStatementDetailCategory.REGULAR;
            //        entACCPrePayableStatementDetail.PayableClassificationID = MasterDataConstants.MDPayableClassification.AS;
            //        //entACCPrePayableStatementDetail.payabl = MasterDataConstants.ACCPrePayableStatementApprovalStatus.INITIATED;

            //        entACCPrePayableStatementDetail.IsRemoved = false;
            //        entACCPrePayableStatementDetail.IsLocked = false;

            //        lstACCPrePayableStatementDetail.Add(entACCPrePayableStatementDetail);
            //        //}
            //    }

            //    #region Insert To Payable Detail

            //    if (lstACCPrePayableStatementDetail != null && lstACCPrePayableStatementDetail.Count > 0)
            //    {
            //        foreach (ACCPrePayableStatementDetailEntity ent in lstACCPrePayableStatementDetail)
            //        {
            //            FCCACCPrePayableStatementDetail.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
            //        }
            //    }

            //    #endregion

            //}

            //#endregion
        }

        #endregion

        #endregion Event
    }
}
