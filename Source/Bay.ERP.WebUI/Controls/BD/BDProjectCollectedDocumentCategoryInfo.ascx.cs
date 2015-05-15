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
    public partial class BDProjectCollectedDocumentCategoryInfoControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectCollectedDocumentCategoryInfoID
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

        public BDProjectCollectedDocumentCategoryInfoEntity _BDProjectCollectedDocumentCategoryInfoEntity
        {
            get
            {
                BDProjectCollectedDocumentCategoryInfoEntity entity = new BDProjectCollectedDocumentCategoryInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectCollectedDocumentCategoryInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectCollectedDocumentCategoryInfoEntity CurrentBDProjectCollectedDocumentCategoryInfoEntity
        {
            get
            {
                if (_ProjectCollectedDocumentCategoryInfoID > 0)
                {
                    if (_BDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentCategoryInfoID != _ProjectCollectedDocumentCategoryInfoID)
                    {
                        _BDProjectCollectedDocumentCategoryInfoEntity = FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().GetByID(_ProjectCollectedDocumentCategoryInfoID);
                    }
                }

                return _BDProjectCollectedDocumentCategoryInfoEntity;
            }
            set
            {
                _BDProjectCollectedDocumentCategoryInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateMDProjectDocumentCategory(ddlProjectDocumentCategoryID, false);
            MiscUtil.PopulateMDProjectCollectedDocumentStatus(ddlProjectCollectedDocumentStatusID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtStartDate.Text = String.Empty;
            txtRequiredTime.Text = String.Empty;
            txtReminder.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectCollectedDocumentCategoryInfoEntity bDProjectCollectedDocumentCategoryInfoEntity = CurrentBDProjectCollectedDocumentCategoryInfoEntity;


            if (!bDProjectCollectedDocumentCategoryInfoEntity.IsNew)
            {
                if (ddlProjectID.Items.Count > 0 && bDProjectCollectedDocumentCategoryInfoEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = bDProjectCollectedDocumentCategoryInfoEntity.ProjectID.ToString();
                }

                if (ddlProjectDocumentCategoryID.Items.Count > 0 && bDProjectCollectedDocumentCategoryInfoEntity.ProjectDocumentCategoryID != null)
                {
                    ddlProjectDocumentCategoryID.SelectedValue = bDProjectCollectedDocumentCategoryInfoEntity.ProjectDocumentCategoryID.ToString();
                }

                txtStartDate.Text = bDProjectCollectedDocumentCategoryInfoEntity.StartDate.ToStringDefault();
                txtRequiredTime.Text = bDProjectCollectedDocumentCategoryInfoEntity.RequiredTime.ToString();
                txtReminder.Text = bDProjectCollectedDocumentCategoryInfoEntity.Reminder.ToString();
                if (ddlProjectCollectedDocumentStatusID.Items.Count > 0 && bDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentStatusID != null)
                {
                    ddlProjectCollectedDocumentStatusID.SelectedValue = bDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentStatusID.ToString();
                }

                txtRemarks.Text = bDProjectCollectedDocumentCategoryInfoEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectCollectedDocumentCategoryInfoList();
        }

        private void BindBDProjectCollectedDocumentCategoryInfoList()
        {
            lvBDProjectCollectedDocumentCategoryInfo.DataBind();
        }

        private BDProjectCollectedDocumentCategoryInfoEntity BuildBDProjectCollectedDocumentCategoryInfoEntity()
        {
            BDProjectCollectedDocumentCategoryInfoEntity bDProjectCollectedDocumentCategoryInfoEntity = CurrentBDProjectCollectedDocumentCategoryInfoEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectCollectedDocumentCategoryInfoEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (ddlProjectDocumentCategoryID.Items.Count > 0)
            {
                if (ddlProjectDocumentCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectCollectedDocumentCategoryInfoEntity.ProjectDocumentCategoryID = Int64.Parse(ddlProjectDocumentCategoryID.SelectedValue);
                }
            }

            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectCollectedDocumentCategoryInfoEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }
            else
            {
                bDProjectCollectedDocumentCategoryInfoEntity.StartDate = null;
            }

            if (!txtRequiredTime.Text.Trim().IsNullOrEmpty())
            {
                bDProjectCollectedDocumentCategoryInfoEntity.RequiredTime = Int32.Parse(txtRequiredTime.Text.Trim());
            }
            else
            {
                bDProjectCollectedDocumentCategoryInfoEntity.RequiredTime = null;
            }

            if (!txtReminder.Text.Trim().IsNullOrEmpty())
            {
                bDProjectCollectedDocumentCategoryInfoEntity.Reminder = Int32.Parse(txtReminder.Text.Trim());
            }
            else
            {
                bDProjectCollectedDocumentCategoryInfoEntity.Reminder = null;
            }

            if (ddlProjectCollectedDocumentStatusID.Items.Count > 0)
            {
                if (ddlProjectCollectedDocumentStatusID.SelectedValue == "0")
                {
                    bDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentStatusID = null;
                }
                else
                {
                    bDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentStatusID = Int64.Parse(ddlProjectCollectedDocumentStatusID.SelectedValue);
                }
            }

            bDProjectCollectedDocumentCategoryInfoEntity.Remarks = txtRemarks.Text.Trim();

            return bDProjectCollectedDocumentCategoryInfoEntity;
        }

        private void SaveBDProjectCollectedDocumentCategoryInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectCollectedDocumentCategoryInfoEntity bDProjectCollectedDocumentCategoryInfoEntity = BuildBDProjectCollectedDocumentCategoryInfoEntity();

                    Int64 result = -1;

                    if (bDProjectCollectedDocumentCategoryInfoEntity.IsNew)
                    {
                        result = FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().Add(bDProjectCollectedDocumentCategoryInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentCategoryInfoEntity.FLD_NAME_ProjectCollectedDocumentCategoryInfoID, bDProjectCollectedDocumentCategoryInfoEntity.ProjectCollectedDocumentCategoryInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().Update(bDProjectCollectedDocumentCategoryInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectCollectedDocumentCategoryInfoID = 0;
                        _BDProjectCollectedDocumentCategoryInfoEntity = new BDProjectCollectedDocumentCategoryInfoEntity();
                        PrepareInitialView();
                        BindBDProjectCollectedDocumentCategoryInfoList();

                        if (bDProjectCollectedDocumentCategoryInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Category Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Category Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectCollectedDocumentCategoryInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Collected Document Category Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Collected Document Category Info Information.", false);
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

        protected void lvBDProjectCollectedDocumentCategoryInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectCollectedDocumentCategoryInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectCollectedDocumentCategoryInfoID);

            if (ProjectCollectedDocumentCategoryInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectCollectedDocumentCategoryInfoID = ProjectCollectedDocumentCategoryInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentCategoryInfoEntity.FLD_NAME_ProjectCollectedDocumentCategoryInfoID, ProjectCollectedDocumentCategoryInfoID.ToString(), SQLMatchType.Equal);

                        BDProjectCollectedDocumentCategoryInfoEntity bDProjectCollectedDocumentCategoryInfoEntity = new BDProjectCollectedDocumentCategoryInfoEntity();


                        result = FCCBDProjectCollectedDocumentCategoryInfo.GetFacadeCreate().Delete(bDProjectCollectedDocumentCategoryInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectCollectedDocumentCategoryInfoID = 0;
                            _BDProjectCollectedDocumentCategoryInfoEntity = new BDProjectCollectedDocumentCategoryInfoEntity();
                            PrepareInitialView();
                            BindBDProjectCollectedDocumentCategoryInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Category Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Collected Document Category Info.", true);
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

        protected void odsBDProjectCollectedDocumentCategoryInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentCategoryInfoEntity.FLD_NAME_ProjectID, UrlConstants.OVERVIEW_PROJECT_ID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectCollectedDocumentCategoryInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectCollectedDocumentCategoryInfoID = 0;
            _BDProjectCollectedDocumentCategoryInfoEntity = new BDProjectCollectedDocumentCategoryInfoEntity();
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
