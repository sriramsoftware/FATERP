// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public partial class PRMSupplierItemMapControl : BaseControl
    {
        #region Properties

        public Int64 _SupplierItemMapID
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

        public PRMSupplierItemMapEntity _PRMSupplierItemMapEntity
        {
            get
            {
                PRMSupplierItemMapEntity entity = new PRMSupplierItemMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMSupplierItemMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMSupplierItemMapEntity CurrentPRMSupplierItemMapEntity
        {
            get
            {
                if (_SupplierItemMapID > 0)
                {
                    if (_PRMSupplierItemMapEntity.SupplierItemMapID != _SupplierItemMapID)
                    {
                        _PRMSupplierItemMapEntity = FCCPRMSupplierItemMap.GetFacadeCreate().GetByID(_SupplierItemMapID);
                    }
                }

                return _PRMSupplierItemMapEntity;
            }
            set
            {
                _PRMSupplierItemMapEntity = value;
            }
        }

        public Int64 SupplierID
        {
            get
            {
                Int64 id = 0;

                if (ddlSupplierID.SelectedValue != "0")
                {
                    Int64.TryParse(ddlSupplierID.SelectedValue, out id);
                }

                return id;
            }
        }

        public IList<PRMSupplierItemMapEntity> _PRMSupplierItemMapList
        {
            get
            {
                IList<PRMSupplierItemMapEntity> supplierItemMapList = null;

                if (ViewState["CurrentPRMSupplierItemMapEntity"] != null)
                {
                    supplierItemMapList = (List<PRMSupplierItemMapEntity>)ViewState["CurrentPRMSupplierItemMapEntity"];
                }
                else
                {
                    supplierItemMapList = new List<PRMSupplierItemMapEntity>();
                }

                return supplierItemMapList;
            }
            set
            {
                ViewState["CurrentPRMSupplierItemMapEntity"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulatePRMSupplier(ddlSupplierID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            hypAddPrice.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierItemMapAdd.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, ddlSupplierID.SelectedValue.ToString(), PRMSupplierItemMapEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString()).ToString();
        }

        private void PrepareEditView()
        {

        }

        private void BindList()
        {
            BindPRMSupplierItemMapList();
        }

        private void BindPRMSupplierItemMapList()
        {
            lvPRMSupplierItemMap.DataBind();
        }

        private void SavePRMSupplierItemMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    IList<ListViewDataItem> list = lvPRMSupplierItemMap.Items;

                    if (list != null && list.Count > 0)
                    {

                        foreach (ListViewDataItem lvdi in list)
                        {

                            TextBox txtActualPriceValidation = (TextBox)lvdi.FindControl("txtActualPriceLV");
                            if (txtActualPriceValidation.Enabled)
                            {
                                Decimal ActualPrice, DiscountPercentage, Price;
                                Int64 ItemID, BrandID;

                                Label lblItemIDLV = (Label)lvdi.FindControl("txtItemIDLV");
                                Label lblBrandIDLV = (Label)lvdi.FindControl("lblBrandIDLV");
                                TextBox txtActualPriceLV = (TextBox)lvdi.FindControl("txtActualPriceLV");
                                TextBox txtDiscountPercentageLV = (TextBox)lvdi.FindControl("txtDiscountPercentageLV");
                                TextBox txtPriceLV = (TextBox)lvdi.FindControl("txtPriceLV");
                                TextBox txtEntryDateLV = (TextBox)lvdi.FindControl("txtEntryDateLV");

                                Int64.TryParse(lblItemIDLV.Text, out ItemID);
                                Int64.TryParse(lblBrandIDLV.Text, out BrandID);
                                Decimal.TryParse(txtActualPriceLV.Text.Trim(), out ActualPrice);
                                Decimal.TryParse(txtDiscountPercentageLV.Text.Trim(), out DiscountPercentage);

                                Decimal actualPrice, discountPercentages, price;

                                Decimal.TryParse(txtActualPriceLV.Text.Trim(), out actualPrice);
                                Decimal.TryParse(txtDiscountPercentageLV.Text.Trim(), out discountPercentages);

                                price = actualPrice - (actualPrice * (discountPercentages / 100));

                                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString(), SQLMatchType.Equal);
                                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_ItemID, ItemID.ToString(), SQLMatchType.Equal);
                                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_BrandID, BrandID.ToString(), SQLMatchType.Equal);
                                String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
                                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe4, SQLJoinType.AND, fe3);
                                IList<PRMSupplierItemMapEntity> SupplierItemMapList = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                                if (SupplierItemMapList != null && SupplierItemMapList.Count > 0)
                                {
                                    PRMSupplierItemMapEntity pRMSupplierItemMapEntity = SupplierItemMapList[0];
                                    pRMSupplierItemMapEntity.ActualPrice = ActualPrice;
                                    pRMSupplierItemMapEntity.DiscountPercentage = DiscountPercentage;
                                    pRMSupplierItemMapEntity.Price = price;
                                    pRMSupplierItemMapEntity.ItemID = ItemID;
                                    if (txtEntryDateLV.Text.Trim().IsNotNullOrEmpty())
                                    {
                                        pRMSupplierItemMapEntity.EntryDate = MiscUtil.ParseToDateTime(txtEntryDateLV.Text);
                                    }

                                    FCCPRMSupplierItemMap.GetFacadeCreate().Update(pRMSupplierItemMapEntity, fe, DatabaseOperationType.Update, TransactionRequired.No);
                                }
                            }
                        }
                        MiscUtil.ShowMessage(lblMessage, "Vendor Item Map Information has been updated successfully.", false);
                    }
                    BindPRMSupplierItemMapList();

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
       
        protected void lvPRMSupplierItemMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierItemMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierItemMapID);

            if (SupplierItemMapID > 0)
            {
                LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                TextBox txtActualPriceLV = (TextBox)e.Item.FindControl("txtActualPriceLV");
                TextBox txtDiscountPercentageLV = (TextBox)e.Item.FindControl("txtDiscountPercentageLV");
                TextBox txtPriceLV = (TextBox)e.Item.FindControl("txtPriceLV");
                TextBox txtEntryDateLV = (TextBox)e.Item.FindControl("txtEntryDateLV");
                Label lblItemIDLV = (Label)e.Item.FindControl("txtItemIDLV");
                Label lblBrandIDLV = (Label)e.Item.FindControl("lblBrandIDLV");

                Decimal ActualPrice, DiscountPercentage, Price;
                Int64 ItemID, BrandID;

                IList<PRMSupplierItemMapEntity> supplierItemMapList = new List<PRMSupplierItemMapEntity>();

                if (string.Equals(e.CommandName, "EditItem") && txtActualPriceLV.Enabled == false)
                {
                    _SupplierItemMapID = SupplierItemMapID;

                    txtActualPriceLV.Enabled = true;
                    txtDiscountPercentageLV.Enabled = true;
                    txtPriceLV.Enabled = false;
                    txtEntryDateLV.Enabled = true;

                    Int64.TryParse(lblItemIDLV.Text, out ItemID);
                    Int64.TryParse(lblBrandIDLV.Text, out BrandID);
                    Decimal.TryParse(txtActualPriceLV.Text.Trim(), out ActualPrice);
                    Decimal.TryParse(txtDiscountPercentageLV.Text.Trim(), out DiscountPercentage);
                    Decimal.TryParse(txtPriceLV.Text.Trim(), out Price);

                    PRMSupplierItemMapEntity ent = new PRMSupplierItemMapEntity();
                    ent.ItemID = ItemID;
                    ent.BrandID = BrandID;
                    ent.ActualPrice = ActualPrice;
                    ent.DiscountPercentage = DiscountPercentage;
                    ent.Price = Price;
                    if (txtEntryDateLV.Text.Trim().IsNotNullOrEmpty())
                    {
                        ent.EntryDate = MiscUtil.ParseToDateTime(txtEntryDateLV.Text);
                    }

                    supplierItemMapList = _PRMSupplierItemMapList;
                    supplierItemMapList.Add(ent);
                    _PRMSupplierItemMapList = supplierItemMapList;

                    PrepareEditView();
                    lnkBtnEdit.Text = "Cancel";

                }
                else if (string.Equals(e.CommandName, "EditItem") && txtActualPriceLV.Enabled == true)
                {
                    _SupplierItemMapID = SupplierItemMapID;

                    PrepareEditView();

                    txtActualPriceLV.Enabled = false;
                    txtDiscountPercentageLV.Enabled = false;
                    txtPriceLV.Enabled = false;
                    txtEntryDateLV.Enabled = false;
                    Int64.TryParse(lblItemIDLV.Text, out ItemID);
                    Int64.TryParse(lblBrandIDLV.Text, out BrandID);

                    if (_PRMSupplierItemMapList != null && _PRMSupplierItemMapList.Count > 0)
                    {
                        PRMSupplierItemMapEntity supplierItemMap =(from s in _PRMSupplierItemMapList
                                                                   where s.ItemID == ItemID
                                                                   select s).First();
                        if (supplierItemMap != null)
                        {
                            txtActualPriceLV.Text =supplierItemMap.ActualPrice.ToString();
                            txtDiscountPercentageLV.Text = supplierItemMap.DiscountPercentage.ToString();
                            txtEntryDateLV.Text = supplierItemMap.EntryDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                            txtPriceLV.Text = supplierItemMap.Price.ToString();
                            _PRMSupplierItemMapList.Remove(supplierItemMap);
                        }                                         
                    }
                   
                    lnkBtnEdit.Text = "Edit"; 

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierItemMapID, SupplierItemMapID.ToString(), SQLMatchType.Equal);

                        PRMSupplierItemMapEntity pRMSupplierItemMapEntity = new PRMSupplierItemMapEntity();

                        result = FCCPRMSupplierItemMap.GetFacadeCreate().Delete(pRMSupplierItemMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierItemMapID = 0;
                            _PRMSupplierItemMapEntity = new PRMSupplierItemMapEntity();
                            PrepareInitialView();
                            BindPRMSupplierItemMapList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Item Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Item Map.", true);
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

        protected void odsPRMSupplierItemMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (ddlSupplierID.SelectedValue != "0")
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("PRMSupplierItemMap." + PRMSupplierItemMapEntity.FLD_NAME_SupplierID, SupplierID.ToString(), SQLMatchType.Equal);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SavePRMSupplierItemMapEntity();
        }

        #endregion

        #region Dropdown Event

        protected void ddlSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSupplierID.SelectedValue != "0")
            {
                BindList();
                hypAddPrice.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMSupplierItemMapAdd.aspx", string.Empty, UrlConstants.OVERVIEW_SUPPLIER_ID, ddlSupplierID.SelectedValue.ToString(), PRMSupplierItemMapEntity.FLD_NAME_SupplierID, ddlSupplierID.SelectedValue.ToString()).ToString();
            }
        }

        #endregion

        #endregion Event

    }
}
