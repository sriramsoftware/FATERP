// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
using System.Data;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class PRMMaterialReceiveAdjustmentControl : BaseControl
    {
        #region Properties

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateApprovedPRMMaterialReceive(ddlMaterialReceiveID, false);
        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidationInput()
        {
            Boolean flag = true;

            if (ddlMaterialReceiveID != null && ddlMaterialReceiveID.Items.Count > 0)
            {
                String fe_itemMap = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, ddlMaterialReceiveID.SelectedValue.ToString(), SQLMatchType.Equal);
                IList<PRMMaterialReceiveItemMapEntity> lst = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_itemMap, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "MRR has no item to adjust.", true);
                    flag = false;
                }
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
        }

        private void BindList()
        {

        }

        private INVStoreIssueNoteEntity BuildINVStoreIssueNoteEntity()
        {
            PRMMaterialReceiveEntity pRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(Int64.Parse(ddlMaterialReceiveID.SelectedValue));

            INVStoreIssueNoteEntity iNVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();

            iNVStoreIssueNoteEntity.ProjectID = pRMMaterialReceiveEntity.ProjectID;

            iNVStoreIssueNoteEntity.SRFNo = "Adjustment";
            iNVStoreIssueNoteEntity.RequestedByEmployeeID = 168;//Need to change here; will come from mrr created employee ID
            iNVStoreIssueNoteEntity.RequestDate = System.DateTime.Now;

            iNVStoreIssueNoteEntity.Remarks = "MRR Adjustment Entry";
            iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID = MasterDataConstants.INVStoreIssueNoteApprovalStatus.ISSUED;
            iNVStoreIssueNoteEntity.IsRemoved = false;

            return iNVStoreIssueNoteEntity;
        }

        private void BuildINVStoreIssueNoteItemMapEntity(Int64 sinID,Int64 projectID)
        {
            try
            {
                String fe_itemMap = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveID, ddlMaterialReceiveID.SelectedValue.ToString(), SQLMatchType.Equal);
                IList<PRMMaterialReceiveItemMapEntity> lst = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_itemMap, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    foreach (PRMMaterialReceiveItemMapEntity ent in lst)
                    {
                        INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();

                        REQRequisitionItemEntity rEQRequisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(ent.RequisitionItemID);

                        if (rEQRequisitionItemEntity != null && rEQRequisitionItemEntity.ItemID > 0)
                        {
                            iNVStoreIssueNoteItemMapEntity.StoreIssueNoteID = sinID;
                            iNVStoreIssueNoteItemMapEntity.ItemID = rEQRequisitionItemEntity.ItemID;
                            iNVStoreIssueNoteItemMapEntity.FolioNo = String.Empty;
                            iNVStoreIssueNoteItemMapEntity.RequestQty = ent.ReceiveQty;
                            iNVStoreIssueNoteItemMapEntity.IssueQty = ent.ReceiveQty;
                        }

                        String fe_transaction1 = SqlExpressionBuilder.PrepareFilterExpression(INVTransactionEntity.FLD_NAME_ItemID, rEQRequisitionItemEntity.ItemID.ToString(), SQLMatchType.Equal);
                        String fe_transaction2 = SqlExpressionBuilder.PrepareFilterExpression(INVTransactionEntity.FLD_NAME_MRRNumber, ddlMaterialReceiveID.Text.ToString(), SQLMatchType.Equal);
                        String fe_transaction = SqlExpressionBuilder.PrepareFilterExpression(fe_transaction1, SQLJoinType.AND, fe_transaction2);

                        IList<INVTransactionEntity> lstINVTransactionEntity = FCCINVTransaction.GetFacadeCreate().GetIL(null, null, String.Empty, fe_transaction, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstINVTransactionEntity != null && lstINVTransactionEntity.Count > 0)
                        {
                            iNVStoreIssueNoteItemMapEntity.BatchNo = lstINVTransactionEntity[0].BatchNumber;
                        }

                        //    iNVStoreIssueNoteItemMapEntity.BatchNo = txtBatchNo.Text.Trim();
                        String fe_store1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
                        String fe_store2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_IsDefault, "1", SQLMatchType.Equal);
                        String fe_store = SqlExpressionBuilder.PrepareFilterExpression(fe_store1, SQLJoinType.AND, fe_store2);

                        IList<INVStoreEntity> lstINVStoreEntity = FCCINVStore.GetFacadeCreate().GetIL(null, null, String.Empty, fe_store, DatabaseOperationType.LoadWithFilterExpression);

                        if (lstINVStoreEntity != null && lstINVStoreEntity.Count > 0)
                        {
                            iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = lstINVStoreEntity[0].StoreID;

                            String fe_storeUnit1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreID, lstINVStoreEntity[0].StoreID.ToString(), SQLMatchType.Equal);
                            String fe_storeUnit2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_IsDefault, "1", SQLMatchType.Equal);
                            String fe_storeUnit = SqlExpressionBuilder.PrepareFilterExpression(fe_storeUnit1, SQLJoinType.AND, fe_storeUnit2);

                            IList<INVStoreUnitEntity> lstINVStoreUnitEntity = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, fe_storeUnit, DatabaseOperationType.LoadWithFilterExpression);

                            if (lstINVStoreUnitEntity != null && lstINVStoreUnitEntity.Count > 0)
                            {
                                iNVStoreIssueNoteItemMapEntity.IssuedFromStoreUnitID = lstINVStoreUnitEntity[0].StoreUnitID;
                            }
                        }


                        iNVStoreIssueNoteItemMapEntity.ReceivedDate = System.DateTime.Now;
                        iNVStoreIssueNoteItemMapEntity.ReceivedByEmployeeID = 168;

                        iNVStoreIssueNoteItemMapEntity.ReturnQty = null;
                        iNVStoreIssueNoteItemMapEntity.ReturnDate = null;
                        iNVStoreIssueNoteItemMapEntity.ReturnToStoreID = null;
                        iNVStoreIssueNoteItemMapEntity.ReturnToStoreUnitID = null;
                        iNVStoreIssueNoteItemMapEntity.ReturnedByEmployeeID = null;

                        iNVStoreIssueNoteItemMapEntity.ActualUse = null;
                        iNVStoreIssueNoteItemMapEntity.Amount = ent.WOItemTotalRate / ent.ReceiveQty;

                        iNVStoreIssueNoteItemMapEntity.PurposeOfWorks = "Adjustment Entry";

                        INVStoreEntity storeEntity = INVManager.GetDefaultStore(projectID);

                        INVStoreUnitEntity storeUnitEntity = INVManager.GetDefaultStoreUnit(storeEntity.StoreID);

                        iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = storeEntity.StoreID;
                        iNVStoreIssueNoteItemMapEntity.IssuedFromStoreID = storeUnitEntity.StoreUnitID;

                        FCCINVStoreIssueNoteItemMap.GetFacadeCreate().Add(iNVStoreIssueNoteItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        #region Inventory


                        String batchNumber = String.Empty;
                        Decimal transactionQty = 0;
                        Boolean invResult = false;

                        invResult = INVManager.RemoveItemsFromStoreUnit(rEQRequisitionItemEntity.ItemID, rEQRequisitionItemEntity.BrandID, rEQRequisitionItemEntity.RegionID, rEQRequisitionItemEntity.CountryID, lstINVTransactionEntity[0].BatchNumber, Int64.Parse(transactionQty.ToString()), MiscUtil.GetLocalIP(), MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember), 0, String.Empty, String.Empty, String.Empty, "", projectID, storeEntity.StoreID, storeUnitEntity.StoreUnitID);

                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Some Error Occured " + ex.Message, true);
            }
        }

        private void SavePRMMaterialReceiveAdjustmentEntity()
        {
            if (IsValid)
            {

               
                    INVStoreIssueNoteEntity iNVStoreIssueNoteEntity = BuildINVStoreIssueNoteEntity();

                    Int64 result = -1;

                    result = FCCINVStoreIssueNote.GetFacadeCreate().Add(iNVStoreIssueNoteEntity, DatabaseOperationType.Add, TransactionRequired.No);

                    if (result > 0)
                    {
                        BuildINVStoreIssueNoteItemMapEntity(iNVStoreIssueNoteEntity.StoreIssueNoteID, iNVStoreIssueNoteEntity.ProjectID);

                        Int64 result_two = -1;

                        //if (iNVStoreIssueNoteItemMapEntity.IsNew)
                        //{
                        //    result = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().Add(iNVStoreIssueNoteItemMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        //}
                        //else
                        //{
                        //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteItemMapID, iNVStoreIssueNoteItemMapEntity.StoreIssueNoteItemMapID.ToString(), SQLMatchType.Equal);
                        //    result = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().Update(iNVStoreIssueNoteItemMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        //}

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
            }
        }

        #endregion

        #region Button Event

        protected void btnAdjustMRR_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
             //   SavePRMMaterialReceiveAdjustmentEntity();
            }
        }

        #endregion

        #endregion Event
    }
}
