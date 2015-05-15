// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public partial class BDMDProcessAssignedResourceApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _ProcessAssignedResourceApprovalStatusID
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

        public BDMDProcessAssignedResourceApprovalStatusEntity _BDMDProcessAssignedResourceApprovalStatusEntity
        {
            get
            {
                BDMDProcessAssignedResourceApprovalStatusEntity entity = new BDMDProcessAssignedResourceApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (BDMDProcessAssignedResourceApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private BDMDProcessAssignedResourceApprovalStatusEntity CurrentBDMDProcessAssignedResourceApprovalStatusEntity
        {
            get
            {
                if (_ProcessAssignedResourceApprovalStatusID > 0)
                {
                    if (_BDMDProcessAssignedResourceApprovalStatusEntity.ProcessAssignedResourceApprovalStatusID != _ProcessAssignedResourceApprovalStatusID)
                    {
                        _BDMDProcessAssignedResourceApprovalStatusEntity = FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().GetByID(_ProcessAssignedResourceApprovalStatusID);
                    }
                }

                return _BDMDProcessAssignedResourceApprovalStatusEntity;
            }
            set
            {
                _BDMDProcessAssignedResourceApprovalStatusEntity = value;
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
            BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity = CurrentBDMDProcessAssignedResourceApprovalStatusEntity;


            if (!bDMDProcessAssignedResourceApprovalStatusEntity.IsNew)
            {
                txtName.Text = bDMDProcessAssignedResourceApprovalStatusEntity.Name.ToString();
                txtDescription.Text = bDMDProcessAssignedResourceApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = bDMDProcessAssignedResourceApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindBDMDProcessAssignedResourceApprovalStatusList();
        }

        private void BindBDMDProcessAssignedResourceApprovalStatusList()
        {
            lvBDMDProcessAssignedResourceApprovalStatus.DataBind();
        }

        private BDMDProcessAssignedResourceApprovalStatusEntity BuildBDMDProcessAssignedResourceApprovalStatusEntity()
        {
            BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity = CurrentBDMDProcessAssignedResourceApprovalStatusEntity;

            bDMDProcessAssignedResourceApprovalStatusEntity.Name = txtName.Text.Trim();
            bDMDProcessAssignedResourceApprovalStatusEntity.Description = txtDescription.Text.Trim();
            bDMDProcessAssignedResourceApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return bDMDProcessAssignedResourceApprovalStatusEntity;
        }

        private void SaveBDMDProcessAssignedResourceApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity = BuildBDMDProcessAssignedResourceApprovalStatusEntity();

                    Int64 result = -1;

                    if (bDMDProcessAssignedResourceApprovalStatusEntity.IsNew)
                    {
                        result = FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().Add(bDMDProcessAssignedResourceApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(BDMDProcessAssignedResourceApprovalStatusEntity.FLD_NAME_ProcessAssignedResourceApprovalStatusID, bDMDProcessAssignedResourceApprovalStatusEntity.ProcessAssignedResourceApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().Update(bDMDProcessAssignedResourceApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ProcessAssignedResourceApprovalStatusID = 0;
                        _BDMDProcessAssignedResourceApprovalStatusEntity = new BDMDProcessAssignedResourceApprovalStatusEntity();
                        PrepareInitialView();
                        BindBDMDProcessAssignedResourceApprovalStatusList();

                        if (bDMDProcessAssignedResourceApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (bDMDProcessAssignedResourceApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Process Assigned Resource Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Process Assigned Resource Approval Status Information.", false);
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

        protected void lvBDMDProcessAssignedResourceApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ProcessAssignedResourceApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out ProcessAssignedResourceApprovalStatusID);

            if (ProcessAssignedResourceApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ProcessAssignedResourceApprovalStatusID = ProcessAssignedResourceApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDProcessAssignedResourceApprovalStatusEntity.FLD_NAME_ProcessAssignedResourceApprovalStatusID, ProcessAssignedResourceApprovalStatusID.ToString(), SQLMatchType.Equal);

                        BDMDProcessAssignedResourceApprovalStatusEntity bDMDProcessAssignedResourceApprovalStatusEntity = new BDMDProcessAssignedResourceApprovalStatusEntity();


                        result = FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().Delete(bDMDProcessAssignedResourceApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ProcessAssignedResourceApprovalStatusID = 0;
                            _BDMDProcessAssignedResourceApprovalStatusEntity = new BDMDProcessAssignedResourceApprovalStatusEntity();
                            PrepareInitialView();
                            BindBDMDProcessAssignedResourceApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Process Assigned Resource Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Process Assigned Resource Approval Status.", true);
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

        protected void odsBDMDProcessAssignedResourceApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveBDMDProcessAssignedResourceApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ProcessAssignedResourceApprovalStatusID = 0;
            _BDMDProcessAssignedResourceApprovalStatusEntity = new BDMDProcessAssignedResourceApprovalStatusEntity();
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
