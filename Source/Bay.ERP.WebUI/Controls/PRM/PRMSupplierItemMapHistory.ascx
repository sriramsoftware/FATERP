<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 16-Apr-2012, 04:09:50
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierItemMapHistory.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierItemMapHistoryControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypSupplier" runat="server" Text="Vendor" NavigateUrl="~/PRM/PRMSupplier.aspx"
                        Target="_blank"></asp:HyperLink>
                    &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        Width="236">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Item&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        Width="236">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    From Date&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFromDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox" Width="230" />
                </div>
                <div class="TableFormValidatorContent">                    
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    To Date&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtToDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox" Width="230" />
                </div>
                <div class="TableFormValidatorContent">                    
                </div>
            </div>

            <div class="TableRow" style="padding-top: 10px; padding-left: 320px;">
                <kti:SecureButton ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" UniqueKey="PRMSupplierItemMapHistoryControl_Search_key" />
            </div>
            <br />
            <div class="listContentTitle">
                Vendor Item Map History List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMSupplierItemMapHistory" runat="server" DataSourceID="odsPRMSupplierItemMapHistory"
                        OnItemCommand="lvPRMSupplierItemMapHistory_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Vendor Item Map
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplier"
                                            CommandName="Sort" Text="Vendor" CommandArgument="PRMSupplier.SupplierName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBrand"
                                            CommandName="Sort" Text="Brand" CommandArgument="MDBrand.BrandName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByItemName"
                                            CommandName="Sort" Text="Item Name" CommandArgument="MDItem.ItemName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByActualPrice"
                                            CommandName="Sort" Text="Actual Price" CommandArgument="PRMSupplierItemMapHistory.ActualPrice" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByDiscountPercentage"
                                            CommandName="Sort" Text="Discount Percentage" CommandArgument="PRMSupplierItemMapHistory.DiscountPercentage" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPrice"
                                            CommandName="Sort" Text="Price" CommandArgument="PRMSupplierItemMapHistory.Price" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierID"
                                            CommandName="Sort" Text="SupplierID" CommandArgument="PMRSupplier.SupplierID" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByOriginRegion"
                                            CommandName="Sort" Text="Origin Region" CommandArgument="MDRegion.Name" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByOriginCountry"
                                            CommandName="Sort" Text="Origin Country" CommandArgument="MDCountry.Name" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWarrantyPeriod"
                                            CommandName="Sort" Text="Warranty Period" CommandArgument="PRMSupplierItemMap.WarrantyPeriod" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByEntryDate"
                                            CommandName="Sort" Text="Entry Date" CommandArgument="PRMSupplierItemMapHistory.EntryDate" />
                                    </td>
                                    <td class="his" style="display: none;">
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
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("SupplierItemMapID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DiscountPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Price")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("SupplierID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RegionName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WarrantyPeriod")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EntryDate") != null ? ((DateTime)Eval("EntryDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierItemMapHistoryID")%>'
                                        UniqueKey="PRMSupplierItemMapHistory_lvPRMSupplierItemMapHistory_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor Item Map History?')"
                                        CommandArgument='<%#Eval("SupplierItemMapHistoryID")%>' UniqueKey="PRMSupplierItemMapHistory_lvPRMSupplierItemMapHistory_Delete_key" />
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
                                <td class="i" style="display: none;">
                                    <%# Eval("SupplierItemMapID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DiscountPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Price")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("SupplierID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RegionName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WarrantyPeriod")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EntryDate") != null ? ((DateTime)Eval("EntryDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierItemMapHistoryID")%>'
                                        UniqueKey="PRMSupplierItemMapHistory_lvPRMSupplierItemMapHistory_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor Item Map History?')"
                                        CommandArgument='<%#Eval("SupplierItemMapHistoryID")%>' UniqueKey="PRMSupplierItemMapHistory_lvPRMSupplierItemMapHistory_Delete_key" />
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
                <asp:ObjectDataSource ID="odsPRMSupplierItemMapHistory" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMSupplierItemMapHistory_CustomDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMSupplierItemMapHistory_Selecting">
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
