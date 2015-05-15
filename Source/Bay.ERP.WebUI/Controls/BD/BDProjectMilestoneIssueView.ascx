<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectMilestoneIssueView.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectMilestoneIssueViewControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Project Milestones</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayProjectIssueTreeView ID="treeProjectMilestone" runat="server" ShowCheckBoxesInDocumentNodes="false"
                            ShowCheckBoxes="None">
                        </kti:BayProjectIssueTreeView>
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 600px;">
                <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div>
                    <div class="d-lv-c">
                        <asp:ListView ID="lvOTIssue_Detailed" runat="server" DataSourceID="odsOTIssue_Detailed">
                            <LayoutTemplate>
                                <div class="d-lv">
                                    <div class="d-lv-header">
                                        Some Header will Come Here</div>
                                    <div class="d-lv-container">
                                        <div runat="server" id="itemPlaceholder">
                                        </div>
                                    </div>
                                    <div class="d-lv-FooterContainer">
                                        <div class="d-lv-Footer">
                                            <asp:DataPager ID="dpListView" runat="server" PageSize="5">
                                                <Fields>
                                                    <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="d-lv-PagerItem" FirstPageImageUrl="~/Images/CustomListView/Default/FT.png"
                                                        PreviousPageImageUrl="~/Images/CustomListView/Default/PT.png" ShowFirstPageButton="true"
                                                        ShowPreviousPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false" />
                                                    <asp:NumericPagerField ButtonType="Button" ButtonCount="10" NumericButtonCssClass="d-lv-PagerItemNumeric"
                                                        CurrentPageLabelCssClass="d-lv-PagerItemNumericCurrent" RenderNonBreakingSpacesBetweenControls="false" />
                                                    <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="d-lv-PagerItem" NextPageImageUrl="~/Images/CustomListView/Default/NT.png"
                                                        LastPageImageUrl="~/Images/CustomListView/Default/LT.png" ShowFirstPageButton="false"
                                                        ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="true"
                                                        RenderNonBreakingSpacesBetweenControls="true" />
                                                    <asp:TemplatePagerField>
                                                        <PagerTemplate>
                                                            <div class="d-lv-PagerCount">
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
                                </div>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <div class="d-lv-row">
                                    <div class="lvTemplateTwo">
                                        <div class="row-content">
                                            <div>
                                                <div class="info1Label">
                                                    Title&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("Title")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Issue Number&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    &nbsp;</div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Issue Category&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("IssueCategoryName")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Completion %&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("CompletionPercentage")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Priority&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("IssuePriorityName")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Status&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("IssueStatusName")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Duration&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("Duration")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Notify&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("NotifyBeforeMin")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Expected Start Date&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Actual Start Date&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Expected End Date&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Actual End Date&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Created By&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("MemberFullName")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Create Date&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Description&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("Description")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Remarks %&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("Remarks")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Parent Issue&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("ParentIssueTitle")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Reference Issue&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("ReferenceIssueTitle")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="seperator">
                                        </div>
                                        <div class="action">
                                            <div>
                                                <asp:HyperLink ID="hypEdit" runat="server" Text="Edit" CssClass="CommonButtonLink"></asp:HyperLink>
                                            </div>
                                            <div>
                                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue Detailed?')"
                                                    CommandArgument='<%#Eval("IssueID")%>' UniqueKey="BDProjectMilestoneIssueViewControl_Delete_key" />
                                            </div>
                                            <div>
                                                <asp:HyperLink ID="hypAddSubIssue" runat="server" Text="Add Sub Issue" CssClass="CommonButtonLink"></asp:HyperLink>
                                            </div>
                                            <div>
                                                <asp:HyperLink ID="hypAddReferenceIssue" runat="server" Text="Add Referenced Issue"
                                                    CssClass="CommonButtonLink"></asp:HyperLink>
                                            </div>
                                            <div>
                                                <asp:HyperLink ID="hypAssignedResource" runat="server" Text="Assigned Resource" CssClass="CommonButtonLink"></asp:HyperLink>
                                            </div>
                                            <div>
                                                <kti:SecureLinkButton ID="lnkBtnAddToSchedule" runat="server" CssClass="CommonButtonLink"
                                                    Text="Add To Schedule" CommandName="AddToSchedule" UniqueKey="BDProjectMilestoneIssueViewControl_Add_To_Schedule_key" />
                                            </div>
                                            <div>
                                            </div>
                                        </div>
                                        <div style="clear: both;">
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                <div class="d-lv-alternet-row">
                                    <div class="lvTemplateTwo">
                                        <div class="row-content">
                                            <div>
                                                <div class="info1Label">
                                                    Title&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("Title")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Issue Number&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    &nbsp;</div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Issue Category&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("IssueCategoryName")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Completion %&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("CompletionPercentage")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Priority&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("IssuePriorityName")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Status&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("IssueStatusName")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Duration&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("Duration")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Notify&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("NotifyBeforeMin")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Expected Start Date&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Actual Start Date&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Expected End Date&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Actual End Date&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Created By&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("MemberFullName")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Create Date&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Description&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("Description")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Remarks %&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("Remarks")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                            <div>
                                                <div class="info1Label">
                                                    Parent Issue&nbsp;:&nbsp;</div>
                                                <div class="info1">
                                                    <%# Eval("ParentIssueTitle")%></div>
                                                <div class="infoSeperator">
                                                </div>
                                                <div class="info2Label">
                                                    Reference Issue&nbsp;:&nbsp;</div>
                                                <div class="info2">
                                                    <%# Eval("ReferenceIssueTitle")%></div>
                                                <div style="clear: both;">
                                                </div>
                                            </div>
                                        </div>
                                        <div class="seperator">
                                        </div>
                                        <div class="action">
                                            <div>
                                                <asp:HyperLink ID="hypEdit" runat="server" Text="Edit" CssClass="CommonButtonLink"></asp:HyperLink>
                                            </div>
                                            <div>
                                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue Detailed?')"
                                                    CommandArgument='<%#Eval("IssueID")%>' UniqueKey="BDProjectMilestoneIssueViewControl_Delete_key" />
                                            </div>
                                            <div>
                                                <asp:HyperLink ID="hypAddSubIssue" runat="server" Text="Add Sub Issue" CssClass="CommonButtonLink"></asp:HyperLink>
                                            </div>
                                            <div>
                                                <asp:HyperLink ID="hypAddReferenceIssue" runat="server" Text="Add Referenced Issue"
                                                    CssClass="CommonButtonLink"></asp:HyperLink>
                                            </div>
                                            <div>
                                                <asp:HyperLink ID="hypAssignedResource" runat="server" Text="Assigned Resource" CssClass="CommonButtonLink"></asp:HyperLink>
                                            </div>
                                            <div>
                                                <kti:SecureLinkButton ID="lnkBtnAddToSchedule" runat="server" CssClass="CommonButtonLink"
                                                    Text="Add To Schedule" CommandName="AddToSchedule" UniqueKey="BDProjectMilestoneIssueViewControl_Add_To_Schedule_key" />
                                            </div>
                                        </div>
                                        <div style="clear: both;">
                                        </div>
                                    </div>
                                </div>
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
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
