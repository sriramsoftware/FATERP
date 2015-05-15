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
using AjaxControlToolkit;
using System.Web.UI;
using System.IO;
using System.Web;
using System.Data;

namespace Bay.ERP.Web.UI
{
    public partial class BDProjectCollectedDocumentInfoControl : ProjectBaseControl
    {       
        #region Properties

        public Int64 _ProjectCollectedDocumentID
        {
            get
            {
                Int64 id = 0;

                if (treeDocument.SelectedNode != null)
                {
                    BayTreeNodeValue bayTreeNodeValue = new BayTreeNodeValue();
                    bayTreeNodeValue.SetValuesFromString(treeDocument.SelectedValue);

                    Int64.TryParse(bayTreeNodeValue.Value, out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public BDProjectCollectedDocumentInfoEntity _BDProjectCollectedDocumentInfoEntity
        {
            get
            {
                BDProjectCollectedDocumentInfoEntity entity = new BDProjectCollectedDocumentInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectCollectedDocumentInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectCollectedDocumentInfoEntity CurrentBDProjectCollectedDocumentInfoEntity
        {
            get
            {
                if (_ProjectCollectedDocumentID > 0)
                {
                    //if (_BDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID != _ProjectCollectedDocumentInfoID)
                    //{
                    String fe_1 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectDocumentID, _ProjectCollectedDocumentID.ToString(), SQLMatchType.Equal);
                        String fe_2 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);
                        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe_1, SQLJoinType.AND, fe_2);

                        IList<BDProjectCollectedDocumentInfoEntity> tempList = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (tempList != null && tempList.Count > 0)
                        {
                            _BDProjectCollectedDocumentInfoEntity = tempList[0];
                        }
                        else
                        {
                            _BDProjectCollectedDocumentInfoEntity = new BDProjectCollectedDocumentInfoEntity();
                        }
                    //}
                }

                return _BDProjectCollectedDocumentInfoEntity;
            }
            set
            {
                _BDProjectCollectedDocumentInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDStandardTimeUnit(ddlRequiredTimeStandardTimeUnitID, true);
            MiscUtil.PopulateMDStandardTimeUnit(ddlReminderBeforeStandardTimeUnitID, true);
            MiscUtil.PopulateMDProjectCollectedDocumentStatus(ddlProjectCollectedDocumentStatusID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            PrepareInitialViewForm();

            treeDocument.ProjectID = this.OverviewProjectID;
            treeDocument.BuildTree();
        }

        private void PrepareInitialViewForm()
        {
            BuildDropDownList();

            txtStartDate.Text = String.Empty;
            txtRequiredTime.Text = String.Empty;
            txtReminderBefore.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity = CurrentBDProjectCollectedDocumentInfoEntity;


            if (!bDProjectCollectedDocumentInfoEntity.IsNew)
            {
                txtStartDate.Text = bDProjectCollectedDocumentInfoEntity.StartDate.ToStringDefault();
                txtRequiredTime.Text = bDProjectCollectedDocumentInfoEntity.RequiredTime.ToString();

                if (ddlRequiredTimeStandardTimeUnitID.Items.Count > 0 && bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID != null)
                {
                    ddlRequiredTimeStandardTimeUnitID.SelectedValue = bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID.ToString();
                }

                txtReminderBefore.Text = bDProjectCollectedDocumentInfoEntity.ReminderBefore.ToString();

                if (ddlReminderBeforeStandardTimeUnitID.Items.Count > 0 && bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID != null)
                {
                    ddlReminderBeforeStandardTimeUnitID.SelectedValue = bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID.ToString();
                }

                if (ddlProjectCollectedDocumentStatusID.Items.Count > 0 && bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID != null)
                {
                    ddlProjectCollectedDocumentStatusID.SelectedValue = bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID.ToString();
                }

                txtRemarks.Text = bDProjectCollectedDocumentInfoEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
            }
           
        }

        private BDProjectCollectedDocumentInfoEntity BuildBDProjectCollectedDocumentInfoEntity()
        {
            BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity = CurrentBDProjectCollectedDocumentInfoEntity;
            bDProjectCollectedDocumentInfoEntity.ProjectDocumentID = _ProjectCollectedDocumentID;
            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectCollectedDocumentInfoEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }
            else
            {
                bDProjectCollectedDocumentInfoEntity.StartDate = null;
            }

            if (!txtRequiredTime.Text.Trim().IsNullOrEmpty())
            {
                bDProjectCollectedDocumentInfoEntity.RequiredTime = Int32.Parse(txtRequiredTime.Text.Trim());
            }
            else
            {
                bDProjectCollectedDocumentInfoEntity.RequiredTime = null;
            }

            if (ddlRequiredTimeStandardTimeUnitID.Items.Count > 0)
            {
                if (ddlRequiredTimeStandardTimeUnitID.SelectedValue == "0")
                {
                    bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID = null;
                }
                else
                {
                    bDProjectCollectedDocumentInfoEntity.RequiredTimeStandardTimeUnitID = Int64.Parse(ddlRequiredTimeStandardTimeUnitID.SelectedValue);
                }
            }

            if (!txtReminderBefore.Text.Trim().IsNullOrEmpty())
            {
                bDProjectCollectedDocumentInfoEntity.ReminderBefore = Int32.Parse(txtReminderBefore.Text.Trim());
            }
            else
            {
                bDProjectCollectedDocumentInfoEntity.ReminderBefore = null;
            }

            if (ddlReminderBeforeStandardTimeUnitID.Items.Count > 0)
            {
                if (ddlReminderBeforeStandardTimeUnitID.SelectedValue == "0")
                {
                    bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID = null;
                }
                else
                {
                    bDProjectCollectedDocumentInfoEntity.ReminderBeforeStandardTimeUnitID = Int64.Parse(ddlReminderBeforeStandardTimeUnitID.SelectedValue);
                }
            }

            if (ddlProjectCollectedDocumentStatusID.Items.Count > 0)
            {
                if (ddlProjectCollectedDocumentStatusID.SelectedValue == "0")
                {
                    bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID = null;
                }
                else
                {
                    bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentStatusID = Int64.Parse(ddlProjectCollectedDocumentStatusID.SelectedValue);
                }
            }

            bDProjectCollectedDocumentInfoEntity.Remarks = txtRemarks.Text.Trim();

            return bDProjectCollectedDocumentInfoEntity;
        }

        private void SaveBDProjectCollectedDocumentInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity = BuildBDProjectCollectedDocumentInfoEntity();

                    Int64 result = -1;

                    if (bDProjectCollectedDocumentInfoEntity.IsNew)
                    {
                        result = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().Add(bDProjectCollectedDocumentInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectCollectedDocumentInfoID, bDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().Update(bDProjectCollectedDocumentInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectCollectedDocumentID = 0;
                        _BDProjectCollectedDocumentInfoEntity = new BDProjectCollectedDocumentInfoEntity();
                        PrepareInitialViewForm();
                        PrepareEditView();

                        if (bDProjectCollectedDocumentInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectCollectedDocumentInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Collected Document Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project Collected Document Info Information.", false);
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
            afuFiles.UploadedComplete += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedComplete);
            afuFiles.UploadedFileError += new EventHandler<AsyncFileUploadEventArgs>(afuFiles_UploadedFileError);

            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }
        
        #endregion

        #region Tree Events

        protected void treeDocument_SelectedNodeChanged(object sender, EventArgs e)
        {
            BayTreeNodeValue bayTreeNodeValue = new BayTreeNodeValue();
            bayTreeNodeValue.SetValuesFromString(treeDocument.SelectedValue);

            if (bayTreeNodeValue.Attributes["NodeType"] == CustomControlConstants.DocumentNodeType.Document)
            {
                divUpdatePanel.Visible = true;
                PrepareInitialViewForm();
                PrepareEditView();
                BindBDProjectCollectedDocumentUploadInfoList();
            }
            else
            {
                divUpdatePanel.Visible = false;
            }
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectCollectedDocumentInfoEntity();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            BindBDProjectCollectedDocumentUploadInfoList();
        }

        #endregion

        #region File Uploader Events

        protected void afuFiles_UploadedComplete(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "size", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Uploaded size: " + AsyncFileUpload1.FileBytes.Length.ToString() + "';", true);

            // Uncomment to save to AsyncFileUpload\Uploads folder.
            // ASP.NET must have the necessary permissions to write to the file system.



            BDProjectCollectedDocumentUploadInfoEntity ent =  new BDProjectCollectedDocumentUploadInfoEntity();
            ent.ProjectCollectedDocumentInfoID = CurrentBDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID;// _BDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID;
            ent.OriginalFileName = Path.GetFileName(e.FileName);
            ent.CurrentFileName = Guid.NewGuid().ToString() + Path.GetExtension(e.FileName);
            ent.FileType = "";
            ent.Extension = Path.GetExtension(e.FileName);
            ent.Path = FileUploadConstants.Project.DOCUMENTS + ent.CurrentFileName;
            ent.Remarks = String.Empty;

            FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

            // file upload

            afuFiles.SaveAs(Server.MapPath(ent.Path));
            //LoadFileListGried
            BindBDProjectCollectedDocumentUploadInfoList();
        }

        protected void afuFiles_UploadedFileError(object sender, AsyncFileUploadEventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "error", "top.$get(\"" + uploadResult.ClientID + "\").innerHTML = 'Error: " + e.StatusMessage + "';", true);
        }

        private void BindBDProjectCollectedDocumentUploadInfoList()
        {
            lvBDProjectCollectedDocumentUploadInfo.DataBind();
        }

        #endregion

        #region ObjectDataSource Event

        protected void odsBDProjectCollectedDocumentUploadInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentUploadInfoEntity.FLD_NAME_ProjectCollectedDocumentInfoID,CurrentBDProjectCollectedDocumentInfoEntity.ProjectCollectedDocumentInfoID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region ListViewEvent

        //protected void lvBDProject_ItemDataBound(object sender, ListViewItemEventArgs e)
        //{
        //    if (e.Item.ItemType == ListViewItemType.DataItem)
        //    {
        //        ListViewDataItem dataItem = (ListViewDataItem)e.Item;

        //        BDProjectEntity ent = (BDProjectEntity)dataItem.DataItem;

        //        HyperLink hypUploadedFile = (HyperLink)e.Item.FindControl("hypUploadedFile");

        //        hypUploadedFile.NavigateUrl = UrlHelper.BuildSecureUrl("~/BD/BDProjectEditor.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, ent.ProjectID.ToString()).ToString();
        //        hypUploadedFile.Target = "_blank";
        //    }
        //}

        protected void lvBDProjectCollectedDocumentUploadInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectCollectedDocumentUploadInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectCollectedDocumentUploadInfoID);

            if (ProjectCollectedDocumentUploadInfoID > 0)
            {

                if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentUploadInfoEntity.FLD_NAME_ProjectCollectedDocumentUploadInfoID, ProjectCollectedDocumentUploadInfoID.ToString(), SQLMatchType.Equal);

                        BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity = FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().GetByID(ProjectCollectedDocumentUploadInfoID);
                        
                        result = FCCBDProjectCollectedDocumentUploadInfo.GetFacadeCreate().Delete(bDProjectCollectedDocumentUploadInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            if (File.Exists(Server.MapPath(bDProjectCollectedDocumentUploadInfoEntity.Path)))
                            {
                                File.Delete(Server.MapPath(bDProjectCollectedDocumentUploadInfoEntity.Path));
                            }

                            BindBDProjectCollectedDocumentUploadInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Project Collected Document Upload Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project Collected Document Upload Info.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion

        #endregion Event
    }
}
