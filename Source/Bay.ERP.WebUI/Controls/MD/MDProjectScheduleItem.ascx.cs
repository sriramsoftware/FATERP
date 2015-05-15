// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class MDProjectScheduleItemControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectScheduleItemID
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

        public MDProjectScheduleItemEntity _MDProjectScheduleItemEntity
        {
            get
            {
                MDProjectScheduleItemEntity entity = new MDProjectScheduleItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDProjectScheduleItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDProjectScheduleItemEntity CurrentMDProjectScheduleItemEntity
        {
            get
            {
                if (_ProjectScheduleItemID > 0)
                {
                    if (_MDProjectScheduleItemEntity.ProjectScheduleItemID != _ProjectScheduleItemID)
                    {
                        _MDProjectScheduleItemEntity = FCCMDProjectScheduleItem.GetFacadeCreate().GetByID(_ProjectScheduleItemID);
                    }
                }

                return _MDProjectScheduleItemEntity;
            }
            set
            {
                _MDProjectScheduleItemEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
           MiscUtil.PopulateMDIssuePriority(ddlIssuePriorityID, false);
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;

            if (treeProjectScheduleItem.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item .", true);
            }

            return validationResult;
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTitle.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtDuration.Text = String.Empty;
            txtNotifyBeforeMin.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDProjectScheduleItemEntity mDProjectScheduleItemEntity = CurrentMDProjectScheduleItemEntity;


            if (!mDProjectScheduleItemEntity.IsNew)
            {
                txtTitle.Text = mDProjectScheduleItemEntity.Title.ToString();
                txtDescription.Text = mDProjectScheduleItemEntity.Description.ToString();
                if (ddlIssuePriorityID.Items.Count > 0 && mDProjectScheduleItemEntity.IssuePriorityID != null)
                {
                    ddlIssuePriorityID.SelectedValue = mDProjectScheduleItemEntity.IssuePriorityID.ToString();
                }

                txtDuration.Text = mDProjectScheduleItemEntity.Duration.ToString();
                txtNotifyBeforeMin.Text = mDProjectScheduleItemEntity.NotifyBeforeMin.ToString();
                chkIsRemoved.Checked = mDProjectScheduleItemEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDProjectScheduleItemList();
        }

        private void BindMDProjectScheduleItemList()
        {
           
        }

        private void LoadTreeView()
        {
            treeProjectScheduleItem.ReBuildTree();
        }

        private MDProjectScheduleItemEntity BuildMDProjectScheduleItemEntity()
        {
            MDProjectScheduleItemEntity mDProjectScheduleItemEntity = CurrentMDProjectScheduleItemEntity;

           
            mDProjectScheduleItemEntity.Title = txtTitle.Text.Trim();
            mDProjectScheduleItemEntity.Description = txtDescription.Text.Trim();
            if (ddlIssuePriorityID.Items.Count > 0)
            {
                if (ddlIssuePriorityID.SelectedValue == "0")
                {
                }
                else
                {
                    mDProjectScheduleItemEntity.IssuePriorityID = Int64.Parse(ddlIssuePriorityID.SelectedValue);
                }
            }

            if (!txtDuration.Text.Trim().IsNullOrEmpty())
            {
                mDProjectScheduleItemEntity.Duration = Decimal.Parse(txtDuration.Text.Trim());
            }
            else
            {
                mDProjectScheduleItemEntity.Duration = null;
            }

            if (!txtNotifyBeforeMin.Text.Trim().IsNullOrEmpty())
            {
                mDProjectScheduleItemEntity.NotifyBeforeMin = Int32.Parse(txtNotifyBeforeMin.Text.Trim());
            }
            else
            {
                mDProjectScheduleItemEntity.NotifyBeforeMin = null;
            }

            mDProjectScheduleItemEntity.IsRemoved = chkIsRemoved.Checked;


            return mDProjectScheduleItemEntity;
        }

        private void SaveMDProjectScheduleItemEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDProjectScheduleItemEntity mDProjectScheduleItemEntity = BuildMDProjectScheduleItemEntity();

                    Int64 result = -1;

                    if (mDProjectScheduleItemEntity.IsNew)
                    {
                        if (treeProjectScheduleItem.SelectedNode != null)
                        {
                            if (treeProjectScheduleItem.SelectedValue == "0")
                            {
                                mDProjectScheduleItemEntity.ParentProjectScheduleItemID = null;
                            }
                            else
                            {
                                mDProjectScheduleItemEntity.ParentProjectScheduleItemID = Int64.Parse(treeProjectScheduleItem.SelectedValue);
                            }
                        }
                        result = FCCMDProjectScheduleItem.GetFacadeCreate().Add(mDProjectScheduleItemEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDProjectScheduleItemEntity.FLD_NAME_ProjectScheduleItemID, mDProjectScheduleItemEntity.ProjectScheduleItemID.ToString(), SQLMatchType.Equal);
                        result = FCCMDProjectScheduleItem.GetFacadeCreate().Update(mDProjectScheduleItemEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectScheduleItemID = 0;
                        _MDProjectScheduleItemEntity = new MDProjectScheduleItemEntity();
                        PrepareInitialView();
                        BindMDProjectScheduleItemList();

                        if (mDProjectScheduleItemEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Schedule Item Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Schedule Item Information has been updated successfully.", false);
                        }

                        LoadTreeView();
                    }
                    else
                    {
                        if (mDProjectScheduleItemEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Schedule Item Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Schedule Item Information.", false);
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
            Int64 ProjectScheduleItemID;

            Int64.TryParse(treeProjectScheduleItem.SelectedValue, out ProjectScheduleItemID);

            if (ProjectScheduleItemID > 0)
            {
                _ProjectScheduleItemID = ProjectScheduleItemID;

                PrepareEditView();
            }
        }

        private void DeleteDocumentCategory()
        {
            Int64 ProjectScheduleItemID;

            Int64.TryParse(treeProjectScheduleItem.SelectedValue, out ProjectScheduleItemID);

            if (ProjectScheduleItemID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectScheduleItemEntity.FLD_NAME_ProjectScheduleItemID, ProjectScheduleItemID.ToString(), SQLMatchType.Equal);

                    MDProjectScheduleItemEntity mDProjectScheduleItemEntity = new MDProjectScheduleItemEntity();


                    result = FCCMDProjectScheduleItem.GetFacadeCreate().Delete(mDProjectScheduleItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _ProjectScheduleItemID = 0;
                        _MDProjectScheduleItemEntity = new MDProjectScheduleItemEntity();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Project Schedule Item has been successfully deleted.", true);
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

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeProjectScheduleItem.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Parent Item Category.", true);
            }

            return validationResult;
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
            if (ValidateInput())
            {
                SaveMDProjectScheduleItemEntity();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectScheduleItemID = 0;
            _MDProjectScheduleItemEntity = new MDProjectScheduleItemEntity();
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
