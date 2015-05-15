// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




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
    public partial class MDReferenceLibraryCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _ReferenceLibraryCategoryID
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

        public MDReferenceLibraryCategoryEntity _MDReferenceLibraryCategoryEntity
        {
            get
            {
                MDReferenceLibraryCategoryEntity entity = new MDReferenceLibraryCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDReferenceLibraryCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDReferenceLibraryCategoryEntity CurrentMDReferenceLibraryCategoryEntity
        {
            get
            {
                if (_ReferenceLibraryCategoryID > 0)
                {
                    if (_MDReferenceLibraryCategoryEntity.ReferenceLibraryCategoryID != _ReferenceLibraryCategoryID)
                    {
                        _MDReferenceLibraryCategoryEntity = FCCMDReferenceLibraryCategory.GetFacadeCreate().GetByID(_ReferenceLibraryCategoryID);
                    }
                }

                return _MDReferenceLibraryCategoryEntity;
            }
            set
            {
                _MDReferenceLibraryCategoryEntity = value;
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
            MDReferenceLibraryCategoryEntity mDReferenceLibraryCategoryEntity = CurrentMDReferenceLibraryCategoryEntity;


            if (!mDReferenceLibraryCategoryEntity.IsNew)
            {
                txtName.Text = mDReferenceLibraryCategoryEntity.Name.ToString();
                txtDescription.Text = mDReferenceLibraryCategoryEntity.Description.ToString();
                chkIsRemoved.Checked = mDReferenceLibraryCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDReferenceLibraryCategoryList();
        }

        private void BindMDReferenceLibraryCategoryList()
        {
            lvMDReferenceLibraryCategory.DataBind();
        }

        private MDReferenceLibraryCategoryEntity BuildMDReferenceLibraryCategoryEntity()
        {
            MDReferenceLibraryCategoryEntity mDReferenceLibraryCategoryEntity = CurrentMDReferenceLibraryCategoryEntity;

            mDReferenceLibraryCategoryEntity.Name = txtName.Text.Trim();
            mDReferenceLibraryCategoryEntity.Description = txtDescription.Text.Trim();
            mDReferenceLibraryCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDReferenceLibraryCategoryEntity;
        }

        private void SaveMDReferenceLibraryCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDReferenceLibraryCategoryEntity mDReferenceLibraryCategoryEntity = BuildMDReferenceLibraryCategoryEntity();

                    Int64 result = -1;

                    if (mDReferenceLibraryCategoryEntity.IsNew)
                    {
                        result = FCCMDReferenceLibraryCategory.GetFacadeCreate().Add(mDReferenceLibraryCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDReferenceLibraryCategoryEntity.FLD_NAME_ReferenceLibraryCategoryID, mDReferenceLibraryCategoryEntity.ReferenceLibraryCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDReferenceLibraryCategory.GetFacadeCreate().Update(mDReferenceLibraryCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ReferenceLibraryCategoryID = 0;
                        _MDReferenceLibraryCategoryEntity = new MDReferenceLibraryCategoryEntity();
                        PrepareInitialView();
                        BindMDReferenceLibraryCategoryList();

                        if (mDReferenceLibraryCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Reference Library Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Reference Library Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDReferenceLibraryCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Reference Library Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Reference Library Category Information.", false);
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

        protected void lvMDReferenceLibraryCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ReferenceLibraryCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out ReferenceLibraryCategoryID);

            if (ReferenceLibraryCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ReferenceLibraryCategoryID = ReferenceLibraryCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDReferenceLibraryCategoryEntity.FLD_NAME_ReferenceLibraryCategoryID, ReferenceLibraryCategoryID.ToString(), SQLMatchType.Equal);

                        MDReferenceLibraryCategoryEntity mDReferenceLibraryCategoryEntity = new MDReferenceLibraryCategoryEntity();


                        result = FCCMDReferenceLibraryCategory.GetFacadeCreate().Delete(mDReferenceLibraryCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ReferenceLibraryCategoryID = 0;
                            _MDReferenceLibraryCategoryEntity = new MDReferenceLibraryCategoryEntity();
                            PrepareInitialView();
                            BindMDReferenceLibraryCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Reference Library Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Reference Library Category.", true);
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

        protected void odsMDReferenceLibraryCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDReferenceLibraryCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ReferenceLibraryCategoryID = 0;
            _MDReferenceLibraryCategoryEntity = new MDReferenceLibraryCategoryEntity();
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
