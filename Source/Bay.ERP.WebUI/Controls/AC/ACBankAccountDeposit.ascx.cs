// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
using System.Globalization;

namespace Bay.ERP.Web.UI
{
    public partial class ACBankAccountDepositControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountDepositID
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

        public ACBankAccountDepositEntity _ACBankAccountDepositEntity
        {
            get
            {
                ACBankAccountDepositEntity entity = new ACBankAccountDepositEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACBankAccountDepositEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACBankAccountDepositEntity CurrentACBankAccountDepositEntity
        {
            get
            {
                if (_BankAccountDepositID > 0)
                {
                    if (_ACBankAccountDepositEntity.BankAccountDepositID != _BankAccountDepositID)
                    {
                        _ACBankAccountDepositEntity = FCCACBankAccountDeposit.GetFacadeCreate().GetByID(_BankAccountDepositID);
                    }
                }

                return _ACBankAccountDepositEntity;
            }
            set
            {
                _ACBankAccountDepositEntity = value;
            }
        }

        public IList<ACBankAccountDepositItem_DetailedEntity> CurrentACBankAccountDepositItemList
        {
            get
            {
                return (IList<ACBankAccountDepositItem_DetailedEntity>)ViewState["vs_CurrentACBankAccountDepositItemList"];
            }
            set
            {
                ViewState["vs_CurrentACBankAccountDepositItemList"] = value;
            }
        }

        public Int64 _BankAccountDepositItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["BankAccountDepositItemID"] != null)
                {
                    Int64.TryParse(ViewState["BankAccountDepositItemID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["BankAccountDepositItemID"] = value;
            }
        }

        public ACBankAccountDepositItem_DetailedEntity _ACBankAccountDepositItemEntity
        {
            get
            {
                ACBankAccountDepositItem_DetailedEntity entity = new ACBankAccountDepositItem_DetailedEntity();

                if (ViewState["Current_ACBankAccountDepositItemEntity"] != null)
                {
                    entity = (ACBankAccountDepositItem_DetailedEntity)ViewState["Current_ACBankAccountDepositItemEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["Current_ACBankAccountDepositItemEntity"] = value;
            }
        }

        private ACBankAccountDepositItem_DetailedEntity CurrentACBankAccountDepositItemEntity
        {
            get
            {
                if (_BankAccountDepositItemID > 0)
                {
                    //if (_ACBankAccountDepositItemEntity.BankAccountDepositItemID != _BankAccountDepositItemID)
                    //{   
                        _ACBankAccountDepositItemEntity = (from s in CurrentACBankAccountDepositItemList
                                                           where s.BankAccountDepositItemID == _BankAccountDepositItemID
                                                           select s).FirstOrDefault();
                   // }
                }

                return _ACBankAccountDepositItemEntity;
            }
            set
            {
                _ACBankAccountDepositItemEntity = value;
            }
        }

        public Int64 _bankAccountDepositID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["bankAccountDepositID"] != null)
                {
                    Int64.TryParse(ViewState["bankAccountDepositID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["bankAccountDepositID"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACMDPaidFrom(ddlPaidFromID, false);
            MiscUtil.PopulateACBankAccount(ddlBankAccountID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, true);
            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false, MasterDataConstants.APPanelStartWith.ACCOUNTS);

            BuildReferenceByPaidFrom();
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

        private void BuildDropDownListDepositeItem()
        {  
            //MiscUtil.PopulateACDimension(ddlDimensionID, true);
            MiscUtil.PopulateMDItem(ddlItemID, true);
            MiscUtil.PopulateBDProject(ddlProjectID, true);

            BuildProjectWiseDropdownInfo();
        }

        private void BuildReferenceByPaidFrom()
        {
            if (ddlPaidFromID != null && ddlPaidFromID.Items.Count > 0)
            {
                lblReference.Text = ddlPaidFromID.SelectedItem.ToString()+" :";

                switch (Int64.Parse(ddlPaidFromID.SelectedValue))
                {
                    case MasterDataConstants.ACMDPaidFrom.MISCELLANEOUS:
                        pnlName.Visible = true;
                        pnlReference.Visible = false;
                        ddlReferenceID.Items.Clear();
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CONTRACTOR:
                        MiscUtil.PopulateCMContractor(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CONSULTANT:
                        MiscUtil.PopulateCMConsultant(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.VENDOR:
                        MiscUtil.PopulatePRMSupplier(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                    case MasterDataConstants.ACMDPaidFrom.CUSTOMER:
                        MiscUtil.PopulateCRMCustomer(ddlReferenceID, false);
                        pnlReference.Visible = true;
                        pnlName.Visible = false;
                        break;
                }
            }
        }

        private void PrepareValidator()
        {
        }

        private Boolean ValidationInput()
        {
            Boolean flag=true;

            if (CurrentACBankAccountDepositItemList.Count <= 0)
            {   
                flag = false;
                MiscUtil.ShowMessage(lblMessage, "Please Make at least one Bank Account Deposit Information.", true);
            }

            return flag;
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDepositDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtReference.Text = "Auto Assigned";
            txtName.Text = String.Empty;
            txtMemo.Text = String.Empty;

            pnlAdd.Visible = true;
            pnlUpdate.Visible = false;

            CurrentACBankAccountDepositItemList = new List<ACBankAccountDepositItem_DetailedEntity>();
        }

        private void PrepareEditView()
        {
            ACBankAccountDepositEntity aCBankAccountDepositEntity = CurrentACBankAccountDepositEntity;


            if (!aCBankAccountDepositEntity.IsNew)
            {
                txtDepositDate.Text = aCBankAccountDepositEntity.DepositDate.ToStringDefault();
                if (ddlPaidFromID.Items.Count > 0 && aCBankAccountDepositEntity.PaidFromID != null)
                {
                    ddlPaidFromID.SelectedValue = aCBankAccountDepositEntity.PaidFromID.ToString();
                }

                if (ddlBankAccountID.Items.Count > 0 && aCBankAccountDepositEntity.BankAccountID != null)
                {
                    ddlBankAccountID.SelectedValue = aCBankAccountDepositEntity.BankAccountID.ToString();
                }

                txtReference.Text = aCBankAccountDepositEntity.Reference.ToString();
                txtName.Text = aCBankAccountDepositEntity.Name.ToString();
                txtMemo.Text = aCBankAccountDepositEntity.Memo.ToString();
            }
        }

        private void EnableDisableApprovalProcessCheck()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.BANK_DEPOSIT, _bankAccountDepositID);

            if (aPApprovalProcessEntity.APApprovalProcessID > 0)
            {
                btnInitiateApprovalProcess.Enabled = false;
            }
            else
            {
                btnInitiateApprovalProcess.Enabled = true;
            }
        }

        private void PrepareInitialViewDepositeItem()
        {
            BuildDropDownListDepositeItem();

            txtAmount.Text = String.Empty;
            txtMemoDetail.Text = String.Empty;
        }

        private void PrepareEditViewDepositeItem()
        {
            ACBankAccountDepositItem_DetailedEntity aCBankAccountDepositItemEntity = CurrentACBankAccountDepositItemEntity;

            if (!aCBankAccountDepositItemEntity.IsNew)
            {
                if (aCBankAccountDepositItemEntity.AccountID > 0)
                {
                    txtItemName.Text = aCBankAccountDepositItemEntity.AccountName.ToString();
                    hdEmpID.Value = aCBankAccountDepositItemEntity.AccountID.ToString();
                }

                if (ddlItemID.Items.Count > 0 && aCBankAccountDepositItemEntity.ItemID != null)
                {
                    ddlItemID.SelectedValue = aCBankAccountDepositItemEntity.ItemID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.ItemID == null)
                {
                    ddlItemID.SelectedValue = "0";
                }

                if (ddlProjectID.Items.Count > 0 && aCBankAccountDepositItemEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = aCBankAccountDepositItemEntity.ProjectID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.ProjectID == null)
                {
                    ddlProjectID.SelectedValue = "0";
                }

                BuildProjectWiseDropdownInfo();

                if (ddlRequisitionID.Items.Count > 0 && aCBankAccountDepositItemEntity.RequisitionID != null)
                {
                    ddlRequisitionID.SelectedValue = aCBankAccountDepositItemEntity.RequisitionID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.RequisitionID == null)
                {
                    ddlRequisitionID.SelectedValue = "0";
                }

                BuildRequisitionWiseInfo();

                if (ddlWorkOrderID.Items.Count > 0 && aCBankAccountDepositItemEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = aCBankAccountDepositItemEntity.WorkOrderID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.WorkOrderID == null)
                {
                    ddlWorkOrderID.SelectedValue = "0";
                }

                BuildWorkorderWiseInfo();

                if (ddlBillID.Items.Count > 0 && aCBankAccountDepositItemEntity.BillID != null)
                {
                    ddlBillID.SelectedValue = aCBankAccountDepositItemEntity.BillID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.BillID == null)
                {
                    ddlBillID.SelectedValue = "0";
                }

                if (ddlProjectFloorID.Items.Count > 0 && aCBankAccountDepositItemEntity.ProjectFloorID != null)
                {
                    ddlProjectFloorID.SelectedValue = aCBankAccountDepositItemEntity.ProjectFloorID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.ProjectFloorID == null)
                {
                    ddlProjectFloorID.SelectedValue = "0";
                }

                BuildFloorWiseInfo();

                if (ddlProjectFloorUnitID.Items.Count > 0 && aCBankAccountDepositItemEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = aCBankAccountDepositItemEntity.ProjectFloorUnitID.ToString();
                }
                else if (aCBankAccountDepositItemEntity.ProjectFloorUnitID == null)
                {
                    ddlProjectFloorUnitID.SelectedValue = "0";
                }

                txtAmount.Text = aCBankAccountDepositItemEntity.Amount.ToString();
                txtMemoDetail.Text = aCBankAccountDepositItemEntity.Memo.ToString();
            }
        }

        private void BindList()
        {
            BindACBankAccountDepositList();
        }

        private void BindACBankAccountDepositList()
        {
            
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
            Decimal totalValue = (from s in CurrentACBankAccountDepositItemList
                                  select s.Amount).Sum();

            lblTotalValue.Text = MiscUtil.NumericCommaSeperatedFormat(totalValue);

            if (totalValue == 0)
            {
                dvTotalValue.Visible = false;
            }
            if (totalValue > 0)
            {
                dvTotalValue.Visible = true;
            }
        }

        private void BindACBankAccountDepositItemList()
        {
            lvACBankAccountDepositItem.DataSource = CurrentACBankAccountDepositItemList;
            lvACBankAccountDepositItem.DataBind();
        }

        private ACBankAccountDepositEntity BuildACBankAccountDepositEntity()
        {
            ACBankAccountDepositEntity aCBankAccountDepositEntity = CurrentACBankAccountDepositEntity;

            if (txtDepositDate.Text.Trim().IsNotNullOrEmpty())
            {
                aCBankAccountDepositEntity.DepositDate = MiscUtil.ParseToDateTime(txtDepositDate.Text);
            }

            if (ddlPaidFromID.Items.Count > 0)
            {
                if (ddlPaidFromID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountDepositEntity.PaidFromID = Int64.Parse(ddlPaidFromID.SelectedValue);
                }
            }

            if (ddlReferenceID.Items.Count > 0 && ddlReferenceID.SelectedValue != "0")
            {
                aCBankAccountDepositEntity.ReferenceID = Int64.Parse(ddlReferenceID.SelectedValue);
            }

            else
            {
                aCBankAccountDepositEntity.ReferenceID = null;
            }

            if (ddlBankAccountID.Items.Count > 0)
            {
                if (ddlBankAccountID.SelectedValue == "0")
                {
                }
                else
                {
                    aCBankAccountDepositEntity.BankAccountID = Int64.Parse(ddlBankAccountID.SelectedValue);
                }
            }

            //if (ddlProjectID.Items.Count > 0)
            //{
            //    if (ddlProjectID.SelectedValue == "0")
            //    {
            //    }
            //    else
            //    {
            //        aCBankAccountDepositEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
            //    }
            //}

            aCBankAccountDepositEntity.BankAccountDepositApprovalStatusID = MasterDataConstants.ACMDBankAccountDepositApprovalStatus.INITIATED;
            aCBankAccountDepositEntity.Reference = txtReference.Text.Trim();
            aCBankAccountDepositEntity.Name = txtName.Text.Trim();
            aCBankAccountDepositEntity.Memo = txtMemo.Text.Trim();
            aCBankAccountDepositEntity.PreparedByEmployeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

            return aCBankAccountDepositEntity;
        }

        private void SaveACBankAccountDepositEntity()
        {
           
                if (IsValid)
                {
                    try
                    {
                        ACBankAccountDepositEntity aCBankAccountDepositEntity = BuildACBankAccountDepositEntity();

                        Int64 result = -1;

                        if (aCBankAccountDepositEntity.IsNew)
                        {
                            result = FCCACBankAccountDeposit.GetFacadeCreate().Add(aCBankAccountDepositEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositEntity.FLD_NAME_BankAccountDepositID, aCBankAccountDepositEntity.BankAccountDepositID.ToString(), SQLMatchType.Equal);
                            result = FCCACBankAccountDeposit.GetFacadeCreate().Update(aCBankAccountDepositEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {
                            Int64 resut_two = -1;

                            if (!aCBankAccountDepositEntity.IsNew)
                            {
                                CurrentACBankAccountDepositItemList = new List<ACBankAccountDepositItem_DetailedEntity>();

                                ACBankAccountDepositItem_DetailedEntity aCBankAccountDepositItemEntity = new ACBankAccountDepositItem_DetailedEntity();

                                IList<ListViewDataItem> listBankDeposit = lvACBankAccountDepositItem.Items;

                                if (listBankDeposit != null && listBankDeposit.Count > 0)
                                {

                                    String fe_del = SqlExpressionBuilder.PrepareFilterExpression(ACBankAccountDepositItemEntity.FLD_NAME_BankAccountDepositID, result.ToString(), SQLMatchType.Equal);
                                    ACBankAccountDepositItemEntity acDopsitItem = new ACBankAccountDepositItemEntity();

                                    FCCACBankAccountDepositItem.GetFacadeCreate().Delete(acDopsitItem, fe_del, DatabaseOperationType.Delete, TransactionRequired.No);

                                    foreach (ListViewDataItem lvdi in listBankDeposit)
                                    {

                                        aCBankAccountDepositItemEntity = new ACBankAccountDepositItem_DetailedEntity();

                                        Label lblAccountIDLV = (Label)lvdi.FindControl("lblAccountIDLV");
                                        Label lblAccountNameLV = (Label)lvdi.FindControl("lblAccountNameLV");
                                        Label lblAmountLV = (Label)lvdi.FindControl("lblAmountLV");
                                        Label lblMemoLV = (Label)lvdi.FindControl("lblMemoLV");

                                        aCBankAccountDepositItemEntity.BankAccountDepositItemID = CurrentACBankAccountDepositItemList.Count + 1;

                                        if (lblAccountIDLV.Text.Trim().IsNotNullOrEmpty())
                                        {
                                            aCBankAccountDepositItemEntity.AccountID = Int64.Parse(lblAccountIDLV.Text.Trim());
                                            aCBankAccountDepositItemEntity.AccountName = lblAccountNameLV.Text.ToString().Trim();
                                        }

                                        if (!lblAmountLV.Text.Trim().IsNullOrEmpty())
                                        {
                                            aCBankAccountDepositItemEntity.Amount = Decimal.Parse(lblAmountLV.Text.Trim());
                                        }

                                        aCBankAccountDepositItemEntity.Memo = lblMemoLV.Text.Trim();

                                        #region Update Value

                                        ACBankAccountDepositItemEntity acBankAccountDepositItemEntity = new ACBankAccountDepositItemEntity();
                                        acBankAccountDepositItemEntity.AccountID = aCBankAccountDepositItemEntity.AccountID;
                                        acBankAccountDepositItemEntity.DimensionID = aCBankAccountDepositItemEntity.DimensionID;
                                        acBankAccountDepositItemEntity.Amount = aCBankAccountDepositItemEntity.Amount;
                                        acBankAccountDepositItemEntity.Memo = aCBankAccountDepositItemEntity.Memo;
                                        acBankAccountDepositItemEntity.ItemID = aCBankAccountDepositItemEntity.ItemID;
                                        acBankAccountDepositItemEntity.RequisitionID = aCBankAccountDepositItemEntity.RequisitionID;
                                        acBankAccountDepositItemEntity.WorkOrderID = aCBankAccountDepositItemEntity.WorkOrderID;
                                        acBankAccountDepositItemEntity.BillID = aCBankAccountDepositItemEntity.BillID;
                                        acBankAccountDepositItemEntity.ProjectID = aCBankAccountDepositItemEntity.ProjectID;
                                        acBankAccountDepositItemEntity.ProjectFloorID = aCBankAccountDepositItemEntity.ProjectFloorID;
                                        acBankAccountDepositItemEntity.ProjectFloorUnitID = aCBankAccountDepositItemEntity.ProjectFloorUnitID;
                                        acBankAccountDepositItemEntity.BankAccountDepositID = result;

                                        resut_two = FCCACBankAccountDepositItem.GetFacadeCreate().Add(acBankAccountDepositItemEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                        #endregion

                                        CurrentACBankAccountDepositItemList.Add(aCBankAccountDepositItemEntity);
                                    }

                                    BindACBankAccountDepositItemList();
                                    BuildTotalValueLabel();
                                }
                            }

                            if (aCBankAccountDepositEntity.IsNew)
                            {
                                if (CurrentACBankAccountDepositItemList != null && CurrentACBankAccountDepositItemList.Count > 0)
                                {
                                    foreach (ACBankAccountDepositItem_DetailedEntity ent in CurrentACBankAccountDepositItemList)
                                    {
                                        ACBankAccountDepositItemEntity acBankAccountDepositItemEntity = new ACBankAccountDepositItemEntity();
                                        acBankAccountDepositItemEntity.AccountID = ent.AccountID;
                                        acBankAccountDepositItemEntity.DimensionID = ent.DimensionID;
                                        acBankAccountDepositItemEntity.Amount = ent.Amount;
                                        acBankAccountDepositItemEntity.Memo = ent.Memo;
                                        acBankAccountDepositItemEntity.ItemID = ent.ItemID;
                                        acBankAccountDepositItemEntity.RequisitionID = ent.RequisitionID;
                                        acBankAccountDepositItemEntity.WorkOrderID = ent.WorkOrderID;
                                        acBankAccountDepositItemEntity.BillID = ent.BillID;
                                        acBankAccountDepositItemEntity.ProjectID = ent.ProjectID;
                                        acBankAccountDepositItemEntity.ProjectFloorID = ent.ProjectFloorID;
                                        acBankAccountDepositItemEntity.ProjectFloorUnitID = ent.ProjectFloorUnitID;
                                        acBankAccountDepositItemEntity.BankAccountDepositID = result;

                                        resut_two = FCCACBankAccountDepositItem.GetFacadeCreate().Add(acBankAccountDepositItemEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                    }
                                }
                            }

                            hypReportLink.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.BANK_ACCOUNT_DEPOSIT_REPORT, UrlConstants.OVERVIEW_BANK_ACCOUNT_DEPOSIT_ID, result.ToString()).ToString();
                            hypReportLink.Target = "_blank";
                            hypReportLink.Visible = true;

                            
                            String str=(String)ViewState["Action"].ToString();

                            if (str == "GenerateReport")
                            {
                                _BankAccountDepositID = result;
                                _bankAccountDepositID = result;
                                PrepareEditView();
                            }

                            else if (str == "Approval")
                            {
                                _BankAccountDepositID = 0;
                                _bankAccountDepositID = result;
                                _ACBankAccountDepositEntity = new ACBankAccountDepositEntity();
                                PrepareInitialView();
                                PrepareInitialViewDepositeItem();
                                CurrentACBankAccountDepositItemList = new List<ACBankAccountDepositItem_DetailedEntity>();
                                BindACBankAccountDepositItemList();
                                BuildTotalValueLabel();
                            }

                            if (aCBankAccountDepositEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bank Account Deposit Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bank Account Deposit Information has been updated successfully.", false);
                            }
                        }
                        else
                        {
                            if (aCBankAccountDepositEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Bank Account Deposit Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Bank Account Deposit Information.", false);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
           
        }

        private void ClearAll()
        {
            txtAmount.Text = String.Empty;
            txtMemoDetail.Text = String.Empty;
            txtItemName.Text = String.Empty;

            //if (ddlProjectID.Items.Count > 0)
            //{
            //    ddlProjectID.SelectedValue = "0";
            //    BuildProjectWiseDropdownInfo();
            //}

            //if (ddlItemID.Items.Count > 0)
            //{
            //    ddlItemID.SelectedValue = "0";
            //}

            hdEmpID.Value = "0";
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            btnInitiateApprovalProcess.Attributes.Add("onclick", "this.disabled=true;" + Page.ClientScript.GetPostBackEventReference(btnInitiateApprovalProcess, "").ToString());

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareInitialViewDepositeItem();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvACBankAccountDepositItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountDepositItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountDepositItemID);

            if (BankAccountDepositItemID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountDepositItemID = BankAccountDepositItemID;

                    PrepareEditViewDepositeItem();
                    pnlAdd.Visible = false;
                    pnlUpdate.Visible = true;
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        ACBankAccountDepositItem_DetailedEntity depositeItemEntity = (from s in CurrentACBankAccountDepositItemList
                                                                                      where s.BankAccountDepositItemID == BankAccountDepositItemID
                                                                                      select s).FirstOrDefault();

                        CurrentACBankAccountDepositItemList.Remove(depositeItemEntity);

                        BindACBankAccountDepositItemList();
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {   
                SaveACBankAccountDepositEntity();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountDepositID = 0;
            _ACBankAccountDepositEntity = new ACBankAccountDepositEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        protected void btnSaveAndGenerateReport_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                ViewState["Action"] = "GenerateReport";

                #region Save Initailly

                SaveACBankAccountDepositEntity();

                #endregion
            }
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                ViewState["Action"] = "Approval";

                #region Save Initailly

                if (_bankAccountDepositID <= 0)
                {
                    SaveACBankAccountDepositEntity();
                }

                #endregion

                #region Approval Process

                Boolean apResult = APRobot.CreateApprovalProcessForNewBankDeposit(_bankAccountDepositID, Int64.Parse(ddlAPPanelID.SelectedValue));

                if (apResult == true)
                {
                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                    //String NavigationUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionList.aspx", string.Empty).ToString();
                    //Response.Redirect(NavigationUrl);
                    _bankAccountDepositID = 0;

                    String str = (String)ViewState["Action"].ToString();

                    if (str == "Approval")
                    {
                        _BankAccountDepositID = 0;
                        _ACBankAccountDepositEntity = new ACBankAccountDepositEntity();
                        PrepareInitialView();
                        PrepareInitialViewDepositeItem();
                        CurrentACBankAccountDepositItemList = new List<ACBankAccountDepositItem_DetailedEntity>();
                        BindACBankAccountDepositItemList();
                        BuildTotalValueLabel();
                        hypReportLink.Visible = false;
                    }
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                }

                EnableDisableApprovalProcessCheck();

                #endregion
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            if (ValidateInputAccounts())
            {
                // Implement Update Code Here.

                ACBankAccountDepositItem_DetailedEntity cust = (from c in CurrentACBankAccountDepositItemList
                                                                where c.BankAccountDepositItemID == CurrentACBankAccountDepositItemEntity.BankAccountDepositItemID
                                                                select c).SingleOrDefault();

                CurrentACBankAccountDepositItemList.Remove(cust);

                ACBankAccountDepositItem_DetailedEntity aCBankAccountDepositItemEntity = cust;

                if (hdEmpID.Value != "0")
                {
                    aCBankAccountDepositItemEntity.AccountID = Int64.Parse(hdEmpID.Value);
                    aCBankAccountDepositItemEntity.AccountName = txtItemName.Text.ToString().Trim();
                }

                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ItemID = null;
                        aCBankAccountDepositItemEntity.ItemName = String.Empty;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                        aCBankAccountDepositItemEntity.ItemName = ddlItemID.SelectedItem.ToString();
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.RequisitionID = null;
                        aCBankAccountDepositItemEntity.RequisitionNo = String.Empty;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                        aCBankAccountDepositItemEntity.RequisitionNo = ddlRequisitionID.SelectedItem.ToString();
                    }
                }


                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.WorkOrderID = null;
                        aCBankAccountDepositItemEntity.WorkOrderNo = String.Empty;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                        aCBankAccountDepositItemEntity.WorkOrderNo = ddlWorkOrderID.SelectedItem.ToString();
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.BillID = null;
                        aCBankAccountDepositItemEntity.BillNo = String.Empty;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                        aCBankAccountDepositItemEntity.BillNo = ddlBillID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectID = null;
                        aCBankAccountDepositItemEntity.ProjectName = String.Empty;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                        aCBankAccountDepositItemEntity.ProjectName = ddlProjectID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorID = null;
                        aCBankAccountDepositItemEntity.ProjectFloorName = String.Empty;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                        aCBankAccountDepositItemEntity.ProjectFloorName = ddlProjectFloorID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorUnitID = null;
                        aCBankAccountDepositItemEntity.ProjectFloorUnitName = String.Empty;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                        aCBankAccountDepositItemEntity.ProjectFloorUnitName = ddlProjectFloorUnitID.SelectedItem.ToString();
                    }
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    aCBankAccountDepositItemEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                aCBankAccountDepositItemEntity.Memo = txtMemoDetail.Text.Trim();

                CurrentACBankAccountDepositItemList.Add(aCBankAccountDepositItemEntity);

                BindACBankAccountDepositItemList();

                pnlAdd.Visible = true;
                pnlUpdate.Visible = false;

                ClearAll();
                BuildTotalValueLabel();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            CurrentACBankAccountDepositItemEntity = new ACBankAccountDepositItem_DetailedEntity();
            txtItemName.Text = String.Empty;
            hdEmpID.Value="0";
            txtMemoDetail.Text = String.Empty;
            txtAmount.Text = String.Empty;

            pnlUpdate.Visible = false;
            pnlAdd.Visible = true;
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInputAccounts())
            {
                ACBankAccountDepositItem_DetailedEntity aCBankAccountDepositItemEntity = new ACBankAccountDepositItem_DetailedEntity();

                aCBankAccountDepositItemEntity.BankAccountDepositItemID = CurrentACBankAccountDepositItemList.Count + 1;

                if (hdEmpID.Value != "0")
                {
                    aCBankAccountDepositItemEntity.AccountID = Int64.Parse(hdEmpID.Value);
                    aCBankAccountDepositItemEntity.AccountName = txtItemName.Text.ToString().Trim();
                }
                
                if (ddlItemID.Items.Count > 0)
                {
                    if (ddlItemID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ItemID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ItemID = Int64.Parse(ddlItemID.SelectedValue);
                        aCBankAccountDepositItemEntity.ItemName = ddlItemID.SelectedItem.ToString();
                    }
                }

                if (ddlRequisitionID.Items.Count > 0)
                {
                    if (ddlRequisitionID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.RequisitionID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.RequisitionID = Int64.Parse(ddlRequisitionID.SelectedValue);
                        aCBankAccountDepositItemEntity.RequisitionNo = ddlRequisitionID.SelectedItem.ToString();
                    }
                }

                if (ddlWorkOrderID.Items.Count > 0)
                {
                    if (ddlWorkOrderID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.WorkOrderID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                        aCBankAccountDepositItemEntity.WorkOrderNo = ddlWorkOrderID.SelectedItem.ToString();
                    }
                }

                if (ddlBillID.Items.Count > 0)
                {
                    if (ddlBillID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.BillID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.BillID = Int64.Parse(ddlBillID.SelectedValue);
                        aCBankAccountDepositItemEntity.BillNo = ddlBillID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectID.Items.Count > 0)
                {
                    if (ddlProjectID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                        aCBankAccountDepositItemEntity.ProjectName = ddlProjectID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorID.Items.Count > 0)
                {
                    if (ddlProjectFloorID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                        aCBankAccountDepositItemEntity.ProjectFloorName = ddlProjectFloorID.SelectedItem.ToString();
                    }
                }

                if (ddlProjectFloorUnitID.Items.Count > 0)
                {
                    if (ddlProjectFloorUnitID.SelectedValue == "0")
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorUnitID = null;
                    }
                    else
                    {
                        aCBankAccountDepositItemEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                        aCBankAccountDepositItemEntity.ProjectFloorUnitName = ddlProjectFloorUnitID.SelectedItem.ToString();
                    }
                }

                if (!txtAmount.Text.Trim().IsNullOrEmpty())
                {
                    aCBankAccountDepositItemEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
                }

                aCBankAccountDepositItemEntity.Memo = txtMemoDetail.Text.Trim();

                CurrentACBankAccountDepositItemList.Add(aCBankAccountDepositItemEntity);
                BindACBankAccountDepositItemList();

                ClearAll();
                BuildTotalValueLabel();
            }
        }

        #endregion

        #region DropDownList Event

        protected void ddlPaidFromID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildReferenceByPaidFrom();
        }

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
    }
}
