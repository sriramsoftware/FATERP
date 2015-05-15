// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDLeaveApplicationApplicationStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _LeaveApplicationApplicationStatusID
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

        public MDLeaveApplicationApplicationStatusEntity _MDLeaveApplicationApplicationStatusEntity
        {
            get
            {
                MDLeaveApplicationApplicationStatusEntity entity = new MDLeaveApplicationApplicationStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDLeaveApplicationApplicationStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDLeaveApplicationApplicationStatusEntity CurrentMDLeaveApplicationApplicationStatusEntity
        {
            get
            {
                if (_LeaveApplicationApplicationStatusID > 0)
                {
                    if (_MDLeaveApplicationApplicationStatusEntity.LeaveApplicationApplicationStatusID != _LeaveApplicationApplicationStatusID)
                    {
                        _MDLeaveApplicationApplicationStatusEntity = FCCMDLeaveApplicationApplicationStatus.GetFacadeCreate().GetByID(_LeaveApplicationApplicationStatusID);
                    }
                }

                return _MDLeaveApplicationApplicationStatusEntity;
            }
            set
            {
                _MDLeaveApplicationApplicationStatusEntity = value;
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
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity = CurrentMDLeaveApplicationApplicationStatusEntity;


            if (!mDLeaveApplicationApplicationStatusEntity.IsNew)
            {
                txtName.Text = mDLeaveApplicationApplicationStatusEntity.Name.ToString();
                txtDescription.Text = mDLeaveApplicationApplicationStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDLeaveApplicationApplicationStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDLeaveApplicationApplicationStatusList();
        }

        private void BindMDLeaveApplicationApplicationStatusList()
        {
            lvMDLeaveApplicationApplicationStatus.DataBind();
        }

        private MDLeaveApplicationApplicationStatusEntity BuildMDLeaveApplicationApplicationStatusEntity()
        {
            MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity = CurrentMDLeaveApplicationApplicationStatusEntity;

            mDLeaveApplicationApplicationStatusEntity.Name = txtName.Text.Trim();
            mDLeaveApplicationApplicationStatusEntity.Description = txtDescription.Text.Trim();
            mDLeaveApplicationApplicationStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDLeaveApplicationApplicationStatusEntity;
        }

        private void SaveMDLeaveApplicationApplicationStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity = BuildMDLeaveApplicationApplicationStatusEntity();

                    Int64 result = -1;

                    if (mDLeaveApplicationApplicationStatusEntity.IsNew)
                    {
                        result = FCCMDLeaveApplicationApplicationStatus.GetFacadeCreate().Add(mDLeaveApplicationApplicationStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDLeaveApplicationApplicationStatusEntity.FLD_NAME_LeaveApplicationApplicationStatusID, mDLeaveApplicationApplicationStatusEntity.LeaveApplicationApplicationStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDLeaveApplicationApplicationStatus.GetFacadeCreate().Update(mDLeaveApplicationApplicationStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _LeaveApplicationApplicationStatusID = 0;
                        _MDLeaveApplicationApplicationStatusEntity = new MDLeaveApplicationApplicationStatusEntity();
                        PrepareInitialView();
                        BindMDLeaveApplicationApplicationStatusList();

                        if (mDLeaveApplicationApplicationStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Leave Application Application Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Leave Application Application Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDLeaveApplicationApplicationStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Leave Application Application Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Leave Application Application Status Information.", false);
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

        protected void lvMDLeaveApplicationApplicationStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 LeaveApplicationApplicationStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out LeaveApplicationApplicationStatusID);

            if (LeaveApplicationApplicationStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _LeaveApplicationApplicationStatusID = LeaveApplicationApplicationStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDLeaveApplicationApplicationStatusEntity.FLD_NAME_LeaveApplicationApplicationStatusID, LeaveApplicationApplicationStatusID.ToString(), SQLMatchType.Equal);

                        MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity = new MDLeaveApplicationApplicationStatusEntity();


                        result = FCCMDLeaveApplicationApplicationStatus.GetFacadeCreate().Delete(mDLeaveApplicationApplicationStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _LeaveApplicationApplicationStatusID = 0;
                            _MDLeaveApplicationApplicationStatusEntity = new MDLeaveApplicationApplicationStatusEntity();
                            PrepareInitialView();
                            BindMDLeaveApplicationApplicationStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Leave Application Application Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Leave Application Application Status.", true);
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

        protected void odsMDLeaveApplicationApplicationStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDLeaveApplicationApplicationStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LeaveApplicationApplicationStatusID = 0;
            _MDLeaveApplicationApplicationStatusEntity = new MDLeaveApplicationApplicationStatusEntity();
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
