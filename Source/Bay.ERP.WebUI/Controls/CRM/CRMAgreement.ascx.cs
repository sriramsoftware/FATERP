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
    public partial class CRMAgreementControl : BaseControl
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

        public IList<CRMAgreementVariableMapEntity> cRMAgreementVariableMapEntityList
        {
            get
            {
                return (IList<CRMAgreementVariableMapEntity>)ViewState["cRMAgreementVariableMapEntityList"];
            }
            set
            {
                ViewState["cRMAgreementVariableMapEntityList"] = value;
            }
        }

        public Int64 OverviewAgreementID
        {
            get
            {
                Int64 cRMAgreementID = 0;

                if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_AGREEMENT_ID], out cRMAgreementID);
                }

                return cRMAgreementID;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCRMPaymentScheduleWithIDBuyerForjectAndFloor(ddlPaymentScheduleID, false);
            MiscUtil.PopulateCRMMDAgreementType(ddlAgreementTypeID, false);
            //MiscUtil.PopulateCRMBuyerBasicInfo(ddlBuyerBasicInfoID, false);
            MiscUtil.PopulateCRMMDAgreementTemplate(ddlTemplateID, false);
            //MiscUtil.PopulateBDProject(ddlProjectID, false);
            MiscUtil.PopulateCRMMDAgreementApprovalStatus(ddlAgreementApprovalStatusID, false);
            MiscUtil.PopulateStartWithAPPanel(ddlAPPanelID, false, MasterDataConstants.APPanelStartWith.CRM);
            
            BuildProjectFloorUnitByProjectID();
        }


        private void BuildProjectFloorUnitByProjectID()
        {
            if (ddlProjectID != null && ddlProjectID.Items.Count > 0)
            {
                MiscUtil.PopulateBDNotAvailableProjectFloorUnitByProject(ddlProjectFloorUnitID, false, Int64.Parse(ddlProjectID.SelectedValue));
            }
            else
            {
                ddlProjectFloorUnitID.Items.Clear();
            }
        }

        private void GetTemplateInfo()
        {
            if (ddlTemplateID != null && ddlTemplateID.Items.Count > 0)
            {
                CRMAgreementTemplateEntity cRMAgreementTemplateEntity = FCCCRMAgreementTemplate.GetFacadeCreate().GetByID(Int64.Parse(ddlTemplateID.SelectedValue));

                if (cRMAgreementTemplateEntity != null && cRMAgreementTemplateEntity.AgreementTemplateID > 0)
                {
                    txtText.Content = cRMAgreementTemplateEntity.Text.ToString();
                }
            }
        }

        private void GetPaymentSchedule()
        {
            String head = "<table border='2'><tr><th> Installment Name</th>" + "<th>Aggrement A</th>" + "<th>Aggrement B </th>" + "<th>Aggrement C</th></tr>" + "<br/>";
            String data = head;
            if (ddlPaymentScheduleID != null && ddlPaymentScheduleID.Items.Count > 0)
            {
                IList<CRMPaymentSchedule_RPTEntity> list = FCCCRMPaymentSchedule_RPT.GetFacadeCreate().GetIL(Convert.ToInt64(ddlPaymentScheduleID.SelectedValue));
                foreach(CRMPaymentSchedule_RPTEntity ent in list)
                {
                    data += "<tr><td>" + ent.InstallmentName + "</td><td>" + ent.AgreementAAmount + "</td><td>" + ent.AgreementBAmount + "</td><td>" + ent.AgreementCAmount + "</td></tr>";
                }
                txtText.Content = data+"</table>";
            }
        }

        private void GetPaymentScheduleReport()
        {
            hypPaymentSchedule.NavigateUrl = UrlHelper.BuildSecureUrl("~/Reports/ReportViewer.aspx", string.Empty, "do", ReportConstants.PAYMENT_SCHEDULE_REPORT, UrlConstants.OVERVIEW_PAYMENT_SCHEDULE_ID, Int64.Parse(ddlPaymentScheduleID.SelectedValue).ToString()).ToString();
            hypPaymentSchedule.Target = "_blank";
        }

        private void GetPaymentScheduleSelectedDropdown()
        {
            CRMPaymentScheduleEntity entity = FCCCRMPaymentSchedule.GetFacadeCreate().GetByID(Int64.Parse(ddlPaymentScheduleID.SelectedValue));
            MiscUtil.PopulateCRMBuyerBasicInfo(ddlBuyerBasicInfoID, false, entity.BuyerBasicInfoID);
            MiscUtil.PopulateBDProjectByCode(ddlProjectID, false, entity.ProjectCode);
            MiscUtil.PopulateBDProjectFloorUnitByBuyerBookSpaceID(ddlProjectFloorUnitID, false, entity.BuyerBookSpaceID);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            GetPaymentScheduleSelectedDropdown();

            txtAgreementDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtSignDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtExecuteDate.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);
            txtRemarks.Text = System.DateTime.Now.ToString(UIConstants.SHORT_DATE_FORMAT);

            if (OverviewAgreementID > 0)
            {
                _AgreementID = OverviewAgreementID;
            }

            cRMAgreementVariableMapEntityList = new List<CRMAgreementVariableMapEntity>();
        }


        private void PrepareEditView()
        {
            CRMAgreementEntity cRMAgreementEntity = CurrentCRMAgreementEntity;


            if (!cRMAgreementEntity.IsNew)
            {
                if (ddlPaymentScheduleID.Items.Count > 0 && cRMAgreementEntity.PaymentScheduleID != null)
                {
                    ddlPaymentScheduleID.SelectedValue = cRMAgreementEntity.PaymentScheduleID.ToString();
                }

                if (ddlAgreementTypeID.Items.Count > 0 && cRMAgreementEntity.AgreementTypeID != null)
                {
                    ddlAgreementTypeID.SelectedValue = cRMAgreementEntity.AgreementTypeID.ToString();
                }

                if (ddlBuyerBasicInfoID.Items.Count > 0 && cRMAgreementEntity.BuyerBasicInfoID != null)
                {
                    ddlBuyerBasicInfoID.SelectedValue = cRMAgreementEntity.BuyerBasicInfoID.ToString();
                }

                if (ddlProjectID.Items.Count > 0 && cRMAgreementEntity.ProjectID != null)
                {
                    ddlProjectID.SelectedValue = cRMAgreementEntity.ProjectID.ToString();
                }

                BuildProjectFloorUnitByProjectID();

                if (ddlProjectFloorUnitID.Items.Count > 0 && cRMAgreementEntity.ProjectFloorUnitID != null)
                {
                    ddlProjectFloorUnitID.SelectedValue = cRMAgreementEntity.ProjectFloorUnitID.ToString();
                }

                txtText.Content = cRMAgreementEntity.Text.ToString();
                txtAgreementDate.Text = cRMAgreementEntity.AgreementDate.ToStringDefault();
                txtSignDate.Text = cRMAgreementEntity.SignDate.ToStringDefault();
                txtExecuteDate.Text = cRMAgreementEntity.ExecuteDate.ToStringDefault();
                txtRemarks.Text = cRMAgreementEntity.Remarks.ToString();

                if (ddlAgreementApprovalStatusID.Items.Count > 0 && cRMAgreementEntity.AgreementApprovalStatusID != null)
                {
                    ddlAgreementApprovalStatusID.SelectedValue = cRMAgreementEntity.AgreementApprovalStatusID.ToString();
                }
            }
        }

        private void BindList()
        {
            BindCRMAgreementList();
        }

        private void BindCRMAgreementList()
        {
            
        }

        private CRMAgreementEntity BuildCRMAgreementEntity()
        {
            CRMAgreementEntity cRMAgreementEntity = CurrentCRMAgreementEntity;

            if (ddlPaymentScheduleID.Items.Count > 0)
            {
                if (ddlPaymentScheduleID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.PaymentScheduleID = Int64.Parse(ddlPaymentScheduleID.SelectedValue);
                }
            }

            if (ddlAgreementTypeID.Items.Count > 0)
            {
                if (ddlPaymentScheduleID.Items.Count > 0)
                {
                    if (ddlPaymentScheduleID.SelectedValue == "0")
                    {
                    }
                    else
                    {
                        cRMAgreementEntity.PaymentScheduleID = Int64.Parse(ddlPaymentScheduleID.SelectedValue);
                    }
                }

                if (ddlAgreementTypeID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.AgreementTypeID = Int64.Parse(ddlAgreementTypeID.SelectedValue);
                }
            }

            if (ddlBuyerBasicInfoID.Items.Count > 0)
            {
                if (ddlBuyerBasicInfoID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.BuyerBasicInfoID = Int64.Parse(ddlBuyerBasicInfoID.SelectedValue);
                }
            }

            if (ddlProjectID.Items.Count > 0)
            {
                if (ddlProjectID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.ProjectID = Int64.Parse(ddlProjectID.SelectedValue);
                }
            }

            if (ddlProjectFloorUnitID.Items.Count > 0)
            {
                if (ddlProjectFloorUnitID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.ProjectFloorUnitID = Int64.Parse(ddlProjectFloorUnitID.SelectedValue);
                }
            }

            cRMAgreementEntity.Text = txtText.Content.ToString();
            if (txtAgreementDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMAgreementEntity.AgreementDate = MiscUtil.ParseToDateTime(txtAgreementDate.Text);
            }
            else
            {
                cRMAgreementEntity.AgreementDate = null;
            }

            if (txtSignDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMAgreementEntity.SignDate = MiscUtil.ParseToDateTime(txtSignDate.Text);
            }
            else
            {
                cRMAgreementEntity.SignDate = null;
            }

            if (txtExecuteDate.Text.Trim().IsNotNullOrEmpty())
            {
                cRMAgreementEntity.ExecuteDate = MiscUtil.ParseToDateTime(txtExecuteDate.Text);
            }
            else
            {
                cRMAgreementEntity.ExecuteDate = null;
            }

            cRMAgreementEntity.Field1 = "Not Implemented";
            cRMAgreementEntity.Field2 = "Not Implemented";
            cRMAgreementEntity.Field3 = "Not Implemented";
            cRMAgreementEntity.Field4 = "Not Implemented";
            cRMAgreementEntity.Remarks = txtRemarks.Text.ToString();
            cRMAgreementEntity.CreatedByEmployeeID = CurrentemployeeID;
            cRMAgreementEntity.CreateDate = System.DateTime.Now;
            cRMAgreementEntity.IP = MiscUtil.GetLocalIP();
            if (ddlAgreementApprovalStatusID.Items.Count > 0)
            {
                if (ddlAgreementApprovalStatusID.SelectedValue == "0")
                {
                }
                else
                {
                    cRMAgreementEntity.AgreementApprovalStatusID = Int64.Parse(ddlAgreementApprovalStatusID.SelectedValue);
                }
            }


            return cRMAgreementEntity;
        }

        private void SaveCRMAgreementEntity()
        {
            if (IsValid)
            {
                try
                {
                    CRMAgreementEntity cRMAgreementEntity = BuildCRMAgreementEntity();

                    Int64 result = -1;

                    if (cRMAgreementEntity.IsNew)
                    {
                        result = FCCCRMAgreement.GetFacadeCreate().Add(cRMAgreementEntity, DatabaseOperationType.Add, TransactionRequired.No);

                        String input = txtText.Content.ToString();

                        String newOutPut = String.Empty;
                        
                        IList<CRMMDAgreementVariableEntity> cRMAgreementVariableList = FCCCRMMDAgreementVariable.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

                        if (cRMAgreementVariableList != null && cRMAgreementVariableList.Count > 0)
                        {
                            foreach (CRMMDAgreementVariableEntity ent in cRMAgreementVariableList)
                            {
                                if (input.Contains(ent.Name))  // AGR body matching
                                {
                                    CRMAgreementVariableMapEntity cRMAgrementVariableMapEnt = new CRMAgreementVariableMapEntity();
                                    cRMAgrementVariableMapEnt.Name = ent.Name;
                                    cRMAgrementVariableMapEnt.Value = ent.Value;
                                    cRMAgreementVariableMapEntityList.Add(cRMAgrementVariableMapEnt);
                                    newOutPut = MiscUtil.ReplaceFullWords(input, ent.Name, ent.Value.ToString());
                                    input = newOutPut;
                                }
                            }
                        }

                        if (newOutPut.IsNotNullOrEmpty())
                        {
                            lblTextView.Text = Server.HtmlDecode(newOutPut);
                        }
                        else
                        {
                            lblTextView.Text = Server.HtmlDecode(input);
                        }

                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementEntity.FLD_NAME_AgreementID, cRMAgreementEntity.AgreementID.ToString(), SQLMatchType.Equal);
                        result = FCCCRMAgreement.GetFacadeCreate().Update(cRMAgreementEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);

                        String input = txtText.Content.ToString();

                        String newOutPut = String.Empty;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementID, result.ToString(), SQLMatchType.Equal);
                        IList<CRMAgreementVariableMapEntity> cRMAgreementVariableList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                        if (cRMAgreementVariableList != null && cRMAgreementVariableList.Count > 0)
                        {
                            cRMAgreementVariableMapEntityList = new List<CRMAgreementVariableMapEntity>();

                            foreach (CRMAgreementVariableMapEntity ent in cRMAgreementVariableList)
                            {
                                if (input.Contains(ent.Name))
                                {
                                    CRMAgreementVariableMapEntity cRMAgrementVariableMapEnt = new CRMAgreementVariableMapEntity();
                                    cRMAgrementVariableMapEnt.Name = ent.Name;
                                    cRMAgrementVariableMapEnt.Value = ent.Value;
                                    //cRMAgreementVariableMapEntityList.Add(cRMAgrementVariableMapEnt);
                                    newOutPut = MiscUtil.ReplaceFullWords(input, ent.Name, ent.Value.ToString());
                                    input = newOutPut;
                                }
                            }
                        }

                        if (newOutPut.IsNotNullOrEmpty())
                        {
                            lblTextView.Text = Server.HtmlDecode(newOutPut);
                        }
                        else
                        {
                            lblTextView.Text = input;
                        }
                    }

                    if (result > 0)
                    {

                        #region Agreement variable Map

                        if (cRMAgreementEntity.IsNew)
                        {
                            if (cRMAgreementVariableMapEntityList != null && cRMAgreementVariableMapEntityList.Count > 0)
                            {
                                // Delete Variable Map Table 

                                //String fe_delete=SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementVariableMapEntity.FLD_NAME_AgreementID,result.ToString(),SQLMatchType.Equal);
                                //IList<CRMAgreementVariableMapEntity> deleteList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe_delete, DatabaseOperationType.LoadWithFilterExpression);

                                //if (deleteList != null && deleteList.Count > 0)
                                //{
                                //    foreach (CRMAgreementVariableMapEntity ent in cRMAgreementVariableMapEntityList)
                                //    {
                                //        FCCCRMAgreementVariableMap.GetFacadeCreate().Delete(ent, fe_delete, DatabaseOperationType.Delete, TransactionRequired.No);
                                //    }
                                //}

                                foreach (CRMAgreementVariableMapEntity ent in cRMAgreementVariableMapEntityList)
                                {
                                    CRMAgreementVariableMapEntity cRMAgrementVariableMapEnt = new CRMAgreementVariableMapEntity();
                                    cRMAgrementVariableMapEnt.Name = ent.Name;
                                    cRMAgrementVariableMapEnt.Value = ent.Value;
                                    cRMAgrementVariableMapEnt.IP = MiscUtil.GetLocalIP();
                                    cRMAgrementVariableMapEnt.Remarks = "Auto Generated";
                                    cRMAgrementVariableMapEnt.CreateDate = System.DateTime.Now;
                                    cRMAgrementVariableMapEnt.CreatedByEmployeeID = CurrentemployeeID;
                                    cRMAgrementVariableMapEnt.AgreementID = result;

                                    FCCCRMAgreementVariableMap.GetFacadeCreate().Add(cRMAgrementVariableMapEnt, DatabaseOperationType.Add, TransactionRequired.No);
                                }
                            }
                        }

                        #endregion

                        if (cRMAgreementEntity.AgreementTypeID == MasterDataConstants.CRMMDAgreementType.SPECS)
                        {
                            hypAgreementSpec.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMAgreementSpecs.aspx", String.Empty, UrlConstants.OVERVIEW_AGREEMENT_ID, result.ToString()).ToString();
                            hypAgreementSpec.Target = "_blank";
                            hypAgreementSpec.Visible = true;
                        }

                        hypAgreementVariablePopup.NavigateUrl = UrlHelper.BuildSecureUrl("~/CRM/CRMAgreementVariableMap.aspx", String.Empty, UrlConstants.OVERVIEW_AGREEMENT_ID, result.ToString()).ToString();
                        hypAgreementVariablePopup.Target="_blank";
                        hypAgreementVariablePopup.Visible = true;

                        _AgreementID = result;
                        //_CRMAgreementEntity = new CRMAgreementEntity();
                        PrepareEditView();
                        BindCRMAgreementList();

                        if (cRMAgreementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Agreement Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cRMAgreementEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Agreement Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Agreement Information.", false);
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
                GetPaymentScheduleReport();
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

                    PrepareEditView();
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementEntity.FLD_NAME_AgreementID, AgreementID.ToString(), SQLMatchType.Equal);

                        CRMAgreementEntity cRMAgreementEntity = new CRMAgreementEntity();


                        result = FCCCRMAgreement.GetFacadeCreate().Delete(cRMAgreementEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

                        if (result == 0)
                        {
                            _AgreementID = 0;
                            _CRMAgreementEntity = new CRMAgreementEntity();
                            PrepareInitialView();
                            BindCRMAgreementList();

                            MiscUtil.ShowMessage(lblMessage, "C RMAgreement has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete C RMAgreement.", true);
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

        protected void odsCRMAgreement_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            CRMAgreementEntity cRMAgreementEntity=new CRMAgreementEntity();

            Int64 result = -1;
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMAgreementEntity.FLD_NAME_AgreementID, _AgreementID.ToString(), SQLMatchType.Equal);
            result = FCCCRMAgreement.GetFacadeCreate().Delete(cRMAgreementEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);

            if (result == 0)
            {
                MiscUtil.ShowMessage(lblMessage, "Agreement Deleted Successfully", true);
                _AgreementID = result;
                _CRMAgreementEntity = new CRMAgreementEntity();
                PrepareInitialView();
                wizAgreement.ActiveStepIndex = 0;
                hypAgreementVariablePopup.Visible = false;
                hypAgreementSpec.Visible = false;
            }
        }

        protected void btnSaveDraft_Click(object sender, EventArgs e)
        {
            #region Save Agreement

            SaveCRMAgreementEntity();

            #endregion
        }

        protected void wizAgreement_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            #region Save Agreement

            #region Approval Process

            if (_AgreementID>0)
            {

                Boolean apResult = APRobot.CreateApprovalProcessForNewAgreement(_AgreementID, Int64.Parse(ddlAPPanelID.SelectedValue));

                if (apResult == true)
                {
                    MiscUtil.ShowMessage(lblMessage, "Approval Process Submited successfully.", UIConstants.MessageType.GREEN);
                    Helper.Url.Redirect("~/CRM/CRMAgreementList.aspx", String.Empty, String.Empty);
                }
                else
                {
                    MiscUtil.ShowMessage(lblMessage, "Failed to Submit Approval Process.", UIConstants.MessageType.RED);
                }
            }

            #endregion

            #endregion
        }
        protected void wizAgreement_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            #region Process Your Data Here

            //String input = txtText.Content.ToString();

            //String newOutPut = String.Empty;

            //IList<CRMAgreementVariableMapEntity> cRMAgreementVariableList = FCCCRMAgreementVariableMap.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            //if (cRMAgreementVariableList != null && cRMAgreementVariableList.Count > 0)
            //{
            //    foreach (CRMAgreementVariableMapEntity ent in cRMAgreementVariableList)
            //    {
            //        if (input.Contains(ent.Name))
            //        {
            //            CRMAgreementVariableMapEntity cRMAgrementVariableMapEnt=new CRMAgreementVariableMapEntity();
            //            cRMAgrementVariableMapEnt.Name=ent.Name;
            //            cRMAgrementVariableMapEnt.Value = ent.Value;
            //            cRMAgreementVariableMapEntityList.Add(cRMAgrementVariableMapEnt);
            //            newOutPut = MiscUtil.ReplaceFullWords(input, ent.Name, ent.Value.ToString());
            //            input = newOutPut;
            //        }
            //    }
                
            //}

            //lblTextView.Text = newOutPut;

            #endregion
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            GetTemplateInfo();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            GetPaymentSchedule();
        }

        #endregion

        #region Dropdown Event

        protected void ddlProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildProjectFloorUnitByProjectID();
        }

        protected void ddlPaymentScheduleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPaymentScheduleReport();
            GetPaymentScheduleSelectedDropdown();
        }

        #endregion

        #endregion Event
    }
}
