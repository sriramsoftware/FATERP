// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2013, 12:12:56




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
    public partial class CRMBuyerBookSpaceControl : BaseControl
    {       
        #region Properties

        public Int64 _BuyerBookSpaceID
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

        public CRMBuyerBookSpaceEntity _CRMBuyerBookSpaceEntity
        {
            get
            {
                CRMBuyerBookSpaceEntity entity = new CRMBuyerBookSpaceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMBuyerBookSpaceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMBuyerBookSpaceEntity CurrentCRMBuyerBookSpaceEntity
        {
            get
            {
                if (_BuyerBookSpaceID > 0)
                {
                    if (_CRMBuyerBookSpaceEntity.BuyerBookSpaceID != _BuyerBookSpaceID)
                    {
                        _CRMBuyerBookSpaceEntity = FCCCRMBuyerBookSpace.GetFacadeCreate().GetByID(_BuyerBookSpaceID);
                    }
                }

                return _CRMBuyerBookSpaceEntity;
            }
            set
            {
                _CRMBuyerBookSpaceEntity = value;
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

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateCRMMDBookingStatus(ddlBookingStatusID, false);

            if (ddlBookingStatusID.Items.Count > 0 && ddlBookingStatusID != null)
            {
                ddlBookingStatusID.SelectedValue = MasterDataConstants.CRMMDBookingStatus.ON_GOING.ToString();
            }

            BuildProjectFloorUnitByProjectID();
            BuildBuyerBasicInfo();
        }

        private void BuildProjectFloorUnitByProjectID()
        {
            if (!CurrentCRMBuyerBookSpaceEntity.IsNew)
            {
                MiscUtil.PopulateBDProjectFloorUnitByProject(ddlProjectFloorUnitID, false, Int64.Parse(ddlProjectID.SelectedValue));
                PrepareLabel(true);
            }
            else
            {
                if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
                {
                    MiscUtil.PopulateBDAvailableProjectFloorUnitByProject(ddlProjectFloorUnitID, false, Int64.Parse(ddlProjectID.SelectedValue));
                }
                else
                {
                    ddlProjectFloorUnitID.Items.Clear();
                }
            }
        }

        private void BuildBuyerBasicInfo()
        {
            if (chkIsLandOwner.Checked)
            {
                MiscUtil.PopulateCRMLandBasicInfo(ddlBuyerBasicInfoID, false);
                lblLandOwnerInfo.Text = "Landowner Info";
            }
            else if (chkIsLandOwner.Checked == false)
            {
                MiscUtil.PopulateCRMBuyerBasicInfo(ddlBuyerBasicInfoID, false);
                lblLandOwnerInfo.Text = "Buyer Info";
            }
        }

        private void PrepareValidator()
        {

        }
        private void PrepareLabel(Boolean flag)
        {
            lblFormLock.Visible = false;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtBookingNote.Text = String.Empty;
            chkIsLandOwner.Checked = false;
            chkIsApprovedByManagement.Checked = false;

            btnSubmit.Text = "Save and Book Another";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity = CurrentCRMBuyerBookSpaceEntity;


            if (!cRMBuyerBookSpaceEntity.IsNew)
            {
                chkIsLandOwner.Checked = cRMBuyerBookSpaceEntity.IsLandOwner;

                BuildBuyerBasicInfo();

                if (ddlBuyerBasicInfoID.Items.Count > 0 && cRMBuyerBookSpaceEntity.ReferenceID != null)
                {
                    ddlBuyerBasicInfoID.SelectedValue = cRMBuyerBookSpaceEntity.ReferenceID.ToString();
                }

                if (ddlProjectID.Items.Count > 0 && cRMBuyerBookSpaceEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cRMBuyerBookSpaceEntity.ProjectID.ToString();
                }

                BuildProjectFloorUnitByProjectID();

                if (ddlProjectFloorUnitID.Items.Count > 0 && cRMBuyerBookSpaceEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = cRMBuyerBookSpaceEntity.ProjectFloorUnitID.ToString();
                }

                txtBookingNote.Text = cRMBuyerBookSpaceEntity.BookingNote.ToString();
                
                chkIsApprovedByManagement.Checked = cRMBuyerBookSpaceEntity.IsApprovedByManagement;
                if (ddlBookingStatusID.Items.Count > 0 && cRMBuyerBookSpaceEntity.BookingStatusID != null)
                {
                    ddlBookingStatusID.SelectedValue = cRMBuyerBookSpaceEntity.BookingStatusID.ToString();
                }

                btnSubmit.Text = "Update and Book Another";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMBuyerBookSpaceList();
        }

        private void BindCRMBuyerBookSpaceList()
        {
            lvCRMBuyerBookSpace.DataBind();
        }

        private CRMBuyerBookSpaceEntity BuildCRMBuyerBookSpaceEntity()
        {
            CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity = CurrentCRMBuyerBookSpaceEntity;

            if (ddlBuyerBasicInfoID.Items.Count > 0)
            {
                if (ddlBuyerBasicInfoID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerBookSpaceEntity.ReferenceID = Int64.Parse(ddlBuyerBasicInfoID.SelectedValue);
                }
            }

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerBookSpaceEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (ddlProjectFloorUnitID.Items.Count > 0)
            {
                if (ddlProjectFloorUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerBookSpaceEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                }
            }

            cRMBuyerBookSpaceEntity.BookingNote = txtBookingNote.Text.Trim();
            cRMBuyerBookSpaceEntity.IsLandOwner = chkIsLandOwner.Checked;

            cRMBuyerBookSpaceEntity.IsApprovedByManagement = chkIsApprovedByManagement.Checked;

            if (ddlBookingStatusID.Items.Count > 0)
            {
                if (ddlBookingStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMBuyerBookSpaceEntity.BookingStatusID = Int64.Parse(ddlBookingStatusID.SelectedValue);
                }
            }

            Int64 currentEmployeeID=MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
            
            if(currentEmployeeID>0)
            {
                cRMBuyerBookSpaceEntity.CreatedByEmployeeID = currentEmployeeID;
            }

            cRMBuyerBookSpaceEntity.IP = MiscUtil.GetLocalIP();
            cRMBuyerBookSpaceEntity.CreateDate = System.DateTime.Now;

            #region Image

            String ImageUrlpath;

            if (fuImageUrl.HasFile == true && cRMBuyerBookSpaceEntity.ImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(cRMBuyerBookSpaceEntity.ImageUrl)))
                {
                    File.Delete(Server.MapPath(cRMBuyerBookSpaceEntity.ImageUrl));
                }
                ImageUrlpath = FileUploadConstants.CRM.Buyer + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cRMBuyerBookSpaceEntity.ImageUrl = ImageUrlpath;
            }

            if (cRMBuyerBookSpaceEntity.ImageUrl.IsNotNullOrEmpty() && fuImageUrl.HasFile == false)
            {
                cRMBuyerBookSpaceEntity.ImageUrl = cRMBuyerBookSpaceEntity.ImageUrl;
            }

            if (fuImageUrl.HasFile == false && cRMBuyerBookSpaceEntity.ImageUrl.IsNullOrEmpty())
            {
                cRMBuyerBookSpaceEntity.ImageUrl = null;
            }

            if (fuImageUrl.HasFile == true && cRMBuyerBookSpaceEntity.ImageUrl.IsNullOrEmpty())
            {
                ImageUrlpath = FileUploadConstants.CRM.Buyer + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));
                cRMBuyerBookSpaceEntity.ImageUrl = ImageUrlpath;
            }

            #endregion Image

            return cRMBuyerBookSpaceEntity;
        }

        private void SaveCRMBuyerBookSpaceEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity = BuildCRMBuyerBookSpaceEntity();

                    Int64 result = -1;

                    if (cRMBuyerBookSpaceEntity.IsNew)
                    {
                        result = FCCCRMBuyerBookSpace.GetFacadeCreate().Add(cRMBuyerBookSpaceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBookSpaceEntity.FLD_NAME_BuyerBookSpaceID, cRMBuyerBookSpaceEntity.BuyerBookSpaceID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMBuyerBookSpace.GetFacadeCreate().Update(cRMBuyerBookSpaceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {

                        #region Project Floor Unit Update Info
                        
                        BDProjectFloorUnitEntity bDProjectFloorUnitEntity = FCCBDProjectFloorUnit.GetFacadeCreate().GetByID(cRMBuyerBookSpaceEntity.ProjectFloorUnitID);
                        bDProjectFloorUnitEntity.ProjectFloorUnitStatusID=MasterDataConstants.MDProjectFloorUnitStatus.ALLOCATED;

                        String fe_floorUnit = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorUnitEntity.FLD_NAME_ProjectFloorUnitID, cRMBuyerBookSpaceEntity.ProjectFloorUnitID.ToString(), SQLMatchType.Equal);

                        FCCBDProjectFloorUnit.GetFacadeCreate().Update(bDProjectFloorUnitEntity, fe_floorUnit, DatabaseOperationType.Update, TransactionRequired.No);

                        #endregion

                        PrepareLabel(false);
                        _BuyerBookSpaceID = 0;
                        _CRMBuyerBookSpaceEntity = new CRMBuyerBookSpaceEntity();
                        PrepareInitialView();
                        BindCRMBuyerBookSpaceList();

                        if (cRMBuyerBookSpaceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Buyer Book Space Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Buyer Book Space Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMBuyerBookSpaceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Buyer Book Space Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Buyer Book Space Information.", false);
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

        protected void lvCRMBuyerBookSpace_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMBuyerBookSpace_DetailedEntity ent = (CRMBuyerBookSpace_DetailedEntity)dataItem.DataItem;

                HyperLink hypContatFullNameLV = (HyperLink)e.Item.FindControl("hypContatFullNameLV");

                if (ent.BookingStatusID == MasterDataConstants.CRMMDBookingStatus.CONVERTED||
                    ent.BookingStatusID == MasterDataConstants.CRMMDBookingStatus.BOOKED)
                {
                    hypContatFullNameLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMPaymentSchedule.aspx", string.Empty, UrlConstants.OVERVIEW_BOOK_SPACE_ID, ent.BuyerBookSpaceID.ToString()).ToString();
                }
                else
                {
                    hypContatFullNameLV.NavigateUrl = String.Empty;
                }

                hypContatFullNameLV.Target = "_blank";
            }
        }

        protected void lvCRMBuyerBookSpace_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BuyerBookSpaceID;

            Int64.TryParse(e.CommandArgument.ToString(), out BuyerBookSpaceID);

            if (BuyerBookSpaceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BuyerBookSpaceID = BuyerBookSpaceID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBookSpaceEntity.FLD_NAME_BuyerBookSpaceID, BuyerBookSpaceID.ToString(), SQLMatchType.Equal);

                        CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity = new CRMBuyerBookSpaceEntity();


                        result = FCCCRMBuyerBookSpace.GetFacadeCreate().Delete(cRMBuyerBookSpaceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BuyerBookSpaceID = 0;
                            _CRMBuyerBookSpaceEntity = new CRMBuyerBookSpaceEntity();
                            PrepareInitialView();
                            BindCRMBuyerBookSpaceList();

                            MiscUtil.ShowMessage(lblMessage, "C RMBuyer Book Space has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMBuyer Book Space.", true);
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

        protected void odsCRMBuyerBookSpace_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBookSpaceEntity.FLD_NAME_CreatedByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {
                fe = fe+" and ContactFullName like '%" + txtSearchText.Text + "%'";
                //fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe9);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMBuyerBookSpaceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BuyerBookSpaceID = 0;
            _CRMBuyerBookSpaceEntity = new CRMBuyerBookSpaceEntity();
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
            BuildProjectFloorUnitByProjectID();
        }

        #endregion

        #region Checkbox Event

        protected void chkIsLandOwner_CheckedChanged(object sender, EventArgs e)
        {
            BuildBuyerBasicInfo();
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
