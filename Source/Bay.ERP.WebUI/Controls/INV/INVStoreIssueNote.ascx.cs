// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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

namespace Bay.ERP.Web.UI
{
    public partial class INVStoreIssueNoteControl : BaseControl
    {       
        #region Properties

        public Int64 _StoreIssueNoteID
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

        public INVStoreIssueNoteEntity _INVStoreIssueNoteEntity
        {
            get
            {
                INVStoreIssueNoteEntity entity = new INVStoreIssueNoteEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVStoreIssueNoteEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVStoreIssueNoteEntity CurrentINVStoreIssueNoteEntity
        {
            get
            {
                if (_StoreIssueNoteID > 0)
                {
                    if (_INVStoreIssueNoteEntity.StoreIssueNoteID != _StoreIssueNoteID)
                    {
                        _INVStoreIssueNoteEntity = FCCINVStoreIssueNote.GetFacadeCreate().GetByID(_StoreIssueNoteID);
                    }
                }

                return _INVStoreIssueNoteEntity;
            }
            set
            {
                _INVStoreIssueNoteEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateHREmployee(ddlRequestedByEmployeeID, false);
            MiscUtil.PopulateMDStoreIssueNoteApprovalStatus(ddlStoreIssueNoteApprovalStatusID, false);

            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                ddlProjectID.SelectedValue = "49";

                //Default Project Cooperate.
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtStoreIssueNoteNo.Text = MasterDataConstants.AutoAssigned.DEFAULT_AUTO_ASSIGNED;
            txtSRFNo.Text = String.Empty;
            txtRequestDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            if (ddlRequestedByEmployeeID.Items.Count > 0)
            {
                Int64 employeeID = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);

                if (employeeID > 0)
                {
                    ddlRequestedByEmployeeID.SelectedValue = employeeID.ToString();
                }
            }

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            INVStoreIssueNoteEntity iNVStoreIssueNoteEntity = CurrentINVStoreIssueNoteEntity;


            if (!iNVStoreIssueNoteEntity.IsNew)
            {
                if (ddlProjectID.Items.Count > 0 && iNVStoreIssueNoteEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = iNVStoreIssueNoteEntity.ProjectID.ToString();
                }

                txtStoreIssueNoteNo.Text = iNVStoreIssueNoteEntity.StoreIssueNoteNo.ToString();
                txtSRFNo.Text = iNVStoreIssueNoteEntity.SRFNo.ToString();
                if (ddlRequestedByEmployeeID.Items.Count > 0 && iNVStoreIssueNoteEntity.RequestedByEmployeeID != null)
                {
                    ddlRequestedByEmployeeID.SelectedValue = iNVStoreIssueNoteEntity.RequestedByEmployeeID.ToString();
                }

                txtRequestDate.Text = iNVStoreIssueNoteEntity.RequestDate.ToStringDefault();
                txtRemarks.Text = iNVStoreIssueNoteEntity.Remarks.ToString();
                if (ddlStoreIssueNoteApprovalStatusID.Items.Count > 0 && iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID != null)
                {
                    ddlStoreIssueNoteApprovalStatusID.SelectedValue = iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID.ToString();
                }

                chkIsRemoved.Checked = iNVStoreIssueNoteEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindINVStoreIssueNoteList();
        }

        private void BindINVStoreIssueNoteList()
        {
            lvINVStoreIssueNote.DataBind();
        }

        private INVStoreIssueNoteEntity BuildINVStoreIssueNoteEntity()
        {
            INVStoreIssueNoteEntity iNVStoreIssueNoteEntity = CurrentINVStoreIssueNoteEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreIssueNoteEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            iNVStoreIssueNoteEntity.StoreIssueNoteNo = txtStoreIssueNoteNo.Text.Trim();
            iNVStoreIssueNoteEntity.SRFNo = txtSRFNo.Text.Trim();
            if (ddlRequestedByEmployeeID.Items.Count > 0)
            {
                if (ddlRequestedByEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreIssueNoteEntity.RequestedByEmployeeID = Int64.Parse(ddlRequestedByEmployeeID.SelectedValue);
                }
            }

            if (txtRequestDate.Text.Trim().IsNotNullOrEmpty())
            {
                iNVStoreIssueNoteEntity.RequestDate = MiscUtil.ParseToDateTime(txtRequestDate.Text);
            }

            iNVStoreIssueNoteEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlStoreIssueNoteApprovalStatusID.Items.Count > 0)
            {
                if (ddlStoreIssueNoteApprovalStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreIssueNoteEntity.StoreIssueNoteApprovalStatusID = Int64.Parse(ddlStoreIssueNoteApprovalStatusID.SelectedValue);
                }
            }

            iNVStoreIssueNoteEntity.IsRemoved = chkIsRemoved.Checked;


            return iNVStoreIssueNoteEntity;
        }

        private void SaveINVStoreIssueNoteEntity()
        {
            if (IsValid)
            {
                try
                {
                    INVStoreIssueNoteEntity iNVStoreIssueNoteEntity = BuildINVStoreIssueNoteEntity();

                    Int64 result = -1;

                    if (iNVStoreIssueNoteEntity.IsNew)
                    {
                        result = FCCINVStoreIssueNote.GetFacadeCreate().Add(iNVStoreIssueNoteEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteEntity.FLD_NAME_StoreIssueNoteID, iNVStoreIssueNoteEntity.StoreIssueNoteID.ToString(), SQLMatchType.Equal);
                        result = FCCINVStoreIssueNote.GetFacadeCreate().Update(iNVStoreIssueNoteEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _StoreIssueNoteID = 0;
                        _INVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();
                        PrepareInitialView();
                        BindINVStoreIssueNoteList();

                        String NavUrl = UrlHelper.BuildSecureUrl("~/INV/INVStoreIssueNoteItemMap.aspx", string.Empty, "do", MasterDataConstants.SINAddOperation.REQUEST_ITEM, UrlConstants.OVERVIEW_STORE_ISSUE_NOTE_ID, result.ToString()).ToString();
                        Response.Redirect(NavUrl);

                        if (iNVStoreIssueNoteEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Store Issue Note Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Store Issue Note Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (iNVStoreIssueNoteEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Store Issue Note Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Store Issue Note Information.", false);
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

        protected void lvINVStoreIssueNote_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                INVStoreIssueNote_DetailedEntity ent = (INVStoreIssueNote_DetailedEntity)dataItem.DataItem;

                HyperLink lnkBtnRequestItem = (HyperLink)e.Item.FindControl("lnkBtnRequestItem");
                HyperLink lnkBtnIssueItem = (HyperLink)e.Item.FindControl("lnkBtnIssueItem");
                HyperLink lnkBtnReturnItem = (HyperLink)e.Item.FindControl("lnkBtnReturnItem");

                lnkBtnRequestItem.NavigateUrl = UrlHelper.BuildSecureUrl("~/INV/INVStoreIssueNoteItemMap.aspx", string.Empty, "do", MasterDataConstants.SINAddOperation.REQUEST_ITEM, UrlConstants.OVERVIEW_STORE_ISSUE_NOTE_ID, ent.StoreIssueNoteID.ToString()).ToString();
                lnkBtnIssueItem.NavigateUrl = UrlHelper.BuildSecureUrl("~/INV/INVStoreIssueNoteItemMap.aspx", string.Empty, "do", MasterDataConstants.SINAddOperation.ISSUE_ITEM, UrlConstants.OVERVIEW_STORE_ISSUE_NOTE_ID, ent.StoreIssueNoteID.ToString()).ToString();
                lnkBtnReturnItem.NavigateUrl = UrlHelper.BuildSecureUrl("~/INV/INVStoreIssueNoteItemMap.aspx", string.Empty, "do", MasterDataConstants.SINAddOperation.RETURN_ITEM, UrlConstants.OVERVIEW_STORE_ISSUE_NOTE_ID, ent.StoreIssueNoteID.ToString()).ToString();

                lnkBtnRequestItem.Target="_blank";
                lnkBtnIssueItem.Target="_blank";
                lnkBtnReturnItem.Target = "_blank";

            }
        }

        protected void lvINVStoreIssueNote_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 StoreIssueNoteID;

            Int64.TryParse(e.CommandArgument.ToString(), out StoreIssueNoteID);

            if (StoreIssueNoteID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _StoreIssueNoteID = StoreIssueNoteID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteEntity.FLD_NAME_StoreIssueNoteID, StoreIssueNoteID.ToString(), SQLMatchType.Equal);

                        INVStoreIssueNoteEntity iNVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();


                        result = FCCINVStoreIssueNote.GetFacadeCreate().Delete(iNVStoreIssueNoteEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _StoreIssueNoteID = 0;
                            _INVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();
                            PrepareInitialView();
                            BindINVStoreIssueNoteList();

                            MiscUtil.ShowMessage(lblMessage, "I NVStore Issue Note has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVStore Issue Note.", true);
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

        protected void odsINVStoreIssueNote_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("MDStoreIssueNoteApprovalStatus.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNote."+INVStoreIssueNoteEntity.FLD_NAME_StoreIssueNoteNo, txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);

                fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe3);
            }

            if (this.Page.User.Identity.IsAuthenticated == true)
            {
                if (Roles.IsUserInRole(this.Page.User.Identity.Name, "Store Keeper") == true)
                {
                    String fe_store = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_StoreInChargeEmployeeID, MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember).ToString(), SQLMatchType.Equal);
                    IList<INVStoreEntity> lst = FCCINVStore.GetFacadeCreate().GetIL(null, null, String.Empty, fe_store, DatabaseOperationType.LoadWithFilterExpression);

                    if (lst != null && lst.Count > 0)
                    {
                        String fe1 = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNote." + INVStoreIssueNoteEntity.FLD_NAME_ProjectID, lst[0].ProjectID.ToString(), SQLMatchType.Equal);

                        if (fe.IsNotNullOrEmpty())
                        {
                            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
                        }
                        else
                        {
                            fe = fe1;
                        }
                    }
                }
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveINVStoreIssueNoteEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _StoreIssueNoteID = 0;
            _INVStoreIssueNoteEntity = new INVStoreIssueNoteEntity();
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
