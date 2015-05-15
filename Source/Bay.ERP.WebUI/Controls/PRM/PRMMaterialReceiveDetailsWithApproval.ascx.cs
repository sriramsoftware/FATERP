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
using System.Data;
using Bay.ERP.Web.UI.Manager;
using System.Web.UI.HtmlControls;
using System.Text;

namespace Bay.ERP.Web.UI
{
    public partial class PRMMaterialReceiveDetailsWithApprovalControl : BaseControl
    {       
        #region Properties

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public IList<PRMMaterialReceiveItemMapEntity> PRMMaterialReceiveItemMapList
        {
            get
            {
                return (IList<PRMMaterialReceiveItemMapEntity>)ViewState["vs_CurrentMaterialReceiveItemMapEntity"];
            }
            set
            {
                ViewState["vs_CurrentMaterialReceiveItemMapEntity"] = value;
            }
        }

        public Int64 _MaterialReceiveID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID], out id);
                    ViewState["ID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public PRMMaterialReceiveEntity _PRMMaterialReceiveEntity
        {
            get
            {
                PRMMaterialReceiveEntity entity = new PRMMaterialReceiveEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMMaterialReceiveEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMMaterialReceiveEntity CurrentPRMMaterialReceiveEntity
        {
            get
            {
                if (_MaterialReceiveID > 0)
                {
                    if (_PRMMaterialReceiveEntity.MaterialReceiveID != _MaterialReceiveID)
                    {
                        _PRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(_MaterialReceiveID);
                    }
                }

                return _PRMMaterialReceiveEntity;
            }
            set
            {
                _PRMMaterialReceiveEntity = value;
            }
        }

        public Int64 _WorkOrderItemMapID
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

        public PRMWorkOrderItemMapEntity _PRMWorkOrderItemMapEntity
        {
            get
            {
                PRMWorkOrderItemMapEntity entity = new PRMWorkOrderItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMWorkOrderItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        public IList<PRMMaterialReceiveItemMapEntity> UpdatedMappedPRMMaterialReceiveEntity
        {
            get
            {
                return (IList<PRMMaterialReceiveItemMapEntity>)ViewState["vs_UpdatedMappedPRMMaterialReceiveEntity"];
            }
            set
            {
                ViewState["vs_UpdatedMappedPRMMaterialReceiveEntity"] = value;
            }
        }


        public Int64 OverviewMaterialReceiveID
        {
            get
            {
                Int64 materialReceiveID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID], out materialReceiveID);
                    //_BankAccountTransferID = bankAccountTransferID;
                }

                return materialReceiveID;
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
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.MRR, OverviewMaterialReceiveID);
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

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);

            if (ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMSupplierByProjectID(ddlSupplierID, false, Int64.Parse(ddlProjectID.SelectedValue));
                ddlRequisitionID.Items.Clear();
                ddlWorkOrderID.Items.Clear();

                if (ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0)
                {
                    MiscUtil.PopulatePRMRequisitionBySupplierID(ddlRequisitionID, false, Int64.Parse(ddlSupplierID.SelectedValue));

                    if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
                    {
                        MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, false, Int64.Parse(ddlRequisitionID.SelectedValue));
                    }
                }
            }
            
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BuildDropDownAPList();
            BindList();

            txtMRRNo.Text = String.Empty;
            txtMRRDate.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
            txtRemarks.Text = String.Empty;

            PRMMaterialReceiveItemMapList = new List<PRMMaterialReceiveItemMapEntity>();
            UpdatedMappedPRMMaterialReceiveEntity = new List<PRMMaterialReceiveItemMapEntity>();

            hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "MaterialReceiveReport", UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, _MaterialReceiveID.ToString()).ToString();

            hypReport.Target = "_blank";

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            //EnableDisableApprovalButtons();

            #endregion

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            PRMMaterialReceiveEntity pRMMaterialReceiveEntity = CurrentPRMMaterialReceiveEntity;

            if (!pRMMaterialReceiveEntity.IsNew)
            {
                if (ddlProjectID.Items.Count > 0 && pRMMaterialReceiveEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = pRMMaterialReceiveEntity.ProjectID.ToString();
                }

                BindRequisitonAndWOByProject();

                if (ddlSupplierID.Items.Count > 0 && pRMMaterialReceiveEntity.SupplierID != null)
                {
                    ddlSupplierID.SelectedValue = pRMMaterialReceiveEntity.SupplierID.ToString();
                }

                BindRequisitionBySupplier();

                if (ddlRequisitionID.Items.Count > 0 && pRMMaterialReceiveEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = pRMMaterialReceiveEntity.RequisitionID.ToString();
                }

                BindWorkorderByRequisition();

                if (ddlWorkOrderID.Items.Count > 0 && pRMMaterialReceiveEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = pRMMaterialReceiveEntity.WorkOrderID.ToString();
                }

                txtMRRNo.Text = pRMMaterialReceiveEntity.MRRNo.ToString();
                txtMRRDate.Text = pRMMaterialReceiveEntity.MRRDate.ToStringDefault();
                txtRemarks.Text = pRMMaterialReceiveEntity.Remarks.ToString();

                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, _MaterialReceiveID.ToString(), SQLMatchType.Equal);
                UpdatedMappedPRMMaterialReceiveEntity = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                if (UpdatedMappedPRMMaterialReceiveEntity != null && UpdatedMappedPRMMaterialReceiveEntity.Count > 0)
                {
                    PRMMaterialReceiveItemMapList = UpdatedMappedPRMMaterialReceiveEntity;
                }
                else
                {
                    UpdatedMappedPRMMaterialReceiveEntity = new List<PRMMaterialReceiveItemMapEntity>();
                }

                BindPRMWorkOrderItemMapList();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = false;
            }
        }

        private void BindList()
        {
            BindPRMWorkOrderItemMapList();
        }

        private void BindPRMWorkOrderItemMapList()
        {
            //String fe = String.Empty;

            ////if (chbxSelectWorkOrder.Checked)
            ////{
            //    if (ddlWorkOrderID.SelectedValue != "0" && ddlWorkOrderID.Items.Count > 0 && ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0 && ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0 && ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            //    {
            //        String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + PRMWorkOrder_CustomEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
            //        String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrder." + PRMWorkOrder_CustomEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString(), SQLMatchType.Equal);
            //        fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            //        String fe3 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrder_CustomEntity.FLD_NAME_WorkOrderID, ddlWorkOrderID.SelectedValue.ToString(), SQLMatchType.Equal);
            //        String fe4 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrder_CustomEntity.FLD_NAME_RequisitionID, ddlRequisitionID.SelectedValue.ToString(), SQLMatchType.Equal);
            //        fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            //        fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);
            //    }

            //    lvPRMWorkOrderItemMap.DataSource = FCCPRMWorkOrder_Custom.GetFacadeCreate().GetDT(fe);
            //    lvPRMWorkOrderItemMap.DataBind();
            //}

            //else if (chbxSelectRequisition.Checked)
            //{
            //    String fe1 = String.Empty;

            //    if (ddlWorkOrderID.SelectedValue != "0" && ddlWorkOrderID.Items.Count > 0 && ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0 && ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0 && ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            //    {
            //        fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionID", ddlRequisitionID.SelectedValue.ToString(), SQLMatchType.Equal);
            //    }

            //    lvPRMWorkOrderItemMap.DataSource = FCCPRMMaterialRequisitionItem_Custom.GetFacadeCreate().GetIL(fe1);
            //    lvPRMWorkOrderItemMap.DataBind();
            //}

           
        }

        private PRMMaterialReceiveEntity BuildPRMMaterialReceiveEntity()
        {
            PRMMaterialReceiveEntity pRMMaterialReceiveEntity = CurrentPRMMaterialReceiveEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMMaterialReceiveEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMMaterialReceiveEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (ddlRequisitionID.Items.Count > 0)
            {
                if (ddlRequisitionID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMMaterialReceiveEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                }
            }

            if (ddlWorkOrderID.Items.Count > 0)
            {
                if (ddlWorkOrderID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMMaterialReceiveEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                }
            }
        
            pRMMaterialReceiveEntity.MRRNo = txtMRRNo.Text.Trim();
            if (txtMRRDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMMaterialReceiveEntity.MRRDate = MiscUtil.ParseToDateTime(txtMRRDate.Text);
            }

            pRMMaterialReceiveEntity.Remarks = txtRemarks.Text.Trim();

            return pRMMaterialReceiveEntity;
        }


        private void UpdateMaterialReceiveEntity()
        {
            IList<ListViewDataItem> list = lvPRMMaterialReceiveItemMap.Items;

            if (list != null && list.Count > 0)
            {
                Int32 tempDataItemIndex = 0;

                foreach (ListViewDataItem lvdi in list)
                {
                    DataKey currentDataKey = lvPRMMaterialReceiveItemMap.DataKeys[tempDataItemIndex++];
                    Int64 materialReceiveItemMapID = (Int64)currentDataKey["MaterialReceiveItemMapID"];

                    Decimal ReceiveQty;

                   // Label lblRequisitonItemIDLV = (Label)lvdi.FindControl("lblRequisitonItemIDLV");
                    TextBox txtReceiveQtyLV = (TextBox)lvdi.FindControl("txtReceiveQtyLV");
                   // TextBox txtChallanNoLV = (TextBox)lvdi.FindControl("txtChallanNoLV");
                    //TextBox txtReceiveDateLV = (TextBox)lvdi.FindControl("txtReceiveDateLV");
                    //Label lblRateLV = (Label)lvdi.FindControl("lblRateLV");

                    Decimal.TryParse(txtReceiveQtyLV.Text.Trim(), out ReceiveQty);
                    //Decimal.TryParse(lblRateLV.Text.Trim(), out rateLV);

                    PRMMaterialReceiveItemMapEntity ent = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetByID(materialReceiveItemMapID);
                    ent.ReceiveQty = ReceiveQty;
                    
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveItemMapID, materialReceiveItemMapID.ToString(), SQLMatchType.Equal);
                    FCCPRMMaterialReceiveItemMap.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
                }
            }
        }
        private void SavePRMMaterialReceiveEntity()
        {
            if (IsValid)
            {

                try
                {
                    PRMMaterialReceiveEntity pRMMaterialReceiveEntity = BuildPRMMaterialReceiveEntity();

                    Int64 result = -1;

                    if (pRMMaterialReceiveEntity.IsNew)
                    {
                        result = FCCPRMMaterialReceive.GetFacadeCreate().Add(pRMMaterialReceiveEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }

                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveID, pRMMaterialReceiveEntity.MaterialReceiveID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMMaterialReceive.GetFacadeCreate().Update(pRMMaterialReceiveEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                       // BuildPRMMaterialReceiveItemEntity(result, pRMMaterialReceiveEntity);
                        _MaterialReceiveID = 0;
                        _PRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();
                        PrepareInitialView();

                        if (pRMMaterialReceiveEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Material Receive Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Material Receive Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMMaterialReceiveEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Material Receive Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Material Receive Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
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
            }
        }

        #endregion

        #region List View Event

        protected void lvPRMMaterialReceiveItemMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MaterialReceiveItemMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out MaterialReceiveItemMapID);

            if (MaterialReceiveItemMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    //_MaterialReceiveItemMapID = MaterialReceiveItemMapID;

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveItemMapID, MaterialReceiveItemMapID.ToString(), SQLMatchType.Equal);

                        PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity = new PRMMaterialReceiveItemMapEntity();


                        result = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().Delete(pRMMaterialReceiveItemMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            //_MaterialReceiveItemMapID = 0;
                            //_PRMMaterialReceiveItemMapEntity = new PRMMaterialReceiveItemMapEntity();
                            //PrepareInitialView();
                            //BindPRMMaterialReceiveItemMapList();

                            MiscUtil.ShowMessage(lblMessage, "Material Receive Item Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Material Receive Item Map.", true);
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

        #region ObjectDataSource Event

        protected void odsPRMMaterialReceiveItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceiveItemMap." + PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, OverviewMaterialReceiveID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            UpdateMaterialReceiveEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MaterialReceiveID = 0;
            _PRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;

            APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.MRR, OverviewMaterialReceiveID);

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
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.MRR, OverviewMaterialReceiveID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.MRR, OverviewMaterialReceiveID, rejectToAPMemberFeedbackID);
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
                sb.Append("A MRR Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, MRR, Forwarded";

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

        #region DropDownEvent

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindRequisitonAndWOByProject();
            BindList();
        }

        private void BindRequisitonAndWOByProject()
        {
            if (ddlProjectID.SelectedValue != "0" && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMSupplierByProjectID(ddlSupplierID, false, Int64.Parse(ddlProjectID.SelectedValue));
                ddlRequisitionID.Items.Clear();
                ddlWorkOrderID.Items.Clear();

                if (ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0)
                {
                    MiscUtil.PopulatePRMRequisitionBySupplierID(ddlRequisitionID, false, Int64.Parse(ddlSupplierID.SelectedValue));

                    if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
                    {
                        MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, false, Int64.Parse(ddlRequisitionID.SelectedValue));
                    }
                }
            }
        }

        protected void ddlSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindRequisitionBySupplier();

            BindList();
        }

        private void BindRequisitionBySupplier()
        {
            ddlRequisitionID.Items.Clear();
            ddlWorkOrderID.Items.Clear();

            if (ddlSupplierID.SelectedValue != "0" && ddlSupplierID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMRequisitionBySupplierID(ddlRequisitionID, false, Int64.Parse(ddlSupplierID.SelectedValue));

                if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
                {
                    MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, false, Int64.Parse(ddlRequisitionID.SelectedValue));
                }
            }
        }

        protected void ddlRequisitionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindWorkorderByRequisition();
            BindList();
        }

        private void BindWorkorderByRequisition()
        {
            ddlWorkOrderID.Items.Clear();

            if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, false, Int64.Parse(ddlRequisitionID.SelectedValue));
            }
        }

        protected void ddlWorkOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #region Check Box Event

        protected void chbxSelectRequisition_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSelectRequisition.Checked)
            {
                chbxSelectWorkOrder.Checked = false;
            }
            else if (chbxSelectRequisition.Checked == false)
            {
                chbxSelectWorkOrder.Checked = true;
            }
            BindPRMWorkOrderItemMapList();
        }

        protected void chbxSelectWorkOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSelectWorkOrder.Checked)
            {
                chbxSelectRequisition.Checked = false;
            }
            else if(chbxSelectWorkOrder.Checked==false)
            {
                chbxSelectRequisition.Checked = true;
            }

            BindPRMWorkOrderItemMapList();
        }

        #endregion

        #endregion Event
    }
}
