// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jan-2013, 04:31:48




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
    public partial class ACBankAccountDepositItemControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountDepositItemID
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

        public ACBankAccountDepositItemEntity _ACBankAccountDepositItemEntity
        {
            get
            {
                ACBankAccountDepositItemEntity entity = new ACBankAccountDepositItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountDepositItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountDepositItemEntity CurrentACBankAccountDepositItemEntity
        {
            get
            {
                if (_BankAccountDepositItemID > 0)
                {
                    if (_ACBankAccountDepositItemEntity.BankAccountDepositItemID != _BankAccountDepositItemID)
                    {
                        _ACBankAccountDepositItemEntity = FCCACBankAccountDepositItem.GetFacadeCreate().GetByID(_BankAccountDepositItemID);
                    }
                }

                return _ACBankAccountDepositItemEntity;
            }
            set
            {
                _ACBankAccountDepositItemEntity = value;
            }
        }

        public Int64 ACBankAccountDepositID
        {
            get
            {
                Int64 acBankAccountDepositID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID], out acBankAccountDepositID);
                }

                return acBankAccountDepositID;
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
            BindACBankAccountDepositItemList();
        }

        private void BindACBankAccountDepositItemList()
        {
            lvACBankAccountDepositItem.DataBind();
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

        protected void lvACBankAccountDepositItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                ACBankAccountDepositItem_DetailedEntity ent = (ACBankAccountDepositItem_DetailedEntity)dataItem.DataItem;

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

        protected void odsACBankAccountDepositItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("ACBankAccountDepositItem." + ACBankAccountDepositItemEntity.FLD_NAME_BankAccountDepositID, ACBankAccountDepositID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #endregion Event
    }
}
