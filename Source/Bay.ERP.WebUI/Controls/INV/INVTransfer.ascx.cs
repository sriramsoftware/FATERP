// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 01:46:09




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class INVTransferControl : BaseControl
    {       
        #region Properties

        public Int64 _TransferID
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

        public INVTransferEntity _INVTransferEntity
        {
            get
            {
                INVTransferEntity entity = new INVTransferEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVTransferEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVTransferEntity CurrentINVTransferEntity
        {
            get
            {
                if (_TransferID > 0)
                {
                    if (_INVTransferEntity.TransferID != _TransferID)
                    {
                        _INVTransferEntity = FCCINVTransfer.GetFacadeCreate().GetByID(_TransferID);
                    }
                }

                return _INVTransferEntity;
            }
            set
            {
                _INVTransferEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHREmployee(ddlRequestedByEmployeeID, false);
            MiscUtil.PopulateINVStore(ddlTransferFromStoreID, false);
            MiscUtil.PopulateINVStore(ddlTransferToStoreID, false);
            MiscUtil.PopulateMDInventoryTransferStatus(ddlInventoryTransferStatusID, false);
            BuildStoreUnitByFromStore();
            BuildStoreUnitByToStore();
        }

        private void BuildStoreUnitByFromStore()
        {
            if (ddlTransferFromStoreID != null && ddlTransferFromStoreID.SelectedValue != "0")
            {
                MiscUtil.PopulateINVStoreUnitByStore(ddlTransferFromStoreUnitID, false, Int64.Parse(ddlTransferFromStoreID.SelectedValue));
            }
        }

        private void BuildStoreUnitByToStore()
        {
            if (ddlTransferToStoreID != null && ddlTransferToStoreID.SelectedValue != "0")
            {
                MiscUtil.PopulateINVStoreUnitByStore(ddlTransferToStoreUnitID, false, Int64.Parse(ddlTransferToStoreID.SelectedValue));
            }
        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidationInput()
        {
            Boolean flag = true;
            if (ddlTransferFromStoreID.SelectedValue == ddlTransferToStoreID.SelectedValue)
            {
                MiscUtil.ShowMessage(lblMessage, "Can't Transfer in Same Store.", true);
                flag = false;
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTRFNo.Text = MasterDataConstants.AutoAssigned.DEFAULT_AUTO_ASSIGNED;
            txtRequestDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtRemarks.Text = String.Empty;

            if (ddlRequestedByEmployeeID.Items.Count > 0)
            {
                Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                if (employeeID > 0)
                {
                    ddlRequestedByEmployeeID.SelectedValue = employeeID.ToString();
                }

            }

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            INVTransferEntity iNVTransferEntity = CurrentINVTransferEntity;
            

            if (!iNVTransferEntity.IsNew)
            {
                txtTRFNo.Text = iNVTransferEntity.TRFNo.ToString();
                if (ddlRequestedByEmployeeID.Items.Count > 0 && iNVTransferEntity.RequestedByEmployeeID != null)
                {
                    ddlRequestedByEmployeeID.SelectedValue = iNVTransferEntity.RequestedByEmployeeID.ToString();
                }

                txtRequestDate.Text = iNVTransferEntity.RequestDate.ToStringDefault();
                if (ddlTransferFromStoreID.Items.Count > 0 && iNVTransferEntity.TransferFromStoreID != null)
                {
                    ddlTransferFromStoreID.SelectedValue = iNVTransferEntity.TransferFromStoreID.ToString();
                }

                BuildStoreUnitByFromStore();

                if (ddlTransferFromStoreUnitID.Items.Count > 0 && iNVTransferEntity.TransferFromStoreUnitID != null)
                {
                    ddlTransferFromStoreUnitID.SelectedValue = iNVTransferEntity.TransferFromStoreUnitID.ToString();
                }

                if (ddlTransferToStoreID.Items.Count > 0 && iNVTransferEntity.TransferToStoreID != null)
                {
                    ddlTransferToStoreID.SelectedValue = iNVTransferEntity.TransferToStoreID.ToString();
                }

                BuildStoreUnitByToStore();

                if (ddlTransferToStoreUnitID.Items.Count > 0 && iNVTransferEntity.TransferToStoreUnitID != null)
                {
                    ddlTransferToStoreUnitID.SelectedValue = iNVTransferEntity.TransferToStoreUnitID.ToString();
                }

                txtRemarks.Text = iNVTransferEntity.Remarks.ToString();
                if (ddlInventoryTransferStatusID.Items.Count > 0 && iNVTransferEntity.InventoryTransferStatusID != null)
                {
                    ddlInventoryTransferStatusID.SelectedValue = iNVTransferEntity.InventoryTransferStatusID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindINVTransferList();
        }

        private void BindINVTransferList()
        {
            lvINVTransfer.DataBind();
        }

        private INVTransferEntity BuildINVTransferEntity()
        {
            INVTransferEntity iNVTransferEntity = CurrentINVTransferEntity;

            iNVTransferEntity.TRFNo = txtTRFNo.Text.Trim();

            if (ddlRequestedByEmployeeID.Items.Count > 0)
            {
                if (ddlRequestedByEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVTransferEntity.RequestedByEmployeeID = Int64.Parse(ddlRequestedByEmployeeID.SelectedValue);
                }
            }

            if (txtRequestDate.Text.Trim().IsNotNullOrEmpty())
            {
                iNVTransferEntity.RequestDate = MiscUtil.ParseToDateTime(txtRequestDate.Text);
            }

            if (ddlTransferFromStoreID.Items.Count > 0)
            {
                if (ddlTransferFromStoreID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVTransferEntity.TransferFromStoreID = Int64.Parse(ddlTransferFromStoreID.SelectedValue);
                }
            }

            if (ddlTransferFromStoreUnitID.Items.Count > 0)
            {
                if (ddlTransferFromStoreUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVTransferEntity.TransferFromStoreUnitID = Int64.Parse(ddlTransferFromStoreUnitID.SelectedValue);
                }
            }

            if (ddlTransferToStoreID.Items.Count > 0)
            {
                if (ddlTransferToStoreID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVTransferEntity.TransferToStoreID = Int64.Parse(ddlTransferToStoreID.SelectedValue);
                }
            }

            if (ddlTransferToStoreUnitID.Items.Count > 0)
            {
                if (ddlTransferToStoreUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVTransferEntity.TransferToStoreUnitID = Int64.Parse(ddlTransferToStoreUnitID.SelectedValue);
                }
            }

            iNVTransferEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlInventoryTransferStatusID.Items.Count > 0)
            {
                if (ddlInventoryTransferStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVTransferEntity.InventoryTransferStatusID = Int64.Parse(ddlInventoryTransferStatusID.SelectedValue);
                }
            }


            return iNVTransferEntity;
        }

        private void SaveINVTransferEntity()
        {
            if (ValidationInput())
            {
                if (IsValid)
                {
                    try
                    {
                        INVTransferEntity iNVTransferEntity = BuildINVTransferEntity();

                        Int64 result = -1;

                        if (iNVTransferEntity.IsNew)
                        {
                            result = FCCINVTransfer.GetFacadeCreate().Add(iNVTransferEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVTransferEntity.FLD_NAME_TransferID, iNVTransferEntity.TransferID.ToString(), SQLMatchType.Equal);
                            result = FCCINVTransfer.GetFacadeCreate().Update(iNVTransferEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {

                            String NavigationUrl = UrlHelper.BuildSecureUrl("~/INV/INVTransferItem.aspx", string.Empty, UrlConstants.OVERVIEW_TRANSFER_ID, result.ToString()).ToString();
                            Response.Redirect(NavigationUrl);

                            _TransferID = 0;
                            _INVTransferEntity = new INVTransferEntity();
                            PrepareInitialView();
                            BindINVTransferList();

                            if (iNVTransferEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "TRF Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "TRF Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (iNVTransferEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add TRF Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update TRF Information.", false);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
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

        protected void lvINVTransfer_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                INVTransfer_DetailedEntity ent = (INVTransfer_DetailedEntity)dataItem.DataItem;

                HyperLink hypTRFNo = (HyperLink)e.Item.FindControl("hypTRFNo");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                hypTRFNo.NavigateUrl = UrlHelper.BuildSecureUrl("~/INV/INVTransferItem.aspx", string.Empty, UrlConstants.OVERVIEW_TRANSFER_ID, ent.TransferID.ToString()).ToString();

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.TRF, ent.TransferID);
                if (aPApprovalProcessEntity.APApprovalProcessID > 0)
                {
                    lnkShowApprovalStatus.NavigateUrl = UrlHelper.BuildSecureUrl(
                               "~/AP/APView.aspx",
                               string.Empty,
                               APApprovalProcessEntity.FLD_NAME_APApprovalProcessID,
                               aPApprovalProcessEntity.APApprovalProcessID.ToString()
                               ).ToString();

                    lnkShowApprovalStatus.Target = "_blank";
                }
                else
                {
                    lnkShowApprovalStatus.NavigateUrl = String.Empty;
                    lnkShowApprovalStatus.Enabled = false;
                }

                hypTRFNo.Target = "_blank";
            }
        }

        protected void lvINVTransfer_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TransferID;

            Int64.TryParse(e.CommandArgument.ToString(), out TransferID);

            if (TransferID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TransferID = TransferID;
                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransferEntity.FLD_NAME_TransferID, TransferID.ToString(), SQLMatchType.Equal);

                        INVTransferEntity iNVTransferEntity = new INVTransferEntity();

                        result = FCCINVTransfer.GetFacadeCreate().Delete(iNVTransferEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TransferID = 0;
                            _INVTransferEntity = new INVTransferEntity();
                            PrepareInitialView();
                            BindINVTransferList();

                            MiscUtil.ShowMessage(lblMessage, "I NVTransfer has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVTransfer.", true);
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

        protected void odsINVTransfer_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("TFS.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MDInventoryTransferStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("INVTransfer.TRFNo", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveINVTransferEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TransferID = 0;
            _INVTransferEntity = new INVTransferEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown List Event

        protected void ddlTransferFromStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildStoreUnitByFromStore();
        }

        protected void ddlTransferToStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildStoreUnitByToStore();
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
