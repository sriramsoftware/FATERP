// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2012, 10:27:43




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
    public partial class MDBillStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _BillStatusID
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

        public MDBillStatusEntity _MDBillStatusEntity
        {
            get
            {
                MDBillStatusEntity entity = new MDBillStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDBillStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDBillStatusEntity CurrentMDBillStatusEntity
        {
            get
            {
                if (_BillStatusID > 0)
                {
                    if (_MDBillStatusEntity.BillStatusID != _BillStatusID)
                    {
                        _MDBillStatusEntity = FCCMDBillStatus.GetFacadeCreate().GetByID(_BillStatusID);
                    }
                }

                return _MDBillStatusEntity;
            }
            set
            {
                _MDBillStatusEntity = value;
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
            chkIsRemove.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDBillStatusEntity mDBillStatusEntity = CurrentMDBillStatusEntity;


            if (!mDBillStatusEntity.IsNew)
            {
                txtName.Text = mDBillStatusEntity.Name.ToString();
                txtDescription.Text = mDBillStatusEntity.Description.ToString();
                chkIsRemove.Checked = mDBillStatusEntity.IsRemove;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDBillStatusList();
        }

        private void BindMDBillStatusList()
        {
            lvMDBillStatus.DataBind();
        }

        private MDBillStatusEntity BuildMDBillStatusEntity()
        {
            MDBillStatusEntity mDBillStatusEntity = CurrentMDBillStatusEntity;

            mDBillStatusEntity.Name = txtName.Text.Trim();
            mDBillStatusEntity.Description = txtDescription.Text.Trim();
            mDBillStatusEntity.IsRemove = chkIsRemove.Checked;


            return mDBillStatusEntity;
        }

        private void SaveMDBillStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDBillStatusEntity mDBillStatusEntity = BuildMDBillStatusEntity();

                    Int64 result = -1;

                    if (mDBillStatusEntity.IsNew)
                    {
                        result = FCCMDBillStatus.GetFacadeCreate().Add(mDBillStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDBillStatusEntity.FLD_NAME_BillStatusID, mDBillStatusEntity.BillStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDBillStatus.GetFacadeCreate().Update(mDBillStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BillStatusID = 0;
                        _MDBillStatusEntity = new MDBillStatusEntity();
                        PrepareInitialView();
                        BindMDBillStatusList();

                        if (mDBillStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bill Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bill Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDBillStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Bill Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Bill Status Information.", false);
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

        protected void lvMDBillStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BillStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out BillStatusID);

            if (BillStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BillStatusID = BillStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDBillStatusEntity.FLD_NAME_BillStatusID, BillStatusID.ToString(), SQLMatchType.Equal);

                        MDBillStatusEntity mDBillStatusEntity = new MDBillStatusEntity();


                        result = FCCMDBillStatus.GetFacadeCreate().Delete(mDBillStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BillStatusID = 0;
                            _MDBillStatusEntity = new MDBillStatusEntity();
                            PrepareInitialView();
                            BindMDBillStatusList();

                            MiscUtil.ShowMessage(lblMessage, "Bill Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Bill Status.", true);
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

        protected void odsMDBillStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDBillStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BillStatusID = 0;
            _MDBillStatusEntity = new MDBillStatusEntity();
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
