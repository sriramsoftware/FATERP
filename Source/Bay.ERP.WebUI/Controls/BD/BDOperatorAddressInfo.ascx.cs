// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 08:31:04




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
    public partial class BDOperatorAddressInfoControl : OperatorBaseControl
    {       
        #region Properties

        public Int64 _OperatorAddressInfoID
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

        public BDOperatorAddressInfoEntity _BDOperatorAddressInfoEntity
        {
            get
            {
                BDOperatorAddressInfoEntity entity = new BDOperatorAddressInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDOperatorAddressInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDOperatorAddressInfoEntity CurrentBDOperatorAddressInfoEntity
        {
            get
            {
                if (_OperatorAddressInfoID > 0)
                {
                    if (_BDOperatorAddressInfoEntity.OperatorAddressInfoID != _OperatorAddressInfoID)
                    {
                        _BDOperatorAddressInfoEntity = FCCBDOperatorAddressInfo.GetFacadeCreate().GetByID(_OperatorAddressInfoID);
                    }
                }

                return _BDOperatorAddressInfoEntity;
            }
            set
            {
                _BDOperatorAddressInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
           MiscUtil.PopulateBDOperator(ddlOperatorID, false);
            MiscUtil.PopulateMDOperatorAddressType(ddlOperatorAddressTypeID, false);
        }

        private void PrepareValidator()
        {

            revWebLink.ValidationExpression = ValidationConstants.RegularExpression.Web;
            revWebLink.ErrorMessage = ValidationConstants.ErrorMessage.Web;
            revZipCode.ValidationExpression = ValidationConstants.RegularExpression.ZipCode;
            txtZipCode.MaxLength = ValidationConstants.FieldLength.ZipCode;
            revZipCode.ErrorMessage = ValidationConstants.ErrorMessage.ZipCode;
            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;

        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtWebLink.Text = String.Empty;
            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtCountryID.Text = String.Empty;
            txtCityID.Text = String.Empty;
            txtZipCode.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity = CurrentBDOperatorAddressInfoEntity;


            if (!bDOperatorAddressInfoEntity.IsNew)
            {
                if (ddlOperatorID.Items.Count > 0 && bDOperatorAddressInfoEntity.OperatorID != null)
                {
                    ddlOperatorID.SelectedValue = bDOperatorAddressInfoEntity.OperatorID.ToString();
                }

                txtWebLink.Text = bDOperatorAddressInfoEntity.WebLink.ToString();
                if (ddlOperatorAddressTypeID.Items.Count > 0 && bDOperatorAddressInfoEntity.OperatorAddressTypeID != null)
                {
                    ddlOperatorAddressTypeID.SelectedValue = bDOperatorAddressInfoEntity.OperatorAddressTypeID.ToString();
                }

                txtAddressLine1.Text = bDOperatorAddressInfoEntity.AddressLine1.ToString();
                txtAddressLine2.Text = bDOperatorAddressInfoEntity.AddressLine2.ToString();
                txtCountryID.Text = bDOperatorAddressInfoEntity.CountryID.ToString();
                txtCityID.Text = bDOperatorAddressInfoEntity.CityID.ToString();
                txtZipCode.Text = bDOperatorAddressInfoEntity.ZipCode.ToString();
                txtPhone.Text = bDOperatorAddressInfoEntity.Phone.ToString();
                txtEmail.Text = bDOperatorAddressInfoEntity.Email.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDOperatorAddressInfoList();
        }

        private void BindBDOperatorAddressInfoList()
        {
            lvBDOperatorAddressInfo.DataBind();
        }

        private BDOperatorAddressInfoEntity BuildBDOperatorAddressInfoEntity()
        {
            BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity = CurrentBDOperatorAddressInfoEntity;

            if (ddlOperatorID.Items.Count > 0)
            {
                if (ddlOperatorID.SelectedValue == "0")
                {
                }
                else
                {
                    bDOperatorAddressInfoEntity.OperatorID = Int64.Parse(ddlOperatorID.SelectedValue);
                }
            }

            bDOperatorAddressInfoEntity.WebLink = txtWebLink.Text.Trim();
            if (ddlOperatorAddressTypeID.Items.Count > 0)
            {
                if (ddlOperatorAddressTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    bDOperatorAddressInfoEntity.OperatorAddressTypeID = Int64.Parse(ddlOperatorAddressTypeID.SelectedValue);
                }
            }

            bDOperatorAddressInfoEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            bDOperatorAddressInfoEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            if (!txtCountryID.Text.Trim().IsNullOrEmpty())
            {
                bDOperatorAddressInfoEntity.CountryID = Int64.Parse(txtCountryID.Text.Trim());
            }
            else
            {
                bDOperatorAddressInfoEntity.CountryID = null;
            }

            if (!txtCityID.Text.Trim().IsNullOrEmpty())
            {
                bDOperatorAddressInfoEntity.CityID = Int64.Parse(txtCityID.Text.Trim());
            }
            else
            {
                bDOperatorAddressInfoEntity.CityID = null;
            }

            bDOperatorAddressInfoEntity.ZipCode = txtZipCode.Text.Trim();
            bDOperatorAddressInfoEntity.Phone = txtPhone.Text.Trim();
            bDOperatorAddressInfoEntity.Email = txtEmail.Text.Trim();

            return bDOperatorAddressInfoEntity;
        }

        private void SaveBDOperatorAddressInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity = BuildBDOperatorAddressInfoEntity();

                    Int64 result = -1;

                    if (bDOperatorAddressInfoEntity.IsNew)
                    {
                        result = FCCBDOperatorAddressInfo.GetFacadeCreate().Add(bDOperatorAddressInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorAddressInfoEntity.FLD_NAME_OperatorAddressInfoID, bDOperatorAddressInfoEntity.OperatorAddressInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCBDOperatorAddressInfo.GetFacadeCreate().Update(bDOperatorAddressInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _OperatorAddressInfoID = 0;
                        _BDOperatorAddressInfoEntity = new BDOperatorAddressInfoEntity();
                        PrepareInitialView();
                        BindBDOperatorAddressInfoList();

                        if (bDOperatorAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Address Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Address Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDOperatorAddressInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Operator Address Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Operator Address Info Information.", false);
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

        protected void lvBDOperatorAddressInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 OperatorAddressInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out OperatorAddressInfoID);

            if (OperatorAddressInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _OperatorAddressInfoID = OperatorAddressInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorAddressInfoEntity.FLD_NAME_OperatorAddressInfoID, OperatorAddressInfoID.ToString(), SQLMatchType.Equal);

                        BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity = new BDOperatorAddressInfoEntity();


                        result = FCCBDOperatorAddressInfo.GetFacadeCreate().Delete(bDOperatorAddressInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _OperatorAddressInfoID = 0;
                            _BDOperatorAddressInfoEntity = new BDOperatorAddressInfoEntity();
                            PrepareInitialView();
                            BindBDOperatorAddressInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Operator Address Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Operator Address Info.", true);
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

        protected void odsBDOperatorAddressInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorAddressInfoEntity.FLD_NAME_OperatorID, this.OverviewOperatorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDOperatorAddressInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _OperatorAddressInfoID = 0;
            _BDOperatorAddressInfoEntity = new BDOperatorAddressInfoEntity();
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
