// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Dec-2011, 11:00:45




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
    public partial class MDProjectDocumentCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectDocumentCategoryID
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

        public MDProjectDocumentCategoryEntity _MDProjectDocumentCategoryEntity
        {
            get
            {
                MDProjectDocumentCategoryEntity entity = new MDProjectDocumentCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectDocumentCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectDocumentCategoryEntity CurrentMDProjectDocumentCategoryEntity
        {
            get
            {
                if (_ProjectDocumentCategoryID > 0)
                {
                    if (_MDProjectDocumentCategoryEntity.ProjectDocumentCategoryID != _ProjectDocumentCategoryID)
                    {
                        _MDProjectDocumentCategoryEntity = FCCMDProjectDocumentCategory.GetFacadeCreate().GetByID(_ProjectDocumentCategoryID);
                    }
                }

                return _MDProjectDocumentCategoryEntity;
            }
            set
            {
                _MDProjectDocumentCategoryEntity = value;
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
            txtRequiredStandardTime.Text = String.Empty;
            txtReminderTime.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity = CurrentMDProjectDocumentCategoryEntity;


            if (!mDProjectDocumentCategoryEntity.IsNew)
            {
                txtName.Text = mDProjectDocumentCategoryEntity.Name.ToString();
                txtRequiredStandardTime.Text = mDProjectDocumentCategoryEntity.RequiredStandardTime.ToString();
                txtReminderTime.Text = mDProjectDocumentCategoryEntity.ReminderTime.ToString();
                chkIsRemoved.Checked = mDProjectDocumentCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void LoadTreeView()
        {
            treeProjectDocumentCategory.ReBuildTree();
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeProjectDocumentCategory.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Parent Item Category.", true);
            }

            return validationResult;
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;

            if (treeProjectDocumentCategory.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item Category.", true);
            }

            return validationResult;
        }


        private MDProjectDocumentCategoryEntity BuildMDProjectDocumentCategoryEntity()
        {
            MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity = CurrentMDProjectDocumentCategoryEntity;

            mDProjectDocumentCategoryEntity.Name = txtName.Text.Trim();
            if (!txtRequiredStandardTime.Text.Trim().IsNullOrEmpty())
            {
                mDProjectDocumentCategoryEntity.RequiredStandardTime = Int32.Parse(txtRequiredStandardTime.Text.Trim());
            }
            else
            {
                mDProjectDocumentCategoryEntity.RequiredStandardTime = null;
            }

            if (!txtReminderTime.Text.Trim().IsNullOrEmpty())
            {
                mDProjectDocumentCategoryEntity.ReminderTime = Int32.Parse(txtReminderTime.Text.Trim());
            }
            else
            {
                mDProjectDocumentCategoryEntity.ReminderTime = null;
            }

            mDProjectDocumentCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectDocumentCategoryEntity;
        }

        private void SaveMDProjectDocumentCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity = BuildMDProjectDocumentCategoryEntity();

                    Int64 result = -1;

                    if (mDProjectDocumentCategoryEntity.IsNew)
                    {
                        if (treeProjectDocumentCategory.SelectedNode != null)
                        {
                            if (treeProjectDocumentCategory.SelectedValue == "0")
                            {
                                mDProjectDocumentCategoryEntity.ParentProjectDocumentCategoryID = null;
                            }
                            else
                            {
                                mDProjectDocumentCategoryEntity.ParentProjectDocumentCategoryID = Int64.Parse(treeProjectDocumentCategory.SelectedValue);
                            }
                        }

                        result = FCCMDProjectDocumentCategory.GetFacadeCreate().Add(mDProjectDocumentCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectDocumentCategoryEntity.FLD_NAME_ProjectDocumentCategoryID, mDProjectDocumentCategoryEntity.ProjectDocumentCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectDocumentCategory.GetFacadeCreate().Update(mDProjectDocumentCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectDocumentCategoryID = 0;
                        _MDProjectDocumentCategoryEntity = new MDProjectDocumentCategoryEntity();
                        PrepareInitialView();

                        if (mDProjectDocumentCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Document Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Document Category Information has been updated successfully.", false);
                        }

                        LoadTreeView();
                    }
                    else
                    {
                        if (mDProjectDocumentCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Document Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Document Category Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void EditDocumentCategory()
        {
            Int64 ProjectDocumentCategoryID;

            Int64.TryParse(treeProjectDocumentCategory.SelectedValue, out ProjectDocumentCategoryID);

            if (ProjectDocumentCategoryID > 0)
            {
                _ProjectDocumentCategoryID = ProjectDocumentCategoryID;

                PrepareEditView();
            }
        }

        private void DeleteDocumentCategory()
        {
            Int64 ProjectDocumentCategoryID;

            Int64.TryParse(treeProjectDocumentCategory.SelectedValue, out ProjectDocumentCategoryID);

            if (ProjectDocumentCategoryID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectDocumentCategoryEntity.FLD_NAME_ProjectDocumentCategoryID, ProjectDocumentCategoryID.ToString(), SQLMatchType.Equal);

                    MDProjectDocumentCategoryEntity mDProjectDocumentCategoryEntity = new MDProjectDocumentCategoryEntity();


                    result = FCCMDProjectDocumentCategory.GetFacadeCreate().Delete(mDProjectDocumentCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _ProjectDocumentCategoryID = 0;
                        _MDProjectDocumentCategoryEntity = new MDProjectDocumentCategoryEntity();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Project Document Category has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Document Category.", true);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                SaveMDProjectDocumentCategoryEntity();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectDocumentCategoryID = 0;
            _MDProjectDocumentCategoryEntity = new MDProjectDocumentCategoryEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void lnkBtnEditItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                EditDocumentCategory();
            }
        }

        protected void lnkBtnremoveItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                DeleteDocumentCategory();
            }
        }

        #endregion

        #endregion Event
    }
}
