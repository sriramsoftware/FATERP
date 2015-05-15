// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2013, 12:49:20




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
    public partial class ACCompanyInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _CompanyInfoID
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

        public ACCompanyInfoEntity _ACCompanyInfoEntity
        {
            get
            {
                ACCompanyInfoEntity entity = new ACCompanyInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACCompanyInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACCompanyInfoEntity CurrentACCompanyInfoEntity
        {
            get
            {
                if (_CompanyInfoID > 0)
                {
                    if (_ACCompanyInfoEntity.CompanyInfoID != _CompanyInfoID)
                    {
                        _ACCompanyInfoEntity = FCCACCompanyInfo.GetFacadeCreate().GetByID(_CompanyInfoID);
                    }
                }

                return _ACCompanyInfoEntity;
            }
            set
            {
                _ACCompanyInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCurrency(ddlHomeCurrencyID, false);
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
        }

        private void PrepareValidator()
        {
            revPhoneNumber.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhoneNumber.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhoneNumber.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;

        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtCompanyName.Text = String.Empty;
            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtOfficialCompanyNumber.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACCompanyInfoEntity aCCompanyInfoEntity = CurrentACCompanyInfoEntity;


            if (!aCCompanyInfoEntity.IsNew)
            {
                txtCompanyName.Text = aCCompanyInfoEntity.CompanyName.ToString();
                txtAddressLine1.Text = aCCompanyInfoEntity.AddressLine1.ToString();
                txtAddressLine2.Text = aCCompanyInfoEntity.AddressLine2.ToString();
                txtPhoneNumber.Text = aCCompanyInfoEntity.PhoneNumber.ToString();
                txtEmail.Text = aCCompanyInfoEntity.Email.ToString();
                txtOfficialCompanyNumber.Text = aCCompanyInfoEntity.OfficialCompanyNumber.ToString();
                if (ddlHomeCurrencyID.Items.Count > 0 && aCCompanyInfoEntity.HomeCurrencyID != null)
                {
                    ddlHomeCurrencyID.SelectedValue = aCCompanyInfoEntity.HomeCurrencyID.ToString();
                }

                if (ddlFiscalYearID.Items.Count > 0 && aCCompanyInfoEntity.FiscalYearID != null)
                {
                    ddlFiscalYearID.SelectedValue = aCCompanyInfoEntity.FiscalYearID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACCompanyInfoList();
        }

        private void BindACCompanyInfoList()
        {
            lvACCompanyInfo.DataBind();
        }

        private ACCompanyInfoEntity BuildACCompanyInfoEntity()
        {
            ACCompanyInfoEntity aCCompanyInfoEntity = CurrentACCompanyInfoEntity;

            aCCompanyInfoEntity.CompanyName = txtCompanyName.Text.Trim();
            aCCompanyInfoEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            aCCompanyInfoEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            aCCompanyInfoEntity.PhoneNumber = txtPhoneNumber.Text.Trim();
            aCCompanyInfoEntity.Email = txtEmail.Text.Trim();
            aCCompanyInfoEntity.OfficialCompanyNumber = txtOfficialCompanyNumber.Text.Trim();
            if (ddlHomeCurrencyID.Items.Count > 0)
            {
                if (ddlHomeCurrencyID.SelectedValue == "0")
                {
                }
                else
                {
                    aCCompanyInfoEntity.HomeCurrencyID = Int64.Parse(ddlHomeCurrencyID.SelectedValue);
                }
            }

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    aCCompanyInfoEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }


            return aCCompanyInfoEntity;
        }

        private void SaveACCompanyInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACCompanyInfoEntity aCCompanyInfoEntity = BuildACCompanyInfoEntity();

                    Int64 result = -1;

                    if (aCCompanyInfoEntity.IsNew)
                    {
                        result = FCCACCompanyInfo.GetFacadeCreate().Add(aCCompanyInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACCompanyInfoEntity.FLD_NAME_CompanyInfoID, aCCompanyInfoEntity.CompanyInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCACCompanyInfo.GetFacadeCreate().Update(aCCompanyInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CompanyInfoID = 0;
                        _ACCompanyInfoEntity = new ACCompanyInfoEntity();
                        PrepareInitialView();
                        BindACCompanyInfoList();

                        if (aCCompanyInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCompany Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCompany Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCCompanyInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CCompany Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CCompany Info Information.", false);
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

        protected void lvACCompanyInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CompanyInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out CompanyInfoID);

            if (CompanyInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CompanyInfoID = CompanyInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCompanyInfoEntity.FLD_NAME_CompanyInfoID, CompanyInfoID.ToString(), SQLMatchType.Equal);

                        ACCompanyInfoEntity aCCompanyInfoEntity = new ACCompanyInfoEntity();


                        result = FCCACCompanyInfo.GetFacadeCreate().Delete(aCCompanyInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CompanyInfoID = 0;
                            _ACCompanyInfoEntity = new ACCompanyInfoEntity();
                            PrepareInitialView();
                            BindACCompanyInfoList();

                            MiscUtil.ShowMessage(lblMessage, "A CCompany Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CCompany Info.", true);
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

        protected void odsACCompanyInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACCompanyInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CompanyInfoID = 0;
            _ACCompanyInfoEntity = new ACCompanyInfoEntity();
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
