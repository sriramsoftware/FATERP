// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jan-2012, 04:11:49




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
using System.Web.Security;
using Bay.ERP.Web.UI.Manager;
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionListControl : ProjectBaseControl
    {       
        #region Properties

        public String PageListType { get; set; }

        public Int64 _RequisitionID
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

        public REQRequisitionEntity _REQRequisitionEntity
        {
            get
            {
                REQRequisitionEntity entity = new REQRequisitionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (REQRequisitionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private REQRequisitionEntity CurrentREQRequisitionEntity
        {
            get
            {
                if (_RequisitionID > 0)
                {
                    if (_REQRequisitionEntity.RequisitionID != _RequisitionID)
                    {
                        _REQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(_RequisitionID);
                    }
                }

                return _REQRequisitionEntity;
            }
            set
            {
                _REQRequisitionEntity = value;
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
            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;
        }

        private void BindList()
        {
            BindREQRequisitionList();
        }

        private void BindREQRequisitionList()
        {
            lvREQRequisition.DataBind();
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
               // Activity Log
               // base.LogActivity("Viewing the Requisition List...", true);
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
                HyperLink hypEdit = (HyperLink)e.Item.FindControl("lnkBtnEdit");
                HyperLink hypRequisitionReport = (HyperLink)e.Item.FindControl("hypRequisitionReport");
                HyperLink hypCRMAdRequisitionReport = (HyperLink)e.Item.FindControl("hypCRMAdRequisitionReport");
                HyperLink hypRequisitionDetail = (HyperLink)e.Item.FindControl("hypRequisitionDetail");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                Label lblRequisitionItem = (Label)e.Item.FindControl("lblRequisitionItem");
                Label lblWorkOrderCreated = (Label)e.Item.FindControl("lblWorkOrderCreated");

                if (ent.RequisitionStatusID == MasterDataConstants.RequisitionStatus.MIGRATE_TO_TRF)
                {
                    String fe_TRF=SqlExpressionBuilder.PrepareFilterExpression(INVTransferEntity.FLD_NAME_RequisitionID,ent.RequisitionID.ToString(),SQLMatchType.Equal);
                    IList<INVTransferEntity> iNVTransferEntityList = FCCINVTransfer.GetFacadeCreate().GetIL(null, null, String.Empty, fe_TRF, DatabaseOperationType.LoadWithFilterExpression);

                    if (iNVTransferEntityList != null && iNVTransferEntityList.Count > 0)
                    {
                        Panel pnlTRFNoLV = (Panel)e.Item.FindControl("pnlTRFNoLV");

                        foreach (INVTransferEntity invTransferEntity in iNVTransferEntityList)
                        {
                            HyperLink hypTRFNoLV = new HyperLink();
                            hypTRFNoLV.Text = iNVTransferEntityList[0].TRFNo;
                            hypTRFNoLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/INV/INVTransferItem.aspx", string.Empty, UrlConstants.OVERVIEW_TRANSFER_ID, invTransferEntity.TransferID.ToString()).ToString();
                            hypTRFNoLV.Target = "_blank";
                            hypTRFNoLV.CssClass = "CommonButtonLink";

                            pnlTRFNoLV.Controls.Add(hypTRFNoLV);
                            pnlTRFNoLV.Controls.Add(new LiteralControl("<br/>"));
                        }
                      
                    }
                }

                Boolean IsAdvertisementRequisition=false;

                String feReqItem=SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem."+REQRequisitionItemEntity.FLD_NAME_RequisitionID,ent.RequisitionID.ToString(),SQLMatchType.Equal);
                IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(100000,1, String.Empty, feReqItem);

                if (lst != null && lst.Count > 0)
                {
                    foreach (REQRequisitionItem_DetailedEntity entREQRequisitionItem_DetailedEntity in lst)
                    {
                        lblRequisitionItem.Text += entREQRequisitionItem_DetailedEntity.MDItemItemName + ", ";

                        if(entREQRequisitionItem_DetailedEntity.ItemCategoryID==MasterDataConstants.ItemDefaults.DEFAULT_ADVERTIESMENT_ITEM_CATEGORY)
                        {
                            IsAdvertisementRequisition=true;
                        }
                    }

                    lblRequisitionItem.Text = lblRequisitionItem.Text.Substring(0, lblRequisitionItem.Text.Length - 2);
                }

                IList<PRMWorkOrderNoByRequisition_CustomEntity> lstWONO = FCCPRMWorkOrderNoByRequisition_Custom.GetFacadeCreate().GetIL(Int64.Parse(ent.RequisitionID.ToString()));

                if (lstWONO != null && lstWONO.Count > 0)
                {
                    lblWorkOrderCreated.Text = lstWONO[0].WorkOrderNo.ToString();
                }

                String fe_req = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrderItemMapEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), SQLMatchType.Equal);
                IList<PRMWorkOrderItemMap_DetailedEntity> lstPRMWorkOrderItemMap = FCCPRMWorkOrderItemMap_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_req);

                if (lstPRMWorkOrderItemMap != null && lstPRMWorkOrderItemMap.Count > 0)
                {

                    Panel pnlWorkOrderLV = (Panel)e.Item.FindControl("pnlWorkOrderLV");

                    List<PRMWorkOrderItemMap_DetailedEntity> distinct =
                                       lstPRMWorkOrderItemMap
                                       .GroupBy(car => car.WorkOrderID)
                                       .Select(g => g.First())
                                       .ToList();

                    foreach (PRMWorkOrderItemMap_DetailedEntity pRMWorkOrderItemMapEntity in distinct)
                    {
                        HyperLink hypWorkOrder = new HyperLink();
                        hypWorkOrder.Text = pRMWorkOrderItemMapEntity.WorkOrderNo.ToString();
                        hypWorkOrder.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, pRMWorkOrderItemMapEntity.WorkOrderID.ToString()).ToString();
                        hypWorkOrder.Target = "_blank";
                        hypWorkOrder.CssClass = "CommonButtonLink";

                        pnlWorkOrderLV.Controls.Add(hypWorkOrder);
                        pnlWorkOrderLV.Controls.Add(new LiteralControl("<br/>"));

                        String fe_mrr = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_WorkOrderID, pRMWorkOrderItemMapEntity.WorkOrderID.ToString(), SQLMatchType.Equal);
                        IList<PRMMaterialReceiveEntity> lstPRMMaterialReceive = FCCPRMMaterialReceive.GetFacadeCreate().GetIL(null, null, String.Empty, fe_mrr, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstPRMMaterialReceive != null && lstPRMMaterialReceive.Count > 0)
                        {
                            Panel pnlMRRLV = (Panel)e.Item.FindControl("pnlMRRLV");

                            foreach (PRMMaterialReceiveEntity pRMMaterialReceiveEntity in lstPRMMaterialReceive)
                            {
                                HyperLink hypMaterialReceive = new HyperLink();
                                hypMaterialReceive.Text = pRMMaterialReceiveEntity.MRRNo;
                                hypMaterialReceive.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "MaterialReceiveReport", UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, pRMMaterialReceiveEntity.MaterialReceiveID.ToString()).ToString();
                                hypMaterialReceive.Target = "_blank";
                                hypMaterialReceive.CssClass = "CommonButtonLink";

                                pnlMRRLV.Controls.Add(hypMaterialReceive);
                                pnlMRRLV.Controls.Add(new LiteralControl("<br/>"));
                            }
                        }
                    }
                }

                if (ent.RequisitionStatusID == MasterDataConstants.RequisitionStatus.APPROVED||
                    ent.RequisitionStatusID==MasterDataConstants.RequisitionStatus.MIGRATE_TO_TRF)
                {
                    hypEdit.Visible = false;
                }

                String NavigationUrl = String.Empty;

                NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "RequisitionReport", UrlConstants.REQUISITION_ID, ent.RequisitionID.ToString()).ToString();

                if (IsAdvertisementRequisition)
                {
                    NavigationUrl= UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.CRM_AD_REQUISITION_REPORT, UrlConstants.REQUISITION_ID, ent.RequisitionID.ToString()).ToString();
                }

                hypRequisitionReport.NavigateUrl = NavigationUrl;
                hypRequisitionReport.Target = "_blank";

                
                hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisition.aspx", string.Empty, "do", "Edit", UrlConstants.REQUISITION_ID, ent.RequisitionID.ToString()).ToString();
                if (this.OverviewProjectID > 0)
                {
                    hypRequisition.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectRequisitionItem.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo, ent.RequisitionNo.ToString()).ToString();
                }
                else
                {
                    hypRequisition.NavigateUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionItem.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo,ent.RequisitionNo.ToString()).ToString();
                    hypRequisitionDetail.NavigateUrl = UrlHelper.BuildSecureUrl("~/Site/REQRequisitionItemView.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo, ent.RequisitionNo.ToString()).ToString();
                }

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.REQUISITION, ent.RequisitionID);
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

                hypEdit.Target = "_blank";
                hypRequisitionReport.Target = "_blank";
                hypRequisitionDetail.Target = "_blank";
            }
        }

        protected void lvREQRequisition_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionID);

            if (RequisitionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _RequisitionID = RequisitionID;

                    PrepareEditView();
                }
               
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionID, RequisitionID.ToString(), SQLMatchType.Equal);

                        REQRequisitionEntity rEQRequisitionEntity = new REQRequisitionEntity();


                        result = FCCREQRequisition.GetFacadeCreate().Delete(rEQRequisitionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RequisitionID = 0;
                            _REQRequisitionEntity = new REQRequisitionEntity();
                            PrepareInitialView();
                            BindREQRequisitionList();

                            MiscUtil.ShowMessage(lblMessage, "Requisition has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Requisition.", true);
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

        protected void odsREQRequisition_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            if (this.OverviewProjectID > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
            }

            else
            {
                fe = "REQRequisition." + REQRequisitionEntity.FLD_NAME_ProjectID + "<> " + "4545454545";
            }

            if (PageListType == "RCSRequisitionList")
            {
                String fe1 = "REQRequisition.IsRCS = 1";
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MDRequisitionStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);

                if (txtSearchText.Text.Trim().IsNotNullOrEmpty())
                {
                  // Activity Log
                  //  base.LogActivity("Searching Requisition With " + txtSearchText.Text.Trim().ToString(), true);
                }
            }

            if (chbxShowLogedinApprovedRequisition.Checked)
            {
                Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                String compositeRequisitionID = String.Empty;

                if (employeeID > 0)
                {
                    IList<APApprovedRequisitionForWOByPanelMember_CustomEntity> lst = FCCAPApprovedRequisitionForWOByPanelMember_Custom.GetFacadeCreate().GetIL(employeeID);

                    if (lst != null && lst.Count > 0)
                    {
                        foreach(APApprovedRequisitionForWOByPanelMember_CustomEntity ent in lst)
                        {
                            compositeRequisitionID += ent.ReferenceID + ",";
                        }
                        compositeRequisitionID = compositeRequisitionID.Substring(0, compositeRequisitionID.Length - 1);
                    }
                }

                String fe_panelWO = "REQRequisition.RequisitionID in(" + compositeRequisitionID + ")";
                String fe_approved = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_RequisitionStatusID, MasterDataConstants.RequisitionStatus.APPROVED.ToString(), SQLMatchType.Equal);
                String fe_all = SqlExpressionBuilder.PrepareFilterExpression(fe_approved, SQLJoinType.AND, fe_panelWO);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe_all);
            }

            if (this.Page.User.Identity.IsAuthenticated == true)
            {
                if (Roles.IsUserInRole(this.Page.User.Identity.Name, "SiteUser") == true)
                {
                    String fe_assignedPerson1=SqlExpressionBuilder.PrepareFilterExpression(BDProjectAssignedPersonEntity.FLD_NAME_EmployeeID,MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString(),SQLMatchType.Equal);
                    String fe_assignedPerson2=SqlExpressionBuilder.PrepareFilterExpression(BDProjectAssignedPersonEntity.FLD_NAME_ProjectAssignedPersonTeamRoleID,MasterDataConstants.ProjectAssignedTeamRole.SITE_INCHARGE.ToString(),SQLMatchType.Equal);
                    String fe_assignedPerson=SqlExpressionBuilder.PrepareFilterExpression(fe_assignedPerson1,SQLJoinType.AND,fe_assignedPerson2);

                    IList<BDProjectAssignedPersonEntity> lst = FCCBDProjectAssignedPerson.GetFacadeCreate().GetIL(null, null, String.Empty, fe_assignedPerson, DatabaseOperationType.LoadWithFilterExpression);

                    if (lst != null && lst.Count > 0)
                    {
                        String compositeProjectID = String.Empty;

                        foreach (BDProjectAssignedPersonEntity ent in lst)
                        {
                            compositeProjectID += ent.ProjectID + ",";
                        }
                        compositeProjectID = compositeProjectID.Substring(0, compositeProjectID.Length - 1);

                        String fe1 = "REQRequisition.ProjectID In(" + compositeProjectID + ")";
                        fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                    }
                }
                else if(Roles.IsUserInRole(this.Page.User.Identity.Name, "Store Keeper") == true)
                {
                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_PreparedByMemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                }
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        protected void chbxShowLogedinApprovedRequisition_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
