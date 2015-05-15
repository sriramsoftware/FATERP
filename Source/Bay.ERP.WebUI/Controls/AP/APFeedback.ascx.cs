// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
    public partial class APFeedbackControl : BaseControl
    {       
        #region Properties

        public Int64 _APFeedbackID
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

        public APFeedbackEntity _APFeedbackEntity
        {
            get
            {
                APFeedbackEntity entity = new APFeedbackEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APFeedbackEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APFeedbackEntity CurrentAPFeedbackEntity
        {
            get
            {
                if (_APFeedbackID > 0)
                {
                    if (_APFeedbackEntity.APFeedbackID != _APFeedbackID)
                    {
                        _APFeedbackEntity = FCCAPFeedback.GetFacadeCreate().GetByID(_APFeedbackID);
                    }
                }

                return _APFeedbackEntity;
            }
            set
            {
                _APFeedbackEntity = value;
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
            APFeedbackEntity aPFeedbackEntity = CurrentAPFeedbackEntity;


            if (!aPFeedbackEntity.IsNew)
            {
                txtName.Text = aPFeedbackEntity.Name.ToString();
                txtDescription.Text = aPFeedbackEntity.Description.ToString();
                chkIsRemoved.Checked = aPFeedbackEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPFeedbackList();
        }

        private void BindAPFeedbackList()
        {
            lvAPFeedback.DataBind();
        }

        private APFeedbackEntity BuildAPFeedbackEntity()
        {
            APFeedbackEntity aPFeedbackEntity = CurrentAPFeedbackEntity;

            aPFeedbackEntity.Name = txtName.Text.Trim();
            aPFeedbackEntity.Description = txtDescription.Text.Trim();
            aPFeedbackEntity.IsRemoved = chkIsRemoved.Checked;


            return aPFeedbackEntity;
        }

        private void SaveAPFeedbackEntity()
        {
            if (IsValid)
            {
                try
                {
                    APFeedbackEntity aPFeedbackEntity = BuildAPFeedbackEntity();

                    Int64 result = -1;

                    if (aPFeedbackEntity.IsNew)
                    {
                        result = FCCAPFeedback.GetFacadeCreate().Add(aPFeedbackEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APFeedbackEntity.FLD_NAME_APFeedbackID, aPFeedbackEntity.APFeedbackID.ToString(), SQLMatchType.Equal);
                        result = FCCAPFeedback.GetFacadeCreate().Update(aPFeedbackEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APFeedbackID = 0;
                        _APFeedbackEntity = new APFeedbackEntity();
                        PrepareInitialView();
                        BindAPFeedbackList();

                        if (aPFeedbackEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PFeedback Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PFeedback Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPFeedbackEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A PFeedback Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A PFeedback Information.", false);
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

        protected void lvAPFeedback_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APFeedbackID;

            Int64.TryParse(e.CommandArgument.ToString(), out APFeedbackID);

            if (APFeedbackID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APFeedbackID = APFeedbackID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APFeedbackEntity.FLD_NAME_APFeedbackID, APFeedbackID.ToString(), SQLMatchType.Equal);

                        APFeedbackEntity aPFeedbackEntity = new APFeedbackEntity();


                        result = FCCAPFeedback.GetFacadeCreate().Delete(aPFeedbackEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APFeedbackID = 0;
                            _APFeedbackEntity = new APFeedbackEntity();
                            PrepareInitialView();
                            BindAPFeedbackList();

                            MiscUtil.ShowMessage(lblMessage, "A PFeedback has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A PFeedback.", true);
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

        protected void odsAPFeedback_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPFeedbackEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APFeedbackID = 0;
            _APFeedbackEntity = new APFeedbackEntity();
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
