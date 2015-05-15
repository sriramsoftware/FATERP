// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jan-2012, 04:11:49




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.Security;
using Bay.ERP.Web.UI.Manager;
using Bay.ERP.Web.UI;

namespace Bay.ERP.Web.UI
{
    public partial class AFMRequisitionListControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _RequisitionID
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

        public REQRequisitionEntity _REQRequisitionEntity
        {
            get
            {
                REQRequisitionEntity entity = new REQRequisitionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (REQRequisitionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private REQRequisitionEntity CurrentREQRequisitionEntity
        {
            get
            {
                if (_RequisitionID > 0)
                {
                    if (_REQRequisitionEntity.RequisitionID != _RequisitionID)
                    {   
                        _REQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(_RequisitionID);
                    }
                }

                return _REQRequisitionEntity;
            }
            set
            {
                _REQRequisitionEntity = value;
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
            
        }

        private void PrepareEditView()
        {
            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;
        }

        private void BindList()
        {
            BindREQRequisitionList();
        }

        private void BindREQRequisitionList()
        {
            lvREQRequisition.DataBind();
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

        protected void lvREQRequisition_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionID);

            if (string.Equals(e.CommandName, "UpdateItem"))
            {
                try
                {
                    _RequisitionID = RequisitionID;

                    REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;
                    rEQRequisitionEntity.IsAccountsMadePayment = true;

                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionID, RequisitionID.ToString(), SQLMatchType.Equal);
                    result = FCCREQRequisition.GetFacadeCreate().Update(rEQRequisitionEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);

                    if (result > 0)
                    {
                        _RequisitionID = 0;
                        _REQRequisitionEntity = new REQRequisitionEntity();
                        BindREQRequisitionList();

                        //MiscUtil.ShowMessage(lblMessage, "Requisition has been successfully Updated.", false);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to Update Requisition.", true);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        protected void lvREQRequisition_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                REQRequisition_DetailedEntity ent = (REQRequisition_DetailedEntity)dataItem.DataItem;

                Label lblWorkOrderCreated = (Label)e.Item.FindControl("lblWorkOrderCreated");
                Label lblMadeCashPaymentLV = (Label)e.Item.FindControl("lblMadeCashPaymentLV");

                Button btnMadeCashPaymentLV = (Button)e.Item.FindControl("btnMadeCashPaymentLV");

                IList<PRMWorkOrderNoByRequisition_CustomEntity> lstWONO = FCCPRMWorkOrderNoByRequisition_Custom.GetFacadeCreate().GetIL(Int64.Parse(ent.RequisitionID.ToString()));

                if (lstWONO != null && lstWONO.Count > 0)
                {
                    lblWorkOrderCreated.Text = lstWONO[0].WorkOrderNo.ToString();
                }

                if (ent.IsCashPayment)
                {
                    btnMadeCashPaymentLV.Visible = true;

                    if (ent.IsAccountsMadePayment)
                    {
                        lblMadeCashPaymentLV.ForeColor = System.Drawing.Color.Green;
                        lblMadeCashPaymentLV.Text = "<b>Paid</b>";
                        btnMadeCashPaymentLV.Visible = false;
                    }
                    else
                    {
                        lblMadeCashPaymentLV.ForeColor = System.Drawing.Color.Red;
                        lblMadeCashPaymentLV.Text = "<b>Unpaid</b>";
                        btnMadeCashPaymentLV.Visible = true;
                    }
                }
                else
                {
                    btnMadeCashPaymentLV.Visible = false;
                }

                


                HyperLink hypRequisitionReport = (HyperLink)e.Item.FindControl("hypRequisitionReport");
                hypRequisitionReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "RequisitionReport", UrlConstants.REQUISITION_ID, ent.RequisitionID.ToString()).ToString();
                hypRequisitionReport.Target = "_blank";
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsREQRequisition_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;
            fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionEntity.FLD_NAME_RequisitionStatusID,MasterDataConstants.RequisitionStatus.APPROVED.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition.RequisitionNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);              
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #region Button Event

        protected void btnMadeCashPayment_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/AC/ACBankAccountPayment.aspx");
        }

        #endregion

        #endregion Event
    }
}
