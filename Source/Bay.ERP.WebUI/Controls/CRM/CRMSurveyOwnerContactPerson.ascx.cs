// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




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
    public partial class CRMSurveyOwnerContactPersonControl : BaseControl
    {       
        #region Properties

        public Int64 _SurveyOwnerContactPersonID
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

        public CRMSurveyOwnerContactPersonEntity _CRMSurveyOwnerContactPersonEntity
        {
            get
            {
                CRMSurveyOwnerContactPersonEntity entity = new CRMSurveyOwnerContactPersonEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMSurveyOwnerContactPersonEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMSurveyOwnerContactPersonEntity CurrentCRMSurveyOwnerContactPersonEntity
        {
            get
            {
                if (_SurveyOwnerContactPersonID > 0)
                {
                    if (_CRMSurveyOwnerContactPersonEntity.SurveyOwnerContactPersonID != _SurveyOwnerContactPersonID)
                    {
                        _CRMSurveyOwnerContactPersonEntity = FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().GetByID(_SurveyOwnerContactPersonID);
                    }
                }

                return _CRMSurveyOwnerContactPersonEntity;
            }
            set
            {
                _CRMSurveyOwnerContactPersonEntity = value;
            }
        }

        public Int64 OverviewSurveyOwnerID
        {
            get
            {
                Int64 overviewSurveyOwnerID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_OWNER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_SURVEY_OWNER_ID], out overviewSurveyOwnerID);
                }

                return overviewSurveyOwnerID;
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
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity = CurrentCRMSurveyOwnerContactPersonEntity;


            if (!cRMSurveyOwnerContactPersonEntity.IsNew)
            {
                txtName.Text = cRMSurveyOwnerContactPersonEntity.Name.ToString();
                txtDesignation.Text = cRMSurveyOwnerContactPersonEntity.Designation.ToString();
                txtPhone.Text = cRMSurveyOwnerContactPersonEntity.Phone.ToString();
                txtMobileNo.Text = cRMSurveyOwnerContactPersonEntity.MobileNo.ToString();
                txtFax.Text = cRMSurveyOwnerContactPersonEntity.Fax.ToString();
                txtEmail.Text = cRMSurveyOwnerContactPersonEntity.Email.ToString();
                txtWebLink.Text = cRMSurveyOwnerContactPersonEntity.WebLink.ToString();
                txtRemarks.Text = cRMSurveyOwnerContactPersonEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMSurveyOwnerContactPersonList();
        }

        private void BindCRMSurveyOwnerContactPersonList()
        {
            lvCRMSurveyOwnerContactPerson.DataBind();
        }

        private CRMSurveyOwnerContactPersonEntity BuildCRMSurveyOwnerContactPersonEntity()
        {
            CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity = CurrentCRMSurveyOwnerContactPersonEntity;

            cRMSurveyOwnerContactPersonEntity.SurveyOwnerID = OverviewSurveyOwnerID;

            cRMSurveyOwnerContactPersonEntity.Name = txtName.Text.Trim();
            cRMSurveyOwnerContactPersonEntity.Designation = txtDesignation.Text.Trim();
            cRMSurveyOwnerContactPersonEntity.Phone = txtPhone.Text.Trim();
            cRMSurveyOwnerContactPersonEntity.MobileNo = txtMobileNo.Text.Trim();
            cRMSurveyOwnerContactPersonEntity.Fax = txtFax.Text.Trim();
            cRMSurveyOwnerContactPersonEntity.Email = txtEmail.Text.Trim();
            cRMSurveyOwnerContactPersonEntity.WebLink = txtWebLink.Text.Trim();
            cRMSurveyOwnerContactPersonEntity.Remarks = txtRemarks.Text.Trim();

            return cRMSurveyOwnerContactPersonEntity;
        }

        private void SaveCRMSurveyOwnerContactPersonEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity = BuildCRMSurveyOwnerContactPersonEntity();

                    Int64 result = -1;

                    if (cRMSurveyOwnerContactPersonEntity.IsNew)
                    {
                        result = FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().Add(cRMSurveyOwnerContactPersonEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyOwnerContactPersonEntity.FLD_NAME_SurveyOwnerContactPersonID, cRMSurveyOwnerContactPersonEntity.SurveyOwnerContactPersonID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().Update(cRMSurveyOwnerContactPersonEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SurveyOwnerContactPersonID = 0;
                        _CRMSurveyOwnerContactPersonEntity = new CRMSurveyOwnerContactPersonEntity();
                        PrepareInitialView();
                        BindCRMSurveyOwnerContactPersonList();

                        if (cRMSurveyOwnerContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Owner Contact Person Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Owner Contact Person Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMSurveyOwnerContactPersonEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Survey Owner Contact Person Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Survey Owner Contact Person Information.", false);
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

        protected void lvCRMSurveyOwnerContactPerson_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SurveyOwnerContactPersonID;

            Int64.TryParse(e.CommandArgument.ToString(), out SurveyOwnerContactPersonID);

            if (SurveyOwnerContactPersonID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SurveyOwnerContactPersonID = SurveyOwnerContactPersonID;

                    PrepareEditView();

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyOwnerContactPersonEntity.FLD_NAME_SurveyOwnerContactPersonID, SurveyOwnerContactPersonID.ToString(), SQLMatchType.Equal);

                        CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity = new CRMSurveyOwnerContactPersonEntity();


                        result = FCCCRMSurveyOwnerContactPerson.GetFacadeCreate().Delete(cRMSurveyOwnerContactPersonEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SurveyOwnerContactPersonID = 0;
                            _CRMSurveyOwnerContactPersonEntity = new CRMSurveyOwnerContactPersonEntity();
                            PrepareInitialView();
                            BindCRMSurveyOwnerContactPersonList();

                            MiscUtil.ShowMessage(lblMessage, "Survey Owner Contact Person has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Survey Owner Contact Person.", true);
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

        protected void odsCRMSurveyOwnerContactPerson_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMSurveyOwnerContactPersonEntity.FLD_NAME_SurveyOwnerID, OverviewSurveyOwnerID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMSurveyOwnerContactPersonEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SurveyOwnerContactPersonID = 0;
            _CRMSurveyOwnerContactPersonEntity = new CRMSurveyOwnerContactPersonEntity();
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
