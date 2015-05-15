// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 11:12:01




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
    public partial class MDMaterialReceiveApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _MaterialReceiveApprovalStatusID
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

        public MDMaterialReceiveApprovalStatusEntity _MDMaterialReceiveApprovalStatusEntity
        {
            get
            {
                MDMaterialReceiveApprovalStatusEntity entity = new MDMaterialReceiveApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDMaterialReceiveApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDMaterialReceiveApprovalStatusEntity CurrentMDMaterialReceiveApprovalStatusEntity
        {
            get
            {
                if (_MaterialReceiveApprovalStatusID > 0)
                {
                    if (_MDMaterialReceiveApprovalStatusEntity.MaterialReceiveApprovalStatusID != _MaterialReceiveApprovalStatusID)
                    {
                        _MDMaterialReceiveApprovalStatusEntity = FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().GetByID(_MaterialReceiveApprovalStatusID);
                    }
                }

                return _MDMaterialReceiveApprovalStatusEntity;
            }
            set
            {
                _MDMaterialReceiveApprovalStatusEntity = value;
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
            MDMaterialReceiveApprovalStatusEntity mDMaterialReceiveApprovalStatusEntity = CurrentMDMaterialReceiveApprovalStatusEntity;


            if (!mDMaterialReceiveApprovalStatusEntity.IsNew)
            {
                txtName.Text = mDMaterialReceiveApprovalStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDMaterialReceiveApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDMaterialReceiveApprovalStatusList();
        }

        private void BindMDMaterialReceiveApprovalStatusList()
        {
            lvMDMaterialReceiveApprovalStatus.DataBind();
        }

        private MDMaterialReceiveApprovalStatusEntity BuildMDMaterialReceiveApprovalStatusEntity()
        {
            MDMaterialReceiveApprovalStatusEntity mDMaterialReceiveApprovalStatusEntity = CurrentMDMaterialReceiveApprovalStatusEntity;

            mDMaterialReceiveApprovalStatusEntity.Name = txtName.Text.Trim();
            mDMaterialReceiveApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDMaterialReceiveApprovalStatusEntity;
        }

        private void SaveMDMaterialReceiveApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDMaterialReceiveApprovalStatusEntity mDMaterialReceiveApprovalStatusEntity = BuildMDMaterialReceiveApprovalStatusEntity();

                    Int64 result = -1;

                    if (mDMaterialReceiveApprovalStatusEntity.IsNew)
                    {
                        result = FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().Add(mDMaterialReceiveApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDMaterialReceiveApprovalStatusEntity.FLD_NAME_MaterialReceiveApprovalStatusID, mDMaterialReceiveApprovalStatusEntity.MaterialReceiveApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().Update(mDMaterialReceiveApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MaterialReceiveApprovalStatusID = 0;
                        _MDMaterialReceiveApprovalStatusEntity = new MDMaterialReceiveApprovalStatusEntity();
                        PrepareInitialView();
                        BindMDMaterialReceiveApprovalStatusList();

                        if (mDMaterialReceiveApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Material Receive Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Material Receive Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDMaterialReceiveApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Material Receive Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Material Receive Approval Status Information.", false);
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

        protected void lvMDMaterialReceiveApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MaterialReceiveApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out MaterialReceiveApprovalStatusID);

            if (MaterialReceiveApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MaterialReceiveApprovalStatusID = MaterialReceiveApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDMaterialReceiveApprovalStatusEntity.FLD_NAME_MaterialReceiveApprovalStatusID, MaterialReceiveApprovalStatusID.ToString(), SQLMatchType.Equal);

                        MDMaterialReceiveApprovalStatusEntity mDMaterialReceiveApprovalStatusEntity = new MDMaterialReceiveApprovalStatusEntity();


                        result = FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().Delete(mDMaterialReceiveApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MaterialReceiveApprovalStatusID = 0;
                            _MDMaterialReceiveApprovalStatusEntity = new MDMaterialReceiveApprovalStatusEntity();
                            PrepareInitialView();
                            BindMDMaterialReceiveApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Material Receive Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Material Receive Approval Status.", true);
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

        protected void odsMDMaterialReceiveApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDMaterialReceiveApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MaterialReceiveApprovalStatusID = 0;
            _MDMaterialReceiveApprovalStatusEntity = new MDMaterialReceiveApprovalStatusEntity();
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
