// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Oct-2012, 04:13:46




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
    public partial class MDBillApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _BillApprovalStatusID
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

        public MDBillApprovalStatusEntity _MDBillApprovalStatusEntity
        {
            get
            {
                MDBillApprovalStatusEntity entity = new MDBillApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDBillApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDBillApprovalStatusEntity CurrentMDBillApprovalStatusEntity
        {
            get
            {
                if (_BillApprovalStatusID > 0)
                {
                    if (_MDBillApprovalStatusEntity.BillApprovalStatusID != _BillApprovalStatusID)
                    {
                        _MDBillApprovalStatusEntity = FCCMDBillApprovalStatus.GetFacadeCreate().GetByID(_BillApprovalStatusID);
                    }
                }

                return _MDBillApprovalStatusEntity;
            }
            set
            {
                _MDBillApprovalStatusEntity = value;
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
            MDBillApprovalStatusEntity mDBillApprovalStatusEntity = CurrentMDBillApprovalStatusEntity;


            if (!mDBillApprovalStatusEntity.IsNew)
            {
                txtName.Text = mDBillApprovalStatusEntity.Name.ToString();
                chkIsRemoved.Checked = mDBillApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDBillApprovalStatusList();
        }

        private void BindMDBillApprovalStatusList()
        {
            lvMDBillApprovalStatus.DataBind();
        }

        private MDBillApprovalStatusEntity BuildMDBillApprovalStatusEntity()
        {
            MDBillApprovalStatusEntity mDBillApprovalStatusEntity = CurrentMDBillApprovalStatusEntity;

            mDBillApprovalStatusEntity.Name = txtName.Text.Trim();
            mDBillApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDBillApprovalStatusEntity;
        }

        private void SaveMDBillApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDBillApprovalStatusEntity mDBillApprovalStatusEntity = BuildMDBillApprovalStatusEntity();

                    Int64 result = -1;

                    if (mDBillApprovalStatusEntity.IsNew)
                    {
                        result = FCCMDBillApprovalStatus.GetFacadeCreate().Add(mDBillApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDBillApprovalStatusEntity.FLD_NAME_BillApprovalStatusID, mDBillApprovalStatusEntity.BillApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDBillApprovalStatus.GetFacadeCreate().Update(mDBillApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BillApprovalStatusID = 0;
                        _MDBillApprovalStatusEntity = new MDBillApprovalStatusEntity();
                        PrepareInitialView();
                        BindMDBillApprovalStatusList();

                        if (mDBillApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bill Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bill Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDBillApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Bill Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Bill Approval Status Information.", false);
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

        protected void lvMDBillApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BillApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out BillApprovalStatusID);

            if (BillApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BillApprovalStatusID = BillApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDBillApprovalStatusEntity.FLD_NAME_BillApprovalStatusID, BillApprovalStatusID.ToString(), SQLMatchType.Equal);

                        MDBillApprovalStatusEntity mDBillApprovalStatusEntity = new MDBillApprovalStatusEntity();


                        result = FCCMDBillApprovalStatus.GetFacadeCreate().Delete(mDBillApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BillApprovalStatusID = 0;
                            _MDBillApprovalStatusEntity = new MDBillApprovalStatusEntity();
                            PrepareInitialView();
                            BindMDBillApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Bill Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Bill Approval Status.", true);
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

        protected void odsMDBillApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDBillApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BillApprovalStatusID = 0;
            _MDBillApprovalStatusEntity = new MDBillApprovalStatusEntity();
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
