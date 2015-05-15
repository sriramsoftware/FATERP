// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




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
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class MDAssetControl : BaseControl
    {       
        #region Properties

        public Int64 _AssetID
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

        public MDAssetEntity _MDAssetEntity
        {
            get
            {
                MDAssetEntity entity = new MDAssetEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAssetEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAssetEntity CurrentMDAssetEntity
        {
            get
            {
                if (_AssetID > 0)
                {
                    if (_MDAssetEntity.AssetID != _AssetID)
                    {
                        _MDAssetEntity = FCCMDAsset.GetFacadeCreate().GetByID(_AssetID);
                    }
                }

                return _MDAssetEntity;
            }
            set
            {
                _MDAssetEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        { 
            MiscUtil.PopulateMDUnit(ddlUnitID, true);
            MiscUtil.PopulateMDBrand(ddlBrandID, true);
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, true);
            MiscUtil.PopulateMDAssetOwnerType(ddlAssetOwnerTypeID, false);
            MiscUtil.PopulateBDProject(ddlCurrentLocationProjectID, true);
            MiscUtil.PopulatePRMWorkOrder(ddlWorkOrderID, true);
            MiscUtil.PopulateMDAssetCondition(ddlAssetConditionID, false);
            MiscUtil.PopulateCRMArtist(ddlOwnerReferenceID, true);

            ProjectFloorUnitByProject();
            ProjectFloorUnitLocationByFloor();
        }

        private void ProjectFloorUnitByProject()
        {
            if (ddlCurrentLocationProjectID.Items.Count>0 && ddlCurrentLocationProjectID.SelectedValue != "0")
            {
                MiscUtil.PopulateBDProjectFloorUnitByProject(ddlProjectFloorUnitID, true, Int64.Parse(ddlCurrentLocationProjectID.SelectedValue));
            }
        }

        private void ProjectFloorUnitLocationByFloor()
        {
            if (ddlProjectFloorUnitID.Items.Count>0 && ddlProjectFloorUnitID.SelectedValue != "0")
            {
                MiscUtil.PopulateBDProjectUnitLocationByFloorUnit(ddlProjectUnitLocationID, true, Int64.Parse(ddlProjectFloorUnitID.SelectedValue));
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAssetCode.Text = String.Empty;
            txtAssetName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtNextMaintananceDate.Text = String.Empty;
            txtUsedOrHandeledBy.Text = String.Empty;
            txtInsuranceInformation.Text = String.Empty;
            txtServiceContractInformation.Text = String.Empty;
            txtPrice.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtMedium.Text = String.Empty;
            txtWidth.Text = String.Empty;
            txtHeight.Text = String.Empty;
            txtPresentBookValue.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDAssetEntity mDAssetEntity = CurrentMDAssetEntity;


            if (!mDAssetEntity.IsNew)
            {
                txtAssetCode.Text = mDAssetEntity.AssetCode.ToString();
                txtAssetName.Text = mDAssetEntity.AssetName.ToString();
                if (ddlUnitID.Items.Count > 0 && mDAssetEntity.UnitID != null)
                {
                    ddlUnitID.SelectedValue = mDAssetEntity.UnitID.ToString();
                }

                txtDescription.Text = mDAssetEntity.Description.ToString();
                if (ddlBrandID.Items.Count > 0 && mDAssetEntity.BrandID != null)
                {
                    ddlBrandID.SelectedValue = mDAssetEntity.BrandID.ToString();
                }

                if (ddlSupplierID.Items.Count > 0 && mDAssetEntity.SupplierID != null)
                {
                    ddlSupplierID.SelectedValue = mDAssetEntity.SupplierID.ToString();
                }

                txtNextMaintananceDate.Text = mDAssetEntity.NextMaintananceDate.ToStringDefault();
                txtUsedOrHandeledBy.Text = mDAssetEntity.UsedOrHandeledBy.ToString();

                if (ddlProjectFloorUnitID.Items.Count > 0 && mDAssetEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = mDAssetEntity.ProjectFloorUnitID.ToString();
                }

                if (ddlProjectUnitLocationID.Items.Count > 0 && mDAssetEntity.ProjectUnitLocationID != null)
                {
                    ddlProjectUnitLocationID.SelectedValue = mDAssetEntity.ProjectUnitLocationID.ToString();
                }
                if (ddlAssetOwnerTypeID.Items.Count > 0 && mDAssetEntity.AssetOwnerTypeID != null)
                {
                    ddlAssetOwnerTypeID.SelectedValue = mDAssetEntity.AssetOwnerTypeID.ToString();
                }
                if (ddlOwnerReferenceID.Items.Count > 0 && mDAssetEntity.OwnerReferenceID != null)
                {
                    ddlOwnerReferenceID.SelectedValue = mDAssetEntity.OwnerReferenceID.ToString();
                }

                if (ddlCurrentLocationProjectID.Items.Count > 0 && mDAssetEntity.CurrentLocationProjectID != null)
                {
                    ddlCurrentLocationProjectID.SelectedValue = mDAssetEntity.CurrentLocationProjectID.ToString();
                }

                txtInsuranceInformation.Text = mDAssetEntity.InsuranceInformation.ToString();
                txtServiceContractInformation.Text = mDAssetEntity.ServiceContractInformation.ToString();
                txtPrice.Text = mDAssetEntity.Price.ToString();
                if (ddlWorkOrderID.Items.Count > 0 && mDAssetEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = mDAssetEntity.WorkOrderID.ToString();
                }

                if (ddlAssetConditionID.Items.Count > 0 && mDAssetEntity.AssetConditionID != null)
                {
                    ddlAssetConditionID.SelectedValue = mDAssetEntity.AssetConditionID.ToString();
                }

                txtRemarks.Text = mDAssetEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDAssetEntity.IsRemoved;

                if (mDAssetEntity.Medium.IsNotNullOrEmpty())
                {
                    txtMedium.Text = mDAssetEntity.Medium.ToString();
                }
                else
                {
                    txtMedium.Text = null;
                }
                
                
                txtWidth.Text = mDAssetEntity.Width.ToString();
                txtHeight.Text = mDAssetEntity.Height.ToString();
                txtPresentBookValue.Text = mDAssetEntity.PresentBookValue.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAssetList();
        }

        private void BindMDAssetList()
        {
            
        }

        private void LoadTreeView()
        {
            treeAsset.ReBuildTree();
        }

        private MDAssetEntity BuildMDAssetEntity()
        {
            MDAssetEntity mDAssetEntity = CurrentMDAssetEntity;

            mDAssetEntity.AssetCode = txtAssetCode.Text.Trim();
            mDAssetEntity.AssetName = txtAssetName.Text.Trim();
            if (ddlUnitID.Items.Count > 0)
            {
                if (ddlUnitID.SelectedValue == "0")
                {
                    mDAssetEntity.UnitID = null;
                }
                else
                {
                    mDAssetEntity.UnitID = Int64.Parse(ddlUnitID.SelectedValue);
                }
            }

            mDAssetEntity.Description = txtDescription.Text.Trim();
            if (ddlBrandID.Items.Count > 0)
            {
                if (ddlBrandID.SelectedValue == "0")
                {
                    mDAssetEntity.BrandID = null;
                }
                else
                {
                    mDAssetEntity.BrandID = Int64.Parse(ddlBrandID.SelectedValue);
                }
            }

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                    mDAssetEntity.SupplierID = null;
                }
                else
                {
                    mDAssetEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }

            if (txtNextMaintananceDate.Text.Trim().IsNotNullOrEmpty())
            {
                mDAssetEntity.NextMaintananceDate = MiscUtil.ParseToDateTime(txtNextMaintananceDate.Text);
            }
            else
            {
                mDAssetEntity.NextMaintananceDate = null;
            }

            if (ddlProjectFloorUnitID.Items.Count > 0)
            {
                if (ddlProjectFloorUnitID.SelectedValue == "0")
                {
                    mDAssetEntity.ProjectFloorUnitID = null;
                }
                else
                {
                    mDAssetEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                }
            }

            if (ddlProjectUnitLocationID.Items.Count > 0)
            {
                if (ddlProjectUnitLocationID.SelectedValue == "0")
                {
                    mDAssetEntity.ProjectUnitLocationID = null;
                }
                else
                {
                    mDAssetEntity.ProjectUnitLocationID = Int64.Parse(ddlProjectUnitLocationID.SelectedValue);
                }
            }

            mDAssetEntity.UsedOrHandeledBy = txtUsedOrHandeledBy.Text.Trim();
            if (ddlAssetOwnerTypeID.Items.Count > 0)
            {
                if (ddlAssetOwnerTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    mDAssetEntity.AssetOwnerTypeID = Int64.Parse(ddlAssetOwnerTypeID.SelectedValue);
                }
            }

            if (ddlOwnerReferenceID.Items.Count>0 && ddlOwnerReferenceID.SelectedValue!="0")
            {
                mDAssetEntity.OwnerReferenceID = Int64.Parse(ddlOwnerReferenceID.Text.Trim());
            }
            else
            {
                mDAssetEntity.OwnerReferenceID = null;
            }

            if (ddlCurrentLocationProjectID.Items.Count > 0)
            {
                if (ddlCurrentLocationProjectID.SelectedValue == "0")
                {
                    mDAssetEntity.CurrentLocationProjectID = null;
                }
                else
                {
                    mDAssetEntity.CurrentLocationProjectID = Int64.Parse(ddlCurrentLocationProjectID.SelectedValue);
                }
            }

            mDAssetEntity.InsuranceInformation = txtInsuranceInformation.Text.Trim();
            mDAssetEntity.ServiceContractInformation = txtServiceContractInformation.Text.Trim();
            if (!txtPrice.Text.Trim().IsNullOrEmpty())
            {
                mDAssetEntity.Price = Decimal.Parse(txtPrice.Text.Trim());
            }

            if (ddlWorkOrderID.Items.Count > 0)
            {
                if (ddlWorkOrderID.SelectedValue == "0")
                {
                    mDAssetEntity.WorkOrderID = null;
                }
                else
                {
                    mDAssetEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                }
            }

            if (ddlAssetConditionID.Items.Count > 0)
            {
                if (ddlAssetConditionID.SelectedValue == "0")
                {
                }
                else
                {
                    mDAssetEntity.AssetConditionID = Int64.Parse(ddlAssetConditionID.SelectedValue);
                }
            }

            String imageUrlpath;

            if (fuImageUrl.HasFile == true && mDAssetEntity.ImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(mDAssetEntity.ImageUrl)))
                {
                    File.Delete(Server.MapPath(mDAssetEntity.ImageUrl));
                }
                imageUrlpath = FileUploadConstants.Asset.AssetImageUrl + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(imageUrlpath));
                mDAssetEntity.ImageUrl = imageUrlpath;
            }

            if (mDAssetEntity.ImageUrl.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                mDAssetEntity.ImageUrl = mDAssetEntity.ImageUrl;
            }

            if (fuImageUrl.HasFile == false && mDAssetEntity.ImageUrl.IsNullOrEmpty())
            {
                mDAssetEntity.ImageUrl = null;
            }

            if (fuImageUrl.HasFile == true && mDAssetEntity.ImageUrl.IsNullOrEmpty())
            {
                imageUrlpath = FileUploadConstants.Asset.AssetImageUrl + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(imageUrlpath));
                mDAssetEntity.ImageUrl = imageUrlpath;
            }

            mDAssetEntity.Remarks = txtRemarks.Text.Trim();

            mDAssetEntity.IsRemoved = chkIsRemoved.Checked;

            if (txtMedium.Text.Trim().IsNotNullOrEmpty())
            {
                mDAssetEntity.Medium = txtMedium.Text.ToString().Trim();
            }
            else
            {
                mDAssetEntity.Medium = null;
            }

            if (txtWidth.Text.Trim().IsNotNullOrEmpty())
            {
                mDAssetEntity.Width = Decimal.Parse(txtWidth.Text);
            }
            else
            {
                mDAssetEntity.Width = null;
            }

            if (txtHeight.Text.Trim().IsNotNullOrEmpty())
            {
                mDAssetEntity.Height = Decimal.Parse(txtHeight.Text);
            }
            else
            {
                mDAssetEntity.Height = null;
            }

            if (txtPresentBookValue.Text.Trim().IsNotNullOrEmpty())
            {
                mDAssetEntity.PresentBookValue = Decimal.Parse(txtPresentBookValue.Text);
            }
            else
            {
                mDAssetEntity.PresentBookValue = null;
            }


            return mDAssetEntity;
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeAsset.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item Sub Category.", true);
            }
            else if (treeAsset.SelectedNode.Depth != 1)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item Sub Category.", true);
            }

            return validationResult;
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;

            if (treeAsset.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item.", true);
            }
            else if (treeAsset.SelectedNode.Depth != 2)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item.", true);
            }

            return validationResult;
        }

        private void EditItem()
        {
            Int64 AssetID;

            Int64.TryParse(treeAsset.SelectedValue, out AssetID);

            if (AssetID > 0)
            {
                _AssetID = AssetID;

                PrepareEditView();
            }
        }

        private void DeleteItem()
        {
            Int64 AssetID;

            Int64.TryParse(treeAsset.SelectedValue, out AssetID);

            if (AssetID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetEntity.FLD_NAME_AssetID, AssetID.ToString(), SQLMatchType.Equal);

                    MDAssetEntity mDAssetEntity = new MDAssetEntity();

                    result = FCCMDAsset.GetFacadeCreate().Delete(mDAssetEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _AssetID = 0;
                        _MDAssetEntity = new MDAssetEntity();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Item has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Item.", true);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void SaveMDAssetEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAssetEntity mDAssetEntity = BuildMDAssetEntity();

                    Boolean addInputValidation = true;

                    Int64 result = -1;

                    if (mDAssetEntity.IsNew)
                    {
                        if (ValidateInput())
                        {
                            if (treeAsset.SelectedNode != null)
                            {
                                mDAssetEntity.AssetCateogryID = Int64.Parse(treeAsset.SelectedValue);
                            }

                            result = FCCMDAsset.GetFacadeCreate().Add(mDAssetEntity, DatabaseOperationType.Add, TransactionRequired.No);

                            if(ViewState["PushToStore"]!=null)
                            {
                                //INVManager.AddItemsToStoreUnit(result, brandID, regionID, countryID, "", receiveQty, MiscUtil.GetLocalIP(), _employeeID, _rate, lstprmMaterialReceive[0].RequisitionNo.ToString(), lstprmMaterialReceive[0].WorkOrderNo.ToString(), lstprmMaterialReceive[0].MaterialReceiveID.ToString(), "", lstprmMaterialReceive[0].ProjectID, storeID, storeUnitID);
                            }
                        }
                        else
                        {
                            addInputValidation = false;
                        }
                      
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAssetEntity.FLD_NAME_AssetID, mDAssetEntity.AssetID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAsset.GetFacadeCreate().Update(mDAssetEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AssetID = 0;
                        _MDAssetEntity = new MDAssetEntity();
                        PrepareInitialView();
                        LoadTreeView();

                        if (mDAssetEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Asset Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Asset Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAssetEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Asset Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Asset Information.", false);
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

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsMDAsset_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAssetEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AssetID = 0;
            _MDAssetEntity = new MDAssetEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnPushToStore_Click(object sender, EventArgs e)
        {

            
        }

        protected void lnkBtnEditAsset_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                EditItem();
            }
        }

        protected void lnkBtnremoveAsset_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                DeleteItem();
            }
        }

        protected void lnkBtnAdvanceSearch_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl("~/Common/CMNAdvanceSearch.aspx", string.Empty, "do", AdvanceSearchConstants.SearchConstants.ITEM_ADVANCE_SEARCH, "EntityName", AdvanceSearchConstants.EntityConstants.ITEM_CUSTOM_ENTITY).ToString();
            Helper.Response.Redirect(navUrl);
        }

        #endregion

        #region Dropdown Event

        protected void ddlCurrentLocationProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectFloorUnitByProject();
        }
        protected void ddlProjectFloorUnitID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectFloorUnitLocationByFloor();
        }

        #endregion

        #endregion Event
    }
}
