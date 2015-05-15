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
    public partial class HREmployeeDrivingLicenseInformationControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeDrivingLicenseInformationID
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

        public HREmployeeDrivingLicenseInformationEntity _HREmployeeDrivingLicenseInformationEntity
        {
            get
            {
                HREmployeeDrivingLicenseInformationEntity entity = new HREmployeeDrivingLicenseInformationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeDrivingLicenseInformationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeDrivingLicenseInformationEntity CurrentHREmployeeDrivingLicenseInformationEntity
        {
            get
            {
                if (_EmployeeDrivingLicenseInformationID > 0)
                {
                    if (_HREmployeeDrivingLicenseInformationEntity.EmployeeDrivingLicenseInformationID != _EmployeeDrivingLicenseInformationID)
                    {
                        _HREmployeeDrivingLicenseInformationEntity = FCCHREmployeeDrivingLicenseInformation.GetFacadeCreate().GetByID(_EmployeeDrivingLicenseInformationID);
                    }
                }

                return _HREmployeeDrivingLicenseInformationEntity;
            }
            set
            {
                _HREmployeeDrivingLicenseInformationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDrivingLicenseCategory(ddlDrivingLicenseCategoryID, false);
            MiscUtil.PopulateMDCountry(ddlCountryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtLicenseNumber.Text = String.Empty;
            txtCityName.Text = String.Empty;
            txtIssuedDate.Text = String.Empty;
            txtExpiryDate.Text = String.Empty;
            txtRenewDate.Text = String.Empty;
            txtIssueAuthority.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsDefaultLicense.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity = CurrentHREmployeeDrivingLicenseInformationEntity;


            if (!hREmployeeDrivingLicenseInformationEntity.IsNew)
            {
              

                if (ddlDrivingLicenseCategoryID.Items.Count > 0 && hREmployeeDrivingLicenseInformationEntity.DrivingLicenseCategoryID != null)
                {
                    ddlDrivingLicenseCategoryID.SelectedValue = hREmployeeDrivingLicenseInformationEntity.DrivingLicenseCategoryID.ToString();
                }

                txtLicenseNumber.Text = hREmployeeDrivingLicenseInformationEntity.LicenseNumber.ToString();
                if (ddlCountryID.Items.Count > 0 && hREmployeeDrivingLicenseInformationEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = hREmployeeDrivingLicenseInformationEntity.CountryID.ToString();
                }

                txtCityName.Text = hREmployeeDrivingLicenseInformationEntity.CityName.ToString();
                txtIssuedDate.Text = hREmployeeDrivingLicenseInformationEntity.IssuedDate.ToStringDefault();
                txtExpiryDate.Text = hREmployeeDrivingLicenseInformationEntity.ExpiryDate.ToStringDefault();
                txtRenewDate.Text = hREmployeeDrivingLicenseInformationEntity.RenewDate.ToStringDefault();
                txtIssueAuthority.Text = hREmployeeDrivingLicenseInformationEntity.IssueAuthority.ToString();
                txtRemarks.Text = hREmployeeDrivingLicenseInformationEntity.Remarks.ToString();
                chkIsDefaultLicense.Checked = hREmployeeDrivingLicenseInformationEntity.IsDefaultLicense;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeDrivingLicenseInformationList();
        }

        private void BindHREmployeeDrivingLicenseInformationList()
        {
            lvHREmployeeDrivingLicenseInformation.DataBind();
        }

        private HREmployeeDrivingLicenseInformationEntity BuildHREmployeeDrivingLicenseInformationEntity()
        {
            HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity = CurrentHREmployeeDrivingLicenseInformationEntity;

          
            hREmployeeDrivingLicenseInformationEntity.EmployeeID = OverviewEmployeeID;

            if (ddlDrivingLicenseCategoryID.Items.Count > 0)
            {
                if (ddlDrivingLicenseCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeDrivingLicenseInformationEntity.DrivingLicenseCategoryID = Int64.Parse(ddlDrivingLicenseCategoryID.SelectedValue);
                }
            }

            hREmployeeDrivingLicenseInformationEntity.LicenseNumber = txtLicenseNumber.Text.Trim();
            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeDrivingLicenseInformationEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            hREmployeeDrivingLicenseInformationEntity.CityName = txtCityName.Text.Trim();
            if (txtIssuedDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeDrivingLicenseInformationEntity.IssuedDate = MiscUtil.ParseToDateTime(txtIssuedDate.Text);
            }

            if (txtExpiryDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeDrivingLicenseInformationEntity.ExpiryDate = MiscUtil.ParseToDateTime(txtExpiryDate.Text);
            }
            else
            {
                hREmployeeDrivingLicenseInformationEntity.ExpiryDate = null;
            }

            if (txtRenewDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeDrivingLicenseInformationEntity.RenewDate = MiscUtil.ParseToDateTime(txtRenewDate.Text);
            }
            else
            {
                hREmployeeDrivingLicenseInformationEntity.RenewDate = null;
            }

            if (txtIssueAuthority.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeDrivingLicenseInformationEntity.IssueAuthority = txtIssueAuthority.Text.Trim();
            }
            else
            {
                hREmployeeDrivingLicenseInformationEntity.IssueAuthority = null;
            }

            if (txtRemarks.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeDrivingLicenseInformationEntity.Remarks = txtRemarks.Text.Trim();
            }
            else
            {
                hREmployeeDrivingLicenseInformationEntity.Remarks = null;
            }

            hREmployeeDrivingLicenseInformationEntity.IsDefaultLicense = chkIsDefaultLicense.Checked;


            return hREmployeeDrivingLicenseInformationEntity;
        }

        private void SaveHREmployeeDrivingLicenseInformationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity = BuildHREmployeeDrivingLicenseInformationEntity();

                    Int64 result = -1;

                    if (hREmployeeDrivingLicenseInformationEntity.IsNew)
                    {
                        result = FCCHREmployeeDrivingLicenseInformation.GetFacadeCreate().Add(hREmployeeDrivingLicenseInformationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeDrivingLicenseInformationEntity.FLD_NAME_EmployeeDrivingLicenseInformationID, hREmployeeDrivingLicenseInformationEntity.EmployeeDrivingLicenseInformationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeDrivingLicenseInformation.GetFacadeCreate().Update(hREmployeeDrivingLicenseInformationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeDrivingLicenseInformationID = 0;
                        _HREmployeeDrivingLicenseInformationEntity = new HREmployeeDrivingLicenseInformationEntity();
                        PrepareInitialView();
                        BindHREmployeeDrivingLicenseInformationList();

                        if (hREmployeeDrivingLicenseInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Driving License Information Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Driving License Information Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeDrivingLicenseInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Driving License Information Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Driving License Information Information.", false);
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

        protected void lvHREmployeeDrivingLicenseInformation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeDrivingLicenseInformationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeDrivingLicenseInformationID);

            if (EmployeeDrivingLicenseInformationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeDrivingLicenseInformationID = EmployeeDrivingLicenseInformationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeDrivingLicenseInformationEntity.FLD_NAME_EmployeeDrivingLicenseInformationID, EmployeeDrivingLicenseInformationID.ToString(), SQLMatchType.Equal);

                        HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity = new HREmployeeDrivingLicenseInformationEntity();


                        result = FCCHREmployeeDrivingLicenseInformation.GetFacadeCreate().Delete(hREmployeeDrivingLicenseInformationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeDrivingLicenseInformationID = 0;
                            _HREmployeeDrivingLicenseInformationEntity = new HREmployeeDrivingLicenseInformationEntity();
                            PrepareInitialView();
                            BindHREmployeeDrivingLicenseInformationList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Driving License Information has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Driving License Information.", true);
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

        protected void odsHREmployeeDrivingLicenseInformation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeDrivingLicenseInformation." + HREmployeeDrivingLicenseInformationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeDrivingLicenseInformationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeDrivingLicenseInformationID = 0;
            _HREmployeeDrivingLicenseInformationEntity = new HREmployeeDrivingLicenseInformationEntity();
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
