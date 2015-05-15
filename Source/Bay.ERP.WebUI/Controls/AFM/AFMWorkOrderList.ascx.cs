// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
    public partial class AFMWorkOrderListControl : BaseControl
    {       
        #region Properties

        public Int64 _WorkOrderID
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

        public PRMWorkOrderEntity _PRMWorkOrderEntity
        {
            get
            {
                PRMWorkOrderEntity entity = new PRMWorkOrderEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMWorkOrderEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMWorkOrderEntity CurrentPRMWorkOrderEntity
        {
            get
            {
                if (_WorkOrderID > 0)
                {
                    if (_PRMWorkOrderEntity.WorkOrderID != _WorkOrderID)
                    {
                        _PRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(_WorkOrderID);
                    }
                }

                return _PRMWorkOrderEntity;
            }
            set
            {
                _PRMWorkOrderEntity = value;
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
            BindPRMWorkOrderList();
        }

        private void BindPRMWorkOrderList()
        {
            lvPRMWorkOrder.DataBind();
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

        protected void lvPRMWorkOrder_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMWorkOrder_DetailedEntity ent = (PRMWorkOrder_DetailedEntity)dataItem.DataItem;

                HyperLink hypWorkOrderReport = (HyperLink)e.Item.FindControl("hypWorkOrderReport");
                HyperLink hypWorkOrderAnnexureReport = (HyperLink)e.Item.FindControl("hypWorkOrderAnnexureReport");
                
                hypWorkOrderReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "WorkOrderReport", UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString()).ToString();
                hypWorkOrderAnnexureReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "WorkOrderReportWithAnnexure", UrlConstants.OVERVIEW_WORKORDER_ID, ent.WorkOrderID.ToString()).ToString();
                
                hypWorkOrderReport.Target = "_blank";
                hypWorkOrderAnnexureReport.Target = "_blank";
            }
        }

        protected void lvPRMWorkOrder_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkOrderID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderID);

            if (WorkOrderID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    String url = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrder.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, WorkOrderID.ToString()).ToString();

                    Response.Redirect(url);

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, WorkOrderID.ToString(), SQLMatchType.Equal);

                        PRMWorkOrderEntity pRMWorkOrderEntity = new PRMWorkOrderEntity();


                        result = FCCPRMWorkOrder.GetFacadeCreate().Delete(pRMWorkOrderEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkOrderID = 0;
                            _PRMWorkOrderEntity = new PRMWorkOrderEntity();
                            PrepareInitialView();
                            BindPRMWorkOrderList();

                            MiscUtil.ShowMessage(lblMessage, "Work Order has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order.", true);
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

        protected void odsPRMWorkOrder_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            fe = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrder." + PRMWorkOrderEntity.FLD_NAME_WorkOrderStatusID, MasterDataConstants.WorkOrderStatus.APPROVED.ToString(), SQLMatchType.Equal);

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
