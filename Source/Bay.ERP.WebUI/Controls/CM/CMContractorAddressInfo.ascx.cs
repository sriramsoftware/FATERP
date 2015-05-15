// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




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
    public partial class CMContractorAddressInfoControl : ContractorBaseControl
    {
        #region Properties

        public Int64 _ContractorAddressInfoID
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

        public CMContractorAddressInfoEntity _CMContractorAddressInfoEntity
        {
            get
            {
                CMContractorAddressInfoEntity entity = new CMContractorAddressInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMContractorAddressInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMContractorAddressInfoEntity CurrentCMContractorAddressInfoEntity
        {
            get
            {
                if (_ContractorAddressInfoID > 0)
                {
                    if (_CMContractorAddressInfoEntity.ContractorAddressInfoID != _ContractorAddressInfoID)
                    {
                        _CMContractorAddressInfoEntity = FCCCMContractorAddressInfo.GetFacadeCreate().GetByID(_ContractorAddressInfoID);
                    }
                }

                return _CMContractorAddressInfoEntity;
            }
            set
            {
                _CMContractorAddressInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDAddressType(ddlAddressTypeID, false);
            MiscUtil.PopulateMDCountry(ddlCountryID, true);

        }

        private void PrepareValidator()
        {

            revFax.ValidationExpression = ValidationConstants.RegularExpression.FaxNo;
            revFax.ErrorMessage = ValidationConstants.ErrorMessage.FaxNo;
            revZipCode.ValidationExpression = ValidationConstants.RegularExpression.ZipCode;
            txtZipCode.MaxLength = ValidationConstants.FieldLength.ZipCode;
            revZipCode.ErrorMessage = ValidationConstants.ErrorMessage.ZipCode;
            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtZipCode.Text = String.Empty;
            txtPhone.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMContractorAddressInfoEntity cMContractorAddressInfoEntity = CurrentCMContractorAddressInfoEntity;


            if (!cMContractorAddressInfoEntity.IsNew)
            {

                if (ddlAddressTypeID.Items.Count > 0 && cMContractorAddressInfoEntity.AddressTypeID != null)
                {
                    ddlAddressTypeID.SelectedValue = cMContractorAddressInfoEntity.AddressTypeID.ToString();
                }

                if (ddlCountryID.Items.Count > 0 && cMContractorAddressInfoEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = cMContractorAddressInfoEntity.CountryID.ToString();
                }

                if (ddlCountryID.SelectedValue != "0")
                {
                    MiscUtil.PopulateMDCityByCountryID(ddlCityID, true, Int64.Parse(ddlCountryID.SelectedValue));
                }

                if (ddlCityID.Items.Count > 0 && cMContractorAddressInfoEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = cMContractorAddressInfoEntity.CityID.ToString();
                }

                txtAddressLine1.Text = cMContractorAddressInfoEntity.AddressLine1.ToString();
                txtAddressLine2.Text = cMContractorAddressInfoEntity.AddressLine2.ToString();
                txtFax.Text = cMContractorAddressInfoEntity.Fax.ToString();
                txtZipCode.Text = cMContractorAddressInfoEntity.ZipCode.ToString();
                txtPhone.Text = cMContractorAddressInfoEntity.Phone.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMContractorAddressInfoList();
        }

        private void BindCMContractorAddressInfoList()
        {
            lvCMContractorAddressInfo.DataBind();
        }

        private CMContractorAddressInfoEntity BuildCMContractorAddressInfoEntity()
        {
            CMContractorAddressInfoEntity cMContractorAddressInfoEntity = CurrentCMContractorAddressInfoEntity;

            cMContractorAddressInfoEntity.ContractorID = this.OverviewContractorID;

            if (ddlAddressTypeID.Items.Count > 0)
            {
                if (ddlAddressTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cMContractorAddressInfoEntity.AddressTypeID = Int64.Parse(ddlAddressTypeID.SelectedValue);
                }
            }

            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                    cMContractorAddressInfoEntity.CountryID = null;
                }
                else
                {
                    cMContractorAddressInfoEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                    cMContractorAddressInfoEntity.CityID = null;
                }
                else
                {
                    cMContractorAddressInfoEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            cMContractorAddressInfoEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            cMContractorAddressInfoEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            cMContractorAddressInfoEntity.Fax = txtFax.Text.Trim();
            cMContractorAddressInfoEntity.ZipCode = txtZipCode.Text.Trim();
            cMContractorAddressInfoEntity.Phone = txtPhone.Text.Trim();

            return cMContractorAddressInfoEntity;
        }

        private void SaveCMContractorAddressInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMContractorAddressInfoEntity cMContractorAddressInfoEntity = BuildCMContractorAddressInfoEntity();

                    Int64 result = -1;

                    if (cMContractorAddressInfoEntity.IsNew)
                    {
                        result = FCCCMContractorAddressInfo.GetFacadeCreate().Add(cMContractorAddressInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMContractorAddressInfoEntity.FLD_NAME_ContractorAddressInfoID, cMContractorAddressInfoEntity.ContractorAddressInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCCMContractorAddressInfo.GetFacadeCreate().Update(cMContractorAddressInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ContractorAddressInfoID = 0;
                        _CMContractorAddressInfoEntity = new CMContractorAddressInfoEntity();
                        PrepareInitialView();
                        BindCMContractorAddressInfoList();

                        if (cMContractorAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Address Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Address Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMContractorAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Contractor Address Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Contractor Address Info Information.", false);
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

        protected void lvCMContractorAddressInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ContractorAddressInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out ContractorAddressInfoID);

            if (ContractorAddressInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ContractorAddressInfoID = ContractorAddressInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorAddressInfoEntity.FLD_NAME_ContractorAddressInfoID, ContractorAddressInfoID.ToString(), SQLMatchType.Equal);

                        CMContractorAddressInfoEntity cMContractorAddressInfoEntity = new CMContractorAddressInfoEntity();


                        result = FCCCMContractorAddressInfo.GetFacadeCreate().Delete(cMContractorAddressInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ContractorAddressInfoID = 0;
                            _CMContractorAddressInfoEntity = new CMContractorAddressInfoEntity();
                            PrepareInitialView();
                            BindCMContractorAddressInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Contractor Address Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Contractor Address Info.", true);
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

        protected void odsCMContractorAddressInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMContractorAddressInfo." + CMContractorAddressInfoEntity.FLD_NAME_ContractorID, this.OverviewContractorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Dropdown Event

        protected void ddlCountryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCountryID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCityByCountryID(ddlCityID, true, Int64.Parse(ddlCountryID.SelectedValue));
            }

        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMContractorAddressInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ContractorAddressInfoID = 0;
            _CMContractorAddressInfoEntity = new CMContractorAddressInfoEntity();
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
