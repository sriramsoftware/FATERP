// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HREmployeeResumeControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeResumeID
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

        public HREmployeeResumeEntity _HREmployeeResumeEntity
        {
            get
            {
                HREmployeeResumeEntity entity = new HREmployeeResumeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeResumeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeResumeEntity CurrentHREmployeeResumeEntity
        {
            get
            {
                if (_EmployeeResumeID > 0)
                {
                    if (_HREmployeeResumeEntity.EmployeeResumeID != _EmployeeResumeID)
                    {
                        _HREmployeeResumeEntity = FCCHREmployeeResume.GetFacadeCreate().GetByID(_EmployeeResumeID);
                    }
                }

                return _HREmployeeResumeEntity;
            }
            set
            {
                _HREmployeeResumeEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDResumeCategory(ddlResumeCategoryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtText.Content = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeResumeEntity hREmployeeResumeEntity = CurrentHREmployeeResumeEntity;


            if (!hREmployeeResumeEntity.IsNew)
            {
                if (ddlResumeCategoryID.Items.Count > 0 && hREmployeeResumeEntity.ResumeCategoryID != null)
                {
                    ddlResumeCategoryID.SelectedValue = hREmployeeResumeEntity.ResumeCategoryID.ToString();
                }

                txtText.Content = hREmployeeResumeEntity.Text.ToString();
                txtRemarks.Text = hREmployeeResumeEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeResumeList();
        }

        private void BindHREmployeeResumeList()
        {
            lvHREmployeeResume.DataBind();
        }

        private HREmployeeResumeEntity BuildHREmployeeResumeEntity()
        {
            HREmployeeResumeEntity hREmployeeResumeEntity = CurrentHREmployeeResumeEntity;

          
                    hREmployeeResumeEntity.EmployeeID = OverviewEmployeeID;

            if (ddlResumeCategoryID.Items.Count > 0)
            {
                if (ddlResumeCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeResumeEntity.ResumeCategoryID = Int64.Parse(ddlResumeCategoryID.SelectedValue);
                }
            }

            hREmployeeResumeEntity.Text = txtText.Content.Trim();
            hREmployeeResumeEntity.Remarks = txtRemarks.Text.Trim();

            return hREmployeeResumeEntity;
        }

        private void SaveHREmployeeResumeEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeResumeEntity hREmployeeResumeEntity = BuildHREmployeeResumeEntity();

                    Int64 result = -1;

                    if (hREmployeeResumeEntity.IsNew)
                    {
                        result = FCCHREmployeeResume.GetFacadeCreate().Add(hREmployeeResumeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeResumeEntity.FLD_NAME_EmployeeResumeID, hREmployeeResumeEntity.EmployeeResumeID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeResume.GetFacadeCreate().Update(hREmployeeResumeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeResumeID = 0;
                        _HREmployeeResumeEntity = new HREmployeeResumeEntity();
                        PrepareInitialView();
                        BindHREmployeeResumeList();

                        if (hREmployeeResumeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Resume Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Resume Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeResumeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Resume Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Resume Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void GetResumeReport()
        {
            hypResumeReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.HR_EMPLOYEE_RESUME_REPORT, UrlConstants.OVERVIEW_EMPLOYEE_ID, OverviewEmployeeID.ToString()).ToString();
            hypResumeReport.Target = "_blank";
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
                GetResumeReport();
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployeeResume_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeResumeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeResumeID);

            if (EmployeeResumeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeResumeID = EmployeeResumeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeResumeEntity.FLD_NAME_EmployeeResumeID, EmployeeResumeID.ToString(), SQLMatchType.Equal);

                        HREmployeeResumeEntity hREmployeeResumeEntity = new HREmployeeResumeEntity();


                        result = FCCHREmployeeResume.GetFacadeCreate().Delete(hREmployeeResumeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeResumeID = 0;
                            _HREmployeeResumeEntity = new HREmployeeResumeEntity();
                            PrepareInitialView();
                            BindHREmployeeResumeList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Resume has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Resume.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsHREmployeeResume_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeResumeEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeResumeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeResumeID = 0;
            _HREmployeeResumeEntity = new HREmployeeResumeEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
