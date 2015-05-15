<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Dec-2012, 02:43:44
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVStoreUnit.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVStoreUnitControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Store Unit"></asp:Label>
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
                        Store&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlStoreID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreUnitEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvStoreID" runat="server" ControlToValidate="ddlStoreID"
                            ErrorMessage="Please Select Store" ValidationGroup="INVStoreUnitEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Inv. Store Unit Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlInventoryStoreUnitTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreUnitEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvInventoryStoreUnitTypeID" runat="server" ControlToValidate="ddlInventoryStoreUnitTypeID"
                            ErrorMessage="Please Select Inventory Store Unit Type" ValidationGroup="INVStoreUnitEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Unit Track Number&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtUnitTrackNumber" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="INVStoreUnitEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Location&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtLocation" runat="server" ValidationGroup="INVStoreUnitEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="INVStoreUnitEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Create Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCreateDate">
                            Enter Create Date</label>
                        <asp:TextBox ID="txtCreateDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="INVStoreUnitEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            ErrorMessage="Please Enter Create Date" ValidationGroup="INVStoreUnitEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="INVStoreUnitEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="INVStoreUnitEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Parent Store Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlParentStoreUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreUnitEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Default&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsDefault" runat="server" ClientIDMode="Static" ValidationGroup="INVStoreUnitEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="INVStoreUnitEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="INVStoreUnitControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="INVStoreUnitControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="INVStoreUnitControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Store Unit List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVStoreUnit" runat="server" DataSourceID="odsINVStoreUnit" OnItemCommand="lvINVStoreUnit_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Store
                                    </td>
                                    <td class="hi">
                                        Inventory Store Unit Type
                                    </td>
                                    <td class="hi">
                                        Unit Track Number
                                    </td>
                                    <td class="hi">
                                        Location
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi">
                                        Is Removed
                                    </td>
                                    <td class="hi">
                                        Parent Store Unit
                                    </td>
                                    <td class="hi">
                                        Is Default
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
                                    <%# Eval("StoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDInventoryStoreUnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitTrackNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StoreUnitLocation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ParentStoreUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDefault") != null ? (((Boolean)Eval("IsDefault")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("StoreUnitID")%>' UniqueKey="INVStoreUnit_lvINVStoreUnit_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVStore Unit?')"
                                        CommandArgument='<%#Eval("StoreUnitID")%>' UniqueKey="INVStoreUnit_lvINVStoreUnit_Delete_key"/>
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
                                    <%# Eval("StoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDInventoryStoreUnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitTrackNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StoreUnitLocation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ParentStoreUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDefault") != null ? (((Boolean)Eval("IsDefault")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("StoreUnitID")%>' UniqueKey="INVStoreUnit_lvINVStoreUnit_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVStore Unit?')"
                                        CommandArgument='<%#Eval("StoreUnitID")%>' UniqueKey="INVStoreUnit_lvINVStoreUnit_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsINVStoreUnit" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVStoreUnit_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVStoreUnit_Selecting">
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
