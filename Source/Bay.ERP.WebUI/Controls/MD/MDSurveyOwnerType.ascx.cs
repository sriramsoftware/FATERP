// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




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
    public partial class MDSurveyOwnerTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _SurveyOwnerTypeID
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

        public MDSurveyOwnerTypeEntity _MDSurveyOwnerTypeEntity
        {
            get
            {
                MDSurveyOwnerTypeEntity entity = new MDSurveyOwnerTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSurveyOwnerTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSurveyOwnerTypeEntity CurrentMDSurveyOwnerTypeEntity
        {
            get
            {
                if (_SurveyOwnerTypeID > 0)
                {
                    if (_MDSurveyOwnerTypeEntity.SurveyOwnerTypeID != _SurveyOwnerTypeID)
                    {
                        _MDSurveyOwnerTypeEntity = FCCMDSurveyOwnerType.GetFacadeCreate().GetByID(_SurveyOwnerTypeID);
                    }
                }

                return _MDSurveyOwnerTypeEntity;
            }
            set
            {
                _MDSurveyOwnerTypeEntity = value;
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
            MDSurveyOwnerTypeEntity mDSurveyOwnerTypeEntity = CurrentMDSurveyOwnerTypeEntity;


            if (!mDSurveyOwnerTypeEntity.IsNew)
            {
                txtName.Text = mDSurveyOwnerTypeEntity.Name.ToString();
                txtDescription.Text = mDSurveyOwnerTypeEntity.Description.ToString();
                chkIsRemoved.Checked = mDSurveyOwnerTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSurveyOwnerTypeList();
        }

        private void BindMDSurveyOwnerTypeList()
        {
            lvMDSurveyOwnerType.DataBind();
        }

        private MDSurveyOwnerTypeEntity BuildMDSurveyOwnerTypeEntity()
        {
            MDSurveyOwnerTypeEntity mDSurveyOwnerTypeEntity = CurrentMDSurveyOwnerTypeEntity;

            mDSurveyOwnerTypeEntity.Name = txtName.Text.Trim();
            mDSurveyOwnerTypeEntity.Description = txtDescription.Text.Trim();
            mDSurveyOwnerTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSurveyOwnerTypeEntity;
        }

        private void SaveMDSurveyOwnerTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSurveyOwnerTypeEntity mDSurveyOwnerTypeEntity = BuildMDSurveyOwnerTypeEntity();

                    Int64 result = -1;

                    if (mDSurveyOwnerTypeEntity.IsNew)
                    {
                        result = FCCMDSurveyOwnerType.GetFacadeCreate().Add(mDSurveyOwnerTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSurveyOwnerTypeEntity.FLD_NAME_SurveyOwnerTypeID, mDSurveyOwnerTypeEntity.SurveyOwnerTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSurveyOwnerType.GetFacadeCreate().Update(mDSurveyOwnerTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SurveyOwnerTypeID = 0;
                        _MDSurveyOwnerTypeEntity = new MDSurveyOwnerTypeEntity();
                        PrepareInitialView();
                        BindMDSurveyOwnerTypeList();

                        if (mDSurveyOwnerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Owner Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Owner Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSurveyOwnerTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Survey Owner Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Survey Owner Type Information.", false);
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

        protected void lvMDSurveyOwnerType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SurveyOwnerTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out SurveyOwnerTypeID);

            if (SurveyOwnerTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SurveyOwnerTypeID = SurveyOwnerTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSurveyOwnerTypeEntity.FLD_NAME_SurveyOwnerTypeID, SurveyOwnerTypeID.ToString(), SQLMatchType.Equal);

                        MDSurveyOwnerTypeEntity mDSurveyOwnerTypeEntity = new MDSurveyOwnerTypeEntity();


                        result = FCCMDSurveyOwnerType.GetFacadeCreate().Delete(mDSurveyOwnerTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SurveyOwnerTypeID = 0;
                            _MDSurveyOwnerTypeEntity = new MDSurveyOwnerTypeEntity();
                            PrepareInitialView();
                            BindMDSurveyOwnerTypeList();

                            MiscUtil.ShowMessage(lblMessage, "Survey Owner Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Survey Owner Type.", true);
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

        protected void odsMDSurveyOwnerType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSurveyOwnerTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SurveyOwnerTypeID = 0;
            _MDSurveyOwnerTypeEntity = new MDSurveyOwnerTypeEntity();
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
