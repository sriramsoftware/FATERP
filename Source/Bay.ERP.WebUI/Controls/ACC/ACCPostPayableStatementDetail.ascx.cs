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

namespace Bay.ERP.Web.UI
{
    public partial class ACCPostPayableStatementDetailControl : BaseControl
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

        public Int64 OverviewACCPostPayableStatementDetailID
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

        private ACCPostPayableStatementEntity CurrentACCPostPayableStatementEntity
        {
            get
            {
                ACCPostPayableStatementEntity _ACCPostPayableStatementEntity = new ACCPostPayableStatementEntity();

                if (ACCPostPayableStatementID > 0)
                {
                    _ACCPostPayableStatementEntity = FCCACCPostPayableStatement.GetFacadeCreate().GetByID(ACCPostPayableStatementID);
                }

                return _ACCPostPayableStatementEntity;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false,MasterDataConstants.APPanelStartWith.PAYABLE);
            MiscUtil.PopulateACBankAccount(ddlBankAccountID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            //int i;
            //for (i = 0; i < ddlAPPanelID.Items.Count; i++)
            //{
            //    ddlAPPanelID.SelectedIndex = i;

            //    if (ddlAPPanelID.SelectedItem.Text.StartsWith("Payable") == true)
            //        break;
            //}

            //if (OverviewACCPostPayableStatementDetailID > 0)
            //{
                //btnMakePayment.Visible = true;
            //}
            //else
            //{
            //    btnMakePayment.Visible = false;
            //}

            #region Payable Info

            if (CurrentACCPostPayableStatementEntity != null && CurrentACCPostPayableStatementEntity.PostPayableStatementID > 0)
            {
                ACCPostPayableStatementEntity ent = CurrentACCPostPayableStatementEntity;

                lblRef.Text = ent.Ref;
                lblCreateDate.Text = ent.CreateDate.ToStringDefault();
                lblStartDate.Text = ent.StartDate.ToStringDefault();
                lblEndDate.Text = ent.EndDate.ToStringDefault();
            }

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
            lvACCPrePayableStatementDetail.DataBind();
        }

        private void SaveACCPostPayableStatementDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity = new ACCPostPayableStatementDetailEntity();//BuildACCPostPayableStatementDetailEntity();

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

        private void UpdateApprovalStatus()
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
                        DropDownList ddlACCPayableApprovalStatusIDLV = (DropDownList)lvdi.FindControl("ddlACCPayableApprovalStatusIDLV");

                        if (ddlACCPayableApprovalStatusIDLV != null && ddlACCPayableApprovalStatusIDLV.Items.Count > 0)
                        {
                            ddlACCPayableApprovalStatusIDLV.SelectedValue = MasterDataConstants.ACCPrePayableStatementApprovalStatus.IN_APPROVE_PROCESS.ToString();
                        }
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

        private void EnableDisableApprovalProcessCheck()
        {
            SetPayableStatementDetailID();

            APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.PAYABLE_STATEMENT, _PostPayableStatementDetailID);

            if (aPApprovalProcessEntity.APApprovalProcessID > 0)
            {
                btnInitiateApprovalProcess.Enabled = false;
            }
            else
            {
                btnInitiateApprovalProcess.Enabled = true;
            }
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

                    if (Int64.Parse(ddlACCPayableApprovalStatusIDLV.SelectedValue) == MasterDataConstants.ACCPrePayableStatementApprovalStatus.IN_APPROVE_PROCESS)
                    {
                        btnInitiateApprovalProcess.Enabled = false;
                    }
                    else
                    {
                        btnInitiateApprovalProcess.Enabled = true;
                    }
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

        protected void lvACCPostPayableStatementDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PostPayableStatementDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out PostPayableStatementDetailID);

            if (PostPayableStatementDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PostPayableStatementDetailID = PostPayableStatementDetailID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, PostPayableStatementDetailID.ToString(), SQLMatchType.Equal);

                        ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity = new ACCPostPayableStatementDetailEntity();


                        result = FCCACCPostPayableStatementDetail.GetFacadeCreate().Delete(aCCPostPayableStatementDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PostPayableStatementDetailID = 0;
                            _ACCPostPayableStatementDetailEntity = new ACCPostPayableStatementDetailEntity();
                            PrepareInitialView();
                            BindACCPostPayableStatementDetailList();

                            MiscUtil.ShowMessage(lblMessage, "Payable Statement Detail has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Payable Statement Detail.", true);
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

        protected void odsACCPostPayableStatementDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementEntity.FLD_NAME_PostPayableStatementID, ACCPostPayableStatementID.ToString(), SQLMatchType.Equal);

            if (OverviewACCPostPayableStatementDetailID > 0)
            {
               String fe1 = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, OverviewACCPostPayableStatementDetailID.ToString(), SQLMatchType.Equal);
               fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }
            
            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsACCPrePayableStatementDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

            if (e.ExecutingSelectCount == false)
            {
                UpdatePayableStatementDetail();
            }

            String fe = String.Empty;
            String fe1 = ACCPostPayableStatementDetailEntity.FLD_NAME_ACCPayableApprovalStatusID + " <> " + MasterDataConstants.ACCPrePayableStatementApprovalStatus.APPROVED.ToString();
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementID, ACCPostPayableStatementID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            if (OverviewACCPostPayableStatementDetailID > 0)
            {
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(ACCPostPayableStatementDetailEntity.FLD_NAME_PostPayableStatementDetailID, OverviewACCPostPayableStatementDetailID.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            e.InputParameters["filterExpression"] = fe;

        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePayableStatementDetail();
        }

        protected void btnPnlSavePopup_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl("~/AC/ACBankAccountPayment.aspx", String.Empty, UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID, _PostPayableStatementDetailID.ToString(), UrlConstants.OVERVIEW_PAYABLE_ACCOUNT_ID,ddlACCAccountID.SelectedValue, UrlConstants.OVERVIEW_BANK_ACCOUNT_ID, ddlBankAccountID.SelectedValue.ToString(), UrlConstants.OVERVIEW_PAYABLE_AMOUNT, txtAmount.Text.ToString()).ToString();
            Helper.Response.Redirect(navUrl);
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PostPayableStatementDetailID = 0;
            _ACCPostPayableStatementDetailEntity = new ACCPostPayableStatementDetailEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnMakePayment_Click(object sender, EventArgs e)
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

            if (_PostPayableStatementDetailID > 0)
            {
                ACCPostPayableStatementDetailEntity aCCPostPayableStatementDetailEntity = CurrentACCPostPayableStatementDetailEntity;

                if (aCCPostPayableStatementDetailEntity != null && aCCPostPayableStatementDetailEntity.PostPayableStatementDetailID > 0)
                {
                    txtAmount.Text = aCCPostPayableStatementDetailEntity.NetPayableConsideringBillAndSecurity.ToString();

                    PRMSupplierEntity pRMSupplierEntity = FCCPRMSupplier.GetFacadeCreate().GetByID(aCCPostPayableStatementDetailEntity.FromVendorID);

                    String compositeID = String.Empty;
                    Int64 accountID=0;
                    if (pRMSupplierEntity != null && pRMSupplierEntity.SupplierID > 0)
                    {
                        Int64 referenceID, resourceCategoryID=0;
                        referenceID = pRMSupplierEntity.SupplierID;

                        switch (pRMSupplierEntity.SupplierTypeID)
                        {

                            case MasterDataConstants.MDSupplierType.LOCAL:
                            case MasterDataConstants.MDSupplierType.IMPORTER:
                            case MasterDataConstants.MDSupplierType.LOCAL_AND_IMPORTER:
                                resourceCategoryID = MasterDataConstants.ACMDAccountResourceCategory.VENDOR;
                                break;
                            case MasterDataConstants.MDSupplierType.CONTRACTOR:
                                resourceCategoryID = MasterDataConstants.ACMDAccountResourceCategory.CONTRACTOR;
                                break;
                            case MasterDataConstants.MDSupplierType.CONSULTANT:
                                resourceCategoryID = MasterDataConstants.ACMDAccountResourceCategory.CONSULTANT;
                                break;

                        }

                      

                        if (referenceID > 0 && resourceCategoryID > 0)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_AccountResourceCategoryID, resourceCategoryID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_ReferenceID, referenceID.ToString(), SQLMatchType.Equal);
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            IList<ACAccountResourceAccountMapEntity> lst = FCCACAccountResourceAccountMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                            if (lst != null && lst.Count > 0)
                            {
                                foreach (ACAccountResourceAccountMapEntity ent in lst)
                                {
                                    compositeID += ent.ReferenceID + ",";
                                    accountID=ent.AccountID;
                                }

                                compositeID = compositeID.Substring(0, compositeID.Length - 1);
                            }
                        }

                    }

                    MiscUtil.PopulateACAccountByAccountGroupByReference(ddlACCAccountID, false, compositeID);

                    if (ddlACCAccountID != null && ddlACCAccountID.Items.Count > 0)
                    {
                        //ddlACCAccountID.SelectedValue = accountID.ToString();
                    }
                }
            }
            this.Panel1_ModalPopupExtender.Show();
            
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            #region Approval Process

            if (ddlAPPanelID != null && ddlAPPanelID.SelectedValue != "0")
            {
                SetPayableStatementDetailID();

                Boolean apResult = APRobot.CreateApprovalProcessForNewPayableStatement(_PostPayableStatementDetailID, Int64.Parse(ddlAPPanelID.SelectedValue.ToString()));

                if (apResult == true)
                {
                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                    UpdateApprovalStatus();
                    BindList();
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                }

                //EnableDisableApprovalProcessCheck();
            }

            #endregion
        }

        #endregion

        #endregion Event
    }
}
