<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Feb-2012, 05:41:59
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>

        <div>
         <div class="TableRow" style="width: 100%; padding-left:620px;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Supplier# Or Email</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMSupplier" runat="server" DataSourceID="odsPRMSupplier" OnItemCommand="lvPRMSupplier_ItemCommand"
                        OnItemDataBound="lvPRMSupplier_ItemDataBound">
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
                                    <td class="hi">
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
                                <td class="i">
                                    <%# Eval("SupplierCode")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypSupplier" runat="server" Text='<%# Eval("SupplierName")%>'
                                        CssClass="CommonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("Relationship")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Fax")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("WebLink")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierStatus")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Reason")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierID")%>'
                                        UniqueKey="PRMSupplierList_lvPRMSupplier_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor?')"
                                        CommandArgument='<%#Eval("SupplierID")%>' UniqueKey="PRMSupplierList_lvPRMSupplier_Delete_key" />
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
                                    <asp:HyperLink ID="hypSupplier" runat="server" Text='<%# Eval("SupplierName")%>'
                                        CssClass="CommonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("Relationship")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Fax")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("WebLink")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierStatus")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Reason")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierID")%>'
                                        UniqueKey="PRMSupplierList_lvPRMSupplier_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor?')"
                                        CommandArgument='<%#Eval("SupplierID")%>' UniqueKey="PRMSupplierList_lvPRMSupplier_Delete_key" />
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
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMSupplier_DetailedDataSource"
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
