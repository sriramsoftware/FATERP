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
    public partial class CRMCustomerControl : BaseControl
    {       
        #region Properties

        public Int64 _CustomerID
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

        public CRMCustomerEntity _CRMCustomerEntity
        {
            get
            {
                CRMCustomerEntity entity = new CRMCustomerEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMCustomerEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMCustomerEntity CurrentCRMCustomerEntity
        {
            get
            {
                if (_CustomerID > 0)
                {
                    if (_CRMCustomerEntity.CustomerID != _CustomerID)
                    {
                        _CRMCustomerEntity = FCCCRMCustomer.GetFacadeCreate().GetByID(_CustomerID);
                    }
                }

                return _CRMCustomerEntity;
            }
            set
            {
                _CRMCustomerEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
        }

        private void PrepareValidator()
        {

            revPrimaryEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtPrimaryEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revPrimaryEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;


            revSecondaryEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtSecondaryEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revSecondaryEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;

            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revFax.ValidationExpression = ValidationConstants.RegularExpression.FaxNo;
            revFax.ErrorMessage = ValidationConstants.ErrorMessage.FaxNo;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtFirstName.Text = String.Empty;
            txtMiddleName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPrimaryEmail.Text = String.Empty;
            txtSecondaryEmail.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtFax.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMCustomerEntity cRMCustomerEntity = CurrentCRMCustomerEntity;


            if (!cRMCustomerEntity.IsNew)
            {
                txtFirstName.Text = cRMCustomerEntity.FirstName.ToString();
                txtMiddleName.Text = cRMCustomerEntity.MiddleName.ToString();
                txtLastName.Text = cRMCustomerEntity.LastName.ToString();
                txtPrimaryEmail.Text = cRMCustomerEntity.PrimaryEmail.ToString();
                txtSecondaryEmail.Text = cRMCustomerEntity.SecondaryEmail.ToString();
                txtPhone.Text = cRMCustomerEntity.Phone.ToString();
                txtFax.Text = cRMCustomerEntity.Fax.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMCustomerList();
        }

        private void BindCRMCustomerList()
        {
            lvCRMCustomer.DataBind();
        }

        private CRMCustomerEntity BuildCRMCustomerEntity()
        {
            CRMCustomerEntity cRMCustomerEntity = CurrentCRMCustomerEntity;

            cRMCustomerEntity.FirstName = txtFirstName.Text.Trim();
            cRMCustomerEntity.MiddleName = txtMiddleName.Text.Trim();
            cRMCustomerEntity.LastName = txtLastName.Text.Trim();
            cRMCustomerEntity.PrimaryEmail = txtPrimaryEmail.Text.Trim();
            cRMCustomerEntity.SecondaryEmail = txtSecondaryEmail.Text.Trim();
            cRMCustomerEntity.Phone = txtPhone.Text.Trim();
            cRMCustomerEntity.Fax = txtFax.Text.Trim();

            return cRMCustomerEntity;
        }

        private void SaveCRMCustomerEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMCustomerEntity cRMCustomerEntity = BuildCRMCustomerEntity();

                    Int64 result = -1;

                    if (cRMCustomerEntity.IsNew)
                    {
                        result = FCCCRMCustomer.GetFacadeCreate().Add(cRMCustomerEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMCustomerEntity.FLD_NAME_CustomerID, cRMCustomerEntity.CustomerID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMCustomer.GetFacadeCreate().Update(cRMCustomerEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CustomerID = 0;
                        _CRMCustomerEntity = new CRMCustomerEntity();
                        PrepareInitialView();
                        BindCRMCustomerList();

                        if (cRMCustomerEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMCustomerEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMCustomer Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMCustomer Information.", false);
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

        protected void lvCRMCustomer_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CustomerID;

            Int64.TryParse(e.CommandArgument.ToString(), out CustomerID);

            if (CustomerID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CustomerID = CustomerID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMCustomerEntity.FLD_NAME_CustomerID, CustomerID.ToString(), SQLMatchType.Equal);

                        CRMCustomerEntity cRMCustomerEntity = new CRMCustomerEntity();


                        result = FCCCRMCustomer.GetFacadeCreate().Delete(cRMCustomerEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CustomerID = 0;
                            _CRMCustomerEntity = new CRMCustomerEntity();
                            PrepareInitialView();
                            BindCRMCustomerList();

                            MiscUtil.ShowMessage(lblMessage, "C RMCustomer has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMCustomer.", true);
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

        protected void odsCRMCustomer_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMCustomerEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CustomerID = 0;
            _CRMCustomerEntity = new CRMCustomerEntity();
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
