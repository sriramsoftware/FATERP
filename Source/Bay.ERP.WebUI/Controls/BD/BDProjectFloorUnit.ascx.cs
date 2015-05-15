// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 03:04:35




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class BDProjectFloorUnitControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectFloorUnitID
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

        public BDProjectFloorUnitEntity _BDProjectFloorUnitEntity
        {
            get
            {
                BDProjectFloorUnitEntity entity = new BDProjectFloorUnitEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectFloorUnitEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectFloorUnitEntity CurrentBDProjectFloorUnitEntity
        {
            get
            {
                if (_ProjectFloorUnitID > 0)
                {
                    if (_BDProjectFloorUnitEntity.ProjectFloorUnitID != _ProjectFloorUnitID)
                    {
                        _BDProjectFloorUnitEntity = FCCBDProjectFloorUnit.GetFacadeCreate().GetByID(_ProjectFloorUnitID);
                    }
                }

                return _BDProjectFloorUnitEntity;
            }
            set
            {
                _BDProjectFloorUnitEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateMDProjectFloorUnitType(ddlProjectFloorUnitTypeID, false);
            MiscUtil.PopulateMDProjectFloorUnitStatus(ddlProjectFloorUnitStatusID, false);

            BuildProjectFloorByProjectID();

            if (ddlProjectFloorID == null || ddlProjectFloorID.Items.Count == 0)
            {
                pnlProjectFloorUnitContent.Enabled = false;
            }
        }

        private void BuildProjectFloorByProjectID()
        {
           MiscUtil.PopulateBDProjectFloorByProject(ddlProjectFloorID, false,OverviewProjectID);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtProjectFloorUnitName.Text = String.Empty;
            txtUnitArea.Text = "0.00";
            txtTotalArea.Text = "0.00";
            txtFacing.Text = "South or East or north?";
            txtToilet.Text = "0";
            txtKitchen.Text = "0";
            txtParking.Text = "0";
            txtRegisteredArea.Text = "0.00";
            txtBathRoom.Text = "0";
            txtBedRoom.Text = "0";
            txtServantBed.Text = "0";
            txtServantToilet.Text = "0";
            txtCorridor.Text = "0";
            txtTapasGarden.Text = "0";
            txtSwimmingPool.Text = "0";
            txtFoyer.Text = "0";
            txtSittingRoom.Text = "0";
            txtDiningRoom.Text = "0";
            txtPantry.Text = "0";
            txtBreakfastCorner.Text = "0";
            txtStudyRoom.Text = "0";
            txtStudy.Text = "0";
            txtVerandah.Text = "0";
            chkIsIDServiceAvailable.Checked = false;
            chkElectricityService.Checked = false;
            chkCommonGenerator.Checked = false;
            chkWaterSupplyAvailable.Checked = false;
            txtPricePerSft.Text = String.Empty;
            txtAreaPrice.Text = String.Empty;
            txtIDPrice.Text = String.Empty;
            txtAdditionalCharges.Text = String.Empty;
            txtFeatures.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectFloorUnitEntity bDProjectFloorUnitEntity = CurrentBDProjectFloorUnitEntity;


            if (!bDProjectFloorUnitEntity.IsNew)
            {
                BuildProjectFloorByProjectID();

                if (ddlProjectFloorID.Items.Count > 0 && bDProjectFloorUnitEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = bDProjectFloorUnitEntity.ProjectFloorID.ToString();
                }

                if (ddlProjectFloorUnitTypeID.Items.Count > 0 && bDProjectFloorUnitEntity.ProjectFloorUnitTypeID != null)
                {
                    ddlProjectFloorUnitTypeID.SelectedValue = bDProjectFloorUnitEntity.ProjectFloorUnitTypeID.ToString();
                }

                txtProjectFloorUnitName.Text = bDProjectFloorUnitEntity.ProjectFloorUnitName.ToString();
                if (ddlProjectFloorUnitStatusID.Items.Count > 0 && bDProjectFloorUnitEntity.ProjectFloorUnitStatusID != null)
                {
                    ddlProjectFloorUnitStatusID.SelectedValue = bDProjectFloorUnitEntity.ProjectFloorUnitStatusID.ToString();
                }

                txtUnitArea.Text = bDProjectFloorUnitEntity.UnitArea.ToString();
                txtTotalArea.Text = bDProjectFloorUnitEntity.TotalArea.ToString();
                txtRegisteredArea.Text = bDProjectFloorUnitEntity.RegisteredArea.ToString();
                txtFacing.Text = bDProjectFloorUnitEntity.Facing.ToString();
                txtToilet.Text = bDProjectFloorUnitEntity.Toilet.ToString();
                txtKitchen.Text = bDProjectFloorUnitEntity.Kitchen.ToString();
                txtParking.Text = bDProjectFloorUnitEntity.Parking.ToString();
                txtBathRoom.Text = bDProjectFloorUnitEntity.BathRoom.ToString();
                txtBedRoom.Text = bDProjectFloorUnitEntity.BedRoom.ToString();
                txtServantBed.Text = bDProjectFloorUnitEntity.ServantBed.ToString();
                txtServantToilet.Text = bDProjectFloorUnitEntity.ServantToilet.ToString();
                txtCorridor.Text = bDProjectFloorUnitEntity.Corridor.ToString();
                txtTapasGarden.Text = bDProjectFloorUnitEntity.TapasGarden.ToString();
                txtSwimmingPool.Text = bDProjectFloorUnitEntity.SwimmingPool.ToString();
                txtFoyer.Text = bDProjectFloorUnitEntity.Foyer.ToString();
                txtSittingRoom.Text = bDProjectFloorUnitEntity.SittingRoom.ToString();
                txtDiningRoom.Text = bDProjectFloorUnitEntity.DiningRoom.ToString();
                txtPantry.Text = bDProjectFloorUnitEntity.Pantry.ToString();
                txtBreakfastCorner.Text = bDProjectFloorUnitEntity.BreakfastCorner.ToString();
                txtStudyRoom.Text = bDProjectFloorUnitEntity.StudyRoom.ToString();
                txtStudy.Text = bDProjectFloorUnitEntity.Study.ToString();
                txtVerandah.Text =bDProjectFloorUnitEntity.Verandah.ToString();
                chkIsIDServiceAvailable.Checked = bDProjectFloorUnitEntity.IsIDServiceAvailable;
                chkElectricityService.Checked = bDProjectFloorUnitEntity.ElectricityService;
                chkCommonGenerator.Checked = bDProjectFloorUnitEntity.CommonGenerator;
                if (bDProjectFloorUnitEntity.WaterSupplyAvailable != null)
                {
                    chkWaterSupplyAvailable.Checked = Convert.ToBoolean(bDProjectFloorUnitEntity.WaterSupplyAvailable);
                }
                else
                {
                    chkWaterSupplyAvailable.Checked = false;
                }
                txtPricePerSft.Text = bDProjectFloorUnitEntity.PricePerSft.ToString();
                txtAreaPrice.Text = bDProjectFloorUnitEntity.AreaPrice.ToString();
                txtIDPrice.Text = bDProjectFloorUnitEntity.IDPrice.ToString();
                txtAdditionalCharges.Text = bDProjectFloorUnitEntity.AdditionalCharges.ToString();
                txtFeatures.Text = bDProjectFloorUnitEntity.Features.ToString();
                chkIsRemoved.Checked = bDProjectFloorUnitEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectFloorUnitList();
            BindBDProjectFloorUnitFloorwiseList();
        }

        private void BindBDProjectFloorUnitList()
        {
            lvBDProjectFloorUnit.DataBind();
        }

        private void BindBDProjectFloorUnitFloorwiseList()
        {
            lvProjectFloorUnitFloorwise.DataBind();
        }

        private BDProjectFloorUnitEntity BuildBDProjectFloorUnitEntity()
        {
            BDProjectFloorUnitEntity bDProjectFloorUnitEntity = CurrentBDProjectFloorUnitEntity;


            if (ddlProjectFloorID.Items.Count > 0)
            {
                if (ddlProjectFloorID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectFloorUnitEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                }
            }

            if (ddlProjectFloorUnitTypeID.Items.Count > 0)
            {
                if (ddlProjectFloorUnitTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectFloorUnitEntity.ProjectFloorUnitTypeID = Int64.Parse(ddlProjectFloorUnitTypeID.SelectedValue);
                }
            }

            bDProjectFloorUnitEntity.ProjectFloorUnitName = txtProjectFloorUnitName.Text.Trim();
            if (ddlProjectFloorUnitStatusID.Items.Count > 0)
            {
                if (ddlProjectFloorUnitStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectFloorUnitEntity.ProjectFloorUnitStatusID = Int64.Parse(ddlProjectFloorUnitStatusID.SelectedValue);
                }
            }

            if (!txtUnitArea.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.UnitArea = Decimal.Parse(txtUnitArea.Text.Trim());
            }

            if (!txtTotalArea.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.TotalArea = Decimal.Parse(txtTotalArea.Text.Trim());
            }

            bDProjectFloorUnitEntity.Facing = txtFacing.Text.Trim();
            if (!txtToilet.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.Toilet = Decimal.Parse(txtToilet.Text.Trim());
            }

            if (!txtRegisteredArea.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.RegisteredArea = Decimal.Parse(txtRegisteredArea.Text.Trim());
            }
            else
            {
                bDProjectFloorUnitEntity.RegisteredArea = null;
            }

            if (!txtKitchen.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.Kitchen = Decimal.Parse(txtKitchen.Text.Trim());
            }

            if (!txtParking.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.Parking = Decimal.Parse(txtParking.Text.Trim());
            }

            if (!txtBathRoom.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.BathRoom = Decimal.Parse(txtBathRoom.Text.Trim());
            }

            if (!txtBedRoom.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.BedRoom = Decimal.Parse(txtBedRoom.Text.Trim());
            }

            if (!txtServantBed.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.ServantBed = Decimal.Parse(txtServantBed.Text.Trim());
            }

            if (!txtServantToilet.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.ServantToilet = Decimal.Parse(txtServantToilet.Text.Trim());
            }

            if (!txtCorridor.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.Corridor = Decimal.Parse(txtCorridor.Text.Trim());
            }

            if (!txtTapasGarden.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.TapasGarden = Decimal.Parse(txtTapasGarden.Text.Trim());
            }

            if (!txtSwimmingPool.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.SwimmingPool = Decimal.Parse(txtSwimmingPool.Text.Trim());
            }

            if (!txtFoyer.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.Foyer = Decimal.Parse(txtFoyer.Text.Trim());
            }

            if (!txtSittingRoom.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.SittingRoom = Decimal.Parse(txtSittingRoom.Text.Trim());
            }

            if (!txtDiningRoom.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.DiningRoom = Decimal.Parse(txtDiningRoom.Text.Trim());
            }

            if (!txtPantry.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.Pantry = Decimal.Parse(txtPantry.Text.Trim());
            }

            if (!txtBreakfastCorner.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.BreakfastCorner = Decimal.Parse(txtBreakfastCorner.Text.Trim());
            }

            if (!txtStudyRoom.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.StudyRoom = Decimal.Parse(txtStudyRoom.Text.Trim());
            }

            if (!txtStudy.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.Study = Decimal.Parse(txtStudy.Text.Trim());
            }

            if (!txtVerandah.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.Verandah = Decimal.Parse(txtVerandah.Text.Trim());
            }

            bDProjectFloorUnitEntity.IsIDServiceAvailable = chkIsIDServiceAvailable.Checked;

            bDProjectFloorUnitEntity.ElectricityService = chkElectricityService.Checked;

            bDProjectFloorUnitEntity.CommonGenerator = chkCommonGenerator.Checked;

            bDProjectFloorUnitEntity.WaterSupplyAvailable = chkWaterSupplyAvailable.Checked;

            if (!txtPricePerSft.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.PricePerSft = Decimal.Parse(txtPricePerSft.Text.Trim());
            }
            else
            {
                bDProjectFloorUnitEntity.PricePerSft = null;
            }

            if (!txtAreaPrice.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.AreaPrice = Decimal.Parse(txtAreaPrice.Text.Trim());
            }
            else
            {
                bDProjectFloorUnitEntity.AreaPrice = null;
            }

            if (!txtIDPrice.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.IDPrice = Decimal.Parse(txtIDPrice.Text.Trim());
            }
            else
            {
                bDProjectFloorUnitEntity.IDPrice = null;
            }

            if (!txtAdditionalCharges.Text.Trim().IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.AdditionalCharges = Decimal.Parse(txtAdditionalCharges.Text.Trim());
            }
            else
            {
                bDProjectFloorUnitEntity.AdditionalCharges = null;
            }

            #region Civil Image Url

            String CivilImageUrlpath;

            if (fuCivilDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.CivilDrawingImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(bDProjectFloorUnitEntity.CivilDrawingImageUrl)))
                {
                    File.Delete(Server.MapPath(bDProjectFloorUnitEntity.CivilDrawingImageUrl));
                }
                CivilImageUrlpath = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuCivilDrawingImageUrl.FileName;
                fuCivilDrawingImageUrl.SaveAs(Server.MapPath(CivilImageUrlpath));
                bDProjectFloorUnitEntity.CivilDrawingImageUrl = CivilImageUrlpath;
            }

            if (bDProjectFloorUnitEntity.CivilDrawingImageUrl.IsNotNullOrEmpty() && fuCivilDrawingImageUrl.HasFile == false)
            {
                bDProjectFloorUnitEntity.CivilDrawingImageUrl = bDProjectFloorUnitEntity.CivilDrawingImageUrl;
            }

            if (fuCivilDrawingImageUrl.HasFile == false && bDProjectFloorUnitEntity.CivilDrawingImageUrl.IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.CivilDrawingImageUrl = null;
            }

            if (fuCivilDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.CivilDrawingImageUrl.IsNullOrEmpty())
            {
                CivilImageUrlpath = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuCivilDrawingImageUrl.FileName;
                fuCivilDrawingImageUrl.SaveAs(Server.MapPath(CivilImageUrlpath));
                bDProjectFloorUnitEntity.CivilDrawingImageUrl = CivilImageUrlpath;
            }

            #endregion

            #region Electrical Image Url

            String ElectricalDrawingImageUrl;

            if (fuElectricalDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.ElectricalDrawingImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(bDProjectFloorUnitEntity.ElectricalDrawingImageUrl)))
                {
                    File.Delete(Server.MapPath(bDProjectFloorUnitEntity.ElectricalDrawingImageUrl));
                }
                ElectricalDrawingImageUrl = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuElectricalDrawingImageUrl.FileName;
                fuElectricalDrawingImageUrl.SaveAs(Server.MapPath(ElectricalDrawingImageUrl));
                bDProjectFloorUnitEntity.ElectricalDrawingImageUrl = ElectricalDrawingImageUrl;
            }

            if (bDProjectFloorUnitEntity.ElectricalDrawingImageUrl.IsNotNullOrEmpty() && fuElectricalDrawingImageUrl.HasFile == false)
            {
                bDProjectFloorUnitEntity.ElectricalDrawingImageUrl = bDProjectFloorUnitEntity.ElectricalDrawingImageUrl;
            }

            if (fuElectricalDrawingImageUrl.HasFile == false && bDProjectFloorUnitEntity.ElectricalDrawingImageUrl.IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.ElectricalDrawingImageUrl = null;
            }

            if (fuElectricalDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.ElectricalDrawingImageUrl.IsNullOrEmpty())
            {
                ElectricalDrawingImageUrl = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuElectricalDrawingImageUrl.FileName;
                fuElectricalDrawingImageUrl.SaveAs(Server.MapPath(ElectricalDrawingImageUrl));
                bDProjectFloorUnitEntity.ElectricalDrawingImageUrl = ElectricalDrawingImageUrl;
            }

            #endregion

            #region Interior Image Url

            String InteriorDrawingImageUrl;

            if (fuInteriorDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.InteriorDrawingImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(bDProjectFloorUnitEntity.InteriorDrawingImageUrl)))
                {
                    File.Delete(Server.MapPath(bDProjectFloorUnitEntity.InteriorDrawingImageUrl));
                }
                InteriorDrawingImageUrl = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuInteriorDrawingImageUrl.FileName;
                fuInteriorDrawingImageUrl.SaveAs(Server.MapPath(InteriorDrawingImageUrl));
                bDProjectFloorUnitEntity.InteriorDrawingImageUrl = InteriorDrawingImageUrl;
            }

            if (bDProjectFloorUnitEntity.InteriorDrawingImageUrl.IsNotNullOrEmpty() && fuInteriorDrawingImageUrl.HasFile == false)
            {
                bDProjectFloorUnitEntity.InteriorDrawingImageUrl = bDProjectFloorUnitEntity.InteriorDrawingImageUrl;
            }

            if (fuInteriorDrawingImageUrl.HasFile == false && bDProjectFloorUnitEntity.InteriorDrawingImageUrl.IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.InteriorDrawingImageUrl = null;
            }

            if (fuInteriorDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.InteriorDrawingImageUrl.IsNullOrEmpty())
            {
                InteriorDrawingImageUrl = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuInteriorDrawingImageUrl.FileName;
                fuInteriorDrawingImageUrl.SaveAs(Server.MapPath(InteriorDrawingImageUrl));
                bDProjectFloorUnitEntity.InteriorDrawingImageUrl = InteriorDrawingImageUrl;
            }

            #endregion

            #region Mechanical Drawing Image Url

            String MechanicalDrawingImageUrl;
            
            if (fuMechanicalDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.MechanicalDrawingImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(bDProjectFloorUnitEntity.MechanicalDrawingImageUrl)))
                {
                    File.Delete(Server.MapPath(bDProjectFloorUnitEntity.MechanicalDrawingImageUrl));
                }
                MechanicalDrawingImageUrl = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuMechanicalDrawingImageUrl.FileName;
                fuMechanicalDrawingImageUrl.SaveAs(Server.MapPath(MechanicalDrawingImageUrl));
                bDProjectFloorUnitEntity.MechanicalDrawingImageUrl = MechanicalDrawingImageUrl;
            }

            if (bDProjectFloorUnitEntity.MechanicalDrawingImageUrl.IsNotNullOrEmpty() && fuMechanicalDrawingImageUrl.HasFile == false)
            {
                bDProjectFloorUnitEntity.MechanicalDrawingImageUrl = bDProjectFloorUnitEntity.MechanicalDrawingImageUrl;
            }

            if (fuMechanicalDrawingImageUrl.HasFile == false && bDProjectFloorUnitEntity.MechanicalDrawingImageUrl.IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.MechanicalDrawingImageUrl = null;
            }

            if (fuMechanicalDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.MechanicalDrawingImageUrl.IsNullOrEmpty())
            {
                MechanicalDrawingImageUrl = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuMechanicalDrawingImageUrl.FileName;
                fuMechanicalDrawingImageUrl.SaveAs(Server.MapPath(MechanicalDrawingImageUrl));
                bDProjectFloorUnitEntity.MechanicalDrawingImageUrl = MechanicalDrawingImageUrl;
            }

            #endregion

            #region Plumbing Drawing Image Url

            String PlumbingDrawingImageUrlpath;

            if (fuPlumbingDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.PlumbingDrawingImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(bDProjectFloorUnitEntity.PlumbingDrawingImageUrl)))
                {
                    File.Delete(Server.MapPath(bDProjectFloorUnitEntity.PlumbingDrawingImageUrl));
                }
                PlumbingDrawingImageUrlpath = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuPlumbingDrawingImageUrl.FileName;
                fuPlumbingDrawingImageUrl.SaveAs(Server.MapPath(PlumbingDrawingImageUrlpath));
                bDProjectFloorUnitEntity.PlumbingDrawingImageUrl = PlumbingDrawingImageUrlpath;
            }

            if (bDProjectFloorUnitEntity.PlumbingDrawingImageUrl.IsNotNullOrEmpty() && fuPlumbingDrawingImageUrl.HasFile == false)
            {
                bDProjectFloorUnitEntity.PlumbingDrawingImageUrl = bDProjectFloorUnitEntity.PlumbingDrawingImageUrl;
            }

            if (fuPlumbingDrawingImageUrl.HasFile == false && bDProjectFloorUnitEntity.PlumbingDrawingImageUrl.IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.PlumbingDrawingImageUrl = null;
            }

            if (fuPlumbingDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.PlumbingDrawingImageUrl.IsNullOrEmpty())
            {
                PlumbingDrawingImageUrlpath = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuPlumbingDrawingImageUrl.FileName;
                fuPlumbingDrawingImageUrl.SaveAs(Server.MapPath(PlumbingDrawingImageUrlpath));
                bDProjectFloorUnitEntity.PlumbingDrawingImageUrl = PlumbingDrawingImageUrlpath;
            }

            #endregion

            #region Others Drawing Image Url

            String OthersDrawingImageUrlpath;

            if (fuOthersDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.OthersDrawingImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(bDProjectFloorUnitEntity.OthersDrawingImageUrl)))
                {
                    File.Delete(Server.MapPath(bDProjectFloorUnitEntity.OthersDrawingImageUrl));
                }
                OthersDrawingImageUrlpath = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuOthersDrawingImageUrl.FileName;
                fuOthersDrawingImageUrl.SaveAs(Server.MapPath(OthersDrawingImageUrlpath));
                bDProjectFloorUnitEntity.OthersDrawingImageUrl = OthersDrawingImageUrlpath;
            }

            if (bDProjectFloorUnitEntity.OthersDrawingImageUrl.IsNotNullOrEmpty() && fuOthersDrawingImageUrl.HasFile == false)
            {
                bDProjectFloorUnitEntity.OthersDrawingImageUrl = bDProjectFloorUnitEntity.OthersDrawingImageUrl;
            }

            if (fuOthersDrawingImageUrl.HasFile == false && bDProjectFloorUnitEntity.OthersDrawingImageUrl.IsNullOrEmpty())
            {
                bDProjectFloorUnitEntity.OthersDrawingImageUrl = null;
            }

            if (fuOthersDrawingImageUrl.HasFile == true && bDProjectFloorUnitEntity.OthersDrawingImageUrl.IsNullOrEmpty())
            {
                OthersDrawingImageUrlpath = FileUploadConstants.Project.PROJECT_FLOOR_DESIGN + Guid.NewGuid() + fuOthersDrawingImageUrl.FileName;
                fuPlumbingDrawingImageUrl.SaveAs(Server.MapPath(OthersDrawingImageUrlpath));
                bDProjectFloorUnitEntity.OthersDrawingImageUrl = OthersDrawingImageUrlpath;
            }

            #endregion

            bDProjectFloorUnitEntity.Features = txtFeatures.Text.Trim();
            bDProjectFloorUnitEntity.IsRemoved = chkIsRemoved.Checked;


            return bDProjectFloorUnitEntity;
        }

        private void SaveBDProjectFloorUnitEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectFloorUnitEntity bDProjectFloorUnitEntity = BuildBDProjectFloorUnitEntity();

                    Int64 result = -1;

                    if (bDProjectFloorUnitEntity.IsNew)
                    {
                        result = FCCBDProjectFloorUnit.GetFacadeCreate().Add(bDProjectFloorUnitEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorUnitEntity.FLD_NAME_ProjectFloorUnitID, bDProjectFloorUnitEntity.ProjectFloorUnitID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectFloorUnit.GetFacadeCreate().Update(bDProjectFloorUnitEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectFloorUnitID = 0;
                        _BDProjectFloorUnitEntity = new BDProjectFloorUnitEntity();
                        PrepareInitialView();
                        BindBDProjectFloorUnitList();
                        BindBDProjectFloorUnitFloorwiseList();

                        if (bDProjectFloorUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectFloorUnitEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Floor Unit Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Floor Unit Information.", false);
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

        protected void lvBDProjectFloorUnit_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectFloorUnitID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectFloorUnitID);

            if (ProjectFloorUnitID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectFloorUnitID = ProjectFloorUnitID;

                    PrepareEditView();
                    
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorUnitEntity.FLD_NAME_ProjectFloorUnitID, ProjectFloorUnitID.ToString(), SQLMatchType.Equal);

                        BDProjectFloorUnitEntity bDProjectFloorUnitEntity = new BDProjectFloorUnitEntity();


                        result = FCCBDProjectFloorUnit.GetFacadeCreate().Delete(bDProjectFloorUnitEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectFloorUnitID = 0;
                            _BDProjectFloorUnitEntity = new BDProjectFloorUnitEntity();
                            PrepareInitialView();
                            BindBDProjectFloorUnitList();
                            BindBDProjectFloorUnitFloorwiseList();

                            MiscUtil.ShowMessage(lblMessage, "Project Floor Unit has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Floor Unit.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        protected void lvBDProjectFloorUnit_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                BDProjectFloorUnit_DetailedEntity ent = (BDProjectFloorUnit_DetailedEntity)dataItem.DataItem;


                HyperLink hypProjectFloorUnitReport = (HyperLink)e.Item.FindControl("hypProjectFloorUnitReport");
                hypProjectFloorUnitReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "ProjectFloorUnitReport", UrlConstants.OVERVIEW_PROJECTFLOORUNITID, ent.ProjectFloorUnitID.ToString()).ToString();

                hypProjectFloorUnitReport.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsBDProjectFloorUnit_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe_floor = SqlExpressionBuilder.PrepareFilterExpression("BDProjectFloor.ProjectID", OverviewProjectID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe_floor;
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsProjectFloorUnitFloorwise_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorUnitEntity.FLD_NAME_ProjectFloorID, "0", SQLMatchType.Equal);

            if (ddlProjectFloorID != null && ddlProjectFloorID.Items.Count > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorUnitEntity.FLD_NAME_ProjectFloorID, ddlProjectFloorID.SelectedValue, SQLMatchType.Equal);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectFloorUnitEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectFloorUnitID = 0;
            _BDProjectFloorUnitEntity = new BDProjectFloorUnitEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectFloorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindBDProjectFloorUnitFloorwiseList();
        }

        #endregion

        #endregion Event
    }
}
