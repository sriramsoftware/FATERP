// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CMBillControl : BaseControl
    {
        #region Properties

        public Int64 _BillID
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

        public CMBillEntity _CMBillEntity
        {
            get
            {
                CMBillEntity entity = new CMBillEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMBillEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMBillEntity CurrentCMBillEntity
        {
            get
            {
                if (_BillID > 0)
                {
                    if (_CMBillEntity.BillID != _BillID)
                    {
                        _CMBillEntity = FCCCMBill.GetFacadeCreate().GetByID(_BillID);
                    }
                }

                return _CMBillEntity;
            }
            set
            {
                _CMBillEntity = value;
            }
        }

        private PRMWorkOrderEntity CurrentPRMWorkOrderEntity
        {
            get
            {
                PRMWorkOrderEntity _PRMWorkOrderEntity = new PRMWorkOrderEntity();

                if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != "0")
                {

                    Int64 workOrderID;
                    Int64.TryParse(ddlWorkOrderID.SelectedValue.ToString(), out workOrderID);

                    if (workOrderID > 0)
                    {
                        _PRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(workOrderID);
                    }
                }

                return _PRMWorkOrderEntity;
            }
        }

        public Int64 CMBillID
        {
            get
            {
                Int64 cMBillID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_ID], out cMBillID);
                }

                return cMBillID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateMDBillApprovalStatus(ddlBillApprovalStatusID, false);
            ListItem contractor = new ListItem("Contractor", "1");
            ListItem consultant = new ListItem("Consultant", "2");
            ListItem vendor = new ListItem("Vendor", "3");

            ddlVendorCategoryID.Items.Add(vendor);
            ddlVendorCategoryID.Items.Add(contractor);
            ddlVendorCategoryID.Items.Add(consultant);

            BuildVendorByVendorCategory();

            if (chbxFinalBilled.Checked == false)
            {
                BuildWOExceptFinalBillByVendor();
            }

            else if (chbxFinalBilled.Checked == true)
            {
                BuildWOByVendor();
            }

            MiscUtil.PopulateMDBillStatus(ddlBillStatusID, false);
        }

        private void BindREQRequisitionList()
        {
            lvREQRequisition.DataBind();
        }

        private void BindREQRequisitionItemList()
        {
            lvREQRequisitionItem.DataBind();
        }

        private void BuildWOExceptFinalBillByVendor()
        {
            if (ddlVendorCategoryID != null && ddlVendorCategoryID.Items.Count > 0)
            {
                if (ddlVendorCategoryID.SelectedValue.ToString() == MasterDataConstants.CM_Bill_VendorCategory.VENDOR)
                {
                    if (ddlVendorID != null && ddlVendorID.SelectedValue != "0")
                    {
                        MiscUtil.PopulatePRMWorkOrderExceptFinalBillbySupplierID(ddlWorkOrderID, true, Int64.Parse(ddlVendorID.SelectedValue.ToString()));
                    }
                }
                else
                {
                    ddlWorkOrderID.Items.Clear();
                }
            }
        }

        private void BuildWOByVendor()
        {
            if (ddlVendorCategoryID != null && ddlVendorCategoryID.Items.Count > 0)
            {
                if (ddlVendorCategoryID.SelectedValue.ToString() == MasterDataConstants.CM_Bill_VendorCategory.VENDOR)
                {
                    if (ddlVendorID != null && ddlVendorID.SelectedValue != "0")
                    {
                        MiscUtil.PopulatePRMWorkOrderbySupplierID(ddlWorkOrderID, true, Int64.Parse(ddlVendorID.SelectedValue.ToString()));
                    }
                }
                else
                {
                    ddlWorkOrderID.Items.Clear();
                }
            }
        }

        private void BuildVendorByVendorCategory()
        {
            if (ddlVendorCategoryID != null && ddlVendorCategoryID.Items.Count > 0)
            {
                switch (ddlVendorCategoryID.SelectedValue.ToString())
                {

                    case MasterDataConstants.CM_Bill_VendorCategory.CONTRACTOR:
                        MiscUtil.PopulateCMContractor(ddlVendorID, false);
                        break;
                    case MasterDataConstants.CM_Bill_VendorCategory.CONSULTANT:
                        MiscUtil.PopulateCMConsultant(ddlVendorID, false);
                        break;
                    case MasterDataConstants.CM_Bill_VendorCategory.VENDOR:
                        MiscUtil.PopulatePRMSupplier(ddlVendorID, false);
                        break;
                }
            }
        }

        private void BuildVendorWOByVendorCategory()
        {
            if (chbxFinalBilled.Checked == false)
            {
                BuildWOExceptFinalBillByVendor();
            }

            else if (chbxFinalBilled.Checked == true)
            {
                BuildWOByVendor();
            }
        }

        private Boolean ValidationInput()
        {
            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != "0")
            {
                if (ddlWorkOrderID.SelectedItem.ToString().EndsWith("Billed"))
                {
                    MiscUtil.ShowMessage(lblMessage, "Bill Already Paid.", true);
                    return false;
                }
            }

            return true;
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtBillNo.Text = String.Empty;
            txtBillDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtAmount.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private String GetFilterExpression()
        {
            String compositeRequisitionID = String.Empty;
            String fe_requisitionItem = String.Empty;

            try
            {
                IList<ListViewDataItem> list = lvREQRequisition.Items;

                if (list != null && list.Count > 0)
                {
                    foreach (ListViewDataItem lvdi in list)
                    {

                        Label lblRequisitionIDLV = (Label)lvdi.FindControl("lblRequisitionIDLV");
                        CheckBox chbxSelectRequisition = (CheckBox)lvdi.FindControl("chbxSelectRequisition");

                        if (chbxSelectRequisition.Checked)
                        {
                            compositeRequisitionID += lblRequisitionIDLV.Text + ",";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            if (compositeRequisitionID == String.Empty)
            {
                MiscUtil.ShowMessage(lblMessage, "Please Select At Least One Requisition", true);
            }
            else if (compositeRequisitionID.IsNotNullOrEmpty())
            {
                compositeRequisitionID = compositeRequisitionID.Substring(0, compositeRequisitionID.Length - 1);

                fe_requisitionItem = "REQRequisition.RequisitionID in(" + compositeRequisitionID + ")";
            }

            return fe_requisitionItem;
        }

        private void PrepareEditView()
        {
            if (CMBillID > 0)
            {
                _BillID = CMBillID;

                if (CurrentCMBillEntity != null)
                {
                    if (CurrentCMBillEntity.BillApprovalStatusID != MasterDataConstants.BillApprovalStatus.INITIATED)
                    {
                        
                    }
                }
            }

            CMBillEntity cMBillEntity = CurrentCMBillEntity;


            if (!cMBillEntity.IsNew)
            {

                if (ddlProjectID.Items.Count > 0 && cMBillEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cMBillEntity.ProjectID.ToString();
                }

                txtBillNo.Text = cMBillEntity.BillNo.ToString();

                if (ddlVendorCategoryID.Items.Count > 0 && cMBillEntity.VendorCategory != null)
                {
                    ddlVendorCategoryID.SelectedValue = cMBillEntity.VendorCategory.ToString();
                }

                BuildVendorByVendorCategory();

                if (ddlVendorID.Items.Count > 0 && cMBillEntity.Vendor != null)
                {
                    ddlVendorID.SelectedValue = cMBillEntity.Vendor.ToString();
                }

                BuildWOByVendor();

                if (ddlWorkOrderID.Items.Count > 0 && cMBillEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = cMBillEntity.WorkOrderID.ToString();
                }
                txtBillDate.Text = cMBillEntity.BillDate.ToStringDefault();
                txtAmount.Text = cMBillEntity.Amount.ToString();
                txtRemarks.Text = cMBillEntity.Remarks.ToString();
                if (ddlBillStatusID.Items.Count > 0 && cMBillEntity.BillStatusID != null)
                {
                    ddlBillStatusID.SelectedValue = cMBillEntity.BillStatusID.ToString();
                }

                if (ddlBillApprovalStatusID.Items.Count > 0 && cMBillEntity.BillApprovalStatusID != null)
                {
                    ddlBillApprovalStatusID.SelectedValue = cMBillEntity.BillApprovalStatusID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMBillList();
        }

        private void BindCMBillList()
        {
            lvCMBill.DataBind();
        }

        private CMBillEntity BuildCMBillEntity()
        {
            CMBillEntity cMBillEntity = CurrentCMBillEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            cMBillEntity.BillNo = txtBillNo.Text.Trim();

            if (ddlVendorCategoryID.Items.Count > 0)
            {
                if (ddlVendorCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.VendorCategory = Int64.Parse(ddlVendorCategoryID.SelectedValue);
                }
            }

            if (ddlVendorID.Items.Count > 0)
            {
                if (ddlVendorID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.Vendor = Int64.Parse(ddlVendorID.SelectedValue);
                }
            }

            if (ddlWorkOrderID.Items.Count > 0)
            {
                if (ddlWorkOrderID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                }
            }

            cMBillEntity.CreateDate = MiscUtil.ParseToDateTime(System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT));

            if (txtBillDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMBillEntity.BillDate = MiscUtil.ParseToDateTime(txtBillDate.Text);
            }

            
            if (!txtAmount.Text.Trim().IsNullOrEmpty())
            {
                cMBillEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
            }

            if (!txtAmount.Text.Trim().IsNullOrEmpty())
            {
                cMBillEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
            }

            if (ddlBillStatusID.Items.Count > 0)
            {
                if (ddlBillStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.BillStatusID = Int64.Parse(ddlBillStatusID.SelectedValue);
                }
            }
            cMBillEntity.Remarks = txtRemarks.Text.Trim();

            if (ddlBillApprovalStatusID.Items.Count > 0)
            {
                if (ddlBillApprovalStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.BillApprovalStatusID = Int64.Parse(ddlBillApprovalStatusID.SelectedValue);
                }
            }

            return cMBillEntity;
        }

        private void SaveCMBillEntity()
        {
            if (ValidationInput())
            {
                if (IsValid)
                {
                    try
                    {
                        CMBillEntity cMBillEntity = BuildCMBillEntity();

                        Int64 result = -1;

                        if (cMBillEntity.IsNew)
                        {
                            result = FCCCMBill.GetFacadeCreate().Add(cMBillEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillID, cMBillEntity.BillID.ToString(), SQLMatchType.Equal);
                            result = FCCCMBill.GetFacadeCreate().Update(cMBillEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {

                            #region Update WO Final Bill Status

                            if (cMBillEntity.BillStatusID == MasterDataConstants.MDBillStatus.FINAL_BILL)
                            {
                                PRMWorkOrderEntity prmWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(cMBillEntity.WorkOrderID);
                                prmWorkOrderEntity.IsFinalBilled = true;

                                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, prmWorkOrderEntity.WorkOrderID.ToString(), SQLMatchType.Equal);

                                FCCPRMWorkOrder.GetFacadeCreate().Update(prmWorkOrderEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                            }

                            #endregion

                            #region Bill Requisition Item Map

                            CMBillRequisitionItemMapEntity cMBillRequisitionItemMapEntity = new CMBillRequisitionItemMapEntity();


                            try
                            {
                                IList<ListViewDataItem> list = lvREQRequisitionItem.Items;

                                if (list != null && list.Count > 0)
                                {
                                    foreach (ListViewDataItem lvdi in list)
                                    {
                                        Decimal billPriceLV;
                                        TextBox txtBillPriceLV = (TextBox)lvdi.FindControl("txtBillPriceLV");
                                        Decimal.TryParse(txtBillPriceLV.Text.Trim(), out billPriceLV);

                                        if (billPriceLV > 0)
                                        {
                                            Label lblRequisitionIDLV = (Label)lvdi.FindControl("lblRequisitionIDLV");
                                            Label lblRequisitionPriceLV = (Label)lvdi.FindControl("lblRequisitionPriceLV");
                                            Label lblRequisitionItemIDLV = (Label)lvdi.FindControl("lblRequisitionItemIDLV");

                                            cMBillRequisitionItemMapEntity.BillID = result;
                                            cMBillRequisitionItemMapEntity.RequisitionID = Int64.Parse(lblRequisitionIDLV.Text);
                                            cMBillRequisitionItemMapEntity.RequisitionItemID = Int64.Parse(lblRequisitionItemIDLV.Text);
                                            cMBillRequisitionItemMapEntity.RequisitionPrice = Decimal.Parse(lblRequisitionPriceLV.Text.Trim());

                                            if (billPriceLV > 0)
                                            {
                                                cMBillRequisitionItemMapEntity.BillPrice = Decimal.Parse(txtBillPriceLV.Text.Trim());
                                            }

                                            FCCCMBillRequisitionItemMap.GetFacadeCreate().Add(cMBillRequisitionItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                            //else
                                            //{
                                            //    cMBillRequisitionItemMapEntity.BillPrice = null;
                                            //}
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                            

                            #endregion

                            CMBillEntity _cMBillEntity = CurrentCMBillEntity;
                            _BillID = 0;
                            _CMBillEntity = new CMBillEntity();
                            PrepareInitialView();
                            BindCMBillList();

                            if (cMBillEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bill Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bill Information has been updated successfully.", false);
                            }

                            String NavUrl = UrlHelper.BuildSecureUrl("~/CM/CMBillUploadInfo.aspx", string.Empty, UrlConstants.OVERVIEW_CM_BILL_ID, result.ToString()).ToString();
                            Response.Redirect(NavUrl);
                        }
                        else
                        {
                            if (cMBillEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Bill Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Bill Information.", false);
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

            if (!IsPostBack)
            {   
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvREQRequisition_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                REQRequisition_DetailedEntity ent = (REQRequisition_DetailedEntity)dataItem.DataItem;

                HyperLink hypRequisition = (HyperLink)e.Item.FindControl("hypRequisition");
                Label lblRequisitionItem = (Label)e.Item.FindControl("lblRequisitionItem");

                hypRequisition.NavigateUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionItem.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, ent.ProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo, ent.RequisitionNo.ToString()).ToString();

                String feReqItem = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), SQLMatchType.Equal);
                IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, feReqItem);

                if (lst != null && lst.Count > 0)
                {
                    foreach (REQRequisitionItem_DetailedEntity entREQRequisitionItem_DetailedEntity in lst)
                    {
                        lblRequisitionItem.Text += entREQRequisitionItem_DetailedEntity.MDItemItemName + ", ";
                    }

                    lblRequisitionItem.Text = lblRequisitionItem.Text.Substring(0, lblRequisitionItem.Text.Length - 2);
                }

                hypRequisition.Target = "_blank";
            }
        }

        protected void lvCMBill_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMBill_DetailedEntity ent = (CMBill_DetailedEntity)dataItem.DataItem;
                HyperLink hypUploadInfo = (HyperLink)e.Item.FindControl("hypUploadInfo");

                //if (ent.BillStatusID == MasterDataConstants.MDBillStatus.FINAL_BILL)
                //{
                //    LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                //    LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");

                //    lnkBtnEdit.Enabled = false;
                //    lnkBtnDelete.Enabled = false;
                //    lnkBtnEdit.ToolTip = "Final Bill Submitted. Can't be Modified!!!";
                //    lnkBtnDelete.ToolTip = "Final Bill Submitted. Can't be Modified!!!";
                //}

                hypUploadInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMBillUploadInfo.aspx", string.Empty, UrlConstants.OVERVIEW_CM_BILL_ID, ent.BillID.ToString()).ToString();
                hypUploadInfo.Target = "_blank";
            }
        }

        protected void lvCMBill_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BillID;

            Int64.TryParse(e.CommandArgument.ToString(), out BillID);

            if (BillID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BillID = BillID;

                    PrepareEditView();

                    if (CurrentCMBillEntity != null)
                    {
                        if (CurrentCMBillEntity.BillApprovalStatusID != MasterDataConstants.BillApprovalStatus.INITIATED)
                        {
                           
                        }
                    }
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillID, BillID.ToString(), SQLMatchType.Equal);

                        CMBillEntity cMBillEntity = new CMBillEntity();


                        result = FCCCMBill.GetFacadeCreate().Delete(cMBillEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BillID = 0;
                            _CMBillEntity = new CMBillEntity();
                            PrepareInitialView();
                            BindCMBillList();

                            MiscUtil.ShowMessage(lblMessage, "Bill has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Bill.", true);
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

        protected void odsCMBill_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region ObjectDataSource Event(Requisition)

        protected void odsREQRequisition_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_RequisitionStatusID, MasterDataConstants.RequisitionStatus.APPROVED.ToString(), SQLMatchType.Equal);

            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue == MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
                {
                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }
            }

            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
            {
                String fe_WO = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, ddlWorkOrderID.SelectedValue.ToString(), SQLMatchType.Equal);
                IList<PRMWorkOrderItemMapEntity> lstPRMWorkOrderItem = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_WO, DatabaseOperationType.LoadWithFilterExpression);

                String compositeRequisitionID = String.Empty;
                if (lstPRMWorkOrderItem != null && lstPRMWorkOrderItem.Count > 0)
                {
                    foreach (PRMWorkOrderItemMapEntity ent in lstPRMWorkOrderItem)
                    {
                        compositeRequisitionID += ent.RequisitionID + ",";
                    }

                    compositeRequisitionID = compositeRequisitionID.Substring(0, compositeRequisitionID.Length - 1);
                }

                String fe1 = "REQRequisition.RequisitionID in(" + compositeRequisitionID + ")";
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ObjectDataSource Event(Requisition Item)

        protected void odsREQRequisitionItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, "0", SQLMatchType.Equal);

            if (chbxShowRequisitionItem.Checked)
            {
                String fe1=GetFilterExpression();
                if(fe1!=String.Empty)
                {
                    fe = fe1;
                }
            }
                //SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMBillEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BillID = 0;
            _CMBillEntity = new CMBillEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region DropDownList Event

        protected void ddlVendorCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildVendorByVendorCategory();
            BuildVendorWOByVendorCategory();
        }

        protected void ddlVendorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildVendorWOByVendorCategory();
        }

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
            {
                ddlWorkOrderID.SelectedValue = MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString();
            }

            BindREQRequisitionList();

            if (chbxShowRequisitionItem.Checked)
            {
                chbxShowRequisitionItem.Checked = false;
                BindREQRequisitionItemList();
            }
        }

        protected void ddlWorkOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindREQRequisitionList();

            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
            {
                String navUrl=UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, ddlWorkOrderID.SelectedValue.ToString()).ToString();
                hypWorkOrder.NavigateUrl = navUrl;
            }
        }

        #endregion

        #region Check Box Event

        protected void chbxFinalBilled_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxFinalBilled.Checked == false)
            {
                BuildWOExceptFinalBillByVendor();
            }

            else if (chbxFinalBilled.Checked == true)
            {
                BuildWOByVendor();
            }
        }

        protected void chbxShowRequisitionItem_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxShowRequisitionItem.Checked)
            {
                BindREQRequisitionItemList();
            }
            else
            {
                BindREQRequisitionItemList();
            }
        }

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindREQRequisitionList();
        }

        #endregion

        #endregion Event
    }
}