// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Apr-2012, 09:57:10




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Data;

namespace Bay.ERP.Web.UI
{
    public partial class REQRequisitionCorporateControl : BaseControl
    {       
        #region Properties

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public Int64 _RequisitionID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.REQUISITION_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.REQUISITION_ID], out id);
                    ViewState["ID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public REQRequisitionEntity _REQRequisitionEntity
        {
            get
            {
                REQRequisitionEntity entity = new REQRequisitionEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (REQRequisitionEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private REQRequisitionEntity CurrentREQRequisitionEntity
        {
            get
            {
                if (_RequisitionID > 0)
                {
                    if (_REQRequisitionEntity.RequisitionID != _RequisitionID)
                    {
                        _REQRequisitionEntity = FCCREQRequisition.GetFacadeCreate().GetByID(_RequisitionID);
                    }
                }

                return _REQRequisitionEntity;
            }
            set
            {
                _REQRequisitionEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        { 
            MiscUtil.PopulateMDRequisitionStatus(ddlRequisitionStatusID, false);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            GetNextREQRequisitionNo();

            txtRequisitionDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtRemarks.Text = String.Empty;
            txtRequisitionNo.ToolTip = "Please Write Requisition Number; By Default It's Next Requisition No! e.g. 30000";
            txtRequisitionDate.ToolTip = "Please Select Requisition Date; By Default Today's Date Available! Format : DD-MM-YYYY";

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
        }

        private void PrepareEditView()
        {
            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;


            if (!rEQRequisitionEntity.IsNew)
            {
                txtRequisitionNo.Text = rEQRequisitionEntity.RequisitionNo.ToString();
                txtRequisitionDate.Text = rEQRequisitionEntity.RequisitionDate.ToStringDefault();
                txtRemarks.Text = rEQRequisitionEntity.Remarks.ToString();
                if (ddlRequisitionStatusID.Items.Count > 0 && rEQRequisitionEntity.RequisitionStatusID != null)
                {
                    ddlRequisitionStatusID.SelectedValue = rEQRequisitionEntity.RequisitionStatusID.ToString();
                }

                txtRequisitionNo.ToolTip = "Please Write Updated Requisiton No; By Default It's Current Requisiton No!";
                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private REQRequisitionEntity BuildREQRequisitionEntity()
        {
            REQRequisitionEntity rEQRequisitionEntity = CurrentREQRequisitionEntity;

            rEQRequisitionEntity.ProjectID = MasterDataConstants.Project.DEFAULT_PROJECT;

            rEQRequisitionEntity.RequisitionNo = txtRequisitionNo.Text.Trim();
            if (txtRequisitionDate.Text.Trim().IsNotNullOrEmpty())
            {
                rEQRequisitionEntity.RequisitionDate = MiscUtil.ParseToDateTime(txtRequisitionDate.Text);
            }

            rEQRequisitionEntity.Remarks = txtRemarks.Text.Trim();
            if (ddlRequisitionStatusID.Items.Count > 0)
            {
                if (ddlRequisitionStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    rEQRequisitionEntity.RequisitionStatusID = Int64.Parse(ddlRequisitionStatusID.SelectedValue);
                }
            }

            return rEQRequisitionEntity;
        }

        private void GetNextREQRequisitionNo()
        {   
                try
                {
                    #region Common_DA

                    //DataTable dt = FCCCommonDA_SP.GetFacadeCreate().GetDT(String.Empty, CommonConstants.NEXT_REQUSITION_NO);

                    //Int32 nextRequsitionNo= 999;

                    //if (dt.Rows.Count > 0)
                    //{
                    //    nextRequsitionNo = (Int32)dt.Rows[0]["MaxID"];
                    //}

                    //txtRequisitionNo.Text = nextRequsitionNo.ToString();

                    #endregion

                    IList<REQRequisitionEntity> requisitonList = FCCREQRequisition.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

                    Int64 x = (from c in requisitonList
                               select Convert.ToInt64(c.RequisitionNo)).Max() + 1;

                    txtRequisitionNo.Text = x.ToString();

                }

                catch (Exception ex)
                {
                    txtRequisitionNo.Text = "62500";
                }
        }

        private void SaveREQRequisitionEntity()
        {
            if (IsValid)
            {
                try
                {
                    REQRequisitionEntity rEQRequisitionEntity = BuildREQRequisitionEntity();

                    Int64 result = -1;

                    if (rEQRequisitionEntity.IsNew)
                    {
                        //Prepared By Employee ID changes only for performing Save Option; not for performing Update Option.
                        rEQRequisitionEntity.PreparedByMemberID = this.CurrentMember.MemberID;

                        result = FCCREQRequisition.GetFacadeCreate().Add(rEQRequisitionEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionID, rEQRequisitionEntity.RequisitionID.ToString(), SQLMatchType.Equal);
                        result = FCCREQRequisition.GetFacadeCreate().Update(rEQRequisitionEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _RequisitionID = 0;
                        _REQRequisitionEntity = new REQRequisitionEntity();

                        if (rEQRequisitionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Requisition Information has been added successfully.", false);
                            //String NavigationUrl = UrlHelper.BuildSecureUrl("~/REQ/REQRequisitionItem.aspx", string.Empty, REQRequisitionEntity.FLD_NAME_RequisitionID, result.ToString()).ToString();
                            //Response.Redirect(NavigationUrl);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Requisition Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (rEQRequisitionEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Requisition Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Requisition Information.", false);
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
            SaveREQRequisitionEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _RequisitionID = 0;
            _REQRequisitionEntity = new REQRequisitionEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        protected void btnGetRequisitionNo_Click(object sender, EventArgs e)
        {
            GetNextREQRequisitionNo();
        }

        #endregion

        #endregion Event
    }
}
