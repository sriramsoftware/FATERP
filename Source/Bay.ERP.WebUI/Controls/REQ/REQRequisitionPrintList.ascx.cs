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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionPrintListControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _RequisitionID
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

        public REQRequisitionEntity _REQRequisitionEntity
        {
            get
            {
                REQRequisitionEntity entity = new REQRequisitionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (REQRequisitionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private REQRequisitionEntity CurrentREQRequisitionEntity
        {
            get
            {
                if (_RequisitionID > 0)
                {
                    if (_REQRequisitionEntity.RequisitionID != _RequisitionID)
                    {
                        _REQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(_RequisitionID);
                    }
                }

                return _REQRequisitionEntity;
            }
            set
            {
                _REQRequisitionEntity = value;
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
            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;
        }

        private void BindList()
        {
            BindREQRequisitionList();
        }

        private void BindREQRequisitionList()
        {
            lvREQRequisition.DataBind();
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

        protected void lvREQRequisition_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                REQRequisition_DetailedEntity ent = (REQRequisition_DetailedEntity)dataItem.DataItem;

                HyperLink hypRequisition = (HyperLink)e.Item.FindControl("hypRequisition");
                HyperLink hypEdit = (HyperLink)e.Item.FindControl("lnkBtnEdit");
                HyperLink hypRequisitionReport = (HyperLink)e.Item.FindControl("hypRequisitionReport");
                hypRequisitionReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "RequisitionReport", UrlConstants.REQUISITION_ID, ent.RequisitionID.ToString()).ToString();

                hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisition.aspx", string.Empty, "do", "Edit", UrlConstants.REQUISITION_ID, ent.RequisitionID.ToString()).ToString();
                if (this.OverviewProjectID > 0)
                {
                    hypRequisition.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectRequisitionItem.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo, ent.RequisitionNo.ToString()).ToString();
                }
                else
                {
                    hypRequisition.NavigateUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionItem.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, this.OverviewProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo,ent.RequisitionNo.ToString()).ToString();
                }
                hypEdit.Target = "_blank";
                hypRequisitionReport.Target = "_blank";
            }
        }

        protected void lvREQRequisition_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionID);

            if (RequisitionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _RequisitionID = RequisitionID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "ReportRequisition"))
                {

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionID, RequisitionID.ToString(), SQLMatchType.Equal);

                        REQRequisitionEntity rEQRequisitionEntity = new REQRequisitionEntity();


                        result = FCCREQRequisition.GetFacadeCreate().Delete(rEQRequisitionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RequisitionID = 0;
                            _REQRequisitionEntity = new REQRequisitionEntity();
                            PrepareInitialView();
                            BindREQRequisitionList();

                            MiscUtil.ShowMessage(lblMessage, "Requisition has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Requisition.", true);
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

        protected void odsREQRequisition_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            if (this.OverviewProjectID > 0)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #endregion Event
    }
}
