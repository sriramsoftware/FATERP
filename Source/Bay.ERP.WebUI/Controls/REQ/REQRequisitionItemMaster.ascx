<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisitionItemMaster.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionItemMasterControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div class="listContentTitle">
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvREQRequisitionItem" runat="server" DataSourceID="odsREQRequisitionItem"
                        OnItemDataBound="lvREQRequisitionItem_ItemDataBound" OnItemCommand="lvREQRequisitionItem_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Requisition
                                    </td>
                                    <td class="hi" style="width: 60px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByAccCode"
                                            CommandName="Sort" Text="Acc Code" CommandArgument="REQRequisitionItem.AccountsCode" />
                                    </td>
                                    <td class="hi" style="width: 200px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByItem"
                                            CommandName="Sort" Text="Item" CommandArgument="MDItem.ItemName" />
                                    </td>
                                    <td class="hi" style="display:none;">
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByTotalReqQty"
                                            CommandName="Sort" Text="Total Req. Qty" CommandArgument="REQRequisitionItem.TotalRequiredQty" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPurchasedQty"
                                            CommandName="Sort" Text="Purchased Qty" CommandArgument="REQRequisitionItem.PurchasedQtyTillToDate" />
                                    </td>
                                    <td class="hi" style="width: 95px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPresentReqQty"
                                            CommandName="Sort" Text="Present Req. Qty" CommandArgument="REQRequisitionItem.PresentRequiredQty" />
                                    </td>
                                    <td class="hi" style="width: 85px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequiredDate"
                                            CommandName="Sort" Text="Required Date" CommandArgument="REQRequisitionItem.RequiredDate" />
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
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
                                <td class="i" style="display:none;">
                                    <%# Eval("RequisitionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AccountsCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <asp:Label ID="lblItemLV" runat="server" Visible="false" Text='<%# Eval("ItemID")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblQtyLV" runat="server" Text='<%# Eval("TotalRequiredQty")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblPurchasedQty" runat="server" Text='<%# Eval("PurchasedQtyTillToDate")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtPresentRequiredQty" runat="server" Text='<%# Eval("PresentRequiredQty")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRequiredDate" runat="server" Text='<%# Eval("RequiredDate") != null ? ((DateTime)Eval("RequiredDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>' CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("RequisitionItemID")%>'
                                        UniqueKey="REQRequisitionItemMaster_lvREQRequisitionItem_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Item?')"
                                        CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionItemMaster_lvREQRequisitionItem_Delete_key" />
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
                                    <%# Eval("RequisitionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AccountsCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <asp:Label ID="lblItemLV" runat="server" Visible="false" Text='<%# Eval("ItemID")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblQtyLV" runat="server" Text='<%# Eval("TotalRequiredQty")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblPurchasedQty" runat="server" Text='<%# Eval("PurchasedQtyTillToDate")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtPresentRequiredQty" runat="server" Text='<%# Eval("PresentRequiredQty")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRequiredDate" runat="server" Text='<%# Eval("RequiredDate") != null ? ((DateTime)Eval("RequiredDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>' CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("RequisitionItemID")%>'
                                        UniqueKey="REQRequisitionItemMaster_lvREQRequisitionItem_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Item?')"
                                        CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionItemMaster_lvREQRequisitionItem_Delete_key" />
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
                <asp:ObjectDataSource ID="odsREQRequisitionItem" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionItem_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsREQRequisitionItem_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
        <div class="TableFormContent">
            <kti:SecureButton ID="btnSubmit" ValidationGroup="REQRequisitionItemEntity" OnClick="btnSave_Click"
                runat="server" Text="Update" UniqueKey="REQRequisitionItemMasterControl_Submit_key" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
