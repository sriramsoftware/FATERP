// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:00:49




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
    public partial class MDConstructionToolCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ConstructionToolCategoryID
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

        public MDConstructionToolCategoryEntity _MDConstructionToolCategoryEntity
        {
            get
            {
                MDConstructionToolCategoryEntity entity = new MDConstructionToolCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDConstructionToolCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDConstructionToolCategoryEntity CurrentMDConstructionToolCategoryEntity
        {
            get
            {
                if (_ConstructionToolCategoryID > 0)
                {
                    if (_MDConstructionToolCategoryEntity.ConstructionToolCategoryID != _ConstructionToolCategoryID)
                    {
                        _MDConstructionToolCategoryEntity = FCCMDConstructionToolCategory.GetFacadeCreate().GetByID(_ConstructionToolCategoryID);
                    }
                }

                return _MDConstructionToolCategoryEntity;
            }
            set
            {
                _MDConstructionToolCategoryEntity = value;
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
            MDConstructionToolCategoryEntity mDConstructionToolCategoryEntity = CurrentMDConstructionToolCategoryEntity;


            if (!mDConstructionToolCategoryEntity.IsNew)
            {
                txtName.Text = mDConstructionToolCategoryEntity.Name.ToString();
                txtDescription.Text = mDConstructionToolCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDConstructionToolCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDConstructionToolCategoryList();
        }

        private void BindMDConstructionToolCategoryList()
        {
            lvMDConstructionToolCategory.DataBind();
        }

        private MDConstructionToolCategoryEntity BuildMDConstructionToolCategoryEntity()
        {
            MDConstructionToolCategoryEntity mDConstructionToolCategoryEntity = CurrentMDConstructionToolCategoryEntity;

            mDConstructionToolCategoryEntity.Name = txtName.Text.Trim();
            mDConstructionToolCategoryEntity.Description = txtDescription.Text.Trim();
            mDConstructionToolCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDConstructionToolCategoryEntity;
        }

        private void SaveMDConstructionToolCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDConstructionToolCategoryEntity mDConstructionToolCategoryEntity = BuildMDConstructionToolCategoryEntity();

                    Int64 result = -1;

                    if (mDConstructionToolCategoryEntity.IsNew)
                    {
                        result = FCCMDConstructionToolCategory.GetFacadeCreate().Add(mDConstructionToolCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDConstructionToolCategoryEntity.FLD_NAME_ConstructionToolCategoryID, mDConstructionToolCategoryEntity.ConstructionToolCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDConstructionToolCategory.GetFacadeCreate().Update(mDConstructionToolCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ConstructionToolCategoryID = 0;
                        _MDConstructionToolCategoryEntity = new MDConstructionToolCategoryEntity();
                        PrepareInitialView();
                        BindMDConstructionToolCategoryList();

                        if (mDConstructionToolCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDConstructionToolCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Construction Tool Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Construction Tool Category Information.", false);
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

        protected void lvMDConstructionToolCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ConstructionToolCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ConstructionToolCategoryID);

            if (ConstructionToolCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ConstructionToolCategoryID = ConstructionToolCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDConstructionToolCategoryEntity.FLD_NAME_ConstructionToolCategoryID, ConstructionToolCategoryID.ToString(), SQLMatchType.Equal);

                        MDConstructionToolCategoryEntity mDConstructionToolCategoryEntity = new MDConstructionToolCategoryEntity();


                        result = FCCMDConstructionToolCategory.GetFacadeCreate().Delete(mDConstructionToolCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ConstructionToolCategoryID = 0;
                            _MDConstructionToolCategoryEntity = new MDConstructionToolCategoryEntity();
                            PrepareInitialView();
                            BindMDConstructionToolCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Construction Tool Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Construction Tool Category.", true);
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

        protected void odsMDConstructionToolCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDConstructionToolCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ConstructionToolCategoryID = 0;
            _MDConstructionToolCategoryEntity = new MDConstructionToolCategoryEntity();
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
