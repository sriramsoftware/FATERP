// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-May-2015, 10:52:28




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
    public partial class BDProjectControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectID
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

        public BDProjectEntity _BDProjectEntity
        {
            get
            {
                BDProjectEntity entity = new BDProjectEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectEntity CurrentBDProjectEntity
        {
            get
            {
                if (_ProjectID > 0)
                {
                    if (_BDProjectEntity.ProjectID != _ProjectID)
                    {
                        _BDProjectEntity = FCCBDProject.GetFacadeCreate().GetByID(_ProjectID);
                    }
                }

                return _BDProjectEntity;
            }
            set
            {
                _BDProjectEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            // MiscUtil.PopulateBDOperator(ddlOperatorID, false);
            // MiscUtil.PopulateMDZone(ddlZoneID, false);
            MiscUtil.PopulateMDUnit(ddlRoadWidthUnitID, true);
            MiscUtil.PopulateMDProjectCategory(ddlProjectCategoryID, false);
            MiscUtil.PopulateMDProjectStatus(ddlProjectStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtProjectCode.Text = String.Empty;
            txtProjectName.Text = String.Empty;
            txtLandAreaKatha.Text = String.Empty;
            txtLandAreaSft.Text = String.Empty;
            txtRoadWidth.Text = String.Empty;
            txtNoOfStoried.Text = String.Empty;
            txtNoOfBasement.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtBSC.Text = String.Empty;
            txtClientPercentage.Text = String.Empty;
            txtCompanyPercentage.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectEntity bDProjectEntity = CurrentBDProjectEntity;


            if (!bDProjectEntity.IsNew)
            {
                if (ddlOperatorID.Items.Count > 0 && bDProjectEntity.OperatorID != null)
                {
                    ddlOperatorID.SelectedValue = bDProjectEntity.OperatorID.ToString();
                }

                if (ddlZoneID.Items.Count > 0 && bDProjectEntity.ZoneID != null)
                {
                    ddlZoneID.SelectedValue = bDProjectEntity.ZoneID.ToString();
                }

                txtProjectCode.Text = bDProjectEntity.ProjectCode.ToString();
                txtProjectName.Text = bDProjectEntity.ProjectName.ToString();
                txtLandAreaKatha.Text = bDProjectEntity.LandAreaKatha.ToString();
                txtLandAreaSft.Text = bDProjectEntity.LandAreaSft.ToString();
                txtRoadWidth.Text = bDProjectEntity.RoadWidth.ToString();
                if (ddlRoadWidthUnitID.Items.Count > 0 && bDProjectEntity.RoadWidthUnitID != null)
                {
                    ddlRoadWidthUnitID.SelectedValue = bDProjectEntity.RoadWidthUnitID.ToString();
                }

                txtNoOfStoried.Text = bDProjectEntity.NoOfStoried.ToString();
                txtNoOfBasement.Text = bDProjectEntity.NoOfBasement.ToString();
                txtDescription.Text = bDProjectEntity.Description.ToString();
                txtBSC.Text = bDProjectEntity.BSC.ToString();
                txtClientPercentage.Text = bDProjectEntity.ClientPercentage.ToString();
                txtCompanyPercentage.Text = bDProjectEntity.CompanyPercentage.ToString();
                if (ddlProjectCategoryID.Items.Count > 0 && bDProjectEntity.ProjectCategoryID != null)
                {
                    ddlProjectCategoryID.SelectedValue = bDProjectEntity.ProjectCategoryID.ToString();
                }

                if (ddlProjectStatusID.Items.Count > 0 && bDProjectEntity.ProjectStatusID != null)
                {
                    ddlProjectStatusID.SelectedValue = bDProjectEntity.ProjectStatusID.ToString();
                }

                chkIsRemoved.Checked = bDProjectEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectList();
        }

        private void BindBDProjectList()
        {
            lvBDProject.DataBind();
        }

        private BDProjectEntity BuildBDProjectEntity()
        {
            BDProjectEntity bDProjectEntity = CurrentBDProjectEntity;

            if (ddlOperatorID.Items.Count > 0)
            {
                if (ddlOperatorID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectEntity.OperatorID = Int64.Parse(ddlOperatorID.SelectedValue);
                }
            }

            if (ddlZoneID.Items.Count > 0)
            {
                if (ddlZoneID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectEntity.ZoneID = Int64.Parse(ddlZoneID.SelectedValue);
                }
            }

            bDProjectEntity.ProjectCode = txtProjectCode.Text.Trim();
            bDProjectEntity.ProjectName = txtProjectName.Text.Trim();
            if (!txtLandAreaKatha.Text.Trim().IsNullOrEmpty())
            {
                bDProjectEntity.LandAreaKatha = Decimal.Parse(txtLandAreaKatha.Text.Trim());
            }
            else
            {
                bDProjectEntity.LandAreaKatha = null;
            }

            if (!txtLandAreaSft.Text.Trim().IsNullOrEmpty())
            {
                bDProjectEntity.LandAreaSft = Decimal.Parse(txtLandAreaSft.Text.Trim());
            }
            else
            {
                bDProjectEntity.LandAreaSft = null;
            }

            if (!txtRoadWidth.Text.Trim().IsNullOrEmpty())
            {
                bDProjectEntity.RoadWidth = Decimal.Parse(txtRoadWidth.Text.Trim());
            }
            else
            {
                bDProjectEntity.RoadWidth = null;
            }

            if (ddlRoadWidthUnitID.Items.Count > 0)
            {
                if (ddlRoadWidthUnitID.SelectedValue == "0")
                {
                    bDProjectEntity.RoadWidthUnitID = null;
                }
                else
                {
                    bDProjectEntity.RoadWidthUnitID = Int64.Parse(ddlRoadWidthUnitID.SelectedValue);
                }
            }

            if (!txtNoOfStoried.Text.Trim().IsNullOrEmpty())
            {
                bDProjectEntity.NoOfStoried = Int32.Parse(txtNoOfStoried.Text.Trim());
            }
            else
            {
                bDProjectEntity.NoOfStoried = null;
            }

            if (!txtNoOfBasement.Text.Trim().IsNullOrEmpty())
            {
                bDProjectEntity.NoOfBasement = Int32.Parse(txtNoOfBasement.Text.Trim());
            }
            else
            {
                bDProjectEntity.NoOfBasement = null;
            }

            bDProjectEntity.Description = txtDescription.Text.Trim();
            bDProjectEntity.BSC = txtBSC.Text.Trim();
            if (!txtClientPercentage.Text.Trim().IsNullOrEmpty())
            {
                bDProjectEntity.ClientPercentage = Decimal.Parse(txtClientPercentage.Text.Trim());
            }
            else
            {
                bDProjectEntity.ClientPercentage = null;
            }

            if (!txtCompanyPercentage.Text.Trim().IsNullOrEmpty())
            {
                bDProjectEntity.CompanyPercentage = Decimal.Parse(txtCompanyPercentage.Text.Trim());
            }
            else
            {
                bDProjectEntity.CompanyPercentage = null;
            }

            if (ddlProjectCategoryID.Items.Count > 0)
            {
                if (ddlProjectCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectEntity.ProjectCategoryID = Int64.Parse(ddlProjectCategoryID.SelectedValue);
                }
            }

            if (ddlProjectStatusID.Items.Count > 0)
            {
                if (ddlProjectStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectEntity.ProjectStatusID = Int64.Parse(ddlProjectStatusID.SelectedValue);
                }
            }

            bDProjectEntity.IsRemoved = chkIsRemoved.Checked;


            return bDProjectEntity;
        }

        private void SaveBDProjectEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectEntity bDProjectEntity = BuildBDProjectEntity();

                    Int64 result = -1;

                    if (bDProjectEntity.IsNew)
                    {
                        result = FCCBDProject.GetFacadeCreate().Add(bDProjectEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectEntity.FLD_NAME_ProjectID, bDProjectEntity.ProjectID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProject.GetFacadeCreate().Update(bDProjectEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectID = 0;
                        _BDProjectEntity = new BDProjectEntity();
                        PrepareInitialView();
                        BindBDProjectList();

                        if (bDProjectEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Information.", false);
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

        protected void lvBDProject_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectID);

            if (ProjectID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectID = ProjectID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectEntity.FLD_NAME_ProjectID, ProjectID.ToString(), SQLMatchType.Equal);

                        BDProjectEntity bDProjectEntity = new BDProjectEntity();


                        result = FCCBDProject.GetFacadeCreate().Delete(bDProjectEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectID = 0;
                            _BDProjectEntity = new BDProjectEntity();
                            PrepareInitialView();
                            BindBDProjectList();

                            MiscUtil.ShowMessage(lblMessage, "Project has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project.", true);
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

        protected void odsBDProject_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectID = 0;
            _BDProjectEntity = new BDProjectEntity();
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
