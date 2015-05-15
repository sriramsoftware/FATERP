// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




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
    public partial class PRMSupplierAddressInfoControl : SupplierBaseControl
    {       
        #region Properties

        public Int64 _SupplierAddressInfoID
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

        public PRMSupplierAddressInfoEntity _PRMSupplierAddressInfoEntity
        {
            get
            {
                PRMSupplierAddressInfoEntity entity = new PRMSupplierAddressInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierAddressInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierAddressInfoEntity CurrentPRMSupplierAddressInfoEntity
        {
            get
            {
                if (_SupplierAddressInfoID > 0)
                {
                    if (_PRMSupplierAddressInfoEntity.SupplierAddressInfoID != _SupplierAddressInfoID)
                    {
                        _PRMSupplierAddressInfoEntity = FCCPRMSupplierAddressInfo.GetFacadeCreate().GetByID(_SupplierAddressInfoID);
                    }
                }

                return _PRMSupplierAddressInfoEntity;
            }
            set
            {
                _PRMSupplierAddressInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateMDSupplierAddressType(ddlSupplierAddressTypeID, false);
            MiscUtil.PopulateMDCountry(ddlCountryID, true);

            BindCityByCountry();
        }

        private void BindCityByCountry()
        {
            if (ddlCountryID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCityByCountryID(ddlCityID, true, Int64.Parse(ddlCountryID.SelectedValue));
            }
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
            PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity = CurrentPRMSupplierAddressInfoEntity;


            if (!pRMSupplierAddressInfoEntity.IsNew)
            {
               
                if (ddlSupplierAddressTypeID.Items.Count > 0 && pRMSupplierAddressInfoEntity.SupplierAddressTypeID != null)
                {
                    ddlSupplierAddressTypeID.SelectedValue = pRMSupplierAddressInfoEntity.SupplierAddressTypeID.ToString();
                }

                txtAddressLine1.Text = pRMSupplierAddressInfoEntity.AddressLine1.ToString();
                txtAddressLine2.Text = pRMSupplierAddressInfoEntity.AddressLine2.ToString();
                if (ddlCountryID.Items.Count > 0 && pRMSupplierAddressInfoEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = pRMSupplierAddressInfoEntity.CountryID.ToString();
                }

                BindCityByCountry();

                if (ddlCityID.Items.Count > 0 && pRMSupplierAddressInfoEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = pRMSupplierAddressInfoEntity.CityID.ToString();
                }

                txtZipCode.Text = pRMSupplierAddressInfoEntity.ZipCode.ToString();
                txtPhone.Text = pRMSupplierAddressInfoEntity.Phone.ToString();
                txtEmail.Text = pRMSupplierAddressInfoEntity.Email.ToString();
                txtWebLink.Text = pRMSupplierAddressInfoEntity.WebLink.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMSupplierAddressInfoList();
        }

        private void BindPRMSupplierAddressInfoList()
        {
            lvPRMSupplierAddressInfo.DataBind();
        }

        private PRMSupplierAddressInfoEntity BuildPRMSupplierAddressInfoEntity()
        {
            PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity = CurrentPRMSupplierAddressInfoEntity;

            pRMSupplierAddressInfoEntity.SupplierID = Int64.Parse(this.OverviewSupplierID.ToString());
           
            if (ddlSupplierAddressTypeID.Items.Count > 0)
            {
                if (ddlSupplierAddressTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMSupplierAddressInfoEntity.SupplierAddressTypeID = Int64.Parse(ddlSupplierAddressTypeID.SelectedValue);
                }
            }

            pRMSupplierAddressInfoEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            pRMSupplierAddressInfoEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                    pRMSupplierAddressInfoEntity.CountryID = null;
                }
                else
                {
                    pRMSupplierAddressInfoEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                    pRMSupplierAddressInfoEntity.CityID = null;
                }
                else
                {
                    pRMSupplierAddressInfoEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            pRMSupplierAddressInfoEntity.ZipCode = txtZipCode.Text.Trim();
            pRMSupplierAddressInfoEntity.Phone = txtPhone.Text.Trim();
            pRMSupplierAddressInfoEntity.Email = txtEmail.Text.Trim();
            pRMSupplierAddressInfoEntity.WebLink = txtWebLink.Text.Trim();

            return pRMSupplierAddressInfoEntity;
        }

        private void SavePRMSupplierAddressInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity = BuildPRMSupplierAddressInfoEntity();

                    Int64 result = -1;

                    if (pRMSupplierAddressInfoEntity.IsNew)
                    {
                        result = FCCPRMSupplierAddressInfo.GetFacadeCreate().Add(pRMSupplierAddressInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierAddressInfoEntity.FLD_NAME_SupplierAddressInfoID, pRMSupplierAddressInfoEntity.SupplierAddressInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMSupplierAddressInfo.GetFacadeCreate().Update(pRMSupplierAddressInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupplierAddressInfoID = 0;
                        _PRMSupplierAddressInfoEntity = new PRMSupplierAddressInfoEntity();
                        PrepareInitialView();
                        BindPRMSupplierAddressInfoList();

                        if (pRMSupplierAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Address Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Address Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMSupplierAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Address Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Address Info Information.", false);
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

        protected void lvPRMSupplierAddressInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierAddressInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierAddressInfoID);

            if (SupplierAddressInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierAddressInfoID = SupplierAddressInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierAddressInfoEntity.FLD_NAME_SupplierAddressInfoID, SupplierAddressInfoID.ToString(), SQLMatchType.Equal);

                        PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity = new PRMSupplierAddressInfoEntity();


                        result = FCCPRMSupplierAddressInfo.GetFacadeCreate().Delete(pRMSupplierAddressInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierAddressInfoID = 0;
                            _PRMSupplierAddressInfoEntity = new PRMSupplierAddressInfoEntity();
                            PrepareInitialView();
                            BindPRMSupplierAddressInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Address Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Address Info.", true);
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

        protected void odsPRMSupplierAddressInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierAddressInfo." + PRMSupplierAddressInfoEntity.FLD_NAME_SupplierID, this.OverviewSupplierID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMSupplierAddressInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupplierAddressInfoID = 0;
            _PRMSupplierAddressInfoEntity = new PRMSupplierAddressInfoEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlCountryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCityByCountry();
        }

        #endregion

        #endregion Event
    }
}
