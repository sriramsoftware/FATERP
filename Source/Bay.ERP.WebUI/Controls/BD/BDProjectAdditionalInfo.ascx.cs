// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    public partial class BDProjectAdditionalInfoControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectAdditionalInfoID
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

        public BDProjectAdditionalInfoEntity _BDProjectAdditionalInfoEntity
        {
            get
            {
                BDProjectAdditionalInfoEntity entity = new BDProjectAdditionalInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectAdditionalInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectAdditionalInfoEntity CurrentBDProjectAdditionalInfoEntity
        {
            get
            {
                if (OverviewProjectID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectAdditionalInfoEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                    IList<BDProjectAdditionalInfoEntity> BDProjectAdditionalInfoList = FCCBDProjectAdditionalInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (BDProjectAdditionalInfoList != null && BDProjectAdditionalInfoList.Count > 0)
                    {
                        _BDProjectAdditionalInfoEntity = BDProjectAdditionalInfoList[0];
                    }
                    else
                    {
                        _BDProjectAdditionalInfoEntity = new BDProjectAdditionalInfoEntity();
                    }
                }

                return _BDProjectAdditionalInfoEntity;
            }
            set
            {
                _BDProjectAdditionalInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {  
            MiscUtil.PopulateMDUnit(ddlTypicalFloorAreaUnitID, true);
            MiscUtil.PopulateMDUnitByUnitID(ddlGroundFloorHeightUnitInFeetID, false, 10030); //feet id
            MiscUtil.PopulateMDUnitByUnitID(ddlGroundFloorHeightUnitInInchID, false, 10036); //Inch id
            MiscUtil.PopulateMDUnitByUnitID(ddlTypicalFloorHeightUnitFeetID, false, 10030); //Feet id
            MiscUtil.PopulateMDUnitByUnitID(ddlTypicalFloorHeightUnitInchID, false, 10036); //Inch id
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtNumberOfStorey.Text = String.Empty;
            txtNumberOfBlock.Text = String.Empty;
            txtTypicalFloorArea.Text = String.Empty;
            txtGCArchieved.Text = "0";
            txtNumberOfBasement.Text = "0";
            txtNumberOfResidentialFloor.Text = String.Empty;
            txtPositionAtBuilding.Text = String.Empty;
            txtNumberOfCommercialFloor.Text = String.Empty;
            txtPositionAtBuildingForCommercial.Text = String.Empty;
            txtNoOfResidentialUnitPerFloor.Text = String.Empty;
            txtFacing.Text = String.Empty;
            txtTotalNumberOfUnit.Text = String.Empty;
            txtNumberOfPenthouse.Text = String.Empty;
            txtNumberOfStair.Text = String.Empty;
            //txtCoolingSystem.Text = String.Empty;
            //txtGeyserSystem.Text = String.Empty;
            txtFacilitiesAtMezzanineFloor.Text = String.Empty;
            txtFacilitiesAtRoofFloor.Text = String.Empty;
            txtApprovalRequired.Text = "0";
            txtGroundFloorHeight.Text = String.Empty;
            txtTypicalFloorHeight.Text = String.Empty;
            txtGroundFloorHeightInch.Text = String.Empty;
            txtTypicalFloorHeightFeet.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity = CurrentBDProjectAdditionalInfoEntity;


            if (!bDProjectAdditionalInfoEntity.IsNew)
            {
                txtNumberOfStorey.Text = bDProjectAdditionalInfoEntity.NumberOfStorey.ToString();
                txtNumberOfBlock.Text = bDProjectAdditionalInfoEntity.NumberOfBlock.ToString();
                txtTypicalFloorArea.Text = bDProjectAdditionalInfoEntity.TypicalFloorArea.ToString();
                if (ddlTypicalFloorAreaUnitID.Items.Count > 0 && bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID != null)
                {
                    ddlTypicalFloorAreaUnitID.SelectedValue = bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID.ToString();
                }

                txtGCArchieved.Text = bDProjectAdditionalInfoEntity.GCArchieved.ToString();
                txtNumberOfBasement.Text = bDProjectAdditionalInfoEntity.NumberOfBasement.ToString();
                txtNumberOfResidentialFloor.Text = bDProjectAdditionalInfoEntity.NumberOfResidentialFloor.ToString();
                txtPositionAtBuilding.Text = bDProjectAdditionalInfoEntity.PositionAtBuilding.ToString();
                txtNumberOfCommercialFloor.Text = bDProjectAdditionalInfoEntity.NumberOfCommercialFloor.ToString();
                txtPositionAtBuildingForCommercial.Text = bDProjectAdditionalInfoEntity.PositionAtBuildingForCommercial.ToString();
                txtNoOfResidentialUnitPerFloor.Text = bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor.ToString();
                txtFacing.Text = bDProjectAdditionalInfoEntity.Facing.ToString();
                txtTotalNumberOfUnit.Text = bDProjectAdditionalInfoEntity.TotalNumberOfUnit.ToString();
                txtNumberOfPenthouse.Text = bDProjectAdditionalInfoEntity.NumberOfPenthouse.ToString();
                txtNumberOfStair.Text = bDProjectAdditionalInfoEntity.NumberOfStair.ToString();

                if (bDProjectAdditionalInfoEntity.CoolingSystem.IsNullOrEmpty())
                {
                    ddlCoolingSystemID.Text = "Please Select";
                }
                else
                {
                    if (ddlCoolingSystemID.Items.Count > 0 && bDProjectAdditionalInfoEntity.CoolingSystem != null)
                    {
                        ddlCoolingSystemID.SelectedValue = bDProjectAdditionalInfoEntity.CoolingSystem.ToString();
                    }
                }

                if (bDProjectAdditionalInfoEntity.GeyserSystem.IsNullOrEmpty())
                {
                    ddlGeyserSystemID.Text = "Please Select";
                }
                else
                {
                    if (ddlGeyserSystemID.Items.Count > 0 && bDProjectAdditionalInfoEntity.GeyserSystem != null)
                    {
                        ddlGeyserSystemID.Text = bDProjectAdditionalInfoEntity.GeyserSystem.ToString();
                    }
                }

                txtFacilitiesAtMezzanineFloor.Text = bDProjectAdditionalInfoEntity.FacilitiesAtMezzanineFloor.ToString();
                txtFacilitiesAtRoofFloor.Text = bDProjectAdditionalInfoEntity.FacilitiesAtRoofFloor.ToString();
                txtApprovalRequired.Text = bDProjectAdditionalInfoEntity.ApprovalRequired.ToString();
                txtGroundFloorHeight.Text = bDProjectAdditionalInfoEntity.GroundFloorHeight.ToString();
                txtTypicalFloorHeight.Text = bDProjectAdditionalInfoEntity.TypicalFloorHeight.ToString();

                txtGroundFloorHeightInch.Text =bDProjectAdditionalInfoEntity.GroundFloorHeightInch.ToString();
                txtTypicalFloorHeightFeet.Text = bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet.ToString();

                if (ddlGroundFloorHeightUnitInFeetID.Items.Count > 0 && bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID != null)
                {
                    if (ddlGroundFloorHeightUnitInFeetID.Items.Count > 0 && bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID != null)
                    {
                        ddlGroundFloorHeightUnitInFeetID.Text = bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID.ToString();
                    }
                }
                else
                {
                    ddlGroundFloorHeightUnitInFeetID.Text = "Please Select";
                }

                if (ddlTypicalFloorHeightUnitInchID.Items.Count > 0 && bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID != null)
                {
                    if (ddlTypicalFloorHeightUnitInchID.Items.Count > 0 && bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID != null)
                    {
                        ddlTypicalFloorHeightUnitInchID.Text = bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID.ToString();
                    }
                }
                else
                {
                    ddlTypicalFloorHeightUnitInchID.Text = "Please Select";
                }

                if (ddlGroundFloorHeightUnitInInchID.Items.Count > 0 && bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID != null)
                {
                    if (ddlGroundFloorHeightUnitInInchID.Items.Count > 0 && bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID != null)
                    {
                        ddlGroundFloorHeightUnitInInchID.Text = bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID.ToString();
                    }
                }
                else
                {
                    ddlGroundFloorHeightUnitInInchID.Text = "Please Select";
                }

                if (ddlTypicalFloorHeightUnitFeetID.Items.Count > 0 && bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID != null)
                {
                    if (ddlTypicalFloorHeightUnitFeetID.Items.Count > 0 && bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID != null)
                    {
                        ddlTypicalFloorHeightUnitFeetID.Text = bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID.ToString();
                    }
                }
                else
                {
                    ddlTypicalFloorHeightUnitFeetID.Text = "Please Select";
                }

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindBDProjectAdditionalInfoList();
        }

        private void BindBDProjectAdditionalInfoList()
        {
           
        }

        private BDProjectAdditionalInfoEntity BuildBDProjectAdditionalInfoEntity()
        {
            BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity = CurrentBDProjectAdditionalInfoEntity;
            
            bDProjectAdditionalInfoEntity.ProjectID = OverviewProjectID;

            if (!txtNumberOfStorey.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.NumberOfStorey = Decimal.Parse(txtNumberOfStorey.Text.Trim());
            }

            if (!txtNumberOfBlock.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.NumberOfBlock = Decimal.Parse(txtNumberOfBlock.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.NumberOfBlock = null;
            }

            if (!txtTypicalFloorArea.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.TypicalFloorArea = Decimal.Parse(txtTypicalFloorArea.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.TypicalFloorArea = null;
            }

            if (ddlTypicalFloorAreaUnitID.Items.Count > 0)
            {
                if (ddlTypicalFloorAreaUnitID.SelectedValue == "0")
                {
                    bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID = null;
                }
                else
                {
                    bDProjectAdditionalInfoEntity.TypicalFloorAreaUnitID = Int64.Parse(ddlTypicalFloorAreaUnitID.SelectedValue);
                }
            }

            if (!txtGCArchieved.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.GCArchieved = Decimal.Parse(txtGCArchieved.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.GCArchieved = null;
            }

            if (!txtNumberOfBasement.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.NumberOfBasement = Decimal.Parse(txtNumberOfBasement.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.NumberOfBasement = null;
            }

            if (!txtNumberOfResidentialFloor.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.NumberOfResidentialFloor = Decimal.Parse(txtNumberOfResidentialFloor.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.NumberOfResidentialFloor = null;
            }

            if (!txtNumberOfCommercialFloor.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.NumberOfCommercialFloor = Decimal.Parse(txtNumberOfCommercialFloor.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.NumberOfCommercialFloor = null;
            }

            if (!txtNoOfResidentialUnitPerFloor.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor = Decimal.Parse(txtNoOfResidentialUnitPerFloor.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.NoOfResidentialUnitPerFloor = null;
            }

            bDProjectAdditionalInfoEntity.Facing = txtFacing.Text.Trim();
            if (!txtTotalNumberOfUnit.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.TotalNumberOfUnit = Decimal.Parse(txtTotalNumberOfUnit.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.TotalNumberOfUnit = null;
            }

            if (!txtNumberOfPenthouse.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.NumberOfPenthouse = Decimal.Parse(txtNumberOfPenthouse.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.NumberOfPenthouse = null;
            }

            if (!txtNumberOfStair.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.NumberOfStair = Decimal.Parse(txtNumberOfStair.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.NumberOfStair = null;
            }

            if (ddlCoolingSystemID.Items.Count > 0)
            {
                if (ddlCoolingSystemID.SelectedValue == "0")
                {
                    bDProjectAdditionalInfoEntity.CoolingSystem = null;
                }
                else
                {
                    bDProjectAdditionalInfoEntity.CoolingSystem = ddlCoolingSystemID.SelectedItem.ToString();
                }
            }

            if (ddlGeyserSystemID.Items.Count > 0)
            {
                if (ddlGeyserSystemID.SelectedValue == "0")
                {
                    bDProjectAdditionalInfoEntity.GeyserSystem = null;
                }
                else
                {
                    bDProjectAdditionalInfoEntity.GeyserSystem = ddlGeyserSystemID.SelectedItem.ToString();
                }
            }

            bDProjectAdditionalInfoEntity.PositionAtBuilding = txtPositionAtBuilding.Text.Trim();
            bDProjectAdditionalInfoEntity.PositionAtBuildingForCommercial = txtPositionAtBuildingForCommercial.Text.Trim();
            bDProjectAdditionalInfoEntity.FacilitiesAtMezzanineFloor = txtFacilitiesAtMezzanineFloor.Text.Trim();
            bDProjectAdditionalInfoEntity.FacilitiesAtRoofFloor = txtFacilitiesAtRoofFloor.Text.Trim();
            bDProjectAdditionalInfoEntity.ApprovalRequired = txtApprovalRequired.Text.Trim();

            if (!txtGroundFloorHeight.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.GroundFloorHeight = Decimal.Parse(txtGroundFloorHeight.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.GroundFloorHeight = null;
            }

            if (!txtTypicalFloorHeight.Text.Trim().IsNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.TypicalFloorHeight = Decimal.Parse(txtTypicalFloorHeight.Text.Trim());
            }
            else
            {
                bDProjectAdditionalInfoEntity.TypicalFloorHeight = null;
            }

            if (ddlGroundFloorHeightUnitInFeetID.Items.Count > 0)
            {
                if (ddlGroundFloorHeightUnitInFeetID.SelectedValue == "0")
                {
                    bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID = null;
                }
                else
                {
                    bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInFeetID = Int64.Parse(ddlGroundFloorHeightUnitInFeetID.SelectedValue);
                }
            }

            if (ddlTypicalFloorHeightUnitInchID.Items.Count > 0)
            {
                if (ddlTypicalFloorHeightUnitInchID.SelectedValue == "0")
                {
                    bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID = null;
                }
                else
                {
                    bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitInchID = Int64.Parse(ddlTypicalFloorHeightUnitInchID.SelectedValue);
                }
            }

            if (txtGroundFloorHeightInch.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.GroundFloorHeightInch = Decimal.Parse(txtGroundFloorHeightInch.Text);
            }
            else
            {
                bDProjectAdditionalInfoEntity.GroundFloorHeightInch = null;
            }

            if (txtTypicalFloorHeightFeet.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet = Decimal.Parse(txtTypicalFloorHeightFeet.Text);
            }
            else
            {
                bDProjectAdditionalInfoEntity.TypicalFloorHeightFeet = null;
            }

            if (ddlGroundFloorHeightUnitInInchID.Items.Count > 0)
            {
                if (ddlGroundFloorHeightUnitInInchID.SelectedValue == "0")
                {
                    bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID = null;
                }
                else
                {
                    bDProjectAdditionalInfoEntity.GroundFloorHeightUnitInInchID = Int64.Parse(ddlGroundFloorHeightUnitInInchID.SelectedValue);
                }
            }

            if (ddlTypicalFloorHeightUnitFeetID.Items.Count > 0)
            {
                if (ddlTypicalFloorHeightUnitFeetID.SelectedValue == "0")
                {
                    bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID = null;
                }
                else
                {
                    bDProjectAdditionalInfoEntity.TypicalFloorHeightUnitFeetID = Int64.Parse(ddlTypicalFloorHeightUnitFeetID.SelectedValue);
                }
            }

            return bDProjectAdditionalInfoEntity;
        }

        private void SaveBDProjectAdditionalInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity = BuildBDProjectAdditionalInfoEntity();

                    Int64 result = -1;

                    if (bDProjectAdditionalInfoEntity.IsNew)
                    {
                        result = FCCBDProjectAdditionalInfo.GetFacadeCreate().Add(bDProjectAdditionalInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectAdditionalInfoEntity.FLD_NAME_ProjectAdditionalInfoID, bDProjectAdditionalInfoEntity.ProjectAdditionalInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectAdditionalInfo.GetFacadeCreate().Update(bDProjectAdditionalInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectAdditionalInfoID = 0;
                        _BDProjectAdditionalInfoEntity = new BDProjectAdditionalInfoEntity();
                        PrepareInitialView();
                        PrepareEditView();
                        BindBDProjectAdditionalInfoList();

                        if (bDProjectAdditionalInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Additional Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Additional Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectAdditionalInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Additional Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Additional Info Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void BuildApprovalNavigation()
        {

            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectID, OverviewProjectID.ToString(), SQLMatchType.Equal);
            IList<BDProjectCollectedDocumentInfoEntity> lstBDProjectCollectedDocumentInfo = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            String navUrl = String.Empty;

            if (lstBDProjectCollectedDocumentInfo != null && lstBDProjectCollectedDocumentInfo.Count > 0)
            {
                navUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectCollectedDocumentInfo.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, OverviewProjectID.ToString()).ToString();
            }
            else
            {
                navUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectCollectedDocumentSetup.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, OverviewProjectID.ToString()).ToString();
            }

            hypApprovalRequired.NavigateUrl = navUrl;
            hypApprovalRequired.Target = "_blank";
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
                BuildApprovalNavigation();
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectAdditionalInfoEntity();
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
