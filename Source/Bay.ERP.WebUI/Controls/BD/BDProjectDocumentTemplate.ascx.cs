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
    public partial class BDProjectDocumentTemplateControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectDocumentTemplateID
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

        public BDProjectDocumentTemplateEntity _BDProjectDocumentTemplateEntity
        {
            get
            {
                BDProjectDocumentTemplateEntity entity = new BDProjectDocumentTemplateEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectDocumentTemplateEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectDocumentTemplateEntity CurrentBDProjectDocumentTemplateEntity
        {
            get
            {
                if (_ProjectDocumentTemplateID > 0)
                {
                    if (_BDProjectDocumentTemplateEntity.ProjectDocumentTemplateID != _ProjectDocumentTemplateID)
                    {
                        _BDProjectDocumentTemplateEntity = FCCBDProjectDocumentTemplate.GetFacadeCreate().GetByID(_ProjectDocumentTemplateID);
                    }
                }

                return _BDProjectDocumentTemplateEntity;
            }
            set
            {
                _BDProjectDocumentTemplateEntity = value;
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
            BDProjectDocumentTemplateEntity bDProjectDocumentTemplateEntity = CurrentBDProjectDocumentTemplateEntity;


            if (!bDProjectDocumentTemplateEntity.IsNew)
            {
                txtTemplateName.Text = bDProjectDocumentTemplateEntity.TemplateName.ToString();
                txtRemarks.Text = bDProjectDocumentTemplateEntity.Remarks.ToString();
                chkIsRemoved.Checked = bDProjectDocumentTemplateEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectDocumentTemplateList();
        }

        private void BindBDProjectDocumentTemplateList()
        {
            lvBDProjectDocumentTemplate.DataBind();
        }

        private BDProjectDocumentTemplateEntity BuildBDProjectDocumentTemplateEntity()
        {
            BDProjectDocumentTemplateEntity bDProjectDocumentTemplateEntity = CurrentBDProjectDocumentTemplateEntity;

            bDProjectDocumentTemplateEntity.TemplateName = txtTemplateName.Text.Trim();
            bDProjectDocumentTemplateEntity.Remarks = txtRemarks.Text.Trim();
            bDProjectDocumentTemplateEntity.IsRemoved = chkIsRemoved.Checked;


            return bDProjectDocumentTemplateEntity;
        }

        private void SaveBDProjectDocumentTemplateEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectDocumentTemplateEntity bDProjectDocumentTemplateEntity = BuildBDProjectDocumentTemplateEntity();

                    Int64 result = -1;

                    if (bDProjectDocumentTemplateEntity.IsNew)
                    {
                        result = FCCBDProjectDocumentTemplate.GetFacadeCreate().Add(bDProjectDocumentTemplateEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectDocumentTemplateEntity.FLD_NAME_ProjectDocumentTemplateID, bDProjectDocumentTemplateEntity.ProjectDocumentTemplateID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectDocumentTemplate.GetFacadeCreate().Update(bDProjectDocumentTemplateEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectDocumentTemplateID = 0;
                        _BDProjectDocumentTemplateEntity = new BDProjectDocumentTemplateEntity();
                        PrepareInitialView();
                        BindBDProjectDocumentTemplateList();

                        if (bDProjectDocumentTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Document Template Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Document Template Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectDocumentTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Document Template Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Document Template Information.", false);
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

        protected void lvBDProjectDocumentTemplate_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                BDProjectDocumentTemplateEntity ent = (BDProjectDocumentTemplateEntity)dataItem.DataItem;

                HyperLink hypProject = (HyperLink)e.Item.FindControl("hypTemplate");

                hypProject.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectDocumentTemplateMap.aspx", string.Empty,BDProjectDocumentTemplateEntity.FLD_NAME_ProjectDocumentTemplateID, ent.ProjectDocumentTemplateID.ToString()).ToString();                
            }
        }

        protected void lvBDProjectDocumentTemplate_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectDocumentTemplateID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectDocumentTemplateID);

            if (ProjectDocumentTemplateID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectDocumentTemplateID = ProjectDocumentTemplateID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectDocumentTemplateEntity.FLD_NAME_ProjectDocumentTemplateID, ProjectDocumentTemplateID.ToString(), SQLMatchType.Equal);

                        BDProjectDocumentTemplateEntity bDProjectDocumentTemplateEntity = new BDProjectDocumentTemplateEntity();


                        result = FCCBDProjectDocumentTemplate.GetFacadeCreate().Delete(bDProjectDocumentTemplateEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectDocumentTemplateID = 0;
                            _BDProjectDocumentTemplateEntity = new BDProjectDocumentTemplateEntity();
                            PrepareInitialView();
                            BindBDProjectDocumentTemplateList();

                            MiscUtil.ShowMessage(lblMessage, "Project Document Template has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Document Template.", true);
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

        protected void odsBDProjectDocumentTemplate_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectDocumentTemplateEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectDocumentTemplateID = 0;
            _BDProjectDocumentTemplateEntity = new BDProjectDocumentTemplateEntity();
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
