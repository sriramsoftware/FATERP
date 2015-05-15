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
    public partial class MDSchedulePriorityControl : BaseControl
    {       
        #region Properties

        public Int64 _SchedulePriorityID
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

        public MDSchedulePriorityEntity _MDSchedulePriorityEntity
        {
            get
            {
                MDSchedulePriorityEntity entity = new MDSchedulePriorityEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSchedulePriorityEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSchedulePriorityEntity CurrentMDSchedulePriorityEntity
        {
            get
            {
                if (_SchedulePriorityID > 0)
                {
                    if (_MDSchedulePriorityEntity.SchedulePriorityID != _SchedulePriorityID)
                    {
                        _MDSchedulePriorityEntity = FCCMDSchedulePriority.GetFacadeCreate().GetByID(_SchedulePriorityID);
                    }
                }

                return _MDSchedulePriorityEntity;
            }
            set
            {
                _MDSchedulePriorityEntity = value;
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
            MDSchedulePriorityEntity mDSchedulePriorityEntity = CurrentMDSchedulePriorityEntity;


            if (!mDSchedulePriorityEntity.IsNew)
            {
                txtName.Text = mDSchedulePriorityEntity.Name.ToString();
                txtDescription.Text = mDSchedulePriorityEntity.Description.ToString();
                chkIsRemoved.Checked = mDSchedulePriorityEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSchedulePriorityList();
        }

        private void BindMDSchedulePriorityList()
        {
            lvMDSchedulePriority.DataBind();
        }

        private MDSchedulePriorityEntity BuildMDSchedulePriorityEntity()
        {
            MDSchedulePriorityEntity mDSchedulePriorityEntity = CurrentMDSchedulePriorityEntity;

            mDSchedulePriorityEntity.Name = txtName.Text.Trim();
            mDSchedulePriorityEntity.Description = txtDescription.Text.Trim();
            mDSchedulePriorityEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSchedulePriorityEntity;
        }

        private void SaveMDSchedulePriorityEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSchedulePriorityEntity mDSchedulePriorityEntity = BuildMDSchedulePriorityEntity();

                    Int64 result = -1;

                    if (mDSchedulePriorityEntity.IsNew)
                    {
                        result = FCCMDSchedulePriority.GetFacadeCreate().Add(mDSchedulePriorityEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSchedulePriorityEntity.FLD_NAME_SchedulePriorityID, mDSchedulePriorityEntity.SchedulePriorityID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSchedulePriority.GetFacadeCreate().Update(mDSchedulePriorityEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SchedulePriorityID = 0;
                        _MDSchedulePriorityEntity = new MDSchedulePriorityEntity();
                        PrepareInitialView();
                        BindMDSchedulePriorityList();

                        if (mDSchedulePriorityEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Schedule Priority Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Schedule Priority Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSchedulePriorityEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Schedule Priority Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Schedule Priority Information.", false);
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

        protected void lvMDSchedulePriority_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SchedulePriorityID;

            Int64.TryParse(e.CommandArgument.ToString(), out SchedulePriorityID);

            if (SchedulePriorityID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SchedulePriorityID = SchedulePriorityID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSchedulePriorityEntity.FLD_NAME_SchedulePriorityID, SchedulePriorityID.ToString(), SQLMatchType.Equal);

                        MDSchedulePriorityEntity mDSchedulePriorityEntity = new MDSchedulePriorityEntity();


                        result = FCCMDSchedulePriority.GetFacadeCreate().Delete(mDSchedulePriorityEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SchedulePriorityID = 0;
                            _MDSchedulePriorityEntity = new MDSchedulePriorityEntity();
                            PrepareInitialView();
                            BindMDSchedulePriorityList();

                            MiscUtil.ShowMessage(lblMessage, "Schedule Priority has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Schedule Priority.", true);
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

        protected void odsMDSchedulePriority_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSchedulePriorityEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SchedulePriorityID = 0;
            _MDSchedulePriorityEntity = new MDSchedulePriorityEntity();
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
