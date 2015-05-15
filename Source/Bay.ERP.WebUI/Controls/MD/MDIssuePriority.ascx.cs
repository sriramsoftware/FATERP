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
    public partial class MDIssuePriorityControl : BaseControl
    {       
        #region Properties

        public Int64 _IssuePriorityID
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

        public MDIssuePriorityEntity _MDIssuePriorityEntity
        {
            get
            {
                MDIssuePriorityEntity entity = new MDIssuePriorityEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDIssuePriorityEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDIssuePriorityEntity CurrentMDIssuePriorityEntity
        {
            get
            {
                if (_IssuePriorityID > 0)
                {
                    if (_MDIssuePriorityEntity.IssuePriorityID != _IssuePriorityID)
                    {
                        _MDIssuePriorityEntity = FCCMDIssuePriority.GetFacadeCreate().GetByID(_IssuePriorityID);
                    }
                }

                return _MDIssuePriorityEntity;
            }
            set
            {
                _MDIssuePriorityEntity = value;
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
            MDIssuePriorityEntity mDIssuePriorityEntity = CurrentMDIssuePriorityEntity;


            if (!mDIssuePriorityEntity.IsNew)
            {
                txtName.Text = mDIssuePriorityEntity.Name.ToString();
                txtDescription.Text = mDIssuePriorityEntity.Description.ToString();
                chkIsRemoved.Checked = mDIssuePriorityEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDIssuePriorityList();
        }

        private void BindMDIssuePriorityList()
        {
            lvMDIssuePriority.DataBind();
        }

        private MDIssuePriorityEntity BuildMDIssuePriorityEntity()
        {
            MDIssuePriorityEntity mDIssuePriorityEntity = CurrentMDIssuePriorityEntity;

            mDIssuePriorityEntity.Name = txtName.Text.Trim();
            mDIssuePriorityEntity.Description = txtDescription.Text.Trim();
            mDIssuePriorityEntity.IsRemoved = chkIsRemoved.Checked;


            return mDIssuePriorityEntity;
        }

        private void SaveMDIssuePriorityEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDIssuePriorityEntity mDIssuePriorityEntity = BuildMDIssuePriorityEntity();

                    Int64 result = -1;

                    if (mDIssuePriorityEntity.IsNew)
                    {
                        result = FCCMDIssuePriority.GetFacadeCreate().Add(mDIssuePriorityEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDIssuePriorityEntity.FLD_NAME_IssuePriorityID, mDIssuePriorityEntity.IssuePriorityID.ToString(), SQLMatchType.Equal);
                        result = FCCMDIssuePriority.GetFacadeCreate().Update(mDIssuePriorityEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _IssuePriorityID = 0;
                        _MDIssuePriorityEntity = new MDIssuePriorityEntity();
                        PrepareInitialView();
                        BindMDIssuePriorityList();

                        if (mDIssuePriorityEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Priority Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Issue Priority Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDIssuePriorityEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Issue Priority Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Issue Priority Information.", false);
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

        protected void lvMDIssuePriority_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 IssuePriorityID;

            Int64.TryParse(e.CommandArgument.ToString(), out IssuePriorityID);

            if (IssuePriorityID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _IssuePriorityID = IssuePriorityID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDIssuePriorityEntity.FLD_NAME_IssuePriorityID, IssuePriorityID.ToString(), SQLMatchType.Equal);

                        MDIssuePriorityEntity mDIssuePriorityEntity = new MDIssuePriorityEntity();


                        result = FCCMDIssuePriority.GetFacadeCreate().Delete(mDIssuePriorityEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _IssuePriorityID = 0;
                            _MDIssuePriorityEntity = new MDIssuePriorityEntity();
                            PrepareInitialView();
                            BindMDIssuePriorityList();

                            MiscUtil.ShowMessage(lblMessage, "Issue Priority has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Issue Priority.", true);
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

        protected void odsMDIssuePriority_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDIssuePriorityEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _IssuePriorityID = 0;
            _MDIssuePriorityEntity = new MDIssuePriorityEntity();
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
