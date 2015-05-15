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
using Bay.ERP.Web.UI.Manager;
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class ACTemporaryJournalMasterControl : BaseControl
    {       
        #region Properties

        public Int64 _TemporaryJournalMasterID
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

        public ACTemporaryJournalMasterEntity _ACTemporaryJournalMasterEntity
        {
            get
            {
                ACTemporaryJournalMasterEntity entity = new ACTemporaryJournalMasterEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACTemporaryJournalMasterEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACTemporaryJournalMasterEntity CurrentACTemporaryJournalMasterEntity
        {
            get
            {
                if (_TemporaryJournalMasterID > 0)
                {
                    if (_ACTemporaryJournalMasterEntity.TemporaryJournalMasterID != _TemporaryJournalMasterID)
                    {
                        _ACTemporaryJournalMasterEntity = FCCACTemporaryJournalMaster.GetFacadeCreate().GetByID(_TemporaryJournalMasterID);
                    }
                }

                return _ACTemporaryJournalMasterEntity;
            }
            set
            {
                _ACTemporaryJournalMasterEntity = value;
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
            BindACTemporaryJournalMasterList();
        }

        private void BindACTemporaryJournalMasterList()
        {
            lvACTemporaryJournalMaster.DataBind();
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

        protected void lvACTemporaryJournalMaster_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACTemporaryJournalMaster_DetailedEntity ent = (ACTemporaryJournalMaster_DetailedEntity)dataItem.DataItem;

                HyperLink hypCreateDate = (HyperLink)e.Item.FindControl("hypCreateDate");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                HyperLink hypJournalReport = (HyperLink)e.Item.FindControl("hypJournalReport");

                hypJournalReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.MANUAL_JOURNAL_REPORT, UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID, ent.TemporaryJournalMasterID.ToString()).ToString();

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.TEMPORARY_JOURNAL, ent.TemporaryJournalMasterID);
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

                Label lblDetailLV = (Label)e.Item.FindControl("lblDetailLV");

                String feItem = SqlExpressionBuilder.PrepareFilterExpression("ACTemporaryJournal." + ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalMasterID, ent.TemporaryJournalMasterID.ToString(), SQLMatchType.Equal);
                IList<ACTemporaryJournal_DetailedEntity> lst = FCCACTemporaryJournal_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, feItem);

                if (lst != null && lst.Count > 0)
                {
                    foreach (ACTemporaryJournal_DetailedEntity aCTemporaryJournal_DetailedEntity in lst)
                    {
                        lblDetailLV.Text += aCTemporaryJournal_DetailedEntity.ACAccountAccountName+ ", ";

                        Panel pnlOtherInfo = (Panel)e.Item.FindControl("pnlOtherInfo");

                        if (aCTemporaryJournal_DetailedEntity.RequisitionID > 0)
                        {
                            HyperLink hypRequisitionLV = new HyperLink();
                            String st = "Requisition :";
                            hypRequisitionLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCTemporaryJournal_DetailedEntity.RequisitionNo;
                            hypRequisitionLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.REQUISITION_REPORT, UrlConstants.REQUISITION_ID, aCTemporaryJournal_DetailedEntity.RequisitionID.ToString()).ToString();
                            hypRequisitionLV.Target = "_blank";
                            hypRequisitionLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypRequisitionLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }

                        if (aCTemporaryJournal_DetailedEntity.WorkOrderID > 0)
                        {
                            HyperLink hypWorkOrderLV = new HyperLink();
                            String st = "Work Order :";
                            hypWorkOrderLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCTemporaryJournal_DetailedEntity.WorkOrderNo;
                            hypWorkOrderLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, aCTemporaryJournal_DetailedEntity.WorkOrderID.ToString()).ToString();
                            hypWorkOrderLV.Target = "_blank";
                            hypWorkOrderLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypWorkOrderLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }

                        if (aCTemporaryJournal_DetailedEntity.BillID > 0)
                        {
                            HyperLink hypBillLV = new HyperLink();
                            String st = "Bill :";
                            hypBillLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCTemporaryJournal_DetailedEntity.BillNo;
                            hypBillLV.NavigateUrl = String.Empty;
                            hypBillLV.Target = "_blank";
                            hypBillLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypBillLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }
                    }

                    lblDetailLV.Text = lblDetailLV.Text.Substring(0, lblDetailLV.Text.Length - 2);
                }

                hypCreateDate.NavigateUrl = UrlHelper.BuildSecureUrl("~/AC/ACTemporaryJournal.aspx", string.Empty, UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID, ent.TemporaryJournalMasterID.ToString()).ToString();
                hypCreateDate.Target = "_blank";
                hypJournalReport.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACTemporaryJournalMaster_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
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
            String fe = "ACTemporaryJournalMaster.CreateDate between '" + MiscUtil.ParseToDateTime(txtStartDate.Text.Trim().ToString()).ToString() + "' AND '" + MiscUtil.ParseToDateTime(txtEndDate.Text.Trim().ToString()).ToString() + "'";

            //if (ddlProjectID != null && ddlProjectID.SelectedValue != "0")
            //{
            //    String fe2 = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive." + PRMMaterialReceiveEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);

            //    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe2);
            //}

            ViewState["SearchString"] = fe;

            BindList();
        }

        protected void btnClearSearch_Click(object sender, EventArgs e)
        {
            ViewState["SearchString"] = null;
            BindList();
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
