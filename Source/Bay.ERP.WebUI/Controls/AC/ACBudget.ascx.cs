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
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ACBudgetControl : BaseControl
    {       
        #region Properties

        public Int64 _BudgetID
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

        public ACBudgetEntity _ACBudgetEntity
        {
            get
            {
                ACBudgetEntity entity = new ACBudgetEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBudgetEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBudgetEntity CurrentACBudgetEntity
        {
            get
            {
                if (_BudgetID > 0)
                {
                    if (_ACBudgetEntity.BudgetID != _BudgetID)
                    {
                        _ACBudgetEntity = FCCACBudget.GetFacadeCreate().GetByID(_BudgetID);
                    }
                }

                return _ACBudgetEntity;
            }
            set
            {
                _ACBudgetEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACFiscalYear(ddlFiscalYearID, false);
            MiscUtil.PopulateACAccountByAccountGroup(ddlAccountID, false);

            if (ddlAccountID.SelectedValue == "$$OPTGROUP$$OPTGROUP$$" && ddlAccountID.Items.Count > 0)
            {
                ddlAccountID.SelectedValue = "1";
            }
        }

        private void UpdateACBudgetEntity()
        {
            try
            {
                IList<ListViewDataItem> list = lvACBudget.Items;

                if (list != null && list.Count > 0)
                {
                    Int32 tempDataItemIndex = 0;

                    foreach (ListViewDataItem lvdi in list)
                    {
                        DataKey currentDataKey = lvACBudget.DataKeys[tempDataItemIndex++];
                        Int64 _budgetID = (Int64)currentDataKey["BudgetID"];
                        _BudgetID = _budgetID;

                        TextBox txtAmountLV = (TextBox)lvdi.FindControl("txtAmountLV");

                        ACBudgetEntity acBudgetEntity = CurrentACBudgetEntity;

                        Decimal budgetamount;
                        Decimal.TryParse(txtAmountLV.Text,out budgetamount);

                        acBudgetEntity.Amount = budgetamount;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBudgetEntity.FLD_NAME_BudgetID, _budgetID.ToString(), SQLMatchType.Equal);
                        FCCACBudget.GetFacadeCreate().Update(acBudgetEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    MiscUtil.ShowMessage(lblMessage, "Budget Information has been added successfully.", false);
                    BuildBudgetLabel();
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Save Budget Information.", false);
            }
        }

        private void BuildBudgetLabel()
        {
            if (ddlFiscalYearID != null && ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlAccountID != null && ddlAccountID.Items.Count > 0)
                {
                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(ACBudgetEntity.FLD_NAME_FiscalYearID, ddlFiscalYearID.SelectedValue.ToString(), SQLMatchType.Equal);
                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(ACBudgetEntity.FLD_NAME_AccountID, ddlAccountID.SelectedValue.ToString(), SQLMatchType.Equal);

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                    IList<ACBudgetEntity> lst = FCCACBudget.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (lst != null && lst.Count > 0)
                    {
                        var sum = (from g in lst
                                   select g.Amount).Sum();

                        lblTopTotalBudgetValue.Text = sum.ToString();
                    }
                    else
                    {
                        lblTopTotalBudgetValue.Text = "0";
                    }
                }
            }
        }

        private void BuildBudgetWizard()
        {
            if (ddlFiscalYearID != null && ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlAccountID!= null && ddlAccountID.Items.Count > 0 && ddlAccountID.SelectedValue!="$$OPTGROUP$$OPTGROUP$$")
                {
                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(ACBudgetEntity.FLD_NAME_FiscalYearID, ddlFiscalYearID.SelectedValue.ToString(), SQLMatchType.Equal);
                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression(ACBudgetEntity.FLD_NAME_AccountID, ddlAccountID.SelectedValue.ToString(), SQLMatchType.Equal);

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                    IList<ACBudgetEntity> lst = FCCACBudget.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (lst != null && lst.Count > 0)
                    {
                        BindList();
                    }
                    else
                    {
                        ACFiscalYearEntity aCFisalYearEntitiy = FCCACFiscalYear.GetFacadeCreate().GetByID(Int64.Parse(ddlFiscalYearID.SelectedValue));

                        if (aCFisalYearEntitiy != null && aCFisalYearEntitiy.FiscalYearID > 0)
                        {
                            DateTime beginDate=aCFisalYearEntitiy.BeginDate;

                            while(beginDate <= aCFisalYearEntitiy.EndDate)
                            {
                                try
                                {
                                    ACBudgetEntity aCBudgetEntity = new ACBudgetEntity();
                                    aCBudgetEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                                    aCBudgetEntity.AccountID = Int64.Parse(ddlAccountID.SelectedValue);
                                    aCBudgetEntity.Period = beginDate;
                                    aCBudgetEntity.Amount = 0;

                                    FCCACBudget.GetFacadeCreate().Add(aCBudgetEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                    beginDate = beginDate.AddMonths(1);
                                }
                                    
                                catch (Exception)
                                {
                                    
                                    throw;
                                }
                                
                            }

                            BindList();
                        }
                    }
                    BuildBudgetLabel();
                }
            }

        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            BuildBudgetWizard();

            btnSubmit.Text = "Save";
            btnAddNew.Visible = false;
        }

        private void BindList()
        {
            BindACBudgetList();
        }

        private void BindACBudgetList()
        {
            lvACBudget.DataBind();
        }

        private ACBudgetEntity BuildACBudgetEntity()
        {
            ACBudgetEntity aCBudgetEntity = CurrentACBudgetEntity;

            if (ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlFiscalYearID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBudgetEntity.FiscalYearID = Int64.Parse(ddlFiscalYearID.SelectedValue);
                }
            }

            if (ddlAccountID.Items.Count > 0)
            {
                if (ddlAccountID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBudgetEntity.AccountID = Int64.Parse(ddlAccountID.SelectedValue);
                }
            }

            return aCBudgetEntity;
        }

        private void SaveACBudgetEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACBudgetEntity aCBudgetEntity = BuildACBudgetEntity();

                    Int64 result = -1;

                    if (aCBudgetEntity.IsNew)
                    {
                        result = FCCACBudget.GetFacadeCreate().Add(aCBudgetEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACBudgetEntity.FLD_NAME_BudgetID, aCBudgetEntity.BudgetID.ToString(), SQLMatchType.Equal);
                        result = FCCACBudget.GetFacadeCreate().Update(aCBudgetEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BudgetID = 0;
                        _ACBudgetEntity = new ACBudgetEntity();
                        PrepareInitialView();
                        BindACBudgetList();

                        if (aCBudgetEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Budget Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Budget Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCBudgetEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Budget Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Budget Information.", false);
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
            }
        }

        #endregion

        #region List View Event

        protected void lvACBudget_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BudgetID;

            Int64.TryParse(e.CommandArgument.ToString(), out BudgetID);

            if (BudgetID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BudgetID = BudgetID;

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACBudgetEntity.FLD_NAME_BudgetID, BudgetID.ToString(), SQLMatchType.Equal);

                        ACBudgetEntity aCBudgetEntity = new ACBudgetEntity();


                        result = FCCACBudget.GetFacadeCreate().Delete(aCBudgetEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BudgetID = 0;
                            _ACBudgetEntity = new ACBudgetEntity();
                            PrepareInitialView();
                            BindACBudgetList();

                            MiscUtil.ShowMessage(lblMessage, "A CBudget has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CBudget.", true);
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

        protected void odsACBudget_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (ddlFiscalYearID != null && ddlFiscalYearID.Items.Count > 0)
            {
                if (ddlAccountID != null && ddlAccountID.Items.Count > 0)
                {
                    String fe1 = SqlExpressionBuilder.PrepareFilterExpression("ACBudget." + ACBudgetEntity.FLD_NAME_FiscalYearID, ddlFiscalYearID.SelectedValue.ToString(), SQLMatchType.Equal);
                    String fe2 = SqlExpressionBuilder.PrepareFilterExpression("ACBudget." + ACBudgetEntity.FLD_NAME_AccountID, ddlAccountID.SelectedValue.ToString(), SQLMatchType.Equal);

                    fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                }
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            UpdateACBudgetEntity();
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            BuildBudgetWizard();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            //_BudgetID = 0;
            //_ACBudgetEntity = new ACBudgetEntity();
            //PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
        }

        #endregion

        #endregion Event
    }
}
