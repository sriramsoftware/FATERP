// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class PRMPreBOQTemplateControl : BaseControl
    {       
        #region Properties

        public Int64 _PreBOQTemplateID
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

        public PRMPreBOQTemplateEntity _PRMPreBOQTemplateEntity
        {
            get
            {
                PRMPreBOQTemplateEntity entity = new PRMPreBOQTemplateEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMPreBOQTemplateEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMPreBOQTemplateEntity CurrentPRMPreBOQTemplateEntity
        {
            get
            {
                if (_PreBOQTemplateID > 0)
                {
                    if (_PRMPreBOQTemplateEntity.PreBOQTemplateID != _PreBOQTemplateID)
                    {
                        _PRMPreBOQTemplateEntity = FCCPRMPreBOQTemplate.GetFacadeCreate().GetByID(_PreBOQTemplateID);
                    }
                }

                return _PRMPreBOQTemplateEntity;
            }
            set
            {
                _PRMPreBOQTemplateEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity = CurrentPRMPreBOQTemplateEntity;


            if (!pRMPreBOQTemplateEntity.IsNew)
            {
                txtTemplateName.Text = pRMPreBOQTemplateEntity.TemplateName.ToString();
                chkIsRemoved.Checked = pRMPreBOQTemplateEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMPreBOQTemplateList();
        }

        private void BindPRMPreBOQTemplateList()
        {
            lvPRMPreBOQTemplate.DataBind();
        }

        private PRMPreBOQTemplateEntity BuildPRMPreBOQTemplateEntity()
        {
            PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity = CurrentPRMPreBOQTemplateEntity;

            pRMPreBOQTemplateEntity.TemplateName = txtTemplateName.Text.Trim();
            pRMPreBOQTemplateEntity.IsRemoved = chkIsRemoved.Checked;


            return pRMPreBOQTemplateEntity;
        }

        private void SavePRMPreBOQTemplateEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity = BuildPRMPreBOQTemplateEntity();

                    Int64 result = -1;

                    if (pRMPreBOQTemplateEntity.IsNew)
                    {
                        result = FCCPRMPreBOQTemplate.GetFacadeCreate().Add(pRMPreBOQTemplateEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQTemplateEntity.FLD_NAME_PreBOQTemplateID, pRMPreBOQTemplateEntity.PreBOQTemplateID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMPreBOQTemplate.GetFacadeCreate().Update(pRMPreBOQTemplateEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PreBOQTemplateID = 0;
                        _PRMPreBOQTemplateEntity = new PRMPreBOQTemplateEntity();
                        PrepareInitialView();
                        BindPRMPreBOQTemplateList();

                        if (pRMPreBOQTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "BOQ Template Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "BOQ Template Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMPreBOQTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add BOQ Template Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update BOQ Template Information.", false);
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

        protected void lvPRMPreBOQTemplate_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMPreBOQTemplateEntity ent = (PRMPreBOQTemplateEntity)dataItem.DataItem;

                HyperLink hypTemplate= (HyperLink)e.Item.FindControl("hypTemplate");

                hypTemplate.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMPreBOQTemplateItemMap.aspx", string.Empty, PRMPreBOQTemplateEntity.FLD_NAME_PreBOQTemplateID, ent.PreBOQTemplateID.ToString()).ToString();
            }
        }

        protected void lvPRMPreBOQTemplate_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 PreBOQTemplateID;

            Int64.TryParse(e.CommandArgument.ToString(), out PreBOQTemplateID);

            if (PreBOQTemplateID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _PreBOQTemplateID = PreBOQTemplateID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQTemplateEntity.FLD_NAME_PreBOQTemplateID, PreBOQTemplateID.ToString(), SQLMatchType.Equal);

                        PRMPreBOQTemplateEntity pRMPreBOQTemplateEntity = new PRMPreBOQTemplateEntity();


                        result = FCCPRMPreBOQTemplate.GetFacadeCreate().Delete(pRMPreBOQTemplateEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _PreBOQTemplateID = 0;
                            _PRMPreBOQTemplateEntity = new PRMPreBOQTemplateEntity();
                            PrepareInitialView();
                            BindPRMPreBOQTemplateList();

                            MiscUtil.ShowMessage(lblMessage, "BOQ Template has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete BOQ Template.", true);
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

        protected void odsPRMPreBOQTemplate_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMPreBOQTemplateEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _PreBOQTemplateID = 0;
            _PRMPreBOQTemplateEntity = new PRMPreBOQTemplateEntity();
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
