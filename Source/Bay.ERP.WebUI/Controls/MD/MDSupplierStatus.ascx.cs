// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




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
    public partial class MDSupplierStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _SupplierStatusID
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

        public MDSupplierStatusEntity _MDSupplierStatusEntity
        {
            get
            {
                MDSupplierStatusEntity entity = new MDSupplierStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSupplierStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSupplierStatusEntity CurrentMDSupplierStatusEntity
        {
            get
            {
                if (_SupplierStatusID > 0)
                {
                    if (_MDSupplierStatusEntity.SupplierStatusID != _SupplierStatusID)
                    {
                        _MDSupplierStatusEntity = FCCMDSupplierStatus.GetFacadeCreate().GetByID(_SupplierStatusID);
                    }
                }

                return _MDSupplierStatusEntity;
            }
            set
            {
                _MDSupplierStatusEntity = value;
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
            MDSupplierStatusEntity mDSupplierStatusEntity = CurrentMDSupplierStatusEntity;


            if (!mDSupplierStatusEntity.IsNew)
            {
                txtName.Text = mDSupplierStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDSupplierStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSupplierStatusList();
        }

        private void BindMDSupplierStatusList()
        {
            lvMDSupplierStatus.DataBind();
        }

        private MDSupplierStatusEntity BuildMDSupplierStatusEntity()
        {
            MDSupplierStatusEntity mDSupplierStatusEntity = CurrentMDSupplierStatusEntity;

            mDSupplierStatusEntity.Name = txtName.Text.Trim();
            mDSupplierStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSupplierStatusEntity;
        }

        private void SaveMDSupplierStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSupplierStatusEntity mDSupplierStatusEntity = BuildMDSupplierStatusEntity();

                    Int64 result = -1;

                    if (mDSupplierStatusEntity.IsNew)
                    {
                        result = FCCMDSupplierStatus.GetFacadeCreate().Add(mDSupplierStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSupplierStatusEntity.FLD_NAME_SupplierStatusID, mDSupplierStatusEntity.SupplierStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSupplierStatus.GetFacadeCreate().Update(mDSupplierStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupplierStatusID = 0;
                        _MDSupplierStatusEntity = new MDSupplierStatusEntity();
                        PrepareInitialView();
                        BindMDSupplierStatusList();

                        if (mDSupplierStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSupplierStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Status Information.", false);
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

        protected void lvMDSupplierStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierStatusID);

            if (SupplierStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierStatusID = SupplierStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSupplierStatusEntity.FLD_NAME_SupplierStatusID, SupplierStatusID.ToString(), SQLMatchType.Equal);

                        MDSupplierStatusEntity mDSupplierStatusEntity = new MDSupplierStatusEntity();


                        result = FCCMDSupplierStatus.GetFacadeCreate().Delete(mDSupplierStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierStatusID = 0;
                            _MDSupplierStatusEntity = new MDSupplierStatusEntity();
                            PrepareInitialView();
                            BindMDSupplierStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Status.", true);
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

        protected void odsMDSupplierStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSupplierStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupplierStatusID = 0;
            _MDSupplierStatusEntity = new MDSupplierStatusEntity();
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
