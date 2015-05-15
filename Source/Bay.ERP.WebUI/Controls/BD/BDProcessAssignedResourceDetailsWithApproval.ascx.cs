// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
using System.Text;
using System.Web.UI.HtmlControls;

namespace Bay.ERP.Web.UI
{
    public partial class BDProcessAssignedResourceDetailsWithApprovalControl : BaseControl
    {

        #region Extra

        class CustomerComparer : IEqualityComparer<CRMContactList_CustomEntity>
        {
            public bool Equals(CRMContactList_CustomEntity x, CRMContactList_CustomEntity y)
            {
                return (x.ResourceID.Equals(y.ResourceID) && x.ResourceCategoryID.Equals(y.ResourceCategoryID));
            }

            public int GetHashCode(CRMContactList_CustomEntity obj)
            {
                return obj.ResourceID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _ProcessAssignedResourceID
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

        public BDProcessAssignedResourceEntity _BDProcessAssignedResourceEntity
        {
            get
            {
                BDProcessAssignedResourceEntity entity = new BDProcessAssignedResourceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProcessAssignedResourceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProcessAssignedResourceEntity CurrentBDProcessAssignedResourceEntity
        {
            get
            {
                if (OverviewProcessAssignedResourceID > 0)
                {
                    _BDProcessAssignedResourceEntity = FCCBDProcessAssignedResource.GetFacadeCreate().GetByID(OverviewProcessAssignedResourceID);
                }

                return _BDProcessAssignedResourceEntity;
            }
            set
            {
                _BDProcessAssignedResourceEntity = value;
            }
        }

        public Int64 _ProcessAssignedResourceMapID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ProcessAssignedResourceMapID"] != null)
                {
                    Int64.TryParse(ViewState["ProcessAssignedResourceMapID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ProcessAssignedResourceMapID"] = value;
            }
        }

        public BDProcessAssignedResourceMapEntity _BDProcessAssignedResourceMapEntity
        {
            get
            {
                BDProcessAssignedResourceMapEntity entity = new BDProcessAssignedResourceMapEntity();

                if (ViewState["BDProcessAssignedResourceMapEntity"] != null)
                {
                    entity = (BDProcessAssignedResourceMapEntity)ViewState["BDProcessAssignedResourceMapEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["BDProcessAssignedResourceMapEntity"] = value;
            }
        }

        private BDProcessAssignedResourceMapEntity CurrentBDProcessAssignedResourceMapEntity
        {
            get
            {
                if (_ProcessAssignedResourceID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceID, _ProcessAssignedResourceID.ToString(), SQLMatchType.Equal);
                    IList<BDProcessAssignedResourceMapEntity> lst = FCCBDProcessAssignedResourceMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (lst != null && lst.Count > 0)
                    {
                        _BDProcessAssignedResourceMapEntity = lst[0];
                    }
                    else
                    {
                        _BDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();
                    }
                }

                return _BDProcessAssignedResourceMapEntity;
            }
            set
            {
                _BDProcessAssignedResourceMapEntity = value;
            }
        }

        public IList<CRMContactList_CustomEntity> IssueCRMContactList_CustomEntityList
        {
            get
            {
                return (IList<CRMContactList_CustomEntity>)ViewState["IssueCRMContactList_CustomEntityList"];
            }
            set
            {
                ViewState["IssueCRMContactList_CustomEntityList"] = value;
            }
        }

        public Int64 OverviewProcessAssignedResourceID
        {
            get
            {
                Int64 templateID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID], out templateID);
                }

                return templateID;
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
            MiscUtil.PopulateBDMDProcessCategory(ddlProcessCategoryID, false);
            MiscUtil.PopulateMDResourceCategory(ddlResourceCategoryID, false);

            if (ddlResourceCategoryID.Items.Count > 0 && ddlResourceCategoryID != null)
            {
                ListItem item = ddlResourceCategoryID.Items.FindByValue(MasterDataConstants.ResourceCategory.TOOL.ToString());
                ddlResourceCategoryID.Items.Remove(item);
            }
        }

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
                ddlForwardTo.DataSource = APRobot.GetAPPanelForwardMemberByApprovalProcessTypeAndReferenceID(MasterDataConstants.APType.CONTACT_LIST, OverviewProcessAssignedResourceID);
                ddlForwardTo.DataBind();
            }
            else
            {
                ddlAction.Items.Add(new ListItem("Comment", "4"));
            }
        }

        private void PrepareValidator()
        {
        }

        private void BuildResourceByResourceCategory()
        {
            if (ddlResourceCategoryID.Items.Count > 0 && ddlResourceCategoryID != null)
            {
                ViewState["SearchString"] = SqlExpressionBuilder.PrepareFilterExpression(CRMContactList_CustomEntity.FLD_NAME_ResourceCategoryID, ddlResourceCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);

                BindCRMContactList();

                //switch (Int64.Parse(ddlResourceCategoryID.SelectedValue))
                //{
                //    case MasterDataConstants.ResourceCategory.VENDOR:
                //        ViewState["SearchString"] = SqlExpressionBuilder.PrepareFilterExpression(CRMContactList_CustomEntity.FLD_NAME_ResourceCategoryID, ddlResourceCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);
                //        BindPRMSupplierList();
                //        break;
                //    case MasterDataConstants.ResourceCategory.CONSULTANT:
                        
                //        BindPRMSupplierList();
                //        break;
                //    case MasterDataConstants.ResourceCategory.CONTRACTOR:
                        
                //        BindPRMSupplierList();
                //        break;
                //    case MasterDataConstants.ResourceCategory.EMPLOYEE:
                        
                //        BindHREmployeeList();
                //        break;
                //    case MasterDataConstants.ResourceCategory.LANDOWNER:
                //        break;
                //}
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

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BuildDropDownListAP();

            if (ddlProcessCategoryID != null && ddlProcessCategoryID.Items.Count > 0)
            {
                txtTitle.Text = ddlProcessCategoryID.SelectedItem.ToString();
            }
            else
            {
                txtTitle.Text = "Title Here";
            }
            txtPurposes.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtStartDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            btnSubmit.Text = "Add";

            IssueCRMContactList_CustomEntityList = new List<CRMContactList_CustomEntity>();

            BuildResourceByResourceCategory();

            #region Approval

            lvAPMemberFeedbackRemarks.DataSource = APRobot.GetMemberFeedbackRemarks_DetailedByApprovalProcessID(APApprovalProcessID);
            lvAPMemberFeedbackRemarks.DataBind();

            EnableDisableApprovalButtons();

            #endregion
        }

        private void PrepareEditView()
        {
            BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = CurrentBDProcessAssignedResourceEntity;


            if (!bDProcessAssignedResourceEntity.IsNew)
            {
                if (ddlProcessCategoryID.Items.Count > 0 && bDProcessAssignedResourceEntity.ProcessCategoryID != null)
                {
                    ddlProcessCategoryID.SelectedValue = bDProcessAssignedResourceEntity.ProcessCategoryID.ToString();
                }

                txtTitle.Text = bDProcessAssignedResourceEntity.Title.ToString();
                txtPurposes.Text = bDProcessAssignedResourceEntity.Purposes.ToString();
                txtRemarks.Text = bDProcessAssignedResourceEntity.Remarks.ToString();
                txtStartDate.Text = bDProcessAssignedResourceEntity.StartDate.ToStringDefault();

                btnSubmit.Text = "Update";
            }
        }

        private void BindBDProcessAssignedResourceMapList()
        {
            lvBDProcessAssignedResourceMap.DataBind();
        }

        private void BindCRMContactList()
        {
            lvCRMContactList.DataBind();
        }

        private BDProcessAssignedResourceEntity BuildBDProcessAssignedResourceEntity()
        {
            BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = CurrentBDProcessAssignedResourceEntity;

            if (ddlProcessCategoryID.Items.Count > 0)
            {
                if (ddlProcessCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProcessAssignedResourceEntity.ProcessCategoryID = Int64.Parse(ddlProcessCategoryID.SelectedValue);
                }
            }

            bDProcessAssignedResourceEntity.Title = txtTitle.Text.Trim();
            bDProcessAssignedResourceEntity.Purposes = txtPurposes.Text.Trim();
            bDProcessAssignedResourceEntity.Remarks = txtRemarks.Text.Trim();
            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                bDProcessAssignedResourceEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }
            else
            {
                bDProcessAssignedResourceEntity.StartDate = null;
            }

            bDProcessAssignedResourceEntity.CreateDate = System.DateTime.Now;
            bDProcessAssignedResourceEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            return bDProcessAssignedResourceEntity;
        }

        private void SaveBDProcessAssignedResourceEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity = BuildBDProcessAssignedResourceEntity();

                    Int64 result = -1;

                    if (bDProcessAssignedResourceEntity.IsNew)
                    {
                        result = FCCBDProcessAssignedResource.GetFacadeCreate().Add(bDProcessAssignedResourceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceEntity.FLD_NAME_ProcessAssignedResourceID, bDProcessAssignedResourceEntity.ProcessAssignedResourceID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProcessAssignedResource.GetFacadeCreate().Update(bDProcessAssignedResourceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        //BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = CurrentBDProcessAssignedResourceMapEntity;

                        //String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceID, result.ToString(), SQLMatchType.Equal);
                        //IList<BDProcessAssignedResourceMapEntity> mappedItemsFromDB = FCCBDProcessAssignedResourceMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                        //IList<CRMContactList_CustomEntity> tempAddList = new List<CRMContactList_CustomEntity>();

                        //if (mappedItemsFromDB != null && mappedItemsFromDB.Count > 0)
                        //{
                        //    foreach (BDProcessAssignedResourceMapEntity ent in mappedItemsFromDB)
                        //    {
                        //        CRMContactList_CustomEntity cRMContactList_CustomEntity = new CRMContactList_CustomEntity();
                        //        cRMContactList_CustomEntity.ResourceID = ent.ReferenceID;
                        //        cRMContactList_CustomEntity.ResourceCategoryID = ent.ResourceCategoryID.ToString();
                        //        cRMContactList_CustomEntity.ResourceName = ent.ResourceName;
                        //        cRMContactList_CustomEntity.ResourceDesignation = ent.ResourceDesignation;
                        //        cRMContactList_CustomEntity.ResourceEmail = ent.ResourceEmail;
                        //        cRMContactList_CustomEntity.ResourceMobileNo = ent.ResourceMobileNo;
                        //        Int64 resourceTypeID = 0;
                        //        Int64.TryParse(ent.ResourceTypeID.ToString(), out resourceTypeID);
                        //        cRMContactList_CustomEntity.ResourceTypeID = resourceTypeID;
                        //        cRMContactList_CustomEntity.ResourceCompany = ent.ResourceCompany;
                        //        tempAddList.Add(cRMContactList_CustomEntity);
                        //    }
                        //}

                        //IList<CRMContactList_CustomEntity> finalAddList = IssueCRMContactList_CustomEntityList.Except(tempAddList, new CustomerComparer()).ToList();
                        //IList<CRMContactList_CustomEntity> finalDeleteList = tempAddList.Except(IssueCRMContactList_CustomEntityList, new CustomerComparer()).ToList();

                        //foreach (CRMContactList_CustomEntity ent in finalAddList)
                        //{

                        //    bDProcessAssignedResourceMapEntity.ProcessAssignedResourceID = result;
                        //    bDProcessAssignedResourceMapEntity.ResourceCategoryID = Int64.Parse(ent.ResourceCategoryID.ToString());
                        //    bDProcessAssignedResourceMapEntity.ReferenceID = ent.ResourceID;
                        //    bDProcessAssignedResourceMapEntity.ResourceName = ent.ResourceName;
                        //    bDProcessAssignedResourceMapEntity.ResourceDesignation = ent.ResourceDesignation;
                        //    bDProcessAssignedResourceMapEntity.ResourceEmail = ent.ResourceEmail;
                        //    bDProcessAssignedResourceMapEntity.ResourceMobileNo = ent.ResourceMobileNo;
                        //    Int64 resourceTypeID = 0;
                        //    Int64.TryParse(ent.ResourceTypeID.ToString(), out resourceTypeID);
                        //    bDProcessAssignedResourceMapEntity.ResourceTypeID = resourceTypeID;
                        //    bDProcessAssignedResourceMapEntity.ResourceCompany = ent.ResourceCompany;
                        //    bDProcessAssignedResourceMapEntity.Remarks = txtRemarks.Text.Trim();

                        //    FCCBDProcessAssignedResourceMap.GetFacadeCreate().Add(bDProcessAssignedResourceMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        //}

                        //foreach (CRMContactList_CustomEntity ent in finalDeleteList)
                        //{
                        //    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ReferenceID, ent.ResourceID.ToString(), SQLMatchType.Equal);
                        //    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ResourceCategoryID,ent.ResourceCategoryID, SQLMatchType.Equal);

                        //    String fe_delete = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        //    FCCBDProcessAssignedResourceMap.GetFacadeCreate().Delete(bDProcessAssignedResourceMapEntity, fe_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                        //}

                        //if (!bDProcessAssignedResourceEntity.IsNew)
                        //{
                        //    //_ProcessAssignedResourceID = 0;
                        //    //_BDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();
                        //}

                        _ProcessAssignedResourceID = result;
                        PrepareEditView();
                        BindBDProcessAssignedResourceMapList();

                        if (bDProcessAssignedResourceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProcessAssignedResourceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Process Assigned Resource Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Process Assigned Resource Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
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
                        btnSubmit.Visible = false;
                    }
                    else
                    {
                        btnSubmit.Visible = true;
                    }
                }
                else
                {   
                    btnSubmit.Visible = false;
                }
            }
            else
            {
                btnApprove.Enabled = false;
                btnReject.Enabled = false;
                btnForward.Enabled = false;
              
                btnSubmit.Visible = false;
            }
        }

        private void BindResourceEmployeeInfoNew()
        {
            try
            {
                IList<ListViewDataItem> list = lvCRMContactList.Items;

                if (list != null && list.Count > 0)
                {

                    foreach (ListViewDataItem lvdi in list)
                    {
                        CheckBox chkSelectResourceLV = (CheckBox)lvdi.FindControl("chkSelectResourceLV");

                        if (chkSelectResourceLV.Checked == true)
                        {
                            Int64 resourceIDLV, resourceCategoryIDLV;
                            Int64? resourceTypeID;
                            String resourceName, resourceDesignation, resourceCompany, resourceMobileNo, resourceEmail;
                            DateTime? resourceDOB;


                            Label lblResourceIDLV = (Label)lvdi.FindControl("lblResourceIDLV");
                            Label lblResourceCategoryIDLV = (Label)lvdi.FindControl("lblResourceCategoryIDLV");
                            Label lblResourceNameLV = (Label)lvdi.FindControl("lblResourceNameLV");
                            Label lblResourceDesignationLV = (Label)lvdi.FindControl("lblResourceDesignationLV");
                            Label lblResourceCompanyLV = (Label)lvdi.FindControl("lblResourceCompanyLV");
                            Label lblResourceMobileNoLV = (Label)lvdi.FindControl("lblResourceMobileNoLV");
                            Label lblResourceEmailLV = (Label)lvdi.FindControl("lblResourceEmailLV");
                            Label lblResourceTypeIDLV = (Label)lvdi.FindControl("lblResourceTypeIDLV");
                            Label lblResourceDOBLV = (Label)lvdi.FindControl("lblResourceDOBLV");

                            Int64.TryParse(lblResourceIDLV.Text, out resourceIDLV);
                            Int64.TryParse(lblResourceCategoryIDLV.Text, out resourceCategoryIDLV);

                            resourceName = lblResourceNameLV.Text.Trim();
                            resourceDesignation = lblResourceDesignationLV.Text.Trim();
                            resourceCompany = lblResourceCompanyLV.Text.Trim();
                            resourceMobileNo = lblResourceMobileNoLV.Text.Trim();
                            resourceEmail = lblResourceEmailLV.Text.Trim();
                            if (!lblResourceTypeIDLV.Text.Trim().IsNullOrEmpty())
                            {
                                resourceTypeID = Int64.Parse(lblResourceTypeIDLV.Text.Trim());
                            }
                            else
                            {
                                resourceTypeID = null;
                            }

                            if (lblResourceDOBLV.Text.Trim().IsNotNullOrEmpty())
                            {
                                resourceDOB = MiscUtil.ParseToDateTime(lblResourceDOBLV.Text);
                            }
                            else
                            {
                                resourceDOB = null;
                            }

                            CRMContactList_CustomEntity cRMContactList_CustomEntity = new CRMContactList_CustomEntity();

                            cRMContactList_CustomEntity.ResourceID = resourceIDLV;
                            cRMContactList_CustomEntity.ResourceCategoryID = resourceCategoryIDLV.ToString();
                            cRMContactList_CustomEntity.ResourceName=resourceName;
                            cRMContactList_CustomEntity.ResourceCompany=resourceCompany;
                            cRMContactList_CustomEntity.ResourceDesignation=resourceDesignation;
                            cRMContactList_CustomEntity.ResourceEmail=resourceEmail;
                            cRMContactList_CustomEntity.ResourceDOB=resourceDOB;
                            cRMContactList_CustomEntity.ResourceTypeID =(Int64)resourceTypeID;
                            //Check Existing Item

                            var employeeList = (from s in IssueCRMContactList_CustomEntityList
                                                where s.ResourceID == resourceIDLV && s.ResourceCategoryID == resourceCategoryIDLV.ToString()
                                                select s);
                            if (employeeList == null || employeeList.Count() <= 0)
                            {
                                IssueCRMContactList_CustomEntityList.Add(cRMContactList_CustomEntity);
                            }

                        }

                        else if (chkSelectResourceLV.Checked == false)
                        {

                            Int64 resourceIDLV, resourceCategoryIDLV;

                            Label lblResourceIDLV = (Label)lvdi.FindControl("lblResourceIDLV");
                            Label lblResourceCategoryIDLV = (Label)lvdi.FindControl("lblResourceCategoryIDLV");
                          
                            Int64.TryParse(lblResourceIDLV.Text, out resourceIDLV);
                            Int64.TryParse(lblResourceCategoryIDLV.Text, out resourceCategoryIDLV);

                         

                            var item = from s in IssueCRMContactList_CustomEntityList
                                       where s.ResourceID == resourceIDLV && s.ResourceCategoryID == resourceCategoryIDLV.ToString()
                                       select s;

                            if (item != null && item.Count() > 0)
                            {
                                //Check Deleted Employee.
                                CRMContactList_CustomEntity di = (from d in IssueCRMContactList_CustomEntityList
                                                                  where d.ResourceID == resourceIDLV && d.ResourceCategoryID == rfvResourceCategoryID.ToString()
                                                                    select d).First();
                                //Delete Here.
                                if (di != null)
                                {
                                    IssueCRMContactList_CustomEntityList.Remove(di);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProcessAssignedResourceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProcessAssignedResourceID = 0;
            _BDProcessAssignedResourceEntity = new BDProcessAssignedResourceEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnAddToList_Click(object sender, EventArgs e)
        {
            BindResourceEmployeeInfoNew();
            SaveBDProcessAssignedResourceEntity();
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
          
                btnApprove.Enabled = false;

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.APPROVED, MasterDataConstants.APType.CONTACT_LIST, OverviewProcessAssignedResourceID);

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
                RedirectPageToPendingList();
        }

        protected void btnReject_Click(object sender, EventArgs e)
        {
            btnReject.Enabled = false;

            if (ddlRejectTo.SelectedValue == "0")
            {
                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.CONTACT_LIST, OverviewProcessAssignedResourceID);
            }
            else
            {
                Int64 rejectToAPMemberFeedbackID = Int64.Parse(ddlRejectTo.SelectedValue);

                APRobot.UpdateApprovalProcessFeedback(APMemberFeedbackID, MasterDataConstants.APFeedback.REJECTED, MasterDataConstants.APType.CONTACT_LIST, OverviewProcessAssignedResourceID, rejectToAPMemberFeedbackID);
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

                #region Forwarded Response Received Mail

                String MailBody = String.Empty;
                String Subject = String.Empty;

                StringBuilder sb = new StringBuilder();

                sb.Append("Dear Sir,");
                sb.Append("<br/>");
                sb.Append("This is a auto generated mail from the ERP.");
                sb.Append("<br/>");
                sb.Append("A Requisition Forwarded Response Received");
                sb.Append("<br/>");
                sb.Append("-");
                sb.Append("<br/>");
                sb.Append("Thanks");
                sb.Append("<br/>");
                sb.Append("ERP System");
                MailBody = sb.ToString();
                Subject = "ERP, Requsition, Forwarded Response Received";

                APMemberFeedbackEntity apMemberFeedbackEntity = FCCAPMemberFeedback.GetFacadeCreate().GetByID(APMemberFeedbackID);

                if (apMemberFeedbackEntity != null && apMemberFeedbackEntity.APMemberFeedbackID > 0)
                {

                    //String fe=SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.f
                    HREmployeeEntity _hREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetByID(apMemberFeedbackEntity.EmployeeID);

                    if (_hREmployeeEntity != null)
                    {
                        String[] sendToMail = new String[] { _hREmployeeEntity.PrimaryEmail };
                        MiscUtil.SendMail(sendToMail, Subject, MailBody);
                    }
                }

                #endregion

                PrepareInitialView();

                MiscUtil.ShowMessage(lblMessage, "You have submited comments successfully", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to submit comments", UIConstants.MessageType.RED);
            }
        }

        #endregion

        #region ObjectDataSource Event Resource

        protected void odsCRMContactList_Custom_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

            if (e.ExecutingSelectCount == false)
            {
                BindResourceEmployeeInfoNew();
            }

            String fe = String.Empty;

            if (ViewState["SearchString"] != null)
            {
                fe = (String)ViewState["SearchString"];
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region List View Event Assigned Resources

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


        protected void lvBDProcessAssignedResourceMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProcessAssignedResourceMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProcessAssignedResourceMapID);

            if (ProcessAssignedResourceMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProcessAssignedResourceMapID = ProcessAssignedResourceMapID;

                    PrepareEditView();
                }

                else if (string.Equals(e.CommandName, "UpdateItem"))
                {
                    _ProcessAssignedResourceMapID = ProcessAssignedResourceMapID;

                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceMapID, ProcessAssignedResourceMapID.ToString(), SQLMatchType.Equal);

                    BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = FCCBDProcessAssignedResourceMap.GetFacadeCreate().GetByID(ProcessAssignedResourceMapID);
                    TextBox txtResourceNameLV = (TextBox)e.Item.FindControl("txtResourceNameLV");
                    TextBox txtResourceDesignationLV = (TextBox)e.Item.FindControl("txtResourceDesignationLV");
                    TextBox txtResourceCompanyLV = (TextBox)e.Item.FindControl("txtResourceCompanyLV");
                    TextBox txtResourceMobileNoLV = (TextBox)e.Item.FindControl("txtResourceMobileNoLV");
                    TextBox txtResourceEmailLV = (TextBox)e.Item.FindControl("txtResourceEmailLV");
                    TextBox txtResourceDOBLV = (TextBox)e.Item.FindControl("txtResourceDOBLV");
                    TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");
                    TextBox txtAddressLine1LV = (TextBox)e.Item.FindControl("txtAddressLine1LV");
                    TextBox txtAddressLine2LV = (TextBox)e.Item.FindControl("txtAddressLine2LV");
                    
                    bDProcessAssignedResourceMapEntity.ResourceCategoryID = 1;
                    bDProcessAssignedResourceMapEntity.ReferenceID = 1;
                    bDProcessAssignedResourceMapEntity.ResourceName = txtResourceNameLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.ResourceDesignation = txtResourceDesignationLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.ResourceEmail = txtResourceEmailLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.ResourceMobileNo = txtResourceMobileNoLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.AddressLine1 = txtAddressLine1LV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.AddressLine2 = txtAddressLine2LV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.ResourceTypeID = 0;
                    bDProcessAssignedResourceMapEntity.ResourceCompany = txtResourceCompanyLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.Remarks = txtRemarksLV.Text.Trim();

                    result = FCCBDProcessAssignedResourceMap.GetFacadeCreate().Update(bDProcessAssignedResourceMapEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                    if (result > 0)
                    {
                        _ProcessAssignedResourceMapID = 0;
                        _BDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();
                        BindBDProcessAssignedResourceMapList();

                        MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Map has been successfully updated.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to update Process Assigned Resource Map.", true);
                    }

                    PrepareEditView();
                }

                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceMapID, ProcessAssignedResourceMapID.ToString(), SQLMatchType.Equal);

                        BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();


                        result = FCCBDProcessAssignedResourceMap.GetFacadeCreate().Delete(bDProcessAssignedResourceMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProcessAssignedResourceMapID = 0;
                            _BDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();
                            PrepareInitialView();
                            BindBDProcessAssignedResourceMapList();

                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Process Assigned Resource Map.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
            if (string.Equals(e.CommandName, "InsertItem"))
            {
                try
                {
                    ListViewItem list = lvBDProcessAssignedResourceMap.InsertItem;

                    TextBox txtResourceNameLV = (TextBox)list.FindControl("txtResourceNameLV");
                    TextBox txtResourceDesignationLV = (TextBox)list.FindControl("txtResourceDesignationLV");
                    TextBox txtResourceCompanyLV = (TextBox)list.FindControl("txtResourceCompanyLV");
                    TextBox txtResourceMobileNoLV = (TextBox)list.FindControl("txtResourceMobileNoLV");
                    TextBox txtResourceEmailLV = (TextBox)list.FindControl("txtResourceEmailLV");
                    TextBox txtResourceDOBLV = (TextBox)list.FindControl("txtResourceDOBLV");
                    TextBox txtRemarksLV = (TextBox)list.FindControl("txtRemarksLV");
                    TextBox txtAddressLine1LV = (TextBox)list.FindControl("txtAddressLine1LV");
                    TextBox txtAddressLine2LV = (TextBox)list.FindControl("txtAddressLine2LV");

                    BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();

                    bDProcessAssignedResourceMapEntity.ProcessAssignedResourceID = OverviewProcessAssignedResourceID;
                    bDProcessAssignedResourceMapEntity.ResourceCategoryID = 1;
                    bDProcessAssignedResourceMapEntity.ReferenceID = 1;
                    bDProcessAssignedResourceMapEntity.ResourceName = txtResourceNameLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.ResourceDesignation = txtResourceDesignationLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.ResourceEmail = txtResourceEmailLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.ResourceMobileNo = txtResourceMobileNoLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.AddressLine1 = txtAddressLine1LV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.AddressLine2 = txtAddressLine2LV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.ResourceTypeID = 0;
                    bDProcessAssignedResourceMapEntity.ResourceCompany = txtResourceCompanyLV.Text.Trim();
                    bDProcessAssignedResourceMapEntity.Remarks = txtRemarksLV.Text.Trim();

                    FCCBDProcessAssignedResourceMap.GetFacadeCreate().Add(bDProcessAssignedResourceMapEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    BindBDProcessAssignedResourceMapList();

                    MiscUtil.ShowMessage(lblMessage, "Resource Assigned Map Information has been saved successfully.", false);
                }

                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, "Resource Assigned Map Information has been saved successfully.", true);
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event Assigned Resources

        protected void odsBDProcessAssignedResourceMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (OverviewProcessAssignedResourceID > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceEntity.FLD_NAME_ProcessAssignedResourceID, OverviewProcessAssignedResourceID.ToString(), SQLMatchType.Equal);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region List View Event Resource

        protected void lvCRMContactList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CheckBox chkSelectResourceLV = (CheckBox)e.Item.FindControl("chkSelectResourceLV");

                Int64 resourceIDLV, resourceCategoryIDLV;

                Label lblResourceIDLV = (Label)e.Item.FindControl("lblResourceIDLV");
                Label lblResourceCategoryIDLV = (Label)e.Item.FindControl("lblResourceCategoryIDLV");

                Int64.TryParse(lblResourceIDLV.Text, out resourceIDLV);
                Int64.TryParse(lblResourceCategoryIDLV.Text, out resourceCategoryIDLV);

                var employeeList = (from s in IssueCRMContactList_CustomEntityList
                                    where s.ResourceID == resourceIDLV && s.ResourceCategoryID == resourceCategoryIDLV.ToString()
                                    select s).ToList();
              

                if (employeeList != null && employeeList.Count() > 0)
                {
                    chkSelectResourceLV.Checked = true;
                }
                else
                {
                    chkSelectResourceLV.Checked = false;
                }
            }
        }

        #endregion List View Event

        #region Dropdown Event

        protected void ddlResourceCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildResourceByResourceCategory();
        }

        #endregion

        #endregion Event
    }
}
