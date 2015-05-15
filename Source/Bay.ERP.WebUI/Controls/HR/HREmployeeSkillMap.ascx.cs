// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HREmployeeSkillMapControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeSkillMapID
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

        public HREmployeeSkillMapEntity _HREmployeeSkillMapEntity
        {
            get
            {
                HREmployeeSkillMapEntity entity = new HREmployeeSkillMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeSkillMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeSkillMapEntity CurrentHREmployeeSkillMapEntity
        {
            get
            {
                if (_EmployeeSkillMapID > 0)
                {
                    if (_HREmployeeSkillMapEntity.EmployeeSkillMapID != _EmployeeSkillMapID)
                    {
                        _HREmployeeSkillMapEntity = FCCHREmployeeSkillMap.GetFacadeCreate().GetByID(_EmployeeSkillMapID);
                    }
                }

                return _HREmployeeSkillMapEntity;
            }
            set
            {
                _HREmployeeSkillMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDEmployeeSkill(ddlEmployeeSkillID, false);
            MiscUtil.PopulateMDEmployeeCompetencyLevel(ddlEmployeeCompetencyLevelID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeSkillMapEntity hREmployeeSkillMapEntity = CurrentHREmployeeSkillMapEntity;


            if (!hREmployeeSkillMapEntity.IsNew)
            {
                if (ddlEmployeeSkillID.Items.Count > 0 && hREmployeeSkillMapEntity.EmployeeSkillID != null)
                {
                    ddlEmployeeSkillID.SelectedValue = hREmployeeSkillMapEntity.EmployeeSkillID.ToString();
                }

                if (ddlEmployeeCompetencyLevelID.Items.Count > 0 && hREmployeeSkillMapEntity.EmployeeCompetencyLevelID != null)
                {
                    ddlEmployeeCompetencyLevelID.SelectedValue = hREmployeeSkillMapEntity.EmployeeCompetencyLevelID.ToString();
                }

                txtRemarks.Text = hREmployeeSkillMapEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeSkillMapList();
        }

        private void BindHREmployeeSkillMapList()
        {
            lvHREmployeeSkillMap.DataBind();
        }

        private HREmployeeSkillMapEntity BuildHREmployeeSkillMapEntity()
        {
            HREmployeeSkillMapEntity hREmployeeSkillMapEntity = CurrentHREmployeeSkillMapEntity;


            hREmployeeSkillMapEntity.EmployeeID = OverviewEmployeeID;
            if (ddlEmployeeSkillID.Items.Count > 0)
            {
                if (ddlEmployeeSkillID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSkillMapEntity.EmployeeSkillID = Int64.Parse(ddlEmployeeSkillID.SelectedValue);
                }
            }

            if (ddlEmployeeCompetencyLevelID.Items.Count > 0)
            {
                if (ddlEmployeeCompetencyLevelID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeSkillMapEntity.EmployeeCompetencyLevelID = Int64.Parse(ddlEmployeeCompetencyLevelID.SelectedValue);
                }
            }

            hREmployeeSkillMapEntity.Remarks = txtRemarks.Text.Trim();

            return hREmployeeSkillMapEntity;
        }

        private void SaveHREmployeeSkillMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeSkillMapEntity hREmployeeSkillMapEntity = BuildHREmployeeSkillMapEntity();

                    Int64 result = -1;

                    if (hREmployeeSkillMapEntity.IsNew)
                    {
                        result = FCCHREmployeeSkillMap.GetFacadeCreate().Add(hREmployeeSkillMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSkillMapEntity.FLD_NAME_EmployeeSkillMapID, hREmployeeSkillMapEntity.EmployeeSkillMapID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeSkillMap.GetFacadeCreate().Update(hREmployeeSkillMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeSkillMapID = 0;
                        _HREmployeeSkillMapEntity = new HREmployeeSkillMapEntity();
                        PrepareInitialView();
                        BindHREmployeeSkillMapList();

                        if (hREmployeeSkillMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Skill Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Skill Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeSkillMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Skill Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Skill Map Information.", false);
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

        protected void lvHREmployeeSkillMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeSkillMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeSkillMapID);

            if (EmployeeSkillMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeSkillMapID = EmployeeSkillMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSkillMapEntity.FLD_NAME_EmployeeSkillMapID, EmployeeSkillMapID.ToString(), SQLMatchType.Equal);

                        HREmployeeSkillMapEntity hREmployeeSkillMapEntity = new HREmployeeSkillMapEntity();


                        result = FCCHREmployeeSkillMap.GetFacadeCreate().Delete(hREmployeeSkillMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeSkillMapID = 0;
                            _HREmployeeSkillMapEntity = new HREmployeeSkillMapEntity();
                            PrepareInitialView();
                            BindHREmployeeSkillMapList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Skill Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Skill Map.", true);
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

        protected void odsHREmployeeSkillMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeSkillMap." + HREmployeeSkillMapEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeSkillMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeSkillMapID = 0;
            _HREmployeeSkillMapEntity = new HREmployeeSkillMapEntity();
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
