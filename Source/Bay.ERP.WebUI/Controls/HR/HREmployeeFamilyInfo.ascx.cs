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
    public partial class HREmployeeFamilyInfoControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _HREmployeeFamilyInfoID
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

        public HREmployeeFamilyInfoEntity _HREmployeeFamilyInfoEntity
        {
            get
            {
                HREmployeeFamilyInfoEntity entity = new HREmployeeFamilyInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeFamilyInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeFamilyInfoEntity CurrentHREmployeeFamilyInfoEntity
        {
            get
            {
                if (_HREmployeeFamilyInfoID > 0)
                {
                    if (_HREmployeeFamilyInfoEntity.HREmployeeFamilyInfoID != _HREmployeeFamilyInfoID)
                    {
                        _HREmployeeFamilyInfoEntity = FCCHREmployeeFamilyInfo.GetFacadeCreate().GetByID(_HREmployeeFamilyInfoID);
                    }
                }

                return _HREmployeeFamilyInfoEntity;
            }
            set
            {
                _HREmployeeFamilyInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDFamilyRelationType(ddlFamilyRelationTypeID, false);
            MiscUtil.PopulateMDEducationalDegree(ddlLastEducationAcquired, false);
        }

        private void PrepareValidator()
        {

            revEmailAddress.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmailAddress.MaxLength = ValidationConstants.FieldLength.Email;
            revEmailAddress.ErrorMessage = ValidationConstants.ErrorMessage.Email;

            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtProfession.Text = String.Empty;
            chkIsDependent.Checked = false;
            chkIsEmployed.Checked = false;
            txtAge.Text = String.Empty;
            txtEmailAddress.Text = String.Empty;
            txtPhone.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity = CurrentHREmployeeFamilyInfoEntity;


            if (!hREmployeeFamilyInfoEntity.IsNew)
            {

                if (ddlFamilyRelationTypeID.Items.Count > 0 && hREmployeeFamilyInfoEntity.FamilyRelationTypeID != null)
                {
                    ddlFamilyRelationTypeID.SelectedValue = hREmployeeFamilyInfoEntity.FamilyRelationTypeID.ToString();
                }

                txtFirstName.Text = hREmployeeFamilyInfoEntity.FirstName.ToString();
                txtMiddleName.Text = hREmployeeFamilyInfoEntity.MiddleName.ToString();
                txtLastName.Text = hREmployeeFamilyInfoEntity.LastName.ToString();
                txtProfession.Text = hREmployeeFamilyInfoEntity.Profession.ToString();
                chkIsDependent.Checked = hREmployeeFamilyInfoEntity.IsDependent;
                if (ddlLastEducationAcquired.Items.Count > 0 && hREmployeeFamilyInfoEntity.LastEducationAcquired != null)
                {
                    ddlLastEducationAcquired.SelectedValue = hREmployeeFamilyInfoEntity.LastEducationAcquired.ToString();
                }

                chkIsEmployed.Checked = hREmployeeFamilyInfoEntity.IsEmployed;
                txtAge.Text = hREmployeeFamilyInfoEntity.Age.ToString();
                txtEmailAddress.Text = hREmployeeFamilyInfoEntity.EmailAddress.ToString();
                txtPhone.Text = hREmployeeFamilyInfoEntity.Phone.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeFamilyInfoList();
        }

        private void BindHREmployeeFamilyInfoList()
        {
            lvHREmployeeFamilyInfo.DataBind();
        }

        private HREmployeeFamilyInfoEntity BuildHREmployeeFamilyInfoEntity()
        {
            HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity = CurrentHREmployeeFamilyInfoEntity;

        
                    hREmployeeFamilyInfoEntity.EmployeeID = OverviewEmployeeID;

            if (ddlFamilyRelationTypeID.Items.Count > 0)
            {
                if (ddlFamilyRelationTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeFamilyInfoEntity.FamilyRelationTypeID = Int64.Parse(ddlFamilyRelationTypeID.SelectedValue);
                }
            }

            hREmployeeFamilyInfoEntity.FirstName = txtFirstName.Text.Trim();
            hREmployeeFamilyInfoEntity.MiddleName = txtMiddleName.Text.Trim();
            hREmployeeFamilyInfoEntity.LastName = txtLastName.Text.Trim();
            hREmployeeFamilyInfoEntity.Profession = txtProfession.Text.Trim();
            hREmployeeFamilyInfoEntity.IsDependent = chkIsDependent.Checked;

            if (ddlLastEducationAcquired.Items.Count > 0)
            {
                if (ddlLastEducationAcquired.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeFamilyInfoEntity.LastEducationAcquired = Int64.Parse(ddlLastEducationAcquired.SelectedValue);
                }
            }

            hREmployeeFamilyInfoEntity.IsEmployed = chkIsEmployed.Checked;

            if (!txtAge.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeFamilyInfoEntity.Age = Decimal.Parse(txtAge.Text.Trim());
            }
            else
            {
                hREmployeeFamilyInfoEntity.Age = null;
            }

            hREmployeeFamilyInfoEntity.EmailAddress = txtEmailAddress.Text.Trim();
            hREmployeeFamilyInfoEntity.Phone = txtPhone.Text.Trim();

            return hREmployeeFamilyInfoEntity;
        }

        private void SaveHREmployeeFamilyInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity = BuildHREmployeeFamilyInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeFamilyInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeFamilyInfo.GetFacadeCreate().Add(hREmployeeFamilyInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeFamilyInfoEntity.FLD_NAME_HREmployeeFamilyInfoID, hREmployeeFamilyInfoEntity.HREmployeeFamilyInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeFamilyInfo.GetFacadeCreate().Update(hREmployeeFamilyInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _HREmployeeFamilyInfoID = 0;
                        _HREmployeeFamilyInfoEntity = new HREmployeeFamilyInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeFamilyInfoList();

                        if (hREmployeeFamilyInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Family Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Family Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeFamilyInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Family Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Family Info Information.", false);
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

        protected void lvHREmployeeFamilyInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 HREmployeeFamilyInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out HREmployeeFamilyInfoID);

            if (HREmployeeFamilyInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _HREmployeeFamilyInfoID = HREmployeeFamilyInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeFamilyInfoEntity.FLD_NAME_HREmployeeFamilyInfoID, HREmployeeFamilyInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity = new HREmployeeFamilyInfoEntity();


                        result = FCCHREmployeeFamilyInfo.GetFacadeCreate().Delete(hREmployeeFamilyInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _HREmployeeFamilyInfoID = 0;
                            _HREmployeeFamilyInfoEntity = new HREmployeeFamilyInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeFamilyInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Family Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Family Info.", true);
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

        protected void odsHREmployeeFamilyInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeFamilyInfo." + HREmployeeFamilyInfoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeFamilyInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _HREmployeeFamilyInfoID = 0;
            _HREmployeeFamilyInfoEntity = new HREmployeeFamilyInfoEntity();
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
