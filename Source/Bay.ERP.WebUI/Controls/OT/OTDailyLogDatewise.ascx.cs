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
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class OTDailyLogDatewiseControl : BaseControl
    {       
        #region Properties

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
            txtStartDate.Text = System.DateTime.Now.AddDays(-7).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
        }

        private void PrepareEditView()
        {
          
        }

        private void BindList()
        {
            BindOTIssueList();
        }

        private void BindOTIssueList()
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

        #region List View Event

        #endregion List View Event

        #region ObjectDataSource Event

        #endregion

        #region Button Event

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            IList<OTIssueCategoryWise_RPTEntity> lst= FCCOTIssueCategoryWise_RPT.GetFacadeCreate().GetIL(MiscUtil.ParseToDateTime(txtStartDate.Text.Trim()), MiscUtil.ParseToDateTime(txtEndDate.Text.Trim()));
            
            lvOTIssueCategoryWise.DataSource = lst;
            lvOTIssueCategoryWise.DataBind();
            dvselection.Visible = false;

            lblDateInfo.Text = "Report Date: " + txtStartDate.Text.ToString() + " To " + txtEndDate.Text.ToString();

            if (lst != null && lst.Count > 0)
            {
                TimeSpan TotalTimeSpan = new TimeSpan(0, 0, 0);

                foreach (OTIssueCategoryWise_RPTEntity ent in lst)
                {
                    TimeSpan DTLtime;
                    TimeSpan.TryParse(ent.TotalTime.ToString(), out DTLtime);
                    TotalTimeSpan += DTLtime;
                }

                lblTotal.Text = "Total Hour In This Session: " + TotalTimeSpan;
            }

            else
            {
                lblTotal.Text = "Total Hour In This Session: N/A.";
            }
        }

        #endregion

        #endregion Event
    }
}
