// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jun-2010, 07:39:49




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
    public partial class UserList_DetailedControlListCustom : BaseControl
    {
        #region Member Variables

        #endregion

        #region Properties

        #endregion

        #region Methods

        private void BindList()
        {
            BindUserList_DetailedList();
        }

        private void BindUserList_DetailedList()
        {
            //odsUserList_Detailed.SelectParameters["pageSize"].Type = TypeCode.Int32;
            //odsUserList_Detailed.SelectParameters["pageSize"].DefaultValue = "";
            //odsUserList_Detailed.SelectParameters["currentPage"].Type = TypeCode.Int32;
            //odsUserList_Detailed.SelectParameters["currentPage"].DefaultValue = "";
            //odsUserList_Detailed.SelectParameters["sortExpression"].Type = TypeCode.String;
            //odsUserList_Detailed.SelectParameters["sortExpression"].DefaultValue = "";
            //odsUserList_Detailed.SelectParameters["filterExpression"].Type = TypeCode.String;
            //odsUserList_Detailed.SelectParameters["filterExpression"].DefaultValue = "";

            rgUserList_Detailed.DataBind();
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    lblTotalUser.Text = "0";

                    String sortExpression = SqlExpressionBuilder.PrepareSortExpression(UserList_DetailedEntity.FLD_NAME_UserName, SQLSortOrderType.Assending);

                    lblTotalUser.Text = FCCUserList_Detailed.GetFacadeCreate().GetIL(1000000, 1, sortExpression, String.Empty).Count.ToString();
                }
                catch (Exception ex)
                { 
                }
            }
        }

        #endregion

        #region Listview Event

        protected void rgUserList_Detailed_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                UserList_DetailedEntity ent = (UserList_DetailedEntity)dataItem.DataItem;
                
                HyperLink hypEditAccess = (HyperLink)e.Item.FindControl("hypEditAccess");
                HyperLink hypBlockUser = (HyperLink)e.Item.FindControl("hypBlockUser");
                hypBlockUser.NavigateUrl = UrlHelper.BuildSecureUrl("~/Security/BlockUser.aspx", string.Empty, UrlConstants.OVERVIEW_MEMBER_ID, ent.MemberID.ToString()).ToString();
                hypEditAccess.NavigateUrl = UrlHelper.BuildSecureUrl("~/Security/CreateUserIdAndPassword.aspx", string.Empty, UrlConstants.OVERVIEW_MEMBER_ID, ent.MemberID.ToString()).ToString();
                hypEditAccess.Target = "_blank";
                hypBlockUser.Target = "_blank";
            }
        }

        #endregion

        #region Rad Grid Event


        protected void rgASDashBoardInfo_ItemCommand(object source, ListViewItemEventArgs e)
        {
            rgUserList_Detailed.DataBind();
        }
        #endregion Rad Grid Event

        #region ObjectDataSource Event
        
        protected void odsUserList_Detailed_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String filterExpression = String.Empty;
            
            if (ViewState["filterExpression"] != null)
            {
                filterExpression = ViewState["filterExpression"].ToString();
            }

            e.InputParameters["filterExpression"] = filterExpression;
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String filterExpression = String.Empty;

            if (txtName.Text.Trim().IsNotNullOrEmpty())
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("FirstName", txtName.Text.Trim(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MiddleName", txtName.Text.Trim(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("LastName", txtName.Text.Trim(), SQLMatchType.LikeWithBothMath); 
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1 , SQLJoinType.OR, fe2);

                filterExpression = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.OR, fe3); 
            }

            if (txtUserId.Text.Trim().IsNotNullOrEmpty())
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression("UserName", txtUserId.Text.Trim(), SQLMatchType.LikeWithBothMath);

                if (filterExpression.IsNotNullOrEmpty())
                {
                    filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression, SQLJoinType.AND, fe);
                }
                else
                {
                    filterExpression = fe;
                }
            }

            if (txtRole.Text.Trim().IsNotNullOrEmpty())
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression("RoleName", txtRole.Text.Trim(), SQLMatchType.Equal);

                if (filterExpression.IsNotNullOrEmpty())
                {
                    filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression, SQLJoinType.AND, fe);
                }
                else
                {
                    filterExpression = fe;
                }
            }

            ViewState["filterExpression"] = filterExpression;

            rgUserList_Detailed.DataBind();
        }

        #endregion

        #region Filter DropdownList Event

        #endregion

        #endregion Event
    }
}
