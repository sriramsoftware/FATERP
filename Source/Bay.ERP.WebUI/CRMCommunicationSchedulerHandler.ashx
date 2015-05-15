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
        
        //if (context.Request.QueryString["ProjectID"] != null)
        //{
        //    projectID = context.Request.QueryString["ProjectID"].ToString();
        //}
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
        //String fe = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, MasterDataConstants.IssueIdentityCategory.PROJECT_ADHOC_ISSUE.ToString(), Bay.ERP.Common.Shared.SQLMatchType.Equal);
        //if (projectID != null)
        //{
        //    String fe1 = SqlExpressionBuilder.PrepareFilterExpression(OTIssueEntity.FLD_NAME_ReferenceID, projectID.ToString(), SQLMatchType.Equal);
        //    fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe1);
        //}

        String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CRMCommunicationEntity.FLD_NAME_CommunicateByEmployeeID, currentEmployeeID.ToString(), SQLMatchType.Equal);
        String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CRMCommunicationEntity.FLD_NAME_CreatedByEmployeeID, currentEmployeeID.ToString(), SQLMatchType.Equal);
        String fe3= CRMCommunicationEntity.FLD_NAME_NextCommunicationDate+" is not null";
        String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.OR, fe2);
        fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.OR, fe3);
        
        #region Project Issue

        IList<CRMCommunicationEntity> issueList = FCCCRMCommunication.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

        if (issueList != null && issueList.Count > 0)
        {
            foreach (CRMCommunicationEntity ent in issueList)
            {
                ScheduleJSON scheduleJSON = new ScheduleJSON();
                scheduleJSON.id = ent.CommunicationID;
                scheduleJSON.title = ent.Topics;
                scheduleJSON.start = ConvertToTimestamp(ent.NextCommunicationDate.Value);
                scheduleJSON.end = ConvertToTimestamp(ent.NextCommunicationDate.Value);
                //scheduleJSON.allDay;
                String NavUrl = String.Empty;// UrlHelper.BuildSecureUrl("OT/OTProjectAdhocIssue.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_ISSUE_ID, ent.IssueID.ToString()).ToString();
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

