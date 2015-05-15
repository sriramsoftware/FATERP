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
    public partial class SiteCMMeasurementBookDetailControl : BaseControl
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
            MiscUtil.PopulateMDUnit(ddlUnitID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDescription.Text = this.MDItemName.ToString();
            txtLengthft.Text = String.Empty;
            txtLenghtin.Text = String.Empty;
            txtWidthft.Text = String.Empty;
            txtWidthin.Text = String.Empty;
            txtHeightft.Text = String.Empty;
            txtHeightin.Text = String.Empty;
            txtNos.Text = String.Empty;

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

            lblItemName.Text = MDItemName.ToString();
            
            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity = CurrentCMMeasurementBookDetailEntity;


            if (!cMMeasurementBookDetailEntity.IsNew)
            {
                txtDescription.Text = cMMeasurementBookDetailEntity.Description.ToString();
                if (ddlUnitID.Items.Count > 0 && cMMeasurementBookDetailEntity.UnitID != null)
                {
                    ddlUnitID.SelectedValue = cMMeasurementBookDetailEntity.UnitID.ToString();
                }

                txtLengthft.Text = cMMeasurementBookDetailEntity.Lengthft.ToString();
                txtLenghtin.Text = cMMeasurementBookDetailEntity.Lenghtin.ToString();
                txtWidthft.Text = cMMeasurementBookDetailEntity.Widthft.ToString();
                txtWidthin.Text = cMMeasurementBookDetailEntity.Widthin.ToString();
                txtHeightft.Text = cMMeasurementBookDetailEntity.Heightft.ToString();
                txtHeightin.Text = cMMeasurementBookDetailEntity.Heightin.ToString();
                txtNos.Text = cMMeasurementBookDetailEntity.Nos.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMMeasurementBookDetailList();
        }

        private void BindCMMeasurementBookDetailList()
        {
            lvCMMeasurementBookDetail.DataBind();
        }

        private CMMeasurementBookDetailEntity BuildCMMeasurementBookDetailEntity()
        {
            CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity = CurrentCMMeasurementBookDetailEntity;

            cMMeasurementBookDetailEntity.MeasurementBookID = this.CMMeasurementBookID;
            
            cMMeasurementBookDetailEntity.Description = txtDescription.Text.Trim();
            if (ddlUnitID.Items.Count > 0)
            {
                if (ddlUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    cMMeasurementBookDetailEntity.UnitID = Int64.Parse(ddlUnitID.SelectedValue);
                }
            }

            if (!txtLengthft.Text.Trim().IsNullOrEmpty())
            {
                cMMeasurementBookDetailEntity.Lengthft = Decimal.Parse(txtLengthft.Text.Trim());
            }
            else
            {
                cMMeasurementBookDetailEntity.Lengthft = null;
            }

            if (!txtLenghtin.Text.Trim().IsNullOrEmpty())
            {
                cMMeasurementBookDetailEntity.Lenghtin = Decimal.Parse(txtLenghtin.Text.Trim());
            }
            else
            {
                cMMeasurementBookDetailEntity.Lenghtin = null;
            }

            if (!txtWidthft.Text.Trim().IsNullOrEmpty())
            {
                cMMeasurementBookDetailEntity.Widthft = Decimal.Parse(txtWidthft.Text.Trim());
            }
            else
            {
                cMMeasurementBookDetailEntity.Widthft = null;
            }

            if (!txtWidthin.Text.Trim().IsNullOrEmpty())
            {
                cMMeasurementBookDetailEntity.Widthin = Decimal.Parse(txtWidthin.Text.Trim());
            }
            else
            {
                cMMeasurementBookDetailEntity.Widthin = null;
            }

            if (!txtHeightft.Text.Trim().IsNullOrEmpty())
            {
                cMMeasurementBookDetailEntity.Heightft = Decimal.Parse(txtHeightft.Text.Trim());
            }
            else
            {
                cMMeasurementBookDetailEntity.Heightft = null;
            }

            if (!txtHeightin.Text.Trim().IsNullOrEmpty())
            {
                cMMeasurementBookDetailEntity.Heightin = Decimal.Parse(txtHeightin.Text.Trim());
            }
            else
            {
                cMMeasurementBookDetailEntity.Heightin = null;
            }

            if (!txtNos.Text.Trim().IsNullOrEmpty())
            {
                cMMeasurementBookDetailEntity.Nos = Decimal.Parse(txtNos.Text.Trim());
            }
           
                Decimal lenghtft=1,lengthin=1,heightft=1,heightin=1,widthft=1,widthin=1,Qty,Nos;

                if (txtLengthft.Text.IsNotNullOrEmpty())
                {
                    Decimal.TryParse(txtLengthft.Text.ToString(), out lenghtft);
                }
                if (txtLenghtin.Text.IsNotNullOrEmpty())
                {
                    Decimal.TryParse(txtLenghtin.Text.ToString(), out lengthin);
                    lengthin = Math.Round(lengthin / 12, 2);
                }
                if (txtWidthft.Text.IsNotNullOrEmpty())
                {
                    Decimal.TryParse(txtWidthft.Text.ToString(), out widthft);
                }
                if (txtWidthin.Text.IsNotNullOrEmpty())
                {
                    Decimal.TryParse(txtWidthin.Text.ToString(), out widthin);
                    widthin = Math.Round(widthin / 12, 2);
                }

                if (txtHeightft.Text.IsNotNullOrEmpty())
                {
                    Decimal.TryParse(txtHeightft.Text.ToString(), out heightft);
                }
                if (txtHeightin.Text.IsNotNullOrEmpty())
                {
                    Decimal.TryParse(txtHeightin.Text.ToString(), out heightin);
                    heightin = Math.Round(heightin / 12, 2);
                }
                Decimal.TryParse(txtNos.Text.ToString(), out Nos);

                Qty = (lenghtft + lengthin) * (widthft + widthin) * Nos;
                Qty = Math.Round(Qty, 4);

                cMMeasurementBookDetailEntity.Qty = Qty;

            return cMMeasurementBookDetailEntity;
        }

        private void SaveCMMeasurementBookDetailEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity = BuildCMMeasurementBookDetailEntity();

                    Int64 result = -1;

                    if (cMMeasurementBookDetailEntity.IsNew)
                    {
                        result = FCCCMMeasurementBookDetail.GetFacadeCreate().Add(cMMeasurementBookDetailEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMMeasurementBookDetailEntity.FLD_NAME_MeasurementBookDetailID, cMMeasurementBookDetailEntity.MeasurementBookDetailID.ToString(), SQLMatchType.Equal);
                        result = FCCCMMeasurementBookDetail.GetFacadeCreate().Update(cMMeasurementBookDetailEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MeasurementBookDetailID = 0;
                        _CMMeasurementBookDetailEntity = new CMMeasurementBookDetailEntity();
                        PrepareInitialView();
                        BindCMMeasurementBookDetailList();

                        if (cMMeasurementBookDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Measurement Book Detail Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Measurement Book Detail Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMMeasurementBookDetailEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Measurement Book Detail Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Measurement Book Detail Information.", false);
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

        protected void lvCMMeasurementBookDetail_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MeasurementBookDetailID;

            Int64.TryParse(e.CommandArgument.ToString(), out MeasurementBookDetailID);

            if (MeasurementBookDetailID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MeasurementBookDetailID = MeasurementBookDetailID;

                    PrepareEditView();
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMMeasurementBookDetailEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MeasurementBookDetailID = 0;
            _CMMeasurementBookDetailEntity = new CMMeasurementBookDetailEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #endregion Event
    }
}
