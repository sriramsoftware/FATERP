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
    public partial class INVCurrentStockControl : BaseControl
    {       
        #region Properties

        public Int64 _CurrentStockID
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

        public INVCurrentStockEntity _INVCurrentStockEntity
        {
            get
            {
                INVCurrentStockEntity entity = new INVCurrentStockEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVCurrentStockEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVCurrentStockEntity CurrentINVCurrentStockEntity
        {
            get
            {
                if (_CurrentStockID > 0)
                {
                    if (_INVCurrentStockEntity.CurrentStockID != _CurrentStockID)
                    {
                        _INVCurrentStockEntity = FCCINVCurrentStock.GetFacadeCreate().GetByID(_CurrentStockID);
                    }
                }

                return _INVCurrentStockEntity;
            }
            set
            {
                _INVCurrentStockEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDItem(ddlItemID, true);
            MiscUtil.PopulateMDBrand(ddlBrandID, true);
            MiscUtil.PopulateMDRegion(ddlRegionID, true);
            MiscUtil.PopulateMDCountry(ddlCountryID, true);
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
            BindINVCurrentStockList();
        }

        private void BindINVCurrentStockList()
        {
            lvINVCurrentStock.DataBind();
        }

        private String BuildFilterArgument(String fe)
        {
            #region One argument

            if (ddlRegionID.SelectedValue != "0" && ddlBrandID.SelectedValue == "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_RegionID, ddlRegionID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlBrandID.SelectedValue != "0" && ddlRegionID.SelectedValue == "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_BrandID, ddlBrandID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlItemID.SelectedValue != "0" && ddlRegionID.SelectedValue == "0" && ddlBrandID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }

            #endregion

            #region Two Arguments

            if (ddlRegionID.SelectedValue != "0" && ddlBrandID.SelectedValue != "0" && ddlItemID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock."+ INVCurrentStockEntity.FLD_NAME_RegionID, ddlRegionID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnitItem." + INVCurrentStockEntity.FLD_NAME_BrandID, ddlBrandID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlRegionID.SelectedValue != "0" && ddlBrandID.SelectedValue == "0" && ddlItemID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_RegionID, ddlRegionID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlRegionID.SelectedValue == "0" && ddlBrandID.SelectedValue != "0" && ddlItemID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_BrandID, ddlBrandID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            #endregion

            #region Three Arguments

            if (ddlRegionID.SelectedValue != "0" && ddlBrandID.SelectedValue != "0" && ddlItemID.SelectedValue != "0")
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_BrandID, ddlBrandID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("INVCurrentStock." + INVCurrentStockEntity.FLD_NAME_RegionID, ddlRegionID.SelectedValue.ToString(), SQLMatchType.Equal);

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

        protected void lvINVCurrentStock_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CurrentStockID;

            Int64.TryParse(e.CommandArgument.ToString(), out CurrentStockID);

            if (CurrentStockID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CurrentStockID = CurrentStockID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVCurrentStockEntity.FLD_NAME_CurrentStockID, CurrentStockID.ToString(), SQLMatchType.Equal);

                        INVCurrentStockEntity iNVCurrentStockEntity = new INVCurrentStockEntity();


                        result = FCCINVCurrentStock.GetFacadeCreate().Delete(iNVCurrentStockEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CurrentStockID = 0;
                            _INVCurrentStockEntity = new INVCurrentStockEntity();
                            PrepareInitialView();
                            BindINVCurrentStockList();

                            MiscUtil.ShowMessage(lblMessage, "I NVCurrent Stock has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVCurrent Stock.", true);
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

        protected void odsINVCurrentStock_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
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
