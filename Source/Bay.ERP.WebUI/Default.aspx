<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="Bay.ERP.Web.UI.Default" %>

<%--<%@ Register Src="~/Controls/Common/CMNDashboardItemView.ascx" TagName="CMNDashboardItemViewEntity"
    TagPrefix="uc" %>--%>
<%@ Register Src="~/Controls/Common/CMNDashboardSchedule.ascx" TagName="CMNDashboardScheduleEntity" TagPrefix="uc" %>
    
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>        Project & Individual Task</h1>
    <div style=" float: right;  margin-right: 25px; margin-top: -30px;">
    <asp:HyperLink ID="hypArtGellaryEvent" runat="server" Text="Art Gallery Event" CssClass="TimeLine"></asp:HyperLink>
                                  |
    <asp:HyperLink ID="hypOfficialEvent" runat="server" Text="Official Event "  CssClass="TimeLine"></asp:HyperLink>                               
    </div>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMNDashboardScheduleEntity ID="ucCMNDashboardScheduleEntity" runat="server" />
        <%--<uc:CMNDashboardItemViewEntity ID="ucCMNDashboardItemViewEntity" runat="server" />--%>
        <br />
      <%--  <div>
            <asp:ListView ID="lvAPMemberFeedback" runat="server" OnItemDataBound="lvAPMemberFeedback_ItemDataBound">
                <LayoutTemplate>
                    <table class="lv" cellpadding="0" cellspacing="0">
                        <tr class="h">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="hi">
                                Details
                            </td>
                            <td class="hi">
                                Title
                            </td>
                            <td class="hi">
                                Department
                            </td>
                            <td class="hi">
                                Employee
                            </td>
                            <td class="hi">
                                Feedback
                            </td>
                            <td class="hi">
                                Feedback Request Date
                            </td>                            
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="rpb">
                                &nbsp;
                            </td>
                        </tr>
                        <tr runat="server" id="itemPlaceholder">
                        </tr>                        
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr class="r">
                        <td class="rp">
                            &nbsp;
                        </td>
                        <td class="i">
                            <asp:HyperLink ID="lnkViewDetails" runat="server" Text="View Details" />
                        </td>
                        <td class="i">
                            <asp:Label ID="lblTitle" runat="server"></asp:Label>
                        </td>
                        <td class="i">
                            <%# Eval("DepartmentID")%>
                        </td>
                        <td class="i">
                            <%# Eval("EmployeeID")%>
                        </td>                        
                        <td class="i">
                            <%# Eval("APFeedbackID")%>
                        </td>
                        <td class="i">
                            <%# Eval("FeedbackRequestDate") != null ? ((DateTime)Eval("FeedbackRequestDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
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
                            <asp:HyperLink ID="lnkViewDetails" runat="server" Text="View Details" />
                        </td>
                        <td class="i">
                            <asp:Label ID="lblTitle" runat="server"></asp:Label>
                        </td>
                        <td class="i">
                            <%# Eval("DepartmentID")%>
                        </td>
                        <td class="i">
                            <%# Eval("EmployeeID")%>
                        </td>                        
                        <td class="i">
                            <%# Eval("APFeedbackID")%>
                        </td>
                        <td class="i">
                            <%# Eval("FeedbackRequestDate") != null ? ((DateTime)Eval("FeedbackRequestDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
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
        </div>--%>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
        <div style="text-align: center; width: 100%; display: none;">
            <h1>
                Construction Module Alpha Release</h1>
            <asp:Button ID="btnSend" runat="server" Text="Send Test Message" OnClick="btnSend_Click"
                Visible="false" />
        </div>
    </div>
</asp:Content>
