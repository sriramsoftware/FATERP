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
    public partial class ACDebitCreditRuleElementControl : BaseControl
    {       
        #region Properties

        public Int64 _DebitCreditRuleElementID
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

        public ACDebitCreditRuleElementEntity _ACDebitCreditRuleElementEntity
        {
            get
            {
                ACDebitCreditRuleElementEntity entity = new ACDebitCreditRuleElementEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACDebitCreditRuleElementEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACDebitCreditRuleElementEntity CurrentACDebitCreditRuleElementEntity
        {
            get
            {
                if (_DebitCreditRuleElementID > 0)
                {
                    if (_ACDebitCreditRuleElementEntity.DebitCreditRuleElementID != _DebitCreditRuleElementID)
                    {
                        _ACDebitCreditRuleElementEntity = FCCACDebitCreditRuleElement.GetFacadeCreate().GetByID(_DebitCreditRuleElementID);
                    }
                }

                return _ACDebitCreditRuleElementEntity;
            }
            set
            {
                _ACDebitCreditRuleElementEntity = value;
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

            txtDebitCreditRuleElementID.Text = String.Empty;
            txtAction.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity = CurrentACDebitCreditRuleElementEntity;


            if (!aCDebitCreditRuleElementEntity.IsNew)
            {
                txtDebitCreditRuleElementID.Text = aCDebitCreditRuleElementEntity.DebitCreditRuleElementID.ToString();
                txtAction.Text = aCDebitCreditRuleElementEntity.Action.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACDebitCreditRuleElementList();
        }

        private void BindACDebitCreditRuleElementList()
        {
            lvACDebitCreditRuleElement.DataBind();
        }

        private ACDebitCreditRuleElementEntity BuildACDebitCreditRuleElementEntity()
        {
            ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity = CurrentACDebitCreditRuleElementEntity;

            if (!txtDebitCreditRuleElementID.Text.Trim().IsNullOrEmpty())
            {
                aCDebitCreditRuleElementEntity.DebitCreditRuleElementID = Int64.Parse(txtDebitCreditRuleElementID.Text.Trim());
            }

            aCDebitCreditRuleElementEntity.Action = txtAction.Text.Trim();

            return aCDebitCreditRuleElementEntity;
        }

        private void SaveACDebitCreditRuleElementEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity = BuildACDebitCreditRuleElementEntity();

                    Int64 result = -1;

                    if (aCDebitCreditRuleElementEntity.IsNew)
                    {
                        result = FCCACDebitCreditRuleElement.GetFacadeCreate().Add(aCDebitCreditRuleElementEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACDebitCreditRuleElementEntity.FLD_NAME_DebitCreditRuleElementID, aCDebitCreditRuleElementEntity.DebitCreditRuleElementID.ToString(), SQLMatchType.Equal);
                        result = FCCACDebitCreditRuleElement.GetFacadeCreate().Update(aCDebitCreditRuleElementEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DebitCreditRuleElementID = 0;
                        _ACDebitCreditRuleElementEntity = new ACDebitCreditRuleElementEntity();
                        PrepareInitialView();
                        BindACDebitCreditRuleElementList();

                        if (aCDebitCreditRuleElementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit Rule Element Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit Rule Element Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCDebitCreditRuleElementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CDebit Credit Rule Element Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CDebit Credit Rule Element Information.", false);
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

        protected void lvACDebitCreditRuleElement_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DebitCreditRuleElementID;

            Int64.TryParse(e.CommandArgument.ToString(), out DebitCreditRuleElementID);

            if (DebitCreditRuleElementID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DebitCreditRuleElementID = DebitCreditRuleElementID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACDebitCreditRuleElementEntity.FLD_NAME_DebitCreditRuleElementID, DebitCreditRuleElementID.ToString(), SQLMatchType.Equal);

                        ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity = new ACDebitCreditRuleElementEntity();


                        result = FCCACDebitCreditRuleElement.GetFacadeCreate().Delete(aCDebitCreditRuleElementEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _DebitCreditRuleElementID = 0;
                            _ACDebitCreditRuleElementEntity = new ACDebitCreditRuleElementEntity();
                            PrepareInitialView();
                            BindACDebitCreditRuleElementList();

                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit Rule Element has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CDebit Credit Rule Element.", true);
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

        protected void odsACDebitCreditRuleElement_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACDebitCreditRuleElementEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DebitCreditRuleElementID = 0;
            _ACDebitCreditRuleElementEntity = new ACDebitCreditRuleElementEntity();
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
