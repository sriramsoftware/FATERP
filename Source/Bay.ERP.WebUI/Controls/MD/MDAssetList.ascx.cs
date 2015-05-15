// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jan-2012, 04:11:49




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
using System.Web.Security;
using Bay.ERP.Web.UI.Manager;
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class MDAssetListControl : ProjectBaseControl
    {       
        #region Properties

        public String PageListType { get; set; }

        public Int64 _AssetID
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

        public MDAssetEntity _MDAssetEntity
        {
            get
            {
                MDAssetEntity entity = new MDAssetEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAssetEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAssetEntity CurrentMDAssetEntity
        {
            get
            {
                if (_AssetID  > 0)
                {
                    if (_MDAssetEntity.AssetID != _AssetID)
                    {
                        _MDAssetEntity = FCCMDAsset.GetFacadeCreate().GetByID(_AssetID);
                    }
                }

                return _MDAssetEntity;
            }
            set
            {
                _MDAssetEntity = value;
            }
        }

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
         BuildDropDownList();
        }

        private void PrepareEditView()
        {
            MDAssetEntity mDAssetEntity = CurrentMDAssetEntity;
        }

        private void BindList()
        {
            BindMDAssetList();
        }

        private void BindMDAssetList()
        {
            lvMDAsset.DataBind();
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

        protected void lvMDAsset_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            //if (e.Item.ItemType == ListViewItemType.DataItem)
            //{

            //    ListViewDataItem dataItem = (ListViewDataItem)e.Item;

            //    MDAsset_DetailedEntity ent = (MDAsset_DetailedEntity)dataItem.DataItem;

            //    //HyperLink hypEdit = (HyperLink)e.Item.FindControl("lnkBtnEdit");
            //    //HyperLink hypRequisitionReport = (HyperLink)e.Item.FindControl("hypRequisitionReport");

            //    //hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/MD/MDAsset.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_ASSET_ID, ent.AssetID.ToString()).ToString();
         
            //    //hypEdit.Target = "_blank";
            //}
        }

        protected void lvMDAsset_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsMDAsset_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CategoryName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("AssetName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("CMConsultant.Name", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
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
