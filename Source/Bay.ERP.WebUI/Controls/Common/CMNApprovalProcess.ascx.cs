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
    public partial class CMNApprovalProcessControl : BaseControl
    {       
        #region Properties

        public Int64 _ApprovalProcessID
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

        public CMNApprovalProcessEntity _CMNApprovalProcessEntity
        {
            get
            {
                CMNApprovalProcessEntity entity = new CMNApprovalProcessEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNApprovalProcessEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNApprovalProcessEntity CurrentCMNApprovalProcessEntity
        {
            get
            {
                if (_ApprovalProcessID > 0)
                {
                    if (_CMNApprovalProcessEntity.ApprovalProcessID != _ApprovalProcessID)
                    {
                        _CMNApprovalProcessEntity = FCCCMNApprovalProcess.GetFacadeCreate().GetByID(_ApprovalProcessID);
                    }
                }

                return _CMNApprovalProcessEntity;
            }
            set
            {
                _CMNApprovalProcessEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDApprovalProcessType(ddlApprovalProcessTypeID, false);
            MiscUtil.PopulateMDApprovalProcessStatus(ddlApprovalProcessStatusID, false);
            MiscUtil.PopulateMDApprovalProcessPriority(ddlApprovalProcessPriorityID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtReferenceID.Text = String.Empty;
            txtCreateDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMNApprovalProcessEntity cMNApprovalProcessEntity = CurrentCMNApprovalProcessEntity;


            if (!cMNApprovalProcessEntity.IsNew)
            {
                txtReferenceID.Text = cMNApprovalProcessEntity.ReferenceID.ToString();
                if (ddlApprovalProcessTypeID.Items.Count > 0 && cMNApprovalProcessEntity.ApprovalProcessTypeID != null)
                {
                    ddlApprovalProcessTypeID.SelectedValue = cMNApprovalProcessEntity.ApprovalProcessTypeID.ToString();
                }

                txtCreateDate.Text = cMNApprovalProcessEntity.CreateDate.ToStringDefault();
                if (ddlApprovalProcessStatusID.Items.Count > 0 && cMNApprovalProcessEntity.ApprovalProcessStatusID != null)
                {
                    ddlApprovalProcessStatusID.SelectedValue = cMNApprovalProcessEntity.ApprovalProcessStatusID.ToString();
                }

                if (ddlApprovalProcessPriorityID.Items.Count > 0 && cMNApprovalProcessEntity.ApprovalProcessPriorityID != null)
                {
                    ddlApprovalProcessPriorityID.SelectedValue = cMNApprovalProcessEntity.ApprovalProcessPriorityID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNApprovalProcessList();
        }

        private void BindCMNApprovalProcessList()
        {
            lvCMNApprovalProcess.DataBind();
        }

        private CMNApprovalProcessEntity BuildCMNApprovalProcessEntity()
        {
            CMNApprovalProcessEntity cMNApprovalProcessEntity = CurrentCMNApprovalProcessEntity;

            if (!txtReferenceID.Text.Trim().IsNullOrEmpty())
            {
                cMNApprovalProcessEntity.ReferenceID = Int64.Parse(txtReferenceID.Text.Trim());
            }

            if (ddlApprovalProcessTypeID.Items.Count > 0)
            {
                if (ddlApprovalProcessTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNApprovalProcessEntity.ApprovalProcessTypeID = Int64.Parse(ddlApprovalProcessTypeID.SelectedValue);
                }
            }

            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMNApprovalProcessEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            if (ddlApprovalProcessStatusID.Items.Count > 0)
            {
                if (ddlApprovalProcessStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNApprovalProcessEntity.ApprovalProcessStatusID = Int64.Parse(ddlApprovalProcessStatusID.SelectedValue);
                }
            }

            if (ddlApprovalProcessPriorityID.Items.Count > 0)
            {
                if (ddlApprovalProcessPriorityID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNApprovalProcessEntity.ApprovalProcessPriorityID = Int64.Parse(ddlApprovalProcessPriorityID.SelectedValue);
                }
            }


            return cMNApprovalProcessEntity;
        }

        private void SaveCMNApprovalProcessEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNApprovalProcessEntity cMNApprovalProcessEntity = BuildCMNApprovalProcessEntity();

                    Int64 result = -1;

                    if (cMNApprovalProcessEntity.IsNew)
                    {
                        result = FCCCMNApprovalProcess.GetFacadeCreate().Add(cMNApprovalProcessEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNApprovalProcessEntity.FLD_NAME_ApprovalProcessID, cMNApprovalProcessEntity.ApprovalProcessID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNApprovalProcess.GetFacadeCreate().Update(cMNApprovalProcessEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ApprovalProcessID = 0;
                        _CMNApprovalProcessEntity = new CMNApprovalProcessEntity();
                        PrepareInitialView();
                        BindCMNApprovalProcessList();

                        if (cMNApprovalProcessEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNApproval Process Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNApproval Process Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNApprovalProcessEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNApproval Process Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNApproval Process Information.", false);
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

        protected void lvCMNApprovalProcess_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ApprovalProcessID;

            Int64.TryParse(e.CommandArgument.ToString(), out ApprovalProcessID);

            if (ApprovalProcessID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ApprovalProcessID = ApprovalProcessID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNApprovalProcessEntity.FLD_NAME_ApprovalProcessID, ApprovalProcessID.ToString(), SQLMatchType.Equal);

                        CMNApprovalProcessEntity cMNApprovalProcessEntity = new CMNApprovalProcessEntity();


                        result = FCCCMNApprovalProcess.GetFacadeCreate().Delete(cMNApprovalProcessEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ApprovalProcessID = 0;
                            _CMNApprovalProcessEntity = new CMNApprovalProcessEntity();
                            PrepareInitialView();
                            BindCMNApprovalProcessList();

                            MiscUtil.ShowMessage(lblMessage, "C MNApproval Process has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNApproval Process.", true);
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

        protected void odsCMNApprovalProcess_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNApprovalProcessEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ApprovalProcessID = 0;
            _CMNApprovalProcessEntity = new CMNApprovalProcessEntity();
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
