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
    public partial class CMBillListControl : BaseControl
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

        #endregion

        #region Methods

        private void BindList()
        {
            BindCMBillList();
        }

        private void BindCMBillList()
        {
            lvCMBill.DataBind();
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
            }
        }

        #endregion

        #region List View Event

        protected void lvCMBill_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMBill_DetailedEntity ent = (CMBill_DetailedEntity)dataItem.DataItem;
                HyperLink hypReport = (HyperLink)e.Item.FindControl("hypReport");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                HyperLink hypWorkOrderNo = (HyperLink)e.Item.FindControl("hypWorkOrderNo");
                Panel pnlRequisitonNoLV = (Panel)e.Item.FindControl("pnlRequisitonNoLV");
                Panel pnlMRRNoLV = (Panel)e.Item.FindControl("pnlMRRNoLV");

                hypWorkOrderNo.NavigateUrl=UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString()).ToString();

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BILL, ent.BillID);
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

                String fe_mrr = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_WorkOrderID, ent.WorkOrderID.ToString(), SQLMatchType.Equal);
                IList<PRMMaterialReceiveEntity> lstPRMMaterialReceive = FCCPRMMaterialReceive.GetFacadeCreate().GetIL(null, null, String.Empty, fe_mrr, DatabaseOperationType.LoadWithFilterExpression);

                if (lstPRMMaterialReceive != null && lstPRMMaterialReceive.Count > 0)
                {
                    //btnResetWorkOrderLV.Visible = false;

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
                IList<PRMWorkOrderItemMap_DetailedEntity> lstPRMWorkOrderItemMap = FCCPRMWorkOrderItemMap_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_req);

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

                hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty,"do",ReportConstants.BILL_REPORT, UrlConstants.OVERVIEW_CM_BILL_ID, ent.BillID.ToString()).ToString();
                hypReport.Target = "_blank";
                hypWorkOrderNo.Target = "_blank";
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

                    String url = UrlHelper.BuildSecureUrl("~/CM/CMBill.aspx", string.Empty, UrlConstants.OVERVIEW_CM_BILL_ID, BillID.ToString()).ToString();
                    Response.Redirect(url);
                    
                 
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
                            BindCMBillList();

                            MiscUtil.ShowMessage(lblMessage, "C MBill has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MBill.", true);
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
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CMBill.BillNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier.SupplierName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                Decimal billAmount;
                Decimal.TryParse(txtSearchText.Text, out billAmount);
                String fe3 = "CMBill.Amount = "+billAmount;
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("MDBillStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe5);
            }
            e.InputParameters["filterExpression"] = fe;
        }

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