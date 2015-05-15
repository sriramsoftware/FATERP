// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




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
    public partial class MDEventInvitatedPersonTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _EventInvitatedPersonTypeID
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

        public MDEventInvitatedPersonTypeEntity _MDEventInvitatedPersonTypeEntity
        {
            get
            {
                MDEventInvitatedPersonTypeEntity entity = new MDEventInvitatedPersonTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEventInvitatedPersonTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEventInvitatedPersonTypeEntity CurrentMDEventInvitatedPersonTypeEntity
        {
            get
            {
                if (_EventInvitatedPersonTypeID > 0)
                {
                    if (_MDEventInvitatedPersonTypeEntity.EventInvitatedPersonTypeID != _EventInvitatedPersonTypeID)
                    {
                        _MDEventInvitatedPersonTypeEntity = FCCMDEventInvitatedPersonType.GetFacadeCreate().GetByID(_EventInvitatedPersonTypeID);
                    }
                }

                return _MDEventInvitatedPersonTypeEntity;
            }
            set
            {
                _MDEventInvitatedPersonTypeEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity = CurrentMDEventInvitatedPersonTypeEntity;


            if (!mDEventInvitatedPersonTypeEntity.IsNew)
            {
                txtName.Text = mDEventInvitatedPersonTypeEntity.Name.ToString();
                txtRemarks.Text = mDEventInvitatedPersonTypeEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDEventInvitatedPersonTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEventInvitatedPersonTypeList();
        }

        private void BindMDEventInvitatedPersonTypeList()
        {
            lvMDEventInvitatedPersonType.DataBind();
        }

        private MDEventInvitatedPersonTypeEntity BuildMDEventInvitatedPersonTypeEntity()
        {
            MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity = CurrentMDEventInvitatedPersonTypeEntity;

            mDEventInvitatedPersonTypeEntity.Name = txtName.Text.Trim();
            mDEventInvitatedPersonTypeEntity.Remarks = txtRemarks.Text.Trim();
            mDEventInvitatedPersonTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEventInvitatedPersonTypeEntity;
        }

        private void SaveMDEventInvitatedPersonTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity = BuildMDEventInvitatedPersonTypeEntity();

                    Int64 result = -1;

                    if (mDEventInvitatedPersonTypeEntity.IsNew)
                    {
                        result = FCCMDEventInvitatedPersonType.GetFacadeCreate().Add(mDEventInvitatedPersonTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEventInvitatedPersonTypeEntity.FLD_NAME_EventInvitatedPersonTypeID, mDEventInvitatedPersonTypeEntity.EventInvitatedPersonTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEventInvitatedPersonType.GetFacadeCreate().Update(mDEventInvitatedPersonTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EventInvitatedPersonTypeID = 0;
                        _MDEventInvitatedPersonTypeEntity = new MDEventInvitatedPersonTypeEntity();
                        PrepareInitialView();
                        BindMDEventInvitatedPersonTypeList();

                        if (mDEventInvitatedPersonTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Invitated Person Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Event Invitated Person Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEventInvitatedPersonTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Event Invitated Person Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Event Invitated Person Type Information.", false);
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

        protected void lvMDEventInvitatedPersonType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EventInvitatedPersonTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EventInvitatedPersonTypeID);

            if (EventInvitatedPersonTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EventInvitatedPersonTypeID = EventInvitatedPersonTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEventInvitatedPersonTypeEntity.FLD_NAME_EventInvitatedPersonTypeID, EventInvitatedPersonTypeID.ToString(), SQLMatchType.Equal);

                        MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity = new MDEventInvitatedPersonTypeEntity();


                        result = FCCMDEventInvitatedPersonType.GetFacadeCreate().Delete(mDEventInvitatedPersonTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EventInvitatedPersonTypeID = 0;
                            _MDEventInvitatedPersonTypeEntity = new MDEventInvitatedPersonTypeEntity();
                            PrepareInitialView();
                            BindMDEventInvitatedPersonTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Event Invitated Person Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Event Invitated Person Type.", true);
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

        protected void odsMDEventInvitatedPersonType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEventInvitatedPersonTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EventInvitatedPersonTypeID = 0;
            _MDEventInvitatedPersonTypeEntity = new MDEventInvitatedPersonTypeEntity();
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
