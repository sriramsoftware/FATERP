// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
using Bay.ERP.Web.UI.Notifciation;
using AjaxControlToolkit;
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class OTIssueAssignedResourceControl : IssueBaseControl
    {
        #region Extra

        class CustomerComparer : IEqualityComparer<OTIssueAssignedResourceEntity>
        {
            public bool Equals(OTIssueAssignedResourceEntity x, OTIssueAssignedResourceEntity y)
            {
                return (x.ResourceID.Equals(y.ResourceID));
            }

            public int GetHashCode(OTIssueAssignedResourceEntity obj)
            {
                return obj.ResourceID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _IssueAssignedResourceID
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

        public OTIssueAssignedResourceEntity _OTIssueAssignedResourceEntity
        {
            get
            {
                OTIssueAssignedResourceEntity entity = new OTIssueAssignedResourceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTIssueAssignedResourceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        public IList<ResourceEmployee_CustomEntity> ResourceEmployeeList
        {
            get
            {
                return (IList<ResourceEmployee_CustomEntity>)ViewState["vs_ResourceEmployee_CustomEntity"];
            }
            set
            {
                ViewState["vs_ResourceEmployee_CustomEntity"] = value;
            }
        }

        public IList<OTIssueAssignedResourceEntity> IssueAssignedResourceEmployeeList
        {
            get
            {
                return (IList<OTIssueAssignedResourceEntity>)ViewState["IssueAssignedResourceEmployeeList"];
            }
            set
            {
                ViewState["IssueAssignedResourceEmployeeList"] = value;
            }
        }

        public IList<ResourceEntity> ResourceConstructionToolList
        {
            get
            {
                if (ViewState["vs_ResourceConstructionToolList"] == null)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceCategoryID, MasterDataConstants.ResourceCategory.TOOL.ToString(), SQLMatchType.Equal);
                    ViewState["vs_ResourceConstructionToolList"] = FCCResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                }

                return (IList<ResourceEntity>)ViewState["vs_ResourceConstructionToolList"];
            }
            set
            {
                ViewState["vs_ResourceConstructionToolList"] = value;
            }
        }

        public IList<ResourceContractor_CustomEntity> ResourceContractorList
        {
            get
            {
                return (IList<ResourceContractor_CustomEntity>)ViewState["vs_ResourceContractor_CustomEntity"];
            }
            set
            {
                ViewState["vs_ResourceContractor_CustomEntity"] = value;
            }
        }

        public Int64 _IssueUploadInfoID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["IssueUploadInfoID"] != null)
                {
                    Int64.TryParse(ViewState["IssueUploadInfoID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["IssueUploadInfoID"] = value;
            }
        }

        public OTIssueUploadInfoEntity _OTIssueUploadInfoEntity
        {
            get
            {
                OTIssueUploadInfoEntity entity = new OTIssueUploadInfoEntity();

                if (ViewState["CurrentIssueUploadInfoEntity"] != null)
                {
                    entity = (OTIssueUploadInfoEntity)ViewState["CurrentIssueUploadInfoEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentIssueUploadInfoEntity"] = value;
            }
        }

        private OTIssueUploadInfoEntity CurrentOTIssueUploadInfoEntity
        {
            get
            {
                if (_IssueUploadInfoID > 0)
                {
                    if (_OTIssueUploadInfoEntity.IssueUploadInfoID != _IssueUploadInfoID)
                    {
                        _OTIssueUploadInfoEntity = FCCOTIssueUploadInfo.GetFacadeCreate().GetByID(_IssueUploadInfoID);
                    }
                }

                return _OTIssueUploadInfoEntity;
            }
            set
            {
                _OTIssueUploadInfoEntity = value;
            }
        }

        private OTIssue_DetailedEntity CurrentOTIssueEntity
        {
            get
            {
                IList<OTIssue_DetailedEntity> lstOTIssue = new List<OTIssue_DetailedEntity>();

                if (OverviewIssueID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_IssueID, OverviewIssueID.ToString(), SQLMatchType.Equal);
                    lstOTIssue = FCCOTIssue_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);
                }

                return lstOTIssue[0];
            }
        }


        private OTIssueEntity CurrentOTIssueEntityForRoomeAllocation
        {
            get
            {
                IList<OTIssueEntity> lstOTIssue = new List<OTIssueEntity>();

                if (OverviewIssueID > 0)
                {
                    String fe = "IssueID = " + OverviewIssueID + "";
                    lstOTIssue = FCCOTIssue.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                }

                return lstOTIssue[0];
            }
        }

        public IList<OTIssueAssignedResourceEntity> CurrentOTIssueAssignedResourceEntityList
        {
            get
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_IssueID, OverviewIssueID.ToString(), SQLMatchType.Equal);
                IList<OTIssueAssignedResourceEntity> lst = FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                return lst!=null?lst:new List<OTIssueAssignedResourceEntity>();
            }
        }

        
        #endregion

        #region Methods

        private void IsItemNode(TreeNode tn)
        {
            if (tn.Depth == 1)
            {
                foreach (TreeNode n in tn.ChildNodes)
                {
                    Int64 referenceID = Int64.Parse(n.Value.ToString());
                    var resource = (from s in ResourceConstructionToolList
                                    where s.ReferenceID == referenceID
                                    select s).FirstOrDefault();

                    if (resource != null && resource.ResourceID > 0)
                    {

                        var tempItem = from s in CurrentOTIssueAssignedResourceEntityList
                                       where s.ResourceID == resource.ResourceID
                                       select s;

                        if (tempItem != null && tempItem.Count() > 0)
                        {
                            n.Checked = true;
                        }
                    }
                }
            }

        }

        private void BindOTIssueUploadInfoList()
        {
            lvOTIssueUploadInfo.DataBind();
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            treeConstructionTool.BuildTree();

            ResourceEmployeeList = new List<ResourceEmployee_CustomEntity>();
            IssueAssignedResourceEmployeeList = new List<OTIssueAssignedResourceEntity>();

            if (CurrentOTIssueAssignedResourceEntityList != null && CurrentOTIssueAssignedResourceEntityList.Count > 0)
            {
                IssueAssignedResourceEmployeeList = CurrentOTIssueAssignedResourceEntityList;

                foreach (TreeNode tn in treeConstructionTool.Nodes)
                {
                    IsItemNode(tn);
                }
            }

            pnlProjectFloor.Visible = false;
            pnlProjectFloorUnit.Visible = false;
            pnlProjectFlooorUnitLocationCategory.Visible = false;
        }

        private void BindList()
        {
            lvResourceEmployee_Custom.DataBind();
        }

        private void SaveOTIssueAssignedResourceEntity()
        {
            if (IsValid)
            {
                try
                {
                    #region Room Allocation
                    if (ddlProjectID.Items.Count > 0 && ddlProjectFloorID.Items.Count > 0 && ddlProjectFloorUnitID.Items.Count > 0 && ddlFloorUnitLocationCategoryID.Items.Count > 0)
                    {

                        OTIssueEntity entity = CurrentOTIssueEntityForRoomeAllocation;
                        entity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                        entity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                        entity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                        entity.ProjectFloorUnitLocationID = Int64.Parse(ddlFloorUnitLocationCategoryID.SelectedValue);

                        FCCOTIssue.GetFacadeCreate().Update(entity, "IssueID ="+OverviewIssueID.ToString(), DatabaseOperationType.Update, TransactionRequired.No);
                    }
                    #endregion

                    IList<OTIssueAssignedResourceEntity> assignedResourceList = new List<OTIssueAssignedResourceEntity>();
                    BindResourceEmployeeInfoNew();

                    if (IssueAssignedResourceEmployeeList != null && IssueAssignedResourceEmployeeList.Count > 0)
                    {
                        foreach (OTIssueAssignedResourceEntity EmployeeEntity in IssueAssignedResourceEmployeeList)
                        {
                            OTIssueAssignedResourceEntity ent = new OTIssueAssignedResourceEntity();
                            ent.IssueID = this.OverviewIssueID;
                            ent.ResourceID = EmployeeEntity.ResourceID;
                            ent.StartDate = EmployeeEntity.StartDate;
                            ent.EndDate = EmployeeEntity.EndDate;
                            ent.Remarks = EmployeeEntity.Remarks;
                            ent.IssueAssignTypeID = EmployeeEntity.IssueAssignTypeID;
                            assignedResourceList.Add(ent);
                        }
                    }

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceCategoryID, MasterDataConstants.ResourceCategory.TOOL.ToString(), SQLMatchType.Equal);
                    IList<ResourceEntity> ResourceConstructionToolList = FCCResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    foreach (TreeNode tn in treeConstructionTool.CheckedNodes)
                    {

                        Int64 ConstructionToolDetail;
                        Int64.TryParse(tn.Value.ToString(), out ConstructionToolDetail);
                        
                        IList<ResourceEntity> tempResourceConstructionToolList=(from s in ResourceConstructionToolList
                                                                                where s.ReferenceID == ConstructionToolDetail
                                                                                select s).ToList();

                        if (tempResourceConstructionToolList != null && tempResourceConstructionToolList.Count > 0)
                        {
                            OTIssueAssignedResourceEntity ent = new OTIssueAssignedResourceEntity();
                            ent.IssueID = this.OverviewIssueID;
                            ent.ResourceID = tempResourceConstructionToolList[0].ResourceID;
                            ent.StartDate = System.DateTime.Now;
                            ent.EndDate = System.DateTime.Now;
                            ent.Remarks = String.Empty;
                            ent.IssueAssignTypeID = 1;
                            assignedResourceList.Add(ent);
                        }
                    }
                    Int64 result = -1;

                    IList<OTIssueAssignedResourceEntity> finalAddList = assignedResourceList.Except(CurrentOTIssueAssignedResourceEntityList, new CustomerComparer()).ToList();
                    IList<OTIssueAssignedResourceEntity> finalDeleteList = CurrentOTIssueAssignedResourceEntityList.Except(assignedResourceList, new CustomerComparer()).ToList();

                    if (finalAddList != null && finalAddList.Count > 0)
                    {
                        foreach (OTIssueAssignedResourceEntity ent in finalAddList)
                        {
                            result = FCCOTIssueAssignedResource.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

                            #region Notification Here

                            //NotificationMessage message = new NotificationMessage();
                            //message.RecipientName = "Admin";
                            //message.MessageContent = "This is a test notificatiopn From Issue" + DateTime.Now.ToLongTimeString();

                            //if (!string.IsNullOrWhiteSpace(message.RecipientName) && !string.IsNullOrEmpty(message.MessageContent))
                            //{
                            //    // Call the client adapter to send the message to the particular recipient instantly.
                            //    NotificationClientAdapter.Instance.SendMessage(message);
                            //}

                            //NotificationMessageLive message = new NotificationMessageLive();
                            //message.RecipientName = "raju";
                            //message.MessageContent = "This is a test notificatiopn" + DateTime.Now.ToLongTimeString();

                            //if (!string.IsNullOrWhiteSpace(message.RecipientName) && !string.IsNullOrEmpty(message.MessageContent))
                            //{
                            //    // Call the client adapter to send the message to the particular recipient instantly.
                            //    NotificationAdapterLive.Instance.SendMessage(message);
                            //}
                            #endregion
                        }
                    }

                    if (finalDeleteList != null && finalDeleteList.Count > 0)
                    {
                        foreach (OTIssueAssignedResourceEntity ent in finalDeleteList)
                        {
                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_IssueID, OverviewIssueID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_ResourceID, ent.ResourceID.ToString(), SQLMatchType.Equal);
                            String fe_resource = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            FCCOTIssueAssignedResource.GetFacadeCreate().Delete(ent, fe_resource, DatabaseOperationType.Delete, TransactionRequired.No);

                            result = 1;
                            #region Notification Here

                            //NotificationMessage message = new NotificationMessage();
                            //message.RecipientName = "Admin";
                            //message.MessageContent = "This is a test notificatiopn From Issue" + DateTime.Now.ToLongTimeString();

                            //if (!string.IsNullOrWhiteSpace(message.RecipientName) && !string.IsNullOrEmpty(message.MessageContent))
                            //{
                            //    // Call the client adapter to send the message to the particular recipient instantly.
                            //    NotificationClientAdapter.Instance.SendMessage(message);
                            //}

                            //NotificationMessageLive message = new NotificationMessageLive();
                            //message.RecipientName = "raju";
                            //message.MessageContent = "This is a test notificatiopn" + DateTime.Now.ToLongTimeString();

                            //if (!string.IsNullOrWhiteSpace(message.RecipientName) && !string.IsNullOrEmpty(message.MessageContent))
                            //{
                            //    // Call the client adapter to send the message to the particular recipient instantly.
                            //    NotificationAdapterLive.Instance.SendMessage(message);
                            //}
                            #endregion
                        }
                    }

                    if (result > 0)
                    {
                        #region Send Notification

                        var distItems = finalAddList.Select(s1 => new OTIssueAssignedResourceEntity{ ResourceID =s1.ResourceID }).Where(w => IssueAssignedResourceEmployeeList.Select(s2 => s2.ResourceID).Contains(w.ResourceID)).ToList();

                        if (distItems != null && distItems.Count() > 0)
                        {
                            
                            String mailSubject = String.Empty;
                            String mailBody = String.Empty;
                            String[] mailTo = new String[1];
                            OTIssue_DetailedEntity oTIssueEntity = CurrentOTIssueEntity;

                            foreach (OTIssueAssignedResourceEntity ent in distItems)
                            {
                                if (oTIssueEntity != null)
                                {
                                    mailSubject = oTIssueEntity.Title.ToString() + "-" + oTIssueEntity.MemberFullName;
                                    mailBody = oTIssueEntity.IssueID +" - "+oTIssueEntity.Description.ToString();
                                    mailBody += "<br/>";
                                    mailBody += "<br/>";
                                    mailBody += "Expected Start Date: " + oTIssueEntity.ExpectedStartDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                                    mailBody += "<br/>";
                                    mailBody += "Expected End Date: " + oTIssueEntity.ExpectedEndDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                                }

                                String additionalMailBody = String.Empty;
                                additionalMailBody += "<br/>";
                                additionalMailBody += "Start Date: " + ent.StartDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                                additionalMailBody += "<br/>";
                                additionalMailBody += "End Date: " + ent.EndDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                                additionalMailBody += "<br/>";
                                mailBody += additionalMailBody;

                                ResourceEntity resouceEntity = FCCResource.GetFacadeCreate().GetByID(ent.ResourceID);

                                if (resouceEntity != null && resouceEntity.ReferenceID > 0)
                                {

                                    HREmployeeEntity hrEmployee = FCCHREmployee.GetFacadeCreate().GetByID(resouceEntity.ReferenceID);

                                    if (hrEmployee != null && hrEmployee.EmployeeID > 0)
                                    {
                                        mailTo[0] = hrEmployee.PrimaryEmail;
                                        MiscUtil.SendMail(mailTo, mailSubject, mailBody);
                                        additionalMailBody = String.Empty;
                                    }
                                }
                            }
                        }

                        #endregion

                        _IssueAssignedResourceID = 0;
                        _OTIssueAssignedResourceEntity = new OTIssueAssignedResourceEntity();
                        IssueAssignedResourceEmployeeList = CurrentOTIssueAssignedResourceEntityList;
                                                             
                        PrepareInitialView();

                        MiscUtil.ShowMessage(lblMessage, "Issue Assigned Resource Information has been added successfully.", false);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to add Issue Assigned Resource Information.", true);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void BuildDDLProjectFloor()
        {
            if (ddlProjectID.Items.Count > 0)
            {
                pnlProjectFloor.Visible = true;

                MiscUtil.PopulateBDProjectFloorByProject(ddlProjectFloorID, true, Int64.Parse(ddlProjectID.SelectedValue));
            }
        }

        private void BuildDDLProjectFloorUnit()
        {
            if (ddlProjectFloorID.Items.Count > 0 || CurrentOTIssueEntityForRoomeAllocation.ProjectFloorUnitID != null)
            {
                pnlProjectFloorUnit.Visible = true;

                MiscUtil.PopulateBDProjectFloorUnitByFloor(ddlProjectFloorUnitID, true, Int64.Parse(ddlProjectFloorID.SelectedValue));
            }
        }

        private void BuildDDlFloorUnitLocationCategory()
        {
            if (ddlProjectFloorUnitID.Items.Count > 0 || CurrentOTIssueEntityForRoomeAllocation.ProjectFloorUnitLocationID != null)
            {
                pnlProjectFlooorUnitLocationCategory.Visible = true;
                MiscUtil.PopulateBDProjectUnitLocationByFloorUnit(ddlFloorUnitLocationCategoryID, true, Int64.Parse(ddlProjectFloorUnitID.SelectedValue));
            }
        }

        private void PrepareProjectEditView()
        {

            OTIssueEntity entity = CurrentOTIssueEntityForRoomeAllocation;

            if (entity.ProjectID != null && entity.ProjectID > 0)
            {
                pnlProjectFloor.Visible = true;
                pnlProjectFloorUnit.Visible = true;
                pnlProjectFlooorUnitLocationCategory.Visible = true;
                ddlProjectID.SelectedValue = entity.ProjectID.ToString();
                ddlProjectFloorID.SelectedValue = entity.ProjectFloorID.ToString();
                ddlProjectFloorUnitID.SelectedValue = entity.ProjectFloorUnitID.ToString();
                ddlFloorUnitLocationCategoryID.SelectedValue = entity.ProjectFloorUnitLocationID.ToString();
            }
            
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareProjectEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvOTIssueAssignedResource_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Label lblResource = (Label)e.Item.FindControl("lblResource");
                CheckBox chbxState = (CheckBox)e.Item.FindControl("chbxState");
                DropDownList ddlIssueAssignTypeIDLV = (DropDownList)e.Item.FindControl("ddlIssueAssignTypeIDLV");
                TextBox txtStartDate = (TextBox)e.Item.FindControl("txtStartDate");
                TextBox txtEndDate = (TextBox)e.Item.FindControl("txtEndDate");

                txtStartDate.Text = CurrentOTIssueEntity.ExpectedStartDate.ToString();
                txtEndDate.Text = CurrentOTIssueEntity.ExpectedEndDate.ToString();
                
                if (CurrentOTIssueAssignedResourceEntityList != null && CurrentOTIssueAssignedResourceEntityList.Count > 0)
                {

                    var result = (from s in CurrentOTIssueAssignedResourceEntityList
                                  where s.ResourceID.ToString() == lblResource.Text.ToString()
                                  select s).FirstOrDefault();

                    //String fe1=SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_ResourceID,lblResource.Text.ToString(),SQLMatchType.Equal);
                    //String fe2=SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_IssueID,OverviewIssueID.ToString(),SQLMatchType.Equal);
                    //String fe=SqlExpressionBuilder.PrepareFilterExpression(fe1,SQLJoinType.AND,fe2);

                    //IList<OTIssueAssignedResourceEntity> lst=FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

                    if (result != null && result.ResourceID > 0)
                    {
                        chbxState.Checked = true;
                    }

                }

                MiscUtil.PopulateMDIssueAssignType(ddlIssueAssignTypeIDLV, false);

                OTIssueEntity entity = CurrentOTIssueEntityForRoomeAllocation;

                if (entity.ProjectID != null && entity.ProjectID > 0)
                {
                    pnlProjectFloor.Visible = true;
                    pnlProjectFloorUnit.Visible = true;
                    pnlProjectFlooorUnitLocationCategory.Visible = true;
                    ddlProjectID.SelectedValue = entity.ProjectID.ToString();
                    BuildDDLProjectFloor();
                    BuildDDLProjectFloorUnit();
                    BuildDDlFloorUnitLocationCategory();
                }
            }
        }

        protected void lvOTIssueAssignedResource_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueAssignedResourceID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueAssignedResourceID);

            if (IssueAssignedResourceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                  
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_IssueAssignedResourceID, IssueAssignedResourceID.ToString(), SQLMatchType.Equal);

                        OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity = new OTIssueAssignedResourceEntity();


                        result = FCCOTIssueAssignedResource.GetFacadeCreate().Delete(oTIssueAssignedResourceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueAssignedResourceID = 0;
                            _OTIssueAssignedResourceEntity = new OTIssueAssignedResourceEntity();
                            PrepareInitialView();

                         //MiscUtil.ShowMessage(lblMessage, "O TIssue Assigned Resource has been successfully deleted.", true);

                        }
                        else
                        {
                           // MiscUtil.ShowMessage(lblMessage, "Failed to delete O TIssue Assigned Resource.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        //MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region Issue Upload List View Event

        protected void lvOTIssueUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueUploadInfoID);

            if (IssueUploadInfoID > 0)
            {
                if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueUploadInfoEntity.FLD_NAME_IssueUploadInfoID, IssueUploadInfoID.ToString(), SQLMatchType.Equal);

                        OTIssueUploadInfoEntity oTIssueUploadInfoEntity = FCCOTIssueUploadInfo.GetFacadeCreate().GetByID(IssueUploadInfoID);


                        result = FCCOTIssueUploadInfo.GetFacadeCreate().Delete(oTIssueUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            if (File.Exists(Server.MapPath(oTIssueUploadInfoEntity.Path)))
                            {
                                File.Delete(Server.MapPath(oTIssueUploadInfoEntity.Path));
                            }

                            _IssueUploadInfoID = 0;
                            _OTIssueUploadInfoEntity = new OTIssueUploadInfoEntity();

                            BindOTIssueUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "File has been deleted successfully.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete file.", true);
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

        protected void odsOTIssueAssignedResource_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_IssueID, this.OverviewIssueID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsOTIssueUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueUploadInfoEntity.FLD_NAME_IssueID, OverviewIssueID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
          SaveOTIssueAssignedResourceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssueAssignedResourceID = 0;
            _OTIssueAssignedResourceEntity = new OTIssueAssignedResourceEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindOTIssueUploadInfoList();
        }

        #endregion

        #endregion Event

        #region Resource Manipulation

        #region ResourceEmployee

        #region Method

        private void BindResourceEmployeeInfoNew()
        {
            try
            {
                IList<ListViewDataItem> list = lvResourceEmployee_Custom.Items;

                if (list != null && list.Count > 0)
                {

                    foreach (ListViewDataItem lvdi in list)
                    {
                        CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxState");

                        if (chbxState.Checked == true)
                        {
                            Int64 ResourceID, employeeID;

                            Label lblResourceID = (Label)lvdi.FindControl("lblResource");
                            Label lblReferenceID = (Label)lvdi.FindControl("lblReferenceID");
                            TextBox txtStartDate = (TextBox)lvdi.FindControl("txtStartDate");
                            TextBox txtEndDate = (TextBox)lvdi.FindControl("txtEndDate");
                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                            DropDownList ddlIssueAssignTypeIDLV = (DropDownList)lvdi.FindControl("ddlIssueAssignTypeIDLV");
                            Label lblEmployeePrimaryEmailLV = (Label)lvdi.FindControl("lblEmployeePrimaryEmailLV");
                            Int64.TryParse(lblResourceID.Text, out ResourceID);
                            Int64.TryParse(lblReferenceID.Text, out employeeID);

                            OTIssueAssignedResourceEntity oTAssignedResourceEntity = new OTIssueAssignedResourceEntity();

                            oTAssignedResourceEntity.ResourceID = ResourceID;

                            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
                            {
                                oTAssignedResourceEntity.StartDate = DateTime.Parse(txtStartDate.Text);
                            }
                            else
                            {
                                oTAssignedResourceEntity.StartDate = System.DateTime.Now;
                            }

                            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
                            {
                                oTAssignedResourceEntity.EndDate= DateTime.Parse(txtEndDate.Text);
                            }
                            else
                            {
                                oTAssignedResourceEntity.EndDate = System.DateTime.Now;
                            }

                            if (ddlIssueAssignTypeIDLV.Items.Count > 0)
                            {
                                if (ddlIssueAssignTypeIDLV.SelectedValue == "0")
                                {
                                }
                                else
                                {
                                    oTAssignedResourceEntity.IssueAssignTypeID= Int64.Parse(ddlIssueAssignTypeIDLV.SelectedValue);
                                }
                            }

                            if (txtRemarksLV.Text.Trim().IsNotNullOrEmpty())
                            {
                                oTAssignedResourceEntity.Remarks = txtRemarksLV.Text.Trim();
                            }

                            else
                            {
                                oTAssignedResourceEntity.Remarks = null;
                            }

                            //Check Existing Item

                            var employeeList = (from s in IssueAssignedResourceEmployeeList
                                                where s.ResourceID == ResourceID
                                                select s);
                            if (employeeList == null || employeeList.Count() <= 0)
                            {
                                IssueAssignedResourceEmployeeList.Add(oTAssignedResourceEntity);
                            }

                        }

                        else if (chbxState.Checked == false)
                        {

                            Int64 ResourceID;

                            Label lblResourceID = (Label)lvdi.FindControl("lblResource");
                            Int64.TryParse(lblResourceID.Text, out ResourceID);

                            var item = from s in IssueAssignedResourceEmployeeList
                                       where s.ResourceID == ResourceID
                                       select s;

                            if (item != null && item.Count() > 0)
                            {
                                //Check Deleted Employee.
                                OTIssueAssignedResourceEntity di = (from d in IssueAssignedResourceEmployeeList
                                                                    where d.ResourceID == ResourceID
                                                                    select d).First();
                                //Delete Here.
                                if (di != null)
                                {
                                    IssueAssignedResourceEmployeeList.Remove(di);
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

        #region List View Event

        //Checked Resource From ViewState
        protected void lvResourceEmployee_Custom_DataBound(object sender, EventArgs e)
        {
            #region Make the Decision to Checkedbox from ViewState

            if (IssueAssignedResourceEmployeeList != null && IssueAssignedResourceEmployeeList.Count > 0)
            {
                IList<ListViewDataItem> list = lvResourceEmployee_Custom.Items;

                if (list != null && list.Count > 0)
                {

                    foreach (ListViewDataItem lvdi in list)
                    {
                        Int64 ResourceID;

                        Label lblResource = (Label)lvdi.FindControl("lblResource");
                        Int64.TryParse(lblResource.Text, out ResourceID);

                        IList<OTIssueAssignedResourceEntity> employeeList = (from s in IssueAssignedResourceEmployeeList
                                                                             where s.ResourceID == ResourceID
                                                                             select s).ToList();

                        if (employeeList != null && employeeList.Count() > 0)
                        {
                            CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxState");
                            TextBox txtStartDate = (TextBox)lvdi.FindControl("txtStartDate");
                            TextBox txtEndDate = (TextBox)lvdi.FindControl("txtEndDate");
                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                            DropDownList ddlIssueAssignTypeIDLV = (DropDownList)lvdi.FindControl("ddlIssueAssignTypeIDLV");

                            txtStartDate.Text = employeeList[0].StartDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                            txtEndDate.Text = employeeList[0].EndDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                            txtRemarksLV.Text = employeeList[0].Remarks;

                            if (ddlIssueAssignTypeIDLV.Items.Count > 0 && ddlIssueAssignTypeIDLV != null)
                            {
                                ddlIssueAssignTypeIDLV.SelectedValue = employeeList[0].IssueAssignTypeID.ToString();
                            }

                            chbxState.Checked = true;

                        }

                    }
                }
            }

            #endregion
        }

        protected void lvResourceEmployee_Custom_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            /*
            Int64 ResourceID;

            Int64.TryParse(e.CommandArgument.ToString(), out ResourceID);

            if (ResourceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ResourceID = ResourceID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ResourceEmployee_CustomEntity.FLD_NAME_ResourceID, ResourceID.ToString(), SQLMatchType.Equal);

                        ResourceEmployee_CustomEntity resourceEmployee_CustomEntity = new ResourceEmployee_CustomEntity();


                        result = FCCResourceEmployee_Custom.GetFacadeCreate().Delete(resourceEmployee_CustomEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ResourceID = 0;
                            _ResourceEmployee_CustomEntity = new ResourceEmployee_CustomEntity();
                            PrepareInitialView();
                            BindResourceEmployee_CustomList();

                            MiscUtil.ShowMessage(lblMessage, "Resource Employee Custom has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Resource Employee Custom.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
            */
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsResourceEmployee_Custom_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            if (e.ExecutingSelectCount == false)
            {
                BindResourceEmployeeInfoNew();
            }

            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("HREmployee.EmployeeCode", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("HRMember.MiddleName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("MDDepartment.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe6 = SqlExpressionBuilder.PrepareFilterExpression("HRMember.FirstName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe7 = SqlExpressionBuilder.PrepareFilterExpression("HRMember.LastName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe8 = SqlExpressionBuilder.PrepareFilterExpression(fe6, SQLJoinType.OR, fe7);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.OR, fe3);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe8);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectID_SelectedIndexChanged(Object sender, EventArgs e)
        {
            BuildDDLProjectFloor();
        }

        protected void ddlProjectFloorID_SelectedIndexChanged(Object sender, EventArgs e)
        {
            BuildDDLProjectFloorUnit();
        }

        protected void ddlProjectFloorUnitID_SelectedIndexChanged(Object sender, EventArgs e)
        {
            BuildDDlFloorUnitLocationCategory();
        }

        #endregion 

        #endregion Event

        #endregion

        #endregion

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            OTIssueUploadInfoEntity ent = new OTIssueUploadInfoEntity();
            ent.IssueID = this.OverviewIssueID;
            ent.OriginalFileName = Path.GetFileName(e.FileName);
            ent.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
            ent.FileType = "";
            ent.Extension = Path.GetExtension(e.FileName);
            ent.Path = FileUploadConstants.Issue.ADHOC_DOCUMENTS + ent.CurrentFileName;
            ent.Remarks = String.Empty;

            FCCOTIssueUploadInfo.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

            // file upload

            afuFiles.SaveAs(Server.MapPath(ent.Path));

            //LoadFileListGried
            BindOTIssueUploadInfoList();
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion
    }
}
#region Backup
 //private void BindResourceEmployeeInfo()
 //       {
 //           try
 //           {
 //               IList<ListViewDataItem> list = lvResourceEmployee_Custom.Items;

 //               if (list != null && list.Count > 0)
 //               {

 //                   foreach (ListViewDataItem lvdi in list)
 //                   {
 //                       CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxState");

 //                       if (chbxState.Checked == true)
 //                       {
 //                           Int64 ResourceID,employeeID;

 //                           Label lblResourceID = (Label)lvdi.FindControl("lblResource");
 //                           Label lblReferenceID = (Label)lvdi.FindControl("lblReferenceID");
 //                           TextBox txtStartDate = (TextBox)lvdi.FindControl("txtStartDate");
 //                           TextBox txtEndDate = (TextBox)lvdi.FindControl("txtEndDate");
 //                           TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
 //                           DropDownList ddlIssueAssignTypeIDLV = (DropDownList)lvdi.FindControl("ddlIssueAssignTypeIDLV");
 //                           Label lblEmployeePrimaryEmailLV = (Label)lvdi.FindControl("lblEmployeePrimaryEmailLV");
 //                           Int64.TryParse(lblResourceID.Text, out ResourceID);
 //                           Int64.TryParse(lblReferenceID.Text, out employeeID);

 //                           ResourceEmployee_CustomEntity ent = new ResourceEmployee_CustomEntity();

 //                           #region Assign Resource Entitiy Builder

 //                           OTIssueAssignedResourceEntity oTAssignedResourceEntity=new OTIssueAssignedResourceEntity();

 //                           #endregion

 //                           ent.ResourceID = ResourceID;
 //                           ent.EmployeeID = employeeID;

 //                           //if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
 //                           //{
 //                           //    ent. = MiscUtil.ParseToDateTimeJQueryUI(txtExpectedStartDate.Text);
 //                           //}
 //                           //else
 //                           //{
 //                           //    oTIssueEntity.ExpectedStartDate = null;
 //                           //}

 //                           //if (txtExpectedEndDate.Text.Trim().IsNotNullOrEmpty())
 //                           //{
 //                           //    oTIssueEntity.ExpectedEndDate = MiscUtil.ParseToDateTimeJQueryUI(txtExpectedEndDate.Text);
 //                           //}
 //                           //else
 //                           //{
 //                           //    oTIssueEntity.ExpectedEndDate = null;
 //                           //}

 //                           //if (ddlSupervisorEmployeeID.Items.Count > 0)
 //                           //{
 //                           //    if (ddlSupervisorEmployeeID.SelectedValue == "0")
 //                           //    {
 //                           //    }
 //                           //    else
 //                           //    {
 //                           //        oTIssueEntity.SupervisorEmployeeID = Int64.Parse(ddlSupervisorEmployeeID.SelectedValue);
 //                           //    }
 //                           //}
                            
 //                           ent.PrimaryEmail = lblEmployeePrimaryEmailLV.Text;

 //                           //Check Existing Item

 //                           var employeeList = (from s in ResourceEmployeeList
 //                                               where s.ResourceID == ResourceID
 //                                               select s);
 //                           if (employeeList == null || employeeList.Count() <= 0)
 //                           {
 //                               ResourceEmployeeList.Add(ent);
 //                           }

 //                       }

 //                       else if (chbxState.Checked == false)
 //                       {

 //                           Int64 ResourceID;

 //                           Label lblResourceID = (Label)lvdi.FindControl("lblResource");
 //                           Int64.TryParse(lblResourceID.Text, out ResourceID);

 //                           var item = from s in ResourceEmployeeList
 //                                      where s.ResourceID == ResourceID
 //                                      select s;

 //                           if (item != null && item.Count() > 0)
 //                           {
 //                               //Check Delete Employee.
 //                               ResourceEmployee_CustomEntity di = (from d in ResourceEmployeeList
 //                                                                   where d.ResourceID == ResourceID
 //                                                                   select d).First();
 //                               //Delete Here.
 //                               if (di != null)
 //                               {
 //                                   ResourceEmployeeList.Remove(di);
 //                               }
 //                           }
 //                       }
 //                   }
 //               }
 //           }
 //           catch (Exception ex)
 //           {

 //           }
 //       }

#endregion
