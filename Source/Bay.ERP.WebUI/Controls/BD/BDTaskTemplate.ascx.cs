// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public partial class BDTaskTemplateControl : BaseControl
    {       
        #region Properties

        public Int64 _TaskTemplateID
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

        public BDTaskTemplateEntity _BDTaskTemplateEntity
        {
            get
            {
                BDTaskTemplateEntity entity = new BDTaskTemplateEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDTaskTemplateEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDTaskTemplateEntity CurrentBDTaskTemplateEntity
        {
            get
            {
                if (_TaskTemplateID > 0)
                {
                    if (_BDTaskTemplateEntity.TaskTemplateID != _TaskTemplateID)
                    {
                        _BDTaskTemplateEntity = FCCBDTaskTemplate.GetFacadeCreate().GetByID(_TaskTemplateID);
                    }
                }

                return _BDTaskTemplateEntity;
            }
            set
            {
                _BDTaskTemplateEntity = value;
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

            txtTemplateName.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDTaskTemplateEntity bDTaskTemplateEntity = CurrentBDTaskTemplateEntity;


            if (!bDTaskTemplateEntity.IsNew)
            {
                txtTemplateName.Text = bDTaskTemplateEntity.TemplateName.ToString();
                txtRemarks.Text = bDTaskTemplateEntity.Remarks.ToString();
                chkIsRemoved.Checked = bDTaskTemplateEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDTaskTemplateList();
        }

        private void BindBDTaskTemplateList()
        {
            lvBDTaskTemplate.DataBind();
        }

        private BDTaskTemplateEntity BuildBDTaskTemplateEntity()
        {
            BDTaskTemplateEntity bDTaskTemplateEntity = CurrentBDTaskTemplateEntity;

            bDTaskTemplateEntity.TemplateName = txtTemplateName.Text.Trim();
            bDTaskTemplateEntity.Remarks = txtRemarks.Text.Trim();
            bDTaskTemplateEntity.IsRemoved = chkIsRemoved.Checked;


            return bDTaskTemplateEntity;
        }

        private void SaveBDTaskTemplateEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDTaskTemplateEntity bDTaskTemplateEntity = BuildBDTaskTemplateEntity();

                    Int64 result = -1;

                    if (bDTaskTemplateEntity.IsNew)
                    {
                        result = FCCBDTaskTemplate.GetFacadeCreate().Add(bDTaskTemplateEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDTaskTemplateEntity.FLD_NAME_TaskTemplateID, bDTaskTemplateEntity.TaskTemplateID.ToString(), SQLMatchType.Equal);
                        result = FCCBDTaskTemplate.GetFacadeCreate().Update(bDTaskTemplateEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _TaskTemplateID = 0;
                        _BDTaskTemplateEntity = new BDTaskTemplateEntity();
                        PrepareInitialView();
                        BindBDTaskTemplateList();

                        String navUrl = UrlHelper.BuildSecureUrl("~/BD/BDTaskTemplateItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_TASK_TEMPLATE_ID, result.ToString()).ToString();
                        Response.Redirect(navUrl);

                        if (bDTaskTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Task Template Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Task Template Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDTaskTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Task Template Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Task Template Information.", false);
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

        protected void lvBDTaskTemplate_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                BDTaskTemplateEntity ent = (BDTaskTemplateEntity)dataItem.DataItem;

                HyperLink hypTemplate = (HyperLink)e.Item.FindControl("hypTemplate");

                hypTemplate.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDTaskTemplateItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_TASK_TEMPLATE_ID, ent.TaskTemplateID.ToString()).ToString();
            }
        }


        protected void lvBDTaskTemplate_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 TaskTemplateID;

            Int64.TryParse(e.CommandArgument.ToString(), out TaskTemplateID);

            if (TaskTemplateID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _TaskTemplateID = TaskTemplateID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDTaskTemplateEntity.FLD_NAME_TaskTemplateID, TaskTemplateID.ToString(), SQLMatchType.Equal);

                        BDTaskTemplateEntity bDTaskTemplateEntity = new BDTaskTemplateEntity();


                        result = FCCBDTaskTemplate.GetFacadeCreate().Delete(bDTaskTemplateEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _TaskTemplateID = 0;
                            _BDTaskTemplateEntity = new BDTaskTemplateEntity();
                            PrepareInitialView();
                            BindBDTaskTemplateList();

                            MiscUtil.ShowMessage(lblMessage, "Task Template has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Task Template.", true);
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

        protected void odsBDTaskTemplate_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDTaskTemplateEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _TaskTemplateID = 0;
            _BDTaskTemplateEntity = new BDTaskTemplateEntity();
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
