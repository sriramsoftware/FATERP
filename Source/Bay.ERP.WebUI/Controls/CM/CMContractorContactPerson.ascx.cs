// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class CMContractorContactPersonControl : ContractorBaseControl
    {       
        #region Properties

        public Int64 _ContractorContactPersonID
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

        public CMContractorContactPersonEntity _CMContractorContactPersonEntity
        {
            get
            {
                CMContractorContactPersonEntity entity = new CMContractorContactPersonEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMContractorContactPersonEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMContractorContactPersonEntity CurrentCMContractorContactPersonEntity
        {
            get
            {
                if (_ContractorContactPersonID > 0)
                {
                    if (_CMContractorContactPersonEntity.ContractorContactPersonID != _ContractorContactPersonID)
                    {
                        _CMContractorContactPersonEntity = FCCCMContractorContactPerson.GetFacadeCreate().GetByID(_ContractorContactPersonID);
                    }
                }

                return _CMContractorContactPersonEntity;
            }
            set
            {
                _CMContractorContactPersonEntity = value;
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

            revEmail.ValidationExpression = ValidationConstants.RegularExpression.Email;
            txtEmail.MaxLength = ValidationConstants.FieldLength.Email;
            revEmail.ErrorMessage = ValidationConstants.ErrorMessage.Email;

        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDesignation.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMContractorContactPersonEntity cMContractorContactPersonEntity = CurrentCMContractorContactPersonEntity;


            if (!cMContractorContactPersonEntity.IsNew)
            {
                
                txtName.Text = cMContractorContactPersonEntity.Name.ToString();
                txtDesignation.Text = cMContractorContactPersonEntity.Designation.ToString();
                txtPhone.Text = cMContractorContactPersonEntity.Phone.ToString();
                txtEmail.Text = cMContractorContactPersonEntity.Email.ToString();
                txtAddressLine1.Text = cMContractorContactPersonEntity.AddressLine1.ToString();
                txtAddressLine2.Text = cMContractorContactPersonEntity.AddressLine2.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMContractorContactPersonList();
        }

        private void BindCMContractorContactPersonList()
        {
            lvCMContractorContactPerson.DataBind();
        }

        private CMContractorContactPersonEntity BuildCMContractorContactPersonEntity()
        {
            CMContractorContactPersonEntity cMContractorContactPersonEntity = CurrentCMContractorContactPersonEntity;

            cMContractorContactPersonEntity.ContractorID = this.OverviewContractorID;

            cMContractorContactPersonEntity.Name = txtName.Text.Trim();
            cMContractorContactPersonEntity.Designation = txtDesignation.Text.Trim();
            cMContractorContactPersonEntity.Phone = txtPhone.Text.Trim();
            cMContractorContactPersonEntity.Email = txtEmail.Text.Trim();
            cMContractorContactPersonEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            cMContractorContactPersonEntity.AddressLine2 = txtAddressLine2.Text.Trim();

            return cMContractorContactPersonEntity;
        }

        private void SaveCMContractorContactPersonEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMContractorContactPersonEntity cMContractorContactPersonEntity = BuildCMContractorContactPersonEntity();

                    Int64 result = -1;

                    if (cMContractorContactPersonEntity.IsNew)
                    {
                        result = FCCCMContractorContactPerson.GetFacadeCreate().Add(cMContractorContactPersonEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMContractorContactPersonEntity.FLD_NAME_ContractorContactPersonID, cMContractorContactPersonEntity.ContractorContactPersonID.ToString(), SQLMatchType.Equal);
                        result = FCCCMContractorContactPerson.GetFacadeCreate().Update(cMContractorContactPersonEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ContractorContactPersonID = 0;
                        _CMContractorContactPersonEntity = new CMContractorContactPersonEntity();
                        PrepareInitialView();
                        BindCMContractorContactPersonList();

                        if (cMContractorContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Contact Person Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Contact Person Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMContractorContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Contractor Contact Person Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Contractor Contact Person Information.", false);
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

        protected void lvCMContractorContactPerson_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ContractorContactPersonID;

            Int64.TryParse(e.CommandArgument.ToString(), out ContractorContactPersonID);

            if (ContractorContactPersonID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ContractorContactPersonID = ContractorContactPersonID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorContactPersonEntity.FLD_NAME_ContractorContactPersonID, ContractorContactPersonID.ToString(), SQLMatchType.Equal);

                        CMContractorContactPersonEntity cMContractorContactPersonEntity = new CMContractorContactPersonEntity();


                        result = FCCCMContractorContactPerson.GetFacadeCreate().Delete(cMContractorContactPersonEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ContractorContactPersonID = 0;
                            _CMContractorContactPersonEntity = new CMContractorContactPersonEntity();
                            PrepareInitialView();
                            BindCMContractorContactPersonList();

                            MiscUtil.ShowMessage(lblMessage, "Contractor Contact Person has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Contractor Contact Person.", true);
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

        protected void odsCMContractorContactPerson_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorContactPersonEntity.FLD_NAME_ContractorID, this.OverviewContractorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMContractorContactPersonEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ContractorContactPersonID = 0;
            _CMContractorContactPersonEntity = new CMContractorContactPersonEntity();
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
