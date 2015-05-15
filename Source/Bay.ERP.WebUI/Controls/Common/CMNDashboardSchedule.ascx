<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNDashboardSchedule.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNDashboardScheduleControl" %>
<script type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#dialog").append($("<iframe />").attr("src", "CM/CMWorkOrder.aspx")).dialog({
                height: 540,
                width: 800,
                modal: true
            });

            $("#opener").click(function () {
                $("#dialog").dialog("open");
                return false;
            });
        });
    }

</script>
<script type='text/javascript'>
    function BindCalender() {
        $(document).ready(function () {

            var projcetID = 0;
            var currentEmployeeID = 0;
            projcetID = $("#hydOverviewProjectID").val();
            currentEmployeeID = $("#hypOverviewCurrentEmployeeID").val();

            var url = "./DashboardSchedulerHandler.ashx?";
            url += "ProjectID=" + projcetID.toString();
            url += "&CurrentEmployeeID=" + currentEmployeeID.toString();

            $('#calendar').fullCalendar({
                selectable: true,
                selectHelper: true,
                select: function (start, end, allDay) {
                    var title = prompt('Event Title:');
                    if (title) {
                        $("#txtTitle").val(title);
                        $("#txtStartDate").val(start);
                        $("#txtEndDate").val(end);
                        if (title != null) {
                            document.getElementById('<%=btnCreateEvent.ClientID %>').click();
                        }
                        calendar.fullCalendar('renderEvent',
						{
						    title: title,
						    start: start,
						    end: end,
						    allDay: allDay
						},
						true // make the event "stick"
					);
                    }
                    calendar.fullCalendar('unselect');
                },
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
                eventRender: function (event, element, view) {

                    //  element.qtip({ content: "My Event: " + event.title });

                },

                loading: function (bool) {

                }
            });

        });
    }

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
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
            Sys.Application.add_load(BindCalender);
        </script>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="display: none;">
                <asp:Button ID="btnCreateEvent" runat="server" ClientIDMode="Static" OnClick="btnCreateEvent_Click" />
                <asp:TextBox ID="txtTitle" runat="server" ClientIDMode="Static"></asp:TextBox>
                <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static"></asp:TextBox>
                <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static"></asp:TextBox>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Select Project&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true"
                        OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged" runat="server" Width="236">
                    </asp:DropDownList>
                    <%--   <div id="dialog" title="Basic dialog">
    <p>This is the default dialog which is useful for displaying information. The dialog window can be moved, resized and closed with the 'x' icon.</p>
</div>
                    </div>--%>
                    <%--  <asp:HyperLink id='opener' runat='server'>Open Dialog</HyperLink>--%>
                </div>
                <br />
                <br />
                <asp:HiddenField ID="hydOverviewProjectID" runat="server" ClientIDMode="Static" />
                <asp:HiddenField ID="hypOverviewCurrentEmployeeID" runat="server" ClientIDMode="Static" />
                <div id="calendar" style="z-index: 9999">
                </div>
            </div>
            <ajaxToolkit:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server" PopupControlID="Panel1"
                DynamicServicePath="" Enabled="True" TargetControlID="lnkSavePopup" OkControlID="lnkSavePopup"
                CancelControlID="btnClose" BackgroundCssClass="modalBackground">
            </ajaxToolkit:ModalPopupExtender>
            <div style="display: inline-block;">
                <asp:Panel ID="Panel1" runat="server" Width="1200" Height="600" BorderWidth="1" Style="display: none;">
                    <div class="modalPanelBackground">
                        <br />
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                &nbsp;
                            </div>
                            <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                                <asp:Button ID="btnClose" runat="server" Text="X"></asp:Button>
                            </div>
                        </div>
                        <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                            padding-left: 10px;">
                            <tr>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="imgSideShadowLeft" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                                <th class="topleft">
                                </th>
                                <td class="tbl-border-top">
                                    &nbsp;
                                </td>
                                <th class="topright">
                                </th>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="imgSideShadowRight" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                            </tr>
                            <tr>
                                <td class="tbl-border-left">
                                </td>
                                <td>
                                    <div class="table-content" style="width: 1080px; display: inline-block; overflow-y: auto;
                                        max-height: 420px;">
                                        <div class="page-content">
                                            <b>Notification</b>
                                            <div>
                                                <div style="float: left; width: 600px; overflow: auto;">
                                                    <div class="contentSubTittle">
                                                        Pending Approval of Requisition and Work Order:&nbsp;
                                                        <asp:Label ID="lblPendingApproval" runat="server"></asp:Label>
                                                    </div>
                                                    <div style="width: 95%">
                                                        <asp:ListView ID="lvAPMemberFeedback" runat="server" OnItemDataBound="lvAPMemberFeedback_ItemDataBound">
                                                            <LayoutTemplate>
                                                                <table class="lv" cellpadding="0" cellspacing="0">
                                                                    <tr class="h">
                                                                        <td class="hi" style="width: 20px;">
                                                                            Details
                                                                        </td>
                                                                        <td class="hi" style="width: 120px;">
                                                                            Title
                                                                        </td>
                                                                    </tr>
                                                                    <tr runat="server" id="itemPlaceholder">
                                                                    </tr>
                                                                </table>
                                                            </LayoutTemplate>
                                                            <ItemTemplate>
                                                                <tr class="r">
                                                                    <td class="i">
                                                                        <asp:HyperLink ID="lnkViewDetails" runat="server" Text="Details" />
                                                                    </td>
                                                                    <td class="i">
                                                                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                            <AlternatingItemTemplate>
                                                                <tr class="ar">
                                                                    <td class="i">
                                                                        <asp:HyperLink ID="lnkViewDetails" runat="server" Text="Details" />
                                                                    </td>
                                                                    <td class="i">
                                                                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </AlternatingItemTemplate>
                                                            <EmptyDataTemplate>
                                                                <div class="edr">
                                                                    No Records Found To Display
                                                                </div>
                                                            </EmptyDataTemplate>
                                                        </asp:ListView>
                                                    </div>
                                                    <div class="contentSubTittle">
                                                        Proxy Request:&nbsp;
                                                        <asp:Label ID="lblPendingProxy" runat="server"></asp:Label>
                                                    </div>
                                                    <div style="width: 95%">
                                                        <asp:ListView ID="lvAPProxyMemberFeedback" runat="server" OnItemDataBound="lvAPProxyMemberFeedback_ItemDataBound">
                                                            <LayoutTemplate>
                                                                <table class="lv" cellpadding="0" cellspacing="0">
                                                                    <tr class="h">
                                                                        <td class="hi" style="width: 20px;">
                                                                            Details
                                                                        </td>
                                                                        <td class="hi" style="width: 100px;">
                                                                            Title
                                                                        </td>
                                                                    </tr>
                                                                    <tr runat="server" id="itemPlaceholder">
                                                                    </tr>
                                                                </table>
                                                            </LayoutTemplate>
                                                            <ItemTemplate>
                                                                <tr class="r">
                                                                    <td class="i">
                                                                        <asp:HyperLink ID="lnkViewDetails" runat="server" Text="Details" />
                                                                    </td>
                                                                    <td class="i">
                                                                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </ItemTemplate>
                                                            <AlternatingItemTemplate>
                                                                <tr class="ar">
                                                                    <td class="i">
                                                                        <asp:HyperLink ID="lnkViewDetails" runat="server" Text="Details" />
                                                                    </td>
                                                                    <td class="i">
                                                                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                                                                    </td>
                                                                </tr>
                                                            </AlternatingItemTemplate>
                                                            <EmptyDataTemplate>
                                                                <div class="edr">
                                                                    No Records Found To Display
                                                                </div>
                                                            </EmptyDataTemplate>
                                                        </asp:ListView>
                                                    </div>
                                                    <div class="contentSubTittle">
                                                        Forward Request:&nbsp;
                                                        <asp:Label ID="lblForward" runat="server"></asp:Label>
                                                    </div>
                                                    <div>
                                                        <div style="width: 95%">
                                                            <asp:ListView ID="lvAPForwardMemberFeedback" runat="server" OnItemDataBound="lvAPForwardMemberFeedback_ItemDataBound">
                                                                <LayoutTemplate>
                                                                    <table class="lv" cellpadding="0" cellspacing="0">
                                                                        <tr class="h">
                                                                            <td class="hi">
                                                                                Details
                                                                            </td>
                                                                            <td class="hi">
                                                                                Title
                                                                            </td>
                                                                        </tr>
                                                                        <tr runat="server" id="itemPlaceholder">
                                                                        </tr>
                                                                    </table>
                                                                </LayoutTemplate>
                                                                <ItemTemplate>
                                                                    <tr class="r">
                                                                        <td class="i">
                                                                            <asp:HyperLink ID="lnkViewDetails" runat="server" Text="Details" />
                                                                        </td>
                                                                        <td class="i">
                                                                            <asp:Label ID="lblTitle" runat="server"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                </ItemTemplate>
                                                                <AlternatingItemTemplate>
                                                                    <tr class="ar">
                                                                        <td class="i">
                                                                            <asp:HyperLink ID="lnkViewDetails" runat="server" Text="Details" />
                                                                        </td>
                                                                        <td class="i">
                                                                            <asp:Label ID="lblTitle" runat="server"></asp:Label>
                                                                        </td>
                                                                    </tr>
                                                                </AlternatingItemTemplate>
                                                                <EmptyDataTemplate>
                                                                    <div class="edr">
                                                                        No Records Found To Display
                                                                    </div>
                                                                </EmptyDataTemplate>
                                                            </asp:ListView>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="contentSeperator">
                                        </div>
                                        <div style="float: left; width: 450px; overflow-y: hidden;">
                                            <b>Recently Approved Requisition</b>
                                            <div class="TableRow" style="width: 100%;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Requisition#</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
                                            <div>
                                                <div class="lv-c">
                                                    <asp:ListView ID="lvREQRequisition" runat="server" DataSourceID="odsREQRequisition"
                                                        OnItemDataBound="lvREQRequisition_ItemDataBound">
                                                        <LayoutTemplate>
                                                            <table class="lv" cellpadding="0" cellspacing="0">
                                                                <tr class="h">
                                                                    <td class="rp">
                                                                        &nbsp;
                                                                    </td>
                                                                    <td class="hi">
                                                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProject"
                                                                            CommandName="Sort" Text="Project" CommandArgument="BDProject.ProjectName" />
                                                                    </td>
                                                                    <td class="hi" style="width: 200px;">
                                                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisitionNo"
                                                                            CommandName="Sort" Text="Requisition No & Items" CommandArgument="REQRequisition.RequisitionNo" />
                                                                    </td>
                                                                    <td class="hi" style="width: 100px;">
                                                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisitionDate"
                                                                            CommandName="Sort" Text="Requisition Date" CommandArgument="REQRequisition.RequisitionDate" />
                                                                    </td>
                                                                    <td class="rpb">
                                                                        &nbsp;
                                                                    </td>
                                                                </tr>
                                                                <tr runat="server" id="itemPlaceholder">
                                                                </tr>
                                                                <tr style="display: none;">
                                                                    <td colspan="100%">
                                                                        <div class="lv-FooterContainer">
                                                                            <div class="lv-Footer">
                                                                                <asp:DataPager ID="dpListView" runat="server" PageSize="100">
                                                                                    <Fields>
                                                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" FirstPageImageUrl="~/Images/CustomListView/Default/FT.png"
                                                                                            PreviousPageImageUrl="~/Images/CustomListView/Default/PT.png" ShowFirstPageButton="true"
                                                                                            ShowPreviousPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false" />
                                                                                        <asp:NumericPagerField ButtonType="Button" ButtonCount="10" NumericButtonCssClass="lv-PagerItemNumeric"
                                                                                            CurrentPageLabelCssClass="lv-PagerItemNumericCurrent" RenderNonBreakingSpacesBetweenControls="false" />
                                                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" NextPageImageUrl="~/Images/CustomListView/Default/NT.png"
                                                                                            LastPageImageUrl="~/Images/CustomListView/Default/LT.png" ShowFirstPageButton="false"
                                                                                            ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="true"
                                                                                            RenderNonBreakingSpacesBetweenControls="true" />
                                                                                        <asp:TemplatePagerField>
                                                                                            <PagerTemplate>
                                                                                                <div class="lv-PagerCount">
                                                                                                    Items <span>
                                                                                                        <%# Container.StartRowIndex +1%></span> to <span>
                                                                                                            <%# (Container.StartRowIndex+Container.PageSize ) < Container.TotalRowCount ? (Container.StartRowIndex+Container.PageSize) : Container.TotalRowCount %></span>
                                                                                                    of <span>
                                                                                                        <%# Container.TotalRowCount%></span>
                                                                                                </div>
                                                                                            </PagerTemplate>
                                                                                        </asp:TemplatePagerField>
                                                                                    </Fields>
                                                                                </asp:DataPager>
                                                                            </div>
                                                                        </div>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </LayoutTemplate>
                                                        <ItemTemplate>
                                                            <tr class="r">
                                                                <td class="rp">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="i">
                                                                    <%# Eval("ProjectName")%>
                                                                </td>
                                                                <td class="i">
                                                                    <asp:HyperLink ID="hypRequisition" runat="server" ClientIDMode="Static" Text='<%# Eval("RequisitionNo")%>'
                                                                        ToolTip="Please Click Here To Edit The Template Items!" CssClass="CommonLink"></asp:HyperLink>
                                                                    <br />
                                                                    <asp:Label ID="lblRequisitionItem" runat="server"></asp:Label>
                                                                </td>
                                                                <td class="i">
                                                                    <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                                                </td>
                                                                <td class="rp">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="rpb">
                                                                    &nbsp;
                                                                </td>
                                                            </tr>
                                                        </ItemTemplate>
                                                        <AlternatingItemTemplate>
                                                            <tr class="ar">
                                                                <td class="rp">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="i">
                                                                    <%# Eval("ProjectName")%>
                                                                </td>
                                                                <td class="i">
                                                                    <asp:HyperLink ID="hypRequisition" runat="server" Text='<%# Eval("RequisitionNo")%>'
                                                                        ToolTip="Please Click Here To Edit The Template Items!" CssClass="CommonLink"></asp:HyperLink>
                                                                    <br />
                                                                    <asp:Label ID="lblRequisitionItem" runat="server"></asp:Label>
                                                                </td>
                                                                <td class="i">
                                                                    <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                                                </td>
                                                                <td class="rp">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="rpb">
                                                                    &nbsp;
                                                                </td>
                                                            </tr>
                                                        </AlternatingItemTemplate>
                                                        <EmptyDataTemplate>
                                                            <div class="edr">
                                                                No Records Found To Display
                                                            </div>
                                                        </EmptyDataTemplate>
                                                    </asp:ListView>
                                                </div>
                                                <asp:ObjectDataSource ID="odsREQRequisition" runat="server" SelectMethod="GetPagedData"
                                                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionDashboard_CustomDataSource"
                                                    SortParameterName="sortExpression" OnSelecting="odsREQRequisition_Selecting">
                                                    <SelectParameters>
                                                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                                                        <asp:Parameter Name="pageSize" Type="Int32" />
                                                        <asp:Parameter Name="sortExpression" Type="String" />
                                                        <asp:Parameter Name="filterExpression" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                            </div>
                                        </div>
                                    </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent">
                            <asp:LinkButton ID="lnkSavePopup" runat="server"></asp:LinkButton>
                        </div>
                    </div>
            </div>
            <div class="quick-links">
            </div>
            <div class="clear">
            </div>
        </div>
        </td>
        <td class="tbl-border-right">
        </td>
        </tr>
        <tr>
            <th class="sized bottomleft">
            </th>
            <td class="tbl-border-bottom">
                &nbsp;
            </td>
            <th class="sized bottomright">
            </th>
        </tr>
        </table> </div> </asp:Panel> </div>

    </ContentTemplate>
</asp:UpdatePanel>
