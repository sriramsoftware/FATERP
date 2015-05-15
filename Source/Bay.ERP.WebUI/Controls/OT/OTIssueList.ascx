<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 19-Mar-2013, 12:48:18
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTIssueList.ascx.cs" Inherits="Bay.ERP.Web.UI.OTIssueListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
         <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvOTIssue" runat="server" DataSourceID="odsOTIssue" OnItemCommand="lvOTIssue_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Issue Identity Category
                                    </td>
                                    <td class="hi">
                                        Issue Category
                                    </td>
                                    <td class="hi">
                                        Parent Issue
                                    </td>
                                    <td class="hi">
                                        Reference
                                    </td>
                                    <td class="hi">
                                        Title
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi">
                                        Issue Priority
                                    </td>
                                    <td class="hi">
                                        Completion Percentage
                                    </td>
                                    <td class="hi">
                                        Issue Status
                                    </td>
                                    <td class="hi">
                                        Created By Member
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi">
                                        Duration
                                    </td>
                                    <td class="hi">
                                        Expected Start Date
                                    </td>
                                    <td class="hi">
                                        Expected End Date
                                    </td>
                                    <td class="hi">
                                        Actual Start Date
                                    </td>
                                    <td class="hi">
                                        Actual End Date
                                    </td>
                                    <td class="hi">
                                        Notify Before Min
                                    </td>
                                    <td class="hi">
                                        Is Notify Completed
                                    </td>
                                    <td class="hi">
                                        Supervisor Employee
                                    </td>
                                    <td class="hi">
                                        Assigned To Employee
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Reference Issue
                                    </td>
                                    <td class="hi">
                                        Is Removed
                                    </td>
                                    <td class="hi">
                                        Supervisor Agreed
                                    </td>
                                    <td class="hi">
                                        Modified By Supervisor Date Time
                                    </td>
                                    <td class="hi">
                                        I P
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
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
                                <tr>
                                    <td colspan="100%">
                                        <div class="lv-FooterContainer">
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="15">
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
                                    <%# Eval("IssueIdentityCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssueCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ParentIssueID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Title")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssuePriorityID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompletionPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssueStatusID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByMemberID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Duration")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("NotifyBeforeMin")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsNotifyCompleted") != null ? (((Boolean)Eval("IsNotifyCompleted")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AssignedToEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferenceIssueID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorAgreed") != null ? (((Boolean)Eval("SupervisorAgreed")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ModifiedBySupervisorDateTime") != null ? ((DateTime)Eval("ModifiedBySupervisorDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("IssueID")%>' UniqueKey="OTIssue_lvOTIssue_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue?')"
                                        CommandArgument='<%#Eval("IssueID")%>' UniqueKey="OTIssue_lvOTIssue_Edit_key" />
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
                                    <%# Eval("IssueIdentityCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssueCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ParentIssueID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Title")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssuePriorityID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompletionPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssueStatusID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByMemberID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Duration")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("NotifyBeforeMin")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsNotifyCompleted") != null ? (((Boolean)Eval("IsNotifyCompleted")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AssignedToEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferenceIssueID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorAgreed") != null ? (((Boolean)Eval("SupervisorAgreed")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ModifiedBySupervisorDateTime") != null ? ((DateTime)Eval("ModifiedBySupervisorDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("IssueID")%>' UniqueKey="OTIssue_lvOTIssue_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue?')"
                                        CommandArgument='<%#Eval("IssueID")%>' UniqueKey="OTIssue_lvOTIssue_Edit_key" />
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
                <asp:ObjectDataSource ID="odsOTIssue" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.OTIssueDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsOTIssue_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
