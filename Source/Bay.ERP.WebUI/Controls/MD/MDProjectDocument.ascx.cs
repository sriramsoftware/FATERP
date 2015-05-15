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
    public partial class MDProjectDocumentControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectDocumentID
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

        public MDProjectDocumentEntity _MDProjectDocumentEntity
        {
            get
            {
                MDProjectDocumentEntity entity = new MDProjectDocumentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectDocumentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectDocumentEntity CurrentMDProjectDocumentEntity
        {
            get
            {
                if (_ProjectDocumentID > 0)
                {
                    if (_MDProjectDocumentEntity.ProjectDocumentID != _ProjectDocumentID)
                    {
                        _MDProjectDocumentEntity = FCCMDProjectDocument.GetFacadeCreate().GetByID(_ProjectDocumentID);
                    }
                }

                return _MDProjectDocumentEntity;
            }
            set
            {
                _MDProjectDocumentEntity = value;
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
            treeProjectDocument.BuildTree();

            PrepareInitialViewForm();
        }

        private void PrepareInitialViewForm()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtRequiredStandardTime.Text = String.Empty;
            txtReminderTime.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDProjectDocumentEntity mDProjectDocumentEntity = CurrentMDProjectDocumentEntity;


            if (!mDProjectDocumentEntity.IsNew)
            {
                txtName.Text = mDProjectDocumentEntity.Name.ToString();
                txtRequiredStandardTime.Text = mDProjectDocumentEntity.RequiredStandardTime.ToString();
                txtReminderTime.Text = mDProjectDocumentEntity.ReminderTime.ToString();
                txtRemarks.Text = mDProjectDocumentEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDProjectDocumentEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void LoadTreeView()
        {
            treeProjectDocument.ReBuildTree();
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeProjectDocument.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Document Category..", true);
            }
            else
            {
                try
                {
                    TreeNode selectedNode = (TreeNode)treeProjectDocument.SelectedNode;

                    BayTreeNodeValue selectedNodeValue = new BayTreeNodeValue();
                    selectedNodeValue.SetValuesFromString(selectedNode.Value);

                    if (selectedNodeValue.Attributes["NodeType"] != CustomControlConstants.DocumentNodeType.DocumentCategory)
                    {
                        validationResult = false;

                        MiscUtil.ShowMessage(lblMessage, "Please Select Document Category..", true);
                    }
                }
                catch
                {
                    validationResult = false;

                    MiscUtil.ShowMessage(lblMessage, "Can not determine Document Category..", true);
                }
            }

            return validationResult;
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;


            if (treeProjectDocument.SelectedNode == null)
            {
                validationResult = false;
                MiscUtil.ShowMessage(lblMessage, "Please Select Document Category.", true);
            }
            else
            {
                try
                {
                    TreeNode selectedNode = (TreeNode)treeProjectDocument.SelectedNode;

                    BayTreeNodeValue selectedNodeValue = new BayTreeNodeValue();
                    selectedNodeValue.SetValuesFromString(selectedNode.Value);

                    if (selectedNodeValue.Attributes["NodeType"] != CustomControlConstants.DocumentNodeType.Document)
                    {
                        validationResult = false;

                        MiscUtil.ShowMessage(lblMessage, "Please Select Document..", true);
                    }
                }
                catch
                {
                    validationResult = false;

                    MiscUtil.ShowMessage(lblMessage, "Can not determine Document..", true);
                }
            }
           return validationResult;
        }
        
        private MDProjectDocumentEntity BuildMDProjectDocumentEntity()
        {
            MDProjectDocumentEntity mDProjectDocumentEntity = CurrentMDProjectDocumentEntity;

            mDProjectDocumentEntity.Name = txtName.Text.Trim();
            if (!txtRequiredStandardTime.Text.Trim().IsNullOrEmpty())
            {
                mDProjectDocumentEntity.RequiredStandardTime = Int32.Parse(txtRequiredStandardTime.Text.Trim());
            }
            else
            {
                mDProjectDocumentEntity.RequiredStandardTime = null;
            }

            if (!txtReminderTime.Text.Trim().IsNullOrEmpty())
            {
                mDProjectDocumentEntity.ReminderTime = Int32.Parse(txtReminderTime.Text.Trim());
            }
            else
            {
                mDProjectDocumentEntity.ReminderTime = null;
            }

            mDProjectDocumentEntity.Remarks = txtRemarks.Text.Trim();
            mDProjectDocumentEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectDocumentEntity;
        }

        private void SaveMDProjectDocumentEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectDocumentEntity mDProjectDocumentEntity = BuildMDProjectDocumentEntity();

                    Int64 result = -1;

                    Boolean insertValidation = true;

                    if (mDProjectDocumentEntity.IsNew)
                    {
                        if (ValidateInput())
                        {
                            if (treeProjectDocument.SelectedNode != null)
                            {
                                mDProjectDocumentEntity.ProjectDocumentCategoryID = Int64.Parse(BayTreeNodeValue.GetValue(treeProjectDocument.SelectedValue));
                            }

                            result = FCCMDProjectDocument.GetFacadeCreate().Add(mDProjectDocumentEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            insertValidation = false;
                        }
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectDocumentEntity.FLD_NAME_ProjectDocumentID, mDProjectDocumentEntity.ProjectDocumentID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectDocument.GetFacadeCreate().Update(mDProjectDocumentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (insertValidation)
                    {
                        if (result > 0)
                        {
                            _ProjectDocumentID = 0;
                            _MDProjectDocumentEntity = new MDProjectDocumentEntity();
                            PrepareInitialViewForm();

                            if (mDProjectDocumentEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Project Document Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Project Document Information has been updated successfully.", false);
                            }

                            LoadTreeView();
                        }
                        else
                        {
                            if (mDProjectDocumentEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Project Document Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Project Document Information.", false);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void EditDocument()
        {
            Int64 ProjectDocumentID;

            Int64.TryParse(BayTreeNodeValue.GetValue(treeProjectDocument.SelectedValue), out ProjectDocumentID);

            if (ProjectDocumentID > 0)
            {
                _ProjectDocumentID = ProjectDocumentID;

                PrepareEditView();
            }
        }

        private void DeleteDocument()
        {
            Int64 ProjectDocumentID;

            Int64.TryParse(BayTreeNodeValue.GetValue(treeProjectDocument.SelectedValue), out ProjectDocumentID);

            if (ProjectDocumentID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectDocumentEntity.FLD_NAME_ProjectDocumentID, ProjectDocumentID.ToString(), SQLMatchType.Equal);

                    MDProjectDocumentEntity mDProjectDocumentEntity = new MDProjectDocumentEntity();


                    result = FCCMDProjectDocument.GetFacadeCreate().Delete(mDProjectDocumentEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _ProjectDocumentID = 0;
                        _MDProjectDocumentEntity = new MDProjectDocumentEntity();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Project Document has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Document.", true);
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
            SaveMDProjectDocumentEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectDocumentID = 0;
            _MDProjectDocumentEntity = new MDProjectDocumentEntity();
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
                EditDocument();
            }
        }

        protected void lnkBtnremoveItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                DeleteDocument();
            }
        }

        #endregion

        #endregion Event
    }
}
