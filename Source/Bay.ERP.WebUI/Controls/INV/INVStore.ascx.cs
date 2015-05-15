// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    public partial class INVStoreControl : BaseControl
    {       
        #region Properties

        public Int64 _StoreID
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

        public INVStoreEntity _INVStoreEntity
        {
            get
            {
                INVStoreEntity entity = new INVStoreEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (INVStoreEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private INVStoreEntity CurrentINVStoreEntity
        {
            get
            {
                if (_StoreID > 0)
                {
                    if (_INVStoreEntity.StoreID != _StoreID)
                    {
                        _INVStoreEntity = FCCINVStore.GetFacadeCreate().GetByID(_StoreID);
                    }
                }

                return _INVStoreEntity;
            }
            set
            {
                _INVStoreEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateMDDepartment(ddlDepartmentID, false);
            MiscUtil.PopulateHREmployee(ddlStoreInChargeEmployeeID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtStoreTrackNumber.Text = String.Empty;
            txtLocation.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtCreateDate.Text = String.Empty;
            chkIsRemoved.Checked = false;
            chkIsDefault.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            INVStoreEntity iNVStoreEntity = CurrentINVStoreEntity;


            if (!iNVStoreEntity.IsNew)
            {
                if (ddlProjectID.Items.Count > 0 && iNVStoreEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = iNVStoreEntity.ProjectID.ToString();
                }

                if (ddlDepartmentID.Items.Count > 0 && iNVStoreEntity.DepartmentID != null)
                {
                    ddlDepartmentID.SelectedValue = iNVStoreEntity.DepartmentID.ToString();
                }

                if (ddlStoreInChargeEmployeeID.Items.Count > 0 && iNVStoreEntity.StoreInChargeEmployeeID != null)
                {
                    ddlStoreInChargeEmployeeID.SelectedValue = iNVStoreEntity.StoreInChargeEmployeeID.ToString();
                }

                txtName.Text = iNVStoreEntity.Name.ToString();
                txtStoreTrackNumber.Text = iNVStoreEntity.StoreTrackNumber.ToString();
                txtLocation.Text = iNVStoreEntity.Location.ToString();
                txtDescription.Text = iNVStoreEntity.Description.ToString();
                txtCreateDate.Text = iNVStoreEntity.CreateDate.ToStringDefault();
                chkIsRemoved.Checked = iNVStoreEntity.IsRemoved;
                chkIsDefault.Checked = iNVStoreEntity.IsDefault;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindINVStoreList();
        }

        private void BindINVStoreList()
        {
            lvINVStore.DataBind();
        }

        private INVStoreEntity BuildINVStoreEntity()
        {
            INVStoreEntity iNVStoreEntity = CurrentINVStoreEntity;

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (ddlDepartmentID.Items.Count > 0)
            {
                if (ddlDepartmentID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreEntity.DepartmentID = Int64.Parse(ddlDepartmentID.SelectedValue);
                }
            }

            if (ddlStoreInChargeEmployeeID.Items.Count > 0)
            {
                if (ddlStoreInChargeEmployeeID.SelectedValue == "0")
                {
                }
                else
                {
                    iNVStoreEntity.StoreInChargeEmployeeID = Int64.Parse(ddlStoreInChargeEmployeeID.SelectedValue);
                }
            }

            iNVStoreEntity.Name = txtName.Text.Trim();
            iNVStoreEntity.StoreTrackNumber = txtStoreTrackNumber.Text.Trim();
            iNVStoreEntity.Location = txtLocation.Text.Trim();
            iNVStoreEntity.Description = txtDescription.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                iNVStoreEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            iNVStoreEntity.IsRemoved = chkIsRemoved.Checked;

            iNVStoreEntity.IsDefault = chkIsDefault.Checked;


            return iNVStoreEntity;
        }

        private void SaveINVStoreEntity()
        {
            if (IsValid)
            {
                try
                {
                    INVStoreEntity iNVStoreEntity = BuildINVStoreEntity();

                    Int64 result = -1;

                    if (iNVStoreEntity.IsNew)
                    {
                        result = FCCINVStore.GetFacadeCreate().Add(iNVStoreEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_StoreID, iNVStoreEntity.StoreID.ToString(), SQLMatchType.Equal);
                        result = FCCINVStore.GetFacadeCreate().Update(iNVStoreEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _StoreID = 0;
                        _INVStoreEntity = new INVStoreEntity();
                        PrepareInitialView();
                        BindINVStoreList();

                        if (iNVStoreEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "I NVStore Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "I NVStore Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (iNVStoreEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add I NVStore Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update I NVStore Information.", false);
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

        protected void lvINVStore_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 StoreID;

            Int64.TryParse(e.CommandArgument.ToString(), out StoreID);

            if (StoreID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _StoreID = StoreID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_StoreID, StoreID.ToString(), SQLMatchType.Equal);

                        INVStoreEntity iNVStoreEntity = new INVStoreEntity();


                        result = FCCINVStore.GetFacadeCreate().Delete(iNVStoreEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _StoreID = 0;
                            _INVStoreEntity = new INVStoreEntity();
                            PrepareInitialView();
                            BindINVStoreList();

                            MiscUtil.ShowMessage(lblMessage, "I NVStore has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete I NVStore.", true);
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

        protected void odsINVStore_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveINVStoreEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _StoreID = 0;
            _INVStoreEntity = new INVStoreEntity();
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
