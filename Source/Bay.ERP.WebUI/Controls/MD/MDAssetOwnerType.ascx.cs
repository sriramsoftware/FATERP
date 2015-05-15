// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




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
    public partial class MDAssetOwnerTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _AssetOwnerTypeID
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

        public MDAssetOwnerTypeEntity _MDAssetOwnerTypeEntity
        {
            get
            {
                MDAssetOwnerTypeEntity entity = new MDAssetOwnerTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAssetOwnerTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAssetOwnerTypeEntity CurrentMDAssetOwnerTypeEntity
        {
            get
            {
                if (_AssetOwnerTypeID > 0)
                {
                    if (_MDAssetOwnerTypeEntity.AssetOwnerTypeID != _AssetOwnerTypeID)
                    {
                        _MDAssetOwnerTypeEntity = FCCMDAssetOwnerType.GetFacadeCreate().GetByID(_AssetOwnerTypeID);
                    }
                }

                return _MDAssetOwnerTypeEntity;
            }
            set
            {
                _MDAssetOwnerTypeEntity = value;
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
            MDAssetOwnerTypeEntity mDAssetOwnerTypeEntity = CurrentMDAssetOwnerTypeEntity;


            if (!mDAssetOwnerTypeEntity.IsNew)
            {
                txtName.Text = mDAssetOwnerTypeEntity.Name.ToString();
                txtDescription.Text = mDAssetOwnerTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDAssetOwnerTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAssetOwnerTypeList();
        }

        private void BindMDAssetOwnerTypeList()
        {
            lvMDAssetOwnerType.DataBind();
        }

        private MDAssetOwnerTypeEntity BuildMDAssetOwnerTypeEntity()
        {
            MDAssetOwnerTypeEntity mDAssetOwnerTypeEntity = CurrentMDAssetOwnerTypeEntity;

            mDAssetOwnerTypeEntity.Name = txtName.Text.Trim();
            mDAssetOwnerTypeEntity.Description = txtDescription.Text.Trim();
            mDAssetOwnerTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDAssetOwnerTypeEntity;
        }

        private void SaveMDAssetOwnerTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAssetOwnerTypeEntity mDAssetOwnerTypeEntity = BuildMDAssetOwnerTypeEntity();

                    Int64 result = -1;

                    if (mDAssetOwnerTypeEntity.IsNew)
                    {
                        result = FCCMDAssetOwnerType.GetFacadeCreate().Add(mDAssetOwnerTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAssetOwnerTypeEntity.FLD_NAME_AssetOwnerTypeID, mDAssetOwnerTypeEntity.AssetOwnerTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAssetOwnerType.GetFacadeCreate().Update(mDAssetOwnerTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AssetOwnerTypeID = 0;
                        _MDAssetOwnerTypeEntity = new MDAssetOwnerTypeEntity();
                        PrepareInitialView();
                        BindMDAssetOwnerTypeList();

                        if (mDAssetOwnerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Asset Owner Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Asset Owner Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAssetOwnerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Asset Owner Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Asset Owner Type Information.", false);
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

        protected void lvMDAssetOwnerType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AssetOwnerTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out AssetOwnerTypeID);

            if (AssetOwnerTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AssetOwnerTypeID = AssetOwnerTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetOwnerTypeEntity.FLD_NAME_AssetOwnerTypeID, AssetOwnerTypeID.ToString(), SQLMatchType.Equal);

                        MDAssetOwnerTypeEntity mDAssetOwnerTypeEntity = new MDAssetOwnerTypeEntity();


                        result = FCCMDAssetOwnerType.GetFacadeCreate().Delete(mDAssetOwnerTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AssetOwnerTypeID = 0;
                            _MDAssetOwnerTypeEntity = new MDAssetOwnerTypeEntity();
                            PrepareInitialView();
                            BindMDAssetOwnerTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Asset Owner Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Asset Owner Type.", true);
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

        protected void odsMDAssetOwnerType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAssetOwnerTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AssetOwnerTypeID = 0;
            _MDAssetOwnerTypeEntity = new MDAssetOwnerTypeEntity();
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
