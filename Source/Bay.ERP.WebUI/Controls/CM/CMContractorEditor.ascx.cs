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
    public partial class CMContractorEditorControl : ContractorBaseControl
    {       
        #region Properties

        public Int64 _ContractorID
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

        public CMContractorEntity _CMContractorEntity
        {
            get
            {
                CMContractorEntity entity = new CMContractorEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMContractorEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMContractorEntity CurrentCMContractorEntity
        {
            get
            {
                if (this.OverviewContractorID > 0)
                {
                        _CMContractorEntity = FCCCMContractor.GetFacadeCreate().GetByID(this.OverviewContractorID);
                }

                return _CMContractorEntity;
            }
            set
            {
                _CMContractorEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHRMember(ddlMemberID, false);
            MiscUtil.PopulateHRMember(ddlPreparedBy, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtNameOfWork.Text = String.Empty;
            txtDate.Text = String.Empty;
            txtName.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
           
        }

        private void PrepareEditView()
        {
            CMContractorEntity cMContractorEntity = CurrentCMContractorEntity;


            if (!cMContractorEntity.IsNew)
            {
                if (ddlMemberID.Items.Count > 0 && cMContractorEntity.MemberID != null)
                {
                    ddlMemberID.SelectedValue = cMContractorEntity.MemberID.ToString();
                }

                txtNameOfWork.Text = cMContractorEntity.NameOfWork.ToString();
                txtDate.Text = cMContractorEntity.Date.ToStringDefault();
                txtName.Text = cMContractorEntity.Name.ToString();
                if (ddlPreparedBy.Items.Count > 0 && cMContractorEntity.PreparedBy != null)
                {
                    ddlPreparedBy.SelectedValue = cMContractorEntity.PreparedBy.ToString();
                }

                chkIsRemoved.Checked = cMContractorEntity.IsRemoved;

                btnSubmit.Text = "Update";
               
            }
        }

       
        private CMContractorEntity BuildCMContractorEntity()
        {
            CMContractorEntity cMContractorEntity = CurrentCMContractorEntity;

            if (ddlMemberID.Items.Count > 0)
            {
                if (ddlMemberID.SelectedValue == "0")
                {
                }
                else
                {
                    cMContractorEntity.MemberID = Int64.Parse(ddlMemberID.SelectedValue);
                }
            }

            cMContractorEntity.NameOfWork = txtNameOfWork.Text.Trim();
            if (txtDate.Text.Trim().IsNotNullOrEmpty())
            {
                cMContractorEntity.Date = MiscUtil.ParseToDateTime(txtDate.Text);
            }

            cMContractorEntity.Name = txtName.Text.Trim();
            if (ddlPreparedBy.Items.Count > 0)
            {
                if (ddlPreparedBy.SelectedValue == "0")
                {
                }
                else
                {
                    cMContractorEntity.PreparedBy = Int64.Parse(ddlPreparedBy.SelectedValue);
                }
            }

            cMContractorEntity.IsRemoved = chkIsRemoved.Checked;


            return cMContractorEntity;
        }

        private void SaveCMContractorEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMContractorEntity cMContractorEntity = BuildCMContractorEntity();

                    Int64 result = -1;

                    if (cMContractorEntity.IsNew)
                    {
                        result = FCCCMContractor.GetFacadeCreate().Add(cMContractorEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMContractorEntity.FLD_NAME_ContractorID, cMContractorEntity.ContractorID.ToString(), SQLMatchType.Equal);
                        result = FCCCMContractor.GetFacadeCreate().Update(cMContractorEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _ContractorID = 0;
                        _CMContractorEntity = new CMContractorEntity();
                        PrepareInitialView();
                       
                        if (cMContractorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Contractor Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMContractorEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add C MContractor Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update C MContractor Information.", false);
                        }
                    }
                    PrepareEditView();
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMContractorEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _ContractorID = 0;
            _CMContractorEntity = new CMContractorEntity();
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
