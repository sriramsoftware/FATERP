<%--
 Copyright and All Rights Reserved by
OSS Ltd

Raju Dutta

 Code Generate Time - 30-Jan-2013, 03:35:13
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACItemGroupAccountMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACItemGroupAccountMapControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Item Group Account Map"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Item Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlItemCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACItemGroupAccountMapEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvItemCategoryID" runat="server" ControlToValidate="ddlItemCategoryID"
                            ErrorMessage="Please Select Item Category" ValidationGroup="ACItemGroupAccountMapEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Dimension&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDimensionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACItemGroupAccountMapEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Sales Account&nbsp;:
                    </div>
                    <div class="TableFormContent">
                      <kti:BayGroupDropDownList ID="ddlSalesAccountID" runat="server"  CssClass="ktiSelect" ClientIDMode="Static" ValidationGroup="ACItemGroupAccountMapEntity"
                             Width="234" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Inventory Account&nbsp;:
                    </div>
                    <div class="TableFormContent">
                     <kti:BayGroupDropDownList ID="ddlInventoryAccountID" runat="server"  CssClass="ktiSelect" ClientIDMode="Static" ValidationGroup="ACItemGroupAccountMapEntity"
                             Width="234" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        C.O.G.S. Account&nbsp;:
                    </div>
                    <div class="TableFormContent">
                         <kti:BayGroupDropDownList ID="ddlCOGSAccountID" runat="server"  CssClass="ktiSelect" ClientIDMode="Static" ValidationGroup="ACItemGroupAccountMapEntity"
                             Width="234" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Inv. Adjustments Acc&nbsp;:
                    </div>
                    <div class="TableFormContent">
                     <kti:BayGroupDropDownList ID="ddlInventoryAdjustmentsAccountID" runat="server"  CssClass="ktiSelect" ClientIDMode="Static" ValidationGroup="ACItemGroupAccountMapEntity"
                             Width="234" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Asset Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAssetType" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="ACItemGroupAccountMapEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Purchase Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPurchaseDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="ACItemGroupAccountMapEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPurchaseDate" runat="server" ControlToValidate="txtPurchaseDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="ACItemGroupAccountMapEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Purchase Price&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPurchasePrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACItemGroupAccountMapEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvPurchasePrice" runat="server" ControlToValidate="txtPurchasePrice" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="ACItemGroupAccountMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Depreciation(%)&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDepreciationRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACItemGroupAccountMapEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDepreciationRate" runat="server" ControlToValidate="txtDepreciationRate" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="ACItemGroupAccountMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Depreciation Method&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDepreciationMethodID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACItemGroupAccountMapEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Depreciation Account&nbsp;:
                    </div>
                    <div class="TableFormContent">
                       <kti:BayGroupDropDownList ID="ddlDepreciationAccountID" runat="server"  CssClass="ktiSelect" ClientIDMode="Static" ValidationGroup="ACItemGroupAccountMapEntity"
                             Width="234" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="ACItemGroupAccountMapEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="ACItemGroupAccountMapControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="ACItemGroupAccountMapControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="ACItemGroupAccountMapControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Item Group Account Map List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACItemGroupAccountMap" runat="server" DataSourceID="odsACItemGroupAccountMap" OnItemCommand="lvACItemGroupAccountMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Item Category
                                    </td>
                                    <td class="hi">
                                        Dimension
                                    </td>
                                    <td class="hi">
                                        Sales Account
                                    </td>
                                    <td class="hi">
                                        Inventory Account
                                    </td>
                                    <td class="hi">
                                        C OGSAccount
                                    </td>
                                    <td class="hi">
                                        Inventory Adjustments Account
                                    </td>
                                    <td class="hi">
                                        Asset Type
                                    </td>
                                    <td class="hi">
                                        Purchase Date
                                    </td>
                                    <td class="hi">
                                        Purchase Price
                                    </td>
                                    <td class="hi">
                                        Depreciation Rate
                                    </td>
                                    <td class="hi">
                                        Depreciation Method
                                    </td>
                                    <td class="hi">
                                        Depreciation Account
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
                                <td class="i">
                                    <%# Eval("ItemCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DimensionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalesAccountID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InventoryAccountID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("COGSAccountID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InventoryAdjustmentsAccountID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AssetType")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurchaseDate") != null ? ((DateTime)Eval("PurchaseDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurchasePrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepreciationRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepreciationMethodID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepreciationAccountID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ItemGroupAccountMapID")%>' UniqueKey="ACItemGroupAccountMap_lvACItemGroupAccountMap_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CItem Group Account Map?')"
                                        CommandArgument='<%#Eval("ItemGroupAccountMapID")%>' UniqueKey="ACItemGroupAccountMap_lvACItemGroupAccountMap_Delete_key"/>
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
                                    <%# Eval("ItemCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DimensionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalesAccountID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InventoryAccountID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("COGSAccountID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InventoryAdjustmentsAccountID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AssetType")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurchaseDate") != null ? ((DateTime)Eval("PurchaseDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurchasePrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepreciationRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepreciationMethodID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepreciationAccountID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ItemGroupAccountMapID")%>' UniqueKey="ACItemGroupAccountMap_lvACItemGroupAccountMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CItem Group Account Map?')"
                                        CommandArgument='<%#Eval("ItemGroupAccountMapID")%>' UniqueKey="ACItemGroupAccountMap_lvACItemGroupAccountMap_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsACItemGroupAccountMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACItemGroupAccountMapDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACItemGroupAccountMap_Selecting">
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
