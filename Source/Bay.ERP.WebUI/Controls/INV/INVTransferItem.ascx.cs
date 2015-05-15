// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2012, 11:15:25




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
    public partial class INVTransferItemControl : BaseControl
    {       
        #region Properties

        public Int64 _TransferItemID
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

        public INVTransferItemEntity _INVTransferItemEntity
        {
            get
            {
                INVTransferItemEntity entity = new INVTransferItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVTransferItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVTransferItemEntity CurrentINVTransferItemEntity
        {
            get
            {
                if (_TransferItemID > 0)
                {
                    if (_INVTransferItemEntity.TransferItemID != _TransferItemID)
                    {
                        _INVTransferItemEntity = FCCINVTransferItem.GetFacadeCreate().GetByID(_TransferItemID);
                    }
                }

                return _INVTransferItemEntity;
            }
            set
            {
                _INVTransferItemEntity = value;
            }
        }


        public Int64 INVTransferID
        {
            get
            {
                Int64 iNVTransferID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TRANSFER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TRANSFER_ID], out iNVTransferID);
                }

                return iNVTransferID;
            }
        }

        private INVTransfer_DetailedEntity CurrentINVTransferEntity
        {
            get
            {
                IList<INVTransfer_DetailedEntity> _INVTransferEntity = new List<INVTransfer_DetailedEntity>();

                if (INVTransferID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransferEntity.FLD_NAME_TransferID, INVTransferID.ToString(), SQLMatchType.Equal);
                    _INVTransferEntity = FCCINVTransfer_Detailed.GetFacadeCreate().GetIL(10000,1,String.Empty,fe);
                }

                return _INVTransferEntity[0] != null ? _INVTransferEntity[0] : new INVTransfer_DetailedEntity();
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
           
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            EnableDisableApprovalProcessCheck();

            hypProjectID.Value = CurrentINVTransferEntity.TransferFromStoreID.ToString();

            INVTransfer_DetailedEntity ent = CurrentINVTransferEntity;

            if (ent != null)
            {
                lblTRFNo.Text = ent.TRFNo.ToString();
                lblRequestedDate.Text = ent.RequestDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                lblFromStore.Text = ent.TransferFromStore.ToString();
                lblToStore.Text = ent.TransferToStoreName.ToString();
            }

        }

        private void PrepareEditView()
        {
            
        }

        private void BindList()
        {
            BindINVTransferItemList();
        }

        private void BindINVTransferItemList()
        {
            lvINVTransferItem.DataBind();
        }

        private void EnableDisableApprovalProcessCheck()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.TRF, INVTransferID);

            if (aPApprovalProcessEntity.APApprovalProcessID > 0)
            {
                btnInitiateApprovalProcess.Enabled = false;
                btnSubmit.Enabled = false;
                txtItemName.Enabled = false;
            }
            else
            {
                btnInitiateApprovalProcess.Enabled = true;
                btnSubmit.Enabled = true;
                txtItemName.Enabled = true;
            }
        }

        private void AddItemToINVTransferItemEntity()
        {
            try
            {
                INVTransferItemEntity iNVTransferItemEntity = CurrentINVTransferItemEntity;

                iNVTransferItemEntity.TransferID = INVTransferID;
                iNVTransferItemEntity.ItemID = Int64.Parse(hdEmpID.Value);

                String fe_StoreUnitID = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnit.StoreID", CurrentINVTransferEntity.TransferFromStoreID.ToString(), SQLMatchType.Equal);
                String fe_ItemID = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem.ItemID", iNVTransferItemEntity.ItemID.ToString(), SQLMatchType.Equal);
                String fe_StoreUnitItem = SqlExpressionBuilder.PrepareFilterExpression(fe_StoreUnitID, SQLJoinType.AND, fe_ItemID);
                IList<INVStoreUnitItem_DetailedEntity> lst = FCCINVStoreUnitItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_StoreUnitItem);

                if (lst != null && lst.Count > 0)
                {
                    iNVTransferItemEntity.BrandID = lst[0].BrandID;
                    iNVTransferItemEntity.RegionID = lst[0].RegionID;
                    iNVTransferItemEntity.CountryID = lst[0].CountryID;
                }

                iNVTransferItemEntity.RequestQty = 1;

                Int64 result = -1;

                result = FCCINVTransferItem.GetFacadeCreate().Add(iNVTransferItemEntity, DatabaseOperationType.Add, TransactionRequired.No);

                BindList();
            }

            catch (Exception ex)
            {

            }
           
        }

        private void UpdateAllINVTransferItemEntity()
        {
            try
            {
                IList<ListViewDataItem> list = lvINVTransferItem.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvINVTransferItem.DataKeys[tempDataItemIndex++];
                        Int64 intTransferItemID = (Int64)currentDataKey["TransferItemID"];

                        TextBox txtRequestQtyLV = (TextBox)lvdi.FindControl("txtRequestQtyLV");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                      
                        Decimal requestedQty;
                        
                        Decimal.TryParse(txtRequestQtyLV.Text.Trim(), out requestedQty);

                        INVTransferItemEntity _INVTransferItem = FCCINVTransferItem.GetFacadeCreate().GetByID(intTransferItemID);

                        _INVTransferItem.RequestQty=requestedQty;

                        if (txtRemarksLV.Text.IsNotNullOrEmpty())
                        {
                            _INVTransferItem.Remarks = txtRemarksLV.Text.Trim().ToString();
                        }
                        else
                        {
                            _INVTransferItem.Remarks = null;
                        }

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransferItemEntity.FLD_NAME_TransferItemID, intTransferItemID.ToString(), SQLMatchType.Equal);

                        FCCINVTransferItem.GetFacadeCreate().Update(_INVTransferItem, fe, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    MiscUtil.ShowMessage(lblMessage, "Transfer Item Information has been updated successfully.", false);
                    BindList();
                }
                
            }

            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to to update Transfer Item Information.", true);
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            btnInitiateApprovalProcess.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnInitiateApprovalProcess, "").ToString());

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvINVTransferItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                if (CurrentINVTransferEntity.InventoryTransferStatusID== MasterDataConstants.INVTransferApprovalStatus.APPROVED)
                {
                    LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");
                    lnkBtnDelete.Visible = false;
                }
            }
        }

        protected void lvINVTransferItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TransferItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out TransferItemID);

            if (TransferItemID > 0)
            {   
                if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransferItemEntity.FLD_NAME_TransferItemID, TransferItemID.ToString(), SQLMatchType.Equal);

                        INVTransferItemEntity iNVTransferItemEntity = new INVTransferItemEntity();


                        result = FCCINVTransferItem.GetFacadeCreate().Delete(iNVTransferItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TransferItemID = 0;
                            _INVTransferItemEntity = new INVTransferItemEntity();
                            PrepareInitialView();
                            BindINVTransferItemList();

                            MiscUtil.ShowMessage(lblMessage, "Transfer Item has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Transfer Item.", true);
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

        protected void odsINVTransferItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("INVTransferItem." + INVTransferItemEntity.FLD_NAME_TransferID, INVTransferID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AddItemToINVTransferItemEntity();
        }

        protected void btnUpdateAll_Click(object sender, EventArgs e)
        {
            UpdateAllINVTransferItemEntity();
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            #region Save Initailly

            UpdateAllINVTransferItemEntity();

            #endregion

            #region Approval Process

            Boolean apResult = APRobot.CreateApprovalProcessForNewTRF(INVTransferID);

            if (apResult == true)
            {
                MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
            }

            EnableDisableApprovalProcessCheck();

            #endregion
        }

        #endregion

        #endregion Event
    }
}
