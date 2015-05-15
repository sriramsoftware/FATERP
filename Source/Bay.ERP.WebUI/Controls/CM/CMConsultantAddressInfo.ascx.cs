// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    public partial class CMConsultantAddressInfoControl : ConsultantBaseControl
    {
        #region Properties

        public Int64 _ConsultantAddressInfoID
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

        public CMConsultantAddressInfoEntity _CMConsultantAddressInfoEntity
        {
            get
            {
                CMConsultantAddressInfoEntity entity = new CMConsultantAddressInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMConsultantAddressInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMConsultantAddressInfoEntity CurrentCMConsultantAddressInfoEntity
        {
            get
            {
                if (_ConsultantAddressInfoID > 0)
                {
                    if (_CMConsultantAddressInfoEntity.ConsultantAddressInfoID != _ConsultantAddressInfoID)
                    {
                        _CMConsultantAddressInfoEntity = FCCCMConsultantAddressInfo.GetFacadeCreate().GetByID(_ConsultantAddressInfoID);
                    }
                }

                return _CMConsultantAddressInfoEntity;
            }
            set
            {
                _CMConsultantAddressInfoEntity = value;
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
            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revFax.ValidationExpression = ValidationConstants.RegularExpression.FaxNo;
            revFax.ErrorMessage = ValidationConstants.ErrorMessage.FaxNo;
            revZipCode.ValidationExpression = ValidationConstants.RegularExpression.ZipCode;
            txtZipCode.MaxLength = ValidationConstants.FieldLength.ZipCode;
            revZipCode.ErrorMessage = ValidationConstants.ErrorMessage.ZipCode;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtPhone.Text = String.Empty;
            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtZipCode.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity = CurrentCMConsultantAddressInfoEntity;


            if (!cMConsultantAddressInfoEntity.IsNew)
            {

                if (ddlAddressTypeID.Items.Count > 0 && cMConsultantAddressInfoEntity.AddressTypeID != null)
                {
                    ddlAddressTypeID.SelectedValue = cMConsultantAddressInfoEntity.AddressTypeID.ToString();
                }

                txtPhone.Text = cMConsultantAddressInfoEntity.Phone.ToString();
                if (ddlCountryID.Items.Count > 0 && cMConsultantAddressInfoEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = cMConsultantAddressInfoEntity.CountryID.ToString();
                }

                if (ddlCountryID.SelectedValue != "0")
                {
                    MiscUtil.PopulateMDCityByCountryID(ddlCityID, true, Int64.Parse(ddlCountryID.SelectedValue));
                }

                if (ddlCityID.Items.Count > 0 && cMConsultantAddressInfoEntity.CityID != null)
                {
                    ddlCityID.SelectedValue = cMConsultantAddressInfoEntity.CityID.ToString();
                }

                txtAddressLine1.Text = cMConsultantAddressInfoEntity.AddressLine1.ToString();
                txtAddressLine2.Text = cMConsultantAddressInfoEntity.AddressLine2.ToString();
                txtFax.Text = cMConsultantAddressInfoEntity.Fax.ToString();
                txtZipCode.Text = cMConsultantAddressInfoEntity.ZipCode.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMConsultantAddressInfoList();
        }

        private void BindCMConsultantAddressInfoList()
        {
            lvCMConsultantAddressInfo.DataBind();
        }

        private CMConsultantAddressInfoEntity BuildCMConsultantAddressInfoEntity()
        {
            CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity = CurrentCMConsultantAddressInfoEntity;

            cMConsultantAddressInfoEntity.ConsultantID = this.OverviewConsultantID;

            if (ddlAddressTypeID.Items.Count > 0)
            {
                if (ddlAddressTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cMConsultantAddressInfoEntity.AddressTypeID = Int64.Parse(ddlAddressTypeID.SelectedValue);
                }
            }

            cMConsultantAddressInfoEntity.Phone = txtPhone.Text.Trim();
            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                    cMConsultantAddressInfoEntity.CountryID = null;
                }
                else
                {
                    cMConsultantAddressInfoEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            if (ddlCityID.Items.Count > 0)
            {
                if (ddlCityID.SelectedValue == "0")
                {
                    cMConsultantAddressInfoEntity.CityID = null;
                }
                else
                {
                    cMConsultantAddressInfoEntity.CityID = Int64.Parse(ddlCityID.SelectedValue);
                }
            }

            cMConsultantAddressInfoEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            cMConsultantAddressInfoEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            cMConsultantAddressInfoEntity.Fax = txtFax.Text.Trim();
            cMConsultantAddressInfoEntity.ZipCode = txtZipCode.Text.Trim();

            return cMConsultantAddressInfoEntity;
        }

        private void SaveCMConsultantAddressInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity = BuildCMConsultantAddressInfoEntity();

                    Int64 result = -1;

                    if (cMConsultantAddressInfoEntity.IsNew)
                    {
                        result = FCCCMConsultantAddressInfo.GetFacadeCreate().Add(cMConsultantAddressInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantAddressInfoEntity.FLD_NAME_ConsultantAddressInfoID, cMConsultantAddressInfoEntity.ConsultantAddressInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCCMConsultantAddressInfo.GetFacadeCreate().Update(cMConsultantAddressInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConsultantAddressInfoID = 0;
                        _CMConsultantAddressInfoEntity = new CMConsultantAddressInfoEntity();
                        PrepareInitialView();
                        BindCMConsultantAddressInfoList();

                        if (cMConsultantAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Consultant Address Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Consultant Address Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMConsultantAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Consultant Address Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Consultant Address Info Information.", false);
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

        protected void lvCMConsultantAddressInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConsultantAddressInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConsultantAddressInfoID);

            if (ConsultantAddressInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConsultantAddressInfoID = ConsultantAddressInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantAddressInfoEntity.FLD_NAME_ConsultantAddressInfoID, ConsultantAddressInfoID.ToString(), SQLMatchType.Equal);

                        CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity = new CMConsultantAddressInfoEntity();


                        result = FCCCMConsultantAddressInfo.GetFacadeCreate().Delete(cMConsultantAddressInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ConsultantAddressInfoID = 0;
                            _CMConsultantAddressInfoEntity = new CMConsultantAddressInfoEntity();
                            PrepareInitialView();
                            BindCMConsultantAddressInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Consultant Address Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Consultant Address Info.", true);
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

        protected void odsCMConsultantAddressInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMConsultantAddressInfo." + CMConsultantAddressInfoEntity.FLD_NAME_ConsultantID, this.OverviewConsultantID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMConsultantAddressInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConsultantAddressInfoID = 0;
            _CMConsultantAddressInfoEntity = new CMConsultantAddressInfoEntity();
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
            if (ddlCountryID.SelectedValue != "0")
            {
                MiscUtil.PopulateMDCityByCountryID(ddlCityID, true, Int64.Parse(ddlCountryID.SelectedValue));
            }
        }

        #endregion

        #endregion Event
    }
}
