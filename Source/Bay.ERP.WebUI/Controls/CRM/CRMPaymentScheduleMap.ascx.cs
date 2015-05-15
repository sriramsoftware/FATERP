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
    public partial class CRMPaymentScheduleMapControl : BaseControl
    {       
        #region Properties

        public Int64 _PaymentScheduleMapID
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

        public CRMPaymentScheduleMapEntity _CRMPaymentScheduleMapEntity
        {
            get
            {
                CRMPaymentScheduleMapEntity entity = new CRMPaymentScheduleMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMPaymentScheduleMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMPaymentScheduleMapEntity CurrentCRMPaymentScheduleMapEntity
        {
            get
            {
                if (_PaymentScheduleMapID > 0)
                {
                    if (_CRMPaymentScheduleMapEntity.PaymentScheduleMapID != _PaymentScheduleMapID)
                    {
                        _CRMPaymentScheduleMapEntity = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetByID(_PaymentScheduleMapID);
                    }
                }

                return _CRMPaymentScheduleMapEntity;
            }
            set
            {
                _CRMPaymentScheduleMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMPaymentScheduleMap(ddlLinkPaymentScheduleMapID, true);
            MiscUtil.PopulateCRMPaymentSchedule(ddlPaymentScheduleID, false);
            MiscUtil.PopulateCRMAgreement(ddlAgreementID, false);
            MiscUtil.PopulateHREmployee(ddlLastRevisedByEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlCreateByEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtInstallmentName.Text = String.Empty;
            txtInstallmentDueDate.Text = String.Empty;
            txtInstallmentDueDateNew.Text = String.Empty;
            txtAgreementAAmount.Text = String.Empty;
            txtAgreementBAmount.Text = String.Empty;
            txtAgreementCAmount.Text = String.Empty;
            txtAgreementDAmount.Text = String.Empty;
            txtAgreementEAmount.Text = String.Empty;
            txtPaymentDueDate.Text = String.Empty;
            chkFinalPayment.Checked = false;
            chkRevised.Checked = false;
            txtRevisedIP.Text = String.Empty;
            txtLastRevisedDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtCreateDate.Text = String.Empty;
            txtIP.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = CurrentCRMPaymentScheduleMapEntity;


            if (!cRMPaymentScheduleMapEntity.IsNew)
            {
                if (ddlLinkPaymentScheduleMapID.Items.Count > 0 && cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID != null)
                {
                    ddlLinkPaymentScheduleMapID.SelectedValue = cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID.ToString();
                }

                if (ddlPaymentScheduleID.Items.Count > 0 && cRMPaymentScheduleMapEntity.PaymentScheduleID != null)
                {
                    ddlPaymentScheduleID.SelectedValue = cRMPaymentScheduleMapEntity.PaymentScheduleID.ToString();
                }

                txtInstallmentName.Text = cRMPaymentScheduleMapEntity.InstallmentName.ToString();
                txtInstallmentDueDate.Text = cRMPaymentScheduleMapEntity.InstallmentDueDate.ToStringDefault();
                txtInstallmentDueDateNew.Text = cRMPaymentScheduleMapEntity.InstallmentDueDateNew.ToStringDefault();
                if (ddlAgreementID.Items.Count > 0 && cRMPaymentScheduleMapEntity.AgreementID != null)
                {
                    ddlAgreementID.SelectedValue = cRMPaymentScheduleMapEntity.AgreementID.ToString();
                }

                txtAgreementAAmount.Text = cRMPaymentScheduleMapEntity.AgreementAAmount.ToString();
                txtAgreementBAmount.Text = cRMPaymentScheduleMapEntity.AgreementBAmount.ToString();
                txtAgreementCAmount.Text = cRMPaymentScheduleMapEntity.AgreementCAmount.ToString();
                txtAgreementDAmount.Text = cRMPaymentScheduleMapEntity.AgreementDAmount.ToString();
                txtAgreementEAmount.Text = cRMPaymentScheduleMapEntity.AgreementEAmount.ToString();
                txtPaymentDueDate.Text = cRMPaymentScheduleMapEntity.PaymentDueDate.ToStringDefault();
                chkFinalPayment.Checked = cRMPaymentScheduleMapEntity.FinalPayment;
                chkRevised.Checked = cRMPaymentScheduleMapEntity.Revised;
                txtRevisedIP.Text = cRMPaymentScheduleMapEntity.RevisedIP.ToString();
                if (ddlLastRevisedByEmployeeID.Items.Count > 0 && cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID != null)
                {
                    ddlLastRevisedByEmployeeID.SelectedValue = cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID.ToString();
                }

                txtLastRevisedDate.Text = cRMPaymentScheduleMapEntity.LastRevisedDate.ToStringDefault();
                txtRemarks.Text = cRMPaymentScheduleMapEntity.Remarks.ToString();
                txtCreateDate.Text = cRMPaymentScheduleMapEntity.CreateDate.ToStringDefault();
                if (ddlCreateByEmployeeID.Items.Count > 0 && cRMPaymentScheduleMapEntity.CreateByEmployeeID != null)
                {
                    ddlCreateByEmployeeID.SelectedValue = cRMPaymentScheduleMapEntity.CreateByEmployeeID.ToString();
                }

                txtIP.Text = cRMPaymentScheduleMapEntity.IP.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMPaymentScheduleMapList();
        }

        private void BindCRMPaymentScheduleMapList()
        {
            lvCRMPaymentScheduleMap.DataBind();
        }

        private CRMPaymentScheduleMapEntity BuildCRMPaymentScheduleMapEntity()
        {
            CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = CurrentCRMPaymentScheduleMapEntity;

            if (ddlLinkPaymentScheduleMapID.Items.Count > 0)
            {
                if (ddlLinkPaymentScheduleMapID.SelectedValue == "0")
                {
                    cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID = null;
                }
                else
                {
                    cRMPaymentScheduleMapEntity.LinkPaymentScheduleMapID = Int64.Parse(ddlLinkPaymentScheduleMapID.SelectedValue);
                }
            }

            if (ddlPaymentScheduleID.Items.Count > 0)
            {
                if (ddlPaymentScheduleID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMPaymentScheduleMapEntity.PaymentScheduleID = Int64.Parse(ddlPaymentScheduleID.SelectedValue);
                }
            }

            cRMPaymentScheduleMapEntity.InstallmentName = txtInstallmentName.Text.Trim();
            if (txtInstallmentDueDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.InstallmentDueDate = MiscUtil.ParseToDateTime(txtInstallmentDueDate.Text);
            }

            if (txtInstallmentDueDateNew.Text.Trim().IsNotNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.InstallmentDueDateNew = MiscUtil.ParseToDateTime(txtInstallmentDueDateNew.Text);
            }
            else
            {
                cRMPaymentScheduleMapEntity.InstallmentDueDateNew = null;
            }

            if (ddlAgreementID.Items.Count > 0)
            {
                if (ddlAgreementID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMPaymentScheduleMapEntity.AgreementID = Int64.Parse(ddlAgreementID.SelectedValue);
                }
            }

            if (!txtAgreementAAmount.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.AgreementAAmount = Decimal.Parse(txtAgreementAAmount.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleMapEntity.AgreementAAmount = null;
            }

            if (!txtAgreementBAmount.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.AgreementBAmount = Decimal.Parse(txtAgreementBAmount.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleMapEntity.AgreementBAmount = null;
            }

            if (!txtAgreementCAmount.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.AgreementCAmount = Decimal.Parse(txtAgreementCAmount.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleMapEntity.AgreementCAmount = null;
            }

            if (!txtAgreementDAmount.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.AgreementDAmount = Decimal.Parse(txtAgreementDAmount.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleMapEntity.AgreementDAmount = null;
            }

            if (!txtAgreementEAmount.Text.Trim().IsNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.AgreementEAmount = Decimal.Parse(txtAgreementEAmount.Text.Trim());
            }
            else
            {
                cRMPaymentScheduleMapEntity.AgreementEAmount = null;
            }

            if (txtPaymentDueDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.PaymentDueDate = MiscUtil.ParseToDateTime(txtPaymentDueDate.Text);
            }
            else
            {
                cRMPaymentScheduleMapEntity.PaymentDueDate = null;
            }

            cRMPaymentScheduleMapEntity.FinalPayment = chkFinalPayment.Checked;

            cRMPaymentScheduleMapEntity.Revised = chkRevised.Checked;

            cRMPaymentScheduleMapEntity.RevisedIP = txtRevisedIP.Text.Trim();
            if (ddlLastRevisedByEmployeeID.Items.Count > 0)
            {
                if (ddlLastRevisedByEmployeeID.SelectedValue == "0")
                {
                    cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID = null;
                }
                else
                {
                    cRMPaymentScheduleMapEntity.LastRevisedByEmployeeID = Int64.Parse(ddlLastRevisedByEmployeeID.SelectedValue);
                }
            }

            if (txtLastRevisedDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.LastRevisedDate = MiscUtil.ParseToDateTime(txtLastRevisedDate.Text);
            }

            cRMPaymentScheduleMapEntity.Remarks = txtRemarks.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMPaymentScheduleMapEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            if (ddlCreateByEmployeeID.Items.Count > 0)
            {
                if (ddlCreateByEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMPaymentScheduleMapEntity.CreateByEmployeeID = Int64.Parse(ddlCreateByEmployeeID.SelectedValue);
                }
            }

            cRMPaymentScheduleMapEntity.IP = txtIP.Text.Trim();

            return cRMPaymentScheduleMapEntity;
        }

        private void SaveCRMPaymentScheduleMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = BuildCRMPaymentScheduleMapEntity();

                    Int64 result = -1;

                    if (cRMPaymentScheduleMapEntity.IsNew)
                    {
                        result = FCCCRMPaymentScheduleMap.GetFacadeCreate().Add(cRMPaymentScheduleMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID, cRMPaymentScheduleMapEntity.PaymentScheduleMapID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMPaymentScheduleMap.GetFacadeCreate().Update(cRMPaymentScheduleMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PaymentScheduleMapID = 0;
                        _CRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();
                        PrepareInitialView();
                        BindCRMPaymentScheduleMapList();

                        if (cRMPaymentScheduleMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Schedule Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Schedule Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMPaymentScheduleMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMPayment Schedule Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMPayment Schedule Map Information.", false);
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

        protected void lvCRMPaymentScheduleMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PaymentScheduleMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out PaymentScheduleMapID);

            if (PaymentScheduleMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PaymentScheduleMapID = PaymentScheduleMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleMapEntity.FLD_NAME_PaymentScheduleMapID, PaymentScheduleMapID.ToString(), SQLMatchType.Equal);

                        CRMPaymentScheduleMapEntity cRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();


                        result = FCCCRMPaymentScheduleMap.GetFacadeCreate().Delete(cRMPaymentScheduleMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PaymentScheduleMapID = 0;
                            _CRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();
                            PrepareInitialView();
                            BindCRMPaymentScheduleMapList();

                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Schedule Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMPayment Schedule Map.", true);
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

        protected void odsCRMPaymentScheduleMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMPaymentScheduleMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PaymentScheduleMapID = 0;
            _CRMPaymentScheduleMapEntity = new CRMPaymentScheduleMapEntity();
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
