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
    public partial class MDEmployeeContactTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _EmployeeContactTypeID
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

        public MDEmployeeContactTypeEntity _MDEmployeeContactTypeEntity
        {
            get
            {
                MDEmployeeContactTypeEntity entity = new MDEmployeeContactTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDEmployeeContactTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDEmployeeContactTypeEntity CurrentMDEmployeeContactTypeEntity
        {
            get
            {
                if (_EmployeeContactTypeID > 0)
                {
                    if (_MDEmployeeContactTypeEntity.EmployeeContactTypeID != _EmployeeContactTypeID)
                    {
                        _MDEmployeeContactTypeEntity = FCCMDEmployeeContactType.GetFacadeCreate().GetByID(_EmployeeContactTypeID);
                    }
                }

                return _MDEmployeeContactTypeEntity;
            }
            set
            {
                _MDEmployeeContactTypeEntity = value;
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
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDEmployeeContactTypeEntity mDEmployeeContactTypeEntity = CurrentMDEmployeeContactTypeEntity;


            if (!mDEmployeeContactTypeEntity.IsNew)
            {
                txtName.Text = mDEmployeeContactTypeEntity.Name.ToString();
                chkIsRemoved.Checked = mDEmployeeContactTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDEmployeeContactTypeList();
        }

        private void BindMDEmployeeContactTypeList()
        {
            lvMDEmployeeContactType.DataBind();
        }

        private MDEmployeeContactTypeEntity BuildMDEmployeeContactTypeEntity()
        {
            MDEmployeeContactTypeEntity mDEmployeeContactTypeEntity = CurrentMDEmployeeContactTypeEntity;

            mDEmployeeContactTypeEntity.Name = txtName.Text.Trim();
            mDEmployeeContactTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDEmployeeContactTypeEntity;
        }

        private void SaveMDEmployeeContactTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDEmployeeContactTypeEntity mDEmployeeContactTypeEntity = BuildMDEmployeeContactTypeEntity();

                    Int64 result = -1;

                    if (mDEmployeeContactTypeEntity.IsNew)
                    {
                        result = FCCMDEmployeeContactType.GetFacadeCreate().Add(mDEmployeeContactTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeContactTypeEntity.FLD_NAME_EmployeeContactTypeID, mDEmployeeContactTypeEntity.EmployeeContactTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDEmployeeContactType.GetFacadeCreate().Update(mDEmployeeContactTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _EmployeeContactTypeID = 0;
                        _MDEmployeeContactTypeEntity = new MDEmployeeContactTypeEntity();
                        PrepareInitialView();
                        BindMDEmployeeContactTypeList();

                        if (mDEmployeeContactTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Contact Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Employee Contact Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDEmployeeContactTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Employee Contact Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Employee Contact Type Information.", false);
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

        protected void lvMDEmployeeContactType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 EmployeeContactTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out EmployeeContactTypeID);

            if (EmployeeContactTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _EmployeeContactTypeID = EmployeeContactTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEmployeeContactTypeEntity.FLD_NAME_EmployeeContactTypeID, EmployeeContactTypeID.ToString(), SQLMatchType.Equal);

                        MDEmployeeContactTypeEntity mDEmployeeContactTypeEntity = new MDEmployeeContactTypeEntity();


                        result = FCCMDEmployeeContactType.GetFacadeCreate().Delete(mDEmployeeContactTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _EmployeeContactTypeID = 0;
                            _MDEmployeeContactTypeEntity = new MDEmployeeContactTypeEntity();
                            PrepareInitialView();
                            BindMDEmployeeContactTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Employee Contact Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Employee Contact Type.", true);
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

        protected void odsMDEmployeeContactType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDEmployeeContactTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _EmployeeContactTypeID = 0;
            _MDEmployeeContactTypeEntity = new MDEmployeeContactTypeEntity();
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
