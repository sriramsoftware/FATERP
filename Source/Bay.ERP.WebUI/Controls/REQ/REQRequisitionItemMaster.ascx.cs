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

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionItemMasterControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _RequisitionItemID
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

        public REQRequisitionItemEntity _REQRequisitionItemEntity
        {
            get
            {
                REQRequisitionItemEntity entity = new REQRequisitionItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (REQRequisitionItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private REQRequisitionItemEntity CurrentREQRequisitionItemEntity
        {
            get
            {
                if (_RequisitionItemID > 0)
                {
                    if (_REQRequisitionItemEntity.RequisitionItemID != _RequisitionItemID)
                    {
                        _REQRequisitionItemEntity = FCCREQRequisitionItem.GetFacadeCreate().GetByID(_RequisitionItemID);
                    }
                }

                return _REQRequisitionItemEntity;
            }
            set
            {
                _REQRequisitionItemEntity = value;
            }
        }

        public Int64 REQRequisitionID
        {
            get
            {
                Int64 rEQRequisitionID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[REQRequisitionEntity.FLD_NAME_RequisitionID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[REQRequisitionEntity.FLD_NAME_RequisitionID], out rEQRequisitionID);
                }

                return rEQRequisitionID;
            }
        }

        public Decimal ItemQty
        {
            get
            {
                Decimal itemQty=0;
                if (ViewState["vs_ItemQty"] != null)
                {
                    Decimal.TryParse(ViewState["vs_ItemQty"].ToString(),out itemQty);
                }

                return itemQty;
            }
            set
            {
                ViewState["vs_ItemQty"] = value;
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

        }

        private void BindList()
        {
            BindREQRequisitionItemList();
        }

        private void BindREQRequisitionItemList()
        {
            lvREQRequisitionItem.DataBind();
        }

        private void SaveREQRequisitionItemEntity()
        {
            try
            {
                IList<ListViewDataItem> list = lvREQRequisitionItem.Items;

                if (list != null && list.Count > 0)
                {
                   
                    foreach (ListViewDataItem lvdi in list)
                    {
                        
                        Decimal PresentRequiredQty;
                        Int64 ItemID;

                        Label lblItemID = (Label)lvdi.FindControl("lblItemLV");
                        Label lblQtyLV = (Label)lvdi.FindControl("lblQtyLV");
                        Label lblPurchasedQty = (Label)lvdi.FindControl("lblPurchasedQty");
                        TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");
                        TextBox txtRequiredDate = (TextBox)lvdi.FindControl("txtRequiredDate");
                        TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");


                        if (txtPresentRequiredQty.Enabled != false)
                        {
                            Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out PresentRequiredQty);
                            Int64.TryParse(lblItemID.Text, out ItemID);

                            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
                            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_ItemID, ItemID.ToString(), SQLMatchType.Equal);
                            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                            IList<REQRequisitionItemEntity> RequisitionItemList = FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                            if (RequisitionItemList != null && RequisitionItemList.Count > 0)
                            {
                                REQRequisitionItemEntity rEQRequisitionItem = RequisitionItemList[0];
                                rEQRequisitionItem.RequisitionID = REQRequisitionID;
                                rEQRequisitionItem.PresentRequiredQty = PresentRequiredQty;
                                rEQRequisitionItem.ItemID = ItemID;
                                //Another Entity Item may be added Here.
                                FCCREQRequisitionItem.GetFacadeCreate().Update(rEQRequisitionItem, fe, DatabaseOperationType.Update, TransactionRequired.No);
                            }
                        }
                    }
                }
                BindREQRequisitionItemList();
                MiscUtil.ShowMessage(lblMessage, "Requisition Item Information has been saved successfully.", false);
            }
            catch (Exception ex)
            {
                MiscUtil.ShowMessage(lblMessage, "Failed to save Requisition Item Information.", true);
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

        protected void lvREQRequisitionItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {   
                TextBox txtPresentRequiredQty = (TextBox)e.Item.FindControl("txtPresentRequiredQty");
                TextBox txtRequiredDate = (TextBox)e.Item.FindControl("txtRequiredDate");
                //TextBox txtRemarksLV = (TextBox)e.Item.FindControl("txtRemarksLV");
                Label txtTotalQtyLV = (Label)e.Item.FindControl("lblQtyLV");
                Label txtPurchasedQty = (Label)e.Item.FindControl("lblPurchasedQty");
                Decimal totalQty;
                Decimal purchasedQty;

                Decimal.TryParse(txtTotalQtyLV.Text.ToString(), out totalQty);
                Decimal.TryParse(txtPurchasedQty.Text.ToString(), out purchasedQty);

                if (purchasedQty >= totalQty)
                {
                    txtPurchasedQty.ForeColor = System.Drawing.Color.Red;
                }

                else if (purchasedQty < totalQty)
                {
                    txtPurchasedQty.ForeColor = System.Drawing.Color.Black;
                }
                
                txtPresentRequiredQty.Enabled = false;
                txtRequiredDate.Enabled = false;
                
            }
        }
        protected void lvREQRequisitionItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionItemID);

            if (RequisitionItemID > 0)
            {
                LinkButton lnkBtnEdit = (LinkButton)e.Item.FindControl("lnkBtnEdit");
                TextBox txtPresentRequiredQty = (TextBox)e.Item.FindControl("txtPresentRequiredQty");

                if (string.Equals(e.CommandName, "EditItem") && txtPresentRequiredQty.Enabled == true)
                {
                    txtPresentRequiredQty.Text = ItemQty.ToString();
                    txtPresentRequiredQty.Enabled = false;
                    lnkBtnEdit.Text = "Edit";
                }

                else if (string.Equals(e.CommandName, "EditItem") && txtPresentRequiredQty.Enabled == false)
                {
                    _RequisitionItemID = RequisitionItemID;

                    PrepareEditView();

                    txtPresentRequiredQty.Enabled = true;
                    ItemQty = Decimal.Parse(txtPresentRequiredQty.Text);
                    lnkBtnEdit.Text = "Cancel";

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, RequisitionItemID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        REQRequisitionItemEntity rEQRequisitionItemEntity = new REQRequisitionItemEntity();


                        result = FCCREQRequisitionItem.GetFacadeCreate().Delete(rEQRequisitionItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RequisitionItemID = 0;
                            _REQRequisitionItemEntity = new REQRequisitionItemEntity();
                            PrepareInitialView();
                            BindREQRequisitionItemList();
                            
                            MiscUtil.ShowMessage(lblMessage, "Requisition Item has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Requisition Item.", true);
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

        protected void odsREQRequisitionItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("REQRequisitionItem." + REQRequisitionItemEntity.FLD_NAME_RequisitionID, REQRequisitionID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveREQRequisitionItemEntity();
        }

        #endregion

        #endregion Event
    }
}
