// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




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
    public partial class CMNEventControl : BaseControl
    {       
        #region Properties

        public Int64 _EventID
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

        public CMNEventEntity _CMNEventEntity
        {
            get
            {
                CMNEventEntity entity = new CMNEventEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNEventEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNEventEntity CurrentCMNEventEntity
        {
            get
            {
                if (_EventID > 0)
                {
                    if (_CMNEventEntity.EventID != _EventID)
                    {
                        _CMNEventEntity = FCCCMNEvent.GetFacadeCreate().GetByID(_EventID);
                    }
                }

                return _CMNEventEntity;
            }
            set
            {
                _CMNEventEntity = value;
            }
        }

        public Int64 OverviewEventIdentityCategoryID
        {
            get
            {
                Int64 overviewEventIdentityCategoryID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID], out overviewEventIdentityCategoryID);
                }

                return overviewEventIdentityCategoryID;
            }
        }

        public Int64 OverviewEventID
        {
            get
            {
                Int64 overviewEventID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EVENT_ID], out overviewEventID);
                }

                return overviewEventID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMNMDEventCategoryByEventIdentity(ddlEventCategoryID, false, OverviewEventIdentityCategoryID);
            MiscUtil.PopulateMDEventLocationCategory(ddlEventLocationCategoryID, false);
            MiscUtil.PopulateCMNMDEventOption(ddlEventOptionID, false);
            MiscUtil.PopulateBDMDRepeatCategory(ddlRepeatCategoryID, false);
            MiscUtil.PopulateCMNMDSharedSetting(ddlSharedSettingID, false);

            PrepareGalleriaDropdown();
        }

        private void PrepareGalleriaDropdown()
        {
            switch (OverviewEventIdentityCategoryID)
            {
                case MasterDataConstants.CMNMDEventIdentityCategory.ART_GALLERY_EVENT:
                    ddlEventLocationCategoryID.SelectedValue = MasterDataConstants.MDEventLocationCategory.ART_GALLERIA.ToString();
                    break;
                case MasterDataConstants.CMNMDEventIdentityCategory.BAY_S_OFFICIAL_EVENT:
                case MasterDataConstants.CMNMDEventIdentityCategory.FRONT_DESK_EVENT:
                    ddlEventLocationCategoryID.SelectedValue = MasterDataConstants.MDEventLocationCategory.OFFICIAL_ROOM.ToString();
                    break;
            }

            BuildLocationCategory();
        }

        private void BuildLocationCategory()
        {
            switch (Int64.Parse(ddlEventLocationCategoryID.SelectedValue))
            {
                case MasterDataConstants.MDEventLocationCategory.LOCATION_NOT_AVAILABLE:
                    pnlGalleria.Visible = false;
                    break;
                case MasterDataConstants.MDEventLocationCategory.OFFICIAL_ROOM:
                    lblGalleria.Text = "Unit Location";
                    MiscUtil.PopulateBDProjectUnitLocationByProject(ddlGalleriaLocationID, false,MasterDataConstants.Project.DEFAULT_PROJECT);
                    //Project ID cooperate
                    pnlGalleria.Visible = true;
                    break;
                case MasterDataConstants.MDEventLocationCategory.ART_GALLERIA:
                    MiscUtil.PopulateMDArtGalleriaLocation(ddlGalleriaLocationID, false);
                    pnlGalleria.Visible = true;
                    break;
            }
        }

        private void PrepareValidator()
        {
            revWebsiteURL.ValidationExpression = ValidationConstants.RegularExpression.Web;
            revWebsiteURL.ErrorMessage = ValidationConstants.ErrorMessage.Web;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtEventReferenceNo.Text = MasterDataConstants.AutoAssigned.DEFAULT_AUTO_ASSIGNED;
            txtTitle.Text = String.Empty;
            txtDetails.Text = String.Empty;
            txtLocation.Text = String.Empty;
            txtWebsiteURL.Text = String.Empty;
            txtTicketSellerURL.Text = String.Empty;
            txtYoutubeURL.Text = String.Empty;
            txtTransitAndParkingInformation.Text = String.Empty;
            txtDuration.Text = String.Empty;
            txtExpectedStartDate.Text = System.DateTime.Now.ToString("MM/dd/yyyy hh:mm");
            txtExpectedEndDate.Text = System.DateTime.Now.AddHours(1).ToString("MM/dd/yyyy hh:mm");
            txtActualStartDate.Text = String.Empty;
            txtActualEndDate.Text = String.Empty;
            chkIsAllDay.Checked = false;
            txtNotifyBeforeMin.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            if(OverviewEventID>0)
            {
                _EventID = OverviewEventID;
            }

            hypEventSchedule.NavigateUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventSchedule.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID, OverviewEventIdentityCategoryID.ToString()).ToString();

            hypEventSchedule.Target = "_blank";

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMNEventEntity cMNEventEntity = CurrentCMNEventEntity;


            if (!cMNEventEntity.IsNew)
            {
                if (ddlEventCategoryID.Items.Count > 0 && cMNEventEntity.EventCategoryID != null)
                {
                    ddlEventCategoryID.SelectedValue = cMNEventEntity.EventCategoryID.ToString();
                }

                txtEventReferenceNo.Text = cMNEventEntity.EventReferenceNo.ToString();
                txtTitle.Text = cMNEventEntity.Title.ToString();
                txtDetails.Text = cMNEventEntity.Details.ToString();
                txtLocation.Text = cMNEventEntity.Location.ToString();
                if (ddlEventLocationCategoryID.Items.Count > 0 && cMNEventEntity.EventLocationCategoryID != null)
                {
                    ddlEventLocationCategoryID.SelectedValue = cMNEventEntity.EventLocationCategoryID.ToString();
                }

                //Location will come here 

                txtWebsiteURL.Text = cMNEventEntity.WebsiteURL.ToString();
                txtTicketSellerURL.Text = cMNEventEntity.TicketSellerURL.ToString();
                txtYoutubeURL.Text = cMNEventEntity.YoutubeURL.ToString();
                txtTransitAndParkingInformation.Text = cMNEventEntity.TransitAndParkingInformation.ToString();
                if (ddlEventOptionID.Items.Count > 0 && cMNEventEntity.EventOptionID != null)
                {
                    ddlEventOptionID.SelectedValue = cMNEventEntity.EventOptionID.ToString();
                }

                if (ddlRepeatCategoryID.Items.Count > 0 && cMNEventEntity.RepeatCategoryID != null)
                {
                    ddlRepeatCategoryID.SelectedValue = cMNEventEntity.RepeatCategoryID.ToString();
                }
                
                txtDuration.Text = cMNEventEntity.Duration.ToString();

                txtExpectedStartDate.Text = MiscUtil.ConvertDateTSQLStringJQueryUI(DateTime.Parse(cMNEventEntity.ExpectedStartDate.ToString()));

                if (cMNEventEntity.ExpectedEndDate != null)
                {
                    txtExpectedEndDate.Text = MiscUtil.ConvertDateTSQLStringJQueryUI(DateTime.Parse(cMNEventEntity.ExpectedEndDate.ToString()));
                }

                else
                {
                    txtExpectedEndDate.Text = String.Empty;
                }

                if (cMNEventEntity.ActualStartDate != null)
                {
                    txtActualStartDate.Text = MiscUtil.ConvertDateTSQLStringJQueryUI(DateTime.Parse(cMNEventEntity.ActualStartDate.ToString()));
                }

                else
                {
                    txtActualStartDate.Text = String.Empty;
                }

                if (cMNEventEntity.ActualEndDate != null)
                {
                    txtActualEndDate.Text = MiscUtil.ConvertDateTSQLStringJQueryUI(DateTime.Parse(cMNEventEntity.ActualEndDate.ToString()));
                }

                else
                {
                    txtActualEndDate.Text = String.Empty;
                }

                chkIsAllDay.Checked = cMNEventEntity.IsAllDay;
                txtNotifyBeforeMin.Text = cMNEventEntity.NotifyBeforeMin.ToString();
                txtRemarks.Text = cMNEventEntity.Remarks.ToString();
                if (ddlSharedSettingID.Items.Count > 0 && cMNEventEntity.SharedSettingID != null)
                {
                    ddlSharedSettingID.SelectedValue = cMNEventEntity.SharedSettingID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNEventList();
        }

        private void BindCMNEventList()
        {
            lvCMNEvent.DataBind();
        }

        private CMNEventEntity BuildCMNEventEntity()
        {
            CMNEventEntity cMNEventEntity = CurrentCMNEventEntity;

            cMNEventEntity.EventIdentityCategoryID = OverviewEventIdentityCategoryID;

            if (ddlEventCategoryID.Items.Count > 0)
            {
                if (ddlEventCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNEventEntity.EventCategoryID = Int64.Parse(ddlEventCategoryID.SelectedValue);
                }
            }
            
            cMNEventEntity.ParentEventID = null;
            cMNEventEntity.ReferenceEventID = null;

            cMNEventEntity.EventReferenceNo = txtEventReferenceNo.Text.Trim();
            cMNEventEntity.Title = txtTitle.Text.Trim();
            cMNEventEntity.Details = txtDetails.Text.Trim();
            cMNEventEntity.Location = txtLocation.Text.Trim();
            if (ddlEventLocationCategoryID.Items.Count > 0)
            {
                if (ddlEventLocationCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNEventEntity.EventLocationCategoryID = Int64.Parse(ddlEventLocationCategoryID.SelectedValue);
                }
            }

            if (ddlGalleriaLocationID.Items.Count > 0)
            {
                if (ddlGalleriaLocationID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNEventEntity.LocationReferenceID = Int64.Parse(ddlGalleriaLocationID.SelectedValue);
                }
            }

            cMNEventEntity.WebsiteURL = txtWebsiteURL.Text.Trim();
            cMNEventEntity.TicketSellerURL = txtTicketSellerURL.Text.Trim();
            cMNEventEntity.YoutubeURL = txtYoutubeURL.Text.Trim();
            cMNEventEntity.TransitAndParkingInformation = txtTransitAndParkingInformation.Text.Trim();

            if (ddlEventOptionID.Items.Count > 0)
            {
                if (ddlEventOptionID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNEventEntity.EventOptionID = Int64.Parse(ddlEventOptionID.SelectedValue);
                }
            }

            cMNEventEntity.CompletionPercentage = 0;
            cMNEventEntity.EventStatusID = MasterDataConstants.CMNMDEventStatus.UP_COMING;

            if (ddlRepeatCategoryID.Items.Count > 0)
            {
                if (ddlRepeatCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNEventEntity.RepeatCategoryID = Int64.Parse(ddlRepeatCategoryID.SelectedValue);
                }
            }
            cMNEventEntity.CreatedByMemberID = CurrentMember.MemberID;
            cMNEventEntity.OwnerMemberID = CurrentMember.MemberID;
            cMNEventEntity.CreateDate = System.DateTime.Now;
            cMNEventEntity.Duration = 0;

            if (txtExpectedStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMNEventEntity.ExpectedStartDate = MiscUtil.ParseToDateTimeJQueryUI(txtExpectedStartDate.Text);
            }

            if (txtExpectedEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMNEventEntity.ExpectedEndDate = MiscUtil.ParseToDateTimeJQueryUI(txtExpectedEndDate.Text);
            }
            else
            {
                cMNEventEntity.ExpectedEndDate = null;
            }

            if (txtActualStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMNEventEntity.ActualStartDate = MiscUtil.ParseToDateTimeJQueryUI(txtActualStartDate.Text);
            }
            else
            {
                cMNEventEntity.ActualStartDate = null;
            }

            if (txtActualEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMNEventEntity.ActualEndDate = MiscUtil.ParseToDateTimeJQueryUI(txtActualEndDate.Text);
            }
            else
            {
                cMNEventEntity.ActualEndDate = null;
            }

            cMNEventEntity.IsAllDay = chkIsAllDay.Checked;

            if (!txtNotifyBeforeMin.Text.Trim().IsNullOrEmpty())
            {
                cMNEventEntity.NotifyBeforeMin = Int32.Parse(txtNotifyBeforeMin.Text.Trim());
            }
            else
            {
                cMNEventEntity.NotifyBeforeMin = null;
            }

            cMNEventEntity.IsNotifyCompleted = false;
            cMNEventEntity.Remarks = txtRemarks.Text.Trim();

            if (ddlSharedSettingID.Items.Count > 0)
            {
                if (ddlSharedSettingID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNEventEntity.SharedSettingID = Int64.Parse(ddlSharedSettingID.SelectedValue);
                }
            }

            cMNEventEntity.ModifiedDateTime = System.DateTime.Now;
            cMNEventEntity.IP = MiscUtil.GetLocalIP();
            cMNEventEntity.IsOwnerGoing = false;
            cMNEventEntity.IsRemoved = false;

            return cMNEventEntity;
        }

        private void SaveCMNEventEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNEventEntity cMNEventEntity = BuildCMNEventEntity();

                    Int64 result = -1;
                    
                    if (cMNEventEntity.IsNew)
                    {
                        result = FCCCMNEvent.GetFacadeCreate().Add(cMNEventEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_EventID, cMNEventEntity.EventID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNEvent.GetFacadeCreate().Update(cMNEventEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {   
                        _EventID = 0;
                        _CMNEventEntity = new CMNEventEntity();
                        PrepareInitialView();
                        BindCMNEventList();

                        if (cMNEventEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Information has been added successfully.", false);
                            String NavigationUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventInvitationInformation.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_ID, result.ToString()).ToString();
                            Response.Redirect(NavigationUrl);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Information has been updated successfully.", false);
                            String NavigationUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventInvitationInformation.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_ID, result.ToString()).ToString();
                            Response.Redirect(NavigationUrl);
                        }
                    }
                    else
                    {
                        if (cMNEventEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Event Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Event Information.", false);
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

        protected void lvCMNEvent_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventID);

            if (EventID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventID = EventID;

                    PrepareEditView();
                }

                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_EventID, EventID.ToString(), SQLMatchType.Equal);

                        CMNEventEntity cMNEventEntity = new CMNEventEntity();


                        result = FCCCMNEvent.GetFacadeCreate().Delete(cMNEventEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventID = 0;
                            _CMNEventEntity = new CMNEventEntity();
                            PrepareInitialView();
                            BindCMNEventList();

                            MiscUtil.ShowMessage(lblMessage, "Event has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Event.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        protected void lvCMNEvent_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMNEvent_DetailedEntity ent = (CMNEvent_DetailedEntity)dataItem.DataItem;
                HyperLink hypUploadInfo = (HyperLink)e.Item.FindControl("hypUploadInfo");
                HyperLink hypInvitationInfo = (HyperLink)e.Item.FindControl("hypInvitationInfo");
                

                //if (ent.BillStatusID == MasterDataConstants.MDBillStatus.FINAL_BILL)
                //{
                //    LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                //    LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");

                //    lnkBtnEdit.Enabled = false;
                //    lnkBtnDelete.Enabled = false;
                //    lnkBtnEdit.ToolTip = "Final Bill Submitted. Can't be Modified!!!";
                //    lnkBtnDelete.ToolTip = "Final Bill Submitted. Can't be Modified!!!";
                //}

                //HyperLink hypTitleLV = (HyperLink)e.Item.FindControl("hypTitleLV");
                //hypTitleLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventView.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_ID, ent.EventID.ToString(),UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID,ent.EventIdentityCategoryID.ToString()).ToString();
                //hypTitleLV.Target = "_blank";

                hypUploadInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventUploadInfo.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_ID, ent.EventID.ToString()).ToString();
                hypInvitationInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/Common/CMNEventInvitationInformation.aspx", string.Empty, UrlConstants.OVERVIEW_EVENT_ID, ent.EventID.ToString()).ToString();

                hypUploadInfo.Target = "_blank";
                hypInvitationInfo.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsCMNEvent_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_EventIdentityCategoryID, OverviewEventIdentityCategoryID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_CreatedByMemberID, CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            String fe_invitation=SqlExpressionBuilder.PrepareFilterExpression(CMNEventInvitationInformationEntity.FLD_NAME_InitationGivenToMemberID,CurrentMember.MemberID.ToString(),SQLMatchType.Equal);
            IList<CMNEventInvitationInformationEntity> lstCMNEventInvitationInformationEntity = FCCCMNEventInvitationInformation.GetFacadeCreate().GetIL(null, null, String.Empty, fe_invitation, DatabaseOperationType.LoadWithFilterExpression);

            if (lstCMNEventInvitationInformationEntity != null && lstCMNEventInvitationInformationEntity.Count > 0)
            {
                String compositeEventID = String.Empty;

                foreach (CMNEventInvitationInformationEntity ent in lstCMNEventInvitationInformationEntity)
                {
                    compositeEventID += ent.EventID + ",";
                }
                compositeEventID = compositeEventID.Substring(0, compositeEventID.Length - 1);

                String fe_compsite = "EventID In(" + compositeEventID + ")";

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe_compsite);
            }

            if (chbxFilter.Checked)
            {
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_Title, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_EventReferenceNo, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe5);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNEventEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EventID = 0;
            _CMNEventEntity = new CMNEventEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion
        
        #region Dropdown Event

        protected void ddlEventLocationCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildLocationCategory();
        }

       

        #endregion

        #region Check Box Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
