// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public partial class BDMDTaskCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _TaskCategoryID
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

        public BDMDTaskCategoryEntity _BDMDTaskCategoryEntity
        {
            get
            {
                BDMDTaskCategoryEntity entity = new BDMDTaskCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDMDTaskCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDMDTaskCategoryEntity CurrentBDMDTaskCategoryEntity
        {
            get
            {
                if (_TaskCategoryID > 0)
                {
                    if (_BDMDTaskCategoryEntity.TaskCategoryID != _TaskCategoryID)
                    {
                        _BDMDTaskCategoryEntity = FCCBDMDTaskCategory.GetFacadeCreate().GetByID(_TaskCategoryID);
                    }
                }

                return _BDMDTaskCategoryEntity;
            }
            set
            {
                _BDMDTaskCategoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, true);
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
            BDMDTaskCategoryEntity bDMDTaskCategoryEntity = CurrentBDMDTaskCategoryEntity;


            if (!bDMDTaskCategoryEntity.IsNew)
            {
                if (ddlDepartmentID.Items.Count > 0 && bDMDTaskCategoryEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = bDMDTaskCategoryEntity.DepartmentID.ToString();
                }

                txtName.Text = bDMDTaskCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = bDMDTaskCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            
        }

        private void LoadTreeView()
        {
            treeTaskCategory.ReBuildTree();
        }

        private void EditTaskCategory()
        {
            Int64 taskCategoryID;

            Int64.TryParse(treeTaskCategory.SelectedValue, out taskCategoryID);

            if (taskCategoryID > 0)
            {
                _TaskCategoryID = taskCategoryID;

                PrepareEditView();
            }
        }

        private void DeleteTaskCategory()
        {
            Int64 taskCategoryID;

            Int64.TryParse(treeTaskCategory.SelectedValue, out taskCategoryID);

            if (taskCategoryID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskCategoryEntity.FLD_NAME_TaskCategoryID, taskCategoryID.ToString(), SQLMatchType.Equal);

                    BDMDTaskCategoryEntity bDMDTaskCategoryEntity = new BDMDTaskCategoryEntity();

                    result = FCCBDMDTaskCategory.GetFacadeCreate().Delete(bDMDTaskCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _TaskCategoryID = 0;
                        _BDMDTaskCategoryEntity = new BDMDTaskCategoryEntity();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Task Category has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Task Category.", true);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private BDMDTaskCategoryEntity BuildBDMDTaskCategoryEntity()
        {
            BDMDTaskCategoryEntity bDMDTaskCategoryEntity = CurrentBDMDTaskCategoryEntity;

            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                    bDMDTaskCategoryEntity.DepartmentID = null;
                }
                else
                {
                    bDMDTaskCategoryEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
                }
            }

            bDMDTaskCategoryEntity.Name = txtName.Text.Trim();
            bDMDTaskCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return bDMDTaskCategoryEntity;
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;

            if (treeTaskCategory.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Task Category.", true);
            }

            return validationResult;
        }

        private void SaveBDMDTaskCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDMDTaskCategoryEntity bDMDTaskCategoryEntity = BuildBDMDTaskCategoryEntity();

                    Int64 result = -1;

                    if (bDMDTaskCategoryEntity.IsNew)
                    {

                        if (treeTaskCategory.SelectedNode != null)
                        {
                            if (treeTaskCategory.SelectedValue == "0")
                            {
                                bDMDTaskCategoryEntity.ParentTaskCategoryID = null;
                            }
                            else
                            {
                                bDMDTaskCategoryEntity.ParentTaskCategoryID = Int64.Parse(treeTaskCategory.SelectedValue);
                            }
                        }

                        result = FCCBDMDTaskCategory.GetFacadeCreate().Add(bDMDTaskCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskCategoryEntity.FLD_NAME_TaskCategoryID, bDMDTaskCategoryEntity.TaskCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCBDMDTaskCategory.GetFacadeCreate().Update(bDMDTaskCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _TaskCategoryID = 0;
                        _BDMDTaskCategoryEntity = new BDMDTaskCategoryEntity();
                        PrepareInitialView();
                        LoadTreeView();

                        if (bDMDTaskCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Task Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Task Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDMDTaskCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Task Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Task Category Information.", false);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDMDTaskCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TaskCategoryID = 0;
            _BDMDTaskCategoryEntity = new BDMDTaskCategoryEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Details Button Event

        protected void lnkBtnEditItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                EditTaskCategory();
            }
        }

        protected void lnkBtnremoveItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                DeleteTaskCategory();
            }
        }

        #endregion

        #endregion Event
    }
}
