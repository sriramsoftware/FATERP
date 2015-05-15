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
    public partial class MDEmployeeCompetencyLevelControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeCompetencyLevelID
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

        public MDEmployeeCompetencyLevelEntity _MDEmployeeCompetencyLevelEntity
        {
            get
            {
                MDEmployeeCompetencyLevelEntity entity = new MDEmployeeCompetencyLevelEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeCompetencyLevelEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeCompetencyLevelEntity CurrentMDEmployeeCompetencyLevelEntity
        {
            get
            {
                if (_EmployeeCompetencyLevelID > 0)
                {
                    if (_MDEmployeeCompetencyLevelEntity.EmployeeCompetencyLevelID != _EmployeeCompetencyLevelID)
                    {
                        _MDEmployeeCompetencyLevelEntity = FCCMDEmployeeCompetencyLevel.GetFacadeCreate().GetByID(_EmployeeCompetencyLevelID);
                    }
                }

                return _MDEmployeeCompetencyLevelEntity;
            }
            set
            {
                _MDEmployeeCompetencyLevelEntity = value;
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
            MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity = CurrentMDEmployeeCompetencyLevelEntity;


            if (!mDEmployeeCompetencyLevelEntity.IsNew)
            {
                txtName.Text = mDEmployeeCompetencyLevelEntity.Name.ToString();
                txtDescription.Text = mDEmployeeCompetencyLevelEntity.Description.ToString();
                chkIsRemoved.Checked = mDEmployeeCompetencyLevelEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeCompetencyLevelList();
        }

        private void BindMDEmployeeCompetencyLevelList()
        {
            lvMDEmployeeCompetencyLevel.DataBind();
        }

        private MDEmployeeCompetencyLevelEntity BuildMDEmployeeCompetencyLevelEntity()
        {
            MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity = CurrentMDEmployeeCompetencyLevelEntity;

            mDEmployeeCompetencyLevelEntity.Name = txtName.Text.Trim();
            mDEmployeeCompetencyLevelEntity.Description = txtDescription.Text.Trim();
            mDEmployeeCompetencyLevelEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEmployeeCompetencyLevelEntity;
        }

        private void SaveMDEmployeeCompetencyLevelEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity = BuildMDEmployeeCompetencyLevelEntity();

                    Int64 result = -1;

                    if (mDEmployeeCompetencyLevelEntity.IsNew)
                    {
                        result = FCCMDEmployeeCompetencyLevel.GetFacadeCreate().Add(mDEmployeeCompetencyLevelEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeCompetencyLevelEntity.FLD_NAME_EmployeeCompetencyLevelID, mDEmployeeCompetencyLevelEntity.EmployeeCompetencyLevelID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeCompetencyLevel.GetFacadeCreate().Update(mDEmployeeCompetencyLevelEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeCompetencyLevelID = 0;
                        _MDEmployeeCompetencyLevelEntity = new MDEmployeeCompetencyLevelEntity();
                        PrepareInitialView();
                        BindMDEmployeeCompetencyLevelList();

                        if (mDEmployeeCompetencyLevelEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Competency Level Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Competency Level Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeCompetencyLevelEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Competency Level Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Competency Level Information.", false);
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

        protected void lvMDEmployeeCompetencyLevel_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeCompetencyLevelID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeCompetencyLevelID);

            if (EmployeeCompetencyLevelID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeCompetencyLevelID = EmployeeCompetencyLevelID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeCompetencyLevelEntity.FLD_NAME_EmployeeCompetencyLevelID, EmployeeCompetencyLevelID.ToString(), SQLMatchType.Equal);

                        MDEmployeeCompetencyLevelEntity mDEmployeeCompetencyLevelEntity = new MDEmployeeCompetencyLevelEntity();


                        result = FCCMDEmployeeCompetencyLevel.GetFacadeCreate().Delete(mDEmployeeCompetencyLevelEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeCompetencyLevelID = 0;
                            _MDEmployeeCompetencyLevelEntity = new MDEmployeeCompetencyLevelEntity();
                            PrepareInitialView();
                            BindMDEmployeeCompetencyLevelList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Competency Level has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Competency Level.", true);
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

        protected void odsMDEmployeeCompetencyLevel_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeCompetencyLevelEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeCompetencyLevelID = 0;
            _MDEmployeeCompetencyLevelEntity = new MDEmployeeCompetencyLevelEntity();
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
