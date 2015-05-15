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
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class CMNEventViewControl : BaseControl
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

        private void BindCMNERPCommentList()
        {
            lvCMNERPComment.DataBind();
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

            btnSubmit.Text = "Add";
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
            }
        }

        private void BindList()
        {
            BindCMNEventList();
        }

        private void BindCMNEventList()
        {
            
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
                        PrepareEditView();

                        if (cMNEventEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Information has been updated successfully.", false);
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

        #region Button Event

        protected void btnSavePost_Click(object sender, EventArgs e)
        {
            Int64 result = -1;
            result = ERPCommentEngine.CreateComment(MasterDataConstants.CMNProcessCategory.EVENT, OverviewEventID, txtComment.Text.Trim().ToString(), MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember));
            if (result > 0)
            {
                txtComment.Text = String.Empty;
                BindCMNERPCommentList();

                MiscUtil.ShowMessage(lblMessage, "Comment Information has been added successfully.", false);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Fail to save Information.", true);
            }

        }

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

        #region ObjectDataSource Event

        protected void odsCMNERPComment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMNERPComment." + CMNERPCommentEntity.FLD_NAME_ProcessCategoryID, "0", SQLMatchType.Equal);

            if (OverviewEventID > 0)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CMNERPComment." + CMNERPCommentEntity.FLD_NAME_ProcessCategoryID, MasterDataConstants.CMNProcessCategory.EVENT.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("CMNERPComment." + CMNERPCommentEntity.FLD_NAME_ReferenceID, OverviewEventID.ToString(), SQLMatchType.Equal);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            e.InputParameters["filterExpression"] = fe;
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
