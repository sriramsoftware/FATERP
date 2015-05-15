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
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class INVStoreIssueNoteItemMapReportControl : BaseControl
    {       
        #region Properties

        public String Action
        {
            get
            {
                String action = null;

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public Int64 _StoreIssueNoteItemMapID
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

        public INVStoreIssueNoteItemMapEntity _INVStoreIssueNoteItemMapEntity
        {
            get
            {
                INVStoreIssueNoteItemMapEntity entity = new INVStoreIssueNoteItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVStoreIssueNoteItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVStoreIssueNoteItemMapEntity CurrentINVStoreIssueNoteItemMapEntity
        {
            get
            {
                if (_StoreIssueNoteItemMapID > 0)
                {
                    if (_INVStoreIssueNoteItemMapEntity.StoreIssueNoteItemMapID != _StoreIssueNoteItemMapID)
                    {
                        _INVStoreIssueNoteItemMapEntity = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().GetByID(_StoreIssueNoteItemMapID);
                    }
                }

                return _INVStoreIssueNoteItemMapEntity;
            }
            set
            {
                _INVStoreIssueNoteItemMapEntity = value;
            }
        }

        public Int64 INVStoreIssueNoteID
        {
            get
            {
                Int64 _iNVStoreIssueNoteID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_STORE_ISSUE_NOTE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_STORE_ISSUE_NOTE_ID], out _iNVStoreIssueNoteID);
                }

                return _iNVStoreIssueNoteID;
            }
        }

        private INVStoreIssueNoteEntity CurrentINVStoreIssueNoteEntity
        {
            get
            {
                INVStoreIssueNoteEntity _iNVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();

                if (INVStoreIssueNoteID > 0)
                {
                    _iNVStoreIssueNoteEntity = FCCINVStoreIssueNote.GetFacadeCreate().GetByID(INVStoreIssueNoteID);
                }

                return _iNVStoreIssueNoteEntity;
            }
        }

        private INVTRFStoreIssueNoteMapEntity CurrentTRFStoreIssueNoteMapEntity 
        {
            get
            {
                IList<INVTRFStoreIssueNoteMapEntity> _iNVTRFStoreIssueNoteMapEntity = new List<INVTRFStoreIssueNoteMapEntity>();

                INVTRFStoreIssueNoteMapEntity TRFStoreIssueNoteMapEntity = null;

                if (INVStoreIssueNoteID > 0)
                {
                    String fe_TRFSIN = SqlExpressionBuilder.PrepareFilterExpression(INVTRFStoreIssueNoteMapEntity.FLD_NAME_StoreIssueNoteID, INVStoreIssueNoteID.ToString(), SQLMatchType.Equal);
                    _iNVTRFStoreIssueNoteMapEntity = FCCINVTRFStoreIssueNoteMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_TRFSIN, DatabaseOperationType.LoadWithFilterExpression);

                    if (_iNVTRFStoreIssueNoteMapEntity != null && _iNVTRFStoreIssueNoteMapEntity.Count > 0)
                    {
                        TRFStoreIssueNoteMapEntity = _iNVTRFStoreIssueNoteMapEntity[0];
                    }
                }

                return TRFStoreIssueNoteMapEntity;
            }
        }


        
        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateHREmployee(ddlReceivedByEmployeeID, true);
            MiscUtil.PopulateMDItem(ddlItemID, true);
        }

        private void PrepareValidator()
        {
        }

        private void EnableDropDownSelectedIndexChanged()
        {
            MiscUtil.PopulateINVStoreIssueNoteItemBystoreIssueNoteID(ddlItemID, false, INVStoreIssueNoteID);
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            btnSearch.Visible = true;
        }
        
        private void PrepareEditView()
        {
        }

        private void BindList()
        {
            BindINVStoreIssueNoteItemMapList();
        }

        private void BindINVStoreIssueNoteItemMapList()
        {
            lvINVStoreIssueNoteItemMap.DataBind();
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

        protected void lvINVStoreIssueNoteItemMap_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                INVStoreIssueNoteItemMap_RPTEntity ent = (INVStoreIssueNoteItemMap_RPTEntity)dataItem.DataItem;

                HyperLink lnkItemDetails = (HyperLink)e.Item.FindControl("lnkItemDetails");

                lnkItemDetails.NavigateUrl = UrlHelper.BuildSecureUrl("~/INV/INVStoreIssueNoteItemMapDetails.aspx", string.Empty, UrlConstants.OVERVIEW_ITEM_ID, ent.ItemID.ToString(),UrlConstants.OVERVIEW_EMPLOYEE_ID, ent.RequestedByEmployeeID.ToString(), UrlConstants.OVERVIEW_STORE_UNIT_ID,ent.IssuedFromStoreUnitID.ToString()).ToString();

                lnkItemDetails.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsINVStoreIssueNoteItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (ViewState["SearchString"] != null)
            {
                fe = (String)ViewState["SearchString"];
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String fe = String.Empty;

            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNoteItemMap." + INVStoreIssueNoteItemMap_RPTEntity.FLD_NAME_ItemID, ddlItemID.SelectedValue.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNote." + INVStoreIssueNoteItemMap_RPTEntity.FLD_NAME_RequestedByEmployeeID, ddlReceivedByEmployeeID.SelectedValue.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            ViewState["SearchString"] = fe;
            BindList();
           
        }

        #endregion

        #endregion Event
    }
}
