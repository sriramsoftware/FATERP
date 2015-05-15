// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:42:57




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.FacadeCreator.FacadeContext;
using System.Web.UI.WebControls;

namespace Bay.ERP.Web.UI
{
    public partial class CRMCommunicationReportPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "CRMCommunicationReportEntity_Page";
            }
        }

        #endregion

        #region Methods

        private void NavigateUrl()
        {
            Int64 buyerBasicInfoID = Convert.ToInt64(DropDownLeadName.SelectedValue);
            hypCommunication.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMCommunication.aspx", string.Empty, "do", "Sales", UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID, buyerBasicInfoID.ToString()).ToString();
            hypCommunication.Target = "_blank";
        }

        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hypCommunication.Visible = false;
            }
        }

        protected void SqlDataSource1_Inserting(object sender, System.Web.UI.WebControls.SqlDataSourceCommandEventArgs e)
        {
        }

        #region Button

        protected void btnCommunication_Click(object sender, EventArgs e)
        {
            Int64 buyerBasicInfoID = Convert.ToInt64(DropDownLeadName.SelectedValue);
            String navUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMCommunication.aspx", string.Empty, "do", "Sales", UrlConstants.OVERVIEW_BUYER_BASIC_INFO_ID, buyerBasicInfoID.ToString()).ToString();
            Response.Redirect(navUrl);
        }
        #endregion

        #region ObjectDataSource Event

        protected void odsCRMBuyerBookSpace_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            //String fe = String.Empty;
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBookSpaceEntity.FLD_NAME_ReferenceID, DropDownLeadName.SelectedValue.ToString(), SQLMatchType.Equal);

            if (ViewState["SearchString"] != null)
            {
                fe = (String)ViewState["SearchString"];
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        protected void DropDownLeadName_SelectedIndexChanged(object sender, EventArgs e)
        {
            NavigateUrl();
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBookSpaceEntity.FLD_NAME_ReferenceID, DropDownLeadName.SelectedValue.ToString(), SQLMatchType.Equal);
            ViewState["SearchString"] = fe;
            lvCRMBuyerBookSpace.DataBind();
            hypCommunication.Visible = true;

        }
        #endregion Events
}
}
