<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Dec-2012, 12:52:14
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVCurrentStock.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVCurrentStockControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Item&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVCurrentStockEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Brand&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVCurrentStockEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                    
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Region&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlRegionID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVCurrentStockEntity" Width="236">
                    </asp:DropDownList>
                    
                </div>
                <div class="TableFormValidatorContent">
                    
                </div>
            </div>
            <div class="TableRow" style="width: 100; display:none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Country&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlCountryID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVCurrentStockEntity" Width="236">
                    </asp:DropDownList>
                  
                </div>
                <div class="TableFormValidatorContent">
                  
                </div>
            </div>
            
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                <kti:SecureButton ID="btnSearch" ValidationGroup="INVCurrentStockEntity" runat="server" OnClick="btnSearch_Click"
                        Text="Search" UniqueKey="INVCurrentStockControl_Search_key" />
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Current Stock List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVCurrentStock" runat="server" DataSourceID="odsINVCurrentStock"
                        OnItemCommand="lvINVCurrentStock_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
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
                                    <%# Eval("MDItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBrandName")%>
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
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("CurrentStockID")%>'
                                        UniqueKey="INVCurrentStock_lvINVCurrentStock_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVCurrent Stock?')"
                                        CommandArgument='<%#Eval("CurrentStockID")%>' UniqueKey="INVCurrentStock_lvINVCurrentStock_Delete_key" />
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
                                    <%# Eval("MDItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBrandName")%>
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
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("CurrentStockID")%>'
                                        UniqueKey="INVCurrentStock_lvINVCurrentStock_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVCurrent Stock?')"
                                        CommandArgument='<%#Eval("CurrentStockID")%>' UniqueKey="INVCurrentStock_lvINVCurrentStock_Delete_key" />
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
                <asp:ObjectDataSource ID="odsINVCurrentStock" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVCurrentStock_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVCurrentStock_Selecting">
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
