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
    public partial class MDMemberTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _MemberTypeID
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

        public MDMemberTypeEntity _MDMemberTypeEntity
        {
            get
            {
                MDMemberTypeEntity entity = new MDMemberTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDMemberTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDMemberTypeEntity CurrentMDMemberTypeEntity
        {
            get
            {
                if (_MemberTypeID > 0)
                {
                    if (_MDMemberTypeEntity.MemberTypeID != _MemberTypeID)
                    {
                        _MDMemberTypeEntity = FCCMDMemberType.GetFacadeCreate().GetByID(_MemberTypeID);
                    }
                }

                return _MDMemberTypeEntity;
            }
            set
            {
                _MDMemberTypeEntity = value;
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
            MDMemberTypeEntity mDMemberTypeEntity = CurrentMDMemberTypeEntity;


            if (!mDMemberTypeEntity.IsNew)
            {
                txtName.Text = mDMemberTypeEntity.Name.ToString();
                txtDescription.Text = mDMemberTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDMemberTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDMemberTypeList();
        }

        private void BindMDMemberTypeList()
        {
            lvMDMemberType.DataBind();
        }

        private MDMemberTypeEntity BuildMDMemberTypeEntity()
        {
            MDMemberTypeEntity mDMemberTypeEntity = CurrentMDMemberTypeEntity;

            mDMemberTypeEntity.Name = txtName.Text.Trim();
            mDMemberTypeEntity.Description = txtDescription.Text.Trim();
            mDMemberTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDMemberTypeEntity;
        }

        private void SaveMDMemberTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDMemberTypeEntity mDMemberTypeEntity = BuildMDMemberTypeEntity();

                    Int64 result = -1;

                    if (mDMemberTypeEntity.IsNew)
                    {
                        result = FCCMDMemberType.GetFacadeCreate().Add(mDMemberTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDMemberTypeEntity.FLD_NAME_MemberTypeID, mDMemberTypeEntity.MemberTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDMemberType.GetFacadeCreate().Update(mDMemberTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MemberTypeID = 0;
                        _MDMemberTypeEntity = new MDMemberTypeEntity();
                        PrepareInitialView();
                        BindMDMemberTypeList();

                        if (mDMemberTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Member Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Member Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDMemberTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Member Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Member Type Information.", false);
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

        protected void lvMDMemberType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MemberTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out MemberTypeID);

            if (MemberTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MemberTypeID = MemberTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDMemberTypeEntity.FLD_NAME_MemberTypeID, MemberTypeID.ToString(), SQLMatchType.Equal);

                        MDMemberTypeEntity mDMemberTypeEntity = new MDMemberTypeEntity();


                        result = FCCMDMemberType.GetFacadeCreate().Delete(mDMemberTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MemberTypeID = 0;
                            _MDMemberTypeEntity = new MDMemberTypeEntity();
                            PrepareInitialView();
                            BindMDMemberTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Member Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Member Type.", true);
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

        protected void odsMDMemberType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDMemberTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MemberTypeID = 0;
            _MDMemberTypeEntity = new MDMemberTypeEntity();
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
