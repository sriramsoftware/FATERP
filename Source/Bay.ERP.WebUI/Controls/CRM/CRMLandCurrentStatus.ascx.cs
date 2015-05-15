// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMLandCurrentStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _LandCurrentStatusID
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

        public CRMLandCurrentStatusEntity _CRMLandCurrentStatusEntity
        {
            get
            {
                CRMLandCurrentStatusEntity entity = new CRMLandCurrentStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMLandCurrentStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMLandCurrentStatusEntity CurrentCRMLandCurrentStatusEntity
        {
            get
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMLandCurrentStatusEntity.FLD_NAME_LandBasicInfoID, CRMLandBasicInfoID.ToString(), SQLMatchType.Equal);
                IList<CRMLandCurrentStatusEntity> lst = FCCCRMLandCurrentStatus.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    _CRMLandCurrentStatusEntity = lst[0];
                }

                return _CRMLandCurrentStatusEntity;
            }
            set
            {
                _CRMLandCurrentStatusEntity = value;
            }
        }

        public Int64 CRMLandBasicInfoID
        {
            get
            {
                Int64 cRMLandBasicInfoID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID], out cRMLandBasicInfoID);
                }

                return cRMLandBasicInfoID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
          
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtOwnership.Text = String.Empty;
            txtMutation.Text = String.Empty;
            txtCurrentUsage.Text = String.Empty;
            txtCommercialPermit.Text = String.Empty;
            txtTenant.Text = String.Empty;
            txtLoanLiability.Text = String.Empty;
            txtNOC.Text = String.Empty;
            txtAgreements.Text = String.Empty;
            txtLitigation.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity = CurrentCRMLandCurrentStatusEntity;


            if (!cRMLandCurrentStatusEntity.IsNew)
            {
                txtOwnership.Text = cRMLandCurrentStatusEntity.Ownership.ToString();
                txtMutation.Text = cRMLandCurrentStatusEntity.Mutation.ToString();
                txtCurrentUsage.Text = cRMLandCurrentStatusEntity.CurrentUsage.ToString();
                txtCommercialPermit.Text = cRMLandCurrentStatusEntity.CommercialPermit.ToString();
                txtTenant.Text = cRMLandCurrentStatusEntity.Tenant.ToString();
                txtLoanLiability.Text = cRMLandCurrentStatusEntity.LoanLiability.ToString();
                txtNOC.Text = cRMLandCurrentStatusEntity.NOC.ToString();
                txtAgreements.Text = cRMLandCurrentStatusEntity.Agreements.ToString();
                txtLitigation.Text = cRMLandCurrentStatusEntity.Litigation.ToString();

                btnSubmit.Text = "Update";
            }
        }

        private void BindList()
        {
            BindCRMLandCurrentStatusList();
        }

        private void BindCRMLandCurrentStatusList()
        {
            
        }

        private CRMLandCurrentStatusEntity BuildCRMLandCurrentStatusEntity()
        {
            CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity = CurrentCRMLandCurrentStatusEntity;

            cRMLandCurrentStatusEntity.LandBasicInfoID = CRMLandBasicInfoID;

            cRMLandCurrentStatusEntity.Ownership = txtOwnership.Text.Trim();
            cRMLandCurrentStatusEntity.Mutation = txtMutation.Text.Trim();
            cRMLandCurrentStatusEntity.CurrentUsage = txtCurrentUsage.Text.Trim();
            cRMLandCurrentStatusEntity.CommercialPermit = txtCommercialPermit.Text.Trim();
            cRMLandCurrentStatusEntity.Tenant = txtTenant.Text.Trim();
            cRMLandCurrentStatusEntity.LoanLiability = txtLoanLiability.Text.Trim();
            cRMLandCurrentStatusEntity.NOC = txtNOC.Text.Trim();
            cRMLandCurrentStatusEntity.Agreements = txtAgreements.Text.Trim();
            cRMLandCurrentStatusEntity.Litigation = txtLitigation.Text.Trim();

            return cRMLandCurrentStatusEntity;
        }

        private void SaveCRMLandCurrentStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMLandCurrentStatusEntity cRMLandCurrentStatusEntity = BuildCRMLandCurrentStatusEntity();

                    Int64 result = -1;

                    if (cRMLandCurrentStatusEntity.IsNew)
                    {
                        result = FCCCRMLandCurrentStatus.GetFacadeCreate().Add(cRMLandCurrentStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        String navUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMLandOwner.aspx", string.Empty, UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID, CRMLandBasicInfoID.ToString()).ToString();
                        Response.Redirect(navUrl);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMLandCurrentStatusEntity.FLD_NAME_LandCurrentStatusID, cRMLandCurrentStatusEntity.LandCurrentStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMLandCurrentStatus.GetFacadeCreate().Update(cRMLandCurrentStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {  
                        _CRMLandCurrentStatusEntity = CurrentCRMLandCurrentStatusEntity;
                        PrepareEditView();
                        BindCRMLandCurrentStatusList();

                        if (cRMLandCurrentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Land Current Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Land Current Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMLandCurrentStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Land Current Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Land Current Status Information.", false);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMLandCurrentStatusEntity();
        }

        protected void btnCommunicate_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMCommunication.aspx", string.Empty, "do", "Land", UrlConstants.OVERVIEW_LAND_BASIC_INFO_ID, CRMLandBasicInfoID.ToString()).ToString();
            Response.Redirect(navUrl);
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _LandCurrentStatusID = 0;
            _CRMLandCurrentStatusEntity = new CRMLandCurrentStatusEntity();
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
