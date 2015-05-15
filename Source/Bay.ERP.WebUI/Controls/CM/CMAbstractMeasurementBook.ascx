<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Oct-2012, 01:19:13
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMAbstractMeasurementBook.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMAbstractMeasurementBookControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
        <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                            Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server" AutoPostBack="true"
                            Width="236" onselectedindexchanged="ddlProjectID_SelectedIndexChanged">
                        </asp:DropDownList>
                        
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>

            <div class="listContentTitle">
                Abstract Measurement List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMAbstractMeasurementBook" runat="server" OnItemDataBound="lvCMAbstractMeasurementBook_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                     <td class="hi" style="display:none;">
                                        Project ID
                                    </td>
                                     <td class="hi" style="display:none;">
                                        Item ID
                                    </td>
                                    <td class="hi">
                                        Item Name
                                    </td>
                                    <td class="hi">
                                        Unit Name
                                    </td>
                                    <td class="hi">
                                        Rate
                                    </td>
                                    <td class="hi">
                                        Previous Qty
                                    </td>
                                    <td class="hi">
                                        Present Qty
                                    </td>
                                    <td class="hi">
                                        Total Qty
                                    </td>
                                    <td class="his">
                                        Amount
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
                                <td class="i" style="display:none;">
                                    <%# Eval("ProjectID")%>
                                </td>
                                 <td class="i" style="display:none;">
                                    <%# Eval("ItemID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblRate" runat="server"></asp:Label>  <%--  <%# Eval("PresentQty")%>--%>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblPreviousQty" runat="server"></asp:Label>  <%--  <%# Eval("PresentQty")%>--%>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblPresentQty" runat="server"></asp:Label>  <%--  <%# Eval("PresentQty")%>--%>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblTotal" runat="server" Text='<%# Eval("TotalQty")%>'></asp:Label>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblAmount" runat="server"></asp:Label>  <%-- <%# Eval("WorkOrderNo")%>--%>
                                </td>
                                <td class="i">
                                   <%-- <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Measurement Book?')"
                                        CommandArgument='<%#Eval("MeasurementBookID")%>' UniqueKey="CMMeasurementBook_lvCMMeasurementBook_Edit_key" />--%>
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
                                <td class="i" style="display:none;">
                                    <%# Eval("ProjectID")%>
                                </td>
                                 <td class="i" style="display:none;">
                                    <%# Eval("ItemID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblRate" runat="server"></asp:Label>  <%--  <%# Eval("PresentQty")%>--%>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblPreviousQty" runat="server"></asp:Label>  <%--  <%# Eval("PresentQty")%>--%>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblPresentQty" runat="server"></asp:Label>  <%--  <%# Eval("PresentQty")%>--%>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblTotal" runat="server" Text='<%# Eval("TotalQty")%>'></asp:Label>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblAmount" runat="server"></asp:Label>  <%-- <%# Eval("WorkOrderNo")%>--%>
                                </td>
                                <td class="i">
                                   <%-- <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Measurement Book?')"
                                        CommandArgument='<%#Eval("MeasurementBookID")%>' UniqueKey="CMMeasurementBook_lvCMMeasurementBook_Edit_key" />--%>
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
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
