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

namespace Bay.ERP.Web.UI
{
    public partial class INVStoreUnitItemControl : BaseControl
    {       
        #region Properties

        public Int64 _StoreUnitItemID
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

        public INVStoreUnitItemEntity _INVStoreUnitItemEntity
        {
            get
            {
                INVStoreUnitItemEntity entity = new INVStoreUnitItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVStoreUnitItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVStoreUnitItemEntity CurrentINVStoreUnitItemEntity
        {
            get
            {
                if (_StoreUnitItemID > 0)
                {
                    if (_INVStoreUnitItemEntity.StoreUnitItemID != _StoreUnitItemID)
                    {
                        _INVStoreUnitItemEntity = FCCINVStoreUnitItem.GetFacadeCreate().GetByID(_StoreUnitItemID);
                    }
                }

                return _INVStoreUnitItemEntity;
            }
            set
            {
                _INVStoreUnitItemEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, true);
            MiscUtil.PopulateINVStoreUnit(ddlStoreUnitID, true);
            MiscUtil.PopulateMDItem(ddlItemID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
        }

        private void PrepareEditView()
        {
          
        }

        private void BindList()
        {
            BindINVStoreUnitItemList();
        }

        private void BindINVStoreUnitItemList()
        {
            lvINVStoreUnitItem.DataBind();
        }

        private String BuildFilterArgument(String fe)
        {
            #region One argument

            if (ddlProjectID.SelectedValue != "0" && ddlStoreUnitID.SelectedValue == "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectID", ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlStoreUnitID.SelectedValue != "0" && ddlProjectID.SelectedValue == "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVStoreUnitItem_DetailedEntity.FLD_NAME_StoreUnitID, ddlStoreUnitID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlItemID.SelectedValue != "0" && ddlProjectID.SelectedValue == "0" && ddlStoreUnitID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVStoreUnitItem_DetailedEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }

            #endregion

            #region Two Arguments

            if (ddlProjectID.SelectedValue != "0" && ddlStoreUnitID.SelectedValue != "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectID", ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVStoreUnitItem_DetailedEntity.FLD_NAME_StoreUnitID, ddlStoreUnitID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlProjectID.SelectedValue != "0" && ddlStoreUnitID.SelectedValue == "0" && ddlItemID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectID", ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVStoreUnitItem_DetailedEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlProjectID.SelectedValue == "0" && ddlStoreUnitID.SelectedValue != "0" && ddlItemID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVStoreUnitItem_DetailedEntity.FLD_NAME_StoreUnitID, ddlStoreUnitID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVStoreUnitItem_DetailedEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            #endregion

            #region Three Arguments

            if (ddlProjectID.SelectedValue != "0" && ddlStoreUnitID.SelectedValue != "0" && ddlItemID.SelectedValue != "0")
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVStoreUnitItem_DetailedEntity.FLD_NAME_StoreUnitID, ddlStoreUnitID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVStoreUnitItem_DetailedEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectID", ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);

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

        protected void lvINVStoreUnitItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                INVStoreUnitItem_DetailedEntity ent = (INVStoreUnitItem_DetailedEntity)dataItem.DataItem;

                HyperLink lnkItemDetails = (HyperLink)e.Item.FindControl("lnkItemDetails");
                Label lblStoreUnitIDLV = (Label)e.Item.FindControl("lblStoreUnitIDLV");
                Label lblItemIDLV = (Label)e.Item.FindControl("lblItemIDLV");
                Label lblProjectIDLV = (Label)e.Item.FindControl("lblProjectIDLV");

                lnkItemDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/INV/INVTransaction.aspx", string.Empty, UrlConstants.OVERVIEW_ITEM_ID,lblItemIDLV.Text.ToString(),UrlConstants.OVERVIEW_STORE_UNIT_ID,lblStoreUnitIDLV.Text.ToString(),UrlConstants.OVERVIEW_PROJECT_ID,lblProjectIDLV.Text.ToString()).ToString();
                lnkItemDetails.Target = "_blank";
            }
        }

        protected void lvINVStoreUnitItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 StoreUnitItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out StoreUnitItemID);

            if (StoreUnitItemID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _StoreUnitItemID = StoreUnitItemID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitItemEntity.FLD_NAME_StoreUnitItemID, StoreUnitItemID.ToString(), SQLMatchType.Equal);

                        INVStoreUnitItemEntity iNVStoreUnitItemEntity = new INVStoreUnitItemEntity();


                        result = FCCINVStoreUnitItem.GetFacadeCreate().Delete(iNVStoreUnitItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _StoreUnitItemID = 0;
                            _INVStoreUnitItemEntity = new INVStoreUnitItemEntity();
                            PrepareInitialView();
                            BindINVStoreUnitItemList();

                            MiscUtil.ShowMessage(lblMessage, "I NVStore Unit Item has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVStore Unit Item.", true);
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

        protected void odsINVStoreUnitItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

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
