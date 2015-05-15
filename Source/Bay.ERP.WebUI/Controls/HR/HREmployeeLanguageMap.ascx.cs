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
    public partial class HREmployeeLanguageMapControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeLanguageMapID
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

        public HREmployeeLanguageMapEntity _HREmployeeLanguageMapEntity
        {
            get
            {
                HREmployeeLanguageMapEntity entity = new HREmployeeLanguageMapEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeLanguageMapEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeLanguageMapEntity CurrentHREmployeeLanguageMapEntity
        {
            get
            {
                if (_EmployeeLanguageMapID > 0)
                {
                    if (_HREmployeeLanguageMapEntity.EmployeeLanguageMapID != _EmployeeLanguageMapID)
                    {
                        _HREmployeeLanguageMapEntity = FCCHREmployeeLanguageMap.GetFacadeCreate().GetByID(_EmployeeLanguageMapID);
                    }
                }

                return _HREmployeeLanguageMapEntity;
            }
            set
            {
                _HREmployeeLanguageMapEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDEmployeeLanguage(ddlEmployeeLanguageID, false);
            MiscUtil.PopulateMDEmployeeCompetencyLevel(ddlEmployeeCompetencyLevelID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeLanguageMapEntity hREmployeeLanguageMapEntity = CurrentHREmployeeLanguageMapEntity;


            if (!hREmployeeLanguageMapEntity.IsNew)
            {
              
                if (ddlEmployeeLanguageID.Items.Count > 0 && hREmployeeLanguageMapEntity.EmployeeLanguageID != null)
                {
                    ddlEmployeeLanguageID.SelectedValue = hREmployeeLanguageMapEntity.EmployeeLanguageID.ToString();
                }

                if (ddlEmployeeCompetencyLevelID.Items.Count > 0 && hREmployeeLanguageMapEntity.EmployeeCompetencyLevelID != null)
                {
                    ddlEmployeeCompetencyLevelID.SelectedValue = hREmployeeLanguageMapEntity.EmployeeCompetencyLevelID.ToString();
                }

                txtRemarks.Text = hREmployeeLanguageMapEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeLanguageMapList();
        }

        private void BindHREmployeeLanguageMapList()
        {
            lvHREmployeeLanguageMap.DataBind();
        }

        private HREmployeeLanguageMapEntity BuildHREmployeeLanguageMapEntity()
        {
            HREmployeeLanguageMapEntity hREmployeeLanguageMapEntity = CurrentHREmployeeLanguageMapEntity;


            hREmployeeLanguageMapEntity.EmployeeID = OverviewEmployeeID;
            if (ddlEmployeeLanguageID.Items.Count > 0)
            {
                if (ddlEmployeeLanguageID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLanguageMapEntity.EmployeeLanguageID = Int64.Parse(ddlEmployeeLanguageID.SelectedValue);
                }
            }

            if (ddlEmployeeCompetencyLevelID.Items.Count > 0)
            {
                if (ddlEmployeeCompetencyLevelID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeLanguageMapEntity.EmployeeCompetencyLevelID = Int64.Parse(ddlEmployeeCompetencyLevelID.SelectedValue);
                }
            }

            hREmployeeLanguageMapEntity.Remarks = txtRemarks.Text.Trim();

            return hREmployeeLanguageMapEntity;
        }

        private void SaveHREmployeeLanguageMapEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeLanguageMapEntity hREmployeeLanguageMapEntity = BuildHREmployeeLanguageMapEntity();

                    Int64 result = -1;

                    if (hREmployeeLanguageMapEntity.IsNew)
                    {
                        result = FCCHREmployeeLanguageMap.GetFacadeCreate().Add(hREmployeeLanguageMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLanguageMapEntity.FLD_NAME_EmployeeLanguageMapID, hREmployeeLanguageMapEntity.EmployeeLanguageMapID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeLanguageMap.GetFacadeCreate().Update(hREmployeeLanguageMapEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeLanguageMapID = 0;
                        _HREmployeeLanguageMapEntity = new HREmployeeLanguageMapEntity();
                        PrepareInitialView();
                        BindHREmployeeLanguageMapList();

                        if (hREmployeeLanguageMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Language Map Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Language Map Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeLanguageMapEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Language Map Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Language Map Information.", false);
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

        protected void lvHREmployeeLanguageMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeLanguageMapID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeLanguageMapID);

            if (EmployeeLanguageMapID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeLanguageMapID = EmployeeLanguageMapID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeLanguageMapEntity.FLD_NAME_EmployeeLanguageMapID, EmployeeLanguageMapID.ToString(), SQLMatchType.Equal);

                        HREmployeeLanguageMapEntity hREmployeeLanguageMapEntity = new HREmployeeLanguageMapEntity();


                        result = FCCHREmployeeLanguageMap.GetFacadeCreate().Delete(hREmployeeLanguageMapEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeLanguageMapID = 0;
                            _HREmployeeLanguageMapEntity = new HREmployeeLanguageMapEntity();
                            PrepareInitialView();
                            BindHREmployeeLanguageMapList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Language Map has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Language Map.", true);
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

        protected void odsHREmployeeLanguageMap_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeLanguageMap." + HREmployeeLanguageMapEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeLanguageMapEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeLanguageMapID = 0;
            _HREmployeeLanguageMapEntity = new HREmployeeLanguageMapEntity();
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
