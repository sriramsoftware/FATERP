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

namespace Bay.ERP.Web.UI
{
    public partial class OTDailyLogListControl : BaseControl
    {       
        #region Properties

        private String[] timespan;
        public String PageIssueListType { get; set; }
        public Int64 PageAPType { get; set; }

        public Int64 _IssueID
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

        public OTIssueEntity _OTIssueEntity
        {
            get
            {
                OTIssueEntity entity = new OTIssueEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTIssueEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        public Int64 CurrentemployeeID
        {
            get
            {
                Int64 _employeeID =0;

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

        private OTIssueEntity CurrentOTIssueEntity
        {
            get
            {
                if (_IssueID > 0)
                {
                    if (_OTIssueEntity.IssueID != _IssueID)
                    {
                        _OTIssueEntity = FCCOTIssue.GetFacadeCreate().GetByID(_IssueID);
                    }
                }

                return _OTIssueEntity;
            }
            set
            {
                _OTIssueEntity = value;
            }
        }

        #endregion

        #region Methods

        public string FormatTime(object value)
        {
            TimeSpan? time = value as TimeSpan?;
            if (time == null) return "";
            return string.Format("{0:00}:{1:00}", Math.Floor(time.Value.TotalHours), time.Value.Minutes);
        }

        private void BuildDropDownList()
        { 
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            txtDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            chbxFilter.Checked = true;
        }

        private void PrepareEditView()
        {
            OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;
        }

        private void BuildLabel()
        {
            String fe=(String)ViewState["SearchString"];

            if (fe.IsNotNullOrEmpty())
            {
                IList<OTIssue_DetailedEntity> lst=FCCOTIssue_Detailed.GetFacadeCreate().GetIL(1000000,1,String.Empty,fe);

                if (lst != null && lst.Count > 0)
                {
                    TimeSpan TotalTimeSpan=new TimeSpan(0,0,0);

                    foreach (OTIssue_DetailedEntity ent in lst)
                    {
                        TimeSpan DTLtime;
                        TimeSpan.TryParse(ent.DTLDuration.ToString(), out DTLtime);
                        TotalTimeSpan += DTLtime;
                    }

                    lblTotalTimeSpan.Text = "Total Duration: " + TotalTimeSpan;
                }

                else
                {
                    lblTotalTimeSpan.Text = "Total Duration: N/A.";
                }
            }
        }

        private void BindList()
        {
            BindOTIssueList();
        }

        private void BindOTIssueList()
        {
            lvOTIssue_Detailed.DataBind();
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

        protected void lvOTIssue_Detailed_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                OTIssue_DetailedEntity ent = (OTIssue_DetailedEntity)dataItem.DataItem;

                Label lblIssuePriorityNameLV = (Label)e.Item.FindControl("lblIssuePriorityNameLV");
                Label lblExpectedEndDateLV = (Label)e.Item.FindControl("lblExpectedEndDateLV");
                Label lblSupervisorAgreedLV = (Label)e.Item.FindControl("lblSupervisorAgreedLV");

                if (ent.IssuePriorityID == MasterDataConstants.MDIssuePriority.CRITICAL && ent.IssueStatusID != MasterDataConstants.MDIssueStatus.COMPLETED)
                {
                    lblIssuePriorityNameLV.ForeColor = System.Drawing.Color.Red;
                }

                if (ent.IssueStatusID != MasterDataConstants.MDIssueStatus.COMPLETED && ent.ExpectedEndDate < System.DateTime.Now)
                {
                    lblExpectedEndDateLV.ForeColor = System.Drawing.Color.Red;
                }

                if (ent.SupervisorAgreed == false)
                {
                    lblSupervisorAgreedLV.ForeColor = System.Drawing.Color.Red;
                }

                HyperLink hypEdit = (HyperLink)e.Item.FindControl("hypEdit");
                HyperLink hypEditDetails = (HyperLink)e.Item.FindControl("hypEditDetails");
                HyperLink hypAddSubIssue = (HyperLink)e.Item.FindControl("hypAddSubIssue");
                HyperLink hypAddReferenceIssue = (HyperLink)e.Item.FindControl("hypAddReferenceIssue");
                HyperLink hypAssignedResource = (HyperLink)e.Item.FindControl("hypAssignedResource");
                Button btnCompletedLV = (Button)e.Item.FindControl("btnCompletedLV");
                LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");

                //Stopped By Rayan vaiya
                //hypIssueReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.ISSUE_REPORT, UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();

                hypAssignedResource.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueAssignedResource.aspx", string.Empty, UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();

                #region Bind Edit Hyperlink

                switch (PageAPType)
                {
                    case MasterDataConstants.IssuePageType.ADHOC_ISSUE:
                        hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTAdhocIssue.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                        break;
                    case MasterDataConstants.IssuePageType.PROJECT_ADHOC_ISSUE:
                        hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                        break;
                    case MasterDataConstants.IssuePageType.MY_ISSUE_LIST:
                        if (ent.ReferenceID != null)
                        {
                            hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                            hypEditDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                        }
                        else
                        {
                            hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTAdhocIssue.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                            hypEditDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                        }
                        break;
                }

                if (ent.ReferenceID != null)
                {
                    hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                    hypEditDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                }
                else
                {
                    hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTAdhocIssue.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                    hypEditDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTAdhocIssue.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                }

                #endregion

                #region Link Build Logic

                if (CurrentemployeeID > 0)
                {
                    String fe=SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID,ent.CreatedByMemberID.ToString(),SQLMatchType.Equal);
                    IList<HREmployeeEntity> lstEmployeeEntity = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (CurrentemployeeID == ent.SupervisorEmployeeID
                        || lstEmployeeEntity[0].EmployeeID == CurrentemployeeID)
                    {

                        hypEdit.Visible = true;
                        hypEditDetails.Visible = true;
                        hypAssignedResource.Visible = true;
                        btnCompletedLV.Enabled = true;
                    }

                    else if(CurrentemployeeID == ent.AssignedToEmployeeID &&
                        CurrentemployeeID != ent.SupervisorEmployeeID &&
                        lstEmployeeEntity[0].EmployeeID != CurrentemployeeID)
                    {
                        hypEdit.Visible = true;
                        hypEditDetails.Visible = false;
                        hypAssignedResource.Visible = true;
                        btnCompletedLV.Enabled = true;
                    }

                    else
                    {
                        hypEdit.Visible = false;
                        hypEditDetails.Visible = false;
                        hypAssignedResource.Visible = false;
                        btnCompletedLV.Enabled = false;
                    }

                    if (CurrentemployeeID == ent.SupervisorEmployeeID||
                        CurrentemployeeID == lstEmployeeEntity[0].EmployeeID)
                    {
                        lnkBtnDelete.Visible = true;
                    }
                    else
                    {
                        lnkBtnDelete.Visible = false;
                    }
                }

                if (ent.IssueStatusID == MasterDataConstants.MDIssueStatus.COMPLETED)
                {
                    hypEdit.Visible = false;
                    hypEditDetails.Visible = false;
                    hypAssignedResource.Visible = false;
                    btnCompletedLV.Enabled = false;
                }

                #endregion

                //hypAddSubIssue.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueEditor.aspx", string.Empty, "do", "AddSubIssue", "ParentIssueID", ent.IssueID.ToString()).ToString();
                //hypAddReferenceIssue.NavigateUrl = UrlHelper.BuildSecureUrl("~/OT/OTIssueEditor.aspx", string.Empty, "do", "AddReferenceIssue", "ReferenceIssueID", ent.IssueID.ToString()).ToString();

                hypEdit.Target = "_blank";
            }
        }

        protected void lvOTIssue_Detailed_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssueID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssueID);

            if (IssueID > 0)
            {
                if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, IssueID.ToString(), SQLMatchType.Equal);

                        OTIssueEntity oTIssueEntity = new OTIssueEntity();

                        result = FCCOTIssue.GetFacadeCreate().Delete(oTIssueEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssueID = 0;
                            _OTIssueEntity = new OTIssueEntity();
                            PrepareInitialView();
                            BindOTIssueList();

                            MiscUtil.ShowMessage(lblMessage, "Issue has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Issue.", true);
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
                        _IssueID = IssueID;

                        OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;

                        if (CurrentOTIssueEntity.IssueStatusID == MasterDataConstants.MDIssueStatus.COMPLETED)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Already Completed.", false);
                            return;
                        }

                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, IssueID.ToString(), SQLMatchType.Equal);

                        
                        oTIssueEntity.IssueStatusID = MasterDataConstants.MDIssueStatus.COMPLETED;
                        oTIssueEntity.CompletionPercentage = 100;
                        result = FCCOTIssue.GetFacadeCreate().Update(oTIssueEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        if (result > 0)
                        {
                            _IssueID = 0;
                            _OTIssueEntity = new OTIssueEntity();
                            PrepareInitialView();
                            BindOTIssueList();

                            MiscUtil.ShowMessage(lblMessage, "Issue has been successfully Updated.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to Update Issue.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
                else if (string.Equals(e.CommandName, "EditGrid"))
                {
                    try
                    {
                        _IssueID = IssueID;

                        OTIssueEntity oTIssueEntity = CurrentOTIssueEntity;

                        Label lblTitleLV = (Label)e.Item.FindControl("lblTitleLV");
                        Label lblDurationLV = (Label)e.Item.FindControl("lblDurationLV");
                        Label lblIssueCategoryLV = (Label)e.Item.FindControl("lblIssueCategoryLV");
                        Label lblIssueStatusLV = (Label)e.Item.FindControl("lblIssueStatusLV");
                        Label lblIssueCategoryIDLV = (Label)e.Item.FindControl("lblIssueCategoryIDLV");
                        Label lblIssueStatusIDLV = (Label)e.Item.FindControl("lblIssueStatusIDLV");
                        Label lblProjectLV = (Label)e.Item.FindControl("lblProjectLV");
                        Label lblProjectIDLV = (Label)e.Item.FindControl("lblProjectIDLV");
                        DropDownList ddlIssueCategoryLV = (DropDownList)e.Item.FindControl("ddlIssueCategoryLV");
                        DropDownList ddlIssueStatusLV = (DropDownList)e.Item.FindControl("ddlIssueStatusLV");
                        DropDownList ddlProjectIDLV = (DropDownList)e.Item.FindControl("ddlProjectIDLV");
                        TextBox txtTitleLV = (TextBox)e.Item.FindControl("txtTitleLV");
                        TextBox txtDurationLV = (TextBox)e.Item.FindControl("txtDurationLV");
                        LinkButton lnkBtnUpdateGrid = (LinkButton)e.Item.FindControl("lnkBtnUpdateGrid");
                        LinkButton lnBtnCancelGrid = (LinkButton)e.Item.FindControl("lnBtnCancelGrid");
                        LinkButton lnkBtnEditGrid = (LinkButton)e.Item.FindControl("lnkBtnEditGrid");

                        txtTitleLV.Visible = true;
                        txtDurationLV.Visible = true;
                        ddlIssueCategoryLV.Visible = true;
                        ddlIssueStatusLV.Visible = true;
                        ddlProjectIDLV.Visible = true;

                        lblIssueCategoryLV.Visible = false;
                        lblIssueStatusLV.Visible = false;
                        lblTitleLV.Visible = false;
                        lblProjectLV.Visible = false;
                        lblDurationLV.Visible = false;
                        lnBtnCancelGrid.Visible = true;
                        lnkBtnUpdateGrid.Visible = true;
                        lnkBtnEditGrid.Visible = false;


                        MiscUtil.PopulateMDIssueCategoryForDTL(ddlIssueCategoryLV, false);
                        MiscUtil.PopulateMDIssueStatusForDTL(ddlIssueStatusLV, false);
                        MiscUtil.PopulateBDProjectForDTL(ddlProjectIDLV, true);

                        if (ddlIssueCategoryLV != null && ddlIssueCategoryLV.Items.Count > 0)
                        {
                            ddlIssueCategoryLV.SelectedValue = lblIssueCategoryIDLV.Text;
                        }

                        if (ddlIssueStatusLV != null && ddlIssueStatusLV.Items.Count > 0)
                        {
                            ddlIssueStatusLV.SelectedValue = lblIssueStatusIDLV.Text;
                        }

                        if (ddlProjectIDLV != null && ddlProjectIDLV.Items.Count > 0)
                        {
                            ddlProjectIDLV.SelectedValue = lblProjectIDLV.Text;
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
                    
                else if (string.Equals(e.CommandName, "AddToSchedule"))
                {
                    try
                    {
                        OTIssueEntity oTIssueEntity = FCCOTIssue.GetFacadeCreate().GetByID(IssueID);
                        OTScheduleEntity oTScheduleEntity = new OTScheduleEntity();
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }

                else if (string.Equals(e.CommandName, "UpdateGrid"))
                {
                    try
                    {
                        Label lblTitleLV = (Label)e.Item.FindControl("lblTitleLV");
                        Label lblDurationLV = (Label)e.Item.FindControl("lblDurationLV");
                        Label lblIssueCategoryLV = (Label)e.Item.FindControl("lblIssueCategoryLV");
                        Label lblIssueStatusLV = (Label)e.Item.FindControl("lblIssueStatusLV");
                        Label lblIssueCategoryIDLV = (Label)e.Item.FindControl("lblIssueCategoryIDLV");
                        Label lblIssueStatusIDLV = (Label)e.Item.FindControl("lblIssueStatusIDLV");
                        Label lblProjectLV = (Label)e.Item.FindControl("lblProjectLV");
                        Label lblProjectIDLV = (Label)e.Item.FindControl("lblProjectIDLV");
                        DropDownList ddlIssueCategoryLV = (DropDownList)e.Item.FindControl("ddlIssueCategoryLV");
                        DropDownList ddlIssueStatusLV = (DropDownList)e.Item.FindControl("ddlIssueStatusLV");
                        DropDownList ddlProjectIDLV = (DropDownList)e.Item.FindControl("ddlProjectIDLV");
                        TextBox txtTitleLV = (TextBox)e.Item.FindControl("txtTitleLV");
                        TextBox txtDurationLV = (TextBox)e.Item.FindControl("txtDurationLV");
                        LinkButton lnkBtnUpdateGrid = (LinkButton)e.Item.FindControl("lnkBtnUpdateGrid");
                        LinkButton lnBtnCancelGrid = (LinkButton)e.Item.FindControl("lnBtnCancelGrid");
                        LinkButton lnkBtnEditGrid = (LinkButton)e.Item.FindControl("lnkBtnEditGrid");

                        TimeSpan durationLV;

                        TimeSpan.TryParse(txtDurationLV.Text.Trim(), out durationLV);

                        OTIssueEntity oTIssueEntity = FCCOTIssue.GetFacadeCreate().GetByID(IssueID);
                        oTIssueEntity.IssueStatusID = Int64.Parse(ddlIssueStatusLV.SelectedValue);
                        oTIssueEntity.IssueCategoryID= Int64.Parse(ddlIssueCategoryLV.SelectedValue);
                        oTIssueEntity.ReferenceID= Int64.Parse(ddlProjectIDLV.SelectedValue);
                        oTIssueEntity.Title = txtTitleLV.Text.Trim().ToString();
                        oTIssueEntity.Duration = 0;
                        oTIssueEntity.DTLDuration = durationLV.ToString();


                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, IssueID.ToString(), SQLMatchType.Equal);

                        Int64 result = -1;
                        String fe_update = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID, IssueID.ToString(), SQLMatchType.Equal);
                        result = FCCOTIssue.GetFacadeCreate().Update(oTIssueEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        if (result > 0)
                        {
                            _IssueID = 0;
                            _OTIssueEntity = new OTIssueEntity();
                            PrepareInitialView();
                            BindOTIssueList();

                            txtTitleLV.Visible = false;
                            txtDurationLV.Visible = false;
                            ddlIssueCategoryLV.Visible = false;
                            ddlIssueStatusLV.Visible = false;
                            ddlProjectIDLV.Visible = false;

                            lblIssueCategoryLV.Visible = true;
                            lblIssueStatusLV.Visible = true;
                            lblTitleLV.Visible = true;
                            lblDurationLV.Visible = true;
                            lblProjectLV.Visible = true;
                            lnBtnCancelGrid.Visible = false;
                            lnkBtnUpdateGrid.Visible = false;
                            lnkBtnEditGrid.Visible = true;

                            MiscUtil.ShowMessage(lblMessage, "Issue has been successfully updated.", false);
                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }

                else if (string.Equals(e.CommandName, "CancelGridEdit"))
                {
                    try
                    {
                        Label lblTitleLV = (Label)e.Item.FindControl("lblTitleLV");
                        Label lblDurationLV = (Label)e.Item.FindControl("lblDurationLV");
                        Label lblIssueCategoryLV = (Label)e.Item.FindControl("lblIssueCategoryLV");
                        Label lblIssueStatusLV = (Label)e.Item.FindControl("lblIssueStatusLV");
                        Label lblIssueCategoryIDLV = (Label)e.Item.FindControl("lblIssueCategoryIDLV");
                        Label lblIssueStatusIDLV = (Label)e.Item.FindControl("lblIssueStatusIDLV");
                        Label lblProjectLV = (Label)e.Item.FindControl("lblProjectLV");
                        DropDownList ddlIssueCategoryLV = (DropDownList)e.Item.FindControl("ddlIssueCategoryLV");
                        DropDownList ddlIssueStatusLV = (DropDownList)e.Item.FindControl("ddlIssueStatusLV");
                        DropDownList ddlProjectIDLV = (DropDownList)e.Item.FindControl("ddlProjectIDLV");
                        TextBox txtTitleLV = (TextBox)e.Item.FindControl("txtTitleLV");
                        TextBox txtDurationLV = (TextBox)e.Item.FindControl("txtDurationLV");
                        LinkButton lnkBtnUpdateGrid = (LinkButton)e.Item.FindControl("lnkBtnUpdateGrid");
                        LinkButton lnBtnCancelGrid = (LinkButton)e.Item.FindControl("lnBtnCancelGrid");
                        LinkButton lnkBtnEditGrid = (LinkButton)e.Item.FindControl("lnkBtnEditGrid");

                        txtTitleLV.Visible = false;
                        txtDurationLV.Visible = false;
                        ddlIssueCategoryLV.Visible = false;
                        ddlIssueStatusLV.Visible = false;
                        ddlProjectIDLV.Visible = false;

                        lblIssueCategoryLV.Visible = true;
                        lblIssueStatusLV.Visible = true;
                        lblTitleLV.Visible = true;
                        lblDurationLV.Visible = true;
                        lblProjectLV.Visible = true;
                        lnBtnCancelGrid.Visible = false;
                        lnkBtnUpdateGrid.Visible = false;
                        lnkBtnEditGrid.Visible = true;
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

                    ListViewItem list = lvOTIssue_Detailed.InsertItem;

                    TextBox txtTitleLV = (TextBox)list.FindControl("txtTitleLV");
                    TextBox txtDurationLV = (TextBox)list.FindControl("txtDurationLV");
                    DropDownList ddlIssueCategoryIDLV = (DropDownList)list.FindControl("ddlIssueCategoryIDLV");
                    DropDownList ddlIssueStatusIDLV = (DropDownList)list.FindControl("ddlIssueStatusIDLV");
                    DropDownList ddlProjectIDLV = (DropDownList)list.FindControl("ddlProjectIDLV");

                    if (ddlIssueCategoryIDLV.SelectedValue == "0")
                    {
                        MiscUtil.ShowMessage(lblMessage,"You have selected Category Head. Please Select Issue Category", true);
                        return;
                    }

                    TimeSpan durationLV;

                    TimeSpan.TryParse(txtDurationLV.Text.Trim(), out durationLV);

                    OTIssueEntity oTIssueEntity = new OTIssueEntity();

                    oTIssueEntity.IssueCategoryID = Int64.Parse(ddlIssueCategoryIDLV.SelectedValue); 

                    oTIssueEntity.Title = txtTitleLV.Text.Trim();
                    oTIssueEntity.Description = "Daily Log Time";
                    oTIssueEntity.IssuePriorityID = MasterDataConstants.MDIssuePriority.HIGH;
                    oTIssueEntity.CompletionPercentage = 0;
                    oTIssueEntity.IssueStatusID = Int64.Parse(ddlIssueStatusIDLV.SelectedValue); 
                    oTIssueEntity.Duration = 0;

                    //String startDate=DateTime.ParseExact(txtStartDate.Text, "ddd MMM dd yyyy HH:mm:ss 'GMT'zzz", System.Globalization.CultureInfo.InvariantCulture).ToString();
                    //String startDate = txtStartDate.Text;

                    DateTime startDate = System.DateTime.Now;
                    DateTime endDate = System.DateTime.Now;

                    if (txtDate.Text.Trim().IsNotNullOrEmpty())
                    {
                        startDate = MiscUtil.ParseToDateTime(txtDate.Text.Trim().ToString());
                        endDate = startDate;
                    }

                    oTIssueEntity.ExpectedStartDate = startDate;
                    oTIssueEntity.ExpectedEndDate = endDate;
                    oTIssueEntity.SupervisorEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    oTIssueEntity.AssignedToEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    oTIssueEntity.ActualStartDate = null;
                    oTIssueEntity.ActualEndDate = null;
                    oTIssueEntity.NotifyBeforeMin = null;
                    oTIssueEntity.SupervisorAgreed = true;
                    oTIssueEntity.ModifiedBySupervisorDateTime = System.DateTime.Now;
                    oTIssueEntity.IP = MiscUtil.GetLocalIP();
                    oTIssueEntity.Remarks = String.Empty;

                    oTIssueEntity.IssueIdentityCategoryID = MasterDataConstants.IssueIdentityCategory.ADHOC_ISSUE;
                    oTIssueEntity.CreatedByMemberID = this.CurrentMember.MemberID;
                    oTIssueEntity.CompletionPercentage = 0;
                    oTIssueEntity.CreateDate = DateTime.Now;
                    oTIssueEntity.IsNotifyCompleted = false;
                    oTIssueEntity.IsRemoved = false;

                    oTIssueEntity.ParentIssueID = null;
                    oTIssueEntity.ReferenceID = Int64.Parse(ddlProjectIDLV.SelectedValue);
                    oTIssueEntity.ReferenceIssueID = null;
                    oTIssueEntity.DTLDuration = durationLV.ToString();

                    Int64 result = -1;

                    result = FCCOTIssue.GetFacadeCreate().Add(oTIssueEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    if (result > 0)
                    {
                        BindList();
                        MiscUtil.ShowMessage(lblMessage, "Event Created Successfully", false);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Can't Create Event.", true);
                    }
                  
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to save Daily Log Information.", true);
                }
            }
        }

        protected void lvOTIssue_Detailed_ItemCreated(object sender, ListViewItemEventArgs e)
        {
            if ((e.Item != null) && (e.Item.ItemType == ListViewItemType.InsertItem))
            {
                DropDownList ddlIssueStatusIDLV = (DropDownList)e.Item.FindControl("ddlIssueStatusIDLV");
                DropDownList ddlIssueCategoryIDLV = (DropDownList)e.Item.FindControl("ddlIssueCategoryIDLV");
                DropDownList ddlProjectIDLV = (DropDownList)e.Item.FindControl("ddlProjectIDLV");

                if (ddlIssueStatusIDLV != null)
                {
                    MiscUtil.PopulateMDIssueStatusForDTL((DropDownList)ddlIssueStatusIDLV, false);

                    if (ddlIssueStatusIDLV != null && ddlIssueStatusIDLV.Items.Count > 0)
                    {
                        ddlIssueStatusIDLV.SelectedValue = MasterDataConstants.MDIssueStatus.COMPLETED.ToString();
                    }
                }

                if (ddlIssueCategoryIDLV != null)
                {
                    MiscUtil.PopulateMDIssueCategoryForDTL(ddlIssueCategoryIDLV, false);

                    if (ddlIssueCategoryIDLV != null && ddlIssueCategoryIDLV.Items.Count > 0)
                    {
                        ddlIssueCategoryIDLV.SelectedValue = "14";//Need to change here with master data.
                    }
                }

                if (ddlProjectIDLV != null)
                {
                    MiscUtil.PopulateBDProjectForDTL(ddlProjectIDLV, true);

                    if (ddlProjectIDLV != null && ddlProjectIDLV.Items.Count > 0)
                    {
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsOTIssue_Detailed_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            switch (PageAPType)
            {
                case MasterDataConstants.IssuePageType.ADHOC_ISSUE:
                    fe = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, MasterDataConstants.IssueIdentityCategory.ADHOC_ISSUE.ToString(), SQLMatchType.Equal);
                    lblIssueList.Text = "Adhoc Issue List";
                    break;
                case MasterDataConstants.IssuePageType.PROJECT_ADHOC_ISSUE:
                    fe = SqlExpressionBuilder.PrepareFilterExpression("OTIssue."+OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, MasterDataConstants.IssueIdentityCategory.PROJECT_ADHOC_ISSUE.ToString(), SQLMatchType.Equal);
                    lblIssueList.Text = "Project Issue List";
                    break;
                case MasterDataConstants.IssuePageType.MY_ISSUE_LIST:
                    fe = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_CreatedByMemberID, CurrentMember.MemberID.ToString(), SQLMatchType.Equal);

                    Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                    if (employeeID > 0)
                    {
                        String fe_assignToEmployee = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_AssignedToEmployeeID, employeeID.ToString(), SQLMatchType.Equal);

                        fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe_assignToEmployee);

                        String fe_resource1=SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ResourceCategoryID,MasterDataConstants.ResourceCategory.EMPLOYEE.ToString(),SQLMatchType.Equal);
                        String fe_resource2=SqlExpressionBuilder.PrepareFilterExpression(ResourceEntity.FLD_NAME_ReferenceID,employeeID.ToString(),SQLMatchType.Equal);

                        String fe_resource=SqlExpressionBuilder.PrepareFilterExpression(fe_resource1,SQLJoinType.AND,fe_resource2);

                        IList<ResourceEntity> lstResource = FCCResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe_resource, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstResource != null && lstResource.Count>0)
                        {
                            String fe_Assigned_Issue = SqlExpressionBuilder.PrepareFilterExpression(OTIssueAssignedResourceEntity.FLD_NAME_ResourceID, lstResource[0].ResourceID.ToString(), SQLMatchType.Equal);

                            IList<OTIssueAssignedResourceEntity> lstIssueAssignedResource = FCCOTIssueAssignedResource.GetFacadeCreate().GetIL(null, null, String.Empty, fe_Assigned_Issue, DatabaseOperationType.LoadWithFilterExpression);

                            if (lstIssueAssignedResource != null && lstIssueAssignedResource.Count > 0)
                            {
                                String compositeIssueID = String.Empty;

                                foreach (OTIssueAssignedResourceEntity ent in lstIssueAssignedResource)
                                {
                                    compositeIssueID += ent.IssueID + ",";
                                }

                                if (compositeIssueID.IsNotNullOrEmpty())
                                {
                                    compositeIssueID = compositeIssueID.Substring(0, compositeIssueID.Length - 1);
                                    String fe_issue = "OTIssue.IssueID in(" + compositeIssueID + ")";

                                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe_issue);
                                }
                            }
                        }
                    }

                    lblIssueList.Text = "";
                    break;
                default:
                    fe = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, MasterDataConstants.IssueIdentityCategory.PROJECT_ADHOC_ISSUE.ToString(), SQLMatchType.Equal);
                    break;
            }

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_ExpectedStartDate, MiscUtil.ParseToDateTime(txtDate.Text.ToString()).ToShortDateString(), SQLMatchType.Equal);
                //String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MDIssuePriority.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                //String fe3 = SqlExpressionBuilder.PrepareFilterExpression("MDIssueStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                //Int64 issueID;
                //Int64.TryParse(txtSearchText.Text.Trim().ToString(), out issueID);
                //String fe6 = SqlExpressionBuilder.PrepareFilterExpression("OTIssue.IssueID", issueID.ToString(), SQLMatchType.Equal);
                //String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                //String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
                //String fe7 = SqlExpressionBuilder.PrepareFilterExpression(fe5, SQLJoinType.OR, fe6);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }
            else if (!chbxFilter.Checked)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("OTIssue." + OTIssueEntity.FLD_NAME_IssueID, "0", SQLMatchType.Equal);
            }

            ViewState["SearchString"] = fe;
            e.InputParameters["filterExpression"] = fe;

            BuildLabel();
           // lblTotalTimeSpan.Text = "Total Duration: ";
        }

        #endregion

        #region Button Event

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
            BuildLabel();
        }

        #endregion

        #endregion Event
    }
}
