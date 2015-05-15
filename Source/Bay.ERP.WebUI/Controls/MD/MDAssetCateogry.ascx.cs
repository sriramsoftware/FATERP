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
    public partial class MDAssetCateogryControl : BaseControl
    {       
        #region Properties

        public Int64 _AssetCateogryID
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

        public MDAssetCateogryEntity _MDAssetCateogryEntity
        {
            get
            {
                MDAssetCateogryEntity entity = new MDAssetCateogryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDAssetCateogryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDAssetCateogryEntity CurrentMDAssetCateogryEntity
        {
            get
            {
                if (_AssetCateogryID > 0)
                {
                    if (_MDAssetCateogryEntity.AssetCateogryID != _AssetCateogryID)
                    {
                        _MDAssetCateogryEntity = FCCMDAssetCateogry.GetFacadeCreate().GetByID(_AssetCateogryID);
                    }
                }

                return _MDAssetCateogryEntity;
            }
            set
            {
                _MDAssetCateogryEntity = value;
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

            txtCategoryName.Text = String.Empty;
            txtDescription.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDAssetCateogryEntity mDAssetCateogryEntity = CurrentMDAssetCateogryEntity;


            if (!mDAssetCateogryEntity.IsNew)
            {   
                txtCategoryName.Text = mDAssetCateogryEntity.CategoryName.ToString();
                txtDescription.Text = mDAssetCateogryEntity.Description.ToString();
                chkIsRemoved.Checked = mDAssetCateogryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void LoadTreeView()
        {
            treeAssetCategory.ReBuildTree();
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeAssetCategory.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Parent Asset Category.", true);
            }

            return validationResult;
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;

            if (treeAssetCategory.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Asset Category.", true);
            }

            return validationResult;
        }

        private void BindList()
        {
            BindMDAssetCateogryList();
        }

        private void BindMDAssetCateogryList()
        {
           
        }

        private MDAssetCateogryEntity BuildMDAssetCateogryEntity()
        {
            MDAssetCateogryEntity mDAssetCateogryEntity = CurrentMDAssetCateogryEntity;

            mDAssetCateogryEntity.CategoryName = txtCategoryName.Text.Trim();
            mDAssetCateogryEntity.Description = txtDescription.Text.Trim();
            mDAssetCateogryEntity.IsRemoved = chkIsRemoved.Checked;

            return mDAssetCateogryEntity;
        }

        private void EditItemCategory()
        {
            Int64 AssetCategoryID;

            Int64.TryParse(treeAssetCategory.SelectedValue, out AssetCategoryID);

            if (AssetCategoryID > 0)
            {
               _AssetCateogryID= AssetCategoryID;

                PrepareEditView();
            }
        }

        private void DeleteItemCategory()
        {
            Int64 AssetCategoryID;

            Int64.TryParse(treeAssetCategory.SelectedValue, out AssetCategoryID);

            if (AssetCategoryID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetCateogryEntity.FLD_NAME_AssetCateogryID, AssetCategoryID.ToString(), SQLMatchType.Equal);

                    MDAssetCateogryEntity mDAssetCateogryEntity = new MDAssetCateogryEntity();


                    result = FCCMDAssetCateogry.GetFacadeCreate().Delete(mDAssetCateogryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _AssetCateogryID = 0;
                        _MDAssetCateogryEntity = new MDAssetCateogryEntity();
                        
                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Asset Category has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Asset Category.", true);
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void SaveMDAssetCateogryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDAssetCateogryEntity mDAssetCateogryEntity = BuildMDAssetCateogryEntity();

                    Int64 result = -1;
                  
                    if (mDAssetCateogryEntity.IsNew)
                    {
                        if (treeAssetCategory.SelectedNode != null)
                        {
                            if (treeAssetCategory.SelectedValue == "0")
                            {
                                mDAssetCateogryEntity.ParentAssetCateogryID = null;
                            }
                            else
                            {
                                mDAssetCateogryEntity.ParentAssetCateogryID = Int64.Parse(treeAssetCategory.SelectedValue);
                            }
                        }

                        result = FCCMDAssetCateogry.GetFacadeCreate().Add(mDAssetCateogryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDAssetCateogryEntity.FLD_NAME_AssetCateogryID, mDAssetCateogryEntity.AssetCateogryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDAssetCateogry.GetFacadeCreate().Update(mDAssetCateogryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AssetCateogryID = 0;
                        _MDAssetCateogryEntity = new MDAssetCateogryEntity();
                        PrepareInitialView();
                        LoadTreeView();

                        if (mDAssetCateogryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Asset Cateogry Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Asset Cateogry Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDAssetCateogryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Asset Cateogry Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Asset Cateogry Information.", false);
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

        protected void lvMDAssetCateogry_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AssetCateogryID;

            Int64.TryParse(e.CommandArgument.ToString(), out AssetCateogryID);

            if (AssetCateogryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AssetCateogryID = AssetCateogryID;

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetCateogryEntity.FLD_NAME_AssetCateogryID, AssetCateogryID.ToString(), SQLMatchType.Equal);

                        MDAssetCateogryEntity mDAssetCateogryEntity = new MDAssetCateogryEntity();


                        result = FCCMDAssetCateogry.GetFacadeCreate().Delete(mDAssetCateogryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AssetCateogryID = 0;
                            _MDAssetCateogryEntity = new MDAssetCateogryEntity();
                            PrepareInitialView();
                            BindMDAssetCateogryList();

                            MiscUtil.ShowMessage(lblMessage, "Asset Cateogry has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Asset Cateogry.", true);
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

        protected void odsMDAssetCateogry_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDAssetCateogryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AssetCateogryID = 0;
            _MDAssetCateogryEntity = new MDAssetCateogryEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void lnkBtnEditAssetCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                EditItemCategory();
            }
        }

        protected void lnkBtnremoveAssetCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                DeleteItemCategory();
            }
        }

        protected void lnkBtnAdvanceSearch_Click(object sender, EventArgs e)
        {
            String navUrl = UrlHelper.BuildSecureUrl("~/Common/CMNAdvanceSearch.aspx", string.Empty, "do", "ItemCategoryAdvanceSearch", "EntityName", "Bay.ERP.Common.BusinessEntities.MDItemCategoryEntity").ToString();
            Response.Redirect(navUrl);
        }

        #endregion

        #endregion Event
    }
}
