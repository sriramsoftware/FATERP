// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDEmployeeSkillControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeSkillID
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

        public MDEmployeeSkillEntity _MDEmployeeSkillEntity
        {
            get
            {
                MDEmployeeSkillEntity entity = new MDEmployeeSkillEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeSkillEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeSkillEntity CurrentMDEmployeeSkillEntity
        {
            get
            {
                if (_EmployeeSkillID > 0)
                {
                    if (_MDEmployeeSkillEntity.EmployeeSkillID != _EmployeeSkillID)
                    {
                        _MDEmployeeSkillEntity = FCCMDEmployeeSkill.GetFacadeCreate().GetByID(_EmployeeSkillID);
                    }
                }

                return _MDEmployeeSkillEntity;
            }
            set
            {
                _MDEmployeeSkillEntity = value;
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
            MDEmployeeSkillEntity mDEmployeeSkillEntity = CurrentMDEmployeeSkillEntity;


            if (!mDEmployeeSkillEntity.IsNew)
            {
                txtName.Text = mDEmployeeSkillEntity.Name.ToString();
                txtDescription.Text = mDEmployeeSkillEntity.Description.ToString();
                chkIsRemoved.Checked = mDEmployeeSkillEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeSkillList();
        }

        private void BindMDEmployeeSkillList()
        {
            lvMDEmployeeSkill.DataBind();
        }

        private MDEmployeeSkillEntity BuildMDEmployeeSkillEntity()
        {
            MDEmployeeSkillEntity mDEmployeeSkillEntity = CurrentMDEmployeeSkillEntity;

            mDEmployeeSkillEntity.Name = txtName.Text.Trim();
            mDEmployeeSkillEntity.Description = txtDescription.Text.Trim();
            mDEmployeeSkillEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEmployeeSkillEntity;
        }

        private void SaveMDEmployeeSkillEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeSkillEntity mDEmployeeSkillEntity = BuildMDEmployeeSkillEntity();

                    Int64 result = -1;

                    if (mDEmployeeSkillEntity.IsNew)
                    {
                        result = FCCMDEmployeeSkill.GetFacadeCreate().Add(mDEmployeeSkillEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeSkillEntity.FLD_NAME_EmployeeSkillID, mDEmployeeSkillEntity.EmployeeSkillID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeSkill.GetFacadeCreate().Update(mDEmployeeSkillEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSkillID = 0;
                        _MDEmployeeSkillEntity = new MDEmployeeSkillEntity();
                        PrepareInitialView();
                        BindMDEmployeeSkillList();

                        if (mDEmployeeSkillEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Skill Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Skill Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeSkillEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Skill Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Skill Information.", false);
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

        protected void lvMDEmployeeSkill_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSkillID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSkillID);

            if (EmployeeSkillID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSkillID = EmployeeSkillID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeSkillEntity.FLD_NAME_EmployeeSkillID, EmployeeSkillID.ToString(), SQLMatchType.Equal);

                        MDEmployeeSkillEntity mDEmployeeSkillEntity = new MDEmployeeSkillEntity();


                        result = FCCMDEmployeeSkill.GetFacadeCreate().Delete(mDEmployeeSkillEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSkillID = 0;
                            _MDEmployeeSkillEntity = new MDEmployeeSkillEntity();
                            PrepareInitialView();
                            BindMDEmployeeSkillList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Skill has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Skill.", true);
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

        protected void odsMDEmployeeSkill_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeSkillEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSkillID = 0;
            _MDEmployeeSkillEntity = new MDEmployeeSkillEntity();
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
