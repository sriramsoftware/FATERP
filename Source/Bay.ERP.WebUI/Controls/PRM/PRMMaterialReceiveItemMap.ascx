<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMMaterialReceiveItemMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMMaterialReceiveItemMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMMaterialReceiveItemMap" runat="server" DataSourceID="odsPRMMaterialReceiveItemMap"
                        OnItemCommand="lvPRMMaterialReceiveItemMap_ItemCommand">
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
                                        Country
                                    </td>
                                    <td class="hi">
                                        Region
                                    </td>
                                    <td class="hi">
                                        Unit
                                    </td>
                                    <td class="hi">
                                        Receive Date
                                    </td>
                                    <td class="hi">
                                        Receive Qty
                                    </td>
                                    <td class="hi">
                                        Challan No
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
                                 <td class="i" style="display:none;">
                                                                <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                                                <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                                                <asp:Label ID="lblWorkOrderItemMapIDLV" runat="server" Text='<%# Eval("WorkOrderItemMapID")%>'></asp:Label>
                                                                <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                                                <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                                                <asp:Label ID="lblItemLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                                            </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                   <br />
                                             <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                    ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor Wise Qty" CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("WorkOrderItemMapID")%>'/>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginCountry")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginRegion")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReceiveDate") != null ? ((DateTime)Eval("ReceiveDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReceiveQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ChallanNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("MaterialReceiveItemMapID")%>'
                                        UniqueKey="PRMMaterialReceiveItemMap_lvPRMMaterialReceiveItemMap_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Material Receive Item Map?')"
                                        CommandArgument='<%#Eval("MaterialReceiveItemMapID")%>' UniqueKey="PRMMaterialReceiveItemMap_lvPRMMaterialReceiveItemMap_Delete_key" />
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
                                                                <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                                                <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                                                <asp:Label ID="lblWorkOrderItemMapIDLV" runat="server" Text='<%# Eval("WorkOrderItemMapID")%>'></asp:Label>
                                                                <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                                                <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                                                <asp:Label ID="lblItemLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                                            </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                   <br />
                                             <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                    ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor Wise Qty" CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("WorkOrderItemMapID")%>'/>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginCountry")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginRegion")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReceiveDate") != null ? ((DateTime)Eval("ReceiveDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReceiveQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ChallanNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("MaterialReceiveItemMapID")%>'
                                        UniqueKey="PRMMaterialReceiveItemMap_lvPRMMaterialReceiveItemMap_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Material Receive Item Map?')"
                                        CommandArgument='<%#Eval("MaterialReceiveItemMapID")%>' UniqueKey="PRMMaterialReceiveItemMap_lvPRMMaterialReceiveItemMap_Delete_key" />
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
                <asp:ObjectDataSource ID="odsPRMMaterialReceiveItemMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMMaterialReceiveItemMap_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMMaterialReceiveItemMap_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>

             <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" PopupControlID="Panel3"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkFloorPopup" OkControlID="lnkFloorPopup"
            CancelControlID="btnFloorPopupCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div style="display: inline-block;">
            <asp:Panel ID="Panel3" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                <div class="modalPanelBackground">
                    <br />
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                            <asp:Button ID="Button2" runat="server" Text="X"></asp:Button>
                        </div>
                    </div>
                    <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                        padding-left: 10px;">
                        <tr>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
                                    Width="20" Height="300" AlternateText="" />
                            </th>
                            <th class="topleft">
                            </th>
                            <td class="tbl-border-top">
                                &nbsp;
                            </td>
                            <th class="topright">
                            </th>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                    Width="20" Height="300" AlternateText="" />
                            </th>
                        </tr>
                        <tr>
                            <td class="tbl-border-left">
                            </td>
                            <td>
                                <div class="table-content" style="width: 500px;">
                                    <div class="page-content">
                                        <h1>
                                            Modify Floor Detail Info</h1>
                                        <div>
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Item Name&nbsp;:
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    <asp:Label ID="lblFloorWiseItemName" runat="server" Font-Bold="true"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="lv-c" style="max-height: 200px; overflow-x:hidden;">
                                                <asp:ListView ID="lvREQRequisitionItemFloorDetail" runat="server" OnItemDataBound="lvREQRequisitionItemFloorDetail_ItemDataBound">
                                                    <LayoutTemplate>
                                                        <table class="lv" cellpadding="0" cellspacing="0">
                                                            <tr class="h">
                                                                <td class="hi" style="width:12px;">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="hi">
                                                                    Project Floor
                                                                </td>
                                                                <td class="hi">
                                                                    Qty
                                                                </td>
                                                                <td class="hi">
                                                                    Rate
                                                                </td>
                                                                <td class="hi">
                                                                    Remarks
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
                                                        </table>
                                                    </LayoutTemplate>
                                                    <ItemTemplate>
                                                        <tr class="r">
                                                            <td class="i" style="display:none;">
                                                                <asp:Label ID="lblProjectFloorIDLV" runat="server" Text='<%# Eval("ProjectFloorID")%>'></asp:Label>
                                                            </td>
                                                            <td class="i">
                                                                <asp:CheckBox ID="chbxSelectLV" runat="server" />
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("BDProjectFloorName")%>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtQtyLV" runat="server" Text='<%# Eval("Qty")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                                            </td>
                                                             <td class="i">
                                                                <asp:TextBox ID="txtRateLV" runat="server" Text='<%# Eval("Rate")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' CssClass="ktiTextBoxListview"></asp:TextBox>
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
                                                        
                                                            <td class="i" style="display: none;">
                                                             <asp:Label ID="lblProjectFloorIDLV" runat="server" Text='<%# Eval("ProjectFloorID")%>'></asp:Label>
                                                            </td>
                                                            <td class="i">
                                                                <asp:CheckBox ID="chbxSelectLV" runat="server" />
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("BDProjectFloorName")%>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtQtyLV" runat="server" Text='<%# Eval("Qty")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                                            </td>
                                                             <td class="i">
                                                                <asp:TextBox ID="txtRateLV" runat="server" Text='<%# Eval("Rate")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' CssClass="ktiTextBoxListview"></asp:TextBox>
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
                                        <div class="TableRow" style="width: 100;">
                                            <div class="TableFormLeble" style="text-align: left;">
                                                &nbsp;
                                            </div>
                                            <div class="TableFormContent">
                                                <asp:LinkButton ID="lnkFloorPopup" runat="server"></asp:LinkButton>
                                                <asp:Button ID="btnFloorPopupSave" runat="server" Text="Ok"/>
                                                <asp:Button ID="btnFloorPopupCancel" runat="server" Text="Cancel"/>
                                            </div>
                                            
                                        </div>
                                        <div>
                                            <asp:Label ID="lblLockMessage" runat="server" Visible="false" ForeColor="Red" Font-Bold="true" Text="Locked : Can't Change any Information."></asp:Label>
                                            </div>
                                    </div>
                                    <div class="quick-links">
                                    </div>
                                    <div class="clear">
                                    </div>
                                </div>
                            </td>
                            <td class="tbl-border-right">
                            </td>
                        </tr>
                        <tr>
                            <th class="sized bottomleft">
                            </th>
                            <td class="tbl-border-bottom">
                                &nbsp;
                            </td>
                            <th class="sized bottomright">
                            </th>
                        </tr>
                    </table>
                </div>
            </asp:Panel>
        </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
