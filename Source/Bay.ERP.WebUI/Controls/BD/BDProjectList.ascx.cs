// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class BDProjectListControl : BaseControl
    {   

        #region Methods

        private void BuildDropDownList()
        {
            
        }

        private void BindList()
        {
            BindBDProjectList();
        }

        private void BindBDProjectList()
        {
            lvBDProject.DataBind();
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

        #region List View Event

        protected void lvBDProject_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                BDProject_DetailedEntity ent = (BDProject_DetailedEntity)dataItem.DataItem;

                HyperLink hypProject = (HyperLink)e.Item.FindControl("hypProject");
                HyperLink hypProjectReport = (HyperLink)e.Item.FindControl("hypProjectReport");
                HyperLink hypProjectHistoryReport = (HyperLink)e.Item.FindControl("hypProjectHistoryReport");
                hypProjectReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "ProjectReport", UrlConstants.OVERVIEW_PROJECT_ID, ent.ProjectID.ToString()).ToString();
                hypProjectHistoryReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do",ReportConstants.PROJECT_HISTORY_REPORT, UrlConstants.OVERVIEW_PROJECT_ID, ent.ProjectID.ToString()).ToString();
                hypProject.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectEditor.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, ent.ProjectID.ToString()).ToString();
                hypProject.Target = "_blank";
                hypProjectReport.Target = "_blank";
                hypProjectHistoryReport.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsBDProject_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }
     
        #endregion

        #endregion Event 
    }
}
