// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Oct-2012, 01:19:13




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
    public partial class CMMeasurementBookDetailControl : BaseControl
    {       
        #region Properties

        public Int64 _MeasurementBookDetailID
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

        public CMMeasurementBookDetailEntity _CMMeasurementBookDetailEntity
        {
            get
            {
                CMMeasurementBookDetailEntity entity = new CMMeasurementBookDetailEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMMeasurementBookDetailEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMMeasurementBookDetailEntity CurrentCMMeasurementBookDetailEntity
        {
            get
            {
                if (_MeasurementBookDetailID > 0)
                {
                    if (_CMMeasurementBookDetailEntity.MeasurementBookDetailID != _MeasurementBookDetailID)
                    {
                        _CMMeasurementBookDetailEntity = FCCCMMeasurementBookDetail.GetFacadeCreate().GetByID(_MeasurementBookDetailID);
                    }
                }

                return _CMMeasurementBookDetailEntity;
            }
            set
            {
                _CMMeasurementBookDetailEntity = value;
            }
        }

        public Int64 CMMeasurementBookID
        {
            get
            {
                Int64 cMMeasurementBookID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_MEASUREMENT_BOOK_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_MEASUREMENT_BOOK_ID], out cMMeasurementBookID);
                }

                return cMMeasurementBookID;
            }
        }

        public String MDItemName
        {
            get
            {
                String itemName = null;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MD_ITEM_NAME]))
                {
                    itemName = Helper.Url.SecureUrl[UrlConstants.OVERVIEW_MD_ITEM_NAME];
                }

                return itemName;
            }
        }

        public String CMBillNo
        {
            get
            {
                String cmBillNo = null;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_NO]))
                {
                    cmBillNo = Helper.Url.SecureUrl[UrlConstants.OVERVIEW_CM_BILL_NO];
                }

                return cmBillNo;
            }
        }

        public String PRMWorkOrder
        {
            get
            {
                String prmWorkOrder = null;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRM_WORK_ORDER_NO]))
                {
                    prmWorkOrder = Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PRM_WORK_ORDER_NO];
                }

                return prmWorkOrder;
            }
        }

        private CMMeasurementBookEntity CurrentCMMeasurementBook_DetailedEntity
        {
            get
            {
                CMMeasurementBookEntity _cmMeasurementBook;

                if (CMMeasurementBookID > 0)
                {
                    _cmMeasurementBook = FCCCMMeasurementBook.GetFacadeCreate().GetByID(CMMeasurementBookID);
                }

                else
                {
                    _cmMeasurementBook = new CMMeasurementBookEntity();
                }

                return _cmMeasurementBook;
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

            if (CMBillNo != null)
            {
                lblBillNo.Text = CMBillNo.ToString();
            }
            else
            {
                lblBillNo.Text = "N/A";
            }

            if (PRMWorkOrder != null)
            {
                lblWorkOrder.Text = PRMWorkOrder.ToString();
            }
            else
            {
                lblWorkOrder.Text = "N/A";
            }

            MiscUtil.PopulateBDProjectFloorByProject(ddlProjectFloorID, true,CurrentCMMeasurementBook_DetailedEntity.ProjectID);

            if (CurrentCMMeasurementBook_DetailedEntity.ProjectFloorID > 0)
            {
                ddlProjectFloorID.SelectedValue = CurrentCMMeasurementBook_DetailedEntity.ProjectFloorID.ToString();
            }

            lblItemName.Text = MDItemName.ToString();
        }

        private void PrepareEditView()
        {   
        }

        private void BindList()
        {
            BindCMMeasurementBookDetailList();
        }

        private void BindCMMeasurementBookDetailList()
        {
            lvCMMeasurementBookDetail.DataBind();
        }

        private void SaveCMMeasurementBookDetailEntityLV()
        {
            try
            {
                UpdateMeasurementBookFloorInfo();

                ListViewItem list = lvCMMeasurementBookDetail.InsertItem;

                TextBox txtDescriptionLV = (TextBox)list.FindControl("txtDescriptionLV");
                TextBox txtLengthftLV = (TextBox)list.FindControl("txtLengthftLV");
                TextBox txtLenghtinLV = (TextBox)list.FindControl("txtLenghtinLV");
                TextBox txtWidthinLV = (TextBox)list.FindControl("txtWidthinLV");
                TextBox txtWidthftLV = (TextBox)list.FindControl("txtWidthftLV");
                TextBox txtHeightftLV = (TextBox)list.FindControl("txtHeightftLV");
                TextBox txtHeightinLV = (TextBox)list.FindControl("txtHeightinLV");
                TextBox txtNosLV = (TextBox)list.FindControl("txtNosLV");
                DropDownList ddlUnitIDInsert = (DropDownList)list.FindControl("ddlUnitIDInsert");

                Decimal LengthftLV, LengthinLV, WidthftLV, WidthinLV, HeightftLV, HeightinLV, NosLV;

                Decimal.TryParse(txtLengthftLV.Text.Trim(), out LengthftLV);
                Decimal.TryParse(txtLenghtinLV.Text.Trim(), out LengthinLV);
                Decimal.TryParse(txtWidthinLV.Text.Trim(), out WidthftLV);
                Decimal.TryParse(txtWidthftLV.Text.Trim(), out WidthinLV);
                Decimal.TryParse(txtHeightftLV.Text.Trim(), out HeightftLV);
                Decimal.TryParse(txtHeightinLV.Text.Trim(), out HeightinLV);
                Decimal.TryParse(txtNosLV.Text.Trim(), out NosLV);

                CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity = new CMMeasurementBookDetailEntity();

                cMMeasurementBookDetailEntity.Description = txtDescriptionLV.Text.ToString();

                if (!txtLengthftLV.Text.Trim().IsNullOrEmpty())
                {
                    cMMeasurementBookDetailEntity.Lengthft = LengthftLV;
                }
                else
                {
                    cMMeasurementBookDetailEntity.Lengthft = null;
                }

                if (!txtLenghtinLV.Text.Trim().IsNullOrEmpty())
                {
                    cMMeasurementBookDetailEntity.Lenghtin = LengthinLV;
                }
                else
                {
                    cMMeasurementBookDetailEntity.Lenghtin = null;
                }

                if (!txtWidthftLV.Text.Trim().IsNullOrEmpty())
                {
                    cMMeasurementBookDetailEntity.Widthft = WidthftLV;
                }
                else
                {
                    cMMeasurementBookDetailEntity.Widthft = null;
                }

                if (!txtWidthinLV.Text.Trim().IsNullOrEmpty())
                {
                    cMMeasurementBookDetailEntity.Widthin = WidthinLV;
                }
                else
                {
                    cMMeasurementBookDetailEntity.Widthin = null;
                }

                if (!txtHeightftLV.Text.Trim().IsNullOrEmpty())
                {
                    cMMeasurementBookDetailEntity.Heightft = HeightftLV;
                }
                else
                {
                    cMMeasurementBookDetailEntity.Heightft = null;
                }

                if (!txtHeightinLV.Text.Trim().IsNullOrEmpty())
                {
                    cMMeasurementBookDetailEntity.Heightin = HeightinLV;
                }
                else
                {
                    cMMeasurementBookDetailEntity.Heightin = null;
                }

                cMMeasurementBookDetailEntity.MeasurementBookID = CMMeasurementBookID;

                LengthinLV = Math.Round(LengthinLV / 12, 2);
                WidthinLV = Math.Round(WidthinLV / 12, 2);
                HeightinLV = Math.Round(HeightinLV / 12, 2);
                Decimal QtyLV;

                QtyLV = (LengthftLV + LengthinLV) * (WidthftLV + WidthinLV) * NosLV;
                QtyLV = Math.Round(QtyLV, 4);

                cMMeasurementBookDetailEntity.UnitID = Int64.Parse(ddlUnitIDInsert.SelectedValue.ToString());
                cMMeasurementBookDetailEntity.Nos = NosLV;
                cMMeasurementBookDetailEntity.Qty = QtyLV;

                Int64 result = -1;

                result = FCCCMMeasurementBookDetail.GetFacadeCreate().Add(cMMeasurementBookDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);

                MiscUtil.ShowMessage(lblMessage, "Measurement Book Detail Information has been saved successfully.", false);
                BindCMMeasurementBookDetailList();
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to save Measurement Book Detail Information.", true);
            }
        }

        private void SaveAllCMMeasurementBookDetailListView()
        {
            UpdateMeasurementBookFloorInfo();

            try
            {
                IList<ListViewDataItem> list = lvCMMeasurementBookDetail.Items;

                if (list != null && list.Count > 0)
                {

                    foreach (ListViewDataItem lvdi in list)
                    {
                        TextBox txtlstDescription = (TextBox)lvdi.FindControl("txtlstDescription");
                        if (txtlstDescription.Enabled)
                        {

                            Label lbllstMeasurementBookID = (Label)lvdi.FindControl("lbllstMeasurementBookID");

                            TextBox txtlstLengthft = (TextBox)lvdi.FindControl("txtlstLengthft");
                            TextBox txtlstLengthin = (TextBox)lvdi.FindControl("txtlstLengthin");
                            TextBox txtlstWidthft = (TextBox)lvdi.FindControl("txtlstWidthft");
                            TextBox txtlstWidthin = (TextBox)lvdi.FindControl("txtlstWidthin");
                            TextBox txtlstHeightft = (TextBox)lvdi.FindControl("txtlstHeightft");
                            TextBox txtlstHeightin = (TextBox)lvdi.FindControl("txtlstHeightin");
                            TextBox txtlstNos = (TextBox)lvdi.FindControl("txtlstNos");
                            TextBox txtlstQty = (TextBox)lvdi.FindControl("txtlstQty");
                            DropDownList ddlUnitIDLV = (DropDownList)lvdi.FindControl("ddlUnitIDLV");

                            Decimal LengthftLV, LengthinLV, WidthftLV, WidthinLV, HeightftLV, HeightinLV, NosLV;

                            Decimal.TryParse(txtlstLengthft.Text.Trim(), out LengthftLV);
                            Decimal.TryParse(txtlstLengthin.Text.Trim(), out LengthinLV);
                            Decimal.TryParse(txtlstWidthft.Text.Trim(), out WidthftLV);
                            Decimal.TryParse(txtlstWidthin.Text.Trim(), out WidthinLV);
                            Decimal.TryParse(txtlstHeightft.Text.Trim(), out HeightftLV);
                            Decimal.TryParse(txtlstHeightin.Text.Trim(), out HeightinLV);
                            Decimal.TryParse(txtlstNos.Text.Trim(), out NosLV);

                            CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity = new CMMeasurementBookDetailEntity();

                            cMMeasurementBookDetailEntity.Description = txtlstDescription.Text.ToString();
                            cMMeasurementBookDetailEntity.Lengthft = LengthftLV;
                            cMMeasurementBookDetailEntity.Lenghtin = LengthinLV;
                            cMMeasurementBookDetailEntity.Widthft = WidthftLV;
                            cMMeasurementBookDetailEntity.Widthin = WidthinLV;
                            cMMeasurementBookDetailEntity.Heightft = HeightftLV;
                            cMMeasurementBookDetailEntity.Heightin = HeightinLV;
                            cMMeasurementBookDetailEntity.MeasurementBookID = CMMeasurementBookID;

                            LengthinLV = Math.Round(LengthinLV / 12, 2);
                            WidthinLV = Math.Round(WidthinLV / 12, 2);
                            HeightinLV = Math.Round(HeightinLV / 12, 2);
                            Decimal QtyLV;

                            QtyLV = (LengthftLV + LengthinLV) * (WidthftLV + WidthinLV) * NosLV;
                            QtyLV = Math.Round(QtyLV, 4);

                            if (ddlUnitIDLV != null && ddlUnitIDLV.SelectedValue != "0")
                            {
                                cMMeasurementBookDetailEntity.UnitID = Int64.Parse(ddlUnitIDLV.SelectedValue.ToString()); 
                            }
                            cMMeasurementBookDetailEntity.Nos = NosLV;
                            cMMeasurementBookDetailEntity.Qty = QtyLV;

                            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMMeasurementBookDetailEntity.FLD_NAME_MeasurementBookDetailID, lbllstMeasurementBookID.Text.ToString(), SQLMatchType.Equal);
                            FCCCMMeasurementBookDetail.GetFacadeCreate().Update(cMMeasurementBookDetailEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                        }
                    }
                }
                        BindCMMeasurementBookDetailList();
                        MiscUtil.ShowMessage(lblMessage, "Measurement Book Detail Information has been saved successfully.", false);
                }
            
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to save Measurment Book Detail Information.", true);
            }
        }

        private void UpdateMeasurementBookFloorInfo()
        {
            String fe_MeasurementBook = SqlExpressionBuilder.PrepareFilterExpression(CMMeasurementBookEntity.FLD_NAME_MeasurementBookID, CurrentCMMeasurementBook_DetailedEntity.MeasurementBookID.ToString(), SQLMatchType.Equal);
            CMMeasurementBookEntity cMMeasurementBookEntity = FCCCMMeasurementBook.GetFacadeCreate().GetByID(CurrentCMMeasurementBook_DetailedEntity.MeasurementBookID);

            if (cMMeasurementBookEntity != null && cMMeasurementBookEntity.MeasurementBookID > 0)
            {
                if (ddlProjectFloorID.SelectedValue != "0" && ddlProjectFloorID.Items.Count > 0)
                {
                    cMMeasurementBookEntity.ProjectFloorID = Int64.Parse(ddlProjectFloorID.SelectedValue);
                }
                else
                {
                    cMMeasurementBookEntity.ProjectFloorID = null;
                }

                FCCCMMeasurementBook.GetFacadeCreate().Update(cMMeasurementBookEntity, fe_MeasurementBook, DatabaseOperationType.Update, TransactionRequired.No);
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

        protected void lvCMMeasurementBookDetail_ItemCreated(object sender, ListViewItemEventArgs e)
        {
            if ((e.Item != null) && (e.Item.ItemType == ListViewItemType.InsertItem))
            {
                System.Web.UI.Control ddlUnitIDInsert = e.Item.FindControl("ddlUnitIDInsert");

                if (ddlUnitIDInsert != null)
                {
                    MiscUtil.PopulateMDUnit((DropDownList)ddlUnitIDInsert, false);
                }
            }
        }

        protected void lvCMMeasurementBookDetail_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;
                CMMeasurementBookDetail_DetailedEntity ent = (CMMeasurementBookDetail_DetailedEntity)dataItem.DataItem;
                DropDownList ddlUnitIDLV = (DropDownList)e.Item.FindControl("ddlUnitIDLV");
                
                MiscUtil.PopulateMDUnit(ddlUnitIDLV, false);

                if (ddlUnitIDLV != null && ddlUnitIDLV.Items.Count > 0)
                {
                    ddlUnitIDLV.SelectedValue = ent.UnitID.ToString();
                }
            }
        }

        protected void lvCMMeasurementBookDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MeasurementBookDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out MeasurementBookDetailID);

            if (MeasurementBookDetailID > 0)
            {
                LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                TextBox txtlstDescription = (TextBox)e.Item.FindControl("txtlstDescription");
                TextBox txtlstLengthft = (TextBox)e.Item.FindControl("txtlstLengthft");
                TextBox txtlstWidthft = (TextBox)e.Item.FindControl("txtlstWidthft");
                TextBox txtlstLengthin = (TextBox)e.Item.FindControl("txtlstLengthin");
                TextBox txtlstWidthin = (TextBox)e.Item.FindControl("txtlstWidthin");
                TextBox txtlstHeightft = (TextBox)e.Item.FindControl("txtlstHeightft");
                TextBox txtlstHeightin = (TextBox)e.Item.FindControl("txtlstHeightin");
                TextBox txtlstNos = (TextBox)e.Item.FindControl("txtlstNos");
                TextBox txtlstQty = (TextBox)e.Item.FindControl("txtlstQty");
                DropDownList ddlUnitIDLV = (DropDownList)e.Item.FindControl("ddlUnitIDLV");

                if (string.Equals(e.CommandName, "EditItem") && lnkBtnEdit.Text == "Cancel")
                {
                    txtlstDescription.Enabled = false;
                    txtlstLengthft.Enabled = false;
                    txtlstWidthft.Enabled = false;
                    txtlstLengthin.Enabled = false;
                    txtlstWidthin.Enabled = false;
                    txtlstHeightft.Enabled = false;
                    txtlstHeightin.Enabled = false;
                    txtlstNos.Enabled = false;
                    ddlUnitIDLV.Enabled = false;
                    
                    lnkBtnEdit.Text = "Edit";
                }

                else if (string.Equals(e.CommandName, "EditItem") && lnkBtnEdit.Text == "Edit")
                {
                    _MeasurementBookDetailID = MeasurementBookDetailID;
                 
                    txtlstDescription.Enabled = true;
                    txtlstLengthft.Enabled = true;
                    txtlstWidthft.Enabled = true;
                    txtlstLengthin.Enabled = true;
                    txtlstWidthin.Enabled = true;
                    txtlstHeightft.Enabled = true;
                    txtlstHeightin.Enabled = true;
                    txtlstNos.Enabled = true;
                    ddlUnitIDLV.Enabled = true;

                    lnkBtnEdit.Text = "Cancel";

                }

                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMMeasurementBookDetailEntity.FLD_NAME_MeasurementBookDetailID, MeasurementBookDetailID.ToString(), SQLMatchType.Equal);

                        CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity = new CMMeasurementBookDetailEntity();


                        result = FCCCMMeasurementBookDetail.GetFacadeCreate().Delete(cMMeasurementBookDetailEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MeasurementBookDetailID = 0;
                            _CMMeasurementBookDetailEntity = new CMMeasurementBookDetailEntity();
                            PrepareInitialView();
                            BindCMMeasurementBookDetailList();

                            MiscUtil.ShowMessage(lblMessage, "Measurement Book Detail has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Measurement Book Detail.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
            if (string.Equals(e.CommandName, "InsertItem"))
            {
                SaveCMMeasurementBookDetailEntityLV();
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsCMMeasurementBookDetail_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMMeasurementBookDetail." + CMMeasurementBookDetailEntity.FLD_NAME_MeasurementBookID, CMMeasurementBookID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SaveAllCMMeasurementBookDetailListView();
        }

        #endregion

        #endregion Event
    }
}
