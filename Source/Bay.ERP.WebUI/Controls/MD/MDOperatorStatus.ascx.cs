// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:41:19




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
    public partial class MDOperatorStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _OperatorStatusID
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

        public MDOperatorStatusEntity _MDOperatorStatusEntity
        {
            get
            {
                MDOperatorStatusEntity entity = new MDOperatorStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDOperatorStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDOperatorStatusEntity CurrentMDOperatorStatusEntity
        {
            get
            {
                if (_OperatorStatusID > 0)
                {
                    if (_MDOperatorStatusEntity.OperatorStatusID != _OperatorStatusID)
                    {
                        _MDOperatorStatusEntity = FCCMDOperatorStatus.GetFacadeCreate().GetByID(_OperatorStatusID);
                    }
                }

                return _MDOperatorStatusEntity;
            }
            set
            {
                _MDOperatorStatusEntity = value;
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
            txtDescripton.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDOperatorStatusEntity mDOperatorStatusEntity = CurrentMDOperatorStatusEntity;


            if (!mDOperatorStatusEntity.IsNew)
            {
                txtName.Text = mDOperatorStatusEntity.Name.ToString();
                txtDescripton.Text = mDOperatorStatusEntity.Descripton.ToString();
                chkIsRemoved.Checked = mDOperatorStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDOperatorStatusList();
        }

        private void BindMDOperatorStatusList()
        {
            lvMDOperatorStatus.DataBind();
        }

        private MDOperatorStatusEntity BuildMDOperatorStatusEntity()
        {
            MDOperatorStatusEntity mDOperatorStatusEntity = CurrentMDOperatorStatusEntity;

            mDOperatorStatusEntity.Name = txtName.Text.Trim();
            mDOperatorStatusEntity.Descripton = txtDescripton.Text.Trim();
            mDOperatorStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDOperatorStatusEntity;
        }

        private void SaveMDOperatorStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDOperatorStatusEntity mDOperatorStatusEntity = BuildMDOperatorStatusEntity();

                    Int64 result = -1;

                    if (mDOperatorStatusEntity.IsNew)
                    {
                        result = FCCMDOperatorStatus.GetFacadeCreate().Add(mDOperatorStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDOperatorStatusEntity.FLD_NAME_OperatorStatusID, mDOperatorStatusEntity.OperatorStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDOperatorStatus.GetFacadeCreate().Update(mDOperatorStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _OperatorStatusID = 0;
                        _MDOperatorStatusEntity = new MDOperatorStatusEntity();
                        PrepareInitialView();
                        BindMDOperatorStatusList();

                        if (mDOperatorStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Operator Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDOperatorStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Operator Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Operator Status Information.", false);
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

        protected void lvMDOperatorStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 OperatorStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out OperatorStatusID);

            if (OperatorStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _OperatorStatusID = OperatorStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDOperatorStatusEntity.FLD_NAME_OperatorStatusID, OperatorStatusID.ToString(), SQLMatchType.Equal);

                        MDOperatorStatusEntity mDOperatorStatusEntity = new MDOperatorStatusEntity();


                        result = FCCMDOperatorStatus.GetFacadeCreate().Delete(mDOperatorStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _OperatorStatusID = 0;
                            _MDOperatorStatusEntity = new MDOperatorStatusEntity();
                            PrepareInitialView();
                            BindMDOperatorStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Operator Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Operator Status.", true);
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

        protected void odsMDOperatorStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDOperatorStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _OperatorStatusID = 0;
            _MDOperatorStatusEntity = new MDOperatorStatusEntity();
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
