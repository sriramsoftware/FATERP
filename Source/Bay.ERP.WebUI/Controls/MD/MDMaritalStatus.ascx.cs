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
    public partial class MDMaritalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _MaritalStatusID
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

        public MDMaritalStatusEntity _MDMaritalStatusEntity
        {
            get
            {
                MDMaritalStatusEntity entity = new MDMaritalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDMaritalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDMaritalStatusEntity CurrentMDMaritalStatusEntity
        {
            get
            {
                if (_MaritalStatusID > 0)
                {
                    if (_MDMaritalStatusEntity.MaritalStatusID != _MaritalStatusID)
                    {
                        _MDMaritalStatusEntity = FCCMDMaritalStatus.GetFacadeCreate().GetByID(_MaritalStatusID);
                    }
                }

                return _MDMaritalStatusEntity;
            }
            set
            {
                _MDMaritalStatusEntity = value;
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
            MDMaritalStatusEntity mDMaritalStatusEntity = CurrentMDMaritalStatusEntity;


            if (!mDMaritalStatusEntity.IsNew)
            {
                txtName.Text = mDMaritalStatusEntity.Name.ToString();
                txtRemarks.Text = mDMaritalStatusEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDMaritalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDMaritalStatusList();
        }

        private void BindMDMaritalStatusList()
        {
            lvMDMaritalStatus.DataBind();
        }

        private MDMaritalStatusEntity BuildMDMaritalStatusEntity()
        {
            MDMaritalStatusEntity mDMaritalStatusEntity = CurrentMDMaritalStatusEntity;

            mDMaritalStatusEntity.Name = txtName.Text.Trim();
            mDMaritalStatusEntity.Remarks = txtRemarks.Text.Trim();
            mDMaritalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDMaritalStatusEntity;
        }

        private void SaveMDMaritalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDMaritalStatusEntity mDMaritalStatusEntity = BuildMDMaritalStatusEntity();

                    Int64 result = -1;

                    if (mDMaritalStatusEntity.IsNew)
                    {
                        result = FCCMDMaritalStatus.GetFacadeCreate().Add(mDMaritalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDMaritalStatusEntity.FLD_NAME_MaritalStatusID, mDMaritalStatusEntity.MaritalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDMaritalStatus.GetFacadeCreate().Update(mDMaritalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MaritalStatusID = 0;
                        _MDMaritalStatusEntity = new MDMaritalStatusEntity();
                        PrepareInitialView();
                        BindMDMaritalStatusList();

                        if (mDMaritalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Marital Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Marital Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDMaritalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Marital Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Marital Status Information.", false);
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

        protected void lvMDMaritalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MaritalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out MaritalStatusID);

            if (MaritalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MaritalStatusID = MaritalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDMaritalStatusEntity.FLD_NAME_MaritalStatusID, MaritalStatusID.ToString(), SQLMatchType.Equal);

                        MDMaritalStatusEntity mDMaritalStatusEntity = new MDMaritalStatusEntity();


                        result = FCCMDMaritalStatus.GetFacadeCreate().Delete(mDMaritalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MaritalStatusID = 0;
                            _MDMaritalStatusEntity = new MDMaritalStatusEntity();
                            PrepareInitialView();
                            BindMDMaritalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Marital Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Marital Status.", true);
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

        protected void odsMDMaritalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDMaritalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MaritalStatusID = 0;
            _MDMaritalStatusEntity = new MDMaritalStatusEntity();
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
