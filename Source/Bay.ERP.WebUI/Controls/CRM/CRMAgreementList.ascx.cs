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
using System.Web.UI.HtmlControls;
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class CRMAgreementListControl : BaseControl
    {       
        #region Properties

        public Int64 _AgreementID
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

        public CRMAgreementEntity _CRMAgreementEntity
        {
            get
            {
                CRMAgreementEntity entity = new CRMAgreementEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CRMAgreementEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CRMAgreementEntity CurrentCRMAgreementEntity
        {
            get
            {
                if (_AgreementID > 0)
                {
                    if (_CRMAgreementEntity.AgreementID != _AgreementID)
                    {
                        _CRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(_AgreementID);
                    }
                }

                return _CRMAgreementEntity;
            }
            set
            {
                _CRMAgreementEntity = value;
            }
        }

        public Int64 CurrentemployeeID
        {
            get
            {
                Int64 _employeeID = 0;

                if (ViewState["currentEmployeeID"] != null)
                {
                    Int64.TryParse(ViewState["currentEmployeeID"].ToString(), out _employeeID);
                }

                if (ViewState["currentEmployeeID"] == null)
                {
                    ViewState["currentEmployeeID"] = MiscUtil.GetCurrentEmployeeByMemberID(CurrentMember);
                    _employeeID = (Int64)ViewState["currentEmployeeID"];
                }

                return _employeeID;
            }
            set
            {
                ViewState["currentEmployeeID"] = value;
            }
        }

        public String Action
        {
            get
            {
                String action = "None";

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
        }

        private void PrepareEditView()
        {
            CRMAgreementEntity cRMAgreementEntity = CurrentCRMAgreementEntity;


            if (!cRMAgreementEntity.IsNew)
            {
              
            }
        }

        private void BindList()
        {
            BindCRMAgreementList();
        }

        private void BindCRMAgreementList()
        {
            lvCRMAgreement.DataBind();
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

        protected void lvCRMAgreement_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 AgreementID;

            Int64.TryParse(e.CommandArgument.ToString(), out AgreementID);

            if (AgreementID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _AgreementID = AgreementID;
                    //PrepareEditView();

                    String navUrl=UrlHelper.BuildSecureUrl("~/CRM/CRMAgreement.aspx", String.Empty, UrlConstants.OVERVIEW_AGREEMENT_ID, AgreementID.ToString()).ToString();
                    Response.Redirect(navUrl);

                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        CRMAgreementEntity cRMAgreementEntity = FCCCRMAgreement.GetFacadeCreate().GetByID(AgreementID);

                        if (cRMAgreementEntity.AgreementApprovalStatusID == MasterDataConstants.CRMMDAgreementApprovalStatus.INITIATED)
                        {

                            Int64 result = -1;

                            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementEntity.FLD_NAME_AgreementID, AgreementID.ToString(), SQLMatchType.Equal);

                            result = FCCCRMAgreement.GetFacadeCreate().Delete(cRMAgreementEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                            if (result == 0)
                            {
                                _AgreementID = 0;
                                _CRMAgreementEntity = new CRMAgreementEntity();
                                PrepareInitialView();
                                BindCRMAgreementList();

                                MiscUtil.ShowMessage(lblMessage, "Agreement Successfully deleted.", true);
                            }
                            else
                            {
                                MiscUtil.ShowMessage(lblMessage, "Failed to delete Agreement.", true);
                            }
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Can't be deleted expect 'Initiated' Status.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        protected void lvCRMAgreement_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                CRMAgreement_DetailedEntity ent = (CRMAgreement_DetailedEntity)dataItem.DataItem;
                
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");
                HyperLink hypAgreementVariableMap = (HyperLink)e.Item.FindControl("hypAgreementVariableMap");
                HyperLink hypAgreementReport = (HyperLink)e.Item.FindControl("hypAgreementReport");
                

                hypAgreementVariableMap.NavigateUrl = UrlHelper.BuildSecureUrl(
                               "~/CRM/CRMAgreementVariableMap.aspx",
                               string.Empty,
                               UrlConstants.OVERVIEW_AGREEMENT_ID,
                               ent.AgreementID.ToString()
                               ).ToString();

                hypAgreementVariableMap.Target = "_blank";

                if (ent.AgreementTypeID == MasterDataConstants.CRMMDAgreementType.SPECS)
                {
                    HyperLink hypAgreementSpec = (HyperLink)e.Item.FindControl("hypAgreementSpec");
                    hypAgreementSpec.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMAgreementSpecs.aspx", String.Empty, UrlConstants.OVERVIEW_AGREEMENT_ID, ent.AgreementID.ToString()).ToString();
                    hypAgreementSpec.Target = "_blank";
                    hypAgreementSpec.Visible = true;
                }

                hypAgreementReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.AGREEMENT_REPORT, UrlConstants.OVERVIEW_AGREEMENT_ID, ent.AgreementID.ToString()).ToString();
                hypAgreementReport.Target = "_blank";

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.AGREEMENT, ent.AgreementID);

                if (aPApprovalProcessEntity.APApprovalProcessID > 0)
                {
                    lnkShowApprovalStatus.NavigateUrl = UrlHelper.BuildSecureUrl(
                               "~/AP/APView.aspx",
                               string.Empty,
                               APApprovalProcessEntity.FLD_NAME_APApprovalProcessID,
                               aPApprovalProcessEntity.APApprovalProcessID.ToString()
                               ).ToString();

                    lnkShowApprovalStatus.Target = "_blank";
                }
                else
                {
                    lnkShowApprovalStatus.NavigateUrl = String.Empty;
                    lnkShowApprovalStatus.Enabled = false;
                }
             
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsCRMAgreement_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CRMAgreement." + CRMAgreementEntity.FLD_NAME_CreatedByEmployeeID, CurrentemployeeID.ToString(), SQLMatchType.Equal);

            if (chbxFilter.Checked)
            {

                String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProject.ProjectName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression("BDProjectFloorUnit.ProjectFloorUnitName", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe4 = SqlExpressionBuilder.PrepareFilterExpression("CRMMDAgreementType.Name", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                String fe3 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
                String fe5 = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.OR, fe4);
                fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe5);
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Button Event

        #endregion

        #region CheckBox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindList();
        }

        #endregion

        #endregion Event
    }
}
