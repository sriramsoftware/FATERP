<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 22-Jan-2013, 03:28:28
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMCommunicationSchedule.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMCommunicationScheduleControl" %>

<script type='text/javascript'>
    $(document).ready(function () {

        var resourceID = 0;
        eventIdentityID = $("#hfOverviewEmployeeID").val();


        var url = "../CRMCommunicationSchedulerHandler.ashx?";
        url += "CurrentEmployeeID=" + eventIdentityID.toString();

        $('#calendar').fullCalendar({

            editable: true,
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'month,agendaWeek,agendaDay'
            },
            events: url,

            eventDrop: function (event, delta) {
                alert(event.title + ' was moved ' + delta + ' days\n' +
					'(should probably update your database)');
            },

            loading: function (bool) {

            }
        });

    });

</script>
<style type="text/css">
    #calendar
    {
        width: 900px;
        margin: 0 auto;
    }
</style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
          
            <asp:HiddenField ID="hfOverviewEmployeeID" runat="server" ClientIDMode="Static"
                Value="1" />
            <div id="calendar">
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
