// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




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
    public partial class PRMPreBOQInfoControl : ProjectBaseControl
    {       
        #region Properties

        public PRMPreBOQEntity _PRMPreBOQEntity
        {
            get
            {
                PRMPreBOQEntity entity = new PRMPreBOQEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMPreBOQEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMPreBOQEntity CurrentPRMPreBOQEntity
        {
            get
            {
                if (this.OverviewProjectID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);

                    IList<PRMPreBOQEntity> tempList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (tempList != null && tempList.Count > 0)
                    {
                        _PRMPreBOQEntity = tempList[0];
                    }
                    else
                    {
                        _PRMPreBOQEntity = new PRMPreBOQEntity();
                    }
                }                

                return _PRMPreBOQEntity;
            }
            set
            {
                _PRMPreBOQEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHRMember(ddlPreparedByMemberID, false);

            if (ddlPreparedByMemberID != null && ddlPreparedByMemberID.Items.Count > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID,this.CurrentMember.MemberID.ToString(),SQLMatchType.Equal);
                IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lstEmployee != null && lstEmployee.Count > 0)
                {
                    ddlPreparedByMemberID.SelectedValue = lstEmployee[0].MemberID.ToString(); 
                }
            }

            MiscUtil.PopulateMDPreBOQStatus(ddlPreBOQStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtStartDate.Text = DateTime.Now.ToStringDefault();
            txtRemarks.Text = String.Empty;
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
        }

        private void PrepareEditView()
        {
            PRMPreBOQEntity pRMPreBOQEntity = CurrentPRMPreBOQEntity;

            if (!pRMPreBOQEntity.IsNew)
            {
                txtStartDate.Text = pRMPreBOQEntity.StartDate.ToString(UIConstants.SHORT_DATE_FORMAT);

                if (ddlPreparedByMemberID.Items.Count > 0 && pRMPreBOQEntity.PreparedByMemberID != null)
                {
                    ddlPreparedByMemberID.SelectedValue = pRMPreBOQEntity.PreparedByMemberID.ToString();
                }

                txtRemarks.Text = pRMPreBOQEntity.Remarks.ToString();

                if (ddlPreBOQStatusID.Items.Count > 0 && pRMPreBOQEntity.PreBOQStatusID != null)
                {
                    ddlPreBOQStatusID.SelectedValue = pRMPreBOQEntity.PreBOQStatusID.ToString();
                }

                chkIsRemoved.Checked = pRMPreBOQEntity.IsRemoved;

                btnSubmit.Text = "Update";
            }

            FormLock(pRMPreBOQEntity.IsLocked);
        }

        private void FormLock(Boolean isLocked)
        {
            #region Form Lock

            if (isLocked == true)
            {
                btnSubmit.Enabled = false;
                btnClear.Enabled = false;
                lblFormLock.Visible = true;
            }
            else
            {
                btnSubmit.Enabled = true;
                btnClear.Enabled = true;
                lblFormLock.Visible = false;
            }

            #endregion Form Lock
        }

        private PRMPreBOQEntity BuildPRMPreBOQEntity()
        {
            PRMPreBOQEntity pRMPreBOQEntity = CurrentPRMPreBOQEntity;

            pRMPreBOQEntity.ProjectID = this.OverviewProjectID;
            
            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMPreBOQEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }

            if (ddlPreparedByMemberID.Items.Count > 0)
            {
                if (ddlPreparedByMemberID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMPreBOQEntity.PreparedByMemberID = Int64.Parse(ddlPreparedByMemberID.SelectedValue);
                }
            }

            pRMPreBOQEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlPreBOQStatusID.Items.Count > 0)
            {
                if (ddlPreBOQStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMPreBOQEntity.PreBOQStatusID = Int64.Parse(ddlPreBOQStatusID.SelectedValue);
                }
            }

            pRMPreBOQEntity.IsRemoved = chkIsRemoved.Checked;
            pRMPreBOQEntity.IsLocked = false;
            

            return pRMPreBOQEntity;
        }

        private void SavePRMPreBOQEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMPreBOQEntity pRMPreBOQEntity = BuildPRMPreBOQEntity();

                    Int64 result = -1;

                    if (pRMPreBOQEntity.IsNew)
                    {
                        result = FCCPRMPreBOQ.GetFacadeCreate().Add(pRMPreBOQEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_PreBOQID, pRMPreBOQEntity.PreBOQID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMPreBOQ.GetFacadeCreate().Update(pRMPreBOQEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        PrepareInitialView();
                        PrepareEditView();

                        if (pRMPreBOQEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "BOQ Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "BOQ Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMPreBOQEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add BOQ Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update BOQ Information.", false);
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

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SavePRMPreBOQEntity();
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
