// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public partial class ACJournalInqueryControl : BaseControl
    {       
        #region Properties

        public Int64 _JournalID
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

        public ACJournalEntity _ACJournalEntity
        {
            get
            {
                ACJournalEntity entity = new ACJournalEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACJournalEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACJournalEntity CurrentACJournalEntity
        {
            get
            {
                if (_JournalID > 0)
                {
                    if (_ACJournalEntity.JournalID != _JournalID)
                    {
                        _ACJournalEntity = FCCACJournal.GetFacadeCreate().GetByID(_JournalID);
                    }
                }

                return _ACJournalEntity;
            }
            set
            {
                _ACJournalEntity = value;
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
         
        }

        private void PrepareEditView()
        {
            ACJournalEntity aCJournalEntity = CurrentACJournalEntity;


            if (!aCJournalEntity.IsNew)
            {
                //if (ddlAccountID.Items.Count > 0 && aCJournalEntity.AccountID != null)
                //{
                //    ddlAccountID.SelectedValue = aCJournalEntity.AccountID.ToString();
                //}

                //if (ddlAccountGroupID.Items.Count > 0 && aCJournalEntity.AccountGroupID != null)
                //{
                //    ddlAccountGroupID.SelectedValue = aCJournalEntity.AccountGroupID.ToString();
                //}

                //if (ddlClassID.Items.Count > 0 && aCJournalEntity.ClassID != null)
                //{
                //    ddlClassID.SelectedValue = aCJournalEntity.ClassID.ToString();
                //}

                //if (ddlClassTypeID.Items.Count > 0 && aCJournalEntity.ClassTypeID != null)
                //{
                //    ddlClassTypeID.SelectedValue = aCJournalEntity.ClassTypeID.ToString();
                //}

                //txtTransactionDateTime.Text = aCJournalEntity.TransactionDateTime.ToStringDefault();
                //txtAmount.Text = aCJournalEntity.Amount.ToString();
                //if (ddlEnteredByEmployeeID.Items.Count > 0 && aCJournalEntity.EnteredByEmployeeID != null)
                //{
                //    ddlEnteredByEmployeeID.SelectedValue = aCJournalEntity.EnteredByEmployeeID.ToString();
                //}

                //txtReferenceOrMemoOrID.Text = aCJournalEntity.ReferenceOrMemoOrID.ToString();
                //txtNote.Text = aCJournalEntity.Note.ToString();
                //if (ddlMDDebitCreditID.Items.Count > 0 && aCJournalEntity.MDDebitCreditID != null)
                //{
                //    ddlMDDebitCreditID.SelectedValue = aCJournalEntity.MDDebitCreditID.ToString();
                //}

                //if (ddlDimensionID.Items.Count > 0 && aCJournalEntity.DimensionID != null)
                //{
                //    ddlDimensionID.SelectedValue = aCJournalEntity.DimensionID.ToString();
                //}

                //if (ddlProjectID.Items.Count > 0 && aCJournalEntity.ProjectID != null)
                //{
                //    ddlProjectID.SelectedValue = aCJournalEntity.ProjectID.ToString();
                //}

                //if (ddlFiscalYearID.Items.Count > 0 && aCJournalEntity.FiscalYearID != null)
                //{
                //    ddlFiscalYearID.SelectedValue = aCJournalEntity.FiscalYearID.ToString();
                //}

                //chkIsReverseTransaction.Checked = aCJournalEntity.IsReverseTransaction;
                //if (ddlReverseTransactionJournalID.Items.Count > 0 && aCJournalEntity.ReverseTransactionJournalID != null)
                //{
                //    ddlReverseTransactionJournalID.SelectedValue = aCJournalEntity.ReverseTransactionJournalID.ToString();
                //}


             
            }
        }

        private void BindList()
        {
            BindACJournalList();
        }

        private void BindACJournalList()
        {   
            lvACJournal.DataBind();
        }

        private ACJournalEntity BuildACJournalEntity()
        {
            ACJournalEntity aCJournalEntity = CurrentACJournalEntity;

            return aCJournalEntity;
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

   

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsACJournal_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (ViewState["SearchString"] != null)
            {
                fe = (String)ViewState["SearchString"];
            }
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String fe = "ACJournal.TransactionDateTime between '" + MiscUtil.ParseToDateTime(txtTransactionDateTime.Text.Trim().ToString()).ToString() + "' AND '" + MiscUtil.ParseToDateTime(txtTransactionToDateTime.Text.Trim().ToString()).ToString() + "'";
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("ACJournal.ReferenceOrMemoOrID", txtReferenceOrMemoOrID.Text.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe1);
            String fe3 = SqlExpressionBuilder.PrepareFilterExpression("ACJournal.Note", txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe4 = SqlExpressionBuilder.PrepareFilterExpression("ACAccount.AccountName", txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
            String fe6 = SqlExpressionBuilder.PrepareFilterExpression("ACAccountGroup.Name", txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe7 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectName", txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe8 = SqlExpressionBuilder.PrepareFilterExpression(fe6, SQLJoinType.OR, fe7);
            String fe9 = SqlExpressionBuilder.PrepareFilterExpression(fe5, SQLJoinType.OR, fe8);
            String fe10 = SqlExpressionBuilder.PrepareFilterExpression("CMBill.BillNo", txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe11 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionNo", txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe12 = SqlExpressionBuilder.PrepareFilterExpression(fe10, SQLJoinType.OR, fe11);
            String fe13 = SqlExpressionBuilder.PrepareFilterExpression(fe9, SQLJoinType.OR, fe12);
            String fullName = "HRMember.FirstName + CASE WHEN HRMember.MiddleName != '' THEN ' ' + HRMember.MiddleName ELSE '' END + CASE WHEN HRMember.MiddleName != NULL THEN ' ' + HRMember.MiddleName ELSE '' END + ' ' + HRMember.LastName";
            String fe14 = SqlExpressionBuilder.PrepareFilterExpression(fullName, txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe15 = SqlExpressionBuilder.PrepareFilterExpression(fe13, SQLJoinType.OR, fe14);
            String fe16 = SqlExpressionBuilder.PrepareFilterExpression("PRMWorkOrder.WorkOrderNo", txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe17 = SqlExpressionBuilder.PrepareFilterExpression("MDItem.ItemName", txtNote.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fe18 = SqlExpressionBuilder.PrepareFilterExpression(fe16, SQLJoinType.OR, fe17);
            String fe19 = SqlExpressionBuilder.PrepareFilterExpression(fe15, SQLJoinType.OR, fe18);
            
            if (txtNote.Text != String.Empty && txtReferenceOrMemoOrID.Text != String.Empty)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe2, SQLJoinType.OR, fe19);
            }

            else if (txtReferenceOrMemoOrID.Text != String.Empty)
            {
                fe = fe2;
            }
            
            else if (txtNote.Text != String.Empty)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe19);
            }

            
            ViewState["SearchString"] = fe;

            BindList();
        }

        #endregion

        #endregion Event
    }
}
