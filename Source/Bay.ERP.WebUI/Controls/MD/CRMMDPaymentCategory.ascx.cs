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
    public partial class CRMMDPaymentCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _PaymentCategoryID
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

        public CRMMDPaymentCategoryEntity _CRMMDPaymentCategoryEntity
        {
            get
            {
                CRMMDPaymentCategoryEntity entity = new CRMMDPaymentCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDPaymentCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDPaymentCategoryEntity CurrentCRMMDPaymentCategoryEntity
        {
            get
            {
                if (_PaymentCategoryID > 0)
                {
                    if (_CRMMDPaymentCategoryEntity.PaymentCategoryID != _PaymentCategoryID)
                    {
                        _CRMMDPaymentCategoryEntity = FCCCRMMDPaymentCategory.GetFacadeCreate().GetByID(_PaymentCategoryID);
                    }
                }

                return _CRMMDPaymentCategoryEntity;
            }
            set
            {
                _CRMMDPaymentCategoryEntity = value;
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
            CRMMDPaymentCategoryEntity cRMMDPaymentCategoryEntity = CurrentCRMMDPaymentCategoryEntity;


            if (!cRMMDPaymentCategoryEntity.IsNew)
            {
                txtName.Text = cRMMDPaymentCategoryEntity.Name.ToString();
                txtDescription.Text = cRMMDPaymentCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDPaymentCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDPaymentCategoryList();
        }

        private void BindCRMMDPaymentCategoryList()
        {
            lvCRMMDPaymentCategory.DataBind();
        }

        private CRMMDPaymentCategoryEntity BuildCRMMDPaymentCategoryEntity()
        {
            CRMMDPaymentCategoryEntity cRMMDPaymentCategoryEntity = CurrentCRMMDPaymentCategoryEntity;

            cRMMDPaymentCategoryEntity.Name = txtName.Text.Trim();
            cRMMDPaymentCategoryEntity.Description = txtDescription.Text.Trim();
            cRMMDPaymentCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDPaymentCategoryEntity;
        }

        private void SaveCRMMDPaymentCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDPaymentCategoryEntity cRMMDPaymentCategoryEntity = BuildCRMMDPaymentCategoryEntity();

                    Int64 result = -1;

                    if (cRMMDPaymentCategoryEntity.IsNew)
                    {
                        result = FCCCRMMDPaymentCategory.GetFacadeCreate().Add(cRMMDPaymentCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDPaymentCategoryEntity.FLD_NAME_PaymentCategoryID, cRMMDPaymentCategoryEntity.PaymentCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDPaymentCategory.GetFacadeCreate().Update(cRMMDPaymentCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PaymentCategoryID = 0;
                        _CRMMDPaymentCategoryEntity = new CRMMDPaymentCategoryEntity();
                        PrepareInitialView();
                        BindCRMMDPaymentCategoryList();

                        if (cRMMDPaymentCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDPaymentCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMPayment Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMPayment Category Information.", false);
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

        protected void lvCRMMDPaymentCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PaymentCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out PaymentCategoryID);

            if (PaymentCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PaymentCategoryID = PaymentCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDPaymentCategoryEntity.FLD_NAME_PaymentCategoryID, PaymentCategoryID.ToString(), SQLMatchType.Equal);

                        CRMMDPaymentCategoryEntity cRMMDPaymentCategoryEntity = new CRMMDPaymentCategoryEntity();


                        result = FCCCRMMDPaymentCategory.GetFacadeCreate().Delete(cRMMDPaymentCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PaymentCategoryID = 0;
                            _CRMMDPaymentCategoryEntity = new CRMMDPaymentCategoryEntity();
                            PrepareInitialView();
                            BindCRMMDPaymentCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMPayment Category.", true);
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

        protected void odsCRMMDPaymentCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDPaymentCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PaymentCategoryID = 0;
            _CRMMDPaymentCategoryEntity = new CRMMDPaymentCategoryEntity();
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
