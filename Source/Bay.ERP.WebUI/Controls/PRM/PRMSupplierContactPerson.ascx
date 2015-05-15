<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Feb-2012, 05:41:59
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierContactPerson.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierContactPersonControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Vendor Contact Person"></asp:Label>
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
                        Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtName">
                            Enter Name</label>
                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierContactPersonEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="PRMSupplierContactPersonEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Designation&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDesignation" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierContactPersonEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Phone&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierContactPersonEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierContactPersonEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Mobile No&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMobileNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierContactPersonEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Fax&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtFax" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierContactPersonEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revFax" runat="server" ControlToValidate="txtFax"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierContactPersonEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Email&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierContactPersonEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierContactPersonEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Web Link&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtWebLink" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierContactPersonEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revWebLink" runat="server" ControlToValidate="txtWebLink"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierContactPersonEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMSupplierContactPersonEntity"
                            OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="PRMSupplierContactPersonControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="PRMSupplierContactPersonControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="PRMSupplierContactPersonControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Vendor Contact Person List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMSupplierContactPerson" runat="server" DataSourceID="odsPRMSupplierContactPerson"
                        OnItemCommand="lvPRMSupplierContactPerson_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Vendor
                                    </td>
                                    <td class="hi" style="width: 150px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByName"
                                            CommandName="Sort" Text="Name" CommandArgument="Name" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByDesignation"
                                            CommandName="Sort" Text="Designation" CommandArgument="Designation" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPhone"
                                            CommandName="Sort" Text="Phone" CommandArgument="Phone" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMobileNo"
                                            CommandName="Sort" Text="Mobile No" CommandArgument="MobileNo" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByFax"
                                            CommandName="Sort" Text="Fax" CommandArgument="Fax" />
                                    </td>
                                    <td class="hi" style="width: 140px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByEmail"
                                            CommandName="Sort" Text="Email" CommandArgument="Email" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWebLink"
                                            CommandName="Sort" Text="Web Link" CommandArgument="WebLink" />
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
                                <td class="i" style="display: none;">
                                    <%# Eval("SupplierID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Name")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Designation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Fax")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("WebLink")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierContactPersonID")%>'
                                        UniqueKey="PRMSupplierContactPerson_lvPRMSupplierContactPerson_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor Contact Person?')"
                                        CommandArgument='<%#Eval("SupplierContactPersonID")%>' UniqueKey="PRMSupplierContactPerson_lvPRMSupplierContactPerson_Delete_key" />
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
                                <td class="i" style="display: none;">
                                    <%# Eval("SupplierID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Name")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Designation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Fax")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("WebLink")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierContactPersonID")%>'
                                        UniqueKey="PRMSupplierContactPerson_lvPRMSupplierContactPerson_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor Contact Person?')"
                                        CommandArgument='<%#Eval("SupplierContactPersonID")%>' UniqueKey="PRMSupplierContactPerson_lvPRMSupplierContactPerson_Delete_key" />
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
                <asp:ObjectDataSource ID="odsPRMSupplierContactPerson" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMSupplierContactPersonDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMSupplierContactPerson_Selecting">
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
