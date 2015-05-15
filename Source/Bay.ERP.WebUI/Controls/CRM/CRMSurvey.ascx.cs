// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




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
    public partial class CRMSurveyControl : BaseControl
    {       
        #region Properties

        public Int64 _SurveyID
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

        public CRMSurveyEntity _CRMSurveyEntity
        {
            get
            {
                CRMSurveyEntity entity = new CRMSurveyEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMSurveyEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMSurveyEntity CurrentCRMSurveyEntity
        {
            get
            {
                if (_SurveyID > 0)
                {
                    if (_CRMSurveyEntity.SurveyID != _SurveyID)
                    {
                        _CRMSurveyEntity = FCCCRMSurvey.GetFacadeCreate().GetByID(_SurveyID);
                    }
                }

                return _CRMSurveyEntity;
            }
            set
            {
                _CRMSurveyEntity = value;
            }
        }


        public Int64 OverviewSurveryMasterID
        {
            get
            {
                Int64 overviewSurveryMasterID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_MASTER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_MASTER_ID], out overviewSurveryMasterID);
                }

                return overviewSurveryMasterID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMSurveyOwner(ddlSurveyOwnerID, false);
            MiscUtil.PopulateMDArea(ddlAreaID, false);
            MiscUtil.PopulateCRMMDAreaUnit(ddlAreaUnitID, false);
            MiscUtil.PopulateMDSurveyBuildingStatus(ddlSurveyBuildingStatusID, false);
            MiscUtil.PopulateMDSurveySourceInformation(ddlSurveySourceInformationID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDescription.Text = String.Empty;
            txtPlotAddress.Text = String.Empty;
            txtApproximatePlotSize.Text = String.Empty;
            txtApproximateFloorSizeSft.Text = String.Empty;
            txtFloors.Text = String.Empty;
            txtApproximateTotalSpaceSft.Text = String.Empty;
            txtBasements.Text = String.Empty;
            txtNoOfCarParking.Text = String.Empty;
            txtACSystem.Text = String.Empty;
            txtGeneratorBackup.Text = String.Empty;
            txtLiftsCapacity.Text = String.Empty;
            txtToiletsPerFloor.Text = String.Empty;
            txtAvailableFloorSft.Text = String.Empty;
            txtAvailableForOccupancy.Text = String.Empty;
            txtRentalRateBDTPerSft.Text = String.Empty;
            txtSellingRateBDTPerSft.Text = String.Empty;
            txtHandoverTime.Text = String.Empty;
            txtSourcePersonInformation.Text = String.Empty;
            txtContactInfo.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtAdditionalRemarks.Text = String.Empty;
            txtOthersRemarks.Text = String.Empty;
            txtSurveyDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMSurveyEntity cRMSurveyEntity = CurrentCRMSurveyEntity;


            if (!cRMSurveyEntity.IsNew)
            {

                if (ddlSurveyOwnerID.Items.Count > 0 && cRMSurveyEntity.SurveyOwnerID != null)
                {
                    ddlSurveyOwnerID.SelectedValue = cRMSurveyEntity.SurveyOwnerID.ToString();
                }

                if (ddlAreaID.Items.Count > 0 && cRMSurveyEntity.AreaID != null)
                {
                    ddlAreaID.SelectedValue = cRMSurveyEntity.AreaID.ToString();
                }

                txtDescription.Text = cRMSurveyEntity.Description.ToString();
                txtPlotAddress.Text = cRMSurveyEntity.PlotAddress.ToString();
                txtApproximatePlotSize.Text = cRMSurveyEntity.ApproximatePlotSize.ToString();
                if (ddlAreaUnitID.Items.Count > 0 && cRMSurveyEntity.AreaUnitID != null)
                {
                    ddlAreaUnitID.SelectedValue = cRMSurveyEntity.AreaUnitID.ToString();
                }

                txtApproximateFloorSizeSft.Text = cRMSurveyEntity.ApproximateFloorSizeSft.ToString();
                txtFloors.Text = cRMSurveyEntity.Floors.ToString();
                txtApproximateTotalSpaceSft.Text = cRMSurveyEntity.ApproximateTotalSpaceSft.ToString();
                txtBasements.Text = cRMSurveyEntity.Basements.ToString();
                txtNoOfCarParking.Text = cRMSurveyEntity.NoOfCarParking.ToString();
                txtACSystem.Text = cRMSurveyEntity.ACSystem.ToString();
                txtGeneratorBackup.Text = cRMSurveyEntity.GeneratorBackup.ToString();
                txtLiftsCapacity.Text = cRMSurveyEntity.LiftsCapacity.ToString();
                txtToiletsPerFloor.Text = cRMSurveyEntity.ToiletsPerFloor.ToString();
                txtAvailableFloorSft.Text = cRMSurveyEntity.AvailableFloorSft.ToString();
                txtAvailableForOccupancy.Text = cRMSurveyEntity.AvailableForOccupancy.ToString();
                txtRentalRateBDTPerSft.Text = cRMSurveyEntity.RentalRateBDTPerSft.ToString();
                txtSellingRateBDTPerSft.Text = cRMSurveyEntity.SellingRateBDTPerSft.ToString();
                txtHandoverTime.Text = cRMSurveyEntity.HandoverTime.ToString();
                if (ddlSurveyBuildingStatusID.Items.Count > 0 && cRMSurveyEntity.SurveyBuildingStatusID != null)
                {
                    ddlSurveyBuildingStatusID.SelectedValue = cRMSurveyEntity.SurveyBuildingStatusID.ToString();
                }

                if (ddlSurveySourceInformationID.Items.Count > 0 && cRMSurveyEntity.SurveySourceInformationID != null)
                {
                    ddlSurveySourceInformationID.SelectedValue = cRMSurveyEntity.SurveySourceInformationID.ToString();
                }

                txtSourcePersonInformation.Text = cRMSurveyEntity.SourcePersonInformation.ToString();
                txtContactInfo.Text = cRMSurveyEntity.ContactInfo.ToString();
                txtRemarks.Text = cRMSurveyEntity.Remarks.ToString();
                txtAdditionalRemarks.Text = cRMSurveyEntity.AdditionalRemarks.ToString();
                txtOthersRemarks.Text = cRMSurveyEntity.OthersRemarks.ToString();
                txtSurveyDate.Text = cRMSurveyEntity.SurveyDate.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMSurveyList();
        }

        private void BindCRMSurveyList()
        {
            lvCRMSurvey.DataBind();
        }

        private CRMSurveyEntity BuildCRMSurveyEntity()
        {
            CRMSurveyEntity cRMSurveyEntity = CurrentCRMSurveyEntity;

            cRMSurveyEntity.SurveyMasterID = OverviewSurveryMasterID;

            if (ddlSurveyOwnerID.Items.Count > 0)
            {
                if (ddlSurveyOwnerID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMSurveyEntity.SurveyOwnerID = Int64.Parse(ddlSurveyOwnerID.SelectedValue);
                }
            }

            if (ddlAreaID.Items.Count > 0)
            {
                if (ddlAreaID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMSurveyEntity.AreaID = Int64.Parse(ddlAreaID.SelectedValue);
                }
            }

            cRMSurveyEntity.Description = txtDescription.Text.Trim();
            cRMSurveyEntity.PlotAddress = txtPlotAddress.Text.Trim();
            if (!txtApproximatePlotSize.Text.Trim().IsNullOrEmpty())
            {
                cRMSurveyEntity.ApproximatePlotSize = Decimal.Parse(txtApproximatePlotSize.Text.Trim());
            }

            if (ddlAreaUnitID.Items.Count > 0)
            {
                if (ddlAreaUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMSurveyEntity.AreaUnitID = Int64.Parse(ddlAreaUnitID.SelectedValue);
                }
            }

            if (!txtApproximateFloorSizeSft.Text.Trim().IsNullOrEmpty())
            {
                cRMSurveyEntity.ApproximateFloorSizeSft = Decimal.Parse(txtApproximateFloorSizeSft.Text.Trim());
            }

            if (!txtFloors.Text.Trim().IsNullOrEmpty())
            {
                cRMSurveyEntity.Floors = Decimal.Parse(txtFloors.Text.Trim());
            }

            if (!txtApproximateTotalSpaceSft.Text.Trim().IsNullOrEmpty())
            {
                cRMSurveyEntity.ApproximateTotalSpaceSft = Decimal.Parse(txtApproximateTotalSpaceSft.Text.Trim());
            }

            cRMSurveyEntity.Basements = txtBasements.Text.Trim();
            cRMSurveyEntity.NoOfCarParking = txtNoOfCarParking.Text.Trim();
            cRMSurveyEntity.ACSystem = txtACSystem.Text.Trim();
            cRMSurveyEntity.GeneratorBackup = txtGeneratorBackup.Text.Trim();
            cRMSurveyEntity.LiftsCapacity = txtLiftsCapacity.Text.Trim();
            cRMSurveyEntity.ToiletsPerFloor = txtToiletsPerFloor.Text.Trim();
            cRMSurveyEntity.AvailableFloorSft = txtAvailableFloorSft.Text.Trim();
            cRMSurveyEntity.AvailableForOccupancy = txtAvailableForOccupancy.Text.Trim();
            cRMSurveyEntity.RentalRateBDTPerSft = txtRentalRateBDTPerSft.Text.Trim();
            cRMSurveyEntity.SellingRateBDTPerSft = txtSellingRateBDTPerSft.Text.Trim();
            cRMSurveyEntity.HandoverTime = txtHandoverTime.Text.Trim();
            if (ddlSurveyBuildingStatusID.Items.Count > 0)
            {
                if (ddlSurveyBuildingStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMSurveyEntity.SurveyBuildingStatusID = Int64.Parse(ddlSurveyBuildingStatusID.SelectedValue);
                }
            }

            if (ddlSurveySourceInformationID.Items.Count > 0)
            {
                if (ddlSurveySourceInformationID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMSurveyEntity.SurveySourceInformationID = Int64.Parse(ddlSurveySourceInformationID.SelectedValue);
                }
            }

            cRMSurveyEntity.SourcePersonInformation = txtSourcePersonInformation.Text.Trim();
            cRMSurveyEntity.ContactInfo = txtContactInfo.Text.Trim();
            cRMSurveyEntity.Remarks = txtRemarks.Text.Trim();
            cRMSurveyEntity.AdditionalRemarks = txtAdditionalRemarks.Text.Trim();
            cRMSurveyEntity.OthersRemarks = txtOthersRemarks.Text.Trim();
            cRMSurveyEntity.CreateDate = System.DateTime.Now;

            if (txtSurveyDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMSurveyEntity.SurveyDate = MiscUtil.ParseToDateTime(txtSurveyDate.Text);
            }

            cRMSurveyEntity.IP = MiscUtil.GetLocalIP();
            cRMSurveyEntity.SurveyByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
            cRMSurveyEntity.CreateByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            return cRMSurveyEntity;
        }

        private void SaveCRMSurveyEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMSurveyEntity cRMSurveyEntity = BuildCRMSurveyEntity();

                    Int64 result = -1;

                    if (cRMSurveyEntity.IsNew)
                    {
                        result = FCCCRMSurvey.GetFacadeCreate().Add(cRMSurveyEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyEntity.FLD_NAME_SurveyID, cRMSurveyEntity.SurveyID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMSurvey.GetFacadeCreate().Update(cRMSurveyEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SurveyID = 0;
                        _CRMSurveyEntity = new CRMSurveyEntity();
                        PrepareInitialView();
                        BindCRMSurveyList();

                        if (cRMSurveyEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMSurveyEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Survey Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Survey Information.", false);
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

        protected void lvCRMServey_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            //if (e.Item.ItemType == ListViewItemType.DataItem)
            //{
            //    ListViewDataItem dataItem = (ListViewDataItem)e.Item;

            //    CRMSurveyEntity ent = (CRMSurveyEntity)dataItem.DataItem;

            //    HyperLink hypSurveyReport = (HyperLink)e.Item.FindControl("hypSurveyReport");
            //    hypSurveyReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "SurveyReport", UrlConstants.OVERVIEW_SURVEY_ID, ent.SurveyID.ToString()).ToString();
            //    hypSurveyReport.Target = "_blank";
            //}
            //HyperLink hypSurveyOwner = (HyperLink)e.Item.FindControl("hypSurveyOwner");
            //hypSurveyOwner.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMSurveyOwner.aspx", String.Empty, String.Empty, String.Empty).ToString();
            //hypSurveyOwner.Target = "_blank";
        }

        protected void lvCRMSurvey_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SurveyID;

            Int64.TryParse(e.CommandArgument.ToString(), out SurveyID);

            if (SurveyID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SurveyID = SurveyID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyEntity.FLD_NAME_SurveyID, SurveyID.ToString(), SQLMatchType.Equal);

                        CRMSurveyEntity cRMSurveyEntity = new CRMSurveyEntity();


                        result = FCCCRMSurvey.GetFacadeCreate().Delete(cRMSurveyEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SurveyID = 0;
                            _CRMSurveyEntity = new CRMSurveyEntity();
                            PrepareInitialView();
                            BindCRMSurveyList();

                            MiscUtil.ShowMessage(lblMessage, "Survey has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Survey.", true);
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

        protected void odsCRMSurvey_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyEntity.FLD_NAME_SurveyMasterID, OverviewSurveryMasterID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMSurveyEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SurveyID = 0;
            _CRMSurveyEntity = new CRMSurveyEntity();
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
