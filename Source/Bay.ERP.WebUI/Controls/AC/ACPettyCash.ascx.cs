// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




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
    public partial class ACPettyCashControl : BaseControl
    {       
        #region Properties

        public Int64 _ACPettyCashID
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

        public ACPettyCashEntity _ACPettyCashEntity
        {
            get
            {
                ACPettyCashEntity entity = new ACPettyCashEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (ACPettyCashEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private ACPettyCashEntity CurrentACPettyCashEntity
        {
            get
            {
                if (_ACPettyCashID > 0)
                {
                    if (_ACPettyCashEntity.ACPettyCashID != _ACPettyCashID)
                    {
                        _ACPettyCashEntity = FCCACPettyCash.GetFacadeCreate().GetByID(_ACPettyCashID);
                    }
                }

                return _ACPettyCashEntity;
            }
            set
            {
                _ACPettyCashEntity = value;
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

            txtCurrentBalance.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            ACPettyCashEntity aCPettyCashEntity = CurrentACPettyCashEntity;


            if (!aCPettyCashEntity.IsNew)
            {
                txtCurrentBalance.Text = aCPettyCashEntity.CurrentBalance.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindACPettyCashList();
        }

        private void BindACPettyCashList()
        {
            lvACPettyCash.DataBind();
        }

        private ACPettyCashEntity BuildACPettyCashEntity()
        {
            ACPettyCashEntity aCPettyCashEntity = CurrentACPettyCashEntity;

            if (!txtCurrentBalance.Text.Trim().IsNullOrEmpty())
            {
                aCPettyCashEntity.CurrentBalance = Decimal.Parse(txtCurrentBalance.Text.Trim());
            }


            return aCPettyCashEntity;
        }

        private void SaveACPettyCashEntity()
        {
            if (IsValid)
            {
                try
                {
                    ACPettyCashEntity aCPettyCashEntity = BuildACPettyCashEntity();

                    Int64 result = -1;

                    if (aCPettyCashEntity.IsNew)
                    {
                        result = FCCACPettyCash.GetFacadeCreate().Add(aCPettyCashEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ACPettyCashEntity.FLD_NAME_ACPettyCashID, aCPettyCashEntity.ACPettyCashID.ToString(), SQLMatchType.Equal);
                        result = FCCACPettyCash.GetFacadeCreate().Update(aCPettyCashEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ACPettyCashID = 0;
                        _ACPettyCashEntity = new ACPettyCashEntity();
                        PrepareInitialView();
                        BindACPettyCashList();

                        if (aCPettyCashEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CPetty Cash Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A CPetty Cash Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aCPettyCashEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A CPetty Cash Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A CPetty Cash Information.", false);
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

        protected void lvACPettyCash_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 ACPettyCashID;

            Int64.TryParse(e.CommandArgument.ToString(), out ACPettyCashID);

            if (ACPettyCashID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _ACPettyCashID = ACPettyCashID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACPettyCashEntity.FLD_NAME_ACPettyCashID, ACPettyCashID.ToString(), SQLMatchType.Equal);

                        ACPettyCashEntity aCPettyCashEntity = new ACPettyCashEntity();


                        result = FCCACPettyCash.GetFacadeCreate().Delete(aCPettyCashEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _ACPettyCashID = 0;
                            _ACPettyCashEntity = new ACPettyCashEntity();
                            PrepareInitialView();
                            BindACPettyCashList();

                            MiscUtil.ShowMessage(lblMessage, "A CPetty Cash has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A CPetty Cash.", true);
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

        protected void odsACPettyCash_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveACPettyCashEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ACPettyCashID = 0;
            _ACPettyCashEntity = new ACPettyCashEntity();
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
