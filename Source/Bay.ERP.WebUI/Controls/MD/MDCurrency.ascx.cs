// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    public partial class MDCurrencyControl : BaseControl
    {       
        #region Properties

        public Int64 _CurrencyID
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

        public MDCurrencyEntity _MDCurrencyEntity
        {
            get
            {
                MDCurrencyEntity entity = new MDCurrencyEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDCurrencyEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDCurrencyEntity CurrentMDCurrencyEntity
        {
            get
            {
                if (_CurrencyID > 0)
                {
                    if (_MDCurrencyEntity.CurrencyID != _CurrencyID)
                    {
                        _MDCurrencyEntity = FCCMDCurrency.GetFacadeCreate().GetByID(_CurrencyID);
                    }
                }

                return _MDCurrencyEntity;
            }
            set
            {
                _MDCurrencyEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCountry(ddlCountryID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtAbbreviation.Text = String.Empty;
            txtSymbol.Text = String.Empty;
            txtCurrencyName.Text = String.Empty;
            txtHundredthsName.Text = String.Empty;
            chkIsStandardCurrency.Checked = false;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDCurrencyEntity mDCurrencyEntity = CurrentMDCurrencyEntity;


            if (!mDCurrencyEntity.IsNew)
            {
                txtAbbreviation.Text = mDCurrencyEntity.Abbreviation.ToString();
                txtSymbol.Text = mDCurrencyEntity.Symbol.ToString();
                txtCurrencyName.Text = mDCurrencyEntity.CurrencyName.ToString();
                txtHundredthsName.Text = mDCurrencyEntity.HundredthsName.ToString();
                if (ddlCountryID.Items.Count > 0 && mDCurrencyEntity.CountryID != null)
                {
                    ddlCountryID.SelectedValue = mDCurrencyEntity.CountryID.ToString();
                }

                chkIsStandardCurrency.Checked = mDCurrencyEntity.IsStandardCurrency;
                chkIsRemoved.Checked = mDCurrencyEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDCurrencyList();
        }

        private void BindMDCurrencyList()
        {
            lvMDCurrency.DataBind();
        }

        private MDCurrencyEntity BuildMDCurrencyEntity()
        {
            MDCurrencyEntity mDCurrencyEntity = CurrentMDCurrencyEntity;

            mDCurrencyEntity.Abbreviation = txtAbbreviation.Text.Trim();
            mDCurrencyEntity.Symbol = txtSymbol.Text.Trim();
            mDCurrencyEntity.CurrencyName = txtCurrencyName.Text.Trim();
            mDCurrencyEntity.HundredthsName = txtHundredthsName.Text.Trim();
            if (ddlCountryID.Items.Count > 0)
            {
                if (ddlCountryID.SelectedValue == "0")
                {
                }
                else
                {
                    mDCurrencyEntity.CountryID = Int64.Parse(ddlCountryID.SelectedValue);
                }
            }

            mDCurrencyEntity.IsStandardCurrency = chkIsStandardCurrency.Checked;

            mDCurrencyEntity.IsRemoved = chkIsRemoved.Checked;


            return mDCurrencyEntity;
        }

        private void SaveMDCurrencyEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDCurrencyEntity mDCurrencyEntity = BuildMDCurrencyEntity();

                    Int64 result = -1;

                    if (mDCurrencyEntity.IsNew)
                    {
                        result = FCCMDCurrency.GetFacadeCreate().Add(mDCurrencyEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDCurrencyEntity.FLD_NAME_CurrencyID, mDCurrencyEntity.CurrencyID.ToString(), SQLMatchType.Equal);
                        result = FCCMDCurrency.GetFacadeCreate().Update(mDCurrencyEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CurrencyID = 0;
                        _MDCurrencyEntity = new MDCurrencyEntity();
                        PrepareInitialView();
                        BindMDCurrencyList();

                        if (mDCurrencyEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Currency Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Currency Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDCurrencyEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Currency Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Currency Information.", false);
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

        protected void lvMDCurrency_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CurrencyID;

            Int64.TryParse(e.CommandArgument.ToString(), out CurrencyID);

            if (CurrencyID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CurrencyID = CurrencyID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDCurrencyEntity.FLD_NAME_CurrencyID, CurrencyID.ToString(), SQLMatchType.Equal);

                        MDCurrencyEntity mDCurrencyEntity = new MDCurrencyEntity();


                        result = FCCMDCurrency.GetFacadeCreate().Delete(mDCurrencyEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CurrencyID = 0;
                            _MDCurrencyEntity = new MDCurrencyEntity();
                            PrepareInitialView();
                            BindMDCurrencyList();

                            MiscUtil.ShowMessage(lblMessage, "Currency has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Currency.", true);
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

        protected void odsMDCurrency_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDCurrencyEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CurrencyID = 0;
            _MDCurrencyEntity = new MDCurrencyEntity();
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
