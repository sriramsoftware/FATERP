<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 16-Apr-2012, 04:09:50
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierItemMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierItemMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypSupplier" runat="server" Text="Select Vendor" NavigateUrl="~/PRM/PRMSupplier.aspx"
                        Target="_blank"></asp:HyperLink>
                    &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" OnSelectedIndexChanged="ddlSupplierID_SelectedIndexChanged"
                        AutoPostBack="true" runat="server" ValidationGroup="PRMSupplierItemMapEntity"
                        Width="236">
                    </asp:DropDownList>
                </div>
            </div>
            <br />
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Find Text&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFind" runat="server" CssClass="ktiTextBox"></asp:TextBox>
                </div>
                <div class="TableFormLeble" style="text-align: right; padding-left: 750px;">
                    <asp:HyperLink ID="hypAddPrice" runat="server" Text="Add New Price"></asp:HyperLink>
                </div>
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMSupplierItemMap" runat="server" DataSourceID="odsPRMSupplierItemMap"
                        OnItemCommand="lvPRMSupplierItemMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="hi" style="display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplier"
                                            CommandName="Sort" Text="Vendor" CommandArgument="PRMSupplier.SupplierName" />
                                    </td>
                                   
                                    <td class="hi" style="display: none;">
                                        ItemID
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByItem"
                                            CommandName="Sort" Text="Item" CommandArgument="MDItem.ItemName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByActualPrice"
                                            CommandName="Sort" Text="Market Price" CommandArgument="PRMSupplierItemMap.ActualPrice" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByDiscountPercentage"
                                            CommandName="Sort" Text="Discount Percentage" CommandArgument="PRMSupplierItemMap.DiscountPercentage" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPrice"
                                            CommandName="Sort" Text="Net Price" CommandArgument="PRMSupplierItemMap.Price" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByEntryDate"
                                            CommandName="Sort" Text="Entry Date" CommandArgument="PRMSupplierItemMap.EntryDate" />
                                    </td>
                                     <td class="hi" style="display: none;">
                                        Brand ID
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBrand"
                                            CommandName="Sort" Text="Brand" CommandArgument="MDBrand.BrandName" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Origin RegionID
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByOriginRegion"
                                            CommandName="Sort" Text="Origin Region" CommandArgument="MDRegion.Name" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Origin CountryID
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByOriginCountry"
                                            CommandName="Sort" Text="Origin Country" CommandArgument="MDCountry.Name" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByModel"
                                            CommandName="Sort" Text="Model" CommandArgument="PRMSupplierItemMap.Model" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWarrantyPeriod"
                                            CommandName="Sort" Text="Warranty Period" CommandArgument="PRMSupplierItemMap.WarrantyPeriod" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Is Removed
                                    </td>
                                    <td class="his" style="display: none;">
                                        DELETE
                                    </td>
                                    <td class="rp" style="display: none;">
                                        &nbsp;
                                    </td>
                                    <td class="rpb">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr class="r">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierItemMapID")%>'
                                        UniqueKey="PRMSupplierItemMap_lvPRMSupplierItemMap_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("SupplierID")%>
                                </td>
                                
                                <td class="i" style="display: none;">
                                    <asp:Label ID="txtItemIDLV" Text='<%# Eval("ItemID")%>' runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtActualPriceLV" runat="server" Text='<%# Eval("ActualPrice")%>'
                                        Enabled="false" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtDiscountPercentageLV" runat="server" Text='<%# Eval("DiscountPercentage")%>'
                                        Enabled="false" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtPriceLV" Text='<%# Eval("Price")%>' runat="server" CssClass="ktiDecimalTextBoxListview"
                                        Enabled="false"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtEntryDateLV" Text='<%# Eval("EntryDate") != null ? ((DateTime)Eval("EntryDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'
                                        Enabled="false" runat="server" CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblBrandIDLV" Text='<%# Eval("BrandID")%>' runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("OriginRegionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RegionName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("OriginCountryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Model")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WarrantyPeriod")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor Item Map?')"
                                        CommandArgument='<%#Eval("SupplierItemMapID")%>' UniqueKey="PRMSupplierItemMap_lvPRMSupplierItemMap_Delete_key" />
                                </td>
                                <td class="rp" style="display: none;">
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
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierItemMapID")%>'
                                        UniqueKey="PRMSupplierItemMap_lvPRMSupplierItemMap_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("SupplierID")%>
                                </td>
                                
                                <td class="i" style="display: none;">
                                    <asp:Label ID="txtItemIDLV" Text='<%# Eval("ItemID")%>' runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtActualPriceLV" runat="server" Text='<%# Eval("ActualPrice")%>'
                                        Enabled="false" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtDiscountPercentageLV" runat="server" Text='<%# Eval("DiscountPercentage")%>'
                                        Enabled="false" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtPriceLV" Text='<%# Eval("Price")%>' Enabled="false" runat="server"
                                        CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtEntryDateLV" Text='<%# Eval("EntryDate") != null ? ((DateTime)Eval("EntryDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'
                                        Enabled="false" runat="server" CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblBrandIDLV" Text='<%# Eval("BrandID")%>' runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("OriginRegionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RegionName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("OriginCountryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Model")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WarrantyPeriod")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor Item Map?')"
                                        CommandArgument='<%#Eval("SupplierItemMapID")%>' UniqueKey="PRMSupplierItemMap_lvPRMSupplierItemMap_Delete_key" />
                                </td>
                                <td class="rp" style="display: none;">
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
                <asp:ObjectDataSource ID="odsPRMSupplierItemMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMSupplierItemMap_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMSupplierItemMap_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
        <div class="TableFormContent" style="padding-top: 10px;">
            <kti:SecureButton ID="btnUpdate" OnClick="btnUpdate_Click"
                runat="server" Text="Update All" UniqueKey="PRMSupplierItemMapControl_Submit_key" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
