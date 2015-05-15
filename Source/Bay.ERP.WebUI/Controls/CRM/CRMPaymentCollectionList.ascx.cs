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
    public partial class CRMPaymentCollectionListControl : BaseControl
    {       
        #region Properties

        public Int64 _PaymentCollectionID
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

        public CRMPaymentCollectionEntity _CRMPaymentCollectionEntity
        {
            get
            {
                CRMPaymentCollectionEntity entity = new CRMPaymentCollectionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMPaymentCollectionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMPaymentCollectionEntity CurrentCRMPaymentCollectionEntity
        {
            get
            {
                if (_PaymentCollectionID > 0)
                {
                    if (_CRMPaymentCollectionEntity.PaymentCollectionID != _PaymentCollectionID)
                    {
                        _CRMPaymentCollectionEntity = FCCCRMPaymentCollection.GetFacadeCreate().GetByID(_PaymentCollectionID);
                    }
                }

                return _CRMPaymentCollectionEntity;
            }
            set
            {
                _CRMPaymentCollectionEntity = value;
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
            CRMPaymentCollectionEntity cRMPaymentCollectionEntity = CurrentCRMPaymentCollectionEntity;
        }

        private void BindList()
        {
            BindCRMPaymentCollectionList();
        }

        private void BindCRMPaymentCollectionList()
        {
            lvCRMPaymentCollection.DataBind();
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

        protected void lvCRMPaymentCollection_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMPaymentCollection_DetailedEntity ent = (CRMPaymentCollection_DetailedEntity)dataItem.DataItem;

                HyperLink hypReport = (HyperLink)e.Item.FindControl("hypReport");
                CheckBox chbxChequeInCashConfirmationLV = (CheckBox)e.Item.FindControl("chbxChequeInCashConfirmationLV");
                Button btnChequeInCashConfirmationLV = (Button)e.Item.FindControl("btnChequeInCashConfirmationLV");

                if (ent.ChequeInCashConfirmation == true)
                {
                    btnChequeInCashConfirmationLV.Enabled = false;
                }
                else if (ent.ChequeInCashConfirmation == false)
                {
                    btnChequeInCashConfirmationLV.Enabled = true;
                }

                hypReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.MONEY_RECEIPT_REPORT, UrlConstants.OVERVIEW_PAYMENT_COLLECTION_ID, ent.PaymentCollectionID.ToString()).ToString();
                hypReport.Target = "_blank";


            }
        }

        protected void lvCRMPaymentCollection_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PaymentCollectionID;

            Int64.TryParse(e.CommandArgument.ToString(), out PaymentCollectionID);

            if (PaymentCollectionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PaymentCollectionID = PaymentCollectionID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentCollectionEntity.FLD_NAME_PaymentCollectionID, PaymentCollectionID.ToString(), SQLMatchType.Equal);

                        CRMPaymentCollectionEntity cRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();


                        result = FCCCRMPaymentCollection.GetFacadeCreate().Delete(cRMPaymentCollectionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PaymentCollectionID = 0;
                            _CRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();
                            PrepareInitialView();
                            BindCRMPaymentCollectionList();

                            MiscUtil.ShowMessage(lblMessage, "C RMPayment Collection has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMPayment Collection.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
                else if (string.Equals(e.CommandName, "UpdateItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        CRMPaymentCollectionEntity cRMPaymentCollectionEntity = FCCCRMPaymentCollection.GetFacadeCreate().GetByID(PaymentCollectionID);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentCollectionEntity.FLD_NAME_PaymentCollectionID, PaymentCollectionID.ToString(), SQLMatchType.Equal);

                        cRMPaymentCollectionEntity.ChequeInCashConfirmation = true;

                        result = FCCCRMPaymentCollection.GetFacadeCreate().Update(cRMPaymentCollectionEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                        if (result > 0)
                        {
                            _PaymentCollectionID = 0;
                            _CRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();
                            PrepareInitialView();
                            BindCRMPaymentCollectionList();

                            MiscUtil.ShowMessage(lblMessage, "Payment Collection has been successfully updated.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Payment Collection.", true);
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

        protected void odsCRMPaymentCollection_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {   
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CRMPaymentCollection.MoneyReceiptNo", txtSearchText.Text.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("CRMPaymentScheduleMap.InstallmentName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression("CRMMDPaymentCategory.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe6 = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.OR, fe5);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe3);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PaymentCollectionID = 0;
            _CRMPaymentCollectionEntity = new CRMPaymentCollectionEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
