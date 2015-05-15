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
using System.Web.Security;

namespace Bay.ERP.Web.UI
{
    public partial class OTDailyLogDatewiseIndividualControl : BaseControl
    {       
        #region Properties

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHREmployee(ddlEmployeeID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            txtStartDate.Text = System.DateTime.Now.AddDays(-7).ToString(UIConstants.SHORT_DATE_FORMAT);
            txtEndDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            if (this.Page.User.Identity.IsAuthenticated == true)
            {
                //if (Roles.IsUserInRole(this.Page.User.Identity.Name, "1.466") == true ||
                //    Roles.IsUserInRole(this.Page.User.Identity.Name, "HR") == true ||
                //    Roles.IsUserInRole(this.Page.User.Identity.Name, "CRM") == true ||
                //    Roles.IsUserInRole(this.Page.User.Identity.Name, "Accounts") == true ||
                //    Roles.IsUserInRole(this.Page.User.Identity.Name, "Engineers") == true||
                //    Roles.IsUserInRole(this.Page.User.Identity.Name, "IS") == true)
                if (this.Page.User.Identity.Name.Equals("17.466") == true ||
                    this.Page.User.Identity.Name.Equals("17.042") == true ||
                    this.Page.User.Identity.Name.Equals("17.1127") == true ||
                    this.Page.User.Identity.Name.Equals("17.605") == true ||
                    this.Page.User.Identity.Name.Equals("17.599") == true ||
                    this.Page.User.Identity.Name.Equals("17.1000") == true ||
                    this.Page.User.Identity.Name.Equals("17.979") == true ||
                    this.Page.User.Identity.Name.Equals("17.687") == true ||
                    this.Page.User.Identity.Name.Equals("17.788") == true ||
                    this.Page.User.Identity.Name.Equals("17.1116") == true||
                    this.Page.User.Identity.Name.Equals("17.799") == true||
                    this.Page.User.Identity.Name.Equals("17.780") == true)
                {
                    String fe_session = SqlExpressionBuilder.PrepareFilterExpression(HRSessionEntity.FLD_NAME_EvaluationSessionStatusID, MasterDataConstants.MDEvaluationSessionStatus.OPEN.ToString(), SQLMatchType.Equal);
                    IList<HRSessionEntity> lstHRSessionEntity = FCCHRSession.GetFacadeCreate().GetIL(null, null, String.Empty, fe_session, DatabaseOperationType.LoadWithFilterExpression);

                    if (lstHRSessionEntity != null && lstHRSessionEntity.Count > 0)
                    {
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSupervisorMap_DetailedEntity.FLD_NAME_SupervisorEmployeeID, MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeSupervisorMap." + HREmployeeSupervisorMap_DetailedEntity.FLD_NAME_SessionCategoryID, lstHRSessionEntity[0].SessionID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        IList<HREmployeeSupervisorMap_DetailedEntity> lst = FCCHREmployeeSupervisorMap_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);
                        if (lst != null && lst.Count > 0)
                        {
                            ddlEmployeeID.Items.Clear();
                            foreach (HREmployeeSupervisorMap_DetailedEntity ent in lst)
                            {
                                ListItem lstItem = new ListItem();
                                lstItem.Text = ent.EmployeeCode + " - " + ent.EmployeeFullName+"("+ent.SessionCategoryName.ToString()+")";
                                lstItem.Value = ent.EmployeeID.ToString();
                                ddlEmployeeID.Items.Add(lstItem);
                            }
                        }

                        ddlEmployeeID.Enabled = true;
                    }
                }
                else
                {
                    ddlEmployeeID.SelectedValue = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString();
                    ddlEmployeeID.Enabled = false;
                }
            }
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
            String reportContant = ReportConstants.WEEKLY_DTL_INDIVIDUAL_REPORT;
            String employeeID = String.Empty;

            if (ddlEmployeeID != null && ddlEmployeeID.SelectedValue != "0")
            {
                employeeID = ddlEmployeeID.SelectedValue;
            }
            else
            {
                employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString();
            }

            String NavigationUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", reportContant, UrlConstants.OVERVIEW_ISSUE_FROM_DATE, txtStartDate.Text.Trim().ToString(), UrlConstants.OVERVIEW_ISSUE_TO_DATE, txtEndDate.Text.Trim().ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, employeeID).ToString();
            Helper.Response.Redirect(NavigationUrl);
        }

        #endregion

        #endregion Event
    }
}
