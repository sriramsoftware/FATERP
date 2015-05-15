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
using System.Web.UI.HtmlControls;
using System.Text;

namespace Bay.ERP.Web.UI
{
    public partial class PRMWorkOrderViewWithApprovalControl : BaseControl
    {       
        #region Properties

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

        private PRMWorkOrderItemMapEntity CurrentPRMWorkOrderItemMapEntity
        {
            get
            {
                if (_WorkOrderItemMapID > 0)
                {
                    if (_PRMWorkOrderItemMapEntity.WorkOrderItemMapID != _WorkOrderItemMapID)
                    {
                        _PRMWorkOrderItemMapEntity = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetByID(_WorkOrderItemMapID);
                    }
                }

                return _PRMWorkOrderItemMapEntity;
            }
            set
            {
                _PRMWorkOrderItemMapEntity = value;
            }
        }

        public Int64 PRMWorkOrderID
        {
            get
            {
                Int64 _pRMWorkOrderID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID], out _pRMWorkOrderID);
                }

                return _pRMWorkOrderID;
            }
        }

        public PRMWorkOrder_DetailedEntity CurrentWorkOrderEntity
        {
            get
            {
                IList<PRMWorkOrder_DetailedEntity> lstWorkOrderEntity = new List<PRMWorkOrder_DetailedEntity>();

                if (PRMWorkOrderID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrder." + PRMWorkOrderEntity.FLD_NAME_WorkOrderID, PRMWorkOrderID.ToString(), SQLMatchType.Equal);
                    lstWorkOrderEntity = FCCPRMWorkOrder_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
                }

                return lstWorkOrderEntity[0];
            }
        }

        public Int64 _CurrentItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ItemID"] != null)
                {
                    Int64.TryParse(ViewState["ItemID"].ToString(), out id);
                }

                return id;
            }

            set
            {
                ViewState["ItemID"] = value;
            }
        }

        public Int64 _CurrentWorkOrderItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["vs_CurrentWorkOrderItemID"] != null)
                {
                    Int64.TryParse(ViewState["vs_CurrentWorkOrderItemID"].ToString(), out id);
                }

                return id;
            }

            set
            {
                ViewState["vs_CurrentWorkOrderItemID"] = value;
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

        #endregion

        #region Properties PopUp

        public Int64 _WorkOrderItemDetailID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ItemDetailID"] != null)
                {
                    Int64.TryParse(ViewState["ItemDetailID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ItemDetailID"] = value;
            }
        }

        public PRMWorkOrderItemDetailEntity _PRMWorkOrderItemDetailEntity
        {
            get
            {
                PRMWorkOrderItemDetailEntity entity = new PRMWorkOrderItemDetailEntity();

                if (ViewState["CurrentWorkOrderItemDetailEntity"] != null)
                {
                    entity = (PRMWorkOrderItemDetailEntity)ViewState["CurrentWorkOrderItemDetailEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentWorkOrderItemDetailEntity"] = value;
            }
        }

        private PRMWorkOrderItemDetailEntity CurrentPRMWorkOrderItemDetailEntity
        {
            get
            {
                if (_WorkOrderItemDetailID > 0)
                {
                    if (_PRMWorkOrderItemDetailEntity.WorkOrderItemDetailID != _WorkOrderItemDetailID)
                    {
                        _PRMWorkOrderItemDetailEntity = FCCPRMWorkOrderItemDetail.GetFacadeCreate().GetByID(_WorkOrderItemDetailID);
                    }
                }

                return _PRMWorkOrderItemDetailEntity;
            }
            set
            {
                _PRMWorkOrderItemDetailEntity = value;
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
            Response.Redirect("~/AP/APPendingList.aspx");
        }

        private void RedirectPageToForwardList()
        {
            Response.Redirect("~/AP/APPendingList.aspx");
        }

        private void RedirectPageToPendingList()
        {
            Response.Redirect("~/AP/APPendingList.aspx");
        }

        private void RedirectPageToProxyList()
        {
            Response.Redirect("~/AP/APProxyApprovalRequest.aspx");
        }

        private void BuildDropDownList()
        {   
            BuildREQRequisitionItem();

            #region Approval Dropdown

            if (!(APForwardInfoID > 0))
            {
                ddlAction.Items.Add(new ListItem("Approve", "1"));
                ddlAction.Items.Add(new ListItem("Back", "2"));
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
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);
                ddlForwardTo.DataBind();
            }
            else
            {
                ddlAction.Items.Add(new ListItem("Comment", "4"));
            }

            #endregion
        }

        private void BuildREQRequisitionItem()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            lblWorkOrderNo.Text = CurrentWorkOrderEntity.WorkOrderNo.ToString();
            BuildGrandTotalLabel();

            #region Build Hyperlink

            if (CurrentWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.APPROVED)
            {
                hypWorkOrder.NavigateUrl = String.Empty;
                hypWorkOrderItem.NavigateUrl = String.Empty;
                hypWorkOrderPaymentTerm.NavigateUrl = String.Empty;
            }
            else
            {
                hypWorkOrder.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrder.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString()).ToString(); ;
                hypWorkOrderItem.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, CurrentWorkOrderEntity.WorkOrderNo).ToString();
                hypWorkOrderPaymentTerm.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderPaymentTerm.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, CurrentWorkOrderEntity.WorkOrderNo).ToString();
            }

            hypReport.NavigateUrl=UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "WorkOrderReport", UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString()).ToString();

            hypReport.Target = "_blank";

            if (CurrentWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.CANCELED||
                CurrentWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.APPROVED||
                CurrentWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.REJECTED)
            {
                btnCancelWO.Enabled = false;
            }
            #endregion

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            PrepareInitialViewPopup();

            #endregion
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
                       // addPanel.Visible = false;
                       // btnSubmit.Visible = false;
                    }
                    else
                    {
                      //  addPanel.Visible = true;
                       // btnSubmit.Visible = true;
                    }
                }
                else
                {
                   // addPanel.Visible = false;
                   // btnSubmit.Visible = false;
                }
            }
            else
            {
                btnApprove.Enabled = false;
                btnReject.Enabled = false;
                btnForward.Enabled = false;

                //addPanel.Visible = false;
                //btnSubmit.Visible = false;
            }
        }

        private void PrepareEditView()
        {
            PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity = CurrentPRMWorkOrderItemMapEntity;


            if (!pRMWorkOrderItemMapEntity.IsNew)
            {
              
            }
        }

        private void BindList()
        {
            BindPRMWorkOrderItemMapList();
        }

        private void BindPRMWorkOrderItemMapList()
        {
            lvPRMWorkOrderItemMap.DataBind();
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

        private void BuildGrandTotalLabel()
        {
            if (PRMWorkOrderID > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, PRMWorkOrderID.ToString(), SQLMatchType.Equal);
                IList<PRMWorkOrderItemMapEntity> lst = FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    var transinfo = (from transaction in lst
                                     select transaction.RequiredQty * transaction.Rate).Sum(val => val);

                    PRMWorkOrderEntity pRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(PRMWorkOrderID);
                    Decimal totalPrice = transinfo;
                    Decimal AIT, Discount, Vat, Tax, CarryingCharge;

                    Decimal.TryParse(pRMWorkOrderEntity.AIT.ToString(), out AIT);
                    Decimal.TryParse(pRMWorkOrderEntity.Discount.ToString(), out Discount);
                    Decimal.TryParse(pRMWorkOrderEntity.CarryingCharge.ToString(), out CarryingCharge);
                    Decimal.TryParse(pRMWorkOrderEntity.VAT.ToString(), out Vat);
                    Decimal.TryParse(pRMWorkOrderEntity.Tax.ToString(), out Tax);

                    totalPrice += AIT;
                    totalPrice += Discount;
                    totalPrice -= Vat;
                    totalPrice -= Tax;
                    totalPrice -= CarryingCharge;
                    //lblGrandTotal.Text = Math.Round(transinfo,2).ToString();
                    lblGrandTotal.Text = MiscUtil.NumericCommaSeperatedFormat((Decimal)totalPrice);
                }
            }
        }

        #endregion

        #region Methods PopUp

        private void BuildDropDownListPopup()
        {
            //MiscUtil.PopulateMDUnit(ddlUnitID, true);
        }

        private void PrepareInitialViewPopup()
        {
            //BuildDropDownListPopup();

            //txtDescription.Text = String.Empty;
            //txtPopupRate.Text = String.Empty;
            //txtQty.Text = String.Empty;

            //btnAddPopup.Text = "Add";
            //btnAddNewPopup.Visible = false;
        }

        private void PrepareEditViewPopup()
        {
            //PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = CurrentPRMWorkOrderItemDetailEntity;


            //if (!pRMWorkOrderItemDetailEntity.IsNew)
            //{

            //    txtDescription.Text = pRMWorkOrderItemDetailEntity.Description.ToString();
            //    if (ddlUnitID.Items.Count > 0 && pRMWorkOrderItemDetailEntity.UnitID != null)
            //    {
            //        ddlUnitID.SelectedValue = pRMWorkOrderItemDetailEntity.UnitID.ToString();
            //    }

            //    txtPopupRate.Text = pRMWorkOrderItemDetailEntity.Rate.ToString();
            //    txtQty.Text = pRMWorkOrderItemDetailEntity.Qty.ToString();

            //    btnSubmit.Text = "Update";
            //    btnAddNew.Visible = true;
            //}
        }

        private void BindListPopup()
        {
            BindPRMWorkOrderItemDetailList();
        }

        private void BindPRMWorkOrderItemDetailList()
        {
            lvPRMWorkOrderItemDetail.DataBind();
        }

        private PRMWorkOrderItemDetailEntity BuildPRMWorkOrderItemDetailEntity()
        {
            PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = CurrentPRMWorkOrderItemDetailEntity;

            //pRMWorkOrderItemDetailEntity.WorkOrderItemMapID = _WorkOrderItemMapID;
            //pRMWorkOrderItemDetailEntity.Description = txtDescription.Text.Trim();
            //if (ddlUnitID.Items.Count > 0)
            //{
            //    if (ddlUnitID.SelectedValue == "0")
            //    {
            //        pRMWorkOrderItemDetailEntity.UnitID = null;
            //    }
            //    else
            //    {
            //        pRMWorkOrderItemDetailEntity.UnitID = Int64.Parse(ddlUnitID.SelectedValue);
            //    }
            //}

            //if (!txtPopupRate.Text.Trim().IsNullOrEmpty())
            //{
            //    pRMWorkOrderItemDetailEntity.Rate = Decimal.Parse(txtPopupRate.Text.Trim());
            //}

            //if (!txtQty.Text.Trim().IsNullOrEmpty())
            //{
            //    pRMWorkOrderItemDetailEntity.Qty = Decimal.Parse(txtQty.Text.Trim());
            //}


            return pRMWorkOrderItemDetailEntity;
        }

        private void SavePRMWorkOrderItemDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    //PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = BuildPRMWorkOrderItemDetailEntity();

                    //Int64 result = -1;

                    //if (pRMWorkOrderItemDetailEntity.IsNew)
                    //{
                    //    result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Add(pRMWorkOrderItemDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    //}
                    //else
                    //{
                    //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemDetailID, pRMWorkOrderItemDetailEntity.WorkOrderItemDetailID.ToString(), SQLMatchType.Equal);
                    //    result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Update(pRMWorkOrderItemDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    //}

                    //if (result > 0)
                    //{
                    //    _WorkOrderItemDetailID = 0;
                    //    _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
                    //    PrepareInitialViewPopup();
                    //    BindPRMWorkOrderItemDetailList();

                    //    if (pRMWorkOrderItemDetailEntity.IsNew)
                    //    {
                    //        MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail Information has been added successfully.", false);
                    //    }
                    //    else
                    //    {
                    //        MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail Information has been updated successfully.", false);
                    //    }
                    //}
                    //else
                    //{
                    //    if (pRMWorkOrderItemDetailEntity.IsNew)
                    //    {
                    //        MiscUtil.ShowMessage(lblMessage, "Failed to add Work Order Item Detail Information.", false);
                    //    }
                    //    else
                    //    {
                    //        MiscUtil.ShowMessage(lblMessage, "Failed to update Work Order Item Detail Information.", false);
                    //    }
                    //}
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
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvPRMWorkOrderItemMap_ItemCommand(object sender, ListViewCommandEventArgs e)
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

        #region List View Event(Popup)

        protected void lvPRMWorkOrderItemDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            //Int64 WorkOrderItemDetailID;

            //Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderItemDetailID);

            //if (WorkOrderItemDetailID > 0)
            //{
            //    if (string.Equals(e.CommandName, "EditItem"))
            //    {
            //        _WorkOrderItemDetailID = WorkOrderItemDetailID;

            //      //  PrepareEditViewPopup();

            //        cpeEditor.Collapsed = false;
            //        cpeEditor.ClientState = "false";
            //    }
            //    else if (string.Equals(e.CommandName, "DeleteItem"))
            //    {
            //        try
            //        {
            //            Int64 result = -1;

            //            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemDetailID, WorkOrderItemDetailID.ToString(), SQLMatchType.Equal);

            //            PRMWorkOrderItemDetailEntity pRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();


            //            result = FCCPRMWorkOrderItemDetail.GetFacadeCreate().Delete(pRMWorkOrderItemDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

            //            if (result == 0)
            //            {
            //                _WorkOrderItemDetailID = 0;
            //                _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
            //                PrepareInitialView();
            //             //   BindPRMWorkOrderItemDetailList();

            //                MiscUtil.ShowMessage(lblMessage, "Work Order Item Detail has been successfully deleted.", true);
            //            }
            //            else
            //            {
            //                MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order Item Detail.", true);
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MiscUtil.ShowMessage(lblMessage, ex.Message, true);
            //        }
            //    }
            //}
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsPRMWorkOrderItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemMap." + PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, PRMWorkOrderID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
           // SavePRMWorkOrderItemMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _WorkOrderItemMapID = 0;
            _PRMWorkOrderItemMapEntity = new PRMWorkOrderItemMapEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
          
            APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);

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
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID, rejectToAPMemberFeedbackID);
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
            RedirectPageToPendingList();
        }

        protected void btnForward_Click(object sender, EventArgs e)
        {
            if (chbxAutoForwardTo.Checked)
            {
                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);

                IList<APMemberFeedbackEntity> feedbackList = APRobot.GetAllMemberFeedbacks(aPApprovalProcessEntity.APApprovalProcessID);

                IList<APMemberFeedbackEntity> ordered_list = feedbackList.OrderBy(x => x.SequenceNo).ToList();

                APPanelForwardMemberEntity aPPanelForwardMemberEntity = APRobot.GetAPPanelForwardMemberByID(Int64.Parse(ddlForwardTo.SelectedValue));

                var existsInfo = (from s in ordered_list
                                  where s.EmployeeID.ToString() == aPPanelForwardMemberEntity.EmployeeID.ToString()
                                  select s);

                if (existsInfo != null && existsInfo.Count()>0)
                {
                    MiscUtil.ShowMessage(lblMessage, "Member Already Exists in the Approval Panel", true);
                    return;
                }

                APMemberFeedbackEntity currentEmployeeInfo = (from r in ordered_list
                                                              where r.EmployeeID.ToString() == MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString()
                                                              select r).FirstOrDefault();

                if (currentEmployeeInfo != null)
                {
                    ordered_list = (from m in ordered_list
                                    where m.SequenceNo > currentEmployeeInfo.SequenceNo
                                    select m).ToList();

                    
                    
                    APMemberFeedbackEntity aPMemberFeedbackEntity = new APMemberFeedbackEntity();

                    aPMemberFeedbackEntity.APApprovalProcessID = aPApprovalProcessEntity.APApprovalProcessID;
                    aPMemberFeedbackEntity.DepartmentID = aPPanelForwardMemberEntity.DepartmentID;
                    aPMemberFeedbackEntity.EmployeeID = aPPanelForwardMemberEntity.EmployeeID;
                    aPMemberFeedbackEntity.SequenceNo = currentEmployeeInfo.SequenceNo+1;
                    aPMemberFeedbackEntity.APFeedbackID = MasterDataConstants.APFeedback.NOT_YET_REQUESTED;
                    aPMemberFeedbackEntity.FeedbackRequestDate = DateTime.Now;
                    aPMemberFeedbackEntity.FeedbackLastResponseDate = null;
                    aPMemberFeedbackEntity.FeedbackSubmitDate = null;
                    aPMemberFeedbackEntity.IsProxyEmployeeEnabled = false;
                    aPMemberFeedbackEntity.ProxyEmployeeID = null;

                    Int64 aPMemberFeedbackID = FCCAPMemberFeedback.GetFacadeCreate().Add(aPMemberFeedbackEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    foreach (APMemberFeedbackEntity ent in ordered_list)
                    {
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, ent.APMemberFeedbackID.ToString(), SQLMatchType.Equal);
                        ent.SequenceNo += 1;
                        FCCAPMemberFeedback.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);

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
            }

            //Previous Code

            else
            {
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
                    sb.Append("A WorkOrder Forwarded Request is waiting for your approval");
                    sb.Append("<br/>");
                    sb.Append("<br/>");
                    sb.Append("-");
                    sb.Append("<br/>");
                    sb.Append("Thanks");
                    sb.Append("<br/>");
                    sb.Append("ERP System");
                    MailBody = sb.ToString();
                    Subject = "ERP, WorkOrder, Forwarded";

                    HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(aPForwardInfoEntity.EmployeeID);

                    if (_hREmployeeEntity != null)
                    {
                        String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                        MiscUtil.SendMail(sendToMail, Subject, MailBody);
                    }

                    #endregion

                    RedirectPageToPendingList();
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to forward", UIConstants.MessageType.RED);
                }
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

        protected void ddlRequisitionItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddlRequisitionID.SelectedValue != "0" && ddlRequisitionID.Items.Count > 0)
            //{
            //    String filterExpression = String.Empty;
            //    String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionItem_CustomEntity.FLD_NAME_RequisitionID, ddlRequisitionID.SelectedValue.ToString(), SQLMatchType.Equal);
            //    String fe2 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItem_CustomEntity.FLD_NAME_RequisitionItemID, ddlRequisitionItemID.SelectedValue.ToString(), SQLMatchType.Equal);
            //    filterExpression = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            //    IList<REQRequisitionItem_CustomEntity> requisitonItemList = FCCREQRequisitionItem_Custom.GetFacadeCreate().GetIL(filterExpression);

            //    if (requisitonItemList != null && requisitonItemList.Count > 0)
            //    {
            //        txtRate.Text = requisitonItemList[0].Rate.ToString();
            //        txtRequiredQty.Text = requisitonItemList[0].PresentRequiredQty.ToString();
            //    }
            //}
        }

        protected void ddlRequisitionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildREQRequisitionItem();
        }

        #endregion

        #region ObjectDataSource Event Popup

        protected void odsPRMWorkOrderItemDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrderItemDetail." + PRMWorkOrderItemDetailEntity.FLD_NAME_WorkOrderItemMapID, _WorkOrderItemMapID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event Popup

        protected void btnSavePopup_Click(object sender, EventArgs e)
        {
            SavePRMWorkOrderItemDetailEntity();
            this.Panel1_ModalPopupExtender.Show();
        }

        protected void btnPnlCancelWO_Click(object sender, EventArgs e)
        {
            PRMWorkOrderEntity pRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(PRMWorkOrderID);
            pRMWorkOrderEntity.WorkOrderStatusID = MasterDataConstants.WorkOrderStatus.CANCELED;
            pRMWorkOrderEntity.Remarks = txtWOCancelRemarks.Text.Trim().ToString();

            Int64 result = -1;
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, PRMWorkOrderID.ToString(), SQLMatchType.Equal);
            result = FCCPRMWorkOrder.GetFacadeCreate().Update(pRMWorkOrderEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

            if (result > 0)
            {
                #region AP Update

                APApprovalProcessEntity aPApprovalProcessEntity = FCCAPApprovalProcess.GetFacadeCreate().GetByID(APApprovalProcessID);

                if (aPApprovalProcessEntity != null && aPApprovalProcessEntity.APApprovalProcessID > 0)
                {
                    aPApprovalProcessEntity.APStatusID = MasterDataConstants.APStatus.CANCELED;

                    Int64 resultOne = -1;

                    String fe_one = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APApprovalProcessID, APApprovalProcessID.ToString(), SQLMatchType.Equal);
                    resultOne = FCCAPApprovalProcess.GetFacadeCreate().Update(aPApprovalProcessEntity, fe_one, DatabaseOperationType.Update, TransactionRequired.No);

                    if (resultOne > 0)
                    {
                        APMemberFeedbackEntity aPMemberFeedbackEntity = FCCAPMemberFeedback.GetFacadeCreate().GetByID(APMemberFeedbackID);

                        if (aPMemberFeedbackEntity != null && aPMemberFeedbackEntity.APMemberFeedbackID > 0)
                        {
                            aPMemberFeedbackEntity.APFeedbackID = MasterDataConstants.APFeedback.CANCELED;

                            Int64 resultC = -1;
                            String fe_memberfeedback = SqlExpressionBuilder.PrepareFilterExpression(APMemberFeedbackEntity.FLD_NAME_APMemberFeedbackID, APMemberFeedbackID.ToString(), SQLMatchType.Equal);

                            resultC = FCCAPMemberFeedback.GetFacadeCreate().Update(aPMemberFeedbackEntity, fe_memberfeedback, DatabaseOperationType.Update, TransactionRequired.No);

                            RedirectPageToPendingList();
                        }
                    }
                }

                #endregion
            }
        }

        protected void btnAddNewPopup_Click(object sender, EventArgs e)
        {
            _WorkOrderItemDetailID = 0;
            _PRMWorkOrderItemDetailEntity = new PRMWorkOrderItemDetailEntity();
            PrepareInitialViewPopup();
        }

        protected void btnClearPopup_Click(object sender, EventArgs e)
        {
            PrepareInitialViewPopup();
            PrepareEditViewPopup();
            this.Panel1_ModalPopupExtender.Show();
        }

        #endregion

        #endregion Event
    }
}
