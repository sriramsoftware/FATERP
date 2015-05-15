// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




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
    public partial class BDProjectUnitLocationControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectUnitLocationID
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

        public BDProjectUnitLocationEntity _BDProjectUnitLocationEntity
        {
            get
            {
                BDProjectUnitLocationEntity entity = new BDProjectUnitLocationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectUnitLocationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectUnitLocationEntity CurrentBDProjectUnitLocationEntity
        {
            get
            {
                if (_ProjectUnitLocationID > 0)
                {
                    if (_BDProjectUnitLocationEntity.ProjectUnitLocationID != _ProjectUnitLocationID)
                    {
                        _BDProjectUnitLocationEntity = FCCBDProjectUnitLocation.GetFacadeCreate().GetByID(_ProjectUnitLocationID);
                    }
                }

                return _BDProjectUnitLocationEntity;
            }
            set
            {
                _BDProjectUnitLocationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateBDProjectFloorUnit(ddlProjectFloorUnitID, true);
            MiscUtil.PopulateMDFloorUnitLocationCategory(ddlFloorUnitLocationCategoryID, false);

            BuildProjectFloorByProjectID();
            BuildProjectFloorUnitByFloor();
        }

        private void BuildProjectFloorByProjectID()
        {
            if (OverviewProjectID > 0)
            {
                MiscUtil.PopulateBDProjectFloorByProject(ddlProjectFloorID, false, OverviewProjectID);
            }
            else
            {
                ddlProjectFloorID.Items.Clear();
            }
        }

        private void BuildProjectFloorUnitByFloor()
        {
            if (ddlProjectFloorID.Items.Count > 0 && ddlProjectFloorID.SelectedValue != "0")
            {
                MiscUtil.PopulateBDProjectFloorUnitByFloor(ddlProjectFloorUnitID, false, Int64.Parse(ddlProjectFloorID.SelectedValue));
            }
            else
            {
                ddlProjectFloorUnitID.Items.Clear();
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtLocation.Text = String.Empty;
            txtNetAreaSft.Text = String.Empty;
            txtGrossAreaSft.Text = String.Empty;
            txtMeasurement.Text = String.Empty;
            txtFacing.Text = String.Empty;
            txtDimension.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtModificationDate.Text = String.Empty;
            txtModificationNote.Text = String.Empty;
            txtSpecialFeatures.Text = String.Empty;
            txtExtra1.Text = String.Empty;
            txtExtra2.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectUnitLocationEntity bDProjectUnitLocationEntity = CurrentBDProjectUnitLocationEntity;


            if (!bDProjectUnitLocationEntity.IsNew)
            {

                BuildProjectFloorByProjectID();

                if (ddlProjectFloorID.Items.Count > 0 && bDProjectUnitLocationEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = bDProjectUnitLocationEntity.ProjectFloorID.ToString();
                }

                BuildProjectFloorUnitByFloor();

                if (ddlProjectFloorUnitID.Items.Count > 0 && bDProjectUnitLocationEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = bDProjectUnitLocationEntity.ProjectFloorUnitID.ToString();
                }

                if (ddlFloorUnitLocationCategoryID.Items.Count > 0 && bDProjectUnitLocationEntity.FloorUnitLocationCategoryID != null)
                {
                    ddlFloorUnitLocationCategoryID.SelectedValue = bDProjectUnitLocationEntity.FloorUnitLocationCategoryID.ToString();
                }

                txtLocation.Text = bDProjectUnitLocationEntity.Name.ToString();
                txtNetAreaSft.Text = bDProjectUnitLocationEntity.NetAreaSft.ToString();
                txtGrossAreaSft.Text = bDProjectUnitLocationEntity.GrossAreaSft.ToString();
                txtMeasurement.Text = bDProjectUnitLocationEntity.Measurement.ToString();
                txtFacing.Text = bDProjectUnitLocationEntity.Facing.ToString();
                txtDimension.Text = bDProjectUnitLocationEntity.Dimension.ToString();
                txtDescription.Text = bDProjectUnitLocationEntity.Description.ToString();
                txtModificationDate.Text = bDProjectUnitLocationEntity.ModificationDate.ToStringDefault();
                txtModificationNote.Text = bDProjectUnitLocationEntity.ModificationNote.ToString();
                txtSpecialFeatures.Text = bDProjectUnitLocationEntity.SpecialFeatures.ToString();
                txtExtra1.Text = bDProjectUnitLocationEntity.Extra1.ToString();
                txtExtra2.Text = bDProjectUnitLocationEntity.Extra2.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectUnitLocationList();
        }

        private void BindBDProjectUnitLocationList()
        {
            lvBDProjectUnitLocation.DataBind();
        }

        private BDProjectUnitLocationEntity BuildBDProjectUnitLocationEntity()
        {
            BDProjectUnitLocationEntity bDProjectUnitLocationEntity = CurrentBDProjectUnitLocationEntity;
            
            bDProjectUnitLocationEntity.ProjectID = OverviewProjectID;

            if (ddlProjectFloorID.Items.Count > 0)
            {
                if (ddlProjectFloorID.SelectedValue == "0")
                {
                    bDProjectUnitLocationEntity.ProjectFloorID = null;
                }
                else
                {
                    bDProjectUnitLocationEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                }
            }

            if (ddlProjectFloorUnitID.Items.Count > 0)
            {
                if (ddlProjectFloorUnitID.SelectedValue == "0")
                {
                    bDProjectUnitLocationEntity.ProjectFloorUnitID = null;
                }
                else
                {
                    bDProjectUnitLocationEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                }
            }

            if (ddlFloorUnitLocationCategoryID.Items.Count > 0)
            {
                if (ddlFloorUnitLocationCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectUnitLocationEntity.FloorUnitLocationCategoryID = Int64.Parse(ddlFloorUnitLocationCategoryID.SelectedValue);
                }
            }

            bDProjectUnitLocationEntity.Name = txtLocation.Text.Trim();
            if (!txtNetAreaSft.Text.Trim().IsNullOrEmpty())
            {
                bDProjectUnitLocationEntity.NetAreaSft = Decimal.Parse(txtNetAreaSft.Text.Trim());
            }
            else
            {
                bDProjectUnitLocationEntity.NetAreaSft = null;
            }

            if (!txtGrossAreaSft.Text.Trim().IsNullOrEmpty())
            {
                bDProjectUnitLocationEntity.GrossAreaSft = Decimal.Parse(txtGrossAreaSft.Text.Trim());
            }
            else
            {
                bDProjectUnitLocationEntity.GrossAreaSft = null;
            }

            bDProjectUnitLocationEntity.Measurement = txtMeasurement.Text.Trim();
            bDProjectUnitLocationEntity.Facing = txtFacing.Text.Trim();
            bDProjectUnitLocationEntity.Dimension = txtDimension.Text.Trim();
            bDProjectUnitLocationEntity.Description = txtDescription.Text.Trim();
            if (txtModificationDate.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectUnitLocationEntity.ModificationDate = MiscUtil.ParseToDateTime(txtModificationDate.Text);
            }
            else
            {
                bDProjectUnitLocationEntity.ModificationDate = null;
            }

            bDProjectUnitLocationEntity.ModificationNote = txtModificationNote.Text.Trim();
            bDProjectUnitLocationEntity.SpecialFeatures = txtSpecialFeatures.Text.Trim();
            bDProjectUnitLocationEntity.Extra1 = txtExtra1.Text.Trim();
            bDProjectUnitLocationEntity.Extra2 = txtExtra2.Text.Trim();

            return bDProjectUnitLocationEntity;
        }

        private void SaveBDProjectUnitLocationEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectUnitLocationEntity bDProjectUnitLocationEntity = BuildBDProjectUnitLocationEntity();

                    Int64 result = -1;

                    if (bDProjectUnitLocationEntity.IsNew)
                    {
                        result = FCCBDProjectUnitLocation.GetFacadeCreate().Add(bDProjectUnitLocationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectUnitLocationEntity.FLD_NAME_ProjectUnitLocationID, bDProjectUnitLocationEntity.ProjectUnitLocationID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectUnitLocation.GetFacadeCreate().Update(bDProjectUnitLocationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectUnitLocationID = 0;
                        _BDProjectUnitLocationEntity = new BDProjectUnitLocationEntity();
                        PrepareInitialView();
                        BindBDProjectUnitLocationList();

                        if (bDProjectUnitLocationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Unit Location Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Unit Location Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectUnitLocationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Unit Location Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Unit Location Information.", false);
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

        protected void lvBDProjectUnitLocation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectUnitLocationID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectUnitLocationID);

            if (ProjectUnitLocationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectUnitLocationID = ProjectUnitLocationID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectUnitLocationEntity.FLD_NAME_ProjectUnitLocationID, ProjectUnitLocationID.ToString(), SQLMatchType.Equal);

                        BDProjectUnitLocationEntity bDProjectUnitLocationEntity = new BDProjectUnitLocationEntity();


                        result = FCCBDProjectUnitLocation.GetFacadeCreate().Delete(bDProjectUnitLocationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectUnitLocationID = 0;
                            _BDProjectUnitLocationEntity = new BDProjectUnitLocationEntity();
                            PrepareInitialView();
                            BindBDProjectUnitLocationList();

                            MiscUtil.ShowMessage(lblMessage, "Project Unit Location has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Unit Location.", true);
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

        protected void odsBDProjectUnitLocation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("BDProjectUnitLocation." + BDProjectUnitLocationEntity.FLD_NAME_ProjectID, OverviewProjectID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectUnitLocationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectUnitLocationID = 0;
            _BDProjectUnitLocationEntity = new BDProjectUnitLocationEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildProjectFloorByProjectID();
            BuildProjectFloorUnitByFloor();
        }

        protected void ddlProjectFloorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildProjectFloorUnitByFloor();
        }

        #endregion

        #endregion Event
    }
}
