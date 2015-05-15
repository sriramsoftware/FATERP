// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    public partial class HREmployeeAdditionalPaymentInfoControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeAdditonalPaymentInfoID
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

        public HREmployeeAdditionalPaymentInfoEntity _HREmployeeAdditionalPaymentInfoEntity
        {
            get
            {
                HREmployeeAdditionalPaymentInfoEntity entity = new HREmployeeAdditionalPaymentInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeAdditionalPaymentInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeAdditionalPaymentInfoEntity CurrentHREmployeeAdditionalPaymentInfoEntity
        {
            get
            {
                if (_EmployeeAdditonalPaymentInfoID > 0)
                {
                    if (_HREmployeeAdditionalPaymentInfoEntity.EmployeeAdditonalPaymentInfoID != _EmployeeAdditonalPaymentInfoID)
                    {
                        _HREmployeeAdditionalPaymentInfoEntity = FCCHREmployeeAdditionalPaymentInfo.GetFacadeCreate().GetByID(_EmployeeAdditonalPaymentInfoID);
                    }
                }

                return _HREmployeeAdditionalPaymentInfoEntity;
            }
            set
            {
                _HREmployeeAdditionalPaymentInfoEntity = value;
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

            txtPayDate.Text = String.Empty;
            txtPayAmount.Text = String.Empty;
            txtPayCurrency.Text = String.Empty;
            txtNotes.Text = String.Empty;
            chkPayNow.Checked = false;
            txtPayDuringPayrollGenerationEditorID.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity = CurrentHREmployeeAdditionalPaymentInfoEntity;


            if (!hREmployeeAdditionalPaymentInfoEntity.IsNew)
            {
                txtPayDate.Text = hREmployeeAdditionalPaymentInfoEntity.PayDate.ToStringDefault();
                txtPayAmount.Text = hREmployeeAdditionalPaymentInfoEntity.PayAmount.ToString();
                txtPayCurrency.Text = hREmployeeAdditionalPaymentInfoEntity.PayCurrency.ToString();
                txtNotes.Text = hREmployeeAdditionalPaymentInfoEntity.Notes.ToString();
                chkPayNow.Checked = hREmployeeAdditionalPaymentInfoEntity.PayNow;
                txtPayDuringPayrollGenerationEditorID.Text = hREmployeeAdditionalPaymentInfoEntity.PayDuringPayrollGenerationEditorID.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeAdditionalPaymentInfoList();
        }

        private void BindHREmployeeAdditionalPaymentInfoList()
        {
            lvHREmployeeAdditionalPaymentInfo.DataBind();
        }

        private HREmployeeAdditionalPaymentInfoEntity BuildHREmployeeAdditionalPaymentInfoEntity()
        {
            HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity = CurrentHREmployeeAdditionalPaymentInfoEntity;

            if (txtPayDate.Text.Trim().IsNotNullOrEmpty())
            {
                hREmployeeAdditionalPaymentInfoEntity.PayDate = MiscUtil.ParseToDateTime(txtPayDate.Text);
            }

            if (!txtPayAmount.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeAdditionalPaymentInfoEntity.PayAmount = Decimal.Parse(txtPayAmount.Text.Trim());
            }

            if (!txtPayCurrency.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeAdditionalPaymentInfoEntity.PayCurrency = Decimal.Parse(txtPayCurrency.Text.Trim());
            }

            hREmployeeAdditionalPaymentInfoEntity.Notes = txtNotes.Text.Trim();
            hREmployeeAdditionalPaymentInfoEntity.PayNow = chkPayNow.Checked;

            if (!txtPayDuringPayrollGenerationEditorID.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeAdditionalPaymentInfoEntity.PayDuringPayrollGenerationEditorID = Int64.Parse(txtPayDuringPayrollGenerationEditorID.Text.Trim());
            }


            return hREmployeeAdditionalPaymentInfoEntity;
        }

        private void SaveHREmployeeAdditionalPaymentInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity = BuildHREmployeeAdditionalPaymentInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeAdditionalPaymentInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeAdditionalPaymentInfo.GetFacadeCreate().Add(hREmployeeAdditionalPaymentInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAdditionalPaymentInfoEntity.FLD_NAME_EmployeeAdditonalPaymentInfoID, hREmployeeAdditionalPaymentInfoEntity.EmployeeAdditonalPaymentInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeAdditionalPaymentInfo.GetFacadeCreate().Update(hREmployeeAdditionalPaymentInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeAdditonalPaymentInfoID = 0;
                        _HREmployeeAdditionalPaymentInfoEntity = new HREmployeeAdditionalPaymentInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeAdditionalPaymentInfoList();

                        if (hREmployeeAdditionalPaymentInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Additional Payment Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Additional Payment Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeAdditionalPaymentInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Additional Payment Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Additional Payment Info Information.", false);
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

        protected void lvHREmployeeAdditionalPaymentInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeAdditonalPaymentInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeAdditonalPaymentInfoID);

            if (EmployeeAdditonalPaymentInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeAdditonalPaymentInfoID = EmployeeAdditonalPaymentInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeAdditionalPaymentInfoEntity.FLD_NAME_EmployeeAdditonalPaymentInfoID, EmployeeAdditonalPaymentInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity = new HREmployeeAdditionalPaymentInfoEntity();


                        result = FCCHREmployeeAdditionalPaymentInfo.GetFacadeCreate().Delete(hREmployeeAdditionalPaymentInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeAdditonalPaymentInfoID = 0;
                            _HREmployeeAdditionalPaymentInfoEntity = new HREmployeeAdditionalPaymentInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeAdditionalPaymentInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Additional Payment Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Additional Payment Info.", true);
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

        protected void odsHREmployeeAdditionalPaymentInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeAdditionalPaymentInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeAdditonalPaymentInfoID = 0;
            _HREmployeeAdditionalPaymentInfoEntity = new HREmployeeAdditionalPaymentInfoEntity();
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
