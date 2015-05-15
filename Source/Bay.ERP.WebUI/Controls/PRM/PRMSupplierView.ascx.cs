// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




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
    public partial class PRMSupplierViewControl : SupplierBaseControl
    {       
        #region Properties

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDSupplierType(ddlSupplierTypeID, true);
            MiscUtil.PopulateMDSupplierStatus(ddlSupplierStatusID, true);
            MiscUtil.PopulateMDSupplierItemCategory(ddlSupplierItemCategoryID, true);
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
            BindPRMSupplierList();
        }

        private void BindPRMSupplierList()
        {
            lvPRMSupplier.DataBind();
        }

        private String BuildFilterArgument(String fe)
        {
            #region One argument

            if (ddlSupplierTypeID.SelectedValue != "0" && ddlSupplierStatusID.SelectedValue == "0" && ddlSupplierItemCategoryID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierTypeID, ddlSupplierTypeID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlSupplierStatusID.SelectedValue != "0" && ddlSupplierTypeID.SelectedValue == "0" && ddlSupplierItemCategoryID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierStatusID, ddlSupplierStatusID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }
            if (ddlSupplierItemCategoryID.SelectedValue != "0" && ddlSupplierTypeID.SelectedValue == "0" && ddlSupplierStatusID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemCategoryMap." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierItemCategoryID, ddlSupplierItemCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = fe1;
            }

            #endregion

            #region Two Arguments

            if (ddlSupplierTypeID.SelectedValue != "0" && ddlSupplierStatusID.SelectedValue != "0" && ddlSupplierItemCategoryID.SelectedValue == "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierTypeID, ddlSupplierTypeID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierStatusID, ddlSupplierStatusID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlSupplierTypeID.SelectedValue != "0" && ddlSupplierStatusID.SelectedValue == "0" && ddlSupplierItemCategoryID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierTypeID, ddlSupplierTypeID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemCategoryMap." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierItemCategoryID, ddlSupplierItemCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            if (ddlSupplierTypeID.SelectedValue == "0" && ddlSupplierStatusID.SelectedValue != "0" && ddlSupplierItemCategoryID.SelectedValue != "0")
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierStatusID, ddlSupplierStatusID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemCategoryMap." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierItemCategoryID, ddlSupplierItemCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            }

            #endregion

            #region Three Arguments

            if (ddlSupplierTypeID.SelectedValue != "0" && ddlSupplierStatusID.SelectedValue != "0" && ddlSupplierItemCategoryID.SelectedValue != "0")
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierStatusID, ddlSupplierStatusID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemCategoryMap." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierItemCategoryID, ddlSupplierItemCategoryID.SelectedValue.ToString(), SQLMatchType.Equal);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier." + PRMSupplierView_CustomEntity.FLD_NAME_SupplierTypeID, ddlSupplierTypeID.SelectedValue.ToString(), SQLMatchType.Equal);

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
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsPRMSupplier_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
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
