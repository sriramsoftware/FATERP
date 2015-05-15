// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 11:30:08




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
    public partial class MDAllowanceCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _AllowanceCategoryID
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

        public MDAllowanceCategoryEntity _MDAllowanceCategoryEntity
        {
            get
            {
                MDAllowanceCategoryEntity entity = new MDAllowanceCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAllowanceCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAllowanceCategoryEntity CurrentMDAllowanceCategoryEntity
        {
            get
            {
                if (_AllowanceCategoryID > 0)
                {
                    if (_MDAllowanceCategoryEntity.AllowanceCategoryID != _AllowanceCategoryID)
                    {
                        _MDAllowanceCategoryEntity = FCCMDAllowanceCategory.GetFacadeCreate().GetByID(_AllowanceCategoryID);
                    }
                }

                return _MDAllowanceCategoryEntity;
            }
            set
            {
                _MDAllowanceCategoryEntity = value;
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
            MDAllowanceCategoryEntity mDAllowanceCategoryEntity = CurrentMDAllowanceCategoryEntity;


            if (!mDAllowanceCategoryEntity.IsNew)
            {
                txtName.Text = mDAllowanceCategoryEntity.Name.ToString();
                txtDescription.Text = mDAllowanceCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDAllowanceCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAllowanceCategoryList();
        }

        private void BindMDAllowanceCategoryList()
        {
            lvMDAllowanceCategory.DataBind();
        }

        private MDAllowanceCategoryEntity BuildMDAllowanceCategoryEntity()
        {
            MDAllowanceCategoryEntity mDAllowanceCategoryEntity = CurrentMDAllowanceCategoryEntity;

            mDAllowanceCategoryEntity.Name = txtName.Text.Trim();
            mDAllowanceCategoryEntity.Description = txtDescription.Text.Trim();
            mDAllowanceCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDAllowanceCategoryEntity;
        }

        private void SaveMDAllowanceCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAllowanceCategoryEntity mDAllowanceCategoryEntity = BuildMDAllowanceCategoryEntity();

                    Int64 result = -1;

                    if (mDAllowanceCategoryEntity.IsNew)
                    {
                        result = FCCMDAllowanceCategory.GetFacadeCreate().Add(mDAllowanceCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAllowanceCategoryEntity.FLD_NAME_AllowanceCategoryID, mDAllowanceCategoryEntity.AllowanceCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAllowanceCategory.GetFacadeCreate().Update(mDAllowanceCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AllowanceCategoryID = 0;
                        _MDAllowanceCategoryEntity = new MDAllowanceCategoryEntity();
                        PrepareInitialView();
                        BindMDAllowanceCategoryList();

                        if (mDAllowanceCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Allowance Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Allowance Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAllowanceCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Allowance Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Allowance Category Information.", false);
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

        protected void lvMDAllowanceCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AllowanceCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out AllowanceCategoryID);

            if (AllowanceCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AllowanceCategoryID = AllowanceCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAllowanceCategoryEntity.FLD_NAME_AllowanceCategoryID, AllowanceCategoryID.ToString(), SQLMatchType.Equal);

                        MDAllowanceCategoryEntity mDAllowanceCategoryEntity = new MDAllowanceCategoryEntity();


                        result = FCCMDAllowanceCategory.GetFacadeCreate().Delete(mDAllowanceCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AllowanceCategoryID = 0;
                            _MDAllowanceCategoryEntity = new MDAllowanceCategoryEntity();
                            PrepareInitialView();
                            BindMDAllowanceCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Allowance Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Allowance Category.", true);
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

        protected void odsMDAllowanceCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAllowanceCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AllowanceCategoryID = 0;
            _MDAllowanceCategoryEntity = new MDAllowanceCategoryEntity();
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
