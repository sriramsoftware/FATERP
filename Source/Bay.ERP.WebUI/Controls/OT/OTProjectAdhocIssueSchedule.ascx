<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTProjectAdhocIssueSchedule.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTProjectAdhocIssueScheduleControl" %>

    <script type='text/javascript'>
        $(document).ready(function () {

            var projcetID = 0;
            projcetID = $("#hydOverviewProjectID").val();

            var url = "../ProjectAdhocSchedulerHandler.ashx?";
            url += "ProjectID=" + projcetID.toString();


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

     <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                   Select Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged"
                            runat="server" Width="236">
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <br />
                <asp:HiddenField ID="hydOverviewProjectID" runat="server" ClientIDMode="Static" />
    <div id="calendar"></div>
    </div>
    </ContentTemplate>
</asp:UpdatePanel>
