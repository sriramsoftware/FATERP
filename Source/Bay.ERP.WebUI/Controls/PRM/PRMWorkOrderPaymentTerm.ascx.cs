// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class PRMWorkOrderPaymentTermControl : BaseControl
    {       
        #region Properties

        public Int64 _WorkOrderPaymentTermID
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

        public PRMWorkOrderPaymentTermEntity _PRMWorkOrderPaymentTermEntity
        {
            get
            {
                PRMWorkOrderPaymentTermEntity entity = new PRMWorkOrderPaymentTermEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMWorkOrderPaymentTermEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMWorkOrderPaymentTermEntity CurrentPRMWorkOrderPaymentTermEntity
        {
            get
            {
                if (_WorkOrderPaymentTermID > 0)
                {
                    if (_PRMWorkOrderPaymentTermEntity.WorkOrderPaymentTermID != _WorkOrderPaymentTermID)
                    {
                        _PRMWorkOrderPaymentTermEntity = FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().GetByID(_WorkOrderPaymentTermID);
                    }
                }

                return _PRMWorkOrderPaymentTermEntity;
            }
            set
            {
                _PRMWorkOrderPaymentTermEntity = value;
            }
        }

        public Int64 PRMWorkOrderID
        {
            get
            {
                Int64 _pRMWorkOrderID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID], out _pRMWorkOrderID);
                }

                return _pRMWorkOrderID;
            }
        }

        public String PRMWorkOrderNo
        {
            get
            {
                String _pRMWorkOrderNo = null;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[PRMWorkOrderEntity.FLD_NAME_WorkOrderNo]))
                {
                    _pRMWorkOrderNo = Helper.Url.SecureUrl[PRMWorkOrderEntity.FLD_NAME_WorkOrderNo];
                }

                return _pRMWorkOrderNo;
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

            lblWorkOrderNo.Text = PRMWorkOrderNo.ToString();
            txtPaymentPercentage.Text = "0";
            txtCompletionPercentage.Text = "0";
            txtCompletionNote.Text = String.Empty;
            txtPaymentDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;

            #region Build Hyperlink

            hypWorkOrder.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrder.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString()).ToString();
            hypWorkOrderItem.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, PRMWorkOrderNo.ToString()).ToString();
            hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "WorkOrderReport", UrlConstants.OVERVIEW_WORKORDER_ID, PRMWorkOrderID.ToString()).ToString();
            hypReport.Target = "_blank";

            #endregion

            #region Approval Process

            EnableDisableApprovalProcessCheck();

            #endregion
        }

        private void EnableDisableApprovalProcessCheck()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.WORK_ORDER, PRMWorkOrderID);

            if (aPApprovalProcessEntity.APApprovalProcessID > 0)
            {
                btnInitiateApprovalProcess.Enabled = false;
            }
            else
            {
                btnInitiateApprovalProcess.Enabled = true;
            }
        }

        private void PrepareEditView()
        {
            PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity = CurrentPRMWorkOrderPaymentTermEntity;


            if (!pRMWorkOrderPaymentTermEntity.IsNew)
            {
                lblWorkOrderNo.Text = PRMWorkOrderNo.ToString();

                txtPaymentPercentage.Text = pRMWorkOrderPaymentTermEntity.PaymentPercentage.ToString();
                txtCompletionPercentage.Text = pRMWorkOrderPaymentTermEntity.CompletionPercentage.ToString();
                txtCompletionNote.Text = pRMWorkOrderPaymentTermEntity.CompletionNote.ToString();
                txtPaymentDate.Text = pRMWorkOrderPaymentTermEntity.PaymentDate.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMWorkOrderPaymentTermList();
        }

        private void BindPRMWorkOrderPaymentTermList()
        {
            lvPRMWorkOrderPaymentTerm.DataBind();
        }

        private PRMWorkOrderPaymentTermEntity BuildPRMWorkOrderPaymentTermEntity()
        {
            PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity = CurrentPRMWorkOrderPaymentTermEntity;


            pRMWorkOrderPaymentTermEntity.WorkOrderID = PRMWorkOrderID;
           
            if (!txtPaymentPercentage.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderPaymentTermEntity.PaymentPercentage = Decimal.Parse(txtPaymentPercentage.Text.Trim());
            }

            if (!txtCompletionPercentage.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderPaymentTermEntity.CompletionPercentage = Decimal.Parse(txtCompletionPercentage.Text.Trim());
            }

            pRMWorkOrderPaymentTermEntity.CompletionNote = txtCompletionNote.Text.Trim();
            if (txtPaymentDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMWorkOrderPaymentTermEntity.PaymentDate = MiscUtil.ParseToDateTime(txtPaymentDate.Text);
            }
            else
            {
                pRMWorkOrderPaymentTermEntity.PaymentDate = null;
            }


            return pRMWorkOrderPaymentTermEntity;
        }

        private void SavePRMWorkOrderPaymentTermEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity = BuildPRMWorkOrderPaymentTermEntity();

                    Int64 result = -1;

                    if (pRMWorkOrderPaymentTermEntity.IsNew)
                    {
                        result = FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().Add(pRMWorkOrderPaymentTermEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderPaymentTermEntity.FLD_NAME_WorkOrderPaymentTermID, pRMWorkOrderPaymentTermEntity.WorkOrderPaymentTermID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().Update(pRMWorkOrderPaymentTermEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _WorkOrderPaymentTermID = 0;
                        _PRMWorkOrderPaymentTermEntity = new PRMWorkOrderPaymentTermEntity();
                        PrepareInitialView();
                        BindPRMWorkOrderPaymentTermList();

                        if (pRMWorkOrderPaymentTermEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Payment Term Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Payment Term Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMWorkOrderPaymentTermEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Work Order Payment Term Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Work Order Payment Term Information.", false);
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

        protected void lvPRMWorkOrderPaymentTerm_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkOrderPaymentTermID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderPaymentTermID);

            if (WorkOrderPaymentTermID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _WorkOrderPaymentTermID = WorkOrderPaymentTermID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderPaymentTermEntity.FLD_NAME_WorkOrderPaymentTermID, WorkOrderPaymentTermID.ToString(), SQLMatchType.Equal);

                        PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity = new PRMWorkOrderPaymentTermEntity();


                        result = FCCPRMWorkOrderPaymentTerm.GetFacadeCreate().Delete(pRMWorkOrderPaymentTermEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkOrderPaymentTermID = 0;
                            _PRMWorkOrderPaymentTermEntity = new PRMWorkOrderPaymentTermEntity();
                            PrepareInitialView();
                            BindPRMWorkOrderPaymentTermList();

                            MiscUtil.ShowMessage(lblMessage, "Work Order Payment Term has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order Payment Term.", true);
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

        protected void odsPRMWorkOrderPaymentTerm_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderPaymentTermEntity.FLD_NAME_WorkOrderID, PRMWorkOrderID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMWorkOrderPaymentTermEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _WorkOrderPaymentTermID = 0;
            _PRMWorkOrderPaymentTermEntity = new PRMWorkOrderPaymentTermEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnInitiateApprovalProcess_Click(object sender, EventArgs e)
        {
            #region Approval Process

            Boolean apResult = APRobot.CreateApprovalProcessForNewWorkWorder(PRMWorkOrderID);

            if (apResult == true)
            {
                MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
            }
            else
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
            }

            EnableDisableApprovalProcessCheck();

            #endregion

        }

        #endregion

        #region Check Box Event

        protected void chbxSecurityMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSecurityMoney.Checked)
            {
                txtCompletionNote.Enabled = false;
                txtCompletionNote.Text = String.Empty;
                txtCompletionNote.Text = "Security Money";
            }
            else
            {
                txtCompletionNote.Enabled = true;
                txtCompletionNote.Text = String.Empty;
            }
        }

        #endregion

        #endregion Event
    }
}
