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
    public partial class HREmployeeExperienceControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeExperienceID
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

        public HREmployeeExperienceEntity _HREmployeeExperienceEntity
        {
            get
            {
                HREmployeeExperienceEntity entity = new HREmployeeExperienceEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeExperienceEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeExperienceEntity CurrentHREmployeeExperienceEntity
        {
            get
            {
                if (_EmployeeExperienceID > 0)
                {
                    if (_HREmployeeExperienceEntity.EmployeeExperienceID != _EmployeeExperienceID)
                    {
                        _HREmployeeExperienceEntity = FCCHREmployeeExperience.GetFacadeCreate().GetByID(_EmployeeExperienceID);
                    }
                }

                return _HREmployeeExperienceEntity;
            }
            set
            {
                _HREmployeeExperienceEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCountry(ddlCompanyCountryID, false);
            MiscUtil.PopulateMDEmployeeJobType(ddlEmployeeJobTypeID, false);
        }

        private void PrepareValidator()
        {

            revWebLink.ValidationExpression = ValidationConstants.RegularExpression.Web;
            revWebLink.ErrorMessage = ValidationConstants.ErrorMessage.Web;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtCompanyName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtJobEndDate.Text = String.Empty;
            txtJobStartDate.Text = String.Empty;
            txtContactNo.Text = String.Empty;
            txtWebLink.Text = String.Empty;
            txtDesignation.Text = String.Empty;
            txtResponsibility.Text = String.Empty;
            txtSupervisorName.Text = String.Empty;
            txtSalaryOrBenefits.Text = String.Empty;
            chkIsLastCompany.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeExperienceEntity hREmployeeExperienceEntity = CurrentHREmployeeExperienceEntity;


            if (!hREmployeeExperienceEntity.IsNew)
            {
                if (ddlCompanyCountryID.Items.Count > 0 && hREmployeeExperienceEntity.CompanyCountryID != null)
                {
                    ddlCompanyCountryID.SelectedValue = hREmployeeExperienceEntity.CompanyCountryID.ToString();
                }

                txtCompanyName.Text = hREmployeeExperienceEntity.CompanyName.ToString();
                txtAddress.Text = hREmployeeExperienceEntity.Address.ToString();
                if (ddlEmployeeJobTypeID.Items.Count > 0 && hREmployeeExperienceEntity.EmployeeJobTypeID != null)
                {
                    ddlEmployeeJobTypeID.SelectedValue = hREmployeeExperienceEntity.EmployeeJobTypeID.ToString();
                }

                txtJobEndDate.Text = hREmployeeExperienceEntity.JobEndDate.ToStringDefault();
                txtJobStartDate.Text = hREmployeeExperienceEntity.JobStartDate.ToStringDefault();
                txtContactNo.Text = hREmployeeExperienceEntity.ContactNo.ToString();
                txtWebLink.Text = hREmployeeExperienceEntity.WebLink.ToString();
                chkIsLastCompany.Checked = hREmployeeExperienceEntity.IsLastCompany;
                txtDesignation.Text = hREmployeeExperienceEntity.Designation.ToString();
                txtResponsibility.Text = hREmployeeExperienceEntity.Responsibility.ToString();
                txtSupervisorName.Text = hREmployeeExperienceEntity.SupervisorName.ToString();
                txtSalaryOrBenefits.Text = hREmployeeExperienceEntity.SalaryOrBenefits.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeExperienceList();
        }

        private void BindHREmployeeExperienceList()
        {
            lvHREmployeeExperience.DataBind();
        }

        private HREmployeeExperienceEntity BuildHREmployeeExperienceEntity()
        {
            HREmployeeExperienceEntity hREmployeeExperienceEntity = CurrentHREmployeeExperienceEntity;


            hREmployeeExperienceEntity.EmployeeID = OverviewEmployeeID;
            if (ddlCompanyCountryID.Items.Count > 0)
            {
                if (ddlCompanyCountryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeExperienceEntity.CompanyCountryID = Int64.Parse(ddlCompanyCountryID.SelectedValue);
                }
            }

            hREmployeeExperienceEntity.CompanyName = txtCompanyName.Text.Trim();
            hREmployeeExperienceEntity.Address = txtAddress.Text.Trim();
            if (ddlEmployeeJobTypeID.Items.Count > 0)
            {
                if (ddlEmployeeJobTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeExperienceEntity.EmployeeJobTypeID = Int64.Parse(ddlEmployeeJobTypeID.SelectedValue);
                }
            }

            if (txtJobEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeExperienceEntity.JobEndDate = MiscUtil.ParseToDateTime(txtJobEndDate.Text);
            }
            else
            {
                hREmployeeExperienceEntity.JobEndDate = null;
            }

            if (txtJobStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeExperienceEntity.JobStartDate = MiscUtil.ParseToDateTime(txtJobStartDate.Text);
            }

            hREmployeeExperienceEntity.ContactNo = txtContactNo.Text.Trim();
            hREmployeeExperienceEntity.WebLink = txtWebLink.Text.Trim();
            hREmployeeExperienceEntity.IsLastCompany = chkIsLastCompany.Checked;
            hREmployeeExperienceEntity.Designation = txtDesignation.Text.Trim();
            hREmployeeExperienceEntity.SupervisorName = txtSupervisorName.Text.Trim();
            hREmployeeExperienceEntity.SalaryOrBenefits = txtSalaryOrBenefits.Text.Trim();
            hREmployeeExperienceEntity.Responsibility = txtResponsibility.Text.Trim();


            return hREmployeeExperienceEntity;
        }

        private void SaveHREmployeeExperienceEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeExperienceEntity hREmployeeExperienceEntity = BuildHREmployeeExperienceEntity();

                    Int64 result = -1;

                    if (hREmployeeExperienceEntity.IsNew)
                    {
                        result = FCCHREmployeeExperience.GetFacadeCreate().Add(hREmployeeExperienceEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeExperienceEntity.FLD_NAME_EmployeeExperienceID, hREmployeeExperienceEntity.EmployeeExperienceID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeExperience.GetFacadeCreate().Update(hREmployeeExperienceEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeExperienceID = 0;
                        _HREmployeeExperienceEntity = new HREmployeeExperienceEntity();
                        PrepareInitialView();
                        BindHREmployeeExperienceList();

                        if (hREmployeeExperienceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Experience Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Experience Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeExperienceEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Experience Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Experience Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
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
            }
        }

        #endregion

        #region List View Event

        protected void lvHREmployeeExperience_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeExperienceID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeExperienceID);

            if (EmployeeExperienceID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeExperienceID = EmployeeExperienceID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeExperienceEntity.FLD_NAME_EmployeeExperienceID, EmployeeExperienceID.ToString(), SQLMatchType.Equal);

                        HREmployeeExperienceEntity hREmployeeExperienceEntity = new HREmployeeExperienceEntity();


                        result = FCCHREmployeeExperience.GetFacadeCreate().Delete(hREmployeeExperienceEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeExperienceID = 0;
                            _HREmployeeExperienceEntity = new HREmployeeExperienceEntity();
                            PrepareInitialView();
                            BindHREmployeeExperienceList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Experience has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Experience.", true);
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

        protected void odsHREmployeeExperience_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeExperience." + HREmployeeExperienceEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeExperienceEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeExperienceID = 0;
            _HREmployeeExperienceEntity = new HREmployeeExperienceEntity();
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
