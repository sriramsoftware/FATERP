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

namespace Bay.ERP.Web.UI
{
    public partial class BDProjectMilestoneIssueViewControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ScheduleID
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
            treeProjectMilestone.ProjectID = 1;

            treeProjectMilestone.ReBuildTree();
        }

        private void PrepareEditView()
        {
       
        }

        private void BindList()
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
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsOTIssue_Detailed_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            //String fe=SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueID,
            //e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #endregion Event
    }
}
