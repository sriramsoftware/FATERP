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
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class ACJournalControl : BaseControl
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

        public Int64 _journalMasterID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["journalMasterID"] != null)
                {
                    Int64.TryParse(ViewState["journalMasterID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["journalMasterID"] = value;
            }
        }

        public ACTemporaryJournalMasterEntity _ACTemporaryJournalMasterEntity
        {
            get
            {
                ACTemporaryJournalMasterEntity entity = new ACTemporaryJournalMasterEntity();

                if (ViewState["ACTemporaryJournalMasterEntity"] != null)
                {
                    entity = (ACTemporaryJournalMasterEntity)ViewState["ACTemporaryJournalMasterEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["ACTemporaryJournalMasterEntity"] = value;
            }
        }

        private ACTemporaryJournalMasterEntity CurrentACTemporaryJournalMasterEntity
        {
            get
            {
                if (_JournalID > 0)
                {
                    if (_ACTemporaryJournalMasterEntity.TemporaryJournalMasterID != _JournalID)
                    {
                        _ACTemporaryJournalMasterEntity = FCCACTemporaryJournalMaster.GetFacadeCreate().GetByID(_JournalID);
                    }
                }

                return _ACTemporaryJournalMasterEntity;
            }
            set
            {
                _ACTemporaryJournalMasterEntity = value;
            }
        }


        public ACTemporaryJournalEntity _ACJournalEntity
        {
            get
            {
                ACTemporaryJournalEntity entity = new ACTemporaryJournalEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACTemporaryJournalEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACTemporaryJournalEntity CurrentACJournalEntity
        {
            get
            {
                if (_JournalID > 0)
                {
                    if (_ACJournalEntity.TemporaryJournalID!= _JournalID)
                    {
                        _ACJournalEntity = FCCACTemporaryJournal.GetFacadeCreate().GetByID(_JournalID);
                    }
                }

                return _ACJournalEntity;
            }
            set
            {
                _ACJournalEntity = value;
            }
        }

        public IList<ACTemporaryJournal_DetailedEntity> CurrentACJournalList
        {
            get
            {
                return (IList<ACTemporaryJournal_DetailedEntity>)ViewState["vs_CurrentACJournalList"];
            }
            set
            {
                ViewState["vs_CurrentACJournalList"] = value;
            }
        }

        public Int64 _temporaryJournalID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["temporaryJournalID"] != null)
                {
                    Int64.TryParse(ViewState["temporaryJournalID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["temporaryJournalID"] = value;
            }
        }

        public Int64 _temporaryJournalItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["TemporaryJournalItemID"] != null)
                {
                    Int64.TryParse(ViewState["TemporaryJournalItemID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["TemporaryJournalItemID"] = value;
            }
        }

        public ACTemporaryJournal_DetailedEntity _ACTemporaryJournalItemEntity
        {
            get
            {
                ACTemporaryJournal_DetailedEntity entity = new ACTemporaryJournal_DetailedEntity();

                if (ViewState["Current_ACTemporaryJournalItemEntity"] != null)
                {
                    entity = (ACTemporaryJournal_DetailedEntity)ViewState["Current_ACTemporaryJournalItemEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["Current_ACTemporaryJournalItemEntity"] = value;
            }
        }

        private ACTemporaryJournal_DetailedEntity CurrentACTemporaryJournalItemEntity
        {
            get
            {
                if (_temporaryJournalID > 0)
                {
                    //if (_ACBankAccountDepositItemEntity.BankAccountDepositItemID != _BankAccountDepositItemID)
                    //{   
                    _ACTemporaryJournalItemEntity = (from s in CurrentACJournalList
                                                     where s.TemporaryJournalID == _temporaryJournalID
                                                       select s).FirstOrDefault();
                    // }
                }

                return _ACTemporaryJournalItemEntity;
            }
            set
            {
                _ACTemporaryJournalItemEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACMDDebitCredit(ddlMDDebitCreditID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, true);
            MiscUtil.PopulateMDItem(ddlItemID, true);
            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false,MasterDataConstants.APPanelStartWith.ACCOUNTS);
            BuildProjectWiseDropdownInfo();
        }

        private void BuildProjectWiseDropdownInfo()
        {
            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulateREQApprovedRequisitionByProject(ddlRequisitionID, true, Int64.Parse(ddlProjectID.SelectedValue));

                BuildRequisitionWiseInfo();

                BuildWorkorderWiseInfo();

                BuildFloorInfo();

                BuildFloorWiseInfo();
            }
        }

        private void BuildRequisitionWiseInfo()
        {
            if (ddlRequisitionID != null && ddlRequisitionID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMWorkOrderByRequisitonID(ddlWorkOrderID, true, Int64.Parse(ddlRequisitionID.SelectedValue));

                BuildWorkorderWiseInfo();
            }
        }

        private void BuildWorkorderWiseInfo()
        {
            if (ddlWorkOrderID != null && ddlWorkOrderID.Items.Count > 0)
            {
                MiscUtil.PopulateCMBillByWorkOrder(ddlBillID, true, Int64.Parse(ddlWorkOrderID.SelectedValue));
            }
        }

        private void BuildFloorInfo()
        {
            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulateBDProjectFloorByProject(ddlProjectFloorID, true, Int64.Parse(ddlProjectID.SelectedValue));

                BuildFloorWiseInfo();
            }
        }

        private void BuildFloorWiseInfo()
        {
            if (ddlProjectFloorID != null && ddlProjectFloorID.Items.Count > 0)
            {
                MiscUtil.PopulateBDProjectFloorUnitByFloor(ddlProjectFloorUnitID, true, Int64.Parse(ddlProjectFloorID.SelectedValue));
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareEditViewJournal()
        {
            ACTemporaryJournal_DetailedEntity aCTemporaryJournal_DetailedEntity = CurrentACTemporaryJournalItemEntity;

            if (!aCTemporaryJournal_DetailedEntity.IsNew)
            {
                if (aCTemporaryJournal_DetailedEntity.AccountID > 0)
                {
                    txtItemName.Text = aCTemporaryJournal_DetailedEntity.ACAccountAccountName.ToString();
                    hdEmpID.Value = aCTemporaryJournal_DetailedEntity.AccountID.ToString();
                }

                if (ddlItemID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = aCTemporaryJournal_DetailedEntity.ItemID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.ItemID == null)
                {
                    ddlItemID.SelectedValue = "0";
                }

                if (ddlProjectID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = aCTemporaryJournal_DetailedEntity.ProjectID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.ProjectID == null)
                {
                    ddlProjectID.SelectedValue = "0";
                }

                BuildProjectWiseDropdownInfo();

                if (ddlRequisitionID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = aCTemporaryJournal_DetailedEntity.RequisitionID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.RequisitionID == null)
                {
                    ddlRequisitionID.SelectedValue = "0";
                }

                BuildRequisitionWiseInfo();

                if (ddlWorkOrderID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = aCTemporaryJournal_DetailedEntity.WorkOrderID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.WorkOrderID == null)
                {
                    ddlWorkOrderID.SelectedValue = "0";
                }

                BuildWorkorderWiseInfo();

                if (ddlBillID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.BillID != null)
                {
                    ddlBillID.SelectedValue = aCTemporaryJournal_DetailedEntity.BillID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.BillID == null)
                {
                    ddlBillID.SelectedValue = "0";
                }

                if (ddlProjectFloorID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = aCTemporaryJournal_DetailedEntity.ProjectFloorID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.ProjectFloorID == null)
                {
                    ddlProjectFloorID.SelectedValue = "0";
                }

                BuildFloorWiseInfo();

                if (ddlProjectFloorUnitID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = aCTemporaryJournal_DetailedEntity.ProjectFloorUnitID.ToString();
                }
                else if (aCTemporaryJournal_DetailedEntity.ProjectFloorUnitID == null)
                {
                    ddlProjectFloorUnitID.SelectedValue = "0";
                }
               
                if (ddlMDDebitCreditID.Items.Count > 0 && aCTemporaryJournal_DetailedEntity.MDDebitCreditID != null)
                {
                    ddlMDDebitCreditID.SelectedValue = aCTemporaryJournal_DetailedEntity.MDDebitCreditID.ToString();
                }

                txtAmount.Text = aCTemporaryJournal_DetailedEntity.Amount.ToString();
                txtNote.Text = aCTemporaryJournal_DetailedEntity.Note.ToString();
            }
        }

        private Boolean ValidateInputAccounts()
        {
            Boolean validationResult = true;

            if (hdEmpID.Value == "0")
            {
                if (txtItemName.Text.Trim().IsNotNullOrEmpty())
                {
                    MiscUtil.ShowMessage(lblMessage, "Invalid Accounts, Please Enter Correct Account Name.", true);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Please Select Correct Account Name.", true);
                }

                validationResult = false;
            }

            return validationResult;
        }

        private void BuildTotalValueLabel()
        {

            Decimal resultDebit = (from s in CurrentACJournalList
                               where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT
                               select s.Amount).Sum(val => val);

            Decimal resultCredit = (from s in CurrentACJournalList
                                where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT
                                select s.Amount).Sum(val => val);

            lblTotalDebitValue.Text = MiscUtil.NumericCommaSeperatedFormat(resultDebit);
            lblTotalCreditValue.Text = MiscUtil.NumericCommaSeperatedFormat(resultCredit);

            if (resultDebit == 0 && resultCredit == 0)
            {
                dvTotalValue.Visible = false;
            }

            if (resultCredit > 0 || resultDebit > 0)
            {
                dvTotalValue.Visible = true;
            }
        }

        private Boolean ValidateInput()
        {
            Boolean flag=true;

            if (CurrentACJournalList != null && CurrentACJournalList.Count > 0)
            {
                var resultDebit = (from s in CurrentACJournalList
                                   where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT
                                   select s.Amount).Sum(val => val);

                var resultCredit = (from s in CurrentACJournalList
                                   where s.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT
                                   select s.Amount).Sum(val => val);

                if (resultCredit != resultDebit)
                {
                    flag = false;
                    MiscUtil.ShowMessage(lblMessage, "Debit and Credit amount should same.", true);
                }
            }

            if (CurrentACJournalList == null || CurrentACJournalList.Count <= 0)
            {
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Please Enter Debit / Credit Amount", true);
            }

            if (String.IsNullOrWhiteSpace(txtTransactionDateTime.Text))
            {
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Transaction Date Can't be empty", true);
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTransactionDateTime.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtAmount.Text = String.Empty;
            txtReferenceOrMemoOrID.Text = "Auto Assigned";
            txtNote.Text = String.Empty;
            chkIsReverseTransaction.Checked = false;

            pnlAdd.Visible = true;
            pnlUpdate.Visible = false;

            CurrentACJournalList = new List<ACTemporaryJournal_DetailedEntity>();
        }

        private void PrepareEditView()
        {
            ACTemporaryJournalMasterEntity aCJournalEntity = CurrentACTemporaryJournalMasterEntity;


            if (!aCJournalEntity.IsNew)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalMasterID, aCJournalEntity.TemporaryJournalMasterID.ToString(), SQLMatchType.Equal);
                IList<ACTemporaryJournalEntity> lst = FCCACTemporaryJournal.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    txtTransactionDateTime.Text = lst[0].TransactionDateTime.ToStringDefault();
                    txtReferenceOrMemoOrID.Text = lst[0].ReferenceOrMemoOrID.ToString();
                    chkIsReverseTransaction.Checked = lst[0].IsReverseTransaction;
                    txtNote.Text = lst[0].Note.ToString();
                }
            }
        }

        private void SaveTemporaryJournalEntity()
        {
            try
            {
                ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity = CurrentACTemporaryJournalMasterEntity;
                aCTemporaryJournalMasterEntity.CreateDate = System.DateTime.Now;
                aCTemporaryJournalMasterEntity.Remarks = "Tempoary Journal Entry - " + System.DateTime.Now.ToString("dd-MM-yyyy");
                aCTemporaryJournalMasterEntity.TemporyJournalApprovalStatusID = MasterDataConstants.ACMDTemporaryJournalApprovalStatus.INITIATED;

                Int64 result = -1;

                if (aCTemporaryJournalMasterEntity.IsNew)
                {
                    result = FCCACTemporaryJournalMaster.GetFacadeCreate().Add(aCTemporaryJournalMasterEntity, DatabaseOperationType.Add, TransactionRequired.No);
                }
                else
                {
                    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalMasterID, aCTemporaryJournalMasterEntity.TemporaryJournalMasterID.ToString(), SQLMatchType.Equal);
                    result = FCCACTemporaryJournalMaster.GetFacadeCreate().Update(aCTemporaryJournalMasterEntity,filterExpression, DatabaseOperationType.Update,TransactionRequired.No);
                }

                Int64 result_tjournal = -1;

                if (result > 0)
                {
                    if (!aCTemporaryJournalMasterEntity.IsNew)
                    {
                        CurrentACJournalList = new List<ACTemporaryJournal_DetailedEntity>();

                        ACTemporaryJournal_DetailedEntity aCTemporaryJournalEntity = new ACTemporaryJournal_DetailedEntity();

                        IList<ListViewDataItem> listJournal = lvACJournal.Items;

                        if (listJournal != null && listJournal.Count > 0)
                        {
                            String referenceNo = txtReferenceOrMemoOrID.Text.Trim().ToString();

                            String fe_del = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalMasterID, result.ToString(), SQLMatchType.Equal);
                            ACTemporaryJournalEntity acDopsitItem = new ACTemporaryJournalEntity();

                            FCCACTemporaryJournal.GetFacadeCreate().Delete(acDopsitItem, fe_del, DatabaseOperationType.Delete, TransactionRequired.No);

                            foreach (ListViewDataItem lvdi in listJournal)
                            {

                                aCTemporaryJournalEntity = new ACTemporaryJournal_DetailedEntity();

                                Label lblAccountIDLV = (Label)lvdi.FindControl("lblAccountIDLV");
                                Label lblAccountNameLV = (Label)lvdi.FindControl("lblAccountNameLV");
                                Label lblMDDebitCreditIDLV = (Label)lvdi.FindControl("lblMDDebitCreditIDLV");
                                Label lblDebitAmountLV = (Label)lvdi.FindControl("lblDebitAmountLV");
                                Label lblCreditAmountLV = (Label)lvdi.FindControl("lblCreditAmountLV");
                                Label lblNoteLV = (Label)lvdi.FindControl("lblNoteLV");
                                Label lblAccountGroupIDLV = (Label)lvdi.FindControl("lblAccountGroupIDLV");
                                Label lblClassIDLV = (Label)lvdi.FindControl("lblClassIDLV");
                                Label lblClassTypeIDLV = (Label)lvdi.FindControl("lblClassTypeIDLV");
                                Label lblFiscalYearIDLV = (Label)lvdi.FindControl("lblFiscalYearIDLV");
                                Label lblRequisitionIDLV = (Label)lvdi.FindControl("lblRequisitionIDLV");
                                Label lblWorkOrderIDLV = (Label)lvdi.FindControl("lblWorkOrderIDLV");
                                Label lblBillIDLV = (Label)lvdi.FindControl("lblBillIDLV");
                                Label lblProjectFloorUnitIDLV = (Label)lvdi.FindControl("lblProjectFloorUnitIDLV");
                                Label lblProjectFloorIDLV = (Label)lvdi.FindControl("lblProjectFloorIDLV");
                                Label lblProjectIDLV = (Label)lvdi.FindControl("lblProjectIDLV");
                                Label lblItemIDLV = (Label)lvdi.FindControl("lblItemIDLV");

                                Int64 itemID, requisitionID, workOrderID, projectID, projectFloorID, floorUnitID, billID, fiscalyearID, classID, classTypeID, accountgroupID;

                                Int64.TryParse(lblAccountGroupIDLV.Text, out accountgroupID);
                                Int64.TryParse(lblItemIDLV.Text, out itemID);
                                Int64.TryParse(lblRequisitionIDLV.Text, out requisitionID);
                                Int64.TryParse(lblWorkOrderIDLV.Text, out workOrderID);
                                Int64.TryParse(lblProjectIDLV.Text, out projectID);
                                Int64.TryParse(lblProjectFloorIDLV.Text, out projectFloorID);
                                Int64.TryParse(lblProjectFloorUnitIDLV.Text, out floorUnitID);
                                Int64.TryParse(lblBillIDLV.Text, out billID);
                                Int64.TryParse(lblFiscalYearIDLV.Text, out fiscalyearID);
                                Int64.TryParse(lblClassIDLV.Text, out classID);
                                Int64.TryParse(lblClassTypeIDLV.Text, out classTypeID);
                                
                                aCTemporaryJournalEntity.TemporaryJournalID = CurrentACJournalList.Count + 1;
                                aCTemporaryJournalEntity.AccountGroupID = accountgroupID;
                                aCTemporaryJournalEntity.ClassID = classID;
                                aCTemporaryJournalEntity.ClassTypeID = classTypeID;
                                aCTemporaryJournalEntity.FiscalYearID = fiscalyearID;

                                ACTemporaryJournalEntity acTemporaryJournalEntity = new ACTemporaryJournalEntity();

                                if (lblAccountIDLV.Text.Trim().IsNotNullOrEmpty())
                                {
                                    aCTemporaryJournalEntity.AccountID = Int64.Parse(lblAccountIDLV.Text.Trim());
                                    aCTemporaryJournalEntity.ACAccountAccountName = lblAccountNameLV.Text.ToString().Trim();
                                }

                                if (lblMDDebitCreditIDLV.Text.ToString() == MasterDataConstants.MDDebitCredit.DEBIT.ToString())
                                {
                                    if (!lblDebitAmountLV.Text.Trim().IsNullOrEmpty())
                                    {
                                        aCTemporaryJournalEntity.Amount = Decimal.Parse(lblDebitAmountLV.Text.Trim());
                                        acTemporaryJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                                    }
                                }
                                else
                                {
                                    if (!lblCreditAmountLV.Text.Trim().IsNullOrEmpty())
                                    {
                                        aCTemporaryJournalEntity.Amount = Decimal.Parse(lblCreditAmountLV.Text.Trim());
                                        acTemporaryJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.CREDIT;
                                    }
                                }

                                aCTemporaryJournalEntity.Note = lblNoteLV.Text.Trim();

                                #region Update Value

                              
                                acTemporaryJournalEntity.TemporaryJournalMasterID = result;
                                acTemporaryJournalEntity.AccountID = aCTemporaryJournalEntity.AccountID;
                                acTemporaryJournalEntity.AccountGroupID = accountgroupID;
                                acTemporaryJournalEntity.ClassID = classID;
                                acTemporaryJournalEntity.ClassTypeID = classTypeID;
                                acTemporaryJournalEntity.FiscalYearID = fiscalyearID;
                                acTemporaryJournalEntity.Amount = aCTemporaryJournalEntity.Amount;
                                acTemporaryJournalEntity.TransactionDateTime = MiscUtil.ParseToDateTime(txtTransactionDateTime.Text.Trim());
                                acTemporaryJournalEntity.EnteredByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                                acTemporaryJournalEntity.ReferenceOrMemoOrID = referenceNo;
                                if (itemID > 0)
                                {
                                    acTemporaryJournalEntity.ItemID = itemID;
                                    aCTemporaryJournalEntity.ItemID = itemID;
                                }
                                else
                                {
                                    acTemporaryJournalEntity.ItemID = null;
                                    aCTemporaryJournalEntity.ItemID = null;
                                    aCTemporaryJournalEntity.ItemName = String.Empty;
                                }
                                if (requisitionID > 0)
                                {
                                    acTemporaryJournalEntity.RequisitionID = requisitionID;
                                    aCTemporaryJournalEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                                }
                                else
                                {
                                    acTemporaryJournalEntity.RequisitionID = null;
                                    aCTemporaryJournalEntity.RequisitionID = null;
                                    aCTemporaryJournalEntity.RequisitionNo = String.Empty;
                                }

                                if (workOrderID > 0)
                                {
                                    acTemporaryJournalEntity.WorkOrderID = workOrderID;
                                    aCTemporaryJournalEntity.WorkOrderID = workOrderID;
                                }
                                else
                                {
                                    acTemporaryJournalEntity.WorkOrderID = null;
                                    aCTemporaryJournalEntity.WorkOrderID = null;
                                    aCTemporaryJournalEntity.WorkOrderNo = String.Empty;
                                }

                                if (billID > 0)
                                {
                                    acTemporaryJournalEntity.BillID = billID;
                                    aCTemporaryJournalEntity.BillID = billID;
                                }
                                else
                                {
                                    acTemporaryJournalEntity.BillID = null;
                                    aCTemporaryJournalEntity.BillID = null;
                                    aCTemporaryJournalEntity.BillNo = String.Empty;
                                }
                                if (projectID > 0)
                                {
                                    acTemporaryJournalEntity.ProjectID = projectID;
                                    aCTemporaryJournalEntity.ProjectID = projectID;
                                }
                                else
                                {
                                    acTemporaryJournalEntity.ProjectID = null;
                                    aCTemporaryJournalEntity.ProjectID = null;
                                    aCTemporaryJournalEntity.BDProjectProjectName = String.Empty;
                                }
                                if (projectFloorID > 0)
                                {
                                    acTemporaryJournalEntity.ProjectFloorID = projectFloorID;
                                    aCTemporaryJournalEntity.ProjectFloorID = projectFloorID;
                                }
                                else
                                {
                                    acTemporaryJournalEntity.ProjectFloorID = null;
                                    aCTemporaryJournalEntity.ProjectFloorID = null;
                                    aCTemporaryJournalEntity.ProjectFloorName = String.Empty;
                                }
                                if (floorUnitID > 0)
                                {
                                    acTemporaryJournalEntity.ProjectFloorUnitID = floorUnitID;
                                    aCTemporaryJournalEntity.ProjectFloorUnitID = floorUnitID;
                                }
                                else
                                {
                                    acTemporaryJournalEntity.ProjectFloorUnitID = null;
                                    aCTemporaryJournalEntity.ProjectFloorUnitID = null;
                                    aCTemporaryJournalEntity.ProjectFloorUnitName = String.Empty;
                                }

                                if (fiscalyearID > 0)
                                {
                                    acTemporaryJournalEntity.FiscalYearID = fiscalyearID;
                                }
                                
                                acTemporaryJournalEntity.Note =  lblNoteLV.Text.Trim();

                                
                                result_tjournal = FCCACTemporaryJournal.GetFacadeCreate().Add(acTemporaryJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                #endregion
                                aCTemporaryJournalEntity.ReferenceOrMemoOrID = txtReferenceOrMemoOrID.Text.Trim();
                                aCTemporaryJournalEntity.Note = txtNote.Text.Trim();

                                if (txtTransactionDateTime.Text.Trim().IsNotNullOrEmpty())
                                {
                                    aCTemporaryJournalEntity.TransactionDateTime = MiscUtil.ParseToDateTime(txtTransactionDateTime.Text);
                                }
                                
                                aCTemporaryJournalEntity.Amount = acTemporaryJournalEntity.Amount;
                                aCTemporaryJournalEntity.EnteredByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                                aCTemporaryJournalEntity.MDDebitCreditID = Int64.Parse(lblMDDebitCreditIDLV.Text);

                                aCTemporaryJournalEntity.IsReverseTransaction = chkIsReverseTransaction.Checked;

                                aCTemporaryJournalEntity.ReverseTransactionJournalID = null;

                                CurrentACJournalList.Add(aCTemporaryJournalEntity);
                            }

                            BindACJournalList();
                            BuildTotalValueLabel();
                        }
                    }

                    _temporaryJournalID = result;


                    if (aCTemporaryJournalMasterEntity.IsNew)
                    {

                        if (CurrentACJournalList != null && CurrentACJournalList.Count > 0)
                        {
                            foreach (ACTemporaryJournal_DetailedEntity ent in CurrentACJournalList)
                            {
                                ACTemporaryJournalEntity acJournalEntity = new ACTemporaryJournalEntity();
                                acJournalEntity.TemporaryJournalMasterID = result;
                                acJournalEntity.AccountID = ent.AccountID;
                                acJournalEntity.AccountGroupID = ent.AccountGroupID;
                                acJournalEntity.ClassID = ent.ClassID;
                                acJournalEntity.ClassTypeID = ent.ClassTypeID;
                                acJournalEntity.FiscalYearID = ent.FiscalYearID;
                                acJournalEntity.TransactionDateTime = ent.TransactionDateTime;
                                acJournalEntity.Amount = ent.Amount;
                                acJournalEntity.EnteredByEmployeeID = ent.EnteredByEmployeeID;
                                acJournalEntity.ReferenceOrMemoOrID = ent.ReferenceOrMemoOrID;
                                acJournalEntity.ItemID = ent.ItemID;
                                acJournalEntity.RequisitionID = ent.RequisitionID;
                                acJournalEntity.WorkOrderID = ent.WorkOrderID;
                                acJournalEntity.BillID = ent.BillID;
                                acJournalEntity.ProjectID = ent.ProjectID;
                                acJournalEntity.ProjectFloorID = ent.ProjectFloorID;
                                acJournalEntity.ProjectFloorUnitID = ent.ProjectFloorUnitID;
                                acJournalEntity.Note = txtNote.Text.Trim();
                                if (chkIsReverseTransaction.Checked)
                                {
                                    if (ent.MDDebitCreditID == MasterDataConstants.MDDebitCredit.DEBIT)
                                    {
                                        acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.CREDIT;
                                    }
                                    else if (ent.MDDebitCreditID == MasterDataConstants.MDDebitCredit.CREDIT)
                                    {
                                        acJournalEntity.MDDebitCreditID = MasterDataConstants.MDDebitCredit.DEBIT;
                                    }
                                }
                                else if (chkIsReverseTransaction.Checked == false)
                                {
                                    acJournalEntity.MDDebitCreditID = ent.MDDebitCreditID;
                                }

                                acJournalEntity.DimensionID = ent.DimensionID;
                                acJournalEntity.ProjectID = ent.ProjectID;
                                acJournalEntity.IsReverseTransaction = chkIsReverseTransaction.Checked;

                                FCCACTemporaryJournal.GetFacadeCreate().Add(acJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);
                            }
                        }
                    }

                    hypReportLink.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.MANUAL_JOURNAL_REPORT, UrlConstants.OVERVIEW_TEMPORARY_JOURNAL_MASTER_ID, result.ToString()).ToString();
                    hypReportLink.Target = "_blank";
                    hypReportLink.Visible = true;


                    String str = (String)ViewState["Action"].ToString();

                    if (str == "GenerateReport")
                    {
                        _JournalID = result;
                        _journalMasterID = result;
                        PrepareEditView();
                    }

                    else if (str == "Approval")
                    {
                        _JournalID = 0;
                        _journalMasterID = result;
                        PrepareInitialView();
                        CurrentACJournalList = new List<ACTemporaryJournal_DetailedEntity>();
                        //Bind List here.
                        BindACJournalList();
                        BuildTotalValueLabel();
                    }

                    if (aCTemporaryJournalMasterEntity.IsNew)
                    {
                        MiscUtil.ShowMessage(lblMessage, "Journal Information has been added successfully.", false);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Bank Account Deposit Information has been updated successfully.", false);
                    }
                }
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to add Journal Information." + ex.Message, false);
            }
         
        }

        private void BindList()
        {
            BindACJournalList();
        }

        private void BindACJournalList()
        {
            lvACJournal.DataSource = CurrentACJournalList;
            lvACJournal.DataBind();
        }

        private ACTemporaryJournalEntity BuildACJournalEntity()
        {
            ACTemporaryJournalEntity aCJournalEntity = CurrentACJournalEntity;

            return aCJournalEntity;
        }

        private void AddItemToListView()
        {
            try
            {
                ACTemporaryJournal_DetailedEntity aCJournalEntity = new ACTemporaryJournal_DetailedEntity();

                aCJournalEntity.TemporaryJournalID = CurrentACJournalList.Count + 1;

                if (hdEmpID.Value != "0")
                {
                    aCJournalEntity.AccountID = Int64.Parse(hdEmpID.Value);
                    aCJournalEntity.ACAccountAccountName = txtItemName.Text.ToString().Trim();

                    ACAccountEntity acAccountEntity = FCCACAccount.GetFacadeCreate().GetByID(aCJournalEntity.AccountID);

                    if (acAccountEntity != null && acAccountEntity.AccountID > 0)
                    {
                        aCJournalEntity.AccountGroupID = acAccountEntity.AccountGroupID;
                        ACAccountGroupEntity acAccountGroup = FCCACAccountGroup.GetFacadeCreate().GetByID(aCJournalEntity.AccountGroupID);

                        if (acAccountGroup != null && acAccountGroup.AccountGroupID > 0)
                        {
                            String fe_accountClass = SqlExpressionBuilder.PrepareFilterExpression(ACClassEntity.FLD_NAME_ClassID, acAccountGroup.ClassID.ToString(), SQLMatchType.Equal);
                            IList<ACClassEntity> lstacAccountClass = FCCACClass.GetFacadeCreate().GetIL(null, null, String.Empty, fe_accountClass, DatabaseOperationType.LoadWithFilterExpression);

                            if (lstacAccountClass != null && lstacAccountClass.Count > 0)
                            {
                                aCJournalEntity.ClassID = lstacAccountClass[0].ClassID;
                                aCJournalEntity.ClassTypeID = lstacAccountClass[0].ClassTypeID;
                            }

                            String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
                            IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe_fiscalYear, DatabaseOperationType.LoadWithFilterExpression);

                            if (lstFiscalYear != null && lstFiscalYear.Count > 0)
                            {
                                aCJournalEntity.FiscalYearID = lstFiscalYear[0].FiscalYearID;
                            }

                        }
                    }
                }

                if (txtTransactionDateTime.Text.Trim().IsNotNullOrEmpty())
                {
                    aCJournalEntity.TransactionDateTime = MiscUtil.ParseToDateTime(txtTransactionDateTime.Text);
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    aCJournalEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                aCJournalEntity.EnteredByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                aCJournalEntity.ReferenceOrMemoOrID = txtReferenceOrMemoOrID.Text.Trim();
                aCJournalEntity.Note = txtNote.Text.Trim();
                if (ddlMDDebitCreditID.Items.Count > 0)
                {
                    if (ddlMDDebitCreditID.SelectedValue == "0")
                    {
                    }
                    else
                    {
                        aCJournalEntity.MDDebitCreditID = Int64.Parse(ddlMDDebitCreditID.SelectedValue);
                        aCJournalEntity.ACMDDebitCreditName = ddlMDDebitCreditID.SelectedItem.ToString();
                    }
                }

                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        aCJournalEntity.ItemID = null;
                        aCJournalEntity.ItemName = String.Empty;
                    }
                    else
                    {
                        aCJournalEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                        aCJournalEntity.ItemName = ddlItemID.SelectedItem.ToString();
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        aCJournalEntity.RequisitionID = null;
                        aCJournalEntity.RequisitionNo = String.Empty;
                    }
                    else
                    {
                        aCJournalEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                        aCJournalEntity.RequisitionNo = ddlRequisitionID.SelectedItem.ToString();
                    }
                }
                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        aCJournalEntity.WorkOrderID = null;
                        aCJournalEntity.WorkOrderNo = String.Empty;
                    }
                    else
                    {
                        aCJournalEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                        aCJournalEntity.WorkOrderNo = ddlWorkOrderID.SelectedItem.ToString();
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        aCJournalEntity.BillID = null;
                        aCJournalEntity.BillNo = String.Empty;
                    }
                    else
                    {
                        aCJournalEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                        aCJournalEntity.BillNo = ddlBillID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectID = null;
                        aCJournalEntity.BDProjectProjectName= String.Empty;
                    }
                    else
                    {
                        aCJournalEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                        aCJournalEntity.BDProjectProjectName = ddlProjectID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectFloorID = null;
                        aCJournalEntity.ProjectFloorName = String.Empty;
                    }
                    else
                    {
                        aCJournalEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                        aCJournalEntity.ProjectFloorName = ddlProjectFloorID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectFloorUnitID = null;
                        aCJournalEntity.ProjectFloorUnitName = String.Empty;
                    }
                    else
                    {
                        aCJournalEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                        aCJournalEntity.ProjectFloorUnitName = ddlProjectFloorUnitID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCJournalEntity.ProjectID = null;
                    }
                    else
                    {
                        aCJournalEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                        aCJournalEntity.BDProjectProjectName = ddlProjectID.SelectedItem.ToString();
                    }
                }

                aCJournalEntity.IsReverseTransaction = chkIsReverseTransaction.Checked;

                aCJournalEntity.ReverseTransactionJournalID = null;
                CurrentACJournalList.Add(aCJournalEntity);

                BindACJournalList();

                txtAmount.Text = String.Empty;
                txtItemName.Text = String.Empty;
                hdEmpID.Value = "0";
                BuildTotalValueLabel();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void SaveACJournalEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACTemporaryJournalEntity aCJournalEntity = BuildACJournalEntity();

                    Int64 result = -1;

                    if (aCJournalEntity.IsNew)
                    {
                        result = FCCACTemporaryJournal.GetFacadeCreate().Add(aCJournalEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalID, aCJournalEntity.TemporaryJournalID.ToString(), SQLMatchType.Equal);
                        result = FCCACTemporaryJournal.GetFacadeCreate().Update(aCJournalEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _JournalID = 0;
                        _ACJournalEntity = new ACTemporaryJournalEntity();
                        PrepareInitialView();
                        BindACJournalList();

                        if (aCJournalEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Journal Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Journal Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCJournalEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Journal Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Journal Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void EnableDisableApprovalProcessCheck()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.TEMPORARY_JOURNAL, _temporaryJournalID);

            if (aPApprovalProcessEntity.APApprovalProcessID > 0)
            {
                btnInitiateApprovalProcess.Enabled = false;
            }
            else
            {
                btnInitiateApprovalProcess.Enabled = true;
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

        protected void lvACJournal_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                Label lblDebitAmountLV = (Label)e.Item.FindControl("lblDebitAmountLV");
                Label lblCreditAmountLV = (Label)e.Item.FindControl("lblCreditAmountLV");

                switch (Int64.Parse(ddlMDDebitCreditID.SelectedValue))
                {
                    case MasterDataConstants.MDDebitCredit.DEBIT:
                        lblDebitAmountLV.Text = txtAmount.Text.ToString();
                        lblCreditAmountLV.Text = String.Empty;
                        break;
                    case MasterDataConstants.MDDebitCredit.CREDIT:
                        lblCreditAmountLV.Text = txtAmount.Text.ToString();
                        lblDebitAmountLV.Text = String.Empty;
                        break;
                }
             }
        }

        protected void lvACJournal_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 temporaryJournalID;

            Int64.TryParse(e.CommandArgument.ToString(), out temporaryJournalID);

            if (temporaryJournalID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _temporaryJournalID = temporaryJournalID;

                    PrepareEditViewJournal();

                    pnlAdd.Visible = false;
                    pnlUpdate.Visible = true;

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {

                        ACTemporaryJournal_DetailedEntity temporaryItemEntity = (from s in CurrentACJournalList
                                                                                 where s.TemporaryJournalID == temporaryJournalID
                                                                                     select s).FirstOrDefault();

                        CurrentACJournalList.Remove(temporaryItemEntity);

                        BindACJournalList();
                        MiscUtil.ShowMessage(lblMessage, "Journal has been successfully deleted.", true);
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

        protected void odsACJournal_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSaveAndGenerateReport_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ViewState["Action"] = "GenerateReport";

                #region Save Initailly

                SaveTemporaryJournalEntity();

                #endregion
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveTemporaryJournalEntity();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputAccounts())
            {

                try
                {

                    ACTemporaryJournal_DetailedEntity cust = (from c in CurrentACJournalList
                                                              where c.TemporaryJournalID == CurrentACTemporaryJournalItemEntity.TemporaryJournalID
                                                              select c).SingleOrDefault();

                    CurrentACJournalList.Remove(cust);

                    ACTemporaryJournal_DetailedEntity aCJournalEntity = cust;// new ACTemporaryJournal_DetailedEntity();

                    if (hdEmpID.Value != "0")
                    {
                        aCJournalEntity.AccountID = Int64.Parse(hdEmpID.Value);
                        aCJournalEntity.ACAccountAccountName = txtItemName.Text.ToString().Trim();
                        ACAccountEntity acAccountEntity = FCCACAccount.GetFacadeCreate().GetByID(aCJournalEntity.AccountID);

                        if (acAccountEntity != null && acAccountEntity.AccountID > 0)
                        {
                            aCJournalEntity.AccountGroupID = acAccountEntity.AccountGroupID;
                            ACAccountGroupEntity acAccountGroup = FCCACAccountGroup.GetFacadeCreate().GetByID(aCJournalEntity.AccountGroupID);

                            if (acAccountGroup != null && acAccountGroup.AccountGroupID > 0)
                            {
                                String fe_accountClass = SqlExpressionBuilder.PrepareFilterExpression(ACClassEntity.FLD_NAME_ClassID, acAccountGroup.ClassID.ToString(), SQLMatchType.Equal);
                                IList<ACClassEntity> lstacAccountClass = FCCACClass.GetFacadeCreate().GetIL(null, null, String.Empty, fe_accountClass, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstacAccountClass != null && lstacAccountClass.Count > 0)
                                {
                                    aCJournalEntity.ClassID = lstacAccountClass[0].ClassID;
                                    aCJournalEntity.ClassTypeID = lstacAccountClass[0].ClassTypeID;
                                }

                                String fe_fiscalYear = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
                                IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe_fiscalYear, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstFiscalYear != null && lstFiscalYear.Count > 0)
                                {
                                    aCJournalEntity.FiscalYearID = lstFiscalYear[0].FiscalYearID;
                                }

                            }

                        }
                    }

                    if (txtTransactionDateTime.Text.Trim().IsNotNullOrEmpty())
                    {
                        aCJournalEntity.TransactionDateTime = MiscUtil.ParseToDateTime(txtTransactionDateTime.Text);
                    }

                    if (ddlItemID.Items.Count > 0)
                    {
                        if (ddlItemID.SelectedValue == "0")
                        {
                            aCJournalEntity.ItemID = null;
                            aCJournalEntity.ItemName = String.Empty;
                        }
                        else
                        {
                            aCJournalEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                            aCJournalEntity.ItemName = ddlItemID.SelectedItem.ToString();
                        }
                    }

                    if (ddlRequisitionID.Items.Count > 0)
                    {
                        if (ddlRequisitionID.SelectedValue == "0")
                        {
                            aCJournalEntity.RequisitionID = null;
                            aCJournalEntity.RequisitionNo = String.Empty;
                        }
                        else
                        {
                            aCJournalEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                            aCJournalEntity.RequisitionNo = ddlRequisitionID.SelectedItem.ToString();
                        }
                    }


                    if (ddlWorkOrderID.Items.Count > 0)
                    {
                        if (ddlWorkOrderID.SelectedValue == "0")
                        {
                            aCJournalEntity.WorkOrderID = null;
                            aCJournalEntity.WorkOrderNo = String.Empty;
                        }
                        else
                        {
                            aCJournalEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                            aCJournalEntity.WorkOrderNo = ddlWorkOrderID.SelectedItem.ToString();
                        }
                    }

                    if (ddlBillID.Items.Count > 0)
                    {
                        if (ddlBillID.SelectedValue == "0")
                        {
                            aCJournalEntity.BillID = null;
                            aCJournalEntity.BillNo = String.Empty;
                        }
                        else
                        {
                            aCJournalEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                            aCJournalEntity.BillNo = ddlBillID.SelectedItem.ToString();
                        }
                    }

                    if (ddlProjectID.Items.Count > 0)
                    {
                        if (ddlProjectID.SelectedValue == "0")
                        {
                            aCJournalEntity.ProjectID = null;
                            aCJournalEntity.BDProjectProjectName = String.Empty;
                        }
                        else
                        {
                            aCJournalEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                            aCJournalEntity.BDProjectProjectName = ddlProjectID.SelectedItem.ToString();
                        }
                    }

                    if (ddlProjectFloorID.Items.Count > 0)
                    {
                        if (ddlProjectFloorID.SelectedValue == "0")
                        {
                            aCJournalEntity.ProjectFloorID = null;
                            aCJournalEntity.ProjectFloorName = String.Empty;
                        }
                        else
                        {
                            aCJournalEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                            aCJournalEntity.ProjectFloorName = ddlProjectFloorID.SelectedItem.ToString();
                        }
                    }

                    if (ddlProjectFloorUnitID.Items.Count > 0)
                    {
                        if (ddlProjectFloorUnitID.SelectedValue == "0")
                        {
                            aCJournalEntity.ProjectFloorUnitID = null;
                            aCJournalEntity.ProjectFloorUnitName = String.Empty;
                        }
                        else
                        {
                            aCJournalEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                            aCJournalEntity.ProjectFloorUnitName = ddlProjectFloorUnitID.SelectedItem.ToString();
                        }
                    }

                    if (!txtAmount.Text.Trim().IsNullOrEmpty())
                    {
                        aCJournalEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                    }

                    aCJournalEntity.EnteredByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                    aCJournalEntity.ReferenceOrMemoOrID = txtReferenceOrMemoOrID.Text.Trim();
                    aCJournalEntity.Note = txtNote.Text.Trim();
                    if (ddlMDDebitCreditID.Items.Count > 0)
                    {
                        if (ddlMDDebitCreditID.SelectedValue == "0")
                        {
                        }
                        else
                        {
                            aCJournalEntity.MDDebitCreditID = Int64.Parse(ddlMDDebitCreditID.SelectedValue);
                            aCJournalEntity.ACMDDebitCreditName = ddlMDDebitCreditID.SelectedItem.ToString();
                        }
                    }

                    if (ddlProjectID.Items.Count > 0)
                    {
                        if (ddlProjectID.SelectedValue == "0")
                        {
                            aCJournalEntity.ProjectID = null;
                        }
                        else
                        {
                            aCJournalEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                            aCJournalEntity.BDProjectProjectName = ddlProjectID.SelectedItem.ToString();
                        }
                    }

                    aCJournalEntity.IsReverseTransaction = chkIsReverseTransaction.Checked;

                    aCJournalEntity.ReverseTransactionJournalID = null;
                    CurrentACJournalList.Add(aCJournalEntity);

                    BindACJournalList();

                    txtAmount.Text = String.Empty;
                    txtItemName.Text = String.Empty;
                    hdEmpID.Value = "0";

                    pnlAdd.Visible = true;
                    pnlUpdate.Visible = false;
                    BuildTotalValueLabel();
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _JournalID = 0;
            _ACJournalEntity = new ACTemporaryJournalEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInputAccounts())
            {
                AddItemToListView();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            CurrentACTemporaryJournalItemEntity = new ACTemporaryJournal_DetailedEntity();
            txtNote.Text = String.Empty;
            txtAmount.Text = String.Empty;

            pnlUpdate.Visible = false;
            pnlAdd.Visible = true;
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ViewState["Action"] = "Approval";

                #region Save Initailly

                if (_JournalID <= 0)
                {
                    #region Save Initailly

                    SaveTemporaryJournalEntity();

                    #endregion
                }

                #endregion

                #region Approval Process

                Boolean apResult = APRobot.CreateApprovalProcessForNewTemporaryJournal(_temporaryJournalID, Int64.Parse(ddlAPPanelID.SelectedValue));

                if (apResult == true)
                {
                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                    //String NavigationUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionList.aspx", string.Empty).ToString();
                    //Response.Redirect(NavigationUrl);
                    _temporaryJournalID = 0;
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                }

                EnableDisableApprovalProcessCheck();

                #endregion
            }
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildProjectWiseDropdownInfo();
        }

        protected void ddlRequisitionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildRequisitionWiseInfo();
        }

        protected void ddlWorkOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildWorkorderWiseInfo();
        }

        protected void ddlProjectFloorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildFloorWiseInfo();
        }

        #endregion

        #endregion Event

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion
    }
}
