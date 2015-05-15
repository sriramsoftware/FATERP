// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 02:08:21




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
    public partial class ACTemporaryJournalControl : BaseControl
    {       
        #region Properties

        public Int64 _TemporaryJournalID
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

        public ACTemporaryJournalEntity _ACTemporaryJournalEntity
        {
            get
            {
                ACTemporaryJournalEntity entity = new ACTemporaryJournalEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACTemporaryJournalEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACTemporaryJournalEntity CurrentACTemporaryJournalEntity
        {
            get
            {
                if (_TemporaryJournalID > 0)
                {
                    if (_ACTemporaryJournalEntity.TemporaryJournalID != _TemporaryJournalID)
                    {
                        _ACTemporaryJournalEntity = FCCACTemporaryJournal.GetFacadeCreate().GetByID(_TemporaryJournalID);
                    }
                }

                return _ACTemporaryJournalEntity;
            }
            set
            {
                _ACTemporaryJournalEntity = value;
            }
        }

        public Int64 OverviewTemporaryJournalID
        {
            get
            {
                Int64 acTemporaryJournalID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID], out acTemporaryJournalID);
                }

                return acTemporaryJournalID;
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

   

        private void BindList()
        {
            BindACTemporaryJournalList();
        }

        private void BindACTemporaryJournalList()
        {
            lvACTemporaryJournal.DataBind();
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
            }
        }

        #endregion

        #region List View Event

        protected void lvACTemporaryJournal_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACTemporaryJournal_DetailedEntity ent = (ACTemporaryJournal_DetailedEntity)dataItem.DataItem;

                HyperLink hypRequisitionLV = (HyperLink)e.Item.FindControl("hypRequisitionLV");
                HyperLink hypWorkOrderLV = (HyperLink)e.Item.FindControl("hypWorkOrderLV");

                hypRequisitionLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.REQUISITION_REPORT, UrlConstants.REQUISITION_ID, ent.RequisitionID.ToString()).ToString();
                hypRequisitionLV.Target = "_blank";
                hypWorkOrderLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString()).ToString();
                hypWorkOrderLV.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACTemporaryJournal_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("ACTemporaryJournal." + ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalMasterID, this.OverviewTemporaryJournalID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
