// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class MDBrandControl : BaseControl
    {       
        #region Properties

        public Int64 _BrandID
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

        public MDBrandEntity _MDBrandEntity
        {
            get
            {
                MDBrandEntity entity = new MDBrandEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDBrandEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDBrandEntity CurrentMDBrandEntity
        {
            get
            {
                if (_BrandID > 0)
                {
                    if (_MDBrandEntity.BrandID != _BrandID)
                    {
                        _MDBrandEntity = FCCMDBrand.GetFacadeCreate().GetByID(_BrandID);
                    }
                }

                return _MDBrandEntity;
            }
            set
            {
                _MDBrandEntity = value;
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

            txtBrandName.Text = String.Empty;
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDBrandEntity mDBrandEntity = CurrentMDBrandEntity;


            if (!mDBrandEntity.IsNew)
            {
                txtBrandName.Text = mDBrandEntity.BrandName.ToString();
                txtRemarks.Text = mDBrandEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDBrandEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDBrandList();
        }

        private void BindMDBrandList()
        {
            lvMDBrand.DataBind();
        }

        private MDBrandEntity BuildMDBrandEntity()
        {
            MDBrandEntity mDBrandEntity = CurrentMDBrandEntity;

            mDBrandEntity.BrandName = txtBrandName.Text.Trim();
            mDBrandEntity.Remarks = txtRemarks.Text.Trim();
            mDBrandEntity.IsRemoved = chkIsRemoved.Checked;


            return mDBrandEntity;
        }

        private void SaveMDBrandEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDBrandEntity mDBrandEntity = BuildMDBrandEntity();

                    Int64 result = -1;

                    if (mDBrandEntity.IsNew)
                    {
                        result = FCCMDBrand.GetFacadeCreate().Add(mDBrandEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDBrandEntity.FLD_NAME_BrandID, mDBrandEntity.BrandID.ToString(), SQLMatchType.Equal);
                        result = FCCMDBrand.GetFacadeCreate().Update(mDBrandEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BrandID = 0;
                        _MDBrandEntity = new MDBrandEntity();
                        PrepareInitialView();
                        BindMDBrandList();

                        if (mDBrandEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Brand Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Brand Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDBrandEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Brand Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Brand Information.", false);
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

                PendingTaskNotification.pendingList();
            }
        }

        #endregion

        #region List View Event

        protected void lvMDBrand_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BrandID;

            Int64.TryParse(e.CommandArgument.ToString(), out BrandID);

            if (BrandID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BrandID = BrandID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDBrandEntity.FLD_NAME_BrandID, BrandID.ToString(), SQLMatchType.Equal);

                        MDBrandEntity mDBrandEntity = new MDBrandEntity();


                        result = FCCMDBrand.GetFacadeCreate().Delete(mDBrandEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BrandID = 0;
                            _MDBrandEntity = new MDBrandEntity();
                            PrepareInitialView();
                            BindMDBrandList();

                            MiscUtil.ShowMessage(lblMessage, "Brand has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Brand.", true);
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

        protected void odsMDBrand_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDBrandEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BrandID = 0;
            _MDBrandEntity = new MDBrandEntity();
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
