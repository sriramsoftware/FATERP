// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Dec-2012, 02:59:46




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
    public partial class INVTransactionINOUT_CustomControlDetailedListCustom : BaseControl
    {

        #region Event

        private void BindList()
        {
            lvINVTransactionINOUT_Custom.DataBind();
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
            }
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsINVTransactionINOUT_Custom_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
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
            String startDate = txtStartDate.Text.Trim().ToString();
            String endDate = txtEndDate.Text.Trim().ToString();

            ViewState["SearchString"] = "INVTransaction.TransactionDate between '" + MiscUtil.ParseToDateTime(startDate) + "' and '" + MiscUtil.ParseToDateTime(endDate)+"'";
            BindList();
        }

        #endregion

        #endregion Event
    }
}
