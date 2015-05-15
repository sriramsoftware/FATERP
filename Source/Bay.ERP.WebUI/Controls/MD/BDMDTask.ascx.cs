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
    public partial class BDMDTaskControl : BaseControl
    {       
        #region Properties

        public Int64 _TaskID
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

        public BDMDTaskEntity _BDMDTaskEntity
        {
            get
            {
                BDMDTaskEntity entity = new BDMDTaskEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDMDTaskEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDMDTaskEntity CurrentBDMDTaskEntity
        {
            get
            {
                if (_TaskID > 0)
                {
                    if (_BDMDTaskEntity.TaskID != _TaskID)
                    {
                        _BDMDTaskEntity = FCCBDMDTask.GetFacadeCreate().GetByID(_TaskID);
                    }
                }

                return _BDMDTaskEntity;
            }
            set
            {
                _BDMDTaskEntity = value;
            }
        }

        public Int64 _TaskRepeatID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["TaskRepeatID"] != null)
                {
                    Int64.TryParse(ViewState["TaskRepeatID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["TaskRepeatID"] = value;
            }
        }

        public BDMDTaskRepeatEntity _BDMDTaskRepeatEntity
        {
            get
            {
                BDMDTaskRepeatEntity entity = new BDMDTaskRepeatEntity();

                if (ViewState["BDMDTaskRepeatEntity"] != null)
                {
                    entity = (BDMDTaskRepeatEntity)ViewState["BDMDTaskRepeatEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["BDMDTaskRepeatEntity"] = value;
            }
        }

        private BDMDTaskRepeatEntity CurrentBDMDTaskRepeatEntity
        {
            get
            {
                if (_TaskID > 0)
                {
                    String fe=SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskRepeatEntity.FLD_NAME_TaskID,_TaskID.ToString(),SQLMatchType.Equal);
                    IList<BDMDTaskRepeatEntity> lst = FCCBDMDTaskRepeat.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (lst != null && lst.Count > 0)
                    {
                        _BDMDTaskRepeatEntity = lst[0];
                    }

                    else
                    {
                        _BDMDTaskRepeatEntity = new BDMDTaskRepeatEntity();
                    }
                }

                return _BDMDTaskRepeatEntity;
            }
            set
            {
                _BDMDTaskRepeatEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDMDRepeatCategory(ddlRepeatCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialViewRepeat()
        {
            BuildDropDownList();

            txtRepeatEvery.Text = "1";
            txtStartsOn.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndsOn.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditViewRepeat()
        {
            BDMDTaskRepeatEntity bDMDTaskRepeatEntity = CurrentBDMDTaskRepeatEntity;


            if (!bDMDTaskRepeatEntity.IsNew)
            {
                if (ddlRepeatCategoryID.Items.Count > 0 && bDMDTaskRepeatEntity.RepeatCategoryID != null)
                {
                    ddlRepeatCategoryID.SelectedValue = bDMDTaskRepeatEntity.RepeatCategoryID.ToString();
                }

                txtRepeatEvery.Text = bDMDTaskRepeatEntity.RepeatEvery.ToString();
                txtStartsOn.Text = bDMDTaskRepeatEntity.StartsOn.ToStringDefault();
                txtEndsOn.Text = bDMDTaskRepeatEntity.EndsOn.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private BDMDTaskRepeatEntity BuildBDMDTaskRepeatEntity()
        {
            BDMDTaskRepeatEntity bDMDTaskRepeatEntity = CurrentBDMDTaskRepeatEntity;

            if (ddlRepeatCategoryID.Items.Count > 0)
            {
                if (ddlRepeatCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    bDMDTaskRepeatEntity.RepeatCategoryID = Int64.Parse(ddlRepeatCategoryID.SelectedValue);
                }
            }

            if (!txtRepeatEvery.Text.Trim().IsNullOrEmpty())
            {
                bDMDTaskRepeatEntity.RepeatEvery = Int32.Parse(txtRepeatEvery.Text.Trim());
            }

            if (txtStartsOn.Text.Trim().IsNotNullOrEmpty())
            {
                bDMDTaskRepeatEntity.StartsOn = MiscUtil.ParseToDateTime(txtStartsOn.Text);
            }

            if (txtEndsOn.Text.Trim().IsNotNullOrEmpty())
            {
                bDMDTaskRepeatEntity.EndsOn = MiscUtil.ParseToDateTime(txtEndsOn.Text);
            }
            else
            {
                bDMDTaskRepeatEntity.EndsOn = null;
            }


            return bDMDTaskRepeatEntity;
        }

        private void LoadTreeView()
        {
            treeTask.ReBuildTree();
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeTask.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Task Category..", true);
            }
            else
            {
                try
                {
                    TreeNode selectedNode = (TreeNode)treeTask.SelectedNode;

                    BayTreeNodeValue selectedNodeValue = new BayTreeNodeValue();
                    selectedNodeValue.SetValuesFromString(selectedNode.Value);

                    if (selectedNodeValue.Attributes["NodeType"] != CustomControlConstants.DocumentNodeType.DocumentCategory)
                    {
                        validationResult = false;

                        MiscUtil.ShowMessage(lblMessage, "Please Select Task Category..", true);
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


            if (treeTask.SelectedNode == null)
            {
                validationResult = false;
                MiscUtil.ShowMessage(lblMessage, "Please Select Task Category.", true);
            }
            else
            {
                try
                {
                    TreeNode selectedNode = (TreeNode)treeTask.SelectedNode;

                    BayTreeNodeValue selectedNodeValue = new BayTreeNodeValue();
                    selectedNodeValue.SetValuesFromString(selectedNode.Value);

                    if (selectedNodeValue.Attributes["NodeType"] != CustomControlConstants.DocumentNodeType.Document)
                    {
                        validationResult = false;

                        MiscUtil.ShowMessage(lblMessage, "Please Select Task..", true);
                    }
                }
                catch
                {
                    validationResult = false;

                    MiscUtil.ShowMessage(lblMessage, "Can not determine Task..", true);
                }
            }
            return validationResult;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            treeTask.BuildTree();

            txtName.Text = String.Empty;
            txtRequiredStandardTime.Text = String.Empty;
            txtReminderTime.Text = String.Empty;
            chkIsRepeat.Checked = false;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
            PrepareInitialViewRepeat();
        }

        private void PrepareEditView()
        {
            BDMDTaskEntity bDMDTaskEntity = CurrentBDMDTaskEntity;


            if (!bDMDTaskEntity.IsNew)
            {
                txtName.Text = bDMDTaskEntity.Name.ToString();
                txtRequiredStandardTime.Text = bDMDTaskEntity.RequiredStandardTime.ToString();
                txtReminderTime.Text = bDMDTaskEntity.ReminderTime.ToString();
                chkIsRepeat.Checked = bDMDTaskEntity.IsRepeat;
                txtRemarks.Text = bDMDTaskEntity.Remarks.ToString();
                chkIsRemoved.Checked = bDMDTaskEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDMDTaskList();
        }

        private void BindBDMDTaskList()
        {
           
        }

        private BDMDTaskEntity BuildBDMDTaskEntity()
        {
            BDMDTaskEntity bDMDTaskEntity = CurrentBDMDTaskEntity;

            bDMDTaskEntity.Name = txtName.Text.Trim();
            if (!txtRequiredStandardTime.Text.Trim().IsNullOrEmpty())
            {
                bDMDTaskEntity.RequiredStandardTime = Int32.Parse(txtRequiredStandardTime.Text.Trim());
            }
            else
            {
                bDMDTaskEntity.RequiredStandardTime = null;
            }

            if (!txtReminderTime.Text.Trim().IsNullOrEmpty())
            {
                bDMDTaskEntity.ReminderTime = Int32.Parse(txtReminderTime.Text.Trim());
            }
            else
            {
                bDMDTaskEntity.ReminderTime = null;
            }

            bDMDTaskEntity.IsRepeat = chkIsRepeat.Checked;

            bDMDTaskEntity.Remarks = txtRemarks.Text.Trim();
            bDMDTaskEntity.IsRemoved = chkIsRemoved.Checked;


            return bDMDTaskEntity;
        }

        private void SaveBDMDTaskEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDMDTaskEntity bDMDTaskEntity = BuildBDMDTaskEntity();

                    Int64 result = -1;

                    Boolean insertValidation = true;

                    if (bDMDTaskEntity.IsNew)
                    {
                        if (ValidateInput())
                        {
                            if (treeTask.SelectedNode != null)
                            {
                                bDMDTaskEntity.TaskCategoryID = Int64.Parse(BayTreeNodeValue.GetValue(treeTask.SelectedValue));
                            }

                            result = FCCBDMDTask.GetFacadeCreate().Add(bDMDTaskEntity, DatabaseOperationType.Add, TransactionRequired.No);

                            if (result > 0 && chkIsRepeat.Checked==true)
                            {
                                BDMDTaskRepeatEntity bDMDTaskRepeatEntity = BuildBDMDTaskRepeatEntity();
                                bDMDTaskRepeatEntity.TaskID = result;

                                Int64 resultC = -1;

                                resultC = FCCBDMDTaskRepeat.GetFacadeCreate().Add(bDMDTaskRepeatEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }
                        }
                        else
                        {
                            insertValidation = false;
                        }
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskEntity.FLD_NAME_TaskID, bDMDTaskEntity.TaskID.ToString(), SQLMatchType.Equal);
                        result = FCCBDMDTask.GetFacadeCreate().Update(bDMDTaskEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);

                        if (result > 0)
                        {
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskRepeatEntity.FLD_NAME_TaskID, result.ToString(), SQLMatchType.Equal);
                            IList<BDMDTaskRepeatEntity> lst = FCCBDMDTaskRepeat.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                            Int64 resultC = -1;

                            BDMDTaskRepeatEntity bDMDTaskRepeatEntity = BuildBDMDTaskRepeatEntity();
                            bDMDTaskRepeatEntity.TaskID = result;

                            if (chkIsRepeat.Checked == true)
                            {
                                if (lst != null && lst.Count > 0)
                                {
                                    String filterExpression_taskRepeat = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskRepeatEntity.FLD_NAME_TaskRepeatID, bDMDTaskRepeatEntity.TaskRepeatID.ToString(), SQLMatchType.Equal);
                                    resultC = FCCBDMDTaskRepeat.GetFacadeCreate().Update(bDMDTaskRepeatEntity, filterExpression_taskRepeat, DatabaseOperationType.Update, TransactionRequired.No);
                                }
                                else
                                {
                                    resultC = FCCBDMDTaskRepeat.GetFacadeCreate().Add(bDMDTaskRepeatEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                }
                            }

                            else if (chkIsRepeat.Checked == false)
                            {
                                if (lst != null && lst.Count > 0)
                                {
                                     String filterExpression_taskRepeat = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskRepeatEntity.FLD_NAME_TaskRepeatID, bDMDTaskRepeatEntity.TaskRepeatID.ToString(), SQLMatchType.Equal);
                                     resultC = FCCBDMDTaskRepeat.GetFacadeCreate().Delete(bDMDTaskRepeatEntity, filterExpression_taskRepeat, DatabaseOperationType.Delete, TransactionRequired.No);
                                }
                            }
                        }
                    }

                    if (insertValidation)
                    {
                        if (result > 0)
                        {
                            _TaskID = 0;
                            _BDMDTaskEntity = new BDMDTaskEntity();
                            PrepareInitialView();
                            BindBDMDTaskList();
                            _TaskRepeatID = 0;
                            _BDMDTaskRepeatEntity = new BDMDTaskRepeatEntity();
                            PrepareInitialViewRepeat();

                            if (bDMDTaskEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Task Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Task Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (bDMDTaskEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Task Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Task Information.", false);
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

        private void EditTask()
        {
            Int64 taskID;

            Int64.TryParse(BayTreeNodeValue.GetValue(treeTask.SelectedValue), out taskID);

            if (taskID > 0)
            {
                _TaskID = taskID;

                PrepareEditView();

                if (chkIsRepeat.Checked)
                {
                    dvRepeatInfo.Visible = true;
                    PrepareEditViewRepeat();
                }
                else if (chkIsRepeat.Checked == false)
                {
                    dvRepeatInfo.Visible = false;
                }
            }
        }

        private void DeleteTask()
        {
            Int64 taskID;

            Int64.TryParse(BayTreeNodeValue.GetValue(treeTask.SelectedValue), out taskID);

            if (taskID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskEntity.FLD_NAME_TaskID, taskID.ToString(), SQLMatchType.Equal);

                    BDMDTaskEntity bdMDTaskEntity = new BDMDTaskEntity();


                    result = FCCBDMDTask.GetFacadeCreate().Delete(bdMDTaskEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _TaskID = 0;
                        _BDMDTaskEntity = new BDMDTaskEntity();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Task has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Task.", true);
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
            SaveBDMDTaskEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TaskID = 0;
            _BDMDTaskEntity = new BDMDTaskEntity();
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
                EditTask();
            }
        }

        protected void lnkBtnremoveItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                DeleteTask();
            }
        }

        #endregion

        #region Checkbox Event

        protected void chkIsRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsRepeat.Checked)
            {
                dvRepeatInfo.Visible = true;
            }
            else
            {
                dvRepeatInfo.Visible = false;
            }
        }

        #endregion

        #endregion Event
    }
}
