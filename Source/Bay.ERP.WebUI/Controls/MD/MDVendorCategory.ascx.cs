// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Dec-2012, 08:03:28




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
    public partial class MDVendorCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _VendorCategoryID
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

        public MDVendorCategoryEntity _MDVendorCategoryEntity
        {
            get
            {
                MDVendorCategoryEntity entity = new MDVendorCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDVendorCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDVendorCategoryEntity CurrentMDVendorCategoryEntity
        {
            get
            {
                if (_VendorCategoryID > 0)
                {
                    if (_MDVendorCategoryEntity.VendorCategoryID != _VendorCategoryID)
                    {
                        _MDVendorCategoryEntity = FCCMDVendorCategory.GetFacadeCreate().GetByID(_VendorCategoryID);
                    }
                }

                return _MDVendorCategoryEntity;
            }
            set
            {
                _MDVendorCategoryEntity = value;
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
            MDVendorCategoryEntity mDVendorCategoryEntity = CurrentMDVendorCategoryEntity;


            if (!mDVendorCategoryEntity.IsNew)
            {
                txtName.Text = mDVendorCategoryEntity.Name.ToString();
                txtDescription.Text = mDVendorCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDVendorCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDVendorCategoryList();
        }

        private void BindMDVendorCategoryList()
        {
            lvMDVendorCategory.DataBind();
        }

        private MDVendorCategoryEntity BuildMDVendorCategoryEntity()
        {
            MDVendorCategoryEntity mDVendorCategoryEntity = CurrentMDVendorCategoryEntity;

            mDVendorCategoryEntity.Name = txtName.Text.Trim();
            mDVendorCategoryEntity.Description = txtDescription.Text.Trim();
            mDVendorCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDVendorCategoryEntity;
        }

        private void SaveMDVendorCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDVendorCategoryEntity mDVendorCategoryEntity = BuildMDVendorCategoryEntity();

                    Int64 result = -1;

                    if (mDVendorCategoryEntity.IsNew)
                    {
                        result = FCCMDVendorCategory.GetFacadeCreate().Add(mDVendorCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDVendorCategoryEntity.FLD_NAME_VendorCategoryID, mDVendorCategoryEntity.VendorCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDVendorCategory.GetFacadeCreate().Update(mDVendorCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _VendorCategoryID = 0;
                        _MDVendorCategoryEntity = new MDVendorCategoryEntity();
                        PrepareInitialView();
                        BindMDVendorCategoryList();

                        if (mDVendorCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Vendor Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDVendorCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Vendor Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Vendor Category Information.", false);
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

        protected void lvMDVendorCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 VendorCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out VendorCategoryID);

            if (VendorCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _VendorCategoryID = VendorCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDVendorCategoryEntity.FLD_NAME_VendorCategoryID, VendorCategoryID.ToString(), SQLMatchType.Equal);

                        MDVendorCategoryEntity mDVendorCategoryEntity = new MDVendorCategoryEntity();


                        result = FCCMDVendorCategory.GetFacadeCreate().Delete(mDVendorCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _VendorCategoryID = 0;
                            _MDVendorCategoryEntity = new MDVendorCategoryEntity();
                            PrepareInitialView();
                            BindMDVendorCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Vendor Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Vendor Category.", true);
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

        protected void odsMDVendorCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDVendorCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _VendorCategoryID = 0;
            _MDVendorCategoryEntity = new MDVendorCategoryEntity();
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
