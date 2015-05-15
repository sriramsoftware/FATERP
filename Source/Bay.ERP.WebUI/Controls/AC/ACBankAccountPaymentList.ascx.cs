// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
using Bay.ERP.Web.UI.Manager;
using System.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class ACBankAccountPaymentListControl : BaseControl
    {
        #region Extra Field Properties

        public Int64 PageAPType { get; set; }

        #endregion

        #region Properties

        public Int64 _BankAccountPaymentID
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

        public ACBankAccountPaymentEntity _ACBankAccountPaymentEntity
        {
            get
            {
                ACBankAccountPaymentEntity entity = new ACBankAccountPaymentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountPaymentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {

        }

        private void BuildDropDownListPaymentItem()
        {
            
        }

        private void PrepareInitialViewPaymentItem()
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
            BindACBankAccountPaymentList();
        }

        private void BindACBankAccountPaymentList()
        {
            lvACBankAccountPayment.DataBind();
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

        protected void lvACBankAccountPayment_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACBankAccountPayment_DetailedEntity ent = (ACBankAccountPayment_DetailedEntity)dataItem.DataItem;

                HyperLink hypReference = (HyperLink)e.Item.FindControl("hypReference");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                Label lblDetailLV = (Label)e.Item.FindControl("lblDetailLV");

                HyperLink hypPaymentReport = (HyperLink)e.Item.FindControl("hypPaymentReport");
                hypPaymentReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BANK_ACCOUNT_PAYMENT_REPORT, UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID, ent.BankAccountPaymentID.ToString()).ToString();

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BANK_PAYMENT, ent.BankAccountPaymentID);

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

                String feItem = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountPaymentItem." + ACBankAccountPaymentItemEntity.FLD_NAME_BankAccountPaymentID, ent.BankAccountPaymentID.ToString(), SQLMatchType.Equal);
                IList<ACBankAccountPaymentItem_DetailedEntity> lst = FCCACBankAccountPaymentItem_Detailed.GetFacadeCreate().GetIL(10000,1,String.Empty,feItem);

                if (lst != null && lst.Count > 0)
                {
                    foreach (ACBankAccountPaymentItem_DetailedEntity aCBankAccountPaymentItemEntity in lst)
                    {
                        lblDetailLV.Text += aCBankAccountPaymentItemEntity.AccountName+ ", ";

                        Panel pnlOtherInfo = (Panel)e.Item.FindControl("pnlOtherInfo");

                        if (aCBankAccountPaymentItemEntity.RequisitionID > 0)
                        {
                            HyperLink hypRequisitionLV = new HyperLink(); 
                            String st = "Requisition :";
                            hypRequisitionLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCBankAccountPaymentItemEntity.RequisitionNo;
                            hypRequisitionLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.REQUISITION_REPORT, UrlConstants.REQUISITION_ID, aCBankAccountPaymentItemEntity.RequisitionID.ToString()).ToString();
                            hypRequisitionLV.Target = "_blank";
                            hypRequisitionLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypRequisitionLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }

                        if (aCBankAccountPaymentItemEntity.WorkOrderID > 0)
                        {
                            HyperLink hypWorkOrderLV = new HyperLink();
                            String st = "Work Order :";
                            hypWorkOrderLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCBankAccountPaymentItemEntity.WorkOrderNo;
                            hypWorkOrderLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, aCBankAccountPaymentItemEntity.WorkOrderID.ToString()).ToString();
                            hypWorkOrderLV.Target = "_blank";
                            hypWorkOrderLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypWorkOrderLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }

                        if (aCBankAccountPaymentItemEntity.BillID > 0)
                        {
                            HyperLink hypBillLV = new HyperLink();
                            String st = "Bill :";
                            hypBillLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCBankAccountPaymentItemEntity.BillNo;
                            hypBillLV.NavigateUrl = String.Empty;
                            hypBillLV.Target = "_blank";
                            hypBillLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypBillLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }
                    }

                    lblDetailLV.Text = lblDetailLV.Text.Substring(0, lblDetailLV.Text.Length - 2);
                }

                hypReference.NavigateUrl = UrlHelper.BuildSecureUrl("~/AC/ACBankAccountPaymentItem.aspx", string.Empty, UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID, ent.BankAccountPaymentID.ToString()).ToString();

                hypReference.Target = "_blank";
                hypPaymentReport.Target = "_blank";

            }
        }
        
        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACBankAccountPayment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (PageAPType.ToString().IsNotNullOrEmpty())
            {
                if (PageAPType == MasterDataConstants.ACPaymentType.BANK_ACCOUNT_PAYMENT)
                {
                    fe = "ACBankAccountPayment." + ACBankAccountPaymentEntity.FLD_NAME_BankAccountID + " <> 3";
                    //"3" Here works as Cash Account -- Should change if requires any change to cash account ID 
                }
                else if (PageAPType == MasterDataConstants.ACPaymentType.CASH_PAYMENT)
                {
                    fe = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountPayment."+ACBankAccountPaymentEntity.FLD_NAME_BankAccountID, "3", SQLMatchType.Equal);
                    //"3" Here works as Cash Account -- Should change if requires any change to cash account ID 
                }
            }

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountPayment.Reference", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount.BankAccountName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountPayment.Memo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe5);
            }

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
            String fe = "ACBankAccountPayment.PaymentDate between '" + MiscUtil.ParseToDateTime(txtStartDate.Text.Trim().ToString()).ToString() + "' AND '" + MiscUtil.ParseToDateTime(txtEndDate.Text.Trim().ToString()).ToString() + "'";

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
