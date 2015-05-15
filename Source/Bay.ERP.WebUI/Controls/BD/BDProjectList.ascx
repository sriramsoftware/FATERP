<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectList.ascx.cs" Inherits="Bay.ERP.Web.UI.BDProjectListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvBDProject" runat="server" DataSourceID="odsBDProject" OnItemDataBound="lvBDProject_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProjectCode"
                                                CommandName="Sort" Text="Project Code" CommandArgument="BDProject.ProjectCode" />
                                        </td>
                                        <td class="hi" style="width: 200px;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProjectName"
                                                CommandName="Sort" Text="Project Name" CommandArgument="BDProject.ProjectName" />
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBuildAreaKatha"
                                                CommandName="Sort" Text="Build Area Katha" CommandArgument="BDProject.LandAreaKatha" />
                                        </td>
                                        <td class="hi" style="display: none;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBuildAreaSft"
                                                CommandName="Sort" Text="Build Area Sft" CommandArgument="BDProject.LandAreaSft" />
                                        </td>
                                        <td class="hi" style="display: none;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByNoOfStoried"
                                                CommandName="Sort" Text="No Of Storied" CommandArgument="BDProject.NoOfStoried" />
                                        </td>
                                        <td class="hi" style="display: none;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByNoOfBasement"
                                                CommandName="Sort" Text="No Of Basement" CommandArgument="BDProject.NoOfBasement" />
                                        </td>
                                        <td class="hi" style="display: none;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByDescription"
                                                CommandName="Sort" Text="Description" CommandArgument="BDProject.Name" />
                                        </td>
                                        <td class="hi" style="display: none;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByClientPercentage"
                                                CommandName="Sort" Text="Client Percentage" CommandArgument="BDProject.ClientPercentage" />
                                        </td>
                                        <td class="hi" style="display: none;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByCompanyPercentage"
                                                CommandName="Sort" Text="Company Percentage" CommandArgument="BDProject.CompanyPercentage" />
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProjectCategory"
                                                CommandName="Sort" Text="Project Category" CommandArgument="MDProjectCategory.Name" />
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProjectStatus"
                                                CommandName="Sort" Text="Project Status" CommandArgument="MDProjectStatus.Name" />
                                        </td>
                                    <td class="hi" style="display: none;">
                                        Is Removed
                                    </td>
                                    <td class="his">
                                        Project Report
                                    </td>
                                    <td class="his" style="width:200px;">
                                        Project History Report
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
                                    <%# Eval("ProjectCode")%>
                                </td>
                                <td class="i" style="width: 200px;">
                                    <asp:HyperLink ID="hypProject" runat="server" Text='<%# Eval("ProjectName")%>' CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("LandAreaKatha")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("LandAreaSft")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("NoOfStoried")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("NoOfBasement")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ClientPercentage")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("CompanyPercentage")%>
                                </td>
                                <td class="i">
                                        <%# Eval("ProjectCategoryName")%>
                                    </td>
                                <td class="i">
                                    <%# Eval("ProjectStatusName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypProjectReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="ProjectReport" CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProjectListControl_lvBDProject_ProjectReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypProjectHistoryReport" runat="server" CssClass="CommonButtonLink" Text="Project History Report"
                                        CommandName="ProjectHistoryReport" CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProjectListControl_lvBDProject_ProjectHistoryReport_key"></asp:HyperLink>
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
                                    <%# Eval("ProjectCode")%>
                                </td>
                                <td class="i" style="width: 200px;">
                                    <asp:HyperLink ID="hypProject" runat="server" Text='<%# Eval("ProjectName")%>' CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("LandAreaKatha")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("LandAreaSft")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("NoOfStoried")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("NoOfBasement")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ClientPercentage")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("CompanyPercentage")%>
                                </td>
                                <td class="i">
                                        <%# Eval("ProjectCategoryName")%>
                                    </td>
                                <td class="i">
                                    <%# Eval("ProjectStatusName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypProjectReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="ProjectReport" CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProjectListControl_lvBDProject_ProjectReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypProjectHistoryReport" runat="server" CssClass="CommonButtonLink" Text="Project History Report"
                                        CommandName="ProjectHistoryReport" CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProjectListControl_lvBDProject_ProjectHistoryReport_key"></asp:HyperLink>
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
                <asp:ObjectDataSource ID="odsBDProject" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.BDProject_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsBDProject_Selecting">
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
