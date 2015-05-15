// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public partial class ACMDDebitCreditControl : BaseControl
    {       
        #region Properties

        public Int64 _MDDebitCreditID
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

        public ACMDDebitCreditEntity _ACMDDebitCreditEntity
        {
            get
            {
                ACMDDebitCreditEntity entity = new ACMDDebitCreditEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACMDDebitCreditEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACMDDebitCreditEntity CurrentACMDDebitCreditEntity
        {
            get
            {
                if (_MDDebitCreditID > 0)
                {
                    if (_ACMDDebitCreditEntity.MDDebitCreditID != _MDDebitCreditID)
                    {
                        _ACMDDebitCreditEntity = FCCACMDDebitCredit.GetFacadeCreate().GetByID(_MDDebitCreditID);
                    }
                }

                return _ACMDDebitCreditEntity;
            }
            set
            {
                _ACMDDebitCreditEntity = value;
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
            chkIsDebit.Checked = false;
            chkIsCredit.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACMDDebitCreditEntity aCMDDebitCreditEntity = CurrentACMDDebitCreditEntity;


            if (!aCMDDebitCreditEntity.IsNew)
            {
                txtName.Text = aCMDDebitCreditEntity.Name.ToString();
                chkIsDebit.Checked = aCMDDebitCreditEntity.IsDebit;
                chkIsCredit.Checked = aCMDDebitCreditEntity.IsCredit;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACMDDebitCreditList();
        }

        private void BindACMDDebitCreditList()
        {
            lvACMDDebitCredit.DataBind();
        }

        private ACMDDebitCreditEntity BuildACMDDebitCreditEntity()
        {
            ACMDDebitCreditEntity aCMDDebitCreditEntity = CurrentACMDDebitCreditEntity;

            aCMDDebitCreditEntity.Name = txtName.Text.Trim();
            aCMDDebitCreditEntity.IsDebit = chkIsDebit.Checked;

            aCMDDebitCreditEntity.IsCredit = chkIsCredit.Checked;


            return aCMDDebitCreditEntity;
        }

        private void SaveACMDDebitCreditEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACMDDebitCreditEntity aCMDDebitCreditEntity = BuildACMDDebitCreditEntity();

                    Int64 result = -1;

                    if (aCMDDebitCreditEntity.IsNew)
                    {
                        result = FCCACMDDebitCredit.GetFacadeCreate().Add(aCMDDebitCreditEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACMDDebitCreditEntity.FLD_NAME_MDDebitCreditID, aCMDDebitCreditEntity.MDDebitCreditID.ToString(), SQLMatchType.Equal);
                        result = FCCACMDDebitCredit.GetFacadeCreate().Update(aCMDDebitCreditEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _MDDebitCreditID = 0;
                        _ACMDDebitCreditEntity = new ACMDDebitCreditEntity();
                        PrepareInitialView();
                        BindACMDDebitCreditList();

                        if (aCMDDebitCreditEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCMDDebitCreditEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CDebit Credit Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CDebit Credit Information.", false);
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

        protected void lvACMDDebitCredit_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MDDebitCreditID;

            Int64.TryParse(e.CommandArgument.ToString(), out MDDebitCreditID);

            if (MDDebitCreditID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _MDDebitCreditID = MDDebitCreditID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACMDDebitCreditEntity.FLD_NAME_MDDebitCreditID, MDDebitCreditID.ToString(), SQLMatchType.Equal);

                        ACMDDebitCreditEntity aCMDDebitCreditEntity = new ACMDDebitCreditEntity();


                        result = FCCACMDDebitCredit.GetFacadeCreate().Delete(aCMDDebitCreditEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MDDebitCreditID = 0;
                            _ACMDDebitCreditEntity = new ACMDDebitCreditEntity();
                            PrepareInitialView();
                            BindACMDDebitCreditList();

                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CDebit Credit.", true);
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

        protected void odsACMDDebitCredit_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACMDDebitCreditEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _MDDebitCreditID = 0;
            _ACMDDebitCreditEntity = new ACMDDebitCreditEntity();
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
