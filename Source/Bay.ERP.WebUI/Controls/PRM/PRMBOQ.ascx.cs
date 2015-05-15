// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public partial class PRMBOQControl : ProjectBaseControl
    {       
        #region Properties

        public PRMBOQEntity _PRMBOQEntity
        {
            get
            {
                PRMBOQEntity entity = new PRMBOQEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMBOQEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMBOQEntity CurrentPRMBOQEntity
        {
            get
            {
                if (this.OverviewProjectID > 0)
                {
                    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_ProjectID, this.OverviewProjectID.ToString(), SQLMatchType.Equal);

                    IList<PRMBOQEntity> tempList = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                    if (tempList != null && tempList.Count > 0)
                    {
                        _PRMBOQEntity = tempList[0];
                    }
                    else
                    {
                        _PRMBOQEntity = new PRMBOQEntity();
                    }
                }

                return _PRMBOQEntity;
            }
            set
            {
                _PRMBOQEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateHRMember(ddlPreparedByMemberID, false);

            if (ddlPreparedByMemberID != null && ddlPreparedByMemberID.Items.Count > 0)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, this.CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
                IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lstEmployee != null && lstEmployee.Count > 0)
                {
                    ddlPreparedByMemberID.SelectedValue = lstEmployee[0].MemberID.ToString();
                }
            }

            MiscUtil.PopulateMDBOQStatus(ddlBOQStatusID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtStartDate.Text = String.Empty;
            txtRemarks.Text = String.Empty;

            btnSubmit.Text = "Add";
        }

        private void FormLock()
        {
            Boolean isLocked = true;
            
            String fe= SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_ProjectID,this.OverviewProjectID.ToString(),SQLMatchType.Equal);
            IList<PRMBOQEntity> lstPRMBOQ=FCCPRMBOQ.GetFacadeCreate().GetIL(null,null,String.Empty,fe,DatabaseOperationType.LoadWithFilterExpression);

            if (lstPRMBOQ != null && lstPRMBOQ.Count > 0)
            {
                isLocked = false;
            }

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

        private void PrepareEditView()
        {
            PRMBOQEntity pRMBOQEntity = CurrentPRMBOQEntity;


            if (!pRMBOQEntity.IsNew)
            {
                txtStartDate.Text = pRMBOQEntity.StartDate.ToStringDefault();
                if (ddlPreparedByMemberID.Items.Count > 0 && pRMBOQEntity.PreparedByMemberID != null)
                {
                    ddlPreparedByMemberID.SelectedValue = pRMBOQEntity.PreparedByMemberID.ToString();
                }

                txtRemarks.Text = pRMBOQEntity.Remarks.ToString();
                if (ddlBOQStatusID.Items.Count > 0 && pRMBOQEntity.BOQStatusID != null)
                {
                    ddlBOQStatusID.SelectedValue = pRMBOQEntity.BOQStatusID.ToString();
                }

                btnSubmit.Text = "Update";
            }

            FormLock();
        }

        private PRMBOQEntity BuildPRMBOQEntity()
        {
            PRMBOQEntity pRMBOQEntity = CurrentPRMBOQEntity;

            if (txtStartDate.Text.Trim().IsNotNullOrEmpty())
            {
                pRMBOQEntity.StartDate = MiscUtil.ParseToDateTime(txtStartDate.Text);
            }
            else
            {
                pRMBOQEntity.StartDate = null;
            }

            if (ddlPreparedByMemberID.Items.Count > 0)
            {
                if (ddlPreparedByMemberID.SelectedValue == "0")
                {
                }
                else
                {
                    pRMBOQEntity.PreparedByMemberID = Int64.Parse(ddlPreparedByMemberID.SelectedValue);
                }
            }

            pRMBOQEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlBOQStatusID.Items.Count > 0)
            {
                if (ddlBOQStatusID.SelectedValue == "0")
                {
                    pRMBOQEntity.BOQStatusID = null;
                }
                else
                {
                    pRMBOQEntity.BOQStatusID = Int64.Parse(ddlBOQStatusID.SelectedValue);
                }
            }


            return pRMBOQEntity;
        }

        private void SavePRMBOQEntity()
        {
            if (IsValid)
            {
                try
                {
                    PRMBOQEntity pRMBOQEntity = BuildPRMBOQEntity();

                    Int64 result = -1;

                    if (pRMBOQEntity.IsNew)
                    {
                        result = FCCPRMBOQ.GetFacadeCreate().Add(pRMBOQEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_BOQID, pRMBOQEntity.BOQID.ToString(), SQLMatchType.Equal);
                        result = FCCPRMBOQ.GetFacadeCreate().Update(pRMBOQEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _PRMBOQEntity = new PRMBOQEntity();
                        PrepareInitialView();
                        PrepareEditView();

                        if (pRMBOQEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Cost Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Project Cost Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (pRMBOQEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Project Cost Information.", false);
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
            SavePRMBOQEntity();
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
