// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jan-2012, 10:20:36




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
    public partial class MDRequisitionStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _RequisitionStatusID
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

        public MDRequisitionStatusEntity _MDRequisitionStatusEntity
        {
            get
            {
                MDRequisitionStatusEntity entity = new MDRequisitionStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDRequisitionStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDRequisitionStatusEntity CurrentMDRequisitionStatusEntity
        {
            get
            {
                if (_RequisitionStatusID > 0)
                {
                    if (_MDRequisitionStatusEntity.RequisitionStatusID != _RequisitionStatusID)
                    {
                        _MDRequisitionStatusEntity = FCCMDRequisitionStatus.GetFacadeCreate().GetByID(_RequisitionStatusID);
                    }
                }

                return _MDRequisitionStatusEntity;
            }
            set
            {
                _MDRequisitionStatusEntity = value;
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
            MDRequisitionStatusEntity mDRequisitionStatusEntity = CurrentMDRequisitionStatusEntity;


            if (!mDRequisitionStatusEntity.IsNew)
            {
                txtName.Text = mDRequisitionStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDRequisitionStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDRequisitionStatusList();
        }

        private void BindMDRequisitionStatusList()
        {
            lvMDRequisitionStatus.DataBind();
        }

        private MDRequisitionStatusEntity BuildMDRequisitionStatusEntity()
        {
            MDRequisitionStatusEntity mDRequisitionStatusEntity = CurrentMDRequisitionStatusEntity;

            mDRequisitionStatusEntity.Name = txtName.Text.Trim();
            mDRequisitionStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDRequisitionStatusEntity;
        }

        private void SaveMDRequisitionStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDRequisitionStatusEntity mDRequisitionStatusEntity = BuildMDRequisitionStatusEntity();

                    Int64 result = -1;

                    if (mDRequisitionStatusEntity.IsNew)
                    {
                        result = FCCMDRequisitionStatus.GetFacadeCreate().Add(mDRequisitionStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDRequisitionStatusEntity.FLD_NAME_RequisitionStatusID, mDRequisitionStatusEntity.RequisitionStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDRequisitionStatus.GetFacadeCreate().Update(mDRequisitionStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _RequisitionStatusID = 0;
                        _MDRequisitionStatusEntity = new MDRequisitionStatusEntity();
                        PrepareInitialView();
                        BindMDRequisitionStatusList();

                        if (mDRequisitionStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Requisition Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Requisition Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDRequisitionStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Requisition Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Requisition Status Information.", false);
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

        protected void lvMDRequisitionStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 RequisitionStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out RequisitionStatusID);

            if (RequisitionStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _RequisitionStatusID = RequisitionStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDRequisitionStatusEntity.FLD_NAME_RequisitionStatusID, RequisitionStatusID.ToString(), SQLMatchType.Equal);

                        MDRequisitionStatusEntity mDRequisitionStatusEntity = new MDRequisitionStatusEntity();


                        result = FCCMDRequisitionStatus.GetFacadeCreate().Delete(mDRequisitionStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _RequisitionStatusID = 0;
                            _MDRequisitionStatusEntity = new MDRequisitionStatusEntity();
                            PrepareInitialView();
                            BindMDRequisitionStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Requisition Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Requisition Status.", true);
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

        protected void odsMDRequisitionStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDRequisitionStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _RequisitionStatusID = 0;
            _MDRequisitionStatusEntity = new MDRequisitionStatusEntity();
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
