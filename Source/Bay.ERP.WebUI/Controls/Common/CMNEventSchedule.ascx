<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNEventSchedule.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNEventScheduleNavigationControl" %>
<script type='text/javascript'>
    $(document).ready(function () {

        var resourceID = 0;
        eventIdentityID = $("#hfOverviewEventIdentityID").val();
        eventCategoryID = $("#hfOverviewEventCategoryID").val();
        ownerMemberID = $("#hfOverviewOwnerMemberID").val();


        var url = "../EventSchedulerHandler.ashx?";
        url += "eventIdentityID=" + eventIdentityID.toString();
        url += "&eventCategoryID=" + eventCategoryID.toString();
        url += "&ownerMemberID=" + ownerMemberID.toString();

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
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Select Category&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlEventCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlEventCategoryID_SelectedIndexChanged"
                        runat="server" Width="236">
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <br />
            <asp:HiddenField ID="hfOverviewEventIdentityID" runat="server" ClientIDMode="Static"
                Value="1" />
            <asp:HiddenField ID="hfOverviewEventCategoryID" runat="server" ClientIDMode="Static" />
             <asp:HiddenField ID="hfOverviewOwnerMemberID" runat="server" ClientIDMode="Static" />
            <div id="calendar">
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
