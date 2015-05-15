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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CRMLandBasicInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _LandBasicInfoID
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

        public CRMLandBasicInfoEntity _CRMLandBasicInfoEntity
        {
            get
            {
                CRMLandBasicInfoEntity entity = new CRMLandBasicInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMLandBasicInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMLandBasicInfoEntity CurrentCRMLandBasicInfoEntity
        {
            get
            {
                if (_LandBasicInfoID > 0)
                {
                    if (_CRMLandBasicInfoEntity.LandBasicInfoID != _LandBasicInfoID)
                    {
                        _CRMLandBasicInfoEntity = FCCCRMLandBasicInfo.GetFacadeCreate().GetByID(_LandBasicInfoID);
                    }
                }

                return _CRMLandBasicInfoEntity;
            }
            set
            {
                _CRMLandBasicInfoEntity = value;
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
                    _operation = (String)ViewState["Operation"];
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

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMMDLandOwnerType(ddlLandOwnerTypeID, false);
            MiscUtil.PopulateCRMMDLandLocation(ddlInterestedLandLocationID, false);
            MiscUtil.PopulateMDCityByCountryID(ddlCityID, false,1);
            MiscUtil.PopulateHREmployee(ddlLeadGeneratedByEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlLeadManagedByOneEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlLeadManagedByTwoEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlReferredByEmployeeID, true);
            MiscUtil.PopulateBDProject(ddlLandOwnerOfProject, true);
            MiscUtil.PopulateCRMMDAreaUnit(ddlAreaUnitID1, true);
            MiscUtil.PopulateCRMMDAreaUnit(ddlAreaUnitID2, true);
        }

        private void PrepareValidator()
        {
            revLandPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtLandPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revLandPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;

        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtContactFullName.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtLandPhone.Text = String.Empty;
            txtPresentAddress.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtLandArea1.Text = String.Empty;
            txtLandArea2.Text = String.Empty;
            txtPlotNumber.Text = String.Empty;
            txtPlotAddress.Text = String.Empty;
            txtPlotMapUrl.Content= String.Empty;
            txtArea.Text = String.Empty;
            txtDimension.Text = String.Empty;
            txtSpecialFeatures.Text = String.Empty;
            txtStructure.Text = String.Empty;
            txtRAJUKDetails.Text = String.Empty;
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
                if (ddlReferredByEmployeeID.Items.Count > 0 && ddlReferredByEmployeeID != null)
                {
                    ddlReferredByEmployeeID.SelectedValue = currentEmployeeID.ToString();
                }
            }

            btnSubmit.Text = "Save and Add New";
            btnAddNew.Visible = false;
        }

      
        private void PrepareEditView()
        {
            CRMLandBasicInfoEntity cRMLandBasicInfoEntity = CurrentCRMLandBasicInfoEntity;


            if (!cRMLandBasicInfoEntity.IsNew)
            {
                if (ddlLandOwnerTypeID.Items.Count > 0 && cRMLandBasicInfoEntity.LandOwnerTypeID != null)
                {
                    ddlLandOwnerTypeID.SelectedValue = cRMLandBasicInfoEntity.LandOwnerTypeID.ToString();
                }

                txtContactFullName.Text = cRMLandBasicInfoEntity.ContactFullName.ToString();
                txtMobileNo.Text = cRMLandBasicInfoEntity.MobileNo.ToString();
                txtLandPhone.Text = cRMLandBasicInfoEntity.LandPhone.ToString();
                txtPresentAddress.Text = cRMLandBasicInfoEntity.PresentAddress.ToString();
                txtEmail.Text = cRMLandBasicInfoEntity.Email.ToString();
                if (ddlInterestedLandLocationID.Items.Count > 0 && cRMLandBasicInfoEntity.InterestedLandLocationID != null)
                {
                    ddlInterestedLandLocationID.SelectedValue = cRMLandBasicInfoEntity.InterestedLandLocationID.ToString();
                }

                if (ddlCityID.Items.Count > 0 && cRMLandBasicInfoEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = cRMLandBasicInfoEntity.CityID.ToString();
                }

                //txtLandArea.Text = cRMLandBasicInfoEntity.LandArea1.ToString();
                txtLandArea1.Text = cRMLandBasicInfoEntity.LandArea1.ToString();
                if (ddlAreaUnitID1.Items.Count > 0 && cRMLandBasicInfoEntity.AreaUnitID1 != null)
                {
                    ddlAreaUnitID1.SelectedValue = cRMLandBasicInfoEntity.AreaUnitID1.ToString();
                }

                txtLandArea2.Text = cRMLandBasicInfoEntity.LandArea2.ToString();
                if (ddlAreaUnitID2.Items.Count > 0 && cRMLandBasicInfoEntity.AreaUnitID2 != null)
                {
                    ddlAreaUnitID2.SelectedValue = cRMLandBasicInfoEntity.AreaUnitID2.ToString();
                }
                txtPlotNumber.Text = cRMLandBasicInfoEntity.PlotNumber.ToString();
                txtPlotAddress.Text = cRMLandBasicInfoEntity.PlotAddress.ToString();
                txtPlotMapUrl.Content = cRMLandBasicInfoEntity.PlotMapUrl.ToString();
                txtArea.Text = cRMLandBasicInfoEntity.Area.ToString();
                txtDimension.Text = cRMLandBasicInfoEntity.Dimension.ToString();
                txtSpecialFeatures.Text = cRMLandBasicInfoEntity.SpecialFeatures.ToString();
                txtStructure.Text = cRMLandBasicInfoEntity.Structure.ToString();
                txtRAJUKDetails.Text = cRMLandBasicInfoEntity.RAJUKDetails.ToString();
                if (ddlLeadGeneratedByEmployeeID.Items.Count > 0 && cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID != null)
                {
                    ddlLeadGeneratedByEmployeeID.SelectedValue = cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID.ToString();
                }

                if (ddlLeadManagedByOneEmployeeID.Items.Count > 0 && cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID != null)
                {
                    ddlLeadManagedByOneEmployeeID.SelectedValue = cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID.ToString();
                }

                if (ddlLeadManagedByTwoEmployeeID.Items.Count > 0 && cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID != null)
                {
                    ddlLeadManagedByTwoEmployeeID.SelectedValue = cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID.ToString();
                }

                if (ddlReferredByEmployeeID.Items.Count > 0 && cRMLandBasicInfoEntity.ReferredByEmployeeID != null)
                {
                    ddlReferredByEmployeeID.SelectedValue = cRMLandBasicInfoEntity.ReferredByEmployeeID.ToString();
                }

                if (ddlLandOwnerOfProject.Items.Count > 0 && cRMLandBasicInfoEntity.LandOwnerOfProject != null)
                {
                    ddlLandOwnerOfProject.SelectedValue = cRMLandBasicInfoEntity.LandOwnerOfProject.ToString();
                }

                txtLeadConversionDate.Text = cRMLandBasicInfoEntity.LeadConversionDate.ToStringDefault();
               // txtReferredBy.Text = cRMLandBasicInfoEntity.ReferredBy.ToString();
                //txtLandOwnerOfProject.Text = cRMLandBasicInfoEntity.LandOwnerOfProject.ToString();

                btnSubmit.Text = "Update and Add New";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMLandBasicInfoList();
        }

        private void BindCRMLandBasicInfoList()
        {
            lvCRMLandBasicInfo.DataBind();
        }

        private CRMLandBasicInfoEntity BuildCRMLandBasicInfoEntity()
        {
            CRMLandBasicInfoEntity cRMLandBasicInfoEntity = CurrentCRMLandBasicInfoEntity;

            if (ddlLandOwnerTypeID.Items.Count > 0)
            {
                if (ddlLandOwnerTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMLandBasicInfoEntity.LandOwnerTypeID = Int64.Parse(ddlLandOwnerTypeID.SelectedValue);
                }
            }

            cRMLandBasicInfoEntity.ContactFullName = txtContactFullName.Text.Trim();
            cRMLandBasicInfoEntity.MobileNo = txtMobileNo.Text.Trim();
            cRMLandBasicInfoEntity.LandPhone = txtLandPhone.Text.Trim();
            cRMLandBasicInfoEntity.PresentAddress = txtPresentAddress.Text.Trim();
            cRMLandBasicInfoEntity.Email = txtEmail.Text.Trim();
            if (ddlInterestedLandLocationID.Items.Count > 0)
            {
                if (ddlInterestedLandLocationID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMLandBasicInfoEntity.InterestedLandLocationID = Int64.Parse(ddlInterestedLandLocationID.SelectedValue);
                }
            }

            cRMLandBasicInfoEntity.LandArea1 = txtLandArea1.Text.Trim();
            if (ddlAreaUnitID1.Items.Count > 0)
            {
                if (ddlAreaUnitID1.SelectedValue == "0")
                {
                    cRMLandBasicInfoEntity.AreaUnitID1 = null;
                }
                else
                {
                    cRMLandBasicInfoEntity.AreaUnitID1 = Int64.Parse(ddlAreaUnitID1.SelectedValue);
                }
            }

            cRMLandBasicInfoEntity.LandArea2 = txtLandArea2.Text.Trim();
            if (ddlAreaUnitID2.Items.Count > 0)
            {
                if (ddlAreaUnitID2.SelectedValue == "0")
                {
                    cRMLandBasicInfoEntity.AreaUnitID2 = null;
                }
                else
                {
                    cRMLandBasicInfoEntity.AreaUnitID2 = Int64.Parse(ddlAreaUnitID2.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMLandBasicInfoEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

           // cRMLandBasicInfoEntity.LandArea = txtLandArea.Text.Trim();
            cRMLandBasicInfoEntity.PlotNumber = txtPlotNumber.Text.Trim();
            cRMLandBasicInfoEntity.PlotAddress = txtPlotAddress.Text.Trim();
            cRMLandBasicInfoEntity.PlotMapUrl = txtPlotMapUrl.Content.Trim();
            cRMLandBasicInfoEntity.Area = txtArea.Text.Trim();
            cRMLandBasicInfoEntity.Dimension = txtDimension.Text.Trim();
            cRMLandBasicInfoEntity.SpecialFeatures = txtSpecialFeatures.Text.Trim();
            cRMLandBasicInfoEntity.Structure = txtStructure.Text.Trim();
            cRMLandBasicInfoEntity.RAJUKDetails = txtRAJUKDetails.Text.Trim();
            if (ddlLeadGeneratedByEmployeeID.Items.Count > 0)
            {
                if (ddlLeadGeneratedByEmployeeID.SelectedValue == "0")
                {
                    cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID = null;
                }
                else
                {
                    cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID = Int64.Parse(ddlLeadGeneratedByEmployeeID.SelectedValue);
                }
            }

            if (ddlLeadManagedByOneEmployeeID.Items.Count > 0)
            {
                if (ddlLeadManagedByOneEmployeeID.SelectedValue == "0")
                {
                    cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID = null;
                }
                else
                {
                    cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID = Int64.Parse(ddlLeadManagedByOneEmployeeID.SelectedValue);
                }
            }

            if (ddlLeadManagedByTwoEmployeeID.Items.Count > 0)
            {
                if (ddlLeadManagedByTwoEmployeeID.SelectedValue == "0")
                {
                    cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID = null;
                }
                else
                {
                    cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID = Int64.Parse(ddlLeadManagedByTwoEmployeeID.SelectedValue);
                }
            }

            if (txtLeadConversionDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMLandBasicInfoEntity.LeadConversionDate = MiscUtil.ParseToDateTime(txtLeadConversionDate.Text);
            }
            else
            {
                cRMLandBasicInfoEntity.LeadConversionDate = null;
            }

            if (ddlReferredByEmployeeID.Items.Count > 0)
            {
                if (ddlReferredByEmployeeID.SelectedValue == "0")
                {
                    cRMLandBasicInfoEntity.ReferredByEmployeeID = null;
                }
                else
                {
                    cRMLandBasicInfoEntity.ReferredByEmployeeID = Int64.Parse(ddlReferredByEmployeeID.SelectedValue);
                }
            }

            if (ddlLandOwnerOfProject.Items.Count > 0)
            {
                if (ddlLandOwnerOfProject.SelectedValue == "0")
                {
                    cRMLandBasicInfoEntity.LandOwnerOfProject = null;
                }
                else
                {
                    cRMLandBasicInfoEntity.LandOwnerOfProject = Int64.Parse(ddlLandOwnerOfProject.SelectedValue);
                }
            }

            Int64 currentEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            if (currentEmployeeID > 0)
            {
                cRMLandBasicInfoEntity.CreatedByEmployeeID = currentEmployeeID;
            }

            cRMLandBasicInfoEntity.IP = MiscUtil.GetLocalIP();
            cRMLandBasicInfoEntity.CreateDate = System.DateTime.Now;


            return cRMLandBasicInfoEntity;
        }

        private void SaveCRMLandBasicInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMLandBasicInfoEntity cRMLandBasicInfoEntity = BuildCRMLandBasicInfoEntity();

                    Int64 result = -1;

                    if (cRMLandBasicInfoEntity.IsNew)
                    {
                        result = FCCCRMLandBasicInfo.GetFacadeCreate().Add(cRMLandBasicInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMLandBasicInfoEntity.FLD_NAME_LandBasicInfoID, cRMLandBasicInfoEntity.LandBasicInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMLandBasicInfo.GetFacadeCreate().Update(cRMLandBasicInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _LandBasicInfoID = 0;
                        _CRMLandBasicInfoEntity = new CRMLandBasicInfoEntity();
                        PrepareInitialView();
                        BindCRMLandBasicInfoList();

                        if (Operation == "Communicate")
                        {
                            String navUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMCommunication.aspx", string.Empty, "do", "Land", UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID, result.ToString()).ToString();
                            Response.Redirect(navUrl);
                        }

                        else if (Operation == "none")
                        {
                            String navUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMLandCurrentStatus.aspx", string.Empty, UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID, result.ToString()).ToString();
                            Response.Redirect(navUrl);
                        }

                        if (cRMLandBasicInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Land Basic Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Land Basic Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMLandBasicInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Land Basic Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Land Basic Info Information.", false);
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

        protected void lvCRMLandBasicInfo_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMLandBasicInfo_DetailedEntity ent = (CRMLandBasicInfo_DetailedEntity)dataItem.DataItem;

                HyperLink hypLandOwnerInfo = (HyperLink)e.Item.FindControl("hypLandOwnerInfo");
                HyperLink hypLandCurrentStatus = (HyperLink)e.Item.FindControl("hypLandCurrentStatus");

                hypLandCurrentStatus.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMLandCurrentStatus.aspx", string.Empty, UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID, ent.LandBasicInfoID.ToString()).ToString();
                hypLandOwnerInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMLandOwner.aspx", string.Empty, UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID, ent.LandBasicInfoID.ToString()).ToString();

                hypLandOwnerInfo.Target = "_blank";
                hypLandCurrentStatus.Target = "_blank";
            }
        }

        protected void lvCRMLandBasicInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 LandBasicInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out LandBasicInfoID);

            if (LandBasicInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _LandBasicInfoID = LandBasicInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMLandBasicInfoEntity.FLD_NAME_LandBasicInfoID, LandBasicInfoID.ToString(), SQLMatchType.Equal);

                        CRMLandBasicInfoEntity cRMLandBasicInfoEntity = new CRMLandBasicInfoEntity();


                        result = FCCCRMLandBasicInfo.GetFacadeCreate().Delete(cRMLandBasicInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _LandBasicInfoID = 0;
                            _CRMLandBasicInfoEntity = new CRMLandBasicInfoEntity();
                            PrepareInitialView();
                            BindCRMLandBasicInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Land Basic Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Land Basic Info.", true);
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

        protected void odsCRMLandBasicInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CRMLandBasicInfo." + CRMLandBasicInfoEntity.FLD_NAME_CreatedByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("CRMLandBasicInfo." + CRMLandBasicInfoEntity.FLD_NAME_LeadGeneratedByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);

            String fe3 = SqlExpressionBuilder.PrepareFilterExpression("CRMLandBasicInfo." + CRMLandBasicInfoEntity.FLD_NAME_LeadManagedByOneEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
            String fe4 = SqlExpressionBuilder.PrepareFilterExpression("CRMLandBasicInfo." + CRMLandBasicInfoEntity.FLD_NAME_LeadManagedByTwoEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);
            String fe7 = SqlExpressionBuilder.PrepareFilterExpression("CRMLandBasicInfo." + CRMLandBasicInfoEntity.FLD_NAME_ReferredByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);

            String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
            String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe5, SQLJoinType.OR, fe6);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe7);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Operation = "none";
            SaveCRMLandBasicInfoEntity();
        }

        protected void btnSubmitAndCommunicate_Click(object sender, EventArgs e)
        {
            Operation = "Communicate";
            SaveCRMLandBasicInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LandBasicInfoID = 0;
            _CRMLandBasicInfoEntity = new CRMLandBasicInfoEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnImportInfo_Click(object sender, EventArgs e)
        {
            //DBConnect oDBConnection = new DBConnect();
            //oDBConnection.Select();
            BindList();
        }

        #endregion

        #endregion Event
    }
}
