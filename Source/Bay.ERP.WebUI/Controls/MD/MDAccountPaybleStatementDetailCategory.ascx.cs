// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    public partial class MDAccountPaybleStatementDetailCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _AccountPaybleStatementDetailCategoryID
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

        public MDAccountPaybleStatementDetailCategoryEntity _MDAccountPaybleStatementDetailCategoryEntity
        {
            get
            {
                MDAccountPaybleStatementDetailCategoryEntity entity = new MDAccountPaybleStatementDetailCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAccountPaybleStatementDetailCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAccountPaybleStatementDetailCategoryEntity CurrentMDAccountPaybleStatementDetailCategoryEntity
        {
            get
            {
                if (_AccountPaybleStatementDetailCategoryID > 0)
                {
                    if (_MDAccountPaybleStatementDetailCategoryEntity.AccountPaybleStatementDetailCategoryID != _AccountPaybleStatementDetailCategoryID)
                    {
                        _MDAccountPaybleStatementDetailCategoryEntity = FCCMDAccountPaybleStatementDetailCategory.GetFacadeCreate().GetByID(_AccountPaybleStatementDetailCategoryID);
                    }
                }

                return _MDAccountPaybleStatementDetailCategoryEntity;
            }
            set
            {
                _MDAccountPaybleStatementDetailCategoryEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDAccountPaybleStatementDetailCategoryEntity mDAccountPaybleStatementDetailCategoryEntity = CurrentMDAccountPaybleStatementDetailCategoryEntity;


            if (!mDAccountPaybleStatementDetailCategoryEntity.IsNew)
            {
                txtName.Text = mDAccountPaybleStatementDetailCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = mDAccountPaybleStatementDetailCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAccountPaybleStatementDetailCategoryList();
        }

        private void BindMDAccountPaybleStatementDetailCategoryList()
        {
            lvMDAccountPaybleStatementDetailCategory.DataBind();
        }

        private MDAccountPaybleStatementDetailCategoryEntity BuildMDAccountPaybleStatementDetailCategoryEntity()
        {
            MDAccountPaybleStatementDetailCategoryEntity mDAccountPaybleStatementDetailCategoryEntity = CurrentMDAccountPaybleStatementDetailCategoryEntity;

            mDAccountPaybleStatementDetailCategoryEntity.Name = txtName.Text.Trim();
            mDAccountPaybleStatementDetailCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDAccountPaybleStatementDetailCategoryEntity;
        }

        private void SaveMDAccountPaybleStatementDetailCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAccountPaybleStatementDetailCategoryEntity mDAccountPaybleStatementDetailCategoryEntity = BuildMDAccountPaybleStatementDetailCategoryEntity();

                    Int64 result = -1;

                    if (mDAccountPaybleStatementDetailCategoryEntity.IsNew)
                    {
                        result = FCCMDAccountPaybleStatementDetailCategory.GetFacadeCreate().Add(mDAccountPaybleStatementDetailCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAccountPaybleStatementDetailCategoryEntity.FLD_NAME_AccountPaybleStatementDetailCategoryID, mDAccountPaybleStatementDetailCategoryEntity.AccountPaybleStatementDetailCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAccountPaybleStatementDetailCategory.GetFacadeCreate().Update(mDAccountPaybleStatementDetailCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AccountPaybleStatementDetailCategoryID = 0;
                        _MDAccountPaybleStatementDetailCategoryEntity = new MDAccountPaybleStatementDetailCategoryEntity();
                        PrepareInitialView();
                        BindMDAccountPaybleStatementDetailCategoryList();

                        if (mDAccountPaybleStatementDetailCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Account Payble Statement Detail Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Account Payble Statement Detail Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAccountPaybleStatementDetailCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Account Payble Statement Detail Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Account Payble Statement Detail Category Information.", false);
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

        protected void lvMDAccountPaybleStatementDetailCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AccountPaybleStatementDetailCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out AccountPaybleStatementDetailCategoryID);

            if (AccountPaybleStatementDetailCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AccountPaybleStatementDetailCategoryID = AccountPaybleStatementDetailCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAccountPaybleStatementDetailCategoryEntity.FLD_NAME_AccountPaybleStatementDetailCategoryID, AccountPaybleStatementDetailCategoryID.ToString(), SQLMatchType.Equal);

                        MDAccountPaybleStatementDetailCategoryEntity mDAccountPaybleStatementDetailCategoryEntity = new MDAccountPaybleStatementDetailCategoryEntity();


                        result = FCCMDAccountPaybleStatementDetailCategory.GetFacadeCreate().Delete(mDAccountPaybleStatementDetailCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AccountPaybleStatementDetailCategoryID = 0;
                            _MDAccountPaybleStatementDetailCategoryEntity = new MDAccountPaybleStatementDetailCategoryEntity();
                            PrepareInitialView();
                            BindMDAccountPaybleStatementDetailCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Account Payble Statement Detail Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Account Payble Statement Detail Category.", true);
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

        protected void odsMDAccountPaybleStatementDetailCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAccountPaybleStatementDetailCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AccountPaybleStatementDetailCategoryID = 0;
            _MDAccountPaybleStatementDetailCategoryEntity = new MDAccountPaybleStatementDetailCategoryEntity();
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
