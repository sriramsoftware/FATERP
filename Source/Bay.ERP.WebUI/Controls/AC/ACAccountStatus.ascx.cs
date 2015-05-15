// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




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
    public partial class ACAccountStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _AccountStatusID
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

        public ACAccountStatusEntity _ACAccountStatusEntity
        {
            get
            {
                ACAccountStatusEntity entity = new ACAccountStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACAccountStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACAccountStatusEntity CurrentACAccountStatusEntity
        {
            get
            {
                if (_AccountStatusID > 0)
                {
                    if (_ACAccountStatusEntity.AccountStatusID != _AccountStatusID)
                    {
                        _ACAccountStatusEntity = FCCACAccountStatus.GetFacadeCreate().GetByID(_AccountStatusID);
                    }
                }

                return _ACAccountStatusEntity;
            }
            set
            {
                _ACAccountStatusEntity = value;
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
            ACAccountStatusEntity aCAccountStatusEntity = CurrentACAccountStatusEntity;


            if (!aCAccountStatusEntity.IsNew)
            {
                txtName.Text = aCAccountStatusEntity.Name.ToString();
                txtDescription.Text = aCAccountStatusEntity.Description.ToString();
                chkIsRemoved.Checked = aCAccountStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACAccountStatusList();
        }

        private void BindACAccountStatusList()
        {
            lvACAccountStatus.DataBind();
        }

        private ACAccountStatusEntity BuildACAccountStatusEntity()
        {
            ACAccountStatusEntity aCAccountStatusEntity = CurrentACAccountStatusEntity;

            aCAccountStatusEntity.Name = txtName.Text.Trim();
            aCAccountStatusEntity.Description = txtDescription.Text.Trim();
            aCAccountStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return aCAccountStatusEntity;
        }

        private void SaveACAccountStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACAccountStatusEntity aCAccountStatusEntity = BuildACAccountStatusEntity();

                    Int64 result = -1;

                    if (aCAccountStatusEntity.IsNew)
                    {
                        result = FCCACAccountStatus.GetFacadeCreate().Add(aCAccountStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACAccountStatusEntity.FLD_NAME_AccountStatusID, aCAccountStatusEntity.AccountStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCACAccountStatus.GetFacadeCreate().Update(aCAccountStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AccountStatusID = 0;
                        _ACAccountStatusEntity = new ACAccountStatusEntity();
                        PrepareInitialView();
                        BindACAccountStatusList();

                        if (aCAccountStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CAccount Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CAccount Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCAccountStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CAccount Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CAccount Status Information.", false);
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

        protected void lvACAccountStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AccountStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out AccountStatusID);

            if (AccountStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AccountStatusID = AccountStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACAccountStatusEntity.FLD_NAME_AccountStatusID, AccountStatusID.ToString(), SQLMatchType.Equal);

                        ACAccountStatusEntity aCAccountStatusEntity = new ACAccountStatusEntity();


                        result = FCCACAccountStatus.GetFacadeCreate().Delete(aCAccountStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AccountStatusID = 0;
                            _ACAccountStatusEntity = new ACAccountStatusEntity();
                            PrepareInitialView();
                            BindACAccountStatusList();

                            MiscUtil.ShowMessage(lblMessage, "A CAccount Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CAccount Status.", true);
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

        protected void odsACAccountStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACAccountStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AccountStatusID = 0;
            _ACAccountStatusEntity = new ACAccountStatusEntity();
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
