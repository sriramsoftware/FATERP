// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class MDSupplierAddressTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _SupplierAddressTypeID
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

        public MDSupplierAddressTypeEntity _MDSupplierAddressTypeEntity
        {
            get
            {
                MDSupplierAddressTypeEntity entity = new MDSupplierAddressTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSupplierAddressTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSupplierAddressTypeEntity CurrentMDSupplierAddressTypeEntity
        {
            get
            {
                if (_SupplierAddressTypeID > 0)
                {
                    if (_MDSupplierAddressTypeEntity.SupplierAddressTypeID != _SupplierAddressTypeID)
                    {
                        _MDSupplierAddressTypeEntity = FCCMDSupplierAddressType.GetFacadeCreate().GetByID(_SupplierAddressTypeID);
                    }
                }

                return _MDSupplierAddressTypeEntity;
            }
            set
            {
                _MDSupplierAddressTypeEntity = value;
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
            MDSupplierAddressTypeEntity mDSupplierAddressTypeEntity = CurrentMDSupplierAddressTypeEntity;


            if (!mDSupplierAddressTypeEntity.IsNew)
            {
                txtName.Text = mDSupplierAddressTypeEntity.Name.ToString();
                txtDescription.Text = mDSupplierAddressTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDSupplierAddressTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSupplierAddressTypeList();
        }

        private void BindMDSupplierAddressTypeList()
        {
            lvMDSupplierAddressType.DataBind();
        }

        private MDSupplierAddressTypeEntity BuildMDSupplierAddressTypeEntity()
        {
            MDSupplierAddressTypeEntity mDSupplierAddressTypeEntity = CurrentMDSupplierAddressTypeEntity;

            mDSupplierAddressTypeEntity.Name = txtName.Text.Trim();
            mDSupplierAddressTypeEntity.Description = txtDescription.Text.Trim();
            mDSupplierAddressTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSupplierAddressTypeEntity;
        }

        private void SaveMDSupplierAddressTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSupplierAddressTypeEntity mDSupplierAddressTypeEntity = BuildMDSupplierAddressTypeEntity();

                    Int64 result = -1;

                    if (mDSupplierAddressTypeEntity.IsNew)
                    {
                        result = FCCMDSupplierAddressType.GetFacadeCreate().Add(mDSupplierAddressTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSupplierAddressTypeEntity.FLD_NAME_SupplierAddressTypeID, mDSupplierAddressTypeEntity.SupplierAddressTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSupplierAddressType.GetFacadeCreate().Update(mDSupplierAddressTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupplierAddressTypeID = 0;
                        _MDSupplierAddressTypeEntity = new MDSupplierAddressTypeEntity();
                        PrepareInitialView();
                        BindMDSupplierAddressTypeList();

                        if (mDSupplierAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Address Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Address Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSupplierAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Address Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Address Type Information.", false);
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

        protected void lvMDSupplierAddressType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierAddressTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierAddressTypeID);

            if (SupplierAddressTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierAddressTypeID = SupplierAddressTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSupplierAddressTypeEntity.FLD_NAME_SupplierAddressTypeID, SupplierAddressTypeID.ToString(), SQLMatchType.Equal);

                        MDSupplierAddressTypeEntity mDSupplierAddressTypeEntity = new MDSupplierAddressTypeEntity();


                        result = FCCMDSupplierAddressType.GetFacadeCreate().Delete(mDSupplierAddressTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierAddressTypeID = 0;
                            _MDSupplierAddressTypeEntity = new MDSupplierAddressTypeEntity();
                            PrepareInitialView();
                            BindMDSupplierAddressTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Address Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Address Type.", true);
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

        protected void odsMDSupplierAddressType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSupplierAddressTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupplierAddressTypeID = 0;
            _MDSupplierAddressTypeEntity = new MDSupplierAddressTypeEntity();
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
