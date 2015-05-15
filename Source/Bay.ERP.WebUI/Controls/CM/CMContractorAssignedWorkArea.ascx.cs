// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jun-2012, 10:26:50




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
    public partial class CMContractorAssignedWorkAreaControl : BaseControl
    {       
        #region Properties

        public Int64 _ContractorAssignedWorkAreaID
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

        public CMContractorAssignedWorkAreaEntity _CMContractorAssignedWorkAreaEntity
        {
            get
            {
                CMContractorAssignedWorkAreaEntity entity = new CMContractorAssignedWorkAreaEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMContractorAssignedWorkAreaEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMContractorAssignedWorkAreaEntity CurrentCMContractorAssignedWorkAreaEntity
        {
            get
            {
                if (_ContractorAssignedWorkAreaID > 0)
                {
                    if (_CMContractorAssignedWorkAreaEntity.ContractorAssignedWorkAreaID != _ContractorAssignedWorkAreaID)
                    {
                        _CMContractorAssignedWorkAreaEntity = FCCCMContractorAssignedWorkArea.GetFacadeCreate().GetByID(_ContractorAssignedWorkAreaID);
                    }
                }

                return _CMContractorAssignedWorkAreaEntity;
            }
            set
            {
                _CMContractorAssignedWorkAreaEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMContractor(ddlContractorID, false);
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateCMWorkAreaStatus(ddlWorkAreaStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtWorkDescription.Text = String.Empty;
            txtStartDate.Text = String.Empty;
            txtEndDate.Text = String.Empty;
            txtActualStartDate.Text = String.Empty;
            txtActualEndDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity = CurrentCMContractorAssignedWorkAreaEntity;


            if (!cMContractorAssignedWorkAreaEntity.IsNew)
            {
                if (ddlContractorID.Items.Count > 0 && cMContractorAssignedWorkAreaEntity.ContractorID != null)
                {
                    ddlContractorID.SelectedValue = cMContractorAssignedWorkAreaEntity.ContractorID.ToString();
                }

                if (ddlProjectID.Items.Count > 0 && cMContractorAssignedWorkAreaEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cMContractorAssignedWorkAreaEntity.ProjectID.ToString();
                }

                txtWorkDescription.Text = cMContractorAssignedWorkAreaEntity.WorkDescription.ToString();
                if (ddlWorkAreaStatusID.Items.Count > 0 && cMContractorAssignedWorkAreaEntity.WorkAreaStatusID != null)
                {
                    ddlWorkAreaStatusID.SelectedValue = cMContractorAssignedWorkAreaEntity.WorkAreaStatusID.ToString();
                }

                txtStartDate.Text = cMContractorAssignedWorkAreaEntity.StartDate.ToStringDefault();
                txtEndDate.Text = cMContractorAssignedWorkAreaEntity.EndDate.ToStringDefault();
                txtActualStartDate.Text = cMContractorAssignedWorkAreaEntity.ActualStartDate.ToStringDefault();
                txtActualEndDate.Text = cMContractorAssignedWorkAreaEntity.ActualEndDate.ToStringDefault();
                txtRemarks.Text = cMContractorAssignedWorkAreaEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMContractorAssignedWorkAreaList();
        }

        private void BindCMContractorAssignedWorkAreaList()
        {
            lvCMContractorAssignedWorkArea.DataBind();
        }

        private CMContractorAssignedWorkAreaEntity BuildCMContractorAssignedWorkAreaEntity()
        {
            CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity = CurrentCMContractorAssignedWorkAreaEntity;

            if (ddlContractorID.Items.Count > 0)
            {
                if (ddlContractorID.SelectedValue == "0")
                {
                }
                else
                {
                    cMContractorAssignedWorkAreaEntity.ContractorID = Int64.Parse(ddlContractorID.SelectedValue);
                }
            }

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    cMContractorAssignedWorkAreaEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            cMContractorAssignedWorkAreaEntity.WorkDescription = txtWorkDescription.Text.Trim();
            if (ddlWorkAreaStatusID.Items.Count > 0)
            {
                if (ddlWorkAreaStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cMContractorAssignedWorkAreaEntity.WorkAreaStatusID = Int64.Parse(ddlWorkAreaStatusID.SelectedValue);
                }
            }

            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMContractorAssignedWorkAreaEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }
            else
            {
                cMContractorAssignedWorkAreaEntity.StartDate = null;
            }

            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMContractorAssignedWorkAreaEntity.EndDate = MiscUtil.ParseToDateTime(txtEndDate.Text);
            }
            else
            {
                cMContractorAssignedWorkAreaEntity.EndDate = null;
            }

            if (txtActualStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMContractorAssignedWorkAreaEntity.ActualStartDate = MiscUtil.ParseToDateTime(txtActualStartDate.Text);
            }
            else
            {
                cMContractorAssignedWorkAreaEntity.ActualStartDate = null;
            }

            if (txtActualEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMContractorAssignedWorkAreaEntity.ActualEndDate = MiscUtil.ParseToDateTime(txtActualEndDate.Text);
            }
            else
            {
                cMContractorAssignedWorkAreaEntity.ActualEndDate = null;
            }

            cMContractorAssignedWorkAreaEntity.Remarks = txtRemarks.Text.Trim();

            return cMContractorAssignedWorkAreaEntity;
        }

        private void SaveCMContractorAssignedWorkAreaEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity = BuildCMContractorAssignedWorkAreaEntity();

                    Int64 result = -1;

                    if (cMContractorAssignedWorkAreaEntity.IsNew)
                    {
                        result = FCCCMContractorAssignedWorkArea.GetFacadeCreate().Add(cMContractorAssignedWorkAreaEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMContractorAssignedWorkAreaEntity.FLD_NAME_ContractorAssignedWorkAreaID, cMContractorAssignedWorkAreaEntity.ContractorAssignedWorkAreaID.ToString(), SQLMatchType.Equal);
                        result = FCCCMContractorAssignedWorkArea.GetFacadeCreate().Update(cMContractorAssignedWorkAreaEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ContractorAssignedWorkAreaID = 0;
                        _CMContractorAssignedWorkAreaEntity = new CMContractorAssignedWorkAreaEntity();
                        PrepareInitialView();
                        BindCMContractorAssignedWorkAreaList();

                        if (cMContractorAssignedWorkAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MContractor Assigned Work Area Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MContractor Assigned Work Area Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMContractorAssignedWorkAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MContractor Assigned Work Area Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MContractor Assigned Work Area Information.", false);
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

        protected void lvCMContractorAssignedWorkArea_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ContractorAssignedWorkAreaID;

            Int64.TryParse(e.CommandArgument.ToString(), out ContractorAssignedWorkAreaID);

            if (ContractorAssignedWorkAreaID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ContractorAssignedWorkAreaID = ContractorAssignedWorkAreaID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMContractorAssignedWorkAreaEntity.FLD_NAME_ContractorAssignedWorkAreaID, ContractorAssignedWorkAreaID.ToString(), SQLMatchType.Equal);

                        CMContractorAssignedWorkAreaEntity cMContractorAssignedWorkAreaEntity = new CMContractorAssignedWorkAreaEntity();


                        result = FCCCMContractorAssignedWorkArea.GetFacadeCreate().Delete(cMContractorAssignedWorkAreaEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ContractorAssignedWorkAreaID = 0;
                            _CMContractorAssignedWorkAreaEntity = new CMContractorAssignedWorkAreaEntity();
                            PrepareInitialView();
                            BindCMContractorAssignedWorkAreaList();

                            MiscUtil.ShowMessage(lblMessage, "C MContractor Assigned Work Area has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MContractor Assigned Work Area.", true);
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

        protected void odsCMContractorAssignedWorkArea_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMContractorAssignedWorkAreaEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ContractorAssignedWorkAreaID = 0;
            _CMContractorAssignedWorkAreaEntity = new CMContractorAssignedWorkAreaEntity();
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
