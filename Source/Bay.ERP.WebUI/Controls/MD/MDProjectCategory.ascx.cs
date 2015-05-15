// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    public partial class MDProjectCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectCategoryID
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

        public MDProjectCategoryEntity _MDProjectCategoryEntity
        {
            get
            {
                MDProjectCategoryEntity entity = new MDProjectCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectCategoryEntity CurrentMDProjectCategoryEntity
        {
            get
            {
                if (_ProjectCategoryID > 0)
                {
                    if (_MDProjectCategoryEntity.ProjectCategoryID != _ProjectCategoryID)
                    {
                        _MDProjectCategoryEntity = FCCMDProjectCategory.GetFacadeCreate().GetByID(_ProjectCategoryID);
                    }
                }

                return _MDProjectCategoryEntity;
            }
            set
            {
                _MDProjectCategoryEntity = value;
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
            MDProjectCategoryEntity mDProjectCategoryEntity = CurrentMDProjectCategoryEntity;


            if (!mDProjectCategoryEntity.IsNew)
            {
                txtName.Text = mDProjectCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = mDProjectCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDProjectCategoryList();
        }

        private void BindMDProjectCategoryList()
        {
            lvMDProjectCategory.DataBind();
        }

        private MDProjectCategoryEntity BuildMDProjectCategoryEntity()
        {
            MDProjectCategoryEntity mDProjectCategoryEntity = CurrentMDProjectCategoryEntity;

            mDProjectCategoryEntity.Name = txtName.Text.Trim();
            mDProjectCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectCategoryEntity;
        }

        private void SaveMDProjectCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectCategoryEntity mDProjectCategoryEntity = BuildMDProjectCategoryEntity();

                    Int64 result = -1;

                    if (mDProjectCategoryEntity.IsNew)
                    {
                        result = FCCMDProjectCategory.GetFacadeCreate().Add(mDProjectCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectCategoryEntity.FLD_NAME_ProjectCategoryID, mDProjectCategoryEntity.ProjectCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectCategory.GetFacadeCreate().Update(mDProjectCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectCategoryID = 0;
                        _MDProjectCategoryEntity = new MDProjectCategoryEntity();
                        PrepareInitialView();
                        BindMDProjectCategoryList();

                        if (mDProjectCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDProjectCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Category Information.", false);
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

        protected void lvMDProjectCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectCategoryID);

            if (ProjectCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectCategoryID = ProjectCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectCategoryEntity.FLD_NAME_ProjectCategoryID, ProjectCategoryID.ToString(), SQLMatchType.Equal);

                        MDProjectCategoryEntity mDProjectCategoryEntity = new MDProjectCategoryEntity();


                        result = FCCMDProjectCategory.GetFacadeCreate().Delete(mDProjectCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectCategoryID = 0;
                            _MDProjectCategoryEntity = new MDProjectCategoryEntity();
                            PrepareInitialView();
                            BindMDProjectCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Project Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Category.", true);
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

        protected void odsMDProjectCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDProjectCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectCategoryID = 0;
            _MDProjectCategoryEntity = new MDProjectCategoryEntity();
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
