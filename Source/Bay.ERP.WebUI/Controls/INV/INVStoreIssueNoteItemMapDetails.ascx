<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Dec-2012, 12:52:14
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVStoreIssueNoteItemMapDetails.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVStoreIssueNoteItemMapDetailsControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
               <div class="listContentTitle">
                Store Issue Note Item Map List
            </div>
               <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVStoreIssueNoteItemMap" runat="server" DataSourceID="odsINVStoreIssueNoteItemMap"
                        OnItemCommand="lvINVStoreIssueNoteItemMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Item
                                    </td>
                                    <td class="hi" style="width:40px; display:none;">
                                        Folio No
                                    </td>
                                    <td class="hi">
                                        Request Qty
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Issued From Store
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Issued From Store Unit
                                    </td>
                                    <td class="hi" >
                                        Received Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Received By Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Return Qty
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Return Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Return To Store
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Return To Store Unit
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Returned By Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Actual Use
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Amount
                                    </td>
                                    <td class="hi">
                                        Purpose Of Works
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
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("FolioNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestQty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IssuedFromStoreID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IssuedFromStoreUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReceivedDate") != null ? ((DateTime)Eval("ReceivedDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReceivedByMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnQty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnDate") != null ? ((DateTime)Eval("ReturnDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnToStoreID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnToStoreUnitID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnedByMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ActualUse")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurposeOfWorks")%>
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
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("FolioNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestQty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("INVStoreName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IssuedFromStoreUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReceivedDate") != null ? ((DateTime)Eval("ReceivedDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReceivedByEmployeeID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnQty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnDate") != null ? ((DateTime)Eval("ReturnDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnToStoreID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnToStoreUnitID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnedByMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ActualUse")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurposeOfWorks")%>
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
                <asp:ObjectDataSource ID="odsINVStoreIssueNoteItemMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVStoreIssueNoteItemMap_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVStoreIssueNoteItemMap_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
