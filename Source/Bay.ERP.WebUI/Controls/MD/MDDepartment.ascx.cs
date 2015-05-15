// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDDepartmentControl : BaseControl
    {       
        #region Properties

        public Int64 _DepartmentID
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

        public MDDepartmentEntity _MDDepartmentEntity
        {
            get
            {
                MDDepartmentEntity entity = new MDDepartmentEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDDepartmentEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDDepartmentEntity CurrentMDDepartmentEntity
        {
            get
            {
                if (_DepartmentID > 0)
                {
                    if (_MDDepartmentEntity.DepartmentID != _DepartmentID)
                    {
                        _MDDepartmentEntity = FCCMDDepartment.GetFacadeCreate().GetByID(_DepartmentID);
                    }
                }

                return _MDDepartmentEntity;
            }
            set
            {
                _MDDepartmentEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDDepartment(ddlParentDepartmentID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtDepartmentCode.Text = String.Empty;
            txtName.Text = String.Empty;
            txtLocation.Text = String.Empty;
            txtHODEmployeeID.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDDepartmentEntity mDDepartmentEntity = CurrentMDDepartmentEntity;


            if (!mDDepartmentEntity.IsNew)
            {
                if (ddlParentDepartmentID.Items.Count > 0 && mDDepartmentEntity.ParentDepartmentID != null)
                {
                    ddlParentDepartmentID.SelectedValue = mDDepartmentEntity.ParentDepartmentID.ToString();
                }

                txtDepartmentCode.Text = mDDepartmentEntity.DepartmentCode.ToString();
                txtName.Text = mDDepartmentEntity.Name.ToString();
                txtLocation.Text = mDDepartmentEntity.Location.ToString();
                txtHODEmployeeID.Text = mDDepartmentEntity.HODEmployeeID.ToString();
                chkIsRemoved.Checked = mDDepartmentEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDDepartmentList();
        }

        private void BindMDDepartmentList()
        {
            lvMDDepartment.DataBind();
        }

        private MDDepartmentEntity BuildMDDepartmentEntity()
        {
            MDDepartmentEntity mDDepartmentEntity = CurrentMDDepartmentEntity;

            if (ddlParentDepartmentID.Items.Count > 0)
            {
                if (ddlParentDepartmentID.SelectedValue == "0")
                {
                    mDDepartmentEntity.ParentDepartmentID = null;
                }
                else
                {
                    mDDepartmentEntity.ParentDepartmentID = Int64.Parse(ddlParentDepartmentID.SelectedValue);
                }
            }

            mDDepartmentEntity.DepartmentCode = txtDepartmentCode.Text.Trim();
            mDDepartmentEntity.Name = txtName.Text.Trim();
            mDDepartmentEntity.Location = txtLocation.Text.Trim();
            if (!txtHODEmployeeID.Text.Trim().IsNullOrEmpty())
            {
                mDDepartmentEntity.HODEmployeeID = Int64.Parse(txtHODEmployeeID.Text.Trim());
            }
            else
            {
                mDDepartmentEntity.HODEmployeeID = null;
            }

            mDDepartmentEntity.IsRemoved = chkIsRemoved.Checked;


            return mDDepartmentEntity;
        }

        private void SaveMDDepartmentEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDDepartmentEntity mDDepartmentEntity = BuildMDDepartmentEntity();

                    Int64 result = -1;

                    if (mDDepartmentEntity.IsNew)
                    {
                        result = FCCMDDepartment.GetFacadeCreate().Add(mDDepartmentEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDDepartmentEntity.FLD_NAME_DepartmentID, mDDepartmentEntity.DepartmentID.ToString(), SQLMatchType.Equal);
                        result = FCCMDDepartment.GetFacadeCreate().Update(mDDepartmentEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DepartmentID = 0;
                        _MDDepartmentEntity = new MDDepartmentEntity();
                        PrepareInitialView();
                        BindMDDepartmentList();

                        if (mDDepartmentEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Department Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Department Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDDepartmentEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Department Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Department Information.", false);
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

        protected void lvMDDepartment_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DepartmentID;

            Int64.TryParse(e.CommandArgument.ToString(), out DepartmentID);

            if (DepartmentID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DepartmentID = DepartmentID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDepartmentEntity.FLD_NAME_DepartmentID, DepartmentID.ToString(), SQLMatchType.Equal);

                        MDDepartmentEntity mDDepartmentEntity = new MDDepartmentEntity();


                        result = FCCMDDepartment.GetFacadeCreate().Delete(mDDepartmentEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DepartmentID = 0;
                            _MDDepartmentEntity = new MDDepartmentEntity();
                            PrepareInitialView();
                            BindMDDepartmentList();

                            MiscUtil.ShowMessage(lblMessage, "Department has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Department.", true);
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

        protected void odsMDDepartment_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDDepartmentEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DepartmentID = 0;
            _MDDepartmentEntity = new MDDepartmentEntity();
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
