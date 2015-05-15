// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 04:41:21




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
    public partial class ACAccountGroupControl : BaseControl
    {   
        #region Properties

        public Int64 _AccountGroupID
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

        public ACAccountGroupEntity _ACAccountGroupEntity
        {
            get
            {
                ACAccountGroupEntity entity = new ACAccountGroupEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACAccountGroupEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACAccountGroupEntity CurrentACAccountGroupEntity
        {
            get
            {
                if (_AccountGroupID > 0)
                {
                    if (_ACAccountGroupEntity.AccountGroupID != _AccountGroupID)
                    {
                        _ACAccountGroupEntity = FCCACAccountGroup.GetFacadeCreate().GetByID(_AccountGroupID);
                    }
                }

                return _ACAccountGroupEntity;
            }
            set
            {
                _ACAccountGroupEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACAccountGroup(ddlParentAccountGroupID, true);
            MiscUtil.PopulateACClass(ddlClassID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtAccountGroupCode.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsInActive.Checked = false;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACAccountGroupEntity aCAccountGroupEntity = CurrentACAccountGroupEntity;


            if (!aCAccountGroupEntity.IsNew)
            {
                if (ddlParentAccountGroupID.Items.Count > 0 && aCAccountGroupEntity.ParentAccountGroupID != null)
                {
                    ddlParentAccountGroupID.SelectedValue = aCAccountGroupEntity.ParentAccountGroupID.ToString();
                }

                if (ddlClassID.Items.Count > 0 && aCAccountGroupEntity.ClassID != null)
                {
                    ddlClassID.SelectedValue = aCAccountGroupEntity.ClassID.ToString();
                }

                txtAccountGroupCode.Text = aCAccountGroupEntity.AccountGroupCode.ToString();
                txtName.Text = aCAccountGroupEntity.Name.ToString();
                txtDescription.Text = aCAccountGroupEntity.Description.ToString();
                chkIsInActive.Checked = aCAccountGroupEntity.IsInActive;
                chkIsRemoved.Checked = aCAccountGroupEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACAccountGroupList();
        }

        private void BindACAccountGroupList()
        {
            lvACAccountGroup.DataBind();
        }

        private ACAccountGroupEntity BuildACAccountGroupEntity()
        {
            ACAccountGroupEntity aCAccountGroupEntity = CurrentACAccountGroupEntity;

            if (ddlParentAccountGroupID.Items.Count > 0)
            {
                if (ddlParentAccountGroupID.SelectedValue == "0")
                {
                    aCAccountGroupEntity.ParentAccountGroupID = null;
                }
                else
                {
                    aCAccountGroupEntity.ParentAccountGroupID = Int64.Parse(ddlParentAccountGroupID.SelectedValue);
                }
            }

            if (ddlClassID.Items.Count > 0)
            {
                if (ddlClassID.SelectedValue == "0")
                {
                }
                else
                {
                    aCAccountGroupEntity.ClassID = Int64.Parse(ddlClassID.SelectedValue);
                }
            }

            aCAccountGroupEntity.AccountGroupCode = txtAccountGroupCode.Text.Trim();
            aCAccountGroupEntity.Name = txtName.Text.Trim();
            aCAccountGroupEntity.Description = txtDescription.Text.Trim();
            aCAccountGroupEntity.IsInActive = chkIsInActive.Checked;

            aCAccountGroupEntity.IsRemoved = chkIsRemoved.Checked;


            return aCAccountGroupEntity;
        }

        private void SaveACAccountGroupEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACAccountGroupEntity aCAccountGroupEntity = BuildACAccountGroupEntity();

                    Int64 result = -1;

                    if (aCAccountGroupEntity.IsNew)
                    {
                        result = FCCACAccountGroup.GetFacadeCreate().Add(aCAccountGroupEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACAccountGroupEntity.FLD_NAME_AccountGroupID, aCAccountGroupEntity.AccountGroupID.ToString(), SQLMatchType.Equal);
                        result = FCCACAccountGroup.GetFacadeCreate().Update(aCAccountGroupEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AccountGroupID = 0;
                        _ACAccountGroupEntity = new ACAccountGroupEntity();
                        PrepareInitialView();
                        BindACAccountGroupList();

                        if (aCAccountGroupEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CAccount Group Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CAccount Group Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCAccountGroupEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CAccount Group Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CAccount Group Information.", false);
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

        protected void lvACAccountGroup_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AccountGroupID;

            Int64.TryParse(e.CommandArgument.ToString(), out AccountGroupID);

            if (AccountGroupID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AccountGroupID = AccountGroupID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACAccountGroupEntity.FLD_NAME_AccountGroupID, AccountGroupID.ToString(), SQLMatchType.Equal);

                        ACAccountGroupEntity aCAccountGroupEntity = new ACAccountGroupEntity();


                        result = FCCACAccountGroup.GetFacadeCreate().Delete(aCAccountGroupEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AccountGroupID = 0;
                            _ACAccountGroupEntity = new ACAccountGroupEntity();
                            PrepareInitialView();
                            BindACAccountGroupList();

                            MiscUtil.ShowMessage(lblMessage, "A CAccount Group has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CAccount Group.", true);
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

        protected void odsACAccountGroup_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACAccountGroupEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AccountGroupID = 0;
            _ACAccountGroupEntity = new ACAccountGroupEntity();
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
