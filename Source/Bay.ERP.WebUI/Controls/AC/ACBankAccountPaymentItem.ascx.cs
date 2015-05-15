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

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ACBankAccountPaymentItemControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountPaymentItemID
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

        public ACBankAccountPaymentItemEntity _ACBankAccountPaymentItemEntity
        {
            get
            {
                ACBankAccountPaymentItemEntity entity = new ACBankAccountPaymentItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountPaymentItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountPaymentItemEntity CurrentACBankAccountPaymentItemEntity
        {
            get
            {
                if (_BankAccountPaymentItemID > 0)
                {
                    if (_ACBankAccountPaymentItemEntity.BankAccountPaymentItemID != _BankAccountPaymentItemID)
                    {
                        _ACBankAccountPaymentItemEntity = FCCACBankAccountPaymentItem.GetFacadeCreate().GetByID(_BankAccountPaymentItemID);
                    }
                }

                return _ACBankAccountPaymentItemEntity;
            }
            set
            {
                _ACBankAccountPaymentItemEntity = value;
            }
        }

        public Int64 OverviewACBankAccountPaymentID
        {
            get
            {
                Int64 acBankAccountPaymentID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_PAYMENT_ID], out acBankAccountPaymentID);
                }

                return acBankAccountPaymentID;
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
            BindACBankAccountPaymentItemList();
        }

        private void BindACBankAccountPaymentItemList()
        {
            lvACBankAccountPaymentItem.DataBind();
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

        protected void lvACBankAccountPaymentItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACBankAccountPaymentItem_DetailedEntity ent = (ACBankAccountPaymentItem_DetailedEntity)dataItem.DataItem;

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

        protected void odsACBankAccountPaymentItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountPaymentItem." + ACBankAccountPaymentItemEntity.FLD_NAME_BankAccountPaymentID, OverviewACBankAccountPaymentID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
