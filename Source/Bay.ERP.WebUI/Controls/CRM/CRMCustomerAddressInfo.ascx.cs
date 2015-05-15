// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public partial class CRMCustomerAddressInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _CustomerAddressInfoID
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

        public CRMCustomerAddressInfoEntity _CRMCustomerAddressInfoEntity
        {
            get
            {
                CRMCustomerAddressInfoEntity entity = new CRMCustomerAddressInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMCustomerAddressInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMCustomerAddressInfoEntity CurrentCRMCustomerAddressInfoEntity
        {
            get
            {
                if (_CustomerAddressInfoID > 0)
                {
                    if (_CRMCustomerAddressInfoEntity.CustomerAddressInfoID != _CustomerAddressInfoID)
                    {
                        _CRMCustomerAddressInfoEntity = FCCCRMCustomerAddressInfo.GetFacadeCreate().GetByID(_CustomerAddressInfoID);
                    }
                }

                return _CRMCustomerAddressInfoEntity;
            }
            set
            {
                _CRMCustomerAddressInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMCustomer(ddlCustomerID, false);
            MiscUtil.PopulateCRMMDCustomerAddressType(ddlCustomerAddressTypeID, false);
            MiscUtil.PopulateMDCountry(ddlCountryID, true);
            MiscUtil.PopulateMDCity(ddlCityID, true);
        }

        private void PrepareValidator()
        {
            revZipCode.ValidationExpression = ValidationConstants.RegularExpression.ZipCode;
            txtZipCode.MaxLength = ValidationConstants.FieldLength.ZipCode;
            revZipCode.ErrorMessage = ValidationConstants.ErrorMessage.ZipCode;
            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;


            revWebLink.ValidationExpression = ValidationConstants.RegularExpression.Web;
            revWebLink.ErrorMessage = ValidationConstants.ErrorMessage.Web;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtZipCode.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtWebLink.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMCustomerAddressInfoEntity cRMCustomerAddressInfoEntity = CurrentCRMCustomerAddressInfoEntity;


            if (!cRMCustomerAddressInfoEntity.IsNew)
            {
                if (ddlCustomerID.Items.Count > 0 && cRMCustomerAddressInfoEntity.CustomerID != null)
                {
                    ddlCustomerID.SelectedValue = cRMCustomerAddressInfoEntity.CustomerID.ToString();
                }

                if (ddlCustomerAddressTypeID.Items.Count > 0 && cRMCustomerAddressInfoEntity.CustomerAddressTypeID != null)
                {
                    ddlCustomerAddressTypeID.SelectedValue = cRMCustomerAddressInfoEntity.CustomerAddressTypeID.ToString();
                }

                txtAddressLine1.Text = cRMCustomerAddressInfoEntity.AddressLine1.ToString();
                txtAddressLine2.Text = cRMCustomerAddressInfoEntity.AddressLine2.ToString();
                if (ddlCountryID.Items.Count > 0 && cRMCustomerAddressInfoEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = cRMCustomerAddressInfoEntity.CountryID.ToString();
                }

                if (ddlCityID.Items.Count > 0 && cRMCustomerAddressInfoEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = cRMCustomerAddressInfoEntity.CityID.ToString();
                }

                txtZipCode.Text = cRMCustomerAddressInfoEntity.ZipCode.ToString();
                txtPhone.Text = cRMCustomerAddressInfoEntity.Phone.ToString();
                txtEmail.Text = cRMCustomerAddressInfoEntity.Email.ToString();
                txtWebLink.Text = cRMCustomerAddressInfoEntity.WebLink.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMCustomerAddressInfoList();
        }

        private void BindCRMCustomerAddressInfoList()
        {
            lvCRMCustomerAddressInfo.DataBind();
        }

        private CRMCustomerAddressInfoEntity BuildCRMCustomerAddressInfoEntity()
        {
            CRMCustomerAddressInfoEntity cRMCustomerAddressInfoEntity = CurrentCRMCustomerAddressInfoEntity;

            if (ddlCustomerID.Items.Count > 0)
            {
                if (ddlCustomerID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMCustomerAddressInfoEntity.CustomerID = Int64.Parse(ddlCustomerID.SelectedValue);
                }
            }

            if (ddlCustomerAddressTypeID.Items.Count > 0)
            {
                if (ddlCustomerAddressTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMCustomerAddressInfoEntity.CustomerAddressTypeID = Int64.Parse(ddlCustomerAddressTypeID.SelectedValue);
                }
            }

            cRMCustomerAddressInfoEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            cRMCustomerAddressInfoEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                    cRMCustomerAddressInfoEntity.CountryID = null;
                }
                else
                {
                    cRMCustomerAddressInfoEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                    cRMCustomerAddressInfoEntity.CityID = null;
                }
                else
                {
                    cRMCustomerAddressInfoEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            cRMCustomerAddressInfoEntity.ZipCode = txtZipCode.Text.Trim();
            cRMCustomerAddressInfoEntity.Phone = txtPhone.Text.Trim();
            cRMCustomerAddressInfoEntity.Email = txtEmail.Text.Trim();
            cRMCustomerAddressInfoEntity.WebLink = txtWebLink.Text.Trim();

            return cRMCustomerAddressInfoEntity;
        }

        private void SaveCRMCustomerAddressInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMCustomerAddressInfoEntity cRMCustomerAddressInfoEntity = BuildCRMCustomerAddressInfoEntity();

                    Int64 result = -1;

                    if (cRMCustomerAddressInfoEntity.IsNew)
                    {
                        result = FCCCRMCustomerAddressInfo.GetFacadeCreate().Add(cRMCustomerAddressInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMCustomerAddressInfoEntity.FLD_NAME_CustomerAddressInfoID, cRMCustomerAddressInfoEntity.CustomerAddressInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMCustomerAddressInfo.GetFacadeCreate().Update(cRMCustomerAddressInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CustomerAddressInfoID = 0;
                        _CRMCustomerAddressInfoEntity = new CRMCustomerAddressInfoEntity();
                        PrepareInitialView();
                        BindCRMCustomerAddressInfoList();

                        if (cRMCustomerAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer Address Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer Address Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMCustomerAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMCustomer Address Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMCustomer Address Info Information.", false);
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

        protected void lvCRMCustomerAddressInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CustomerAddressInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out CustomerAddressInfoID);

            if (CustomerAddressInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CustomerAddressInfoID = CustomerAddressInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMCustomerAddressInfoEntity.FLD_NAME_CustomerAddressInfoID, CustomerAddressInfoID.ToString(), SQLMatchType.Equal);

                        CRMCustomerAddressInfoEntity cRMCustomerAddressInfoEntity = new CRMCustomerAddressInfoEntity();


                        result = FCCCRMCustomerAddressInfo.GetFacadeCreate().Delete(cRMCustomerAddressInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CustomerAddressInfoID = 0;
                            _CRMCustomerAddressInfoEntity = new CRMCustomerAddressInfoEntity();
                            PrepareInitialView();
                            BindCRMCustomerAddressInfoList();

                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer Address Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMCustomer Address Info.", true);
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

        protected void odsCRMCustomerAddressInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMCustomerAddressInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CustomerAddressInfoID = 0;
            _CRMCustomerAddressInfoEntity = new CRMCustomerAddressInfoEntity();
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
