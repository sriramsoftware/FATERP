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
    public partial class ACDebitCreditRuleControl : BaseControl
    {       
        #region Properties

        public Int64 _ACDebitCreditRuleID
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

        public ACDebitCreditRuleEntity _ACDebitCreditRuleEntity
        {
            get
            {
                ACDebitCreditRuleEntity entity = new ACDebitCreditRuleEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACDebitCreditRuleEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACDebitCreditRuleEntity CurrentACDebitCreditRuleEntity
        {
            get
            {
                if (_ACDebitCreditRuleID > 0)
                {
                    if (_ACDebitCreditRuleEntity.ACDebitCreditRuleID != _ACDebitCreditRuleID)
                    {
                        _ACDebitCreditRuleEntity = FCCACDebitCreditRule.GetFacadeCreate().GetByID(_ACDebitCreditRuleID);
                    }
                }

                return _ACDebitCreditRuleEntity;
            }
            set
            {
                _ACDebitCreditRuleEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateACDebitCreditRuleElement(ddlDebitCreditActionID, false);
            MiscUtil.PopulateACMDDebitCredit(ddlMDDebitCreditID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            chkIsUp.Checked = false;
            chkIsDown.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACDebitCreditRuleEntity aCDebitCreditRuleEntity = CurrentACDebitCreditRuleEntity;


            if (!aCDebitCreditRuleEntity.IsNew)
            {
                if (ddlDebitCreditActionID.Items.Count > 0 && aCDebitCreditRuleEntity.DebitCreditActionID != null)
                {
                    ddlDebitCreditActionID.SelectedValue = aCDebitCreditRuleEntity.DebitCreditActionID.ToString();
                }

                chkIsUp.Checked = aCDebitCreditRuleEntity.IsUp;
                chkIsDown.Checked = aCDebitCreditRuleEntity.IsDown;
                if (ddlMDDebitCreditID.Items.Count > 0 && aCDebitCreditRuleEntity.MDDebitCreditID != null)
                {
                    ddlMDDebitCreditID.SelectedValue = aCDebitCreditRuleEntity.MDDebitCreditID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACDebitCreditRuleList();
        }

        private void BindACDebitCreditRuleList()
        {
            lvACDebitCreditRule.DataBind();
        }

        private ACDebitCreditRuleEntity BuildACDebitCreditRuleEntity()
        {
            ACDebitCreditRuleEntity aCDebitCreditRuleEntity = CurrentACDebitCreditRuleEntity;

            if (ddlDebitCreditActionID.Items.Count > 0)
            {
                if (ddlDebitCreditActionID.SelectedValue == "0")
                {
                }
                else
                {
                    aCDebitCreditRuleEntity.DebitCreditActionID = Int64.Parse(ddlDebitCreditActionID.SelectedValue);
                }
            }

            aCDebitCreditRuleEntity.IsUp = chkIsUp.Checked;

            aCDebitCreditRuleEntity.IsDown = chkIsDown.Checked;

            if (ddlMDDebitCreditID.Items.Count > 0)
            {
                if (ddlMDDebitCreditID.SelectedValue == "0")
                {
                }
                else
                {
                    aCDebitCreditRuleEntity.MDDebitCreditID = Int64.Parse(ddlMDDebitCreditID.SelectedValue);
                }
            }


            return aCDebitCreditRuleEntity;
        }

        private void SaveACDebitCreditRuleEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACDebitCreditRuleEntity aCDebitCreditRuleEntity = BuildACDebitCreditRuleEntity();

                    Int64 result = -1;

                    if (aCDebitCreditRuleEntity.IsNew)
                    {
                        result = FCCACDebitCreditRule.GetFacadeCreate().Add(aCDebitCreditRuleEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACDebitCreditRuleEntity.FLD_NAME_ACDebitCreditRuleID, aCDebitCreditRuleEntity.ACDebitCreditRuleID.ToString(), SQLMatchType.Equal);
                        result = FCCACDebitCreditRule.GetFacadeCreate().Update(aCDebitCreditRuleEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ACDebitCreditRuleID = 0;
                        _ACDebitCreditRuleEntity = new ACDebitCreditRuleEntity();
                        PrepareInitialView();
                        BindACDebitCreditRuleList();

                        if (aCDebitCreditRuleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit Rule Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit Rule Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCDebitCreditRuleEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CDebit Credit Rule Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CDebit Credit Rule Information.", false);
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

        protected void lvACDebitCreditRule_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ACDebitCreditRuleID;

            Int64.TryParse(e.CommandArgument.ToString(), out ACDebitCreditRuleID);

            if (ACDebitCreditRuleID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ACDebitCreditRuleID = ACDebitCreditRuleID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACDebitCreditRuleEntity.FLD_NAME_ACDebitCreditRuleID, ACDebitCreditRuleID.ToString(), SQLMatchType.Equal);

                        ACDebitCreditRuleEntity aCDebitCreditRuleEntity = new ACDebitCreditRuleEntity();


                        result = FCCACDebitCreditRule.GetFacadeCreate().Delete(aCDebitCreditRuleEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ACDebitCreditRuleID = 0;
                            _ACDebitCreditRuleEntity = new ACDebitCreditRuleEntity();
                            PrepareInitialView();
                            BindACDebitCreditRuleList();

                            MiscUtil.ShowMessage(lblMessage, "A CDebit Credit Rule has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CDebit Credit Rule.", true);
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

        protected void odsACDebitCreditRule_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACDebitCreditRuleEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ACDebitCreditRuleID = 0;
            _ACDebitCreditRuleEntity = new ACDebitCreditRuleEntity();
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
