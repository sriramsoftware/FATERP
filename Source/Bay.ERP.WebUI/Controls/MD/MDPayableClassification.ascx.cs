// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




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
    public partial class MDPayableClassificationControl : BaseControl
    {       
        #region Properties

        public Int64 _PayableClassificationID
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

        public MDPayableClassificationEntity _MDPayableClassificationEntity
        {
            get
            {
                MDPayableClassificationEntity entity = new MDPayableClassificationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDPayableClassificationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDPayableClassificationEntity CurrentMDPayableClassificationEntity
        {
            get
            {
                if (_PayableClassificationID > 0)
                {
                    if (_MDPayableClassificationEntity.PayableClassificationID != _PayableClassificationID)
                    {
                        _MDPayableClassificationEntity = FCCMDPayableClassification.GetFacadeCreate().GetByID(_PayableClassificationID);
                    }
                }

                return _MDPayableClassificationEntity;
            }
            set
            {
                _MDPayableClassificationEntity = value;
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
            txtNarration.Text = String.Empty;
            txtPaymentMode.Text = String.Empty;
            txtPaymentChennal.Text = String.Empty;
            txtSecurityMoney.Text = String.Empty;
            txtTaxDeduction.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDPayableClassificationEntity mDPayableClassificationEntity = CurrentMDPayableClassificationEntity;


            if (!mDPayableClassificationEntity.IsNew)
            {
                txtName.Text = mDPayableClassificationEntity.Name.ToString();
                txtNarration.Text = mDPayableClassificationEntity.Narration.ToString();
                txtPaymentMode.Text = mDPayableClassificationEntity.PaymentMode.ToString();
                txtPaymentChennal.Text = mDPayableClassificationEntity.PaymentChennal.ToString();
                txtSecurityMoney.Text = mDPayableClassificationEntity.SecurityMoney.ToString();
                txtTaxDeduction.Text = mDPayableClassificationEntity.TaxDeduction.ToString();
                txtRemarks.Text = mDPayableClassificationEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDPayableClassificationEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDPayableClassificationList();
        }

        private void BindMDPayableClassificationList()
        {
            lvMDPayableClassification.DataBind();
        }

        private MDPayableClassificationEntity BuildMDPayableClassificationEntity()
        {
            MDPayableClassificationEntity mDPayableClassificationEntity = CurrentMDPayableClassificationEntity;

            mDPayableClassificationEntity.Name = txtName.Text.Trim();
            mDPayableClassificationEntity.Narration = txtNarration.Text.Trim();
            mDPayableClassificationEntity.PaymentMode = txtPaymentMode.Text.Trim();
            mDPayableClassificationEntity.PaymentChennal = txtPaymentChennal.Text.Trim();
            mDPayableClassificationEntity.SecurityMoney = txtSecurityMoney.Text.Trim();
            mDPayableClassificationEntity.TaxDeduction = txtTaxDeduction.Text.Trim();
            mDPayableClassificationEntity.Remarks = txtRemarks.Text.Trim();
            mDPayableClassificationEntity.IsRemoved = chkIsRemoved.Checked;


            return mDPayableClassificationEntity;
        }

        private void SaveMDPayableClassificationEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDPayableClassificationEntity mDPayableClassificationEntity = BuildMDPayableClassificationEntity();

                    Int64 result = -1;

                    if (mDPayableClassificationEntity.IsNew)
                    {
                        result = FCCMDPayableClassification.GetFacadeCreate().Add(mDPayableClassificationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDPayableClassificationEntity.FLD_NAME_PayableClassificationID, mDPayableClassificationEntity.PayableClassificationID.ToString(), SQLMatchType.Equal);
                        result = FCCMDPayableClassification.GetFacadeCreate().Update(mDPayableClassificationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PayableClassificationID = 0;
                        _MDPayableClassificationEntity = new MDPayableClassificationEntity();
                        PrepareInitialView();
                        BindMDPayableClassificationList();

                        if (mDPayableClassificationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Payable Classification Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Payable Classification Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDPayableClassificationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Payable Classification Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Payable Classification Information.", false);
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

        protected void lvMDPayableClassification_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PayableClassificationID;

            Int64.TryParse(e.CommandArgument.ToString(), out PayableClassificationID);

            if (PayableClassificationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PayableClassificationID = PayableClassificationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDPayableClassificationEntity.FLD_NAME_PayableClassificationID, PayableClassificationID.ToString(), SQLMatchType.Equal);

                        MDPayableClassificationEntity mDPayableClassificationEntity = new MDPayableClassificationEntity();


                        result = FCCMDPayableClassification.GetFacadeCreate().Delete(mDPayableClassificationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PayableClassificationID = 0;
                            _MDPayableClassificationEntity = new MDPayableClassificationEntity();
                            PrepareInitialView();
                            BindMDPayableClassificationList();

                            MiscUtil.ShowMessage(lblMessage, "Payable Classification has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Payable Classification.", true);
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

        protected void odsMDPayableClassification_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDPayableClassificationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PayableClassificationID = 0;
            _MDPayableClassificationEntity = new MDPayableClassificationEntity();
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
