// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Sep-2013, 01:19:45




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
    public partial class MDSupervisorTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _SupervisorTypeID
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

        public MDSupervisorTypeEntity _MDSupervisorTypeEntity
        {
            get
            {
                MDSupervisorTypeEntity entity = new MDSupervisorTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSupervisorTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSupervisorTypeEntity CurrentMDSupervisorTypeEntity
        {
            get
            {
                if (_SupervisorTypeID > 0)
                {
                    if (_MDSupervisorTypeEntity.SupervisorTypeID != _SupervisorTypeID)
                    {
                        _MDSupervisorTypeEntity = FCCMDSupervisorType.GetFacadeCreate().GetByID(_SupervisorTypeID);
                    }
                }

                return _MDSupervisorTypeEntity;
            }
            set
            {
                _MDSupervisorTypeEntity = value;
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
            MDSupervisorTypeEntity mDSupervisorTypeEntity = CurrentMDSupervisorTypeEntity;


            if (!mDSupervisorTypeEntity.IsNew)
            {
                txtName.Text = mDSupervisorTypeEntity.Name.ToString();
                txtDescription.Text = mDSupervisorTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDSupervisorTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSupervisorTypeList();
        }

        private void BindMDSupervisorTypeList()
        {
            lvMDSupervisorType.DataBind();
        }

        private MDSupervisorTypeEntity BuildMDSupervisorTypeEntity()
        {
            MDSupervisorTypeEntity mDSupervisorTypeEntity = CurrentMDSupervisorTypeEntity;

            mDSupervisorTypeEntity.Name = txtName.Text.Trim();
            mDSupervisorTypeEntity.Description = txtDescription.Text.Trim();
            mDSupervisorTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSupervisorTypeEntity;
        }

        private void SaveMDSupervisorTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSupervisorTypeEntity mDSupervisorTypeEntity = BuildMDSupervisorTypeEntity();

                    Int64 result = -1;

                    if (mDSupervisorTypeEntity.IsNew)
                    {
                        result = FCCMDSupervisorType.GetFacadeCreate().Add(mDSupervisorTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSupervisorTypeEntity.FLD_NAME_SupervisorTypeID, mDSupervisorTypeEntity.SupervisorTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSupervisorType.GetFacadeCreate().Update(mDSupervisorTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupervisorTypeID = 0;
                        _MDSupervisorTypeEntity = new MDSupervisorTypeEntity();
                        PrepareInitialView();
                        BindMDSupervisorTypeList();

                        if (mDSupervisorTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Supervisor Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Supervisor Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSupervisorTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Supervisor Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Supervisor Type Information.", false);
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

        protected void lvMDSupervisorType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupervisorTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupervisorTypeID);

            if (SupervisorTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupervisorTypeID = SupervisorTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSupervisorTypeEntity.FLD_NAME_SupervisorTypeID, SupervisorTypeID.ToString(), SQLMatchType.Equal);

                        MDSupervisorTypeEntity mDSupervisorTypeEntity = new MDSupervisorTypeEntity();


                        result = FCCMDSupervisorType.GetFacadeCreate().Delete(mDSupervisorTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupervisorTypeID = 0;
                            _MDSupervisorTypeEntity = new MDSupervisorTypeEntity();
                            PrepareInitialView();
                            BindMDSupervisorTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Supervisor Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Supervisor Type.", true);
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

        protected void odsMDSupervisorType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSupervisorTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupervisorTypeID = 0;
            _MDSupervisorTypeEntity = new MDSupervisorTypeEntity();
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
