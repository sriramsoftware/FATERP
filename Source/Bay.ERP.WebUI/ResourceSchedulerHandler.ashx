<%@ WebHandler Language="C#" Class="ResourceSchedulerHandler" %>

using System;
using System.Collections.Generic;
using System.Web;
using System.IO;


public class ResourceSchedulerHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        String resourceID = null;
        String resourceCategoryID = null;
        if (context.Request.QueryString["ResourceID"] != null)
        {
            resourceID = context.Request.QueryString["ResourceID"].ToString();
            resourceCategoryID = context.Request.QueryString["ResourceCategoryID"].ToString();
        }

        context.Response.ContentType = "text/json";
        context.Response.Expires = -1;
        System.Web.Script.Serialization.JavaScriptSerializer ser = new System.Web.Script.Serialization.JavaScriptSerializer();

        // handeling the request
        //ClientPersonalizedProductInfoJSON cppij = ser.Deserialize<ClientPersonalizedProductInfoJSON>(jsonString);

        // for response        
        IList<Bay.ERP.Common.BusinessEntity.ScheduleJSON> scheduleJSONList = new List<Bay.ERP.Common.BusinessEntity.ScheduleJSON>();
        
        Int64 ResourceID, ResourceCategoryID;
        Int64.TryParse(resourceID, out ResourceID);
        Int64.TryParse(resourceCategoryID, out ResourceCategoryID);

        if (ResourceID > 0 && ResourceCategoryID > 0)
        {
            IList<Bay.ERP.Common.BusinessEntities.OTResourceIssueSchedule_CustomEntity> resourceIssueList = Bay.ERP.FacadeCreator.FacadeContext.FCCOTResourceIssueSchedule_Custom.GetFacadeCreate().GetIL(ResourceID, ResourceCategoryID);

            if (resourceIssueList != null && resourceIssueList.Count > 0)
            {
                foreach (Bay.ERP.Common.BusinessEntities.OTResourceIssueSchedule_CustomEntity ent in resourceIssueList)
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
        }

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