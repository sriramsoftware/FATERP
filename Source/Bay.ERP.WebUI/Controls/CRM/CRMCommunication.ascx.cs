// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMCommunicationControl : BaseControl
    {       
        #region Properties

        public Int64 _CommunicationID
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

        public CRMCommunicationEntity _CRMCommunicationEntity
        {
            get
            {
                CRMCommunicationEntity entity = new CRMCommunicationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMCommunicationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMCommunicationEntity CurrentCRMCommunicationEntity
        {
            get
            {
                if (_CommunicationID > 0)
                {
                    if (_CRMCommunicationEntity.CommunicationID != _CommunicationID)
                    {
                        _CRMCommunicationEntity = FCCCRMCommunication.GetFacadeCreate().GetByID(_CommunicationID);
                    }
                }

                return _CRMCommunicationEntity;
            }
            set
            {
                _CRMCommunicationEntity = value;
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

        public Int64 OverviewBuyerBasicInfoID
        {
            get
            {
                Int64 buyerBasicInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID], out buyerBasicInfoID);
                }

                return buyerBasicInfoID;
            }
        }

        private CRMBuyerBasicInfoEntity CurrentCRMBuyerBasicInfoEntity
        {
            get
            {
                CRMBuyerBasicInfoEntity cRMBuyerBasicInfo = new CRMBuyerBasicInfoEntity();
                if (OverviewBuyerBasicInfoID > 0)
                {
                    cRMBuyerBasicInfo = FCCCRMBuyerBasicInfo.GetFacadeCreate().GetByID(OverviewBuyerBasicInfoID);
                }

                return cRMBuyerBasicInfo;
            }
        }

        public Int64 OverviewLandBasicInfoID
        {
            get
            {
                Int64 landBasicInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID], out landBasicInfoID);
                }

                return landBasicInfoID;
            }
        }

        private CRMLandBasicInfoEntity CurrentCRMLandBasicInfoEntity
        {
            get
            {
                CRMLandBasicInfoEntity cRMLandBasicInfo = new CRMLandBasicInfoEntity();

                if (OverviewLandBasicInfoID > 0)
                {
                    cRMLandBasicInfo = FCCCRMLandBasicInfo.GetFacadeCreate().GetByID(OverviewLandBasicInfoID);
                }

                return cRMLandBasicInfo;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMNProcessCategory(ddlProcessCategoryID, false);
            MiscUtil.PopulateCRMMDCommuicationDiscussionType(ddlCommuicationDiscussionTypeID, false);
            MiscUtil.PopulateHREmployee(ddlCommunicateByEmployeeID, false);
            MiscUtil.PopulateCRMMDCommunicationStatus(ddlCommunicationStatusID, false);

            GetActionFigure();

           // BindReferenceByProcessCategory();
        }

        private void GetActionFigure()
        {
            if (ddlProcessCategoryID.Items.Count > 0 && ddlProcessCategoryID != null)
            {
                switch (Action)
                {
                    case "Sales":
                        ddlProcessCategoryID.SelectedValue = MasterDataConstants.CMNProcessCategory.SALES.ToString();
                        cpeEditor.Collapsed = false;
                        cpeEditor.ClientState = "false";

                        BindReferenceByProcessCategory();

                        if(CurrentCRMBuyerBasicInfoEntity!=null && CurrentCRMBuyerBasicInfoEntity.BuyerBasicInfoID>0)
                        {
                            ddlReferenceID.SelectedValue = CurrentCRMBuyerBasicInfoEntity.BuyerBasicInfoID.ToString();
                            ddlReferenceID.Enabled = false;
                        }
                        
                        lblReference.Text = "Buyer";
                        ddlProcessCategoryID.Enabled = false;
                        break;
                    case "Land":
                        ddlProcessCategoryID.SelectedValue = MasterDataConstants.CMNProcessCategory.LAND.ToString();
                        cpeEditor.Collapsed = false;
                        cpeEditor.ClientState = "false";

                        BindReferenceByProcessCategory();

                        if (CurrentCRMLandBasicInfoEntity != null && CurrentCRMLandBasicInfoEntity.LandBasicInfoID > 0)
                        {
                            ddlReferenceID.SelectedValue = CurrentCRMLandBasicInfoEntity.LandBasicInfoID.ToString();
                            ddlReferenceID.Enabled = false;
                        }
                        
                        ddlReferenceID.Enabled = false;
                        ddlProcessCategoryID.Enabled = false;
                        lblReference.Text = "Landowner";
                        break;
                    case "None":
                        ddlProcessCategoryID.Enabled = true;
                        ddlReferenceID.Enabled = true;
                        ddlProcessCategoryID.SelectedValue = MasterDataConstants.CMNProcessCategory.SALES.ToString();
                        lblReference.Text = "Buyer";
                        BindReferenceByProcessCategory();
                        break;

                }
            }
        }

        private void BindReferenceByProcessCategory()
        {
            if (ddlProcessCategoryID.Items.Count > 0 && ddlProcessCategoryID != null)
            {
                switch (Int64.Parse(ddlProcessCategoryID.SelectedValue))
                {
                    case MasterDataConstants.CMNProcessCategory.LAND:
                        MiscUtil.PopulateCRMLandBasicInfo(ddlReferenceID, false);
                        break;
                    case MasterDataConstants.CMNProcessCategory.SALES:
                        MiscUtil.PopulateCRMBuyerBasicInfo(ddlReferenceID, false);
                        break;
                    case MasterDataConstants.CMNProcessCategory.INTERVIEW_PERSON:
                        ddlReferenceID.Items.Clear(); //Temporary Implemented
                        break;
                    default:
                        ddlReferenceID.Items.Clear();
                        break;
                }
            }
            else
            {
                ddlReferenceID.Items.Clear();
            }

        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDiscussionDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtTopics.Text = String.Empty;
            txtNote.Text = String.Empty;
            chkIsFollowUpNeeded.Checked = false;
            chkIsIWillCall.Checked = false;
            chkIsField1.Checked = false;
            txtNextAction.Text = String.Empty;
            txtNextCommunicationDate.Text = System.DateTime.Now.AddDays(7).ToString(UIConstants.SHORT_DATE_FORMAT);

            if (ddlCommunicateByEmployeeID.Items.Count > 0 && ddlCommunicateByEmployeeID != null)
            {
                Int64 currentEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                if (currentEmployeeID > 0)
                {
                    ddlCommunicateByEmployeeID.SelectedValue = currentEmployeeID.ToString();
                }
            }

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMCommunicationEntity cRMCommunicationEntity = CurrentCRMCommunicationEntity;


            if (!cRMCommunicationEntity.IsNew)
            {
                if (ddlCommuicationDiscussionTypeID.Items.Count > 0 && cRMCommunicationEntity.CommuicationDiscussionTypeID != null)
                {
                    ddlCommuicationDiscussionTypeID.SelectedValue = cRMCommunicationEntity.CommuicationDiscussionTypeID.ToString();
                }

                if (ddlProcessCategoryID.Items.Count > 0 && cRMCommunicationEntity.ProcessCategoryID != null)
                {
                    ddlProcessCategoryID.SelectedValue = cRMCommunicationEntity.ProcessCategoryID.ToString();
                }

                BindReferenceByProcessCategory();

                if (ddlReferenceID.Items.Count > 0 && cRMCommunicationEntity.ReferenceID != null)
                {
                    ddlReferenceID.SelectedValue = cRMCommunicationEntity.ReferenceID.ToString();
                }

                txtDiscussionDate.Text = cRMCommunicationEntity.DiscussionDate.ToStringDefault();
                if (ddlCommunicateByEmployeeID.Items.Count > 0 && cRMCommunicationEntity.CommunicateByEmployeeID != null)
                {
                    ddlCommunicateByEmployeeID.SelectedValue = cRMCommunicationEntity.CommunicateByEmployeeID.ToString();
                }

                txtTopics.Text = cRMCommunicationEntity.Topics.ToString();
                txtNote.Text = cRMCommunicationEntity.Note.ToString();
                chkIsFollowUpNeeded.Checked = cRMCommunicationEntity.IsFollowUpNeeded;
                chkIsIWillCall.Checked = cRMCommunicationEntity.IsIWillCall;
                chkIsField1.Checked = cRMCommunicationEntity.IsField1;
                txtNextAction.Text = cRMCommunicationEntity.NextAction.ToString();
                txtNextCommunicationDate.Text = cRMCommunicationEntity.NextCommunicationDate.ToStringDefault();
                if (ddlCommunicationStatusID.Items.Count > 0 && cRMCommunicationEntity.CommunicationStatusID != null)
                {
                    ddlCommunicationStatusID.SelectedValue = cRMCommunicationEntity.CommunicationStatusID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMCommunicationList();
        }

        private void BindCRMCommunicationList()
        {
            lvCRMCommunication.DataBind();
        }

        private CRMCommunicationEntity BuildCRMCommunicationEntity()
        {
            CRMCommunicationEntity cRMCommunicationEntity = CurrentCRMCommunicationEntity;

            if (ddlCommuicationDiscussionTypeID.Items.Count > 0)
            {
                if (ddlCommuicationDiscussionTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMCommunicationEntity.CommuicationDiscussionTypeID = Int64.Parse(ddlCommuicationDiscussionTypeID.SelectedValue);
                }
            }

            if (txtDiscussionDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMCommunicationEntity.DiscussionDate = MiscUtil.ParseToDateTime(txtDiscussionDate.Text);
            }

            if (ddlCommunicateByEmployeeID.Items.Count > 0)
            {
                if (ddlCommunicateByEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMCommunicationEntity.CommunicateByEmployeeID = Int64.Parse(ddlCommunicateByEmployeeID.SelectedValue);
                }
            }

            if (ddlProcessCategoryID.Items.Count > 0)
            {
                if (ddlProcessCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMCommunicationEntity.ProcessCategoryID = Int64.Parse(ddlProcessCategoryID.SelectedValue);
                }
            }

            if (ddlReferenceID.Items.Count > 0)
            {
                if (ddlReferenceID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMCommunicationEntity.ReferenceID = Int64.Parse(ddlReferenceID.SelectedValue);
                }
            }

            cRMCommunicationEntity.Topics = txtTopics.Text.Trim();
            cRMCommunicationEntity.Note = txtNote.Text.Trim();
            cRMCommunicationEntity.IsFollowUpNeeded = chkIsFollowUpNeeded.Checked;

            cRMCommunicationEntity.IsIWillCall = chkIsIWillCall.Checked;

            cRMCommunicationEntity.IsField1 = chkIsField1.Checked;

            cRMCommunicationEntity.NextAction = txtNextAction.Text.Trim();
            if (txtNextCommunicationDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMCommunicationEntity.NextCommunicationDate = MiscUtil.ParseToDateTime(txtNextCommunicationDate.Text);
            }
            else
            {
                cRMCommunicationEntity.NextCommunicationDate = null;
            }

            if (ddlCommunicationStatusID.Items.Count > 0)
            {
                if (ddlCommunicationStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMCommunicationEntity.CommunicationStatusID = Int64.Parse(ddlCommunicationStatusID.SelectedValue);
                }
            }

            Int64 currentEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            if (currentEmployeeID > 0)
            {
                cRMCommunicationEntity.CreatedByEmployeeID = currentEmployeeID;
            }

            cRMCommunicationEntity.IP = MiscUtil.GetLocalIP();
            cRMCommunicationEntity.CreateDate = System.DateTime.Now;

            return cRMCommunicationEntity;
        }

        private void SaveCRMCommunicationEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMCommunicationEntity cRMCommunicationEntity = BuildCRMCommunicationEntity();

                    Int64 result = -1;

                    if (cRMCommunicationEntity.IsNew)
                    {
                        result = FCCCRMCommunication.GetFacadeCreate().Add(cRMCommunicationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMCommunicationEntity.FLD_NAME_CommunicationID, cRMCommunicationEntity.CommunicationID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMCommunication.GetFacadeCreate().Update(cRMCommunicationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CommunicationID = 0;
                        _CRMCommunicationEntity = new CRMCommunicationEntity();
                        PrepareInitialView();
                        BindCRMCommunicationList();

                        if (cRMCommunicationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Communication Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Communication Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMCommunicationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Communication Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Communication Information.", false);
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
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvCRMCommunication_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CommunicationID;

            Int64.TryParse(e.CommandArgument.ToString(), out CommunicationID);

            if (CommunicationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CommunicationID = CommunicationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMCommunicationEntity.FLD_NAME_CommunicationID, CommunicationID.ToString(), SQLMatchType.Equal);

                        CRMCommunicationEntity cRMCommunicationEntity = new CRMCommunicationEntity();


                        result = FCCCRMCommunication.GetFacadeCreate().Delete(cRMCommunicationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CommunicationID = 0;
                            _CRMCommunicationEntity = new CRMCommunicationEntity();
                            PrepareInitialView();
                            BindCRMCommunicationList();

                            MiscUtil.ShowMessage(lblMessage, "Communication has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Communication.", true);
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

        protected void odsCRMCommunication_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CRMCommunicationEntity.FLD_NAME_CommunicateByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CRMCommunicationEntity.FLD_NAME_CreatedByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);

            if (chbxFilter.Checked)
            {
                String fe9 = "CommunicateToContactFullName like '%" + txtSearchText.Text + "%'";
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe9);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMCommunicationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CommunicationID = 0;
            _CRMCommunicationEntity = new CRMCommunicationEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region DropDownList Event

        protected void ddlProcessCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindReferenceByProcessCategory();
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
