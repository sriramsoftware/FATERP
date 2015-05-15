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
using Geekees.Common.Controls;
using AjaxControlToolkit;

namespace Bay.ERP.Web.UI
{
    public partial class HREmployeePersonalFileControl : EmployeeBaseControl
    {       
        #region Properties

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDocumentCategory(ddlDocumentCategoryID, false);
            MiscUtil.PopulateHRSession(ddlEvolutionSessionID, false);
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
            
        }

        private void BindList()
        {
            BindHREmployeeList();
        }

        private void BindHREmployeeList()
        {
            
        }

        private void GenerateReport()
        {
            hypGenerateReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, (Int64.Parse(ddlEvolutionSessionID.SelectedValue)).ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, OverviewEmployeeID.ToString()).ToString();
            hypGenerateReport.Target = "_blank";
        }

        private void GetAllLetters()
        {
            String fe = "SendToEmployeeID = "+OverviewEmployeeID+"";
            IList<HREmployeeNoticeEntity> hREmployeeNoticeList = FCCHREmployeeNotice.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            if (hREmployeeNoticeList != null && hREmployeeNoticeList.Count > 0)
            {
                foreach (HREmployeeNoticeEntity entity in hREmployeeNoticeList)
                {
                    if(entity.TemplateID == MasterDataConstants.HREmployeeNoticeTemplate.JOINLETTER)
                    {
                        lblJoinLetter.Text += Server.HtmlDecode(entity.Text.ToString()) + "<hr><br/>";
                    }
                    else if (entity.TemplateID == MasterDataConstants.HREmployeeNoticeTemplate.APPOINTMENTLETTER)
                    {
                        lblAppointmentLetter.Text += Server.HtmlDecode(entity.Text.ToString()) + "<hr><br/>";
                    }
                    else if (entity.TemplateID == MasterDataConstants.HREmployeeNoticeTemplate.CHANGEOFDESIGNATIONLETTER)
                    {
                        lblChangeOfDesignationLetter.Text += Server.HtmlDecode(entity.Text.ToString()) + "<hr><br/>";
                    }
                    else if (entity.TemplateID == MasterDataConstants.HREmployeeNoticeTemplate.SALARYENHANCEMENTLETTER)
                    {
                        lblSalaryEnhancementLetter.Text += Server.HtmlDecode(entity.Text.ToString()) + "<hr><br/>";
                    }
                    else if (entity.TemplateID == MasterDataConstants.HREmployeeNoticeTemplate.CONFIRMATIONLETTER)
                    {
                        lblConfirmationLetter.Text += Server.HtmlDecode(entity.Text.ToString()) + "<hr><br/>";
                    }
                    else if (entity.TemplateID == MasterDataConstants.HREmployeeNoticeTemplate.OFFICEMEMO)
                    {
                        lblOfficeMemo.Text += Server.HtmlDecode(entity.Text.ToString()) + "<hr><br/>";
                    }
                }
            }

        }

        private void GenerateCV()
        {
            String fe = "EmployeeID = " + OverviewEmployeeID + "";
            IList<HREmployeeResumeEntity> list = FCCHREmployeeResume.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            if (list != null && list.Count > 0)
            {
                foreach (HREmployeeResumeEntity entity in list)
                {
                    lblCVTextView.Text += Server.HtmlDecode(entity.Text.ToString()) + "<hr><br/>";
                }
            }
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
                GenerateReport();
                GetAllLetters();
                GenerateCV();
                
            }
        }

        #endregion

        #region List View Event

        protected void lvHRSession_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                HRSession_DetailedEntity ent = (HRSession_DetailedEntity)dataItem.DataItem;
                HyperLink hypEvoluationReport = (HyperLink)e.Item.FindControl("hypEvoluationReport");
                hypEvoluationReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_EVALUATION_REPORT, UrlConstants.OVERVIEW_EVALUATION_SESSION_ID, ent.SessionID.ToString(), UrlConstants.OVERVIEW_EMPLOYEE_ID, OverviewEmployeeID.ToString()).ToString();
                hypEvoluationReport.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event
        
        protected void odsHREmployeeDocument_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = "EmployeeID = " + OverviewEmployeeID + " and DocumentCategoryID=" + Int64.Parse(ddlDocumentCategoryID.SelectedValue) + "";
            e.InputParameters["filterExpression"] = fe;
        }

        protected void odsHRSession_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event


        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region CheckBox Event


        #endregion

        #region Dropdown Event

        protected void ddlDocumentCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvHREmployeeDocument.DataBind();
        }

        protected void ddlEvolutionSessionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }
        #endregion


        #region Treeview Event

        protected void astvMyTree_OnSelectedNodeChanged(object src, ASTreeViewNodeSelectedEventArgs e)
        {
            //TreeViewSelectedNodeChanged();
        }

        #endregion

        #endregion Event
    }
}
