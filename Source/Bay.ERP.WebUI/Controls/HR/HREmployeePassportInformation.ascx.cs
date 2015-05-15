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
    public partial class HREmployeePassportInformationControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeePassportInformationID
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

        public HREmployeePassportInformationEntity _HREmployeePassportInformationEntity
        {
            get
            {
                HREmployeePassportInformationEntity entity = new HREmployeePassportInformationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeePassportInformationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeePassportInformationEntity CurrentHREmployeePassportInformationEntity
        {
            get
            {
                if (_EmployeePassportInformationID > 0)
                {
                    if (_HREmployeePassportInformationEntity.EmployeePassportInformationID != _EmployeePassportInformationID)
                    {
                        _HREmployeePassportInformationEntity = FCCHREmployeePassportInformation.GetFacadeCreate().GetByID(_EmployeePassportInformationID);
                    }
                }

                return _HREmployeePassportInformationEntity;
            }
            set
            {
                _HREmployeePassportInformationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCountry(ddlPassportCountry, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtCityName.Text = String.Empty;
            txtPassportNumber.Text = String.Empty;
            txtIssuedDate.Text = String.Empty;
            txtExpireDate.Text = String.Empty;
            txtPassportProfession.Text = String.Empty;
            txtNote.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeePassportInformationEntity hREmployeePassportInformationEntity = CurrentHREmployeePassportInformationEntity;


            if (!hREmployeePassportInformationEntity.IsNew)
            {
              

                if (ddlPassportCountry.Items.Count > 0 && hREmployeePassportInformationEntity.PassportCountry != null)
                {
                    ddlPassportCountry.SelectedValue = hREmployeePassportInformationEntity.PassportCountry.ToString();
                }

                txtCityName.Text = hREmployeePassportInformationEntity.CityName.ToString();
                txtPassportNumber.Text = hREmployeePassportInformationEntity.PassportNumber.ToString();
                txtIssuedDate.Text = hREmployeePassportInformationEntity.IssuedDate.ToStringDefault();
                txtExpireDate.Text = hREmployeePassportInformationEntity.ExpireDate.ToStringDefault();
                txtPassportProfession.Text = hREmployeePassportInformationEntity.PassportProfession.ToString();
                txtNote.Text = hREmployeePassportInformationEntity.Note.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeePassportInformationList();
        }

        private void BindHREmployeePassportInformationList()
        {
            lvHREmployeePassportInformation.DataBind();
        }

        private HREmployeePassportInformationEntity BuildHREmployeePassportInformationEntity()
        {
            HREmployeePassportInformationEntity hREmployeePassportInformationEntity = CurrentHREmployeePassportInformationEntity;


            hREmployeePassportInformationEntity.EmployeeID = OverviewEmployeeID;
            if (ddlPassportCountry.Items.Count > 0)
            {
                if (ddlPassportCountry.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeePassportInformationEntity.PassportCountry = Int64.Parse(ddlPassportCountry.SelectedValue);
                }
            }

            hREmployeePassportInformationEntity.CityName = txtCityName.Text.Trim();
            hREmployeePassportInformationEntity.PassportNumber = txtPassportNumber.Text.Trim();
            if (txtIssuedDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeePassportInformationEntity.IssuedDate = MiscUtil.ParseToDateTime(txtIssuedDate.Text);
            }

            if (txtExpireDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeePassportInformationEntity.ExpireDate = MiscUtil.ParseToDateTime(txtExpireDate.Text);
            }

            hREmployeePassportInformationEntity.PassportProfession = txtPassportProfession.Text.Trim();
            hREmployeePassportInformationEntity.Note = txtNote.Text.Trim();

            return hREmployeePassportInformationEntity;
        }

        private void SaveHREmployeePassportInformationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeePassportInformationEntity hREmployeePassportInformationEntity = BuildHREmployeePassportInformationEntity();

                    Int64 result = -1;

                    if (hREmployeePassportInformationEntity.IsNew)
                    {
                        result = FCCHREmployeePassportInformation.GetFacadeCreate().Add(hREmployeePassportInformationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePassportInformationEntity.FLD_NAME_EmployeePassportInformationID, hREmployeePassportInformationEntity.EmployeePassportInformationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeePassportInformation.GetFacadeCreate().Update(hREmployeePassportInformationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeePassportInformationID = 0;
                        _HREmployeePassportInformationEntity = new HREmployeePassportInformationEntity();
                        PrepareInitialView();
                        BindHREmployeePassportInformationList();

                        if (hREmployeePassportInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Passport Information Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Passport Information Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeePassportInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Passport Information Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Passport Information Information.", false);
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

        protected void lvHREmployeePassportInformation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeePassportInformationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeePassportInformationID);

            if (EmployeePassportInformationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeePassportInformationID = EmployeePassportInformationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeePassportInformationEntity.FLD_NAME_EmployeePassportInformationID, EmployeePassportInformationID.ToString(), SQLMatchType.Equal);

                        HREmployeePassportInformationEntity hREmployeePassportInformationEntity = new HREmployeePassportInformationEntity();


                        result = FCCHREmployeePassportInformation.GetFacadeCreate().Delete(hREmployeePassportInformationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeePassportInformationID = 0;
                            _HREmployeePassportInformationEntity = new HREmployeePassportInformationEntity();
                            PrepareInitialView();
                            BindHREmployeePassportInformationList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Passport Information has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Passport Information.", true);
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

        protected void odsHREmployeePassportInformation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeePassportInformation." + HREmployeePassportInformationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeePassportInformationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeePassportInformationID = 0;
            _HREmployeePassportInformationEntity = new HREmployeePassportInformationEntity();
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
