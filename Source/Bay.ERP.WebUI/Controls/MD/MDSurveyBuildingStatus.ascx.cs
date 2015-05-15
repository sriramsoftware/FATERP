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
    public partial class MDSurveyBuildingStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _SurveyBuildingStatusID
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

        public MDSurveyBuildingStatusEntity _MDSurveyBuildingStatusEntity
        {
            get
            {
                MDSurveyBuildingStatusEntity entity = new MDSurveyBuildingStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSurveyBuildingStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSurveyBuildingStatusEntity CurrentMDSurveyBuildingStatusEntity
        {
            get
            {
                if (_SurveyBuildingStatusID > 0)
                {
                    if (_MDSurveyBuildingStatusEntity.SurveyBuildingStatusID != _SurveyBuildingStatusID)
                    {
                        _MDSurveyBuildingStatusEntity = FCCMDSurveyBuildingStatus.GetFacadeCreate().GetByID(_SurveyBuildingStatusID);
                    }
                }

                return _MDSurveyBuildingStatusEntity;
            }
            set
            {
                _MDSurveyBuildingStatusEntity = value;
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
            MDSurveyBuildingStatusEntity mDSurveyBuildingStatusEntity = CurrentMDSurveyBuildingStatusEntity;


            if (!mDSurveyBuildingStatusEntity.IsNew)
            {
                txtName.Text = mDSurveyBuildingStatusEntity.Name.ToString();
                txtDescription.Text = mDSurveyBuildingStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDSurveyBuildingStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSurveyBuildingStatusList();
        }

        private void BindMDSurveyBuildingStatusList()
        {
            lvMDSurveyBuildingStatus.DataBind();
        }

        private MDSurveyBuildingStatusEntity BuildMDSurveyBuildingStatusEntity()
        {
            MDSurveyBuildingStatusEntity mDSurveyBuildingStatusEntity = CurrentMDSurveyBuildingStatusEntity;

            mDSurveyBuildingStatusEntity.Name = txtName.Text.Trim();
            mDSurveyBuildingStatusEntity.Description = txtDescription.Text.Trim();
            mDSurveyBuildingStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSurveyBuildingStatusEntity;
        }

        private void SaveMDSurveyBuildingStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSurveyBuildingStatusEntity mDSurveyBuildingStatusEntity = BuildMDSurveyBuildingStatusEntity();

                    Int64 result = -1;

                    if (mDSurveyBuildingStatusEntity.IsNew)
                    {
                        result = FCCMDSurveyBuildingStatus.GetFacadeCreate().Add(mDSurveyBuildingStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSurveyBuildingStatusEntity.FLD_NAME_SurveyBuildingStatusID, mDSurveyBuildingStatusEntity.SurveyBuildingStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSurveyBuildingStatus.GetFacadeCreate().Update(mDSurveyBuildingStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SurveyBuildingStatusID = 0;
                        _MDSurveyBuildingStatusEntity = new MDSurveyBuildingStatusEntity();
                        PrepareInitialView();
                        BindMDSurveyBuildingStatusList();

                        if (mDSurveyBuildingStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Building Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Building Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSurveyBuildingStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Survey Building Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Survey Building Status Information.", false);
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

        protected void lvMDSurveyBuildingStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SurveyBuildingStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out SurveyBuildingStatusID);

            if (SurveyBuildingStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SurveyBuildingStatusID = SurveyBuildingStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSurveyBuildingStatusEntity.FLD_NAME_SurveyBuildingStatusID, SurveyBuildingStatusID.ToString(), SQLMatchType.Equal);

                        MDSurveyBuildingStatusEntity mDSurveyBuildingStatusEntity = new MDSurveyBuildingStatusEntity();


                        result = FCCMDSurveyBuildingStatus.GetFacadeCreate().Delete(mDSurveyBuildingStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SurveyBuildingStatusID = 0;
                            _MDSurveyBuildingStatusEntity = new MDSurveyBuildingStatusEntity();
                            PrepareInitialView();
                            BindMDSurveyBuildingStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Survey Building Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Survey Building Status.", true);
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

        protected void odsMDSurveyBuildingStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSurveyBuildingStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SurveyBuildingStatusID = 0;
            _MDSurveyBuildingStatusEntity = new MDSurveyBuildingStatusEntity();
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
