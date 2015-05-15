<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"  CodeFile="CalenderTest.aspx.cs" Inherits="Bay.ERP.Web.UI.OTCalenderTest" Title="ERP" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Add Adhoc Issue</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">

<script type='text/javascript'>
    $(document).ready(function () {

        var projcetID = 0;

        projcetID = $("#hydOverviewProjectID").val();

        var url = "../SchedulerHandler.ashx?";
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

	body {
		margin-top: 40px;
		text-align: center;
		font-size: 14px;
		font-family: "Lucida Grande",Helvetica,Arial,Verdana,sans-serif;
		}

	#calendar {
		width: 900px;
		margin: 0 auto;
		}

</style>

    <div>
    <asp:HiddenField ID="hydOverviewProjectID" runat="server" ClientIDMode="Static" />
    <div id="calendar"></div>
    </div>

</div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>