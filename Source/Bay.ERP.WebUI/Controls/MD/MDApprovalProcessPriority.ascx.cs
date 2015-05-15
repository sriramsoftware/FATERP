// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




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
    public partial class MDApprovalProcessPriorityControl : BaseControl
    {       
        #region Properties

        public Int64 _ApprovalProcessPriorityID
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

        public MDApprovalProcessPriorityEntity _MDApprovalProcessPriorityEntity
        {
            get
            {
                MDApprovalProcessPriorityEntity entity = new MDApprovalProcessPriorityEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDApprovalProcessPriorityEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDApprovalProcessPriorityEntity CurrentMDApprovalProcessPriorityEntity
        {
            get
            {
                if (_ApprovalProcessPriorityID > 0)
                {
                    if (_MDApprovalProcessPriorityEntity.ApprovalProcessPriorityID != _ApprovalProcessPriorityID)
                    {
                        _MDApprovalProcessPriorityEntity = FCCMDApprovalProcessPriority.GetFacadeCreate().GetByID(_ApprovalProcessPriorityID);
                    }
                }

                return _MDApprovalProcessPriorityEntity;
            }
            set
            {
                _MDApprovalProcessPriorityEntity = value;
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
            txtResponseTime.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDApprovalProcessPriorityEntity mDApprovalProcessPriorityEntity = CurrentMDApprovalProcessPriorityEntity;


            if (!mDApprovalProcessPriorityEntity.IsNew)
            {
                txtName.Text = mDApprovalProcessPriorityEntity.Name.ToString();
                txtResponseTime.Text = mDApprovalProcessPriorityEntity.ResponseTime.ToString();
                chkIsRemoved.Checked = mDApprovalProcessPriorityEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDApprovalProcessPriorityList();
        }

        private void BindMDApprovalProcessPriorityList()
        {
            lvMDApprovalProcessPriority.DataBind();
        }

        private MDApprovalProcessPriorityEntity BuildMDApprovalProcessPriorityEntity()
        {
            MDApprovalProcessPriorityEntity mDApprovalProcessPriorityEntity = CurrentMDApprovalProcessPriorityEntity;

            mDApprovalProcessPriorityEntity.Name = txtName.Text.Trim();
            if (!txtResponseTime.Text.Trim().IsNullOrEmpty())
            {
                mDApprovalProcessPriorityEntity.ResponseTime = Int32.Parse(txtResponseTime.Text.Trim());
            }

            mDApprovalProcessPriorityEntity.IsRemoved = chkIsRemoved.Checked;


            return mDApprovalProcessPriorityEntity;
        }

        private void SaveMDApprovalProcessPriorityEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDApprovalProcessPriorityEntity mDApprovalProcessPriorityEntity = BuildMDApprovalProcessPriorityEntity();

                    Int64 result = -1;

                    if (mDApprovalProcessPriorityEntity.IsNew)
                    {
                        result = FCCMDApprovalProcessPriority.GetFacadeCreate().Add(mDApprovalProcessPriorityEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalProcessPriorityEntity.FLD_NAME_ApprovalProcessPriorityID, mDApprovalProcessPriorityEntity.ApprovalProcessPriorityID.ToString(), SQLMatchType.Equal);
                        result = FCCMDApprovalProcessPriority.GetFacadeCreate().Update(mDApprovalProcessPriorityEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ApprovalProcessPriorityID = 0;
                        _MDApprovalProcessPriorityEntity = new MDApprovalProcessPriorityEntity();
                        PrepareInitialView();
                        BindMDApprovalProcessPriorityList();

                        if (mDApprovalProcessPriorityEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Priority Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process Priority Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDApprovalProcessPriorityEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Approval Process Priority Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Approval Process Priority Information.", false);
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

        protected void lvMDApprovalProcessPriority_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ApprovalProcessPriorityID;

            Int64.TryParse(e.CommandArgument.ToString(), out ApprovalProcessPriorityID);

            if (ApprovalProcessPriorityID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ApprovalProcessPriorityID = ApprovalProcessPriorityID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalProcessPriorityEntity.FLD_NAME_ApprovalProcessPriorityID, ApprovalProcessPriorityID.ToString(), SQLMatchType.Equal);

                        MDApprovalProcessPriorityEntity mDApprovalProcessPriorityEntity = new MDApprovalProcessPriorityEntity();


                        result = FCCMDApprovalProcessPriority.GetFacadeCreate().Delete(mDApprovalProcessPriorityEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ApprovalProcessPriorityID = 0;
                            _MDApprovalProcessPriorityEntity = new MDApprovalProcessPriorityEntity();
                            PrepareInitialView();
                            BindMDApprovalProcessPriorityList();

                            MiscUtil.ShowMessage(lblMessage, "Approval Process Priority has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Approval Process Priority.", true);
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

        protected void odsMDApprovalProcessPriority_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDApprovalProcessPriorityEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ApprovalProcessPriorityID = 0;
            _MDApprovalProcessPriorityEntity = new MDApprovalProcessPriorityEntity();
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
