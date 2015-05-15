<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisitionListMaster.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionListMasterControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div class="lv-c">
                <asp:ListView ID="lvREQRequisition" runat="server" DataSourceID="odsREQRequisition"
                    OnItemDataBound="lvREQRequisition_ItemDataBound" OnItemCommand="lvREQRequisition_ItemCommand">
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
                                        CommandName="Sort" Text="Requisition No" CommandArgument="REQRequisition.RequisitionNo" />
                                </td>
                                <td class="hi" style="width: 170px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisitionDate"
                                        CommandName="Sort" Text="Requisition Date" CommandArgument="REQRequisition.RequisitionDate" />
                                </td>
                                <td class="hi" style="display: none;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRemarks"
                                        CommandName="Sort" Text="Remarks" CommandArgument="REQRequisition.Remarks" />
                                </td>
                                <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByStatus"
                                        CommandName="Sort" Text="Status" CommandArgument="MDRequisitionStatus.Name" />
                                </td>
                                <td class="his">
                                    EDIT
                                </td>
                                <td class="his">
                                    DELETE
                                </td>
                                <td class="his">
                                    Report
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
                                <%# Eval("ProjectName")%>
                            </td>
                            <td class="i">
                                <asp:HyperLink ID="hypRequisition" runat="server" ClientIDMode="Static" Text='<%# Eval("RequisitionNo")%>' ToolTip="Please Click Here To Edit The Template Items!"
                                    CssClass="CommonLink"></asp:HyperLink>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i" style="display:none;">
                                <%# Eval("Remarks")%>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionStatusName")%>
                            </td>
                            <td class="i">
                                <asp:HyperLink ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                    CommandName="EditItem" CommandArgument='<%#Eval("RequisitionID")%>' UniqueKey="REQRequisitionListMaster_lvREQRequisition_Edit_key"></asp:HyperLink>
                            </td>
                            <td class="i">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition?')"
                                    CommandArgument='<%#Eval("RequisitionID")%>' UniqueKey="REQRequisitionListMaster_lvREQRequisition_Delete_key" />
                            </td>
                            <td class="i">
                                <asp:HyperLink ID="hypRequisitionReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                    CommandName="RequisitionReport" CommandArgument='<%#Eval("RequisitionID")%>' UniqueKey="REQRequisitionListMaster_lvREQRequisition_RequisitionReport_key"></asp:HyperLink>
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
                                <asp:HyperLink ID="hypRequisition" runat="server" Text='<%# Eval("RequisitionNo")%>' ToolTip="Please Click Here To Edit The Template Items!"
                                    CssClass="CommonLink"></asp:HyperLink>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i" style="display:none;">
                                <%# Eval("Remarks")%>
                            </td>
                            <td class="i">
                                <%# Eval("RequisitionStatusName")%>
                            </td>
                            <td class="i">
                                <asp:HyperLink ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                    CommandName="EditItem" CommandArgument='<%#Eval("RequisitionID")%>' UniqueKey="REQRequisitionListMaster_lvREQRequisition_Edit_key"></asp:HyperLink>
                            </td>
                            <td class="i">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition?')"
                                    CommandArgument='<%#Eval("RequisitionID")%>' UniqueKey="REQRequisitionListMaster_lvREQRequisition_Delete_key" />
                            </td>
                             <td class="i">
                                <asp:HyperLink ID="hypRequisitionReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                    CommandName="RequisitionReport" CommandArgument='<%#Eval("RequisitionID")%>' UniqueKey="REQRequisitionListMaster_lvREQRequisition_RequisitionReport_key"></asp:HyperLink>
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
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisition_DetailedDataSource"
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
    </ContentTemplate>
</asp:UpdatePanel>
