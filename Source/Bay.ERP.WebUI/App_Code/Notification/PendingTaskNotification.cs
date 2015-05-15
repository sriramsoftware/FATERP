using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bay.ERP.Web.UI.Manager;

/// <summary>
/// Summary description for PendingTaskNotification
/// </summary>
public static class PendingTaskNotification
{

    public static void pendingList()
    {
        Int64 EmployeeID = 214;

        var forwardedList = APRobot.GetAPForwardInfo_DetailedByEmployee(EmployeeID);
       
        var ProxyList = APRobot.GetApprovalRequests_DetailedByProxyMember(EmployeeID);

        var PendingList = APRobot.GetAllApprovalRequests_DetailedToMemberFeedback(EmployeeID);
    }

}