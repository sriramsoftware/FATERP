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
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class PRMWorkOrderControl : BaseControl
    {
        #region Properties

        public Int64 _WorkOrderID
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

        public PRMWorkOrderEntity _PRMWorkOrderEntity
        {
            get
            {
                PRMWorkOrderEntity entity = new PRMWorkOrderEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMWorkOrderEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMWorkOrderEntity CurrentPRMWorkOrderEntity
        {
            get
            {
                if (_WorkOrderID > 0)
                {
                    if (_PRMWorkOrderEntity.WorkOrderID != _WorkOrderID)
                    {
                        _PRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(_WorkOrderID);
                    }
                }

                return _PRMWorkOrderEntity;
            }
            set
            {
                _PRMWorkOrderEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, false);
            MiscUtil.PopulateHREmployee(ddlPreparedByID, false);
            MiscUtil.PopulateMDWorkOrderStatus(ddlWorkOrderStatusID, false);

            PopulatePRMSupplierContactPersonByVedor();
        }

        private void PrepareValidator()
        {
        }

        private void PopulatePRMSupplierContactPersonByVedor()
        {
            if (ddlSupplierID != null && ddlSupplierID.Items.Count > 0)
            {
                MiscUtil.PopulatePRMSupplierContactPersonByVendorID(ddlAttentionID, false, Int64.Parse(ddlSupplierID.SelectedValue.ToString()));

                ListItem pleaseSelectListItem = new ListItem("Others", "0");
                ddlAttentionID.Items.Insert(ddlAttentionID.Items.Count, pleaseSelectListItem);

                if (ddlAttentionID.Items.Count > 0 && ddlAttentionID.SelectedValue == "0")
                {
                    pnlOtherAttention.Visible = true;
                }
                else if (ddlAttentionID.Items.Count > 0 && ddlAttentionID.SelectedValue != "0")
                {
                    pnlOtherAttention.Visible = false;
                }
            }
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            //String se = SqlExpressionBuilder.PrepareSortExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, SQLSortOrderType.Decending);
            //IList<PRMWorkOrderEntity> workOrderList = FCCPRMWorkOrder.GetFacadeCreate().GetIL(null, null, se, String.Empty, DatabaseOperationType.LoadWithSortExpression);
            //Int64 workOrderNo = 0;

            //if (workOrderList != null && workOrderList.Count > 0)
            //{
            //    workOrderNo = (from c in workOrderList
            //                   select Convert.ToInt64(c.WorkOrderNo)).Max() + 1;

            //    txtWorkOrderNo.Text = workOrderNo.ToString();
            //}
            //else
            //{
            //    //Put The Start Project Code Here.
            //    txtWorkOrderNo.Text = "00001";
            //}

            txtWorkOrderNo.Text = MasterDataConstants.AutoAssigned.DEFAULT_AUTO_ASSIGNED;
            txtOtherAttention.Text = String.Empty;
            txtCreateDate.Text = DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtSubject.Text = String.Empty;
            txtBodyTitle.Text = String.Empty;
            txtStartDate.Text = System.DateTime.Now.ToString("dd-MM-yyyy");
            txtCompletionDate.Text = System.DateTime.Now.AddDays(7).ToString("dd-MM-yyyy");
            txtWarranty.Text = "N/A";
            txtDelayCharge.Text = "N/A";
            txtRowText.Text = String.Empty;
            txtRemarks.Text = "N/A";
            txtFootNote.Text = "TDS will be deducted as per government rule.";
            hypWorkOrderItemMap.Visible = false;
            hypWorkOrderPaymentTerm.Visible = false;
            txtAIT.Text = "0";
            txtCarryingCharge.Text = "0";
            txtDiscount.Text = "0";
            txtVAT.Text = "0";
            txtTax.Text = "0";
            txtGrandTotal.Text = String.Empty;

            btnSubmit.Text = "Save & Next";
            btnAddNew.Visible = false;

            Int64 workOrderID = 0;

            if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID]))
            {
                Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_WORKORDER_ID], out workOrderID);
                _WorkOrderID = workOrderID;

                BuildLabel(workOrderID);
            }

           // pnlOtherAttention.Visible = false;

            if(ddlPreparedByID!=null && ddlPreparedByID.Items.Count>0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEntity.FLD_NAME_MemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);

                IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lstEmployee != null && lstEmployee.Count > 0)
                {
                    ddlPreparedByID.SelectedValue = lstEmployee[0].EmployeeID.ToString();
                }
            }
        }

        private void BuildLabel(Int64 workOrderID)
        {
            hypWorkOrderItemMap.Visible = true;
            hypWorkOrderPaymentTerm.Visible = true;
            hypWorkOrderItemMap.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, workOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, CurrentPRMWorkOrderEntity.WorkOrderNo.ToString()).ToString();
            hypWorkOrderPaymentTerm.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderPaymentTerm.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, workOrderID.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, CurrentPRMWorkOrderEntity.WorkOrderNo.ToString()).ToString();
        }

        private void PrepareEditView()
        {
            PRMWorkOrderEntity pRMWorkOrderEntity = CurrentPRMWorkOrderEntity;


            if (!pRMWorkOrderEntity.IsNew)
            {
                if (ddlSupplierID.Items.Count > 0 && pRMWorkOrderEntity.SupplierID != null)
                {
                    ddlSupplierID.SelectedValue = pRMWorkOrderEntity.SupplierID.ToString();
                }

                PopulatePRMSupplierContactPersonByVedor();

                txtWorkOrderNo.Text = pRMWorkOrderEntity.WorkOrderNo.ToString();

                if (ddlAttentionID.Items.Count > 0 && pRMWorkOrderEntity.AttentionID != null)
                {
                    ddlAttentionID.SelectedValue = pRMWorkOrderEntity.AttentionID.ToString();
                    pnlOtherAttention.Visible = false;
                }
                if (ddlAttentionID.Items.Count > 0 && pRMWorkOrderEntity.AttentionID == null)
                {
                    ddlAttentionID.SelectedValue = "0";
                    pnlOtherAttention.Visible = true;
                }

                txtOtherAttention.Text = pRMWorkOrderEntity.OtherAttention.ToString();
                txtCreateDate.Text = pRMWorkOrderEntity.CreateDate.ToStringDefault();
                txtSubject.Text = pRMWorkOrderEntity.Subject.ToString();
                txtBodyTitle.Text = pRMWorkOrderEntity.BodyTitle.ToString();
                txtStartDate.Text = pRMWorkOrderEntity.StartDate.ToStringDefault();
                txtCompletionDate.Text = pRMWorkOrderEntity.CompletionDate.ToStringDefault();
                txtWarranty.Text = pRMWorkOrderEntity.Warranty.ToString();
                txtDelayCharge.Text = pRMWorkOrderEntity.DelayCharge.ToString();
                txtAIT.Text = pRMWorkOrderEntity.AIT.ToString();
                txtCarryingCharge.Text = pRMWorkOrderEntity.CarryingCharge.ToString();
                txtDiscount.Text = pRMWorkOrderEntity.Discount.ToString();
                txtVAT.Text = pRMWorkOrderEntity.VAT.ToString();
                txtTax.Text = pRMWorkOrderEntity.Tax.ToString();
                 
                String fe_workorderItem = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderID, pRMWorkOrderEntity.WorkOrderID.ToString(), SQLMatchType.Equal);
                IList<PRMWorkOrderItemMapEntity> lstPRMWorkOrderItemMap=FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null,null,String.Empty,fe_workorderItem,DatabaseOperationType.LoadWithFilterExpression);

                if (lstPRMWorkOrderItemMap != null && lstPRMWorkOrderItemMap.Count > 0)
                {
                    txtTotal.Text = Math.Round(lstPRMWorkOrderItemMap.Sum(o => (o.RequiredQty * o.Rate)), 2).ToString();
                }
                else
                {
                    txtTotal.Text = "0";
                }

                if (txtTotal.Text.Trim().IsNotNullOrEmpty())
                {
                    Decimal total, ait, vat, tax, discount, carryingcharge,netAmount;
                    Decimal.TryParse(txtTotal.Text.Trim(), out total);
                    Decimal.TryParse(txtAIT.Text.Trim(), out ait);
                    Decimal.TryParse(txtVAT.Text.Trim(), out vat);
                    Decimal.TryParse(txtTax.Text.Trim(), out tax);
                    Decimal.TryParse(txtDiscount.Text.Trim(), out discount);
                    Decimal.TryParse(txtCarryingCharge.Text.Trim(), out carryingcharge);

                    netAmount = total - discount + carryingcharge + vat + tax;
                    txtGrandTotal.Text = Math.Round(netAmount,2).ToString();
                }
                else
                {
                    txtGrandTotal.Text = "0";
                }

                txtRowText.Text = pRMWorkOrderEntity.RowText.ToString();
                txtRemarks.Text = pRMWorkOrderEntity.Remarks.ToString();
                txtFootNote.Text = pRMWorkOrderEntity.FootNote.ToString();
                if (ddlPreparedByID.Items.Count > 0 && pRMWorkOrderEntity.PreparedByID != null)
                {
                    ddlPreparedByID.SelectedValue = pRMWorkOrderEntity.PreparedByID.ToString();
                }

                if (ddlWorkOrderStatusID.Items.Count > 0 && pRMWorkOrderEntity.WorkOrderStatusID != null)
                {
                    ddlWorkOrderStatusID.SelectedValue = pRMWorkOrderEntity.WorkOrderStatusID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private PRMWorkOrderEntity BuildPRMWorkOrderEntity()
        {
            PRMWorkOrderEntity pRMWorkOrderEntity = CurrentPRMWorkOrderEntity;

            if (ddlSupplierID.Items.Count > 0)
            {
                if (ddlSupplierID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMWorkOrderEntity.SupplierID = Int64.Parse(ddlSupplierID.SelectedValue);
                }
            }
               pRMWorkOrderEntity.WorkOrderNo = txtWorkOrderNo.Text.ToString();

            if (ddlAttentionID.Items.Count > 0)
            {
                if (ddlAttentionID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMWorkOrderEntity.AttentionID = Int64.Parse(ddlAttentionID.SelectedValue);
                }
            }

            pRMWorkOrderEntity.OtherAttention = txtOtherAttention.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMWorkOrderEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            pRMWorkOrderEntity.Subject = txtSubject.Text.Trim();
            pRMWorkOrderEntity.BodyTitle = txtBodyTitle.Text.Trim();
            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMWorkOrderEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }

            if (txtCompletionDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMWorkOrderEntity.CompletionDate = MiscUtil.ParseToDateTime(txtCompletionDate.Text);
            }

            pRMWorkOrderEntity.Warranty = txtWarranty.Text.Trim();
            pRMWorkOrderEntity.DelayCharge = txtDelayCharge.Text.Trim();

            if (!txtAIT.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderEntity.AIT = Decimal.Parse(txtAIT.Text.Trim());
            }
            else
            {
                pRMWorkOrderEntity.AIT = null;
            }

            if (!txtCarryingCharge.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderEntity.CarryingCharge = Decimal.Parse(txtCarryingCharge.Text.Trim());
            }
            else
            {
                pRMWorkOrderEntity.CarryingCharge = null;
            }

            if (!txtDiscount.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderEntity.Discount = Decimal.Parse(txtDiscount.Text.Trim());
            }
            else
            {
                pRMWorkOrderEntity.Discount = null;
            }

            if (!txtVAT.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderEntity.VAT = Decimal.Parse(txtVAT.Text.Trim());
            }
            else
            {
                pRMWorkOrderEntity.VAT = null;
            }

            if (!txtTax.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderEntity.Tax = Decimal.Parse(txtTax.Text.Trim());
            }
            else
            {
                pRMWorkOrderEntity.Tax = null;
            }

            if (!txtGrandTotal.Text.Trim().IsNullOrEmpty())
            {
                pRMWorkOrderEntity.GrandTotal = Decimal.Parse(txtGrandTotal.Text.Trim());
            }
            else
            {
                pRMWorkOrderEntity.GrandTotal = null;
            }

            pRMWorkOrderEntity.RowText = txtRowText.Text.Trim();
            pRMWorkOrderEntity.Remarks = txtRemarks.Text.Trim();
            pRMWorkOrderEntity.FootNote = txtFootNote.Text.Trim();
            if (ddlPreparedByID.Items.Count > 0)
            {
                if (ddlPreparedByID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMWorkOrderEntity.PreparedByID = Int64.Parse(ddlPreparedByID.SelectedValue);
                }
            }

            if (ddlWorkOrderStatusID.Items.Count > 0)
            {
                if (ddlWorkOrderStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMWorkOrderEntity.WorkOrderStatusID = Int64.Parse(ddlWorkOrderStatusID.SelectedValue);
                }
            }
            pRMWorkOrderEntity.IsFinalBilled = false;

            return pRMWorkOrderEntity;
        }

        private void SavePRMWorkOrderEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMWorkOrderEntity pRMWorkOrderEntity = BuildPRMWorkOrderEntity();

                    Int64 result = -1;

                    if (pRMWorkOrderEntity.IsNew)
                    {
                        result = FCCPRMWorkOrder.GetFacadeCreate().Add(pRMWorkOrderEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, pRMWorkOrderEntity.WorkOrderID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMWorkOrder.GetFacadeCreate().Update(pRMWorkOrderEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _WorkOrderID = result;
                        _PRMWorkOrderEntity = new PRMWorkOrderEntity();
                        PrepareInitialView();
                        PrepareEditView();

                        if (pRMWorkOrderEntity.IsNew)
                        {
                            if (result > 0)
                            {
                                _WorkOrderID = result;
                                BuildLabel(result);

                                String NavUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, result.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, CurrentPRMWorkOrderEntity.WorkOrderNo.ToString()).ToString();
                                Response.Redirect(NavUrl);
                            }

                            MiscUtil.ShowMessage(lblMessage, "Work Order Information has been added successfully.", false);
                        }
                        else
                        {
                            String NavUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMWorkOrderPaymentTerm.aspx", string.Empty, UrlConstants.OVERVIEW_WORKORDER_ID, result.ToString(), PRMWorkOrderEntity.FLD_NAME_WorkOrderNo, CurrentPRMWorkOrderEntity.WorkOrderNo.ToString()).ToString();
                            Response.Redirect(NavUrl);
                            MiscUtil.ShowMessage(lblMessage, "Work Order Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMWorkOrderEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Work Order Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Work Order Information.", false);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMWorkOrderEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _WorkOrderID = 0;
            _PRMWorkOrderEntity = new PRMWorkOrderEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void ddlSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulatePRMSupplierContactPersonByVedor();
        }

        protected void ddlAttentionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAttentionID != null && ddlAttentionID.SelectedValue.ToString() == "0")
            {
                pnlOtherAttention.Visible = true;
            }
            if (ddlAttentionID != null && ddlAttentionID.SelectedValue.ToString() != "0")
            {
                txtOtherAttention.Text = String.Empty;
                pnlOtherAttention.Visible = false;
            }

        }

        #endregion

        #endregion Event
    }
}
