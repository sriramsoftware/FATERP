// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDBankAccountCategoryControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountCategoryID
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

        public MDBankAccountCategoryEntity _MDBankAccountCategoryEntity
        {
            get
            {
                MDBankAccountCategoryEntity entity = new MDBankAccountCategoryEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (MDBankAccountCategoryEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private MDBankAccountCategoryEntity CurrentMDBankAccountCategoryEntity
        {
            get
            {
                if (_BankAccountCategoryID > 0)
                {
                    if (_MDBankAccountCategoryEntity.BankAccountCategoryID != _BankAccountCategoryID)
                    {
                        _MDBankAccountCategoryEntity = FCCMDBankAccountCategory.GetFacadeCreate().GetByID(_BankAccountCategoryID);
                    }
                }

                return _MDBankAccountCategoryEntity;
            }
            set
            {
                _MDBankAccountCategoryEntity = value;
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
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            MDBankAccountCategoryEntity mDBankAccountCategoryEntity = CurrentMDBankAccountCategoryEntity;


            if (!mDBankAccountCategoryEntity.IsNew)
            {
                txtName.Text = mDBankAccountCategoryEntity.Name.ToString();
                txtRemarks.Text = mDBankAccountCategoryEntity.Remarks.ToString();
                chkIsRemoved.Checked = mDBankAccountCategoryEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindMDBankAccountCategoryList();
        }

        private void BindMDBankAccountCategoryList()
        {
            lvMDBankAccountCategory.DataBind();
        }

        private MDBankAccountCategoryEntity BuildMDBankAccountCategoryEntity()
        {
            MDBankAccountCategoryEntity mDBankAccountCategoryEntity = CurrentMDBankAccountCategoryEntity;

            mDBankAccountCategoryEntity.Name = txtName.Text.Trim();
            mDBankAccountCategoryEntity.Remarks = txtRemarks.Text.Trim();
            mDBankAccountCategoryEntity.IsRemoved = chkIsRemoved.Checked;


            return mDBankAccountCategoryEntity;
        }

        private void SaveMDBankAccountCategoryEntity()
        {
            if (IsValid)
            {
                try
                {
                    MDBankAccountCategoryEntity mDBankAccountCategoryEntity = BuildMDBankAccountCategoryEntity();

                    Int64 result = -1;

                    if (mDBankAccountCategoryEntity.IsNew)
                    {
                        result = FCCMDBankAccountCategory.GetFacadeCreate().Add(mDBankAccountCategoryEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDBankAccountCategoryEntity.FLD_NAME_BankAccountCategoryID, mDBankAccountCategoryEntity.BankAccountCategoryID.ToString(), SQLMatchType.Equal);
                        result = FCCMDBankAccountCategory.GetFacadeCreate().Update(mDBankAccountCategoryEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BankAccountCategoryID = 0;
                        _MDBankAccountCategoryEntity = new MDBankAccountCategoryEntity();
                        PrepareInitialView();
                        BindMDBankAccountCategoryList();

                        if (mDBankAccountCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bank Account Category Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Bank Account Category Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (mDBankAccountCategoryEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Bank Account Category Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Bank Account Category Information.", false);
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

        protected void lvMDBankAccountCategory_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountCategoryID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountCategoryID);

            if (BankAccountCategoryID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountCategoryID = BankAccountCategoryID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDBankAccountCategoryEntity.FLD_NAME_BankAccountCategoryID, BankAccountCategoryID.ToString(), SQLMatchType.Equal);

                        MDBankAccountCategoryEntity mDBankAccountCategoryEntity = new MDBankAccountCategoryEntity();


                        result = FCCMDBankAccountCategory.GetFacadeCreate().Delete(mDBankAccountCategoryEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BankAccountCategoryID = 0;
                            _MDBankAccountCategoryEntity = new MDBankAccountCategoryEntity();
                            PrepareInitialView();
                            BindMDBankAccountCategoryList();

                            MiscUtil.ShowMessage(lblMessage, "Bank Account Category has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Bank Account Category.", true);
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

        protected void odsMDBankAccountCategory_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveMDBankAccountCategoryEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountCategoryID = 0;
            _MDBankAccountCategoryEntity = new MDBankAccountCategoryEntity();
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
