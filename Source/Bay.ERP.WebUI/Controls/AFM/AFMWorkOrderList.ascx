<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AFMWorkOrderList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.AFMWorkOrderListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
            <div class="listContentTitle">
                Work Order List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMWorkOrder" runat="server" DataSourceID="odsPRMWorkOrder" OnItemCommand="lvPRMWorkOrder_ItemCommand" OnItemDataBound="lvPRMWorkOrder_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="his">
                                        Report
                                    </td>
                                    <td class="his">
                                        Annexure Report
                                    </td>
                                    <td class="hi">
                                        Work Order No
                                    </td>
                                    <td class="hi">
                                        Supplier
                                    </td>                                    
                                    <td class="hi">
                                        Attention
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Subject
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Body Title
                                    </td>
                                    <td class="hi">
                                        Start Date
                                    </td>
                                    <td class="hi">
                                        Completion Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Warranty
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Delay Charge
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Remarks
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Foot Note
                                    </td>
                                    <td class="hi">
                                        Prepared By
                                    </td>
                                    <td class="hi">
                                        Status
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
                                    <asp:HyperLink ID="hypWorkOrderReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                            CommandName="WorkOrderReport" CommandArgument='<%#Eval("WorkOrderID")%>' UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_WorkOrderReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypWorkOrderAnnexureReport" runat="server" CssClass="CommonButtonLink" Text="Annexure Report"
                                            CommandName="WorkOrderAnnexureReport" CommandArgument='<%#Eval("WorkOrderID")%>' UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_WorkOrderAnnexureReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PRMSupplierSupplierName")%>
                                </td>                                
                                <td class="i">
                                    <%# Eval("AttentionFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i"  style="display:none;">
                                    <%# Eval("Subject")%>
                                </td>
                                <td class="i"  style="display:none;">
                                    <%# Eval("BodyTitle")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompletionDate") != null ? ((DateTime)Eval("CompletionDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i"  style="display:none;">
                                    <%# Eval("Warranty")%>
                                </td>
                                <td class="i"  style="display:none;">
                                    <%# Eval("DelayCharge")%>
                                </td>
                                <td class="i"  style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i"  style="display:none;">
                                    <%# Eval("FootNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PreparedByFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDWorkOrderStatusName")%>
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
                                    <asp:HyperLink ID="hypWorkOrderReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                            CommandName="WorkOrderReport" CommandArgument='<%#Eval("WorkOrderID")%>' UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_WorkOrderReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypWorkOrderAnnexureReport" runat="server" CssClass="CommonButtonLink" Text="Annexure Report"
                                            CommandName="WorkOrderAnnexureReport" CommandArgument='<%#Eval("WorkOrderID")%>' UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_WorkOrderAnnexureReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                   <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PRMSupplierSupplierName")%>
                                </td>                                
                                <td class="i">
                                    <%# Eval("AttentionFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Subject")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("BodyTitle")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompletionDate") != null ? ((DateTime)Eval("CompletionDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Warranty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("DelayCharge")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("FootNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PreparedByFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDWorkOrderStatusName")%>
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
                <asp:ObjectDataSource ID="odsPRMWorkOrder" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMWorkOrder_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMWorkOrder_Selecting">
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
