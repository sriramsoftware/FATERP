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
    public partial class HREmployeeAddressInfoControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeAddressInfoID
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

        public HREmployeeAddressInfoEntity _HREmployeeAddressInfoEntity
        {
            get
            {
                HREmployeeAddressInfoEntity entity = new HREmployeeAddressInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeAddressInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeAddressInfoEntity CurrentHREmployeeAddressInfoEntity
        {
            get
            {
                if (_EmployeeAddressInfoID > 0)
                {
                    if (_HREmployeeAddressInfoEntity.EmployeeAddressInfoID != _EmployeeAddressInfoID)
                    {
                        _HREmployeeAddressInfoEntity = FCCHREmployeeAddressInfo.GetFacadeCreate().GetByID(_EmployeeAddressInfoID);
                    }
                }

                return _HREmployeeAddressInfoEntity;
            }
            set
            {
                _HREmployeeAddressInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDEmployeeAddressType(ddlEmployeeAddressTypeID, false);
            MiscUtil.PopulateMDCountry(ddlCountryID, true);
            MiscUtil.PopulateMDCity(ddlCityID, true);
        }

        private void PrepareValidator()
        {
            revZipCode.ValidationExpression = ValidationConstants.RegularExpression.ZipCode;
            txtZipCode.MaxLength = ValidationConstants.FieldLength.ZipCode;
            revZipCode.ErrorMessage = ValidationConstants.ErrorMessage.ZipCode;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtZipCode.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeAddressInfoEntity hREmployeeAddressInfoEntity = CurrentHREmployeeAddressInfoEntity;


            if (!hREmployeeAddressInfoEntity.IsNew)
            {
                if (ddlEmployeeAddressTypeID.Items.Count > 0 && hREmployeeAddressInfoEntity.EmployeeAddressTypeID != null)
                {
                    ddlEmployeeAddressTypeID.SelectedValue = hREmployeeAddressInfoEntity.EmployeeAddressTypeID.ToString();
                }

                if (ddlCountryID.Items.Count > 0 && hREmployeeAddressInfoEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = hREmployeeAddressInfoEntity.CountryID.ToString();
                }

                if (ddlCityID.Items.Count > 0 && hREmployeeAddressInfoEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = hREmployeeAddressInfoEntity.CityID.ToString();
                }

                txtAddressLine1.Text = hREmployeeAddressInfoEntity.AddressLine1.ToString();
                txtAddressLine2.Text = hREmployeeAddressInfoEntity.AddressLine2.ToString();
                txtZipCode.Text = hREmployeeAddressInfoEntity.ZipCode.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeAddressInfoList();
        }

        private void BindHREmployeeAddressInfoList()
        {
            lvHREmployeeAddressInfo.DataBind();
        }

        private HREmployeeAddressInfoEntity BuildHREmployeeAddressInfoEntity()
        {
            HREmployeeAddressInfoEntity hREmployeeAddressInfoEntity = CurrentHREmployeeAddressInfoEntity;

            if (ddlEmployeeAddressTypeID.Items.Count > 0)
            {
                if (ddlEmployeeAddressTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeAddressInfoEntity.EmployeeAddressTypeID = Int64.Parse(ddlEmployeeAddressTypeID.SelectedValue);
                }
            }

           
                    hREmployeeAddressInfoEntity.EmployeeID = OverviewEmployeeID;

            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                    hREmployeeAddressInfoEntity.CountryID = null;
                }
                else
                {
                    hREmployeeAddressInfoEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                    hREmployeeAddressInfoEntity.CityID = null;
                }
                else
                {
                    hREmployeeAddressInfoEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            hREmployeeAddressInfoEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            hREmployeeAddressInfoEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            hREmployeeAddressInfoEntity.ZipCode = txtZipCode.Text.Trim();

            return hREmployeeAddressInfoEntity;
        }

        private void SaveHREmployeeAddressInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeAddressInfoEntity hREmployeeAddressInfoEntity = BuildHREmployeeAddressInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeAddressInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeAddressInfo.GetFacadeCreate().Add(hREmployeeAddressInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAddressInfoEntity.FLD_NAME_EmployeeAddressInfoID, hREmployeeAddressInfoEntity.EmployeeAddressInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeAddressInfo.GetFacadeCreate().Update(hREmployeeAddressInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeAddressInfoID = 0;
                        _HREmployeeAddressInfoEntity = new HREmployeeAddressInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeAddressInfoList();

                        if (hREmployeeAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Address Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Address Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Address Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Address Info Information.", false);
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

        protected void lvHREmployeeAddressInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeAddressInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeAddressInfoID);

            if (EmployeeAddressInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeAddressInfoID = EmployeeAddressInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAddressInfoEntity.FLD_NAME_EmployeeAddressInfoID, EmployeeAddressInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeAddressInfoEntity hREmployeeAddressInfoEntity = new HREmployeeAddressInfoEntity();


                        result = FCCHREmployeeAddressInfo.GetFacadeCreate().Delete(hREmployeeAddressInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeAddressInfoID = 0;
                            _HREmployeeAddressInfoEntity = new HREmployeeAddressInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeAddressInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Address Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Address Info.", true);
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

        protected void odsHREmployeeAddressInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeAddressInfo." + HREmployeeAddressInfoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeAddressInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeAddressInfoID = 0;
            _HREmployeeAddressInfoEntity = new HREmployeeAddressInfoEntity();
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
