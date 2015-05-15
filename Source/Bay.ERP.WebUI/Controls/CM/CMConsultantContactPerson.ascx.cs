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
    public partial class CMConsultantContactPersonControl : ConsultantBaseControl
    {       
        #region Properties

        public Int64 _ConsultantContactPersonID
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

        public CMConsultantContactPersonEntity _CMConsultantContactPersonEntity
        {
            get
            {
                CMConsultantContactPersonEntity entity = new CMConsultantContactPersonEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMConsultantContactPersonEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMConsultantContactPersonEntity CurrentCMConsultantContactPersonEntity
        {
            get
            {
                if (_ConsultantContactPersonID > 0)
                {
                    if (_CMConsultantContactPersonEntity.ConsultantContactPersonID != _ConsultantContactPersonID)
                    {
                        _CMConsultantContactPersonEntity = FCCCMConsultantContactPerson.GetFacadeCreate().GetByID(_ConsultantContactPersonID);
                    }
                }

                return _CMConsultantContactPersonEntity;
            }
            set
            {
                _CMConsultantContactPersonEntity = value;
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
            txtAddressLine1.Text = String.Empty;
            txtAddressLine2.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtContactNo.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMConsultantContactPersonEntity cMConsultantContactPersonEntity = CurrentCMConsultantContactPersonEntity;


            if (!cMConsultantContactPersonEntity.IsNew)
            {
                

                txtName.Text = cMConsultantContactPersonEntity.Name.ToString();
                txtDesignation.Text = cMConsultantContactPersonEntity.Designation.ToString();
                txtAddressLine1.Text = cMConsultantContactPersonEntity.AddressLine1.ToString();
                txtAddressLine2.Text = cMConsultantContactPersonEntity.AddressLine2.ToString();
                txtPhone.Text = cMConsultantContactPersonEntity.Phone.ToString();
                txtContactNo.Text = cMConsultantContactPersonEntity.ContactNo.ToString();
                txtEmail.Text = cMConsultantContactPersonEntity.Email.ToString();
                txtRemarks.Text = cMConsultantContactPersonEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMConsultantContactPersonList();
        }

        private void BindCMConsultantContactPersonList()
        {
            lvCMConsultantContactPerson.DataBind();
        }

        private CMConsultantContactPersonEntity BuildCMConsultantContactPersonEntity()
        {
            CMConsultantContactPersonEntity cMConsultantContactPersonEntity = CurrentCMConsultantContactPersonEntity;

            cMConsultantContactPersonEntity.ConsultantID = this.OverviewConsultantID;
            cMConsultantContactPersonEntity.Name = txtName.Text.Trim();
            cMConsultantContactPersonEntity.Designation = txtDesignation.Text.Trim();
            cMConsultantContactPersonEntity.AddressLine1 = txtAddressLine1.Text.Trim();
            cMConsultantContactPersonEntity.AddressLine2 = txtAddressLine2.Text.Trim();
            cMConsultantContactPersonEntity.Phone = txtPhone.Text.Trim();
            cMConsultantContactPersonEntity.ContactNo = txtContactNo.Text.Trim();
            cMConsultantContactPersonEntity.Email = txtEmail.Text.Trim();
            cMConsultantContactPersonEntity.Remarks = txtRemarks.Text.Trim();

            return cMConsultantContactPersonEntity;
        }

        private void SaveCMConsultantContactPersonEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMConsultantContactPersonEntity cMConsultantContactPersonEntity = BuildCMConsultantContactPersonEntity();

                    Int64 result = -1;

                    if (cMConsultantContactPersonEntity.IsNew)
                    {
                        result = FCCCMConsultantContactPerson.GetFacadeCreate().Add(cMConsultantContactPersonEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantContactPersonEntity.FLD_NAME_ConsultantContactPersonID, cMConsultantContactPersonEntity.ConsultantContactPersonID.ToString(), SQLMatchType.Equal);
                        result = FCCCMConsultantContactPerson.GetFacadeCreate().Update(cMConsultantContactPersonEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConsultantContactPersonID = 0;
                        _CMConsultantContactPersonEntity = new CMConsultantContactPersonEntity();
                        PrepareInitialView();
                        BindCMConsultantContactPersonList();

                        if (cMConsultantContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Consultant Contact Person Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Consultant Contact Person Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMConsultantContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Consultant Contact Person Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Consultant Contact Person Information.", false);
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

        protected void lvCMConsultantContactPerson_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConsultantContactPersonID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConsultantContactPersonID);

            if (ConsultantContactPersonID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConsultantContactPersonID = ConsultantContactPersonID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantContactPersonEntity.FLD_NAME_ConsultantContactPersonID, ConsultantContactPersonID.ToString(), SQLMatchType.Equal);

                        CMConsultantContactPersonEntity cMConsultantContactPersonEntity = new CMConsultantContactPersonEntity();


                        result = FCCCMConsultantContactPerson.GetFacadeCreate().Delete(cMConsultantContactPersonEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ConsultantContactPersonID = 0;
                            _CMConsultantContactPersonEntity = new CMConsultantContactPersonEntity();
                            PrepareInitialView();
                            BindCMConsultantContactPersonList();

                            MiscUtil.ShowMessage(lblMessage, "Consultant Contact Person has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Consultant Contact Person.", true);
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

        protected void odsCMConsultantContactPerson_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantContactPersonEntity.FLD_NAME_ConsultantID, this.OverviewConsultantID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMConsultantContactPersonEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConsultantContactPersonID = 0;
            _CMConsultantContactPersonEntity = new CMConsultantContactPersonEntity();
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
