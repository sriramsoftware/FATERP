// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




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
    public partial class MDSupplierTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _SupplierTypeID
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

        public MDSupplierTypeEntity _MDSupplierTypeEntity
        {
            get
            {
                MDSupplierTypeEntity entity = new MDSupplierTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSupplierTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSupplierTypeEntity CurrentMDSupplierTypeEntity
        {
            get
            {
                if (_SupplierTypeID > 0)
                {
                    if (_MDSupplierTypeEntity.SupplierTypeID != _SupplierTypeID)
                    {
                        _MDSupplierTypeEntity = FCCMDSupplierType.GetFacadeCreate().GetByID(_SupplierTypeID);
                    }
                }

                return _MDSupplierTypeEntity;
            }
            set
            {
                _MDSupplierTypeEntity = value;
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
            MDSupplierTypeEntity mDSupplierTypeEntity = CurrentMDSupplierTypeEntity;


            if (!mDSupplierTypeEntity.IsNew)
            {
                txtName.Text = mDSupplierTypeEntity.Name.ToString();
                txtDescription.Text = mDSupplierTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDSupplierTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSupplierTypeList();
        }

        private void BindMDSupplierTypeList()
        {
            lvMDSupplierType.DataBind();
        }

        private MDSupplierTypeEntity BuildMDSupplierTypeEntity()
        {
            MDSupplierTypeEntity mDSupplierTypeEntity = CurrentMDSupplierTypeEntity;

            mDSupplierTypeEntity.Name = txtName.Text.Trim();
            mDSupplierTypeEntity.Description = txtDescription.Text.Trim();
            mDSupplierTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSupplierTypeEntity;
        }

        private void SaveMDSupplierTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSupplierTypeEntity mDSupplierTypeEntity = BuildMDSupplierTypeEntity();

                    Int64 result = -1;

                    if (mDSupplierTypeEntity.IsNew)
                    {
                        result = FCCMDSupplierType.GetFacadeCreate().Add(mDSupplierTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSupplierTypeEntity.FLD_NAME_SupplierTypeID, mDSupplierTypeEntity.SupplierTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSupplierType.GetFacadeCreate().Update(mDSupplierTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupplierTypeID = 0;
                        _MDSupplierTypeEntity = new MDSupplierTypeEntity();
                        PrepareInitialView();
                        BindMDSupplierTypeList();

                        if (mDSupplierTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSupplierTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Type Information.", false);
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

        protected void lvMDSupplierType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierTypeID);

            if (SupplierTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierTypeID = SupplierTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSupplierTypeEntity.FLD_NAME_SupplierTypeID, SupplierTypeID.ToString(), SQLMatchType.Equal);

                        MDSupplierTypeEntity mDSupplierTypeEntity = new MDSupplierTypeEntity();


                        result = FCCMDSupplierType.GetFacadeCreate().Delete(mDSupplierTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierTypeID = 0;
                            _MDSupplierTypeEntity = new MDSupplierTypeEntity();
                            PrepareInitialView();
                            BindMDSupplierTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Type.", true);
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

        protected void odsMDSupplierType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSupplierTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupplierTypeID = 0;
            _MDSupplierTypeEntity = new MDSupplierTypeEntity();
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
