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
    public partial class PRMSupplierListControl : SupplierBaseControl
    {   

        #region Methods

        private void BuildDropDownList()
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

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        #endregion

        #region List View Event

        protected void lvPRMSupplier_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMSupplier_DetailedEntity ent = (PRMSupplier_DetailedEntity)dataItem.DataItem;

                HyperLink hypSupplier = (HyperLink)e.Item.FindControl("hypSupplier");

                hypSupplier.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierEditor.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, ent.SupplierID.ToString()).ToString();
                hypSupplier.Target = "_blank";
            }
        }

        protected void lvPRMSupplier_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierID);

            if (SupplierID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierEntity.FLD_NAME_SupplierID, SupplierID.ToString(), SQLMatchType.Equal);

                        PRMSupplierEntity pRMSupplierEntity = new PRMSupplierEntity();


                        result = FCCPRMSupplier.GetFacadeCreate().Delete(pRMSupplierEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                          
                        }
                        else
                        {
                         
                        }
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsPRMSupplier_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier.SupplierName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier.Email", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
            }

            e.InputParameters["filterExpression"] = fe;
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
