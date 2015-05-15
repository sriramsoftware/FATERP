<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTContractorIssueSchedule.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTContractorIssueScheduleControl" %>

    <script type='text/javascript'>
        $(document).ready(function () {

            var resourceID = 0;
            resourceID = $("#hfOverviewResourceID").val();
            resourceCategoryID = $("#hfOverviewResourceCategoryID").val();

            var url = "../ResourceSchedulerHandler.ashx?";
            url += "ResourceID=" + resourceID.toString()
            url += "&ResourceCategoryID=" + resourceCategoryID.toString();

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
                       Select Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlContractorID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlContractorID_SelectedIndexChanged"
                            runat="server" Width="236">
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <br />
                <asp:HiddenField ID="hfOverviewResourceID" runat="server" ClientIDMode="Static" />
                <asp:HiddenField ID="hfOverviewResourceCategoryID" runat="server" ClientIDMode="Static"/>
    <div id="calendar"></div>
    </div>
    </ContentTemplate>
</asp:UpdatePanel>
