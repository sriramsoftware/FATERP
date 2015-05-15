<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 03-Oct-2012, 03:53:48
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MyAPForwardList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MyAPForwardListControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
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
                            <td class="hi" style="width: 200px;">
                                Title
                            </td>
                             <td class="hi">
                                Type
                            </td>
                            <td class="hi">
                                Department
                            </td>
                            <td class="hi" style="width: 200px; display:none;">
                                Employee
                            </td>
                            <td class="hi">
                                Feedback
                            </td>
                            <td class="hi">
                                Comment Request Date
                            </td>          
                            <td class="hi">
                                Comment Submit Date
                            </td>          
                            <td class="hi">
                                Approval Status
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
                            <asp:Label ID="lblAPType" runat="server"></asp:Label>
                        </td>
                        <td class="i">
                            <%# Eval("MDDepartmentName")%>
                        </td>
                        <td class="i" style="display:none;">
                            <%# Eval("MemberFullName")%>
                        </td>                        
                        <td class="i">
                            <asp:Label ID="lblAPFeedbackName" runat="server"></asp:Label>
                        </td>
                        <td class="i">
                            <%# Eval("CommentRequestDate") != null ? ((DateTime)Eval("CommentRequestDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                        </td>
                        <td class="i">
                            <%# Eval("CommentSubmitDate") != null ? ((DateTime)Eval("CommentSubmitDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                        </td>
                        <td class="i">
                            <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Show Approval Status" />
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
                            <asp:Label ID="lblAPType" runat="server"></asp:Label>
                        </td>
                        <td class="i">
                            <%# Eval("MDDepartmentName")%>
                        </td>
                        <td class="i" style="display:none;">
                            <%# Eval("MemberFullName")%>
                        </td>                        
                        <td class="i">
                            <asp:Label ID="lblAPFeedbackName" runat="server"></asp:Label>
                        </td>
                        <td class="i">
                            <%# Eval("CommentRequestDate") != null ? ((DateTime)Eval("CommentRequestDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                        </td>
                         <td class="i">
                            <%# Eval("CommentSubmitDate") != null ? ((DateTime)Eval("CommentSubmitDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                        </td>
                        <td class="i">
                            <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Show Approval Status" />
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
    </ContentTemplate>
</asp:UpdatePanel>
