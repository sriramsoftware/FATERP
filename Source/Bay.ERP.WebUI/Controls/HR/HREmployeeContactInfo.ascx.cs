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
    public partial class HREmployeeContactInfoControl : EmployeeBaseControl
    {       
        #region Properties

        public Int64 _EmployeeContactInfoID
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

        public HREmployeeContactInfoEntity _HREmployeeContactInfoEntity
        {
            get
            {
                HREmployeeContactInfoEntity entity = new HREmployeeContactInfoEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (HREmployeeContactInfoEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private HREmployeeContactInfoEntity CurrentHREmployeeContactInfoEntity
        {
            get
            {
                if (_EmployeeContactInfoID > 0)
                {
                    if (_HREmployeeContactInfoEntity.EmployeeContactInfoID != _EmployeeContactInfoID)
                    {
                        _HREmployeeContactInfoEntity = FCCHREmployeeContactInfo.GetFacadeCreate().GetByID(_EmployeeContactInfoID);
                    }
                }

                return _HREmployeeContactInfoEntity;
            }
            set
            {
                _HREmployeeContactInfoEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDEmployeeContactType(ddlEmployeeContactTypeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtContactInfo.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            HREmployeeContactInfoEntity hREmployeeContactInfoEntity = CurrentHREmployeeContactInfoEntity;


            if (!hREmployeeContactInfoEntity.IsNew)
            {
              
                if (ddlEmployeeContactTypeID.Items.Count > 0 && hREmployeeContactInfoEntity.EmployeeContactTypeID != null)
                {
                    ddlEmployeeContactTypeID.SelectedValue = hREmployeeContactInfoEntity.EmployeeContactTypeID.ToString();
                }

                txtContactInfo.Text = hREmployeeContactInfoEntity.ContactInfo.ToString();
                txtDescription.Text = hREmployeeContactInfoEntity.Description.ToString();
                txtRemarks.Text = hREmployeeContactInfoEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindHREmployeeContactInfoList();
        }

        private void BindHREmployeeContactInfoList()
        {
            lvHREmployeeContactInfo.DataBind();
        }

        private HREmployeeContactInfoEntity BuildHREmployeeContactInfoEntity()
        {
            HREmployeeContactInfoEntity hREmployeeContactInfoEntity = CurrentHREmployeeContactInfoEntity;


            hREmployeeContactInfoEntity.EmployeeID = OverviewEmployeeID;

            if (ddlEmployeeContactTypeID.Items.Count > 0)
            {
                if (ddlEmployeeContactTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    hREmployeeContactInfoEntity.EmployeeContactTypeID = Int64.Parse(ddlEmployeeContactTypeID.SelectedValue);
                }
            }

            hREmployeeContactInfoEntity.ContactInfo = txtContactInfo.Text.Trim();
            hREmployeeContactInfoEntity.Description = txtDescription.Text.Trim();
            hREmployeeContactInfoEntity.Remarks = txtRemarks.Text.Trim();

            return hREmployeeContactInfoEntity;
        }

        private void SaveHREmployeeContactInfoEntity()
        {
            if (IsValid)
            {
                try
                {
                    HREmployeeContactInfoEntity hREmployeeContactInfoEntity = BuildHREmployeeContactInfoEntity();

                    Int64 result = -1;

                    if (hREmployeeContactInfoEntity.IsNew)
                    {
                        result = FCCHREmployeeContactInfo.GetFacadeCreate().Add(hREmployeeContactInfoEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeContactInfoEntity.FLD_NAME_EmployeeContactInfoID, hREmployeeContactInfoEntity.EmployeeContactInfoID.ToString(), SQLMatchType.Equal);
                        result = FCCHREmployeeContactInfo.GetFacadeCreate().Update(hREmployeeContactInfoEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeContactInfoID = 0;
                        _HREmployeeContactInfoEntity = new HREmployeeContactInfoEntity();
                        PrepareInitialView();
                        BindHREmployeeContactInfoList();

                        if (hREmployeeContactInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Contact Info Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Contact Info Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (hREmployeeContactInfoEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Contact Info Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Contact Info Information.", false);
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

        protected void lvHREmployeeContactInfo_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeContactInfoID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeContactInfoID);

            if (EmployeeContactInfoID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeContactInfoID = EmployeeContactInfoID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeContactInfoEntity.FLD_NAME_EmployeeContactInfoID, EmployeeContactInfoID.ToString(), SQLMatchType.Equal);

                        HREmployeeContactInfoEntity hREmployeeContactInfoEntity = new HREmployeeContactInfoEntity();


                        result = FCCHREmployeeContactInfo.GetFacadeCreate().Delete(hREmployeeContactInfoEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeContactInfoID = 0;
                            _HREmployeeContactInfoEntity = new HREmployeeContactInfoEntity();
                            PrepareInitialView();
                            BindHREmployeeContactInfoList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Contact Info has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Contact Info.", true);
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

        protected void odsHREmployeeContactInfo_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeContactInfo." + HREmployeeContactInfoEntity.FLD_NAME_EmployeeID, OverviewEmployeeID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveHREmployeeContactInfoEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeContactInfoID = 0;
            _HREmployeeContactInfoEntity = new HREmployeeContactInfoEntity();
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
