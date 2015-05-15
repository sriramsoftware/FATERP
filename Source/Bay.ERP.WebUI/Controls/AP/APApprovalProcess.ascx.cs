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
    public partial class APApprovalProcessControl : BaseControl
    {       
        #region Properties

        public Int64 _APApprovalProcessID
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

        public APApprovalProcessEntity _APApprovalProcessEntity
        {
            get
            {
                APApprovalProcessEntity entity = new APApprovalProcessEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (APApprovalProcessEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private APApprovalProcessEntity CurrentAPApprovalProcessEntity
        {
            get
            {
                if (_APApprovalProcessID > 0)
                {
                    if (_APApprovalProcessEntity.APApprovalProcessID != _APApprovalProcessID)
                    {
                        _APApprovalProcessEntity = FCCAPApprovalProcess.GetFacadeCreate().GetByID(_APApprovalProcessID);
                    }
                }

                return _APApprovalProcessEntity;
            }
            set
            {
                _APApprovalProcessEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateAPType(ddlAPTypeID, false);
            MiscUtil.PopulateAPStatus(ddlAPStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtReferenceID.Text = String.Empty;
            txtDescription.Text = String.Empty;
            txtTitle.Text = String.Empty;
            txtCreateDate.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = CurrentAPApprovalProcessEntity;


            if (!aPApprovalProcessEntity.IsNew)
            {
                if (ddlAPTypeID.Items.Count > 0 && aPApprovalProcessEntity.APTypeID != null)
                {
                    ddlAPTypeID.SelectedValue = aPApprovalProcessEntity.APTypeID.ToString();
                }

                txtReferenceID.Text = aPApprovalProcessEntity.ReferenceID.ToString();
                txtDescription.Text = aPApprovalProcessEntity.Description.ToString();
                txtTitle.Text = aPApprovalProcessEntity.Title.ToString();
                txtCreateDate.Text = aPApprovalProcessEntity.CreateDate.ToStringDefault();
                if (ddlAPStatusID.Items.Count > 0 && aPApprovalProcessEntity.APStatusID != null)
                {
                    ddlAPStatusID.SelectedValue = aPApprovalProcessEntity.APStatusID.ToString();
                }


                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindAPApprovalProcessList();
        }

        private void BindAPApprovalProcessList()
        {
            lvAPApprovalProcess.DataBind();
        }

        private APApprovalProcessEntity BuildAPApprovalProcessEntity()
        {
            APApprovalProcessEntity aPApprovalProcessEntity = CurrentAPApprovalProcessEntity;

            if (ddlAPTypeID.Items.Count > 0)
            {
                if (ddlAPTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    aPApprovalProcessEntity.APTypeID = Int64.Parse(ddlAPTypeID.SelectedValue);
                }
            }

            if (!txtReferenceID.Text.Trim().IsNullOrEmpty())
            {
                aPApprovalProcessEntity.ReferenceID = Int64.Parse(txtReferenceID.Text.Trim());
            }
            else
            {
                aPApprovalProcessEntity.ReferenceID = null;
            }

            aPApprovalProcessEntity.Description = txtDescription.Text.Trim();
            aPApprovalProcessEntity.Title = txtTitle.Text.Trim();
            if (txtCreateDate.Text.Trim().IsNotNullOrEmpty())
            {
                aPApprovalProcessEntity.CreateDate = MiscUtil.ParseToDateTime(txtCreateDate.Text);
            }

            if (ddlAPStatusID.Items.Count > 0)
            {
                if (ddlAPStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    aPApprovalProcessEntity.APStatusID = Int64.Parse(ddlAPStatusID.SelectedValue);
                }
            }


            return aPApprovalProcessEntity;
        }

        private void SaveAPApprovalProcessEntity()
        {
            if (IsValid)
            {
                try
                {
                    APApprovalProcessEntity aPApprovalProcessEntity = BuildAPApprovalProcessEntity();

                    Int64 result = -1;

                    if (aPApprovalProcessEntity.IsNew)
                    {
                        result = FCCAPApprovalProcess.GetFacadeCreate().Add(aPApprovalProcessEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APApprovalProcessID, aPApprovalProcessEntity.APApprovalProcessID.ToString(), SQLMatchType.Equal);
                        result = FCCAPApprovalProcess.GetFacadeCreate().Update(aPApprovalProcessEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _APApprovalProcessID = 0;
                        _APApprovalProcessEntity = new APApprovalProcessEntity();
                        PrepareInitialView();
                        BindAPApprovalProcessList();

                        if (aPApprovalProcessEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PApproval Process Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "A PApproval Process Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (aPApprovalProcessEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add A PApproval Process Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update A PApproval Process Information.", false);
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

        protected void lvAPApprovalProcess_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 APApprovalProcessID;

            Int64.TryParse(e.CommandArgument.ToString(), out APApprovalProcessID);

            if (APApprovalProcessID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _APApprovalProcessID = APApprovalProcessID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(APApprovalProcessEntity.FLD_NAME_APApprovalProcessID, APApprovalProcessID.ToString(), SQLMatchType.Equal);

                        APApprovalProcessEntity aPApprovalProcessEntity = new APApprovalProcessEntity();


                        result = FCCAPApprovalProcess.GetFacadeCreate().Delete(aPApprovalProcessEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _APApprovalProcessID = 0;
                            _APApprovalProcessEntity = new APApprovalProcessEntity();
                            PrepareInitialView();
                            BindAPApprovalProcessList();

                            MiscUtil.ShowMessage(lblMessage, "A PApproval Process has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete A PApproval Process.", true);
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

        protected void odsAPApprovalProcess_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveAPApprovalProcessEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _APApprovalProcessID = 0;
            _APApprovalProcessEntity = new APApprovalProcessEntity();
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
