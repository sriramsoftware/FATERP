// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:00:20




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
    public partial class ACMDBankAccountPaymentApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountPaymentApprovalStatusID
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

        public ACMDBankAccountPaymentApprovalStatusEntity _ACMDBankAccountPaymentApprovalStatusEntity
        {
            get
            {
                ACMDBankAccountPaymentApprovalStatusEntity entity = new ACMDBankAccountPaymentApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDBankAccountPaymentApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDBankAccountPaymentApprovalStatusEntity CurrentACMDBankAccountPaymentApprovalStatusEntity
        {
            get
            {
                if (_BankAccountPaymentApprovalStatusID > 0)
                {
                    if (_ACMDBankAccountPaymentApprovalStatusEntity.BankAccountPaymentApprovalStatusID != _BankAccountPaymentApprovalStatusID)
                    {
                        _ACMDBankAccountPaymentApprovalStatusEntity = FCCACMDBankAccountPaymentApprovalStatus.GetFacadeCreate().GetByID(_BankAccountPaymentApprovalStatusID);
                    }
                }

                return _ACMDBankAccountPaymentApprovalStatusEntity;
            }
            set
            {
                _ACMDBankAccountPaymentApprovalStatusEntity = value;
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
            ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity = CurrentACMDBankAccountPaymentApprovalStatusEntity;


            if (!aCMDBankAccountPaymentApprovalStatusEntity.IsNew)
            {
                txtName.Text = aCMDBankAccountPaymentApprovalStatusEntity.Name.ToString();
                txtDescription.Text = aCMDBankAccountPaymentApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = aCMDBankAccountPaymentApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDBankAccountPaymentApprovalStatusList();
        }

        private void BindACMDBankAccountPaymentApprovalStatusList()
        {
            lvACMDBankAccountPaymentApprovalStatus.DataBind();
        }

        private ACMDBankAccountPaymentApprovalStatusEntity BuildACMDBankAccountPaymentApprovalStatusEntity()
        {
            ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity = CurrentACMDBankAccountPaymentApprovalStatusEntity;

            aCMDBankAccountPaymentApprovalStatusEntity.Name = txtName.Text.Trim();
            aCMDBankAccountPaymentApprovalStatusEntity.Description = txtDescription.Text.Trim();
            aCMDBankAccountPaymentApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDBankAccountPaymentApprovalStatusEntity;
        }

        private void SaveACMDBankAccountPaymentApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity = BuildACMDBankAccountPaymentApprovalStatusEntity();

                    Int64 result = -1;

                    if (aCMDBankAccountPaymentApprovalStatusEntity.IsNew)
                    {
                        result = FCCACMDBankAccountPaymentApprovalStatus.GetFacadeCreate().Add(aCMDBankAccountPaymentApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountPaymentApprovalStatusEntity.FLD_NAME_BankAccountPaymentApprovalStatusID, aCMDBankAccountPaymentApprovalStatusEntity.BankAccountPaymentApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDBankAccountPaymentApprovalStatus.GetFacadeCreate().Update(aCMDBankAccountPaymentApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BankAccountPaymentApprovalStatusID = 0;
                        _ACMDBankAccountPaymentApprovalStatusEntity = new ACMDBankAccountPaymentApprovalStatusEntity();
                        PrepareInitialView();
                        BindACMDBankAccountPaymentApprovalStatusList();

                        if (aCMDBankAccountPaymentApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Payment Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Payment Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDBankAccountPaymentApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CBank Account Payment Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CBank Account Payment Approval Status Information.", false);
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

        protected void lvACMDBankAccountPaymentApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountPaymentApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountPaymentApprovalStatusID);

            if (BankAccountPaymentApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountPaymentApprovalStatusID = BankAccountPaymentApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountPaymentApprovalStatusEntity.FLD_NAME_BankAccountPaymentApprovalStatusID, BankAccountPaymentApprovalStatusID.ToString(), SQLMatchType.Equal);

                        ACMDBankAccountPaymentApprovalStatusEntity aCMDBankAccountPaymentApprovalStatusEntity = new ACMDBankAccountPaymentApprovalStatusEntity();


                        result = FCCACMDBankAccountPaymentApprovalStatus.GetFacadeCreate().Delete(aCMDBankAccountPaymentApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BankAccountPaymentApprovalStatusID = 0;
                            _ACMDBankAccountPaymentApprovalStatusEntity = new ACMDBankAccountPaymentApprovalStatusEntity();
                            PrepareInitialView();
                            BindACMDBankAccountPaymentApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Payment Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CBank Account Payment Approval Status.", true);
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

        protected void odsACMDBankAccountPaymentApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDBankAccountPaymentApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountPaymentApprovalStatusID = 0;
            _ACMDBankAccountPaymentApprovalStatusEntity = new ACMDBankAccountPaymentApprovalStatusEntity();
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
