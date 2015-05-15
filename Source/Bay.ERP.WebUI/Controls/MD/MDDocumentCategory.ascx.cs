// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDDocumentCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _DocumentCategoryID
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

        public MDDocumentCategoryEntity _MDDocumentCategoryEntity
        {
            get
            {
                MDDocumentCategoryEntity entity = new MDDocumentCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDDocumentCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDDocumentCategoryEntity CurrentMDDocumentCategoryEntity
        {
            get
            {
                if (_DocumentCategoryID > 0)
                {
                    if (_MDDocumentCategoryEntity.DocumentCategoryID != _DocumentCategoryID)
                    {
                        _MDDocumentCategoryEntity = FCCMDDocumentCategory.GetFacadeCreate().GetByID(_DocumentCategoryID);
                    }
                }

                return _MDDocumentCategoryEntity;
            }
            set
            {
                _MDDocumentCategoryEntity = value;
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
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDDocumentCategoryEntity mDDocumentCategoryEntity = CurrentMDDocumentCategoryEntity;


            if (!mDDocumentCategoryEntity.IsNew)
            {
                txtName.Text = mDDocumentCategoryEntity.Name.ToString();
                txtRemarks.Text = mDDocumentCategoryEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDDocumentCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDDocumentCategoryList();
        }

        private void BindMDDocumentCategoryList()
        {
            lvMDDocumentCategory.DataBind();
        }

        private MDDocumentCategoryEntity BuildMDDocumentCategoryEntity()
        {
            MDDocumentCategoryEntity mDDocumentCategoryEntity = CurrentMDDocumentCategoryEntity;

            mDDocumentCategoryEntity.Name = txtName.Text.Trim();
            mDDocumentCategoryEntity.Remarks = txtRemarks.Text.Trim();
            mDDocumentCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDDocumentCategoryEntity;
        }

        private void SaveMDDocumentCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDDocumentCategoryEntity mDDocumentCategoryEntity = BuildMDDocumentCategoryEntity();

                    Int64 result = -1;

                    if (mDDocumentCategoryEntity.IsNew)
                    {
                        result = FCCMDDocumentCategory.GetFacadeCreate().Add(mDDocumentCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDDocumentCategoryEntity.FLD_NAME_DocumentCategoryID, mDDocumentCategoryEntity.DocumentCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDDocumentCategory.GetFacadeCreate().Update(mDDocumentCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DocumentCategoryID = 0;
                        _MDDocumentCategoryEntity = new MDDocumentCategoryEntity();
                        PrepareInitialView();
                        BindMDDocumentCategoryList();

                        if (mDDocumentCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Document Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Document Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDDocumentCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Document Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Document Category Information.", false);
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

        protected void lvMDDocumentCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DocumentCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out DocumentCategoryID);

            if (DocumentCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DocumentCategoryID = DocumentCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDocumentCategoryEntity.FLD_NAME_DocumentCategoryID, DocumentCategoryID.ToString(), SQLMatchType.Equal);

                        MDDocumentCategoryEntity mDDocumentCategoryEntity = new MDDocumentCategoryEntity();


                        result = FCCMDDocumentCategory.GetFacadeCreate().Delete(mDDocumentCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DocumentCategoryID = 0;
                            _MDDocumentCategoryEntity = new MDDocumentCategoryEntity();
                            PrepareInitialView();
                            BindMDDocumentCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Document Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Document Category.", true);
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

        protected void odsMDDocumentCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDDocumentCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DocumentCategoryID = 0;
            _MDDocumentCategoryEntity = new MDDocumentCategoryEntity();
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
