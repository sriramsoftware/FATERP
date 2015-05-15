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
    public partial class MDEmployeeJobTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeJobTypeID
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

        public MDEmployeeJobTypeEntity _MDEmployeeJobTypeEntity
        {
            get
            {
                MDEmployeeJobTypeEntity entity = new MDEmployeeJobTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeJobTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeJobTypeEntity CurrentMDEmployeeJobTypeEntity
        {
            get
            {
                if (_EmployeeJobTypeID > 0)
                {
                    if (_MDEmployeeJobTypeEntity.EmployeeJobTypeID != _EmployeeJobTypeID)
                    {
                        _MDEmployeeJobTypeEntity = FCCMDEmployeeJobType.GetFacadeCreate().GetByID(_EmployeeJobTypeID);
                    }
                }

                return _MDEmployeeJobTypeEntity;
            }
            set
            {
                _MDEmployeeJobTypeEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtName.Text = String.Empty;
            txtDescription.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDEmployeeJobTypeEntity mDEmployeeJobTypeEntity = CurrentMDEmployeeJobTypeEntity;


            if (!mDEmployeeJobTypeEntity.IsNew)
            {
                txtName.Text = mDEmployeeJobTypeEntity.Name.ToString();
                txtDescription.Text = mDEmployeeJobTypeEntity.Description.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeJobTypeList();
        }

        private void BindMDEmployeeJobTypeList()
        {
            lvMDEmployeeJobType.DataBind();
        }

        private MDEmployeeJobTypeEntity BuildMDEmployeeJobTypeEntity()
        {
            MDEmployeeJobTypeEntity mDEmployeeJobTypeEntity = CurrentMDEmployeeJobTypeEntity;

            mDEmployeeJobTypeEntity.Name = txtName.Text.Trim();
            mDEmployeeJobTypeEntity.Description = txtDescription.Text.Trim();

            return mDEmployeeJobTypeEntity;
        }

        private void SaveMDEmployeeJobTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeJobTypeEntity mDEmployeeJobTypeEntity = BuildMDEmployeeJobTypeEntity();

                    Int64 result = -1;

                    if (mDEmployeeJobTypeEntity.IsNew)
                    {
                        result = FCCMDEmployeeJobType.GetFacadeCreate().Add(mDEmployeeJobTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeJobTypeEntity.FLD_NAME_EmployeeJobTypeID, mDEmployeeJobTypeEntity.EmployeeJobTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeJobType.GetFacadeCreate().Update(mDEmployeeJobTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeJobTypeID = 0;
                        _MDEmployeeJobTypeEntity = new MDEmployeeJobTypeEntity();
                        PrepareInitialView();
                        BindMDEmployeeJobTypeList();

                        if (mDEmployeeJobTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Job Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Job Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeJobTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Job Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Job Type Information.", false);
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

        protected void lvMDEmployeeJobType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeJobTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeJobTypeID);

            if (EmployeeJobTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeJobTypeID = EmployeeJobTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeJobTypeEntity.FLD_NAME_EmployeeJobTypeID, EmployeeJobTypeID.ToString(), SQLMatchType.Equal);

                        MDEmployeeJobTypeEntity mDEmployeeJobTypeEntity = new MDEmployeeJobTypeEntity();


                        result = FCCMDEmployeeJobType.GetFacadeCreate().Delete(mDEmployeeJobTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeJobTypeID = 0;
                            _MDEmployeeJobTypeEntity = new MDEmployeeJobTypeEntity();
                            PrepareInitialView();
                            BindMDEmployeeJobTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Job Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Job Type.", true);
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

        protected void odsMDEmployeeJobType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeJobTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeJobTypeID = 0;
            _MDEmployeeJobTypeEntity = new MDEmployeeJobTypeEntity();
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
