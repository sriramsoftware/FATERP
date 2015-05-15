// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 02:43:44




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
    public partial class INVTransactionControl : BaseControl
    {       
        #region Properties

        public Int64 _TransactionID
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

        public INVTransactionEntity _INVTransactionEntity
        {
            get
            {
                INVTransactionEntity entity = new INVTransactionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVTransactionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVTransactionEntity CurrentINVTransactionEntity
        {
            get
            {
                if (_TransactionID > 0)
                {
                    if (_INVTransactionEntity.TransactionID != _TransactionID)
                    {
                        _INVTransactionEntity = FCCINVTransaction.GetFacadeCreate().GetByID(_TransactionID);
                    }
                }

                return _INVTransactionEntity;
            }
            set
            {
                _INVTransactionEntity = value;
            }
        }

        public Int64 INVStoreUnitID
        {
            get
            {
                Int64 _iNVStoreUnitID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_STORE_UNIT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_STORE_UNIT_ID], out _iNVStoreUnitID);
                }

                return _iNVStoreUnitID;
            }
        }

        public Int64 OverviewItemID
        {
            get
            {
                Int64 _overviewItemID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ITEM_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ITEM_ID], out _overviewItemID);
                }

                return _overviewItemID;
            }
        }

        public Int64 OverviewProjectID
        {
            get
            {
                Int64 _overviewProjectID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECT_ID], out _overviewProjectID);
                }

                return _overviewProjectID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDItem(ddlItemID, true);
            MiscUtil.PopulateBDProject(ddlProjectID, true);
            MiscUtil.PopulateINVStore(ddlStoreID, true);
            MiscUtil.PopulateINVStoreUnit(ddlStoreUnitID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtBatchNumber.Text = String.Empty;
            txtTransactionDate.Text = String.Empty;
        }

        private void PrepareEditView()
        {
           
        }

        private void BindList()
        {
            BindINVTransactionList();
        }

        private void BindINVTransactionList()
        {
            lvINVTransaction.DataBind();
        }

        private String BuildFilterArgument(String fe)
        {
            #region One argument

            if (ddlProjectID.SelectedValue != "0" && ddlStoreUnitID.SelectedValue == "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStore."+ INVTransaction_DetailedEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlStoreUnitID.SelectedValue != "0" && ddlProjectID.SelectedValue == "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction." + INVTransaction_DetailedEntity.FLD_NAME_StoreUnitID, ddlStoreUnitID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlItemID.SelectedValue != "0" && ddlProjectID.SelectedValue == "0" && ddlStoreUnitID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction." + INVStoreUnitItem_DetailedEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }

            #endregion

            #region Two Arguments

            if (ddlProjectID.SelectedValue != "0" && ddlStoreUnitID.SelectedValue != "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStore." + INVTransaction_DetailedEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction." + INVTransaction_DetailedEntity.FLD_NAME_StoreUnitID, ddlStoreUnitID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlProjectID.SelectedValue != "0" && ddlStoreUnitID.SelectedValue == "0" && ddlItemID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStore." + INVTransaction_DetailedEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction." + INVTransaction_DetailedEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlProjectID.SelectedValue == "0" && ddlStoreUnitID.SelectedValue != "0" && ddlItemID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction." + INVTransaction_DetailedEntity.FLD_NAME_StoreUnitID, ddlStoreUnitID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction." + INVTransaction_DetailedEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            #endregion

            #region Three Arguments

            if (ddlProjectID.SelectedValue != "0" && ddlStoreUnitID.SelectedValue != "0" && ddlItemID.SelectedValue != "0")
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction." + INVTransaction_DetailedEntity.FLD_NAME_StoreUnitID, ddlStoreUnitID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction." + INVTransaction_DetailedEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("INVStore." + INVTransaction_DetailedEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);

                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.AND, fe4);
            }

            #endregion

            return fe;
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

        protected void lvINVTransaction_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TransactionID;

            Int64.TryParse(e.CommandArgument.ToString(), out TransactionID);

            if (TransactionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TransactionID = TransactionID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTransactionEntity.FLD_NAME_TransactionID, TransactionID.ToString(), SQLMatchType.Equal);

                        INVTransactionEntity iNVTransactionEntity = new INVTransactionEntity();


                        result = FCCINVTransaction.GetFacadeCreate().Delete(iNVTransactionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TransactionID = 0;
                            _INVTransactionEntity = new INVTransactionEntity();
                            PrepareInitialView();
                            BindINVTransactionList();

                            MiscUtil.ShowMessage(lblMessage, "I NVTransaction has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVTransaction.", true);
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

        protected void odsINVTransaction_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (OverviewItemID > 0 && INVStoreUnitID > 0)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction."+INVTransactionEntity.FLD_NAME_StoreUnitID, INVStoreUnitID.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVTransaction."+INVTransactionEntity.FLD_NAME_ItemID, OverviewItemID.ToString(), SQLMatchType.Equal);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("INVStore." + INVTransactionEntity.FLD_NAME_ProjectID, OverviewProjectID.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            fe = BuildFilterArgument(fe);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
