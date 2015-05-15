// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 04:59:58




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
    public partial class CRMPaymentScheduleListControl : BaseControl
    {       
        #region Properties

        public Int64 _PaymentScheduleID
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

        public CRMPaymentScheduleEntity _CRMPaymentScheduleEntity
        {
            get
            {
                CRMPaymentScheduleEntity entity = new CRMPaymentScheduleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMPaymentScheduleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMPaymentScheduleEntity CurrentCRMPaymentScheduleEntity
        {
            get
            {
                if (_PaymentScheduleID > 0)
                {
                    if (_CRMPaymentScheduleEntity.PaymentScheduleID != _PaymentScheduleID)
                    {
                        _CRMPaymentScheduleEntity = FCCCRMPaymentSchedule.GetFacadeCreate().GetByID(_PaymentScheduleID);
                    }
                }

                return _CRMPaymentScheduleEntity;
            }
            set
            {
                _CRMPaymentScheduleEntity = value;
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
            BindCRMPaymentScheduleList();
        }

        private void BindCRMPaymentScheduleList()
        {
            lvCRMPaymentSchedule.DataBind();
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

        protected void lvCRMPaymentSchedule_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMPaymentSchedule_DetailedEntity ent = (CRMPaymentSchedule_DetailedEntity)dataItem.DataItem;

                HyperLink hypReport = (HyperLink)e.Item.FindControl("hypReport");
                HyperLink hypPaymentCollectionReport = (HyperLink)e.Item.FindControl("hypPaymentCollectionReport");

                hypPaymentCollectionReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.PAYMENT_COLLECTION_REPORT, UrlConstants.OVERVIEW_PAYMENT_SCHEDULE_ID, ent.PaymentScheduleID.ToString()).ToString();
                hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.PAYMENT_SCHEDULE_REPORT, UrlConstants.OVERVIEW_PAYMENT_SCHEDULE_ID, ent.PaymentScheduleID.ToString()).ToString();

                hypReport.Target = "_blank";
                hypPaymentCollectionReport.Target = "_blank";
            }
        }

        protected void lvCRMPaymentSchedule_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PaymentScheduleID;

            Int64.TryParse(e.CommandArgument.ToString(), out PaymentScheduleID);

            if (PaymentScheduleID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PaymentScheduleID = PaymentScheduleID;

                    String url = UrlHelper.BuildSecureUrl("~/CRM/CRMPaymentSchedule.aspx",
                        string.Empty,"do","Edit", UrlConstants.OVERVIEW_PAYMENT_SCHEDULE_ID,
                        PaymentScheduleID.ToString()).ToString();
                    Response.Redirect(url);
                }

                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleEntity.FLD_NAME_PaymentScheduleID, PaymentScheduleID.ToString(), SQLMatchType.Equal);

                        CRMPaymentScheduleEntity cRMPaymentScheduleEntity = new CRMPaymentScheduleEntity();

                        result = FCCCRMPaymentSchedule.GetFacadeCreate().Delete(cRMPaymentScheduleEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PaymentScheduleID = 0;
                            _CRMPaymentScheduleEntity = new CRMPaymentScheduleEntity();
                            PrepareInitialView();
                            BindCRMPaymentScheduleList();

                            MiscUtil.ShowMessage(lblMessage, "Payment Schedule has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Payment Schedule.", true);
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

        protected void odsCRMPaymentSchedule_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                //
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MDRequisitionStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event
        
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
