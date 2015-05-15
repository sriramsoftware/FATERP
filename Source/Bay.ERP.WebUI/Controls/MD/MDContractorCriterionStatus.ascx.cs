// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class MDContractorCriterionStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ContractorCriterionStatusID
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

        public MDContractorCriterionStatusEntity _MDContractorCriterionStatusEntity
        {
            get
            {
                MDContractorCriterionStatusEntity entity = new MDContractorCriterionStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDContractorCriterionStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDContractorCriterionStatusEntity CurrentMDContractorCriterionStatusEntity
        {
            get
            {
                if (_ContractorCriterionStatusID > 0)
                {
                    if (_MDContractorCriterionStatusEntity.ContractorCriterionStatusID != _ContractorCriterionStatusID)
                    {
                        _MDContractorCriterionStatusEntity = FCCMDContractorCriterionStatus.GetFacadeCreate().GetByID(_ContractorCriterionStatusID);
                    }
                }

                return _MDContractorCriterionStatusEntity;
            }
            set
            {
                _MDContractorCriterionStatusEntity = value;
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
            MDContractorCriterionStatusEntity mDContractorCriterionStatusEntity = CurrentMDContractorCriterionStatusEntity;


            if (!mDContractorCriterionStatusEntity.IsNew)
            {
                txtName.Text = mDContractorCriterionStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDContractorCriterionStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDContractorCriterionStatusList();
        }

        private void BindMDContractorCriterionStatusList()
        {
            lvMDContractorCriterionStatus.DataBind();
        }

        private MDContractorCriterionStatusEntity BuildMDContractorCriterionStatusEntity()
        {
            MDContractorCriterionStatusEntity mDContractorCriterionStatusEntity = CurrentMDContractorCriterionStatusEntity;

            mDContractorCriterionStatusEntity.Name = txtName.Text.Trim();
            mDContractorCriterionStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDContractorCriterionStatusEntity;
        }

        private void SaveMDContractorCriterionStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDContractorCriterionStatusEntity mDContractorCriterionStatusEntity = BuildMDContractorCriterionStatusEntity();

                    Int64 result = -1;

                    if (mDContractorCriterionStatusEntity.IsNew)
                    {
                        result = FCCMDContractorCriterionStatus.GetFacadeCreate().Add(mDContractorCriterionStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDContractorCriterionStatusEntity.FLD_NAME_ContractorCriterionStatusID, mDContractorCriterionStatusEntity.ContractorCriterionStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDContractorCriterionStatus.GetFacadeCreate().Update(mDContractorCriterionStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ContractorCriterionStatusID = 0;
                        _MDContractorCriterionStatusEntity = new MDContractorCriterionStatusEntity();
                        PrepareInitialView();
                        BindMDContractorCriterionStatusList();

                        if (mDContractorCriterionStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Criterion Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Criterion Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDContractorCriterionStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Contractor Criterion Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Contractor Criterion Status Information.", false);
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

        protected void lvMDContractorCriterionStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ContractorCriterionStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ContractorCriterionStatusID);

            if (ContractorCriterionStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ContractorCriterionStatusID = ContractorCriterionStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDContractorCriterionStatusEntity.FLD_NAME_ContractorCriterionStatusID, ContractorCriterionStatusID.ToString(), SQLMatchType.Equal);

                        MDContractorCriterionStatusEntity mDContractorCriterionStatusEntity = new MDContractorCriterionStatusEntity();


                        result = FCCMDContractorCriterionStatus.GetFacadeCreate().Delete(mDContractorCriterionStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ContractorCriterionStatusID = 0;
                            _MDContractorCriterionStatusEntity = new MDContractorCriterionStatusEntity();
                            PrepareInitialView();
                            BindMDContractorCriterionStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Contractor Criterion Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Contractor Criterion Status.", true);
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

        protected void odsMDContractorCriterionStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDContractorCriterionStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ContractorCriterionStatusID = 0;
            _MDContractorCriterionStatusEntity = new MDContractorCriterionStatusEntity();
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
