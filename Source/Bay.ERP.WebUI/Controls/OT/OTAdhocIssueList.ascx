<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTAdhocIssueList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTAdhocIssueListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div class="TableRow" style="width: 100%; padding-left: 600px;">
                <div class="TableFormLeble" style="text-align: right;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Issue No, Title, Priority# Or Status</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="listContentTitle">
                <asp:Label ID="lblIssueList" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <div class="d-lv-c">
                    <asp:ListView ID="lvOTIssue_Detailed" runat="server" DataSourceID="odsOTIssue_Detailed"
                        OnItemDataBound="lvOTIssue_Detailed_ItemDataBound" OnItemCommand="lvOTIssue_Detailed_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="hi" style="width: 80px;">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 30px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByIssueNo"
                                            CommandName="Sort" Text="Issue No" CommandArgument="OTIssue.IssueID" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Issue Identity Category
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByCategory"
                                            CommandName="Sort" Text="Category" CommandArgument="MDIssueCategory.Name" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Parent Issue
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Reference
                                    </td>
                                    <td class="hi" style="width: 150px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByTitle"
                                            CommandName="Sort" Text="Title" CommandArgument="OTIssue.Title" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPriority"
                                            CommandName="Sort" Text="Priority" CommandArgument="MDIssuePriority.Name" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Description
                                    </td>
                                    <td class="hi" style="width: 165px;">
                                        Member
                                    </td>
                                    <td class="hi" style="width: 100px;">
                                        Expected
                                    </td>
                                    <td class="hi" style="width: 100px;">
                                        Actual
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Notify Before Min
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Is Notify Completed
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Remarks
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Reference Issue
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Is Removed
                                    </td>
                                    <td class="hi" style="width: 50px;">
                                        Supervisor Agreed
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Modified By Supervisor Date Time
                                    </td>
                                    <td class="hi" style="display: none;">
                                        I P
                                    </td>
                                    <td class="his" style="width: 50px;">
                                        EDIT
                                    </td>
                                    <td class="his" style="display: none;">
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
                                <td class="i">
                                    <asp:Button ID="btnCompletedLV" Text="Complete" runat="server" CommandName="UpdateItem"
                                        OnClientClick="return confirm('Are you sure to Complete?')" CommandArgument='<%#Eval("IssueID")%>'
                                        ToolTip='<%# Eval("CompletionPercentage")%>'></asp:Button>
                                    <%#Decimal.Round((Decimal)Eval("CompletionPercentage"),0)%>%
                                </td>
                                <td class="i">
                               
                                    <%# Eval("IssueID")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IssueIdentityCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssueCategoryName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ParentIssueID")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssueStatusName")%>:&nbsp<asp:HyperLink ID="hypIssueReport" runat="server"
                                        CssClass="CommonButtonLink" Text='<%# Eval("Title")%>' CommandName="IssueReport"
                                        CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblIssuePriorityNameLV" runat="server" Text='<%# Eval("IssuePriorityName")%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <b>Created</b>:&nbsp;<%# Eval("MemberFullName")%>
                                    <b>Supervisor</b>:&nbsp;<%# Eval("SupervisorFullName")%>
                                    <b>Assigned</b>:&nbsp;<%# Eval("AssignedToFullName")%>
                                </td>
                                <td class="i">
                                    <b>Create</b>:&nbsp<%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <b>Start</b>:&nbsp<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <br />
                                    <b>End</b>:&nbsp<asp:Label ID="lblExpectedEndDateLV" runat="server" Text='<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <b>Start</b>:&nbsp<%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <br />
                                    <b>End</b>:&nbsp<%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("NotifyBeforeMin")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsNotifyCompleted") != null ? (((Boolean)Eval("IsNotifyCompleted")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ReferenceIssueID")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblSupervisorAgreedLV" runat="server" Text='<%# Eval("SupervisorAgreed") != null ? (((Boolean)Eval("SupervisorAgreed")) ? "Yes" : "No") : ""%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ModifiedBySupervisorDateTime") != null ? ((DateTime)Eval("ModifiedBySupervisorDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEdit" runat="server" Text="Log Time" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypEditDetails" runat="server" Text="Edit" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypAssignedResource" runat="server" Text="Assigned" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Visible="false" Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue?')"
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
                                <td class="i">
                                    <asp:Button ID="btnCompletedLV" runat="server" CommandName="UpdateItem" Text="Complete"
                                        OnClientClick="return confirm('Are you sure to Complete?')" CommandArgument='<%#Eval("IssueID")%>'
                                        ToolTip='<%# Eval("CompletionPercentage")%>'></asp:Button>
                                    <%# Decimal.Round((Decimal)Eval("CompletionPercentage"),0)%>%
                                </td>
                                <td class="i">
                               
                                    <%# Eval("IssueID")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IssueIdentityCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssueCategoryName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ParentIssueID")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssueStatusName")%>:&nbsp<asp:HyperLink ID="hypIssueReport" runat="server"
                                        CssClass="CommonButtonLink" Text='<%# Eval("Title")%>' CommandName="IssueReport"
                                        CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblIssuePriorityNameLV" runat="server" Text='<%# Eval("IssuePriorityName")%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <b>Created</b>:&nbsp;<%# Eval("MemberFullName")%>
                                    <b>Supervisor</b>:&nbsp;<%# Eval("SupervisorFullName")%>
                                    <b>Assigned</b>:&nbsp;<%# Eval("AssignedToFullName")%>
                                </td>
                                <td class="i">
                                    <b>Create</b>:&nbsp<%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <b>Start</b>:&nbsp<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <br />
                                    <b>End</b>:&nbsp<asp:Label ID="lblExpectedEndDateLV" runat="server" Text='<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <b>Start</b>:&nbsp<%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <br />
                                    <b>End</b>:&nbsp<%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("NotifyBeforeMin")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsNotifyCompleted") != null ? (((Boolean)Eval("IsNotifyCompleted")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ReferenceIssueID")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblSupervisorAgreedLV" runat="server" Text='<%# Eval("SupervisorAgreed") != null ? (((Boolean)Eval("SupervisorAgreed")) ? "Yes" : "No") : ""%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ModifiedBySupervisorDateTime") != null ? ((DateTime)Eval("ModifiedBySupervisorDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEdit" runat="server" Text="Log Time" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypEditDetails" runat="server" Text="Edit" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypAssignedResource" runat="server" Text="Assigned" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Visible="false" Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Issue?')"
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
                            <div class="d-edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsOTIssue_Detailed" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.OTIssue_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsOTIssue_Detailed_Selecting">
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
