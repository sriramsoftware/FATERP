// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class MDAddressTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _AddressTypeID
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

        public MDAddressTypeEntity _MDAddressTypeEntity
        {
            get
            {
                MDAddressTypeEntity entity = new MDAddressTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAddressTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAddressTypeEntity CurrentMDAddressTypeEntity
        {
            get
            {
                if (_AddressTypeID > 0)
                {
                    if (_MDAddressTypeEntity.AddressTypeID != _AddressTypeID)
                    {
                        _MDAddressTypeEntity = FCCMDAddressType.GetFacadeCreate().GetByID(_AddressTypeID);
                    }
                }

                return _MDAddressTypeEntity;
            }
            set
            {
                _MDAddressTypeEntity = value;
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
            MDAddressTypeEntity mDAddressTypeEntity = CurrentMDAddressTypeEntity;


            if (!mDAddressTypeEntity.IsNew)
            {
                txtName.Text = mDAddressTypeEntity.Name.ToString();
                txtDescription.Text = mDAddressTypeEntity.Description.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAddressTypeList();
        }

        private void BindMDAddressTypeList()
        {
            lvMDAddressType.DataBind();
        }

        private MDAddressTypeEntity BuildMDAddressTypeEntity()
        {
            MDAddressTypeEntity mDAddressTypeEntity = CurrentMDAddressTypeEntity;

            mDAddressTypeEntity.Name = txtName.Text.Trim();
            mDAddressTypeEntity.Description = txtDescription.Text.Trim();

            return mDAddressTypeEntity;
        }

        private void SaveMDAddressTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAddressTypeEntity mDAddressTypeEntity = BuildMDAddressTypeEntity();

                    Int64 result = -1;

                    if (mDAddressTypeEntity.IsNew)
                    {
                        result = FCCMDAddressType.GetFacadeCreate().Add(mDAddressTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAddressTypeEntity.FLD_NAME_AddressTypeID, mDAddressTypeEntity.AddressTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAddressType.GetFacadeCreate().Update(mDAddressTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AddressTypeID = 0;
                        _MDAddressTypeEntity = new MDAddressTypeEntity();
                        PrepareInitialView();
                        BindMDAddressTypeList();

                        if (mDAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Address Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Address Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAddressTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Address Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Address Type Information.", false);
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

        protected void lvMDAddressType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AddressTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out AddressTypeID);

            if (AddressTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AddressTypeID = AddressTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAddressTypeEntity.FLD_NAME_AddressTypeID, AddressTypeID.ToString(), SQLMatchType.Equal);

                        MDAddressTypeEntity mDAddressTypeEntity = new MDAddressTypeEntity();


                        result = FCCMDAddressType.GetFacadeCreate().Delete(mDAddressTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AddressTypeID = 0;
                            _MDAddressTypeEntity = new MDAddressTypeEntity();
                            PrepareInitialView();
                            BindMDAddressTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Address Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Address Type.", true);
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

        protected void odsMDAddressType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAddressTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AddressTypeID = 0;
            _MDAddressTypeEntity = new MDAddressTypeEntity();
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
