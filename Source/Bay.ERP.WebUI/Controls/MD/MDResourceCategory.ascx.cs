// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class MDResourceCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ResourceCategoryID
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

        public MDResourceCategoryEntity _MDResourceCategoryEntity
        {
            get
            {
                MDResourceCategoryEntity entity = new MDResourceCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDResourceCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDResourceCategoryEntity CurrentMDResourceCategoryEntity
        {
            get
            {
                if (_ResourceCategoryID > 0)
                {
                    if (_MDResourceCategoryEntity.ResourceCategoryID != _ResourceCategoryID)
                    {
                        _MDResourceCategoryEntity = FCCMDResourceCategory.GetFacadeCreate().GetByID(_ResourceCategoryID);
                    }
                }

                return _MDResourceCategoryEntity;
            }
            set
            {
                _MDResourceCategoryEntity = value;
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
            MDResourceCategoryEntity mDResourceCategoryEntity = CurrentMDResourceCategoryEntity;


            if (!mDResourceCategoryEntity.IsNew)
            {
                txtName.Text = mDResourceCategoryEntity.Name.ToString();
                txtDescription.Text = mDResourceCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDResourceCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDResourceCategoryList();
        }

        private void BindMDResourceCategoryList()
        {
            lvMDResourceCategory.DataBind();
        }

        private MDResourceCategoryEntity BuildMDResourceCategoryEntity()
        {
            MDResourceCategoryEntity mDResourceCategoryEntity = CurrentMDResourceCategoryEntity;

            mDResourceCategoryEntity.Name = txtName.Text.Trim();
            mDResourceCategoryEntity.Description = txtDescription.Text.Trim();
            mDResourceCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDResourceCategoryEntity;
        }

        private void SaveMDResourceCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDResourceCategoryEntity mDResourceCategoryEntity = BuildMDResourceCategoryEntity();

                    Int64 result = -1;

                    if (mDResourceCategoryEntity.IsNew)
                    {
                        result = FCCMDResourceCategory.GetFacadeCreate().Add(mDResourceCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDResourceCategoryEntity.FLD_NAME_ResourceCategoryID, mDResourceCategoryEntity.ResourceCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDResourceCategory.GetFacadeCreate().Update(mDResourceCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ResourceCategoryID = 0;
                        _MDResourceCategoryEntity = new MDResourceCategoryEntity();
                        PrepareInitialView();
                        BindMDResourceCategoryList();

                        if (mDResourceCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Resource Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Resource Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDResourceCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Resource Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Resource Category Information.", false);
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

        protected void lvMDResourceCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ResourceCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ResourceCategoryID);

            if (ResourceCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ResourceCategoryID = ResourceCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDResourceCategoryEntity.FLD_NAME_ResourceCategoryID, ResourceCategoryID.ToString(), SQLMatchType.Equal);

                        MDResourceCategoryEntity mDResourceCategoryEntity = new MDResourceCategoryEntity();


                        result = FCCMDResourceCategory.GetFacadeCreate().Delete(mDResourceCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ResourceCategoryID = 0;
                            _MDResourceCategoryEntity = new MDResourceCategoryEntity();
                            PrepareInitialView();
                            BindMDResourceCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Resource Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Resource Category.", true);
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

        protected void odsMDResourceCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDResourceCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ResourceCategoryID = 0;
            _MDResourceCategoryEntity = new MDResourceCategoryEntity();
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
