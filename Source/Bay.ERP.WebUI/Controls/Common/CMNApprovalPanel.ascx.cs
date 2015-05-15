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
    public partial class CMNApprovalPanelControl : BaseControl
    {       
        #region Properties

        public Int64 _ApprovalPanelID
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

        public CMNApprovalPanelEntity _CMNApprovalPanelEntity
        {
            get
            {
                CMNApprovalPanelEntity entity = new CMNApprovalPanelEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNApprovalPanelEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNApprovalPanelEntity CurrentCMNApprovalPanelEntity
        {
            get
            {
                if (_ApprovalPanelID > 0)
                {
                    if (_CMNApprovalPanelEntity.ApprovalPanelID != _ApprovalPanelID)
                    {
                        _CMNApprovalPanelEntity = FCCCMNApprovalPanel.GetFacadeCreate().GetByID(_ApprovalPanelID);
                    }
                }

                return _CMNApprovalPanelEntity;
            }
            set
            {
                _CMNApprovalPanelEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMNApprovalProcess(ddlApprovalProcessID, false);
            MiscUtil.PopulateHREmployee(ddlEmployeeID, false);
            MiscUtil.PopulateMDApprovalPanelStatus(ddlApprovalPanelStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtSequeenceNo.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            txtRequestDate.Text = String.Empty;
            txtResponseDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMNApprovalPanelEntity cMNApprovalPanelEntity = CurrentCMNApprovalPanelEntity;


            if (!cMNApprovalPanelEntity.IsNew)
            {
                if (ddlApprovalProcessID.Items.Count > 0 && cMNApprovalPanelEntity.ApprovalProcessID != null)
                {
                    ddlApprovalProcessID.SelectedValue = cMNApprovalPanelEntity.ApprovalProcessID.ToString();
                }

                if (ddlEmployeeID.Items.Count > 0 && cMNApprovalPanelEntity.EmployeeID != null)
                {
                    ddlEmployeeID.SelectedValue = cMNApprovalPanelEntity.EmployeeID.ToString();
                }

                txtSequeenceNo.Text = cMNApprovalPanelEntity.SequeenceNo.ToString();
                if (ddlApprovalPanelStatusID.Items.Count > 0 && cMNApprovalPanelEntity.ApprovalPanelStatusID != null)
                {
                    ddlApprovalPanelStatusID.SelectedValue = cMNApprovalPanelEntity.ApprovalPanelStatusID.ToString();
                }

                txtRemarks.Text = cMNApprovalPanelEntity.Remarks.ToString();
                txtRequestDate.Text = cMNApprovalPanelEntity.RequestDate.ToStringDefault();
                txtResponseDate.Text = cMNApprovalPanelEntity.ResponseDate.ToStringDefault();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNApprovalPanelList();
        }

        private void BindCMNApprovalPanelList()
        {
            lvCMNApprovalPanel.DataBind();
        }

        private CMNApprovalPanelEntity BuildCMNApprovalPanelEntity()
        {
            CMNApprovalPanelEntity cMNApprovalPanelEntity = CurrentCMNApprovalPanelEntity;

            if (ddlApprovalProcessID.Items.Count > 0)
            {
                if (ddlApprovalProcessID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNApprovalPanelEntity.ApprovalProcessID = Int64.Parse(ddlApprovalProcessID.SelectedValue);
                }
            }

            if (ddlEmployeeID.Items.Count > 0)
            {
                if (ddlEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNApprovalPanelEntity.EmployeeID = Int64.Parse(ddlEmployeeID.SelectedValue);
                }
            }

            if (!txtSequeenceNo.Text.Trim().IsNullOrEmpty())
            {
                cMNApprovalPanelEntity.SequeenceNo = Int32.Parse(txtSequeenceNo.Text.Trim());
            }

            if (ddlApprovalPanelStatusID.Items.Count > 0)
            {
                if (ddlApprovalPanelStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cMNApprovalPanelEntity.ApprovalPanelStatusID = Int64.Parse(ddlApprovalPanelStatusID.SelectedValue);
                }
            }

            cMNApprovalPanelEntity.Remarks = txtRemarks.Text.Trim();
            if (txtRequestDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMNApprovalPanelEntity.RequestDate = MiscUtil.ParseToDateTime(txtRequestDate.Text);
            }

            if (txtResponseDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMNApprovalPanelEntity.ResponseDate = MiscUtil.ParseToDateTime(txtResponseDate.Text);
            }
            else
            {
                cMNApprovalPanelEntity.ResponseDate = null;
            }


            return cMNApprovalPanelEntity;
        }

        private void SaveCMNApprovalPanelEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNApprovalPanelEntity cMNApprovalPanelEntity = BuildCMNApprovalPanelEntity();

                    Int64 result = -1;

                    if (cMNApprovalPanelEntity.IsNew)
                    {
                        result = FCCCMNApprovalPanel.GetFacadeCreate().Add(cMNApprovalPanelEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNApprovalPanelEntity.FLD_NAME_ApprovalPanelID, cMNApprovalPanelEntity.ApprovalPanelID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNApprovalPanel.GetFacadeCreate().Update(cMNApprovalPanelEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ApprovalPanelID = 0;
                        _CMNApprovalPanelEntity = new CMNApprovalPanelEntity();
                        PrepareInitialView();
                        BindCMNApprovalPanelList();

                        if (cMNApprovalPanelEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNApproval Panel Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MNApproval Panel Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNApprovalPanelEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MNApproval Panel Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MNApproval Panel Information.", false);
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

        protected void lvCMNApprovalPanel_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ApprovalPanelID;

            Int64.TryParse(e.CommandArgument.ToString(), out ApprovalPanelID);

            if (ApprovalPanelID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ApprovalPanelID = ApprovalPanelID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNApprovalPanelEntity.FLD_NAME_ApprovalPanelID, ApprovalPanelID.ToString(), SQLMatchType.Equal);

                        CMNApprovalPanelEntity cMNApprovalPanelEntity = new CMNApprovalPanelEntity();


                        result = FCCCMNApprovalPanel.GetFacadeCreate().Delete(cMNApprovalPanelEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ApprovalPanelID = 0;
                            _CMNApprovalPanelEntity = new CMNApprovalPanelEntity();
                            PrepareInitialView();
                            BindCMNApprovalPanelList();

                            MiscUtil.ShowMessage(lblMessage, "C MNApproval Panel has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MNApproval Panel.", true);
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

        protected void odsCMNApprovalPanel_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNApprovalPanelEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ApprovalPanelID = 0;
            _CMNApprovalPanelEntity = new CMNApprovalPanelEntity();
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
