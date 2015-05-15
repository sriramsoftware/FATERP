// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class PRMWorkOrderListCancellationControl : BaseControl
    {       
        #region Properties

        public Int64 _WorkOrderID
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

        public PRMWorkOrderEntity _PRMWorkOrderEntity
        {
            get
            {
                PRMWorkOrderEntity entity = new PRMWorkOrderEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMWorkOrderEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMWorkOrderEntity CurrentPRMWorkOrderEntity
        {
            get
            {
                if (_WorkOrderID > 0)
                {
                    if (_PRMWorkOrderEntity.WorkOrderID != _WorkOrderID)
                    {
                        _PRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(_WorkOrderID);
                    }
                }

                return _PRMWorkOrderEntity;
            }
            set
            {
                _PRMWorkOrderEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
        }

        private void PrepareEditView()
        {
        }

        private void BindList()
        {
            BindPRMWorkOrderList();
        }

        private void BindPRMWorkOrderList()
        {
            lvPRMWorkOrder.DataBind();
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

        protected void lvPRMWorkOrder_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                
                PRMWorkOrder_DetailedEntity ent = (PRMWorkOrder_DetailedEntity)dataItem.DataItem;
                HyperLink hypWorkOrderFloorwiseReport = (HyperLink)e.Item.FindControl("hypWorkOrderFloorwiseReport");
                HyperLink hypWorkOrderNo = (HyperLink)e.Item.FindControl("hypWorkOrderNo");
                HyperLink hypWorkOrderReport = (HyperLink)e.Item.FindControl("hypWorkOrderReport");
                HyperLink hypWorkOrderAnnexureReport = (HyperLink)e.Item.FindControl("hypWorkOrderAnnexureReport");
                HyperLink hypWorkOrderPaymentTerm = (HyperLink)e.Item.FindControl("hypWorkOrderPaymentTerm");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                Button btnResetWorkOrderLV = (Button)e.Item.FindControl("btnResetWorkOrderLV");
                
                hypWorkOrderPaymentTerm.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderPaymentTerm.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, ent.WorkOrderNo).ToString();
                hypWorkOrderNo.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo,ent.WorkOrderNo).ToString();
                hypWorkOrderReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString()).ToString();
                hypWorkOrderAnnexureReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT_WITH_ANNEXURE, UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString()).ToString();
                hypWorkOrderFloorwiseReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_ITEM_FLOOR_DETAIL, UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString()).ToString();

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.WORK_ORDER, ent.WorkOrderID);
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

                if (ent.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.APPROVED||
                    ent.WorkOrderStatusID==MasterDataConstants.WorkOrderStatus.IN_APPROVE_PROCESS)
                {
                    lnkBtnEdit.Visible = false;
                    hypWorkOrderNo.NavigateUrl = String.Empty;
                    hypWorkOrderPaymentTerm.NavigateUrl =String.Empty;
                }

                Panel pnlRequisitonNoLV = (Panel)e.Item.FindControl("pnlRequisitonNoLV");
                Panel pnlMRRNoLV = (Panel)e.Item.FindControl("pnlMRRNoLV");
                Panel pnlBillLV = (Panel)e.Item.FindControl("pnlBillLV");

                if (ent.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.APPROVED||
                    ent.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.CANCELED)
                {
                    btnResetWorkOrderLV.Visible = true;
                }
                else
                {
                    btnResetWorkOrderLV.Visible = false;
                }

                String fe_mrr = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_WorkOrderID, ent.WorkOrderID.ToString(), SQLMatchType.Equal);
                IList<PRMMaterialReceiveEntity> lstPRMMaterialReceive = FCCPRMMaterialReceive.GetFacadeCreate().GetIL(null, null, String.Empty, fe_mrr, DatabaseOperationType.LoadWithFilterExpression);

                if (lstPRMMaterialReceive != null && lstPRMMaterialReceive.Count > 0)
                {
                    btnResetWorkOrderLV.Visible = false;

                    foreach (PRMMaterialReceiveEntity pRMMaterialReceiveEntity in lstPRMMaterialReceive)
                    {
                        HyperLink hypMaterialReceive = new HyperLink();
                        hypMaterialReceive.Text = pRMMaterialReceiveEntity.MRRNo;
                        hypMaterialReceive.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "MaterialReceiveReport", UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, pRMMaterialReceiveEntity.MaterialReceiveID.ToString()).ToString();
                        hypMaterialReceive.Target = "_blank";
                        hypMaterialReceive.CssClass = "CommonButtonLink";

                        pnlMRRNoLV.Controls.Add(hypMaterialReceive);
                        pnlMRRNoLV.Controls.Add(new LiteralControl("<br/>"));
                    }
                }


                String fe_req = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, ent.WorkOrderID.ToString(), SQLMatchType.Equal);
                IList<PRMWorkOrderItemMap_DetailedEntity> lstPRMWorkOrderItemMap = FCCPRMWorkOrderItemMap_Detailed.GetFacadeCreate().GetIL(10000,1,String.Empty, fe_req);

                if (lstPRMWorkOrderItemMap != null && lstPRMWorkOrderItemMap.Count > 0)
                {

                    List<PRMWorkOrderItemMap_DetailedEntity> distinct =
                                       lstPRMWorkOrderItemMap
                                       .GroupBy(car => car.WorkOrderID)
                                       .Select(g => g.First())
                                       .ToList();

                    foreach (PRMWorkOrderItemMap_DetailedEntity pRMWorkOrderItemMapEntity in distinct)
                    {

                        HyperLink hypRequisitionNo = new HyperLink();
                        hypRequisitionNo.Text = pRMWorkOrderItemMapEntity.RequisitionNo.ToString();
                        hypRequisitionNo.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.REQUISITION_REPORT, UrlConstants.REQUISITION_ID, pRMWorkOrderItemMapEntity.RequisitionID.ToString()).ToString();
                        hypRequisitionNo.Target = "_blank";
                        hypRequisitionNo.CssClass = "CommonButtonLink";

                        pnlRequisitonNoLV.Controls.Add(hypRequisitionNo);
                        pnlRequisitonNoLV.Controls.Add(new LiteralControl("<br/>"));
                    }
                }

                String fe_bill = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_WorkOrderID, ent.WorkOrderID.ToString(), SQLMatchType.Equal);
                IList<CMBillEntity> lstBill = FCCCMBill.GetFacadeCreate().GetIL(null, null, String.Empty, fe_bill, DatabaseOperationType.LoadWithFilterExpression);

                if (lstBill != null && lstBill.Count > 0)
                {
                    btnResetWorkOrderLV.Visible = false;

                    foreach (CMBillEntity cMBillEntity in lstBill)
                    {
                        HyperLink hypBill = new HyperLink();
                        hypBill.Text = cMBillEntity.BillNo.ToString();
                        //hypBill.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.REQUISITION_REPORT, UrlConstants.REQUISITION_ID, pRMWorkOrderItemMapEntity.RequisitionID.ToString()).ToString();
                        hypBill.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BILL_REPORT, UrlConstants.OVERVIEW_CM_BILL_ID, cMBillEntity.BillID.ToString()).ToString();
                        hypBill.Target = "_blank";
                        hypBill.CssClass = "CommonButtonLink";

                        pnlBillLV.Controls.Add(hypBill);
                        pnlBillLV.Controls.Add(new LiteralControl("<br/>"));
                    }
                }

               

                hypWorkOrderPaymentTerm.Target = "_blank";
                hypWorkOrderReport.Target = "_blank";
                hypWorkOrderAnnexureReport.Target = "_blank";
            }
        }

        protected void lvPRMWorkOrder_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkOrderID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderID);

            if (WorkOrderID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    String url = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrder.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, WorkOrderID.ToString()).ToString();
                    Response.Redirect(url);
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, WorkOrderID.ToString(), SQLMatchType.Equal);

                        PRMWorkOrderEntity pRMWorkOrderEntity = new PRMWorkOrderEntity();


                        result = FCCPRMWorkOrder.GetFacadeCreate().Delete(pRMWorkOrderEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkOrderID = 0;
                            _PRMWorkOrderEntity = new PRMWorkOrderEntity();
                            PrepareInitialView();
                            BindPRMWorkOrderList();

                            MiscUtil.ShowMessage(lblMessage, "Work Order has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }

                else if (string.Equals(e.CommandName, "CancelItem"))
                {
                    try
                    {
                        _WorkOrderID = WorkOrderID;
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, WorkOrderID.ToString(), SQLMatchType.Equal);

                        PRMWorkOrderEntity pRMWorkOrderEntity = CurrentPRMWorkOrderEntity;

                        pRMWorkOrderEntity.WorkOrderStatusID = MasterDataConstants.WorkOrderStatus.CANCELED;

                        result = FCCPRMWorkOrder.GetFacadeCreate().Update(pRMWorkOrderEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        if (result > 0)
                        {

                            _WorkOrderID = 0;
                            _PRMWorkOrderEntity = new PRMWorkOrderEntity();
                            PrepareInitialView();
                            BindPRMWorkOrderList();

                            MiscUtil.ShowMessage(lblMessage, "WorkOrder has been successfully Rejected.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to WorkOrder Rejected", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
                else if (string.Equals(e.CommandName, "UpdateItem"))
                {
                    try
                    {


                        #region Approval Process

                        Boolean apResult = APRobot.ResetApprovalProcessForWorkOrder(WorkOrderID);

                        if (apResult == true)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process has been reset successfully.", UIConstants.MessageType.GREEN);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to reset approval process.", UIConstants.MessageType.RED);
                        }

                       // EnableDisableApprovalProcessCheck();

                        BindList();

                        #endregion

                        //Int64 result = -1;

                        //String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, WorkOrderID.ToString(), SQLMatchType.Equal);

                        //PRMWorkOrderEntity pRMWorkOrderEntity = new PRMWorkOrderEntity();


                        //result = FCCPRMWorkOrder.GetFacadeCreate().Delete(pRMWorkOrderEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        //if (result == 0)
                        //{
                        //    _WorkOrderID = 0;
                        //    _PRMWorkOrderEntity = new PRMWorkOrderEntity();
                        //    PrepareInitialView();
                        //    BindPRMWorkOrderList();

                        //    MiscUtil.ShowMessage(lblMessage, "Work Order has been successfully deleted.", true);
                        //}
                        //else
                        //{
                        //    MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order.", true);
                        //}
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

        protected void odsPRMWorkOrder_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrder." + PRMWorkOrderEntity.FLD_NAME_WorkOrderStatusID, MasterDataConstants.WorkOrderStatus.INITIATED.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrder.WorkOrderNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MDWorkOrderStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrder.Subject", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier.SupplierName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
                String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe5, SQLJoinType.OR, fe6);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe5);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
