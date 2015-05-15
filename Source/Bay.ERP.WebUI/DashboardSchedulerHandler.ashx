<%@ WebHandler Language="C#" Class="DashboardSchedulerHandler" %>

using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI;
using Bay.ERP.Common.BusinessEntity;
using Bay.ERP.Web.UI.Helper;


public class DashboardSchedulerHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        String projectID = null;
        String currentEmployeeID = null;
        
        if (context.Request.QueryString["ProjectID"] != null)
        {
            projectID = context.Request.QueryString["ProjectID"].ToString();
        }
        if (context.Request.QueryString["CurrentEmployeeID"] != null)
        {
            currentEmployeeID = context.Request.QueryString["CurrentEmployeeID"].ToString();
        }
        
        context.Response.ContentType = "text/json";
        context.Response.Expires = -1;
        System.Web.Script.Serialization.JavaScriptSerializer ser = new System.Web.Script.Serialization.JavaScriptSerializer();

        // handeling the request
        //ClientPersonalizedProductInfoJSON cppij = ser.Deserialize<ClientPersonalizedProductInfoJSON>(jsonString);

        // for response
        IList<ScheduleJSON> scheduleJSONList = new List<ScheduleJSON>();
        String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, MasterDataConstants.IssueIdentityCategory.PROJECT_ADHOC_ISSUE.ToString(), Bay.ERP.Common.Shared.SQLMatchType.Equal);
        if (projectID != null)
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_ReferenceID, projectID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
        }

        #region Project Issue

        IList<OTIssueEntity> issueList = FCCOTIssue.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

        if (issueList != null && issueList.Count > 0)
        {
            foreach (OTIssueEntity ent in issueList)
            {
                ScheduleJSON scheduleJSON = new ScheduleJSON();
                scheduleJSON.id = ent.IssueID;
                scheduleJSON.title = ent.Title;
                scheduleJSON.start = ConvertToTimestamp(ent.ExpectedStartDate.Value);
                scheduleJSON.end = ConvertToTimestamp(ent.ExpectedEndDate.Value);
                //scheduleJSON.allDay;
                String NavUrl = UrlHelper.BuildSecureUrl("OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                scheduleJSON.url = NavUrl;
                scheduleJSON.editable = false;
                //scheduleJSON.source ;
                //scheduleJSON.color;
                //scheduleJSON.backgroundColor ;
                //scheduleJSON.borderColor;
                //scheduleJSON.textColor;
                scheduleJSONList.Add(scheduleJSON);
                 
            }
        }

        #endregion

        //String meeting = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_AssignedToEmployeeID, currentEmployeeID.ToString(), SQLMatchType.Equal);
        String meeting = "OTIssue.AssignedToEmployeeID =" + currentEmployeeID + " and OTIssue.IssueCategoryID = " + MasterDataConstants.MDIssueCategory.MEETING + "";
        IList<OTIssue_DetailedEntity> meetingIssueCalanderList = FCCOTIssue_Detailed.GetFacadeCreate().GetIL(100000,1, String.Empty, meeting);
        

        if (meetingIssueCalanderList != null && meetingIssueCalanderList.Count > 0)
        {
            
            foreach (OTIssue_DetailedEntity ent in meetingIssueCalanderList)
            {
                ScheduleJSON scheduleJSON = new ScheduleJSON();
                scheduleJSON.id = ent.IssueID;
                String title = String.Empty;
                title += ent.Title + " Duration: " + ent.Duration + " Project: " + ent.MeetingInProject + " Floor: " + ent.ProjectFloorName + " Location: " + ent.ProjectUnitLocationName;

                #region Resource Employee
                
                String f1 = "OTIssue.IssueID ="+ent.IssueID+"";
                IList<OTIssue_CustomEntity> oTIssue_CustomList = FCCOTIssue_Custom.GetFacadeCreate().GetIL(100000, 1, String.Empty, f1);
                if (oTIssue_CustomList != null && oTIssue_CustomList.Count > 0)
                {
                    title += " Employee: ";
                    foreach (OTIssue_CustomEntity o in oTIssue_CustomList)
                    {
                        if (o.ResourceCategoryID == MasterDataConstants.ResourceCategory.EMPLOYEE)
                        {
                            title +=  o.EmployeeFullName+", ";
                        }
                    }

                    title += " Tools: ";
                    foreach (OTIssue_CustomEntity o in oTIssue_CustomList)
                    {
                        if (o.ResourceCategoryID == MasterDataConstants.ResourceCategory.TOOL)
                        {
                            title += o.Specification + ", ";
                        }
                    }
                }
                
                #endregion

                scheduleJSON.title = title;
                scheduleJSON.start = ConvertToTimestamp(ent.ExpectedStartDate.Value);
                scheduleJSON.end = ConvertToTimestamp(ent.ExpectedEndDate.Value);
                //scheduleJSON.allDay;
                //scheduleJSON.url = "<asp:HyperLink id='opener' runat='server'>Open Dialog</HyperLink>";
                //scheduleJSON.className;
                String NavUrl = UrlHelper.BuildSecureUrl("OT/OTAdhocIssue.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                scheduleJSON.url = NavUrl;
                scheduleJSON.editable = false;
                //scheduleJSON.source ;
                scheduleJSON.color = "#fff";
                scheduleJSON.backgroundColor = "#555";
                //scheduleJSON.borderColor;
                //scheduleJSON.textColor;
                scheduleJSONList.Add(scheduleJSON);

            }
        }
        
        #region Meeting Issue
        
        #endregion

        #region My Issue List

        String f = "OTIssue.IssueCategoryID <> " + MasterDataConstants.MDIssueCategory.MEETING + "";
        String fe_calendar = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_AssignedToEmployeeID, currentEmployeeID.ToString(), SQLMatchType.Equal);
        fe_calendar = SqlExpressionBuilder.PrepareFilterExpression(f, SQLJoinType.AND, fe_calendar);
        IList<OTIssueEntity> myCalendarIssueList = FCCOTIssue.GetFacadeCreate().GetIL(null, null, String.Empty, fe_calendar, DatabaseOperationType.LoadWithFilterExpression);

        if (myCalendarIssueList != null && myCalendarIssueList.Count > 0)
        {
            foreach (OTIssueEntity ent in myCalendarIssueList)
            {
                ScheduleJSON scheduleJSON = new ScheduleJSON();
                scheduleJSON.id = ent.IssueID;
                scheduleJSON.title = ent.Title;
                scheduleJSON.start = ConvertToTimestamp(ent.ExpectedStartDate.Value);
                scheduleJSON.end = ConvertToTimestamp(ent.ExpectedEndDate.Value);
                //scheduleJSON.allDay;
                //scheduleJSON.url = "<asp:HyperLink id='opener' runat='server'>Open Dialog</HyperLink>";
                //scheduleJSON.className;
                String NavUrl = UrlHelper.BuildSecureUrl("OT/OTAdhocIssue.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
                scheduleJSON.url = NavUrl;
                scheduleJSON.editable = false;
                //scheduleJSON.source ;
                scheduleJSON.color="#fff";
                scheduleJSON.backgroundColor ="#555";
                //scheduleJSON.borderColor;
                //scheduleJSON.textColor;
                scheduleJSONList.Add(scheduleJSON);

            }
        }

        #endregion

        //#region PreBOQ Info

        //String fePreBOQ = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);

        //IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fePreBOQ, DatabaseOperationType.LoadWithFilterExpression);

        //if (preBOQList != null && preBOQList.Count > 0)
        //{
        //    PRMPreBOQEntity ent = preBOQList[0];
        //    ScheduleJSON scheduleJSON = new ScheduleJSON();
        //    scheduleJSON.id = ent.PreBOQID;
        //    scheduleJSON.title = "BOQ Creation";
        //    scheduleJSON.start = ConvertToTimestamp(ent.StartDate.Value);
        //    scheduleJSON.end = ConvertToTimestamp(ent.StartDate.Value);
        //    //scheduleJSON.allDay;
        //    //scheduleJSON.url;
        //    //scheduleJSON.className;
        //    scheduleJSON.editable = false;
        //    //scheduleJSON.source ;
        //    //scheduleJSON.color;
        //    scheduleJSON.backgroundColor = "Gray";
        //    //scheduleJSON.borderColor;
        //    //scheduleJSON.textColor;
        //    scheduleJSONList.Add(scheduleJSON);
        //}

        //#endregion

        //#region BOQ Info

        //String feBOQ = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);

        //IList<PRMBOQEntity> BOQList = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, feBOQ, DatabaseOperationType.LoadWithFilterExpression);

        //if (BOQList != null && BOQList.Count > 0)
        //{
        //    PRMBOQEntity ent = BOQList[0];
        //    ScheduleJSON scheduleJSON = new ScheduleJSON();
        //    scheduleJSON.id = ent.BOQID;
        //    scheduleJSON.title = "Project Cost";
        //    scheduleJSON.start = ConvertToTimestamp(ent.StartDate.Value);
        //    scheduleJSON.end = ConvertToTimestamp(ent.StartDate.Value);
        //    //scheduleJSON.allDay;
        //    //scheduleJSON.url;
        //    //scheduleJSON.className;
        //    scheduleJSON.editable = false;
        //    //scheduleJSON.source ;
        //    //scheduleJSON.color;
        //    scheduleJSON.backgroundColor = "Orange";
        //    //scheduleJSON.borderColor;
        //    //scheduleJSON.textColor;
        //    scheduleJSONList.Add(scheduleJSON);
        //}

        //#endregion

        #region BOQ Info

        String feProjectHistory = SqlExpressionBuilder.PrepareFilterExpression(BDProjectHistoryEntity.FLD_NAME_ProjectID, projectID, SQLMatchType.Equal);

        IList<BDProjectHistoryEntity> projectHistoryList = FCCBDProjectHistory.GetFacadeCreate().GetIL(null, null, String.Empty, feProjectHistory, DatabaseOperationType.LoadWithFilterExpression);

        if (projectHistoryList != null && projectHistoryList.Count > 0)
        {
            foreach (BDProjectHistoryEntity ent in projectHistoryList)
            {   
                ScheduleJSON scheduleJSON = new ScheduleJSON();
                scheduleJSON.id = ent.ProjectHistoryID;
                scheduleJSON.title = ent.Remarks;
                scheduleJSON.start = ConvertToTimestamp(ent.HistoryDate);
                scheduleJSON.end = ConvertToTimestamp(ent.HistoryDate);
                //scheduleJSON.allDay;
                //scheduleJSON.url;
                //scheduleJSON.className;
                scheduleJSON.editable = false;
                //scheduleJSON.source ;
                //scheduleJSON.color;
                scheduleJSON.backgroundColor = "Turquoise";
                //scheduleJSON.borderColor;
                //scheduleJSON.textColor;
                scheduleJSONList.Add(scheduleJSON);
            }
        }

        #endregion

        //#region Contractor Assigned Work Area

        //String feContractor = SqlExpressionBuilder.PrepareFilterExpression(CMContractorAssignedWorkAreaEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);

        //IList<CMContractorAssignedWorkAreaEntity> lstContratorAssigned = FCCCMContractorAssignedWorkArea.GetFacadeCreate().GetIL(null, null, String.Empty, feContractor, DatabaseOperationType.LoadWithFilterExpression);

        //if (lstContratorAssigned != null && lstContratorAssigned.Count > 0)
        //{
        //    foreach (CMContractorAssignedWorkAreaEntity ent in lstContratorAssigned)
        //    {
        //        ScheduleJSON scheduleJSON = new ScheduleJSON();
        //        scheduleJSON.id = ent.ContractorID;
        //        scheduleJSON.title = ent.WorkDescription;
        //        scheduleJSON.start = ConvertToTimestamp(ent.StartDate.Value);
        //        scheduleJSON.end = ConvertToTimestamp(ent.EndDate.Value);
        //        //scheduleJSON.allDay;
        //        //scheduleJSON.url;
        //        //scheduleJSON.className;
        //        scheduleJSON.editable = false;
        //        //scheduleJSON.source ;
        //        //scheduleJSON.color;
        //        scheduleJSON.backgroundColor = "Turquoise";
        //        //scheduleJSON.borderColor;
        //        //scheduleJSON.textColor;
        //        scheduleJSONList.Add(scheduleJSON);
        //    }
        //}

        //#endregion

        //#region Consultant Assigned Work Area

        //String feConsultant = SqlExpressionBuilder.PrepareFilterExpression(CMConsultantAssignedWorkAreaEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);

        //IList<CMConsultantAssignedWorkAreaEntity> lstConsultantAssigned = FCCCMConsultantAssignedWorkArea.GetFacadeCreate().GetIL(null,null,String.Empty,feConsultant,DatabaseOperationType.LoadWithFilterExpression);

        //if (lstConsultantAssigned != null && lstConsultantAssigned.Count > 0)
        //{
        //    foreach (CMConsultantAssignedWorkAreaEntity ent in lstConsultantAssigned)
        //    {
        //        ScheduleJSON scheduleJSON = new ScheduleJSON();
        //        scheduleJSON.id = ent.ConsultantID;
        //        scheduleJSON.title = ent.ConsultantWorkAreaID.ToString();
        //        scheduleJSON.start = ConvertToTimestamp(ent.StartDate.Value);
        //        scheduleJSON.end = ConvertToTimestamp(ent.EndDate.Value);
        //        //scheduleJSON.allDay;
        //        //scheduleJSON.url;
        //        //scheduleJSON.className;
        //        scheduleJSON.editable = false;
        //        //scheduleJSON.source ;
        //        //scheduleJSON.color;
        //        scheduleJSON.backgroundColor = "Turquoise";
        //        //scheduleJSON.borderColor;
        //        //scheduleJSON.textColor;
        //        scheduleJSONList.Add(scheduleJSON);
        //    }
        //}

        //#endregion

        //#region Work Order

        ////String feWorkOrder = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity., projectID.ToString(), SQLMatchType.Equal);

        //IList<PRMWorkOrderEntity> lstWorkOrder= FCCPRMWorkOrder.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

        //if (lstWorkOrder != null && lstWorkOrder.Count > 0)
        //{
        //    foreach (PRMWorkOrderEntity ent in lstWorkOrder)
        //    {
        //        ScheduleJSON scheduleJSON = new ScheduleJSON();
        //        scheduleJSON.id = ent.WorkOrderID;
        //        scheduleJSON.title = "Work Order - " + ent.WorkOrderNo.ToString() + " - Start Date";
        //        scheduleJSON.start = ConvertToTimestamp(ent.StartDate);
        //        scheduleJSON.end = ConvertToTimestamp(ent.StartDate);
        //        //scheduleJSON.allDay;
        //        //scheduleJSON.url;
        //        //scheduleJSON.className;
        //        scheduleJSON.editable = false;
        //        //scheduleJSON.source ;
        //        //scheduleJSON.color;
        //        scheduleJSON.backgroundColor = "Purple";
        //        //scheduleJSON.borderColor;
        //        //scheduleJSON.textColor;
        //        scheduleJSONList.Add(scheduleJSON);
        //    }
            
        //    foreach (PRMWorkOrderEntity ent in lstWorkOrder)
        //    {
        //        ScheduleJSON scheduleJSON = new ScheduleJSON();
        //        scheduleJSON.id = ent.WorkOrderID;
        //        scheduleJSON.title = "Work Order - "+ ent.WorkOrderNo.ToString()+" - Completion Date";
        //        scheduleJSON.start = ConvertToTimestamp(ent.CompletionDate);
        //        scheduleJSON.end = ConvertToTimestamp(ent.CompletionDate);
        //        //scheduleJSON.allDay;
        //        //scheduleJSON.url;
        //        //scheduleJSON.className;
        //        scheduleJSON.editable = false;
        //        //scheduleJSON.source ;
        //        //scheduleJSON.color;
        //        scheduleJSON.backgroundColor = "Purple";
        //        //scheduleJSON.borderColor;
        //        //scheduleJSON.textColor;
        //        scheduleJSONList.Add(scheduleJSON);
        //    }
        //}

        //#endregion

        //#region Bill

        //String feBill = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);

        //IList<CMBillEntity> lstBill = FCCCMBill.GetFacadeCreate().GetIL(null, null, String.Empty, feBill, DatabaseOperationType.LoadWithFilterExpression);

        //if (lstBill != null && lstBill.Count > 0)
        //{
        //    foreach (CMBillEntity ent in lstBill)
        //    {
        //        ScheduleJSON scheduleJSON = new ScheduleJSON();
        //        scheduleJSON.id = ent.BillID;
        //        scheduleJSON.title = ent.BillNo.ToString();
        //        scheduleJSON.start = ConvertToTimestamp(ent.BillDate);
        //        scheduleJSON.end = ConvertToTimestamp(ent.BillDate);
        //        //scheduleJSON.allDay;
        //        //scheduleJSON.url;
        //        //scheduleJSON.className;
        //        scheduleJSON.editable = false;
        //        //scheduleJSON.source ;
        //        //scheduleJSON.color;
        //        scheduleJSON.backgroundColor = "Lavender";
        //        //scheduleJSON.borderColor;
        //        //scheduleJSON.textColor;
        //        scheduleJSONList.Add(scheduleJSON);
        //    }
        //}

        //#endregion

        //#region Requisition

        //String feRequisition = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);

        //IList<REQRequisitionEntity> lstRequisition = FCCREQRequisition.GetFacadeCreate().GetIL(null, null, String.Empty, feRequisition, DatabaseOperationType.LoadWithFilterExpression);

        //if (lstRequisition != null && lstRequisition.Count > 0)
        //{
        //    foreach (REQRequisitionEntity ent in lstRequisition)
        //    {
        //        ScheduleJSON scheduleJSON = new ScheduleJSON();
        //        scheduleJSON.id = ent.ProjectID;
        //        scheduleJSON.title = "Requisition No - "+ent.RequisitionNo.ToString()+" - Requisition Date";
        //        scheduleJSON.start = ConvertToTimestamp(ent.RequisitionDate);
        //        scheduleJSON.end = ConvertToTimestamp(ent.RequisitionDate);
        //        //scheduleJSON.allDay;
        //        String NavUrl = UrlHelper.BuildSecureUrl("Site/REQRequisitionItemView.aspx", string.Empty, UrlConstants.OVERVIEW_PROJECT_ID, ent.ProjectID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionID, ent.RequisitionID.ToString(), REQRequisitionEntity.FLD_NAME_RequisitionNo, ent.RequisitionNo.ToString()).ToString();
        //        scheduleJSON.url = NavUrl;
        //        //scheduleJSON.className = "asdfasfasdfasfasdfs";
        //        scheduleJSON.editable = false;
        //        //scheduleJSON.source ;
        //        //scheduleJSON.color;
        //        scheduleJSON.backgroundColor = "Teal";
        //        //scheduleJSON.borderColor;
        //        //scheduleJSON.textColor;
        //        scheduleJSONList.Add(scheduleJSON);
        //    }
        //}

        //#endregion

        String response = ser.Serialize(scheduleJSONList);

        context.Response.Write(response);
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    private long ConvertToTimestamp(DateTime value)
    {
        long epoch = (value.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        return epoch;
    }
}

