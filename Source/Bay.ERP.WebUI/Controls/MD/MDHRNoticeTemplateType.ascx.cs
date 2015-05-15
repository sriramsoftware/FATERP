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
    public partial class MDHRNoticeTemplateTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _NoticeTemplateTypeID
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

        public MDHRNoticeTemplateTypeEntity _MDHRNoticeTemplateTypeEntity
        {
            get
            {
                MDHRNoticeTemplateTypeEntity entity = new MDHRNoticeTemplateTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDHRNoticeTemplateTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDHRNoticeTemplateTypeEntity CurrentMDHRNoticeTemplateTypeEntity
        {
            get
            {
                if (_NoticeTemplateTypeID > 0)
                {
                    if (_MDHRNoticeTemplateTypeEntity.NoticeTemplateTypeID != _NoticeTemplateTypeID)
                    {
                        _MDHRNoticeTemplateTypeEntity = FCCMDHRNoticeTemplateType.GetFacadeCreate().GetByID(_NoticeTemplateTypeID);
                    }
                }

                return _MDHRNoticeTemplateTypeEntity;
            }
            set
            {
                _MDHRNoticeTemplateTypeEntity = value;
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
            MDHRNoticeTemplateTypeEntity mDHRNoticeTemplateTypeEntity = CurrentMDHRNoticeTemplateTypeEntity;


            if (!mDHRNoticeTemplateTypeEntity.IsNew)
            {
                txtName.Text = mDHRNoticeTemplateTypeEntity.Name.ToString();
                txtDescription.Text = mDHRNoticeTemplateTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDHRNoticeTemplateTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDHRNoticeTemplateTypeList();
        }

        private void BindMDHRNoticeTemplateTypeList()
        {
            lvMDHRNoticeTemplateType.DataBind();
        }

        private MDHRNoticeTemplateTypeEntity BuildMDHRNoticeTemplateTypeEntity()
        {
            MDHRNoticeTemplateTypeEntity mDHRNoticeTemplateTypeEntity = CurrentMDHRNoticeTemplateTypeEntity;

            mDHRNoticeTemplateTypeEntity.Name = txtName.Text.Trim();
            mDHRNoticeTemplateTypeEntity.Description = txtDescription.Text.Trim();
            mDHRNoticeTemplateTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDHRNoticeTemplateTypeEntity;
        }

        private void SaveMDHRNoticeTemplateTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDHRNoticeTemplateTypeEntity mDHRNoticeTemplateTypeEntity = BuildMDHRNoticeTemplateTypeEntity();

                    Int64 result = -1;

                    if (mDHRNoticeTemplateTypeEntity.IsNew)
                    {
                        result = FCCMDHRNoticeTemplateType.GetFacadeCreate().Add(mDHRNoticeTemplateTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDHRNoticeTemplateTypeEntity.FLD_NAME_NoticeTemplateTypeID, mDHRNoticeTemplateTypeEntity.NoticeTemplateTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDHRNoticeTemplateType.GetFacadeCreate().Update(mDHRNoticeTemplateTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _NoticeTemplateTypeID = 0;
                        _MDHRNoticeTemplateTypeEntity = new MDHRNoticeTemplateTypeEntity();
                        PrepareInitialView();
                        BindMDHRNoticeTemplateTypeList();

                        if (mDHRNoticeTemplateTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Notice Template Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Notice Template Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDHRNoticeTemplateTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Notice Template Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Notice Template Type Information.", false);
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

        protected void lvMDHRNoticeTemplateType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 NoticeTemplateTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out NoticeTemplateTypeID);

            if (NoticeTemplateTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _NoticeTemplateTypeID = NoticeTemplateTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDHRNoticeTemplateTypeEntity.FLD_NAME_NoticeTemplateTypeID, NoticeTemplateTypeID.ToString(), SQLMatchType.Equal);

                        MDHRNoticeTemplateTypeEntity mDHRNoticeTemplateTypeEntity = new MDHRNoticeTemplateTypeEntity();


                        result = FCCMDHRNoticeTemplateType.GetFacadeCreate().Delete(mDHRNoticeTemplateTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _NoticeTemplateTypeID = 0;
                            _MDHRNoticeTemplateTypeEntity = new MDHRNoticeTemplateTypeEntity();
                            PrepareInitialView();
                            BindMDHRNoticeTemplateTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Notice Template Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Notice Template Type.", true);
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

        protected void odsMDHRNoticeTemplateType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDHRNoticeTemplateTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _NoticeTemplateTypeID = 0;
            _MDHRNoticeTemplateTypeEntity = new MDHRNoticeTemplateTypeEntity();
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
