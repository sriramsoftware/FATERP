<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Dec-2012, 12:52:14
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVStoreUnitItem.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVStoreUnitItemControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
             <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Project&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVTransactionEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Store Unit&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlStoreUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="INVStoreUnitItemEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Item&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVStoreUnitItemEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                <kti:SecureButton ID="btnSearch" ValidationGroup="INVTransactionEntity" runat="server"
                        OnClick="btnSearch_Click" Text="Search" UniqueKey="INVTransactionControl_Search_key" />
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Store Unit Item List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVStoreUnitItem" runat="server" DataSourceID="odsINVStoreUnitItem" OnItemDataBound="lvINVStoreUnitItem_ItemDataBound"
                        OnItemCommand="lvINVStoreUnitItem_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                     <td class="hi">
                                        Store
                                    </td>
                                    <td class="hi">
                                        Store Unit
                                    </td>
                                    <td class="hi">
                                        Item
                                    </td>
                                    <td class="hi">
                                        Brand
                                    </td>
                                    <td class="hi">
                                        Region
                                    </td>
                                    <td class="hi">
                                        Country
                                    </td>
                                    <td class="hi">
                                        Unit Current Stock
                                    </td>
                                    <td class="hi">
                                        Unit
                                    </td>
                                    <td class="his" style="display:none;">
                                        EDIT
                                    </td>
                                    <td class="his" style="display:none;">
                                        DELETE
                                    </td>
                                    <td class="his">
                                        Details
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
                                <td class="i" style="display:none;">
                                <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'  ></asp:Label>
                                <asp:Label ID="lblStoreUnitIDLV" runat="server" Text='<%# Eval("StoreUnitID")%>' ></asp:Label>
                                <asp:Label ID="lblItemIDLV" runat="server" Text='<%# Eval("ItemID")%>' ></asp:Label>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                 <td class="i">
                                    <%# Eval("StoreName")%>
                                </td>
                               <td class="i">
                                    <%# Eval("UnitTrackNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBrandBrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDRegionName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDCountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitCurrentStock")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("StoreUnitItemID")%>'
                                        UniqueKey="INVStoreUnitItem_lvINVStoreUnitItem_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVStore Unit Item?')"
                                        CommandArgument='<%#Eval("StoreUnitItemID")%>' UniqueKey="INVStoreUnitItem_lvINVStoreUnitItem_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkItemDetails" runat="server" CssClass="CommonButtonLink" Text="Details"
                                        CommandName="ItemDetails" CommandArgument='<%#Eval("StoreUnitItemID")%>'/>
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
                                <td class="i" style="display:none;">
                                <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'  ></asp:Label>
                                <asp:Label ID="lblStoreUnitIDLV" runat="server" Text='<%# Eval("StoreUnitID")%>' ></asp:Label>
                                <asp:Label ID="lblItemIDLV" runat="server" Text='<%# Eval("ItemID")%>' ></asp:Label>
                                </td>
                                 <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                 <td class="i">
                                    <%# Eval("StoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitTrackNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBrandBrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDRegionName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDCountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitCurrentStock")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("StoreUnitItemID")%>'
                                        UniqueKey="INVStoreUnitItem_lvINVStoreUnitItem_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVStore Unit Item?')"
                                        CommandArgument='<%#Eval("StoreUnitItemID")%>' UniqueKey="INVStoreUnitItem_lvINVStoreUnitItem_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkItemDetails" runat="server" CssClass="CommonButtonLink" Text="Details"
                                        CommandName="ItemDetails" CommandArgument='<%#Eval("StoreUnitItemID")%>'/>
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
                <asp:ObjectDataSource ID="odsINVStoreUnitItem" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVStoreUnitItem_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVStoreUnitItem_Selecting">
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
