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
    public partial class ACBankAccountDepositListControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountDepositID
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

        public ACBankAccountDepositEntity _ACBankAccountDepositEntity
        {
            get
            {
                ACBankAccountDepositEntity entity = new ACBankAccountDepositEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountDepositEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountDepositEntity CurrentACBankAccountDepositEntity
        {
            get
            {
                if (_BankAccountDepositID > 0)
                {
                    if (_ACBankAccountDepositEntity.BankAccountDepositID != _BankAccountDepositID)
                    {
                        _ACBankAccountDepositEntity = FCCACBankAccountDeposit.GetFacadeCreate().GetByID(_BankAccountDepositID);
                    }
                }

                return _ACBankAccountDepositEntity;
            }
            set
            {
                _ACBankAccountDepositEntity = value;
            }
        }

        public IList<ACBankAccountDepositItem_DetailedEntity> CurrentACBankAccountDepositItemList
        {
            get
            {
                return (IList<ACBankAccountDepositItem_DetailedEntity>)ViewState["vs_CurrentACBankAccountDepositItemList"];
            }
            set
            {
                ViewState["vs_CurrentACBankAccountDepositItemList"] = value;
            }
        }

        public Int64 _BankAccountDepositItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["BankAccountDepositItemID"] != null)
                {
                    Int64.TryParse(ViewState["BankAccountDepositItemID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["BankAccountDepositItemID"] = value;
            }
        }

        public ACBankAccountDepositItem_DetailedEntity _ACBankAccountDepositItemEntity
        {
            get
            {
                ACBankAccountDepositItem_DetailedEntity entity = new ACBankAccountDepositItem_DetailedEntity();

                if (ViewState["Current_ACBankAccountDepositItemEntity"] != null)
                {
                    entity = (ACBankAccountDepositItem_DetailedEntity)ViewState["Current_ACBankAccountDepositItemEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["Current_ACBankAccountDepositItemEntity"] = value;
            }
        }

        private ACBankAccountDepositItem_DetailedEntity CurrentACBankAccountDepositItemEntity
        {
            get
            {
                if (_BankAccountDepositItemID > 0)
                {
                    if (_ACBankAccountDepositItemEntity.BankAccountDepositItemID != _BankAccountDepositItemID)
                    {   
                        _ACBankAccountDepositItemEntity = (from s in CurrentACBankAccountDepositItemList
                                                           where s.BankAccountDepositItemID == _BankAccountDepositItemID
                                                           select s).FirstOrDefault();
                    }
                }

                return _ACBankAccountDepositItemEntity;
            }
            set
            {
                _ACBankAccountDepositItemEntity = value;
            }
        }

        public Int64 _bankAccountDepositID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["bankAccountDepositID"] != null)
                {
                    Int64.TryParse(ViewState["bankAccountDepositID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["bankAccountDepositID"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
        }

        private void BuildDropDownListDepositeItem()
        {
         
        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidationInput()
        {
            Boolean flag=true;

            if (CurrentACBankAccountDepositItemList.Count <= 0)
            {   
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Please Make at least one Bank Account Deposit Information.", true);
            }

            return flag;
        }

        private void BindList()
        {
            BindACBankAccountDepositList();
        }

        private void BindACBankAccountDepositList()
        {
            lvACBankAccountDeposit.DataBind();
        }

        private void BindACBankAccountDepositItemList()
        {
          
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                PrepareValidator();
               // PrepareInitialView();
               // PrepareInitialViewDepositeItem();
              //  PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvACBankAccountDeposit_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACBankAccountDeposit_DetailedEntity ent = (ACBankAccountDeposit_DetailedEntity)dataItem.DataItem;

                HyperLink hypReferenceLV = (HyperLink)e.Item.FindControl("hypReferenceLV");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                HyperLink hypDepositReport = (HyperLink)e.Item.FindControl("hypDepositReport");

                hypDepositReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BANK_ACCOUNT_DEPOSIT_REPORT, UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID, ent.BankAccountDepositID.ToString()).ToString();

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BANK_DEPOSIT, ent.BankAccountDepositID);
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

                String feItem = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountDepositItem." + ACBankAccountDepositItemEntity.FLD_NAME_BankAccountDepositID, ent.BankAccountDepositID.ToString(), SQLMatchType.Equal);
                IList<ACBankAccountDepositItem_DetailedEntity> lst = FCCACBankAccountDepositItem_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, feItem);

                if (lst != null && lst.Count > 0)
                {
                    Panel pnlOtherInfo = (Panel)e.Item.FindControl("pnlOtherInfo");

                    foreach (ACBankAccountDepositItem_DetailedEntity aCBankAccountDepositItemEntity in lst)
                    {
                        lblDetailLV.Text += aCBankAccountDepositItemEntity.AccountName + ", ";

                        if (aCBankAccountDepositItemEntity.RequisitionID > 0)
                        {
                            HyperLink hypRequisitionLV = new HyperLink();
                            String st = "Requisition :";
                            hypRequisitionLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCBankAccountDepositItemEntity.RequisitionNo;
                            hypRequisitionLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.REQUISITION_REPORT, UrlConstants.REQUISITION_ID, aCBankAccountDepositItemEntity.RequisitionID.ToString()).ToString();
                            hypRequisitionLV.Target = "_blank";
                            hypRequisitionLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypRequisitionLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }

                        if (aCBankAccountDepositItemEntity.WorkOrderID > 0)
                        {
                            HyperLink hypWorkOrderLV = new HyperLink();
                            String st = "Work Order :";
                            hypWorkOrderLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCBankAccountDepositItemEntity.WorkOrderNo;
                            hypWorkOrderLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, aCBankAccountDepositItemEntity.WorkOrderID.ToString()).ToString();
                            hypWorkOrderLV.Target = "_blank";
                            hypWorkOrderLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypWorkOrderLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }

                        if (aCBankAccountDepositItemEntity.BillID > 0)
                        {
                            HyperLink hypBillLV = new HyperLink();
                            String st = "Bill :";
                            hypBillLV.Text = "<font color=\"black\"><b>" + st + "</font></b>" + aCBankAccountDepositItemEntity.BillNo;
                            hypBillLV.NavigateUrl = String.Empty;
                            hypBillLV.Target = "_blank";
                            hypBillLV.CssClass = "CommonButtonLink";
                            pnlOtherInfo.Controls.Add(hypBillLV);
                            pnlOtherInfo.Controls.Add(new LiteralControl("<br/>"));
                        }
                    }

                    lblDetailLV.Text = lblDetailLV.Text.Substring(0, lblDetailLV.Text.Length - 2);
                }

                hypReferenceLV.NavigateUrl = UrlHelper.BuildSecureUrl("~/AC/ACBankAccountDepositItem.aspx", string.Empty, UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID, ent.BankAccountDepositID.ToString()).ToString();
                hypReferenceLV.Target = "_blank";
                
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACBankAccountDeposit_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {   
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountDeposit.Reference", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccount.BankAccountName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountDeposit.Memo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
                fe = fe5;
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
            String fe = "ACBankAccountDeposit.DepositDate between '" + MiscUtil.ParseToDateTime(txtStartDate.Text.Trim().ToString()).ToString() + "' AND '" + MiscUtil.ParseToDateTime(txtEndDate.Text.Trim().ToString()).ToString() + "'";

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
