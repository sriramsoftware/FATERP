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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class OTScheduleControl : BaseControl
    {       
        #region Properties

        public Int64 _ScheduleID
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

        public OTScheduleEntity _OTScheduleEntity
        {
            get
            {
                OTScheduleEntity entity = new OTScheduleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTScheduleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private OTScheduleEntity CurrentOTScheduleEntity
        {
            get
            {
                if (_ScheduleID > 0)
                {
                    if (_OTScheduleEntity.ScheduleID != _ScheduleID)
                    {
                        _OTScheduleEntity = FCCOTSchedule.GetFacadeCreate().GetByID(_ScheduleID);
                    }
                }

                return _OTScheduleEntity;
            }
            set
            {
                _OTScheduleEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDScheduleIdentityCategory(ddlScheduleIdentityCategoryID, false);
            MiscUtil.PopulateMDScheduleCategory(ddlScheduleCategoryID, false);
            MiscUtil.PopulateMDSchedulePriority(ddlSchedulePriorityID, false);
            MiscUtil.PopulateHRMember(ddlCreatedByMemberID, false);
            MiscUtil.PopulateOTSchedule(ddlReferenceScheduleID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtReferenceID.Text = String.Empty;
            txtTitle.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtCreateDate.Text = String.Empty;
            txtDuration.Text = String.Empty;
            txtStartDateTime.Text = String.Empty;
            txtEndDateTime.Text = String.Empty;
            txtNotifyBeforeMin.Text = String.Empty;
            chkIsNotifyCompleted.Checked = false;
            txtRemarks.Text = String.Empty;
            chkIsRescheduled.Checked = false;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            OTScheduleEntity oTScheduleEntity = CurrentOTScheduleEntity;


            if (!oTScheduleEntity.IsNew)
            {
                if (ddlScheduleIdentityCategoryID.Items.Count > 0 && oTScheduleEntity.ScheduleIdentityCategoryID != null)
                {
                    ddlScheduleIdentityCategoryID.SelectedValue = oTScheduleEntity.ScheduleIdentityCategoryID.ToString();
                }

                if (ddlScheduleCategoryID.Items.Count > 0 && oTScheduleEntity.ScheduleCategoryID != null)
                {
                    ddlScheduleCategoryID.SelectedValue = oTScheduleEntity.ScheduleCategoryID.ToString();
                }

                txtReferenceID.Text = oTScheduleEntity.ReferenceID.ToString();
                txtTitle.Text = oTScheduleEntity.Title.ToString();
                txtDescription.Text = oTScheduleEntity.Description.ToString();
                if (ddlSchedulePriorityID.Items.Count > 0 && oTScheduleEntity.SchedulePriorityID != null)
                {
                    ddlSchedulePriorityID.SelectedValue = oTScheduleEntity.SchedulePriorityID.ToString();
                }

                if (ddlCreatedByMemberID.Items.Count > 0 && oTScheduleEntity.CreatedByMemberID != null)
                {
                    ddlCreatedByMemberID.SelectedValue = oTScheduleEntity.CreatedByMemberID.ToString();
                }

                txtCreateDate.Text = oTScheduleEntity.CreateDate.ToStringDefault();
                txtDuration.Text = oTScheduleEntity.Duration.ToString();
                txtStartDateTime.Text = oTScheduleEntity.StartDateTime.ToStringDefault();
                txtEndDateTime.Text = oTScheduleEntity.EndDateTime.ToStringDefault();
                txtNotifyBeforeMin.Text = oTScheduleEntity.NotifyBeforeMin.ToString();
                chkIsNotifyCompleted.Checked = oTScheduleEntity.IsNotifyCompleted;
                txtRemarks.Text = oTScheduleEntity.Remarks.ToString();
                if (ddlReferenceScheduleID.Items.Count > 0 && oTScheduleEntity.ReferenceScheduleID != null)
                {
                    ddlReferenceScheduleID.SelectedValue = oTScheduleEntity.ReferenceScheduleID.ToString();
                }

                chkIsRescheduled.Checked = oTScheduleEntity.IsRescheduled;
                chkIsRemoved.Checked = oTScheduleEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindOTScheduleList();
        }

        private void BindOTScheduleList()
        {
            lvOTSchedule.DataBind();
        }

        private OTScheduleEntity BuildOTScheduleEntity()
        {
            OTScheduleEntity oTScheduleEntity = CurrentOTScheduleEntity;

            if (ddlScheduleIdentityCategoryID.Items.Count > 0)
            {
                if (ddlScheduleIdentityCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    oTScheduleEntity.ScheduleIdentityCategoryID = Int64.Parse(ddlScheduleIdentityCategoryID.SelectedValue);
                }
            }

            if (ddlScheduleCategoryID.Items.Count > 0)
            {
                if (ddlScheduleCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    oTScheduleEntity.ScheduleCategoryID = Int64.Parse(ddlScheduleCategoryID.SelectedValue);
                }
            }

            if (!txtReferenceID.Text.Trim().IsNullOrEmpty())
            {
                oTScheduleEntity.ReferenceID = Int64.Parse(txtReferenceID.Text.Trim());
            }
            else
            {
                oTScheduleEntity.ReferenceID = null;
            }

            oTScheduleEntity.Title = txtTitle.Text.Trim();
            oTScheduleEntity.Description = txtDescription.Text.Trim();
            if (ddlSchedulePriorityID.Items.Count > 0)
            {
                if (ddlSchedulePriorityID.SelectedValue == "0")
                {
                }
                else
                {
                    oTScheduleEntity.SchedulePriorityID = Int64.Parse(ddlSchedulePriorityID.SelectedValue);
                }
            }

            if (ddlCreatedByMemberID.Items.Count > 0)
            {
                if (ddlCreatedByMemberID.SelectedValue == "0")
                {
                }
                else
                {
                    oTScheduleEntity.CreatedByMemberID = Int64.Parse(ddlCreatedByMemberID.SelectedValue);
                }
            }

            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                oTScheduleEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }
            else
            {
                oTScheduleEntity.CreateDate = null;
            }

            if (!txtDuration.Text.Trim().IsNullOrEmpty())
            {
                oTScheduleEntity.Duration = Decimal.Parse(txtDuration.Text.Trim());
            }
            else
            {
                oTScheduleEntity.Duration = null;
            }

            if (txtStartDateTime.Text.Trim().IsNotNullOrEmpty())
            {
                oTScheduleEntity.StartDateTime = MiscUtil.ParseToDateTime(txtStartDateTime.Text);
            }
            else
            {
                oTScheduleEntity.StartDateTime = null;
            }

            if (txtEndDateTime.Text.Trim().IsNotNullOrEmpty())
            {
                oTScheduleEntity.EndDateTime = MiscUtil.ParseToDateTime(txtEndDateTime.Text);
            }
            else
            {
                oTScheduleEntity.EndDateTime = null;
            }

            if (!txtNotifyBeforeMin.Text.Trim().IsNullOrEmpty())
            {
                oTScheduleEntity.NotifyBeforeMin = Int32.Parse(txtNotifyBeforeMin.Text.Trim());
            }
            else
            {
                oTScheduleEntity.NotifyBeforeMin = null;
            }

            oTScheduleEntity.IsNotifyCompleted = chkIsNotifyCompleted.Checked;

            oTScheduleEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlReferenceScheduleID.Items.Count > 0)
            {
                if (ddlReferenceScheduleID.SelectedValue == "0")
                {
                    oTScheduleEntity.ReferenceScheduleID = null;
                }
                else
                {
                    oTScheduleEntity.ReferenceScheduleID = Int64.Parse(ddlReferenceScheduleID.SelectedValue);
                }
            }

            oTScheduleEntity.IsRescheduled = chkIsRescheduled.Checked;

            oTScheduleEntity.IsRemoved = chkIsRemoved.Checked;


            return oTScheduleEntity;
        }

        private void SaveOTScheduleEntity()
        {
            if (IsValid)
            {
                try
                {
                    OTScheduleEntity oTScheduleEntity = BuildOTScheduleEntity();

                    Int64 result = -1;

                    if (oTScheduleEntity.IsNew)
                    {
                        result = FCCOTSchedule.GetFacadeCreate().Add(oTScheduleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(OTScheduleEntity.FLD_NAME_ScheduleID, oTScheduleEntity.ScheduleID.ToString(), SQLMatchType.Equal);
                        result = FCCOTSchedule.GetFacadeCreate().Update(oTScheduleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ScheduleID = 0;
                        _OTScheduleEntity = new OTScheduleEntity();
                        PrepareInitialView();
                        BindOTScheduleList();

                        if (oTScheduleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "O TSchedule Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "O TSchedule Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (oTScheduleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add O TSchedule Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update O TSchedule Information.", false);
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

        protected void lvOTSchedule_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ScheduleID;

            Int64.TryParse(e.CommandArgument.ToString(), out ScheduleID);

            if (ScheduleID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ScheduleID = ScheduleID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTScheduleEntity.FLD_NAME_ScheduleID, ScheduleID.ToString(), SQLMatchType.Equal);

                        OTScheduleEntity oTScheduleEntity = new OTScheduleEntity();


                        result = FCCOTSchedule.GetFacadeCreate().Delete(oTScheduleEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ScheduleID = 0;
                            _OTScheduleEntity = new OTScheduleEntity();
                            PrepareInitialView();
                            BindOTScheduleList();

                            MiscUtil.ShowMessage(lblMessage, "O TSchedule has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete O TSchedule.", true);
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

        protected void odsOTSchedule_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveOTScheduleEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ScheduleID = 0;
            _OTScheduleEntity = new OTScheduleEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
