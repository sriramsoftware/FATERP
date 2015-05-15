<%@ WebHandler Language="C#" Class="EventSchedulerHandler" %>

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


public class EventSchedulerHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        String eventIdentityID = null;
        String eventCategoryID = null;
        String ownerMemberID = null;
        if (context.Request.QueryString["eventIdentityID"] != null)
        {
            eventIdentityID = context.Request.QueryString["eventIdentityID"].ToString();
            eventCategoryID = context.Request.QueryString["eventCategoryID"].ToString();
            ownerMemberID = context.Request.QueryString["ownerMemberID"].ToString();
        }

        context.Response.ContentType = "text/json";
        context.Response.Expires = -1;
        System.Web.Script.Serialization.JavaScriptSerializer ser = new System.Web.Script.Serialization.JavaScriptSerializer();

        // handeling the request
        //ClientPersonalizedProductInfoJSON cppij = ser.Deserialize<ClientPersonalizedProductInfoJSON>(jsonString);

        // for response        
        IList<Bay.ERP.Common.BusinessEntity.ScheduleJSON> scheduleJSONList = new List<Bay.ERP.Common.BusinessEntity.ScheduleJSON>();

        Int64 EventIdentityID, EventCategoryID;
        Int64.TryParse(eventIdentityID, out EventIdentityID);
        Int64.TryParse(eventCategoryID, out EventCategoryID);

        if (EventIdentityID > 0 && EventCategoryID > 0)
        {
            String fe1=SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_EventIdentityCategoryID,EventIdentityID.ToString(),SQLMatchType.Equal);
            String fe2=SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_EventCategoryID,EventCategoryID.ToString(),SQLMatchType.Equal);
            String fe3 = SqlExpressionBuilder.PrepareFilterExpression(CMNEventEntity.FLD_NAME_OwnerMemberID, ownerMemberID.ToString(), SQLMatchType.Equal);
            
            String fe4 = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe3, SQLJoinType.AND, fe4);

            IList<CMNEventEntity> eventEntityList = FCCCMNEvent.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (eventEntityList != null && eventEntityList.Count > 0)
            {
                foreach (CMNEventEntity ent in eventEntityList)
                {
                    Bay.ERP.Common.BusinessEntity.ScheduleJSON scheduleJSON = new Bay.ERP.Common.BusinessEntity.ScheduleJSON();
                    scheduleJSON.id = ent.EventID;
                    scheduleJSON.title = ent.Title;
                    scheduleJSON.start = ConvertToTimestamp(ent.ExpectedStartDate);
                    if (ent.ExpectedEndDate.HasValue)
                    {
                        scheduleJSON.end = ConvertToTimestamp(ent.ExpectedEndDate.Value);
                    }
                    else
                    {
                        scheduleJSON.end = ConvertToTimestamp(ent.ExpectedStartDate);
                    }
                    scheduleJSON.allDay = ent.IsAllDay;
                    if (ent.WebsiteURL.IsNotNullOrEmpty())
                    {
                        scheduleJSON.url=ent.WebsiteURL.ToString();
                    }

                    String NavUrl = UrlHelper.BuildSecureUrl("CMNEvent.aspx", string.Empty, "do", "EditDetails", UrlConstants.OVERVIEW_EVENT_ID, ent.EventID.ToString(),UrlConstants.OVERVIEW_EVENT_IDENTITY_CATEGORY_ID,ent.EventIdentityCategoryID.ToString()).ToString();
                    scheduleJSON.url = NavUrl;
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