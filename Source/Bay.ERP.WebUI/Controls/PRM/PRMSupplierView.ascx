<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Feb-2012, 05:41:59
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierView.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierViewControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Vendor Type&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSupplierTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMSupplierViewEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Vendor Status&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSupplierStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMSupplierViewEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Map Item Category&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSupplierItemCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMSupplierViewEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center; padding-left: 170px;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSearch" ValidationGroup="PRMSupplierViewEntity" OnClick="btnSearch_Click"
                        runat="server" Text="Search" UniqueKey="PRMSupplierViewControl_Search_key" />
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Vendor List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMSupplier" runat="server" DataSourceID="odsPRMSupplier">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 80px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierCode"
                                            CommandName="Sort" Text="Vendor Code" CommandArgument="PRMSupplier.SupplierCode" />
                                    </td>
                                    <td class="hi" style="width: 170px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierName"
                                            CommandName="Sort" Text="Vendor Name" CommandArgument="PRMSupplier.SupplierName" />
                                    </td>
                                    <td class="hi" style="width: 90px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRelationship"
                                            CommandName="Sort" Text="Relationship" CommandArgument="PRMSupplier.Relationship" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPhone"
                                            CommandName="Sort" Text="Phone" CommandArgument="PRMSupplier.Phone" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMobileNo"
                                            CommandName="Sort" Text="Mobile No" CommandArgument="PRMSupplier.MobileNo" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByFax"
                                            CommandName="Sort" Text="Fax" CommandArgument="PRMSupplier.Fax" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByEmail"
                                            CommandName="Sort" Text="Email" CommandArgument="PRMSupplier.Email" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWebLink"
                                            CommandName="Sort" Text="Web Link" CommandArgument="PRMSupplier.WebLink" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierStatus"
                                            CommandName="Sort" Text="Vendor Status" CommandArgument="MDSupplierStatus.Name" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByReason"
                                            CommandName="Sort" Text="Reason" CommandArgument="PRMSupplier.Reason" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Is Removed
                                    </td>
                                    <td class="his">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierType"
                                            CommandName="Sort" Text="Vendor Type" CommandArgument="MDSupplierType.Name" />
                                    </td>
                                    <td class="his" style="width: 100px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMappedItemCategory"
                                            CommandName="Sort" Text="Mapped Item Category" CommandArgument="MDSupplierItemCategory.Name" />
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
                                    <%# Eval("SupplierCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Relationship")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Fax")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%-- <asp:Hyperlink ID="hypWebLink" Target="_blank" Text='' href='#' onclick="window.open('<%# Eval("WebLink")%>'); return false;"></asp:Hyperlink>--%>
                                    <%-- <a href="http://google.com/" onclick="window.open(this.href, 'popupwindow', 'width=400,height=300,scrollbars,resizable'); return false;">Link text goes here<a>--%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierStatusName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%-- <%# Eval("Reason")%>--%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%-- <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>--%>
                                </td>
                                <td class="i">
                                    <%#Eval("SupplierTypeName")%>
                                </td>
                                <td class="i" style="width: 100px;">
                                    <%#Eval("SupplierItemCategoryName") %>
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
                                    <%# Eval("SupplierCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Relationship")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Fax")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%-- <a href='<%# Eval("WebLink")%>' target="_blank"><%# Eval("WebLink")%></a>--%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierStatusName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%--<%# Eval("Reason")%>--%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%--<%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>--%>
                                </td>
                                <td class="i">
                                    <%#Eval("SupplierTypeName")%>
                                </td>
                                <td class="i" style="width: 100px;">
                                    <%#Eval("SupplierItemCategoryName") %>
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
                <asp:ObjectDataSource ID="odsPRMSupplier" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMSupplierView_CustomDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMSupplier_Selecting">
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
