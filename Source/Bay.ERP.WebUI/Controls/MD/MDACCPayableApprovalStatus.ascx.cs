// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




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
    public partial class MDACCPayableApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ACCPayableApprovalStatusID
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

        public MDACCPayableApprovalStatusEntity _MDACCPayableApprovalStatusEntity
        {
            get
            {
                MDACCPayableApprovalStatusEntity entity = new MDACCPayableApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDACCPayableApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDACCPayableApprovalStatusEntity CurrentMDACCPayableApprovalStatusEntity
        {
            get
            {
                if (_ACCPayableApprovalStatusID > 0)
                {
                    if (_MDACCPayableApprovalStatusEntity.ACCPayableApprovalStatusID != _ACCPayableApprovalStatusID)
                    {
                        _MDACCPayableApprovalStatusEntity = FCCMDACCPayableApprovalStatus.GetFacadeCreate().GetByID(_ACCPayableApprovalStatusID);
                    }
                }

                return _MDACCPayableApprovalStatusEntity;
            }
            set
            {
                _MDACCPayableApprovalStatusEntity = value;
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
            MDACCPayableApprovalStatusEntity mDACCPayableApprovalStatusEntity = CurrentMDACCPayableApprovalStatusEntity;


            if (!mDACCPayableApprovalStatusEntity.IsNew)
            {
                txtName.Text = mDACCPayableApprovalStatusEntity.Name.ToString();
                txtDescription.Text = mDACCPayableApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDACCPayableApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDACCPayableApprovalStatusList();
        }

        private void BindMDACCPayableApprovalStatusList()
        {
            lvMDACCPayableApprovalStatus.DataBind();
        }

        private MDACCPayableApprovalStatusEntity BuildMDACCPayableApprovalStatusEntity()
        {
            MDACCPayableApprovalStatusEntity mDACCPayableApprovalStatusEntity = CurrentMDACCPayableApprovalStatusEntity;

            mDACCPayableApprovalStatusEntity.Name = txtName.Text.Trim();
            mDACCPayableApprovalStatusEntity.Description = txtDescription.Text.Trim();
            mDACCPayableApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDACCPayableApprovalStatusEntity;
        }

        private void SaveMDACCPayableApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDACCPayableApprovalStatusEntity mDACCPayableApprovalStatusEntity = BuildMDACCPayableApprovalStatusEntity();

                    Int64 result = -1;

                    if (mDACCPayableApprovalStatusEntity.IsNew)
                    {
                        result = FCCMDACCPayableApprovalStatus.GetFacadeCreate().Add(mDACCPayableApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDACCPayableApprovalStatusEntity.FLD_NAME_ACCPayableApprovalStatusID, mDACCPayableApprovalStatusEntity.ACCPayableApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDACCPayableApprovalStatus.GetFacadeCreate().Update(mDACCPayableApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ACCPayableApprovalStatusID = 0;
                        _MDACCPayableApprovalStatusEntity = new MDACCPayableApprovalStatusEntity();
                        PrepareInitialView();
                        BindMDACCPayableApprovalStatusList();

                        if (mDACCPayableApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCPayable Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCPayable Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDACCPayableApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CCPayable Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CCPayable Approval Status Information.", false);
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

        protected void lvMDACCPayableApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ACCPayableApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ACCPayableApprovalStatusID);

            if (ACCPayableApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ACCPayableApprovalStatusID = ACCPayableApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDACCPayableApprovalStatusEntity.FLD_NAME_ACCPayableApprovalStatusID, ACCPayableApprovalStatusID.ToString(), SQLMatchType.Equal);

                        MDACCPayableApprovalStatusEntity mDACCPayableApprovalStatusEntity = new MDACCPayableApprovalStatusEntity();


                        result = FCCMDACCPayableApprovalStatus.GetFacadeCreate().Delete(mDACCPayableApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ACCPayableApprovalStatusID = 0;
                            _MDACCPayableApprovalStatusEntity = new MDACCPayableApprovalStatusEntity();
                            PrepareInitialView();
                            BindMDACCPayableApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "A CCPayable Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CCPayable Approval Status.", true);
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

        protected void odsMDACCPayableApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDACCPayableApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ACCPayableApprovalStatusID = 0;
            _MDACCPayableApprovalStatusEntity = new MDACCPayableApprovalStatusEntity();
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
