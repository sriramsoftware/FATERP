// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.UI;
using System.Web.Security;

namespace Bay.ERP.Web.UI
{
    public partial class INVInterProjectTransferReportControl : BaseControl
    {
        #region Properties

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateBDProject(ddlFromProjectID, true);
            MiscUtil.PopulateBDProject(ddlToProjectID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtStartDate.Text = System.DateTime.Now.AddDays(-30).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
        }

        private void PrepareEditView()
        {
           
        }

        private void BindList()
        {
            BindINVTransferList();
        }

        private void BindINVTransferList()
        {
            lvINVTransfer.DataBind();
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

        #region ObjectDataSource Event

        protected void odsINVTransfer_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (ViewState["SearchString"] != null)
            {
                fe =(String)ViewState["SearchString"];
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String fe = "INVTransfer_1.RequestDate between '" + MiscUtil.ParseToDateTime(txtStartDate.Text.Trim().ToString()).ToString() + "' AND '" + MiscUtil.ParseToDateTime(txtEndDate.Text.Trim().ToString()).ToString() + "'";

            if (ddlFromProjectID != null && ddlFromProjectID.SelectedValue != "0")
            {
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("BDProject_1.ProjectID", ddlFromProjectID.SelectedValue.ToString(), SQLMatchType.Equal);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe2);
            }
            if (ddlToProjectID != null && ddlToProjectID.SelectedValue != "0")
            {
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectID", ddlToProjectID.SelectedValue.ToString(), SQLMatchType.Equal);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe2);
            }

            ViewState["SearchString"] = fe;

            BindList();
        }

        protected void btnClearSearch_Click(object sender, EventArgs e)
        {
            ViewState["SearchString"] = null;
            BindList();
        }

        #endregion

        #endregion Event
    }
}
