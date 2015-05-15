// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




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
    public partial class BDProjectAssignedPersonControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectAssignedPersonID
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

        public BDProjectAssignedPersonEntity _BDProjectAssignedPersonEntity
        {
            get
            {
                BDProjectAssignedPersonEntity entity = new BDProjectAssignedPersonEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectAssignedPersonEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectAssignedPersonEntity CurrentBDProjectAssignedPersonEntity
        {
            get
            {
                if (_ProjectAssignedPersonID > 0)
                {
                    if (_BDProjectAssignedPersonEntity.ProjectAssignedPersonID != _ProjectAssignedPersonID)
                    {
                        _BDProjectAssignedPersonEntity = FCCBDProjectAssignedPerson.GetFacadeCreate().GetByID(_ProjectAssignedPersonID);
                    }
                }

                return _BDProjectAssignedPersonEntity;
            }
            set
            {
                _BDProjectAssignedPersonEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);

            if (OverviewProjectID > 0)
            {
                ddlProjectID.SelectedValue = OverviewProjectID.ToString();
                ddlProjectID.Enabled = false;
            }
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateMDProjectAssignedPersonTeamRole(ddlProjectAssignedPersonTeamRoleID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDescription.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity = CurrentBDProjectAssignedPersonEntity;


            if (!bDProjectAssignedPersonEntity.IsNew)
            {
                if (OverviewProjectID <= 0)
                {
                    if (ddlProjectID.Items.Count > 0 && bDProjectAssignedPersonEntity.ProjectID != null)
                    {
                        ddlProjectID.SelectedValue = bDProjectAssignedPersonEntity.ProjectID.ToString();
                    }
                }
                if (ddlEmployeeID.Items.Count > 0 && bDProjectAssignedPersonEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = bDProjectAssignedPersonEntity.EmployeeID.ToString();
                }

                if (ddlProjectAssignedPersonTeamRoleID.Items.Count > 0 && bDProjectAssignedPersonEntity.ProjectAssignedPersonTeamRoleID != null)
                {
                    ddlProjectAssignedPersonTeamRoleID.SelectedValue = bDProjectAssignedPersonEntity.ProjectAssignedPersonTeamRoleID.ToString();
                }

                txtDescription.Text = bDProjectAssignedPersonEntity.Description.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectAssignedPersonList();
        }

        private void BindBDProjectAssignedPersonList()
        {
            lvBDProjectAssignedPerson.DataBind();
        }

        private BDProjectAssignedPersonEntity BuildBDProjectAssignedPersonEntity()
        {
            BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity = CurrentBDProjectAssignedPersonEntity;

            if (OverviewProjectID>0)
            {
                bDProjectAssignedPersonEntity.ProjectID = this.OverviewProjectID;
            }
            else
            {
                bDProjectAssignedPersonEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
            }
            
            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectAssignedPersonEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (ddlProjectAssignedPersonTeamRoleID.Items.Count > 0)
            {
                if (ddlProjectAssignedPersonTeamRoleID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectAssignedPersonEntity.ProjectAssignedPersonTeamRoleID = Int64.Parse(ddlProjectAssignedPersonTeamRoleID.SelectedValue);
                }
            }

            bDProjectAssignedPersonEntity.Description = txtDescription.Text.Trim();

            return bDProjectAssignedPersonEntity;
        }

        private void SaveBDProjectAssignedPersonEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity = BuildBDProjectAssignedPersonEntity();

                    Int64 result = -1;

                    if (bDProjectAssignedPersonEntity.IsNew)
                    {
                        result = FCCBDProjectAssignedPerson.GetFacadeCreate().Add(bDProjectAssignedPersonEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectAssignedPersonEntity.FLD_NAME_ProjectAssignedPersonID, bDProjectAssignedPersonEntity.ProjectAssignedPersonID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectAssignedPerson.GetFacadeCreate().Update(bDProjectAssignedPersonEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectAssignedPersonID = 0;
                        _BDProjectAssignedPersonEntity = new BDProjectAssignedPersonEntity();
                        PrepareInitialView();
                        BindBDProjectAssignedPersonList();

                        if (bDProjectAssignedPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Assigned Person Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Assigned Person Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectAssignedPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Assigned Person Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Assigned Person Information.", false);
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

        protected void lvBDProjectAssignedPerson_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectAssignedPersonID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectAssignedPersonID);

            if (ProjectAssignedPersonID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectAssignedPersonID = ProjectAssignedPersonID;

                    PrepareEditView();

                   
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectAssignedPersonEntity.FLD_NAME_ProjectAssignedPersonID, ProjectAssignedPersonID.ToString(), SQLMatchType.Equal);

                        BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity = new BDProjectAssignedPersonEntity();


                        result = FCCBDProjectAssignedPerson.GetFacadeCreate().Delete(bDProjectAssignedPersonEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectAssignedPersonID = 0;
                            _BDProjectAssignedPersonEntity = new BDProjectAssignedPersonEntity();
                            PrepareInitialView();
                            BindBDProjectAssignedPersonList();

                            MiscUtil.ShowMessage(lblMessage, "Project Assigned Person has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Assigned Person.", true);
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

        protected void odsBDProjectAssignedPerson_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (OverviewProjectID > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("BDProjectAssignedPerson." + BDProjectAssignedPersonEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectAssignedPersonEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectAssignedPersonID = 0;
            _BDProjectAssignedPersonEntity = new BDProjectAssignedPersonEntity();
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
