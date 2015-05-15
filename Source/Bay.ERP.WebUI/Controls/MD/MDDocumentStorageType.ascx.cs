// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 12:46:09




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
    public partial class MDDocumentStorageTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _DocumentStorageTypeID
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

        public MDDocumentStorageTypeEntity _MDDocumentStorageTypeEntity
        {
            get
            {
                MDDocumentStorageTypeEntity entity = new MDDocumentStorageTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDDocumentStorageTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDDocumentStorageTypeEntity CurrentMDDocumentStorageTypeEntity
        {
            get
            {
                if (_DocumentStorageTypeID > 0)
                {
                    if (_MDDocumentStorageTypeEntity.DocumentStorageTypeID != _DocumentStorageTypeID)
                    {
                        _MDDocumentStorageTypeEntity = FCCMDDocumentStorageType.GetFacadeCreate().GetByID(_DocumentStorageTypeID);
                    }
                }

                return _MDDocumentStorageTypeEntity;
            }
            set
            {
                _MDDocumentStorageTypeEntity = value;
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
            MDDocumentStorageTypeEntity mDDocumentStorageTypeEntity = CurrentMDDocumentStorageTypeEntity;


            if (!mDDocumentStorageTypeEntity.IsNew)
            {
                txtName.Text = mDDocumentStorageTypeEntity.Name.ToString();
                chkIsRemoved.Checked = mDDocumentStorageTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDDocumentStorageTypeList();
        }

        private void BindMDDocumentStorageTypeList()
        {
            lvMDDocumentStorageType.DataBind();
        }

        private MDDocumentStorageTypeEntity BuildMDDocumentStorageTypeEntity()
        {
            MDDocumentStorageTypeEntity mDDocumentStorageTypeEntity = CurrentMDDocumentStorageTypeEntity;

            mDDocumentStorageTypeEntity.Name = txtName.Text.Trim();
            mDDocumentStorageTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDDocumentStorageTypeEntity;
        }

        private void SaveMDDocumentStorageTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDDocumentStorageTypeEntity mDDocumentStorageTypeEntity = BuildMDDocumentStorageTypeEntity();

                    Int64 result = -1;

                    if (mDDocumentStorageTypeEntity.IsNew)
                    {
                        result = FCCMDDocumentStorageType.GetFacadeCreate().Add(mDDocumentStorageTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDDocumentStorageTypeEntity.FLD_NAME_DocumentStorageTypeID, mDDocumentStorageTypeEntity.DocumentStorageTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDDocumentStorageType.GetFacadeCreate().Update(mDDocumentStorageTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DocumentStorageTypeID = 0;
                        _MDDocumentStorageTypeEntity = new MDDocumentStorageTypeEntity();
                        PrepareInitialView();
                        BindMDDocumentStorageTypeList();

                        if (mDDocumentStorageTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Document Storage Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Document Storage Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDDocumentStorageTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Document Storage Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Document Storage Type Information.", false);
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

        protected void lvMDDocumentStorageType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DocumentStorageTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out DocumentStorageTypeID);

            if (DocumentStorageTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DocumentStorageTypeID = DocumentStorageTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDocumentStorageTypeEntity.FLD_NAME_DocumentStorageTypeID, DocumentStorageTypeID.ToString(), SQLMatchType.Equal);

                        MDDocumentStorageTypeEntity mDDocumentStorageTypeEntity = new MDDocumentStorageTypeEntity();


                        result = FCCMDDocumentStorageType.GetFacadeCreate().Delete(mDDocumentStorageTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DocumentStorageTypeID = 0;
                            _MDDocumentStorageTypeEntity = new MDDocumentStorageTypeEntity();
                            PrepareInitialView();
                            BindMDDocumentStorageTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Document Storage Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Document Storage Type.", true);
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

        protected void odsMDDocumentStorageType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDDocumentStorageTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DocumentStorageTypeID = 0;
            _MDDocumentStorageTypeEntity = new MDDocumentStorageTypeEntity();
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
