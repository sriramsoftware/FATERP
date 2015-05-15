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
    public partial class BDProjectCategoryStatusReportControl : BaseControl
    { 

        #region Methods

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
        
        }

        private void PrepareEditView()
        {
            
        }

        private void LoadTreeView()
        {
            treeProjectCategoryStatus.ReBuildTree();
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeProjectCategoryStatus.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select a Project.", true);
            }

            if (treeProjectCategoryStatus.SelectedNode != null)
            {
                if (treeProjectCategoryStatus.SelectedNode.Depth != 3)
                {
                    validationResult = false;

                    MiscUtil.ShowMessage(lblMessage, "Please Select a Project.", true);
                }
            }
            return validationResult;
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

        protected void btnShow_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                String NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "ProjectReport", UrlConstants.OVERVIEW_PROJECT_ID, treeProjectCategoryStatus.SelectedValue.ToString()).ToString();
                Response.Redirect(NavigationUrl);
            }
        }

        #endregion

        #endregion Event
    }
}
