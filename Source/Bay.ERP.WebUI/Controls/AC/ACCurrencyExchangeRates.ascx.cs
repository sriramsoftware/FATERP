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
    public partial class ACCurrencyExchangeRatesControl : BaseControl
    {       
        #region Properties

        public Int64 _CurrencyExchangeRatesID
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

        public ACCurrencyExchangeRatesEntity _ACCurrencyExchangeRatesEntity
        {
            get
            {
                ACCurrencyExchangeRatesEntity entity = new ACCurrencyExchangeRatesEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACCurrencyExchangeRatesEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACCurrencyExchangeRatesEntity CurrentACCurrencyExchangeRatesEntity
        {
            get
            {
                if (_CurrencyExchangeRatesID > 0)
                {
                    if (_ACCurrencyExchangeRatesEntity.CurrencyExchangeRatesID != _CurrencyExchangeRatesID)
                    {
                        _ACCurrencyExchangeRatesEntity = FCCACCurrencyExchangeRates.GetFacadeCreate().GetByID(_CurrencyExchangeRatesID);
                    }
                }

                return _ACCurrencyExchangeRatesEntity;
            }
            set
            {
                _ACCurrencyExchangeRatesEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCurrency(ddlCurrencyID, false);
            MiscUtil.PopulateMDCurrency(ddlStandardCurrencyID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtExchangeRate.Text = String.Empty;
            txtDateUsedFrom.Text = String.Empty;
            txtDateUsedUpTo.Text = String.Empty;
            chkIsCurrent.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity = CurrentACCurrencyExchangeRatesEntity;


            if (!aCCurrencyExchangeRatesEntity.IsNew)
            {
                if (ddlCurrencyID.Items.Count > 0 && aCCurrencyExchangeRatesEntity.CurrencyID != null)
                {
                    ddlCurrencyID.SelectedValue = aCCurrencyExchangeRatesEntity.CurrencyID.ToString();
                }

                if (ddlStandardCurrencyID.Items.Count > 0 && aCCurrencyExchangeRatesEntity.StandardCurrencyID != null)
                {
                    ddlStandardCurrencyID.SelectedValue = aCCurrencyExchangeRatesEntity.StandardCurrencyID.ToString();
                }

                txtExchangeRate.Text = aCCurrencyExchangeRatesEntity.ExchangeRate.ToString();
                txtDateUsedFrom.Text = aCCurrencyExchangeRatesEntity.DateUsedFrom.ToStringDefault();
                txtDateUsedUpTo.Text = aCCurrencyExchangeRatesEntity.DateUsedUpTo.ToStringDefault();
                chkIsCurrent.Checked = aCCurrencyExchangeRatesEntity.IsCurrent;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACCurrencyExchangeRatesList();
        }

        private void BindACCurrencyExchangeRatesList()
        {
            lvACCurrencyExchangeRates.DataBind();
        }

        private ACCurrencyExchangeRatesEntity BuildACCurrencyExchangeRatesEntity()
        {
            ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity = CurrentACCurrencyExchangeRatesEntity;

            if (ddlCurrencyID.Items.Count > 0)
            {
                if (ddlCurrencyID.SelectedValue == "0")
                {
                }
                else
                {
                    aCCurrencyExchangeRatesEntity.CurrencyID = Int64.Parse(ddlCurrencyID.SelectedValue);
                }
            }

            if (ddlStandardCurrencyID.Items.Count > 0)
            {
                if (ddlStandardCurrencyID.SelectedValue == "0")
                {
                }
                else
                {
                    aCCurrencyExchangeRatesEntity.StandardCurrencyID = Int64.Parse(ddlStandardCurrencyID.SelectedValue);
                }
            }

            if (!txtExchangeRate.Text.Trim().IsNullOrEmpty())
            {
                aCCurrencyExchangeRatesEntity.ExchangeRate = Decimal.Parse(txtExchangeRate.Text.Trim());
            }

            if (txtDateUsedFrom.Text.Trim().IsNotNullOrEmpty())
            {
                aCCurrencyExchangeRatesEntity.DateUsedFrom = MiscUtil.ParseToDateTime(txtDateUsedFrom.Text);
            }

            if (txtDateUsedUpTo.Text.Trim().IsNotNullOrEmpty())
            {
                aCCurrencyExchangeRatesEntity.DateUsedUpTo = MiscUtil.ParseToDateTime(txtDateUsedUpTo.Text);
            }
            else
            {
                aCCurrencyExchangeRatesEntity.DateUsedUpTo = null;
            }

            aCCurrencyExchangeRatesEntity.IsCurrent = chkIsCurrent.Checked;


            return aCCurrencyExchangeRatesEntity;
        }

        private void SaveACCurrencyExchangeRatesEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity = BuildACCurrencyExchangeRatesEntity();

                    Int64 result = -1;

                    if (aCCurrencyExchangeRatesEntity.IsNew)
                    {
                        result = FCCACCurrencyExchangeRates.GetFacadeCreate().Add(aCCurrencyExchangeRatesEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACCurrencyExchangeRatesEntity.FLD_NAME_CurrencyExchangeRatesID, aCCurrencyExchangeRatesEntity.CurrencyExchangeRatesID.ToString(), SQLMatchType.Equal);
                        result = FCCACCurrencyExchangeRates.GetFacadeCreate().Update(aCCurrencyExchangeRatesEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CurrencyExchangeRatesID = 0;
                        _ACCurrencyExchangeRatesEntity = new ACCurrencyExchangeRatesEntity();
                        PrepareInitialView();
                        BindACCurrencyExchangeRatesList();

                        if (aCCurrencyExchangeRatesEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCurrency Exchange Rates Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CCurrency Exchange Rates Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCCurrencyExchangeRatesEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CCurrency Exchange Rates Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CCurrency Exchange Rates Information.", false);
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

        protected void lvACCurrencyExchangeRates_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CurrencyExchangeRatesID;

            Int64.TryParse(e.CommandArgument.ToString(), out CurrencyExchangeRatesID);

            if (CurrencyExchangeRatesID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CurrencyExchangeRatesID = CurrencyExchangeRatesID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACCurrencyExchangeRatesEntity.FLD_NAME_CurrencyExchangeRatesID, CurrencyExchangeRatesID.ToString(), SQLMatchType.Equal);

                        ACCurrencyExchangeRatesEntity aCCurrencyExchangeRatesEntity = new ACCurrencyExchangeRatesEntity();


                        result = FCCACCurrencyExchangeRates.GetFacadeCreate().Delete(aCCurrencyExchangeRatesEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CurrencyExchangeRatesID = 0;
                            _ACCurrencyExchangeRatesEntity = new ACCurrencyExchangeRatesEntity();
                            PrepareInitialView();
                            BindACCurrencyExchangeRatesList();

                            MiscUtil.ShowMessage(lblMessage, "A CCurrency Exchange Rates has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CCurrency Exchange Rates.", true);
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

        protected void odsACCurrencyExchangeRates_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACCurrencyExchangeRatesEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CurrencyExchangeRatesID = 0;
            _ACCurrencyExchangeRatesEntity = new ACCurrencyExchangeRatesEntity();
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
