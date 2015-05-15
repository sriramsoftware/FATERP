// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public partial class MDBOQStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _BOQStatusID
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

        public MDBOQStatusEntity _MDBOQStatusEntity
        {
            get
            {
                MDBOQStatusEntity entity = new MDBOQStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDBOQStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDBOQStatusEntity CurrentMDBOQStatusEntity
        {
            get
            {
                if (_BOQStatusID > 0)
                {
                    if (_MDBOQStatusEntity.BOQStatusID != _BOQStatusID)
                    {
                        _MDBOQStatusEntity = FCCMDBOQStatus.GetFacadeCreate().GetByID(_BOQStatusID);
                    }
                }

                return _MDBOQStatusEntity;
            }
            set
            {
                _MDBOQStatusEntity = value;
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
            MDBOQStatusEntity mDBOQStatusEntity = CurrentMDBOQStatusEntity;


            if (!mDBOQStatusEntity.IsNew)
            {
                txtName.Text = mDBOQStatusEntity.Name.ToString();
                txtDescription.Text = mDBOQStatusEntity.Description.ToString();
                chkIsRemoved.Checked = mDBOQStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDBOQStatusList();
        }

        private void BindMDBOQStatusList()
        {
            lvMDBOQStatus.DataBind();
        }

        private MDBOQStatusEntity BuildMDBOQStatusEntity()
        {
            MDBOQStatusEntity mDBOQStatusEntity = CurrentMDBOQStatusEntity;

            mDBOQStatusEntity.Name = txtName.Text.Trim();
            mDBOQStatusEntity.Description = txtDescription.Text.Trim();
            mDBOQStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return mDBOQStatusEntity;
        }

        private void SaveMDBOQStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDBOQStatusEntity mDBOQStatusEntity = BuildMDBOQStatusEntity();

                    Int64 result = -1;

                    if (mDBOQStatusEntity.IsNew)
                    {
                        result = FCCMDBOQStatus.GetFacadeCreate().Add(mDBOQStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDBOQStatusEntity.FLD_NAME_BOQStatusID, mDBOQStatusEntity.BOQStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCMDBOQStatus.GetFacadeCreate().Update(mDBOQStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BOQStatusID = 0;
                        _MDBOQStatusEntity = new MDBOQStatusEntity();
                        PrepareInitialView();
                        BindMDBOQStatusList();

                        if (mDBOQStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "B OQStatus Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "B OQStatus Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDBOQStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add B OQStatus Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update B OQStatus Information.", false);
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

        protected void lvMDBOQStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BOQStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out BOQStatusID);

            if (BOQStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BOQStatusID = BOQStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDBOQStatusEntity.FLD_NAME_BOQStatusID, BOQStatusID.ToString(), SQLMatchType.Equal);

                        MDBOQStatusEntity mDBOQStatusEntity = new MDBOQStatusEntity();


                        result = FCCMDBOQStatus.GetFacadeCreate().Delete(mDBOQStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BOQStatusID = 0;
                            _MDBOQStatusEntity = new MDBOQStatusEntity();
                            PrepareInitialView();
                            BindMDBOQStatusList();

                            MiscUtil.ShowMessage(lblMessage, "B OQStatus has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete B OQStatus.", true);
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

        protected void odsMDBOQStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDBOQStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BOQStatusID = 0;
            _MDBOQStatusEntity = new MDBOQStatusEntity();
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
