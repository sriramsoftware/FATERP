// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    public partial class CRMMDAgreementApprovalStatusControl : BaseControl
    {       
        #region Properties

        public Int64 _AgreementApprovalStatusID
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

        public CRMMDAgreementApprovalStatusEntity _CRMMDAgreementApprovalStatusEntity
        {
            get
            {
                CRMMDAgreementApprovalStatusEntity entity = new CRMMDAgreementApprovalStatusEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMMDAgreementApprovalStatusEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMMDAgreementApprovalStatusEntity CurrentCRMMDAgreementApprovalStatusEntity
        {
            get
            {
                if (_AgreementApprovalStatusID > 0)
                {
                    if (_CRMMDAgreementApprovalStatusEntity.AgreementApprovalStatusID != _AgreementApprovalStatusID)
                    {
                        _CRMMDAgreementApprovalStatusEntity = FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().GetByID(_AgreementApprovalStatusID);
                    }
                }

                return _CRMMDAgreementApprovalStatusEntity;
            }
            set
            {
                _CRMMDAgreementApprovalStatusEntity = value;
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
            CRMMDAgreementApprovalStatusEntity cRMMDAgreementApprovalStatusEntity = CurrentCRMMDAgreementApprovalStatusEntity;


            if (!cRMMDAgreementApprovalStatusEntity.IsNew)
            {
                txtName.Text = cRMMDAgreementApprovalStatusEntity.Name.ToString();
                txtDescription.Text = cRMMDAgreementApprovalStatusEntity.Description.ToString();
                chkIsRemoved.Checked = cRMMDAgreementApprovalStatusEntity.IsRemoved;

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCRMMDAgreementApprovalStatusList();
        }

        private void BindCRMMDAgreementApprovalStatusList()
        {
            lvCRMMDAgreementApprovalStatus.DataBind();
        }

        private CRMMDAgreementApprovalStatusEntity BuildCRMMDAgreementApprovalStatusEntity()
        {
            CRMMDAgreementApprovalStatusEntity cRMMDAgreementApprovalStatusEntity = CurrentCRMMDAgreementApprovalStatusEntity;

            cRMMDAgreementApprovalStatusEntity.Name = txtName.Text.Trim();
            cRMMDAgreementApprovalStatusEntity.Description = txtDescription.Text.Trim();
            cRMMDAgreementApprovalStatusEntity.IsRemoved = chkIsRemoved.Checked;


            return cRMMDAgreementApprovalStatusEntity;
        }

        private void SaveCRMMDAgreementApprovalStatusEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMMDAgreementApprovalStatusEntity cRMMDAgreementApprovalStatusEntity = BuildCRMMDAgreementApprovalStatusEntity();

                    Int64 result = -1;

                    if (cRMMDAgreementApprovalStatusEntity.IsNew)
                    {
                        result = FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().Add(cRMMDAgreementApprovalStatusEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementApprovalStatusEntity.FLD_NAME_AgreementApprovalStatusID, cRMMDAgreementApprovalStatusEntity.AgreementApprovalStatusID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().Update(cRMMDAgreementApprovalStatusEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _AgreementApprovalStatusID = 0;
                        _CRMMDAgreementApprovalStatusEntity = new CRMMDAgreementApprovalStatusEntity();
                        PrepareInitialView();
                        BindCRMMDAgreementApprovalStatusList();

                        if (cRMMDAgreementApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Approval Status Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Approval Status Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMMDAgreementApprovalStatusEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C RMAgreement Approval Status Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C RMAgreement Approval Status Information.", false);
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

        protected void lvCRMMDAgreementApprovalStatus_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementApprovalStatusID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementApprovalStatusID);

            if (AgreementApprovalStatusID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementApprovalStatusID = AgreementApprovalStatusID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMMDAgreementApprovalStatusEntity.FLD_NAME_AgreementApprovalStatusID, AgreementApprovalStatusID.ToString(), SQLMatchType.Equal);

                        CRMMDAgreementApprovalStatusEntity cRMMDAgreementApprovalStatusEntity = new CRMMDAgreementApprovalStatusEntity();


                        result = FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().Delete(cRMMDAgreementApprovalStatusEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementApprovalStatusID = 0;
                            _CRMMDAgreementApprovalStatusEntity = new CRMMDAgreementApprovalStatusEntity();
                            PrepareInitialView();
                            BindCRMMDAgreementApprovalStatusList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement Approval Status has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAgreement Approval Status.", true);
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

        protected void odsCRMMDAgreementApprovalStatus_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCRMMDAgreementApprovalStatusEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _AgreementApprovalStatusID = 0;
            _CRMMDAgreementApprovalStatusEntity = new CRMMDAgreementApprovalStatusEntity();
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
