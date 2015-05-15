// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.IO;

namespace Bay.ERP.Web.UI
{
    public partial class CRMBuyerBasicInfoControl : BaseControl
    {
        #region Extra

        public String PageBuyerListType { get; set; }
        public Int64 PageAPType { get; set; }

        class CustomerComparer : IEqualityComparer<CRMBuyerInterestedRoomMapEntity>
        {
            public bool Equals(CRMBuyerInterestedRoomMapEntity x, CRMBuyerInterestedRoomMapEntity y)
            {
                return (x.BuyerBasicInfoID.Equals(y.BuyerBasicInfoID) && x.BuyerInterestedRoomCategoryID.Equals(y.BuyerInterestedRoomCategoryID));
            }

            public int GetHashCode(CRMBuyerInterestedRoomMapEntity obj)
            {
                return obj.BuyerInterestedRoomCategoryID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public Int64 _BuyerBasicInfoID
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

        public CRMBuyerBasicInfoEntity _CRMBuyerBasicInfoEntity
        {
            get
            {
                CRMBuyerBasicInfoEntity entity = new CRMBuyerBasicInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMBuyerBasicInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMBuyerBasicInfoEntity CurrentCRMBuyerBasicInfoEntity
        {
            get
            {
                if (_BuyerBasicInfoID > 0)
                {
                    if (_CRMBuyerBasicInfoEntity.BuyerBasicInfoID != _BuyerBasicInfoID)
                    {
                        _CRMBuyerBasicInfoEntity = FCCCRMBuyerBasicInfo.GetFacadeCreate().GetByID(_BuyerBasicInfoID);
                    }
                }

                return _CRMBuyerBasicInfoEntity;
            }
            set
            {
                _CRMBuyerBasicInfoEntity = value;
            }
        }

        public IList<CRMMDBuyerInterestedRoomCategoryEntity> _CurrentCRMMDBuyerInterestedRoomCategoryList
        {
            get
            {
                IList<CRMMDBuyerInterestedRoomCategoryEntity> itemBrandList = null;

                if (ViewState["_CurrentCRMMDBuyerInterestedRoomCategoryList"] != null)
                {
                    itemBrandList = (List<CRMMDBuyerInterestedRoomCategoryEntity>)ViewState["_CurrentCRMMDBuyerInterestedRoomCategoryList"];
                }
                else
                {
                    itemBrandList = new List<CRMMDBuyerInterestedRoomCategoryEntity>();
                }

                return itemBrandList;
            }
            set
            {
                ViewState["_CurrentCRMMDBuyerInterestedRoomCategoryList"] = value;
            }
        }

        public IList<CRMBuyerInterestedRoomMapEntity> _CurrentCRMBuyerInterestedRoomMapEntityList
        {
            get
            {
                IList<CRMBuyerInterestedRoomMapEntity> itemBrandMapList = null;

                if (ViewState["CurrentCRMBuyerInterestedRoomMapEntityList"] != null)
                {
                    itemBrandMapList = (List<CRMBuyerInterestedRoomMapEntity>)ViewState["CurrentCRMBuyerInterestedRoomMapEntityList"];
                }
                else
                {
                    itemBrandMapList = new List<CRMBuyerInterestedRoomMapEntity>();
                }

                return itemBrandMapList;
            }
            set
            {
                ViewState["CurrentCRMBuyerInterestedRoomMapEntityList"] = value;
            }
        }

        public Int64 CurrentemployeeID
        {
            get
            {
                Int64 _employeeID = 0;

                if (ViewState["currentEmployeeID"] != null)
                {
                    Int64.TryParse(ViewState["currentEmployeeID"].ToString(), out _employeeID);
                }

                if (ViewState["currentEmployeeID"] == null)
                {
                    ViewState["currentEmployeeID"] = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    _employeeID = (Int64)ViewState["currentEmployeeID"];
                }

                return _employeeID;
            }
            set
            {
                ViewState["currentEmployeeID"] = value;
            }
        }

        public String Operation
        {
            get
            {
                String _operation = "none";

                if (ViewState["Operation"] != null)
                {
                    _operation=(String)ViewState["Operation"];
                }

                return _operation;
            }
            set
            {
                ViewState["Operation"] = value;
            }
        }

        #endregion

        #region Methods

        private void BindPRMItemBrandMapList()
        {
            String se = SqlExpressionBuilder.PrepareSortExpression(CRMMDBuyerInterestedRoomCategoryEntity.FLD_NAME_Name, SQLSortOrderType.Assending);
            IList<CRMMDBuyerInterestedRoomCategoryEntity> buyerInterestedRoomList = FCCCRMMDBuyerInterestedRoomCategory.GetFacadeCreate().GetIL(null, null, se, String.Empty, DatabaseOperationType.LoadWithSortExpression);
            _CurrentCRMMDBuyerInterestedRoomCategoryList = buyerInterestedRoomList;
            chbxBuyerInterestedRoom.DataSource = buyerInterestedRoomList;

            chbxBuyerInterestedRoom.DataTextField = "Name";
            chbxBuyerInterestedRoom.DataValueField = "BuyerInterestedRoomCategoryID";
            chbxBuyerInterestedRoom.DataBind();
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMMDBuyerType(ddlBuyerTypeID, false);
            MiscUtil.PopulateCRMMDLandLocation(ddlInterestedLandLocationID, true);
            MiscUtil.PopulateMDProjectCategory(ddlInterestedProjectCategoryID, false);
            MiscUtil.PopulateMDCityByCountryID(ddlCityID, true,1);
            MiscUtil.PopulateCRMMDAreaUnit(ddlAreaUnitID, true);
            MiscUtil.PopulateHREmployee(ddlLeadGeneratedByEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlLeadManagedByOneEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlLeadManagedByTwoEmployeeID, true);
            MiscUtil.PopulateBDProject(ddlProspectForProject, true);
            MiscUtil.PopulateCRMMDAdvertiseWay(ddlAdvertiseWayID, true);
        }

        private void PrepareValidator()
        {
            revLandPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtLandPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revLandPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;
            revLandPhoneOffice.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtLandPhoneOffice.MaxLength = ValidationConstants.FieldLength.Phone;
            revLandPhoneOffice.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revFaxNumber.ValidationExpression = ValidationConstants.RegularExpression.FaxNo;
            revFaxNumber.ErrorMessage = ValidationConstants.ErrorMessage.FaxNo;

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;


            revEmail2.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail2.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail2.ErrorMessage = ValidationConstants.ErrorMessage.Email;

        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BindPRMItemBrandMapList();

            txtContactFullName.Text = String.Empty;
            txtCompanyName.Text = String.Empty;
            txtDesignation.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtMobileNo2.Text = String.Empty;
            txtLandPhone.Text = String.Empty;
            txtLandPhoneOffice.Text = String.Empty;
            txtFaxNumber.Text = String.Empty;
            txtPresentAddress.Text = String.Empty;
            txtPresentAddressOffice.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtEmail2.Text = String.Empty;
            txtDOB.Text = String.Empty;
            txtNoOfChildren.Text = String.Empty;
            txtAreaNeededFrom.Text = String.Empty;
            txtAreaNeededTo.Text = String.Empty;
            txtParkingNeeded.Text = String.Empty;
            txtToiletNeeded.Text = String.Empty;
            txtUnitNeeded.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtLeadConversionDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
         

            Int64 currentEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            if (currentEmployeeID > 0)
            {
                if (ddlLeadGeneratedByEmployeeID.Items.Count > 0 && ddlLeadGeneratedByEmployeeID != null)
                {
                    ddlLeadGeneratedByEmployeeID.SelectedValue = currentEmployeeID.ToString();
                }
                if (ddlLeadManagedByOneEmployeeID.Items.Count > 0 && ddlLeadManagedByOneEmployeeID != null)
                {
                    ddlLeadManagedByOneEmployeeID.SelectedValue = currentEmployeeID.ToString();
                }
                if (ddlLeadManagedByTwoEmployeeID.Items.Count > 0 && ddlLeadManagedByTwoEmployeeID != null)
                {
                    ddlLeadManagedByTwoEmployeeID.SelectedValue = currentEmployeeID.ToString();
                }
            }

            if (ddlAreaUnitID.Items.Count > 0 && ddlAreaUnitID != null)
            {
                ddlAreaUnitID.SelectedValue = "1";
            }

            if (PageAPType == MasterDataConstants.CRMMDBuyerType.EXISTING_BUYER)
            {
                pnlEditor.Visible = false;
            }

            btnSubmit.Text = "Save and Add New";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity = CurrentCRMBuyerBasicInfoEntity;


            if (!cRMBuyerBasicInfoEntity.IsNew)
            {
                if (ddlBuyerTypeID.Items.Count > 0 && cRMBuyerBasicInfoEntity.BuyerTypeID != null)
                {
                    ddlBuyerTypeID.SelectedValue = cRMBuyerBasicInfoEntity.BuyerTypeID.ToString();
                }

                txtContactFullName.Text = cRMBuyerBasicInfoEntity.ContactFullName.ToString();
                txtCompanyName.Text = cRMBuyerBasicInfoEntity.CompanyName.ToString();
                txtDesignation.Text = cRMBuyerBasicInfoEntity.Designation.ToString();
                if (ddlInterestedProjectCategoryID.Items.Count > 0 && cRMBuyerBasicInfoEntity.InterestedProjectCategoryID != null)
                {
                    ddlInterestedProjectCategoryID.SelectedValue = cRMBuyerBasicInfoEntity.InterestedProjectCategoryID.ToString();
                }

                txtMobileNo.Text = cRMBuyerBasicInfoEntity.MobileNo.ToString();
                txtMobileNo2.Text = cRMBuyerBasicInfoEntity.MobileNo2.ToString();
                txtLandPhone.Text = cRMBuyerBasicInfoEntity.LandPhone.ToString();
                txtLandPhoneOffice.Text = cRMBuyerBasicInfoEntity.LandPhoneOffice.ToString();
                txtFaxNumber.Text = cRMBuyerBasicInfoEntity.FaxNumber.ToString();
                txtPresentAddress.Text = cRMBuyerBasicInfoEntity.PresentAddress.ToString();
                txtPresentAddressOffice.Text = cRMBuyerBasicInfoEntity.PresentAddressOffice.ToString();
                txtEmail.Text = cRMBuyerBasicInfoEntity.Email.ToString();
                txtEmail2.Text = cRMBuyerBasicInfoEntity.Email2.ToString();
                txtDOB.Text = cRMBuyerBasicInfoEntity.DOB.ToStringDefault();
                txtNoOfChildren.Text = cRMBuyerBasicInfoEntity.NoOfChildren.ToString();
                if (ddlInterestedLandLocationID.Items.Count > 0 && cRMBuyerBasicInfoEntity.InterestedLandLocationID != null)
                {
                    ddlInterestedLandLocationID.SelectedValue = cRMBuyerBasicInfoEntity.InterestedLandLocationID.ToString();
                }

                if (ddlCityID.Items.Count > 0 && cRMBuyerBasicInfoEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = cRMBuyerBasicInfoEntity.CityID.ToString();
                }

                txtAreaNeededFrom.Text = cRMBuyerBasicInfoEntity.AreaNeededFrom.ToString();
                txtAreaNeededTo.Text = cRMBuyerBasicInfoEntity.AreaNeededTo.ToString();
                txtParkingNeeded.Text = cRMBuyerBasicInfoEntity.ParkingNeeded.ToString();
                if (ddlAreaUnitID.Items.Count > 0 && cRMBuyerBasicInfoEntity.AreaUnitID != null)
                {
                    ddlAreaUnitID.SelectedValue = cRMBuyerBasicInfoEntity.AreaUnitID.ToString();
                }

                txtToiletNeeded.Text = cRMBuyerBasicInfoEntity.ToiletNeeded.ToString();
                txtUnitNeeded.Text = cRMBuyerBasicInfoEntity.UnitNeeded.ToString();
                if (ddlAdvertiseWayID.Items.Count > 0 && cRMBuyerBasicInfoEntity.AdvertiseWayID != null)
                {
                    ddlAdvertiseWayID.SelectedValue = cRMBuyerBasicInfoEntity.AdvertiseWayID.ToString();
                }
               
                if (ddlLeadGeneratedByEmployeeID.Items.Count > 0 && cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID != null)
                {
                    ddlLeadGeneratedByEmployeeID.SelectedValue = cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID.ToString();
                }

                if (ddlLeadManagedByOneEmployeeID.Items.Count > 0 && cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID != null)
                {
                    ddlLeadManagedByOneEmployeeID.SelectedValue = cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID.ToString();
                }

                if (ddlLeadManagedByTwoEmployeeID.Items.Count > 0 && cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID != null)
                {
                    ddlLeadManagedByTwoEmployeeID.SelectedValue = cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID.ToString();
                }

                txtLeadConversionDate.Text = cRMBuyerBasicInfoEntity.LeadConversionDate.ToStringDefault();
                if (ddlProspectForProject.Items.Count > 0 && cRMBuyerBasicInfoEntity.ProspectForProject != null)
                {
                    ddlProspectForProject.SelectedValue = cRMBuyerBasicInfoEntity.ProspectForProject.ToString();
                }

                txtRemarks.Text = cRMBuyerBasicInfoEntity.Remarks.ToString();

                String feCurrent = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerInterestedRoomMapEntity.FLD_NAME_BuyerBasicInfoID, cRMBuyerBasicInfoEntity.BuyerBasicInfoID.ToString(), SQLMatchType.Equal);
                IList<CRMBuyerInterestedRoomMapEntity> ItemBrandList = FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().GetIL(null, null, String.Empty, feCurrent, DatabaseOperationType.LoadWithFilterExpression);
                _CurrentCRMBuyerInterestedRoomMapEntityList = ItemBrandList;

                if (ItemBrandList != null && ItemBrandList.Count > 0)
                {

                    foreach (ListItem chbxItem in chbxBuyerInterestedRoom.Items)
                    {
                        var item = (from s in ItemBrandList
                                    where s.BuyerInterestedRoomCategoryID.ToString() == chbxItem.Value
                                    select s).FirstOrDefault();
                        if (item != null && item.BuyerInterestedRoomCategoryID > 0)
                        {
                            chbxItem.Selected = true;
                        }
                        else
                        {
                            chbxItem.Selected = false;
                        }

                    }
                }
                else
                {
                    foreach (ListItem chbxItem in chbxBuyerInterestedRoom.Items)
                    {
                            chbxItem.Selected = false;
                    }
                }
            

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMBuyerBasicInfoList();
        }

        private void BindCRMBuyerBasicInfoList()
        {
            lvCRMBuyerBasicInfo.DataBind();
        }

        private CRMBuyerBasicInfoEntity BuildCRMBuyerBasicInfoEntity()
        {
            CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity = CurrentCRMBuyerBasicInfoEntity;

            if (ddlBuyerTypeID.Items.Count > 0)
            {
                if (ddlBuyerTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerBasicInfoEntity.BuyerTypeID = Int64.Parse(ddlBuyerTypeID.SelectedValue);
                }
            }

            cRMBuyerBasicInfoEntity.ContactFullName = txtContactFullName.Text.Trim();
            cRMBuyerBasicInfoEntity.CompanyName = txtCompanyName.Text.Trim();
            cRMBuyerBasicInfoEntity.Designation = txtDesignation.Text.Trim();

            #region Image

            String ImageUrlpath;

            if (fuImageUrl.HasFile == true && cRMBuyerBasicInfoEntity.ImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(cRMBuyerBasicInfoEntity.ImageUrl)))
                {
                    File.Delete(Server.MapPath(cRMBuyerBasicInfoEntity.ImageUrl));
                }
                ImageUrlpath = FileUploadConstants.CRM.Buyer + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cRMBuyerBasicInfoEntity.ImageUrl = ImageUrlpath;
            }

            if (cRMBuyerBasicInfoEntity.ImageUrl.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                cRMBuyerBasicInfoEntity.ImageUrl = cRMBuyerBasicInfoEntity.ImageUrl;
            }

            if (fuImageUrl.HasFile == false && cRMBuyerBasicInfoEntity.ImageUrl.IsNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.ImageUrl = null;
            }

            if (fuImageUrl.HasFile == true && cRMBuyerBasicInfoEntity.ImageUrl.IsNullOrEmpty())
            {
                ImageUrlpath = FileUploadConstants.CRM.Buyer + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cRMBuyerBasicInfoEntity.ImageUrl = ImageUrlpath;
            }

            #endregion Image

            if (ddlInterestedProjectCategoryID.Items.Count > 0)
            {
                if (ddlInterestedProjectCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerBasicInfoEntity.InterestedProjectCategoryID = Int64.Parse(ddlInterestedProjectCategoryID.SelectedValue);
                }
            }

            cRMBuyerBasicInfoEntity.MobileNo = txtMobileNo.Text.Trim();
            cRMBuyerBasicInfoEntity.MobileNo2 = txtMobileNo2.Text.Trim();
            cRMBuyerBasicInfoEntity.LandPhone = txtLandPhone.Text.Trim();
            cRMBuyerBasicInfoEntity.LandPhoneOffice = txtLandPhoneOffice.Text.Trim();
            cRMBuyerBasicInfoEntity.FaxNumber = txtFaxNumber.Text.Trim();
            cRMBuyerBasicInfoEntity.PresentAddress = txtPresentAddress.Text.Trim();
            cRMBuyerBasicInfoEntity.PresentAddressOffice = txtPresentAddressOffice.Text.Trim();
            cRMBuyerBasicInfoEntity.Email = txtEmail.Text.Trim();
            cRMBuyerBasicInfoEntity.Email2 = txtEmail2.Text.Trim();
            if (txtDOB.Text.Trim().IsNotNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.DOB = MiscUtil.ParseToDateTime(txtDOB.Text);
            }
            else
            {
                cRMBuyerBasicInfoEntity.DOB = null;
            }

            if (!txtNoOfChildren.Text.Trim().IsNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.NoOfChildren = Decimal.Parse(txtNoOfChildren.Text.Trim());
            }
            else
            {
                cRMBuyerBasicInfoEntity.NoOfChildren = null;
            }

            if (ddlInterestedLandLocationID.Items.Count > 0)
            {
                if (ddlInterestedLandLocationID.SelectedValue == "0")
                {
                    cRMBuyerBasicInfoEntity.InterestedLandLocationID = null;
                }
                else
                {
                    cRMBuyerBasicInfoEntity.InterestedLandLocationID = Int64.Parse(ddlInterestedLandLocationID.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                    cRMBuyerBasicInfoEntity.CityID = null;
                }
                else
                {
                    cRMBuyerBasicInfoEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            if (!txtAreaNeededFrom.Text.Trim().IsNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.AreaNeededFrom = Decimal.Parse(txtAreaNeededFrom.Text.Trim());
            }
            else
            {
                cRMBuyerBasicInfoEntity.AreaNeededFrom = null;
            }

            if (!txtAreaNeededTo.Text.Trim().IsNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.AreaNeededTo = Decimal.Parse(txtAreaNeededTo.Text.Trim());
            }
            else
            {
                cRMBuyerBasicInfoEntity.AreaNeededTo = null;
            }

            if (!txtParkingNeeded.Text.Trim().IsNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.ParkingNeeded = Decimal.Parse(txtParkingNeeded.Text.Trim());
            }
            else
            {
                cRMBuyerBasicInfoEntity.ParkingNeeded = null;
            }

            if (ddlAreaUnitID.Items.Count > 0)
            {
                if (ddlAreaUnitID.SelectedValue == "0")
                {
                    cRMBuyerBasicInfoEntity.AreaUnitID = null;
                }
                else
                {
                    cRMBuyerBasicInfoEntity.AreaUnitID = Int64.Parse(ddlAreaUnitID.SelectedValue);
                }
            }

            if (!txtToiletNeeded.Text.Trim().IsNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.ToiletNeeded = Decimal.Parse(txtToiletNeeded.Text.Trim());
            }
            else
            {
                cRMBuyerBasicInfoEntity.ToiletNeeded = null;
            }

            if (!txtUnitNeeded.Text.Trim().IsNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.UnitNeeded = Decimal.Parse(txtUnitNeeded.Text.Trim());
            }
            else
            {
                cRMBuyerBasicInfoEntity.UnitNeeded = null;
            }

            if (ddlAdvertiseWayID.Items.Count > 0)
            {
                if (ddlAdvertiseWayID.SelectedValue == "0")
                {
                    cRMBuyerBasicInfoEntity.AdvertiseWayID = null;
                }
                else
                {
                    cRMBuyerBasicInfoEntity.AdvertiseWayID = Int64.Parse(ddlAdvertiseWayID.SelectedValue);
                }
            }

            if (ddlLeadGeneratedByEmployeeID.Items.Count > 0)
            {
                if (ddlLeadGeneratedByEmployeeID.SelectedValue == "0")
                {
                    cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID = null;
                }
                else
                {
                    cRMBuyerBasicInfoEntity.LeadGeneratedByEmployeeID = Int64.Parse(ddlLeadGeneratedByEmployeeID.SelectedValue);
                }
            }

            if (ddlLeadManagedByOneEmployeeID.Items.Count > 0)
            {
                if (ddlLeadManagedByOneEmployeeID.SelectedValue == "0")
                {
                    cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID = null;
                }
                else
                {
                    cRMBuyerBasicInfoEntity.LeadManagedByOneEmployeeID = Int64.Parse(ddlLeadManagedByOneEmployeeID.SelectedValue);
                }
            }

            if (ddlLeadManagedByTwoEmployeeID.Items.Count > 0)
            {
                if (ddlLeadManagedByTwoEmployeeID.SelectedValue == "0")
                {
                    cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID = null;
                }
                else
                {
                    cRMBuyerBasicInfoEntity.LeadManagedByTwoEmployeeID = Int64.Parse(ddlLeadManagedByTwoEmployeeID.SelectedValue);
                }
            }

            if (txtLeadConversionDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMBuyerBasicInfoEntity.LeadConversionDate = MiscUtil.ParseToDateTime(txtLeadConversionDate.Text);
            }
            else
            {
                cRMBuyerBasicInfoEntity.LeadConversionDate = null;
            }

            if (ddlProspectForProject.Items.Count > 0)
            {
                if (ddlProspectForProject.SelectedValue == "0")
                {
                    cRMBuyerBasicInfoEntity.ProspectForProject = null;
                }
                else
                {
                    cRMBuyerBasicInfoEntity.ProspectForProject = Int64.Parse(ddlProspectForProject.SelectedValue);
                }
            }

            cRMBuyerBasicInfoEntity.Remarks = txtRemarks.Text.Trim();

            Int64 currentEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            if (currentEmployeeID > 0)
            {
                cRMBuyerBasicInfoEntity.CreatedByEmployeeID = currentEmployeeID;
            }

            cRMBuyerBasicInfoEntity.IP = MiscUtil.GetLocalIP();
            cRMBuyerBasicInfoEntity.CreateDate = System.DateTime.Now;

            return cRMBuyerBasicInfoEntity;
        }

        private void SaveCRMBuyerBasicInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity = BuildCRMBuyerBasicInfoEntity();

                    Int64 result = -1;

                    if (cRMBuyerBasicInfoEntity.IsNew)
                    {
                        result = FCCCRMBuyerBasicInfo.GetFacadeCreate().Add(cRMBuyerBasicInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBasicInfoEntity.FLD_NAME_BuyerBasicInfoID, cRMBuyerBasicInfoEntity.BuyerBasicInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMBuyerBasicInfo.GetFacadeCreate().Update(cRMBuyerBasicInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        #region Buyer Interested Room Map

                        try
                        {
                            IList<CRMBuyerInterestedRoomMapEntity> newMappedItems = new List<CRMBuyerInterestedRoomMapEntity>();

                            foreach (ListItem chbxItem in chbxBuyerInterestedRoom.Items)
                            {
                                if (chbxItem.Selected)
                                {
                                    CRMBuyerInterestedRoomMapEntity mDItemMapEntity = new CRMBuyerInterestedRoomMapEntity();
                                    mDItemMapEntity.BuyerBasicInfoID = result;
                                    mDItemMapEntity.BuyerInterestedRoomCategoryID = Int64.Parse(chbxItem.Value.ToString());
                                    newMappedItems.Add(mDItemMapEntity);
                                }
                            }

                            IList<CRMBuyerInterestedRoomMapEntity> deleteList = _CurrentCRMBuyerInterestedRoomMapEntityList.Except(newMappedItems, new CustomerComparer()).ToList();
                            IList<CRMBuyerInterestedRoomMapEntity> addNewList = newMappedItems.Except(_CurrentCRMBuyerInterestedRoomMapEntityList, new CustomerComparer()).ToList();

                            if (deleteList != null && deleteList.Count > 0)
                            {
                                foreach (CRMBuyerInterestedRoomMapEntity ent in deleteList)
                                {
                                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerInterestedRoomMapEntity.FLD_NAME_BuyerBasicInfoID, ent.BuyerBasicInfoID.ToString(), SQLMatchType.Equal);
                                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerInterestedRoomMapEntity.FLD_NAME_BuyerInterestedRoomCategoryID , ent.BuyerInterestedRoomCategoryID.ToString(), SQLMatchType.Equal);
                                    String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                                    FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                                }
                            }

                            if (addNewList != null && addNewList.Count > 0)
                            {
                                foreach (CRMBuyerInterestedRoomMapEntity ent in addNewList)
                                {
                                    FCCCRMBuyerInterestedRoomMap.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
                                }
                            }

                            //MiscUtil.ShowMessage(lblMessage, "Item Brand Map Information has been added successfully.", false);

                            if (Operation == "Communicate")
                            {
                                String navUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMCommunication.aspx", string.Empty, "do", "Sales", UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID, result.ToString()).ToString();
                                Response.Redirect(navUrl);
                            }

                            else if (Operation == "none")
                            {
                                String navUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMBuyerAllottee.aspx", string.Empty, UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID, result.ToString()).ToString();
                                Response.Redirect(navUrl);
                            }

                        }
                        catch (Exception ex)
                        {
                            MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                        }

                        #endregion

                        _BuyerBasicInfoID = 0;
                        Operation = "none";
                        _CRMBuyerBasicInfoEntity = new CRMBuyerBasicInfoEntity();
                        PrepareInitialView();
                        BindCRMBuyerBasicInfoList();
                        BindPRMItemBrandMapList();

                        if (cRMBuyerBasicInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Buyer Basic Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Buyer Basic Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMBuyerBasicInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Buyer Basic Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Buyer Basic Info Information.", false);
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

        protected void lvCRMBuyerBasicInfo_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMBuyerBasicInfo_DetailedEntity ent = (CRMBuyerBasicInfo_DetailedEntity)dataItem.DataItem;
                
                HyperLink hypAlltteeInfo = (HyperLink)e.Item.FindControl("hypAlltteeInfo");
                HyperLink hypBuyerChildrenInfo = (HyperLink)e.Item.FindControl("hypBuyerChildrenInfo");

                hypBuyerChildrenInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMBuyerChildrenInfo.aspx", string.Empty, UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID, ent.BuyerBasicInfoID.ToString()).ToString();
                hypAlltteeInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMBuyerAllottee.aspx", string.Empty, UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID, ent.BuyerBasicInfoID.ToString()).ToString();

                hypAlltteeInfo.Target = "_blank";
                hypBuyerChildrenInfo.Target = "_blank";
            }
        }

        protected void lvCRMBuyerBasicInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BuyerBasicInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out BuyerBasicInfoID);

            if (BuyerBasicInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BuyerBasicInfoID = BuyerBasicInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBasicInfoEntity.FLD_NAME_BuyerBasicInfoID, BuyerBasicInfoID.ToString(), SQLMatchType.Equal);

                        CRMBuyerBasicInfoEntity cRMBuyerBasicInfoEntity = new CRMBuyerBasicInfoEntity();


                        result = FCCCRMBuyerBasicInfo.GetFacadeCreate().Delete(cRMBuyerBasicInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BuyerBasicInfoID = 0;
                            _CRMBuyerBasicInfoEntity = new CRMBuyerBasicInfoEntity();
                            PrepareInitialView();
                            BindCRMBuyerBasicInfoList();

                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Basic Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMBuyer Basic Info.", true);
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

        protected void odsCRMBuyerBasicInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CRMBuyerBasicInfo."+CRMBuyerBasicInfoEntity.FLD_NAME_CreatedByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("CRMBuyerBasicInfo." + CRMBuyerBasicInfoEntity.FLD_NAME_LeadGeneratedByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);

            String fe3 = SqlExpressionBuilder.PrepareFilterExpression("CRMBuyerBasicInfo." + CRMBuyerBasicInfoEntity.FLD_NAME_LeadManagedByOneEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
            String fe4 = SqlExpressionBuilder.PrepareFilterExpression("CRMBuyerBasicInfo." + CRMBuyerBasicInfoEntity.FLD_NAME_LeadManagedByTwoEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);

            String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
            String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe5, SQLJoinType.OR, fe6);

            if (PageAPType == MasterDataConstants.CRMMDBuyerType.EXISTING_BUYER)
            {
                String fe7 = SqlExpressionBuilder.PrepareFilterExpression("CRMBuyerBasicInfo." + CRMBuyerBasicInfoEntity.FLD_NAME_BuyerTypeID, MasterDataConstants.CRMMDBuyerType.EXISTING_BUYER.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe7);
            }

            if (chbxFilter.Checked)
            {
                fe = "((((CRMBuyerBasicInfo.CreatedByEmployeeID = " + CurrentemployeeID + " OR CRMBuyerBasicInfo.LeadGeneratedByEmployeeID = " + CurrentemployeeID + ") and CRMBuyerBasicInfo.CompanyName like '%" + txtSearchText.Text.ToString() + "%') OR ((CRMBuyerBasicInfo.LeadManagedByOneEmployeeID = " + CurrentemployeeID + " OR CRMBuyerBasicInfo.LeadManagedByTwoEmployeeID = " + CurrentemployeeID + ")) and CRMBuyerBasicInfo.ContactFullName like '%"+txtSearchText.Text+"%') )";
                //fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe9);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Operation = "none";
            SaveCRMBuyerBasicInfoEntity();
        }

        protected void btnSubmitAndCommunicate_Click(object sender, EventArgs e)
        {
            Operation = "Communicate";
            SaveCRMBuyerBasicInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BuyerBasicInfoID = 0;
            _CRMBuyerBasicInfoEntity = new CRMBuyerBasicInfoEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
