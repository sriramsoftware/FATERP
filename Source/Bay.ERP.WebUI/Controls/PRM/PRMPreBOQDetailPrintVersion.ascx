<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 14-Dec-2011, 03:47:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMPreBOQDetailPrintVersion.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMPreBOQDetailPrintVersionControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div style="font-size: 13px; font-weight: bold; color: Green; padding-bottom: 10px;">
            Total Budgeted Value:
            <asp:Label ID="lblTopTotalBudgetValue" runat="server"></asp:Label>
        </div>
        <div class="lv-c">
            <asp:ListView ID="lvPRMPreBOQDetail" runat="server" DataSourceID="odsPRMPreBOQDetail_Custom"
                OnItemCommand="lvPRMPreBOQDetail_ItemCommand" DataKeyNames="PreBOQDetailID">
                <LayoutTemplate>
                    <table class="lv" cellpadding="0" cellspacing="0">
                        <tr class="h">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="hi" style="width: 180px;">
                                Parent Category
                            </td>
                            <td class="hi" style="width: 120px;">
                                Sub Category
                            </td>
                            <td class="hi" style="display: none;">
                                Item ID
                            </td>
                            <td class="hi" style="width: 200px;">
                                <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByItem"
                                    CommandName="Sort" Text="Item" CommandArgument="MDItem.ItemName" />
                            </td>
                            <td class="hi" style="width: 50px;">
                                Unit
                            </td>
                            <td class="hi">
                                Rate
                            </td>
                            <td class="hi">
                                Qty
                            </td>
                            <td class="hi">
                                Item Total
                            </td>
                            <td class="hi" style="display: none;">
                                Remarks
                            </td>
                            <td class="hi" style="display: none;">
                                Brand ID
                            </td>
                            <td class="hi" style="display: none;">
                                Vendor ID
                            </td>
                            <td class="hi" style="display: none;">
                                Region ID
                            </td>
                            <td class="hi" style="display: none;">
                                Country ID
                            </td>
                            <td class="hi">
                                &nbsp;
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
                                        <asp:DataPager ID="dpListView" runat="server" PageSize="1000" OnPagePropertiesChanged="lvPRMPreBOQDetail_PagePropertiesChanged">
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
                            <b>
                                <%# Eval("ParentCategoryName")%></b>
                        </td>
                        <td class="i">
                            <b>
                                <%# Eval("CategoryName")%></b>
                        </td>
                        <td class="i" style="display: none;">
                            <%# Eval("ItemID")%>
                        </td>
                        <td class="i">
                            <b>
                                <asp:Label ID="lblItemNameLV" runat="server" Text='<%# Eval("MDItemItemName")%>'></asp:Label></b><br />
                            Brand :&nbsp;<asp:Label ID="lblBrandNameLV" runat="server" Text='<%# Eval("BrandName")%>'></asp:Label><br />
                            Supplier :&nbsp;<asp:Label ID="lblSupplierNameLV" runat="server" Text='<%# Eval("SupplierName")%>'></asp:Label><br />
                            Region :&nbsp;<asp:Label ID="lblRegionNameLV" runat="server" Text='<%# Eval("RegionName")%>'></asp:Label><br />
                            Country :&nbsp;<asp:Label ID="lblCountryNameLV" runat="server" Text='<%# Eval("CountryName")%>'></asp:Label>
                        </td>
                        <td class="i">
                            <%# Eval("UnitName")%>
                        </td>
                        <td class="i">
                            <%# Eval("Rate")%>
                        </td>
                        <td class="i">
                            <%# Eval("TotalQty")%>
                        </td>
                        <td class="i">
                            <asp:Label ID="lblItemTotal" runat="server" Text='<%# Decimal.Round(((Decimal) Eval("TotalQty") * (Decimal) Eval("Rate")), 2) %>'></asp:Label>
                        </td>
                        <td class="i" style="display: none;">
                            <%# Eval("Remarks")%>
                        </td>
                        <td class="i" style="display: none;">
                            <asp:Label ID="lblBrandID" runat="server" Text='<%# Eval("BrandID")%>'></asp:Label>
                        </td>
                        <td class="i" style="display: none;">
                            <asp:Label ID="lblSupplierID" runat="server" Text='<%# Eval("SupplierID")%>'></asp:Label>
                        </td>
                        <td class="i" style="display: none;">
                            <asp:Label ID="lblRegionID" runat="server" Text='<%# Eval("RegionID")%>'></asp:Label>
                        </td>
                        <td class="i" style="display: none;">
                            <asp:Label ID="lblCountryID" runat="server" Text='<%# Eval("CountryID")%>'></asp:Label>
                        </td>
                        <td class="rp">
                            &nbsp;
                        </td>
                        <td class="rpb">
                            &nbsp;
                        </td>
                    </tr>
                </ItemTemplate>
                <EmptyDataTemplate>
                    <div class="edr">
                        No Records Found To Display
                    </div>
                </EmptyDataTemplate>
            </asp:ListView>
        </div>
        <div style="font-size: 13px; font-weight: bold; color: Green; padding-top: 10px;">
            Total Budgeted Value:
            <asp:Label ID="lblButtomTotalBudgetValue" runat="server"></asp:Label>
        </div>
        <asp:ObjectDataSource ID="odsPRMPreBOQDetail_Custom" runat="server" SelectMethod="GetPagedData"
            SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
            StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMPreBOQDetail_CustomDataSource"
            SortParameterName="sortExpression" OnSelecting="odsPRMPreBOQDetail_Custom_Selecting">
            <SelectParameters>
                <asp:Parameter Name="startRowIndex" Type="Int32" />
                <asp:Parameter Name="pageSize" Type="Int32" />
                <asp:Parameter Name="sortExpression" Type="String" />
                <asp:Parameter Name="filterExpression" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <div style="text-align: right; padding-top: 5px; display: none;">
            <kti:SecureButton ID="btnUpdate" OnClick="btnUpdate_Click" runat="server" Text="Save"
                Visible="false" UniqueKey="PRMPreBOQDetailPrintVersionControl_Update_key" />
        </div>
        <ajaxToolkit:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server" PopupControlID="Panel1"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkSavePopup" OkControlID="lnkSavePopup"
            CancelControlID="btnCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div>
            <asp:Panel ID="Panel1" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                <div class="modalPanelBackground">
                    <br />
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                            <asp:Button ID="btnClose" runat="server" Text="X"></asp:Button>
                        </div>
                    </div>
                    <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                        padding-left: 10px;">
                        <tr>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="imgSideShadowLeft" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
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
                                <asp:Image ID="imgSideShadowRight" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
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
                                            Modify Item Info</h1>
                                        <div>
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Item Name&nbsp;:
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    <asp:Label ID="lblItemName" runat="server" Font-Bold="true"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Brand&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                                        ValidationGroup="MDItemEntity" Width="236">
                                                    </asp:DropDownList>
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvBrandID" runat="server" ControlToValidate="ddlBrandID"
                                                        ErrorMessage="Please Select Brand" ValidationGroup="MDItemEntity" EnableViewState="False"
                                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Vendor&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                                        ValidationGroup="MDItemEntity" Width="236">
                                                    </asp:DropDownList>
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvSupplierID" runat="server" ControlToValidate="ddlSupplierID"
                                                        ErrorMessage="Please Select Vendor" ValidationGroup="MDItemEntity" EnableViewState="False"
                                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Origin Region&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlOriginRegionID" CssClass="ktiSelect" ClientIDMode="Static"
                                                        OnSelectedIndexChanged="ddlOriginRegionID_SelectedIndexChanged" AutoPostBack="true"
                                                        runat="server" ValidationGroup="PRMSupplierItemMapEntity" Width="236">
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Origin Country&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlOriginCountryID" CssClass="ktiSelect" ClientIDMode="Static"
                                                        runat="server" ValidationGroup="PRMSupplierItemMapEntity" Width="236">
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Net Price&nbsp;:
                                                </div>
                                                <div class="TableFormContent waterMarkContainer">
                                                    <asp:TextBox ID="txtPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                        ReadOnly="true" Width="210" />
                                                    <span>
                                                        <asp:LinkButton ID="lnkGetPrice" runat="server" OnClick="lnkGetPrice_OnClick" ToolTip="Please Click Here To Get The Net Price According To Selected Brand, Vendor, Origin Region, Origin Country To The Item!">Get Price</asp:LinkButton></span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtPrice"
                                                        ErrorMessage="Please Enter Price" ValidationGroup="PRMSupplierItemMapEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    <asp:RangeValidator ID="rvPrice" runat="server" ControlToValidate="txtPrice" Display="Dynamic"
                                                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="PRMSupplierItemMapEntity"></asp:RangeValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:LinkButton ID="lnkSavePopup" runat="server"></asp:LinkButton>
                                                    <kti:SecureButton ID="btnUpdatePopup" runat="server" Text="Update" OnClick="lnkSavePopup_Click"
                                                        UniqueKey="PRMPreBOQDetailPrintVersionControl_UpdatePopup_key" />
                                                    <kti:SecureButton ID="btnCancel" runat="server" Text="Cancel" UniqueKey="PRMPreBOQDetailPrintVersionControl_CancelPopup_key" />
                                                </div>
                                            </div>
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
    </ContentTemplate>
</asp:UpdatePanel>
