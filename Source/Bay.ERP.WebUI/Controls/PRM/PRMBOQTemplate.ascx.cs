// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public partial class PRMBOQTemplateControl : BaseControl
    {       
        #region Properties

        public Int64 _BOQTemplateID
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

        public PRMBOQTemplateEntity _PRMBOQTemplateEntity
        {
            get
            {
                PRMBOQTemplateEntity entity = new PRMBOQTemplateEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMBOQTemplateEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMBOQTemplateEntity CurrentPRMBOQTemplateEntity
        {
            get
            {
                if (_BOQTemplateID > 0)
                {
                    if (_PRMBOQTemplateEntity.BOQTemplateID != _BOQTemplateID)
                    {
                        _PRMBOQTemplateEntity = FCCPRMBOQTemplate.GetFacadeCreate().GetByID(_BOQTemplateID);
                    }
                }

                return _PRMBOQTemplateEntity;
            }
            set
            {
                _PRMBOQTemplateEntity = value;
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
            PRMBOQTemplateEntity pRMBOQTemplateEntity = CurrentPRMBOQTemplateEntity;


            if (!pRMBOQTemplateEntity.IsNew)
            {
                txtTemplateName.Text = pRMBOQTemplateEntity.TemplateName.ToString();
                chkIsRemoved.Checked = pRMBOQTemplateEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindPRMBOQTemplateList();
        }

        private void BindPRMBOQTemplateList()
        {
            lvPRMBOQTemplate.DataBind();
        }

        private PRMBOQTemplateEntity BuildPRMBOQTemplateEntity()
        {
            PRMBOQTemplateEntity pRMBOQTemplateEntity = CurrentPRMBOQTemplateEntity;

            pRMBOQTemplateEntity.TemplateName = txtTemplateName.Text.Trim();
            pRMBOQTemplateEntity.IsRemoved = chkIsRemoved.Checked;


            return pRMBOQTemplateEntity;
        }

        private void SavePRMBOQTemplateEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMBOQTemplateEntity pRMBOQTemplateEntity = BuildPRMBOQTemplateEntity();

                    Int64 result = -1;

                    if (pRMBOQTemplateEntity.IsNew)
                    {
                        result = FCCPRMBOQTemplate.GetFacadeCreate().Add(pRMBOQTemplateEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQTemplateEntity.FLD_NAME_BOQTemplateID, pRMBOQTemplateEntity.BOQTemplateID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMBOQTemplate.GetFacadeCreate().Update(pRMBOQTemplateEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BOQTemplateID = 0;
                        _PRMBOQTemplateEntity = new PRMBOQTemplateEntity();
                        PrepareInitialView();
                        BindPRMBOQTemplateList();

                        if (pRMBOQTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "B OQTemplate Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "B OQTemplate Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMBOQTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add B OQTemplate Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update B OQTemplate Information.", false);
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

        protected void lvPRMBOQTemplate_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMBOQTemplateEntity ent = (PRMBOQTemplateEntity)dataItem.DataItem;

                HyperLink hypTemplate = (HyperLink)e.Item.FindControl("hypTemplateName");

                hypTemplate.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMBOQTemplateItemMap.aspx", string.Empty, PRMBOQTemplateEntity.FLD_NAME_BOQTemplateID, ent.BOQTemplateID.ToString()).ToString();
            }
        }

        protected void lvPRMBOQTemplate_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BOQTemplateID;

            Int64.TryParse(e.CommandArgument.ToString(), out BOQTemplateID);

            if (BOQTemplateID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BOQTemplateID = BOQTemplateID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQTemplateEntity.FLD_NAME_BOQTemplateID, BOQTemplateID.ToString(), SQLMatchType.Equal);

                        PRMBOQTemplateEntity pRMBOQTemplateEntity = new PRMBOQTemplateEntity();


                        result = FCCPRMBOQTemplate.GetFacadeCreate().Delete(pRMBOQTemplateEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BOQTemplateID = 0;
                            _PRMBOQTemplateEntity = new PRMBOQTemplateEntity();
                            PrepareInitialView();
                            BindPRMBOQTemplateList();

                            MiscUtil.ShowMessage(lblMessage, "B OQTemplate has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete B OQTemplate.", true);
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

        protected void odsPRMBOQTemplate_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMBOQTemplateEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BOQTemplateID = 0;
            _PRMBOQTemplateEntity = new PRMBOQTemplateEntity();
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
