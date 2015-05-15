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
    public partial class MDSupplierItemCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _SupplierItemCategoryID
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

        public MDSupplierItemCategoryEntity _MDSupplierItemCategoryEntity
        {
            get
            {
                MDSupplierItemCategoryEntity entity = new MDSupplierItemCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSupplierItemCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSupplierItemCategoryEntity CurrentMDSupplierItemCategoryEntity
        {
            get
            {
                if (_SupplierItemCategoryID > 0)
                {
                    if (_MDSupplierItemCategoryEntity.SupplierItemCategoryID != _SupplierItemCategoryID)
                    {
                        _MDSupplierItemCategoryEntity = FCCMDSupplierItemCategory.GetFacadeCreate().GetByID(_SupplierItemCategoryID);
                    }
                }

                return _MDSupplierItemCategoryEntity;
            }
            set
            {
                _MDSupplierItemCategoryEntity = value;
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
            MDSupplierItemCategoryEntity mDSupplierItemCategoryEntity = CurrentMDSupplierItemCategoryEntity;


            if (!mDSupplierItemCategoryEntity.IsNew)
            {
                txtName.Text = mDSupplierItemCategoryEntity.Name.ToString();
                chkIsRemoved.Checked = mDSupplierItemCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSupplierItemCategoryList();
        }

        private void BindMDSupplierItemCategoryList()
        {
            lvMDSupplierItemCategory.DataBind();
        }

        private MDSupplierItemCategoryEntity BuildMDSupplierItemCategoryEntity()
        {
            MDSupplierItemCategoryEntity mDSupplierItemCategoryEntity = CurrentMDSupplierItemCategoryEntity;

            mDSupplierItemCategoryEntity.Name = txtName.Text.Trim();
            mDSupplierItemCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSupplierItemCategoryEntity;
        }

        private void SaveMDSupplierItemCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSupplierItemCategoryEntity mDSupplierItemCategoryEntity = BuildMDSupplierItemCategoryEntity();

                    Int64 result = -1;

                    if (mDSupplierItemCategoryEntity.IsNew)
                    {
                        result = FCCMDSupplierItemCategory.GetFacadeCreate().Add(mDSupplierItemCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSupplierItemCategoryEntity.FLD_NAME_SupplierItemCategoryID, mDSupplierItemCategoryEntity.SupplierItemCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSupplierItemCategory.GetFacadeCreate().Update(mDSupplierItemCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SupplierItemCategoryID = 0;
                        _MDSupplierItemCategoryEntity = new MDSupplierItemCategoryEntity();
                        PrepareInitialView();
                        BindMDSupplierItemCategoryList();

                        if (mDSupplierItemCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Item Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Item Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSupplierItemCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Item Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Item Category Information.", false);
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

        protected void lvMDSupplierItemCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SupplierItemCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out SupplierItemCategoryID);

            if (SupplierItemCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SupplierItemCategoryID = SupplierItemCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSupplierItemCategoryEntity.FLD_NAME_SupplierItemCategoryID, SupplierItemCategoryID.ToString(), SQLMatchType.Equal);

                        MDSupplierItemCategoryEntity mDSupplierItemCategoryEntity = new MDSupplierItemCategoryEntity();


                        result = FCCMDSupplierItemCategory.GetFacadeCreate().Delete(mDSupplierItemCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SupplierItemCategoryID = 0;
                            _MDSupplierItemCategoryEntity = new MDSupplierItemCategoryEntity();
                            PrepareInitialView();
                            BindMDSupplierItemCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Item Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Item Category.", true);
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

        protected void odsMDSupplierItemCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSupplierItemCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SupplierItemCategoryID = 0;
            _MDSupplierItemCategoryEntity = new MDSupplierItemCategoryEntity();
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
