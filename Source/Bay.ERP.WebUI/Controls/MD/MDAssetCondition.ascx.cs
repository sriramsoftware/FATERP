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
    public partial class MDAssetConditionControl : BaseControl
    {       
        #region Properties

        public Int64 _AssetConditionID
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

        public MDAssetConditionEntity _MDAssetConditionEntity
        {
            get
            {
                MDAssetConditionEntity entity = new MDAssetConditionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAssetConditionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAssetConditionEntity CurrentMDAssetConditionEntity
        {
            get
            {
                if (_AssetConditionID > 0)
                {
                    if (_MDAssetConditionEntity.AssetConditionID != _AssetConditionID)
                    {
                        _MDAssetConditionEntity = FCCMDAssetCondition.GetFacadeCreate().GetByID(_AssetConditionID);
                    }
                }

                return _MDAssetConditionEntity;
            }
            set
            {
                _MDAssetConditionEntity = value;
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
            MDAssetConditionEntity mDAssetConditionEntity = CurrentMDAssetConditionEntity;


            if (!mDAssetConditionEntity.IsNew)
            {
                txtName.Text = mDAssetConditionEntity.Name.ToString();
                txtDescription.Text = mDAssetConditionEntity.Description.ToString();
                chkIsRemoved.Checked = mDAssetConditionEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDAssetConditionList();
        }

        private void BindMDAssetConditionList()
        {
            lvMDAssetCondition.DataBind();
        }

        private MDAssetConditionEntity BuildMDAssetConditionEntity()
        {
            MDAssetConditionEntity mDAssetConditionEntity = CurrentMDAssetConditionEntity;

            mDAssetConditionEntity.Name = txtName.Text.Trim();
            mDAssetConditionEntity.Description = txtDescription.Text.Trim();
            mDAssetConditionEntity.IsRemoved = chkIsRemoved.Checked;


            return mDAssetConditionEntity;
        }

        private void SaveMDAssetConditionEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAssetConditionEntity mDAssetConditionEntity = BuildMDAssetConditionEntity();

                    Int64 result = -1;

                    if (mDAssetConditionEntity.IsNew)
                    {
                        result = FCCMDAssetCondition.GetFacadeCreate().Add(mDAssetConditionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAssetConditionEntity.FLD_NAME_AssetConditionID, mDAssetConditionEntity.AssetConditionID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAssetCondition.GetFacadeCreate().Update(mDAssetConditionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AssetConditionID = 0;
                        _MDAssetConditionEntity = new MDAssetConditionEntity();
                        PrepareInitialView();
                        BindMDAssetConditionList();

                        if (mDAssetConditionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Asset Condition Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Asset Condition Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAssetConditionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Asset Condition Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Asset Condition Information.", false);
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

        protected void lvMDAssetCondition_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AssetConditionID;

            Int64.TryParse(e.CommandArgument.ToString(), out AssetConditionID);

            if (AssetConditionID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AssetConditionID = AssetConditionID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetConditionEntity.FLD_NAME_AssetConditionID, AssetConditionID.ToString(), SQLMatchType.Equal);

                        MDAssetConditionEntity mDAssetConditionEntity = new MDAssetConditionEntity();


                        result = FCCMDAssetCondition.GetFacadeCreate().Delete(mDAssetConditionEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AssetConditionID = 0;
                            _MDAssetConditionEntity = new MDAssetConditionEntity();
                            PrepareInitialView();
                            BindMDAssetConditionList();

                            MiscUtil.ShowMessage(lblMessage, "Asset Condition has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Asset Condition.", true);
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

        protected void odsMDAssetCondition_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAssetConditionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AssetConditionID = 0;
            _MDAssetConditionEntity = new MDAssetConditionEntity();
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
