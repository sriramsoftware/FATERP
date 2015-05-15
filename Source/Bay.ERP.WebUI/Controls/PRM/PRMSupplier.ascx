<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Feb-2012, 05:41:59
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplier.ascx.cs" Inherits="Bay.ERP.Web.UI.PRMSupplierControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Vendor"></asp:Label>
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
                        Vendor Code&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSupplierCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vendor Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSupplierName">
                            Enter Vendor Name</label>
                        <asp:TextBox ID="txtSupplierName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupplierName" runat="server" ControlToValidate="txtSupplierName"
                            ErrorMessage="Please Enter Vendor Name" ValidationGroup="PRMSupplierEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Relationship&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRelationship" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierEntity" Width="230" />
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
                            ValidationGroup="PRMSupplierEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Mobile No&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMobileNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierEntity" Width="230" />
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
                            ValidationGroup="PRMSupplierEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revFax" runat="server" ControlToValidate="txtFax"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Email&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Web Link&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtWebLink" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMSupplierEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revWebLink" runat="server" ControlToValidate="txtWebLink"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
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
                            ValidationGroup="PRMSupplierEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            ErrorMessage="Please Enter Create Date" ValidationGroup="PRMSupplierEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypSupplierType" runat="server" Text="Vendor Type" NavigateUrl="~/MD/MDSupplierType.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupplierTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMSupplierEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupplierTypeID" runat="server" ControlToValidate="ddlSupplierTypeID"
                            ErrorMessage="Please Select Vendor Type" ValidationGroup="PRMSupplierEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vendor Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupplierStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlSupplierStatusID_SelectedIndexChanged"
                            runat="server" ValidationGroup="PRMSupplierEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupplierStatusID" runat="server" ControlToValidate="ddlSupplierStatusID"
                            ErrorMessage="Please Select Vendor Status" ValidationGroup="PRMSupplierEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        <asp:Label ID="lblReason" runat="server" Text="Reason :"></asp:Label>
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ClientIDMode="Static" ID="txtReason" runat="server" ValidationGroup="PRMSupplierEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="PRMSupplierEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="PRMSupplierEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMSupplierEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="PRMSupplierControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="PRMSupplierControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="PRMSupplierControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Vendor List
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
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierCode" CommandName="Sort" Text="Vendor Code" CommandArgument="PRMSupplier.SupplierCode"/>
                                    </td>
                                    <td class="hi" style="width: 170px;">
                                       <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierName" CommandName="Sort" Text="Vendor Name" CommandArgument="PRMSupplier.SupplierName"/>
                                    </td>
                                    <td class="hi" style="width: 90px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRelationship" CommandName="Sort" Text="Relationship" CommandArgument="PRMSupplier.Relationship"/>
                                    </td>
                                    <td class="hi">
                                       <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPhone" CommandName="Sort" Text="Phone" CommandArgument="PRMSupplier.Phone"/>
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMobileNo" CommandName="Sort" Text="Mobile No" CommandArgument="PRMSupplier.MobileNo"/>
                                    </td>
                                    <td class="hi" style="display: none;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByFax" CommandName="Sort" Text="Fax" CommandArgument="PRMSupplier.Fax"/>
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByEmail" CommandName="Sort" Text="Email" CommandArgument="PRMSupplier.Email"/>
                                    </td>
                                    <td class="hi" style="display: none;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWebLink" CommandName="Sort" Text="Web Link" CommandArgument="PRMSupplier.WebLink"/>
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierStatus" CommandName="Sort" Text="Vendor Status" CommandArgument="MDSupplierStatus.Name"/>
                                    </td>
                                    <td class="hi" style="display: none;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByReason" CommandName="Sort" Text="Reason" CommandArgument="PRMSupplier.Reason"/>
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Is Removed
                                    </td>
                                    <td class="his">
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
                                        CssClass="CommonLink" ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
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
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierID")%>'
                                        UniqueKey="PRMSupplier_lvPRMSupplier_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor?')"
                                        CommandArgument='<%#Eval("SupplierID")%>' UniqueKey="PRMSupplier_lvPRMSupplier_Delete_key" />
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
                                        CssClass="CommonLink" ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
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
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SupplierID")%>'
                                        UniqueKey="PRMSupplier_lvPRMSupplier_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Vendor?')"
                                        CommandArgument='<%#Eval("SupplierID")%>' UniqueKey="PRMSupplier_lvPRMSupplier_Delete_key" />
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
