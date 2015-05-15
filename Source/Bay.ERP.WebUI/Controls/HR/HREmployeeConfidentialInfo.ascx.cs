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
    public partial class HREmployeeConfidentialInfoControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeConfidentialInfoID
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

        public HREmployeeConfidentialInfoEntity _HREmployeeConfidentialInfoEntity
        {
            get
            {
                HREmployeeConfidentialInfoEntity entity = new HREmployeeConfidentialInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeConfidentialInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeConfidentialInfoEntity CurrentHREmployeeConfidentialInfoEntity
        {
            get
            {
                if (OverviewEmployeeID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeConfidentialInfoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
                    IList<HREmployeeConfidentialInfoEntity> lst = FCCHREmployeeConfidentialInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                    _HREmployeeConfidentialInfoEntity = lst != null ? lst[0] : new HREmployeeConfidentialInfoEntity();
                }

                return _HREmployeeConfidentialInfoEntity;
            }
            set
            {
                _HREmployeeConfidentialInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDMaritalStatus(ddlMaritalStatusID, true);
            MiscUtil.PopulateMDDistrict(ddlBirthOfStateID, true);
            MiscUtil.PopulateMDCountry(ddlCountryOfBirthCountryID, false);
            MiscUtil.PopulateMDCountry(ddlResidenceCountryID, false);
            MiscUtil.PopulateMDRegion(ddlRegionID, true);
            MiscUtil.PopulateMDReligion(ddlReligionID, true);
            MiscUtil.PopulateMDBloodGroup(ddlBloodGroupID, true);
            MiscUtil.PopulateMDGender(ddlGenderID, true);
            MiscUtil.PopulateMDCountry(ddlCurrentNationalityCountryID, false);
            MiscUtil.PopulateMDCountry(ddlPreviousNationalityCountryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtNumberofChildren.Text = String.Empty;
            txtDateofBirth.Text = String.Empty;
            txtCityofBirth.Text = String.Empty;
            txtPersonlTaxIdNumber.Text = String.Empty;
            txtNationalIdNumber.Text = String.Empty;
            txtBirthMark.Text = String.Empty;
            txtDisabilityInformation.Text = String.Empty;
            txtAnniversaryDate.Text = String.Empty;
            txtHeight.Text = String.Empty;
            txtWeight.Text = String.Empty;
            chkHasPassport.Checked = false;
            chkHasDrivingLisence.Checked = false;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity = CurrentHREmployeeConfidentialInfoEntity;


            if (!hREmployeeConfidentialInfoEntity.IsNew)
            {
             
                txtNumberofChildren.Text = hREmployeeConfidentialInfoEntity.NumberofChildren.ToString();
                txtDateofBirth.Text = hREmployeeConfidentialInfoEntity.DateofBirth.ToStringDefault();
                if (ddlMaritalStatusID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.MaritalStatusID != null)
                {
                    ddlMaritalStatusID.SelectedValue = hREmployeeConfidentialInfoEntity.MaritalStatusID.ToString();
                }

                txtCityofBirth.Text = hREmployeeConfidentialInfoEntity.CityofBirth.ToString();
                if (ddlBirthOfStateID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.District != null)
                {
                    ddlBirthOfStateID.SelectedValue = hREmployeeConfidentialInfoEntity.District.ToString();
                }

                if (ddlCountryOfBirthCountryID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID != null)
                {
                    ddlCountryOfBirthCountryID.SelectedValue = hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID.ToString();
                }

                if (ddlResidenceCountryID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.ResidenceCountryID != null)
                {
                    ddlResidenceCountryID.SelectedValue = hREmployeeConfidentialInfoEntity.ResidenceCountryID.ToString();
                }

                txtPersonlTaxIdNumber.Text = hREmployeeConfidentialInfoEntity.PersonlTaxIdNumber.ToString();
                txtNationalIdNumber.Text = hREmployeeConfidentialInfoEntity.NationalIdNumber.ToString();
                if (ddlRegionID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.RegionID != null)
                {
                    ddlRegionID.SelectedValue = hREmployeeConfidentialInfoEntity.RegionID.ToString();
                }

                if (ddlReligionID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.ReligionID != null)
                {
                    ddlReligionID.SelectedValue = hREmployeeConfidentialInfoEntity.ReligionID.ToString();
                }

                txtBirthMark.Text = hREmployeeConfidentialInfoEntity.BirthMark.ToString();
                if (ddlBloodGroupID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.BloodGroupID != null)
                {
                    ddlBloodGroupID.SelectedValue = hREmployeeConfidentialInfoEntity.BloodGroupID.ToString();
                }

                txtDisabilityInformation.Text = hREmployeeConfidentialInfoEntity.DisabilityInformation.ToString();
                if (ddlGenderID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.GenderID != null)
                {
                    ddlGenderID.SelectedValue = hREmployeeConfidentialInfoEntity.GenderID.ToString();
                }

                txtAnniversaryDate.Text = hREmployeeConfidentialInfoEntity.AnniversaryDate.ToStringDefault();
                txtHeight.Text = hREmployeeConfidentialInfoEntity.Height.ToString();
                txtWeight.Text = hREmployeeConfidentialInfoEntity.Weight.ToString();
                if (ddlCurrentNationalityCountryID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID != null)
                {
                    ddlCurrentNationalityCountryID.SelectedValue = hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID.ToString();
                }

                if (ddlPreviousNationalityCountryID.Items.Count > 0 && hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID != null)
                {
                    ddlPreviousNationalityCountryID.SelectedValue = hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID.ToString();
                }

                chkHasPassport.Checked = hREmployeeConfidentialInfoEntity.HasPassport;
                chkHasDrivingLisence.Checked = hREmployeeConfidentialInfoEntity.HasDrivingLisence;
                chkIsRemoved.Checked = hREmployeeConfidentialInfoEntity.IsRemoved;

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindHREmployeeConfidentialInfoList();
        }

        private void BindHREmployeeConfidentialInfoList()
        {
           
        }

        private HREmployeeConfidentialInfoEntity BuildHREmployeeConfidentialInfoEntity()
        {
            HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity = CurrentHREmployeeConfidentialInfoEntity;

          
                    hREmployeeConfidentialInfoEntity.EmployeeID = OverviewEmployeeID;

            if (!txtNumberofChildren.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeConfidentialInfoEntity.NumberofChildren = Int32.Parse(txtNumberofChildren.Text.Trim());
            }
            else
            {
                hREmployeeConfidentialInfoEntity.NumberofChildren = null;
            }

            if (txtDateofBirth.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeConfidentialInfoEntity.DateofBirth = MiscUtil.ParseToDateTime(txtDateofBirth.Text);
            }
            else
            {
                hREmployeeConfidentialInfoEntity.DateofBirth = null;
            }

            if (ddlMaritalStatusID.Items.Count > 0)
            {
                if (ddlMaritalStatusID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.MaritalStatusID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.MaritalStatusID = Int64.Parse(ddlMaritalStatusID.SelectedValue);
                }
            }

            hREmployeeConfidentialInfoEntity.CityofBirth = txtCityofBirth.Text.Trim();
            if (ddlBirthOfStateID.Items.Count > 0)
            {
                if (ddlBirthOfStateID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.District = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.District = Int64.Parse(ddlBirthOfStateID.SelectedValue);
                }
            }

            if (ddlCountryOfBirthCountryID.Items.Count > 0)
            {
                if (ddlCountryOfBirthCountryID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.CountryOfBirthCountryID = Int64.Parse(ddlCountryOfBirthCountryID.SelectedValue);
                }
            }

            if (ddlResidenceCountryID.Items.Count > 0)
            {
                if (ddlResidenceCountryID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.ResidenceCountryID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.ResidenceCountryID = Int64.Parse(ddlResidenceCountryID.SelectedValue);
                }
            }

            hREmployeeConfidentialInfoEntity.PersonlTaxIdNumber = txtPersonlTaxIdNumber.Text.Trim();
            hREmployeeConfidentialInfoEntity.NationalIdNumber = txtNationalIdNumber.Text.Trim();
            if (ddlRegionID.Items.Count > 0)
            {
                if (ddlRegionID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.RegionID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.RegionID = Int64.Parse(ddlRegionID.SelectedValue);
                }
            }

            if (ddlReligionID.Items.Count > 0)
            {
                if (ddlReligionID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.ReligionID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.ReligionID = Int64.Parse(ddlReligionID.SelectedValue);
                }
            }

            hREmployeeConfidentialInfoEntity.BirthMark = txtBirthMark.Text.Trim();
            if (ddlBloodGroupID.Items.Count > 0)
            {
                if (ddlBloodGroupID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.BloodGroupID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.BloodGroupID = Int64.Parse(ddlBloodGroupID.SelectedValue);
                }
            }

            hREmployeeConfidentialInfoEntity.DisabilityInformation = txtDisabilityInformation.Text.Trim();
            if (ddlGenderID.Items.Count > 0)
            {
                if (ddlGenderID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.GenderID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.GenderID = Int64.Parse(ddlGenderID.SelectedValue);
                }
            }

            if (txtAnniversaryDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeConfidentialInfoEntity.AnniversaryDate = MiscUtil.ParseToDateTime(txtAnniversaryDate.Text);
            }
            else
            {
                hREmployeeConfidentialInfoEntity.AnniversaryDate = null;
            }

            hREmployeeConfidentialInfoEntity.Height = txtHeight.Text.Trim();
            hREmployeeConfidentialInfoEntity.Weight = txtWeight.Text.Trim();
            if (ddlCurrentNationalityCountryID.Items.Count > 0)
            {
                if (ddlCurrentNationalityCountryID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.CurrentNationalityCountryID = Int64.Parse(ddlCurrentNationalityCountryID.SelectedValue);
                }
            }

            if (ddlPreviousNationalityCountryID.Items.Count > 0)
            {
                if (ddlPreviousNationalityCountryID.SelectedValue == "0")
                {
                    hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID = null;
                }
                else
                {
                    hREmployeeConfidentialInfoEntity.PreviousNationalityCountryID = Int64.Parse(ddlPreviousNationalityCountryID.SelectedValue);
                }
            }

            hREmployeeConfidentialInfoEntity.HasPassport = chkHasPassport.Checked;

            hREmployeeConfidentialInfoEntity.HasDrivingLisence = chkHasDrivingLisence.Checked;

            hREmployeeConfidentialInfoEntity.IsRemoved = chkIsRemoved.Checked;


            return hREmployeeConfidentialInfoEntity;
        }

        private void SaveHREmployeeConfidentialInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeConfidentialInfoEntity hREmployeeConfidentialInfoEntity = BuildHREmployeeConfidentialInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeConfidentialInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeConfidentialInfo.GetFacadeCreate().Add(hREmployeeConfidentialInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeConfidentialInfoEntity.FLD_NAME_EmployeeConfidentialInfoID, hREmployeeConfidentialInfoEntity.EmployeeConfidentialInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeConfidentialInfo.GetFacadeCreate().Update(hREmployeeConfidentialInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeConfidentialInfoID = result;
                        _HREmployeeConfidentialInfoEntity = CurrentHREmployeeConfidentialInfoEntity; 
                        //PrepareInitialView();
                        BindHREmployeeConfidentialInfoList();
                        PrepareEditView();

                        if (hREmployeeConfidentialInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Confidential Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Confidential Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeConfidentialInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Confidential Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Confidential Info Information.", false);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeConfidentialInfoEntity();
        }
        #endregion

        #endregion Event
    }
}
