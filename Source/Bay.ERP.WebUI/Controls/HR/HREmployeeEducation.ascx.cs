// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HREmployeeEducationControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeEducationID
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

        public HREmployeeEducationEntity _HREmployeeEducationEntity
        {
            get
            {
                HREmployeeEducationEntity entity = new HREmployeeEducationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeEducationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeEducationEntity CurrentHREmployeeEducationEntity
        {
            get
            {
                if (_EmployeeEducationID > 0)
                {
                    if (_HREmployeeEducationEntity.EmployeeEducationID != _EmployeeEducationID)
                    {
                        _HREmployeeEducationEntity = FCCHREmployeeEducation.GetFacadeCreate().GetByID(_EmployeeEducationID);
                    }
                }

                return _HREmployeeEducationEntity;
            }
            set
            {
                _HREmployeeEducationEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDEducationalDegree(ddlEducationalDegreeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtPassedYear.Text = String.Empty;
            txtSession.Text = String.Empty;
            txtResult.Text = String.Empty;
            txtResultOutOf.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsCompleted.Checked = false;
            chkIsLastAcquired.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeEducationEntity hREmployeeEducationEntity = CurrentHREmployeeEducationEntity;


            if (!hREmployeeEducationEntity.IsNew)
            {
           

                if (ddlEducationalDegreeID.Items.Count > 0 && hREmployeeEducationEntity.EducationalDegreeID != null)
                {
                    ddlEducationalDegreeID.SelectedValue = hREmployeeEducationEntity.EducationalDegreeID.ToString();
                }

                txtPassedYear.Text = hREmployeeEducationEntity.PassedYear.ToString();
                txtSession.Text = hREmployeeEducationEntity.Session.ToString();
                txtResult.Text = hREmployeeEducationEntity.Result.ToString();
                txtResultOutOf.Text = hREmployeeEducationEntity.ResultOutOf.ToString();
                txtRemarks.Text = hREmployeeEducationEntity.Remarks.ToString();
                chkIsCompleted.Checked = hREmployeeEducationEntity.IsCompleted;
                chkIsLastAcquired.Checked = hREmployeeEducationEntity.IsLastAcquired;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeEducationList();
        }

        private void BindHREmployeeEducationList()
        {
            lvHREmployeeEducation.DataBind();
        }

        private HREmployeeEducationEntity BuildHREmployeeEducationEntity()
        {
            HREmployeeEducationEntity hREmployeeEducationEntity = CurrentHREmployeeEducationEntity;


            hREmployeeEducationEntity.EmployeeID = OverviewEmployeeID;
            if (ddlEducationalDegreeID.Items.Count > 0)
            {
                if (ddlEducationalDegreeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeEducationEntity.EducationalDegreeID = Int64.Parse(ddlEducationalDegreeID.SelectedValue);
                }
            }

            if (!txtPassedYear.Text.Trim().IsNullOrEmpty())
            {
                hREmployeeEducationEntity.PassedYear = Int32.Parse(txtPassedYear.Text.Trim());
            }
            else
            {
                hREmployeeEducationEntity.PassedYear = null;
            }

            hREmployeeEducationEntity.Session = txtSession.Text.Trim();
            hREmployeeEducationEntity.Result = txtResult.Text.Trim();
            hREmployeeEducationEntity.ResultOutOf = txtResultOutOf.Text.Trim();
            hREmployeeEducationEntity.Remarks = txtRemarks.Text.Trim();
            hREmployeeEducationEntity.IsCompleted = chkIsCompleted.Checked;

            hREmployeeEducationEntity.IsLastAcquired = chkIsLastAcquired.Checked;


            return hREmployeeEducationEntity;
        }

        private void SaveHREmployeeEducationEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeEducationEntity hREmployeeEducationEntity = BuildHREmployeeEducationEntity();

                    Int64 result = -1;

                    if (hREmployeeEducationEntity.IsNew)
                    {
                        result = FCCHREmployeeEducation.GetFacadeCreate().Add(hREmployeeEducationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEducationEntity.FLD_NAME_EmployeeEducationID, hREmployeeEducationEntity.EmployeeEducationID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeEducation.GetFacadeCreate().Update(hREmployeeEducationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeEducationID = 0;
                        _HREmployeeEducationEntity = new HREmployeeEducationEntity();
                        PrepareInitialView();
                        BindHREmployeeEducationList();

                        if (hREmployeeEducationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Education Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Education Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeEducationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Education Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Education Information.", false);
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

        protected void lvHREmployeeEducation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeEducationID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeEducationID);

            if (EmployeeEducationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeEducationID = EmployeeEducationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeEducationEntity.FLD_NAME_EmployeeEducationID, EmployeeEducationID.ToString(), SQLMatchType.Equal);

                        HREmployeeEducationEntity hREmployeeEducationEntity = new HREmployeeEducationEntity();


                        result = FCCHREmployeeEducation.GetFacadeCreate().Delete(hREmployeeEducationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeEducationID = 0;
                            _HREmployeeEducationEntity = new HREmployeeEducationEntity();
                            PrepareInitialView();
                            BindHREmployeeEducationList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Education has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Education.", true);
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

        protected void odsHREmployeeEducation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeEducation." + HREmployeeEducationEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeEducationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeEducationID = 0;
            _HREmployeeEducationEntity = new HREmployeeEducationEntity();
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
