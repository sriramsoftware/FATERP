// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
using Bay.ERP.Web.UI.Manager;

namespace Bay.ERP.Web.UI
{
    public partial class PRMMaterialReceiveListControl : BaseControl
    {       
        #region Properties

        public Int64 _MaterialReceiveID
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

        public PRMMaterialReceiveEntity _PRMMaterialReceiveEntity
        {
            get
            {
                PRMMaterialReceiveEntity entity = new PRMMaterialReceiveEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (PRMMaterialReceiveEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private PRMMaterialReceiveEntity CurrentPRMMaterialReceiveEntity
        {
            get
            {
                if (_MaterialReceiveID > 0)
                {
                    if (_PRMMaterialReceiveEntity.MaterialReceiveID != _MaterialReceiveID)
                    {
                        _PRMMaterialReceiveEntity = FCCPRMMaterialReceive.GetFacadeCreate().GetByID(_MaterialReceiveID);
                    }
                }

                return _PRMMaterialReceiveEntity;
            }
            set
            {
                _PRMMaterialReceiveEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateBDProject(ddlProjectID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
        }

        private void BindList()
        {
            BindPRMMaterialReceiveList();
        }

        private void BindPRMMaterialReceiveList()
        {
            lvPRMMaterialReceive.DataBind();
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
            }
        }

        #endregion

        #region List View Event

        protected void lvPRMMaterialReceive_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                ListViewDataItem dataItem = (ListViewDataItem)e.Item;

                PRMMaterialReceive_DetailedEntity ent = (PRMMaterialReceive_DetailedEntity)dataItem.DataItem;
                HyperLink hypEdit = (HyperLink)e.Item.FindControl("lnkBtnEdit");
                HyperLink hypMRRNo = (HyperLink)e.Item.FindControl("hypMRRNo");
                Button btnResetMaterialRecieveLV = (Button)e.Item.FindControl("btnResetMaterialRecieveLV");
                HyperLink hypMateialReceiveReport = (HyperLink)e.Item.FindControl("hypMateialReceiveReport");
                HyperLink lnkShowApprovalStatus = (HyperLink)e.Item.FindControl("lnkShowApprovalStatus");

                hypMateialReceiveReport.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", "MaterialReceiveReport", UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, ent.MaterialReceiveID.ToString()).ToString();
                hypEdit.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMMaterialReceive.aspx", string.Empty, "do", "Edit", UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, ent.MaterialReceiveID.ToString()).ToString();
                hypMRRNo.NavigateUrl = UrlHelper.BuildSecureUrl("~/PRM/PRMMaterialReceiveItemMap.aspx", string.Empty, UrlConstants.OVERVIEW_MATERIAL_RECEIVE_ID, ent.MaterialReceiveID.ToString()).ToString();

                hypMateialReceiveReport.Target = "_blank";
                hypEdit.Target = "_blank";
                hypMRRNo.Target = "_blank";

                APApprovalProcessEntity aPApprovalProcessEntity = APRobot.GetApprovalProcessByTypeAndReference(MasterDataConstants.APType.MRR, ent.MaterialReceiveID);

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

                if (ent.MaterialReceiveApprovalStatusID == MasterDataConstants.MDMaterialReceiveApprovalStatus.APPROVED ||
                  ent.MaterialReceiveApprovalStatusID == MasterDataConstants.MDMaterialReceiveApprovalStatus.CANCELED)
                {
                    btnResetMaterialRecieveLV.Visible = true;
                }
                else
                {
                    btnResetMaterialRecieveLV.Visible = false;
                }

                String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillMaterialReceiveMeasurementBookMapEntity.FLD_NAME_MaterialReceiveID, ent.MaterialReceiveID.ToString(), SQLMatchType.Equal);
                IList<CMBillMaterialReceiveMeasurementBookMapEntity> lst = FCCCMBillMaterialReceiveMeasurementBookMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    btnResetMaterialRecieveLV.Visible = false;
                }

            }
        }

        protected void lvPRMMaterialReceive_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 MaterialReceiveID;

            Int64.TryParse(e.CommandArgument.ToString(), out MaterialReceiveID);

            if (MaterialReceiveID > 0)
            {
                
                if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveID, MaterialReceiveID.ToString(), SQLMatchType.Equal);

                        PRMMaterialReceiveEntity pRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();


                        result = FCCPRMMaterialReceive.GetFacadeCreate().Delete(pRMMaterialReceiveEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _MaterialReceiveID = 0;
                            _PRMMaterialReceiveEntity = new PRMMaterialReceiveEntity();
                            PrepareInitialView();
                            BindPRMMaterialReceiveList();

                            MiscUtil.ShowMessage(lblMessage, "Material Receive has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Material Receive.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
                else if (string.Equals(e.CommandName, "ResetAP"))
                {
                    try
                    {
                        #region Approval Process

                        Boolean apResult = APRobot.ResetApprovalProcessForMRR(MaterialReceiveID);

                        if (apResult == true)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Approval Process has been reset successfully.", UIConstants.MessageType.GREEN);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to reset approval process.", UIConstants.MessageType.RED);
                        }

                        BindList();

                        #endregion
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

        protected void odsPRMMaterialReceive_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            String fe = String.Empty;

            if (chbxFilter.Checked)
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive.MRRNo", txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
            }

            if (ViewState["SearchString"] != null)
            {
                fe = (String)ViewState["SearchString"];
            }

            e.InputParameters["filterExpression"] = fe;
        }

        #endregion

        #region Checkbox Event

        protected void chbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            BindPRMMaterialReceiveList();
        }

        #endregion

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String fe="PRMMaterialReceive.MRRDate between '" + MiscUtil.ParseToDateTime(txtStartDate.Text.Trim().ToString()).ToString() + "' AND '" + MiscUtil.ParseToDateTime(txtEndDate.Text.Trim().ToString()).ToString()+"'";

            if(ddlProjectID!=null && ddlProjectID.SelectedValue!="0")
            {
                String fe2=SqlExpressionBuilder.PrepareFilterExpression("PRMMaterialReceive."+PRMMaterialReceiveEntity.FLD_NAME_ProjectID,ddlProjectID.SelectedValue.ToString(),SQLMatchType.Equal);

                fe=SqlExpressionBuilder.PrepareFilterExpression(fe,SQLJoinType.AND,fe2);
            }

            ViewState["SearchString"] = fe;

            BindList();
        }

        protected void btnClearSearch_Click(object sender, EventArgs e)
        {
            ViewState["SearchString"] = null;
            BindList();
        }

        #endregion

        #endregion Event
    }
}
