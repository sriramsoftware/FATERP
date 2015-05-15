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
    public partial class BDProjectHistoryStandaloneControl : BaseControl
    {       
        #region Properties

        public Int64 _ProjectHistoryID
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

        public BDProjectHistoryEntity _BDProjectHistoryEntity
        {
            get
            {
                BDProjectHistoryEntity entity = new BDProjectHistoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDProjectHistoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDProjectHistoryEntity CurrentBDProjectHistoryEntity
        {
            get
            {
                if (_ProjectHistoryID > 0)
                {
                    if (_BDProjectHistoryEntity.ProjectHistoryID != _ProjectHistoryID)
                    {
                        _BDProjectHistoryEntity = FCCBDProjectHistory.GetFacadeCreate().GetByID(_ProjectHistoryID);
                    }
                }

                return _BDProjectHistoryEntity;
            }
            set
            {
                _BDProjectHistoryEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtHistoryDate.Text = DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtDescription.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtEntryDate.Text = DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            BDProjectHistoryEntity bDProjectHistoryEntity = CurrentBDProjectHistoryEntity;


            if (!bDProjectHistoryEntity.IsNew)
            {
                if (ddlProjectID.Items.Count > 0 && bDProjectHistoryEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = bDProjectHistoryEntity.ProjectID.ToString();
                }

                txtHistoryDate.Text = bDProjectHistoryEntity.HistoryDate.ToStringDefault();
                txtDescription.Text = bDProjectHistoryEntity.Description.ToString();
                txtRemarks.Text = bDProjectHistoryEntity.Remarks.ToString();
                txtEntryDate.Text = bDProjectHistoryEntity.EntryDate.ToStringDefault();
                chkIsRemoved.Checked = bDProjectHistoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDProjectHistoryList();
        }

        private void BindBDProjectHistoryList()
        {
            lvBDProjectHistory.DataBind();
        }

        private BDProjectHistoryEntity BuildBDProjectHistoryEntity()
        {
            BDProjectHistoryEntity bDProjectHistoryEntity = CurrentBDProjectHistoryEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    bDProjectHistoryEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }
            
            if (txtHistoryDate.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectHistoryEntity.HistoryDate = MiscUtil.ParseToDateTime(txtHistoryDate.Text);
            }

            bDProjectHistoryEntity.Description = txtDescription.Text.Trim();
            bDProjectHistoryEntity.Remarks = txtRemarks.Text.Trim();
            if (txtEntryDate.Text.Trim().IsNotNullOrEmpty())
            {
                bDProjectHistoryEntity.EntryDate = MiscUtil.ParseToDateTime(txtEntryDate.Text);
            }

            bDProjectHistoryEntity.IsRemoved = chkIsRemoved.Checked;


            return bDProjectHistoryEntity;
        }

        private void SaveBDProjectHistoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDProjectHistoryEntity bDProjectHistoryEntity = BuildBDProjectHistoryEntity();

                    Int64 result = -1;

                    if (bDProjectHistoryEntity.IsNew)
                    {
                        result = FCCBDProjectHistory.GetFacadeCreate().Add(bDProjectHistoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDProjectHistoryEntity.FLD_NAME_ProjectHistoryID, bDProjectHistoryEntity.ProjectHistoryID.ToString(), SQLMatchType.Equal);
                        result = FCCBDProjectHistory.GetFacadeCreate().Update(bDProjectHistoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProjectHistoryID = 0;
                        _BDProjectHistoryEntity = new BDProjectHistoryEntity();
                        PrepareInitialView();
                        BindBDProjectHistoryList();

                        if (bDProjectHistoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project History Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project History Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDProjectHistoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project History Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Project History Information.", false);
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

        protected void lvBDProjectHistory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProjectHistoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProjectHistoryID);

            if (ProjectHistoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProjectHistoryID = ProjectHistoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectHistoryEntity.FLD_NAME_ProjectHistoryID, ProjectHistoryID.ToString(), SQLMatchType.Equal);

                        BDProjectHistoryEntity bDProjectHistoryEntity = new BDProjectHistoryEntity();


                        result = FCCBDProjectHistory.GetFacadeCreate().Delete(bDProjectHistoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProjectHistoryID = 0;
                            _BDProjectHistoryEntity = new BDProjectHistoryEntity();
                            PrepareInitialView();
                            BindBDProjectHistoryList();

                            MiscUtil.ShowMessage(lblMessage, "Project History has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Project History.", true);
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

        protected void odsBDProjectHistory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDProjectHistoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProjectHistoryID = 0;
            _BDProjectHistoryEntity = new BDProjectHistoryEntity();
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
