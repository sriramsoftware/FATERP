// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Apr-2013, 12:14:24




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
    public partial class CRMMDPaymentApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _PaymentApprovalStatusID
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

        public CRMMDPaymentApprovalStatusEntity _CRMMDPaymentApprovalStatusEntity
        {
            get
            {
                CRMMDPaymentApprovalStatusEntity entity = new CRMMDPaymentApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDPaymentApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDPaymentApprovalStatusEntity CurrentCRMMDPaymentApprovalStatusEntity
        {
            get
            {
                if (_PaymentApprovalStatusID > 0)
                {
                    if (_CRMMDPaymentApprovalStatusEntity.PaymentApprovalStatusID != _PaymentApprovalStatusID)
                    {
                        _CRMMDPaymentApprovalStatusEntity = FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().GetByID(_PaymentApprovalStatusID);
                    }
                }

                return _CRMMDPaymentApprovalStatusEntity;
            }
            set
            {
                _CRMMDPaymentApprovalStatusEntity = value;
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

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMMDPaymentApprovalStatusEntity cRMMDPaymentApprovalStatusEntity = CurrentCRMMDPaymentApprovalStatusEntity;


            if (!cRMMDPaymentApprovalStatusEntity.IsNew)
            {
                txtName.Text = cRMMDPaymentApprovalStatusEntity.Name.ToString();
                txtDescription.Text = cRMMDPaymentApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDPaymentApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDPaymentApprovalStatusList();
        }

        private void BindCRMMDPaymentApprovalStatusList()
        {
            lvCRMMDPaymentApprovalStatus.DataBind();
        }

        private CRMMDPaymentApprovalStatusEntity BuildCRMMDPaymentApprovalStatusEntity()
        {
            CRMMDPaymentApprovalStatusEntity cRMMDPaymentApprovalStatusEntity = CurrentCRMMDPaymentApprovalStatusEntity;

            cRMMDPaymentApprovalStatusEntity.Name = txtName.Text.Trim();
            cRMMDPaymentApprovalStatusEntity.Description = txtDescription.Text.Trim();
            cRMMDPaymentApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDPaymentApprovalStatusEntity;
        }

        private void SaveCRMMDPaymentApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDPaymentApprovalStatusEntity cRMMDPaymentApprovalStatusEntity = BuildCRMMDPaymentApprovalStatusEntity();

                    Int64 result = -1;

                    if (cRMMDPaymentApprovalStatusEntity.IsNew)
                    {
                        result = FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().Add(cRMMDPaymentApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDPaymentApprovalStatusEntity.FLD_NAME_PaymentApprovalStatusID, cRMMDPaymentApprovalStatusEntity.PaymentApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().Update(cRMMDPaymentApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PaymentApprovalStatusID = 0;
                        _CRMMDPaymentApprovalStatusEntity = new CRMMDPaymentApprovalStatusEntity();
                        PrepareInitialView();
                        BindCRMMDPaymentApprovalStatusList();

                        if (cRMMDPaymentApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDPaymentApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMPayment Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMPayment Approval Status Information.", false);
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

        protected void lvCRMMDPaymentApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PaymentApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out PaymentApprovalStatusID);

            if (PaymentApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PaymentApprovalStatusID = PaymentApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDPaymentApprovalStatusEntity.FLD_NAME_PaymentApprovalStatusID, PaymentApprovalStatusID.ToString(), SQLMatchType.Equal);

                        CRMMDPaymentApprovalStatusEntity cRMMDPaymentApprovalStatusEntity = new CRMMDPaymentApprovalStatusEntity();


                        result = FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().Delete(cRMMDPaymentApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PaymentApprovalStatusID = 0;
                            _CRMMDPaymentApprovalStatusEntity = new CRMMDPaymentApprovalStatusEntity();
                            PrepareInitialView();
                            BindCRMMDPaymentApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMPayment Approval Status.", true);
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

        protected void odsCRMMDPaymentApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDPaymentApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PaymentApprovalStatusID = 0;
            _CRMMDPaymentApprovalStatusEntity = new CRMMDPaymentApprovalStatusEntity();
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
