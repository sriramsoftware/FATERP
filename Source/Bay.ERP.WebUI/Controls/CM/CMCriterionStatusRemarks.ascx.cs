// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class CMCriterionStatusRemarksControl : ContractorBaseControl
    {       
        #region Properties

        public Int64 _CriterionStatusRemarksID
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

        public CMCriterionStatusRemarksEntity _CMCriterionStatusRemarksEntity
        {
            get
            {
                CMCriterionStatusRemarksEntity entity = new CMCriterionStatusRemarksEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMCriterionStatusRemarksEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMCriterionStatusRemarksEntity CurrentCMCriterionStatusRemarksEntity
        {
            get
            {
                if (_CriterionStatusRemarksID > 0)
                {
                    if (_CMCriterionStatusRemarksEntity.CriterionStatusRemarksID != _CriterionStatusRemarksID)
                    {
                        _CMCriterionStatusRemarksEntity = FCCCMCriterionStatusRemarks.GetFacadeCreate().GetByID(_CriterionStatusRemarksID);
                    }
                }

                return _CMCriterionStatusRemarksEntity;
            }
            set
            {
                _CMCriterionStatusRemarksEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateMDCriterionCategory(ddlReferenceCriterionCategoryID, false);
            MiscUtil.PopulateMDContractorCriterionStatus(ddlContractorCriterionStatusID, true);
            MiscUtil.PopulateHRMember(ddlMemberID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity = CurrentCMCriterionStatusRemarksEntity;


            if (!cMCriterionStatusRemarksEntity.IsNew)
            {

                if (ddlReferenceCriterionCategoryID.Items.Count > 0 && cMCriterionStatusRemarksEntity.ReferenceCriterionCategoryID != null)
                {
                    ddlReferenceCriterionCategoryID.SelectedValue = cMCriterionStatusRemarksEntity.ReferenceCriterionCategoryID.ToString();
                }

                if (ddlContractorCriterionStatusID.Items.Count > 0 && cMCriterionStatusRemarksEntity.ContractorCriterionStatusID != null)
                {
                    ddlContractorCriterionStatusID.SelectedValue = cMCriterionStatusRemarksEntity.ContractorCriterionStatusID.ToString();
                }

                if (ddlMemberID.Items.Count > 0 && cMCriterionStatusRemarksEntity.MemberID != null)
                {
                    ddlMemberID.SelectedValue = cMCriterionStatusRemarksEntity.MemberID.ToString();
                }

                txtRemarks.Text = cMCriterionStatusRemarksEntity.Remarks.ToString();

                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMCriterionStatusRemarksList();
        }

        private void BindCMCriterionStatusRemarksList()
        {
            lvCMCriterionStatusRemarks.DataBind();
        }

        private CMCriterionStatusRemarksEntity BuildCMCriterionStatusRemarksEntity()
        {
            CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity = CurrentCMCriterionStatusRemarksEntity;

            cMCriterionStatusRemarksEntity.ContractorID = this.OverviewContractorID;
           
            if (ddlReferenceCriterionCategoryID.Items.Count > 0)
            {
                if (ddlReferenceCriterionCategoryID.SelectedValue == "0")
                {
                }
                else
                {
                    cMCriterionStatusRemarksEntity.ReferenceCriterionCategoryID = Int64.Parse(ddlReferenceCriterionCategoryID.SelectedValue);
                }
            }

            if (ddlContractorCriterionStatusID.Items.Count > 0)
            {
                if (ddlContractorCriterionStatusID.SelectedValue == "0")
                {
                    cMCriterionStatusRemarksEntity.ContractorCriterionStatusID = null;
                }
                else
                {
                    cMCriterionStatusRemarksEntity.ContractorCriterionStatusID = Int64.Parse(ddlContractorCriterionStatusID.SelectedValue);
                }
            }

            if (ddlMemberID.Items.Count > 0)
            {
                if (ddlMemberID.SelectedValue == "0")
                {
                }
                else
                {
                    cMCriterionStatusRemarksEntity.MemberID = Int64.Parse(ddlMemberID.SelectedValue);
                }
            }

            cMCriterionStatusRemarksEntity.Remarks = txtRemarks.Text.Trim();

            return cMCriterionStatusRemarksEntity;
        }

        private void SaveCMCriterionStatusRemarksEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity = BuildCMCriterionStatusRemarksEntity();

                    Int64 result = -1;

                    if (cMCriterionStatusRemarksEntity.IsNew)
                    {
                        result = FCCCMCriterionStatusRemarks.GetFacadeCreate().Add(cMCriterionStatusRemarksEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMCriterionStatusRemarksEntity.FLD_NAME_CriterionStatusRemarksID, cMCriterionStatusRemarksEntity.CriterionStatusRemarksID.ToString(), SQLMatchType.Equal);
                        result = FCCCMCriterionStatusRemarks.GetFacadeCreate().Update(cMCriterionStatusRemarksEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _CriterionStatusRemarksID = 0;
                        _CMCriterionStatusRemarksEntity = new CMCriterionStatusRemarksEntity();
                        PrepareInitialView();
                        BindCMCriterionStatusRemarksList();

                        if (cMCriterionStatusRemarksEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Criterion Status Remarks Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Criterion Status Remarks Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMCriterionStatusRemarksEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Criterion Status Remarks Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Criterion Status Remarks Information.", false);
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

        protected void lvCMCriterionStatusRemarks_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 CriterionStatusRemarksID;

            Int64.TryParse(e.CommandArgument.ToString(), out CriterionStatusRemarksID);

            if (CriterionStatusRemarksID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _CriterionStatusRemarksID = CriterionStatusRemarksID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMCriterionStatusRemarksEntity.FLD_NAME_CriterionStatusRemarksID, CriterionStatusRemarksID.ToString(), SQLMatchType.Equal);

                        CMCriterionStatusRemarksEntity cMCriterionStatusRemarksEntity = new CMCriterionStatusRemarksEntity();


                        result = FCCCMCriterionStatusRemarks.GetFacadeCreate().Delete(cMCriterionStatusRemarksEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _CriterionStatusRemarksID = 0;
                            _CMCriterionStatusRemarksEntity = new CMCriterionStatusRemarksEntity();
                            PrepareInitialView();
                            BindCMCriterionStatusRemarksList();

                            MiscUtil.ShowMessage(lblMessage, "Criterion Status Remarks has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Criterion Status Remarks.", true);
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

        protected void odsCMCriterionStatusRemarks_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CMCriterionStatusRemarks." + CMCriterionStatusRemarks_DetailedEntity.FLD_NAME_ContractorID, this.OverviewContractorID.ToString(), SQLMatchType.Equal);
            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMCriterionStatusRemarksEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _CriterionStatusRemarksID = 0;
            _CMCriterionStatusRemarksEntity = new CMCriterionStatusRemarksEntity();
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
