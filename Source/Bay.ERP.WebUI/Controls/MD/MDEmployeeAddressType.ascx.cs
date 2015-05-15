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
    public partial class MDEmployeeAddressTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeAddressTypeID
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

        public MDEmployeeAddressTypeEntity _MDEmployeeAddressTypeEntity
        {
            get
            {
                MDEmployeeAddressTypeEntity entity = new MDEmployeeAddressTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeAddressTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeAddressTypeEntity CurrentMDEmployeeAddressTypeEntity
        {
            get
            {
                if (_EmployeeAddressTypeID > 0)
                {
                    if (_MDEmployeeAddressTypeEntity.EmployeeAddressTypeID != _EmployeeAddressTypeID)
                    {
                        _MDEmployeeAddressTypeEntity = FCCMDEmployeeAddressType.GetFacadeCreate().GetByID(_EmployeeAddressTypeID);
                    }
                }

                return _MDEmployeeAddressTypeEntity;
            }
            set
            {
                _MDEmployeeAddressTypeEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDEmployeeAddressTypeEntity mDEmployeeAddressTypeEntity = CurrentMDEmployeeAddressTypeEntity;


            if (!mDEmployeeAddressTypeEntity.IsNew)
            {
                txtName.Text = mDEmployeeAddressTypeEntity.Name.ToString();
                txtDescription.Text = mDEmployeeAddressTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDEmployeeAddressTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeAddressTypeList();
        }

        private void BindMDEmployeeAddressTypeList()
        {
            lvMDEmployeeAddressType.DataBind();
        }

        private MDEmployeeAddressTypeEntity BuildMDEmployeeAddressTypeEntity()
        {
            MDEmployeeAddressTypeEntity mDEmployeeAddressTypeEntity = CurrentMDEmployeeAddressTypeEntity;

            mDEmployeeAddressTypeEntity.Name = txtName.Text.Trim();
            mDEmployeeAddressTypeEntity.Description = txtDescription.Text.Trim();
            mDEmployeeAddressTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEmployeeAddressTypeEntity;
        }

        private void SaveMDEmployeeAddressTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeAddressTypeEntity mDEmployeeAddressTypeEntity = BuildMDEmployeeAddressTypeEntity();

                    Int64 result = -1;

                    if (mDEmployeeAddressTypeEntity.IsNew)
                    {
                        result = FCCMDEmployeeAddressType.GetFacadeCreate().Add(mDEmployeeAddressTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeAddressTypeEntity.FLD_NAME_EmployeeAddressTypeID, mDEmployeeAddressTypeEntity.EmployeeAddressTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeAddressType.GetFacadeCreate().Update(mDEmployeeAddressTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeAddressTypeID = 0;
                        _MDEmployeeAddressTypeEntity = new MDEmployeeAddressTypeEntity();
                        PrepareInitialView();
                        BindMDEmployeeAddressTypeList();

                        if (mDEmployeeAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Address Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Address Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Address Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Address Type Information.", false);
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

        protected void lvMDEmployeeAddressType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeAddressTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeAddressTypeID);

            if (EmployeeAddressTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeAddressTypeID = EmployeeAddressTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeAddressTypeEntity.FLD_NAME_EmployeeAddressTypeID, EmployeeAddressTypeID.ToString(), SQLMatchType.Equal);

                        MDEmployeeAddressTypeEntity mDEmployeeAddressTypeEntity = new MDEmployeeAddressTypeEntity();


                        result = FCCMDEmployeeAddressType.GetFacadeCreate().Delete(mDEmployeeAddressTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeAddressTypeID = 0;
                            _MDEmployeeAddressTypeEntity = new MDEmployeeAddressTypeEntity();
                            PrepareInitialView();
                            BindMDEmployeeAddressTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Address Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Address Type.", true);
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

        protected void odsMDEmployeeAddressType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeAddressTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeAddressTypeID = 0;
            _MDEmployeeAddressTypeEntity = new MDEmployeeAddressTypeEntity();
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
