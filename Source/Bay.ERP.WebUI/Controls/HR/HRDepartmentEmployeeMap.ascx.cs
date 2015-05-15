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
    public partial class HRDepartmentEmployeeMapControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _DepartmentEmployeeMapID
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

        public HRDepartmentEmployeeMapEntity _HRDepartmentEmployeeMapEntity
        {
            get
            {
                HRDepartmentEmployeeMapEntity entity = new HRDepartmentEmployeeMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HRDepartmentEmployeeMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HRDepartmentEmployeeMapEntity CurrentHRDepartmentEmployeeMapEntity
        {
            get
            {
                if (_DepartmentEmployeeMapID > 0)
                {
                    if (_HRDepartmentEmployeeMapEntity.DepartmentEmployeeMapID != _DepartmentEmployeeMapID)
                    {
                        _HRDepartmentEmployeeMapEntity = FCCHRDepartmentEmployeeMap.GetFacadeCreate().GetByID(_DepartmentEmployeeMapID);
                    }
                }

                return _HRDepartmentEmployeeMapEntity;
            }
            set
            {
                _HRDepartmentEmployeeMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            chkIsHeadOfDepartment.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HRDepartmentEmployeeMapEntity hRDepartmentEmployeeMapEntity = CurrentHRDepartmentEmployeeMapEntity;


            if (!hRDepartmentEmployeeMapEntity.IsNew)
            {
                if (ddlDepartmentID.Items.Count > 0 && hRDepartmentEmployeeMapEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = hRDepartmentEmployeeMapEntity.DepartmentID.ToString();
                }

                chkIsHeadOfDepartment.Checked = hRDepartmentEmployeeMapEntity.IsHeadOfDepartment;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHRDepartmentEmployeeMapList();
        }

        private void BindHRDepartmentEmployeeMapList()
        {
            lvHRDepartmentEmployeeMap.DataBind();
        }

        private HRDepartmentEmployeeMapEntity BuildHRDepartmentEmployeeMapEntity()
        {
            HRDepartmentEmployeeMapEntity hRDepartmentEmployeeMapEntity = CurrentHRDepartmentEmployeeMapEntity;

            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                }
                else
                {
                    hRDepartmentEmployeeMapEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
                }
            }


            hRDepartmentEmployeeMapEntity.EmployeeID = OverviewEmployeeID;

            hRDepartmentEmployeeMapEntity.IsHeadOfDepartment = chkIsHeadOfDepartment.Checked;


            return hRDepartmentEmployeeMapEntity;
        }

        private void SaveHRDepartmentEmployeeMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    HRDepartmentEmployeeMapEntity hRDepartmentEmployeeMapEntity = BuildHRDepartmentEmployeeMapEntity();

                    Int64 result = -1;

                    if (hRDepartmentEmployeeMapEntity.IsNew)
                    {
                        result = FCCHRDepartmentEmployeeMap.GetFacadeCreate().Add(hRDepartmentEmployeeMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRDepartmentEmployeeMapEntity.FLD_NAME_DepartmentEmployeeMapID, hRDepartmentEmployeeMapEntity.DepartmentEmployeeMapID.ToString(), SQLMatchType.Equal);
                        result = FCCHRDepartmentEmployeeMap.GetFacadeCreate().Update(hRDepartmentEmployeeMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DepartmentEmployeeMapID = 0;
                        _HRDepartmentEmployeeMapEntity = new HRDepartmentEmployeeMapEntity();
                        PrepareInitialView();
                        BindHRDepartmentEmployeeMapList();

                        if (hRDepartmentEmployeeMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Department Employee Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Department Employee Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hRDepartmentEmployeeMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Department Employee Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Department Employee Map Information.", false);
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

        protected void lvHRDepartmentEmployeeMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DepartmentEmployeeMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out DepartmentEmployeeMapID);

            if (DepartmentEmployeeMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DepartmentEmployeeMapID = DepartmentEmployeeMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRDepartmentEmployeeMapEntity.FLD_NAME_DepartmentEmployeeMapID, DepartmentEmployeeMapID.ToString(), SQLMatchType.Equal);

                        HRDepartmentEmployeeMapEntity hRDepartmentEmployeeMapEntity = new HRDepartmentEmployeeMapEntity();


                        result = FCCHRDepartmentEmployeeMap.GetFacadeCreate().Delete(hRDepartmentEmployeeMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DepartmentEmployeeMapID = 0;
                            _HRDepartmentEmployeeMapEntity = new HRDepartmentEmployeeMapEntity();
                            PrepareInitialView();
                            BindHRDepartmentEmployeeMapList();

                            MiscUtil.ShowMessage(lblMessage, "Department Employee Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Department Employee Map.", true);
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

        protected void odsHRDepartmentEmployeeMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHRDepartmentEmployeeMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DepartmentEmployeeMapID = 0;
            _HRDepartmentEmployeeMapEntity = new HRDepartmentEmployeeMapEntity();
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
