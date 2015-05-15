// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI.HtmlControls;
using Bay.ERP.Web.UI.Manager;
using System.Text;

namespace Bay.ERP.Web.UI
{
    public partial class CRMAgreementDetailsWithApprovalControl : BaseControl
    {

        #region Properties

        public Int64 _AgreementID
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

        public CRMAgreementEntity _CRMAgreementEntity
        {
            get
            {
                CRMAgreementEntity entity = new CRMAgreementEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMAgreementEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMAgreementEntity CurrentCRMAgreementEntity
        {
            get
            {
                if (OverviewAgreementID > 0)
                {
                    _CRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(OverviewAgreementID);
                }

                return _CRMAgreementEntity;
            }
            set
            {
                _CRMAgreementEntity = value;
            }
        }

        public Int64 CurrentemployeeID
        {
            get
            {
                Int64 _employeeID = 0;

                if (ViewState["currentEmployeeID"] != null)
                {
                    Int64.TryParse(ViewState["currentEmployeeID"].ToString(), out _employeeID);
                }

                if (ViewState["currentEmployeeID"] == null)
                {
                    ViewState["currentEmployeeID"] = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    _employeeID = (Int64)ViewState["currentEmployeeID"];
                }

                return _employeeID;
            }
            set
            {
                ViewState["currentEmployeeID"] = value;
            }
        }

        public String Action
        {
            get
            {
                String action = "None";

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

        public Int64 OverviewAgreementID
        {
            get
            {
                Int64 agreementID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID], out agreementID);
                }

                return agreementID;
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

        private void BuildDropDownListAP()
        {
            if (!(APForwardInfoID > 0))
            {
                ddlAction.Items.Add(new ListItem("Approve", "1"));
                ddlAction.Items.Add(new ListItem("Reject", "2"));
                ddlAction.Items.Add(new ListItem("Forward", "3"));
                // ddlAction.Items.Add(new ListItem("Canceled & Return To Initiator", "4"));

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
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.AGREEMENT, OverviewAgreementID);
                ddlForwardTo.DataBind();
            }
            else
            {
                ddlAction.Items.Add(new ListItem("Comment", "4"));
            }
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMPaymentSchedule(ddlPaymentScheduleID, false);
            MiscUtil.PopulateCRMMDAgreementType(ddlAgreementTypeID, false);
            MiscUtil.PopulateCRMBuyerBasicInfo(ddlBuyerBasicInfoID, false);
            MiscUtil.PopulateCRMMDAgreementTemplate(ddlTemplateID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateCRMMDAgreementApprovalStatus(ddlAgreementApprovalStatusID, false);

            BuildDropDownListAP();

            GetTemplateInfo();

            BuildProjectFloorUnitByProjectID();
        }

        private void BuildProjectFloorUnitByProjectID()
        {
            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulateBDNotAvailableProjectFloorUnitByProject(ddlProjectFloorUnitID, false, Int64.Parse(ddlProjectID.SelectedValue));
            }
            else
            {
                ddlProjectFloorUnitID.Items.Clear();
            }
        }

        private void GetTemplateInfo()
        {
            if (ddlTemplateID != null && ddlTemplateID.Items.Count > 0)
            {
                CRMAgreementTemplateEntity cRMAgreementTemplateEntity = FCCCRMAgreementTemplate.GetFacadeCreate().GetByID(Int64.Parse(ddlTemplateID.SelectedValue));

                if (cRMAgreementTemplateEntity != null && cRMAgreementTemplateEntity.AgreementTemplateID > 0)
                {
                    txtText.Content = cRMAgreementTemplateEntity.Text.ToString();
                }
            }
        }

        private void PrepareValidator()
        {
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
                        //addPanel.Visible = false;
                        //btnSubmit.Visible = false;
                    }
                    else
                    {
                        //addPanel.Visible = true;
                        //btnSubmit.Visible = true;
                    }
                }
                else
                {
                    //addPanel.Visible = false;
                    //btnSubmit.Visible = false;
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

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAgreementDate.Text = String.Empty;
            txtSignDate.Text = String.Empty;
            txtExecuteDate.Text = String.Empty;
            txtWizardRemarks.Text = String.Empty;

            hypAgreementVariableMap.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMAgreementVariableMap.aspx", String.Empty, UrlConstants.OVERVIEW_AGREEMENT_ID, OverviewAgreementID.ToString()).ToString();
            hypAgreementVariableMap.Target = "_blank";

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            #endregion
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

        private void PrepareEditView()
        {
            CRMAgreementEntity cRMAgreementEntity = CurrentCRMAgreementEntity;


            if (!cRMAgreementEntity.IsNew)
            {
                if (ddlPaymentScheduleID.Items.Count > 0 && cRMAgreementEntity.PaymentScheduleID != null)
                {
                    ddlPaymentScheduleID.SelectedValue = cRMAgreementEntity.PaymentScheduleID.ToString();
                }
                if (ddlAgreementTypeID.Items.Count > 0 && cRMAgreementEntity.AgreementTypeID != null)
                {
                    ddlAgreementTypeID.SelectedValue = cRMAgreementEntity.AgreementTypeID.ToString();
                }

                if (ddlBuyerBasicInfoID.Items.Count > 0 && cRMAgreementEntity.BuyerBasicInfoID != null)
                {
                    ddlBuyerBasicInfoID.SelectedValue = cRMAgreementEntity.BuyerBasicInfoID.ToString();
                }

                if (ddlProjectID.Items.Count > 0 && cRMAgreementEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cRMAgreementEntity.ProjectID.ToString();
                }

                BuildProjectFloorUnitByProjectID();

                if (ddlProjectFloorUnitID.Items.Count > 0 && cRMAgreementEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = cRMAgreementEntity.ProjectFloorUnitID.ToString();
                }

                txtText.Content = cRMAgreementEntity.Text.ToString();
                txtAgreementDate.Text = cRMAgreementEntity.AgreementDate.ToStringDefault();
                txtSignDate.Text = cRMAgreementEntity.SignDate.ToStringDefault();
                txtExecuteDate.Text = cRMAgreementEntity.ExecuteDate.ToStringDefault();
                txtWizardRemarks.Text = cRMAgreementEntity.Remarks.ToString();

                if (ddlAgreementApprovalStatusID.Items.Count > 0 && cRMAgreementEntity.AgreementApprovalStatusID != null)
                {
                    ddlAgreementApprovalStatusID.SelectedValue = cRMAgreementEntity.AgreementApprovalStatusID.ToString();
                }

                #region Process Your Data Here

                String input = cRMAgreementEntity.Text.ToString();

                String newOutPut = String.Empty;

                IList<CRMAgreementVariableMapEntity> cRMAgreementVariableList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

                if (cRMAgreementVariableList != null && cRMAgreementVariableList.Count > 0)
                {
                    foreach (CRMAgreementVariableMapEntity ent in cRMAgreementVariableList)
                    {
                        if (input.Contains(ent.Name))
                        {   
                            newOutPut = MiscUtil.ReplaceFullWords(input, ent.Name, ent.Value.ToString());
                            input = newOutPut;
                        }
                    }
                }

                lblTextView.Text = newOutPut;

                #endregion
            }
        }

        private void BindList()
        {
            BindCRMAgreementList();
        }

        private void BindCRMAgreementList()
        {

        }

        private CRMAgreementEntity BuildCRMAgreementEntity()
        {
            CRMAgreementEntity cRMAgreementEntity = CurrentCRMAgreementEntity;

            if (ddlPaymentScheduleID.Items.Count > 0)
            {
                if (ddlPaymentScheduleID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.PaymentScheduleID = Int64.Parse(ddlPaymentScheduleID.SelectedValue);
                }
            }

            if (ddlAgreementTypeID.Items.Count > 0)
            {
                if (ddlAgreementTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.AgreementTypeID = Int64.Parse(ddlAgreementTypeID.SelectedValue);
                }
            }

            if (ddlBuyerBasicInfoID.Items.Count > 0)
            {
                if (ddlBuyerBasicInfoID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.BuyerBasicInfoID = Int64.Parse(ddlBuyerBasicInfoID.SelectedValue);
                }
            }

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (ddlProjectFloorUnitID.Items.Count > 0)
            {
                if (ddlProjectFloorUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                }
            }

            cRMAgreementEntity.Text = txtText.Content.Trim();
            if (txtAgreementDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMAgreementEntity.AgreementDate = MiscUtil.ParseToDateTime(txtAgreementDate.Text);
            }
            else
            {
                cRMAgreementEntity.AgreementDate = null;
            }

            if (txtSignDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMAgreementEntity.SignDate = MiscUtil.ParseToDateTime(txtSignDate.Text);
            }
            else
            {
                cRMAgreementEntity.SignDate = null;
            }

            if (txtExecuteDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMAgreementEntity.ExecuteDate = MiscUtil.ParseToDateTime(txtExecuteDate.Text);
            }
            else
            {
                cRMAgreementEntity.ExecuteDate = null;
            }

            cRMAgreementEntity.Field1 = "Not Implemented";
            cRMAgreementEntity.Field2 = "Not Implemented";
            cRMAgreementEntity.Field3 = "Not Implemented";
            cRMAgreementEntity.Field4 = "Not Implemented";
            cRMAgreementEntity.Remarks = "Not Implemented";
            cRMAgreementEntity.CreatedByEmployeeID = CurrentemployeeID;
            cRMAgreementEntity.CreateDate = System.DateTime.Now;
            cRMAgreementEntity.IP = MiscUtil.GetLocalIP();
            if (ddlAgreementApprovalStatusID.Items.Count > 0)
            {
                if (ddlAgreementApprovalStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.AgreementApprovalStatusID = Int64.Parse(ddlAgreementApprovalStatusID.SelectedValue);
                }
            }


            return cRMAgreementEntity;
        }

        private void SaveCRMAgreementEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMAgreementEntity cRMAgreementEntity = BuildCRMAgreementEntity();

                    Int64 result = -1;

                    if (cRMAgreementEntity.IsNew)
                    {
                        result = FCCCRMAgreement.GetFacadeCreate().Add(cRMAgreementEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementEntity.FLD_NAME_AgreementID, cRMAgreementEntity.AgreementID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMAgreement.GetFacadeCreate().Update(cRMAgreementEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);


                    }

                    if (result > 0)
                    {

                        //#region Update Agreement Variable Map

                        //if (!cRMAgreementEntity.IsNew)
                        //{
                        ////    String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementID, result.ToString(), SQLMatchType.Equal);
                        ////    CRMAgreementVariableMapEntity cRMAgreementVariableMapEntity = new CRMAgreementVariableMapEntity();
                        ////    FCCCRMAgreementVariableMap.GetFacadeCreate().Delete(cRMAgreementVariableMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        ////    String input = txtText.Content.ToString();

                        ////    String newOutPut = String.Empty;

                        //    //IList<CRMAgreementVariableMapEntity> cRMAgreementVariableList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

                        //    //if (cRMAgreementVariableList != null && cRMAgreementVariableList.Count > 0)
                        //    //{
                        //        //String fe_delete = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementID, result.ToString(), SQLMatchType.Equal);
                        //        //IList<CRMAgreementVariableMapEntity> deleteList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_delete, DatabaseOperationType.LoadWithFilterExpression);

                        //        //if (deleteList != null && deleteList.Count > 0)
                        //        //{
                        //        //    foreach (CRMAgreementVariableMapEntity ent in deleteList)
                        //        //    {
                        //        //        FCCCRMAgreementVariableMap.GetFacadeCreate().Delete(ent, fe_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        //        //    }
                        //        //}

                        //        //foreach (CRMAgreementVariableMapEntity ent in cRMAgreementVariableList)
                        //        //{
                        //        //    if (input.Contains(ent.Name))
                        //        //    {
                        //        //        CRMAgreementVariableMapEntity cRMAgreementVariableMap=new CRMAgreementVariableMapEntity();
                        //        //        cRMAgreementVariableMap.Name = ent.Name;
                        //        //        cRMAgreementVariableMap.IP = MiscUtil.GetLocalIP();
                        //        //        cRMAgreementVariableMap.Value = ent.Value;
                        //        //        cRMAgreementVariableMap.AgreementID = result;
                        //        //        cRMAgreementVariableMap.CreateDate = System.DateTime.Now;
                        //        //        cRMAgreementVariableMap.CreatedByEmployeeID = CurrentemployeeID;
                        //        //        cRMAgreementVariableMap.Remarks = "Auto Generated";
                        //        //        FCCCRMAgreementVariableMap.GetFacadeCreate().Add(cRMAgreementVariableMap, DatabaseOperationType.Add, TransactionRequired.No);
                        //        //    }
                        //        //}
                        //    //}
                        //}

                        //#endregion

                        _AgreementID = result;
                        PrepareEditView();
                        ProcessText();
                        BindCRMAgreementList();

                        if (cRMAgreementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMAgreementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Agreement Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Agreement Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void ProcessText()
        {
            String input = txtText.Content.ToString();

            String newOutPut = String.Empty;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementID, OverviewAgreementID.ToString(), SQLMatchType.Equal);
            IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (cRMAgreementVariableMapList != null && cRMAgreementVariableMapList.Count > 0)
            {
                foreach (CRMAgreementVariableMapEntity ent in cRMAgreementVariableMapList)
                {
                    newOutPut = MiscUtil.ReplaceFullWords(input, ent.Name, ent.Value.ToString());
                    input = newOutPut;
                }
            }

            if (newOutPut.IsNotNullOrEmpty())
            {
                lblTextView.Text = newOutPut;
            }
            else
            {
                lblTextView.Text = input;
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

        protected void lvCRMAgreement_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementID);

            if (AgreementID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementID = AgreementID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementEntity.FLD_NAME_AgreementID, AgreementID.ToString(), SQLMatchType.Equal);

                        CRMAgreementEntity cRMAgreementEntity = new CRMAgreementEntity();

                        result = FCCCRMAgreement.GetFacadeCreate().Delete(cRMAgreementEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementID = 0;
                            _CRMAgreementEntity = new CRMAgreementEntity();
                            PrepareInitialView();
                            BindCRMAgreementList();

                            MiscUtil.ShowMessage(lblMessage, "Agreement has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Agreement.", true);
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

        protected void odsCRMAgreement_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnApprove_Click(object sender, EventArgs e)
        {  
                btnApprove.Enabled = false;

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.AGREEMENT, OverviewAgreementID);

                String remarks = txtRemarks.Text.Trim();

                if (remarks.IsNullOrEmpty())
                {
                    remarks = "Approved";
                }

                remarks = AddProxyMemberInfo(remarks);

                APRobot.AddAPMemberFeedbackRemarks(APMemberFeedbackID, remarks);

                EnableDisableApprovalButtons();

                MiscUtil.ShowMessage(lblMessage, "You Have Approved Successfully", UIConstants.MessageType.GREEN);

                String fe = SqlExpressionBuilder.PrepareFilterExpression(APForwardInfoEntity.FLD_NAME_APMemberFeedbackID, APMemberFeedbackID.ToString(), SQLMatchType.Equal);
                IList<APForwardInfoEntity> lstForwardedInfo = FCCAPForwardInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lstForwardedInfo != null && lstForwardedInfo.Count > 0)
                {

                    #region Forwarded Reply Mail

                    String MailBody = String.Empty;
                    String Subject = String.Empty;

                    StringBuilder sb = new StringBuilder();

                    sb.Append("Dear Sir,");
                    sb.Append("<br/>");
                    sb.Append("This is a auto generated mail from the ERP.");
                    sb.Append("<br/>");
                    sb.Append("A Forwarded Requisition is Processed By Senior");
                    sb.Append("<br/>");
                    sb.Append("-");
                    sb.Append("<br/>");
                    sb.Append("Thanks");
                    sb.Append("<br/>");
                    sb.Append("ERP System");
                    MailBody = sb.ToString();
                    Subject = "ERP, Requsition, Forwarded Reply";

                    String[] sendToMail = new String[lstForwardedInfo.Count];

                    Int64 count = 0;

                    foreach (APForwardInfoEntity aPForwardInfoEntity in lstForwardedInfo)
                    {
                        HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(aPForwardInfoEntity.EmployeeID);

                        if (_hREmployeeEntity != null)
                        {
                            sendToMail[count] = _hREmployeeEntity.PrimaryEmail;
                            count++;
                        }
                    }

                    MiscUtil.SendMail(sendToMail, Subject, MailBody);

                    #endregion
                }

                PrepareInitialView();
                BindList();
                RedirectPageToPendingList();
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            btnReject.Enabled = false;

            if (ddlRejectTo.SelectedValue == "0")
            {
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.AGREEMENT, OverviewAgreementID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.AGREEMENT, OverviewAgreementID, rejectToAPMemberFeedbackID);
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
                sb.Append("A Requisition Forwarded Request is waiting for your approval");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Requsition, Forwarded";

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

                //#region Forwarded Response Received Mail

                //String MailBody = String.Empty;
                //String Subject = String.Empty;

                //StringBuilder sb = new StringBuilder();

                //sb.Append("Dear Sir,");
                //sb.Append("<br/>");
                //sb.Append("This is a auto generated mail from the ERP.");
                //sb.Append("<br/>");
                //sb.Append("A Requisition Forwarded Response Received");
                //sb.Append("<br/>");
                //sb.Append("-");
                //sb.Append("<br/>");
                //sb.Append("Thanks");
                //sb.Append("<br/>");
                //sb.Append("ERP System");
                //MailBody = sb.ToString();
                //Subject = "ERP, Requsition, Forwarded Response Received";

                //APMemberFeedbackEntity apMemberFeedbackEntity = FCCAPMemberFeedback.GetFacadeCreate().GetByID(APMemberFeedbackID);

                //if (apMemberFeedbackEntity != null && apMemberFeedbackEntity.APMemberFeedbackID > 0)
                //{

                //    //String fe=SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.f
                //    HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(apMemberFeedbackEntity.EmployeeID);

                //    if (_hREmployeeEntity != null)
                //    {
                //        String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                //        MiscUtil.SendMail(sendToMail, Subject, MailBody);
                //    }
                //}

                //#endregion

                PrepareInitialView();
                BindList();

                MiscUtil.ShowMessage(lblMessage, "You have submited comments successfully", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to submit comments", UIConstants.MessageType.RED);
            }
        }

        protected void wizAgreement_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            #region Save Agreement

            SaveCRMAgreementEntity();

            #endregion
        }

        protected void wizAgreement_PreviousButtonClick(object sender, WizardNavigationEventArgs e)
        {
            PrepareEditView();
            wizAgreement.ActiveStepIndex = 0; 
        }

        protected void wizAgreement_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            #region Process Your Data Here

            ProcessText();

            #endregion
        }

        #endregion

        #region Dropdown Event

        protected void ddlTemplateID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetTemplateInfo();
        }

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildProjectFloorUnitByProjectID();
        }


        #endregion

        #endregion Event
    }
}
