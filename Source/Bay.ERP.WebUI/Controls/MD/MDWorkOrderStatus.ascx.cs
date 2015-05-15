// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
    public partial class MDWorkOrderStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _WorkOrderStatusID
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

        public MDWorkOrderStatusEntity _MDWorkOrderStatusEntity
        {
            get
            {
                MDWorkOrderStatusEntity entity = new MDWorkOrderStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDWorkOrderStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDWorkOrderStatusEntity CurrentMDWorkOrderStatusEntity
        {
            get
            {
                if (_WorkOrderStatusID > 0)
                {
                    if (_MDWorkOrderStatusEntity.WorkOrderStatusID != _WorkOrderStatusID)
                    {
                        _MDWorkOrderStatusEntity = FCCMDWorkOrderStatus.GetFacadeCreate().GetByID(_WorkOrderStatusID);
                    }
                }

                return _MDWorkOrderStatusEntity;
            }
            set
            {
                _MDWorkOrderStatusEntity = value;
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
            MDWorkOrderStatusEntity mDWorkOrderStatusEntity = CurrentMDWorkOrderStatusEntity;


            if (!mDWorkOrderStatusEntity.IsNew)
            {
                txtName.Text = mDWorkOrderStatusEntity.Name.ToString();
                txtDescription.Text = mDWorkOrderStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDWorkOrderStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDWorkOrderStatusList();
        }

        private void BindMDWorkOrderStatusList()
        {
            lvMDWorkOrderStatus.DataBind();
        }

        private MDWorkOrderStatusEntity BuildMDWorkOrderStatusEntity()
        {
            MDWorkOrderStatusEntity mDWorkOrderStatusEntity = CurrentMDWorkOrderStatusEntity;

            mDWorkOrderStatusEntity.Name = txtName.Text.Trim();
            mDWorkOrderStatusEntity.Description = txtDescription.Text.Trim();
            mDWorkOrderStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDWorkOrderStatusEntity;
        }

        private void SaveMDWorkOrderStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDWorkOrderStatusEntity mDWorkOrderStatusEntity = BuildMDWorkOrderStatusEntity();

                    Int64 result = -1;

                    if (mDWorkOrderStatusEntity.IsNew)
                    {
                        result = FCCMDWorkOrderStatus.GetFacadeCreate().Add(mDWorkOrderStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDWorkOrderStatusEntity.FLD_NAME_WorkOrderStatusID, mDWorkOrderStatusEntity.WorkOrderStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDWorkOrderStatus.GetFacadeCreate().Update(mDWorkOrderStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _WorkOrderStatusID = 0;
                        _MDWorkOrderStatusEntity = new MDWorkOrderStatusEntity();
                        PrepareInitialView();
                        BindMDWorkOrderStatusList();

                        if (mDWorkOrderStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Work Order Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDWorkOrderStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Work Order Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Work Order Status Information.", false);
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

        protected void lvMDWorkOrderStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 WorkOrderStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out WorkOrderStatusID);

            if (WorkOrderStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _WorkOrderStatusID = WorkOrderStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDWorkOrderStatusEntity.FLD_NAME_WorkOrderStatusID, WorkOrderStatusID.ToString(), SQLMatchType.Equal);

                        MDWorkOrderStatusEntity mDWorkOrderStatusEntity = new MDWorkOrderStatusEntity();


                        result = FCCMDWorkOrderStatus.GetFacadeCreate().Delete(mDWorkOrderStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _WorkOrderStatusID = 0;
                            _MDWorkOrderStatusEntity = new MDWorkOrderStatusEntity();
                            PrepareInitialView();
                            BindMDWorkOrderStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Work Order Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Work Order Status.", true);
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

        protected void odsMDWorkOrderStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDWorkOrderStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _WorkOrderStatusID = 0;
            _MDWorkOrderStatusEntity = new MDWorkOrderStatusEntity();
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
