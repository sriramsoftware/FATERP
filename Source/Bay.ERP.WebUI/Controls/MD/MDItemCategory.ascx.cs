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
    public partial class MDItemCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ItemCategoryID
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

        public MDItemCategoryEntity _MDItemCategoryEntity
        {
            get
            {
                MDItemCategoryEntity entity = new MDItemCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDItemCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDItemCategoryEntity CurrentMDItemCategoryEntity
        {
            get
            {
                if (_ItemCategoryID > 0)
                {
                    if (_MDItemCategoryEntity.ItemCategoryID != _ItemCategoryID)
                    {
                        _MDItemCategoryEntity = FCCMDItemCategory.GetFacadeCreate().GetByID(_ItemCategoryID);
                    }
                }

                return _MDItemCategoryEntity;
            }
            set
            {
                _MDItemCategoryEntity = value;
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
            MDItemCategoryEntity mDItemCategoryEntity = CurrentMDItemCategoryEntity;


            if (!mDItemCategoryEntity.IsNew)
            {
                txtCategoryName.Text = mDItemCategoryEntity.CategoryName.ToString();
                txtDescription.Text = mDItemCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDItemCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void LoadTreeView()
        {
            treeItemCategory.ReBuildTree();
        }

        private Boolean ValidateInput()
        {
            Boolean validationResult = true;

            if (treeItemCategory.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Parent Item Category.", true);
            }

            return validationResult;
        }

        private Boolean ValidateInput1()
        {
            Boolean validationResult = true;

            if (treeItemCategory.SelectedNode == null)
            {
                validationResult = false;

                MiscUtil.ShowMessage(lblMessage, "Please Select Item Category.", true);
            }

            return validationResult;
        }

        private MDItemCategoryEntity BuildMDItemCategoryEntity()
        {
            MDItemCategoryEntity mDItemCategoryEntity = CurrentMDItemCategoryEntity;

            mDItemCategoryEntity.CategoryName = txtCategoryName.Text.Trim();
            mDItemCategoryEntity.Description = txtDescription.Text.Trim();
            mDItemCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDItemCategoryEntity;
        }

        private void SaveMDItemCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDItemCategoryEntity mDItemCategoryEntity = BuildMDItemCategoryEntity();

                    Int64 result = -1;

                    if (mDItemCategoryEntity.IsNew)
                    {
                        if (treeItemCategory.SelectedNode != null)
                        {
                            if (treeItemCategory.SelectedValue == "0")
                            {
                                mDItemCategoryEntity.ParentItemCategoryID = null;
                            }
                            else
                            {
                                mDItemCategoryEntity.ParentItemCategoryID = Int64.Parse(treeItemCategory.SelectedValue);
                            }
                        }

                        result = FCCMDItemCategory.GetFacadeCreate().Add(mDItemCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDItemCategoryEntity.FLD_NAME_ItemCategoryID, mDItemCategoryEntity.ItemCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDItemCategory.GetFacadeCreate().Update(mDItemCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ItemCategoryID = 0;
                        _MDItemCategoryEntity = new MDItemCategoryEntity();

                        // clearing cache
                        FCCMDItemCategory.GetFacadeCreate().RemoveCache();
                        
                        PrepareInitialView();

                        LoadTreeView();

                        if (mDItemCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Item Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Item Category Information has been updated successfully.", false);
                        }

                        
                    }
                    else
                    {
                        if (mDItemCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Item Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Item Category Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        private void EditItemCategory()
        {
            Int64 ItemCategoryID;

            Int64.TryParse(treeItemCategory.SelectedValue, out ItemCategoryID);

            if (ItemCategoryID > 0)
            {
                _ItemCategoryID = ItemCategoryID;

                PrepareEditView();
            }
        }

        private void DeleteItemCategory()
        {
            Int64 ItemCategoryID;

            Int64.TryParse(treeItemCategory.SelectedValue, out ItemCategoryID);

            if (ItemCategoryID > 0)
            {
                try
                {
                    Int64 result = -1;

                    String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemCategoryEntity.FLD_NAME_ItemCategoryID, ItemCategoryID.ToString(), SQLMatchType.Equal);

                    MDItemCategoryEntity mDItemCategoryEntity = new MDItemCategoryEntity();


                    result = FCCMDItemCategory.GetFacadeCreate().Delete(mDItemCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                    if (result == 0)
                    {
                        _ItemCategoryID = 0;
                        _MDItemCategoryEntity = new MDItemCategoryEntity();
                        
                        // clearing cache
                        FCCMDItemCategory.GetFacadeCreate().RemoveCache();

                        PrepareInitialView();

                        LoadTreeView();

                        MiscUtil.ShowMessage(lblMessage, "Item Category has been successfully deleted.", true);
                    }
                    else
                    {
                        MiscUtil.ShowMessage(lblMessage, "Failed to delete Item Category.", true);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveMDItemCategoryEntity();
            }
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ItemCategoryID = 0;
            _MDItemCategoryEntity = new MDItemCategoryEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void lnkBtnEditItemCategory_Click(object sender, EventArgs e)
        {
            if (ValidateInput1())
            {
                EditItemCategory();
            }
        }

        protected void lnkBtnremoveItemCategory_Click(object sender, EventArgs e)
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
