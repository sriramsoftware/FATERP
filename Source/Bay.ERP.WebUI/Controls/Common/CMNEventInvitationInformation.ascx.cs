// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Text;

namespace Bay.ERP.Web.UI
{
    public partial class CMNEventInvitationInformationControl : BaseControl
    {       
        #region Properties

        public Int64 _EventInvitationInformationID
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

        public CMNEventInvitationInformationEntity _CMNEventInvitationInformationEntity
        {
            get
            {
                CMNEventInvitationInformationEntity entity = new CMNEventInvitationInformationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNEventInvitationInformationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNEventInvitationInformationEntity CurrentCMNEventInvitationInformationEntity
        {
            get
            {
                if (_EventInvitationInformationID > 0)
                {
                    if (_CMNEventInvitationInformationEntity.EventInvitationInformationID != _EventInvitationInformationID)
                    {
                        _CMNEventInvitationInformationEntity = FCCCMNEventInvitationInformation.GetFacadeCreate().GetByID(_EventInvitationInformationID);
                    }
                }

                return _CMNEventInvitationInformationEntity;
            }
            set
            {
                _CMNEventInvitationInformationEntity = value;
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
            MiscUtil.PopulateHRMemberForEventInvitationGroupWise(ddlInitationGivenToMemberID, false);
            MiscUtil.PopulateMDEventInvitatedPersonType(ddlEventInvitatedPersonTypeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            txtMessage.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity = CurrentCMNEventInvitationInformationEntity;


            if (!cMNEventInvitationInformationEntity.IsNew)
            {  
                if (ddlInitationGivenToMemberID.Items.Count > 0 && cMNEventInvitationInformationEntity.InitationGivenToMemberID != null)
                {
                    ddlInitationGivenToMemberID.SelectedValue = cMNEventInvitationInformationEntity.InitationGivenToMemberID.ToString();
                }

                if (ddlEventInvitatedPersonTypeID.Items.Count > 0 && cMNEventInvitationInformationEntity.EventInvitatedPersonTypeID != null)
                {
                    ddlEventInvitatedPersonTypeID.SelectedValue = cMNEventInvitationInformationEntity.EventInvitatedPersonTypeID.ToString();
                }
                txtMessage.Text = cMNEventInvitationInformationEntity.Message.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNEventInvitationInformationList();
        }

        private void BindCMNEventInvitationInformationList()
        {
            lvCMNEventInvitationInformation.DataBind();
        }

        private CMNEventInvitationInformationEntity BuildCMNEventInvitationInformationEntity()
        {
            CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity = CurrentCMNEventInvitationInformationEntity;

            if (OverviewEventID > 0)
            {
                cMNEventInvitationInformationEntity.EventID = OverviewEventID;
            }
            cMNEventInvitationInformationEntity.InitationGivenByMemberID = CurrentMember.MemberID;
            cMNEventInvitationInformationEntity.SharedDateTime = DateTime.Now;
            cMNEventInvitationInformationEntity.Message = txtMessage.Text.Trim();

            if (ddlInitationGivenToMemberID.Items.Count > 0)
            {
                if (ddlInitationGivenToMemberID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNEventInvitationInformationEntity.InitationGivenToMemberID = Int64.Parse(ddlInitationGivenToMemberID.SelectedValue);
                }
            }

            if (ddlEventInvitatedPersonTypeID.Items.Count > 0)
            {
                if (ddlEventInvitatedPersonTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNEventInvitationInformationEntity.EventInvitatedPersonTypeID = Int64.Parse(ddlEventInvitatedPersonTypeID.SelectedValue);
                }
            }

            cMNEventInvitationInformationEntity.IsGuestGoing = false;
            cMNEventInvitationInformationEntity.IP = MiscUtil.GetLocalIP();

            return cMNEventInvitationInformationEntity;
        }

        private void SaveCMNEventInvitationInformationEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity = BuildCMNEventInvitationInformationEntity();

                    Int64 result = -1;

                    if (cMNEventInvitationInformationEntity.IsNew)
                    {
                        result = FCCCMNEventInvitationInformation.GetFacadeCreate().Add(cMNEventInvitationInformationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNEventInvitationInformationEntity.FLD_NAME_EventInvitationInformationID, cMNEventInvitationInformationEntity.EventInvitationInformationID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNEventInvitationInformation.GetFacadeCreate().Update(cMNEventInvitationInformationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EventInvitationInformationID = 0;
                        _CMNEventInvitationInformationEntity = new CMNEventInvitationInformationEntity();
                        PrepareInitialView();
                        BindCMNEventInvitationInformationList();

                        if (cMNEventInvitationInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Invitation Information Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Invitation Information Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNEventInvitationInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Event Invitation Information Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Event Invitation Information Information.", false);
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

        protected void lvCMNEventInvitationInformation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventInvitationInformationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventInvitationInformationID);

            if (EventInvitationInformationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventInvitationInformationID = EventInvitationInformationID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNEventInvitationInformationEntity.FLD_NAME_EventInvitationInformationID, EventInvitationInformationID.ToString(), SQLMatchType.Equal);

                        CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity = new CMNEventInvitationInformationEntity();


                        result = FCCCMNEventInvitationInformation.GetFacadeCreate().Delete(cMNEventInvitationInformationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventInvitationInformationID = 0;
                            _CMNEventInvitationInformationEntity = new CMNEventInvitationInformationEntity();
                            PrepareInitialView();
                            BindCMNEventInvitationInformationList();

                            MiscUtil.ShowMessage(lblMessage, "Event Invitation Information has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Event Invitation Information.", true);
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

        protected void odsCMNEventInvitationInformation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMNEventInvitationInformation." + CMNEventInvitationInformationEntity.FLD_NAME_EventID, OverviewEventID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNEventInvitationInformationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EventInvitationInformationID = 0;
            _CMNEventInvitationInformationEntity = new CMNEventInvitationInformationEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnSendMailToGuest_Click(object sender, EventArgs e)
        {
           //Mail will implement here.

            #region Guest Invitation Mail

            CMNEventEntity cMNEventEntity=FCCCMNEvent.GetFacadeCreate().GetByID(OverviewEventID);

            String MailBody = String.Empty;
            String Subject = String.Empty;

            StringBuilder sb = new StringBuilder();

            sb.Append("Dear Sir,");
            sb.Append("<br/>");
            sb.Append("This is a auto generated mail from the ERP.");
            sb.Append("<br/>");
            sb.Append("An Event has created.");
            sb.Append("<br/>");
            sb.Append("Dated : " + cMNEventEntity.ExpectedStartDate.ToString(UIConstants.SHORT_DATE_FORMAT));
            sb.Append("<br/>");
            sb.Append("-");
            sb.Append("<br/>");
            sb.Append("Thanks");
            sb.Append("<br/>");
            sb.Append("ERP System");
            MailBody = sb.ToString();
            Subject = "ERP, Event";

            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMNEventInvitationInformationEntity.FLD_NAME_EventID, OverviewEventID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMNEventInvitationInformationEntity.FLD_NAME_EventInvitatedPersonTypeID, MasterDataConstants.EventInvitationPersonType.GUEST.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            IList<CMNEventInvitationInformationEntity> lstEventInvitationInformationEntity = FCCCMNEventInvitationInformation.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lstEventInvitationInformationEntity != null && lstEventInvitationInformationEntity.Count > 0)
            {
                String[] sendToMail = new String[10]; // Should change here.
                Int64 i = 0;

                foreach(CMNEventInvitationInformationEntity ent in lstEventInvitationInformationEntity)
                {
                    HRMemberEntity hRMemberEntity = FCCHRMember.GetFacadeCreate().GetByID(ent.InitationGivenToMemberID);

                    if (hRMemberEntity != null && hRMemberEntity.MemberID > 0)
                    {
                        switch (hRMemberEntity.MemberTypeID)
                        {
                            case MasterDataConstants.MemberType.HR_MEMBER:

                                String fe_member = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, ent.InitationGivenToMemberID.ToString(), SQLMatchType.Equal);
                                IList<HREmployeeEntity> lsthREmployeeEntity = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe_member, DatabaseOperationType.LoadWithFilterExpression);

                                if (lsthREmployeeEntity != null && lsthREmployeeEntity.Count > 0)
                                {
                                    sendToMail[i++] = lsthREmployeeEntity[0].PrimaryEmail;
                                }
                                break;

                                //Will Implement Later on...
                            case MasterDataConstants.MemberType.CONSULATANT:
                                break;
                            //case MasterDataConstants.MemberType.CONSULATANT:
                            //    break;
                        }
                    }
                    
                }

                MiscUtil.SendMail(sendToMail, Subject, MailBody);
            }

            #endregion
        }

        #endregion

        #endregion Event
    }
}
