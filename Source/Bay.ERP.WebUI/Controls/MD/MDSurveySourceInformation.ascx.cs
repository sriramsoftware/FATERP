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
    public partial class MDSurveySourceInformationControl : BaseControl
    {       
        #region Properties

        public Int64 _SurveySourceInformationID
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

        public MDSurveySourceInformationEntity _MDSurveySourceInformationEntity
        {
            get
            {
                MDSurveySourceInformationEntity entity = new MDSurveySourceInformationEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDSurveySourceInformationEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDSurveySourceInformationEntity CurrentMDSurveySourceInformationEntity
        {
            get
            {
                if (_SurveySourceInformationID > 0)
                {
                    if (_MDSurveySourceInformationEntity.SurveySourceInformationID != _SurveySourceInformationID)
                    {
                        _MDSurveySourceInformationEntity = FCCMDSurveySourceInformation.GetFacadeCreate().GetByID(_SurveySourceInformationID);
                    }
                }

                return _MDSurveySourceInformationEntity;
            }
            set
            {
                _MDSurveySourceInformationEntity = value;
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
            MDSurveySourceInformationEntity mDSurveySourceInformationEntity = CurrentMDSurveySourceInformationEntity;


            if (!mDSurveySourceInformationEntity.IsNew)
            {
                txtName.Text = mDSurveySourceInformationEntity.Name.ToString();
                txtDescription.Text = mDSurveySourceInformationEntity.Description.ToString();
                chkIsRemoved.Checked = mDSurveySourceInformationEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDSurveySourceInformationList();
        }

        private void BindMDSurveySourceInformationList()
        {
            lvMDSurveySourceInformation.DataBind();
        }

        private MDSurveySourceInformationEntity BuildMDSurveySourceInformationEntity()
        {
            MDSurveySourceInformationEntity mDSurveySourceInformationEntity = CurrentMDSurveySourceInformationEntity;

            mDSurveySourceInformationEntity.Name = txtName.Text.Trim();
            mDSurveySourceInformationEntity.Description = txtDescription.Text.Trim();
            mDSurveySourceInformationEntity.IsRemoved = chkIsRemoved.Checked;


            return mDSurveySourceInformationEntity;
        }

        private void SaveMDSurveySourceInformationEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDSurveySourceInformationEntity mDSurveySourceInformationEntity = BuildMDSurveySourceInformationEntity();

                    Int64 result = -1;

                    if (mDSurveySourceInformationEntity.IsNew)
                    {
                        result = FCCMDSurveySourceInformation.GetFacadeCreate().Add(mDSurveySourceInformationEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDSurveySourceInformationEntity.FLD_NAME_SurveySourceInformationID, mDSurveySourceInformationEntity.SurveySourceInformationID.ToString(), SQLMatchType.Equal);
                        result = FCCMDSurveySourceInformation.GetFacadeCreate().Update(mDSurveySourceInformationEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _SurveySourceInformationID = 0;
                        _MDSurveySourceInformationEntity = new MDSurveySourceInformationEntity();
                        PrepareInitialView();
                        BindMDSurveySourceInformationList();

                        if (mDSurveySourceInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Source Information Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Survey Source Information Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDSurveySourceInformationEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Survey Source Information Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Survey Source Information Information.", false);
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

        protected void lvMDSurveySourceInformation_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 SurveySourceInformationID;

            Int64.TryParse(e.CommandArgument.ToString(), out SurveySourceInformationID);

            if (SurveySourceInformationID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _SurveySourceInformationID = SurveySourceInformationID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSurveySourceInformationEntity.FLD_NAME_SurveySourceInformationID, SurveySourceInformationID.ToString(), SQLMatchType.Equal);

                        MDSurveySourceInformationEntity mDSurveySourceInformationEntity = new MDSurveySourceInformationEntity();


                        result = FCCMDSurveySourceInformation.GetFacadeCreate().Delete(mDSurveySourceInformationEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _SurveySourceInformationID = 0;
                            _MDSurveySourceInformationEntity = new MDSurveySourceInformationEntity();
                            PrepareInitialView();
                            BindMDSurveySourceInformationList();

                            MiscUtil.ShowMessage(lblMessage, "Survey Source Information has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Survey Source Information.", true);
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

        protected void odsMDSurveySourceInformation_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDSurveySourceInformationEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _SurveySourceInformationID = 0;
            _MDSurveySourceInformationEntity = new MDSurveySourceInformationEntity();
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
