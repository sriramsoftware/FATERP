// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public partial class PRMSupplierItemMapHistoryReportControl : BaseControl
    {       
        #region Properties

        public Int64 _SupplierItemMapHistoryID
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

        public PRMSupplierItemMapHistoryEntity _PRMSupplierItemMapHistoryEntity
        {
            get
            {
                PRMSupplierItemMapHistoryEntity entity = new PRMSupplierItemMapHistoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierItemMapHistoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierItemMapHistoryEntity CurrentPRMSupplierItemMapHistoryEntity
        {
            get
            {
                if (_SupplierItemMapHistoryID > 0)
                {
                    if (_PRMSupplierItemMapHistoryEntity.SupplierItemMapHistoryID != _SupplierItemMapHistoryID)
                    {
                        _PRMSupplierItemMapHistoryEntity = FCCPRMSupplierItemMapHistory.GetFacadeCreate().GetByID(_SupplierItemMapHistoryID);
                    }
                }

                return _PRMSupplierItemMapHistoryEntity;
            }
            set
            {
                _PRMSupplierItemMapHistoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDItem(ddlItemID, false);
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
            PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity = CurrentPRMSupplierItemMapHistoryEntity;
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        { 
            String NavigationUrl=UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "PriceHistoryReport", UrlConstants.OVERVIEW_SUPPLIERPRICE_ITEM_ID, ddlItemID.SelectedValue.ToString()).ToString();
            Response.Redirect(NavigationUrl);
        }

        #endregion

        #endregion Event
    }
}
