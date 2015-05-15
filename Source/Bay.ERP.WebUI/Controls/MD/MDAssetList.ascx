<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDAssetList.ascx.cs" Inherits="Bay.ERP.Web.UI.MDAssetListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div class="TableRow" style="width: 100%; padding-left: 480px;">
            <div class="TableFormLeble" style="text-align: right;">
                Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
                <label class="watermarkLabel" for="txtSearchText">
                    Type Asset Code Or Name Or Owner</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                    Width="240" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                        OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
        <div>
            <div class="lv-c">
                <asp:ListView ID="lvMDAsset" runat="server" DataSourceID="odsMDAsset" OnItemDataBound="lvMDAsset_ItemDataBound"
                    OnItemCommand="lvMDAsset_ItemCommand">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="his" style="width: 95px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByAssetCategory"
                                        CommandName="Sort" Text="Asset Category" CommandArgument="MDAssetCateogry.CategoryName" />
                                </td>
                                <td class="his" style="width: 90px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByAssetName"
                                        CommandName="Sort" Text="Name" CommandArgument="AssetName" />
                                </td>
                                <td class="his" style="width: 95px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnk" CommandName="Sort"
                                        Text="Date Acquired" CommandArgument="NextMaintananceDate" />
                                </td>
                                <td class="his" style="width: 200px;">
                                    Medium
                                </td>
                                <td class="his" style="width: 72;">
                                    Width
                                </td>
                                <td class="his" style="width: 72;">
                                    Height
                                </td>
                                <td class="his" style="width: 200px;">
                                    Present Book Value
                                </td>
                                <td class="his" style="width: 200px;">
                                    Description
                                </td>
                                <td class="his" style="width: 90px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByOwner"
                                        CommandName="Sort" Text="Owner" CommandArgument="CMConsultant.Name" />
                                </td>
                                <td class="his" style="width: 90px;">
                                    Location
                                </td>
                                <td class="his" style="width: 90px;">
                                    Price
                                </td>
                                <td class="his" style="width: 90px;">
                                    Insurance (If any)
                                </td>
                                <td class="his" style="width: 90px;">
                                    Remarks
                                </td>
                                <td class="i">
                                    Image
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
                                <%# Eval("AssetCateogryName")%>
                            </td>
                            <td class="i">
                                <%# Eval("AssetName")%>
                            </td>
                            <td class="i">
                                <%# Eval("NextMaintananceDate")%>
                            </td>
                            <td class="i">
                                <%# Eval("Medium")%>
                            </td>
                            <td class="i">
                                <%# Eval("Width")%>
                            </td>
                            <td class="i">
                                <%# Eval("Height")%>
                            </td>
                            
                            <td class="i">
                                <%# Eval("PresentBookValue")%>
                            </td>
                            <td class="i">
                                <%# Eval("Description")%>
                            </td>
                            <td class="i">
                                <%# Eval("OwnerReferenceName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ProjectFloorUnitName")%>
                            </td>
                            <td class="i">
                                <%# Eval("Price")%>
                            </td>
                            <td class="i">
                                <%# Eval("InsuranceInformation")%>
                            </td>
                            <td class="i">
                                <%# Eval("Remarks")%>
                            </td>
                            <td class="i">
                                <asp:Image ID="imgImageUrl" ImageUrl='<%# Eval("ImageUrl")%>' runat="server" Height="45"
                                    Width="45" />
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
                                <%# Eval("AssetCateogryName")%>
                            </td>
                            <td class="i">
                                <%# Eval("AssetName")%>
                            </td>
                            <td class="i">
                                <%# Eval("NextMaintananceDate")%>
                            </td>
                            <td class="i">
                                <%# Eval("Medium")%>
                            </td>
                            <td class="i">
                                <%# Eval("Width")%>
                            </td>
                            <td class="i">
                                <%# Eval("Height")%>
                            </td>
                            <td class="i">
                                <%# Eval("PresentBookValue")%>
                            </td>
                            <td class="i">
                                <%# Eval("Description")%>
                            </td>
                            <td class="i">
                                <%# Eval("OwnerReferenceName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ProjectFloorUnitName")%>
                            </td>
                            <td class="i">
                                <%# Eval("Price")%>
                            </td>
                            <td class="i">
                                <%# Eval("InsuranceInformation")%>
                            </td>
                            <td class="i">
                                <%# Eval("Remarks")%>
                            </td>
                            <td class="i">
                                <asp:Image ID="imgImageUrl" ImageUrl='<%# Eval("ImageUrl")%>' runat="server" Height="45"
                                    Width="45" />
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
            <asp:ObjectDataSource ID="odsMDAsset" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.MDAsset_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsMDAsset_Selecting">
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
