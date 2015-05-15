// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




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
    public partial class ACMDBankAccountTypeControl : BaseControl
    {       
        #region Properties

        public Int64 _BankAccountTypeID
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

        public ACMDBankAccountTypeEntity _ACMDBankAccountTypeEntity
        {
            get
            {
                ACMDBankAccountTypeEntity entity = new ACMDBankAccountTypeEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDBankAccountTypeEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDBankAccountTypeEntity CurrentACMDBankAccountTypeEntity
        {
            get
            {
                if (_BankAccountTypeID > 0)
                {
                    if (_ACMDBankAccountTypeEntity.BankAccountTypeID != _BankAccountTypeID)
                    {
                        _ACMDBankAccountTypeEntity = FCCACMDBankAccountType.GetFacadeCreate().GetByID(_BankAccountTypeID);
                    }
                }

                return _ACMDBankAccountTypeEntity;
            }
            set
            {
                _ACMDBankAccountTypeEntity = value;
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
            ACMDBankAccountTypeEntity aCMDBankAccountTypeEntity = CurrentACMDBankAccountTypeEntity;


            if (!aCMDBankAccountTypeEntity.IsNew)
            {
                txtName.Text = aCMDBankAccountTypeEntity.Name.ToString();
                txtDescription.Text = aCMDBankAccountTypeEntity.Description.ToString();
                chkIsRemoved.Checked = aCMDBankAccountTypeEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDBankAccountTypeList();
        }

        private void BindACMDBankAccountTypeList()
        {
            lvACMDBankAccountType.DataBind();
        }

        private ACMDBankAccountTypeEntity BuildACMDBankAccountTypeEntity()
        {
            ACMDBankAccountTypeEntity aCMDBankAccountTypeEntity = CurrentACMDBankAccountTypeEntity;

            aCMDBankAccountTypeEntity.Name = txtName.Text.Trim();
            aCMDBankAccountTypeEntity.Description = txtDescription.Text.Trim();
            aCMDBankAccountTypeEntity.IsRemoved = chkIsRemoved.Checked;


            return aCMDBankAccountTypeEntity;
        }

        private void SaveACMDBankAccountTypeEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDBankAccountTypeEntity aCMDBankAccountTypeEntity = BuildACMDBankAccountTypeEntity();

                    Int64 result = -1;

                    if (aCMDBankAccountTypeEntity.IsNew)
                    {
                        result = FCCACMDBankAccountType.GetFacadeCreate().Add(aCMDBankAccountTypeEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountTypeEntity.FLD_NAME_BankAccountTypeID, aCMDBankAccountTypeEntity.BankAccountTypeID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDBankAccountType.GetFacadeCreate().Update(aCMDBankAccountTypeEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _BankAccountTypeID = 0;
                        _ACMDBankAccountTypeEntity = new ACMDBankAccountTypeEntity();
                        PrepareInitialView();
                        BindACMDBankAccountTypeList();

                        if (aCMDBankAccountTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Type Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Type Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDBankAccountTypeEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CBank Account Type Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CBank Account Type Information.", false);
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

        protected void lvACMDBankAccountType_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 BankAccountTypeID;

            Int64.TryParse(e.CommandArgument.ToString(), out BankAccountTypeID);

            if (BankAccountTypeID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _BankAccountTypeID = BankAccountTypeID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDBankAccountTypeEntity.FLD_NAME_BankAccountTypeID, BankAccountTypeID.ToString(), SQLMatchType.Equal);

                        ACMDBankAccountTypeEntity aCMDBankAccountTypeEntity = new ACMDBankAccountTypeEntity();


                        result = FCCACMDBankAccountType.GetFacadeCreate().Delete(aCMDBankAccountTypeEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _BankAccountTypeID = 0;
                            _ACMDBankAccountTypeEntity = new ACMDBankAccountTypeEntity();
                            PrepareInitialView();
                            BindACMDBankAccountTypeList();

                            MiscUtil.ShowMessage(lblMessage, "A CBank Account Type has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CBank Account Type.", true);
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

        protected void odsACMDBankAccountType_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDBankAccountTypeEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _BankAccountTypeID = 0;
            _ACMDBankAccountTypeEntity = new ACMDBankAccountTypeEntity();
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
