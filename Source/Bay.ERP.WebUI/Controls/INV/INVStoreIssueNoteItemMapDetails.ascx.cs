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
    public partial class INVStoreIssueNoteItemMapDetailsControl : BaseControl
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

        public Int64 OverviewItemID
        {
            get
            {
                Int64 OverviewItemID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ITEM_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ITEM_ID], out OverviewItemID);
                }

                return OverviewItemID;
            }
        }

        public Int64 OverviewReceivedByEmployeeID
        {
            get
            {
                Int64 OverviewReceivedByEmployeeID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_EMPLOYEE_ID], out OverviewReceivedByEmployeeID);
                }

                return OverviewReceivedByEmployeeID;
            }
        }

        public Int64 OverviewIssuedFromStoreUnitID
        {
            get
            {
                Int64 OverviewIssuedFromStoreUnitID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_STORE_UNIT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_STORE_UNIT_ID], out OverviewIssuedFromStoreUnitID);
                }

                return OverviewIssuedFromStoreUnitID;
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

        protected void lvINVStoreIssueNoteItemMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 StoreIssueNoteItemMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out StoreIssueNoteItemMapID);

            if (StoreIssueNoteItemMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _StoreIssueNoteItemMapID = StoreIssueNoteItemMapID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteItemMapID, StoreIssueNoteItemMapID.ToString(), SQLMatchType.Equal);

                        INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();


                        result = FCCINVStoreIssueNoteItemMap.GetFacadeCreate().Delete(iNVStoreIssueNoteItemMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _StoreIssueNoteItemMapID = 0;
                            _INVStoreIssueNoteItemMapEntity = new INVStoreIssueNoteItemMapEntity();
                            PrepareInitialView();
                            BindINVStoreIssueNoteItemMapList();

                            MiscUtil.ShowMessage(lblMessage, "I NVStore Issue Note Item Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVStore Issue Note Item Map.", true);
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

        protected void odsINVStoreIssueNoteItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = string.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNoteItemMap." + INVStoreIssueNoteItemMap_DetailedEntity.FLD_NAME_ItemID, OverviewItemID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNoteItemMap." +INVStoreIssueNoteItemMap_DetailedEntity.FLD_NAME_ReceivedByEmployeeID, OverviewReceivedByEmployeeID.ToString(), SQLMatchType.Equal);
            String fe3 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNoteItemMap." + INVStoreIssueNoteItemMap_DetailedEntity.FLD_NAME_IssuedFromStoreUnitID, OverviewIssuedFromStoreUnitID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
