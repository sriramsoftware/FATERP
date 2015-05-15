// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




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
    public partial class CMBill_NEWControl : BaseControl
    {
        #region Properties

        public Int64 _BillID
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

        public CMBillEntity _CMBillEntity
        {
            get
            {
                CMBillEntity entity = new CMBillEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMBillEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMBillEntity CurrentCMBillEntity
        {
            get
            {
                if (_BillID > 0)
                {
                    if (_CMBillEntity.BillID != _BillID)
                    {
                        _CMBillEntity = FCCCMBill.GetFacadeCreate().GetByID(_BillID);
                    }
                }

                return _CMBillEntity;
            }
            set
            {
                _CMBillEntity = value;
            }
        }

        private PRMWorkOrderEntity CurrentPRMWorkOrderEntity
        {
            get
            {
                PRMWorkOrderEntity _PRMWorkOrderEntity = new PRMWorkOrderEntity();

                if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != "0")
                {

                    Int64 workOrderID;
                    Int64.TryParse(ddlWorkOrderID.SelectedValue.ToString(), out workOrderID);

                    if (workOrderID > 0)
                    {
                        _PRMWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(workOrderID);
                    }
                }

                return _PRMWorkOrderEntity;
            }
        }

        public Int64 CMBillID
        {
            get
            {
                Int64 cMBillID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_ID], out cMBillID);
                }

                return cMBillID;
            }
        }

        public Int64 CurrentWorkOrderItemIDPopup
        {
            get
            {
                Int64 id = 0;

                if (ViewState["CurrentWorkOrderItemIDPopup"] != null)
                {
                    Int64.TryParse(ViewState["CurrentWorkOrderItemIDPopup"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["CurrentWorkOrderItemIDPopup"] = value;
            }
        }

        public IList<PRMWorkOrderItemFloorDetailEntity> PRMWorkOrderItemFloorDetailEntityList
        {
            get
            {
                //if (_RequisitionItemID > 0)
                //{
                //    if (_REQRequisitionItemEntity.RequisitionItemID != _RequisitionItemID)
                //    {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemFloorDetailEntity.FLD_NAME_WorkOrderItemMapID, CurrentWorkOrderItemIDPopup.ToString(), SQLMatchType.Equal);
                ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"] = FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                //}
                //}

                return (IList<PRMWorkOrderItemFloorDetailEntity>)ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"];
            }
            set
            {
                ViewState["vs_CurrentPRMWorkOrderItemFloorDetailEntity"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateMDBillApprovalStatus(ddlBillApprovalStatusID, false);
            ListItem contractor = new ListItem("Contractor", "1");
            ListItem consultant = new ListItem("Consultant", "2");
            ListItem vendor = new ListItem("Vendor", "3");

            ddlVendorCategoryID.Items.Add(vendor);
            ddlVendorCategoryID.Items.Add(contractor);
            ddlVendorCategoryID.Items.Add(consultant);

            BuildVendorByVendorCategory();

            if (chbxFinalBilled.Checked == false)
            {
                BuildWOExceptFinalBillByVendor();
            }

            else if (chbxFinalBilled.Checked == true)
            {
                BuildWOByVendor();
            }

            MiscUtil.PopulateMDBillStatus(ddlBillStatusID, false);
        }

        private void BindPRMMaterialReceiveList()
        {
            lvPRMMaterialReceive.DataBind();
        }

        private void BindMaterialReceiveItemList()
        {
            lvPRMMaterialReceiveItemMap.DataBind();
        }

        private void BuildWOExceptFinalBillByVendor()
        {
            if (ddlVendorCategoryID != null && ddlVendorCategoryID.Items.Count > 0)
            {
                //if (ddlVendorCategoryID.SelectedValue.ToString() == MasterDataConstants.CM_Bill_VendorCategory.VENDOR)
                //{
                    if (ddlVendorID != null && ddlVendorID.SelectedValue != "0")
                    {
                        MiscUtil.PopulatePRMWorkOrderExceptFinalBillbySupplierID(ddlWorkOrderID, true, Int64.Parse(ddlVendorID.SelectedValue.ToString()));
                    }
                //}
                //else
                //{
                //    ddlWorkOrderID.Items.Clear();
                //}
            }
        }

        private void BuildWOByVendor()
        {
            if (ddlVendorCategoryID != null && ddlVendorCategoryID.Items.Count > 0)
            {
                if (ddlVendorCategoryID.SelectedValue.ToString() == MasterDataConstants.CM_Bill_VendorCategory.VENDOR)
                {
                    if (ddlVendorID != null && ddlVendorID.SelectedValue != "0")
                    {
                        MiscUtil.PopulatePRMWorkOrderbySupplierID(ddlWorkOrderID, true, Int64.Parse(ddlVendorID.SelectedValue.ToString()));
                    }
                }
                else
                {
                    ddlWorkOrderID.Items.Clear();
                }
            }
        }

        private void BuildVendorByVendorCategory()
        {
            if (ddlVendorCategoryID != null && ddlVendorCategoryID.Items.Count > 0)
            {
                switch (ddlVendorCategoryID.SelectedValue.ToString())
                {

                    case MasterDataConstants.CM_Bill_VendorCategory.CONTRACTOR:
                        MiscUtil.PopulateCMContractor(ddlVendorID, false);
                        break;
                    case MasterDataConstants.CM_Bill_VendorCategory.CONSULTANT:
                        MiscUtil.PopulateCMConsultant(ddlVendorID, false);
                        break;
                    case MasterDataConstants.CM_Bill_VendorCategory.VENDOR:
                        MiscUtil.PopulatePRMSupplier(ddlVendorID, false);
                        break;
                }
            }
        }

        private void BuildVendorWOByVendorCategory()
        {
            if (chbxFinalBilled.Checked == false)
            {
                BuildWOExceptFinalBillByVendor();
            }

            else if (chbxFinalBilled.Checked == true)
            {
                BuildWOByVendor();
            }
        }

        private Boolean ValidationInput()
        {
            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != "0")
            {
                if (ddlWorkOrderID.SelectedItem.ToString().EndsWith("Billed"))
                {
                    MiscUtil.ShowMessage(lblMessage, "Bill Already Paid.", true);
                    return false;
                }
            }

            return true;
        }

        private void CalculatePrice()
        {
            try
            {
                IList<ListViewDataItem> list = lvPRMMaterialReceiveItemMap.Items;

                if (list != null && list.Count > 0)
                {
                    Decimal totalBillPrice = 0;
                    foreach (ListViewDataItem lvdi in list)
                    {
                        Decimal billPriceLV;
                        TextBox txtBillPriceLV = (TextBox)lvdi.FindControl("txtBillPriceLV");
                        Decimal.TryParse(txtBillPriceLV.Text.Trim(), out billPriceLV);

                        if (billPriceLV > 0)
                        {
                            totalBillPrice += billPriceLV;
                        }

                        txtTentativeAmount.Text = totalBillPrice.ToString();
                        if (txtAmount.Text.IsNullOrEmpty())
                        {
                            txtAmount.Text = totalBillPrice.ToString();
                        }
                    }
                }

                CalculateNetAmount();
            }
            catch (Exception ex)
            {

            }
        }

        private void CalculateNetAmount()
        {
            Decimal tax, vat, discount, carryingCharge, amount, netAmount;
            Decimal.TryParse(txtDiscountAddition.Text, out discount);
            Decimal.TryParse(txtVat.Text, out vat);
            Decimal.TryParse(txtCarryingCharge.Text, out carryingCharge);
            Decimal.TryParse(txtTax.Text, out tax);
            Decimal.TryParse(txtTentativeAmount.Text, out amount);

            netAmount = amount - discount + tax + vat + carryingCharge;

            txtAmount.Text = netAmount.ToString();
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtBillNo.Text = String.Empty;
            txtBillDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtAmount.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtDiscountAddition.Text = "0";
            txtVat.Text = "0";
            txtTax.Text = "0";
            txtCarryingCharge.Text = "0";

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private String GetFilterExpression()
        {
            String compositeMRRID = String.Empty;
            String fe_materialReceiveItem = String.Empty;

            try
            {
                IList<ListViewDataItem> list = lvPRMMaterialReceive.Items;

                if (list != null && list.Count > 0)
                {
                    foreach (ListViewDataItem lvdi in list)
                    {

                        Label lblMaterialReceiveIDLV = (Label)lvdi.FindControl("lblMaterialReceiveIDLV");
                        CheckBox chbxSelectMRR = (CheckBox)lvdi.FindControl("chbxSelectMRR");

                        if (chbxSelectMRR.Checked)
                        {
                            compositeMRRID += lblMaterialReceiveIDLV.Text + ",";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            if (compositeMRRID == String.Empty)
            {
                MiscUtil.ShowMessage(lblMessage, "Please Select At Least One Requisition", true);
            }
            else if (compositeMRRID.IsNotNullOrEmpty())
            {
                compositeMRRID = compositeMRRID.Substring(0, compositeMRRID.Length - 1);

                fe_materialReceiveItem = "PRMMaterialReceive.MaterialReceiveID in(" + compositeMRRID + ")";
            }

            return fe_materialReceiveItem;
        }

        private void PrepareEditView()
        {
            if (CMBillID > 0)
            {
                _BillID = CMBillID;

                if (CurrentCMBillEntity != null)
                {
                    if (CurrentCMBillEntity.BillApprovalStatusID != MasterDataConstants.BillApprovalStatus.INITIATED)
                    {
                        
                    }
                }
            }

            CMBillEntity cMBillEntity = CurrentCMBillEntity;


            if (!cMBillEntity.IsNew)
            {

                if (ddlProjectID.Items.Count > 0 && cMBillEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cMBillEntity.ProjectID.ToString();
                }

                txtBillNo.Text = cMBillEntity.BillNo.ToString();

                if (ddlVendorCategoryID.Items.Count > 0 && cMBillEntity.VendorCategory != null)
                {
                    ddlVendorCategoryID.SelectedValue = cMBillEntity.VendorCategory.ToString();
                }

                BuildVendorByVendorCategory();

                if (ddlVendorID.Items.Count > 0 && cMBillEntity.Vendor != null)
                {
                    ddlVendorID.SelectedValue = cMBillEntity.Vendor.ToString();
                }

                BuildWOByVendor();

                if (ddlWorkOrderID.Items.Count > 0 && cMBillEntity.WorkOrderID != null)
                {
                    ddlWorkOrderID.SelectedValue = cMBillEntity.WorkOrderID.ToString();
                }
                txtBillDate.Text = cMBillEntity.BillDate.ToStringDefault();
                txtAmount.Text = cMBillEntity.Amount.ToString();
                txtRemarks.Text = cMBillEntity.Remarks.ToString();
                if (ddlBillStatusID.Items.Count > 0 && cMBillEntity.BillStatusID != null)
                {
                    ddlBillStatusID.SelectedValue = cMBillEntity.BillStatusID.ToString();
                }

                if (ddlBillApprovalStatusID.Items.Count > 0 && cMBillEntity.BillApprovalStatusID != null)
                {
                    ddlBillApprovalStatusID.SelectedValue = cMBillEntity.BillApprovalStatusID.ToString();
                }

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMBillList();
        }

        private void BindCMBillList()
        {
            lvCMBill.DataBind();
        }

        private void BindCMMeasurementBookList()
        {
            lvCMMeasurementBook.DataBind();
        }

        private CMBillEntity BuildCMBillEntity()
        {
            CMBillEntity cMBillEntity = CurrentCMBillEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            cMBillEntity.BillNo = txtBillNo.Text.Trim();

            if (ddlVendorCategoryID.Items.Count > 0)
            {
                if (ddlVendorCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.VendorCategory = Int64.Parse(ddlVendorCategoryID.SelectedValue);
                }
            }

            if (ddlVendorID.Items.Count > 0)
            {
                if (ddlVendorID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.Vendor = Int64.Parse(ddlVendorID.SelectedValue);
                }
            }

            if (ddlWorkOrderID.Items.Count > 0)
            {
                if (ddlWorkOrderID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.WorkOrderID = Int64.Parse(ddlWorkOrderID.SelectedValue);
                }
            }

            cMBillEntity.CreateDate = MiscUtil.ParseToDateTime(System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT));

            if (txtBillDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMBillEntity.BillDate = MiscUtil.ParseToDateTime(txtBillDate.Text);
            }
            if (!txtTax.Text.Trim().IsNullOrEmpty())
            {
                cMBillEntity.Tax = Decimal.Parse(txtTax.Text.Trim());
            }
            if (!txtVat.Text.Trim().IsNullOrEmpty())
            {
                cMBillEntity.Vat = Decimal.Parse(txtVat.Text.Trim());
            }
            if (!txtCarryingCharge.Text.Trim().IsNullOrEmpty())
            {
                cMBillEntity.CarryingCharge = Decimal.Parse(txtCarryingCharge.Text.Trim());
            }
            if (!txtDiscountAddition.Text.Trim().IsNullOrEmpty())
            {
                cMBillEntity.DiscountAddition = Decimal.Parse(txtDiscountAddition.Text.Trim());
            }

            if (!txtAmount.Text.Trim().IsNullOrEmpty())
            {
                CalculateNetAmount();
                cMBillEntity.Amount = Decimal.Parse(txtAmount.Text.Trim());
            }

            if (ddlBillStatusID.Items.Count > 0)
            {
                if (ddlBillStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.BillStatusID = Int64.Parse(ddlBillStatusID.SelectedValue);
                }
            }
            cMBillEntity.Remarks = txtRemarks.Text.Trim();

            if (ddlBillApprovalStatusID.Items.Count > 0)
            {
                if (ddlBillApprovalStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cMBillEntity.BillApprovalStatusID = Int64.Parse(ddlBillApprovalStatusID.SelectedValue);
                }
            }

            return cMBillEntity;
        }

        private void SaveCMBillEntity()
        {
            if (ValidationInput())
            {
                if (IsValid)
                {
                    try
                    {
                        CMBillEntity cMBillEntity = BuildCMBillEntity();

                        Int64 result = -1;

                        if (cMBillEntity.IsNew)
                        {
                            result = FCCCMBill.GetFacadeCreate().Add(cMBillEntity, DatabaseOperationType.Add, TransactionRequired.No);
                        }
                        else
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillID, cMBillEntity.BillID.ToString(), SQLMatchType.Equal);
                            result = FCCCMBill.GetFacadeCreate().Update(cMBillEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                        }

                        if (result > 0)
                        {

                            #region Update WO Final Bill Status

                            if (cMBillEntity.BillStatusID == MasterDataConstants.MDBillStatus.FINAL_BILL)
                            {
                                PRMWorkOrderEntity prmWorkOrderEntity = FCCPRMWorkOrder.GetFacadeCreate().GetByID(cMBillEntity.WorkOrderID);
                                prmWorkOrderEntity.IsFinalBilled = true;

                                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderID, prmWorkOrderEntity.WorkOrderID.ToString(), SQLMatchType.Equal);

                                FCCPRMWorkOrder.GetFacadeCreate().Update(prmWorkOrderEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                            }

                            #endregion

                            #region Bill Material Receive

                            CMBillMaterialReceiveMeasurementBookMapEntity cmBillMaterialReceiveMeasurementBookMapEntity = new CMBillMaterialReceiveMeasurementBookMapEntity();


                            try
                            {
                                IList<ListViewDataItem> list = lvPRMMaterialReceiveItemMap.Items;

                                if (list != null && list.Count > 0)
                                {
                                    foreach (ListViewDataItem lvdi in list)
                                    {
                                        Decimal billPriceLV;
                                        TextBox txtBillPriceLV = (TextBox)lvdi.FindControl("txtBillPriceLV");
                                        Decimal.TryParse(txtBillPriceLV.Text.Trim(), out billPriceLV);

                                        if (billPriceLV > 0)
                                        {
                                            Label lblMaterialReceiveIDLV = (Label)lvdi.FindControl("lblMaterialReceiveIDLV");
                                            Label lblMaterialReceiveItemMapIDLV = (Label)lvdi.FindControl("lblMaterialReceiveItemMapIDLV");

                                            cmBillMaterialReceiveMeasurementBookMapEntity.BillID = result;
                                            cmBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveID = Int64.Parse(lblMaterialReceiveIDLV.Text);
                                            cmBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveItemMapID = Int64.Parse(lblMaterialReceiveItemMapIDLV.Text);
                                            cmBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookID = null;
                                            cmBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookDetailID = null;

                                            if (billPriceLV > 0)
                                            {
                                                cmBillMaterialReceiveMeasurementBookMapEntity.BillPrice = Decimal.Parse(txtBillPriceLV.Text.Trim());
                                            }

                                            Int64 result_one = FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().Add(cmBillMaterialReceiveMeasurementBookMapEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                            #region Update MRR Price

                                            if (result_one > 0)
                                            {   
                                                PRMMaterialReceiveItemMapEntity pRMMaterialReceiveItemMapEntity=FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetByID(Int64.Parse(cmBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveItemMapID.ToString()));

                                                if(pRMMaterialReceiveItemMapEntity!=null && pRMMaterialReceiveItemMapEntity.MaterialReceiveItemMapID>0)
                                                {
                                                    String fe_woItemMap=SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_RequisitionItemID,pRMMaterialReceiveItemMapEntity.RequisitionItemID.ToString(),SQLMatchType.Equal);
                                                    IList<PRMWorkOrderItemMapEntity> lstPRMWorkOrderItemMapEntity=FCCPRMWorkOrderItemMap.GetFacadeCreate().GetIL(null,null,String.Empty,fe_woItemMap,DatabaseOperationType.LoadWithFilterExpression);

                                                    if(lstPRMWorkOrderItemMapEntity!=null && lstPRMWorkOrderItemMapEntity.Count>0)
                                                    {
                                                        String fe_woItemFloor = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemFloorDetailEntity.FLD_NAME_WorkOrderItemMapID, lstPRMWorkOrderItemMapEntity[0].WorkOrderItemMapID.ToString(), SQLMatchType.Equal);
                                                        IList<PRMWorkOrderItemFloorDetailEntity> lstPRMWorkOrderItemFloorDetailEntity = FCCPRMWorkOrderItemFloorDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_woItemFloor, DatabaseOperationType.LoadWithFilterExpression);

                                                        if (lstPRMWorkOrderItemFloorDetailEntity != null && lstPRMWorkOrderItemFloorDetailEntity.Count > 0)
                                                        {
                                                            foreach (PRMWorkOrderItemFloorDetailEntity ent in lstPRMWorkOrderItemFloorDetailEntity)
                                                            {
                                                                CMBillFloorDetailEntity cMBillFloorDetailEntity = new CMBillFloorDetailEntity();
                                                                cMBillFloorDetailEntity.BillFloorDetailCategoryID = MasterDataConstants.CMMDBillBillFloorDetailCategory.MRR;
                                                                cMBillFloorDetailEntity.BillID = result;
                                                                cMBillFloorDetailEntity.EntryDate = System.DateTime.Now;
                                                                cMBillFloorDetailEntity.ProjectFloorID = ent.ProjectFloorID;
                                                                cMBillFloorDetailEntity.ProjectFloorUnitID = ent.ProjectFloorUnitID;
                                                                cMBillFloorDetailEntity.FloorBillAmount = ent.Qty * ent.Rate;
                                                                cMBillFloorDetailEntity.Remarks = null;

                                                                FCCCMBillFloorDetail.GetFacadeCreate().Add(cMBillFloorDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                                            }
                                                        }
                                                    }
                                                }

                                                PRMMaterialReceiveItemMapEntity prmMaterialReceiveItemMapEntity = FCCPRMMaterialReceiveItemMap.GetFacadeCreate().GetByID(Int64.Parse(lblMaterialReceiveItemMapIDLV.Text));
                                                prmMaterialReceiveItemMapEntity.WOItemTotalRate = billPriceLV;
                                                String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveItemMapEntity.FLD_NAME_MaterialReceiveItemMapID, lblMaterialReceiveItemMapIDLV.Text, SQLMatchType.Equal);
                                                FCCPRMMaterialReceiveItemMap.GetFacadeCreate().Update(prmMaterialReceiveItemMapEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                                            }
                                             
                                            #endregion
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                            

                            #endregion

                            #region Bill Measurement Book

                            CMBillMaterialReceiveMeasurementBookMapEntity cmBillMeasurementBookMapEntity = new CMBillMaterialReceiveMeasurementBookMapEntity();


                            try
                            {
                                IList<ListViewDataItem> list = lvCMMeasurementBook.Items;

                                if (list != null && list.Count > 0)
                                {
                                    foreach (ListViewDataItem lvdi in list)
                                    {   
                                        CheckBox chbxSelectMeasurementBook = (CheckBox)lvdi.FindControl("chbxSelectMeasurementBook");

                                        if (chbxSelectMeasurementBook.Checked)
                                        {
                                            Label lblMaterialReceiveIDLV = (Label)lvdi.FindControl("lblMeasurementBookIDLV");

                                            cmBillMeasurementBookMapEntity.BillID = result;
                                            cmBillMeasurementBookMapEntity.MaterialReceiveID = null;
                                            cmBillMeasurementBookMapEntity.MaterialReceiveItemMapID = null;
                                            cmBillMeasurementBookMapEntity.MeasurementBookID = Int64.Parse(lblMaterialReceiveIDLV.Text);
                                            cmBillMeasurementBookMapEntity.MeasurementBookDetailID = null;
                                            
                                            FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().Add(cmBillMeasurementBookMapEntity, DatabaseOperationType.Add, TransactionRequired.No);

                                            CMMeasurementBookEntity cMMeasurementBookEntity = FCCCMMeasurementBook.GetFacadeCreate().GetByID(Int64.Parse(cmBillMeasurementBookMapEntity.MeasurementBookID.ToString()));

                                            if (cMMeasurementBookEntity != null && cMMeasurementBookEntity.ProjectFloorID > 0)
                                            {
                                                CMBillFloorDetailEntity cMBillFloorDetailEntity = new CMBillFloorDetailEntity();
                                                cMBillFloorDetailEntity.BillFloorDetailCategoryID = MasterDataConstants.CMMDBillBillFloorDetailCategory.MB;
                                                cMBillFloorDetailEntity.BillID = result;
                                                cMBillFloorDetailEntity.EntryDate = System.DateTime.Now;

                                                Int64 projectFloorID, projectFloorUnitID;
                                                Int64.TryParse(cMMeasurementBookEntity.ProjectFloorID.ToString(), out projectFloorID);
                                                Int64.TryParse(cMMeasurementBookEntity.ProjectFloorUnitID.ToString(), out projectFloorUnitID);

                                                    if(projectFloorID>0)
                                                    {
                                                        cMBillFloorDetailEntity.ProjectFloorID = projectFloorID;
                                                    }
                                                    if (projectFloorUnitID > 0)
                                                    {
                                                        cMBillFloorDetailEntity.ProjectFloorUnitID = projectFloorUnitID;
                                                    }
                                                    else
                                                    {
                                                        cMBillFloorDetailEntity.ProjectFloorUnitID = null;
                                                    }

                                                cMBillFloorDetailEntity.FloorBillAmount = 0;//need to change here. will discuss with rayan vaiya.

                                                cMBillFloorDetailEntity.Remarks = null;

                                                FCCCMBillFloorDetail.GetFacadeCreate().Add(cMBillFloorDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                                            }
                                            
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {

                            }

                            #endregion

                            CMBillEntity _cMBillEntity = CurrentCMBillEntity;
                            _BillID = 0;
                            _CMBillEntity = new CMBillEntity();
                            PrepareInitialView();
                            BindCMBillList();

                            if (cMBillEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bill Information has been added successfully.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Bill Information has been updated successfully.", false);
                            }

                            String NavUrl = UrlHelper.BuildSecureUrl("~/CM/CMBillUploadInfo.aspx", string.Empty, UrlConstants.OVERVIEW_CM_BILL_ID, result.ToString()).ToString();
                            Response.Redirect(NavUrl);
                        }
                        else
                        {
                            if (cMBillEntity.IsNew)
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to add Bill Information.", false);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to update Bill Information.", false);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
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

        protected void lvREQRequisitionItemFloorDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                CheckBox chbxSelectLV = (CheckBox)e.Item.FindControl("chbxSelectLV");
                Label lblProjectFloorIDLV = (Label)e.Item.FindControl("lblProjectFloorIDLV");
                TextBox txtQtyLV = (TextBox)e.Item.FindControl("txtQtyLV");
                TextBox txtRateLV = (TextBox)e.Item.FindControl("txtRateLV");
                TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");


                if (CurrentPRMWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.APPROVED)
                {
                    chbxSelectLV.Enabled = false;
                }


                IList<PRMWorkOrderItemFloorDetailEntity> lst = PRMWorkOrderItemFloorDetailEntityList;

                if (lst != null && lst.Count > 0)
                {
                    var result = (from s in lst
                                  where s.ProjectFloorID.ToString() == lblProjectFloorIDLV.Text.Trim()
                                  select s).FirstOrDefault();

                    if (result != null)
                    {
                        chbxSelectLV.Checked = true;
                        txtQtyLV.Text = result.Qty.ToString();
                        txtRateLV.Text = result.Rate.ToString();
                        txtRemarksLV.Text = result.Remarks;
                    }
                    else
                    {
                        chbxSelectLV.Checked = false;
                    }
                }

                else
                {
                    chbxSelectLV.Checked = false;
                }
            }
        }

        protected void lvPRMMaterialReceiveItemMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MaterialReceiveItemMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out MaterialReceiveItemMapID);

            if (e.CommandName == "FloorWiseRateAndQty")
            {
                CurrentWorkOrderItemIDPopup = MaterialReceiveItemMapID;

                Label lblItemLV = (Label)e.Item.FindControl("lblItemLV");
                Label lblRequisitionIDLV = (Label)e.Item.FindControl("lblRequisitionIDLV");
                Label lblRequisitionItemIDLV = (Label)e.Item.FindControl("lblRequisitionItemIDLV");
                Label lblWorkOrderItemMapIDLV = (Label)e.Item.FindControl("lblWorkOrderItemMapIDLV");

                Label lblProjectIDLV = (Label)e.Item.FindControl("lblProjectIDLV");
                Label lblWorkOrderIDLV = (Label)e.Item.FindControl("lblWorkOrderIDLV");

                Int64 itemID;
                Int64.TryParse(lblItemLV.Text.Trim(), out itemID);

                String fe_floor = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorEntity.FLD_NAME_ProjectID, lblProjectIDLV.Text.ToString(), SQLMatchType.Equal);
                IList<BDProjectFloorEntity> lstBDProjectFloor = FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, String.Empty, fe_floor, DatabaseOperationType.LoadWithFilterExpression);

                if (lstBDProjectFloor != null && lstBDProjectFloor.Count > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, lblProjectIDLV.Text.ToString(), SQLMatchType.Equal);
                    IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (preBOQList != null && preBOQList.Count > 0)
                    {
                        Int64 preBOQID = preBOQList[0].PreBOQID;

                        switch (preBOQList[0].IsLocked)
                        {
                            case true:

                                #region GET Item From BOQ

                                String fe_boq = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                                IList<PRMBOQEntity> lstPRMBOQ = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe_boq, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstPRMBOQ != null && lstPRMBOQ.Count > 0)
                                {
                                    String fe_BOQDetail1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_BOQID, lstPRMBOQ[0].BOQID.ToString(), SQLMatchType.Equal);
                                    String fe_BOQDetail2 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetailEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);

                                    String fe_BOQDetail = SqlExpressionBuilder.PrepareFilterExpression(fe_BOQDetail1, SQLJoinType.AND, fe_BOQDetail2);

                                    IList<PRMBOQDetailEntity> lstPRMBOQDetail = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_BOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                                    if (lstPRMBOQDetail != null && lstPRMBOQDetail.Count > 0)
                                    {
                                        String fe_floorDetail = SqlExpressionBuilder.PrepareFilterExpression("PRMBOQFloorDetail." + PRMBOQFloorDetailEntity.FLD_NAME_BOQDetailID, lstPRMBOQDetail[0].BOQDetailID.ToString(), SQLMatchType.Equal);
                                        IList<PRMBOQFloorDetail_DetailedEntity> lstPRMPreBOQFloorDetail = FCCPRMBOQFloorDetail_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe_floorDetail);

                                        lvREQRequisitionItemFloorDetail.DataSource = lstPRMPreBOQFloorDetail;
                                        lvREQRequisitionItemFloorDetail.DataBind();
                                    }
                                }

                                #endregion

                                break;

                            case false:

                                #region Get Item From Pre-BOQ

                                String fe_preBOQDetail1 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                                String fe_preBOQDetail2 = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQDetailEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);

                                String fe_preBOQDetail = SqlExpressionBuilder.PrepareFilterExpression(fe_preBOQDetail1, SQLJoinType.AND, fe_preBOQDetail2);

                                IList<PRMPreBOQDetailEntity> lstPRMPreBOQDetail = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, String.Empty, fe_preBOQDetail, DatabaseOperationType.LoadWithFilterExpression);

                                if (lstPRMPreBOQDetail != null && lstPRMPreBOQDetail.Count > 0)
                                {
                                    String fe_floorDetail = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQFloorDetail." + PRMPreBOQFloorDetailEntity.FLD_NAME_PreBOQDetailID, lstPRMPreBOQDetail[0].PreBOQDetailID.ToString(), SQLMatchType.Equal);
                                    IList<PRMPreBOQFloorDetail_DetailedEntity> lstPRMPreBOQFloorDetail = FCCPRMPreBOQFloorDetail_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe_floorDetail);

                                    lvREQRequisitionItemFloorDetail.DataSource = lstPRMPreBOQFloorDetail;
                                    lvREQRequisitionItemFloorDetail.DataBind();
                                }

                                #endregion

                                break;

                            default:
                                break;
                        }
                    }
                }

                Label lblItemNameLV = (Label)e.Item.FindControl("lblItemNameLV");

                //BindREQRequisitionFloorDetailList();
                //lblFloorWiseItemName.Text = lblItemNameLV.Text.ToString();
                this.ModalPopupExtender2.Show();

                if (lvREQRequisitionItemFloorDetail.DataSource != null)
                {
                    btnFloorPopupSave.Enabled = true;
                }
                else
                {
                    btnFloorPopupSave.Enabled = false;
                }

                if (CurrentPRMWorkOrderEntity.WorkOrderStatusID != MasterDataConstants.WorkOrderStatus.APPROVED)
                {
                    lblLockMessage.Visible = false;
                }

                else if (CurrentPRMWorkOrderEntity.WorkOrderStatusID == MasterDataConstants.WorkOrderStatus.APPROVED)
                {
                    btnFloorPopupSave.Enabled = false;
                    lblLockMessage.Visible = true;
                }
            }
        }

        protected void lvREQRequisition_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                REQRequisition_DetailedEntity ent = (REQRequisition_DetailedEntity)dataItem.DataItem;

                HyperLink hypRequisition = (HyperLink)e.Item.FindControl("hypRequisition");
                Label lblRequisitionItem = (Label)e.Item.FindControl("lblRequisitionItem");

                hypRequisition.NavigateUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionItem.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, ent.ProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo, ent.RequisitionNo.ToString()).ToString();

                String feReqItem = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), SQLMatchType.Equal);
                IList<REQRequisitionItem_DetailedEntity> lst = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, feReqItem);

                if (lst != null && lst.Count > 0)
                {
                    foreach (REQRequisitionItem_DetailedEntity entREQRequisitionItem_DetailedEntity in lst)
                    {
                        lblRequisitionItem.Text += entREQRequisitionItem_DetailedEntity.MDItemItemName + ", ";
                    }

                    lblRequisitionItem.Text = lblRequisitionItem.Text.Substring(0, lblRequisitionItem.Text.Length - 2);
                }

                hypRequisition.Target = "_blank";
            }
        }

        protected void lvCMMeasurementBook_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMMeasurementBook_DetailedEntity ent = (CMMeasurementBook_DetailedEntity)dataItem.DataItem;
                HyperLink hypItem = (HyperLink)e.Item.FindControl("hypItem");

                hypItem.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMMeasurementBookDetail.aspx", string.Empty, UrlConstants.OVERVIEW_CM_MEASUREMENT_BOOK_ID, ent.MeasurementBookID.ToString(), UrlConstants.OVERVIEW_CM_BILL_NO, ent.BillNo, UrlConstants.OVERVIEW_PRM_WORK_ORDER_NO, ent.WorkOrderNo, UrlConstants.OVERVIEW_MD_ITEM_NAME, ent.ItemName).ToString();
                hypItem.Target = "_blank";
            }
        }

        protected void lvCMBill_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMBill_DetailedEntity ent = (CMBill_DetailedEntity)dataItem.DataItem;
                HyperLink hypUploadInfo = (HyperLink)e.Item.FindControl("hypUploadInfo");

                //if (ent.BillStatusID == MasterDataConstants.MDBillStatus.FINAL_BILL)
                //{
                //    LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                //    LinkButton lnkBtnDelete = (LinkButton)e.Item.FindControl("lnkBtnDelete");

                //    lnkBtnEdit.Enabled = false;
                //    lnkBtnDelete.Enabled = false;
                //    lnkBtnEdit.ToolTip = "Final Bill Submitted. Can't be Modified!!!";
                //    lnkBtnDelete.ToolTip = "Final Bill Submitted. Can't be Modified!!!";
                //}

                hypUploadInfo.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMBillUploadInfo.aspx", string.Empty, UrlConstants.OVERVIEW_CM_BILL_ID, ent.BillID.ToString()).ToString();
                hypUploadInfo.Target = "_blank";
            }
        }

        protected void lvPRMMaterialReceive_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMMaterialReceive_DetailedEntity ent = (PRMMaterialReceive_DetailedEntity)dataItem.DataItem;
                HyperLink hypMRRNo = (HyperLink)e.Item.FindControl("hypMRRNo");
                hypMRRNo.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMMaterialReceiveItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, ent.MaterialReceiveID.ToString()).ToString();
                hypMRRNo.Target = "_blank";
            }
        }

        protected void lvCMBill_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BillID;

            Int64.TryParse(e.CommandArgument.ToString(), out BillID);

            if (BillID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BillID = BillID;

                    PrepareEditView();

                    if (CurrentCMBillEntity != null)
                    {
                        if (CurrentCMBillEntity.BillApprovalStatusID != MasterDataConstants.BillApprovalStatus.INITIATED)
                        {
                           
                        }
                    }
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillID, BillID.ToString(), SQLMatchType.Equal);

                        CMBillEntity cMBillEntity = new CMBillEntity();


                        result = FCCCMBill.GetFacadeCreate().Delete(cMBillEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BillID = 0;
                            _CMBillEntity = new CMBillEntity();
                            PrepareInitialView();
                            BindCMBillList();

                            MiscUtil.ShowMessage(lblMessage, "Bill has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Bill.", true);
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

        protected void odsCMBill_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region ObjectDataSource Event(Material Receive)

        protected void odsPRMMaterialReceive_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveApprovalStatusID, MasterDataConstants.MDMaterialReceiveApprovalStatus.APPROVED.ToString(), SQLMatchType.Equal);

            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                if (ddlWorkOrderID == null || ddlWorkOrderID.SelectedValue == MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
                {
                    fe = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive." + PRMMaterialReceiveEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                }
            }

            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive." + PRMMaterialReceiveEntity.FLD_NAME_WorkOrderID, ddlWorkOrderID.SelectedValue.ToString(), SQLMatchType.Equal);
            }

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive.MRRNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ObjectDataSource Event(Material Receive Item Map)

        protected void odsPRMMaterialReceiveItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive." + PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveID, "0", SQLMatchType.Equal);

            if (chbxShowRequisitionItem.Checked)
            {
                String fe1 = GetFilterExpression();
                if (fe1 != String.Empty)
                {
                    fe = fe1;
                }
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ObjectDataSource Event(Measurement Book)

        protected void odsCMMeasurementBook_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMMeasurementBook." + CMMeasurementBookEntity.FLD_NAME_MeasurementBookID, "0", SQLMatchType.Equal);

            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                if (ddlWorkOrderID == null || ddlWorkOrderID.SelectedValue == MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
                {
                    fe = SqlExpressionBuilder.PrepareFilterExpression("CMMeasurementBook."+ CMMeasurementBookEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);
                }
            }

            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("CMMeasurementBook." + CMMeasurementBookEntity.FLD_NAME_WorkOrderID, ddlWorkOrderID.SelectedValue.ToString(), SQLMatchType.Equal);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMBillEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BillID = 0;
            _CMBillEntity = new CMBillEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void lnkbtnCalculate_Click(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        #endregion

        #region DropDownList Event

        protected void ddlVendorCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildVendorByVendorCategory();
            BuildVendorWOByVendorCategory();
        }

        protected void ddlVendorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildVendorWOByVendorCategory();
        }

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
            {
                ddlWorkOrderID.SelectedValue = MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString();
            }

            BindPRMMaterialReceiveList();
            BindCMMeasurementBookList();

            if (chbxShowRequisitionItem.Checked)
            {
                chbxShowRequisitionItem.Checked = false;
                BindMaterialReceiveItemList();
            }
        }

        protected void ddlWorkOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindPRMMaterialReceiveList();
            BindCMMeasurementBookList();

            if (ddlWorkOrderID == null && ddlWorkOrderID.SelectedValue == MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
            {
                chbxShowRequisitionItem.Checked = false;
            }

            if (ddlWorkOrderID != null && ddlWorkOrderID.SelectedValue != MasterDataConstants.ItemDefaults.DEFAULT_WORKORDER.ToString())
            {
                String navUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.WORK_ORDER_REPORT, UrlConstants.OVERVIEW_WORKORDER_ID, ddlWorkOrderID.SelectedValue.ToString()).ToString();
                hypWorkOrder.NavigateUrl = navUrl;
            }
            else
            {
                hypWorkOrder.NavigateUrl = String.Empty;
            }

            if (chbxShowRequisitionItem.Checked)
            {
                chbxShowRequisitionItem.Checked = false;
                BindMaterialReceiveItemList();
            }
        }

        #endregion

        #region Check Box Event

        protected void chbxFinalBilled_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxFinalBilled.Checked == false)
            {
                BuildWOExceptFinalBillByVendor();
            }

            else if (chbxFinalBilled.Checked == true)
            {
                BuildWOByVendor();
            }
        }

        protected void chbxShowRequisitionItem_CheckedChanged(object sender, EventArgs e)
        {
            //if (chbxShowRequisitionItem.Checked)
            //{
                BindMaterialReceiveItemList();
            //}
            //else
            //{
            //    BindMaterialReceiveItemList();
            //}
        }

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindPRMMaterialReceiveList();
        }

        #endregion

        #endregion Event
    }
}