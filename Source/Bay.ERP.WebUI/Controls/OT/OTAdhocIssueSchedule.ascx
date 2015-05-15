<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTAdhocIssueSchedule.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTAdhocIssueScheduleControl" %>

<link rel="stylesheet" type="text/css" href="~/ThirdParty/fullcalendar153/fullcalendar/fullcalendar.css" />
<link rel="stylesheet" type="text/css" href="~/ThirdParty/fullcalendar153/fullcalendar/fullcalendar.print.css" media="print" />
<script type="text/javascript" src="~/ThirdParty/fullcalendar153/jquery/jquery-1.7.1.min.js"></script>
<script type="text/javascript" src="~/ThirdParty/fullcalendar153/jquery/jquery-ui-1.8.17.custom.min.js"></script>
<script type="text/javascript" src="~/ThirdParty/fullcalendar153/fullcalendar/fullcalendar.min.js"></script>

    <script type='text/javascript'>
        $(document).ready(function () {
            $('#calendar').fullCalendar({

                editable: true,
                header: {
                    left: 'prev,next today',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                events: "../SchedulerHandler.ashx",

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

<%--	body {
		margin-top: 40px;
		text-align: center;
		font-size: 14px;
		font-family: "Lucida Grande",Helvetica,Arial,Verdana,sans-serif;
		}--%>

	#calendar {
		width: 900px;
		margin: 0 auto;
		}

</style>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
     <div>
    <div id="calendar"></div>
    </div>
    </ContentTemplate>
</asp:UpdatePanel>

