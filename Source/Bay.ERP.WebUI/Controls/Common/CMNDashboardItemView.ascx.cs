// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2012, 06:02:47




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.IO;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class CMNDashboardItemViewControl : BaseControl
    {       
        #region Properties

        public Int64 _DashboardItemID
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

        public CMNDashboardItemEntity _CMNDashboardItemEntity
        {
            get
            {
                CMNDashboardItemEntity entity = new CMNDashboardItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNDashboardItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNDashboardItemEntity CurrentCMNDashboardItemEntity
        {
            get
            {
                if (_DashboardItemID > 0)
                {
                    if (_CMNDashboardItemEntity.DashboardItemID != _DashboardItemID)
                    {
                        _CMNDashboardItemEntity = FCCCMNDashboardItem.GetFacadeCreate().GetByID(_DashboardItemID);
                    }
                }

                return _CMNDashboardItemEntity;
            }
            set
            {
                _CMNDashboardItemEntity = value;
            }
        }

        public Int64 DashboardItemID
        {
            get
            {
                Int64 dashboardItemID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_DASHBOARD_ITEM_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_DASHBOARD_ITEM_ID], out dashboardItemID);
                }

                return dashboardItemID;
            }
        }

        #endregion

        #region Methods

        private void PrepareInitialView()
        {
           
        }
        
        private void PrepareEditView()
        {
        
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

        #region List View Event

        protected void lvCMNDashboardItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMNDashboardItemEntity ent = (CMNDashboardItemEntity)dataItem.DataItem;

                HyperLink hypImgDashBoardItem = (HyperLink)e.Item.FindControl("hypImgDashBoardItem");
                hypImgDashBoardItem.NavigateUrl = UrlHelper.BuildSecureUrl((String)DataBinder.Eval(e.Item.DataItem, "NavigationUrl"), string.Empty, UrlConstants.OVERVIEW_DASHBOARD_ITEM_ID, ent.DashboardItemID.ToString()).ToString();

                HyperLink hypDashBoardItem = (HyperLink)e.Item.FindControl("hypDashBoardItem");
                hypDashBoardItem.NavigateUrl = UrlHelper.BuildSecureUrl((String)DataBinder.Eval(e.Item.DataItem,"NavigationUrl"), string.Empty, UrlConstants.OVERVIEW_DASHBOARD_ITEM_ID, ent.DashboardItemID.ToString()).ToString();

                ListView lvCMNDashboardItemQuicklink = (ListView)e.Item.FindControl("lvCMNDashboardItemQuicklink");

                String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemQuicklinkEntity.FLD_NAME_DashboardItemID, ent.DashboardItemID.ToString(), SQLMatchType.Equal);
                lvCMNDashboardItemQuicklink.DataSource = FCCCMNDashboardItemQuicklink.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                lvCMNDashboardItemQuicklink.DataBind();
            }
        }

        protected void lvCMNDashboardItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DashboardItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out DashboardItemID);

            if (DashboardItemID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DashboardItemID = DashboardItemID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemEntity.FLD_NAME_DashboardItemID, DashboardItemID.ToString(), SQLMatchType.Equal);

                        CMNDashboardItemEntity cMNDashboardItemEntity = FCCCMNDashboardItem.GetFacadeCreate().GetByID(DashboardItemID);


                        result = FCCCMNDashboardItem.GetFacadeCreate().Delete(cMNDashboardItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                     
                        if (result == 0)
                        {
                            if (File.Exists(Server.MapPath(cMNDashboardItemEntity.ImageUrl)))
                            {
                                File.Delete(Server.MapPath(cMNDashboardItemEntity.ImageUrl));
                            }
                            if (File.Exists(Server.MapPath(cMNDashboardItemEntity.HoverImageUrl)))
                            {
                                File.Delete(Server.MapPath(cMNDashboardItemEntity.HoverImageUrl));
                            }
                            _DashboardItemID = 0;
                            _CMNDashboardItemEntity = new CMNDashboardItemEntity();

                            PrepareInitialView();
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

        protected void odsCMNDashboardItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemEntity.FLD_NAME_ParentDashboardItemID, String.Empty, SQLMatchType.IsNull);

            if (DashboardItemID > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemEntity.FLD_NAME_ParentDashboardItemID,DashboardItemID.ToString(), SQLMatchType.Equal);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #endregion Event
    }
}
