// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class CMProjectScheduleTemplateControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectScheduleTemplateID
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

        public CMProjectScheduleTemplateEntity _CMProjectScheduleTemplateEntity
        {
            get
            {
                CMProjectScheduleTemplateEntity entity = new CMProjectScheduleTemplateEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMProjectScheduleTemplateEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMProjectScheduleTemplateEntity CurrentCMProjectScheduleTemplateEntity
        {
            get
            {
                if (_ProjectScheduleTemplateID > 0)
                {
                    if (_CMProjectScheduleTemplateEntity.ProjectScheduleTemplateID != _ProjectScheduleTemplateID)
                    {
                        _CMProjectScheduleTemplateEntity = FCCCMProjectScheduleTemplate.GetFacadeCreate().GetByID(_ProjectScheduleTemplateID);
                    }
                }

                return _CMProjectScheduleTemplateEntity;
            }
            set
            {
                _CMProjectScheduleTemplateEntity = value;
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
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity = CurrentCMProjectScheduleTemplateEntity;


            if (!cMProjectScheduleTemplateEntity.IsNew)
            {
                txtTemplateName.Text = cMProjectScheduleTemplateEntity.TemplateName.ToString();
                txtDescription.Text = cMProjectScheduleTemplateEntity.Description.ToString();
                chkIsRemoved.Checked = cMProjectScheduleTemplateEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMProjectScheduleTemplateList();
        }

        private void BindCMProjectScheduleTemplateList()
        {
            lvCMProjectScheduleTemplate.DataBind();
        }

        private CMProjectScheduleTemplateEntity BuildCMProjectScheduleTemplateEntity()
        {
            CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity = CurrentCMProjectScheduleTemplateEntity;

            cMProjectScheduleTemplateEntity.TemplateName = txtTemplateName.Text.Trim();
            cMProjectScheduleTemplateEntity.Description = txtDescription.Text.Trim();
            cMProjectScheduleTemplateEntity.IsRemoved = chkIsRemoved.Checked;


            return cMProjectScheduleTemplateEntity;
        }

        private void SaveCMProjectScheduleTemplateEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity = BuildCMProjectScheduleTemplateEntity();

                    Int64 result = -1;

                    if (cMProjectScheduleTemplateEntity.IsNew)
                    {
                        result = FCCCMProjectScheduleTemplate.GetFacadeCreate().Add(cMProjectScheduleTemplateEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateEntity.FLD_NAME_ProjectScheduleTemplateID, cMProjectScheduleTemplateEntity.ProjectScheduleTemplateID.ToString(), SQLMatchType.Equal);
                        result = FCCCMProjectScheduleTemplate.GetFacadeCreate().Update(cMProjectScheduleTemplateEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectScheduleTemplateID = 0;
                        _CMProjectScheduleTemplateEntity = new CMProjectScheduleTemplateEntity();
                        PrepareInitialView();
                        BindCMProjectScheduleTemplateList();

                        if (cMProjectScheduleTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Schedule Template Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Schedule Template Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMProjectScheduleTemplateEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Schedule Template Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Schedule Template Information.", false);
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

        protected void lvCMProjectScheduleTemplate_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CMProjectScheduleTemplateEntity ent = (CMProjectScheduleTemplateEntity)dataItem.DataItem;

                HyperLink hypProject = (HyperLink)e.Item.FindControl("hypTemplate");

                hypProject.NavigateUrl = UrlHelper.BuildSecureUrl("~/CM/CMProjectScheduleTemplateItemMap.aspx", string.Empty, CMProjectScheduleTemplateEntity.FLD_NAME_ProjectScheduleTemplateID, ent.ProjectScheduleTemplateID.ToString()).ToString();
            }
        }

        protected void lvCMProjectScheduleTemplate_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectScheduleTemplateID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectScheduleTemplateID);

            if (ProjectScheduleTemplateID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectScheduleTemplateID = ProjectScheduleTemplateID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMProjectScheduleTemplateEntity.FLD_NAME_ProjectScheduleTemplateID, ProjectScheduleTemplateID.ToString(), SQLMatchType.Equal);

                        CMProjectScheduleTemplateEntity cMProjectScheduleTemplateEntity = new CMProjectScheduleTemplateEntity();


                        result = FCCCMProjectScheduleTemplate.GetFacadeCreate().Delete(cMProjectScheduleTemplateEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectScheduleTemplateID = 0;
                            _CMProjectScheduleTemplateEntity = new CMProjectScheduleTemplateEntity();
                            PrepareInitialView();
                            BindCMProjectScheduleTemplateList();

                            MiscUtil.ShowMessage(lblMessage, "Project Schedule Template has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Schedule Template.", true);
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

        protected void odsCMProjectScheduleTemplate_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMProjectScheduleTemplateEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectScheduleTemplateID = 0;
            _CMProjectScheduleTemplateEntity = new CMProjectScheduleTemplateEntity();
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
