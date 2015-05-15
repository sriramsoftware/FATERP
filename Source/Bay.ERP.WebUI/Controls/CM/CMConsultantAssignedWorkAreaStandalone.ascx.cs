// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    public partial class CMConsultantAssignedWorkAreaStandaloneControl : BaseControl
    {       
        #region Properties

        public Int64 _ConsultantAssignedWorkAreaID
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

        public CMConsultantAssignedWorkAreaEntity _CMConsultantAssignedWorkAreaEntity
        {
            get
            {
                CMConsultantAssignedWorkAreaEntity entity = new CMConsultantAssignedWorkAreaEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMConsultantAssignedWorkAreaEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMConsultantAssignedWorkAreaEntity CurrentCMConsultantAssignedWorkAreaEntity
        {
            get
            {
                if (_ConsultantAssignedWorkAreaID > 0)
                {
                    if (_CMConsultantAssignedWorkAreaEntity.ConsultantAssignedWorkAreaID != _ConsultantAssignedWorkAreaID)
                    {
                        _CMConsultantAssignedWorkAreaEntity = FCCCMConsultantAssignedWorkArea.GetFacadeCreate().GetByID(_ConsultantAssignedWorkAreaID);
                    }
                }

                return _CMConsultantAssignedWorkAreaEntity;
            }
            set
            {
                _CMConsultantAssignedWorkAreaEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {   
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateCMWorkAreaStatus(ddlWorkAreaStatusID, false);
            MiscUtil.PopulateCMConsultant(ddlConsultantID, false);
            BuildDropdownByConsultantID();
        }

        private void BuildDropdownByConsultantID()
        {
            if (ddlConsultantID.SelectedValue != "0")
            {
                MiscUtil.PopulateCMConsultantWorkAreaByCosultantID(ddlConsultantWorkAreaID, false, Int64.Parse(ddlConsultantID.SelectedValue));
            }
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

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
            CMConsultantAssignedWorkAreaEntity cMConsultantAssignedWorkAreaEntity = CurrentCMConsultantAssignedWorkAreaEntity;


            if (!cMConsultantAssignedWorkAreaEntity.IsNew)
            {
                
                if (ddlProjectID.Items.Count > 0 && cMConsultantAssignedWorkAreaEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cMConsultantAssignedWorkAreaEntity.ProjectID.ToString();
                }

                if (ddlConsultantID.Items.Count > 0 && cMConsultantAssignedWorkAreaEntity.ConsultantID != null)
                {
                    ddlConsultantID.SelectedValue = cMConsultantAssignedWorkAreaEntity.ConsultantID.ToString();
                }

                BuildDropdownByConsultantID();

                if (ddlConsultantWorkAreaID.Items.Count > 0 && cMConsultantAssignedWorkAreaEntity.ConsultantWorkAreaID != null)
                {
                    ddlConsultantWorkAreaID.SelectedValue = cMConsultantAssignedWorkAreaEntity.ConsultantWorkAreaID.ToString();
                }

                if (ddlWorkAreaStatusID.Items.Count > 0 && cMConsultantAssignedWorkAreaEntity.WorkAreaStatusID != null)
                {
                    ddlWorkAreaStatusID.SelectedValue = cMConsultantAssignedWorkAreaEntity.WorkAreaStatusID.ToString();
                }

                txtStartDate.Text = cMConsultantAssignedWorkAreaEntity.StartDate.ToStringDefault();
                txtEndDate.Text = cMConsultantAssignedWorkAreaEntity.EndDate.ToStringDefault();
                txtActualStartDate.Text = cMConsultantAssignedWorkAreaEntity.ActualStartDate.ToStringDefault();
                txtActualEndDate.Text = cMConsultantAssignedWorkAreaEntity.ActualEndDate.ToStringDefault();
                txtRemarks.Text = cMConsultantAssignedWorkAreaEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMConsultantAssignedWorkAreaList();
        }

        private void BindCMConsultantAssignedWorkAreaList()
        {
            lvCMConsultantAssignedWorkArea.DataBind();
        }

        private CMConsultantAssignedWorkAreaEntity BuildCMConsultantAssignedWorkAreaEntity()
        {
            CMConsultantAssignedWorkAreaEntity cMConsultantAssignedWorkAreaEntity = CurrentCMConsultantAssignedWorkAreaEntity;

            if (ddlConsultantID.Items.Count > 0)
            {
                if (ddlConsultantID.SelectedValue == "0")
                {
                }
                else
                {
                    cMConsultantAssignedWorkAreaEntity.ConsultantID = Int64.Parse(ddlConsultantID.SelectedValue);
                }
            }
            
            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    cMConsultantAssignedWorkAreaEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (ddlConsultantWorkAreaID.Items.Count > 0)
            {
                if (ddlConsultantWorkAreaID.SelectedValue == "0")
                {
                }
                else
                {
                    cMConsultantAssignedWorkAreaEntity.ConsultantWorkAreaID = Int64.Parse(ddlConsultantWorkAreaID.SelectedValue);
                }
            }

            if (ddlWorkAreaStatusID.Items.Count > 0)
            {
                if (ddlWorkAreaStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cMConsultantAssignedWorkAreaEntity.WorkAreaStatusID = Int64.Parse(ddlWorkAreaStatusID.SelectedValue);
                }
            }

            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMConsultantAssignedWorkAreaEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }
            else
            {
                cMConsultantAssignedWorkAreaEntity.StartDate = null;
            }

            if (txtEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMConsultantAssignedWorkAreaEntity.EndDate = MiscUtil.ParseToDateTime(txtEndDate.Text);
            }
            else
            {
                cMConsultantAssignedWorkAreaEntity.EndDate = null;
            }

            if (txtActualStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMConsultantAssignedWorkAreaEntity.ActualStartDate = MiscUtil.ParseToDateTime(txtActualStartDate.Text);
            }
            else
            {
                cMConsultantAssignedWorkAreaEntity.ActualStartDate = null;
            }

            if (txtActualEndDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMConsultantAssignedWorkAreaEntity.ActualEndDate = MiscUtil.ParseToDateTime(txtActualEndDate.Text);
            }
            else
            {
                cMConsultantAssignedWorkAreaEntity.ActualEndDate = null;
            }

            cMConsultantAssignedWorkAreaEntity.Remarks = txtRemarks.Text.Trim();

            return cMConsultantAssignedWorkAreaEntity;
        }

        private void SaveCMConsultantAssignedWorkAreaEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMConsultantAssignedWorkAreaEntity cMConsultantAssignedWorkAreaEntity = BuildCMConsultantAssignedWorkAreaEntity();

                    Int64 result = -1;

                    if (cMConsultantAssignedWorkAreaEntity.IsNew)
                    {
                        result = FCCCMConsultantAssignedWorkArea.GetFacadeCreate().Add(cMConsultantAssignedWorkAreaEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantAssignedWorkAreaEntity.FLD_NAME_ConsultantAssignedWorkAreaID, cMConsultantAssignedWorkAreaEntity.ConsultantAssignedWorkAreaID.ToString(), SQLMatchType.Equal);
                        result = FCCCMConsultantAssignedWorkArea.GetFacadeCreate().Update(cMConsultantAssignedWorkAreaEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConsultantAssignedWorkAreaID = 0;
                        _CMConsultantAssignedWorkAreaEntity = new CMConsultantAssignedWorkAreaEntity();
                        PrepareInitialView();
                        BindCMConsultantAssignedWorkAreaList();

                        if (cMConsultantAssignedWorkAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MConsultant Assigned Work Area Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C MConsultant Assigned Work Area Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMConsultantAssignedWorkAreaEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MConsultant Assigned Work Area Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MConsultant Assigned Work Area Information.", false);
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

        protected void lvCMConsultantAssignedWorkArea_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConsultantAssignedWorkAreaID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConsultantAssignedWorkAreaID);

            if (ConsultantAssignedWorkAreaID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConsultantAssignedWorkAreaID = ConsultantAssignedWorkAreaID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantAssignedWorkAreaEntity.FLD_NAME_ConsultantAssignedWorkAreaID, ConsultantAssignedWorkAreaID.ToString(), SQLMatchType.Equal);

                        CMConsultantAssignedWorkAreaEntity cMConsultantAssignedWorkAreaEntity = new CMConsultantAssignedWorkAreaEntity();


                        result = FCCCMConsultantAssignedWorkArea.GetFacadeCreate().Delete(cMConsultantAssignedWorkAreaEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ConsultantAssignedWorkAreaID = 0;
                            _CMConsultantAssignedWorkAreaEntity = new CMConsultantAssignedWorkAreaEntity();
                            PrepareInitialView();
                            BindCMConsultantAssignedWorkAreaList();

                            MiscUtil.ShowMessage(lblMessage, "C MConsultant Assigned Work Area has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C MConsultant Assigned Work Area.", true);
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

        protected void odsCMConsultantAssignedWorkArea_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {  
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMConsultantAssignedWorkAreaEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConsultantAssignedWorkAreaID = 0;
            _CMConsultantAssignedWorkAreaEntity = new CMConsultantAssignedWorkAreaEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlConsultantID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildDropdownByConsultantID();
        }

        #endregion

        #endregion Event
    }
}
