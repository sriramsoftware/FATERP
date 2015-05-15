// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    public partial class INVStoreIssueNoteItemMapControl : BaseControl
    {       
        #region Properties

        public String Action
        {
            get
            {
                String action = null;

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public Int64 _StoreIssueNoteItemMapID
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

        public INVStoreIssueNoteItemMapEntity _INVStoreIssueNoteItemMapEntity
        {
            get
            {
                INVStoreIssueNoteItemMapEntity entity = new INVStoreIssueNoteItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVStoreIssueNoteItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVStoreIssueNoteItemMapEntity CurrentINVStoreIssueNoteItemMapEntity
        {
            get
            {
                if (_StoreIssueNoteItemMapID > 0)
                {
                    if (_INVStoreIssueNoteItemMapEntity.StoreIssueNoteItemMapID != _StoreIssueNoteItemMapID)
                    {
                        _INVStoreIssueNoteItemMapEntity = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetByID(_StoreIssueNoteItemMapID);
                    }
                }

                return _INVStoreIssueNoteItemMapEntity;
            }
            set
            {
                _INVStoreIssueNoteItemMapEntity = value;
            }
        }

        public Int64 INVStoreIssueNoteID
        {
            get
            {
                Int64 _iNVStoreIssueNoteID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_STORE_ISSUE_NOTE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_STORE_ISSUE_NOTE_ID], out _iNVStoreIssueNoteID);
                }

                return _iNVStoreIssueNoteID;
            }
        }

        private INVStoreIssueNoteEntity CurrentINVStoreIssueNoteEntity
        {
            get
            {
                INVStoreIssueNoteEntity _iNVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();

                if (INVStoreIssueNoteID > 0)
                {
                    _iNVStoreIssueNoteEntity = FCCINVStoreIssueNote.GetFacadeCreate().GetByID(INVStoreIssueNoteID);
                }

                return _iNVStoreIssueNoteEntity;
            }
        }

        private INVTRFStoreIssueNoteMapEntity CurrentTRFStoreIssueNoteMapEntity 
        {
            get
            {
                IList<INVTRFStoreIssueNoteMapEntity> _iNVTRFStoreIssueNoteMapEntity = new List<INVTRFStoreIssueNoteMapEntity>();

                INVTRFStoreIssueNoteMapEntity TRFStoreIssueNoteMapEntity = null;

                if (INVStoreIssueNoteID > 0)
                {
                    String fe_TRFSIN = SqlExpressionBuilder.PrepareFilterExpression(INVTRFStoreIssueNoteMapEntity.FLD_NAME_StoreIssueNoteID, INVStoreIssueNoteID.ToString(), SQLMatchType.Equal);
                    _iNVTRFStoreIssueNoteMapEntity = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_TRFSIN, DatabaseOperationType.LoadWithFilterExpression);

                    if (_iNVTRFStoreIssueNoteMapEntity != null && _iNVTRFStoreIssueNoteMapEntity.Count > 0)
                    {
                        TRFStoreIssueNoteMapEntity = _iNVTRFStoreIssueNoteMapEntity[0];
                    }
                }

                return TRFStoreIssueNoteMapEntity;
            }
        }


        
        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateHREmployee(ddlReceivedByEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlReturnedByEmployeeID, true);
        }

        private void PrepareValidator()
        {
        }

        private void BuildCurrentStock()
        {
            if (ddlItemID != null && ddlItemID.Items.Count > 0)
            {   
                Int64 projectID=CurrentINVStoreIssueNoteEntity.ProjectID;
                INVStoreEntity storeEntity = INVManager.GetDefaultStore(projectID);
                Int64 storeID=0;
                if(storeEntity!=null)
                {
                    storeID = storeEntity.StoreID;
                }

                else if (ddlIssuedFromStoreID != null && ddlIssuedFromStoreID.SelectedValue!="0")
                {
                    storeID = Int64.Parse(ddlIssuedFromStoreID.SelectedValue.ToString());
                }

                INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeID);
                Int64 storeUnitID=0;
                if(storeUnitEntity!=null)
                {
                    storeUnitID = storeUnitEntity.StoreUnitID;
                }

                else if(ddlIssuedFromStoreUnitID!=null && ddlIssuedFromStoreUnitID.SelectedValue!="0")
                {
                   storeUnitID = Int64.Parse(ddlIssuedFromStoreUnitID.SelectedValue.ToString());
                }
                 
                String fe = String.Empty;
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStore.ProjectID", projectID.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem.ItemID", ddlItemID.SelectedValue, SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem.StoreUnitID", storeUnitID.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);

                IList<INVStoreUnitItem_DetailedEntity> lst = FCCINVStoreUnitItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);

                if (lst != null && lst.Count > 0)
                {
                    lblCurrentStockQty.Text = "Stock Qty: " + lst[0].UnitCurrentStock.ToString();
                }
                else
                {
                    lblCurrentStockQty.Text = "Stock Qty: 0";
                }
            }
        }

        private void BindAndVisiblePanel()
        {
            switch(Action)
            {
                case MasterDataConstants.SINAddOperation.REQUEST_ITEM:
                    Int64 projectID=CurrentINVStoreIssueNoteEntity.ProjectID;
                    INVStoreEntity storeEntity = INVManager.GetDefaultStore(projectID);
                    MiscUtil.PopulateINVStoreAvailableItem(ddlItemID, false, storeEntity.StoreID);
                    //MiscUtil.PopulateREQRequisitionItem(ddlItemID, false);
                    BuildStoreAndStoreUnit();
                    btnSubmit.Text = "Request";
                    pnllvTransaction.Visible = false;
                    pnllvIssueNoteItemMap.Visible = true;
                    rfvtxtBatchNo.Enabled = false;
                    rfvtxtReturnQty.Enabled = false;
                    lvINVTransaction.Visible = false;
                    pnlIssueStoreDetail.Visible = false;
                    pnlReturnDetail.Visible = false;
                    pnlRequestItemDetail.Visible = true;
                    break;
                case MasterDataConstants.SINAddOperation.ISSUE_ITEM:
                    MiscUtil.PopulateINVStoreIssueNoteItemBystoreIssueNoteID(ddlItemID, false, INVStoreIssueNoteID);
                    BuildStoreAndStoreUnit();
                    //EnableDropDownSelectedIndexChanged();
                    btnSubmit.Text = "Issue";
                    pnlIssueStoreDetail.Visible = true;
                    GetItemHistory();
                    pnllvIssueNoteItemMap.Visible = false;
                    rfvtxtReturnQty.Enabled = false;
                    ddlReceivedByEmployeeID.SelectedValue = CurrentINVStoreIssueNoteEntity.RequestedByEmployeeID.ToString();
                    
                    pnlReturnDetail.Visible = false;
                    pnlRequestItemDetail.Enabled = false;
                    break;
                case MasterDataConstants.SINAddOperation.RETURN_ITEM:
                    MiscUtil.PopulateINVStoreIssueNoteItemBystoreIssueNoteID(ddlItemID, false, INVStoreIssueNoteID);
                    BuildStoreAndStoreUnit();
                    //EnableDropDownSelectedIndexChanged();
                    btnSubmit.Text = "Return";
                    GetItemHistory();
                    pnllvIssueNoteItemMap.Visible = false;
                    pnlIssueStoreDetail.Enabled = false;
                    pnlReturnDetail.Visible = true;
                    pnlRequestItemDetail.Enabled = false;
                    break;
            }       
        }

        private void EnableDropDownSelectedIndexChanged()
        {
            MiscUtil.PopulateINVStoreIssueNoteItemBystoreIssueNoteID(ddlItemID, false, INVStoreIssueNoteID);
            ddlItemID.SelectedIndexChanged += new EventHandler(ddlItemID_SelectedIndexChanged);
            ddlItemID.AutoPostBack = true;
        }

        private void BuildStoreUnitByFromStore()
        {
         if (ddlIssuedFromStoreID != null && ddlIssuedFromStoreID.SelectedValue != "0")
            {
                MiscUtil.PopulateINVStoreUnitByStore(ddlIssuedFromStoreUnitID, false,Int64.Parse(ddlIssuedFromStoreID.SelectedValue));
                //MiscUtil.PopulateINVStoreUnitByStore(ddlReturnToStoreUnitID, false, Int64.Parse(ddlIssuedFromStoreID.SelectedValue));
            }
        }

        private void BuildStoreUnitByReturnToStore()
        {
            if (ddlReturnToStoreID != null && ddlReturnToStoreID.SelectedValue != "0")
            {  
               MiscUtil.PopulateINVStoreUnitByStore(ddlReturnToStoreUnitID, false, Int64.Parse(ddlIssuedFromStoreID.SelectedValue));
            }
        }

        private void BuildStoreAndStoreUnit()
        {
            Int64 projectID = CurrentINVStoreIssueNoteEntity.ProjectID;

            if (projectID > 0)
            {
                MiscUtil.PopulateINVStoreByProject(ddlIssuedFromStoreID, false, projectID);
                MiscUtil.PopulateINVStoreByProject(ddlReturnToStoreID, false, projectID);
            }

            if (ddlIssuedFromStoreID != null && ddlIssuedFromStoreID.SelectedValue != "0")
            {
                MiscUtil.PopulateINVStoreUnitByStore(ddlIssuedFromStoreUnitID, false,Int64.Parse(ddlIssuedFromStoreID.SelectedValue));
                MiscUtil.PopulateINVStoreUnitByStore(ddlReturnToStoreUnitID, false, Int64.Parse(ddlIssuedFromStoreID.SelectedValue));
            }
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtFolioNo.Text = String.Empty;
            txtBatchNo.Text = String.Empty;
            txtRequestQty.Text = String.Empty;
            txtIssueQty.Text = String.Empty;
            txtReceivedDate.Text = String.Empty;
            txtReturnQty.Text = String.Empty;
            txtReturnDate.Text = String.Empty;
            txtActualUse.Text = String.Empty;
            txtAmount.Text = String.Empty;
            txtPurposeOfWorks.Text = String.Empty;

            BindAndVisiblePanel();
            BuildCurrentStock();

            btnAddNew.Visible = false;
        }

        private void GetItemHistory()
        {
            if (Action == MasterDataConstants.SINAddOperation.ISSUE_ITEM || Action == MasterDataConstants.SINAddOperation.RETURN_ITEM)
            {
                if (ddlItemID != null && ddlItemID.Items.Count > 0)
                {
                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteID, INVStoreIssueNoteID.ToString(), SQLMatchType.Equal);
                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteItemMapEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                    IList<INVStoreIssueNoteItemMapEntity> lst = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (lst != null && lst.Count > 0)
                    {
                        txtRequestQty.Text = lst[0].RequestQty.ToString();
                        txtFolioNo.Text = lst[0].FolioNo.ToString();
                        txtPurposeOfWorks.Text = lst[0].PurposeOfWorks.ToString();
                        txtAmount.Text = lst[0].Amount.ToString();
                        txtBatchNo.Text = lst[0].BatchNo;
                        txtIssueQty.Text = lst[0].IssueQty.ToString();
                        _StoreIssueNoteItemMapID = lst[0].StoreIssueNoteItemMapID;

                        if (Action == MasterDataConstants.SINAddOperation.ISSUE_ITEM)
                        {
                            if (lst[0].IssueQty == null)
                            {
                                btnSubmit.Enabled = true;
                                txtReceivedDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
                            }
                            else if (lst[0].IssueQty > 0)
                            {
                                btnSubmit.Enabled = false;
                            }

                        }

                        else if (Action == MasterDataConstants.SINAddOperation.RETURN_ITEM)
                        { 
                            txtReceivedDate.Text = lst[0].ReceivedDate.ToStringDefault();

                            if (ddlReceivedByEmployeeID.Items.Count > 0 && lst[0].ReceivedByEmployeeID != null)
                            {
                                ddlReceivedByEmployeeID.SelectedValue = lst[0].ReceivedByEmployeeID.ToString();
                            }
                            if (lst[0].ReturnQty == null)
                            {
                                btnSubmit.Enabled = true;
                                txtReturnDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
                            }
                            else if (lst[0].ReturnQty > 0)
                            {
                                btnSubmit.Enabled = false;
                            }
                        }
                    }

                }
            }
        }

        private void PrepareEditView()
        {
            INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity = CurrentINVStoreIssueNoteItemMapEntity;

            if (!iNVStoreIssueNoteItemMapEntity.IsNew)
            {
                if (ddlItemID.Items.Count > 0 && iNVStoreIssueNoteItemMapEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = iNVStoreIssueNoteItemMapEntity.ItemID.ToString();
                }

                txtBatchNo.Text = iNVStoreIssueNoteItemMapEntity.BatchNo.ToString();
                txtFolioNo.Text = iNVStoreIssueNoteItemMapEntity.FolioNo.ToString();
                txtIssueQty.Text = iNVStoreIssueNoteItemMapEntity.IssueQty.ToString();
                txtRequestQty.Text = iNVStoreIssueNoteItemMapEntity.RequestQty.ToString();
                if (ddlIssuedFromStoreID.Items.Count > 0 && iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID != null)
                {
                    ddlIssuedFromStoreID.SelectedValue = iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID.ToString();
                }

                if (ddlIssuedFromStoreUnitID.Items.Count > 0 && iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID != null)
                {
                    ddlIssuedFromStoreUnitID.SelectedValue = iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID.ToString();
                }

                txtReceivedDate.Text = iNVStoreIssueNoteItemMapEntity.ReceivedDate.ToStringDefault();
                if (ddlReceivedByEmployeeID.Items.Count > 0 && iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID != null)
                {
                    ddlReceivedByEmployeeID.SelectedValue = iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID.ToString();
                }

                txtReturnQty.Text = iNVStoreIssueNoteItemMapEntity.ReturnQty.ToString();
                txtReturnDate.Text = iNVStoreIssueNoteItemMapEntity.ReturnDate.ToStringDefault();
                if (ddlReturnToStoreID.Items.Count > 0 && iNVStoreIssueNoteItemMapEntity.ReturnToStoreID != null)
                {
                    ddlReturnToStoreID.SelectedValue = iNVStoreIssueNoteItemMapEntity.ReturnToStoreID.ToString();
                }

                if (ddlReturnToStoreUnitID.Items.Count > 0 && iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID != null)
                {
                    ddlReturnToStoreUnitID.SelectedValue = iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID.ToString();
                }

                if (ddlReturnedByEmployeeID.Items.Count > 0 && iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID != null)
                {
                    ddlReturnedByEmployeeID.SelectedValue = iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID.ToString();
                }

                txtActualUse.Text = iNVStoreIssueNoteItemMapEntity.ActualUse.ToString();
                txtAmount.Text = iNVStoreIssueNoteItemMapEntity.Amount.ToString();
                txtPurposeOfWorks.Text = iNVStoreIssueNoteItemMapEntity.PurposeOfWorks.ToString();

                if (Action == MasterDataConstants.SINAddOperation.ISSUE_ITEM)
                {
                    if (iNVStoreIssueNoteItemMapEntity.IssueQty > 0)
                    {
                        btnSubmit.Enabled = false;
                    }
                    if (iNVStoreIssueNoteItemMapEntity.IssueQty == null)
                    {
                        txtReceivedDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
                    }

                }
                else if (Action == MasterDataConstants.SINAddOperation.RETURN_ITEM)
                {
                    if (iNVStoreIssueNoteItemMapEntity.ReturnQty > 0)
                    {
                        btnSubmit.Enabled = false;
                    }
                    if (iNVStoreIssueNoteItemMapEntity.ReturnQty == null)
                    {
                        txtReturnDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
                    }
                }

                btnAddNew.Visible = false;
            }
        }

        private void GetModifyQty()
        {
            try
            {
                IList<ListViewDataItem> list = lvINVTransaction.Items;

                if (list != null && list.Count > 0)
                {
                    String batchNumber = String.Empty;
                    Decimal transactionQty = 0, qty = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        CheckBox chbxSelect = (CheckBox)lvdi.FindControl("chbxSelect");
                        TextBox txtIssueQtyLV = (TextBox)lvdi.FindControl("txtIssueQtyLV");

                        if (chbxSelect.Checked == true)
                        {
                            Decimal.TryParse(txtIssueQtyLV.Text.ToString(), out transactionQty);
                            qty += transactionQty;
                        }
                    }
                    if (Action == MasterDataConstants.SINAddOperation.ISSUE_ITEM)
                    {
                        txtIssueQty.Text = qty.ToString();
                        Decimal requestedQty;
                        Decimal.TryParse(txtRequestQty.Text, out requestedQty);

                        if (qty != requestedQty)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Requested Qty and Issue Qty are not equal", true);
                        }
                    }
                    else if (Action == MasterDataConstants.SINAddOperation.RETURN_ITEM)
                    {
                        txtReturnQty.Text = qty.ToString();
                    }
                }


            }
            catch (Exception ex)
            {
            }
        }

        private void BindList()
        {
            BindINVStoreIssueNoteItemMapList();
        }

        private void BindINVStoreIssueNoteItemMapList()
        {
            lvINVStoreIssueNoteItemMap.DataBind();
        }

        private void BindINVTransactionList()
        {
            lvINVTransaction.DataBind();
        }

        private INVStoreIssueNoteItemMapEntity BuildINVStoreIssueNoteItemMapEntity()
        {
            INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity = CurrentINVStoreIssueNoteItemMapEntity;

            if (INVStoreIssueNoteID > 0)
            {
                iNVStoreIssueNoteItemMapEntity.StoreIssueNoteID = INVStoreIssueNoteID;
            }
           
            if (ddlItemID.Items.Count > 0)
            {
                if (ddlItemID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreIssueNoteItemMapEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                }
            }

            GetModifyQty();

            iNVStoreIssueNoteItemMapEntity.FolioNo = txtFolioNo.Text.Trim();
            if (!txtRequestQty.Text.Trim().IsNullOrEmpty())
            {
                iNVStoreIssueNoteItemMapEntity.RequestQty = Decimal.Parse(txtRequestQty.Text.Trim());
            }

            if (!txtIssueQty.Text.Trim().IsNullOrEmpty())
            {
                iNVStoreIssueNoteItemMapEntity.IssueQty = Decimal.Parse(txtIssueQty.Text.Trim());
            }
            else
            {
                iNVStoreIssueNoteItemMapEntity.IssueQty = null;
            }

            iNVStoreIssueNoteItemMapEntity.BatchNo = txtBatchNo.Text.Trim();

            if (ddlIssuedFromStoreID.Items.Count > 0)
            {
                if (ddlIssuedFromStoreID.SelectedValue == "0")
                {
                    iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = null;
                }
                else
                {
                    iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = Int64.Parse(ddlIssuedFromStoreID.SelectedValue);
                }
            }

            if (ddlIssuedFromStoreUnitID.Items.Count > 0)
            {
                if (ddlIssuedFromStoreUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID = Int64.Parse(ddlIssuedFromStoreUnitID.SelectedValue);
                }
            }

            if (txtReceivedDate.Text.Trim().IsNotNullOrEmpty())
            {
                iNVStoreIssueNoteItemMapEntity.ReceivedDate = MiscUtil.ParseToDateTime(txtReceivedDate.Text);
            }
            else
            {
                iNVStoreIssueNoteItemMapEntity.ReceivedDate = null;
            }

            if (ddlReceivedByEmployeeID.Items.Count > 0)
            {
                if (ddlReceivedByEmployeeID.SelectedValue == "0")
                {
                    iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID = null;
                }
                else
                {
                    iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID = Int64.Parse(ddlReceivedByEmployeeID.SelectedValue);
                }
            }

            if (!txtReturnQty.Text.Trim().IsNullOrEmpty())
            {
                iNVStoreIssueNoteItemMapEntity.ReturnQty = Decimal.Parse(txtReturnQty.Text.Trim());
            }
            else
            {
                iNVStoreIssueNoteItemMapEntity.ReturnQty = null;
            }

            if (txtReturnDate.Text.Trim().IsNotNullOrEmpty())
            {
                iNVStoreIssueNoteItemMapEntity.ReturnDate = MiscUtil.ParseToDateTime(txtReturnDate.Text);
            }
            else
            {
                iNVStoreIssueNoteItemMapEntity.ReturnDate = null;
            }

            if (ddlReturnToStoreID.Items.Count > 0)
            {
                if (ddlReturnToStoreID.SelectedValue == "0")
                {
                    iNVStoreIssueNoteItemMapEntity.ReturnToStoreID = null;
                }
                else
                {
                    iNVStoreIssueNoteItemMapEntity.ReturnToStoreID = Int64.Parse(ddlReturnToStoreID.SelectedValue);
                }
            }

            if (ddlReturnToStoreUnitID.Items.Count > 0)
            {
                if (ddlReturnToStoreUnitID.SelectedValue == "0")
                {
                    iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID = null;
                }
                else
                {
                    iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID = Int64.Parse(ddlReturnToStoreUnitID.SelectedValue);
                }
            }

            if (ddlReturnedByEmployeeID.Items.Count > 0)
            {
                if (ddlReturnedByEmployeeID.SelectedValue == "0")
                {
                    iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID = null;
                }
                else
                {
                    iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID = Int64.Parse(ddlReturnedByEmployeeID.SelectedValue);
                }
            }

            if (!txtActualUse.Text.Trim().IsNullOrEmpty())
            {
                iNVStoreIssueNoteItemMapEntity.ActualUse = Decimal.Parse(txtActualUse.Text.Trim());
            }
            else
            {
                iNVStoreIssueNoteItemMapEntity.ActualUse = null;
            }

            if (!txtAmount.Text.Trim().IsNullOrEmpty())
            {
                iNVStoreIssueNoteItemMapEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
            }
            else
            {
                iNVStoreIssueNoteItemMapEntity.Amount = null;
            }

            iNVStoreIssueNoteItemMapEntity.PurposeOfWorks = txtPurposeOfWorks.Text.Trim();

            INVStoreEntity storeEntity = INVManager.GetDefaultStore(CurrentINVStoreIssueNoteEntity.ProjectID);

            if (Action == MasterDataConstants.SINAddOperation.ISSUE_ITEM)
            {
                if (ddlIssuedFromStoreID.Items.Count > 0)
                {
                    if (ddlIssuedFromStoreID.SelectedValue == "0")
                    {    
                         iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = storeEntity.StoreID;
                    }
                    else
                    {
                        iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = Int64.Parse(ddlIssuedFromStoreID.SelectedValue);
                    }
                }

                if (ddlIssuedFromStoreUnitID.Items.Count > 0)
                {
                    if (ddlIssuedFromStoreUnitID.SelectedValue == "0")
                    {
                        INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(Int64.Parse(iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID.ToString()));
                        iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID = storeUnitEntity.StoreUnitID;
                    }
                    else
                    {
                        iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID = Int64.Parse(ddlIssuedFromStoreUnitID.SelectedValue);
                    }
                }
            }

            if (Action == MasterDataConstants.SINAddOperation.RETURN_ITEM)
            {
                if (ddlReturnToStoreID.Items.Count > 0)
                {
                    if (ddlReturnToStoreID.SelectedValue == "0")
                    {  
                        iNVStoreIssueNoteItemMapEntity.ReturnToStoreID = storeEntity.StoreID;
                    }
                    else
                    {
                        iNVStoreIssueNoteItemMapEntity.ReturnToStoreID = Int64.Parse(ddlReturnToStoreID.SelectedValue);
                    }
                }

                if (ddlReturnToStoreUnitID.Items.Count > 0)
                {
                    if (ddlReturnToStoreUnitID.SelectedValue == "0")
                    {
                        INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(Int64.Parse(iNVStoreIssueNoteItemMapEntity.ReturnToStoreID.ToString()));
                        iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID = storeUnitEntity.StoreUnitID; ;
                    }
                    else
                    {
                        iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID = Int64.Parse(ddlReturnToStoreUnitID.SelectedValue);
                    }
                }
            }

            return iNVStoreIssueNoteItemMapEntity;
        }

        private void SaveINVStoreIssueNoteItemMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity = BuildINVStoreIssueNoteItemMapEntity();

                    Int64 result = -1;

                    if (iNVStoreIssueNoteItemMapEntity.IsNew)
                    {
                        result = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().Add(iNVStoreIssueNoteItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteItemMapID, iNVStoreIssueNoteItemMapEntity.StoreIssueNoteItemMapID.ToString(), SQLMatchType.Equal);
                        result = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().Update(iNVStoreIssueNoteItemMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        #region Inventory

                        if (Action == MasterDataConstants.SINAddOperation.ISSUE_ITEM || Action == MasterDataConstants.SINAddOperation.RETURN_ITEM)
                        {
                            Int64 _employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                            Int64 _projectID = Int64.Parse(CurrentINVStoreIssueNoteEntity.ProjectID.ToString());

                            Int64 storeID = 0;
                            Int64 storeUnitID = 0;
                            Decimal amount = 0;
                            Int64 brandID = 0;
                            Int64 regionID = 0;
                            Int64 countryID = 0;
                            Int64 _itemID = Int64.Parse(ddlItemID.SelectedValue);

                            Boolean invResult = false;

                            switch (Action)
                            {
                                case MasterDataConstants.SINAddOperation.ISSUE_ITEM:

                                    #region Issue Item

                                    try
                                    {
                                        IList<ListViewDataItem> list = lvINVTransaction.Items;

                                        if (list != null && list.Count > 0)
                                        {
                                            String batchNumber = String.Empty;
                                            Decimal transactionQty = 0;

                                            foreach (ListViewDataItem lvdi in list)
                                            {

                                                Label lblBatchNumberLV = (Label)lvdi.FindControl("lblBatchNumberLV");
                                                Label lblBrandIDLV = (Label)lvdi.FindControl("lblBrandIDLV");
                                                Label lblRegionIDLV = (Label)lvdi.FindControl("lblRegionIDLV");
                                                Label lblCountryIDLV = (Label)lvdi.FindControl("lblCountryIDLV");
                                                Label lblUnitPriceLV = (Label)lvdi.FindControl("lblUnitPriceLV");
                                                CheckBox chbxSelect = (CheckBox)lvdi.FindControl("chbxSelect");
                                                TextBox txtIssueQtyLV = (TextBox)lvdi.FindControl("txtIssueQtyLV");

                                                Decimal.TryParse(txtIssueQtyLV.Text.ToString(), out transactionQty);
                                                Int64.TryParse(lblBrandIDLV.Text.ToString(), out brandID);
                                                Int64.TryParse(lblRegionIDLV.Text.ToString(), out regionID);
                                                Int64.TryParse(lblCountryIDLV.Text.ToString(), out countryID);
                                                Decimal.TryParse(lblUnitPriceLV.Text.ToString(), out amount);

                                                if (chbxSelect.Checked)
                                                {

                                                    if (iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID != null)
                                                    {
                                                        storeID = Int64.Parse(iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID.ToString());
                                                    }
                                                    else
                                                    {
                                                        INVStoreEntity storeEntity = INVManager.GetDefaultStore(_projectID);
                                                        storeID = storeEntity.StoreID;
                                                    }

                                                    if (iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID != null)
                                                    {
                                                        storeUnitID = Int64.Parse(iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID.ToString());
                                                    }
                                                    else
                                                    {
                                                        INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeID);
                                                        storeUnitID = storeUnitEntity.StoreUnitID;
                                                    }

                                                    //String fe_TRFSIN=SqlExpressionBuilder.PrepareFilterExpression(INVTRFStoreIssueNoteMapEntity.FLD_NAME_StoreIssueNoteID,INVStoreIssueNoteID.ToString(),SQLMatchType.Equal);
                                                    //IList<INVTRFStoreIssueNoteMapEntity> lstINVTRFStoreIssueNoteMapEntity = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_TRFSIN, DatabaseOperationType.LoadWithFilterExpression);

                                                    //IList<INVTRFStoreIssueNoteMapEntity> lstINVTRFStoreIssueNoteMapEntity = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_TRFSIN, DatabaseOperationType.LoadWithFilterExpression);
                                                    //CurrentTRFStoreIssueNoteMapEntity
                                                    if (CurrentTRFStoreIssueNoteMapEntity != null)
                                                    {
                                                        INVTransferEntity iNVTransferEntity = FCCINVTransfer.GetFacadeCreate().GetByID(CurrentTRFStoreIssueNoteMapEntity.TransferID);

                                                        if (iNVTransferEntity != null)
                                                        {
                                                            INVManager.TransferItems(_itemID, brandID, regionID, countryID, lblBatchNumberLV.Text, Int64.Parse(transactionQty.ToString()), MiscUtil.GetLocalIP(), _employeeID, amount, String.Empty, String.Empty, String.Empty, CurrentINVStoreIssueNoteEntity.StoreIssueNoteNo.ToString(), _projectID, iNVTransferEntity.TransferFromStoreID, iNVTransferEntity.TransferFromStoreUnitID, iNVTransferEntity.TransferToStoreID, iNVTransferEntity.TransferToStoreUnitID);
                                                            continue;
                                                        }
                                                    }

                                                    invResult = INVManager.RemoveItemsFromStoreUnit(_itemID, brandID, regionID, countryID, lblBatchNumberLV.Text, Int64.Parse(transactionQty.ToString()), MiscUtil.GetLocalIP(), _employeeID, amount, String.Empty, String.Empty, String.Empty, CurrentINVStoreIssueNoteEntity.StoreIssueNoteNo.ToString(), _projectID, storeID, storeUnitID);

                                                    if (!invResult)
                                                    {
                                                        MiscUtil.ShowMessage(lblMessage, "Out of Stock Balance.", false);
                                                    }

                                                }
                                            }

                                            INVStoreIssueNoteEntity iNVStoreIssueNoteEntity=FCCINVStoreIssueNote.GetFacadeCreate().GetByID(INVStoreIssueNoteID);
                                            String fe_inv=SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteEntity.FLD_NAME_StoreIssueNoteID,INVStoreIssueNoteID.ToString(),SQLMatchType.Equal);
                                            iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID = MasterDataConstants.INVStoreIssueNoteApprovalStatus.ISSUED;
                                            FCCINVStoreIssueNote.GetFacadeCreate().Update(iNVStoreIssueNoteEntity, fe_inv, DatabaseOperationType.Update, TransactionRequired.No);
                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                    }

                                    #endregion

                                    break;

                                case MasterDataConstants.SINAddOperation.RETURN_ITEM:

                                    #region Return Item

                                    try
                                    {
                                        IList<ListViewDataItem> list = lvINVTransaction.Items;

                                        if (list != null && list.Count > 0)
                                        {
                                            String batchNumber = String.Empty;
                                            Decimal transactionQty = 0;

                                            foreach (ListViewDataItem lvdi in list)
                                            {

                                                Label lblBatchNumberLV = (Label)lvdi.FindControl("lblBatchNumberLV");
                                                Label lblBrandIDLV = (Label)lvdi.FindControl("lblBrandIDLV");
                                                Label lblRegionIDLV = (Label)lvdi.FindControl("lblRegionIDLV");
                                                Label lblCountryIDLV = (Label)lvdi.FindControl("lblCountryIDLV");
                                                Label lblUnitPriceLV = (Label)lvdi.FindControl("lblUnitPriceLV");
                                                CheckBox chbxSelect = (CheckBox)lvdi.FindControl("chbxSelect");
                                                TextBox txtIssueQtyLV = (TextBox)lvdi.FindControl("txtIssueQtyLV");

                                                Decimal.TryParse(txtIssueQtyLV.Text.ToString(), out transactionQty);
                                                Int64.TryParse(lblBrandIDLV.Text.ToString(), out brandID);
                                                Int64.TryParse(lblRegionIDLV.Text.ToString(), out regionID);
                                                Int64.TryParse(lblCountryIDLV.Text.ToString(), out countryID);
                                                Decimal.TryParse(lblUnitPriceLV.Text.ToString(), out amount);

                                                if (chbxSelect.Checked)
                                                {

                                                    if (iNVStoreIssueNoteItemMapEntity.ReturnToStoreID != null)
                                                    {
                                                        storeID = Int64.Parse(iNVStoreIssueNoteItemMapEntity.ReturnToStoreID.ToString());
                                                    }
                                                    else
                                                    {
                                                        INVStoreEntity storeEntity = INVManager.GetDefaultStore(_projectID);
                                                        storeID = storeEntity.StoreID;
                                                    }

                                                    if (iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID != null)
                                                    {
                                                        storeUnitID = Int64.Parse(iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID.ToString());
                                                    }
                                                    else
                                                    {
                                                        INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeID);
                                                        storeUnitID = storeUnitEntity.StoreUnitID;
                                                    }

                                                    invResult = INVManager.AddItemsToStoreUnit(_itemID, brandID, regionID, countryID, lblBatchNumberLV.Text, Int64.Parse(iNVStoreIssueNoteItemMapEntity.ReturnQty.ToString()), MiscUtil.GetLocalIP(), _employeeID, amount, String.Empty, String.Empty, String.Empty, CurrentINVStoreIssueNoteEntity.StoreIssueNoteNo.ToString(), _projectID, storeID, storeUnitID);

                                                    if (!invResult)
                                                    {
                                                        MiscUtil.ShowMessage(lblMessage, "Out of Stock Balance.", false);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                    #endregion

                                    break;
                            }
                        }


                        #endregion

                       
                        _StoreIssueNoteItemMapID = 0;
                       _INVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();
                       
                        PrepareInitialView();
                        BindINVStoreIssueNoteItemMapList();
                        BindINVTransactionList();

                        if (iNVStoreIssueNoteItemMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Store Issue Note Item Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Store Issue Note Item Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (iNVStoreIssueNoteItemMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Store Issue Note Item Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Store Issue Note Item Map Information.", false);
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

        protected void lvINVStoreIssueNoteItemMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 StoreIssueNoteItemMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out StoreIssueNoteItemMapID);

            if (StoreIssueNoteItemMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _StoreIssueNoteItemMapID = StoreIssueNoteItemMapID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteItemMapID, StoreIssueNoteItemMapID.ToString(), SQLMatchType.Equal);

                        INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();


                        result = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().Delete(iNVStoreIssueNoteItemMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _StoreIssueNoteItemMapID = 0;
                            _INVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();
                            PrepareInitialView();
                            BindINVStoreIssueNoteItemMapList();

                            MiscUtil.ShowMessage(lblMessage, "I NVStore Issue Note Item Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVStore Issue Note Item Map.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        protected void lvINVTransaction_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TransactionID;

            Int64.TryParse(e.CommandArgument.ToString(), out TransactionID);

            if (TransactionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    //_TransactionID = TransactionID;

                    //PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        //Int64 result = -1;

                        //String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransactionEntity.FLD_NAME_TransactionID, TransactionID.ToString(), SQLMatchType.Equal);

                        //INVTransactionEntity iNVTransactionEntity = new INVTransactionEntity();


                        //result = FCCINVTransaction.GetFacadeCreate().Delete(iNVTransactionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        //if (result == 0)
                        //{
                        //    _TransactionID = 0;
                        //    _INVTransactionEntity = new INVTransactionEntity();
                        //    PrepareInitialView();
                        //    BindINVTransactionList();

                        //    MiscUtil.ShowMessage(lblMessage, "I NVTransaction has been successfully deleted.", true);
                        //}
                        //else
                        //{
                        //    MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVTransaction.", true);
                        //}
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

        protected void odsINVStoreIssueNoteItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNoteItemMap." + INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteID, INVStoreIssueNoteID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsINVTransaction_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            Int64 projectID = CurrentINVStoreIssueNoteEntity.ProjectID;
            INVStoreEntity storeEntity = INVManager.GetDefaultStore(projectID);
            Int64 storeID = 0;
            if (storeEntity != null)
            {
                storeID = storeEntity.StoreID;
            }

            else if (ddlIssuedFromStoreID != null && ddlIssuedFromStoreID.SelectedValue != "0")
            {
                storeID = Int64.Parse(ddlIssuedFromStoreID.SelectedValue.ToString());
            }

            INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeID);
            Int64 storeUnitID = 0;
            if (storeUnitEntity != null)
            {
                storeUnitID = storeUnitEntity.StoreUnitID;
            }

            else if (ddlIssuedFromStoreUnitID != null && ddlIssuedFromStoreUnitID.SelectedValue != "0")
            {
                storeUnitID = Int64.Parse(ddlIssuedFromStoreUnitID.SelectedValue.ToString());
            }

            String fe3 = SqlExpressionBuilder.PrepareFilterExpression("INVTransactionIN.StoreUnitID", storeUnitID.ToString(), SQLMatchType.Equal);

            fe = SqlExpressionBuilder.PrepareFilterExpression("INVTransactionIN.ItemID", ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
            String fe1 = "INVTransactionIN.TotalINQty - ISNULL(INVTransactionOUT.TotalOUTQty, 0) >0";
            if (Action == MasterDataConstants.SINAddOperation.RETURN_ITEM)
            {
                fe1 = "INVTransactionIN.TotalINQty - ISNULL(INVTransactionOUT.TotalOUTQty, 0) >=0 or INVTransactionIN.TotalINQty - ISNULL(INVTransactionOUT.TotalOUTQty, 0) <0";
            }

            String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.AND, fe1);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveINVStoreIssueNoteItemMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _StoreIssueNoteItemMapID = 0;
            _INVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            GetModifyQty();
        }

        #endregion

        #region Dropdown List Event

        protected void ddlItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetItemHistory();
            BuildCurrentStock();
            BindINVTransactionList();
        }

        protected void ddlIssuedFromStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildStoreUnitByFromStore();
        }

        protected void ddlReturnToStoreID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildStoreUnitByReturnToStore();
        }

        #endregion

        #region Check Box Event

        protected void chbxSelect_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                IList<ListViewDataItem> list = lvINVTransaction.Items;

                if (list != null && list.Count > 0)
                {  
                    String batchNumber=String.Empty;
                    Decimal qty = 0, transactionQty = 0;
                    
                    foreach (ListViewDataItem lvdi in list)
                    {

                        Label lblBatchNumberLV = (Label)lvdi.FindControl("lblBatchNumberLV");
                        Label lblTransactionQtyLV = (Label)lvdi.FindControl("lblTransactionQtyLV");
                        CheckBox chbxSelect = (CheckBox)lvdi.FindControl("chbxSelect");
                        TextBox txtIssueQtyLV = (TextBox)lvdi.FindControl("txtIssueQtyLV");

                        Decimal.TryParse(txtIssueQtyLV.Text.ToString(), out transactionQty);

                        if (chbxSelect.Checked)
                        {
                            txtIssueQtyLV.Visible = true;
                            qty += transactionQty;
                            batchNumber += lblBatchNumberLV.Text.ToString()+", ";

                            if (Action == MasterDataConstants.SINAddOperation.ISSUE_ITEM)
                            {
                                txtBatchNo.Text = String.Empty;
                            }
                        }
                        else if (chbxSelect.Checked == false)
                        {
                            txtIssueQtyLV.Visible = false;
                        }
                    }

                    if (Action == MasterDataConstants.SINAddOperation.ISSUE_ITEM)
                    {
                        txtBatchNo.Text = batchNumber;
                        txtIssueQty.Text = qty.ToString();
                    }

                    else if (Action == MasterDataConstants.SINAddOperation.RETURN_ITEM)
                    {
                        txtBatchNo.Text = batchNumber;
                        txtReturnQty.Text = qty.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
           
        }

        #endregion

        #endregion Event
    }
}
