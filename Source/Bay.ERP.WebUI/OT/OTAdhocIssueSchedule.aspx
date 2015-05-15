<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="OTAdhocIssueSchedule.aspx.cs" Inherits="Bay.ERP.Web.UI.OTAdhocIssueSchedulePage" Title="ERP" %>


<%--
<%@ Register Src="~/Controls/OT/OTAdhocIssueSchedule.ascx" TagName="OTAdhocIssueScheduleEntity" TagPrefix="uc" %>--%>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">    
    
    
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Adhoc Issue Schedule</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    

    <link rel="stylesheet" type="text/css" href="../ThirdParty/fullcalendar153/fullcalendar/fullcalendar.css" />
<link rel="stylesheet" type="text/css" href="../ThirdParty/fullcalendar153/fullcalendar/fullcalendar.print.css" media="print" />
<script type="text/javascript" src="../ThirdParty/fullcalendar153/jquery/jquery-1.7.1.min.js"></script>
<script type="text/javascript" src="../ThirdParty/fullcalendar153/jquery/jquery-ui-1.8.17.custom.min.js"></script>
<script type="text/javascript" src="../ThirdParty/fullcalendar153/fullcalendar/fullcalendar.min.js"></script>

<script type='text/javascript'>
    $(document).ready(function () {
        $('#calendar').fullCalendar({

            editable: true,
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'month,agendaWeek,agendaDay'
            },
            events: "/Bay.ERP.WebUI/SchedulerHandler.ashx",

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

	

	#calendar {
		width: 900px;
		margin: 0 auto;
		}

</style>



<div id="calendar"></div>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>