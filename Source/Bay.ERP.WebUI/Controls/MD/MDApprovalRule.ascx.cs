// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




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
    public partial class MDApprovalRuleControl : BaseControl
    {       
        #region Properties

        public Int64 _ApprovalRuleID
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

        public MDApprovalRuleEntity _MDApprovalRuleEntity
        {
            get
            {
                MDApprovalRuleEntity entity = new MDApprovalRuleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDApprovalRuleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDApprovalRuleEntity CurrentMDApprovalRuleEntity
        {
            get
            {
                if (_ApprovalRuleID > 0)
                {
                    if (_MDApprovalRuleEntity.ApprovalRuleID != _ApprovalRuleID)
                    {
                        _MDApprovalRuleEntity = FCCMDApprovalRule.GetFacadeCreate().GetByID(_ApprovalRuleID);
                    }
                }

                return _MDApprovalRuleEntity;
            }
            set
            {
                _MDApprovalRuleEntity = value;
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

            txtApprovalRuleName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDApprovalRuleEntity mDApprovalRuleEntity = CurrentMDApprovalRuleEntity;


            if (!mDApprovalRuleEntity.IsNew)
            {
                txtApprovalRuleName.Text = mDApprovalRuleEntity.ApprovalRuleName.ToString();
                txtDescription.Text = mDApprovalRuleEntity.Description.ToString();
                chkIsRemoved.Checked = mDApprovalRuleEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDApprovalRuleList();
        }

        private void BindMDApprovalRuleList()
        {
            lvMDApprovalRule.DataBind();
        }

        private MDApprovalRuleEntity BuildMDApprovalRuleEntity()
        {
            MDApprovalRuleEntity mDApprovalRuleEntity = CurrentMDApprovalRuleEntity;

            mDApprovalRuleEntity.ApprovalRuleName = txtApprovalRuleName.Text.Trim();
            mDApprovalRuleEntity.Description = txtDescription.Text.Trim();
            mDApprovalRuleEntity.IsRemoved = chkIsRemoved.Checked;


            return mDApprovalRuleEntity;
        }

        private void SaveMDApprovalRuleEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDApprovalRuleEntity mDApprovalRuleEntity = BuildMDApprovalRuleEntity();

                    Int64 result = -1;

                    if (mDApprovalRuleEntity.IsNew)
                    {
                        result = FCCMDApprovalRule.GetFacadeCreate().Add(mDApprovalRuleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalRuleEntity.FLD_NAME_ApprovalRuleID, mDApprovalRuleEntity.ApprovalRuleID.ToString(), SQLMatchType.Equal);
                        result = FCCMDApprovalRule.GetFacadeCreate().Update(mDApprovalRuleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ApprovalRuleID = 0;
                        _MDApprovalRuleEntity = new MDApprovalRuleEntity();
                        PrepareInitialView();
                        BindMDApprovalRuleList();

                        if (mDApprovalRuleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Rule Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Rule Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDApprovalRuleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Approval Rule Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Approval Rule Information.", false);
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

        protected void lvMDApprovalRule_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                MDApprovalRuleEntity ent = (MDApprovalRuleEntity)dataItem.DataItem;

                HyperLink hypPanelMembers = (HyperLink)e.Item.FindControl("hypPanelMembers");

                hypPanelMembers.NavigateUrl = UrlHelper.BuildSecureUrl("~/MD/MDApprovalRuleDesignationMap.aspx", string.Empty, MDApprovalRuleEntity.FLD_NAME_ApprovalRuleID, ent.ApprovalRuleID.ToString()).ToString();
                hypPanelMembers.Target = "_blank";
            }
        }

        protected void lvMDApprovalRule_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ApprovalRuleID;

            Int64.TryParse(e.CommandArgument.ToString(), out ApprovalRuleID);

            if (ApprovalRuleID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ApprovalRuleID = ApprovalRuleID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalRuleEntity.FLD_NAME_ApprovalRuleID, ApprovalRuleID.ToString(), SQLMatchType.Equal);

                        MDApprovalRuleEntity mDApprovalRuleEntity = new MDApprovalRuleEntity();


                        result = FCCMDApprovalRule.GetFacadeCreate().Delete(mDApprovalRuleEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ApprovalRuleID = 0;
                            _MDApprovalRuleEntity = new MDApprovalRuleEntity();
                            PrepareInitialView();
                            BindMDApprovalRuleList();

                            MiscUtil.ShowMessage(lblMessage, "Approval Rule has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Approval Rule.", true);
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

        protected void odsMDApprovalRule_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDApprovalRuleEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ApprovalRuleID = 0;
            _MDApprovalRuleEntity = new MDApprovalRuleEntity();
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
