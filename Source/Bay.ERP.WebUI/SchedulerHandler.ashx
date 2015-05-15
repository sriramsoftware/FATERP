<%@ WebHandler Language="C#" Class="SchedulerHandler" %>

using System;
using System.Collections.Generic;
using System.Web;
using System.IO;


public class SchedulerHandler : IHttpHandler {
    
    public void ProcessRequest(HttpContext context)
    {
        if (context.Request.QueryString["ProjectID"] != null)
        {
            String projectID = context.Request.QueryString["ProjectID"].ToString();
        }
        context.Response.ContentType = "text/json";
        context.Response.Expires = -1;
        System.Web.Script.Serialization.JavaScriptSerializer ser = new System.Web.Script.Serialization.JavaScriptSerializer();

        // handeling the request
        //ClientPersonalizedProductInfoJSON cppij = ser.Deserialize<ClientPersonalizedProductInfoJSON>(jsonString);

        // for response        
        IList<Bay.ERP.Common.BusinessEntity.ScheduleJSON> scheduleJSONList = new List<Bay.ERP.Common.BusinessEntity.ScheduleJSON>();
        String fe = Bay.ERP.Common.Helper.SqlExpressionBuilder.PrepareFilterExpression(Bay.ERP.Common.BusinessEntities.OTIssueEntity.FLD_NAME_IssueIdentityCategoryID, Bay.ERP.Web.UI.MasterDataConstants.IssueIdentityCategory.ADHOC_ISSUE.ToString(), Bay.ERP.Common.Shared.SQLMatchType.Equal);
        IList<Bay.ERP.Common.BusinessEntities.OTIssueEntity> issueList = Bay.ERP.FacadeCreator.FacadeContext.FCCOTIssue.GetFacadeCreate().GetIL(null, null, String.Empty, fe, Bay.ERP.Common.Shared.DatabaseOperationType.LoadWithFilterExpression);

        if (issueList != null && issueList.Count > 0)
        {
            foreach (Bay.ERP.Common.BusinessEntities.OTIssueEntity ent in issueList)
            {
                Bay.ERP.Common.BusinessEntity.ScheduleJSON scheduleJSON = new Bay.ERP.Common.BusinessEntity.ScheduleJSON();
                scheduleJSON.id = ent.IssueID;
                scheduleJSON.title = ent.Title;
                scheduleJSON.start = ConvertToTimestamp(ent.ExpectedStartDate.Value);
                scheduleJSON.end = ConvertToTimestamp(ent.ExpectedEndDate.Value);
                //scheduleJSON.allDay;
                //scheduleJSON.url;
                //scheduleJSON.className;
                scheduleJSON.editable = true;
                //scheduleJSON.source ;
                //scheduleJSON.color;
                //scheduleJSON.backgroundColor;
                //scheduleJSON.borderColor;
                //scheduleJSON.textColor;
                
                scheduleJSONList.Add(scheduleJSON);
            }
        }

        String response = ser.Serialize(scheduleJSONList);
        
        context.Response.Write(response);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

    private long ConvertToTimestamp(DateTime value)
    {


        long epoch = (value.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        return epoch;


    }


}