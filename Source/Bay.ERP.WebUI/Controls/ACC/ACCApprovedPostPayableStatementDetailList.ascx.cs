// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    public partial class ACCApprovedPostPayableStatementDetailListControl : BaseControl
    {       
        #region Properties

        public Int64 PageAPType { get; set; }

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
          
        }

        private void PrepareEditView()
        {
           
        }

        private void BindList()
        {
            BindACCPostPayableStatementDetailList();
        }

        private void BindACCPostPayableStatementDetailList()
        {
            lvACCPostPayableStatementDetail.DataBind();
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

        protected void lvACCPostPayableStatementDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACCPostPayableStatementDetail_DetailedEntity ent = (ACCPostPayableStatementDetail_DetailedEntity)dataItem.DataItem;

                HyperLink hypPostPayableStatementDetailIDLV = (HyperLink)e.Item.FindControl("hypPostPayableStatementDetailIDLV");

                hypPostPayableStatementDetailIDLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/ACC/ACCPostPayableStatementDetail.aspx", string.Empty,UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_ID, ent.PostPayableStatementID.ToString(), UrlConstants.OVERVIEW_POST_PAYABLE_STATEMENT_DETAIL_ID, ent.PostPayableStatementDetailID.ToString()).ToString();
                
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.PAYABLE_STATEMENT, ent.PostPayableStatementDetailID);
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
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACCPostPayableStatementDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("ACCPostPayableStatementDetail." + ACCPostPayableStatementDetailEntity.FLD_NAME_AccountPaybleStatementDetailCategoryID, PageAPType.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression("ACCPostPayableStatementDetail." + ACCPostPayableStatementDetailEntity.FLD_NAME_ACCPayableApprovalStatusID, MasterDataConstants.ACCPostPayableStatementApprovalStatus.INITIATED.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("ACCPostPayableStatementDetail.WorkOrderNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("ACCPostPayableStatementDetail.BillNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplier.SupplierName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe5);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe6);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

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
