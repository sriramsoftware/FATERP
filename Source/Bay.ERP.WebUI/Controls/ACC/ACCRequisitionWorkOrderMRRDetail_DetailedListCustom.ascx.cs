// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 04:58:29




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
    public partial class ACCRequisitionWorkOrderMRRDetail_DetailedControlListCustom : BaseControl
    {
        #region Member Variables

        #endregion

        #region Properties

        #endregion

        #region Methods

        private void BindList()
        {
            BindACCRequisitionWorkOrderMRRDetail_DetailedList();
        }

        private void BindACCRequisitionWorkOrderMRRDetail_DetailedList()
        {  
            lvACCRequisitionWorkOrderMRRDetail_Detailed.DataBind();
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

        protected void odsACCRequisitionWorkOrderMRRDetail_Detailed_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectCode", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MDItem.ItemName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #region Filter DropdownList Event

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
