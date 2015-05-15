// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public partial class KBUserTreeModifiedHistoryControl : BaseControl
    {       
        #region Properties

        public Int64 _UserTreeHistoryID
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

        public KBUserTreeModifiedHistoryEntity _KBUserTreeModifiedHistoryEntity
        {
            get
            {
                KBUserTreeModifiedHistoryEntity entity = new KBUserTreeModifiedHistoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (KBUserTreeModifiedHistoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private KBUserTreeModifiedHistoryEntity CurrentKBUserTreeModifiedHistoryEntity
        {
            get
            {
                if (_UserTreeHistoryID > 0)
                {
                    if (_KBUserTreeModifiedHistoryEntity.UserTreeHistoryID != _UserTreeHistoryID)
                    {
                        _KBUserTreeModifiedHistoryEntity = FCCKBUserTreeModifiedHistory.GetFacadeCreate().GetByID(_UserTreeHistoryID);
                    }
                }

                return _KBUserTreeModifiedHistoryEntity;
            }
            set
            {
                _KBUserTreeModifiedHistoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateKBUserTree(ddlUserTreeID, false);
            MiscUtil.PopulateHREmployee(ddlCreatedByEmployeeID, true);
            MiscUtil.PopulateHREmployee(ddlOwnerEmployeeID, true);
            MiscUtil.PopulateKBMDUserTreeStatus(ddlUserTreeStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            chkIsDocumentNodeType.Checked = false;
            txtTitle.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtReferenceID.Text = String.Empty;
            txtTagKeyword.Text = String.Empty;
            chkIsStarred.Checked = false;
            txtCreateDate.Text = String.Empty;
            txtDocumentSize.Text = String.Empty;
            txtLastModifiedDate.Text = String.Empty;
            txtCountViewState.Text = String.Empty;
            txtModifiedDate.Text = String.Empty;
            txtModifiedEmployeeID.Text = String.Empty;
            txtIP.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity = CurrentKBUserTreeModifiedHistoryEntity;


            if (!kBUserTreeModifiedHistoryEntity.IsNew)
            {
                if (ddlUserTreeID.Items.Count > 0 && kBUserTreeModifiedHistoryEntity.UserTreeID != null)
                {
                    ddlUserTreeID.SelectedValue = kBUserTreeModifiedHistoryEntity.UserTreeID.ToString();
                }

                chkIsDocumentNodeType.Checked = kBUserTreeModifiedHistoryEntity.IsDocumentNodeType;
                txtTitle.Text = kBUserTreeModifiedHistoryEntity.Title.ToString();
                txtDescription.Text = kBUserTreeModifiedHistoryEntity.Description.ToString();
                txtReferenceID.Text = kBUserTreeModifiedHistoryEntity.ReferenceID.ToString();
                txtTagKeyword.Text = kBUserTreeModifiedHistoryEntity.TagKeyword.ToString();
                chkIsStarred.Checked = kBUserTreeModifiedHistoryEntity.IsStarred;
                if (ddlCreatedByEmployeeID.Items.Count > 0 && kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID != null)
                {
                    ddlCreatedByEmployeeID.SelectedValue = kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID.ToString();
                }

                txtCreateDate.Text = kBUserTreeModifiedHistoryEntity.CreateDate.ToStringDefault();
                if (ddlOwnerEmployeeID.Items.Count > 0 && kBUserTreeModifiedHistoryEntity.OwnerEmployeeID != null)
                {
                    ddlOwnerEmployeeID.SelectedValue = kBUserTreeModifiedHistoryEntity.OwnerEmployeeID.ToString();
                }

                txtDocumentSize.Text = kBUserTreeModifiedHistoryEntity.DocumentSize.ToString();
                txtLastModifiedDate.Text = kBUserTreeModifiedHistoryEntity.LastModifiedDate.ToStringDefault();
                if (ddlUserTreeStatusID.Items.Count > 0 && kBUserTreeModifiedHistoryEntity.UserTreeStatusID != null)
                {
                    ddlUserTreeStatusID.SelectedValue = kBUserTreeModifiedHistoryEntity.UserTreeStatusID.ToString();
                }

                txtCountViewState.Text = kBUserTreeModifiedHistoryEntity.CountViewState.ToString();
                txtModifiedDate.Text = kBUserTreeModifiedHistoryEntity.ModifiedDate.ToStringDefault();
                txtModifiedEmployeeID.Text = kBUserTreeModifiedHistoryEntity.ModifiedEmployeeID.ToString();
                txtIP.Text = kBUserTreeModifiedHistoryEntity.IP.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindKBUserTreeModifiedHistoryList();
        }

        private void BindKBUserTreeModifiedHistoryList()
        {
            lvKBUserTreeModifiedHistory.DataBind();
        }

        private KBUserTreeModifiedHistoryEntity BuildKBUserTreeModifiedHistoryEntity()
        {
            KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity = CurrentKBUserTreeModifiedHistoryEntity;

            if (ddlUserTreeID.Items.Count > 0)
            {
                if (ddlUserTreeID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeModifiedHistoryEntity.UserTreeID = Int64.Parse(ddlUserTreeID.SelectedValue);
                }
            }

            kBUserTreeModifiedHistoryEntity.IsDocumentNodeType = chkIsDocumentNodeType.Checked;

            kBUserTreeModifiedHistoryEntity.Title = txtTitle.Text.Trim();
            kBUserTreeModifiedHistoryEntity.Description = txtDescription.Text.Trim();
            if (!txtReferenceID.Text.Trim().IsNullOrEmpty())
            {
                kBUserTreeModifiedHistoryEntity.ReferenceID = Int64.Parse(txtReferenceID.Text.Trim());
            }
            else
            {
                kBUserTreeModifiedHistoryEntity.ReferenceID = null;
            }

            kBUserTreeModifiedHistoryEntity.TagKeyword = txtTagKeyword.Text.Trim();
            kBUserTreeModifiedHistoryEntity.IsStarred = chkIsStarred.Checked;

            if (ddlCreatedByEmployeeID.Items.Count > 0)
            {
                if (ddlCreatedByEmployeeID.SelectedValue == "0")
                {
                    kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID = null;
                }
                else
                {
                    kBUserTreeModifiedHistoryEntity.CreatedByEmployeeID = Int64.Parse(ddlCreatedByEmployeeID.SelectedValue);
                }
            }

            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                kBUserTreeModifiedHistoryEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }
            else
            {
                kBUserTreeModifiedHistoryEntity.CreateDate = null;
            }

            if (ddlOwnerEmployeeID.Items.Count > 0)
            {
                if (ddlOwnerEmployeeID.SelectedValue == "0")
                {
                    kBUserTreeModifiedHistoryEntity.OwnerEmployeeID = null;
                }
                else
                {
                    kBUserTreeModifiedHistoryEntity.OwnerEmployeeID = Int64.Parse(ddlOwnerEmployeeID.SelectedValue);
                }
            }

            if (!txtDocumentSize.Text.Trim().IsNullOrEmpty())
            {
                kBUserTreeModifiedHistoryEntity.DocumentSize = Decimal.Parse(txtDocumentSize.Text.Trim());
            }
            else
            {
                kBUserTreeModifiedHistoryEntity.DocumentSize = null;
            }

            if (txtLastModifiedDate.Text.Trim().IsNotNullOrEmpty())
            {
                kBUserTreeModifiedHistoryEntity.LastModifiedDate = MiscUtil.ParseToDateTime(txtLastModifiedDate.Text);
            }
            else
            {
                kBUserTreeModifiedHistoryEntity.LastModifiedDate = null;
            }

            if (ddlUserTreeStatusID.Items.Count > 0)
            {
                if (ddlUserTreeStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    kBUserTreeModifiedHistoryEntity.UserTreeStatusID = Int64.Parse(ddlUserTreeStatusID.SelectedValue);
                }
            }

            if (!txtCountViewState.Text.Trim().IsNullOrEmpty())
            {
                kBUserTreeModifiedHistoryEntity.CountViewState = Int64.Parse(txtCountViewState.Text.Trim());
            }

            if (txtModifiedDate.Text.Trim().IsNotNullOrEmpty())
            {
                kBUserTreeModifiedHistoryEntity.ModifiedDate = MiscUtil.ParseToDateTime(txtModifiedDate.Text);
            }

            if (!txtModifiedEmployeeID.Text.Trim().IsNullOrEmpty())
            {
                kBUserTreeModifiedHistoryEntity.ModifiedEmployeeID = Int64.Parse(txtModifiedEmployeeID.Text.Trim());
            }

            kBUserTreeModifiedHistoryEntity.IP = txtIP.Text.Trim();

            return kBUserTreeModifiedHistoryEntity;
        }

        private void SaveKBUserTreeModifiedHistoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity = BuildKBUserTreeModifiedHistoryEntity();

                    Int64 result = -1;

                    if (kBUserTreeModifiedHistoryEntity.IsNew)
                    {
                        result = FCCKBUserTreeModifiedHistory.GetFacadeCreate().Add(kBUserTreeModifiedHistoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeModifiedHistoryEntity.FLD_NAME_UserTreeHistoryID, kBUserTreeModifiedHistoryEntity.UserTreeHistoryID.ToString(), SQLMatchType.Equal);
                        result = FCCKBUserTreeModifiedHistory.GetFacadeCreate().Update(kBUserTreeModifiedHistoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _UserTreeHistoryID = 0;
                        _KBUserTreeModifiedHistoryEntity = new KBUserTreeModifiedHistoryEntity();
                        PrepareInitialView();
                        BindKBUserTreeModifiedHistoryList();

                        if (kBUserTreeModifiedHistoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Modified History Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Modified History Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (kBUserTreeModifiedHistoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add K BUser Tree Modified History Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update K BUser Tree Modified History Information.", false);
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

        protected void lvKBUserTreeModifiedHistory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 UserTreeHistoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out UserTreeHistoryID);

            if (UserTreeHistoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _UserTreeHistoryID = UserTreeHistoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBUserTreeModifiedHistoryEntity.FLD_NAME_UserTreeHistoryID, UserTreeHistoryID.ToString(), SQLMatchType.Equal);

                        KBUserTreeModifiedHistoryEntity kBUserTreeModifiedHistoryEntity = new KBUserTreeModifiedHistoryEntity();


                        result = FCCKBUserTreeModifiedHistory.GetFacadeCreate().Delete(kBUserTreeModifiedHistoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _UserTreeHistoryID = 0;
                            _KBUserTreeModifiedHistoryEntity = new KBUserTreeModifiedHistoryEntity();
                            PrepareInitialView();
                            BindKBUserTreeModifiedHistoryList();

                            MiscUtil.ShowMessage(lblMessage, "K BUser Tree Modified History has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete K BUser Tree Modified History.", true);
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

        protected void odsKBUserTreeModifiedHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveKBUserTreeModifiedHistoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _UserTreeHistoryID = 0;
            _KBUserTreeModifiedHistoryEntity = new KBUserTreeModifiedHistoryEntity();
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
