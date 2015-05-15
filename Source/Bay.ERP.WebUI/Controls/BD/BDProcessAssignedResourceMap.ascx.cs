// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public partial class BDProcessAssignedResourceMapControl : BaseControl
    {       
        #region Properties

        public Int64 _ProcessAssignedResourceMapID
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

        public BDProcessAssignedResourceMapEntity _BDProcessAssignedResourceMapEntity
        {
            get
            {
                BDProcessAssignedResourceMapEntity entity = new BDProcessAssignedResourceMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProcessAssignedResourceMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProcessAssignedResourceMapEntity CurrentBDProcessAssignedResourceMapEntity
        {
            get
            {
                if (_ProcessAssignedResourceMapID > 0)
                {
                    if (_BDProcessAssignedResourceMapEntity.ProcessAssignedResourceMapID != _ProcessAssignedResourceMapID)
                    {
                        _BDProcessAssignedResourceMapEntity = FCCBDProcessAssignedResourceMap.GetFacadeCreate().GetByID(_ProcessAssignedResourceMapID);
                    }
                }

                return _BDProcessAssignedResourceMapEntity;
            }
            set
            {
                _BDProcessAssignedResourceMapEntity = value;
            }
        }

        public Int64 OverviewProcessAssignedResourceID
        {
            get
            {
                Int64 templateID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_ID], out templateID);
                }

                return templateID;
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
            BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = CurrentBDProcessAssignedResourceMapEntity;


            if (!bDProcessAssignedResourceMapEntity.IsNew)
            {
              
            }
        }

        private void BindList()
        {
            BindBDProcessAssignedResourceMapList();
        }

        private void BindBDProcessAssignedResourceMapList()
        {
            lvBDProcessAssignedResourceMap.DataBind();
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

        protected void lvBDProcessAssignedResourceMap_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                BDProcessAssignedResourceMapEntity ent = (BDProcessAssignedResourceMapEntity)dataItem.DataItem;

                HyperLink hypEnvelopReport = (HyperLink)e.Item.FindControl("hypEnvelopReport");
                HyperLink hypLargeEvelopReport = (HyperLink)e.Item.FindControl("hypLargeEvelopReport");
                HyperLink hypLegalEnvelopReport = (HyperLink)e.Item.FindControl("hypLegalEnvelopReport");
                HyperLink hypTransmissionSheet = (HyperLink)e.Item.FindControl("hypTransmissionSheet");

                hypEnvelopReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.ENVELOP_REPORT, UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_MAP_ID, ent.ProcessAssignedResourceMapID.ToString()).ToString();
                hypLargeEvelopReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.LARGE_ENVELOP_REPORT, UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_MAP_ID, ent.ProcessAssignedResourceMapID.ToString()).ToString();
                hypLegalEnvelopReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.LEGEL_ENVELOP_REPORT, UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_MAP_ID, ent.ProcessAssignedResourceMapID.ToString()).ToString();
                hypTransmissionSheet.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.TRANSMISSION_SHEET_REPORT, UrlConstants.OVERVIEW_PROCESS_ASSIGNED_RESOURCE_MAP_ID, ent.ProcessAssignedResourceMapID.ToString()).ToString();

                hypEnvelopReport.Target = "_blank";
                hypLargeEvelopReport.Target = "_blank";
                hypLegalEnvelopReport.Target = "_blank";
                hypTransmissionSheet.Target = "_blank";
            }
        }

        protected void lvBDProcessAssignedResourceMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProcessAssignedResourceMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProcessAssignedResourceMapID);

            if (ProcessAssignedResourceMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProcessAssignedResourceMapID = ProcessAssignedResourceMapID;
                 
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceMapID, ProcessAssignedResourceMapID.ToString(), SQLMatchType.Equal);

                        BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();


                        result = FCCBDProcessAssignedResourceMap.GetFacadeCreate().Delete(bDProcessAssignedResourceMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProcessAssignedResourceMapID = 0;
                            _BDProcessAssignedResourceMapEntity = new BDProcessAssignedResourceMapEntity();
                            PrepareInitialView();
                            BindBDProcessAssignedResourceMapList();

                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Process Assigned Resource Map.", true);
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

        protected void odsBDProcessAssignedResourceMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (OverviewProcessAssignedResourceID > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceID, OverviewProcessAssignedResourceID.ToString(), SQLMatchType.Equal);
            }
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event
    

        #endregion

        #endregion Event
    }
}
