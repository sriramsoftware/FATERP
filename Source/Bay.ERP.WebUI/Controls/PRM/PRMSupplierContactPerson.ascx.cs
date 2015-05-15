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
    public partial class PRMSupplierContactPersonControl : SupplierBaseControl
    {       
        #region Properties

        public Int64 _SupplierContactPersonID
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

        public PRMSupplierContactPersonEntity _PRMSupplierContactPersonEntity
        {
            get
            {
                PRMSupplierContactPersonEntity entity = new PRMSupplierContactPersonEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierContactPersonEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierContactPersonEntity CurrentPRMSupplierContactPersonEntity
        {
            get
            {
                if (_SupplierContactPersonID > 0)
                {
                    if (_PRMSupplierContactPersonEntity.SupplierContactPersonID != _SupplierContactPersonID)
                    {
                        _PRMSupplierContactPersonEntity = FCCPRMSupplierContactPerson.GetFacadeCreate().GetByID(_SupplierContactPersonID);
                    }
                }

                return _PRMSupplierContactPersonEntity;
            }
            set
            {
                _PRMSupplierContactPersonEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
          
        }

        private void PrepareValidator()
        {
            revPhone.ValidationExpression = ValidationConstants.RegularExpression.Phone;
            txtPhone.MaxLength = ValidationConstants.FieldLength.Phone;
            revPhone.ErrorMessage = ValidationConstants.ErrorMessage.Phone;

            revFax.ValidationExpression = ValidationConstants.RegularExpression.FaxNo;
            revFax.ErrorMessage = ValidationConstants.ErrorMessage.FaxNo;

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;


            revWebLink.ValidationExpression = ValidationConstants.RegularExpression.Web;
            revWebLink.ErrorMessage = ValidationConstants.ErrorMessage.Web;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDesignation.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtWebLink.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            PRMSupplierContactPersonEntity pRMSupplierContactPersonEntity = CurrentPRMSupplierContactPersonEntity;


            if (!pRMSupplierContactPersonEntity.IsNew)
            {
                txtName.Text = pRMSupplierContactPersonEntity.Name.ToString();
                txtDesignation.Text = pRMSupplierContactPersonEntity.Designation.ToString();
                txtPhone.Text = pRMSupplierContactPersonEntity.Phone.ToString();
                txtMobileNo.Text = pRMSupplierContactPersonEntity.MobileNo.ToString();
                txtFax.Text = pRMSupplierContactPersonEntity.Fax.ToString();
                txtEmail.Text = pRMSupplierContactPersonEntity.Email.ToString();
                txtWebLink.Text = pRMSupplierContactPersonEntity.WebLink.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMSupplierContactPersonList();
        }

        private void BindPRMSupplierContactPersonList()
        {
            lvPRMSupplierContactPerson.DataBind();
        }

        private PRMSupplierContactPersonEntity BuildPRMSupplierContactPersonEntity()
        {
            PRMSupplierContactPersonEntity pRMSupplierContactPersonEntity = CurrentPRMSupplierContactPersonEntity;

             pRMSupplierContactPersonEntity.SupplierID = Int64.Parse(this.OverviewSupplierID.ToString());
           
            pRMSupplierContactPersonEntity.Name = txtName.Text.Trim();
            pRMSupplierContactPersonEntity.Designation = txtDesignation.Text.Trim();
            pRMSupplierContactPersonEntity.Phone = txtPhone.Text.Trim();
            pRMSupplierContactPersonEntity.MobileNo = txtMobileNo.Text.Trim();
            pRMSupplierContactPersonEntity.Fax = txtFax.Text.Trim();
            pRMSupplierContactPersonEntity.Email = txtEmail.Text.Trim();
            pRMSupplierContactPersonEntity.WebLink = txtWebLink.Text.Trim();

            return pRMSupplierContactPersonEntity;
        }

        private void SavePRMSupplierContactPersonEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMSupplierContactPersonEntity pRMSupplierContactPersonEntity = BuildPRMSupplierContactPersonEntity();

                    Int64 result = -1;

                    if (pRMSupplierContactPersonEntity.IsNew)
                    {
                        result = FCCPRMSupplierContactPerson.GetFacadeCreate().Add(pRMSupplierContactPersonEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierContactPersonEntity.FLD_NAME_SupplierContactPersonID, pRMSupplierContactPersonEntity.SupplierContactPersonID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMSupplierContactPerson.GetFacadeCreate().Update(pRMSupplierContactPersonEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupplierContactPersonID = 0;
                        _PRMSupplierContactPersonEntity = new PRMSupplierContactPersonEntity();
                        PrepareInitialView();
                        BindPRMSupplierContactPersonList();

                        if (pRMSupplierContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Contact Person Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Contact Person Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMSupplierContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Contact Person Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Contact Person Information.", false);
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

        protected void lvPRMSupplierContactPerson_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierContactPersonID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierContactPersonID);

            if (SupplierContactPersonID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierContactPersonID = SupplierContactPersonID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierContactPersonEntity.FLD_NAME_SupplierContactPersonID, SupplierContactPersonID.ToString(), SQLMatchType.Equal);

                        PRMSupplierContactPersonEntity pRMSupplierContactPersonEntity = new PRMSupplierContactPersonEntity();


                        result = FCCPRMSupplierContactPerson.GetFacadeCreate().Delete(pRMSupplierContactPersonEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierContactPersonID = 0;
                            _PRMSupplierContactPersonEntity = new PRMSupplierContactPersonEntity();
                            PrepareInitialView();
                            BindPRMSupplierContactPersonList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Contact Person has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Contact Person.", true);
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

        protected void odsPRMSupplierContactPerson_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierContactPersonEntity.FLD_NAME_SupplierID, this.OverviewSupplierID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMSupplierContactPersonEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupplierContactPersonID = 0;
            _PRMSupplierContactPersonEntity = new PRMSupplierContactPersonEntity();
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
