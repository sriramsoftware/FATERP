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
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Text;

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionMasterControl : ProjectBaseControl
    {

        #region Extra

        class CustomerComparer : IEqualityComparer<REQRequisitionItemEntity>
        {
            public bool Equals(REQRequisitionItemEntity x, REQRequisitionItemEntity y)
            {
                return (x.ItemID.Equals(y.ItemID));
            }

            public int GetHashCode(REQRequisitionItemEntity obj)
            {
                return obj.ItemID.GetHashCode();
            }
        }

        #endregion

        #region Properties

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public Int64 _RequisitionID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.REQUISITION_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.REQUISITION_ID], out id);
                    ViewState["ID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public Int64 _ProjectID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ProjectID"] != null)
                {
                    Int64.TryParse(ViewState["ProjectID"].ToString(), out id);
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_PROJECT_ID], out id);
                    ViewState["ProjectID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ProjectID"] = value;
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

        public IList<REQRequisitionItemEntity> REQRequisitionItemList
        {
            get
            {
                return (IList<REQRequisitionItemEntity>)ViewState["vs_CurrentRequisitionItemEntity"];
            }
            set
            {
                ViewState["vs_CurrentRequisitionItemEntity"] = value;
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

        public IList<REQRequisitionItemEntity> UpdatedMappedRequisitionItem
        {
            get
            {
                return (IList<REQRequisitionItemEntity>)ViewState["UpdatedMappedRequisitionItem"];
            }
            set
            {
                ViewState["UpdatedMappedRequisitionItem"] = value;
            }
        }

        public Int64 _PreBOQID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["PreBOQID"] != null)
                {
                    Int64.TryParse(ViewState["PreBOQID"].ToString(), out id);
                }
                else
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, ddlProjectID.SelectedValue.ToString(), SQLMatchType.Equal);

                    IList<PRMPreBOQEntity> tempList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (tempList != null && tempList.Count > 0)
                    {
                        id = tempList[0].PreBOQID;
                    }
                }

                return id;
            }
            set
            {
                ViewState["PreBOQID"] = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateMDRequisitionStatus(ddlRequisitionStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRequisitionNo.Text = String.Empty;
            txtRequisitionDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            REQRequisitionItemList = new List<REQRequisitionItemEntity>();
            UpdatedMappedRequisitionItem = new List<REQRequisitionItemEntity>();

        }

        private void PrepareEditView()
        {

            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;


            if (!rEQRequisitionEntity.IsNew)
            {
                if (ddlProjectID.Items.Count > 0 && rEQRequisitionEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = rEQRequisitionEntity.ProjectID.ToString();
                }

                txtRequisitionNo.Text = rEQRequisitionEntity.RequisitionNo.ToString();
                txtRequisitionDate.Text = rEQRequisitionEntity.RequisitionDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                txtRemarks.Text = rEQRequisitionEntity.Remarks.ToString();
                if (ddlRequisitionStatusID.Items.Count > 0 && rEQRequisitionEntity.RequisitionStatusID != null)
                {
                    ddlRequisitionStatusID.SelectedValue = rEQRequisitionEntity.RequisitionStatusID.ToString();
                }
                String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, _RequisitionID.ToString(), SQLMatchType.Equal);
                UpdatedMappedRequisitionItem = FCCREQRequisitionItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                if (UpdatedMappedRequisitionItem != null && UpdatedMappedRequisitionItem.Count > 0)
                {
                    REQRequisitionItemList = UpdatedMappedRequisitionItem;
                }
                else
                {
                    UpdatedMappedRequisitionItem = new List<REQRequisitionItemEntity>();
                }
                BindREQRequisitionList();
            }
            if (_ProjectID > 0)
            {
                if (ddlProjectID.Items.Count > 0)
                {
                    ddlProjectID.SelectedValue = this.OverviewProjectID.ToString();
                    ddlProjectID.Enabled = false;
                }
            }
        }

        private void BindList()
        {
            BindREQRequisitionList();
        }

        private void BindREQRequisitionList()
        {
            lvRequisitionItem.DataBind();
        }

        private REQRequisitionEntity BuildREQRequisitionEntity()
        {
            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            rEQRequisitionEntity.RequisitionNo = txtRequisitionNo.Text.Trim();
            if (txtRequisitionDate.Text.Trim().IsNotNullOrEmpty())
            {
                rEQRequisitionEntity.RequisitionDate = MiscUtil.ParseToDateTime(txtRequisitionDate.Text);
            }
            rEQRequisitionEntity.Remarks = txtRemarks.Text.Trim();

            if (ddlRequisitionStatusID.Items.Count > 0)
            {
                if (ddlRequisitionStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionEntity.RequisitionStatusID = Int64.Parse(ddlRequisitionStatusID.SelectedValue);
                }
            }

            return rEQRequisitionEntity;
        }

        private void SaveREQRequisitionEntity()
        {
            if (IsValid)
            {
                try
                {
                    REQRequisitionEntity rEQRequisitionEntity = BuildREQRequisitionEntity();

                    Int64 result = -1;

                    if (rEQRequisitionEntity.IsNew)
                    {
                        //Prepared By ID Only for Save Operation; not for Update.
                        rEQRequisitionEntity.PreparedByMemberID = this.CurrentMember.MemberID;
                        result = FCCREQRequisition.GetFacadeCreate().Add(rEQRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionID, rEQRequisitionEntity.RequisitionID.ToString(), SQLMatchType.Equal);
                        result = FCCREQRequisition.GetFacadeCreate().Update(rEQRequisitionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }
                    BindRequisitionItemInfo();

                    IList<REQRequisitionItemEntity> deleteList = UpdatedMappedRequisitionItem.Except(REQRequisitionItemList, new CustomerComparer()).ToList();
                    IList<REQRequisitionItemEntity> addNewList = REQRequisitionItemList.Except(UpdatedMappedRequisitionItem, new CustomerComparer()).ToList();

                    foreach (REQRequisitionItemEntity ent in deleteList)
                    {
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), SQLMatchType.Equal);
                        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_ItemID, ent.ItemID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                        FCCREQRequisitionItem.GetFacadeCreate().Delete(ent, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                    }

                    StringBuilder xmlStr = new StringBuilder();
                    String subXmlStr = String.Empty;

                    xmlStr.Append("<m>");

                    foreach (REQRequisitionItemEntity ent in addNewList)
                    {
                        subXmlStr = subXmlStr + "<i><a>" + result + "</a><b>" + ent.AccountsCode + "</b><c>" + ent.ItemID + "</c><d>" + ent.TotalRequiredQty + "</d><e>" + ent.PurchasedQtyTillToDate + "</e><f>" + ent.PresentRequiredQty + "</f><g>" + ent.RequiredDate + "</g><h>" + ent.Remarks + "</h><j>" + ent.Rate + "</j></i>";
                    }
                    xmlStr.Append(subXmlStr.ToString());
                    xmlStr.Append("</m>");
                    FCCBulkInsertXML.GetFacadeCreate().GetIL(xmlStr.ToString(), CommonConstants.RequisitionItemInfo);

                    if (result > 0)
                    {
                        _RequisitionID = 0;
                        _REQRequisitionEntity = new REQRequisitionEntity();
                        PrepareInitialView();
                        ClearAllRequisitionItem();

                        if (rEQRequisitionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Requisition Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Requisition Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (rEQRequisitionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Requisition Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Requisition Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void BindRequisitionItemInfo()
        {
            try
            {
                IList<ListViewDataItem> list = lvRequisitionItem.Items;

                if (list != null && list.Count > 0)
                {

                    foreach (ListViewDataItem lvdi in list)
                    {
                        CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxState");

                        if (chbxState.Checked == true)
                        {
                            REQRequisitionItemEntity ent = new REQRequisitionItemEntity();
                            Decimal TotalRequiredQty;
                            Int64 ItemID;
                            Decimal PurchasedQty;
                            Decimal PresentRequiredQty;
                            Decimal RateLV;


                            TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtQtyLV");
                            TextBox txtPurchasedQty = (TextBox)lvdi.FindControl("txtPurchasedQty");
                            TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");
                            TextBox txtRequiredDate = (TextBox)lvdi.FindControl("txtRequiredDate");
                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                            TextBox txtAccountsCodeLV = (TextBox)lvdi.FindControl("txtAccountsCodeLV");
                            Label lblItemLV = (Label)lvdi.FindControl("lblItem");
                            TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                            Decimal.TryParse(txtTotalQtyLV.Text.Trim(), out TotalRequiredQty);
                            Decimal.TryParse(txtPurchasedQty.Text.Trim(), out PurchasedQty);
                            Decimal.TryParse(txtPresentRequiredQty.Text.Trim(), out PresentRequiredQty);
                            Decimal.TryParse(txtRateLV.Text.Trim(), out RateLV);
                            Int64.TryParse(lblItemLV.Text, out ItemID);
                            ent.ItemID = ItemID;
                            ent.TotalRequiredQty = TotalRequiredQty;
                            ent.PurchasedQtyTillToDate = PurchasedQty;
                            ent.PresentRequiredQty = PresentRequiredQty;
                            ent.Remarks = txtRemarksLV.Text.Trim();
                            ent.AccountsCode = txtAccountsCodeLV.Text.ToString();
                            ent.Rate = RateLV;
                            if (txtRequiredDate.Text.Trim().IsNotNullOrEmpty())
                            {
                                ent.RequiredDate = MiscUtil.ParseToDateTime(txtRequisitionDate.Text);
                            }
                            else
                            {
                                ent.RequiredDate = MiscUtil.ParseToDateTime(System.DateTime.Now.ToStringDefault());
                            }

                            //Check Existing Item

                            var itemList = (from s in REQRequisitionItemList
                                            where s.ItemID == ItemID
                                            select s);
                            if (itemList == null || itemList.Count() <= 0)
                            {
                                REQRequisitionItemList.Add(ent);
                            }

                        }

                        else if (chbxState.Checked == false)
                        {

                            Int64 ItemID;

                            Label lblItemLV = (Label)lvdi.FindControl("lblItem");
                            Int64.TryParse(lblItemLV.Text, out ItemID);

                            var item = from s in REQRequisitionItemList
                                       where s.ItemID == ItemID
                                       select s;

                            if (item != null && item.Count() > 0)
                            {
                                REQRequisitionItemEntity di = (from d in REQRequisitionItemList
                                                               where d.ItemID == ItemID
                                                               select d).First();
                                if (di != null)
                                {
                                    REQRequisitionItemList.Remove(di);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ClearAllRequisitionItem()
        {

            IList<ListViewDataItem> list = lvRequisitionItem.Items;

            if (list != null && list.Count > 0)
            {

                foreach (ListViewDataItem lvdi in list)
                {
                    CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxState");
                    TextBox txtTotalQtyLV = (TextBox)lvdi.FindControl("txtQtyLV");
                    TextBox txtPurchasedQty = (TextBox)lvdi.FindControl("txtPurchasedQty");
                    TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");
                    TextBox txtRequiredDate = (TextBox)lvdi.FindControl("txtRequiredDate");
                    TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                    TextBox txtAccountsCodeLV = (TextBox)lvdi.FindControl("txtAccountsCodeLV");
                    TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");
                    chbxState.Checked = false;
                    txtTotalQtyLV.Text = String.Empty;
                    txtPurchasedQty.Text = String.Empty;
                    txtPresentRequiredQty.Text = String.Empty;
                    txtRequiredDate.Text = String.Empty;
                    txtAccountsCodeLV.Text = String.Empty;
                    txtRateLV.Text = String.Empty;
                    txtRemarksLV.Text = String.Empty;
                }
            }
        }

        #endregion

        #region Event

        #region List View Event


        protected void lvRequisitionItem_ItemDataBound(object sender, ListViewItemEventArgs e)
        {

            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                TextBox txtQtyLV = (TextBox)e.Item.FindControl("txtQtyLV");
                Decimal TotalQty;
                Decimal.TryParse(txtQtyLV.Text.ToString(), out TotalQty);

                if (TotalQty <= 0)
                {
                    TextBox txtPresentRequiredQty = (TextBox)e.Item.FindControl("txtPresentRequiredQty");
                    txtPresentRequiredQty.Enabled = false;
                }
            }
        }

        protected void lvRequisitionItem_DataBound(object sender, EventArgs e)
        {
            #region Make the Decision to Checkedbox from ViewState

            if (REQRequisitionItemList != null && REQRequisitionItemList.Count > 0)
            {
                IList<ListViewDataItem> list = lvRequisitionItem.Items;

                if (list != null && list.Count > 0)
                {

                    foreach (ListViewDataItem lvdi in list)
                    {
                        Int64 ItemID;

                        Label lblItemLV = (Label)lvdi.FindControl("lblItem");
                        Int64.TryParse(lblItemLV.Text, out ItemID);

                        IList<REQRequisitionItemEntity> item = (from s in REQRequisitionItemList
                                                                where s.ItemID == ItemID
                                                                select s).ToList();

                        if (item != null && item.Count() > 0)
                        {
                            CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxState");
                            TextBox txtQtyLV = (TextBox)lvdi.FindControl("txtQtyLV");
                            TextBox txtPurchasedQty = (TextBox)lvdi.FindControl("txtPurchasedQty");
                            TextBox txtPresentRequiredQty = (TextBox)lvdi.FindControl("txtPresentRequiredQty");
                            TextBox txtRequiredDate = (TextBox)lvdi.FindControl("txtRequiredDate");
                            TextBox txtRemarksLV = (TextBox)lvdi.FindControl("txtRemarksLV");
                            TextBox txtAccountsCodeLV = (TextBox)lvdi.FindControl("txtAccountsCodeLV");
                            TextBox txtRateLV = (TextBox)lvdi.FindControl("txtRateLV");

                            chbxState.Checked = true;
                            txtQtyLV.Text = item[0].TotalRequiredQty.ToString();
                            txtAccountsCodeLV.Text = item[0].AccountsCode.ToString();
                            txtPresentRequiredQty.Text = item[0].PresentRequiredQty.ToString();
                            txtPurchasedQty.Text = item[0].PurchasedQtyTillToDate.ToString();
                            txtRemarksLV.Text = item[0].Remarks.ToString();
                            txtRequiredDate.Text = item[0].RequiredDate.ToString(UIConstants.SHORT_DATE_FORMAT);
                            txtRateLV.Text = item[0].Rate.ToString();

                        }

                    }
                }
            }

            #endregion
        }

        #endregion List View Event

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

        #region ObjectDataSource Event

        protected void odsPRMPreBOQDetail_Custom_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            if (e.ExecutingSelectCount == false)
            {
                BindRequisitionItemInfo();
            }
            String fe = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQDetail." + PRMPreBOQDetailEntity.FLD_NAME_PreBOQID, _PreBOQID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveREQRequisitionEntity();
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindREQRequisitionList();
        }

        #endregion Dropdown Event

        #region Header CheckBox

        protected void chbxHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chbxHeader = (CheckBox)lvRequisitionItem.FindControl("chbxHeader");
            
            IList<ListViewDataItem> list = lvRequisitionItem.Items;
            if (list != null && list.Count > 0)
            {
                if (chbxHeader.Checked == true)
                {
                    foreach (ListViewDataItem lvdi in list)
                    {
                        CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxState");
                        chbxState.Checked = true;
                    }
                }
                if (chbxHeader.Checked == false)
                {
                    foreach (ListViewDataItem lvdi in list)
                    {
                        CheckBox chbxState = (CheckBox)lvdi.FindControl("chbxState");
                        chbxState.Checked = false;
                    }
                }
            }
        }

        #endregion

        #endregion Event

    }
}
